using System.Collections.Generic;
using System.Text;
using OpenGlSpecGen.SpecMapping;

namespace OpenGlSpecGen
{
	static class Utils
	{
		//static TextInfo textInfo = new CultureInfo ( "en-US", false ).TextInfo;
		static StringBuilder sb = new StringBuilder ();

		public static string MapString(this IEnumerable<MapBase> typeMap, string value)
		{
			if ( typeMap != null )
			{
				foreach ( var map in typeMap )
				{
					value = map.Replace ( value );
				}
			}
			return value;
		}

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
	}
}
