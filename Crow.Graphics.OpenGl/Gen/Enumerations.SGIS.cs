using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public enum PixelTexGenParameterNameSGIS
	{
		// GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
		PixelFragmentRgbSource = unchecked((int)33620),
		// GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
		PixelFragmentAlphaSource = unchecked((int)33621),
	}
	public enum SamplePatternSGIS
	{
		// GL_1PASS_EXT = 0x80A1
		// GL_1PASS_SGIS = 0x80A1
		_1pass = unchecked((int)32929),
		// GL_2PASS_0_EXT = 0x80A2
		// GL_2PASS_0_SGIS = 0x80A2
		_2pass0 = unchecked((int)32930),
		// GL_2PASS_1_EXT = 0x80A3
		// GL_2PASS_1_SGIS = 0x80A3
		_2pass1 = unchecked((int)32931),
		// GL_4PASS_0_EXT = 0x80A4
		// GL_4PASS_0_SGIS = 0x80A4
		_4pass0 = unchecked((int)32932),
		// GL_4PASS_1_EXT = 0x80A5
		// GL_4PASS_1_SGIS = 0x80A5
		_4pass1 = unchecked((int)32933),
		// GL_4PASS_2_EXT = 0x80A6
		// GL_4PASS_2_SGIS = 0x80A6
		_4pass2 = unchecked((int)32934),
		// GL_4PASS_3_EXT = 0x80A7
		// GL_4PASS_3_SGIS = 0x80A7
		_4pass3 = unchecked((int)32935),
	}
}

