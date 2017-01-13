using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Crow.Vulkan.SpecGen
{
	public class Map
	{
		[XmlAttribute ( "command" )]
		public string Command;
		[XmlAttribute ( "param" )]
		public string Param;
		[XmlAttribute ( "struct" )]
		public string Struct;
		[XmlAttribute ( "field" )]
		public string Field;
		[XmlAttribute ( "enum" )]
		public string Enum;
		[XmlAttribute ( "enum-item" )]
		public string EnumItem;
		[XmlAttribute ( "type" )]
		public string Type;
		[XmlAttribute ( "extension" )]
		public string Extension;
		[XmlAttribute ( "feature" )]
		public string Feature;


		[XmlAttribute ( "attribute" )]
		public string Attribute;
		[XmlAttribute ( "visibility" )]
		public string Visibility;

		[XmlAttribute ( "map-name" )]
		public string MapName;
		[XmlAttribute ( "map-type" )]
		public string MapType;

		[XmlAttribute ( "namespace" )]
		public string Namespace;
		[XmlAttribute ( "group" )]
		public string Group;

		[XmlAttribute ( "type-handle" )]
		public bool TypeHandle;
		[XmlAttribute ( "type-handle64" )]
		public bool TypeHandle64;
		[XmlAttribute ( "camelcase" )]
		public bool CamelCase;

		[XmlAttribute ( "fixed-size" )]
		public int FixedSize;

		[XmlAttribute ( "class" )]
		public bool ToClass;

		[XmlAttribute ( "value" )]
		public int Value;
		[XmlAttribute ( "file" )]
		public string File;

		[XmlAttribute ( "optional" )]
		public bool Optional;
	}
}
