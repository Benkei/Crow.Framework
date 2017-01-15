using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace OpenGlSpecGen.Spec
{
	public interface ISpecReader
	{
		void Read(XmlReader reader, SpecRegistry model);
	}

	public static class SpecUtil
	{
		public static string ReadElement(this XmlReader reader)
		{
			if ( reader.IsEmptyElement )
				return null;
			reader.Read ();
			if ( reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA )
			{
				var value = reader.Value;
				reader.Read ();
				return value;
			}
			return null;
		}

		public static IEnumerable<XmlReader> ReadElementTree(this XmlReader reader)
		{
			if ( reader.IsEmptyElement )
				yield break;
			if ( reader.NodeType != XmlNodeType.Element )
				throw new XmlException ();
			var depth = reader.Depth;
			var element = reader.Name;
			while ( reader.Read () )
			{
				if ( reader.NodeType == XmlNodeType.EndElement && reader.Name == element )
					break;
				if ( reader.NodeType != XmlNodeType.Element )
					continue;

				yield return reader;

				if ( reader.Depth < depth )
					throw new XmlException ();

				if ( reader.NodeType == XmlNodeType.EndElement && reader.Name == element )
					break;
			}
		}

		public static long Parse(string value)
		{
			if ( value == null )
				return 0;
			if ( value.StartsWith ( "0x", StringComparison.InvariantCultureIgnoreCase ) )
				return Convert.ToInt64 ( value.Substring ( 2 ), 16 );
			return long.Parse ( value, CultureInfo.InvariantCulture );
		}
	}

	public class SpecRegistry
	{
		public string Comment;
		public SpecTypes Types = new SpecTypes ();
		public SpecGroups Groups = new SpecGroups ();
		public List<SpecEnums> Enums = new List<SpecEnums> ();
		public List<SpecCommands> Commands = new List<SpecCommands> ();
		public List<SpecInterfaceGroup> Features = new List<SpecInterfaceGroup> ();
		public List<SpecInterfaceGroup> Extensions = new List<SpecInterfaceGroup> ();

		public void Read(Stream stream)
		{
			var setting = new XmlReaderSettings ()
			{
				IgnoreComments = true,
				IgnoreWhitespace = false,
				IgnoreProcessingInstructions = true,
			};
			var reader = XmlReader.Create ( stream, setting );

			if ( !reader.ReadToFollowing ( "registry" ) )
				throw new XmlException ();

			foreach ( var child in reader.ReadElementTree () )
			{
				switch ( child.Name )
				{
					case "comment":
						Comment = child.ReadElement ();
						break;
					case "types":
						Types.Read ( child, this );
						break;
					case "groups":
						Groups.Read ( child, this );
						break;
					case "enums":
						var enums = new SpecEnums ();
						enums.Read ( child, this );
						Enums.Add ( enums );
						break;
					case "commands":
						var commands = new SpecCommands ();
						commands.Read ( child, this );
						Commands.Add ( commands );
						break;
					case "feature":
						var feature = new SpecInterfaceGroup ();
						feature.Read ( child, this );
						Features.Add ( feature );
						break;
					case "extensions":
						foreach ( var item in reader.ReadElementTree () )
						{
							var extensions = new SpecInterfaceGroup ();
							extensions.Read ( child, this );
							Extensions.Add ( extensions );
						}
						break;
				}
			}
		}
	}

	[DebuggerDisplay ( "Types {Types.Count}" )]
	public class SpecTypes : ISpecReader
	{
		public List<SpecType> Types = new List<SpecType> ();

		public void Read(XmlReader reader, SpecRegistry model)
		{
			foreach ( var child in reader.ReadElementTree () )
			{
				if ( child.Name == "type" )
				{
					var type = new SpecType ();
					type.Read ( reader, model );
					Types.Add ( type );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Name} {Api} {Requires}" )]
	public class SpecType : ISpecReader
	{
		public string Requires;
		public string Name;
		public string Api;
		public string Comment;

		public string Content;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Requires = reader.GetAttribute ( "requires" );
			Name = reader.GetAttribute ( "name" );
			Api = reader.GetAttribute ( "api" );
			Comment = reader.GetAttribute ( "comment" );

			//content = reader.ReadInnerXml ();

			// <type>typedef void (<apientry/> *<name>GLDEBUGPROC</name>)(GLenum source,GLenum type,GLuint id,GLenum severity,GLsizei length,const GLchar *message,const void *userParam);</type>

			while ( reader.Read () )
			{
				if ( reader.NodeType == XmlNodeType.EndElement && reader.Name == "type" )
					break;

				if ( reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.Whitespace )
				{
					Content += reader.Value;
				}
				else if ( reader.NodeType == XmlNodeType.Element )
				{
					if ( reader.Name == "apientry" )
					{
						Content += "#APIENTRY#";
					}
					else if ( reader.Name == "name" )
					{
						Content += "#NAME#";
						Name = reader.ReadElement ();
					}
				}
			}
		}
	}

	[DebuggerDisplay ( "Groups {Groups.Count}" )]
	public class SpecGroups : ISpecReader
	{
		public List<SpecGroup> Groups = new List<SpecGroup> ();

		public void Read(XmlReader reader, SpecRegistry model)
		{
			foreach ( var child in reader.ReadElementTree () )
			{
				if ( child.Name == "group" )
				{
					var group = new SpecGroup ();
					group.Read ( child, model );
					Groups.Add ( group );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Name} {Enums.Count}" )]
	public class SpecGroup : ISpecReader
	{
		public string Name;

		public List<string> Enums = new List<string> ();

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Name = reader.GetAttribute ( "name" );

			foreach ( var child in reader.ReadElementTree () )
			{
				if ( child.Name == "enum" )
				{
					var value = child.GetAttribute ( "name" );
					Enums.Add ( value );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Namespace} {Group} {Type} {Start}-{End} {Comment}" )]
	public class SpecEnums : ISpecReader
	{
		public string Namespace;
		public string Group;
		public string Type;
		public long Start;
		public long End;
		public string Ventor;
		public string Comment;

		public List<SpecEnum> Enums = new List<SpecEnum> ();

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Namespace = reader.GetAttribute ( "namespace" );
			Group = reader.GetAttribute ( "group" );
			Type = reader.GetAttribute ( "type" );
			Start = SpecUtil.Parse ( reader.GetAttribute ( "start" ) );
			End = SpecUtil.Parse ( reader.GetAttribute ( "end" ) );
			Ventor = reader.GetAttribute ( "ventor" );
			Comment = reader.GetAttribute ( "comment" );

			foreach ( var child in reader.ReadElementTree () )
			{
				if ( child.Name == "enum" )
				{
					var value = new SpecEnum ();
					value.Read ( child, model );
					Enums.Add ( value );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Name} {Value}" )]
	public struct SpecEnum : ISpecReader
	{
		public long Value;
		public string Name;
		public string Api;
		public SpecEnumType Type;
		public string Alias;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Value = SpecUtil.Parse ( reader.GetAttribute ( "value" ) );
			Name = reader.GetAttribute ( "name" );
			Api = reader.GetAttribute ( "api" );
			var type = reader.GetAttribute ( "type" );
			if ( type != null && !Enum.TryParse ( type, true, out Type ) )
				throw new XmlException ();
			Alias = reader.GetAttribute ( "alias" );
		}
	}

	public enum SpecEnumType : byte
	{
		// "u" (unsigned), "ull" (uint64) or integer
		integer, u, ull
	}

	/*
	[DebuggerDisplay ( "{Start}-{End} {Comment}" )]
	struct SpecUnused : ISpecReader
	{
		public long Start;
		public long End;
		public string Comment;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Start = SpecUtil.Parse ( reader.GetAttribute ( "start" ) );
			End = SpecUtil.Parse ( reader.GetAttribute ( "end" ) );
			Comment = reader.GetAttribute ( "comment" );
		}
	}
	*/

	[DebuggerDisplay ( "{Namespace}" )]
	public class SpecCommands : ISpecReader
	{
		public string Namespace;

		public List<SpecCommand> Commands = new List<SpecCommand> ();

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Namespace = reader.GetAttribute ( "namespace" );

			foreach ( var child in reader.ReadElementTree () )
			{
				if ( reader.Name == "command" )
				{
					var value = new SpecCommand ();
					value.Read ( reader, model );
					Commands.Add ( value );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Prototype.Declaration.Name}" )]
	public class SpecCommand : ISpecReader
	{
		public SpecPrototype Prototype;
		public List<SpecPrototype> Parameters = new List<SpecPrototype> ();
		public string Alias;
		public string VectorEquivalent;
		public SpecGlx Glx;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			foreach ( var child in reader.ReadElementTree () )
			{
				if ( reader.Name == "proto" )
				{
					Prototype.Read ( reader, model );
				}
				else if ( reader.Name == "param" )
				{
					var value = new SpecPrototype ();
					value.Read ( reader, model );
					Parameters.Add ( value );
				}
				else if ( reader.Name == "alias" )
				{
					Alias = reader.GetAttribute ( "name" );
				}
				else if ( reader.Name == "vecequiv" )
				{
					VectorEquivalent = reader.GetAttribute ( "name" );
				}
				else if ( reader.Name == "glx" )
				{
					Glx = new SpecGlx ();
					Glx.Read ( reader, model );
				}
			}
		}
	}

	[DebuggerDisplay ( "{EnumGroup} {Length} {Declaration.Type} {Declaration.Name}" )]
	public struct SpecPrototype : ISpecReader
	{
		public string EnumGroup;
		public SpecTypeDeclaration Declaration;
		public string Length;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			EnumGroup = reader.GetAttribute ( "group" );
			Length = reader.GetAttribute ( "len" );

			Declaration.Read ( reader, model );
		}
	}

	[DebuggerDisplay ( "{Type} {Name} {Content}" )]
	public struct SpecTypeDeclaration : ISpecReader
	{
		public string Type;
		public string Name;
		public string Content;
		public int Pointers;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			if ( reader.NodeType != XmlNodeType.Element )
				throw new XmlException ();
			var beginElement = reader.Name;
			while ( reader.Read () )
			{
				if ( reader.NodeType == XmlNodeType.EndElement && reader.Name == beginElement )
					break;

				if ( reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.Whitespace )
				{
					Content += reader.Value;
				}
				else if ( reader.NodeType == XmlNodeType.Element )
				{
					if ( reader.Name == "ptype" )
					{
						Content += "#PTYPE#";
						Type = reader.ReadElement ();
					}
					else if ( reader.Name == "name" )
					{
						Content += "#NAME#";
						Name = reader.ReadElement ();
					}
				}
			}
			for ( int i = 0; i < Content.Length; i++ )
			{
				if ( Content[i] == '*' )
				{
					Pointers++;
				}
			}
		}
	}

	[DebuggerDisplay ( "{Type} {OpCode}" )]
	public class SpecGlx : ISpecReader
	{
		public string Type;
		public int OpCode;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Type = reader.GetAttribute ( "type" );
			OpCode = (int)SpecUtil.Parse ( reader.GetAttribute ( "opcode" ) );
		}
	}

	[DebuggerDisplay ( "{Name} {Api} {Number} {Supported} {Protect} Req:{Require.Count} Rev:{Remove.Count}" )]
	public class SpecInterfaceGroup : ISpecReader
	{
		public string Api;
		public string Name;
		public float Number;

		public Regex Supported;

		public string Protect;
		public string Comment;

		public bool isExtension;

		public List<SpecInterfaceList> Require;
		public List<SpecInterfaceList> Remove;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			isExtension = reader.Name == "extension";

			Api = reader.GetAttribute ( "api" );
			Name = reader.GetAttribute ( "name" );

			var value = reader.GetAttribute ( "number" );
			Number = value == null ? 0f : float.Parse ( value, CultureInfo.InvariantCulture );

			value = reader.GetAttribute ( "supported" );
			Supported = value == null ? null : new Regex ( "^(" + value + ")$", RegexOptions.CultureInvariant );

			Protect = reader.GetAttribute ( "protect" );
			Comment = reader.GetAttribute ( "comment" );

			foreach ( var child in reader.ReadElementTree () )
			{
				if ( reader.Name == "require" )
				{
					if ( Require == null )
						Require = new List<SpecInterfaceList> ();
					var list = new SpecInterfaceList ();
					list.Read ( reader, model );
					Require.Add ( list );
				}
				else if ( reader.Name == "remove" )
				{
					if ( Remove == null )
						Remove = new List<SpecInterfaceList> ();
					var list = new SpecInterfaceList ();
					list.Read ( reader, model );
					Remove.Add ( list );
				}
			}
		}
	}

	[DebuggerDisplay ( "{Profile} {Api} Count:{Count}" )]
	public class SpecInterfaceList : List<SpecInterface>, ISpecReader
	{
		public string Api;
		public string Profile;
		public string Comment;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			Api = reader.GetAttribute ( "api" );
			Profile = reader.GetAttribute ( "profile" );
			Comment = reader.GetAttribute ( "comment" );

			foreach ( var child in reader.ReadElementTree () )
			{
				var value = new SpecInterface ();
				value.Read ( reader, model );
				Add ( value );
			}
		}
	}

	[DebuggerDisplay ( "{Type} {Name}" )]
	public struct SpecInterface : IEquatable<SpecInterface>, ISpecReader
	{
		public SpecInterfaceType Type;
		public string Name;
		public string Comment;

		public void Read(XmlReader reader, SpecRegistry model)
		{
			if ( !Enum.TryParse ( reader.Name, true, out Type ) )
				throw new XmlException ();

			Name = reader.GetAttribute ( "name" );
			Comment = reader.GetAttribute ( "comment" );
		}

		public bool Equals(SpecInterface other)
		{
			return Type == other.Type && Name == other.Name;
		}
		public override bool Equals(object obj)
		{
			return obj is SpecInterface && Equals ( (SpecInterface)obj );
		}
		public override int GetHashCode()
		{
			int hashCode = Type.GetHashCode ();
			hashCode = (hashCode * 397) ^ (Name ?? string.Empty).GetHashCode ();
			return hashCode;
		}
	}

	public enum SpecInterfaceType : byte
	{
		Command, Enum, Type
	}
}
