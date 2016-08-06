using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public enum BlendEquationModeEXT
	{
		// GL_LOGIC_OP = 0xBF1
		LogicOp = unchecked((int)3057),
		// GL_FUNC_ADD_EXT = 0x8006
		FuncAdd = unchecked((int)32774),
		// GL_MIN_EXT = 0x8007
		Min = unchecked((int)32775),
		// GL_MAX_EXT = 0x8008
		Max = unchecked((int)32776),
		// GL_FUNC_SUBTRACT_EXT = 0x800A
		FuncSubtract = unchecked((int)32778),
		// GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
		FuncReverseSubtract = unchecked((int)32779),
		// GL_ALPHA_MIN_SGIX = 0x8320
		AlphaMin = unchecked((int)33568),
		// GL_ALPHA_MAX_SGIX = 0x8321
		AlphaMax = unchecked((int)33569),
	}
	public enum ConvolutionParameterEXT
	{
		// GL_CONVOLUTION_BORDER_MODE = 0x8013
		// GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
		ConvolutionBorderMode = unchecked((int)32787),
		// GL_CONVOLUTION_FILTER_SCALE = 0x8014
		// GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
		ConvolutionFilterScale = unchecked((int)32788),
		// GL_CONVOLUTION_FILTER_BIAS = 0x8015
		// GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
		ConvolutionFilterBias = unchecked((int)32789),
	}
	public enum ConvolutionTargetEXT
	{
		// GL_CONVOLUTION_1D = 0x8010
		// GL_CONVOLUTION_1D_EXT = 0x8010
		Convolution1d = unchecked((int)32784),
		// GL_CONVOLUTION_2D = 0x8011
		// GL_CONVOLUTION_2D_EXT = 0x8011
		Convolution2d = unchecked((int)32785),
	}
	public enum FogPointerTypeEXT
	{
		// GL_FLOAT = 0x1406
		Float = unchecked((int)5126),
		// GL_DOUBLE = 0x140A
		Double = unchecked((int)5130),
	}
	public enum GetHistogramParameterPNameEXT
	{
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
	}
	public enum GetMinmaxParameterPNameEXT
	{
		// GL_MINMAX_FORMAT = 0x802F
		// GL_MINMAX_FORMAT_EXT = 0x802F
		MinmaxFormat = unchecked((int)32815),
		// GL_MINMAX_SINK = 0x8030
		// GL_MINMAX_SINK_EXT = 0x8030
		MinmaxSink = unchecked((int)32816),
	}
	public enum HistogramTargetEXT
	{
		// GL_HISTOGRAM = 0x8024
		// GL_HISTOGRAM_EXT = 0x8024
		Histogram = unchecked((int)32804),
		// GL_PROXY_HISTOGRAM = 0x8025
		// GL_PROXY_HISTOGRAM_EXT = 0x8025
		ProxyHistogram = unchecked((int)32805),
	}
	public enum MinmaxTargetEXT
	{
		// GL_MINMAX = 0x802E
		// GL_MINMAX_EXT = 0x802E
		Minmax = unchecked((int)32814),
	}
	public enum SeparableTargetEXT
	{
		// GL_SEPARABLE_2D = 0x8012
		// GL_SEPARABLE_2D_EXT = 0x8012
		Separable2d = unchecked((int)32786),
	}
}

