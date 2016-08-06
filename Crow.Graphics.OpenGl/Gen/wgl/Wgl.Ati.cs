using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class AtiPixelFormatFloat
		{
			public enum All
			{
				// WGL_TYPE_RGBA_FLOAT_ATI = 0x21A0
				TypeRgbaFloat = unchecked((int)8608),
			}
			public const string NAME_STRING = "WGL_ATI_pixel_format_float";
		}
	}
}

