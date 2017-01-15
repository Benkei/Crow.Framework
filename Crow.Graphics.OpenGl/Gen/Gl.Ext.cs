using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class Ext422Pixels
		{
			public enum All
			{
				// GL_422_EXT = 0x80CC
				_422 = unchecked((int)32972),
				// GL_422_REV_EXT = 0x80CD
				_422Rev = unchecked((int)32973),
				// GL_422_AVERAGE_EXT = 0x80CE
				_422Average = unchecked((int)32974),
				// GL_422_REV_AVERAGE_EXT = 0x80CF
				_422RevAverage = unchecked((int)32975),
			}
			public const string NAME_STRING = "GL_EXT_422_pixels";
		}
		public partial class ExtAbgr
		{
			public enum All
			{
				// GL_ABGR_EXT = 0x8000
				Abgr = unchecked((int)32768),
			}
			public const string NAME_STRING = "GL_EXT_abgr";
		}
		public partial class ExtBgra
		{
			public enum All
			{
				// GL_BGR_EXT = 0x80E0
				Bgr = unchecked((int)32992),
				// GL_BGRA_EXT = 0x80E1
				Bgra = unchecked((int)32993),
			}
			public const string NAME_STRING = "GL_EXT_bgra";
		}
		public partial class ExtBindableUniform
		{
			public enum All
			{
				// GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2
				MaxVertexBindableUniforms = unchecked((int)36322),
				// GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3
				MaxFragmentBindableUniforms = unchecked((int)36323),
				// GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4
				MaxGeometryBindableUniforms = unchecked((int)36324),
				// GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED
				MaxBindableUniformSize = unchecked((int)36333),
				// GL_UNIFORM_BUFFER_EXT = 0x8DEE
				UniformBuffer = unchecked((int)36334),
				// GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF
				UniformBufferBinding = unchecked((int)36335),
			}
			public const string NAME_STRING = "GL_EXT_bindable_uniform";
			#region command delegates
			// GLint glGetUniformBufferSizeEXT (GLuint program, GLint location)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetUniformBufferSizeDelegate (System.UInt32 program, System.Int32 location);
			// GLintptr glGetUniformOffsetEXT (GLuint program, GLint location)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetUniformOffsetDelegate (System.UInt32 program, System.Int32 location);
			// void glUniformBufferEXT (GLuint program, GLint location, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformBufferDelegate (System.UInt32 program, System.Int32 location, System.UInt32 buffer);
			#endregion // command delegates
			#region commands
			// GLint glGetUniformBufferSizeEXT (GLuint program, GLint location)
			public readonly GetUniformBufferSizeDelegate GetUniformBufferSize;
			// GLintptr glGetUniformOffsetEXT (GLuint program, GLint location)
			public readonly GetUniformOffsetDelegate GetUniformOffset;
			// void glUniformBufferEXT (GLuint program, GLint location, GLuint buffer)
			public readonly UniformBufferDelegate UniformBuffer;
			#endregion // commands
			public ExtBindableUniform (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetUniformBufferSizeEXT", out GetUniformBufferSize);
				resolver.LoadHandle ("glGetUniformOffsetEXT", out GetUniformOffset);
				resolver.LoadHandle ("glUniformBufferEXT", out UniformBuffer);
			}
		}
		public partial class ExtBlendColor
		{
			public enum All
			{
				// GL_CONSTANT_COLOR_EXT = 0x8001
				ConstantColor = unchecked((int)32769),
				// GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002
				OneMinusConstantColor = unchecked((int)32770),
				// GL_CONSTANT_ALPHA_EXT = 0x8003
				ConstantAlpha = unchecked((int)32771),
				// GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004
				OneMinusConstantAlpha = unchecked((int)32772),
				// GL_BLEND_COLOR_EXT = 0x8005
				BlendColor = unchecked((int)32773),
			}
			public const string NAME_STRING = "GL_EXT_blend_color";
			#region command delegates
			// void glBlendColorEXT (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendColorDelegate (System.Single red, System.Single green, System.Single blue, System.Single alpha);
			#endregion // command delegates
			#region commands
			// void glBlendColorEXT (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
			public readonly BlendColorDelegate BlendColor;
			#endregion // commands
			public ExtBlendColor (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendColorEXT", out BlendColor);
			}
		}
		public partial class ExtBlendEquationSeparate
		{
			public enum All
			{
				// GL_BLEND_EQUATION_RGB_EXT = 0x8009
				BlendEquationRgb = unchecked((int)32777),
				// GL_BLEND_EQUATION_ALPHA_EXT = 0x883D
				BlendEquationAlpha = unchecked((int)34877),
			}
			public const string NAME_STRING = "GL_EXT_blend_equation_separate";
			#region command delegates
			// void glBlendEquationSeparateEXT (GLenum modeRGB, GLenum modeAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationSeparateDelegate (BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
			#endregion // command delegates
			#region commands
			// void glBlendEquationSeparateEXT (GLenum modeRGB, GLenum modeAlpha)
			public readonly BlendEquationSeparateDelegate BlendEquationSeparate;
			#endregion // commands
			public ExtBlendEquationSeparate (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendEquationSeparateEXT", out BlendEquationSeparate);
			}
		}
		public partial class ExtBlendFuncSeparate
		{
			public enum All
			{
				// GL_BLEND_DST_RGB_EXT = 0x80C8
				BlendDstRgb = unchecked((int)32968),
				// GL_BLEND_SRC_RGB_EXT = 0x80C9
				BlendSrcRgb = unchecked((int)32969),
				// GL_BLEND_DST_ALPHA_EXT = 0x80CA
				BlendDstAlpha = unchecked((int)32970),
				// GL_BLEND_SRC_ALPHA_EXT = 0x80CB
				BlendSrcAlpha = unchecked((int)32971),
			}
			public const string NAME_STRING = "GL_EXT_blend_func_separate";
			#region command delegates
			// void glBlendFuncSeparateEXT (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFuncSeparateDelegate (System.UInt32 sfactorRGB, System.UInt32 dfactorRGB, System.UInt32 sfactorAlpha, System.UInt32 dfactorAlpha);
			#endregion // command delegates
			#region commands
			// void glBlendFuncSeparateEXT (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
			public readonly BlendFuncSeparateDelegate BlendFuncSeparate;
			#endregion // commands
			public ExtBlendFuncSeparate (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendFuncSeparateEXT", out BlendFuncSeparate);
			}
		}
		public partial class ExtBlendMinmax
		{
			public enum All
			{
				// GL_FUNC_ADD_EXT = 0x8006
				FuncAdd = unchecked((int)32774),
				// GL_MIN_EXT = 0x8007
				Min = unchecked((int)32775),
				// GL_MAX_EXT = 0x8008
				Max = unchecked((int)32776),
				// GL_BLEND_EQUATION_EXT = 0x8009
				BlendEquation = unchecked((int)32777),
			}
			public const string NAME_STRING = "GL_EXT_blend_minmax";
			#region command delegates
			// void glBlendEquationEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationDelegate (BlendEquationModeEXT mode);
			#endregion // command delegates
			#region commands
			// void glBlendEquationEXT (GLenum mode)
			public readonly BlendEquationDelegate BlendEquation;
			#endregion // commands
			public ExtBlendMinmax (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendEquationEXT", out BlendEquation);
			}
		}
		public partial class ExtBlendSubtract
		{
			public enum All
			{
				// GL_FUNC_SUBTRACT_EXT = 0x800A
				FuncSubtract = unchecked((int)32778),
				// GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
				FuncReverseSubtract = unchecked((int)32779),
			}
			public const string NAME_STRING = "GL_EXT_blend_subtract";
		}
		public partial class ExtClipVolumeHint
		{
			public enum All
			{
				// GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
				ClipVolumeClippingHint = unchecked((int)33008),
			}
			public const string NAME_STRING = "GL_EXT_clip_volume_hint";
		}
		public partial class ExtCmyka
		{
			public enum All
			{
				// GL_CMYK_EXT = 0x800C
				Cmyk = unchecked((int)32780),
				// GL_CMYKA_EXT = 0x800D
				Cmyka = unchecked((int)32781),
				// GL_PACK_CMYK_HINT_EXT = 0x800E
				PackCmykHint = unchecked((int)32782),
				// GL_UNPACK_CMYK_HINT_EXT = 0x800F
				UnpackCmykHint = unchecked((int)32783),
			}
			public const string NAME_STRING = "GL_EXT_cmyka";
		}
		public partial class ExtColorSubtable
		{
			public const string NAME_STRING = "GL_EXT_color_subtable";
			#region command delegates
			// void glColorSubTableEXT (GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorSubTableDelegate (System.UInt32 target, System.Int32 start, System.Int32 count, PixelFormat format, PixelType type, IntPtr data);
			// void glCopyColorSubTableEXT (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyColorSubTableDelegate (System.UInt32 target, System.Int32 start, System.Int32 x, System.Int32 y, System.Int32 width);
			#endregion // command delegates
			#region commands
			// void glColorSubTableEXT (GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data)
			public readonly ColorSubTableDelegate ColorSubTable;
			// void glCopyColorSubTableEXT (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width)
			public readonly CopyColorSubTableDelegate CopyColorSubTable;
			#endregion // commands
			public ExtColorSubtable (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorSubTableEXT", out ColorSubTable);
				resolver.LoadHandle ("glCopyColorSubTableEXT", out CopyColorSubTable);
			}
		}
		public partial class ExtCompiledVertexArray
		{
			public enum All
			{
				// GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8
				ArrayElementLockFirst = unchecked((int)33192),
				// GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9
				ArrayElementLockCount = unchecked((int)33193),
			}
			public const string NAME_STRING = "GL_EXT_compiled_vertex_array";
			#region command delegates
			// void glLockArraysEXT (GLint first, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LockArraysDelegate (System.Int32 first, System.Int32 count);
			// void glUnlockArraysEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UnlockArraysDelegate ();
			#endregion // command delegates
			#region commands
			// void glLockArraysEXT (GLint first, GLsizei count)
			public readonly LockArraysDelegate LockArrays;
			// void glUnlockArraysEXT ()
			public readonly UnlockArraysDelegate UnlockArrays;
			#endregion // commands
			public ExtCompiledVertexArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glLockArraysEXT", out LockArrays);
				resolver.LoadHandle ("glUnlockArraysEXT", out UnlockArrays);
			}
		}
		public partial class ExtConvolution
		{
			public enum All
			{
				// GL_CONVOLUTION_1D_EXT = 0x8010
				Convolution1d = unchecked((int)32784),
				// GL_CONVOLUTION_2D_EXT = 0x8011
				Convolution2d = unchecked((int)32785),
				// GL_SEPARABLE_2D_EXT = 0x8012
				Separable2d = unchecked((int)32786),
				// GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
				ConvolutionBorderMode = unchecked((int)32787),
				// GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
				ConvolutionFilterScale = unchecked((int)32788),
				// GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
				ConvolutionFilterBias = unchecked((int)32789),
				// GL_REDUCE_EXT = 0x8016
				Reduce = unchecked((int)32790),
				// GL_CONVOLUTION_FORMAT_EXT = 0x8017
				ConvolutionFormat = unchecked((int)32791),
				// GL_CONVOLUTION_WIDTH_EXT = 0x8018
				ConvolutionWidth = unchecked((int)32792),
				// GL_CONVOLUTION_HEIGHT_EXT = 0x8019
				ConvolutionHeight = unchecked((int)32793),
				// GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
				MaxConvolutionWidth = unchecked((int)32794),
				// GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
				MaxConvolutionHeight = unchecked((int)32795),
				// GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
				PostConvolutionRedScale = unchecked((int)32796),
				// GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
				PostConvolutionGreenScale = unchecked((int)32797),
				// GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
				PostConvolutionBlueScale = unchecked((int)32798),
				// GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
				PostConvolutionAlphaScale = unchecked((int)32799),
				// GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
				PostConvolutionRedBias = unchecked((int)32800),
				// GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
				PostConvolutionGreenBias = unchecked((int)32801),
				// GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
				PostConvolutionBlueBias = unchecked((int)32802),
				// GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
				PostConvolutionAlphaBias = unchecked((int)32803),
			}
			public const string NAME_STRING = "GL_EXT_convolution";
			#region command delegates
			// void glConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionFilter1DDelegate (ConvolutionTargetEXT target, System.UInt32 internalformat, System.Int32 width, PixelFormat format, PixelType type, IntPtr image);
			// void glConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionFilter2DDelegate (ConvolutionTargetEXT target, System.UInt32 internalformat, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr image);
			// void glConvolutionParameterfEXT (GLenum target, GLenum pname, GLfloat params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameterfDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, System.Single @params);
			// void glConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameterfvDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, IntPtr @params);
			// void glConvolutionParameteriEXT (GLenum target, GLenum pname, GLint params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameteriDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, System.Int32 @params);
			// void glConvolutionParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameterivDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, IntPtr @params);
			// void glCopyConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyConvolutionFilter1DDelegate (ConvolutionTargetEXT target, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width);
			// void glCopyConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyConvolutionFilter2DDelegate (ConvolutionTargetEXT target, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glGetConvolutionFilterEXT (GLenum target, GLenum format, GLenum type, void* image)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetConvolutionFilterDelegate (ConvolutionTargetEXT target, PixelFormat format, PixelType type, IntPtr image);
			// void glGetConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetConvolutionParameterfvDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, IntPtr @params);
			// void glGetConvolutionParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetConvolutionParameterivDelegate (ConvolutionTargetEXT target, ConvolutionParameterEXT pname, IntPtr @params);
			// void glGetSeparableFilterEXT (GLenum target, GLenum format, GLenum type, void* row, void* column, void* span)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetSeparableFilterDelegate (SeparableTargetEXT target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span);
			// void glSeparableFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SeparableFilter2DDelegate (SeparableTargetEXT target, System.UInt32 internalformat, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr row, IntPtr column);
			#endregion // command delegates
			#region commands
			// void glConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image)
			public readonly ConvolutionFilter1DDelegate ConvolutionFilter1D;
			// void glConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image)
			public readonly ConvolutionFilter2DDelegate ConvolutionFilter2D;
			// void glConvolutionParameterfEXT (GLenum target, GLenum pname, GLfloat params)
			public readonly ConvolutionParameterfDelegate ConvolutionParameterf;
			// void glConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly ConvolutionParameterfvDelegate ConvolutionParameterfv;
			// void glConvolutionParameteriEXT (GLenum target, GLenum pname, GLint params)
			public readonly ConvolutionParameteriDelegate ConvolutionParameteri;
			// void glConvolutionParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly ConvolutionParameterivDelegate ConvolutionParameteriv;
			// void glCopyConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
			public readonly CopyConvolutionFilter1DDelegate CopyConvolutionFilter1D;
			// void glCopyConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyConvolutionFilter2DDelegate CopyConvolutionFilter2D;
			// void glGetConvolutionFilterEXT (GLenum target, GLenum format, GLenum type, void* image)
			public readonly GetConvolutionFilterDelegate GetConvolutionFilter;
			// void glGetConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetConvolutionParameterfvDelegate GetConvolutionParameterfv;
			// void glGetConvolutionParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetConvolutionParameterivDelegate GetConvolutionParameteriv;
			// void glGetSeparableFilterEXT (GLenum target, GLenum format, GLenum type, void* row, void* column, void* span)
			public readonly GetSeparableFilterDelegate GetSeparableFilter;
			// void glSeparableFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column)
			public readonly SeparableFilter2DDelegate SeparableFilter2D;
			#endregion // commands
			public ExtConvolution (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glConvolutionFilter1DEXT", out ConvolutionFilter1D);
				resolver.LoadHandle ("glConvolutionFilter2DEXT", out ConvolutionFilter2D);
				resolver.LoadHandle ("glConvolutionParameterfEXT", out ConvolutionParameterf);
				resolver.LoadHandle ("glConvolutionParameterfvEXT", out ConvolutionParameterfv);
				resolver.LoadHandle ("glConvolutionParameteriEXT", out ConvolutionParameteri);
				resolver.LoadHandle ("glConvolutionParameterivEXT", out ConvolutionParameteriv);
				resolver.LoadHandle ("glCopyConvolutionFilter1DEXT", out CopyConvolutionFilter1D);
				resolver.LoadHandle ("glCopyConvolutionFilter2DEXT", out CopyConvolutionFilter2D);
				resolver.LoadHandle ("glGetConvolutionFilterEXT", out GetConvolutionFilter);
				resolver.LoadHandle ("glGetConvolutionParameterfvEXT", out GetConvolutionParameterfv);
				resolver.LoadHandle ("glGetConvolutionParameterivEXT", out GetConvolutionParameteriv);
				resolver.LoadHandle ("glGetSeparableFilterEXT", out GetSeparableFilter);
				resolver.LoadHandle ("glSeparableFilter2DEXT", out SeparableFilter2D);
			}
		}
		public partial class ExtCoordinateFrame
		{
			public enum All
			{
				// GL_TANGENT_ARRAY_EXT = 0x8439
				TangentArray = unchecked((int)33849),
				// GL_BINORMAL_ARRAY_EXT = 0x843A
				BinormalArray = unchecked((int)33850),
				// GL_CURRENT_TANGENT_EXT = 0x843B
				CurrentTangent = unchecked((int)33851),
				// GL_CURRENT_BINORMAL_EXT = 0x843C
				CurrentBinormal = unchecked((int)33852),
				// GL_TANGENT_ARRAY_TYPE_EXT = 0x843E
				TangentArrayType = unchecked((int)33854),
				// GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F
				TangentArrayStride = unchecked((int)33855),
				// GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440
				BinormalArrayType = unchecked((int)33856),
				// GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441
				BinormalArrayStride = unchecked((int)33857),
				// GL_TANGENT_ARRAY_POINTER_EXT = 0x8442
				TangentArrayPointer = unchecked((int)33858),
				// GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443
				BinormalArrayPointer = unchecked((int)33859),
				// GL_MAP1_TANGENT_EXT = 0x8444
				Map1Tangent = unchecked((int)33860),
				// GL_MAP2_TANGENT_EXT = 0x8445
				Map2Tangent = unchecked((int)33861),
				// GL_MAP1_BINORMAL_EXT = 0x8446
				Map1Binormal = unchecked((int)33862),
				// GL_MAP2_BINORMAL_EXT = 0x8447
				Map2Binormal = unchecked((int)33863),
			}
			public const string NAME_STRING = "GL_EXT_coordinate_frame";
			#region command delegates
			// void glBinormal3bEXT (GLbyte bx, GLbyte by, GLbyte bz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3bDelegate (System.SByte bx, System.SByte by, System.SByte bz);
			// void glBinormal3bvEXT (GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3bvDelegate (IntPtr v);
			// void glBinormal3dEXT (GLdouble bx, GLdouble by, GLdouble bz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3dDelegate (System.Double bx, System.Double by, System.Double bz);
			// void glBinormal3dvEXT (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3dvDelegate (IntPtr v);
			// void glBinormal3fEXT (GLfloat bx, GLfloat by, GLfloat bz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3fDelegate (System.Single bx, System.Single by, System.Single bz);
			// void glBinormal3fvEXT (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3fvDelegate (IntPtr v);
			// void glBinormal3iEXT (GLint bx, GLint by, GLint bz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3iDelegate (System.Int32 bx, System.Int32 by, System.Int32 bz);
			// void glBinormal3ivEXT (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3ivDelegate (IntPtr v);
			// void glBinormal3sEXT (GLshort bx, GLshort by, GLshort bz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3sDelegate (System.Int16 bx, System.Int16 by, System.Int16 bz);
			// void glBinormal3svEXT (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Binormal3svDelegate (IntPtr v);
			// void glBinormalPointerEXT (GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BinormalPointerDelegate (System.UInt32 type, System.Int32 stride, IntPtr pointer);
			// void glTangent3bEXT (GLbyte tx, GLbyte ty, GLbyte tz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3bDelegate (System.SByte tx, System.SByte ty, System.SByte tz);
			// void glTangent3bvEXT (GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3bvDelegate (IntPtr v);
			// void glTangent3dEXT (GLdouble tx, GLdouble ty, GLdouble tz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3dDelegate (System.Double tx, System.Double ty, System.Double tz);
			// void glTangent3dvEXT (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3dvDelegate (IntPtr v);
			// void glTangent3fEXT (GLfloat tx, GLfloat ty, GLfloat tz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3fDelegate (System.Single tx, System.Single ty, System.Single tz);
			// void glTangent3fvEXT (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3fvDelegate (IntPtr v);
			// void glTangent3iEXT (GLint tx, GLint ty, GLint tz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3iDelegate (System.Int32 tx, System.Int32 ty, System.Int32 tz);
			// void glTangent3ivEXT (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3ivDelegate (IntPtr v);
			// void glTangent3sEXT (GLshort tx, GLshort ty, GLshort tz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3sDelegate (System.Int16 tx, System.Int16 ty, System.Int16 tz);
			// void glTangent3svEXT (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Tangent3svDelegate (IntPtr v);
			// void glTangentPointerEXT (GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TangentPointerDelegate (System.UInt32 type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glBinormal3bEXT (GLbyte bx, GLbyte by, GLbyte bz)
			public readonly Binormal3bDelegate Binormal3b;
			// void glBinormal3bvEXT (GLbyte* v)
			public readonly Binormal3bvDelegate Binormal3bv;
			// void glBinormal3dEXT (GLdouble bx, GLdouble by, GLdouble bz)
			public readonly Binormal3dDelegate Binormal3d;
			// void glBinormal3dvEXT (GLdouble* v)
			public readonly Binormal3dvDelegate Binormal3dv;
			// void glBinormal3fEXT (GLfloat bx, GLfloat by, GLfloat bz)
			public readonly Binormal3fDelegate Binormal3f;
			// void glBinormal3fvEXT (GLfloat* v)
			public readonly Binormal3fvDelegate Binormal3fv;
			// void glBinormal3iEXT (GLint bx, GLint by, GLint bz)
			public readonly Binormal3iDelegate Binormal3i;
			// void glBinormal3ivEXT (GLint* v)
			public readonly Binormal3ivDelegate Binormal3iv;
			// void glBinormal3sEXT (GLshort bx, GLshort by, GLshort bz)
			public readonly Binormal3sDelegate Binormal3s;
			// void glBinormal3svEXT (GLshort* v)
			public readonly Binormal3svDelegate Binormal3sv;
			// void glBinormalPointerEXT (GLenum type, GLsizei stride, void* pointer)
			public readonly BinormalPointerDelegate BinormalPointer;
			// void glTangent3bEXT (GLbyte tx, GLbyte ty, GLbyte tz)
			public readonly Tangent3bDelegate Tangent3b;
			// void glTangent3bvEXT (GLbyte* v)
			public readonly Tangent3bvDelegate Tangent3bv;
			// void glTangent3dEXT (GLdouble tx, GLdouble ty, GLdouble tz)
			public readonly Tangent3dDelegate Tangent3d;
			// void glTangent3dvEXT (GLdouble* v)
			public readonly Tangent3dvDelegate Tangent3dv;
			// void glTangent3fEXT (GLfloat tx, GLfloat ty, GLfloat tz)
			public readonly Tangent3fDelegate Tangent3f;
			// void glTangent3fvEXT (GLfloat* v)
			public readonly Tangent3fvDelegate Tangent3fv;
			// void glTangent3iEXT (GLint tx, GLint ty, GLint tz)
			public readonly Tangent3iDelegate Tangent3i;
			// void glTangent3ivEXT (GLint* v)
			public readonly Tangent3ivDelegate Tangent3iv;
			// void glTangent3sEXT (GLshort tx, GLshort ty, GLshort tz)
			public readonly Tangent3sDelegate Tangent3s;
			// void glTangent3svEXT (GLshort* v)
			public readonly Tangent3svDelegate Tangent3sv;
			// void glTangentPointerEXT (GLenum type, GLsizei stride, void* pointer)
			public readonly TangentPointerDelegate TangentPointer;
			#endregion // commands
			public ExtCoordinateFrame (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBinormal3bEXT", out Binormal3b);
				resolver.LoadHandle ("glBinormal3bvEXT", out Binormal3bv);
				resolver.LoadHandle ("glBinormal3dEXT", out Binormal3d);
				resolver.LoadHandle ("glBinormal3dvEXT", out Binormal3dv);
				resolver.LoadHandle ("glBinormal3fEXT", out Binormal3f);
				resolver.LoadHandle ("glBinormal3fvEXT", out Binormal3fv);
				resolver.LoadHandle ("glBinormal3iEXT", out Binormal3i);
				resolver.LoadHandle ("glBinormal3ivEXT", out Binormal3iv);
				resolver.LoadHandle ("glBinormal3sEXT", out Binormal3s);
				resolver.LoadHandle ("glBinormal3svEXT", out Binormal3sv);
				resolver.LoadHandle ("glBinormalPointerEXT", out BinormalPointer);
				resolver.LoadHandle ("glTangent3bEXT", out Tangent3b);
				resolver.LoadHandle ("glTangent3bvEXT", out Tangent3bv);
				resolver.LoadHandle ("glTangent3dEXT", out Tangent3d);
				resolver.LoadHandle ("glTangent3dvEXT", out Tangent3dv);
				resolver.LoadHandle ("glTangent3fEXT", out Tangent3f);
				resolver.LoadHandle ("glTangent3fvEXT", out Tangent3fv);
				resolver.LoadHandle ("glTangent3iEXT", out Tangent3i);
				resolver.LoadHandle ("glTangent3ivEXT", out Tangent3iv);
				resolver.LoadHandle ("glTangent3sEXT", out Tangent3s);
				resolver.LoadHandle ("glTangent3svEXT", out Tangent3sv);
				resolver.LoadHandle ("glTangentPointerEXT", out TangentPointer);
			}
		}
		public partial class ExtCopyTexture
		{
			public const string NAME_STRING = "GL_EXT_copy_texture";
			#region command delegates
			// void glCopyTexImage1DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTexImage1DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 border);
			// void glCopyTexImage2DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTexImage2DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 border);
			// void glCopyTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width);
			// void glCopyTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glCopyTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			#endregion // command delegates
			#region commands
			// void glCopyTexImage1DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			public readonly CopyTexImage1DDelegate CopyTexImage1D;
			// void glCopyTexImage2DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			public readonly CopyTexImage2DDelegate CopyTexImage2D;
			// void glCopyTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			public readonly CopyTexSubImage1DDelegate CopyTexSubImage1D;
			// void glCopyTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyTexSubImage2DDelegate CopyTexSubImage2D;
			// void glCopyTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyTexSubImage3DDelegate CopyTexSubImage3D;
			#endregion // commands
			public ExtCopyTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCopyTexImage1DEXT", out CopyTexImage1D);
				resolver.LoadHandle ("glCopyTexImage2DEXT", out CopyTexImage2D);
				resolver.LoadHandle ("glCopyTexSubImage1DEXT", out CopyTexSubImage1D);
				resolver.LoadHandle ("glCopyTexSubImage2DEXT", out CopyTexSubImage2D);
				resolver.LoadHandle ("glCopyTexSubImage3DEXT", out CopyTexSubImage3D);
			}
		}
		public partial class ExtCullVertex
		{
			public enum All
			{
				// GL_CULL_VERTEX_EXT = 0x81AA
				CullVertex = unchecked((int)33194),
				// GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB
				CullVertexEyePosition = unchecked((int)33195),
				// GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC
				CullVertexObjectPosition = unchecked((int)33196),
			}
			public const string NAME_STRING = "GL_EXT_cull_vertex";
			#region command delegates
			// void glCullParameterdvEXT (GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CullParameterdvDelegate (System.UInt32 pname, IntPtr @params);
			// void glCullParameterfvEXT (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CullParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glCullParameterdvEXT (GLenum pname, GLdouble* params)
			public readonly CullParameterdvDelegate CullParameterdv;
			// void glCullParameterfvEXT (GLenum pname, GLfloat* params)
			public readonly CullParameterfvDelegate CullParameterfv;
			#endregion // commands
			public ExtCullVertex (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCullParameterdvEXT", out CullParameterdv);
				resolver.LoadHandle ("glCullParameterfvEXT", out CullParameterfv);
			}
		}
		public partial class ExtDebugLabel
		{
			public enum All
			{
				// GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F
				ProgramPipelineObject = unchecked((int)35407),
				// GL_PROGRAM_OBJECT_EXT = 0x8B40
				ProgramObject = unchecked((int)35648),
				// GL_SHADER_OBJECT_EXT = 0x8B48
				ShaderObject = unchecked((int)35656),
				// GL_BUFFER_OBJECT_EXT = 0x9151
				BufferObject = unchecked((int)37201),
				// GL_QUERY_OBJECT_EXT = 0x9153
				QueryObject = unchecked((int)37203),
				// GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154
				VertexArrayObject = unchecked((int)37204),
			}
			public const string NAME_STRING = "GL_EXT_debug_label";
			#region command delegates
			// void glGetObjectLabelEXT (GLenum type, GLuint object, GLsizei bufSize, GLsizei* length, GLchar* label)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectLabelDelegate (System.UInt32 type, System.UInt32 @object, System.Int32 bufSize, IntPtr length, StringPtr label);
			// void glLabelObjectEXT (GLenum type, GLuint object, GLsizei length, GLchar* label)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LabelObjectDelegate (System.UInt32 type, System.UInt32 @object, System.Int32 length, IntPtr label);
			#endregion // command delegates
			#region commands
			// void glGetObjectLabelEXT (GLenum type, GLuint object, GLsizei bufSize, GLsizei* length, GLchar* label)
			public readonly GetObjectLabelDelegate GetObjectLabel;
			// void glLabelObjectEXT (GLenum type, GLuint object, GLsizei length, GLchar* label)
			public readonly LabelObjectDelegate LabelObject;
			#endregion // commands
			public ExtDebugLabel (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetObjectLabelEXT", out GetObjectLabel);
				resolver.LoadHandle ("glLabelObjectEXT", out LabelObject);
			}
		}
		public partial class ExtDebugMarker
		{
			public const string NAME_STRING = "GL_EXT_debug_marker";
			#region command delegates
			// void glInsertEventMarkerEXT (GLsizei length, GLchar* marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void InsertEventMarkerDelegate (System.Int32 length, IntPtr marker);
			// void glPopGroupMarkerEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PopGroupMarkerDelegate ();
			// void glPushGroupMarkerEXT (GLsizei length, GLchar* marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PushGroupMarkerDelegate (System.Int32 length, IntPtr marker);
			#endregion // command delegates
			#region commands
			// void glInsertEventMarkerEXT (GLsizei length, GLchar* marker)
			public readonly InsertEventMarkerDelegate InsertEventMarker;
			// void glPopGroupMarkerEXT ()
			public readonly PopGroupMarkerDelegate PopGroupMarker;
			// void glPushGroupMarkerEXT (GLsizei length, GLchar* marker)
			public readonly PushGroupMarkerDelegate PushGroupMarker;
			#endregion // commands
			public ExtDebugMarker (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glInsertEventMarkerEXT", out InsertEventMarker);
				resolver.LoadHandle ("glPopGroupMarkerEXT", out PopGroupMarker);
				resolver.LoadHandle ("glPushGroupMarkerEXT", out PushGroupMarker);
			}
		}
		public partial class ExtDepthBoundsTest
		{
			public enum All
			{
				// GL_DEPTH_BOUNDS_TEST_EXT = 0x8890
				DepthBoundsTest = unchecked((int)34960),
				// GL_DEPTH_BOUNDS_EXT = 0x8891
				DepthBounds = unchecked((int)34961),
			}
			public const string NAME_STRING = "GL_EXT_depth_bounds_test";
			#region command delegates
			// void glDepthBoundsEXT (GLclampd zmin, GLclampd zmax)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DepthBoundsDelegate (System.Double zmin, System.Double zmax);
			#endregion // command delegates
			#region commands
			// void glDepthBoundsEXT (GLclampd zmin, GLclampd zmax)
			public readonly DepthBoundsDelegate DepthBounds;
			#endregion // commands
			public ExtDepthBoundsTest (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDepthBoundsEXT", out DepthBounds);
			}
		}
		public partial class ExtDirectStateAccess
		{
			public enum All
			{
				// GL_PROGRAM_MATRIX_EXT = 0x8E2D
				ProgramMatrix = unchecked((int)36397),
				// GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E
				TransposeProgramMatrix = unchecked((int)36398),
				// GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F
				ProgramMatrixStackDepth = unchecked((int)36399),
			}
			public const string NAME_STRING = "GL_EXT_direct_state_access";
			#region command delegates
			// void glBindMultiTextureEXT (GLenum texunit, GLenum target, GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindMultiTextureDelegate (System.UInt32 texunit, TextureTarget target, System.UInt32 texture);
			// GLenum glCheckNamedFramebufferStatusEXT (GLuint framebuffer, GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 CheckNamedFramebufferStatusDelegate (System.UInt32 framebuffer, System.UInt32 target);
			// void glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearNamedBufferDataDelegate (System.UInt32 buffer, System.UInt32 internalformat, PixelFormat format, PixelType type, IntPtr data);
			// void glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLsizeiptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearNamedBufferSubDataDelegate (System.UInt32 buffer, System.UInt32 internalformat, System.IntPtr offset, System.IntPtr size, PixelFormat format, PixelType type, IntPtr data);
			// void glClientAttribDefaultEXT (GLbitfield mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClientAttribDefaultDelegate (ClientAttribMask mask);
			// void glCompressedMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexImage3DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexSubImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCompressedMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexSubImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCompressedMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedMultiTexSubImage3DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureImage3DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureSubImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureSubImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCompressedTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTextureSubImage3DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, System.Int32 imageSize, IntPtr bits);
			// void glCopyMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyMultiTexImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 border);
			// void glCopyMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyMultiTexImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 border);
			// void glCopyMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyMultiTexSubImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width);
			// void glCopyMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyMultiTexSubImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glCopyMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyMultiTexSubImage3DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glCopyTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTextureImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 border);
			// void glCopyTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTextureImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 border);
			// void glCopyTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTextureSubImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width);
			// void glCopyTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTextureSubImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glCopyTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyTextureSubImage3DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			// void glDisableClientStateiEXT (GLenum array, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableClientStateiDelegate (EnableCap array, System.UInt32 index);
			// void glDisableClientStateIndexedEXT (GLenum array, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableClientStateIndexedDelegate (EnableCap array, System.UInt32 index);
			// void glDisableIndexedEXT (GLenum target, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableIndexedDelegate (System.UInt32 target, System.UInt32 index);
			// void glDisableVertexArrayAttribEXT (GLuint vaobj, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableVertexArrayAttribDelegate (System.UInt32 vaobj, System.UInt32 index);
			// void glDisableVertexArrayEXT (GLuint vaobj, GLenum array)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableVertexArrayDelegate (System.UInt32 vaobj, EnableCap array);
			// void glEnableClientStateiEXT (GLenum array, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableClientStateiDelegate (EnableCap array, System.UInt32 index);
			// void glEnableClientStateIndexedEXT (GLenum array, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableClientStateIndexedDelegate (EnableCap array, System.UInt32 index);
			// void glEnableIndexedEXT (GLenum target, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableIndexedDelegate (System.UInt32 target, System.UInt32 index);
			// void glEnableVertexArrayAttribEXT (GLuint vaobj, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableVertexArrayAttribDelegate (System.UInt32 vaobj, System.UInt32 index);
			// void glEnableVertexArrayEXT (GLuint vaobj, GLenum array)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableVertexArrayDelegate (System.UInt32 vaobj, EnableCap array);
			// void glFlushMappedNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushMappedNamedBufferRangeDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr length);
			// void glFramebufferDrawBufferEXT (GLuint framebuffer, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferDrawBufferDelegate (System.UInt32 framebuffer, DrawBufferMode mode);
			// void glFramebufferDrawBuffersEXT (GLuint framebuffer, GLsizei n, GLenum* bufs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferDrawBuffersDelegate (System.UInt32 framebuffer, System.Int32 n, DrawBufferMode bufs);
			// void glFramebufferReadBufferEXT (GLuint framebuffer, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferReadBufferDelegate (System.UInt32 framebuffer, ReadBufferMode mode);
			// void glGenerateMultiTexMipmapEXT (GLenum texunit, GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenerateMultiTexMipmapDelegate (System.UInt32 texunit, TextureTarget target);
			// void glGenerateTextureMipmapEXT (GLuint texture, GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenerateTextureMipmapDelegate (System.UInt32 texture, TextureTarget target);
			// void glGetBooleanIndexedvEXT (GLenum target, GLuint index, GLboolean* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetBooleanIndexedvDelegate (System.UInt32 target, System.UInt32 index, Boolean data);
			// void glGetCompressedMultiTexImageEXT (GLenum texunit, GLenum target, GLint lod, void* img)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCompressedMultiTexImageDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 lod, IntPtr img);
			// void glGetCompressedTextureImageEXT (GLuint texture, GLenum target, GLint lod, void* img)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCompressedTextureImageDelegate (System.UInt32 texture, TextureTarget target, System.Int32 lod, IntPtr img);
			// void glGetDoublei_vEXT (GLenum pname, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetDoublei_vDelegate (System.UInt32 pname, System.UInt32 index, IntPtr @params);
			// void glGetDoubleIndexedvEXT (GLenum target, GLuint index, GLdouble* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetDoubleIndexedvDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
			// void glGetFloati_vEXT (GLenum pname, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFloati_vDelegate (System.UInt32 pname, System.UInt32 index, IntPtr @params);
			// void glGetFloatIndexedvEXT (GLenum target, GLuint index, GLfloat* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFloatIndexedvDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
			// void glGetFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFramebufferParameterivDelegate (System.UInt32 framebuffer, System.UInt32 pname, IntPtr @params);
			// void glGetIntegerIndexedvEXT (GLenum target, GLuint index, GLint* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetIntegerIndexedvDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
			// void glGetMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexEnvfvDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
			// void glGetMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexEnvivDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
			// void glGetMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexGendvDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glGetMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexGenfvDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glGetMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexGenivDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glGetMultiTexImageEXT (GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexImageDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, PixelFormat format, PixelType type, IntPtr pixels);
			// void glGetMultiTexLevelParameterfvEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexLevelParameterfvDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
			// void glGetMultiTexLevelParameterivEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexLevelParameterivDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
			// void glGetMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexParameterfvDelegate (System.UInt32 texunit, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexParameterIivDelegate (System.UInt32 texunit, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexParameterIuivDelegate (System.UInt32 texunit, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultiTexParameterivDelegate (System.UInt32 texunit, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetNamedBufferParameterivEXT (GLuint buffer, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedBufferParameterivDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
			// void glGetNamedBufferPointervEXT (GLuint buffer, GLenum pname, void** params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedBufferPointervDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
			// void glGetNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedBufferSubDataDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, IntPtr data);
			// void glGetNamedFramebufferAttachmentParameterivEXT (GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedFramebufferAttachmentParameterivDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 pname, IntPtr @params);
			// void glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedFramebufferParameterivDelegate (System.UInt32 framebuffer, System.UInt32 pname, IntPtr @params);
			// void glGetNamedProgramivEXT (GLuint program, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetNamedProgramLocalParameterdvEXT (GLuint program, GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramLocalParameterdvDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetNamedProgramLocalParameterfvEXT (GLuint program, GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramLocalParameterfvDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetNamedProgramLocalParameterIivEXT (GLuint program, GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramLocalParameterIivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetNamedProgramLocalParameterIuivEXT (GLuint program, GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramLocalParameterIuivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetNamedProgramStringEXT (GLuint program, GLenum target, GLenum pname, void* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedProgramStringDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 pname, IntPtr @string);
			// void glGetNamedRenderbufferParameterivEXT (GLuint renderbuffer, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedRenderbufferParameterivDelegate (System.UInt32 renderbuffer, System.UInt32 pname, IntPtr @params);
			// void glGetPointeri_vEXT (GLenum pname, GLuint index, void** params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPointeri_vDelegate (System.UInt32 pname, System.UInt32 index, IntPtr @params);
			// void glGetPointerIndexedvEXT (GLenum target, GLuint index, void** data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPointerIndexedvDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
			// void glGetTextureImageEXT (GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureImageDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, PixelFormat format, PixelType type, IntPtr pixels);
			// void glGetTextureLevelParameterfvEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureLevelParameterfvDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
			// void glGetTextureLevelParameterivEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureLevelParameterivDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
			// void glGetTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureParameterfvDelegate (System.UInt32 texture, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureParameterIivDelegate (System.UInt32 texture, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureParameterIuivDelegate (System.UInt32 texture, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTextureParameterivDelegate (System.UInt32 texture, TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetVertexArrayIntegeri_vEXT (GLuint vaobj, GLuint index, GLenum pname, GLint* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexArrayIntegeri_vDelegate (System.UInt32 vaobj, System.UInt32 index, System.UInt32 pname, IntPtr param);
			// void glGetVertexArrayIntegervEXT (GLuint vaobj, GLenum pname, GLint* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexArrayIntegervDelegate (System.UInt32 vaobj, System.UInt32 pname, IntPtr param);
			// void glGetVertexArrayPointeri_vEXT (GLuint vaobj, GLuint index, GLenum pname, void** param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexArrayPointeri_vDelegate (System.UInt32 vaobj, System.UInt32 index, System.UInt32 pname, IntPtr param);
			// void glGetVertexArrayPointervEXT (GLuint vaobj, GLenum pname, void** param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexArrayPointervDelegate (System.UInt32 vaobj, System.UInt32 pname, IntPtr param);
			// GLboolean glIsEnabledIndexedEXT (GLenum target, GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsEnabledIndexedDelegate (System.UInt32 target, System.UInt32 index);
			// void* glMapNamedBufferEXT (GLuint buffer, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr MapNamedBufferDelegate (System.UInt32 buffer, System.UInt32 access);
			// void* glMapNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr MapNamedBufferRangeDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr length, System.UInt32 access);
			// void glMatrixFrustumEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixFrustumDelegate (MatrixMode mode, System.Double left, System.Double right, System.Double bottom, System.Double top, System.Double zNear, System.Double zFar);
			// void glMatrixLoaddEXT (GLenum mode, GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoaddDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixLoadfEXT (GLenum mode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoadfDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixLoadIdentityEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoadIdentityDelegate (MatrixMode mode);
			// void glMatrixLoadTransposedEXT (GLenum mode, GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoadTransposedDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixLoadTransposefEXT (GLenum mode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoadTransposefDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixMultdEXT (GLenum mode, GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMultdDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixMultfEXT (GLenum mode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMultfDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixMultTransposedEXT (GLenum mode, GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMultTransposedDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixMultTransposefEXT (GLenum mode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMultTransposefDelegate (MatrixMode mode, IntPtr m);
			// void glMatrixOrthoEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixOrthoDelegate (MatrixMode mode, System.Double left, System.Double right, System.Double bottom, System.Double top, System.Double zNear, System.Double zFar);
			// void glMatrixPopEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixPopDelegate (MatrixMode mode);
			// void glMatrixPushEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixPushDelegate (MatrixMode mode);
			// void glMatrixRotatedEXT (GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixRotatedDelegate (MatrixMode mode, System.Double angle, System.Double x, System.Double y, System.Double z);
			// void glMatrixRotatefEXT (GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixRotatefDelegate (MatrixMode mode, System.Single angle, System.Single x, System.Single y, System.Single z);
			// void glMatrixScaledEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixScaledDelegate (MatrixMode mode, System.Double x, System.Double y, System.Double z);
			// void glMatrixScalefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixScalefDelegate (MatrixMode mode, System.Single x, System.Single y, System.Single z);
			// void glMatrixTranslatedEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixTranslatedDelegate (MatrixMode mode, System.Double x, System.Double y, System.Double z);
			// void glMatrixTranslatefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixTranslatefDelegate (MatrixMode mode, System.Single x, System.Single y, System.Single z);
			// void glMultiTexBufferEXT (GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexBufferDelegate (System.UInt32 texunit, TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer);
			// void glMultiTexCoordPointerEXT (GLenum texunit, GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoordPointerDelegate (System.UInt32 texunit, System.Int32 size, TexCoordPointerType type, System.Int32 stride, IntPtr pointer);
			// void glMultiTexEnvfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexEnvfDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, System.Single param);
			// void glMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexEnvfvDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
			// void glMultiTexEnviEXT (GLenum texunit, GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexEnviDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, System.Int32 param);
			// void glMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexEnvivDelegate (System.UInt32 texunit, TextureEnvTarget target, TextureEnvParameter pname, IntPtr @params);
			// void glMultiTexGendEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGendDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, System.Double param);
			// void glMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGendvDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glMultiTexGenfEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGenfDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, System.Single param);
			// void glMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGenfvDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glMultiTexGeniEXT (GLenum texunit, GLenum coord, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGeniDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, System.Int32 param);
			// void glMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexGenivDelegate (System.UInt32 texunit, TextureCoordName coord, TextureGenParameter pname, IntPtr @params);
			// void glMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexImage3DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glMultiTexParameterfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameterfDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, System.Single param);
			// void glMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameterfvDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glMultiTexParameteriEXT (GLenum texunit, GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameteriDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, System.Int32 param);
			// void glMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameterIivDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameterIuivDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexParameterivDelegate (System.UInt32 texunit, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glMultiTexRenderbufferEXT (GLenum texunit, GLenum target, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexRenderbufferDelegate (System.UInt32 texunit, TextureTarget target, System.UInt32 renderbuffer);
			// void glMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexSubImage1DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, PixelType type, IntPtr pixels);
			// void glMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexSubImage2DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr pixels);
			// void glMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexSubImage3DDelegate (System.UInt32 texunit, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, PixelType type, IntPtr pixels);
			// void glNamedBufferDataEXT (GLuint buffer, GLsizeiptr size, void* data, GLenum usage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedBufferDataDelegate (System.UInt32 buffer, System.IntPtr size, IntPtr data, System.UInt32 usage);
			// void glNamedBufferStorageEXT (GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedBufferStorageDelegate (System.UInt32 buffer, System.IntPtr size, IntPtr data, System.UInt32 flags);
			// void glNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedBufferSubDataDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, IntPtr data);
			// void glNamedCopyBufferSubDataEXT (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedCopyBufferSubDataDelegate (System.UInt32 readBuffer, System.UInt32 writeBuffer, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size);
			// void glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferParameteriDelegate (System.UInt32 framebuffer, System.UInt32 pname, System.Int32 param);
			// void glNamedFramebufferRenderbufferEXT (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferRenderbufferDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 renderbuffertarget, System.UInt32 renderbuffer);
			// void glNamedFramebufferTexture1DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTexture1DDelegate (System.UInt32 framebuffer, System.UInt32 attachment, TextureTarget textarget, System.UInt32 texture, System.Int32 level);
			// void glNamedFramebufferTexture2DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTexture2DDelegate (System.UInt32 framebuffer, System.UInt32 attachment, TextureTarget textarget, System.UInt32 texture, System.Int32 level);
			// void glNamedFramebufferTexture3DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTexture3DDelegate (System.UInt32 framebuffer, System.UInt32 attachment, TextureTarget textarget, System.UInt32 texture, System.Int32 level, System.Int32 zoffset);
			// void glNamedFramebufferTextureFaceEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTextureFaceDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, TextureTarget face);
			// void glNamedFramebufferTextureEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTextureDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 texture, System.Int32 level);
			// void glNamedFramebufferTextureLayerEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferTextureLayerDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer);
			// void glNamedProgramLocalParameter4dEXT (GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameter4dDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glNamedProgramLocalParameter4dvEXT (GLuint program, GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameter4dvDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glNamedProgramLocalParameter4fEXT (GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameter4fDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glNamedProgramLocalParameter4fvEXT (GLuint program, GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameter4fvDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glNamedProgramLocalParameterI4iEXT (GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameterI4iDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glNamedProgramLocalParameterI4ivEXT (GLuint program, GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameterI4ivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glNamedProgramLocalParameterI4uiEXT (GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameterI4uiDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w);
			// void glNamedProgramLocalParameterI4uivEXT (GLuint program, GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameterI4uivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glNamedProgramLocalParameters4fvEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParameters4fvDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glNamedProgramLocalParametersI4ivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParametersI4ivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glNamedProgramLocalParametersI4uivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramLocalParametersI4uivDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glNamedProgramStringEXT (GLuint program, GLenum target, GLenum format, GLsizei len, void* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedProgramStringDelegate (System.UInt32 program, System.UInt32 target, System.UInt32 format, System.Int32 len, IntPtr @string);
			// void glNamedRenderbufferStorageEXT (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedRenderbufferStorageDelegate (System.UInt32 renderbuffer, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			// void glNamedRenderbufferStorageMultisampleCoverageEXT (GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedRenderbufferStorageMultisampleCoverageDelegate (System.UInt32 renderbuffer, System.Int32 coverageSamples, System.Int32 colorSamples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			// void glNamedRenderbufferStorageMultisampleEXT (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedRenderbufferStorageMultisampleDelegate (System.UInt32 renderbuffer, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			// void glProgramUniform1dEXT (GLuint program, GLint location, GLdouble x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1dDelegate (System.UInt32 program, System.Int32 location, System.Double x);
			// void glProgramUniform1dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform1fEXT (GLuint program, GLint location, GLfloat v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1fDelegate (System.UInt32 program, System.Int32 location, System.Single v0);
			// void glProgramUniform1fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform1iEXT (GLuint program, GLint location, GLint v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0);
			// void glProgramUniform1ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform1uiEXT (GLuint program, GLint location, GLuint v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0);
			// void glProgramUniform1uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2dEXT (GLuint program, GLint location, GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2dDelegate (System.UInt32 program, System.Int32 location, System.Double x, System.Double y);
			// void glProgramUniform2dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1);
			// void glProgramUniform2fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2iEXT (GLuint program, GLint location, GLint v0, GLint v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1);
			// void glProgramUniform2ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1);
			// void glProgramUniform2uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3dDelegate (System.UInt32 program, System.Int32 location, System.Double x, System.Double y, System.Double z);
			// void glProgramUniform3dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1, System.Single v2);
			// void glProgramUniform3fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2);
			// void glProgramUniform3ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2);
			// void glProgramUniform3uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4dDelegate (System.UInt32 program, System.Int32 location, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glProgramUniform4dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1, System.Single v2, System.Single v3);
			// void glProgramUniform4fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3);
			// void glProgramUniform4ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2, System.UInt32 v3);
			// void glProgramUniform4uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniformMatrix2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix2x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2x3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix2x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2x3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix2x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2x4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix2x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix2x4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3x2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3x2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3x4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix3x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix3x4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4x2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4x2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4x3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glProgramUniformMatrix4x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformMatrix4x3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glPushClientAttribDefaultEXT (GLbitfield mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PushClientAttribDefaultDelegate (ClientAttribMask mask);
			// void glTextureBufferEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureBufferDelegate (System.UInt32 texture, TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer);
			// void glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureBufferRangeDelegate (System.UInt32 texture, TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
			// void glTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage3DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTexturePageCommitmentEXT (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexturePageCommitmentDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.Boolean commit);
			// void glTextureParameterfEXT (GLuint texture, GLenum target, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameterfDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, System.Single param);
			// void glTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameterfvDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glTextureParameteriEXT (GLuint texture, GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameteriDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, System.Int32 param);
			// void glTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameterIivDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameterIuivDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureParameterivDelegate (System.UInt32 texture, TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glTextureRenderbufferEXT (GLuint texture, GLenum target, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureRenderbufferDelegate (System.UInt32 texture, TextureTarget target, System.UInt32 renderbuffer);
			// void glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorage1DDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width);
			// void glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorage2DDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			// void glTextureStorage2DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorage2DMultisampleDelegate (System.UInt32 texture, TextureTarget target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, Boolean fixedsamplelocations);
			// void glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorage3DDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth);
			// void glTextureStorage3DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorage3DMultisampleDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedsamplelocations);
			// void glTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureSubImage1DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureSubImage2DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureSubImage3DDelegate (System.UInt32 texture, TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, PixelType type, IntPtr pixels);
			// GLboolean glUnmapNamedBufferEXT (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean UnmapNamedBufferDelegate (System.UInt32 buffer);
			// void glVertexArrayBindVertexBufferEXT (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayBindVertexBufferDelegate (System.UInt32 vaobj, System.UInt32 bindingindex, System.UInt32 buffer, System.IntPtr offset, System.Int32 stride);
			// void glVertexArrayColorOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayColorOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.Int32 size, ColorPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayEdgeFlagOffsetEXT (GLuint vaobj, GLuint buffer, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayEdgeFlagOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayFogCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayFogCoordOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, FogCoordinatePointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayIndexOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayIndexOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, IndexPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayMultiTexCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLenum texunit, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayMultiTexCoordOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.UInt32 texunit, System.Int32 size, TexCoordPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayNormalOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayNormalOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, NormalPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArraySecondaryColorOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArraySecondaryColorOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.Int32 size, ColorPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayTexCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayTexCoordOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.Int32 size, TexCoordPointerType type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayVertexAttribBindingEXT (GLuint vaobj, GLuint attribindex, GLuint bindingindex)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribBindingDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.UInt32 bindingindex);
			// void glVertexArrayVertexAttribDivisorEXT (GLuint vaobj, GLuint index, GLuint divisor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribDivisorDelegate (System.UInt32 vaobj, System.UInt32 index, System.UInt32 divisor);
			// void glVertexArrayVertexAttribFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, Boolean normalized, System.UInt32 relativeoffset);
			// void glVertexArrayVertexAttribIFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribIFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
			// void glVertexArrayVertexAttribIOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribIOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayVertexAttribLFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribLFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
			// void glVertexArrayVertexAttribLOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribLOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayVertexAttribOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexAttribOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.UInt32 index, System.Int32 size, System.UInt32 type, System.Boolean normalized, System.Int32 stride, System.IntPtr offset);
			// void glVertexArrayVertexBindingDivisorEXT (GLuint vaobj, GLuint bindingindex, GLuint divisor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexBindingDivisorDelegate (System.UInt32 vaobj, System.UInt32 bindingindex, System.UInt32 divisor);
			// void glVertexArrayVertexOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayVertexOffsetDelegate (System.UInt32 vaobj, System.UInt32 buffer, System.Int32 size, VertexPointerType type, System.Int32 stride, System.IntPtr offset);
			#endregion // command delegates
			#region commands
			// void glBindMultiTextureEXT (GLenum texunit, GLenum target, GLuint texture)
			public readonly BindMultiTextureDelegate BindMultiTexture;
			// GLenum glCheckNamedFramebufferStatusEXT (GLuint framebuffer, GLenum target)
			public readonly CheckNamedFramebufferStatusDelegate CheckNamedFramebufferStatus;
			// void glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data)
			public readonly ClearNamedBufferDataDelegate ClearNamedBufferData;
			// void glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLsizeiptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
			public readonly ClearNamedBufferSubDataDelegate ClearNamedBufferSubData;
			// void glClientAttribDefaultEXT (GLbitfield mask)
			public readonly ClientAttribDefaultDelegate ClientAttribDefault;
			// void glCompressedMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexImage1DDelegate CompressedMultiTexImage1D;
			// void glCompressedMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexImage2DDelegate CompressedMultiTexImage2D;
			// void glCompressedMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexImage3DDelegate CompressedMultiTexImage3D;
			// void glCompressedMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexSubImage1DDelegate CompressedMultiTexSubImage1D;
			// void glCompressedMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexSubImage2DDelegate CompressedMultiTexSubImage2D;
			// void glCompressedMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedMultiTexSubImage3DDelegate CompressedMultiTexSubImage3D;
			// void glCompressedTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedTextureImage1DDelegate CompressedTextureImage1D;
			// void glCompressedTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedTextureImage2DDelegate CompressedTextureImage2D;
			// void glCompressedTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits)
			public readonly CompressedTextureImage3DDelegate CompressedTextureImage3D;
			// void glCompressedTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedTextureSubImage1DDelegate CompressedTextureSubImage1D;
			// void glCompressedTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedTextureSubImage2DDelegate CompressedTextureSubImage2D;
			// void glCompressedTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits)
			public readonly CompressedTextureSubImage3DDelegate CompressedTextureSubImage3D;
			// void glCopyMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			public readonly CopyMultiTexImage1DDelegate CopyMultiTexImage1D;
			// void glCopyMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			public readonly CopyMultiTexImage2DDelegate CopyMultiTexImage2D;
			// void glCopyMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			public readonly CopyMultiTexSubImage1DDelegate CopyMultiTexSubImage1D;
			// void glCopyMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyMultiTexSubImage2DDelegate CopyMultiTexSubImage2D;
			// void glCopyMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyMultiTexSubImage3DDelegate CopyMultiTexSubImage3D;
			// void glCopyTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
			public readonly CopyTextureImage1DDelegate CopyTextureImage1D;
			// void glCopyTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
			public readonly CopyTextureImage2DDelegate CopyTextureImage2D;
			// void glCopyTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
			public readonly CopyTextureSubImage1DDelegate CopyTextureSubImage1D;
			// void glCopyTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyTextureSubImage2DDelegate CopyTextureSubImage2D;
			// void glCopyTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
			public readonly CopyTextureSubImage3DDelegate CopyTextureSubImage3D;
			// void glDisableClientStateiEXT (GLenum array, GLuint index)
			public readonly DisableClientStateiDelegate DisableClientStatei;
			// void glDisableClientStateIndexedEXT (GLenum array, GLuint index)
			public readonly DisableClientStateIndexedDelegate DisableClientStateIndexed;
			// void glDisableIndexedEXT (GLenum target, GLuint index)
			public readonly DisableIndexedDelegate DisableIndexed;
			// void glDisableVertexArrayAttribEXT (GLuint vaobj, GLuint index)
			public readonly DisableVertexArrayAttribDelegate DisableVertexArrayAttrib;
			// void glDisableVertexArrayEXT (GLuint vaobj, GLenum array)
			public readonly DisableVertexArrayDelegate DisableVertexArray;
			// void glEnableClientStateiEXT (GLenum array, GLuint index)
			public readonly EnableClientStateiDelegate EnableClientStatei;
			// void glEnableClientStateIndexedEXT (GLenum array, GLuint index)
			public readonly EnableClientStateIndexedDelegate EnableClientStateIndexed;
			// void glEnableIndexedEXT (GLenum target, GLuint index)
			public readonly EnableIndexedDelegate EnableIndexed;
			// void glEnableVertexArrayAttribEXT (GLuint vaobj, GLuint index)
			public readonly EnableVertexArrayAttribDelegate EnableVertexArrayAttrib;
			// void glEnableVertexArrayEXT (GLuint vaobj, GLenum array)
			public readonly EnableVertexArrayDelegate EnableVertexArray;
			// void glFlushMappedNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length)
			public readonly FlushMappedNamedBufferRangeDelegate FlushMappedNamedBufferRange;
			// void glFramebufferDrawBufferEXT (GLuint framebuffer, GLenum mode)
			public readonly FramebufferDrawBufferDelegate FramebufferDrawBuffer;
			// void glFramebufferDrawBuffersEXT (GLuint framebuffer, GLsizei n, GLenum* bufs)
			public readonly FramebufferDrawBuffersDelegate FramebufferDrawBuffers;
			// void glFramebufferReadBufferEXT (GLuint framebuffer, GLenum mode)
			public readonly FramebufferReadBufferDelegate FramebufferReadBuffer;
			// void glGenerateMultiTexMipmapEXT (GLenum texunit, GLenum target)
			public readonly GenerateMultiTexMipmapDelegate GenerateMultiTexMipmap;
			// void glGenerateTextureMipmapEXT (GLuint texture, GLenum target)
			public readonly GenerateTextureMipmapDelegate GenerateTextureMipmap;
			// void glGetBooleanIndexedvEXT (GLenum target, GLuint index, GLboolean* data)
			public readonly GetBooleanIndexedvDelegate GetBooleanIndexedv;
			// void glGetCompressedMultiTexImageEXT (GLenum texunit, GLenum target, GLint lod, void* img)
			public readonly GetCompressedMultiTexImageDelegate GetCompressedMultiTexImage;
			// void glGetCompressedTextureImageEXT (GLuint texture, GLenum target, GLint lod, void* img)
			public readonly GetCompressedTextureImageDelegate GetCompressedTextureImage;
			// void glGetDoublei_vEXT (GLenum pname, GLuint index, GLdouble* params)
			public readonly GetDoublei_vDelegate GetDoublei_v;
			// void glGetDoubleIndexedvEXT (GLenum target, GLuint index, GLdouble* data)
			public readonly GetDoubleIndexedvDelegate GetDoubleIndexedv;
			// void glGetFloati_vEXT (GLenum pname, GLuint index, GLfloat* params)
			public readonly GetFloati_vDelegate GetFloati_v;
			// void glGetFloatIndexedvEXT (GLenum target, GLuint index, GLfloat* data)
			public readonly GetFloatIndexedvDelegate GetFloatIndexedv;
			// void glGetFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint* params)
			public readonly GetFramebufferParameterivDelegate GetFramebufferParameteriv;
			// void glGetIntegerIndexedvEXT (GLenum target, GLuint index, GLint* data)
			public readonly GetIntegerIndexedvDelegate GetIntegerIndexedv;
			// void glGetMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			public readonly GetMultiTexEnvfvDelegate GetMultiTexEnvfv;
			// void glGetMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly GetMultiTexEnvivDelegate GetMultiTexEnviv;
			// void glGetMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble* params)
			public readonly GetMultiTexGendvDelegate GetMultiTexGendv;
			// void glGetMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat* params)
			public readonly GetMultiTexGenfvDelegate GetMultiTexGenfv;
			// void glGetMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint* params)
			public readonly GetMultiTexGenivDelegate GetMultiTexGeniv;
			// void glGetMultiTexImageEXT (GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
			public readonly GetMultiTexImageDelegate GetMultiTexImage;
			// void glGetMultiTexLevelParameterfvEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat* params)
			public readonly GetMultiTexLevelParameterfvDelegate GetMultiTexLevelParameterfv;
			// void glGetMultiTexLevelParameterivEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLint* params)
			public readonly GetMultiTexLevelParameterivDelegate GetMultiTexLevelParameteriv;
			// void glGetMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			public readonly GetMultiTexParameterfvDelegate GetMultiTexParameterfv;
			// void glGetMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly GetMultiTexParameterIivDelegate GetMultiTexParameterIiv;
			// void glGetMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint* params)
			public readonly GetMultiTexParameterIuivDelegate GetMultiTexParameterIuiv;
			// void glGetMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly GetMultiTexParameterivDelegate GetMultiTexParameteriv;
			// void glGetNamedBufferParameterivEXT (GLuint buffer, GLenum pname, GLint* params)
			public readonly GetNamedBufferParameterivDelegate GetNamedBufferParameteriv;
			// void glGetNamedBufferPointervEXT (GLuint buffer, GLenum pname, void** params)
			public readonly GetNamedBufferPointervDelegate GetNamedBufferPointerv;
			// void glGetNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
			public readonly GetNamedBufferSubDataDelegate GetNamedBufferSubData;
			// void glGetNamedFramebufferAttachmentParameterivEXT (GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params)
			public readonly GetNamedFramebufferAttachmentParameterivDelegate GetNamedFramebufferAttachmentParameteriv;
			// void glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint* params)
			public readonly GetNamedFramebufferParameterivDelegate GetNamedFramebufferParameteriv;
			// void glGetNamedProgramivEXT (GLuint program, GLenum target, GLenum pname, GLint* params)
			public readonly GetNamedProgramivDelegate GetNamedProgramiv;
			// void glGetNamedProgramLocalParameterdvEXT (GLuint program, GLenum target, GLuint index, GLdouble* params)
			public readonly GetNamedProgramLocalParameterdvDelegate GetNamedProgramLocalParameterdv;
			// void glGetNamedProgramLocalParameterfvEXT (GLuint program, GLenum target, GLuint index, GLfloat* params)
			public readonly GetNamedProgramLocalParameterfvDelegate GetNamedProgramLocalParameterfv;
			// void glGetNamedProgramLocalParameterIivEXT (GLuint program, GLenum target, GLuint index, GLint* params)
			public readonly GetNamedProgramLocalParameterIivDelegate GetNamedProgramLocalParameterIiv;
			// void glGetNamedProgramLocalParameterIuivEXT (GLuint program, GLenum target, GLuint index, GLuint* params)
			public readonly GetNamedProgramLocalParameterIuivDelegate GetNamedProgramLocalParameterIuiv;
			// void glGetNamedProgramStringEXT (GLuint program, GLenum target, GLenum pname, void* string)
			public readonly GetNamedProgramStringDelegate GetNamedProgramString;
			// void glGetNamedRenderbufferParameterivEXT (GLuint renderbuffer, GLenum pname, GLint* params)
			public readonly GetNamedRenderbufferParameterivDelegate GetNamedRenderbufferParameteriv;
			// void glGetPointeri_vEXT (GLenum pname, GLuint index, void** params)
			public readonly GetPointeri_vDelegate GetPointeri_v;
			// void glGetPointerIndexedvEXT (GLenum target, GLuint index, void** data)
			public readonly GetPointerIndexedvDelegate GetPointerIndexedv;
			// void glGetTextureImageEXT (GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
			public readonly GetTextureImageDelegate GetTextureImage;
			// void glGetTextureLevelParameterfvEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat* params)
			public readonly GetTextureLevelParameterfvDelegate GetTextureLevelParameterfv;
			// void glGetTextureLevelParameterivEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLint* params)
			public readonly GetTextureLevelParameterivDelegate GetTextureLevelParameteriv;
			// void glGetTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat* params)
			public readonly GetTextureParameterfvDelegate GetTextureParameterfv;
			// void glGetTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			public readonly GetTextureParameterIivDelegate GetTextureParameterIiv;
			// void glGetTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint* params)
			public readonly GetTextureParameterIuivDelegate GetTextureParameterIuiv;
			// void glGetTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			public readonly GetTextureParameterivDelegate GetTextureParameteriv;
			// void glGetVertexArrayIntegeri_vEXT (GLuint vaobj, GLuint index, GLenum pname, GLint* param)
			public readonly GetVertexArrayIntegeri_vDelegate GetVertexArrayIntegeri_v;
			// void glGetVertexArrayIntegervEXT (GLuint vaobj, GLenum pname, GLint* param)
			public readonly GetVertexArrayIntegervDelegate GetVertexArrayIntegerv;
			// void glGetVertexArrayPointeri_vEXT (GLuint vaobj, GLuint index, GLenum pname, void** param)
			public readonly GetVertexArrayPointeri_vDelegate GetVertexArrayPointeri_v;
			// void glGetVertexArrayPointervEXT (GLuint vaobj, GLenum pname, void** param)
			public readonly GetVertexArrayPointervDelegate GetVertexArrayPointerv;
			// GLboolean glIsEnabledIndexedEXT (GLenum target, GLuint index)
			public readonly IsEnabledIndexedDelegate IsEnabledIndexed;
			// void* glMapNamedBufferEXT (GLuint buffer, GLenum access)
			public readonly MapNamedBufferDelegate MapNamedBuffer;
			// void* glMapNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
			public readonly MapNamedBufferRangeDelegate MapNamedBufferRange;
			// void glMatrixFrustumEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
			public readonly MatrixFrustumDelegate MatrixFrustum;
			// void glMatrixLoaddEXT (GLenum mode, GLdouble* m)
			public readonly MatrixLoaddDelegate MatrixLoadd;
			// void glMatrixLoadfEXT (GLenum mode, GLfloat* m)
			public readonly MatrixLoadfDelegate MatrixLoadf;
			// void glMatrixLoadIdentityEXT (GLenum mode)
			public readonly MatrixLoadIdentityDelegate MatrixLoadIdentity;
			// void glMatrixLoadTransposedEXT (GLenum mode, GLdouble* m)
			public readonly MatrixLoadTransposedDelegate MatrixLoadTransposed;
			// void glMatrixLoadTransposefEXT (GLenum mode, GLfloat* m)
			public readonly MatrixLoadTransposefDelegate MatrixLoadTransposef;
			// void glMatrixMultdEXT (GLenum mode, GLdouble* m)
			public readonly MatrixMultdDelegate MatrixMultd;
			// void glMatrixMultfEXT (GLenum mode, GLfloat* m)
			public readonly MatrixMultfDelegate MatrixMultf;
			// void glMatrixMultTransposedEXT (GLenum mode, GLdouble* m)
			public readonly MatrixMultTransposedDelegate MatrixMultTransposed;
			// void glMatrixMultTransposefEXT (GLenum mode, GLfloat* m)
			public readonly MatrixMultTransposefDelegate MatrixMultTransposef;
			// void glMatrixOrthoEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
			public readonly MatrixOrthoDelegate MatrixOrtho;
			// void glMatrixPopEXT (GLenum mode)
			public readonly MatrixPopDelegate MatrixPop;
			// void glMatrixPushEXT (GLenum mode)
			public readonly MatrixPushDelegate MatrixPush;
			// void glMatrixRotatedEXT (GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
			public readonly MatrixRotatedDelegate MatrixRotated;
			// void glMatrixRotatefEXT (GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
			public readonly MatrixRotatefDelegate MatrixRotatef;
			// void glMatrixScaledEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z)
			public readonly MatrixScaledDelegate MatrixScaled;
			// void glMatrixScalefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z)
			public readonly MatrixScalefDelegate MatrixScalef;
			// void glMatrixTranslatedEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z)
			public readonly MatrixTranslatedDelegate MatrixTranslated;
			// void glMatrixTranslatefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z)
			public readonly MatrixTranslatefDelegate MatrixTranslatef;
			// void glMultiTexBufferEXT (GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer)
			public readonly MultiTexBufferDelegate MultiTexBuffer;
			// void glMultiTexCoordPointerEXT (GLenum texunit, GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly MultiTexCoordPointerDelegate MultiTexCoordPointer;
			// void glMultiTexEnvfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param)
			public readonly MultiTexEnvfDelegate MultiTexEnvf;
			// void glMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			public readonly MultiTexEnvfvDelegate MultiTexEnvfv;
			// void glMultiTexEnviEXT (GLenum texunit, GLenum target, GLenum pname, GLint param)
			public readonly MultiTexEnviDelegate MultiTexEnvi;
			// void glMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly MultiTexEnvivDelegate MultiTexEnviv;
			// void glMultiTexGendEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble param)
			public readonly MultiTexGendDelegate MultiTexGend;
			// void glMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble* params)
			public readonly MultiTexGendvDelegate MultiTexGendv;
			// void glMultiTexGenfEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat param)
			public readonly MultiTexGenfDelegate MultiTexGenf;
			// void glMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat* params)
			public readonly MultiTexGenfvDelegate MultiTexGenfv;
			// void glMultiTexGeniEXT (GLenum texunit, GLenum coord, GLenum pname, GLint param)
			public readonly MultiTexGeniDelegate MultiTexGeni;
			// void glMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint* params)
			public readonly MultiTexGenivDelegate MultiTexGeniv;
			// void glMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexImage1DDelegate MultiTexImage1D;
			// void glMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexImage2DDelegate MultiTexImage2D;
			// void glMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexImage3DDelegate MultiTexImage3D;
			// void glMultiTexParameterfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param)
			public readonly MultiTexParameterfDelegate MultiTexParameterf;
			// void glMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat* params)
			public readonly MultiTexParameterfvDelegate MultiTexParameterfv;
			// void glMultiTexParameteriEXT (GLenum texunit, GLenum target, GLenum pname, GLint param)
			public readonly MultiTexParameteriDelegate MultiTexParameteri;
			// void glMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly MultiTexParameterIivDelegate MultiTexParameterIiv;
			// void glMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint* params)
			public readonly MultiTexParameterIuivDelegate MultiTexParameterIuiv;
			// void glMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint* params)
			public readonly MultiTexParameterivDelegate MultiTexParameteriv;
			// void glMultiTexRenderbufferEXT (GLenum texunit, GLenum target, GLuint renderbuffer)
			public readonly MultiTexRenderbufferDelegate MultiTexRenderbuffer;
			// void glMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexSubImage1DDelegate MultiTexSubImage1D;
			// void glMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexSubImage2DDelegate MultiTexSubImage2D;
			// void glMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			public readonly MultiTexSubImage3DDelegate MultiTexSubImage3D;
			// void glNamedBufferDataEXT (GLuint buffer, GLsizeiptr size, void* data, GLenum usage)
			public readonly NamedBufferDataDelegate NamedBufferData;
			// void glNamedBufferStorageEXT (GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags)
			public readonly NamedBufferStorageDelegate NamedBufferStorage;
			// void glNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
			public readonly NamedBufferSubDataDelegate NamedBufferSubData;
			// void glNamedCopyBufferSubDataEXT (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
			public readonly NamedCopyBufferSubDataDelegate NamedCopyBufferSubData;
			// void glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param)
			public readonly NamedFramebufferParameteriDelegate NamedFramebufferParameteri;
			// void glNamedFramebufferRenderbufferEXT (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
			public readonly NamedFramebufferRenderbufferDelegate NamedFramebufferRenderbuffer;
			// void glNamedFramebufferTexture1DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			public readonly NamedFramebufferTexture1DDelegate NamedFramebufferTexture1D;
			// void glNamedFramebufferTexture2DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			public readonly NamedFramebufferTexture2DDelegate NamedFramebufferTexture2D;
			// void glNamedFramebufferTexture3DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
			public readonly NamedFramebufferTexture3DDelegate NamedFramebufferTexture3D;
			// void glNamedFramebufferTextureFaceEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face)
			public readonly NamedFramebufferTextureFaceDelegate NamedFramebufferTextureFace;
			// void glNamedFramebufferTextureEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
			public readonly NamedFramebufferTextureDelegate NamedFramebufferTexture;
			// void glNamedFramebufferTextureLayerEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
			public readonly NamedFramebufferTextureLayerDelegate NamedFramebufferTextureLayer;
			// void glNamedProgramLocalParameter4dEXT (GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly NamedProgramLocalParameter4dDelegate NamedProgramLocalParameter4d;
			// void glNamedProgramLocalParameter4dvEXT (GLuint program, GLenum target, GLuint index, GLdouble* params)
			public readonly NamedProgramLocalParameter4dvDelegate NamedProgramLocalParameter4dv;
			// void glNamedProgramLocalParameter4fEXT (GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly NamedProgramLocalParameter4fDelegate NamedProgramLocalParameter4f;
			// void glNamedProgramLocalParameter4fvEXT (GLuint program, GLenum target, GLuint index, GLfloat* params)
			public readonly NamedProgramLocalParameter4fvDelegate NamedProgramLocalParameter4fv;
			// void glNamedProgramLocalParameterI4iEXT (GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			public readonly NamedProgramLocalParameterI4iDelegate NamedProgramLocalParameterI4i;
			// void glNamedProgramLocalParameterI4ivEXT (GLuint program, GLenum target, GLuint index, GLint* params)
			public readonly NamedProgramLocalParameterI4ivDelegate NamedProgramLocalParameterI4iv;
			// void glNamedProgramLocalParameterI4uiEXT (GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			public readonly NamedProgramLocalParameterI4uiDelegate NamedProgramLocalParameterI4ui;
			// void glNamedProgramLocalParameterI4uivEXT (GLuint program, GLenum target, GLuint index, GLuint* params)
			public readonly NamedProgramLocalParameterI4uivDelegate NamedProgramLocalParameterI4uiv;
			// void glNamedProgramLocalParameters4fvEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat* params)
			public readonly NamedProgramLocalParameters4fvDelegate NamedProgramLocalParameters4fv;
			// void glNamedProgramLocalParametersI4ivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLint* params)
			public readonly NamedProgramLocalParametersI4ivDelegate NamedProgramLocalParametersI4iv;
			// void glNamedProgramLocalParametersI4uivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, GLuint* params)
			public readonly NamedProgramLocalParametersI4uivDelegate NamedProgramLocalParametersI4uiv;
			// void glNamedProgramStringEXT (GLuint program, GLenum target, GLenum format, GLsizei len, void* string)
			public readonly NamedProgramStringDelegate NamedProgramString;
			// void glNamedRenderbufferStorageEXT (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly NamedRenderbufferStorageDelegate NamedRenderbufferStorage;
			// void glNamedRenderbufferStorageMultisampleCoverageEXT (GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly NamedRenderbufferStorageMultisampleCoverageDelegate NamedRenderbufferStorageMultisampleCoverage;
			// void glNamedRenderbufferStorageMultisampleEXT (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly NamedRenderbufferStorageMultisampleDelegate NamedRenderbufferStorageMultisample;
			// void glProgramUniform1dEXT (GLuint program, GLint location, GLdouble x)
			public readonly ProgramUniform1dDelegate ProgramUniform1d;
			// void glProgramUniform1dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			public readonly ProgramUniform1dvDelegate ProgramUniform1dv;
			// void glProgramUniform1fEXT (GLuint program, GLint location, GLfloat v0)
			public readonly ProgramUniform1fDelegate ProgramUniform1f;
			// void glProgramUniform1fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			public readonly ProgramUniform1fvDelegate ProgramUniform1fv;
			// void glProgramUniform1iEXT (GLuint program, GLint location, GLint v0)
			public readonly ProgramUniform1iDelegate ProgramUniform1i;
			// void glProgramUniform1ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			public readonly ProgramUniform1ivDelegate ProgramUniform1iv;
			// void glProgramUniform1uiEXT (GLuint program, GLint location, GLuint v0)
			public readonly ProgramUniform1uiDelegate ProgramUniform1ui;
			// void glProgramUniform1uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			public readonly ProgramUniform1uivDelegate ProgramUniform1uiv;
			// void glProgramUniform2dEXT (GLuint program, GLint location, GLdouble x, GLdouble y)
			public readonly ProgramUniform2dDelegate ProgramUniform2d;
			// void glProgramUniform2dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			public readonly ProgramUniform2dvDelegate ProgramUniform2dv;
			// void glProgramUniform2fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1)
			public readonly ProgramUniform2fDelegate ProgramUniform2f;
			// void glProgramUniform2fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			public readonly ProgramUniform2fvDelegate ProgramUniform2fv;
			// void glProgramUniform2iEXT (GLuint program, GLint location, GLint v0, GLint v1)
			public readonly ProgramUniform2iDelegate ProgramUniform2i;
			// void glProgramUniform2ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			public readonly ProgramUniform2ivDelegate ProgramUniform2iv;
			// void glProgramUniform2uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1)
			public readonly ProgramUniform2uiDelegate ProgramUniform2ui;
			// void glProgramUniform2uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			public readonly ProgramUniform2uivDelegate ProgramUniform2uiv;
			// void glProgramUniform3dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z)
			public readonly ProgramUniform3dDelegate ProgramUniform3d;
			// void glProgramUniform3dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			public readonly ProgramUniform3dvDelegate ProgramUniform3dv;
			// void glProgramUniform3fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
			public readonly ProgramUniform3fDelegate ProgramUniform3f;
			// void glProgramUniform3fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			public readonly ProgramUniform3fvDelegate ProgramUniform3fv;
			// void glProgramUniform3iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
			public readonly ProgramUniform3iDelegate ProgramUniform3i;
			// void glProgramUniform3ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			public readonly ProgramUniform3ivDelegate ProgramUniform3iv;
			// void glProgramUniform3uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
			public readonly ProgramUniform3uiDelegate ProgramUniform3ui;
			// void glProgramUniform3uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			public readonly ProgramUniform3uivDelegate ProgramUniform3uiv;
			// void glProgramUniform4dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly ProgramUniform4dDelegate ProgramUniform4d;
			// void glProgramUniform4dvEXT (GLuint program, GLint location, GLsizei count, GLdouble* value)
			public readonly ProgramUniform4dvDelegate ProgramUniform4dv;
			// void glProgramUniform4fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
			public readonly ProgramUniform4fDelegate ProgramUniform4f;
			// void glProgramUniform4fvEXT (GLuint program, GLint location, GLsizei count, GLfloat* value)
			public readonly ProgramUniform4fvDelegate ProgramUniform4fv;
			// void glProgramUniform4iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
			public readonly ProgramUniform4iDelegate ProgramUniform4i;
			// void glProgramUniform4ivEXT (GLuint program, GLint location, GLsizei count, GLint* value)
			public readonly ProgramUniform4ivDelegate ProgramUniform4iv;
			// void glProgramUniform4uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
			public readonly ProgramUniform4uiDelegate ProgramUniform4ui;
			// void glProgramUniform4uivEXT (GLuint program, GLint location, GLsizei count, GLuint* value)
			public readonly ProgramUniform4uivDelegate ProgramUniform4uiv;
			// void glProgramUniformMatrix2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix2dvDelegate ProgramUniformMatrix2dv;
			// void glProgramUniformMatrix2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix2fvDelegate ProgramUniformMatrix2fv;
			// void glProgramUniformMatrix2x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix2x3dvDelegate ProgramUniformMatrix2x3dv;
			// void glProgramUniformMatrix2x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix2x3fvDelegate ProgramUniformMatrix2x3fv;
			// void glProgramUniformMatrix2x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix2x4dvDelegate ProgramUniformMatrix2x4dv;
			// void glProgramUniformMatrix2x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix2x4fvDelegate ProgramUniformMatrix2x4fv;
			// void glProgramUniformMatrix3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix3dvDelegate ProgramUniformMatrix3dv;
			// void glProgramUniformMatrix3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix3fvDelegate ProgramUniformMatrix3fv;
			// void glProgramUniformMatrix3x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix3x2dvDelegate ProgramUniformMatrix3x2dv;
			// void glProgramUniformMatrix3x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix3x2fvDelegate ProgramUniformMatrix3x2fv;
			// void glProgramUniformMatrix3x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix3x4dvDelegate ProgramUniformMatrix3x4dv;
			// void glProgramUniformMatrix3x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix3x4fvDelegate ProgramUniformMatrix3x4fv;
			// void glProgramUniformMatrix4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix4dvDelegate ProgramUniformMatrix4dv;
			// void glProgramUniformMatrix4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix4fvDelegate ProgramUniformMatrix4fv;
			// void glProgramUniformMatrix4x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix4x2dvDelegate ProgramUniformMatrix4x2dv;
			// void glProgramUniformMatrix4x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix4x2fvDelegate ProgramUniformMatrix4x2fv;
			// void glProgramUniformMatrix4x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
			public readonly ProgramUniformMatrix4x3dvDelegate ProgramUniformMatrix4x3dv;
			// void glProgramUniformMatrix4x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly ProgramUniformMatrix4x3fvDelegate ProgramUniformMatrix4x3fv;
			// void glPushClientAttribDefaultEXT (GLbitfield mask)
			public readonly PushClientAttribDefaultDelegate PushClientAttribDefault;
			// void glTextureBufferEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer)
			public readonly TextureBufferDelegate TextureBuffer;
			// void glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
			public readonly TextureBufferRangeDelegate TextureBufferRange;
			// void glTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly TextureImage1DDelegate TextureImage1D;
			// void glTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly TextureImage2DDelegate TextureImage2D;
			// void glTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly TextureImage3DDelegate TextureImage3D;
			// void glTexturePageCommitmentEXT (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit)
			public readonly TexturePageCommitmentDelegate TexturePageCommitment;
			// void glTextureParameterfEXT (GLuint texture, GLenum target, GLenum pname, GLfloat param)
			public readonly TextureParameterfDelegate TextureParameterf;
			// void glTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat* params)
			public readonly TextureParameterfvDelegate TextureParameterfv;
			// void glTextureParameteriEXT (GLuint texture, GLenum target, GLenum pname, GLint param)
			public readonly TextureParameteriDelegate TextureParameteri;
			// void glTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			public readonly TextureParameterIivDelegate TextureParameterIiv;
			// void glTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint* params)
			public readonly TextureParameterIuivDelegate TextureParameterIuiv;
			// void glTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint* params)
			public readonly TextureParameterivDelegate TextureParameteriv;
			// void glTextureRenderbufferEXT (GLuint texture, GLenum target, GLuint renderbuffer)
			public readonly TextureRenderbufferDelegate TextureRenderbuffer;
			// void glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
			public readonly TextureStorage1DDelegate TextureStorage1D;
			// void glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly TextureStorage2DDelegate TextureStorage2D;
			// void glTextureStorage2DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
			public readonly TextureStorage2DMultisampleDelegate TextureStorage2DMultisample;
			// void glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
			public readonly TextureStorage3DDelegate TextureStorage3D;
			// void glTextureStorage3DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
			public readonly TextureStorage3DMultisampleDelegate TextureStorage3DMultisample;
			// void glTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			public readonly TextureSubImage1DDelegate TextureSubImage1D;
			// void glTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			public readonly TextureSubImage2DDelegate TextureSubImage2D;
			// void glTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			public readonly TextureSubImage3DDelegate TextureSubImage3D;
			// GLboolean glUnmapNamedBufferEXT (GLuint buffer)
			public readonly UnmapNamedBufferDelegate UnmapNamedBuffer;
			// void glVertexArrayBindVertexBufferEXT (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
			public readonly VertexArrayBindVertexBufferDelegate VertexArrayBindVertexBuffer;
			// void glVertexArrayColorOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayColorOffsetDelegate VertexArrayColorOffset;
			// void glVertexArrayEdgeFlagOffsetEXT (GLuint vaobj, GLuint buffer, GLsizei stride, GLintptr offset)
			public readonly VertexArrayEdgeFlagOffsetDelegate VertexArrayEdgeFlagOffset;
			// void glVertexArrayFogCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayFogCoordOffsetDelegate VertexArrayFogCoordOffset;
			// void glVertexArrayIndexOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayIndexOffsetDelegate VertexArrayIndexOffset;
			// void glVertexArrayMultiTexCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLenum texunit, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayMultiTexCoordOffsetDelegate VertexArrayMultiTexCoordOffset;
			// void glVertexArrayNormalOffsetEXT (GLuint vaobj, GLuint buffer, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayNormalOffsetDelegate VertexArrayNormalOffset;
			// void glVertexArraySecondaryColorOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArraySecondaryColorOffsetDelegate VertexArraySecondaryColorOffset;
			// void glVertexArrayTexCoordOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayTexCoordOffsetDelegate VertexArrayTexCoordOffset;
			// void glVertexArrayVertexAttribBindingEXT (GLuint vaobj, GLuint attribindex, GLuint bindingindex)
			public readonly VertexArrayVertexAttribBindingDelegate VertexArrayVertexAttribBinding;
			// void glVertexArrayVertexAttribDivisorEXT (GLuint vaobj, GLuint index, GLuint divisor)
			public readonly VertexArrayVertexAttribDivisorDelegate VertexArrayVertexAttribDivisor;
			// void glVertexArrayVertexAttribFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
			public readonly VertexArrayVertexAttribFormatDelegate VertexArrayVertexAttribFormat;
			// void glVertexArrayVertexAttribIFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
			public readonly VertexArrayVertexAttribIFormatDelegate VertexArrayVertexAttribIFormat;
			// void glVertexArrayVertexAttribIOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayVertexAttribIOffsetDelegate VertexArrayVertexAttribIOffset;
			// void glVertexArrayVertexAttribLFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
			public readonly VertexArrayVertexAttribLFormatDelegate VertexArrayVertexAttribLFormat;
			// void glVertexArrayVertexAttribLOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayVertexAttribLOffsetDelegate VertexArrayVertexAttribLOffset;
			// void glVertexArrayVertexAttribOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLintptr offset)
			public readonly VertexArrayVertexAttribOffsetDelegate VertexArrayVertexAttribOffset;
			// void glVertexArrayVertexBindingDivisorEXT (GLuint vaobj, GLuint bindingindex, GLuint divisor)
			public readonly VertexArrayVertexBindingDivisorDelegate VertexArrayVertexBindingDivisor;
			// void glVertexArrayVertexOffsetEXT (GLuint vaobj, GLuint buffer, GLint size, GLenum type, GLsizei stride, GLintptr offset)
			public readonly VertexArrayVertexOffsetDelegate VertexArrayVertexOffset;
			#endregion // commands
			public ExtDirectStateAccess (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindMultiTextureEXT", out BindMultiTexture);
				resolver.LoadHandle ("glCheckNamedFramebufferStatusEXT", out CheckNamedFramebufferStatus);
				resolver.LoadHandle ("glClearNamedBufferDataEXT", out ClearNamedBufferData);
				resolver.LoadHandle ("glClearNamedBufferSubDataEXT", out ClearNamedBufferSubData);
				resolver.LoadHandle ("glClientAttribDefaultEXT", out ClientAttribDefault);
				resolver.LoadHandle ("glCompressedMultiTexImage1DEXT", out CompressedMultiTexImage1D);
				resolver.LoadHandle ("glCompressedMultiTexImage2DEXT", out CompressedMultiTexImage2D);
				resolver.LoadHandle ("glCompressedMultiTexImage3DEXT", out CompressedMultiTexImage3D);
				resolver.LoadHandle ("glCompressedMultiTexSubImage1DEXT", out CompressedMultiTexSubImage1D);
				resolver.LoadHandle ("glCompressedMultiTexSubImage2DEXT", out CompressedMultiTexSubImage2D);
				resolver.LoadHandle ("glCompressedMultiTexSubImage3DEXT", out CompressedMultiTexSubImage3D);
				resolver.LoadHandle ("glCompressedTextureImage1DEXT", out CompressedTextureImage1D);
				resolver.LoadHandle ("glCompressedTextureImage2DEXT", out CompressedTextureImage2D);
				resolver.LoadHandle ("glCompressedTextureImage3DEXT", out CompressedTextureImage3D);
				resolver.LoadHandle ("glCompressedTextureSubImage1DEXT", out CompressedTextureSubImage1D);
				resolver.LoadHandle ("glCompressedTextureSubImage2DEXT", out CompressedTextureSubImage2D);
				resolver.LoadHandle ("glCompressedTextureSubImage3DEXT", out CompressedTextureSubImage3D);
				resolver.LoadHandle ("glCopyMultiTexImage1DEXT", out CopyMultiTexImage1D);
				resolver.LoadHandle ("glCopyMultiTexImage2DEXT", out CopyMultiTexImage2D);
				resolver.LoadHandle ("glCopyMultiTexSubImage1DEXT", out CopyMultiTexSubImage1D);
				resolver.LoadHandle ("glCopyMultiTexSubImage2DEXT", out CopyMultiTexSubImage2D);
				resolver.LoadHandle ("glCopyMultiTexSubImage3DEXT", out CopyMultiTexSubImage3D);
				resolver.LoadHandle ("glCopyTextureImage1DEXT", out CopyTextureImage1D);
				resolver.LoadHandle ("glCopyTextureImage2DEXT", out CopyTextureImage2D);
				resolver.LoadHandle ("glCopyTextureSubImage1DEXT", out CopyTextureSubImage1D);
				resolver.LoadHandle ("glCopyTextureSubImage2DEXT", out CopyTextureSubImage2D);
				resolver.LoadHandle ("glCopyTextureSubImage3DEXT", out CopyTextureSubImage3D);
				resolver.LoadHandle ("glDisableClientStateiEXT", out DisableClientStatei);
				resolver.LoadHandle ("glDisableClientStateIndexedEXT", out DisableClientStateIndexed);
				resolver.LoadHandle ("glDisableIndexedEXT", out DisableIndexed);
				resolver.LoadHandle ("glDisableVertexArrayAttribEXT", out DisableVertexArrayAttrib);
				resolver.LoadHandle ("glDisableVertexArrayEXT", out DisableVertexArray);
				resolver.LoadHandle ("glEnableClientStateiEXT", out EnableClientStatei);
				resolver.LoadHandle ("glEnableClientStateIndexedEXT", out EnableClientStateIndexed);
				resolver.LoadHandle ("glEnableIndexedEXT", out EnableIndexed);
				resolver.LoadHandle ("glEnableVertexArrayAttribEXT", out EnableVertexArrayAttrib);
				resolver.LoadHandle ("glEnableVertexArrayEXT", out EnableVertexArray);
				resolver.LoadHandle ("glFlushMappedNamedBufferRangeEXT", out FlushMappedNamedBufferRange);
				resolver.LoadHandle ("glFramebufferDrawBufferEXT", out FramebufferDrawBuffer);
				resolver.LoadHandle ("glFramebufferDrawBuffersEXT", out FramebufferDrawBuffers);
				resolver.LoadHandle ("glFramebufferReadBufferEXT", out FramebufferReadBuffer);
				resolver.LoadHandle ("glGenerateMultiTexMipmapEXT", out GenerateMultiTexMipmap);
				resolver.LoadHandle ("glGenerateTextureMipmapEXT", out GenerateTextureMipmap);
				resolver.LoadHandle ("glGetBooleanIndexedvEXT", out GetBooleanIndexedv);
				resolver.LoadHandle ("glGetCompressedMultiTexImageEXT", out GetCompressedMultiTexImage);
				resolver.LoadHandle ("glGetCompressedTextureImageEXT", out GetCompressedTextureImage);
				resolver.LoadHandle ("glGetDoublei_vEXT", out GetDoublei_v);
				resolver.LoadHandle ("glGetDoubleIndexedvEXT", out GetDoubleIndexedv);
				resolver.LoadHandle ("glGetFloati_vEXT", out GetFloati_v);
				resolver.LoadHandle ("glGetFloatIndexedvEXT", out GetFloatIndexedv);
				resolver.LoadHandle ("glGetFramebufferParameterivEXT", out GetFramebufferParameteriv);
				resolver.LoadHandle ("glGetIntegerIndexedvEXT", out GetIntegerIndexedv);
				resolver.LoadHandle ("glGetMultiTexEnvfvEXT", out GetMultiTexEnvfv);
				resolver.LoadHandle ("glGetMultiTexEnvivEXT", out GetMultiTexEnviv);
				resolver.LoadHandle ("glGetMultiTexGendvEXT", out GetMultiTexGendv);
				resolver.LoadHandle ("glGetMultiTexGenfvEXT", out GetMultiTexGenfv);
				resolver.LoadHandle ("glGetMultiTexGenivEXT", out GetMultiTexGeniv);
				resolver.LoadHandle ("glGetMultiTexImageEXT", out GetMultiTexImage);
				resolver.LoadHandle ("glGetMultiTexLevelParameterfvEXT", out GetMultiTexLevelParameterfv);
				resolver.LoadHandle ("glGetMultiTexLevelParameterivEXT", out GetMultiTexLevelParameteriv);
				resolver.LoadHandle ("glGetMultiTexParameterfvEXT", out GetMultiTexParameterfv);
				resolver.LoadHandle ("glGetMultiTexParameterIivEXT", out GetMultiTexParameterIiv);
				resolver.LoadHandle ("glGetMultiTexParameterIuivEXT", out GetMultiTexParameterIuiv);
				resolver.LoadHandle ("glGetMultiTexParameterivEXT", out GetMultiTexParameteriv);
				resolver.LoadHandle ("glGetNamedBufferParameterivEXT", out GetNamedBufferParameteriv);
				resolver.LoadHandle ("glGetNamedBufferPointervEXT", out GetNamedBufferPointerv);
				resolver.LoadHandle ("glGetNamedBufferSubDataEXT", out GetNamedBufferSubData);
				resolver.LoadHandle ("glGetNamedFramebufferAttachmentParameterivEXT", out GetNamedFramebufferAttachmentParameteriv);
				resolver.LoadHandle ("glGetNamedFramebufferParameterivEXT", out GetNamedFramebufferParameteriv);
				resolver.LoadHandle ("glGetNamedProgramivEXT", out GetNamedProgramiv);
				resolver.LoadHandle ("glGetNamedProgramLocalParameterdvEXT", out GetNamedProgramLocalParameterdv);
				resolver.LoadHandle ("glGetNamedProgramLocalParameterfvEXT", out GetNamedProgramLocalParameterfv);
				resolver.LoadHandle ("glGetNamedProgramLocalParameterIivEXT", out GetNamedProgramLocalParameterIiv);
				resolver.LoadHandle ("glGetNamedProgramLocalParameterIuivEXT", out GetNamedProgramLocalParameterIuiv);
				resolver.LoadHandle ("glGetNamedProgramStringEXT", out GetNamedProgramString);
				resolver.LoadHandle ("glGetNamedRenderbufferParameterivEXT", out GetNamedRenderbufferParameteriv);
				resolver.LoadHandle ("glGetPointeri_vEXT", out GetPointeri_v);
				resolver.LoadHandle ("glGetPointerIndexedvEXT", out GetPointerIndexedv);
				resolver.LoadHandle ("glGetTextureImageEXT", out GetTextureImage);
				resolver.LoadHandle ("glGetTextureLevelParameterfvEXT", out GetTextureLevelParameterfv);
				resolver.LoadHandle ("glGetTextureLevelParameterivEXT", out GetTextureLevelParameteriv);
				resolver.LoadHandle ("glGetTextureParameterfvEXT", out GetTextureParameterfv);
				resolver.LoadHandle ("glGetTextureParameterIivEXT", out GetTextureParameterIiv);
				resolver.LoadHandle ("glGetTextureParameterIuivEXT", out GetTextureParameterIuiv);
				resolver.LoadHandle ("glGetTextureParameterivEXT", out GetTextureParameteriv);
				resolver.LoadHandle ("glGetVertexArrayIntegeri_vEXT", out GetVertexArrayIntegeri_v);
				resolver.LoadHandle ("glGetVertexArrayIntegervEXT", out GetVertexArrayIntegerv);
				resolver.LoadHandle ("glGetVertexArrayPointeri_vEXT", out GetVertexArrayPointeri_v);
				resolver.LoadHandle ("glGetVertexArrayPointervEXT", out GetVertexArrayPointerv);
				resolver.LoadHandle ("glIsEnabledIndexedEXT", out IsEnabledIndexed);
				resolver.LoadHandle ("glMapNamedBufferEXT", out MapNamedBuffer);
				resolver.LoadHandle ("glMapNamedBufferRangeEXT", out MapNamedBufferRange);
				resolver.LoadHandle ("glMatrixFrustumEXT", out MatrixFrustum);
				resolver.LoadHandle ("glMatrixLoaddEXT", out MatrixLoadd);
				resolver.LoadHandle ("glMatrixLoadfEXT", out MatrixLoadf);
				resolver.LoadHandle ("glMatrixLoadIdentityEXT", out MatrixLoadIdentity);
				resolver.LoadHandle ("glMatrixLoadTransposedEXT", out MatrixLoadTransposed);
				resolver.LoadHandle ("glMatrixLoadTransposefEXT", out MatrixLoadTransposef);
				resolver.LoadHandle ("glMatrixMultdEXT", out MatrixMultd);
				resolver.LoadHandle ("glMatrixMultfEXT", out MatrixMultf);
				resolver.LoadHandle ("glMatrixMultTransposedEXT", out MatrixMultTransposed);
				resolver.LoadHandle ("glMatrixMultTransposefEXT", out MatrixMultTransposef);
				resolver.LoadHandle ("glMatrixOrthoEXT", out MatrixOrtho);
				resolver.LoadHandle ("glMatrixPopEXT", out MatrixPop);
				resolver.LoadHandle ("glMatrixPushEXT", out MatrixPush);
				resolver.LoadHandle ("glMatrixRotatedEXT", out MatrixRotated);
				resolver.LoadHandle ("glMatrixRotatefEXT", out MatrixRotatef);
				resolver.LoadHandle ("glMatrixScaledEXT", out MatrixScaled);
				resolver.LoadHandle ("glMatrixScalefEXT", out MatrixScalef);
				resolver.LoadHandle ("glMatrixTranslatedEXT", out MatrixTranslated);
				resolver.LoadHandle ("glMatrixTranslatefEXT", out MatrixTranslatef);
				resolver.LoadHandle ("glMultiTexBufferEXT", out MultiTexBuffer);
				resolver.LoadHandle ("glMultiTexCoordPointerEXT", out MultiTexCoordPointer);
				resolver.LoadHandle ("glMultiTexEnvfEXT", out MultiTexEnvf);
				resolver.LoadHandle ("glMultiTexEnvfvEXT", out MultiTexEnvfv);
				resolver.LoadHandle ("glMultiTexEnviEXT", out MultiTexEnvi);
				resolver.LoadHandle ("glMultiTexEnvivEXT", out MultiTexEnviv);
				resolver.LoadHandle ("glMultiTexGendEXT", out MultiTexGend);
				resolver.LoadHandle ("glMultiTexGendvEXT", out MultiTexGendv);
				resolver.LoadHandle ("glMultiTexGenfEXT", out MultiTexGenf);
				resolver.LoadHandle ("glMultiTexGenfvEXT", out MultiTexGenfv);
				resolver.LoadHandle ("glMultiTexGeniEXT", out MultiTexGeni);
				resolver.LoadHandle ("glMultiTexGenivEXT", out MultiTexGeniv);
				resolver.LoadHandle ("glMultiTexImage1DEXT", out MultiTexImage1D);
				resolver.LoadHandle ("glMultiTexImage2DEXT", out MultiTexImage2D);
				resolver.LoadHandle ("glMultiTexImage3DEXT", out MultiTexImage3D);
				resolver.LoadHandle ("glMultiTexParameterfEXT", out MultiTexParameterf);
				resolver.LoadHandle ("glMultiTexParameterfvEXT", out MultiTexParameterfv);
				resolver.LoadHandle ("glMultiTexParameteriEXT", out MultiTexParameteri);
				resolver.LoadHandle ("glMultiTexParameterIivEXT", out MultiTexParameterIiv);
				resolver.LoadHandle ("glMultiTexParameterIuivEXT", out MultiTexParameterIuiv);
				resolver.LoadHandle ("glMultiTexParameterivEXT", out MultiTexParameteriv);
				resolver.LoadHandle ("glMultiTexRenderbufferEXT", out MultiTexRenderbuffer);
				resolver.LoadHandle ("glMultiTexSubImage1DEXT", out MultiTexSubImage1D);
				resolver.LoadHandle ("glMultiTexSubImage2DEXT", out MultiTexSubImage2D);
				resolver.LoadHandle ("glMultiTexSubImage3DEXT", out MultiTexSubImage3D);
				resolver.LoadHandle ("glNamedBufferDataEXT", out NamedBufferData);
				resolver.LoadHandle ("glNamedBufferStorageEXT", out NamedBufferStorage);
				resolver.LoadHandle ("glNamedBufferSubDataEXT", out NamedBufferSubData);
				resolver.LoadHandle ("glNamedCopyBufferSubDataEXT", out NamedCopyBufferSubData);
				resolver.LoadHandle ("glNamedFramebufferParameteriEXT", out NamedFramebufferParameteri);
				resolver.LoadHandle ("glNamedFramebufferRenderbufferEXT", out NamedFramebufferRenderbuffer);
				resolver.LoadHandle ("glNamedFramebufferTexture1DEXT", out NamedFramebufferTexture1D);
				resolver.LoadHandle ("glNamedFramebufferTexture2DEXT", out NamedFramebufferTexture2D);
				resolver.LoadHandle ("glNamedFramebufferTexture3DEXT", out NamedFramebufferTexture3D);
				resolver.LoadHandle ("glNamedFramebufferTextureFaceEXT", out NamedFramebufferTextureFace);
				resolver.LoadHandle ("glNamedFramebufferTextureEXT", out NamedFramebufferTexture);
				resolver.LoadHandle ("glNamedFramebufferTextureLayerEXT", out NamedFramebufferTextureLayer);
				resolver.LoadHandle ("glNamedProgramLocalParameter4dEXT", out NamedProgramLocalParameter4d);
				resolver.LoadHandle ("glNamedProgramLocalParameter4dvEXT", out NamedProgramLocalParameter4dv);
				resolver.LoadHandle ("glNamedProgramLocalParameter4fEXT", out NamedProgramLocalParameter4f);
				resolver.LoadHandle ("glNamedProgramLocalParameter4fvEXT", out NamedProgramLocalParameter4fv);
				resolver.LoadHandle ("glNamedProgramLocalParameterI4iEXT", out NamedProgramLocalParameterI4i);
				resolver.LoadHandle ("glNamedProgramLocalParameterI4ivEXT", out NamedProgramLocalParameterI4iv);
				resolver.LoadHandle ("glNamedProgramLocalParameterI4uiEXT", out NamedProgramLocalParameterI4ui);
				resolver.LoadHandle ("glNamedProgramLocalParameterI4uivEXT", out NamedProgramLocalParameterI4uiv);
				resolver.LoadHandle ("glNamedProgramLocalParameters4fvEXT", out NamedProgramLocalParameters4fv);
				resolver.LoadHandle ("glNamedProgramLocalParametersI4ivEXT", out NamedProgramLocalParametersI4iv);
				resolver.LoadHandle ("glNamedProgramLocalParametersI4uivEXT", out NamedProgramLocalParametersI4uiv);
				resolver.LoadHandle ("glNamedProgramStringEXT", out NamedProgramString);
				resolver.LoadHandle ("glNamedRenderbufferStorageEXT", out NamedRenderbufferStorage);
				resolver.LoadHandle ("glNamedRenderbufferStorageMultisampleCoverageEXT", out NamedRenderbufferStorageMultisampleCoverage);
				resolver.LoadHandle ("glNamedRenderbufferStorageMultisampleEXT", out NamedRenderbufferStorageMultisample);
				resolver.LoadHandle ("glProgramUniform1dEXT", out ProgramUniform1d);
				resolver.LoadHandle ("glProgramUniform1dvEXT", out ProgramUniform1dv);
				resolver.LoadHandle ("glProgramUniform1fEXT", out ProgramUniform1f);
				resolver.LoadHandle ("glProgramUniform1fvEXT", out ProgramUniform1fv);
				resolver.LoadHandle ("glProgramUniform1iEXT", out ProgramUniform1i);
				resolver.LoadHandle ("glProgramUniform1ivEXT", out ProgramUniform1iv);
				resolver.LoadHandle ("glProgramUniform1uiEXT", out ProgramUniform1ui);
				resolver.LoadHandle ("glProgramUniform1uivEXT", out ProgramUniform1uiv);
				resolver.LoadHandle ("glProgramUniform2dEXT", out ProgramUniform2d);
				resolver.LoadHandle ("glProgramUniform2dvEXT", out ProgramUniform2dv);
				resolver.LoadHandle ("glProgramUniform2fEXT", out ProgramUniform2f);
				resolver.LoadHandle ("glProgramUniform2fvEXT", out ProgramUniform2fv);
				resolver.LoadHandle ("glProgramUniform2iEXT", out ProgramUniform2i);
				resolver.LoadHandle ("glProgramUniform2ivEXT", out ProgramUniform2iv);
				resolver.LoadHandle ("glProgramUniform2uiEXT", out ProgramUniform2ui);
				resolver.LoadHandle ("glProgramUniform2uivEXT", out ProgramUniform2uiv);
				resolver.LoadHandle ("glProgramUniform3dEXT", out ProgramUniform3d);
				resolver.LoadHandle ("glProgramUniform3dvEXT", out ProgramUniform3dv);
				resolver.LoadHandle ("glProgramUniform3fEXT", out ProgramUniform3f);
				resolver.LoadHandle ("glProgramUniform3fvEXT", out ProgramUniform3fv);
				resolver.LoadHandle ("glProgramUniform3iEXT", out ProgramUniform3i);
				resolver.LoadHandle ("glProgramUniform3ivEXT", out ProgramUniform3iv);
				resolver.LoadHandle ("glProgramUniform3uiEXT", out ProgramUniform3ui);
				resolver.LoadHandle ("glProgramUniform3uivEXT", out ProgramUniform3uiv);
				resolver.LoadHandle ("glProgramUniform4dEXT", out ProgramUniform4d);
				resolver.LoadHandle ("glProgramUniform4dvEXT", out ProgramUniform4dv);
				resolver.LoadHandle ("glProgramUniform4fEXT", out ProgramUniform4f);
				resolver.LoadHandle ("glProgramUniform4fvEXT", out ProgramUniform4fv);
				resolver.LoadHandle ("glProgramUniform4iEXT", out ProgramUniform4i);
				resolver.LoadHandle ("glProgramUniform4ivEXT", out ProgramUniform4iv);
				resolver.LoadHandle ("glProgramUniform4uiEXT", out ProgramUniform4ui);
				resolver.LoadHandle ("glProgramUniform4uivEXT", out ProgramUniform4uiv);
				resolver.LoadHandle ("glProgramUniformMatrix2dvEXT", out ProgramUniformMatrix2dv);
				resolver.LoadHandle ("glProgramUniformMatrix2fvEXT", out ProgramUniformMatrix2fv);
				resolver.LoadHandle ("glProgramUniformMatrix2x3dvEXT", out ProgramUniformMatrix2x3dv);
				resolver.LoadHandle ("glProgramUniformMatrix2x3fvEXT", out ProgramUniformMatrix2x3fv);
				resolver.LoadHandle ("glProgramUniformMatrix2x4dvEXT", out ProgramUniformMatrix2x4dv);
				resolver.LoadHandle ("glProgramUniformMatrix2x4fvEXT", out ProgramUniformMatrix2x4fv);
				resolver.LoadHandle ("glProgramUniformMatrix3dvEXT", out ProgramUniformMatrix3dv);
				resolver.LoadHandle ("glProgramUniformMatrix3fvEXT", out ProgramUniformMatrix3fv);
				resolver.LoadHandle ("glProgramUniformMatrix3x2dvEXT", out ProgramUniformMatrix3x2dv);
				resolver.LoadHandle ("glProgramUniformMatrix3x2fvEXT", out ProgramUniformMatrix3x2fv);
				resolver.LoadHandle ("glProgramUniformMatrix3x4dvEXT", out ProgramUniformMatrix3x4dv);
				resolver.LoadHandle ("glProgramUniformMatrix3x4fvEXT", out ProgramUniformMatrix3x4fv);
				resolver.LoadHandle ("glProgramUniformMatrix4dvEXT", out ProgramUniformMatrix4dv);
				resolver.LoadHandle ("glProgramUniformMatrix4fvEXT", out ProgramUniformMatrix4fv);
				resolver.LoadHandle ("glProgramUniformMatrix4x2dvEXT", out ProgramUniformMatrix4x2dv);
				resolver.LoadHandle ("glProgramUniformMatrix4x2fvEXT", out ProgramUniformMatrix4x2fv);
				resolver.LoadHandle ("glProgramUniformMatrix4x3dvEXT", out ProgramUniformMatrix4x3dv);
				resolver.LoadHandle ("glProgramUniformMatrix4x3fvEXT", out ProgramUniformMatrix4x3fv);
				resolver.LoadHandle ("glPushClientAttribDefaultEXT", out PushClientAttribDefault);
				resolver.LoadHandle ("glTextureBufferEXT", out TextureBuffer);
				resolver.LoadHandle ("glTextureBufferRangeEXT", out TextureBufferRange);
				resolver.LoadHandle ("glTextureImage1DEXT", out TextureImage1D);
				resolver.LoadHandle ("glTextureImage2DEXT", out TextureImage2D);
				resolver.LoadHandle ("glTextureImage3DEXT", out TextureImage3D);
				resolver.LoadHandle ("glTexturePageCommitmentEXT", out TexturePageCommitment);
				resolver.LoadHandle ("glTextureParameterfEXT", out TextureParameterf);
				resolver.LoadHandle ("glTextureParameterfvEXT", out TextureParameterfv);
				resolver.LoadHandle ("glTextureParameteriEXT", out TextureParameteri);
				resolver.LoadHandle ("glTextureParameterIivEXT", out TextureParameterIiv);
				resolver.LoadHandle ("glTextureParameterIuivEXT", out TextureParameterIuiv);
				resolver.LoadHandle ("glTextureParameterivEXT", out TextureParameteriv);
				resolver.LoadHandle ("glTextureRenderbufferEXT", out TextureRenderbuffer);
				resolver.LoadHandle ("glTextureStorage1DEXT", out TextureStorage1D);
				resolver.LoadHandle ("glTextureStorage2DEXT", out TextureStorage2D);
				resolver.LoadHandle ("glTextureStorage2DMultisampleEXT", out TextureStorage2DMultisample);
				resolver.LoadHandle ("glTextureStorage3DEXT", out TextureStorage3D);
				resolver.LoadHandle ("glTextureStorage3DMultisampleEXT", out TextureStorage3DMultisample);
				resolver.LoadHandle ("glTextureSubImage1DEXT", out TextureSubImage1D);
				resolver.LoadHandle ("glTextureSubImage2DEXT", out TextureSubImage2D);
				resolver.LoadHandle ("glTextureSubImage3DEXT", out TextureSubImage3D);
				resolver.LoadHandle ("glUnmapNamedBufferEXT", out UnmapNamedBuffer);
				resolver.LoadHandle ("glVertexArrayBindVertexBufferEXT", out VertexArrayBindVertexBuffer);
				resolver.LoadHandle ("glVertexArrayColorOffsetEXT", out VertexArrayColorOffset);
				resolver.LoadHandle ("glVertexArrayEdgeFlagOffsetEXT", out VertexArrayEdgeFlagOffset);
				resolver.LoadHandle ("glVertexArrayFogCoordOffsetEXT", out VertexArrayFogCoordOffset);
				resolver.LoadHandle ("glVertexArrayIndexOffsetEXT", out VertexArrayIndexOffset);
				resolver.LoadHandle ("glVertexArrayMultiTexCoordOffsetEXT", out VertexArrayMultiTexCoordOffset);
				resolver.LoadHandle ("glVertexArrayNormalOffsetEXT", out VertexArrayNormalOffset);
				resolver.LoadHandle ("glVertexArraySecondaryColorOffsetEXT", out VertexArraySecondaryColorOffset);
				resolver.LoadHandle ("glVertexArrayTexCoordOffsetEXT", out VertexArrayTexCoordOffset);
				resolver.LoadHandle ("glVertexArrayVertexAttribBindingEXT", out VertexArrayVertexAttribBinding);
				resolver.LoadHandle ("glVertexArrayVertexAttribDivisorEXT", out VertexArrayVertexAttribDivisor);
				resolver.LoadHandle ("glVertexArrayVertexAttribFormatEXT", out VertexArrayVertexAttribFormat);
				resolver.LoadHandle ("glVertexArrayVertexAttribIFormatEXT", out VertexArrayVertexAttribIFormat);
				resolver.LoadHandle ("glVertexArrayVertexAttribIOffsetEXT", out VertexArrayVertexAttribIOffset);
				resolver.LoadHandle ("glVertexArrayVertexAttribLFormatEXT", out VertexArrayVertexAttribLFormat);
				resolver.LoadHandle ("glVertexArrayVertexAttribLOffsetEXT", out VertexArrayVertexAttribLOffset);
				resolver.LoadHandle ("glVertexArrayVertexAttribOffsetEXT", out VertexArrayVertexAttribOffset);
				resolver.LoadHandle ("glVertexArrayVertexBindingDivisorEXT", out VertexArrayVertexBindingDivisor);
				resolver.LoadHandle ("glVertexArrayVertexOffsetEXT", out VertexArrayVertexOffset);
			}
		}
		public partial class ExtDrawBuffers2
		{
			public const string NAME_STRING = "GL_EXT_draw_buffers2";
			#region command delegates
			// void glColorMaskIndexedEXT (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorMaskIndexedDelegate (System.UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a);
			#endregion // command delegates
			#region commands
			// void glColorMaskIndexedEXT (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
			public readonly ColorMaskIndexedDelegate ColorMaskIndexed;
			#endregion // commands
			public ExtDrawBuffers2 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorMaskIndexedEXT", out ColorMaskIndexed);
			}
		}
		public partial class ExtDrawInstanced
		{
			public const string NAME_STRING = "GL_EXT_draw_instanced";
			#region command delegates
			// void glDrawArraysInstancedEXT (GLenum mode, GLint start, GLsizei count, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawArraysInstancedDelegate (PrimitiveType mode, System.Int32 start, System.Int32 count, System.Int32 primcount);
			// void glDrawElementsInstancedEXT (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawElementsInstancedDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 primcount);
			#endregion // command delegates
			#region commands
			// void glDrawArraysInstancedEXT (GLenum mode, GLint start, GLsizei count, GLsizei primcount)
			public readonly DrawArraysInstancedDelegate DrawArraysInstanced;
			// void glDrawElementsInstancedEXT (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount)
			public readonly DrawElementsInstancedDelegate DrawElementsInstanced;
			#endregion // commands
			public ExtDrawInstanced (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawArraysInstancedEXT", out DrawArraysInstanced);
				resolver.LoadHandle ("glDrawElementsInstancedEXT", out DrawElementsInstanced);
			}
		}
		public partial class ExtDrawRangeElements
		{
			public enum All
			{
				// GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8
				MaxElementsVertices = unchecked((int)33000),
				// GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9
				MaxElementsIndices = unchecked((int)33001),
			}
			public const string NAME_STRING = "GL_EXT_draw_range_elements";
			#region command delegates
			// void glDrawRangeElementsEXT (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawRangeElementsDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, System.Int32 count, System.UInt32 type, IntPtr indices);
			#endregion // command delegates
			#region commands
			// void glDrawRangeElementsEXT (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices)
			public readonly DrawRangeElementsDelegate DrawRangeElements;
			#endregion // commands
			public ExtDrawRangeElements (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawRangeElementsEXT", out DrawRangeElements);
			}
		}
		public partial class ExtFogCoord
		{
			public enum All
			{
				// GL_FOG_COORDINATE_SOURCE_EXT = 0x8450
				FogCoordinateSource = unchecked((int)33872),
				// GL_FOG_COORDINATE_EXT = 0x8451
				FogCoordinate = unchecked((int)33873),
				// GL_FRAGMENT_DEPTH_EXT = 0x8452
				FragmentDepth = unchecked((int)33874),
				// GL_CURRENT_FOG_COORDINATE_EXT = 0x8453
				CurrentFogCoordinate = unchecked((int)33875),
				// GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454
				FogCoordinateArrayType = unchecked((int)33876),
				// GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455
				FogCoordinateArrayStride = unchecked((int)33877),
				// GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456
				FogCoordinateArrayPointer = unchecked((int)33878),
				// GL_FOG_COORDINATE_ARRAY_EXT = 0x8457
				FogCoordinateArray = unchecked((int)33879),
			}
			public const string NAME_STRING = "GL_EXT_fog_coord";
			#region command delegates
			// void glFogCoorddEXT (GLdouble coord)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoorddDelegate (System.Double coord);
			// void glFogCoorddvEXT (GLdouble* coord)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoorddvDelegate (IntPtr coord);
			// void glFogCoordfEXT (GLfloat coord)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordfDelegate (System.Single coord);
			// void glFogCoordfvEXT (GLfloat* coord)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordfvDelegate (IntPtr coord);
			// void glFogCoordPointerEXT (GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordPointerDelegate (FogPointerTypeEXT type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glFogCoorddEXT (GLdouble coord)
			public readonly FogCoorddDelegate FogCoordd;
			// void glFogCoorddvEXT (GLdouble* coord)
			public readonly FogCoorddvDelegate FogCoorddv;
			// void glFogCoordfEXT (GLfloat coord)
			public readonly FogCoordfDelegate FogCoordf;
			// void glFogCoordfvEXT (GLfloat* coord)
			public readonly FogCoordfvDelegate FogCoordfv;
			// void glFogCoordPointerEXT (GLenum type, GLsizei stride, void* pointer)
			public readonly FogCoordPointerDelegate FogCoordPointer;
			#endregion // commands
			public ExtFogCoord (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFogCoorddEXT", out FogCoordd);
				resolver.LoadHandle ("glFogCoorddvEXT", out FogCoorddv);
				resolver.LoadHandle ("glFogCoordfEXT", out FogCoordf);
				resolver.LoadHandle ("glFogCoordfvEXT", out FogCoordfv);
				resolver.LoadHandle ("glFogCoordPointerEXT", out FogCoordPointer);
			}
		}
		public partial class ExtFramebufferBlit
		{
			public enum All
			{
				// GL_DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6
				DrawFramebufferBinding = unchecked((int)36006),
				// GL_READ_FRAMEBUFFER_EXT = 0x8CA8
				ReadFramebuffer = unchecked((int)36008),
				// GL_DRAW_FRAMEBUFFER_EXT = 0x8CA9
				DrawFramebuffer = unchecked((int)36009),
				// GL_READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA
				ReadFramebufferBinding = unchecked((int)36010),
			}
			public const string NAME_STRING = "GL_EXT_framebuffer_blit";
			#region command delegates
			// void glBlitFramebufferEXT (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlitFramebufferDelegate (System.Int32 srcX0, System.Int32 srcY0, System.Int32 srcX1, System.Int32 srcY1, System.Int32 dstX0, System.Int32 dstY0, System.Int32 dstX1, System.Int32 dstY1, ClearBufferMask mask, System.UInt32 filter);
			#endregion // command delegates
			#region commands
			// void glBlitFramebufferEXT (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
			public readonly BlitFramebufferDelegate BlitFramebuffer;
			#endregion // commands
			public ExtFramebufferBlit (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlitFramebufferEXT", out BlitFramebuffer);
			}
		}
		public partial class ExtFramebufferMultisample
		{
			public enum All
			{
				// GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
				RenderbufferSamples = unchecked((int)36011),
				// GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
				FramebufferIncompleteMultisample = unchecked((int)36182),
				// GL_MAX_SAMPLES_EXT = 0x8D57
				MaxSamples = unchecked((int)36183),
			}
			public const string NAME_STRING = "GL_EXT_framebuffer_multisample";
			#region command delegates
			// void glRenderbufferStorageMultisampleEXT (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RenderbufferStorageMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			#endregion // command delegates
			#region commands
			// void glRenderbufferStorageMultisampleEXT (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly RenderbufferStorageMultisampleDelegate RenderbufferStorageMultisample;
			#endregion // commands
			public ExtFramebufferMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glRenderbufferStorageMultisampleEXT", out RenderbufferStorageMultisample);
			}
		}
		public partial class ExtFramebufferMultisampleBlitScaled
		{
			public enum All
			{
				// GL_SCALED_RESOLVE_FASTEST_EXT = 0x90BA
				ScaledResolveFastest = unchecked((int)37050),
				// GL_SCALED_RESOLVE_NICEST_EXT = 0x90BB
				ScaledResolveNicest = unchecked((int)37051),
			}
			public const string NAME_STRING = "GL_EXT_framebuffer_multisample_blit_scaled";
		}
		public partial class ExtFramebufferObject
		{
			public enum All
			{
				// GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x506
				InvalidFramebufferOperation = unchecked((int)1286),
				// GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8
				MaxRenderbufferSize = unchecked((int)34024),
				// GL_FRAMEBUFFER_BINDING_EXT = 0x8CA6
				FramebufferBinding = unchecked((int)36006),
				// GL_RENDERBUFFER_BINDING_EXT = 0x8CA7
				RenderbufferBinding = unchecked((int)36007),
				// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0
				FramebufferAttachmentObjectType = unchecked((int)36048),
				// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1
				FramebufferAttachmentObjectName = unchecked((int)36049),
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2
				FramebufferAttachmentTextureLevel = unchecked((int)36050),
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3
				FramebufferAttachmentTextureCubeMapFace = unchecked((int)36051),
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4
				FramebufferAttachmentTexture3dZoffset = unchecked((int)36052),
				// GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5
				FramebufferComplete = unchecked((int)36053),
				// GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6
				FramebufferIncompleteAttachment = unchecked((int)36054),
				// GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7
				FramebufferIncompleteMissingAttachment = unchecked((int)36055),
				// GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9
				FramebufferIncompleteDimensions = unchecked((int)36057),
				// GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA
				FramebufferIncompleteFormats = unchecked((int)36058),
				// GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB
				FramebufferIncompleteDrawBuffer = unchecked((int)36059),
				// GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC
				FramebufferIncompleteReadBuffer = unchecked((int)36060),
				// GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD
				FramebufferUnsupported = unchecked((int)36061),
				// GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
				MaxColorAttachments = unchecked((int)36063),
				// GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
				ColorAttachment0 = unchecked((int)36064),
				// GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
				ColorAttachment1 = unchecked((int)36065),
				// GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
				ColorAttachment2 = unchecked((int)36066),
				// GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
				ColorAttachment3 = unchecked((int)36067),
				// GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
				ColorAttachment4 = unchecked((int)36068),
				// GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
				ColorAttachment5 = unchecked((int)36069),
				// GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
				ColorAttachment6 = unchecked((int)36070),
				// GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
				ColorAttachment7 = unchecked((int)36071),
				// GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
				ColorAttachment8 = unchecked((int)36072),
				// GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
				ColorAttachment9 = unchecked((int)36073),
				// GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
				ColorAttachment10 = unchecked((int)36074),
				// GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
				ColorAttachment11 = unchecked((int)36075),
				// GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
				ColorAttachment12 = unchecked((int)36076),
				// GL_COLOR_ATTACHMENT13_EXT = 0x8CED
				ColorAttachment13 = unchecked((int)36077),
				// GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
				ColorAttachment14 = unchecked((int)36078),
				// GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
				ColorAttachment15 = unchecked((int)36079),
				// GL_DEPTH_ATTACHMENT_EXT = 0x8D00
				DepthAttachment = unchecked((int)36096),
				// GL_STENCIL_ATTACHMENT_EXT = 0x8D20
				StencilAttachment = unchecked((int)36128),
				// GL_FRAMEBUFFER_EXT = 0x8D40
				Framebuffer = unchecked((int)36160),
				// GL_RENDERBUFFER_EXT = 0x8D41
				Renderbuffer = unchecked((int)36161),
				// GL_RENDERBUFFER_WIDTH_EXT = 0x8D42
				RenderbufferWidth = unchecked((int)36162),
				// GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43
				RenderbufferHeight = unchecked((int)36163),
				// GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44
				RenderbufferInternalFormat = unchecked((int)36164),
				// GL_STENCIL_INDEX1_EXT = 0x8D46
				StencilIndex1 = unchecked((int)36166),
				// GL_STENCIL_INDEX4_EXT = 0x8D47
				StencilIndex4 = unchecked((int)36167),
				// GL_STENCIL_INDEX8_EXT = 0x8D48
				StencilIndex8 = unchecked((int)36168),
				// GL_STENCIL_INDEX16_EXT = 0x8D49
				StencilIndex16 = unchecked((int)36169),
				// GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50
				RenderbufferRedSize = unchecked((int)36176),
				// GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51
				RenderbufferGreenSize = unchecked((int)36177),
				// GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52
				RenderbufferBlueSize = unchecked((int)36178),
				// GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53
				RenderbufferAlphaSize = unchecked((int)36179),
				// GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54
				RenderbufferDepthSize = unchecked((int)36180),
				// GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55
				RenderbufferStencilSize = unchecked((int)36181),
			}
			public const string NAME_STRING = "GL_EXT_framebuffer_object";
			#region command delegates
			// void glBindFramebufferEXT (GLenum target, GLuint framebuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindFramebufferDelegate (System.UInt32 target, System.UInt32 framebuffer);
			// void glBindRenderbufferEXT (GLenum target, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindRenderbufferDelegate (System.UInt32 target, System.UInt32 renderbuffer);
			// GLenum glCheckFramebufferStatusEXT (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 CheckFramebufferStatusDelegate (System.UInt32 target);
			// void glDeleteFramebuffersEXT (GLsizei n, GLuint* framebuffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteFramebuffersDelegate (System.Int32 n, IntPtr framebuffers);
			// void glDeleteRenderbuffersEXT (GLsizei n, GLuint* renderbuffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteRenderbuffersDelegate (System.Int32 n, IntPtr renderbuffers);
			// void glFramebufferRenderbufferEXT (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferRenderbufferDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 renderbuffertarget, System.UInt32 renderbuffer);
			// void glFramebufferTexture1DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTexture1DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level);
			// void glFramebufferTexture2DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTexture2DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level);
			// void glFramebufferTexture3DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTexture3DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level, System.Int32 zoffset);
			// void glGenerateMipmapEXT (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenerateMipmapDelegate (System.UInt32 target);
			// void glGenFramebuffersEXT (GLsizei n, GLuint* framebuffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenFramebuffersDelegate (System.Int32 n, IntPtr framebuffers);
			// void glGenRenderbuffersEXT (GLsizei n, GLuint* renderbuffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenRenderbuffersDelegate (System.Int32 n, IntPtr renderbuffers);
			// void glGetFramebufferAttachmentParameterivEXT (GLenum target, GLenum attachment, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFramebufferAttachmentParameterivDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 pname, IntPtr @params);
			// void glGetRenderbufferParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetRenderbufferParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsFramebufferEXT (GLuint framebuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsFramebufferDelegate (System.UInt32 framebuffer);
			// GLboolean glIsRenderbufferEXT (GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsRenderbufferDelegate (System.UInt32 renderbuffer);
			// void glRenderbufferStorageEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RenderbufferStorageDelegate (System.UInt32 target, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			#endregion // command delegates
			#region commands
			// void glBindFramebufferEXT (GLenum target, GLuint framebuffer)
			public readonly BindFramebufferDelegate BindFramebuffer;
			// void glBindRenderbufferEXT (GLenum target, GLuint renderbuffer)
			public readonly BindRenderbufferDelegate BindRenderbuffer;
			// GLenum glCheckFramebufferStatusEXT (GLenum target)
			public readonly CheckFramebufferStatusDelegate CheckFramebufferStatus;
			// void glDeleteFramebuffersEXT (GLsizei n, GLuint* framebuffers)
			public readonly DeleteFramebuffersDelegate DeleteFramebuffers;
			// void glDeleteRenderbuffersEXT (GLsizei n, GLuint* renderbuffers)
			public readonly DeleteRenderbuffersDelegate DeleteRenderbuffers;
			// void glFramebufferRenderbufferEXT (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
			public readonly FramebufferRenderbufferDelegate FramebufferRenderbuffer;
			// void glFramebufferTexture1DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			public readonly FramebufferTexture1DDelegate FramebufferTexture1D;
			// void glFramebufferTexture2DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
			public readonly FramebufferTexture2DDelegate FramebufferTexture2D;
			// void glFramebufferTexture3DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
			public readonly FramebufferTexture3DDelegate FramebufferTexture3D;
			// void glGenerateMipmapEXT (GLenum target)
			public readonly GenerateMipmapDelegate GenerateMipmap;
			// void glGenFramebuffersEXT (GLsizei n, GLuint* framebuffers)
			public readonly GenFramebuffersDelegate GenFramebuffers;
			// void glGenRenderbuffersEXT (GLsizei n, GLuint* renderbuffers)
			public readonly GenRenderbuffersDelegate GenRenderbuffers;
			// void glGetFramebufferAttachmentParameterivEXT (GLenum target, GLenum attachment, GLenum pname, GLint* params)
			public readonly GetFramebufferAttachmentParameterivDelegate GetFramebufferAttachmentParameteriv;
			// void glGetRenderbufferParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetRenderbufferParameterivDelegate GetRenderbufferParameteriv;
			// GLboolean glIsFramebufferEXT (GLuint framebuffer)
			public readonly IsFramebufferDelegate IsFramebuffer;
			// GLboolean glIsRenderbufferEXT (GLuint renderbuffer)
			public readonly IsRenderbufferDelegate IsRenderbuffer;
			// void glRenderbufferStorageEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly RenderbufferStorageDelegate RenderbufferStorage;
			#endregion // commands
			public ExtFramebufferObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindFramebufferEXT", out BindFramebuffer);
				resolver.LoadHandle ("glBindRenderbufferEXT", out BindRenderbuffer);
				resolver.LoadHandle ("glCheckFramebufferStatusEXT", out CheckFramebufferStatus);
				resolver.LoadHandle ("glDeleteFramebuffersEXT", out DeleteFramebuffers);
				resolver.LoadHandle ("glDeleteRenderbuffersEXT", out DeleteRenderbuffers);
				resolver.LoadHandle ("glFramebufferRenderbufferEXT", out FramebufferRenderbuffer);
				resolver.LoadHandle ("glFramebufferTexture1DEXT", out FramebufferTexture1D);
				resolver.LoadHandle ("glFramebufferTexture2DEXT", out FramebufferTexture2D);
				resolver.LoadHandle ("glFramebufferTexture3DEXT", out FramebufferTexture3D);
				resolver.LoadHandle ("glGenerateMipmapEXT", out GenerateMipmap);
				resolver.LoadHandle ("glGenFramebuffersEXT", out GenFramebuffers);
				resolver.LoadHandle ("glGenRenderbuffersEXT", out GenRenderbuffers);
				resolver.LoadHandle ("glGetFramebufferAttachmentParameterivEXT", out GetFramebufferAttachmentParameteriv);
				resolver.LoadHandle ("glGetRenderbufferParameterivEXT", out GetRenderbufferParameteriv);
				resolver.LoadHandle ("glIsFramebufferEXT", out IsFramebuffer);
				resolver.LoadHandle ("glIsRenderbufferEXT", out IsRenderbuffer);
				resolver.LoadHandle ("glRenderbufferStorageEXT", out RenderbufferStorage);
			}
		}
		public partial class ExtFramebufferSrgb
		{
			public enum All
			{
				// GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9
				FramebufferSrgb = unchecked((int)36281),
				// GL_FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA
				FramebufferSrgbCapable = unchecked((int)36282),
			}
			public const string NAME_STRING = "GL_EXT_framebuffer_sRGB";
		}
		public partial class ExtGeometryShader4
		{
			public enum All
			{
				// GL_LINES_ADJACENCY_EXT = 0xA
				LinesAdjacency = unchecked((int)10),
				// GL_LINE_STRIP_ADJACENCY_EXT = 0xB
				LineStripAdjacency = unchecked((int)11),
				// GL_TRIANGLES_ADJACENCY_EXT = 0xC
				TrianglesAdjacency = unchecked((int)12),
				// GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0xD
				TriangleStripAdjacency = unchecked((int)13),
				// GL_PROGRAM_POINT_SIZE_EXT = 0x8642
				ProgramPointSize = unchecked((int)34370),
				// GL_MAX_VARYING_COMPONENTS_EXT = 0x8B4B
				MaxVaryingComponents = unchecked((int)35659),
				// GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29
				MaxGeometryTextureImageUnits = unchecked((int)35881),
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4
				FramebufferAttachmentTextureLayer = unchecked((int)36052),
				// GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7
				FramebufferAttachmentLayered = unchecked((int)36263),
				// GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8
				FramebufferIncompleteLayerTargets = unchecked((int)36264),
				// GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9
				FramebufferIncompleteLayerCount = unchecked((int)36265),
				// GL_GEOMETRY_SHADER_EXT = 0x8DD9
				GeometryShader = unchecked((int)36313),
				// GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA
				GeometryVerticesOut = unchecked((int)36314),
				// GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB
				GeometryInputType = unchecked((int)36315),
				// GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC
				GeometryOutputType = unchecked((int)36316),
				// GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD
				MaxGeometryVaryingComponents = unchecked((int)36317),
				// GL_MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE
				MaxVertexVaryingComponents = unchecked((int)36318),
				// GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF
				MaxGeometryUniformComponents = unchecked((int)36319),
				// GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0
				MaxGeometryOutputVertices = unchecked((int)36320),
				// GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1
				MaxGeometryTotalOutputComponents = unchecked((int)36321),
			}
			public const string NAME_STRING = "GL_EXT_geometry_shader4";
			#region command delegates
			// void glProgramParameteriEXT (GLuint program, GLenum pname, GLint value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameteriDelegate (System.UInt32 program, System.UInt32 pname, System.Int32 value);
			#endregion // command delegates
			#region commands
			// void glProgramParameteriEXT (GLuint program, GLenum pname, GLint value)
			public readonly ProgramParameteriDelegate ProgramParameteri;
			#endregion // commands
			public ExtGeometryShader4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glProgramParameteriEXT", out ProgramParameteri);
			}
		}
		public partial class ExtGpuProgramParameters
		{
			public const string NAME_STRING = "GL_EXT_gpu_program_parameters";
			#region command delegates
			// void glProgramEnvParameters4fvEXT (GLenum target, GLuint index, GLsizei count, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameters4fvDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glProgramLocalParameters4fvEXT (GLenum target, GLuint index, GLsizei count, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameters4fvDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glProgramEnvParameters4fvEXT (GLenum target, GLuint index, GLsizei count, GLfloat* params)
			public readonly ProgramEnvParameters4fvDelegate ProgramEnvParameters4fv;
			// void glProgramLocalParameters4fvEXT (GLenum target, GLuint index, GLsizei count, GLfloat* params)
			public readonly ProgramLocalParameters4fvDelegate ProgramLocalParameters4fv;
			#endregion // commands
			public ExtGpuProgramParameters (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glProgramEnvParameters4fvEXT", out ProgramEnvParameters4fv);
				resolver.LoadHandle ("glProgramLocalParameters4fvEXT", out ProgramLocalParameters4fv);
			}
		}
		public partial class ExtGpuShader4
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD
				VertexAttribArrayInteger = unchecked((int)35069),
				// GL_MIN_PROGRAM_TEXEL_OFFSET_EXT = 0x8904
				MinProgramTexelOffset = unchecked((int)35076),
				// GL_MAX_PROGRAM_TEXEL_OFFSET_EXT = 0x8905
				MaxProgramTexelOffset = unchecked((int)35077),
				// GL_SAMPLER_1D_ARRAY_EXT = 0x8DC0
				Sampler1dArray = unchecked((int)36288),
				// GL_SAMPLER_2D_ARRAY_EXT = 0x8DC1
				Sampler2dArray = unchecked((int)36289),
				// GL_SAMPLER_BUFFER_EXT = 0x8DC2
				SamplerBuffer = unchecked((int)36290),
				// GL_SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3
				Sampler1dArrayShadow = unchecked((int)36291),
				// GL_SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4
				Sampler2dArrayShadow = unchecked((int)36292),
				// GL_SAMPLER_CUBE_SHADOW_EXT = 0x8DC5
				SamplerCubeShadow = unchecked((int)36293),
				// GL_UNSIGNED_INT_VEC2_EXT = 0x8DC6
				UnsignedIntVec2 = unchecked((int)36294),
				// GL_UNSIGNED_INT_VEC3_EXT = 0x8DC7
				UnsignedIntVec3 = unchecked((int)36295),
				// GL_UNSIGNED_INT_VEC4_EXT = 0x8DC8
				UnsignedIntVec4 = unchecked((int)36296),
				// GL_INT_SAMPLER_1D_EXT = 0x8DC9
				IntSampler1d = unchecked((int)36297),
				// GL_INT_SAMPLER_2D_EXT = 0x8DCA
				IntSampler2d = unchecked((int)36298),
				// GL_INT_SAMPLER_3D_EXT = 0x8DCB
				IntSampler3d = unchecked((int)36299),
				// GL_INT_SAMPLER_CUBE_EXT = 0x8DCC
				IntSamplerCube = unchecked((int)36300),
				// GL_INT_SAMPLER_2D_RECT_EXT = 0x8DCD
				IntSampler2dRect = unchecked((int)36301),
				// GL_INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE
				IntSampler1dArray = unchecked((int)36302),
				// GL_INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF
				IntSampler2dArray = unchecked((int)36303),
				// GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0
				IntSamplerBuffer = unchecked((int)36304),
				// GL_UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1
				UnsignedIntSampler1d = unchecked((int)36305),
				// GL_UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2
				UnsignedIntSampler2d = unchecked((int)36306),
				// GL_UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3
				UnsignedIntSampler3d = unchecked((int)36307),
				// GL_UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4
				UnsignedIntSamplerCube = unchecked((int)36308),
				// GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5
				UnsignedIntSampler2dRect = unchecked((int)36309),
				// GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6
				UnsignedIntSampler1dArray = unchecked((int)36310),
				// GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7
				UnsignedIntSampler2dArray = unchecked((int)36311),
				// GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8
				UnsignedIntSamplerBuffer = unchecked((int)36312),
			}
			public const string NAME_STRING = "GL_EXT_gpu_shader4";
			#region command delegates
			// void glBindFragDataLocationEXT (GLuint program, GLuint color, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindFragDataLocationDelegate (System.UInt32 program, System.UInt32 color, IntPtr name);
			// GLint glGetFragDataLocationEXT (GLuint program, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetFragDataLocationDelegate (System.UInt32 program, StringPtr name);
			// void glGetUniformuivEXT (GLuint program, GLint location, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformuivDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
			// void glUniform1uiEXT (GLint location, GLuint v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1uiDelegate (System.Int32 location, System.UInt32 v0);
			// void glUniform1uivEXT (GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2uiEXT (GLint location, GLuint v0, GLuint v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1);
			// void glUniform2uivEXT (GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2);
			// void glUniform3uivEXT (GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2, System.UInt32 v3);
			// void glUniform4uivEXT (GLint location, GLsizei count, GLuint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			#endregion // command delegates
			#region commands
			// void glBindFragDataLocationEXT (GLuint program, GLuint color, GLchar* name)
			public readonly BindFragDataLocationDelegate BindFragDataLocation;
			// GLint glGetFragDataLocationEXT (GLuint program, GLchar* name)
			public readonly GetFragDataLocationDelegate GetFragDataLocation;
			// void glGetUniformuivEXT (GLuint program, GLint location, GLuint* params)
			public readonly GetUniformuivDelegate GetUniformuiv;
			// void glUniform1uiEXT (GLint location, GLuint v0)
			public readonly Uniform1uiDelegate Uniform1ui;
			// void glUniform1uivEXT (GLint location, GLsizei count, GLuint* value)
			public readonly Uniform1uivDelegate Uniform1uiv;
			// void glUniform2uiEXT (GLint location, GLuint v0, GLuint v1)
			public readonly Uniform2uiDelegate Uniform2ui;
			// void glUniform2uivEXT (GLint location, GLsizei count, GLuint* value)
			public readonly Uniform2uivDelegate Uniform2uiv;
			// void glUniform3uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2)
			public readonly Uniform3uiDelegate Uniform3ui;
			// void glUniform3uivEXT (GLint location, GLsizei count, GLuint* value)
			public readonly Uniform3uivDelegate Uniform3uiv;
			// void glUniform4uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
			public readonly Uniform4uiDelegate Uniform4ui;
			// void glUniform4uivEXT (GLint location, GLsizei count, GLuint* value)
			public readonly Uniform4uivDelegate Uniform4uiv;
			#endregion // commands
			public ExtGpuShader4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindFragDataLocationEXT", out BindFragDataLocation);
				resolver.LoadHandle ("glGetFragDataLocationEXT", out GetFragDataLocation);
				resolver.LoadHandle ("glGetUniformuivEXT", out GetUniformuiv);
				resolver.LoadHandle ("glUniform1uiEXT", out Uniform1ui);
				resolver.LoadHandle ("glUniform1uivEXT", out Uniform1uiv);
				resolver.LoadHandle ("glUniform2uiEXT", out Uniform2ui);
				resolver.LoadHandle ("glUniform2uivEXT", out Uniform2uiv);
				resolver.LoadHandle ("glUniform3uiEXT", out Uniform3ui);
				resolver.LoadHandle ("glUniform3uivEXT", out Uniform3uiv);
				resolver.LoadHandle ("glUniform4uiEXT", out Uniform4ui);
				resolver.LoadHandle ("glUniform4uivEXT", out Uniform4uiv);
			}
		}
		public partial class ExtHistogram
		{
			public enum All
			{
				// GL_HISTOGRAM_EXT = 0x8024
				Histogram = unchecked((int)32804),
				// GL_PROXY_HISTOGRAM_EXT = 0x8025
				ProxyHistogram = unchecked((int)32805),
				// GL_HISTOGRAM_WIDTH_EXT = 0x8026
				HistogramWidth = unchecked((int)32806),
				// GL_HISTOGRAM_FORMAT_EXT = 0x8027
				HistogramFormat = unchecked((int)32807),
				// GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
				HistogramRedSize = unchecked((int)32808),
				// GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
				HistogramGreenSize = unchecked((int)32809),
				// GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
				HistogramBlueSize = unchecked((int)32810),
				// GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
				HistogramAlphaSize = unchecked((int)32811),
				// GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
				HistogramLuminanceSize = unchecked((int)32812),
				// GL_HISTOGRAM_SINK_EXT = 0x802D
				HistogramSink = unchecked((int)32813),
				// GL_MINMAX_EXT = 0x802E
				Minmax = unchecked((int)32814),
				// GL_MINMAX_FORMAT_EXT = 0x802F
				MinmaxFormat = unchecked((int)32815),
				// GL_MINMAX_SINK_EXT = 0x8030
				MinmaxSink = unchecked((int)32816),
				// GL_TABLE_TOO_LARGE_EXT = 0x8031
				TableTooLarge = unchecked((int)32817),
			}
			public const string NAME_STRING = "GL_EXT_histogram";
			#region command delegates
			// void glGetHistogramEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetHistogramDelegate (HistogramTargetEXT target, Boolean reset, PixelFormat format, PixelType type, IntPtr values);
			// void glGetHistogramParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetHistogramParameterfvDelegate (HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, IntPtr @params);
			// void glGetHistogramParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetHistogramParameterivDelegate (HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, IntPtr @params);
			// void glGetMinmaxEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMinmaxDelegate (MinmaxTargetEXT target, Boolean reset, PixelFormat format, PixelType type, IntPtr values);
			// void glGetMinmaxParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMinmaxParameterfvDelegate (MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, IntPtr @params);
			// void glGetMinmaxParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMinmaxParameterivDelegate (MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, IntPtr @params);
			// void glHistogramEXT (GLenum target, GLsizei width, GLenum internalformat, GLboolean sink)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void HistogramDelegate (HistogramTargetEXT target, System.Int32 width, System.UInt32 internalformat, Boolean sink);
			// void glMinmaxEXT (GLenum target, GLenum internalformat, GLboolean sink)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MinmaxDelegate (MinmaxTargetEXT target, System.UInt32 internalformat, Boolean sink);
			// void glResetHistogramEXT (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ResetHistogramDelegate (HistogramTargetEXT target);
			// void glResetMinmaxEXT (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ResetMinmaxDelegate (MinmaxTargetEXT target);
			#endregion // command delegates
			#region commands
			// void glGetHistogramEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)
			public readonly GetHistogramDelegate GetHistogram;
			// void glGetHistogramParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetHistogramParameterfvDelegate GetHistogramParameterfv;
			// void glGetHistogramParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetHistogramParameterivDelegate GetHistogramParameteriv;
			// void glGetMinmaxEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, void* values)
			public readonly GetMinmaxDelegate GetMinmax;
			// void glGetMinmaxParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetMinmaxParameterfvDelegate GetMinmaxParameterfv;
			// void glGetMinmaxParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetMinmaxParameterivDelegate GetMinmaxParameteriv;
			// void glHistogramEXT (GLenum target, GLsizei width, GLenum internalformat, GLboolean sink)
			public readonly HistogramDelegate Histogram;
			// void glMinmaxEXT (GLenum target, GLenum internalformat, GLboolean sink)
			public readonly MinmaxDelegate Minmax;
			// void glResetHistogramEXT (GLenum target)
			public readonly ResetHistogramDelegate ResetHistogram;
			// void glResetMinmaxEXT (GLenum target)
			public readonly ResetMinmaxDelegate ResetMinmax;
			#endregion // commands
			public ExtHistogram (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetHistogramEXT", out GetHistogram);
				resolver.LoadHandle ("glGetHistogramParameterfvEXT", out GetHistogramParameterfv);
				resolver.LoadHandle ("glGetHistogramParameterivEXT", out GetHistogramParameteriv);
				resolver.LoadHandle ("glGetMinmaxEXT", out GetMinmax);
				resolver.LoadHandle ("glGetMinmaxParameterfvEXT", out GetMinmaxParameterfv);
				resolver.LoadHandle ("glGetMinmaxParameterivEXT", out GetMinmaxParameteriv);
				resolver.LoadHandle ("glHistogramEXT", out Histogram);
				resolver.LoadHandle ("glMinmaxEXT", out Minmax);
				resolver.LoadHandle ("glResetHistogramEXT", out ResetHistogram);
				resolver.LoadHandle ("glResetMinmaxEXT", out ResetMinmax);
			}
		}
		public partial class ExtIndexArrayFormats
		{
			public enum All
			{
				// GL_IUI_V2F_EXT = 0x81AD
				IuiV2f = unchecked((int)33197),
				// GL_IUI_V3F_EXT = 0x81AE
				IuiV3f = unchecked((int)33198),
				// GL_IUI_N3F_V2F_EXT = 0x81AF
				IuiN3fV2f = unchecked((int)33199),
				// GL_IUI_N3F_V3F_EXT = 0x81B0
				IuiN3fV3f = unchecked((int)33200),
				// GL_T2F_IUI_V2F_EXT = 0x81B1
				T2fIuiV2f = unchecked((int)33201),
				// GL_T2F_IUI_V3F_EXT = 0x81B2
				T2fIuiV3f = unchecked((int)33202),
				// GL_T2F_IUI_N3F_V2F_EXT = 0x81B3
				T2fIuiN3fV2f = unchecked((int)33203),
				// GL_T2F_IUI_N3F_V3F_EXT = 0x81B4
				T2fIuiN3fV3f = unchecked((int)33204),
			}
			public const string NAME_STRING = "GL_EXT_index_array_formats";
		}
		public partial class ExtIndexFunc
		{
			public enum All
			{
				// GL_INDEX_TEST_EXT = 0x81B5
				IndexTest = unchecked((int)33205),
				// GL_INDEX_TEST_FUNC_EXT = 0x81B6
				IndexTestFunc = unchecked((int)33206),
				// GL_INDEX_TEST_REF_EXT = 0x81B7
				IndexTestRef = unchecked((int)33207),
			}
			public const string NAME_STRING = "GL_EXT_index_func";
			#region command delegates
			// void glIndexFuncEXT (GLenum func, GLclampf ref)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexFuncDelegate (System.UInt32 func, System.Single @ref);
			#endregion // command delegates
			#region commands
			// void glIndexFuncEXT (GLenum func, GLclampf ref)
			public readonly IndexFuncDelegate IndexFunc;
			#endregion // commands
			public ExtIndexFunc (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glIndexFuncEXT", out IndexFunc);
			}
		}
		public partial class ExtIndexMaterial
		{
			public enum All
			{
				// GL_INDEX_MATERIAL_EXT = 0x81B8
				IndexMaterial = unchecked((int)33208),
				// GL_INDEX_MATERIAL_PARAMETER_EXT = 0x81B9
				IndexMaterialParameter = unchecked((int)33209),
				// GL_INDEX_MATERIAL_FACE_EXT = 0x81BA
				IndexMaterialFace = unchecked((int)33210),
			}
			public const string NAME_STRING = "GL_EXT_index_material";
			#region command delegates
			// void glIndexMaterialEXT (GLenum face, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexMaterialDelegate (MaterialFace face, System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glIndexMaterialEXT (GLenum face, GLenum mode)
			public readonly IndexMaterialDelegate IndexMaterial;
			#endregion // commands
			public ExtIndexMaterial (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glIndexMaterialEXT", out IndexMaterial);
			}
		}
		public partial class ExtLightTexture
		{
			public enum All
			{
				// GL_FRAGMENT_MATERIAL_EXT = 0x8349
				FragmentMaterial = unchecked((int)33609),
				// GL_FRAGMENT_NORMAL_EXT = 0x834A
				FragmentNormal = unchecked((int)33610),
				// GL_FRAGMENT_COLOR_EXT = 0x834C
				FragmentColor = unchecked((int)33612),
				// GL_ATTENUATION_EXT = 0x834D
				Attenuation = unchecked((int)33613),
				// GL_SHADOW_ATTENUATION_EXT = 0x834E
				ShadowAttenuation = unchecked((int)33614),
				// GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F
				TextureApplicationMode = unchecked((int)33615),
				// GL_TEXTURE_LIGHT_EXT = 0x8350
				TextureLight = unchecked((int)33616),
				// GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351
				TextureMaterialFace = unchecked((int)33617),
				// GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352
				TextureMaterialParameter = unchecked((int)33618),
			}
			public const string NAME_STRING = "GL_EXT_light_texture";
			#region command delegates
			// void glApplyTextureEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ApplyTextureDelegate (System.UInt32 mode);
			// void glTextureLightEXT (GLenum pname)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureLightDelegate (System.UInt32 pname);
			// void glTextureMaterialEXT (GLenum face, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureMaterialDelegate (MaterialFace face, MaterialParameter mode);
			#endregion // command delegates
			#region commands
			// void glApplyTextureEXT (GLenum mode)
			public readonly ApplyTextureDelegate ApplyTexture;
			// void glTextureLightEXT (GLenum pname)
			public readonly TextureLightDelegate TextureLight;
			// void glTextureMaterialEXT (GLenum face, GLenum mode)
			public readonly TextureMaterialDelegate TextureMaterial;
			#endregion // commands
			public ExtLightTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glApplyTextureEXT", out ApplyTexture);
				resolver.LoadHandle ("glTextureLightEXT", out TextureLight);
				resolver.LoadHandle ("glTextureMaterialEXT", out TextureMaterial);
			}
		}
		public partial class ExtMultiDrawArrays
		{
			public const string NAME_STRING = "GL_EXT_multi_draw_arrays";
			#region command delegates
			// void glMultiDrawArraysEXT (GLenum mode, GLint* first, GLsizei* count, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawArraysDelegate (PrimitiveType mode, IntPtr first, IntPtr count, System.Int32 primcount);
			// void glMultiDrawElementsEXT (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementsDelegate (PrimitiveType mode, IntPtr count, System.UInt32 type, IntPtr indices, System.Int32 primcount);
			#endregion // command delegates
			#region commands
			// void glMultiDrawArraysEXT (GLenum mode, GLint* first, GLsizei* count, GLsizei primcount)
			public readonly MultiDrawArraysDelegate MultiDrawArrays;
			// void glMultiDrawElementsEXT (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount)
			public readonly MultiDrawElementsDelegate MultiDrawElements;
			#endregion // commands
			public ExtMultiDrawArrays (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiDrawArraysEXT", out MultiDrawArrays);
				resolver.LoadHandle ("glMultiDrawElementsEXT", out MultiDrawElements);
			}
		}
		public partial class ExtMultisample
		{
			public enum All
			{
				// GL_MULTISAMPLE_EXT = 0x809D
				Multisample = unchecked((int)32925),
				// GL_SAMPLE_ALPHA_TO_MASK_EXT = 0x809E
				SampleAlphaToMask = unchecked((int)32926),
				// GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F
				SampleAlphaToOne = unchecked((int)32927),
				// GL_SAMPLE_MASK_EXT = 0x80A0
				SampleMask = unchecked((int)32928),
				// GL_1PASS_EXT = 0x80A1
				_1pass = unchecked((int)32929),
				// GL_2PASS_0_EXT = 0x80A2
				_2pass0 = unchecked((int)32930),
				// GL_2PASS_1_EXT = 0x80A3
				_2pass1 = unchecked((int)32931),
				// GL_4PASS_0_EXT = 0x80A4
				_4pass0 = unchecked((int)32932),
				// GL_4PASS_1_EXT = 0x80A5
				_4pass1 = unchecked((int)32933),
				// GL_4PASS_2_EXT = 0x80A6
				_4pass2 = unchecked((int)32934),
				// GL_4PASS_3_EXT = 0x80A7
				_4pass3 = unchecked((int)32935),
				// GL_SAMPLE_BUFFERS_EXT = 0x80A8
				SampleBuffers = unchecked((int)32936),
				// GL_SAMPLES_EXT = 0x80A9
				Samples = unchecked((int)32937),
				// GL_SAMPLE_MASK_VALUE_EXT = 0x80AA
				SampleMaskValue = unchecked((int)32938),
				// GL_SAMPLE_MASK_INVERT_EXT = 0x80AB
				SampleMaskInvert = unchecked((int)32939),
				// GL_SAMPLE_PATTERN_EXT = 0x80AC
				SamplePattern = unchecked((int)32940),
				// GL_MULTISAMPLE_BIT_EXT = 0x20000000
				MultisampleBit = unchecked((int)536870912),
			}
			public const string NAME_STRING = "GL_EXT_multisample";
			#region command delegates
			// void glSampleMaskEXT (GLclampf value, GLboolean invert)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SampleMaskDelegate (System.Single value, Boolean invert);
			// void glSamplePatternEXT (GLenum pattern)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SamplePatternDelegate (System.UInt32 pattern);
			#endregion // command delegates
			#region commands
			// void glSampleMaskEXT (GLclampf value, GLboolean invert)
			public readonly SampleMaskDelegate SampleMask;
			// void glSamplePatternEXT (GLenum pattern)
			public readonly SamplePatternDelegate SamplePattern;
			#endregion // commands
			public ExtMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSampleMaskEXT", out SampleMask);
				resolver.LoadHandle ("glSamplePatternEXT", out SamplePattern);
			}
		}
		public partial class ExtPackedDepthStencil
		{
			public enum All
			{
				// GL_DEPTH_STENCIL_EXT = 0x84F9
				DepthStencil = unchecked((int)34041),
				// GL_UNSIGNED_INT_24_8_EXT = 0x84FA
				UnsignedInt248 = unchecked((int)34042),
				// GL_DEPTH24_STENCIL8_EXT = 0x88F0
				Depth24Stencil8 = unchecked((int)35056),
				// GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1
				TextureStencilSize = unchecked((int)35057),
			}
			public const string NAME_STRING = "GL_EXT_packed_depth_stencil";
		}
		public partial class ExtPackedFloat
		{
			public enum All
			{
				// GL_R11F_G11F_B10F_EXT = 0x8C3A
				R11fG11fB10f = unchecked((int)35898),
				// GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B
				UnsignedInt10f11f11fRev = unchecked((int)35899),
				// GL_RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C
				RgbaSignedComponents = unchecked((int)35900),
			}
			public const string NAME_STRING = "GL_EXT_packed_float";
		}
		public partial class ExtPackedPixels
		{
			public enum All
			{
				// GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
				UnsignedByte332 = unchecked((int)32818),
				// GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
				UnsignedShort4444 = unchecked((int)32819),
				// GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
				UnsignedShort5551 = unchecked((int)32820),
				// GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
				UnsignedInt8888 = unchecked((int)32821),
				// GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
				UnsignedInt1010102 = unchecked((int)32822),
			}
			public const string NAME_STRING = "GL_EXT_packed_pixels";
		}
		public partial class ExtPalettedTexture
		{
			public enum All
			{
				// GL_COLOR_INDEX1_EXT = 0x80E2
				ColorIndex1 = unchecked((int)32994),
				// GL_COLOR_INDEX2_EXT = 0x80E3
				ColorIndex2 = unchecked((int)32995),
				// GL_COLOR_INDEX4_EXT = 0x80E4
				ColorIndex4 = unchecked((int)32996),
				// GL_COLOR_INDEX8_EXT = 0x80E5
				ColorIndex8 = unchecked((int)32997),
				// GL_COLOR_INDEX12_EXT = 0x80E6
				ColorIndex12 = unchecked((int)32998),
				// GL_COLOR_INDEX16_EXT = 0x80E7
				ColorIndex16 = unchecked((int)32999),
				// GL_TEXTURE_INDEX_SIZE_EXT = 0x80ED
				TextureIndexSize = unchecked((int)33005),
			}
			public const string NAME_STRING = "GL_EXT_paletted_texture";
			#region command delegates
			// void glColorTableEXT (GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, void* table)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorTableDelegate (System.UInt32 target, System.UInt32 internalFormat, System.Int32 width, PixelFormat format, PixelType type, IntPtr table);
			// void glGetColorTableEXT (GLenum target, GLenum format, GLenum type, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableDelegate (System.UInt32 target, PixelFormat format, PixelType type, IntPtr data);
			// void glGetColorTableParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableParameterfvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetColorTableParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glColorTableEXT (GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, void* table)
			public readonly ColorTableDelegate ColorTable;
			// void glGetColorTableEXT (GLenum target, GLenum format, GLenum type, void* data)
			public readonly GetColorTableDelegate GetColorTable;
			// void glGetColorTableParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetColorTableParameterfvDelegate GetColorTableParameterfv;
			// void glGetColorTableParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetColorTableParameterivDelegate GetColorTableParameteriv;
			#endregion // commands
			public ExtPalettedTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorTableEXT", out ColorTable);
				resolver.LoadHandle ("glGetColorTableEXT", out GetColorTable);
				resolver.LoadHandle ("glGetColorTableParameterfvEXT", out GetColorTableParameterfv);
				resolver.LoadHandle ("glGetColorTableParameterivEXT", out GetColorTableParameteriv);
			}
		}
		public partial class ExtPixelBufferObject
		{
			public enum All
			{
				// GL_PIXEL_PACK_BUFFER_EXT = 0x88EB
				PixelPackBuffer = unchecked((int)35051),
				// GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC
				PixelUnpackBuffer = unchecked((int)35052),
				// GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED
				PixelPackBufferBinding = unchecked((int)35053),
				// GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF
				PixelUnpackBufferBinding = unchecked((int)35055),
			}
			public const string NAME_STRING = "GL_EXT_pixel_buffer_object";
		}
		public partial class ExtPixelTransform
		{
			public enum All
			{
				// GL_PIXEL_TRANSFORM_2D_EXT = 0x8330
				PixelTransform2d = unchecked((int)33584),
				// GL_PIXEL_MAG_FILTER_EXT = 0x8331
				PixelMagFilter = unchecked((int)33585),
				// GL_PIXEL_MIN_FILTER_EXT = 0x8332
				PixelMinFilter = unchecked((int)33586),
				// GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333
				PixelCubicWeight = unchecked((int)33587),
				// GL_CUBIC_EXT = 0x8334
				Cubic = unchecked((int)33588),
				// GL_AVERAGE_EXT = 0x8335
				Average = unchecked((int)33589),
				// GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336
				PixelTransform2dStackDepth = unchecked((int)33590),
				// GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337
				MaxPixelTransform2dStackDepth = unchecked((int)33591),
				// GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338
				PixelTransform2dMatrix = unchecked((int)33592),
			}
			public const string NAME_STRING = "GL_EXT_pixel_transform";
			#region command delegates
			// void glGetPixelTransformParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPixelTransformParameterfvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetPixelTransformParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPixelTransformParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glPixelTransformParameterfEXT (GLenum target, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTransformParameterfDelegate (System.UInt32 target, System.UInt32 pname, System.Single param);
			// void glPixelTransformParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTransformParameterfvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glPixelTransformParameteriEXT (GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTransformParameteriDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glPixelTransformParameterivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTransformParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetPixelTransformParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetPixelTransformParameterfvDelegate GetPixelTransformParameterfv;
			// void glGetPixelTransformParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetPixelTransformParameterivDelegate GetPixelTransformParameteriv;
			// void glPixelTransformParameterfEXT (GLenum target, GLenum pname, GLfloat param)
			public readonly PixelTransformParameterfDelegate PixelTransformParameterf;
			// void glPixelTransformParameterfvEXT (GLenum target, GLenum pname, GLfloat* params)
			public readonly PixelTransformParameterfvDelegate PixelTransformParameterfv;
			// void glPixelTransformParameteriEXT (GLenum target, GLenum pname, GLint param)
			public readonly PixelTransformParameteriDelegate PixelTransformParameteri;
			// void glPixelTransformParameterivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly PixelTransformParameterivDelegate PixelTransformParameteriv;
			#endregion // commands
			public ExtPixelTransform (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetPixelTransformParameterfvEXT", out GetPixelTransformParameterfv);
				resolver.LoadHandle ("glGetPixelTransformParameterivEXT", out GetPixelTransformParameteriv);
				resolver.LoadHandle ("glPixelTransformParameterfEXT", out PixelTransformParameterf);
				resolver.LoadHandle ("glPixelTransformParameterfvEXT", out PixelTransformParameterfv);
				resolver.LoadHandle ("glPixelTransformParameteriEXT", out PixelTransformParameteri);
				resolver.LoadHandle ("glPixelTransformParameterivEXT", out PixelTransformParameteriv);
			}
		}
		public partial class ExtPointParameters
		{
			public enum All
			{
				// GL_POINT_SIZE_MIN_EXT = 0x8126
				PointSizeMin = unchecked((int)33062),
				// GL_POINT_SIZE_MAX_EXT = 0x8127
				PointSizeMax = unchecked((int)33063),
				// GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
				PointFadeThresholdSize = unchecked((int)33064),
				// GL_DISTANCE_ATTENUATION_EXT = 0x8129
				DistanceAttenuation = unchecked((int)33065),
			}
			public const string NAME_STRING = "GL_EXT_point_parameters";
			#region command delegates
			// void glPointParameterfEXT (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfDelegate (System.UInt32 pname, System.Single param);
			// void glPointParameterfvEXT (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glPointParameterfEXT (GLenum pname, GLfloat param)
			public readonly PointParameterfDelegate PointParameterf;
			// void glPointParameterfvEXT (GLenum pname, GLfloat* params)
			public readonly PointParameterfvDelegate PointParameterfv;
			#endregion // commands
			public ExtPointParameters (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPointParameterfEXT", out PointParameterf);
				resolver.LoadHandle ("glPointParameterfvEXT", out PointParameterfv);
			}
		}
		public partial class ExtPolygonOffset
		{
			public enum All
			{
				// GL_POLYGON_OFFSET_EXT = 0x8037
				PolygonOffset = unchecked((int)32823),
				// GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038
				PolygonOffsetFactor = unchecked((int)32824),
				// GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
				PolygonOffsetBias = unchecked((int)32825),
			}
			public const string NAME_STRING = "GL_EXT_polygon_offset";
			#region command delegates
			// void glPolygonOffsetEXT (GLfloat factor, GLfloat bias)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PolygonOffsetDelegate (System.Single factor, System.Single bias);
			#endregion // command delegates
			#region commands
			// void glPolygonOffsetEXT (GLfloat factor, GLfloat bias)
			public readonly PolygonOffsetDelegate PolygonOffset;
			#endregion // commands
			public ExtPolygonOffset (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPolygonOffsetEXT", out PolygonOffset);
			}
		}
		public partial class ExtPolygonOffsetClamp
		{
			public enum All
			{
				// GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B
				PolygonOffsetClamp = unchecked((int)36379),
			}
			public const string NAME_STRING = "GL_EXT_polygon_offset_clamp";
			#region command delegates
			// void glPolygonOffsetClampEXT (GLfloat factor, GLfloat units, GLfloat clamp)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PolygonOffsetClampDelegate (System.Single factor, System.Single units, System.Single clamp);
			#endregion // command delegates
			#region commands
			// void glPolygonOffsetClampEXT (GLfloat factor, GLfloat units, GLfloat clamp)
			public readonly PolygonOffsetClampDelegate PolygonOffsetClamp;
			#endregion // commands
			public ExtPolygonOffsetClamp (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPolygonOffsetClampEXT", out PolygonOffsetClamp);
			}
		}
		public partial class ExtProvokingVertex
		{
			public enum All
			{
				// GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C
				QuadsFollowProvokingVertexConvention = unchecked((int)36428),
				// GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D
				FirstVertexConvention = unchecked((int)36429),
				// GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E
				LastVertexConvention = unchecked((int)36430),
				// GL_PROVOKING_VERTEX_EXT = 0x8E4F
				ProvokingVertex = unchecked((int)36431),
			}
			public const string NAME_STRING = "GL_EXT_provoking_vertex";
			#region command delegates
			// void glProvokingVertexEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProvokingVertexDelegate (System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glProvokingVertexEXT (GLenum mode)
			public readonly ProvokingVertexDelegate ProvokingVertex;
			#endregion // commands
			public ExtProvokingVertex (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glProvokingVertexEXT", out ProvokingVertex);
			}
		}
		public partial class ExtRasterMultisample
		{
			public enum All
			{
				// GL_RASTER_MULTISAMPLE_EXT = 0x9327
				RasterMultisample = unchecked((int)37671),
				// GL_RASTER_SAMPLES_EXT = 0x9328
				RasterSamples = unchecked((int)37672),
				// GL_MAX_RASTER_SAMPLES_EXT = 0x9329
				MaxRasterSamples = unchecked((int)37673),
				// GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A
				RasterFixedSampleLocations = unchecked((int)37674),
				// GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B
				MultisampleRasterizationAllowed = unchecked((int)37675),
				// GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C
				EffectiveRasterSamples = unchecked((int)37676),
			}
			public const string NAME_STRING = "GL_EXT_raster_multisample";
			#region command delegates
			// void glRasterSamplesEXT (GLuint samples, GLboolean fixedsamplelocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterSamplesDelegate (System.UInt32 samples, System.Boolean fixedsamplelocations);
			#endregion // command delegates
			#region commands
			// void glRasterSamplesEXT (GLuint samples, GLboolean fixedsamplelocations)
			public readonly RasterSamplesDelegate RasterSamples;
			#endregion // commands
			public ExtRasterMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glRasterSamplesEXT", out RasterSamples);
			}
		}
		public partial class ExtRescaleNormal
		{
			public enum All
			{
				// GL_RESCALE_NORMAL_EXT = 0x803A
				RescaleNormal = unchecked((int)32826),
			}
			public const string NAME_STRING = "GL_EXT_rescale_normal";
		}
		public partial class ExtSecondaryColor
		{
			public enum All
			{
				// GL_COLOR_SUM_EXT = 0x8458
				ColorSum = unchecked((int)33880),
				// GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459
				CurrentSecondaryColor = unchecked((int)33881),
				// GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A
				SecondaryColorArraySize = unchecked((int)33882),
				// GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B
				SecondaryColorArrayType = unchecked((int)33883),
				// GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C
				SecondaryColorArrayStride = unchecked((int)33884),
				// GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D
				SecondaryColorArrayPointer = unchecked((int)33885),
				// GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E
				SecondaryColorArray = unchecked((int)33886),
			}
			public const string NAME_STRING = "GL_EXT_secondary_color";
			#region command delegates
			// void glSecondaryColor3bEXT (GLbyte red, GLbyte green, GLbyte blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3bDelegate (System.SByte red, System.SByte green, System.SByte blue);
			// void glSecondaryColor3bvEXT (GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3bvDelegate (IntPtr v);
			// void glSecondaryColor3dEXT (GLdouble red, GLdouble green, GLdouble blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3dDelegate (System.Double red, System.Double green, System.Double blue);
			// void glSecondaryColor3dvEXT (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3dvDelegate (IntPtr v);
			// void glSecondaryColor3fEXT (GLfloat red, GLfloat green, GLfloat blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3fDelegate (System.Single red, System.Single green, System.Single blue);
			// void glSecondaryColor3fvEXT (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3fvDelegate (IntPtr v);
			// void glSecondaryColor3iEXT (GLint red, GLint green, GLint blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3iDelegate (System.Int32 red, System.Int32 green, System.Int32 blue);
			// void glSecondaryColor3ivEXT (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3ivDelegate (IntPtr v);
			// void glSecondaryColor3sEXT (GLshort red, GLshort green, GLshort blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3sDelegate (System.Int16 red, System.Int16 green, System.Int16 blue);
			// void glSecondaryColor3svEXT (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3svDelegate (IntPtr v);
			// void glSecondaryColor3ubEXT (GLubyte red, GLubyte green, GLubyte blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3ubDelegate (System.Byte red, System.Byte green, System.Byte blue);
			// void glSecondaryColor3ubvEXT (GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3ubvDelegate (IntPtr v);
			// void glSecondaryColor3uiEXT (GLuint red, GLuint green, GLuint blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3uiDelegate (System.UInt32 red, System.UInt32 green, System.UInt32 blue);
			// void glSecondaryColor3uivEXT (GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3uivDelegate (IntPtr v);
			// void glSecondaryColor3usEXT (GLushort red, GLushort green, GLushort blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3usDelegate (System.UInt16 red, System.UInt16 green, System.UInt16 blue);
			// void glSecondaryColor3usvEXT (GLushort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3usvDelegate (IntPtr v);
			// void glSecondaryColorPointerEXT (GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColorPointerDelegate (System.Int32 size, ColorPointerType type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glSecondaryColor3bEXT (GLbyte red, GLbyte green, GLbyte blue)
			public readonly SecondaryColor3bDelegate SecondaryColor3b;
			// void glSecondaryColor3bvEXT (GLbyte* v)
			public readonly SecondaryColor3bvDelegate SecondaryColor3bv;
			// void glSecondaryColor3dEXT (GLdouble red, GLdouble green, GLdouble blue)
			public readonly SecondaryColor3dDelegate SecondaryColor3d;
			// void glSecondaryColor3dvEXT (GLdouble* v)
			public readonly SecondaryColor3dvDelegate SecondaryColor3dv;
			// void glSecondaryColor3fEXT (GLfloat red, GLfloat green, GLfloat blue)
			public readonly SecondaryColor3fDelegate SecondaryColor3f;
			// void glSecondaryColor3fvEXT (GLfloat* v)
			public readonly SecondaryColor3fvDelegate SecondaryColor3fv;
			// void glSecondaryColor3iEXT (GLint red, GLint green, GLint blue)
			public readonly SecondaryColor3iDelegate SecondaryColor3i;
			// void glSecondaryColor3ivEXT (GLint* v)
			public readonly SecondaryColor3ivDelegate SecondaryColor3iv;
			// void glSecondaryColor3sEXT (GLshort red, GLshort green, GLshort blue)
			public readonly SecondaryColor3sDelegate SecondaryColor3s;
			// void glSecondaryColor3svEXT (GLshort* v)
			public readonly SecondaryColor3svDelegate SecondaryColor3sv;
			// void glSecondaryColor3ubEXT (GLubyte red, GLubyte green, GLubyte blue)
			public readonly SecondaryColor3ubDelegate SecondaryColor3ub;
			// void glSecondaryColor3ubvEXT (GLubyte* v)
			public readonly SecondaryColor3ubvDelegate SecondaryColor3ubv;
			// void glSecondaryColor3uiEXT (GLuint red, GLuint green, GLuint blue)
			public readonly SecondaryColor3uiDelegate SecondaryColor3ui;
			// void glSecondaryColor3uivEXT (GLuint* v)
			public readonly SecondaryColor3uivDelegate SecondaryColor3uiv;
			// void glSecondaryColor3usEXT (GLushort red, GLushort green, GLushort blue)
			public readonly SecondaryColor3usDelegate SecondaryColor3us;
			// void glSecondaryColor3usvEXT (GLushort* v)
			public readonly SecondaryColor3usvDelegate SecondaryColor3usv;
			// void glSecondaryColorPointerEXT (GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly SecondaryColorPointerDelegate SecondaryColorPointer;
			#endregion // commands
			public ExtSecondaryColor (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSecondaryColor3bEXT", out SecondaryColor3b);
				resolver.LoadHandle ("glSecondaryColor3bvEXT", out SecondaryColor3bv);
				resolver.LoadHandle ("glSecondaryColor3dEXT", out SecondaryColor3d);
				resolver.LoadHandle ("glSecondaryColor3dvEXT", out SecondaryColor3dv);
				resolver.LoadHandle ("glSecondaryColor3fEXT", out SecondaryColor3f);
				resolver.LoadHandle ("glSecondaryColor3fvEXT", out SecondaryColor3fv);
				resolver.LoadHandle ("glSecondaryColor3iEXT", out SecondaryColor3i);
				resolver.LoadHandle ("glSecondaryColor3ivEXT", out SecondaryColor3iv);
				resolver.LoadHandle ("glSecondaryColor3sEXT", out SecondaryColor3s);
				resolver.LoadHandle ("glSecondaryColor3svEXT", out SecondaryColor3sv);
				resolver.LoadHandle ("glSecondaryColor3ubEXT", out SecondaryColor3ub);
				resolver.LoadHandle ("glSecondaryColor3ubvEXT", out SecondaryColor3ubv);
				resolver.LoadHandle ("glSecondaryColor3uiEXT", out SecondaryColor3ui);
				resolver.LoadHandle ("glSecondaryColor3uivEXT", out SecondaryColor3uiv);
				resolver.LoadHandle ("glSecondaryColor3usEXT", out SecondaryColor3us);
				resolver.LoadHandle ("glSecondaryColor3usvEXT", out SecondaryColor3usv);
				resolver.LoadHandle ("glSecondaryColorPointerEXT", out SecondaryColorPointer);
			}
		}
		public partial class ExtSeparateShaderObjects
		{
			public enum All
			{
				// GL_ACTIVE_PROGRAM_EXT = 0x8B8D
				ActiveProgram = unchecked((int)35725),
			}
			public const string NAME_STRING = "GL_EXT_separate_shader_objects";
			#region command delegates
			// void glActiveProgramEXT (GLuint program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ActiveProgramDelegate (System.UInt32 program);
			// GLuint glCreateShaderProgramEXT (GLenum type, GLchar* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 CreateShaderProgramDelegate (System.UInt32 type, IntPtr @string);
			// void glUseShaderProgramEXT (GLenum type, GLuint program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UseShaderProgramDelegate (System.UInt32 type, System.UInt32 program);
			#endregion // command delegates
			#region commands
			// void glActiveProgramEXT (GLuint program)
			public readonly ActiveProgramDelegate ActiveProgram;
			// GLuint glCreateShaderProgramEXT (GLenum type, GLchar* string)
			public readonly CreateShaderProgramDelegate CreateShaderProgram;
			// void glUseShaderProgramEXT (GLenum type, GLuint program)
			public readonly UseShaderProgramDelegate UseShaderProgram;
			#endregion // commands
			public ExtSeparateShaderObjects (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glActiveProgramEXT", out ActiveProgram);
				resolver.LoadHandle ("glCreateShaderProgramEXT", out CreateShaderProgram);
				resolver.LoadHandle ("glUseShaderProgramEXT", out UseShaderProgram);
			}
		}
		public partial class ExtSeparateSpecularColor
		{
			public enum All
			{
				// GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
				LightModelColorControl = unchecked((int)33272),
				// GL_SINGLE_COLOR_EXT = 0x81F9
				SingleColor = unchecked((int)33273),
				// GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
				SeparateSpecularColor = unchecked((int)33274),
			}
			public const string NAME_STRING = "GL_EXT_separate_specular_color";
		}
		public partial class ExtShaderImageLoadStore
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x1
				VertexAttribArrayBarrierBit = unchecked((int)1),
				// GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x2
				ElementArrayBarrierBit = unchecked((int)2),
				// GL_UNIFORM_BARRIER_BIT_EXT = 0x4
				UniformBarrierBit = unchecked((int)4),
				// GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x8
				TextureFetchBarrierBit = unchecked((int)8),
				// GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x20
				ShaderImageAccessBarrierBit = unchecked((int)32),
				// GL_COMMAND_BARRIER_BIT_EXT = 0x40
				CommandBarrierBit = unchecked((int)64),
				// GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x80
				PixelBufferBarrierBit = unchecked((int)128),
				// GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x100
				TextureUpdateBarrierBit = unchecked((int)256),
				// GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x200
				BufferUpdateBarrierBit = unchecked((int)512),
				// GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x400
				FramebufferBarrierBit = unchecked((int)1024),
				// GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x800
				TransformFeedbackBarrierBit = unchecked((int)2048),
				// GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x1000
				AtomicCounterBarrierBit = unchecked((int)4096),
				// GL_MAX_IMAGE_UNITS_EXT = 0x8F38
				MaxImageUnits = unchecked((int)36664),
				// GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39
				MaxCombinedImageUnitsAndFragmentOutputs = unchecked((int)36665),
				// GL_IMAGE_BINDING_NAME_EXT = 0x8F3A
				ImageBindingName = unchecked((int)36666),
				// GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B
				ImageBindingLevel = unchecked((int)36667),
				// GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C
				ImageBindingLayered = unchecked((int)36668),
				// GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D
				ImageBindingLayer = unchecked((int)36669),
				// GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E
				ImageBindingAccess = unchecked((int)36670),
				// GL_IMAGE_1D_EXT = 0x904C
				Image1d = unchecked((int)36940),
				// GL_IMAGE_2D_EXT = 0x904D
				Image2d = unchecked((int)36941),
				// GL_IMAGE_3D_EXT = 0x904E
				Image3d = unchecked((int)36942),
				// GL_IMAGE_2D_RECT_EXT = 0x904F
				Image2dRect = unchecked((int)36943),
				// GL_IMAGE_CUBE_EXT = 0x9050
				ImageCube = unchecked((int)36944),
				// GL_IMAGE_BUFFER_EXT = 0x9051
				ImageBuffer = unchecked((int)36945),
				// GL_IMAGE_1D_ARRAY_EXT = 0x9052
				Image1dArray = unchecked((int)36946),
				// GL_IMAGE_2D_ARRAY_EXT = 0x9053
				Image2dArray = unchecked((int)36947),
				// GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054
				ImageCubeMapArray = unchecked((int)36948),
				// GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055
				Image2dMultisample = unchecked((int)36949),
				// GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056
				Image2dMultisampleArray = unchecked((int)36950),
				// GL_INT_IMAGE_1D_EXT = 0x9057
				IntImage1d = unchecked((int)36951),
				// GL_INT_IMAGE_2D_EXT = 0x9058
				IntImage2d = unchecked((int)36952),
				// GL_INT_IMAGE_3D_EXT = 0x9059
				IntImage3d = unchecked((int)36953),
				// GL_INT_IMAGE_2D_RECT_EXT = 0x905A
				IntImage2dRect = unchecked((int)36954),
				// GL_INT_IMAGE_CUBE_EXT = 0x905B
				IntImageCube = unchecked((int)36955),
				// GL_INT_IMAGE_BUFFER_EXT = 0x905C
				IntImageBuffer = unchecked((int)36956),
				// GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D
				IntImage1dArray = unchecked((int)36957),
				// GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E
				IntImage2dArray = unchecked((int)36958),
				// GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F
				IntImageCubeMapArray = unchecked((int)36959),
				// GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060
				IntImage2dMultisample = unchecked((int)36960),
				// GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061
				IntImage2dMultisampleArray = unchecked((int)36961),
				// GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062
				UnsignedIntImage1d = unchecked((int)36962),
				// GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063
				UnsignedIntImage2d = unchecked((int)36963),
				// GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064
				UnsignedIntImage3d = unchecked((int)36964),
				// GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065
				UnsignedIntImage2dRect = unchecked((int)36965),
				// GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066
				UnsignedIntImageCube = unchecked((int)36966),
				// GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067
				UnsignedIntImageBuffer = unchecked((int)36967),
				// GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068
				UnsignedIntImage1dArray = unchecked((int)36968),
				// GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069
				UnsignedIntImage2dArray = unchecked((int)36969),
				// GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A
				UnsignedIntImageCubeMapArray = unchecked((int)36970),
				// GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B
				UnsignedIntImage2dMultisample = unchecked((int)36971),
				// GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C
				UnsignedIntImage2dMultisampleArray = unchecked((int)36972),
				// GL_MAX_IMAGE_SAMPLES_EXT = 0x906D
				MaxImageSamples = unchecked((int)36973),
				// GL_IMAGE_BINDING_FORMAT_EXT = 0x906E
				ImageBindingFormat = unchecked((int)36974),
				// GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
				AllBarrierBits = unchecked((int)4294967295),
			}
			public const string NAME_STRING = "GL_EXT_shader_image_load_store";
			#region command delegates
			// void glBindImageTextureEXT (GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindImageTextureDelegate (System.UInt32 index, System.UInt32 texture, System.Int32 level, Boolean layered, System.Int32 layer, System.UInt32 access, System.Int32 format);
			// void glMemoryBarrierEXT (GLbitfield barriers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MemoryBarrierDelegate (System.UInt32 barriers);
			#endregion // command delegates
			#region commands
			// void glBindImageTextureEXT (GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format)
			public readonly BindImageTextureDelegate BindImageTexture;
			// void glMemoryBarrierEXT (GLbitfield barriers)
			public readonly MemoryBarrierDelegate MemoryBarrier;
			#endregion // commands
			public ExtShaderImageLoadStore (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindImageTextureEXT", out BindImageTexture);
				resolver.LoadHandle ("glMemoryBarrierEXT", out MemoryBarrier);
			}
		}
		public partial class ExtSharedTexturePalette
		{
			public enum All
			{
				// GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
				SharedTexturePalette = unchecked((int)33275),
			}
			public const string NAME_STRING = "GL_EXT_shared_texture_palette";
		}
		public partial class ExtStencilClearTag
		{
			public enum All
			{
				// GL_STENCIL_TAG_BITS_EXT = 0x88F2
				StencilTagBits = unchecked((int)35058),
				// GL_STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3
				StencilClearTagValue = unchecked((int)35059),
			}
			public const string NAME_STRING = "GL_EXT_stencil_clear_tag";
			#region command delegates
			// void glStencilClearTagEXT (GLsizei stencilTagBits, GLuint stencilClearTag)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilClearTagDelegate (System.Int32 stencilTagBits, System.UInt32 stencilClearTag);
			#endregion // command delegates
			#region commands
			// void glStencilClearTagEXT (GLsizei stencilTagBits, GLuint stencilClearTag)
			public readonly StencilClearTagDelegate StencilClearTag;
			#endregion // commands
			public ExtStencilClearTag (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glStencilClearTagEXT", out StencilClearTag);
			}
		}
		public partial class ExtStencilTwoSide
		{
			public enum All
			{
				// GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910
				StencilTestTwoSide = unchecked((int)35088),
				// GL_ACTIVE_STENCIL_FACE_EXT = 0x8911
				ActiveStencilFace = unchecked((int)35089),
			}
			public const string NAME_STRING = "GL_EXT_stencil_two_side";
			#region command delegates
			// void glActiveStencilFaceEXT (GLenum face)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ActiveStencilFaceDelegate (System.UInt32 face);
			#endregion // command delegates
			#region commands
			// void glActiveStencilFaceEXT (GLenum face)
			public readonly ActiveStencilFaceDelegate ActiveStencilFace;
			#endregion // commands
			public ExtStencilTwoSide (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glActiveStencilFaceEXT", out ActiveStencilFace);
			}
		}
		public partial class ExtStencilWrap
		{
			public enum All
			{
				// GL_INCR_WRAP_EXT = 0x8507
				IncrWrap = unchecked((int)34055),
				// GL_DECR_WRAP_EXT = 0x8508
				DecrWrap = unchecked((int)34056),
			}
			public const string NAME_STRING = "GL_EXT_stencil_wrap";
		}
		public partial class ExtSubtexture
		{
			public const string NAME_STRING = "GL_EXT_subtexture";
			#region command delegates
			// void glTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr pixels);
			#endregion // command delegates
			#region commands
			// void glTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
			public readonly TexSubImage1DDelegate TexSubImage1D;
			// void glTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
			public readonly TexSubImage2DDelegate TexSubImage2D;
			#endregion // commands
			public ExtSubtexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexSubImage1DEXT", out TexSubImage1D);
				resolver.LoadHandle ("glTexSubImage2DEXT", out TexSubImage2D);
			}
		}
		public partial class ExtTexture
		{
			public enum All
			{
				// GL_ALPHA4_EXT = 0x803B
				Alpha4 = unchecked((int)32827),
				// GL_ALPHA8_EXT = 0x803C
				Alpha8 = unchecked((int)32828),
				// GL_ALPHA12_EXT = 0x803D
				Alpha12 = unchecked((int)32829),
				// GL_ALPHA16_EXT = 0x803E
				Alpha16 = unchecked((int)32830),
				// GL_LUMINANCE4_EXT = 0x803F
				Luminance4 = unchecked((int)32831),
				// GL_LUMINANCE8_EXT = 0x8040
				Luminance8 = unchecked((int)32832),
				// GL_LUMINANCE12_EXT = 0x8041
				Luminance12 = unchecked((int)32833),
				// GL_LUMINANCE16_EXT = 0x8042
				Luminance16 = unchecked((int)32834),
				// GL_LUMINANCE4_ALPHA4_EXT = 0x8043
				Luminance4Alpha4 = unchecked((int)32835),
				// GL_LUMINANCE6_ALPHA2_EXT = 0x8044
				Luminance6Alpha2 = unchecked((int)32836),
				// GL_LUMINANCE8_ALPHA8_EXT = 0x8045
				Luminance8Alpha8 = unchecked((int)32837),
				// GL_LUMINANCE12_ALPHA4_EXT = 0x8046
				Luminance12Alpha4 = unchecked((int)32838),
				// GL_LUMINANCE12_ALPHA12_EXT = 0x8047
				Luminance12Alpha12 = unchecked((int)32839),
				// GL_LUMINANCE16_ALPHA16_EXT = 0x8048
				Luminance16Alpha16 = unchecked((int)32840),
				// GL_INTENSITY_EXT = 0x8049
				Intensity = unchecked((int)32841),
				// GL_INTENSITY4_EXT = 0x804A
				Intensity4 = unchecked((int)32842),
				// GL_INTENSITY8_EXT = 0x804B
				Intensity8 = unchecked((int)32843),
				// GL_INTENSITY12_EXT = 0x804C
				Intensity12 = unchecked((int)32844),
				// GL_INTENSITY16_EXT = 0x804D
				Intensity16 = unchecked((int)32845),
				// GL_RGB2_EXT = 0x804E
				Rgb2 = unchecked((int)32846),
				// GL_RGB4_EXT = 0x804F
				Rgb4 = unchecked((int)32847),
				// GL_RGB5_EXT = 0x8050
				Rgb5 = unchecked((int)32848),
				// GL_RGB8_EXT = 0x8051
				Rgb8 = unchecked((int)32849),
				// GL_RGB10_EXT = 0x8052
				Rgb10 = unchecked((int)32850),
				// GL_RGB12_EXT = 0x8053
				Rgb12 = unchecked((int)32851),
				// GL_RGB16_EXT = 0x8054
				Rgb16 = unchecked((int)32852),
				// GL_RGBA2_EXT = 0x8055
				Rgba2 = unchecked((int)32853),
				// GL_RGBA4_EXT = 0x8056
				Rgba4 = unchecked((int)32854),
				// GL_RGB5_A1_EXT = 0x8057
				Rgb5A1 = unchecked((int)32855),
				// GL_RGBA8_EXT = 0x8058
				Rgba8 = unchecked((int)32856),
				// GL_RGB10_A2_EXT = 0x8059
				Rgb10A2 = unchecked((int)32857),
				// GL_RGBA12_EXT = 0x805A
				Rgba12 = unchecked((int)32858),
				// GL_RGBA16_EXT = 0x805B
				Rgba16 = unchecked((int)32859),
				// GL_TEXTURE_RED_SIZE_EXT = 0x805C
				TextureRedSize = unchecked((int)32860),
				// GL_TEXTURE_GREEN_SIZE_EXT = 0x805D
				TextureGreenSize = unchecked((int)32861),
				// GL_TEXTURE_BLUE_SIZE_EXT = 0x805E
				TextureBlueSize = unchecked((int)32862),
				// GL_TEXTURE_ALPHA_SIZE_EXT = 0x805F
				TextureAlphaSize = unchecked((int)32863),
				// GL_TEXTURE_LUMINANCE_SIZE_EXT = 0x8060
				TextureLuminanceSize = unchecked((int)32864),
				// GL_TEXTURE_INTENSITY_SIZE_EXT = 0x8061
				TextureIntensitySize = unchecked((int)32865),
				// GL_REPLACE_EXT = 0x8062
				Replace = unchecked((int)32866),
				// GL_PROXY_TEXTURE_1D_EXT = 0x8063
				ProxyTexture1d = unchecked((int)32867),
				// GL_PROXY_TEXTURE_2D_EXT = 0x8064
				ProxyTexture2d = unchecked((int)32868),
				// GL_TEXTURE_TOO_LARGE_EXT = 0x8065
				TextureTooLarge = unchecked((int)32869),
			}
			public const string NAME_STRING = "GL_EXT_texture";
		}
		public partial class ExtTexture3d
		{
			public enum All
			{
				// GL_PACK_SKIP_IMAGES_EXT = 0x806B
				PackSkipImages = unchecked((int)32875),
				// GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
				PackImageHeight = unchecked((int)32876),
				// GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
				UnpackSkipImages = unchecked((int)32877),
				// GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
				UnpackImageHeight = unchecked((int)32878),
				// GL_TEXTURE_3D_EXT = 0x806F
				Texture3d = unchecked((int)32879),
				// GL_PROXY_TEXTURE_3D_EXT = 0x8070
				ProxyTexture3d = unchecked((int)32880),
				// GL_TEXTURE_DEPTH_EXT = 0x8071
				TextureDepth = unchecked((int)32881),
				// GL_TEXTURE_WRAP_R_EXT = 0x8072
				TextureWrapR = unchecked((int)32882),
				// GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
				Max3dTextureSize = unchecked((int)32883),
			}
			public const string NAME_STRING = "GL_EXT_texture3D";
			#region command delegates
			// void glTexImage3DEXT (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexImage3DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
			// void glTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, PixelType type, IntPtr pixels);
			#endregion // command delegates
			#region commands
			// void glTexImage3DEXT (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
			public readonly TexImage3DDelegate TexImage3D;
			// void glTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
			public readonly TexSubImage3DDelegate TexSubImage3D;
			#endregion // commands
			public ExtTexture3d (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexImage3DEXT", out TexImage3D);
				resolver.LoadHandle ("glTexSubImage3DEXT", out TexSubImage3D);
			}
		}
		public partial class ExtTextureArray
		{
			public enum All
			{
				// GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E
				CompareRefDepthToTexture = unchecked((int)34894),
				// GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF
				MaxArrayTextureLayers = unchecked((int)35071),
				// GL_TEXTURE_1D_ARRAY_EXT = 0x8C18
				Texture1dArray = unchecked((int)35864),
				// GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
				ProxyTexture1dArray = unchecked((int)35865),
				// GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A
				Texture2dArray = unchecked((int)35866),
				// GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
				ProxyTexture2dArray = unchecked((int)35867),
				// GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C
				TextureBinding1dArray = unchecked((int)35868),
				// GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D
				TextureBinding2dArray = unchecked((int)35869),
			}
			public const string NAME_STRING = "GL_EXT_texture_array";
			#region command delegates
			// void glFramebufferTextureLayerEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureLayerDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer);
			#endregion // command delegates
			#region commands
			// void glFramebufferTextureLayerEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
			public readonly FramebufferTextureLayerDelegate FramebufferTextureLayer;
			#endregion // commands
			public ExtTextureArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFramebufferTextureLayerEXT", out FramebufferTextureLayer);
			}
		}
		public partial class ExtTextureBufferObject
		{
			public enum All
			{
				// GL_TEXTURE_BUFFER_EXT = 0x8C2A
				TextureBuffer = unchecked((int)35882),
				// GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B
				MaxTextureBufferSize = unchecked((int)35883),
				// GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C
				TextureBindingBuffer = unchecked((int)35884),
				// GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D
				TextureBufferDataStoreBinding = unchecked((int)35885),
				// GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E
				TextureBufferFormat = unchecked((int)35886),
			}
			public const string NAME_STRING = "GL_EXT_texture_buffer_object";
			#region command delegates
			// void glTexBufferEXT (GLenum target, GLenum internalformat, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexBufferDelegate (TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer);
			#endregion // command delegates
			#region commands
			// void glTexBufferEXT (GLenum target, GLenum internalformat, GLuint buffer)
			public readonly TexBufferDelegate TexBuffer;
			#endregion // commands
			public ExtTextureBufferObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexBufferEXT", out TexBuffer);
			}
		}
		public partial class ExtTextureCompressionLatc
		{
			public enum All
			{
				// GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70
				CompressedLuminanceLatc1 = unchecked((int)35952),
				// GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71
				CompressedSignedLuminanceLatc1 = unchecked((int)35953),
				// GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72
				CompressedLuminanceAlphaLatc2 = unchecked((int)35954),
				// GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73
				CompressedSignedLuminanceAlphaLatc2 = unchecked((int)35955),
			}
			public const string NAME_STRING = "GL_EXT_texture_compression_latc";
		}
		public partial class ExtTextureCompressionRgtc
		{
			public enum All
			{
				// GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
				CompressedRedRgtc1 = unchecked((int)36283),
				// GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
				CompressedSignedRedRgtc1 = unchecked((int)36284),
				// GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD
				CompressedRedGreenRgtc2 = unchecked((int)36285),
				// GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE
				CompressedSignedRedGreenRgtc2 = unchecked((int)36286),
			}
			public const string NAME_STRING = "GL_EXT_texture_compression_rgtc";
		}
		public partial class ExtTextureCompressionS3tc
		{
			public enum All
			{
				// GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
				CompressedRgbS3tcDxt1 = unchecked((int)33776),
				// GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
				CompressedRgbaS3tcDxt1 = unchecked((int)33777),
				// GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
				CompressedRgbaS3tcDxt3 = unchecked((int)33778),
				// GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
				CompressedRgbaS3tcDxt5 = unchecked((int)33779),
			}
			public const string NAME_STRING = "GL_EXT_texture_compression_s3tc";
		}
		public partial class ExtTextureCubeMap
		{
			public enum All
			{
				// GL_NORMAL_MAP_EXT = 0x8511
				NormalMap = unchecked((int)34065),
				// GL_REFLECTION_MAP_EXT = 0x8512
				ReflectionMap = unchecked((int)34066),
				// GL_TEXTURE_CUBE_MAP_EXT = 0x8513
				TextureCubeMap = unchecked((int)34067),
				// GL_TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514
				TextureBindingCubeMap = unchecked((int)34068),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515
				TextureCubeMapPositiveX = unchecked((int)34069),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516
				TextureCubeMapNegativeX = unchecked((int)34070),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517
				TextureCubeMapPositiveY = unchecked((int)34071),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518
				TextureCubeMapNegativeY = unchecked((int)34072),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519
				TextureCubeMapPositiveZ = unchecked((int)34073),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A
				TextureCubeMapNegativeZ = unchecked((int)34074),
				// GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
				ProxyTextureCubeMap = unchecked((int)34075),
				// GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C
				MaxCubeMapTextureSize = unchecked((int)34076),
			}
			public const string NAME_STRING = "GL_EXT_texture_cube_map";
		}
		public partial class ExtTextureEnvCombine
		{
			public enum All
			{
				// GL_COMBINE_EXT = 0x8570
				Combine = unchecked((int)34160),
				// GL_COMBINE_RGB_EXT = 0x8571
				CombineRgb = unchecked((int)34161),
				// GL_COMBINE_ALPHA_EXT = 0x8572
				CombineAlpha = unchecked((int)34162),
				// GL_RGB_SCALE_EXT = 0x8573
				RgbScale = unchecked((int)34163),
				// GL_ADD_SIGNED_EXT = 0x8574
				AddSigned = unchecked((int)34164),
				// GL_INTERPOLATE_EXT = 0x8575
				Interpolate = unchecked((int)34165),
				// GL_CONSTANT_EXT = 0x8576
				Constant = unchecked((int)34166),
				// GL_PRIMARY_COLOR_EXT = 0x8577
				PrimaryColor = unchecked((int)34167),
				// GL_PREVIOUS_EXT = 0x8578
				Previous = unchecked((int)34168),
				// GL_SOURCE0_RGB_EXT = 0x8580
				Source0Rgb = unchecked((int)34176),
				// GL_SOURCE1_RGB_EXT = 0x8581
				Source1Rgb = unchecked((int)34177),
				// GL_SOURCE2_RGB_EXT = 0x8582
				Source2Rgb = unchecked((int)34178),
				// GL_SOURCE0_ALPHA_EXT = 0x8588
				Source0Alpha = unchecked((int)34184),
				// GL_SOURCE1_ALPHA_EXT = 0x8589
				Source1Alpha = unchecked((int)34185),
				// GL_SOURCE2_ALPHA_EXT = 0x858A
				Source2Alpha = unchecked((int)34186),
				// GL_OPERAND0_RGB_EXT = 0x8590
				Operand0Rgb = unchecked((int)34192),
				// GL_OPERAND1_RGB_EXT = 0x8591
				Operand1Rgb = unchecked((int)34193),
				// GL_OPERAND2_RGB_EXT = 0x8592
				Operand2Rgb = unchecked((int)34194),
				// GL_OPERAND0_ALPHA_EXT = 0x8598
				Operand0Alpha = unchecked((int)34200),
				// GL_OPERAND1_ALPHA_EXT = 0x8599
				Operand1Alpha = unchecked((int)34201),
				// GL_OPERAND2_ALPHA_EXT = 0x859A
				Operand2Alpha = unchecked((int)34202),
			}
			public const string NAME_STRING = "GL_EXT_texture_env_combine";
		}
		public partial class ExtTextureEnvDot3
		{
			public enum All
			{
				// GL_DOT3_RGB_EXT = 0x8740
				Dot3Rgb = unchecked((int)34624),
				// GL_DOT3_RGBA_EXT = 0x8741
				Dot3Rgba = unchecked((int)34625),
			}
			public const string NAME_STRING = "GL_EXT_texture_env_dot3";
		}
		public partial class ExtTextureFilterAnisotropic
		{
			public enum All
			{
				// GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
				TextureMaxAnisotropy = unchecked((int)34046),
				// GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
				MaxTextureMaxAnisotropy = unchecked((int)34047),
			}
			public const string NAME_STRING = "GL_EXT_texture_filter_anisotropic";
		}
		public partial class ExtTextureInteger
		{
			public enum All
			{
				// GL_RGBA32UI_EXT = 0x8D70
				Rgba32ui = unchecked((int)36208),
				// GL_RGB32UI_EXT = 0x8D71
				Rgb32ui = unchecked((int)36209),
				// GL_ALPHA32UI_EXT = 0x8D72
				Alpha32ui = unchecked((int)36210),
				// GL_INTENSITY32UI_EXT = 0x8D73
				Intensity32ui = unchecked((int)36211),
				// GL_LUMINANCE32UI_EXT = 0x8D74
				Luminance32ui = unchecked((int)36212),
				// GL_LUMINANCE_ALPHA32UI_EXT = 0x8D75
				LuminanceAlpha32ui = unchecked((int)36213),
				// GL_RGBA16UI_EXT = 0x8D76
				Rgba16ui = unchecked((int)36214),
				// GL_RGB16UI_EXT = 0x8D77
				Rgb16ui = unchecked((int)36215),
				// GL_ALPHA16UI_EXT = 0x8D78
				Alpha16ui = unchecked((int)36216),
				// GL_INTENSITY16UI_EXT = 0x8D79
				Intensity16ui = unchecked((int)36217),
				// GL_LUMINANCE16UI_EXT = 0x8D7A
				Luminance16ui = unchecked((int)36218),
				// GL_LUMINANCE_ALPHA16UI_EXT = 0x8D7B
				LuminanceAlpha16ui = unchecked((int)36219),
				// GL_RGBA8UI_EXT = 0x8D7C
				Rgba8ui = unchecked((int)36220),
				// GL_RGB8UI_EXT = 0x8D7D
				Rgb8ui = unchecked((int)36221),
				// GL_ALPHA8UI_EXT = 0x8D7E
				Alpha8ui = unchecked((int)36222),
				// GL_INTENSITY8UI_EXT = 0x8D7F
				Intensity8ui = unchecked((int)36223),
				// GL_LUMINANCE8UI_EXT = 0x8D80
				Luminance8ui = unchecked((int)36224),
				// GL_LUMINANCE_ALPHA8UI_EXT = 0x8D81
				LuminanceAlpha8ui = unchecked((int)36225),
				// GL_RGBA32I_EXT = 0x8D82
				Rgba32i = unchecked((int)36226),
				// GL_RGB32I_EXT = 0x8D83
				Rgb32i = unchecked((int)36227),
				// GL_ALPHA32I_EXT = 0x8D84
				Alpha32i = unchecked((int)36228),
				// GL_INTENSITY32I_EXT = 0x8D85
				Intensity32i = unchecked((int)36229),
				// GL_LUMINANCE32I_EXT = 0x8D86
				Luminance32i = unchecked((int)36230),
				// GL_LUMINANCE_ALPHA32I_EXT = 0x8D87
				LuminanceAlpha32i = unchecked((int)36231),
				// GL_RGBA16I_EXT = 0x8D88
				Rgba16i = unchecked((int)36232),
				// GL_RGB16I_EXT = 0x8D89
				Rgb16i = unchecked((int)36233),
				// GL_ALPHA16I_EXT = 0x8D8A
				Alpha16i = unchecked((int)36234),
				// GL_INTENSITY16I_EXT = 0x8D8B
				Intensity16i = unchecked((int)36235),
				// GL_LUMINANCE16I_EXT = 0x8D8C
				Luminance16i = unchecked((int)36236),
				// GL_LUMINANCE_ALPHA16I_EXT = 0x8D8D
				LuminanceAlpha16i = unchecked((int)36237),
				// GL_RGBA8I_EXT = 0x8D8E
				Rgba8i = unchecked((int)36238),
				// GL_RGB8I_EXT = 0x8D8F
				Rgb8i = unchecked((int)36239),
				// GL_ALPHA8I_EXT = 0x8D90
				Alpha8i = unchecked((int)36240),
				// GL_INTENSITY8I_EXT = 0x8D91
				Intensity8i = unchecked((int)36241),
				// GL_LUMINANCE8I_EXT = 0x8D92
				Luminance8i = unchecked((int)36242),
				// GL_LUMINANCE_ALPHA8I_EXT = 0x8D93
				LuminanceAlpha8i = unchecked((int)36243),
				// GL_RED_INTEGER_EXT = 0x8D94
				RedInteger = unchecked((int)36244),
				// GL_GREEN_INTEGER_EXT = 0x8D95
				GreenInteger = unchecked((int)36245),
				// GL_BLUE_INTEGER_EXT = 0x8D96
				BlueInteger = unchecked((int)36246),
				// GL_ALPHA_INTEGER_EXT = 0x8D97
				AlphaInteger = unchecked((int)36247),
				// GL_RGB_INTEGER_EXT = 0x8D98
				RgbInteger = unchecked((int)36248),
				// GL_RGBA_INTEGER_EXT = 0x8D99
				RgbaInteger = unchecked((int)36249),
				// GL_BGR_INTEGER_EXT = 0x8D9A
				BgrInteger = unchecked((int)36250),
				// GL_BGRA_INTEGER_EXT = 0x8D9B
				BgraInteger = unchecked((int)36251),
				// GL_LUMINANCE_INTEGER_EXT = 0x8D9C
				LuminanceInteger = unchecked((int)36252),
				// GL_LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D
				LuminanceAlphaInteger = unchecked((int)36253),
				// GL_RGBA_INTEGER_MODE_EXT = 0x8D9E
				RgbaIntegerMode = unchecked((int)36254),
			}
			public const string NAME_STRING = "GL_EXT_texture_integer";
			#region command delegates
			// void glClearColorIiEXT (GLint red, GLint green, GLint blue, GLint alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearColorIiDelegate (System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha);
			// void glClearColorIuiEXT (GLuint red, GLuint green, GLuint blue, GLuint alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearColorIuiDelegate (System.UInt32 red, System.UInt32 green, System.UInt32 blue, System.UInt32 alpha);
			// void glGetTexParameterIivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexParameterIivDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glGetTexParameterIuivEXT (GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexParameterIuivDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
			// void glTexParameterIivEXT (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexParameterIivDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
			// void glTexParameterIuivEXT (GLenum target, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexParameterIuivDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glClearColorIiEXT (GLint red, GLint green, GLint blue, GLint alpha)
			public readonly ClearColorIiDelegate ClearColorIi;
			// void glClearColorIuiEXT (GLuint red, GLuint green, GLuint blue, GLuint alpha)
			public readonly ClearColorIuiDelegate ClearColorIui;
			// void glGetTexParameterIivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly GetTexParameterIivDelegate GetTexParameterIiv;
			// void glGetTexParameterIuivEXT (GLenum target, GLenum pname, GLuint* params)
			public readonly GetTexParameterIuivDelegate GetTexParameterIuiv;
			// void glTexParameterIivEXT (GLenum target, GLenum pname, GLint* params)
			public readonly TexParameterIivDelegate TexParameterIiv;
			// void glTexParameterIuivEXT (GLenum target, GLenum pname, GLuint* params)
			public readonly TexParameterIuivDelegate TexParameterIuiv;
			#endregion // commands
			public ExtTextureInteger (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glClearColorIiEXT", out ClearColorIi);
				resolver.LoadHandle ("glClearColorIuiEXT", out ClearColorIui);
				resolver.LoadHandle ("glGetTexParameterIivEXT", out GetTexParameterIiv);
				resolver.LoadHandle ("glGetTexParameterIuivEXT", out GetTexParameterIuiv);
				resolver.LoadHandle ("glTexParameterIivEXT", out TexParameterIiv);
				resolver.LoadHandle ("glTexParameterIuivEXT", out TexParameterIuiv);
			}
		}
		public partial class ExtTextureLodBias
		{
			public enum All
			{
				// GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
				MaxTextureLodBias = unchecked((int)34045),
				// GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
				TextureFilterControl = unchecked((int)34048),
				// GL_TEXTURE_LOD_BIAS_EXT = 0x8501
				TextureLodBias = unchecked((int)34049),
			}
			public const string NAME_STRING = "GL_EXT_texture_lod_bias";
		}
		public partial class ExtTextureMirrorClamp
		{
			public enum All
			{
				// GL_MIRROR_CLAMP_EXT = 0x8742
				MirrorClamp = unchecked((int)34626),
				// GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743
				MirrorClampToEdge = unchecked((int)34627),
				// GL_MIRROR_CLAMP_TO_BORDER_EXT = 0x8912
				MirrorClampToBorder = unchecked((int)35090),
			}
			public const string NAME_STRING = "GL_EXT_texture_mirror_clamp";
		}
		public partial class ExtTextureObject
		{
			public enum All
			{
				// GL_TEXTURE_PRIORITY_EXT = 0x8066
				TexturePriority = unchecked((int)32870),
				// GL_TEXTURE_RESIDENT_EXT = 0x8067
				TextureResident = unchecked((int)32871),
				// GL_TEXTURE_1D_BINDING_EXT = 0x8068
				Texture1dBinding = unchecked((int)32872),
				// GL_TEXTURE_2D_BINDING_EXT = 0x8069
				Texture2dBinding = unchecked((int)32873),
				// GL_TEXTURE_3D_BINDING_EXT = 0x806A
				Texture3dBinding = unchecked((int)32874),
			}
			public const string NAME_STRING = "GL_EXT_texture_object";
			#region command delegates
			// GLboolean glAreTexturesResidentEXT (GLsizei n, GLuint* textures, GLboolean* residences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean AreTexturesResidentDelegate (System.Int32 n, IntPtr textures, Boolean residences);
			// void glBindTextureEXT (GLenum target, GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindTextureDelegate (TextureTarget target, System.UInt32 texture);
			// void glDeleteTexturesEXT (GLsizei n, GLuint* textures)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteTexturesDelegate (System.Int32 n, IntPtr textures);
			// void glGenTexturesEXT (GLsizei n, GLuint* textures)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenTexturesDelegate (System.Int32 n, IntPtr textures);
			// GLboolean glIsTextureEXT (GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsTextureDelegate (System.UInt32 texture);
			// void glPrioritizeTexturesEXT (GLsizei n, GLuint* textures, GLclampf* priorities)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PrioritizeTexturesDelegate (System.Int32 n, IntPtr textures, IntPtr priorities);
			#endregion // command delegates
			#region commands
			// GLboolean glAreTexturesResidentEXT (GLsizei n, GLuint* textures, GLboolean* residences)
			public readonly AreTexturesResidentDelegate AreTexturesResident;
			// void glBindTextureEXT (GLenum target, GLuint texture)
			public readonly BindTextureDelegate BindTexture;
			// void glDeleteTexturesEXT (GLsizei n, GLuint* textures)
			public readonly DeleteTexturesDelegate DeleteTextures;
			// void glGenTexturesEXT (GLsizei n, GLuint* textures)
			public readonly GenTexturesDelegate GenTextures;
			// GLboolean glIsTextureEXT (GLuint texture)
			public readonly IsTextureDelegate IsTexture;
			// void glPrioritizeTexturesEXT (GLsizei n, GLuint* textures, GLclampf* priorities)
			public readonly PrioritizeTexturesDelegate PrioritizeTextures;
			#endregion // commands
			public ExtTextureObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAreTexturesResidentEXT", out AreTexturesResident);
				resolver.LoadHandle ("glBindTextureEXT", out BindTexture);
				resolver.LoadHandle ("glDeleteTexturesEXT", out DeleteTextures);
				resolver.LoadHandle ("glGenTexturesEXT", out GenTextures);
				resolver.LoadHandle ("glIsTextureEXT", out IsTexture);
				resolver.LoadHandle ("glPrioritizeTexturesEXT", out PrioritizeTextures);
			}
		}
		public partial class ExtTexturePerturbNormal
		{
			public enum All
			{
				// GL_PERTURB_EXT = 0x85AE
				Perturb = unchecked((int)34222),
				// GL_TEXTURE_NORMAL_EXT = 0x85AF
				TextureNormal = unchecked((int)34223),
			}
			public const string NAME_STRING = "GL_EXT_texture_perturb_normal";
			#region command delegates
			// void glTextureNormalEXT (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureNormalDelegate (System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glTextureNormalEXT (GLenum mode)
			public readonly TextureNormalDelegate TextureNormal;
			#endregion // commands
			public ExtTexturePerturbNormal (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTextureNormalEXT", out TextureNormal);
			}
		}
		public partial class ExtTextureSharedExponent
		{
			public enum All
			{
				// GL_RGB9_E5_EXT = 0x8C3D
				Rgb9E5 = unchecked((int)35901),
				// GL_UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E
				UnsignedInt5999Rev = unchecked((int)35902),
				// GL_TEXTURE_SHARED_SIZE_EXT = 0x8C3F
				TextureSharedSize = unchecked((int)35903),
			}
			public const string NAME_STRING = "GL_EXT_texture_shared_exponent";
		}
		public partial class ExtTextureSnorm
		{
			public enum All
			{
				// GL_RED_SNORM = 0x8F90
				RedSnorm = unchecked((int)36752),
				// GL_RG_SNORM = 0x8F91
				RgSnorm = unchecked((int)36753),
				// GL_RGB_SNORM = 0x8F92
				RgbSnorm = unchecked((int)36754),
				// GL_RGBA_SNORM = 0x8F93
				RgbaSnorm = unchecked((int)36755),
				// GL_ALPHA_SNORM = 0x9010
				AlphaSnorm = unchecked((int)36880),
				// GL_LUMINANCE_SNORM = 0x9011
				LuminanceSnorm = unchecked((int)36881),
				// GL_LUMINANCE_ALPHA_SNORM = 0x9012
				LuminanceAlphaSnorm = unchecked((int)36882),
				// GL_INTENSITY_SNORM = 0x9013
				IntensitySnorm = unchecked((int)36883),
				// GL_ALPHA8_SNORM = 0x9014
				Alpha8Snorm = unchecked((int)36884),
				// GL_LUMINANCE8_SNORM = 0x9015
				Luminance8Snorm = unchecked((int)36885),
				// GL_LUMINANCE8_ALPHA8_SNORM = 0x9016
				Luminance8Alpha8Snorm = unchecked((int)36886),
				// GL_INTENSITY8_SNORM = 0x9017
				Intensity8Snorm = unchecked((int)36887),
				// GL_ALPHA16_SNORM = 0x9018
				Alpha16Snorm = unchecked((int)36888),
				// GL_LUMINANCE16_SNORM = 0x9019
				Luminance16Snorm = unchecked((int)36889),
				// GL_LUMINANCE16_ALPHA16_SNORM = 0x901A
				Luminance16Alpha16Snorm = unchecked((int)36890),
				// GL_INTENSITY16_SNORM = 0x901B
				Intensity16Snorm = unchecked((int)36891),
			}
			public const string NAME_STRING = "GL_EXT_texture_snorm";
		}
		public partial class ExtTextureSrgb
		{
			public enum All
			{
				// GL_SRGB_EXT = 0x8C40
				Srgb = unchecked((int)35904),
				// GL_SRGB8_EXT = 0x8C41
				Srgb8 = unchecked((int)35905),
				// GL_SRGB_ALPHA_EXT = 0x8C42
				SrgbAlpha = unchecked((int)35906),
				// GL_SRGB8_ALPHA8_EXT = 0x8C43
				Srgb8Alpha8 = unchecked((int)35907),
				// GL_SLUMINANCE_ALPHA_EXT = 0x8C44
				SluminanceAlpha = unchecked((int)35908),
				// GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45
				Sluminance8Alpha8 = unchecked((int)35909),
				// GL_SLUMINANCE_EXT = 0x8C46
				Sluminance = unchecked((int)35910),
				// GL_SLUMINANCE8_EXT = 0x8C47
				Sluminance8 = unchecked((int)35911),
				// GL_COMPRESSED_SRGB_EXT = 0x8C48
				CompressedSrgb = unchecked((int)35912),
				// GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49
				CompressedSrgbAlpha = unchecked((int)35913),
				// GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A
				CompressedSluminance = unchecked((int)35914),
				// GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B
				CompressedSluminanceAlpha = unchecked((int)35915),
				// GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
				CompressedSrgbS3tcDxt1 = unchecked((int)35916),
				// GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
				CompressedSrgbAlphaS3tcDxt1 = unchecked((int)35917),
				// GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
				CompressedSrgbAlphaS3tcDxt3 = unchecked((int)35918),
				// GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
				CompressedSrgbAlphaS3tcDxt5 = unchecked((int)35919),
			}
			public const string NAME_STRING = "GL_EXT_texture_sRGB";
		}
		public partial class ExtTextureSrgbDecode
		{
			public enum All
			{
				// GL_TEXTURE_SRGB_DECODE_EXT = 0x8A48
				TextureSrgbDecode = unchecked((int)35400),
				// GL_DECODE_EXT = 0x8A49
				Decode = unchecked((int)35401),
				// GL_SKIP_DECODE_EXT = 0x8A4A
				SkipDecode = unchecked((int)35402),
			}
			public const string NAME_STRING = "GL_EXT_texture_sRGB_decode";
		}
		public partial class ExtTextureSwizzle
		{
			public enum All
			{
				// GL_TEXTURE_SWIZZLE_R_EXT = 0x8E42
				TextureSwizzleR = unchecked((int)36418),
				// GL_TEXTURE_SWIZZLE_G_EXT = 0x8E43
				TextureSwizzleG = unchecked((int)36419),
				// GL_TEXTURE_SWIZZLE_B_EXT = 0x8E44
				TextureSwizzleB = unchecked((int)36420),
				// GL_TEXTURE_SWIZZLE_A_EXT = 0x8E45
				TextureSwizzleA = unchecked((int)36421),
				// GL_TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46
				TextureSwizzleRgba = unchecked((int)36422),
			}
			public const string NAME_STRING = "GL_EXT_texture_swizzle";
		}
		public partial class ExtTimerQuery
		{
			public enum All
			{
				// GL_TIME_ELAPSED_EXT = 0x88BF
				TimeElapsed = unchecked((int)35007),
			}
			public const string NAME_STRING = "GL_EXT_timer_query";
			#region command delegates
			// void glGetQueryObjecti64vEXT (GLuint id, GLenum pname, GLint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetQueryObjecti64vDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// void glGetQueryObjectui64vEXT (GLuint id, GLenum pname, GLuint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetQueryObjectui64vDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetQueryObjecti64vEXT (GLuint id, GLenum pname, GLint64* params)
			public readonly GetQueryObjecti64vDelegate GetQueryObjecti64v;
			// void glGetQueryObjectui64vEXT (GLuint id, GLenum pname, GLuint64* params)
			public readonly GetQueryObjectui64vDelegate GetQueryObjectui64v;
			#endregion // commands
			public ExtTimerQuery (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetQueryObjecti64vEXT", out GetQueryObjecti64v);
				resolver.LoadHandle ("glGetQueryObjectui64vEXT", out GetQueryObjectui64v);
			}
		}
		public partial class ExtTransformFeedback
		{
			public enum All
			{
				// GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76
				TransformFeedbackVaryingMaxLength = unchecked((int)35958),
				// GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F
				TransformFeedbackBufferMode = unchecked((int)35967),
				// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80
				MaxTransformFeedbackSeparateComponents = unchecked((int)35968),
				// GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83
				TransformFeedbackVaryings = unchecked((int)35971),
				// GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84
				TransformFeedbackBufferStart = unchecked((int)35972),
				// GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85
				TransformFeedbackBufferSize = unchecked((int)35973),
				// GL_PRIMITIVES_GENERATED_EXT = 0x8C87
				PrimitivesGenerated = unchecked((int)35975),
				// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88
				TransformFeedbackPrimitivesWritten = unchecked((int)35976),
				// GL_RASTERIZER_DISCARD_EXT = 0x8C89
				RasterizerDiscard = unchecked((int)35977),
				// GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A
				MaxTransformFeedbackInterleavedComponents = unchecked((int)35978),
				// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B
				MaxTransformFeedbackSeparateAttribs = unchecked((int)35979),
				// GL_INTERLEAVED_ATTRIBS_EXT = 0x8C8C
				InterleavedAttribs = unchecked((int)35980),
				// GL_SEPARATE_ATTRIBS_EXT = 0x8C8D
				SeparateAttribs = unchecked((int)35981),
				// GL_TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E
				TransformFeedbackBuffer = unchecked((int)35982),
				// GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F
				TransformFeedbackBufferBinding = unchecked((int)35983),
			}
			public const string NAME_STRING = "GL_EXT_transform_feedback";
			#region command delegates
			// void glBeginTransformFeedbackEXT (GLenum primitiveMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginTransformFeedbackDelegate (System.UInt32 primitiveMode);
			// void glBindBufferBaseEXT (GLenum target, GLuint index, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferBaseDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer);
			// void glBindBufferOffsetEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferOffsetDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset);
			// void glBindBufferRangeEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferRangeDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
			// void glEndTransformFeedbackEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndTransformFeedbackDelegate ();
			// void glGetTransformFeedbackVaryingEXT (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTransformFeedbackVaryingDelegate (System.UInt32 program, System.UInt32 index, System.Int32 bufSize, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
			// void glTransformFeedbackVaryingsEXT (GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TransformFeedbackVaryingsDelegate (System.UInt32 program, System.Int32 count, IntPtr varyings, System.UInt32 bufferMode);
			#endregion // command delegates
			#region commands
			// void glBeginTransformFeedbackEXT (GLenum primitiveMode)
			public readonly BeginTransformFeedbackDelegate BeginTransformFeedback;
			// void glBindBufferBaseEXT (GLenum target, GLuint index, GLuint buffer)
			public readonly BindBufferBaseDelegate BindBufferBase;
			// void glBindBufferOffsetEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset)
			public readonly BindBufferOffsetDelegate BindBufferOffset;
			// void glBindBufferRangeEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
			public readonly BindBufferRangeDelegate BindBufferRange;
			// void glEndTransformFeedbackEXT ()
			public readonly EndTransformFeedbackDelegate EndTransformFeedback;
			// void glGetTransformFeedbackVaryingEXT (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
			public readonly GetTransformFeedbackVaryingDelegate GetTransformFeedbackVarying;
			// void glTransformFeedbackVaryingsEXT (GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode)
			public readonly TransformFeedbackVaryingsDelegate TransformFeedbackVaryings;
			#endregion // commands
			public ExtTransformFeedback (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginTransformFeedbackEXT", out BeginTransformFeedback);
				resolver.LoadHandle ("glBindBufferBaseEXT", out BindBufferBase);
				resolver.LoadHandle ("glBindBufferOffsetEXT", out BindBufferOffset);
				resolver.LoadHandle ("glBindBufferRangeEXT", out BindBufferRange);
				resolver.LoadHandle ("glEndTransformFeedbackEXT", out EndTransformFeedback);
				resolver.LoadHandle ("glGetTransformFeedbackVaryingEXT", out GetTransformFeedbackVarying);
				resolver.LoadHandle ("glTransformFeedbackVaryingsEXT", out TransformFeedbackVaryings);
			}
		}
		public partial class ExtVertexArray
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_EXT = 0x8074
				VertexArray = unchecked((int)32884),
				// GL_NORMAL_ARRAY_EXT = 0x8075
				NormalArray = unchecked((int)32885),
				// GL_COLOR_ARRAY_EXT = 0x8076
				ColorArray = unchecked((int)32886),
				// GL_INDEX_ARRAY_EXT = 0x8077
				IndexArray = unchecked((int)32887),
				// GL_TEXTURE_COORD_ARRAY_EXT = 0x8078
				TextureCoordArray = unchecked((int)32888),
				// GL_EDGE_FLAG_ARRAY_EXT = 0x8079
				EdgeFlagArray = unchecked((int)32889),
				// GL_VERTEX_ARRAY_SIZE_EXT = 0x807A
				VertexArraySize = unchecked((int)32890),
				// GL_VERTEX_ARRAY_TYPE_EXT = 0x807B
				VertexArrayType = unchecked((int)32891),
				// GL_VERTEX_ARRAY_STRIDE_EXT = 0x807C
				VertexArrayStride = unchecked((int)32892),
				// GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
				VertexArrayCount = unchecked((int)32893),
				// GL_NORMAL_ARRAY_TYPE_EXT = 0x807E
				NormalArrayType = unchecked((int)32894),
				// GL_NORMAL_ARRAY_STRIDE_EXT = 0x807F
				NormalArrayStride = unchecked((int)32895),
				// GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
				NormalArrayCount = unchecked((int)32896),
				// GL_COLOR_ARRAY_SIZE_EXT = 0x8081
				ColorArraySize = unchecked((int)32897),
				// GL_COLOR_ARRAY_TYPE_EXT = 0x8082
				ColorArrayType = unchecked((int)32898),
				// GL_COLOR_ARRAY_STRIDE_EXT = 0x8083
				ColorArrayStride = unchecked((int)32899),
				// GL_COLOR_ARRAY_COUNT_EXT = 0x8084
				ColorArrayCount = unchecked((int)32900),
				// GL_INDEX_ARRAY_TYPE_EXT = 0x8085
				IndexArrayType = unchecked((int)32901),
				// GL_INDEX_ARRAY_STRIDE_EXT = 0x8086
				IndexArrayStride = unchecked((int)32902),
				// GL_INDEX_ARRAY_COUNT_EXT = 0x8087
				IndexArrayCount = unchecked((int)32903),
				// GL_TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088
				TextureCoordArraySize = unchecked((int)32904),
				// GL_TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089
				TextureCoordArrayType = unchecked((int)32905),
				// GL_TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A
				TextureCoordArrayStride = unchecked((int)32906),
				// GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
				TextureCoordArrayCount = unchecked((int)32907),
				// GL_EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C
				EdgeFlagArrayStride = unchecked((int)32908),
				// GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
				EdgeFlagArrayCount = unchecked((int)32909),
				// GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
				VertexArrayPointer = unchecked((int)32910),
				// GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
				NormalArrayPointer = unchecked((int)32911),
				// GL_COLOR_ARRAY_POINTER_EXT = 0x8090
				ColorArrayPointer = unchecked((int)32912),
				// GL_INDEX_ARRAY_POINTER_EXT = 0x8091
				IndexArrayPointer = unchecked((int)32913),
				// GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
				TextureCoordArrayPointer = unchecked((int)32914),
				// GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
				EdgeFlagArrayPointer = unchecked((int)32915),
			}
			public const string NAME_STRING = "GL_EXT_vertex_array";
			#region command delegates
			// void glArrayElementEXT (GLint i)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ArrayElementDelegate (System.Int32 i);
			// void glColorPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorPointerDelegate (System.Int32 size, ColorPointerType type, System.Int32 stride, System.Int32 count, IntPtr pointer);
			// void glDrawArraysEXT (GLenum mode, GLint first, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawArraysDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count);
			// void glEdgeFlagPointerEXT (GLsizei stride, GLsizei count, GLboolean* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EdgeFlagPointerDelegate (System.Int32 stride, System.Int32 count, Boolean pointer);
			// void glGetPointervEXT (GLenum pname, void** params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPointervDelegate (GetPointervPName pname, IntPtr @params);
			// void glIndexPointerEXT (GLenum type, GLsizei stride, GLsizei count, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexPointerDelegate (IndexPointerType type, System.Int32 stride, System.Int32 count, IntPtr pointer);
			// void glNormalPointerEXT (GLenum type, GLsizei stride, GLsizei count, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalPointerDelegate (NormalPointerType type, System.Int32 stride, System.Int32 count, IntPtr pointer);
			// void glTexCoordPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoordPointerDelegate (System.Int32 size, TexCoordPointerType type, System.Int32 stride, System.Int32 count, IntPtr pointer);
			// void glVertexPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexPointerDelegate (System.Int32 size, VertexPointerType type, System.Int32 stride, System.Int32 count, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glArrayElementEXT (GLint i)
			public readonly ArrayElementDelegate ArrayElement;
			// void glColorPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			public readonly ColorPointerDelegate ColorPointer;
			// void glDrawArraysEXT (GLenum mode, GLint first, GLsizei count)
			public readonly DrawArraysDelegate DrawArrays;
			// void glEdgeFlagPointerEXT (GLsizei stride, GLsizei count, GLboolean* pointer)
			public readonly EdgeFlagPointerDelegate EdgeFlagPointer;
			// void glGetPointervEXT (GLenum pname, void** params)
			public readonly GetPointervDelegate GetPointerv;
			// void glIndexPointerEXT (GLenum type, GLsizei stride, GLsizei count, void* pointer)
			public readonly IndexPointerDelegate IndexPointer;
			// void glNormalPointerEXT (GLenum type, GLsizei stride, GLsizei count, void* pointer)
			public readonly NormalPointerDelegate NormalPointer;
			// void glTexCoordPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			public readonly TexCoordPointerDelegate TexCoordPointer;
			// void glVertexPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer)
			public readonly VertexPointerDelegate VertexPointer;
			#endregion // commands
			public ExtVertexArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glArrayElementEXT", out ArrayElement);
				resolver.LoadHandle ("glColorPointerEXT", out ColorPointer);
				resolver.LoadHandle ("glDrawArraysEXT", out DrawArrays);
				resolver.LoadHandle ("glEdgeFlagPointerEXT", out EdgeFlagPointer);
				resolver.LoadHandle ("glGetPointervEXT", out GetPointerv);
				resolver.LoadHandle ("glIndexPointerEXT", out IndexPointer);
				resolver.LoadHandle ("glNormalPointerEXT", out NormalPointer);
				resolver.LoadHandle ("glTexCoordPointerEXT", out TexCoordPointer);
				resolver.LoadHandle ("glVertexPointerEXT", out VertexPointer);
			}
		}
		public partial class ExtVertexAttrib64bit
		{
			public enum All
			{
				// GL_DOUBLE_MAT2_EXT = 0x8F46
				DoubleMat2 = unchecked((int)36678),
				// GL_DOUBLE_MAT3_EXT = 0x8F47
				DoubleMat3 = unchecked((int)36679),
				// GL_DOUBLE_MAT4_EXT = 0x8F48
				DoubleMat4 = unchecked((int)36680),
				// GL_DOUBLE_MAT2x3_EXT = 0x8F49
				DoubleMat2x3 = unchecked((int)36681),
				// GL_DOUBLE_MAT2x4_EXT = 0x8F4A
				DoubleMat2x4 = unchecked((int)36682),
				// GL_DOUBLE_MAT3x2_EXT = 0x8F4B
				DoubleMat3x2 = unchecked((int)36683),
				// GL_DOUBLE_MAT3x4_EXT = 0x8F4C
				DoubleMat3x4 = unchecked((int)36684),
				// GL_DOUBLE_MAT4x2_EXT = 0x8F4D
				DoubleMat4x2 = unchecked((int)36685),
				// GL_DOUBLE_MAT4x3_EXT = 0x8F4E
				DoubleMat4x3 = unchecked((int)36686),
				// GL_DOUBLE_VEC2_EXT = 0x8FFC
				DoubleVec2 = unchecked((int)36860),
				// GL_DOUBLE_VEC3_EXT = 0x8FFD
				DoubleVec3 = unchecked((int)36861),
				// GL_DOUBLE_VEC4_EXT = 0x8FFE
				DoubleVec4 = unchecked((int)36862),
			}
			public const string NAME_STRING = "GL_EXT_vertex_attrib_64bit";
			#region command delegates
			// void glGetVertexAttribLdvEXT (GLuint index, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribLdvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glVertexAttribL1dEXT (GLuint index, GLdouble x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1dDelegate (System.UInt32 index, System.Double x);
			// void glVertexAttribL1dvEXT (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL2dEXT (GLuint index, GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2dDelegate (System.UInt32 index, System.Double x, System.Double y);
			// void glVertexAttribL2dvEXT (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL3dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z);
			// void glVertexAttribL3dvEXT (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL4dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glVertexAttribL4dvEXT (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribLPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribLPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glGetVertexAttribLdvEXT (GLuint index, GLenum pname, GLdouble* params)
			public readonly GetVertexAttribLdvDelegate GetVertexAttribLdv;
			// void glVertexAttribL1dEXT (GLuint index, GLdouble x)
			public readonly VertexAttribL1dDelegate VertexAttribL1d;
			// void glVertexAttribL1dvEXT (GLuint index, GLdouble* v)
			public readonly VertexAttribL1dvDelegate VertexAttribL1dv;
			// void glVertexAttribL2dEXT (GLuint index, GLdouble x, GLdouble y)
			public readonly VertexAttribL2dDelegate VertexAttribL2d;
			// void glVertexAttribL2dvEXT (GLuint index, GLdouble* v)
			public readonly VertexAttribL2dvDelegate VertexAttribL2dv;
			// void glVertexAttribL3dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			public readonly VertexAttribL3dDelegate VertexAttribL3d;
			// void glVertexAttribL3dvEXT (GLuint index, GLdouble* v)
			public readonly VertexAttribL3dvDelegate VertexAttribL3dv;
			// void glVertexAttribL4dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly VertexAttribL4dDelegate VertexAttribL4d;
			// void glVertexAttribL4dvEXT (GLuint index, GLdouble* v)
			public readonly VertexAttribL4dvDelegate VertexAttribL4dv;
			// void glVertexAttribLPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly VertexAttribLPointerDelegate VertexAttribLPointer;
			#endregion // commands
			public ExtVertexAttrib64bit (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetVertexAttribLdvEXT", out GetVertexAttribLdv);
				resolver.LoadHandle ("glVertexAttribL1dEXT", out VertexAttribL1d);
				resolver.LoadHandle ("glVertexAttribL1dvEXT", out VertexAttribL1dv);
				resolver.LoadHandle ("glVertexAttribL2dEXT", out VertexAttribL2d);
				resolver.LoadHandle ("glVertexAttribL2dvEXT", out VertexAttribL2dv);
				resolver.LoadHandle ("glVertexAttribL3dEXT", out VertexAttribL3d);
				resolver.LoadHandle ("glVertexAttribL3dvEXT", out VertexAttribL3dv);
				resolver.LoadHandle ("glVertexAttribL4dEXT", out VertexAttribL4d);
				resolver.LoadHandle ("glVertexAttribL4dvEXT", out VertexAttribL4dv);
				resolver.LoadHandle ("glVertexAttribLPointerEXT", out VertexAttribLPointer);
			}
		}
		public partial class ExtVertexShader
		{
			public enum All
			{
				// GL_VERTEX_SHADER_EXT = 0x8780
				VertexShader = unchecked((int)34688),
				// GL_VERTEX_SHADER_BINDING_EXT = 0x8781
				VertexShaderBinding = unchecked((int)34689),
				// GL_OP_INDEX_EXT = 0x8782
				OpIndex = unchecked((int)34690),
				// GL_OP_NEGATE_EXT = 0x8783
				OpNegate = unchecked((int)34691),
				// GL_OP_DOT3_EXT = 0x8784
				OpDot3 = unchecked((int)34692),
				// GL_OP_DOT4_EXT = 0x8785
				OpDot4 = unchecked((int)34693),
				// GL_OP_MUL_EXT = 0x8786
				OpMul = unchecked((int)34694),
				// GL_OP_ADD_EXT = 0x8787
				OpAdd = unchecked((int)34695),
				// GL_OP_MADD_EXT = 0x8788
				OpMadd = unchecked((int)34696),
				// GL_OP_FRAC_EXT = 0x8789
				OpFrac = unchecked((int)34697),
				// GL_OP_MAX_EXT = 0x878A
				OpMax = unchecked((int)34698),
				// GL_OP_MIN_EXT = 0x878B
				OpMin = unchecked((int)34699),
				// GL_OP_SET_GE_EXT = 0x878C
				OpSetGe = unchecked((int)34700),
				// GL_OP_SET_LT_EXT = 0x878D
				OpSetLt = unchecked((int)34701),
				// GL_OP_CLAMP_EXT = 0x878E
				OpClamp = unchecked((int)34702),
				// GL_OP_FLOOR_EXT = 0x878F
				OpFloor = unchecked((int)34703),
				// GL_OP_ROUND_EXT = 0x8790
				OpRound = unchecked((int)34704),
				// GL_OP_EXP_BASE_2_EXT = 0x8791
				OpExpBase2 = unchecked((int)34705),
				// GL_OP_LOG_BASE_2_EXT = 0x8792
				OpLogBase2 = unchecked((int)34706),
				// GL_OP_POWER_EXT = 0x8793
				OpPower = unchecked((int)34707),
				// GL_OP_RECIP_EXT = 0x8794
				OpRecip = unchecked((int)34708),
				// GL_OP_RECIP_SQRT_EXT = 0x8795
				OpRecipSqrt = unchecked((int)34709),
				// GL_OP_SUB_EXT = 0x8796
				OpSub = unchecked((int)34710),
				// GL_OP_CROSS_PRODUCT_EXT = 0x8797
				OpCrossProduct = unchecked((int)34711),
				// GL_OP_MULTIPLY_MATRIX_EXT = 0x8798
				OpMultiplyMatrix = unchecked((int)34712),
				// GL_OP_MOV_EXT = 0x8799
				OpMov = unchecked((int)34713),
				// GL_OUTPUT_VERTEX_EXT = 0x879A
				OutputVertex = unchecked((int)34714),
				// GL_OUTPUT_COLOR0_EXT = 0x879B
				OutputColor0 = unchecked((int)34715),
				// GL_OUTPUT_COLOR1_EXT = 0x879C
				OutputColor1 = unchecked((int)34716),
				// GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D
				OutputTextureCoord0 = unchecked((int)34717),
				// GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E
				OutputTextureCoord1 = unchecked((int)34718),
				// GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F
				OutputTextureCoord2 = unchecked((int)34719),
				// GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0
				OutputTextureCoord3 = unchecked((int)34720),
				// GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1
				OutputTextureCoord4 = unchecked((int)34721),
				// GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2
				OutputTextureCoord5 = unchecked((int)34722),
				// GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3
				OutputTextureCoord6 = unchecked((int)34723),
				// GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4
				OutputTextureCoord7 = unchecked((int)34724),
				// GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5
				OutputTextureCoord8 = unchecked((int)34725),
				// GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6
				OutputTextureCoord9 = unchecked((int)34726),
				// GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7
				OutputTextureCoord10 = unchecked((int)34727),
				// GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8
				OutputTextureCoord11 = unchecked((int)34728),
				// GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9
				OutputTextureCoord12 = unchecked((int)34729),
				// GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA
				OutputTextureCoord13 = unchecked((int)34730),
				// GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB
				OutputTextureCoord14 = unchecked((int)34731),
				// GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC
				OutputTextureCoord15 = unchecked((int)34732),
				// GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD
				OutputTextureCoord16 = unchecked((int)34733),
				// GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE
				OutputTextureCoord17 = unchecked((int)34734),
				// GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF
				OutputTextureCoord18 = unchecked((int)34735),
				// GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0
				OutputTextureCoord19 = unchecked((int)34736),
				// GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1
				OutputTextureCoord20 = unchecked((int)34737),
				// GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2
				OutputTextureCoord21 = unchecked((int)34738),
				// GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3
				OutputTextureCoord22 = unchecked((int)34739),
				// GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4
				OutputTextureCoord23 = unchecked((int)34740),
				// GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5
				OutputTextureCoord24 = unchecked((int)34741),
				// GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6
				OutputTextureCoord25 = unchecked((int)34742),
				// GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7
				OutputTextureCoord26 = unchecked((int)34743),
				// GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8
				OutputTextureCoord27 = unchecked((int)34744),
				// GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9
				OutputTextureCoord28 = unchecked((int)34745),
				// GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA
				OutputTextureCoord29 = unchecked((int)34746),
				// GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB
				OutputTextureCoord30 = unchecked((int)34747),
				// GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC
				OutputTextureCoord31 = unchecked((int)34748),
				// GL_OUTPUT_FOG_EXT = 0x87BD
				OutputFog = unchecked((int)34749),
				// GL_SCALAR_EXT = 0x87BE
				Scalar = unchecked((int)34750),
				// GL_VECTOR_EXT = 0x87BF
				Vector = unchecked((int)34751),
				// GL_MATRIX_EXT = 0x87C0
				Matrix = unchecked((int)34752),
				// GL_VARIANT_EXT = 0x87C1
				Variant = unchecked((int)34753),
				// GL_INVARIANT_EXT = 0x87C2
				Invariant = unchecked((int)34754),
				// GL_LOCAL_CONSTANT_EXT = 0x87C3
				LocalConstant = unchecked((int)34755),
				// GL_LOCAL_EXT = 0x87C4
				Local = unchecked((int)34756),
				// GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5
				MaxVertexShaderInstructions = unchecked((int)34757),
				// GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6
				MaxVertexShaderVariants = unchecked((int)34758),
				// GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7
				MaxVertexShaderInvariants = unchecked((int)34759),
				// GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8
				MaxVertexShaderLocalConstants = unchecked((int)34760),
				// GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9
				MaxVertexShaderLocals = unchecked((int)34761),
				// GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA
				MaxOptimizedVertexShaderInstructions = unchecked((int)34762),
				// GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB
				MaxOptimizedVertexShaderVariants = unchecked((int)34763),
				// GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC
				MaxOptimizedVertexShaderLocalConstants = unchecked((int)34764),
				// GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD
				MaxOptimizedVertexShaderInvariants = unchecked((int)34765),
				// GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE
				MaxOptimizedVertexShaderLocals = unchecked((int)34766),
				// GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF
				VertexShaderInstructions = unchecked((int)34767),
				// GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0
				VertexShaderVariants = unchecked((int)34768),
				// GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1
				VertexShaderInvariants = unchecked((int)34769),
				// GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2
				VertexShaderLocalConstants = unchecked((int)34770),
				// GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3
				VertexShaderLocals = unchecked((int)34771),
				// GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4
				VertexShaderOptimized = unchecked((int)34772),
				// GL_X_EXT = 0x87D5
				X = unchecked((int)34773),
				// GL_Y_EXT = 0x87D6
				Y = unchecked((int)34774),
				// GL_Z_EXT = 0x87D7
				Z = unchecked((int)34775),
				// GL_W_EXT = 0x87D8
				W = unchecked((int)34776),
				// GL_NEGATIVE_X_EXT = 0x87D9
				NegativeX = unchecked((int)34777),
				// GL_NEGATIVE_Y_EXT = 0x87DA
				NegativeY = unchecked((int)34778),
				// GL_NEGATIVE_Z_EXT = 0x87DB
				NegativeZ = unchecked((int)34779),
				// GL_NEGATIVE_W_EXT = 0x87DC
				NegativeW = unchecked((int)34780),
				// GL_ZERO_EXT = 0x87DD
				Zero = unchecked((int)34781),
				// GL_ONE_EXT = 0x87DE
				One = unchecked((int)34782),
				// GL_NEGATIVE_ONE_EXT = 0x87DF
				NegativeOne = unchecked((int)34783),
				// GL_NORMALIZED_RANGE_EXT = 0x87E0
				NormalizedRange = unchecked((int)34784),
				// GL_FULL_RANGE_EXT = 0x87E1
				FullRange = unchecked((int)34785),
				// GL_CURRENT_VERTEX_EXT = 0x87E2
				CurrentVertex = unchecked((int)34786),
				// GL_MVP_MATRIX_EXT = 0x87E3
				MvpMatrix = unchecked((int)34787),
				// GL_VARIANT_VALUE_EXT = 0x87E4
				VariantValue = unchecked((int)34788),
				// GL_VARIANT_DATATYPE_EXT = 0x87E5
				VariantDatatype = unchecked((int)34789),
				// GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6
				VariantArrayStride = unchecked((int)34790),
				// GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7
				VariantArrayType = unchecked((int)34791),
				// GL_VARIANT_ARRAY_EXT = 0x87E8
				VariantArray = unchecked((int)34792),
				// GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9
				VariantArrayPointer = unchecked((int)34793),
				// GL_INVARIANT_VALUE_EXT = 0x87EA
				InvariantValue = unchecked((int)34794),
				// GL_INVARIANT_DATATYPE_EXT = 0x87EB
				InvariantDatatype = unchecked((int)34795),
				// GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC
				LocalConstantValue = unchecked((int)34796),
				// GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED
				LocalConstantDatatype = unchecked((int)34797),
			}
			public const string NAME_STRING = "GL_EXT_vertex_shader";
			#region command delegates
			// void glBeginVertexShaderEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginVertexShaderDelegate ();
			// GLuint glBindLightParameterEXT (GLenum light, GLenum value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 BindLightParameterDelegate (LightName light, LightParameter value);
			// GLuint glBindMaterialParameterEXT (GLenum face, GLenum value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 BindMaterialParameterDelegate (MaterialFace face, MaterialParameter value);
			// GLuint glBindParameterEXT (GLenum value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 BindParameterDelegate (System.UInt32 value);
			// GLuint glBindTexGenParameterEXT (GLenum unit, GLenum coord, GLenum value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 BindTexGenParameterDelegate (System.UInt32 unit, TextureCoordName coord, TextureGenParameter value);
			// GLuint glBindTextureUnitParameterEXT (GLenum unit, GLenum value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 BindTextureUnitParameterDelegate (System.UInt32 unit, System.UInt32 value);
			// void glBindVertexShaderEXT (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindVertexShaderDelegate (System.UInt32 id);
			// void glDeleteVertexShaderEXT (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteVertexShaderDelegate (System.UInt32 id);
			// void glDisableVariantClientStateEXT (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableVariantClientStateDelegate (System.UInt32 id);
			// void glEnableVariantClientStateEXT (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableVariantClientStateDelegate (System.UInt32 id);
			// void glEndVertexShaderEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndVertexShaderDelegate ();
			// void glExtractComponentEXT (GLuint res, GLuint src, GLuint num)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ExtractComponentDelegate (System.UInt32 res, System.UInt32 src, System.UInt32 num);
			// GLuint glGenSymbolsEXT (GLenum datatype, GLenum storagetype, GLenum range, GLuint components)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GenSymbolsDelegate (System.UInt32 datatype, System.UInt32 storagetype, System.UInt32 range, System.UInt32 components);
			// GLuint glGenVertexShadersEXT (GLuint range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GenVertexShadersDelegate (System.UInt32 range);
			// void glGetInvariantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetInvariantBooleanvDelegate (System.UInt32 id, System.UInt32 value, Boolean data);
			// void glGetInvariantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetInvariantFloatvDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetInvariantIntegervEXT (GLuint id, GLenum value, GLint* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetInvariantIntegervDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetLocalConstantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetLocalConstantBooleanvDelegate (System.UInt32 id, System.UInt32 value, Boolean data);
			// void glGetLocalConstantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetLocalConstantFloatvDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetLocalConstantIntegervEXT (GLuint id, GLenum value, GLint* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetLocalConstantIntegervDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetVariantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantBooleanvDelegate (System.UInt32 id, System.UInt32 value, Boolean data);
			// void glGetVariantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantFloatvDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetVariantIntegervEXT (GLuint id, GLenum value, GLint* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantIntegervDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glGetVariantPointervEXT (GLuint id, GLenum value, void** data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantPointervDelegate (System.UInt32 id, System.UInt32 value, IntPtr data);
			// void glInsertComponentEXT (GLuint res, GLuint src, GLuint num)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void InsertComponentDelegate (System.UInt32 res, System.UInt32 src, System.UInt32 num);
			// GLboolean glIsVariantEnabledEXT (GLuint id, GLenum cap)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsVariantEnabledDelegate (System.UInt32 id, System.UInt32 cap);
			// void glSetInvariantEXT (GLuint id, GLenum type, void* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetInvariantDelegate (System.UInt32 id, System.UInt32 type, IntPtr addr);
			// void glSetLocalConstantEXT (GLuint id, GLenum type, void* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetLocalConstantDelegate (System.UInt32 id, System.UInt32 type, IntPtr addr);
			// void glShaderOp1EXT (GLenum op, GLuint res, GLuint arg1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ShaderOp1Delegate (System.UInt32 op, System.UInt32 res, System.UInt32 arg1);
			// void glShaderOp2EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ShaderOp2Delegate (System.UInt32 op, System.UInt32 res, System.UInt32 arg1, System.UInt32 arg2);
			// void glShaderOp3EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ShaderOp3Delegate (System.UInt32 op, System.UInt32 res, System.UInt32 arg1, System.UInt32 arg2, System.UInt32 arg3);
			// void glSwizzleEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SwizzleDelegate (System.UInt32 res, System.UInt32 @in, System.UInt32 outX, System.UInt32 outY, System.UInt32 outZ, System.UInt32 outW);
			// void glVariantbvEXT (GLuint id, GLbyte* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantbvDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantdvEXT (GLuint id, GLdouble* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantdvDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantfvEXT (GLuint id, GLfloat* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantfvDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantivEXT (GLuint id, GLint* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantivDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantPointerEXT (GLuint id, GLenum type, GLuint stride, void* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantPointerDelegate (System.UInt32 id, System.UInt32 type, System.UInt32 stride, IntPtr addr);
			// void glVariantsvEXT (GLuint id, GLshort* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantsvDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantubvEXT (GLuint id, GLubyte* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantubvDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantuivEXT (GLuint id, GLuint* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantuivDelegate (System.UInt32 id, IntPtr addr);
			// void glVariantusvEXT (GLuint id, GLushort* addr)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantusvDelegate (System.UInt32 id, IntPtr addr);
			// void glWriteMaskEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WriteMaskDelegate (System.UInt32 res, System.UInt32 @in, System.UInt32 outX, System.UInt32 outY, System.UInt32 outZ, System.UInt32 outW);
			#endregion // command delegates
			#region commands
			// void glBeginVertexShaderEXT ()
			public readonly BeginVertexShaderDelegate BeginVertexShader;
			// GLuint glBindLightParameterEXT (GLenum light, GLenum value)
			public readonly BindLightParameterDelegate BindLightParameter;
			// GLuint glBindMaterialParameterEXT (GLenum face, GLenum value)
			public readonly BindMaterialParameterDelegate BindMaterialParameter;
			// GLuint glBindParameterEXT (GLenum value)
			public readonly BindParameterDelegate BindParameter;
			// GLuint glBindTexGenParameterEXT (GLenum unit, GLenum coord, GLenum value)
			public readonly BindTexGenParameterDelegate BindTexGenParameter;
			// GLuint glBindTextureUnitParameterEXT (GLenum unit, GLenum value)
			public readonly BindTextureUnitParameterDelegate BindTextureUnitParameter;
			// void glBindVertexShaderEXT (GLuint id)
			public readonly BindVertexShaderDelegate BindVertexShader;
			// void glDeleteVertexShaderEXT (GLuint id)
			public readonly DeleteVertexShaderDelegate DeleteVertexShader;
			// void glDisableVariantClientStateEXT (GLuint id)
			public readonly DisableVariantClientStateDelegate DisableVariantClientState;
			// void glEnableVariantClientStateEXT (GLuint id)
			public readonly EnableVariantClientStateDelegate EnableVariantClientState;
			// void glEndVertexShaderEXT ()
			public readonly EndVertexShaderDelegate EndVertexShader;
			// void glExtractComponentEXT (GLuint res, GLuint src, GLuint num)
			public readonly ExtractComponentDelegate ExtractComponent;
			// GLuint glGenSymbolsEXT (GLenum datatype, GLenum storagetype, GLenum range, GLuint components)
			public readonly GenSymbolsDelegate GenSymbols;
			// GLuint glGenVertexShadersEXT (GLuint range)
			public readonly GenVertexShadersDelegate GenVertexShaders;
			// void glGetInvariantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			public readonly GetInvariantBooleanvDelegate GetInvariantBooleanv;
			// void glGetInvariantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			public readonly GetInvariantFloatvDelegate GetInvariantFloatv;
			// void glGetInvariantIntegervEXT (GLuint id, GLenum value, GLint* data)
			public readonly GetInvariantIntegervDelegate GetInvariantIntegerv;
			// void glGetLocalConstantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			public readonly GetLocalConstantBooleanvDelegate GetLocalConstantBooleanv;
			// void glGetLocalConstantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			public readonly GetLocalConstantFloatvDelegate GetLocalConstantFloatv;
			// void glGetLocalConstantIntegervEXT (GLuint id, GLenum value, GLint* data)
			public readonly GetLocalConstantIntegervDelegate GetLocalConstantIntegerv;
			// void glGetVariantBooleanvEXT (GLuint id, GLenum value, GLboolean* data)
			public readonly GetVariantBooleanvDelegate GetVariantBooleanv;
			// void glGetVariantFloatvEXT (GLuint id, GLenum value, GLfloat* data)
			public readonly GetVariantFloatvDelegate GetVariantFloatv;
			// void glGetVariantIntegervEXT (GLuint id, GLenum value, GLint* data)
			public readonly GetVariantIntegervDelegate GetVariantIntegerv;
			// void glGetVariantPointervEXT (GLuint id, GLenum value, void** data)
			public readonly GetVariantPointervDelegate GetVariantPointerv;
			// void glInsertComponentEXT (GLuint res, GLuint src, GLuint num)
			public readonly InsertComponentDelegate InsertComponent;
			// GLboolean glIsVariantEnabledEXT (GLuint id, GLenum cap)
			public readonly IsVariantEnabledDelegate IsVariantEnabled;
			// void glSetInvariantEXT (GLuint id, GLenum type, void* addr)
			public readonly SetInvariantDelegate SetInvariant;
			// void glSetLocalConstantEXT (GLuint id, GLenum type, void* addr)
			public readonly SetLocalConstantDelegate SetLocalConstant;
			// void glShaderOp1EXT (GLenum op, GLuint res, GLuint arg1)
			public readonly ShaderOp1Delegate ShaderOp1;
			// void glShaderOp2EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2)
			public readonly ShaderOp2Delegate ShaderOp2;
			// void glShaderOp3EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3)
			public readonly ShaderOp3Delegate ShaderOp3;
			// void glSwizzleEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
			public readonly SwizzleDelegate Swizzle;
			// void glVariantbvEXT (GLuint id, GLbyte* addr)
			public readonly VariantbvDelegate Variantbv;
			// void glVariantdvEXT (GLuint id, GLdouble* addr)
			public readonly VariantdvDelegate Variantdv;
			// void glVariantfvEXT (GLuint id, GLfloat* addr)
			public readonly VariantfvDelegate Variantfv;
			// void glVariantivEXT (GLuint id, GLint* addr)
			public readonly VariantivDelegate Variantiv;
			// void glVariantPointerEXT (GLuint id, GLenum type, GLuint stride, void* addr)
			public readonly VariantPointerDelegate VariantPointer;
			// void glVariantsvEXT (GLuint id, GLshort* addr)
			public readonly VariantsvDelegate Variantsv;
			// void glVariantubvEXT (GLuint id, GLubyte* addr)
			public readonly VariantubvDelegate Variantubv;
			// void glVariantuivEXT (GLuint id, GLuint* addr)
			public readonly VariantuivDelegate Variantuiv;
			// void glVariantusvEXT (GLuint id, GLushort* addr)
			public readonly VariantusvDelegate Variantusv;
			// void glWriteMaskEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
			public readonly WriteMaskDelegate WriteMask;
			#endregion // commands
			public ExtVertexShader (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginVertexShaderEXT", out BeginVertexShader);
				resolver.LoadHandle ("glBindLightParameterEXT", out BindLightParameter);
				resolver.LoadHandle ("glBindMaterialParameterEXT", out BindMaterialParameter);
				resolver.LoadHandle ("glBindParameterEXT", out BindParameter);
				resolver.LoadHandle ("glBindTexGenParameterEXT", out BindTexGenParameter);
				resolver.LoadHandle ("glBindTextureUnitParameterEXT", out BindTextureUnitParameter);
				resolver.LoadHandle ("glBindVertexShaderEXT", out BindVertexShader);
				resolver.LoadHandle ("glDeleteVertexShaderEXT", out DeleteVertexShader);
				resolver.LoadHandle ("glDisableVariantClientStateEXT", out DisableVariantClientState);
				resolver.LoadHandle ("glEnableVariantClientStateEXT", out EnableVariantClientState);
				resolver.LoadHandle ("glEndVertexShaderEXT", out EndVertexShader);
				resolver.LoadHandle ("glExtractComponentEXT", out ExtractComponent);
				resolver.LoadHandle ("glGenSymbolsEXT", out GenSymbols);
				resolver.LoadHandle ("glGenVertexShadersEXT", out GenVertexShaders);
				resolver.LoadHandle ("glGetInvariantBooleanvEXT", out GetInvariantBooleanv);
				resolver.LoadHandle ("glGetInvariantFloatvEXT", out GetInvariantFloatv);
				resolver.LoadHandle ("glGetInvariantIntegervEXT", out GetInvariantIntegerv);
				resolver.LoadHandle ("glGetLocalConstantBooleanvEXT", out GetLocalConstantBooleanv);
				resolver.LoadHandle ("glGetLocalConstantFloatvEXT", out GetLocalConstantFloatv);
				resolver.LoadHandle ("glGetLocalConstantIntegervEXT", out GetLocalConstantIntegerv);
				resolver.LoadHandle ("glGetVariantBooleanvEXT", out GetVariantBooleanv);
				resolver.LoadHandle ("glGetVariantFloatvEXT", out GetVariantFloatv);
				resolver.LoadHandle ("glGetVariantIntegervEXT", out GetVariantIntegerv);
				resolver.LoadHandle ("glGetVariantPointervEXT", out GetVariantPointerv);
				resolver.LoadHandle ("glInsertComponentEXT", out InsertComponent);
				resolver.LoadHandle ("glIsVariantEnabledEXT", out IsVariantEnabled);
				resolver.LoadHandle ("glSetInvariantEXT", out SetInvariant);
				resolver.LoadHandle ("glSetLocalConstantEXT", out SetLocalConstant);
				resolver.LoadHandle ("glShaderOp1EXT", out ShaderOp1);
				resolver.LoadHandle ("glShaderOp2EXT", out ShaderOp2);
				resolver.LoadHandle ("glShaderOp3EXT", out ShaderOp3);
				resolver.LoadHandle ("glSwizzleEXT", out Swizzle);
				resolver.LoadHandle ("glVariantbvEXT", out Variantbv);
				resolver.LoadHandle ("glVariantdvEXT", out Variantdv);
				resolver.LoadHandle ("glVariantfvEXT", out Variantfv);
				resolver.LoadHandle ("glVariantivEXT", out Variantiv);
				resolver.LoadHandle ("glVariantPointerEXT", out VariantPointer);
				resolver.LoadHandle ("glVariantsvEXT", out Variantsv);
				resolver.LoadHandle ("glVariantubvEXT", out Variantubv);
				resolver.LoadHandle ("glVariantuivEXT", out Variantuiv);
				resolver.LoadHandle ("glVariantusvEXT", out Variantusv);
				resolver.LoadHandle ("glWriteMaskEXT", out WriteMask);
			}
		}
		public partial class ExtVertexWeighting
		{
			public enum All
			{
				// GL_MODELVIEW0_STACK_DEPTH_EXT = 0xBA3
				Modelview0StackDepth = unchecked((int)2979),
				// GL_MODELVIEW0_MATRIX_EXT = 0xBA6
				Modelview0Matrix = unchecked((int)2982),
				// GL_MODELVIEW0_EXT = 0x1700
				Modelview0 = unchecked((int)5888),
				// GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502
				Modelview1StackDepth = unchecked((int)34050),
				// GL_MODELVIEW1_MATRIX_EXT = 0x8506
				Modelview1Matrix = unchecked((int)34054),
				// GL_VERTEX_WEIGHTING_EXT = 0x8509
				VertexWeighting = unchecked((int)34057),
				// GL_MODELVIEW1_EXT = 0x850A
				Modelview1 = unchecked((int)34058),
				// GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B
				CurrentVertexWeight = unchecked((int)34059),
				// GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C
				VertexWeightArray = unchecked((int)34060),
				// GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D
				VertexWeightArraySize = unchecked((int)34061),
				// GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E
				VertexWeightArrayType = unchecked((int)34062),
				// GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F
				VertexWeightArrayStride = unchecked((int)34063),
				// GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510
				VertexWeightArrayPointer = unchecked((int)34064),
			}
			public const string NAME_STRING = "GL_EXT_vertex_weighting";
			#region command delegates
			// void glVertexWeightfEXT (GLfloat weight)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexWeightfDelegate (System.Single weight);
			// void glVertexWeightfvEXT (GLfloat* weight)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexWeightfvDelegate (IntPtr weight);
			// void glVertexWeightPointerEXT (GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexWeightPointerDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glVertexWeightfEXT (GLfloat weight)
			public readonly VertexWeightfDelegate VertexWeightf;
			// void glVertexWeightfvEXT (GLfloat* weight)
			public readonly VertexWeightfvDelegate VertexWeightfv;
			// void glVertexWeightPointerEXT (GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly VertexWeightPointerDelegate VertexWeightPointer;
			#endregion // commands
			public ExtVertexWeighting (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glVertexWeightfEXT", out VertexWeightf);
				resolver.LoadHandle ("glVertexWeightfvEXT", out VertexWeightfv);
				resolver.LoadHandle ("glVertexWeightPointerEXT", out VertexWeightPointer);
			}
		}
		public partial class ExtWindowRectangles
		{
			public enum All
			{
				// GL_INCLUSIVE_EXT = 0x8F10
				Inclusive = unchecked((int)36624),
				// GL_EXCLUSIVE_EXT = 0x8F11
				Exclusive = unchecked((int)36625),
				// GL_WINDOW_RECTANGLE_EXT = 0x8F12
				WindowRectangle = unchecked((int)36626),
				// GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13
				WindowRectangleMode = unchecked((int)36627),
				// GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14
				MaxWindowRectangles = unchecked((int)36628),
				// GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15
				NumWindowRectangles = unchecked((int)36629),
			}
			public const string NAME_STRING = "GL_EXT_window_rectangles";
			#region command delegates
			// void glWindowRectanglesEXT (GLenum mode, GLsizei count, GLint* box)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowRectanglesDelegate (System.UInt32 mode, System.Int32 count, IntPtr box);
			#endregion // command delegates
			#region commands
			// void glWindowRectanglesEXT (GLenum mode, GLsizei count, GLint* box)
			public readonly WindowRectanglesDelegate WindowRectangles;
			#endregion // commands
			public ExtWindowRectangles (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glWindowRectanglesEXT", out WindowRectangles);
			}
		}
		public partial class ExtX11SyncObject
		{
			public enum All
			{
				// GL_SYNC_X11_FENCE_EXT = 0x90E1
				SyncX11Fence = unchecked((int)37089),
			}
			public const string NAME_STRING = "GL_EXT_x11_sync_object";
			#region command delegates
			// GLsync glImportSyncEXT (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr ImportSyncDelegate (System.UInt32 external_sync_type, System.IntPtr external_sync, System.UInt32 flags);
			#endregion // command delegates
			#region commands
			// GLsync glImportSyncEXT (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags)
			public readonly ImportSyncDelegate ImportSync;
			#endregion // commands
			public ExtX11SyncObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glImportSyncEXT", out ImportSync);
			}
		}
	}
}

