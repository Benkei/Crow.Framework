using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class MesaxTextureStack
		{
			public enum All
			{
				// GL_TEXTURE_1D_STACK_MESAX = 0x8759
				Texture1dStack = unchecked((int)34649),
				// GL_TEXTURE_2D_STACK_MESAX = 0x875A
				Texture2dStack = unchecked((int)34650),
				// GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B
				ProxyTexture1dStack = unchecked((int)34651),
				// GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C
				ProxyTexture2dStack = unchecked((int)34652),
				// GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D
				Texture1dStackBinding = unchecked((int)34653),
				// GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E
				Texture2dStackBinding = unchecked((int)34654),
			}
			public const string NAME_STRING = "GL_MESAX_texture_stack";
		}
	}
}

