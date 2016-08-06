using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class RendScreenCoordinates
		{
			public enum All
			{
				// GL_SCREEN_COORDINATES_REND = 0x8490
				ScreenCoordinates = unchecked((int)33936),
				// GL_INVERTED_SCREEN_W_REND = 0x8491
				InvertedScreenW = unchecked((int)33937),
			}
			public const string NAME_STRING = "GL_REND_screen_coordinates";
		}
	}
}

