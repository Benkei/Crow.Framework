using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class _3dfxMultisample
		{
			public enum All
			{
				// WGL_SAMPLE_BUFFERS_3DFX = 0x2060
				SampleBuffers = unchecked((int)8288),
				// WGL_SAMPLES_3DFX = 0x2061
				Samples = unchecked((int)8289),
			}
			public const string NAME_STRING = "WGL_3DFX_multisample";
		}
	}
}

