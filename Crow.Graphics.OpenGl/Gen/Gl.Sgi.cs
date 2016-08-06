using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class SgiColorMatrix
		{
			public enum All
			{
				// GL_COLOR_MATRIX_SGI = 0x80B1
				ColorMatrix = unchecked((int)32945),
				// GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
				ColorMatrixStackDepth = unchecked((int)32946),
				// GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
				MaxColorMatrixStackDepth = unchecked((int)32947),
				// GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
				PostColorMatrixRedScale = unchecked((int)32948),
				// GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
				PostColorMatrixGreenScale = unchecked((int)32949),
				// GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
				PostColorMatrixBlueScale = unchecked((int)32950),
				// GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
				PostColorMatrixAlphaScale = unchecked((int)32951),
				// GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
				PostColorMatrixRedBias = unchecked((int)32952),
				// GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
				PostColorMatrixGreenBias = unchecked((int)32953),
				// GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
				PostColorMatrixBlueBias = unchecked((int)32954),
				// GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
				PostColorMatrixAlphaBias = unchecked((int)32955),
			}
			public const string NAME_STRING = "GL_SGI_color_matrix";
		}
		public partial class SgiColorTable
		{
			public enum All
			{
				// GL_COLOR_TABLE_SGI = 0x80D0
				ColorTable = unchecked((int)32976),
				// GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
				PostConvolutionColorTable = unchecked((int)32977),
				// GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
				PostColorMatrixColorTable = unchecked((int)32978),
				// GL_PROXY_COLOR_TABLE_SGI = 0x80D3
				ProxyColorTable = unchecked((int)32979),
				// GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
				ProxyPostConvolutionColorTable = unchecked((int)32980),
				// GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
				ProxyPostColorMatrixColorTable = unchecked((int)32981),
				// GL_COLOR_TABLE_SCALE_SGI = 0x80D6
				ColorTableScale = unchecked((int)32982),
				// GL_COLOR_TABLE_BIAS_SGI = 0x80D7
				ColorTableBias = unchecked((int)32983),
				// GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
				ColorTableFormat = unchecked((int)32984),
				// GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
				ColorTableWidth = unchecked((int)32985),
				// GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
				ColorTableRedSize = unchecked((int)32986),
				// GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
				ColorTableGreenSize = unchecked((int)32987),
				// GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
				ColorTableBlueSize = unchecked((int)32988),
				// GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
				ColorTableAlphaSize = unchecked((int)32989),
				// GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
				ColorTableLuminanceSize = unchecked((int)32990),
				// GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
				ColorTableIntensitySize = unchecked((int)32991),
			}
			public const string NAME_STRING = "GL_SGI_color_table";
			#region command delegates
			// void glColorTableSGI (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorTableDelegate (ColorTableTargetSGI target, System.UInt32 internalformat, System.Int32 width, PixelFormat format, PixelType type, IntPtr table);
			// void glColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorTableParameterfvDelegate (ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, IntPtr @params);
			// void glColorTableParameterivSGI (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorTableParameterivDelegate (ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, IntPtr @params);
			// void glCopyColorTableSGI (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyColorTableDelegate (ColorTableTargetSGI target, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width);
			// void glGetColorTableSGI (GLenum target, GLenum format, GLenum type, void* table)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableDelegate (ColorTableTargetSGI target, PixelFormat format, PixelType type, IntPtr table);
			// void glGetColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableParameterfvDelegate (ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, IntPtr @params);
			// void glGetColorTableParameterivSGI (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetColorTableParameterivDelegate (ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glColorTableSGI (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table)
			public readonly ColorTableDelegate ColorTable;
			// void glColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat* params)
			public readonly ColorTableParameterfvDelegate ColorTableParameterfv;
			// void glColorTableParameterivSGI (GLenum target, GLenum pname, GLint* params)
			public readonly ColorTableParameterivDelegate ColorTableParameteriv;
			// void glCopyColorTableSGI (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
			public readonly CopyColorTableDelegate CopyColorTable;
			// void glGetColorTableSGI (GLenum target, GLenum format, GLenum type, void* table)
			public readonly GetColorTableDelegate GetColorTable;
			// void glGetColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetColorTableParameterfvDelegate GetColorTableParameterfv;
			// void glGetColorTableParameterivSGI (GLenum target, GLenum pname, GLint* params)
			public readonly GetColorTableParameterivDelegate GetColorTableParameteriv;
			#endregion // commands
			public SgiColorTable (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorTableSGI", out ColorTable);
				resolver.LoadHandle ("glColorTableParameterfvSGI", out ColorTableParameterfv);
				resolver.LoadHandle ("glColorTableParameterivSGI", out ColorTableParameteriv);
				resolver.LoadHandle ("glCopyColorTableSGI", out CopyColorTable);
				resolver.LoadHandle ("glGetColorTableSGI", out GetColorTable);
				resolver.LoadHandle ("glGetColorTableParameterfvSGI", out GetColorTableParameterfv);
				resolver.LoadHandle ("glGetColorTableParameterivSGI", out GetColorTableParameteriv);
			}
		}
		public partial class SgiTextureColorTable
		{
			public enum All
			{
				// GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
				TextureColorTable = unchecked((int)32956),
				// GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
				ProxyTextureColorTable = unchecked((int)32957),
			}
			public const string NAME_STRING = "GL_SGI_texture_color_table";
		}
	}
}

