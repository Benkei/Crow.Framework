using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public enum OcclusionQueryEventMaskAMD
	{
		// GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x1
		QueryDepthPassEventBit = unchecked((int)1),
		// GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x2
		QueryDepthFailEventBit = unchecked((int)2),
		// GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x4
		QueryStencilFailEventBit = unchecked((int)4),
		// GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x8
		QueryDepthBoundsFailEventBit = unchecked((int)8),
		// GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
		QueryAllEventBits = unchecked((int)4294967295),
	}
}

