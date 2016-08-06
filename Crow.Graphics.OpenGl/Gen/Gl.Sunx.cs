using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class SunxConstantData
		{
			public enum All
			{
				// GL_UNPACK_CONSTANT_DATA_SUNX = 0x81D5
				UnpackConstantData = unchecked((int)33237),
				// GL_TEXTURE_CONSTANT_DATA_SUNX = 0x81D6
				TextureConstantData = unchecked((int)33238),
			}
			public const string NAME_STRING = "GL_SUNX_constant_data";
			#region command delegates
			// void glFinishTextureSUNX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FinishTextureDelegate ();
			#endregion // command delegates
			#region commands
			// void glFinishTextureSUNX ()
			public readonly FinishTextureDelegate FinishTexture;
			#endregion // commands
			public SunxConstantData (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFinishTextureSUNX", out FinishTexture);
			}
		}
	}
}

