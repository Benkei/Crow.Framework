using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class IngrBlendFuncSeparate
		{
			public const string NAME_STRING = "GL_INGR_blend_func_separate";
			#region command delegates
			// void glBlendFuncSeparateINGR (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFuncSeparateDelegate (System.UInt32 sfactorRGB, System.UInt32 dfactorRGB, System.UInt32 sfactorAlpha, System.UInt32 dfactorAlpha);
			#endregion // command delegates
			#region commands
			// void glBlendFuncSeparateINGR (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
			public readonly BlendFuncSeparateDelegate BlendFuncSeparate;
			#endregion // commands
			public IngrBlendFuncSeparate (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendFuncSeparateINGR", out BlendFuncSeparate);
			}
		}
		public partial class IngrColorClamp
		{
			public enum All
			{
				// GL_RED_MIN_CLAMP_INGR = 0x8560
				RedMinClamp = unchecked((int)34144),
				// GL_GREEN_MIN_CLAMP_INGR = 0x8561
				GreenMinClamp = unchecked((int)34145),
				// GL_BLUE_MIN_CLAMP_INGR = 0x8562
				BlueMinClamp = unchecked((int)34146),
				// GL_ALPHA_MIN_CLAMP_INGR = 0x8563
				AlphaMinClamp = unchecked((int)34147),
				// GL_RED_MAX_CLAMP_INGR = 0x8564
				RedMaxClamp = unchecked((int)34148),
				// GL_GREEN_MAX_CLAMP_INGR = 0x8565
				GreenMaxClamp = unchecked((int)34149),
				// GL_BLUE_MAX_CLAMP_INGR = 0x8566
				BlueMaxClamp = unchecked((int)34150),
				// GL_ALPHA_MAX_CLAMP_INGR = 0x8567
				AlphaMaxClamp = unchecked((int)34151),
			}
			public const string NAME_STRING = "GL_INGR_color_clamp";
		}
		public partial class IngrInterlaceRead
		{
			public enum All
			{
				// GL_INTERLACE_READ_INGR = 0x8568
				InterlaceRead = unchecked((int)34152),
			}
			public const string NAME_STRING = "GL_INGR_interlace_read";
		}
	}
}

