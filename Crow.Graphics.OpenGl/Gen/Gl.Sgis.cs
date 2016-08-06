using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class SgisDetailTexture
		{
			public enum All
			{
				// GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
				DetailTexture2d = unchecked((int)32917),
				// GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
				DetailTexture2dBinding = unchecked((int)32918),
				// GL_LINEAR_DETAIL_SGIS = 0x8097
				LinearDetail = unchecked((int)32919),
				// GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
				LinearDetailAlpha = unchecked((int)32920),
				// GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
				LinearDetailColor = unchecked((int)32921),
				// GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
				DetailTextureLevel = unchecked((int)32922),
				// GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
				DetailTextureMode = unchecked((int)32923),
				// GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
				DetailTextureFuncPoints = unchecked((int)32924),
			}
			public const string NAME_STRING = "GL_SGIS_detail_texture";
			#region command delegates
			// void glDetailTexFuncSGIS (GLenum target, GLsizei n, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DetailTexFuncDelegate (TextureTarget target, System.Int32 n, IntPtr points);
			// void glGetDetailTexFuncSGIS (GLenum target, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetDetailTexFuncDelegate (TextureTarget target, IntPtr points);
			#endregion // command delegates
			#region commands
			// void glDetailTexFuncSGIS (GLenum target, GLsizei n, GLfloat* points)
			public readonly DetailTexFuncDelegate DetailTexFunc;
			// void glGetDetailTexFuncSGIS (GLenum target, GLfloat* points)
			public readonly GetDetailTexFuncDelegate GetDetailTexFunc;
			#endregion // commands
			public SgisDetailTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDetailTexFuncSGIS", out DetailTexFunc);
				resolver.LoadHandle ("glGetDetailTexFuncSGIS", out GetDetailTexFunc);
			}
		}
		public partial class SgisFogFunction
		{
			public enum All
			{
				// GL_FOG_FUNC_SGIS = 0x812A
				FogFunc = unchecked((int)33066),
				// GL_FOG_FUNC_POINTS_SGIS = 0x812B
				FogFuncPoints = unchecked((int)33067),
				// GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
				MaxFogFuncPoints = unchecked((int)33068),
			}
			public const string NAME_STRING = "GL_SGIS_fog_function";
			#region command delegates
			// void glFogFuncSGIS (GLsizei n, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogFuncDelegate (System.Int32 n, IntPtr points);
			// void glGetFogFuncSGIS (GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFogFuncDelegate (IntPtr points);
			#endregion // command delegates
			#region commands
			// void glFogFuncSGIS (GLsizei n, GLfloat* points)
			public readonly FogFuncDelegate FogFunc;
			// void glGetFogFuncSGIS (GLfloat* points)
			public readonly GetFogFuncDelegate GetFogFunc;
			#endregion // commands
			public SgisFogFunction (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFogFuncSGIS", out FogFunc);
				resolver.LoadHandle ("glGetFogFuncSGIS", out GetFogFunc);
			}
		}
		public partial class SgisGenerateMipmap
		{
			public enum All
			{
				// GL_GENERATE_MIPMAP_SGIS = 0x8191
				GenerateMipmap = unchecked((int)33169),
				// GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
				GenerateMipmapHint = unchecked((int)33170),
			}
			public const string NAME_STRING = "GL_SGIS_generate_mipmap";
		}
		public partial class SgisMultisample
		{
			public enum All
			{
				// GL_MULTISAMPLE_SGIS = 0x809D
				Multisample = unchecked((int)32925),
				// GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
				SampleAlphaToMask = unchecked((int)32926),
				// GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
				SampleAlphaToOne = unchecked((int)32927),
				// GL_SAMPLE_MASK_SGIS = 0x80A0
				SampleMask = unchecked((int)32928),
				// GL_1PASS_SGIS = 0x80A1
				_1pass = unchecked((int)32929),
				// GL_2PASS_0_SGIS = 0x80A2
				_2pass0 = unchecked((int)32930),
				// GL_2PASS_1_SGIS = 0x80A3
				_2pass1 = unchecked((int)32931),
				// GL_4PASS_0_SGIS = 0x80A4
				_4pass0 = unchecked((int)32932),
				// GL_4PASS_1_SGIS = 0x80A5
				_4pass1 = unchecked((int)32933),
				// GL_4PASS_2_SGIS = 0x80A6
				_4pass2 = unchecked((int)32934),
				// GL_4PASS_3_SGIS = 0x80A7
				_4pass3 = unchecked((int)32935),
				// GL_SAMPLE_BUFFERS_SGIS = 0x80A8
				SampleBuffers = unchecked((int)32936),
				// GL_SAMPLES_SGIS = 0x80A9
				Samples = unchecked((int)32937),
				// GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
				SampleMaskValue = unchecked((int)32938),
				// GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
				SampleMaskInvert = unchecked((int)32939),
				// GL_SAMPLE_PATTERN_SGIS = 0x80AC
				SamplePattern = unchecked((int)32940),
			}
			public const string NAME_STRING = "GL_SGIS_multisample";
			#region command delegates
			// void glSampleMaskSGIS (GLclampf value, GLboolean invert)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SampleMaskDelegate (System.Single value, Boolean invert);
			// void glSamplePatternSGIS (GLenum pattern)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SamplePatternDelegate (SamplePatternSGIS pattern);
			#endregion // command delegates
			#region commands
			// void glSampleMaskSGIS (GLclampf value, GLboolean invert)
			public readonly SampleMaskDelegate SampleMask;
			// void glSamplePatternSGIS (GLenum pattern)
			public readonly SamplePatternDelegate SamplePattern;
			#endregion // commands
			public SgisMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSampleMaskSGIS", out SampleMask);
				resolver.LoadHandle ("glSamplePatternSGIS", out SamplePattern);
			}
		}
		public partial class SgisPixelTexture
		{
			public enum All
			{
				// GL_PIXEL_TEXTURE_SGIS = 0x8353
				PixelTexture = unchecked((int)33619),
				// GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
				PixelFragmentRgbSource = unchecked((int)33620),
				// GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
				PixelFragmentAlphaSource = unchecked((int)33621),
				// GL_PIXEL_GROUP_COLOR_SGIS = 0x8356
				PixelGroupColor = unchecked((int)33622),
			}
			public const string NAME_STRING = "GL_SGIS_pixel_texture";
			#region command delegates
			// void glGetPixelTexGenParameterfvSGIS (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPixelTexGenParameterfvDelegate (PixelTexGenParameterNameSGIS pname, IntPtr @params);
			// void glGetPixelTexGenParameterivSGIS (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPixelTexGenParameterivDelegate (PixelTexGenParameterNameSGIS pname, IntPtr @params);
			// void glPixelTexGenParameterfSGIS (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTexGenParameterfDelegate (PixelTexGenParameterNameSGIS pname, System.Single param);
			// void glPixelTexGenParameterfvSGIS (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTexGenParameterfvDelegate (PixelTexGenParameterNameSGIS pname, IntPtr @params);
			// void glPixelTexGenParameteriSGIS (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTexGenParameteriDelegate (PixelTexGenParameterNameSGIS pname, System.Int32 param);
			// void glPixelTexGenParameterivSGIS (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTexGenParameterivDelegate (PixelTexGenParameterNameSGIS pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetPixelTexGenParameterfvSGIS (GLenum pname, GLfloat* params)
			public readonly GetPixelTexGenParameterfvDelegate GetPixelTexGenParameterfv;
			// void glGetPixelTexGenParameterivSGIS (GLenum pname, GLint* params)
			public readonly GetPixelTexGenParameterivDelegate GetPixelTexGenParameteriv;
			// void glPixelTexGenParameterfSGIS (GLenum pname, GLfloat param)
			public readonly PixelTexGenParameterfDelegate PixelTexGenParameterf;
			// void glPixelTexGenParameterfvSGIS (GLenum pname, GLfloat* params)
			public readonly PixelTexGenParameterfvDelegate PixelTexGenParameterfv;
			// void glPixelTexGenParameteriSGIS (GLenum pname, GLint param)
			public readonly PixelTexGenParameteriDelegate PixelTexGenParameteri;
			// void glPixelTexGenParameterivSGIS (GLenum pname, GLint* params)
			public readonly PixelTexGenParameterivDelegate PixelTexGenParameteriv;
			#endregion // commands
			public SgisPixelTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetPixelTexGenParameterfvSGIS", out GetPixelTexGenParameterfv);
				resolver.LoadHandle ("glGetPixelTexGenParameterivSGIS", out GetPixelTexGenParameteriv);
				resolver.LoadHandle ("glPixelTexGenParameterfSGIS", out PixelTexGenParameterf);
				resolver.LoadHandle ("glPixelTexGenParameterfvSGIS", out PixelTexGenParameterfv);
				resolver.LoadHandle ("glPixelTexGenParameteriSGIS", out PixelTexGenParameteri);
				resolver.LoadHandle ("glPixelTexGenParameterivSGIS", out PixelTexGenParameteriv);
			}
		}
		public partial class SgisPointLineTexgen
		{
			public enum All
			{
				// GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
				EyeDistanceToPoint = unchecked((int)33264),
				// GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
				ObjectDistanceToPoint = unchecked((int)33265),
				// GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
				EyeDistanceToLine = unchecked((int)33266),
				// GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
				ObjectDistanceToLine = unchecked((int)33267),
				// GL_EYE_POINT_SGIS = 0x81F4
				EyePoint = unchecked((int)33268),
				// GL_OBJECT_POINT_SGIS = 0x81F5
				ObjectPoint = unchecked((int)33269),
				// GL_EYE_LINE_SGIS = 0x81F6
				EyeLine = unchecked((int)33270),
				// GL_OBJECT_LINE_SGIS = 0x81F7
				ObjectLine = unchecked((int)33271),
			}
			public const string NAME_STRING = "GL_SGIS_point_line_texgen";
		}
		public partial class SgisPointParameters
		{
			public enum All
			{
				// GL_POINT_SIZE_MIN_SGIS = 0x8126
				PointSizeMin = unchecked((int)33062),
				// GL_POINT_SIZE_MAX_SGIS = 0x8127
				PointSizeMax = unchecked((int)33063),
				// GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
				PointFadeThresholdSize = unchecked((int)33064),
				// GL_DISTANCE_ATTENUATION_SGIS = 0x8129
				DistanceAttenuation = unchecked((int)33065),
			}
			public const string NAME_STRING = "GL_SGIS_point_parameters";
			#region command delegates
			// void glPointParameterfSGIS (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfDelegate (System.UInt32 pname, System.Single param);
			// void glPointParameterfvSGIS (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glPointParameterfSGIS (GLenum pname, GLfloat param)
			public readonly PointParameterfDelegate PointParameterf;
			// void glPointParameterfvSGIS (GLenum pname, GLfloat* params)
			public readonly PointParameterfvDelegate PointParameterfv;
			#endregion // commands
			public SgisPointParameters (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPointParameterfSGIS", out PointParameterf);
				resolver.LoadHandle ("glPointParameterfvSGIS", out PointParameterfv);
			}
		}
		public partial class SgisSharpenTexture
		{
			public enum All
			{
				// GL_LINEAR_SHARPEN_SGIS = 0x80AD
				LinearSharpen = unchecked((int)32941),
				// GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
				LinearSharpenAlpha = unchecked((int)32942),
				// GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
				LinearSharpenColor = unchecked((int)32943),
				// GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
				SharpenTextureFuncPoints = unchecked((int)32944),
			}
			public const string NAME_STRING = "GL_SGIS_sharpen_texture";
			#region command delegates
			// void glGetSharpenTexFuncSGIS (GLenum target, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetSharpenTexFuncDelegate (TextureTarget target, IntPtr points);
			// void glSharpenTexFuncSGIS (GLenum target, GLsizei n, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SharpenTexFuncDelegate (TextureTarget target, System.Int32 n, IntPtr points);
			#endregion // command delegates
			#region commands
			// void glGetSharpenTexFuncSGIS (GLenum target, GLfloat* points)
			public readonly GetSharpenTexFuncDelegate GetSharpenTexFunc;
			// void glSharpenTexFuncSGIS (GLenum target, GLsizei n, GLfloat* points)
			public readonly SharpenTexFuncDelegate SharpenTexFunc;
			#endregion // commands
			public SgisSharpenTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetSharpenTexFuncSGIS", out GetSharpenTexFunc);
				resolver.LoadHandle ("glSharpenTexFuncSGIS", out SharpenTexFunc);
			}
		}
		public partial class SgisTexture4d
		{
			public enum All
			{
				// GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
				PackSkipVolumes = unchecked((int)33072),
				// GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
				PackImageDepth = unchecked((int)33073),
				// GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
				UnpackSkipVolumes = unchecked((int)33074),
				// GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
				UnpackImageDepth = unchecked((int)33075),
				// GL_TEXTURE_4D_SGIS = 0x8134
				Texture4d = unchecked((int)33076),
				// GL_PROXY_TEXTURE_4D_SGIS = 0x8135
				ProxyTexture4d = unchecked((int)33077),
				// GL_TEXTURE_4DSIZE_SGIS = 0x8136
				Texture4dsize = unchecked((int)33078),
				// GL_TEXTURE_WRAP_Q_SGIS = 0x8137
				TextureWrapQ = unchecked((int)33079),
				// GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
				Max4dTextureSize = unchecked((int)33080),
				// GL_TEXTURE_4D_BINDING_SGIS = 0x814F
				Texture4dBinding = unchecked((int)33103),
			}
			public const string NAME_STRING = "GL_SGIS_texture4D";
			#region command delegates
			// void glTexImage4DSGIS (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexImage4DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 size4d, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTexSubImage4DSGIS (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexSubImage4DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 woffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 size4d, PixelFormat format, PixelType type, IntPtr pixels);
			#endregion // command delegates
			#region commands
			// void glTexImage4DSGIS (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly TexImage4DDelegate TexImage4D;
			// void glTexSubImage4DSGIS (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, void* pixels)
			public readonly TexSubImage4DDelegate TexSubImage4D;
			#endregion // commands
			public SgisTexture4d (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexImage4DSGIS", out TexImage4D);
				resolver.LoadHandle ("glTexSubImage4DSGIS", out TexSubImage4D);
			}
		}
		public partial class SgisTextureBorderClamp
		{
			public enum All
			{
				// GL_CLAMP_TO_BORDER_SGIS = 0x812D
				ClampToBorder = unchecked((int)33069),
			}
			public const string NAME_STRING = "GL_SGIS_texture_border_clamp";
		}
		public partial class SgisTextureColorMask
		{
			public enum All
			{
				// GL_TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF
				TextureColorWritemask = unchecked((int)33263),
			}
			public const string NAME_STRING = "GL_SGIS_texture_color_mask";
			#region command delegates
			// void glTextureColorMaskSGIS (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureColorMaskDelegate (Boolean red, Boolean green, Boolean blue, Boolean alpha);
			#endregion // command delegates
			#region commands
			// void glTextureColorMaskSGIS (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
			public readonly TextureColorMaskDelegate TextureColorMask;
			#endregion // commands
			public SgisTextureColorMask (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTextureColorMaskSGIS", out TextureColorMask);
			}
		}
		public partial class SgisTextureEdgeClamp
		{
			public enum All
			{
				// GL_CLAMP_TO_EDGE_SGIS = 0x812F
				ClampToEdge = unchecked((int)33071),
			}
			public const string NAME_STRING = "GL_SGIS_texture_edge_clamp";
		}
		public partial class SgisTextureFilter4
		{
			public enum All
			{
				// GL_FILTER4_SGIS = 0x8146
				Filter4 = unchecked((int)33094),
				// GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
				TextureFilter4Size = unchecked((int)33095),
			}
			public const string NAME_STRING = "GL_SGIS_texture_filter4";
			#region command delegates
			// void glGetTexFilterFuncSGIS (GLenum target, GLenum filter, GLfloat* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexFilterFuncDelegate (TextureTarget target, System.UInt32 filter, IntPtr weights);
			// void glTexFilterFuncSGIS (GLenum target, GLenum filter, GLsizei n, GLfloat* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexFilterFuncDelegate (TextureTarget target, System.UInt32 filter, System.Int32 n, IntPtr weights);
			#endregion // command delegates
			#region commands
			// void glGetTexFilterFuncSGIS (GLenum target, GLenum filter, GLfloat* weights)
			public readonly GetTexFilterFuncDelegate GetTexFilterFunc;
			// void glTexFilterFuncSGIS (GLenum target, GLenum filter, GLsizei n, GLfloat* weights)
			public readonly TexFilterFuncDelegate TexFilterFunc;
			#endregion // commands
			public SgisTextureFilter4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetTexFilterFuncSGIS", out GetTexFilterFunc);
				resolver.LoadHandle ("glTexFilterFuncSGIS", out TexFilterFunc);
			}
		}
		public partial class SgisTextureLod
		{
			public enum All
			{
				// GL_TEXTURE_MIN_LOD_SGIS = 0x813A
				TextureMinLod = unchecked((int)33082),
				// GL_TEXTURE_MAX_LOD_SGIS = 0x813B
				TextureMaxLod = unchecked((int)33083),
				// GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
				TextureBaseLevel = unchecked((int)33084),
				// GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
				TextureMaxLevel = unchecked((int)33085),
			}
			public const string NAME_STRING = "GL_SGIS_texture_lod";
		}
		public partial class SgisTextureSelect
		{
			public enum All
			{
				// GL_DUAL_ALPHA4_SGIS = 0x8110
				DualAlpha4 = unchecked((int)33040),
				// GL_DUAL_ALPHA8_SGIS = 0x8111
				DualAlpha8 = unchecked((int)33041),
				// GL_DUAL_ALPHA12_SGIS = 0x8112
				DualAlpha12 = unchecked((int)33042),
				// GL_DUAL_ALPHA16_SGIS = 0x8113
				DualAlpha16 = unchecked((int)33043),
				// GL_DUAL_LUMINANCE4_SGIS = 0x8114
				DualLuminance4 = unchecked((int)33044),
				// GL_DUAL_LUMINANCE8_SGIS = 0x8115
				DualLuminance8 = unchecked((int)33045),
				// GL_DUAL_LUMINANCE12_SGIS = 0x8116
				DualLuminance12 = unchecked((int)33046),
				// GL_DUAL_LUMINANCE16_SGIS = 0x8117
				DualLuminance16 = unchecked((int)33047),
				// GL_DUAL_INTENSITY4_SGIS = 0x8118
				DualIntensity4 = unchecked((int)33048),
				// GL_DUAL_INTENSITY8_SGIS = 0x8119
				DualIntensity8 = unchecked((int)33049),
				// GL_DUAL_INTENSITY12_SGIS = 0x811A
				DualIntensity12 = unchecked((int)33050),
				// GL_DUAL_INTENSITY16_SGIS = 0x811B
				DualIntensity16 = unchecked((int)33051),
				// GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
				DualLuminanceAlpha4 = unchecked((int)33052),
				// GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
				DualLuminanceAlpha8 = unchecked((int)33053),
				// GL_QUAD_ALPHA4_SGIS = 0x811E
				QuadAlpha4 = unchecked((int)33054),
				// GL_QUAD_ALPHA8_SGIS = 0x811F
				QuadAlpha8 = unchecked((int)33055),
				// GL_QUAD_LUMINANCE4_SGIS = 0x8120
				QuadLuminance4 = unchecked((int)33056),
				// GL_QUAD_LUMINANCE8_SGIS = 0x8121
				QuadLuminance8 = unchecked((int)33057),
				// GL_QUAD_INTENSITY4_SGIS = 0x8122
				QuadIntensity4 = unchecked((int)33058),
				// GL_QUAD_INTENSITY8_SGIS = 0x8123
				QuadIntensity8 = unchecked((int)33059),
				// GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
				DualTextureSelect = unchecked((int)33060),
				// GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
				QuadTextureSelect = unchecked((int)33061),
			}
			public const string NAME_STRING = "GL_SGIS_texture_select";
		}
	}
}

