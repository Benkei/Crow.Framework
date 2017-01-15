using System;
using System.IO;
using System.Linq;
using OpenGlSpecGen.Spec;
using OpenGlSpecGen.SpecMapping;

namespace OpenGlSpecGen
{
	class Mapper
	{
		private MapBase[] commandNameMaps;
		private MapBase[] parameterNameMaps;
		private MapType[] typeMaps;
		private MapBase[] enumNameMaps;
		private MapGroup[] groupMaps;
		private MapInterface[] interfaceMaps;

		public Mapper(Config config)
		{
			commandNameMaps = (from item in config.mapping.Maps
									 where (item is MapCommand || item is Map) && item.TargetRegex != null
									 select item).ToArray ();

			parameterNameMaps = (from item in config.mapping.Maps
										where (item is MapParam || item is Map) && item.TargetRegex != null
										select item).ToArray ();

			typeMaps = (from item in config.mapping.Maps
							where item is MapType && item.TargetRegex != null
							select item as MapType).ToArray ();

			enumNameMaps = (from item in config.mapping.Maps
								 where (item is MapEnum || item is Map) && item.TargetRegex != null
								 select item).ToArray ();

			groupMaps = (from item in config.mapping.Maps
							 where (item is MapGroup) && item.TargetRegex != null
							 select item as MapGroup).ToArray ();

			interfaceMaps = (from item in config.mapping.Maps
								  where (item is MapInterface) && item.TargetRegex != null
								  select item as MapInterface).ToArray ();
		}

		public void CommandMapping(SpecPrototype prototype, ref string name, out string returnType)
		{
			returnType = null;
			foreach ( var map in commandNameMaps )
			{
				if ( map.IsMatch ( prototype.Declaration.Name ) )
				{
					name = map.Replace ( name );

					var cmdMap = map as MapCommand;
					if ( cmdMap != null && !string.IsNullOrEmpty ( cmdMap.Type ) )
						returnType = cmdMap.Type;
				}
			}
		}

		public void ParameterMapping(SpecPrototype prototype, string commandName,
			ref string name, out string attribute, out string type)
		{
			attribute = null;
			type = null;
			foreach ( var map in parameterNameMaps )
			{
				if ( map is MapParam )
				{
					MapParam param = (MapParam)map;
					if ( param.CommandTargetRegex == null
						|| param.CommandTargetRegex.IsMatch ( commandName )
						&& param.IsMatch ( prototype.Declaration.Name ) )
					{
						name = param.Replace ( name );

						if ( !string.IsNullOrEmpty ( param.Attribute ) )
							attribute = param.Attribute;
						if ( !string.IsNullOrEmpty ( param.Type ) )
							type = param.Type;
					}
				}
				else
				{
					name = map.Replace ( name );
				}
			}
		}

		public string EnumNameMapping(string value)
		{
			foreach ( var map in enumNameMaps )
			{
				value = map.Replace ( value );
				if ( map.CamelCase )
				{
					value = value.ToCamelCase ();
				}
			}
			return value;
		}

		public string TypeMapping(SpecPrototype prototype)
		{
			string returnType;
			if ( prototype.Declaration.Pointers > 0 )
			{
				returnType = "IntPtr";
			}
			//else if ( prototype.EnumGroup != null && groups.ContainsKey ( prototype.EnumGroup ) )
			//{
			//	returnType = prototype.EnumGroup;
			//}
			else
			{
				returnType = prototype.Declaration.Type;
				if ( !string.IsNullOrWhiteSpace ( returnType ) )
				{
					foreach ( var map in typeMaps )
					{
						returnType = map.Replace ( returnType, map.Type );
					}
					if ( returnType == prototype.Declaration.Type )
					{
						Console.WriteLine ( "Type mapping not found! " + returnType );
					}
				}
				else
				{
					returnType = "void";
				}
			}
			return returnType;
		}

		public EnumGroupInfo GroupMapping(SpecGroup prototype)
		{
			EnumGroupInfo group = new EnumGroupInfo ();
			group.Group = prototype;
			group.Name = prototype.Name;
			foreach ( var map in groupMaps )
			{
				var match = map.Match ( prototype.Name );
				if ( !match.Success )
					continue;
				group.Name = match.Result ( group.Name );
				group.Namespace = match.Result ( map.Namespace );
				var classChain = match.Result ( map.Class );
				if ( classChain.Contains ( "::" ) )
				{
					group.Class = classChain.Split ( new[] { "::" }, StringSplitOptions.RemoveEmptyEntries );
				}
				else
				{
					group.Class = new[] { classChain };
				}
				group.FileOutput = match.Result ( map.FileOutput );
				if ( map.CamelCase )
				{
					group.Namespace = group.Namespace.ToCamelCase ();
					for ( int i = 0; i < group.Class.Length; i++ )
					{
						var value = group.Class[i].ToCamelCase ();
						if ( value.Length > 0 && char.IsDigit ( value[0] ) )
							value = "_" + value;
						group.Class[i] = value;
					}
					group.FileOutput =
						Path.GetFileNameWithoutExtension ( group.FileOutput ).ToCamelCase ()
						+ Path.GetExtension ( group.FileOutput );
				}
				else
				{
					for ( int i = 0; i < group.Class.Length; i++ )
					{
						var value = group.Class[i];
						if ( value.Length > 0 && char.IsDigit ( value[0] ) )
							value = "_" + value;
						group.Class[i] = value;
					}
				}
			}
			return group;
		}

		public InterfaceGroup InterfaceMapping(SpecInterfaceGroup prototype)
		{
			InterfaceGroup group = new InterfaceGroup ( prototype );
			foreach ( var map in interfaceMaps )
			{
				var match = map.Match ( prototype.Name );
				if ( !match.Success )
					continue;
				group.Namespace = match.Result ( map.Namespace );
				var classChain = match.Result ( map.Class );
				if ( classChain.Contains ( "::" ) )
				{
					group.Class = classChain.Split ( new[] { "::" }, StringSplitOptions.RemoveEmptyEntries );
				}
				else
				{
					group.Class = new[] { classChain };
				}
				group.FileOutput = match.Result ( map.FileOutput );
				if ( map.CamelCase )
				{
					group.Namespace = group.Namespace.ToCamelCase ();
					for ( int i = 0; i < group.Class.Length; i++ )
					{
						var value = group.Class[i].ToCamelCase ();
						if ( value.Length > 0 && char.IsDigit ( value[0] ) )
							value = "_" + value;
						group.Class[i] = value;
					}
					group.FileOutput =
						Path.GetFileNameWithoutExtension ( group.FileOutput ).ToCamelCase ()
						+ Path.GetExtension ( group.FileOutput );
				}
				else
				{
					for ( int i = 0; i < group.Class.Length; i++ )
					{
						var value = group.Class[i];
						if ( value.Length > 0 && char.IsDigit ( value[0] ) )
							value = "_" + value;
						group.Class[i] = value;
					}
				}
			}
			return group;
		}
	}
}
