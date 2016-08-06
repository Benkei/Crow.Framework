using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class WinPhongShading
		{
			public enum All
			{
				// GL_PHONG_WIN = 0x80EA
				Phong = unchecked((int)33002),
				// GL_PHONG_HINT_WIN = 0x80EB
				PhongHint = unchecked((int)33003),
			}
			public const string NAME_STRING = "GL_WIN_phong_shading";
		}
		public partial class WinSpecularFog
		{
			public enum All
			{
				// GL_FOG_SPECULAR_TEXTURE_WIN = 0x80EC
				FogSpecularTexture = unchecked((int)33004),
			}
			public const string NAME_STRING = "GL_WIN_specular_fog";
		}
	}
}

