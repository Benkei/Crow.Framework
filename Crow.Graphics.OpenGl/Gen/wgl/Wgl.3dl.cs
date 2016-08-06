using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class _3dlStereoControl
		{
			public enum All
			{
				// WGL_STEREO_EMITTER_ENABLE_3DL = 0x2055
				StereoEmitterEnable = unchecked((int)8277),
				// WGL_STEREO_EMITTER_DISABLE_3DL = 0x2056
				StereoEmitterDisable = unchecked((int)8278),
				// WGL_STEREO_POLARITY_NORMAL_3DL = 0x2057
				StereoPolarityNormal = unchecked((int)8279),
				// WGL_STEREO_POLARITY_INVERT_3DL = 0x2058
				StereoPolarityInvert = unchecked((int)8280),
			}
			public const string NAME_STRING = "WGL_3DL_stereo_control";
			#region command delegates
			// BOOL wglSetStereoEmitterState3DL (HDC hDC, UINT uState)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SetStereoEmitterStateDelegate (System.IntPtr hDC, System.UInt32 uState);
			#endregion // command delegates
			#region commands
			// BOOL wglSetStereoEmitterState3DL (HDC hDC, UINT uState)
			public readonly SetStereoEmitterStateDelegate SetStereoEmitterState;
			#endregion // commands
			public _3dlStereoControl (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglSetStereoEmitterState3DL", out SetStereoEmitterState);
			}
		}
	}
}

