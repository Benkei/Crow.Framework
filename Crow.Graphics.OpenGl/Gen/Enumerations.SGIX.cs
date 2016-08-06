using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public enum FfdMaskSGIX
	{
	}
	public enum FfdTargetSGIX
	{
		// GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
		GeometryDeformation = unchecked((int)33172),
		// GL_TEXTURE_DEFORMATION_SGIX = 0x8195
		TextureDeformation = unchecked((int)33173),
	}
	public enum FragmentLightModelParameterSGIX
	{
		// GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
		FragmentLightModelLocalViewer = unchecked((int)33800),
		// GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
		FragmentLightModelTwoSide = unchecked((int)33801),
		// GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
		FragmentLightModelAmbient = unchecked((int)33802),
		// GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
		FragmentLightModelNormalInterpolation = unchecked((int)33803),
	}
	public enum LightEnvParameterSGIX
	{
		// GL_LIGHT_ENV_MODE_SGIX = 0x8407
		LightEnvMode = unchecked((int)33799),
	}
}

