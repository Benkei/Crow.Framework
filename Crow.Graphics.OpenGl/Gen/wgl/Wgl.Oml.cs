using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class OmlSyncControl
		{
			public const string NAME_STRING = "WGL_OML_sync_control";
			#region command delegates
			// BOOL wglGetMscRateOML (HDC hdc, INT32* numerator, INT32* denominator)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetMscRateDelegate (System.IntPtr hdc, IntPtr numerator, IntPtr denominator);
			// BOOL wglGetSyncValuesOML (HDC hdc, INT64* ust, INT64* msc, INT64* sbc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetSyncValuesDelegate (System.IntPtr hdc, IntPtr ust, IntPtr msc, IntPtr sbc);
			// INT64 wglSwapBuffersMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int64 SwapBuffersMscDelegate (System.IntPtr hdc, System.Int64 target_msc, System.Int64 divisor, System.Int64 remainder);
			// INT64 wglSwapLayerBuffersMscOML (HDC hdc, int fuPlanes, INT64 target_msc, INT64 divisor, INT64 remainder)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int64 SwapLayerBuffersMscDelegate (System.IntPtr hdc, System.Int32 fuPlanes, System.Int64 target_msc, System.Int64 divisor, System.Int64 remainder);
			// BOOL wglWaitForMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder, INT64* ust, INT64* msc, INT64* sbc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean WaitForMscDelegate (System.IntPtr hdc, System.Int64 target_msc, System.Int64 divisor, System.Int64 remainder, IntPtr ust, IntPtr msc, IntPtr sbc);
			// BOOL wglWaitForSbcOML (HDC hdc, INT64 target_sbc, INT64* ust, INT64* msc, INT64* sbc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean WaitForSbcDelegate (System.IntPtr hdc, System.Int64 target_sbc, IntPtr ust, IntPtr msc, IntPtr sbc);
			#endregion // command delegates
			#region commands
			// BOOL wglGetMscRateOML (HDC hdc, INT32* numerator, INT32* denominator)
			public readonly GetMscRateDelegate GetMscRate;
			// BOOL wglGetSyncValuesOML (HDC hdc, INT64* ust, INT64* msc, INT64* sbc)
			public readonly GetSyncValuesDelegate GetSyncValues;
			// INT64 wglSwapBuffersMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder)
			public readonly SwapBuffersMscDelegate SwapBuffersMsc;
			// INT64 wglSwapLayerBuffersMscOML (HDC hdc, int fuPlanes, INT64 target_msc, INT64 divisor, INT64 remainder)
			public readonly SwapLayerBuffersMscDelegate SwapLayerBuffersMsc;
			// BOOL wglWaitForMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder, INT64* ust, INT64* msc, INT64* sbc)
			public readonly WaitForMscDelegate WaitForMsc;
			// BOOL wglWaitForSbcOML (HDC hdc, INT64 target_sbc, INT64* ust, INT64* msc, INT64* sbc)
			public readonly WaitForSbcDelegate WaitForSbc;
			#endregion // commands
			public OmlSyncControl (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetMscRateOML", out GetMscRate);
				resolver.LoadHandle ("wglGetSyncValuesOML", out GetSyncValues);
				resolver.LoadHandle ("wglSwapBuffersMscOML", out SwapBuffersMsc);
				resolver.LoadHandle ("wglSwapLayerBuffersMscOML", out SwapLayerBuffersMsc);
				resolver.LoadHandle ("wglWaitForMscOML", out WaitForMsc);
				resolver.LoadHandle ("wglWaitForSbcOML", out WaitForSbc);
			}
		}
	}
}

