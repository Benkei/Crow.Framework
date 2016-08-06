using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class S3S3tc
		{
			public enum All
			{
				// GL_RGB_S3TC = 0x83A0
				RgbS3tc = unchecked((int)33696),
				// GL_RGB4_S3TC = 0x83A1
				Rgb4S3tc = unchecked((int)33697),
				// GL_RGBA_S3TC = 0x83A2
				RgbaS3tc = unchecked((int)33698),
				// GL_RGBA4_S3TC = 0x83A3
				Rgba4S3tc = unchecked((int)33699),
				// GL_RGBA_DXT5_S3TC = 0x83A4
				RgbaDxt5S3tc = unchecked((int)33700),
				// GL_RGBA4_DXT5_S3TC = 0x83A5
				Rgba4Dxt5S3tc = unchecked((int)33701),
			}
			public const string NAME_STRING = "GL_S3_s3tc";
		}
	}
}

