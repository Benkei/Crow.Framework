using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Crow.Vulkan.SpecGen
{
	public class Mappings
	{
		[XmlElement ( "Map" )]
		public Map[] Maps;

		private static string[] splitter = new[] { "::" };

		public string MapNameMatches(Func<Map, string> selector, string groupName, string name)
		{
			foreach ( var map in Maps )
			{
				if ( map.MapName == null ) continue;
				var matchString = selector ( map );
				if ( matchString == null ) continue;

				bool isGroupMatch = true;
				string nameMatch = matchString;
				int idx = matchString.IndexOf ( "::" );
				if ( idx != -1 )
				{
					var groupMatch = matchString.Substring ( 0, idx );

					isGroupMatch = !string.IsNullOrEmpty ( groupName )
						&& Regex.IsMatch ( groupName, groupMatch, RegexOptions.CultureInvariant );

					if ( isGroupMatch )
						nameMatch = matchString.Substring ( idx + 2 );
				}
				if ( isGroupMatch )
				{
					var fieldMatch = Regex.Match ( name, nameMatch, RegexOptions.CultureInvariant );

					if ( fieldMatch.Success )
					{
						if ( map.MapName.Contains ( "$" ) )
						{
							name = fieldMatch.Result ( map.MapName );
						}
						else
						{
							name = map.MapName;
						}
						if ( map.CamelCase )
						{
							name = name.ToCamelCase ();
						}
					}
				}
			}
			return name;
		}

		public IEnumerable<Map> FindMatch(Func<Map, string> selector, string groupName, string name)
		{
			foreach ( var map in Maps )
			{
				var matchString = selector ( map );
				if ( matchString == null ) continue;

				bool isGroupMatch = true;
				string nameMatch = matchString;
				int idx = matchString.IndexOf ( "::" );
				if ( idx != -1 )
				{
					var groupMatch = matchString.Substring ( 0, idx );

					isGroupMatch = !string.IsNullOrEmpty ( groupName )
						&& Regex.IsMatch ( groupName, groupMatch, RegexOptions.CultureInvariant );

					if ( isGroupMatch )
						nameMatch = matchString.Substring ( idx + 2 );
				}
				if ( isGroupMatch )
				{
					var fieldMatch = Regex.Match ( name, nameMatch, RegexOptions.CultureInvariant );

					if ( fieldMatch.Success )
					{
						yield return map;
					}
				}
			}
		}
		/*
		public IEnumerable<Map> FindMatch(Func<Map, string> selector, params string[] paths)
		{
			foreach ( var map in Maps )
			{
				var matchString = selector ( map );
				if ( matchString == null || !matchString.Contains ( "::" ) ) continue;

				var split = matchString.Split ( splitter, StringSplitOptions.RemoveEmptyEntries );

				if ( paths.Length != split.Length ) continue;

				var hasMatch = true;
				for ( int i = 0; i < paths.Length; i++ )
				{
					var path = paths[i];
					var mathPath = split[i];
					var match = Regex.Match ( path, mathPath, RegexOptions.CultureInvariant );
					hasMatch &= match.Success;
					if ( !hasMatch ) break;
				}
				if ( hasMatch )
				{
					yield return map;
				}
			}
		}
		*/
	}
}
