using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class OmlInterlace
		{
			public enum All
			{
				// GL_INTERLACE_OML = 0x8980
				Interlace = unchecked((int)35200),
				// GL_INTERLACE_READ_OML = 0x8981
				InterlaceRead = unchecked((int)35201),
			}
			public const string NAME_STRING = "GL_OML_interlace";
		}
		public partial class OmlResample
		{
			public enum All
			{
				// GL_PACK_RESAMPLE_OML = 0x8984
				PackResample = unchecked((int)35204),
				// GL_UNPACK_RESAMPLE_OML = 0x8985
				UnpackResample = unchecked((int)35205),
				// GL_RESAMPLE_REPLICATE_OML = 0x8986
				ResampleReplicate = unchecked((int)35206),
				// GL_RESAMPLE_ZERO_FILL_OML = 0x8987
				ResampleZeroFill = unchecked((int)35207),
				// GL_RESAMPLE_AVERAGE_OML = 0x8988
				ResampleAverage = unchecked((int)35208),
				// GL_RESAMPLE_DECIMATE_OML = 0x8989
				ResampleDecimate = unchecked((int)35209),
			}
			public const string NAME_STRING = "GL_OML_resample";
		}
		public partial class OmlSubsample
		{
			public enum All
			{
				// GL_FORMAT_SUBSAMPLE_24_24_OML = 0x8982
				FormatSubsample2424 = unchecked((int)35202),
				// GL_FORMAT_SUBSAMPLE_244_244_OML = 0x8983
				FormatSubsample244244 = unchecked((int)35203),
			}
			public const string NAME_STRING = "GL_OML_subsample";
		}
	}
}

