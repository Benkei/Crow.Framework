using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class HpConvolutionBorderModes
		{
			public enum All
			{
				// GL_IGNORE_BORDER_HP = 0x8150
				IgnoreBorder = unchecked((int)33104),
				// GL_CONSTANT_BORDER_HP = 0x8151
				ConstantBorder = unchecked((int)33105),
				// GL_REPLICATE_BORDER_HP = 0x8153
				ReplicateBorder = unchecked((int)33107),
				// GL_CONVOLUTION_BORDER_COLOR_HP = 0x8154
				ConvolutionBorderColor = unchecked((int)33108),
			}
			public const string NAME_STRING = "GL_HP_convolution_border_modes";
		}
		public partial class HpImageTransform
		{
			public enum All
			{
				// GL_IMAGE_SCALE_X_HP = 0x8155
				ImageScaleX = unchecked((int)33109),
				// GL_IMAGE_SCALE_Y_HP = 0x8156
				ImageScaleY = unchecked((int)33110),
				// GL_IMAGE_TRANSLATE_X_HP = 0x8157
				ImageTranslateX = unchecked((int)33111),
				// GL_IMAGE_TRANSLATE_Y_HP = 0x8158
				ImageTranslateY = unchecked((int)33112),
				// GL_IMAGE_ROTATE_ANGLE_HP = 0x8159
				ImageRotateAngle = unchecked((int)33113),
				// GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A
				ImageRotateOriginX = unchecked((int)33114),
				// GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B
				ImageRotateOriginY = unchecked((int)33115),
				// GL_IMAGE_MAG_FILTER_HP = 0x815C
				ImageMagFilter = unchecked((int)33116),
				// GL_IMAGE_MIN_FILTER_HP = 0x815D
				ImageMinFilter = unchecked((int)33117),
				// GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E
				ImageCubicWeight = unchecked((int)33118),
				// GL_CUBIC_HP = 0x815F
				Cubic = unchecked((int)33119),
				// GL_AVERAGE_HP = 0x8160
				Average = unchecked((int)33120),
				// GL_IMAGE_TRANSFORM_2D_HP = 0x8161
				ImageTransform2d = unchecked((int)33121),
				// GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162
				PostImageTransformColorTable = unchecked((int)33122),
				// GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163
				ProxyPostImageTransformColorTable = unchecked((int)33123),
			}
			public const string NAME_STRING = "GL_HP_image_transform";
			#region command delegates
			// void glGetImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetImageTransformParameterfvHPDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetImageTransformParameterivHP (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetImageTransformParameterivHPDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glImageTransformParameterfHP (GLenum target, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ImageTransformParameterfHPDelegate (System.UInt32 target, System.UInt32 pname, System.Single param);
			// void glImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ImageTransformParameterfvHPDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glImageTransformParameteriHP (GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ImageTransformParameteriHPDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glImageTransformParameterivHP (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ImageTransformParameterivHPDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetImageTransformParameterfvHPDelegate GetImageTransformParameterfvHP;
			// void glGetImageTransformParameterivHP (GLenum target, GLenum pname, GLint* params)
			public readonly GetImageTransformParameterivHPDelegate GetImageTransformParameterivHP;
			// void glImageTransformParameterfHP (GLenum target, GLenum pname, GLfloat param)
			public readonly ImageTransformParameterfHPDelegate ImageTransformParameterfHP;
			// void glImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat* params)
			public readonly ImageTransformParameterfvHPDelegate ImageTransformParameterfvHP;
			// void glImageTransformParameteriHP (GLenum target, GLenum pname, GLint param)
			public readonly ImageTransformParameteriHPDelegate ImageTransformParameteriHP;
			// void glImageTransformParameterivHP (GLenum target, GLenum pname, GLint* params)
			public readonly ImageTransformParameterivHPDelegate ImageTransformParameterivHP;
			#endregion // commands
			public HpImageTransform (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetImageTransformParameterfvHP", out GetImageTransformParameterfvHP);
				resolver.LoadHandle ("glGetImageTransformParameterivHP", out GetImageTransformParameterivHP);
				resolver.LoadHandle ("glImageTransformParameterfHP", out ImageTransformParameterfHP);
				resolver.LoadHandle ("glImageTransformParameterfvHP", out ImageTransformParameterfvHP);
				resolver.LoadHandle ("glImageTransformParameteriHP", out ImageTransformParameteriHP);
				resolver.LoadHandle ("glImageTransformParameterivHP", out ImageTransformParameterivHP);
			}
		}
		public partial class HpOcclusionTest
		{
			public enum All
			{
				// GL_OCCLUSION_TEST_HP = 0x8165
				OcclusionTest = unchecked((int)33125),
				// GL_OCCLUSION_TEST_RESULT_HP = 0x8166
				OcclusionTestResult = unchecked((int)33126),
			}
			public const string NAME_STRING = "GL_HP_occlusion_test";
		}
		public partial class HpTextureLighting
		{
			public enum All
			{
				// GL_TEXTURE_LIGHTING_MODE_HP = 0x8167
				TextureLightingMode = unchecked((int)33127),
				// GL_TEXTURE_POST_SPECULAR_HP = 0x8168
				TexturePostSpecular = unchecked((int)33128),
				// GL_TEXTURE_PRE_SPECULAR_HP = 0x8169
				TexturePreSpecular = unchecked((int)33129),
			}
			public const string NAME_STRING = "GL_HP_texture_lighting";
		}
	}
}

