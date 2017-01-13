using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace Crow.Vulkan.SpecGen
{
	static class Utils
	{
		static StringBuilder sb = new StringBuilder ();

		public static string ToCamelCase(this string value)
		{
			if ( value == null ) return value;
			bool upper = true;
			//bool lastIsUpper = false;
			for ( int i = 0; i < value.Length; i++ )
			{
				var ch = value[i];
				if ( ch == '_' || ch == ' ' )
				{
					//lastIsUpper = true;
					upper = true;
					continue;
				}
				//bool isUpper = char.IsUpper ( ch ) && !char.IsDigit ( ch );
				//upper |= !lastIsUpper && isUpper;
				//lastIsUpper = isUpper;
				if ( upper ) ch = char.ToUpperInvariant ( ch );
				else ch = char.ToLowerInvariant ( ch );
				sb.Append ( ch );
				upper = ch == '.';
			}
			value = sb.ToString ();
			sb.Length = 0;
			return value;
		}

		public static string GetAttribute(this XPathNavigator node, string name)
		{
			if ( !node.HasAttributes ) return null;
			var attri = node.GetAttribute ( name, string.Empty );
			if ( string.IsNullOrEmpty ( attri ) ) return null;
			return attri;
		}

		public static T GetAttribute<T>(this XPathNavigator node, string name, T defaultValue = default ( T ))
			where T : struct
		{
			if ( !node.HasAttributes ) return defaultValue;
			var attri = node.GetAttribute ( name, string.Empty );
			if ( string.IsNullOrEmpty ( attri ) ) return defaultValue;
			if ( typeof ( T ).IsEnum )
			{
				T val;
				Enum.TryParse<T> ( attri, true, out val );
				return val;
			}
			return (T)Convert.ChangeType ( attri, typeof ( T ) );
		}

		public static T? GetAttributeNullable<T>(this XPathNavigator node, string name)
			where T : struct
		{
			if ( !node.HasAttributes ) return null;
			var attri = node.GetAttribute ( name, string.Empty );
			if ( string.IsNullOrEmpty ( attri ) ) return null;
			if ( typeof ( T ).IsEnum )
			{
				T val;
				Enum.TryParse<T> ( attri, true, out val );
				return val;
			}
			return (T)Convert.ChangeType ( attri, typeof ( T ) );
		}

		public static T ReadAttribute<T>(this XmlNode node, string name, T defaultValue = default ( T ))
		{
			var attri = node.Attributes[name];
			if ( attri == null )
			{
				return defaultValue;
			}
			if ( typeof ( T ).IsEnum )
			{
				return (T)Enum.Parse ( typeof ( T ), attri.Value, true );
			}
			return (T)Convert.ChangeType ( attri.Value, typeof ( T ) );
		}

		public static T? ReadAttributeNullable<T>(this XmlNode node, string name)
			where T : struct
		{
			var attri = node.Attributes[name];
			if ( attri == null )
			{
				return null;
			}
			if ( typeof ( T ).IsEnum )
			{
				T val;
				Enum.TryParse<T> ( attri.Value, true, out val );
				return val;
			}
			return (T)Convert.ChangeType ( attri.Value, typeof ( T ) );
		}
	}
}
