using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using OpenGlSpecGen.Spec;
using OpenGlSpecGen.SpecMapping;

namespace OpenGlSpecGen
{
	class Program
	{
		static void Main(string[] args)
		{
			// xml khronos file
			// xml mapping file
			// api name
			// profile name (common|core|compatibility)
			// version max
			// output path

			if ( args.Length < 5 )
			{
				return;
			}
			if ( !File.Exists ( args[0] ) )
			{
				return;
			}
			if ( !File.Exists ( args[1] ) )
			{
				return;
			}

			//Debugger.Launch ();

			var watch = Stopwatch.StartNew ();

			var khronosXml = args[0];
			var mappingXml = args[1];
			var api = args[2];
			var profile = args[3];
			var version = float.Parse ( args[4], CultureInfo.InvariantCulture );
			var output = args[5];

			var registry = new SpecRegistry ();
			using ( var stream = new FileStream ( khronosXml, FileMode.Open, FileAccess.Read,
				FileShare.Read, 4096, FileOptions.SequentialScan ) )
			{
				registry.Read ( stream );
			}

			Config config;
			using ( var stream = new FileStream ( mappingXml, FileMode.Open, FileAccess.Read,
				FileShare.Read, 4096, FileOptions.SequentialScan ) )
			{
				config = Config.Load ( stream );
			}

			Mapper mapper = new Mapper ( config );

			var interfaces = (from item in registry.Features.Concat ( registry.Extensions )
									where (item.Api == null || item.Api == api) && (item.Supported == null || item.Supported.IsMatch ( api )) && item.Number <= version
									select mapper.InterfaceMapping ( item ))
									.ToArray ();

			var reqInterfaces = from item in interfaces
									  where item.SpecGroup.Require != null
									  from list in item.SpecGroup.Require
									  where (string.IsNullOrWhiteSpace ( list.Api ) || list.Api == api)
										  && (string.IsNullOrWhiteSpace ( list.Profile ) || list.Profile == profile)
									  from tag in list
									  select new InterfaceElement { Group = item, List = list, Interface = tag };
			var remInterfaces = from item in interfaces
									  where item.SpecGroup.Remove != null
									  from list in item.SpecGroup.Remove
									  where (string.IsNullOrWhiteSpace ( list.Api ) || list.Api == api)
										  && (string.IsNullOrWhiteSpace ( list.Profile ) || list.Profile == profile)
									  from tag in list
									  select new InterfaceElement { Group = item, List = list, Interface = tag };


			var activeInterfaces = new HashSet<InterfaceElement> ();
			activeInterfaces.UnionWith ( reqInterfaces );
			activeInterfaces.ExceptWith ( remInterfaces );


			var groups = (from item in registry.Groups.Groups select item)
				.ToDictionary (
				(a) => a.Name,
				(a) => mapper.GroupMapping ( a )
				);

			var commandMap = (from item in registry.Commands
									from cmd in item.Commands
									select cmd)
									.ToDictionary ( (a) => a.Prototype.Declaration.Name );

			var _enums = (from range in registry.Enums
							  from @enum in range.Enums
							  where (string.IsNullOrWhiteSpace ( @enum.Api ) || @enum.Api == api)
							  select new EnumValue { Range = range, Value = @enum })
							  .ToDictionary ( (a) => a.Value.Name );

			HashSet<string> requireGroups = new HashSet<string> ( StringComparer.InvariantCulture );

			var cmds = from item in activeInterfaces
						  where item.Interface.Type == SpecInterfaceType.Command
						  select item;

			List<CommandInfo> commands = new List<CommandInfo> ( cmds.Count () );

			#region Cmds

			foreach ( var cmd in cmds )
			{
				var command = commandMap[cmd.Interface.Name];
				string name = command.Prototype.Declaration.Name;
				string type = null;

				CommandInfo info = new CommandInfo
				{
					CommandGroup = cmd,
					Command = command,
				};

				if ( command.Prototype.EnumGroup != null && groups.ContainsKey ( command.Prototype.EnumGroup ) )
					requireGroups.Add ( command.Prototype.EnumGroup );

				mapper.CommandMapping ( command.Prototype, ref name, out type );

				if ( string.IsNullOrWhiteSpace ( type ) )
				{
					if ( command.Prototype.EnumGroup != null && groups.ContainsKey ( command.Prototype.EnumGroup ) )
					{
						type = command.Prototype.EnumGroup;
					}
					else
					{
						type = mapper.TypeMapping ( command.Prototype );
					}
				}

				info.Method.Name = name;
				info.Method.Type = type;
				info.Method.TypeGroup = command.Prototype.EnumGroup;

				info.Parameters = new VariableInfo[command.Parameters.Count];
				for ( int i = 0; i < command.Parameters.Count; i++ )
				{
					var item = command.Parameters[i];
					string pName = item.Declaration.Name;
					string pType;
					string attribute;

					if ( item.EnumGroup != null && groups.ContainsKey ( item.EnumGroup ) )
						requireGroups.Add ( item.EnumGroup );

					mapper.ParameterMapping ( item, command.Prototype.Declaration.Name,
						ref pName, out attribute, out pType );

					if ( string.IsNullOrWhiteSpace ( pType ) )
					{
						if ( item.EnumGroup != null && groups.ContainsKey ( item.EnumGroup ) )
						{
							pType = item.EnumGroup;
						}
						else
						{
							pType = mapper.TypeMapping ( item );
						}
					}

					if ( pType.Equals ( "void", StringComparison.InvariantCultureIgnoreCase ) )
					{
						pType = "System.IntPtr";
					}

					if ( attribute != null )
					{
						pType = attribute + " " + pType;
					}

					info.Parameters[i] = new VariableInfo
					{
						Name = pName,
						Type = pType,
						TypeGroup = item.EnumGroup,
					};
				}

				commands.Add ( info );
			}

			#endregion

			var requireEnums = new List<EnumGroup> ();
			var _requireEnums = from item in activeInterfaces
									  where item.Interface.Type == SpecInterfaceType.Enum
									  select item;
			foreach ( var item in _requireEnums )
			{
				EnumGroup enumValue = new EnumGroup {
					Group = item.Group,
					List = item.List,
					Element = _enums[item.Interface.Name]
				};
				requireEnums.Add ( enumValue );
			}
			
			var interCmds = from item in commands
								 group item by new
								 {
									 item.CommandGroup.Group,
									 item.CommandGroup.Group.Namespace,
									 item.CommandGroup.Group.Class,
									 item.CommandGroup.Group.FileOutput,
								 } into itemGroup
								 select itemGroup;

			var templates = new Dictionary<string, Templates.GlBindingTemplate> ();

			#region setup command templates
			foreach ( var inter in interCmds )
			{
				Templates.GlBindingTemplate tmpl;
				if ( !templates.TryGetValue ( inter.Key.FileOutput, out tmpl ) )
				{
					tmpl = new Templates.GlBindingTemplate ();
					tmpl.FileNamespace = inter.Key.Namespace;
					templates.Add ( inter.Key.FileOutput, tmpl );
				}

				var classes = tmpl.Class;
				ClassInfo classInfo = null;
				foreach ( var item in inter.Key.Class )
				{
					classInfo = classes.Find ( (a) => a.Name == item );
					if ( classInfo == null )
					{
						classInfo = new ClassInfo ()
						{
							Name = item,
							Type = "class",
							Accessor = "public partial"
						};
						classes.Add ( classInfo );
					}
					classes = classInfo.SubClasses;
				}

				classInfo.Group = inter.Key.Group;
				classInfo.Commands.AddRange ( inter );
			}
			#endregion

			#region setup enum templates
			foreach ( var group in requireGroups )
			{
				var elements = groups[group];

				Templates.GlBindingTemplate tmpl;
				if ( !templates.TryGetValue ( elements.FileOutput, out tmpl ) )
				{
					tmpl = new Templates.GlBindingTemplate ();
					tmpl.FileNamespace = elements.Namespace;
					templates.Add ( elements.FileOutput, tmpl );
				}

				EnumClassInfo enumInfo = new EnumClassInfo ()
				{
					Name = elements.Name,
					Type = "enum",
					Accessor = "public",
					EnumValueType = null,
					Group = elements.Group,
				};
				foreach ( var item in elements.Group.Enums )
				{
					var eItem = _enums[item];
					EnumElementInfo inf;
					string name = mapper.EnumNameMapping ( eItem.Value.Name );
					if ( enumInfo.Values.TryGetValue ( name, out inf ) )
					{
						if ( inf.Alias == null )
							inf.Alias = new List<SpecEnum> ();
						inf.Alias.Add ( eItem.Value );
						enumInfo.Values[inf.Name] = inf;
					}
					else
					{
						inf = new EnumElementInfo
						{
							Name = name,
							Value = eItem.Value
						};
						enumInfo.Values.Add ( inf.Name, inf );
					}
				}
				tmpl.Enums.Add ( enumInfo );
			}
			#endregion

			#region setup all enum templates
			foreach ( var enums in requireEnums )
			{
				Templates.GlBindingTemplate tmpl;
				if ( !templates.TryGetValue ( enums.Group.FileOutput, out tmpl ) )
				{
					tmpl = new Templates.GlBindingTemplate ();
					tmpl.FileNamespace = enums.Group.Namespace;
					templates.Add ( enums.Group.FileOutput, tmpl );
				}

				var classes = tmpl.Class;
				ClassInfo classInfo = null;
				for ( int i = 0; i < enums.Group.Class.Length; i++ )
				{
					var item = enums.Group.Class[i];
					classInfo = classes.Find ( (a) => a.Name == item );
					if ( classInfo == null )
					{
						classInfo = new ClassInfo ()
						{
							Name = item,
							Type = "class",
							Accessor = "public partial"
						};
						classes.Add ( classInfo );
					}
					classes = classInfo.SubClasses;
				}

				classInfo.Group = enums.Group;
				var enumList = classInfo != null ? classInfo.Enums : tmpl.Enums;
				EnumClassInfo enumInfo = enumList.Find ( (a) => a.Name == "All" );
				if ( enumInfo == null )
				{
					enumInfo = new EnumClassInfo ()
					{
						Name = "All",
						Type = "enum",
						Accessor = "public",
						EnumValueType = null,
					};
					enumList.Add ( enumInfo );
				}

				EnumElementInfo inf;
				string name = mapper.EnumNameMapping ( enums.Element.Value.Name );
				if ( enumInfo.Values.TryGetValue ( name, out inf ) )
				{
					if ( inf.Alias == null )
						inf.Alias = new List<SpecEnum> ();
					inf.Alias.Add ( enums.Element.Value );
					enumInfo.Values[inf.Name] = inf;
				}
				else
				{
					inf = new EnumElementInfo
					{
						Name = name,
						Value = enums.Element.Value
					};
					enumInfo.Values.Add ( inf.Name, inf );
				}
			}
			#endregion


			var time0 = watch.Elapsed;
			Console.WriteLine ( "Time0 " + time0 );

			if ( !Directory.Exists ( output ) )
			{
				Directory.CreateDirectory ( output );
			}
			foreach ( var item in templates )
			{
				var text = item.Value.TransformText ();
				File.WriteAllText ( Path.Combine ( output, item.Key ), text );
			}

			var time1 = watch.Elapsed;
			Console.WriteLine ( "Time1 " + time1 );
			Console.WriteLine ( "Done..." );
		}
	}

	[DebuggerDisplay ( "{SpecGroup.Name}" )]
	public class InterfaceGroup
	{
		public SpecInterfaceGroup SpecGroup;
		public string Namespace;
		public string[] Class;
		public string FileOutput;
		public InterfaceGroup(SpecInterfaceGroup group)
		{
			SpecGroup = group;
		}
	}
	[DebuggerDisplay ( "{Interface.Type} {Interface.Name}" )]
	public struct InterfaceElement : IEquatable<InterfaceElement>
	{
		public InterfaceGroup Group;
		public SpecInterfaceList List;
		public SpecInterface Interface;

		public bool Equals(InterfaceElement other)
		{
			return Interface.Equals ( other.Interface );
		}
		public override bool Equals(object obj)
		{
			return obj is InterfaceElement && Interface.Equals ( (InterfaceElement)obj );
		}
		public override int GetHashCode()
		{
			return Interface.GetHashCode ();
		}
	}
	[DebuggerDisplay ( "{Element.Value.Value} {Element.Value.Name}" )]
	struct EnumGroup
	{
		public InterfaceGroup Group;
		public SpecInterfaceList List;
		public EnumValue Element;
	}
	[DebuggerDisplay ( "{Value.Value} {Value.Name}" )]
	struct EnumValue
	{
		public SpecEnums Range;
		public SpecEnum Value;
	}
	class EnumGroupInfo
	{
		public string Name;
		public SpecGroup Group;
		public string Namespace;
		public string[] Class;
		public string FileOutput;
	}


	public abstract class TypeClassInfo
	{
		public string Accessor;
		public string Type;
		public string Name;
	}

	public class EnumClassInfo : TypeClassInfo
	{
		public SpecGroup Group;
		public string EnumValueType;
		public SortedList<string, EnumElementInfo> Values = new SortedList<string, EnumElementInfo> ();
		public SpecEnums Range;
	}

	public struct EnumElementInfo
	{
		public string Name;
		public SpecEnum Value;
		public List<SpecEnum> Alias;
	}

	public class ClassInfo : TypeClassInfo
	{
		public InterfaceGroup Group;
		public List<CommandInfo> Commands = new List<CommandInfo> ();
		public List<EnumClassInfo> Enums = new List<EnumClassInfo> ();
		public List<ClassInfo> SubClasses = new List<ClassInfo> ();
	}

	public struct CommandInfo
	{
		public InterfaceElement CommandGroup;
		public SpecCommand Command;

		public VariableInfo Method;
		public VariableInfo[] Parameters;

		public string Version
		{
			get { return CommandGroup.Group.SpecGroup.Number.ToString ( "0.0" ); }
		}
	}

	public struct VariableInfo
	{
		public string Name;
		public string Type;
		public string TypeGroup;
	}
}
