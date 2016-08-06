using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class _3dfxMultisample
		{
			public enum All
			{
				// GL_MULTISAMPLE_3DFX = 0x86B2
				Multisample = unchecked((int)34482),
				// GL_SAMPLE_BUFFERS_3DFX = 0x86B3
				SampleBuffers = unchecked((int)34483),
				// GL_SAMPLES_3DFX = 0x86B4
				Samples = unchecked((int)34484),
				// GL_MULTISAMPLE_BIT_3DFX = 0x20000000
				MultisampleBit = unchecked((int)536870912),
			}
			public const string NAME_STRING = "GL_3DFX_multisample";
		}
		public partial class _3dfxTbuffer
		{
			public const string NAME_STRING = "GL_3DFX_tbuffer";
			#region command delegates
			// void glTbufferMask3DFX (GLuint mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TbufferMaskDelegate (System.UInt32 mask);
			#endregion // command delegates
			#region commands
			// void glTbufferMask3DFX (GLuint mask)
			public readonly TbufferMaskDelegate TbufferMask;
			#endregion // commands
			public _3dfxTbuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTbufferMask3DFX", out TbufferMask);
			}
		}
		public partial class _3dfxTextureCompressionFxt1
		{
			public enum All
			{
				// GL_COMPRESSED_RGB_FXT1_3DFX = 0x86B0
				CompressedRgbFxt1 = unchecked((int)34480),
				// GL_COMPRESSED_RGBA_FXT1_3DFX = 0x86B1
				CompressedRgbaFxt1 = unchecked((int)34481),
			}
			public const string NAME_STRING = "GL_3DFX_texture_compression_FXT1";
		}
	}
}

