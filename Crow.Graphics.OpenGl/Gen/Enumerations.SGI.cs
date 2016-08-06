using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public enum ColorTableParameterPNameSGI
	{
		// GL_COLOR_TABLE_SCALE = 0x80D6
		// GL_COLOR_TABLE_SCALE_SGI = 0x80D6
		ColorTableScale = unchecked((int)32982),
		// GL_COLOR_TABLE_BIAS = 0x80D7
		// GL_COLOR_TABLE_BIAS_SGI = 0x80D7
		ColorTableBias = unchecked((int)32983),
	}
	public enum ColorTableTargetSGI
	{
		// GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
		TextureColorTable = unchecked((int)32956),
		// GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
		ProxyTextureColorTable = unchecked((int)32957),
		// GL_COLOR_TABLE = 0x80D0
		// GL_COLOR_TABLE_SGI = 0x80D0
		ColorTable = unchecked((int)32976),
		// GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
		// GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
		PostConvolutionColorTable = unchecked((int)32977),
		// GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
		// GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
		PostColorMatrixColorTable = unchecked((int)32978),
		// GL_PROXY_COLOR_TABLE = 0x80D3
		// GL_PROXY_COLOR_TABLE_SGI = 0x80D3
		ProxyColorTable = unchecked((int)32979),
		// GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
		// GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
		ProxyPostConvolutionColorTable = unchecked((int)32980),
		// GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
		// GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
		ProxyPostColorMatrixColorTable = unchecked((int)32981),
	}
	public enum GetColorTableParameterPNameSGI
	{
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
}

