using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace OpenGlSpecGen.SpecMapping
{
	[XmlRoot ( "config" )]
	public class Config
	{
		[XmlElement ( "mapping" )]
		public Mapping mapping;

		public static Config Load(Stream stream)
		{
			var ser = new XmlSerializer ( typeof ( Config ) );
			return (Config)ser.Deserialize ( stream );
		}
	}

	public class Mapping
	{
		[XmlElement ( "map", typeof ( Map ) )]
		[XmlElement ( "map-param", typeof ( MapParam ) )]
		[XmlElement ( "map-group", typeof ( MapGroup ) )]
		[XmlElement ( "map-enum", typeof ( MapEnum ) )]
		[XmlElement ( "map-command", typeof ( MapCommand ) )]
		[XmlElement ( "map-type", typeof ( MapType ) )]
		[XmlElement ( "map-interface", typeof ( MapInterface ) )]
		public List<MapBase> Maps = new List<MapBase> ();
	}

	public abstract class MapBase
	{
		[XmlAttribute ( "target" )]
		public virtual string Target
		{
			get { return null; }
			set { TargetRegex = new Regex ( value, RegexOptions.CultureInvariant | RegexOptions.Compiled ); }
		}
		[XmlAttribute ( "map" )]
		public virtual string Map { get; set; }
		[XmlIgnore]
		public Regex TargetRegex { get; private set; }
		[XmlAttribute ( "camelcase" )]
		public bool CamelCase { get; set; }

		public System.Text.RegularExpressions.Match Match(string target)
		{
			if ( TargetRegex != null )
			{
				return TargetRegex.Match ( target );
			}
			return global::System.Text.RegularExpressions.Match.Empty;
		}

		public bool IsMatch(string target)
		{
			if ( TargetRegex != null )
			{
				return TargetRegex.IsMatch ( target );
			}
			return false;
		}

		public string Replace(string target)
		{
			return Replace ( target, Map );
		}

		public string Replace(string target, string replacement)
		{
			if ( TargetRegex != null && !string.IsNullOrEmpty ( replacement ) )
			{
				var match = TargetRegex.Match ( target );
				if ( match.Success )
				{
					return replacement.Contains ( "$" ) ? match.Result ( replacement ) : replacement;
				}
			}
			return target;
		}
	}

	public class MapParam : MapBase
	{
		[XmlAttribute ( "target" )]
		public override string Target
		{
			get { return base.Target; }
			set
			{
				if ( value.Contains ( "::" ) )
				{
					var idx = value.LastIndexOf ( "::" );
					CommandTarget = value.Substring ( 0, idx );
					idx += 2;
					value = value.Substring ( idx, value.Length - idx );
				}
				base.Target = value;
			}
		}
		[XmlIgnore]
		public string CommandTarget
		{
			get { return null; }
			private set { CommandTargetRegex = new Regex ( value, RegexOptions.CultureInvariant | RegexOptions.Compiled ); }
		}
		[XmlIgnore]
		public Regex CommandTargetRegex { get; private set; }

		[XmlAttribute ( "type" )]
		public string Type;
		[XmlAttribute ( "attribute" )]
		public string Attribute;
	}

	public class MapCommand : MapBase
	{
		[XmlAttribute ( "type" )]
		public string Type;
	}

	public class MapEnum : MapBase
	{
	}

	public class MapType : MapBase
	{
		private System.Type type;

		[XmlAttribute ( "type" )]
		public string Type
		{
			get { return type.FullName; }
			set { type = System.Type.GetType ( value, true, true ); }
		}
		[XmlAttribute ( "il-type" )]
		public string IlType;
	}

	public class Map : MapBase
	{
	}

	public class MapGroup : MapBase
	{
		[XmlAttribute ( "namespace" )]
		public string Namespace;
		[XmlAttribute ( "class" )]
		public string Class;
		[XmlAttribute ( "filename" )]
		public string FileOutput;
	}

	public class MapInterface : MapBase
	{
		[XmlAttribute ( "namespace" )]
		public string Namespace;
		[XmlAttribute ( "class" )]
		public string Class;
		[XmlAttribute ( "filename" )]
		public string FileOutput;
	}
}
