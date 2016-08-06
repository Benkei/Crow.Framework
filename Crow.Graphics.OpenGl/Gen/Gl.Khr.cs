using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class KhrBlendEquationAdvanced
		{
			public enum All
			{
				// GL_MULTIPLY_KHR = 0x9294
				Multiply = unchecked((int)37524),
				// GL_SCREEN_KHR = 0x9295
				Screen = unchecked((int)37525),
				// GL_OVERLAY_KHR = 0x9296
				Overlay = unchecked((int)37526),
				// GL_DARKEN_KHR = 0x9297
				Darken = unchecked((int)37527),
				// GL_LIGHTEN_KHR = 0x9298
				Lighten = unchecked((int)37528),
				// GL_COLORDODGE_KHR = 0x9299
				Colordodge = unchecked((int)37529),
				// GL_COLORBURN_KHR = 0x929A
				Colorburn = unchecked((int)37530),
				// GL_HARDLIGHT_KHR = 0x929B
				Hardlight = unchecked((int)37531),
				// GL_SOFTLIGHT_KHR = 0x929C
				Softlight = unchecked((int)37532),
				// GL_DIFFERENCE_KHR = 0x929E
				Difference = unchecked((int)37534),
				// GL_EXCLUSION_KHR = 0x92A0
				Exclusion = unchecked((int)37536),
				// GL_HSL_HUE_KHR = 0x92AD
				HslHue = unchecked((int)37549),
				// GL_HSL_SATURATION_KHR = 0x92AE
				HslSaturation = unchecked((int)37550),
				// GL_HSL_COLOR_KHR = 0x92AF
				HslColor = unchecked((int)37551),
				// GL_HSL_LUMINOSITY_KHR = 0x92B0
				HslLuminosity = unchecked((int)37552),
			}
			public const string NAME_STRING = "GL_KHR_blend_equation_advanced";
			#region command delegates
			// void glBlendBarrierKHR ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendBarrierDelegate ();
			#endregion // command delegates
			#region commands
			// void glBlendBarrierKHR ()
			public readonly BlendBarrierDelegate BlendBarrier;
			#endregion // commands
			public KhrBlendEquationAdvanced (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendBarrierKHR", out BlendBarrier);
			}
		}
		public partial class KhrBlendEquationAdvancedCoherent
		{
			public enum All
			{
				// GL_BLEND_ADVANCED_COHERENT_KHR = 0x9285
				BlendAdvancedCoherent = unchecked((int)37509),
			}
			public const string NAME_STRING = "GL_KHR_blend_equation_advanced_coherent";
		}
		public partial class KhrNoError
		{
			public enum All
			{
				// GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x8
				ContextFlagNoErrorBit = unchecked((int)8),
			}
			public const string NAME_STRING = "GL_KHR_no_error";
		}
		public partial class KhrRobustness
		{
			public enum All
			{
				// GL_CONTEXT_ROBUST_ACCESS = 0x90F3
				ContextRobustAccess = unchecked((int)37107),
			}
			public const string NAME_STRING = "GL_KHR_robustness";
		}
		public partial class KhrTextureCompressionAstcHdr
		{
			public enum All
			{
				// GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0
				CompressedRgbaAstc4x4 = unchecked((int)37808),
				// GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1
				CompressedRgbaAstc5x4 = unchecked((int)37809),
				// GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2
				CompressedRgbaAstc5x5 = unchecked((int)37810),
				// GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3
				CompressedRgbaAstc6x5 = unchecked((int)37811),
				// GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4
				CompressedRgbaAstc6x6 = unchecked((int)37812),
				// GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5
				CompressedRgbaAstc8x5 = unchecked((int)37813),
				// GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6
				CompressedRgbaAstc8x6 = unchecked((int)37814),
				// GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7
				CompressedRgbaAstc8x8 = unchecked((int)37815),
				// GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8
				CompressedRgbaAstc10x5 = unchecked((int)37816),
				// GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9
				CompressedRgbaAstc10x6 = unchecked((int)37817),
				// GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA
				CompressedRgbaAstc10x8 = unchecked((int)37818),
				// GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB
				CompressedRgbaAstc10x10 = unchecked((int)37819),
				// GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC
				CompressedRgbaAstc12x10 = unchecked((int)37820),
				// GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD
				CompressedRgbaAstc12x12 = unchecked((int)37821),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0
				CompressedSrgb8Alpha8Astc4x4 = unchecked((int)37840),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1
				CompressedSrgb8Alpha8Astc5x4 = unchecked((int)37841),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2
				CompressedSrgb8Alpha8Astc5x5 = unchecked((int)37842),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3
				CompressedSrgb8Alpha8Astc6x5 = unchecked((int)37843),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4
				CompressedSrgb8Alpha8Astc6x6 = unchecked((int)37844),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5
				CompressedSrgb8Alpha8Astc8x5 = unchecked((int)37845),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6
				CompressedSrgb8Alpha8Astc8x6 = unchecked((int)37846),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7
				CompressedSrgb8Alpha8Astc8x8 = unchecked((int)37847),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8
				CompressedSrgb8Alpha8Astc10x5 = unchecked((int)37848),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9
				CompressedSrgb8Alpha8Astc10x6 = unchecked((int)37849),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA
				CompressedSrgb8Alpha8Astc10x8 = unchecked((int)37850),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB
				CompressedSrgb8Alpha8Astc10x10 = unchecked((int)37851),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC
				CompressedSrgb8Alpha8Astc12x10 = unchecked((int)37852),
				// GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD
				CompressedSrgb8Alpha8Astc12x12 = unchecked((int)37853),
			}
			public const string NAME_STRING = "GL_KHR_texture_compression_astc_hdr";
		}
	}
}

