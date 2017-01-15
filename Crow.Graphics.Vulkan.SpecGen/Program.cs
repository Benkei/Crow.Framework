using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Crow.Vulkan.SpecGen
{
	class Program
	{
		static Dictionary<string, SpecType> typeMap = new Dictionary<string, SpecType> ();
		static Dictionary<string, SpecCommand> commandMap = new Dictionary<string, SpecCommand> ();
		static Dictionary<string, SpecEnum> enumMap = new Dictionary<string, SpecEnum> ();
		static Dictionary<string, SpecEnumMember> enumMemberMap = new Dictionary<string, SpecEnumMember> ();
		static Dictionary<string, SpecStruct> structMap = new Dictionary<string, SpecStruct> ();
		static Dictionary<string, SpecDelegate> delegateMap = new Dictionary<string, SpecDelegate> ();
		static Dictionary<string, SpecExtension> extensionMap = new Dictionary<string, SpecExtension> ();

		static void Main(string[] args)
		{
			string input = "vk.xml";
			string mapping = "mapping.xml";
			string export = "";
			string api = "vulkan";
			string version = "1.0";

			if ( args.Length >= 4 )
			{
				input = args[0];
				mapping = args[1];
				export = args[2];
				api = args[3];
				version = args[4];
			}

			System.Diagnostics.Debugger.Launch ();

			var ser = new XmlSerializer ( typeof ( Mappings ) );
			Mappings maps;
			using ( var file = System.IO.File.OpenRead ( mapping ) )
			{
				maps = (Mappings)ser.Deserialize ( file );
			}

			XPathDocument specDoc;
			var set = new XmlReaderSettings ()
			{
				IgnoreWhitespace = true,
				IgnoreProcessingInstructions = true
			};
			using ( var reader = XmlReader.Create ( input, set ) )
			{
				specDoc = new XPathDocument ( reader );
			}

			var root = specDoc.CreateNavigator ();

			foreach ( XPathNavigator item in root.Select ( @"//enums" ) )
			{
				ParseEnum ( item );
			}

			foreach ( XPathNavigator item in root.Select ( @"//types/type" ) )
			{
				var category = item.GetAttribute<Category> ( "category" );

				if ( category == Category.Funcpointer )
				{
					ParseDelegate ( item );
				}
				else if ( category == Category.Struct || category == Category.Union )
				{
					ParseStruct ( category, item );
				}
				else if ( category != Category.Include && category != Category.Define )
				{
					ParseTypes ( category, item );
				}
			}

			foreach ( XPathNavigator item in root.Select ( @"//commands/command" ) )
			{
				ParseCommand ( item );
			}

			var featureNodes = root.Select ( @"//feature[@api = '" + api + "' and @number <= '" + version + "']/*/*" );


			var extensionNodes = root.Select ( @"//extensions/extension/*/*" );
			foreach ( XPathNavigator node in extensionNodes )
			{
				var extension = node.CreateNavigator ();
				extension.MoveToParent ();
				extension.MoveToParent ();
				var exsupported = extension.GetAttribute ( "supported" );

				if ( !Regex.IsMatch ( api, "^(" + exsupported + ")$", RegexOptions.CultureInvariant ) )
					continue;

				var exname = extension.GetAttribute ( "name" );
				var exnumber = extension.GetAttribute<int> ( "number" );

				var spec = GetSpecExtension ( exname );
				spec.Number = exnumber;

				if ( node.Name == "enum" )
				{
					var name = node.GetAttribute ( "name" );
					var extends = node.GetAttribute ( "extends" );
					var dir = node.GetAttribute ( "dir" );
					var offset = node.GetAttributeNullable<int> ( "offset" );
					var value = node.GetAttribute ( "value" );
					var bitpos = node.GetAttributeNullable<int> ( "bitpos" );
					var comment = node.GetAttribute ( "comment" );

					if ( extends != null )
					{
						if ( offset.HasValue )
						{
							var mem = GetSpecEnumMember ( name );
							mem.Value = dir + ExtensionEnumOffset ( exnumber, offset.Value );
							mem.Comment = comment;

							enumMap[extends].Members.Add ( mem );
						}
						if ( bitpos.HasValue )
						{
							var mem = GetSpecEnumMember ( name );
							mem.BitPos = bitpos.Value;
							mem.Comment = comment;

							enumMap[extends].Members.Add ( mem );
						}
					}
					if ( value != null )
					{
						SpecEnumMember mem;
						if ( enumMemberMap.TryGetValue ( value, out mem ) )
						{
							var field = new SpecField
							{
								Visibility = "public const",
								Name = name,
								MapName = name,
								MapType = "int",
								Value = mem.Value,
							};
							spec.Members.Add ( field );
						}
						else
						{
							var field = new SpecField
							{
								Visibility = "public const",
								Name = name,
								MapName = name,
								MapType = value.Contains ( "\"" ) ? "string" : "int",
								Value = value,
							};
							spec.Members.Add ( field );
						}
					}
				}
				if ( node.Name == "command" )
				{
					var name = node.GetAttribute ( "name" );
					spec.Commands.Add ( commandMap[name] );
				}
			}

			foreach ( var item in extensionMap.Values )
			{
				item.Commands.Sort ( (a, b) => string.Compare ( a.Name, b.Name ) );
			}

			foreach ( var mapType in typeMap.Values )
			{
				foreach ( var map in maps.Maps )
				{
					if ( map.Type == null ) continue;

					var match = Regex.Match ( mapType.MapName, map.Type, RegexOptions.CultureInvariant );
					if ( match.Success )
					{
						if ( map.MapName != null )
						{
							if ( map.MapName.Contains ( "$" ) )
							{
								mapType.MapName = match.Result ( map.MapName );
							}
							else
							{
								mapType.MapName = map.MapName;
							}
						}
						if ( map.MapType != null )
						{
							mapType.MapType = map.MapType;
						}

						mapType.TypeHandle |= map.TypeHandle;
						mapType.TypeHandle64 |= map.TypeHandle64;
					}
				}
			}
			#region Enum Mapping
			foreach ( var item in enumMap.Values )
			{
				item.MapName = maps.MapNameMatches ( (a) => a.Enum, null, item.MapName );

				for ( int i = 0; i < item.Members.Count; i++ )
				{
					var member = item.Members[i];
					member.MapName = maps.MapNameMatches ( (a) => a.EnumItem, item.Name, member.MapName );

					foreach ( var membMap in maps.FindMatch ( (a) => a.Field, item.Name, member.Name ) )
					{
						if ( membMap.MapType != null )
						{
							member.MapType = membMap.MapType;
						}
						if ( membMap.Visibility != null )
						{
							member.Visibility = membMap.Visibility;
						}
					}
				}
			}
			#endregion
			#region Command Mapping
			foreach ( var item in commandMap.Values )
			{
				item.MapName = maps.MapNameMatches ( (a) => a.Command, null, item.MapName );

				for ( int i = 0; i < item.Parameters.Count; i++ )
				{
					var param = item.Parameters[i];
					param.MapName = maps.MapNameMatches ( (a) => a.Param, item.Name, param.MapName );

					foreach ( var membMap in maps.FindMatch ( (a) => a.Param, item.Name, param.Name ) )
					{
						if ( membMap.MapType != null )
						{
							param.MapType = membMap.MapType;
						}
						if ( membMap.Attribute != null )
						{
							param.Attribute = membMap.Attribute;
						}
						param.Optional |= membMap.Optional;
					}
				}
			}
			#endregion
			#region Delegate Mapping
			foreach ( var item in delegateMap.Values )
			{
				item.MapName = maps.MapNameMatches ( (a) => a.Command, null, item.MapName );

				for ( int i = 0; i < item.Parameters.Count; i++ )
				{
					var param = item.Parameters[i];
					param.MapName = maps.MapNameMatches ( (a) => a.Param, item.Name, param.MapName );

					foreach ( var membMap in maps.FindMatch ( (a) => a.Param, item.Name, param.Name ) )
					{
						if ( membMap.MapType != null )
						{
							param.MapType = membMap.MapType;
						}
						if ( membMap.Attribute != null )
						{
							param.Attribute = membMap.Attribute;
						}
						param.Optional |= membMap.Optional;
					}
				}
			}
			#endregion
			#region Struct Mapping
			foreach ( var item in structMap.Values )
			{
				item.MapName = maps.MapNameMatches ( (a) => a.Struct, null, item.MapName );

				for ( int i = 0; i < item.Members.Count; i++ )
				{
					var member = item.Members[i];
					member.MapName = maps.MapNameMatches ( (a) => a.Field, item.Name, member.MapName );

					foreach ( var membMap in maps.FindMatch ( (a) => a.Field, item.Name, member.Name ) )
					{
						if ( membMap.MapType != null )
						{
							member.MapType = membMap.MapType;
						}
						if ( membMap.FixedSize != 0 )
						{
							member.FixedSize = membMap.FixedSize;
							member.FixedSizeEnum = null;
						}
					}
				}
			}
			#endregion
			foreach ( var item in extensionMap.Values )
			{
				item.MapName = maps.MapNameMatches ( (a) => a.Extension, null, item.MapName );
				foreach ( var member in item.Members )
				{
					member.MapName = maps.MapNameMatches ( (a) => a.Field, item.Name, member.MapName );
				}
			}
			foreach ( var mapType in typeMap.Values )
			{
				var maptype = mapType.FindType ();
				if ( maptype == null && mapType.TypeObject == null )
				{
					Console.WriteLine ( "Missing type mapping {0}", mapType.Name );
				}

				foreach ( var map in mapType.IteratorParents () )
				{
					if ( map.TypeHandle || map.TypeHandle64 )
					{
						var spec = new SpecStruct ()
						{
							Name = mapType.Name,
							MapName = mapType.MapName,
							TypeHandle = map.TypeHandle,
							TypeHandle64 = map.TypeHandle64
						};
						structMap.Add ( mapType.Name, spec );
						break;
					}
				}
			}





			if ( !string.IsNullOrWhiteSpace ( export ) && !Directory.Exists ( export ) )
			{
				Directory.CreateDirectory ( export );
			}


			string text;
			CodeGenerator gen;

			var tmp = new ClassTemplate ()
			{
				Namespace = "Crow.Graphics.Vulkan",
				Accessor = null
			};
			//tmp.Objects.AddRange ( structMap.Values.OrderBy ( (a) => a.MapName ) );
			//tmp.Objects.AddRange ( enumMap.Values.OrderBy ( (a) => a.MapName ) );
			//tmp.Objects.AddRange ( delegateMap.Values.OrderBy ( (a) => a.MapName ) );
			//tmp.Objects.AddRange ( extensionMap.Values.OrderBy ( (a) => a.MapName ) );


			//Enumerations.cs
			tmp.Objects.AddRange ( enumMap.Values.OrderBy ( (a) => a.MapName ) );
			gen = new CodeGenerator ();
			gen.Classes.Add ( tmp );
			text = gen.TransformText ();
			System.IO.File.WriteAllText ( Path.Combine ( export, "Enumerations.cs" ), text );
			tmp.Objects.Clear ();

			//Structures.cs
			tmp.Objects.AddRange ( structMap.Values.OrderBy ( (a) => a.MapName ) );
			gen = new CodeGenerator ();
			gen.Classes.Add ( tmp );
			text = gen.TransformText ();
			System.IO.File.WriteAllText ( Path.Combine ( export, "Structures.cs" ), text );
			tmp.Objects.Clear ();

			//Delegates.cs
			tmp.Objects.AddRange ( delegateMap.Values.OrderBy ( (a) => a.MapName ) );
			gen = new CodeGenerator ();
			gen.Classes.Add ( tmp );
			text = gen.TransformText ();
			System.IO.File.WriteAllText ( Path.Combine ( export, "Delegates.cs" ), text );
			tmp.Objects.Clear ();

			//Functions.cs
			tmp.Objects.AddRange ( extensionMap.Values.OrderBy ( (a) => a.MapName ) );

			var dic = new Dictionary<string, ClassTemplate> ();
			foreach ( XPathNavigator item in featureNodes )
			{
				var feature = item.CreateNavigator ();
				feature.MoveToParent ();
				feature.MoveToParent ();
				var feaName = feature.GetAttribute ( "name" );


				string className = null;
				string fileNamespace = null;
				string file = null;
				foreach ( var map in maps.FindMatch ( (a) => a.Feature, null, feaName ) )
				{
					className = map.MapName ?? className;
					fileNamespace = map.Namespace ?? fileNamespace;
					file = map.File ?? file;
				}

				ClassTemplate classTemp;
				if ( !dic.TryGetValue ( file, out classTemp ) )
				{
					classTemp = new ClassTemplate ();
					dic.Add ( file, classTemp );
				}
				classTemp.Namespace = fileNamespace;
				classTemp.Name = className;


				if ( item.Name == "command" )
				{
					var name = item.GetAttribute ( "name" );
					classTemp.Objects.Add ( commandMap[name] );
				}
			}

			foreach ( var item in dic.Values )
			{
				item.Objects.Sort ( (a, b) => string.Compare ( ((SpecCommand)a).MapName, ((SpecCommand)b).MapName ) );
			}
			tmp.NestedClass.AddRange ( dic.Values );

			gen = new CodeGenerator ();
			gen.Classes.Add ( tmp );
			text = gen.TransformText ();
			System.IO.File.WriteAllText ( Path.Combine ( export, "Functions.cs" ), text );
			//tmp.Objects.Clear ();


			Console.WriteLine ( "done" );
			//Console.ReadKey ();
		}


		//* base_value = 1000000000
		//* range_size = 1000
		//* enum_offset(extension_number, offset) = base_value + (extension_number - 1) × range_size + offset
		//* Positive values: enum_offset(extension_number, offset)
		//* Negative values: -enum_offset(extension_number, offset)
		//static int ExtensionEnumOffset(int extensionNumber, int offset)
		//{
		//	const int BASE_VALUE = 1000000000;
		//	const int RANGE_SIZE = 1000;
		//	return BASE_VALUE + (extensionNumber - 1) * RANGE_SIZE + offset;
		//}
		static string ExtensionEnumOffset(int extensionNumber, int offset)
		{
			return "(1000000000 + 1000 * (" + extensionNumber + " - 1) + " + offset + ")";
		}


		static SpecEnumMember GetSpecEnumMember(string name)
		{
			SpecEnumMember result;
			if ( !enumMemberMap.TryGetValue ( name, out result ) )
			{
				result = new SpecEnumMember { Name = name, MapName = name };
				enumMemberMap.Add ( name, result );
			}
			return result;
		}

		static SpecType GetSpecType(string name)
		{
			SpecType result;
			if ( !typeMap.TryGetValue ( name, out result ) )
			{
				result = new SpecType { Name = name, MapName = name };
				typeMap.Add ( name, result );
			}
			return result;
		}

		static SpecExtension GetSpecExtension(string name)
		{
			SpecExtension result;
			if ( !extensionMap.TryGetValue ( name, out result ) )
			{
				result = new SpecExtension
				{
					Name = name,
					MapName = name,
					Members = new List<SpecField> (),
					Commands = new List<SpecCommand> (),
				};
				extensionMap.Add ( name, result );
			}
			return result;
		}

		static void ParseTypes(Category category, XPathNavigator node)
		{
			var nameNode = node.SelectSingleNode ( "name" );
			string name = nameNode != null ? nameNode.Value : node.GetAttribute ( "name" );

			var typeNode = node.SelectSingleNode ( "type" );

			var mapType = GetSpecType ( name );

			if ( typeNode != null )
			{
				mapType.ParentType = GetSpecType ( typeNode.Value );
			}
			if ( category == Category.Bitmask )
			{
				var requires = node.GetAttribute ( "requires" );
				if ( requires != null )
				{
					mapType.ParentType = GetSpecType ( requires );
				}
			}
		}

		static void ParseDelegate(XPathNavigator node)
		{
			SpecDelegate result = new SpecDelegate ();
			result.Parameters = new List<SpecField> ();

			XPathNavigator nameNode = node.SelectSingleNode ( "name" );
			result.Name = result.MapName = nameNode.InnerXml;

			GetSpecType ( result.Name ).TypeObject = result;
			delegateMap.Add ( result.Name, result );

			// move to name tag
			var child = node.CreateNavigator ();
			child.MoveToFirstChild ();
			var returnType = Regex.Match ( child.Value, @"typedef (\w*)", RegexOptions.CultureInvariant );
			result.Return = GetSpecType ( returnType.Groups[1].Value );
			result.ReturnIsPointer = Regex.IsMatch ( child.Value, @"typedef (\w*)\s*\*", RegexOptions.CultureInvariant );

			foreach ( XPathNavigator item in node.Select ( "type" ) )
			{
				var paramType = item.Value;

				item.MoveToNext ( XPathNodeType.Text );
				var raw = Regex.Match ( item.Value, @"\s*(\*)?\s*(\w+)", RegexOptions.CultureInvariant );

				var paramName = raw.Groups[2].Value;
				var paramIsPointer = raw.Groups[1].Success;

				result.Parameters.Add ( new SpecField ()
				{
					Type = GetSpecType ( paramType ),
					Name = paramName,
					MapName = paramName,
					IsPointer = paramIsPointer,
				} );
			}
		}

		static void ParseStruct(Category category, XPathNavigator node)
		{
			var result = new SpecStruct
			{
				Union = category == Category.Union,
				ReadOnly = node.GetAttribute<bool> ( "returnedonly" )
			};
			result.Name = result.MapName = node.GetAttribute ( "name" );
			GetSpecType ( result.Name ).TypeObject = result;
			structMap.Add ( result.Name, result );

			foreach ( XPathNavigator member in node.Select ( "member" ) )
			{
				SpecField field = new SpecField ();
				var comment = member.CreateNavigator ();
				if ( comment.MoveToNext ( XPathNodeType.Comment ) )
					field.Comment = comment.Value;

				var memberNode = member.SelectSingleNode ( "type" );
				if ( memberNode != null )
				{
					field.Type = GetSpecType ( memberNode.Value );
					if ( memberNode.MoveToNext ( XPathNodeType.Text ) )
						field.IsPointer = memberNode.Value.Contains ( "*" );
				}
				else
				{
					Console.WriteLine ( "Missing type? " + result.Name );
				}

				memberNode = member.SelectSingleNode ( "name" );
				if ( memberNode != null )
				{
					field.Name = field.MapName = memberNode.Value;

					// check field size
					if ( memberNode.MoveToNext ( XPathNodeType.Text ) )
					{
						var txt = memberNode.Value;
						var match = Regex.Match ( txt, @"[(\d+)]", RegexOptions.CultureInvariant );
						if ( match.Success )
						{
							field.FixedSize = int.Parse ( match.Value, CultureInfo.InvariantCulture );
							result.HasFixedSizeField = true;
						}
					}
				}

				// check field enum const size
				memberNode = member.SelectSingleNode ( "enum" );
				if ( memberNode != null )
				{
					var enumMem = enumMemberMap[memberNode.Value];
					//var enumNode = member.OwnerDocument.SelectSingleNode ( "//enum[@name='" + memberNode.InnerText + "']" );
					//field.FixedSize = enumNode.ReadAttribute<int> ( "value" );
					field.FixedSize = int.Parse ( enumMem.Value, CultureInfo.InvariantCulture );
					field.FixedSizeEnum = memberNode.Value;
					result.HasFixedSizeField = true;
				}

				field.Visibility = "public";

				result.Members.Add ( field );
			}
		}

		static void ParseEnum(XPathNavigator node)
		{
			var result = new SpecEnum ();
			result.Name = result.MapName = node.GetAttribute ( "name" );
			result.Comment = node.GetAttribute ( "comment" );
			result.Bitmask = string.Equals ( "bitmask", node.GetAttribute ( "type" ), StringComparison.InvariantCultureIgnoreCase );
			result.Members = new List<SpecEnumMember> ();
			GetSpecType ( result.Name ).TypeObject = result;
			enumMap.Add ( result.Name, result );

			foreach ( XPathNavigator member in node.Select ( "enum" ) )
			{
				var mem = GetSpecEnumMember ( member.GetAttribute ( "name" ) );
				mem.Comment = member.GetAttribute ( "comment" );
				mem.Value = member.GetAttribute ( "value" );
				mem.BitPos = member.GetAttribute<int> ( "bitpos" );

				if ( mem.Value != null )
				{
					if ( mem.Value.IndexOf ( "ull", StringComparison.InvariantCultureIgnoreCase ) != -1 )
					{
						mem.Value = Regex.Replace ( mem.Value, "[uU][lL][lL]", "ul" );
					}
					if ( mem.Value.IndexOf ( "f", StringComparison.InvariantCultureIgnoreCase ) != -1 )
					{
						mem.Value = "(int)" + mem.Value;
					}
					if ( mem.Value.IndexOf ( "~", StringComparison.InvariantCultureIgnoreCase ) != -1 )
					{
						mem.Value = "(int)" + mem.Value;
					}
				}

				result.Members.Add ( mem );
			}
		}

		static void ParseCommand(XPathNavigator node)
		{
			var result = new SpecCommand ();
			result.Successcodes = node.GetAttribute ( "successcodes" );
			result.Errorcodes = node.GetAttribute ( "errorcodes" );

			var proto = node.SelectSingleNode ( "proto" );
			var rType = proto.SelectSingleNode ( "type" );
			result.Return = GetSpecType ( rType.Value );
			result.ReturnIsPointer = proto.InnerXml.Contains ( "*" );

			result.Name = result.MapName = proto.SelectSingleNode ( "name" ).Value;

			commandMap.Add ( result.Name, result );

			result.Parameters = new List<SpecField> ();
			foreach ( XPathNavigator param in node.Select ( "param" ) )
			{
				var field = new SpecField ();

				//field.Optional = param.ReadAttribute<bool> ( "optional" );

				XPathNavigator paramNode;
				paramNode = param.SelectSingleNode ( "type" );
				field.Type = GetSpecType ( paramNode.Value );
				if ( paramNode.MoveToNext ( XPathNodeType.Text ) )
					field.IsPointer = paramNode.Value.Contains ( "*" );

				paramNode = param.SelectSingleNode ( "name" );
				field.Name = field.MapName = paramNode.Value;

				result.Parameters.Add ( field );
			}

			//foreach ( XmlNode param in node.SelectNodes ( "validity/usage" ) )
			//{
			//	result.Summary += param.InnerText + "\n";
			//}
		}
	}

	public class ClassTemplate
	{
		public string Namespace;
		public string Accessor;
		public string Type;
		public string Name;
		public string Interfaces;

		public List<ClassTemplate> NestedClass = new List<ClassTemplate> ();
		public List<object> Objects = new List<object> ();

		public ClassTemplate()
		{
			Accessor = "public partial";
			Type = "class";
		}
	}

	public enum Category
	{
		None, Basetype, Bitmask, Define, Enum, Funcpointer, Group, Handle, Include, Struct, Union,
	}

	public class SpecType
	{
		public SpecType ParentType;
		public object TypeObject;
		public string Name;
		public bool IsPointer;

		public string MapName;
		public string MapType;

		public bool TypeHandle;
		public bool TypeHandle64;

		public bool IsVoid
		{
			get { return !IsPointer && string.Equals ( Name, "void", StringComparison.InvariantCultureIgnoreCase ); }
		}

		public IEnumerable<SpecType> IteratorParents()
		{
			SpecType type = this;
			do
			{
				type = type.ParentType;
				if ( type != null )
				{
					yield return type;
				}
			}
			while ( type != null );
		}

		public string FindType()
		{
			SpecType type = this;
			int i = 0;
			do
			{
				if ( type.MapType != null )
					return type.MapType;
				if ( type.TypeObject is SpecEnum )
				{
					return ((SpecEnum)type.TypeObject).MapName;
				}
				if ( type.TypeObject is SpecStruct )
				{
					return ((SpecStruct)type.TypeObject).MapName;
				}
				if ( type.TypeObject is SpecDelegate )
				{
					return ((SpecDelegate)type.TypeObject).MapName;
				}
				type = type.ParentType;
				i++;
				if ( i >= 10 )
					throw new Exception ( "Infinit type loop? " + Name );
			}
			while ( type != null );
			return null;
		}

		public string FinalTypeName()
		{
			//if ( IsPointer )
			//{
			//	return "IntPtr";
			//}
			return FindType () ?? MapName;
		}

		public string DebugLog()
		{
			var log = Name;
			if ( IsPointer ) log += "*";
			return log;
		}
	}

	public class SpecDelegate
	{
		public SpecType Return;
		public bool ReturnIsPointer;
		public string Name;
		public List<SpecField> Parameters;

		public string MapName;
		public string MapNamespace;
		public string MapGroup;

		public bool IsReturnVoid
		{
			get { return !ReturnIsPointer && Return.IsVoid; }
		}

		public string DebugLog()
		{
			var iter = from item in Parameters select item.DebugLog ();
			var param = string.Join ( ", ", iter );
			var returnType = Return.DebugLog ();
			if ( ReturnIsPointer ) returnType += "*";
			return string.Format ( "{0} {1} ({2})", returnType, Name, param );
		}
	}

	public class SpecField
	{
		public SpecType Type;
		public string MapType;
		public string Name;
		public string MapName;
		public bool IsPointer;
		public bool Optional;
		public string Length;
		public int FixedSize;
		public string FixedSizeEnum;
		public string Comment;
		public string Visibility;
		public string Attribute;
		public string Value;

		public string DebugLog()
		{
			if ( Type == null ) return "";
			var log = Type.DebugLog ();
			if ( IsPointer ) log += "*";
			return log + " " + Name;
		}
	}

	public class SpecStruct
	{
		public string Name;
		public bool Union;
		public bool ReadOnly;
		public List<SpecField> Members = new List<SpecField> ();

		public string MapName;
		public string MapNamespace;
		public string MapGroup;

		public bool HasFixedSizeField;

		public bool TypeHandle;
		public bool TypeHandle64;
	}

	public class SpecEnum
	{
		public string Name;
		public string Comment;
		public bool Bitmask;
		public List<SpecEnumMember> Members;

		public string MapName;
		public string MapNamespace;
		public string MapGroup;
	}

	public class SpecEnumMember
	{
		public string Comment;
		public string Name;
		public string MapName;
		public string Value;
		public int BitPos;
		public string MapType;
		public string Visibility;
		public string Attribute;
	}

	public class SpecCommand : SpecDelegate
	{
		public string Successcodes;
		public string Errorcodes;
		public string Summary;
	}

	public class SpecExtension
	{
		public string MapName;
		public string Name;
		public int Number;
		public string Author;
		public string Contact;
		public List<SpecField> Members;
		public List<SpecCommand> Commands;
	}
}
