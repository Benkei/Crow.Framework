using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class I3dDigitalVideoControl
		{
			public enum All
			{
				// WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = 0x2050
				DigitalVideoCursorAlphaFramebuffer = unchecked((int)8272),
				// WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = 0x2051
				DigitalVideoCursorAlphaValue = unchecked((int)8273),
				// WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = 0x2052
				DigitalVideoCursorIncluded = unchecked((int)8274),
				// WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = 0x2053
				DigitalVideoGammaCorrected = unchecked((int)8275),
			}
			public const string NAME_STRING = "WGL_I3D_digital_video_control";
			#region command delegates
			// BOOL wglGetDigitalVideoParametersI3D (HDC hDC, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetDigitalVideoParametersDelegate (System.IntPtr hDC, System.Int32 iAttribute, IntPtr piValue);
			// BOOL wglSetDigitalVideoParametersI3D (HDC hDC, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SetDigitalVideoParametersDelegate (System.IntPtr hDC, System.Int32 iAttribute, IntPtr piValue);
			#endregion // command delegates
			#region commands
			// BOOL wglGetDigitalVideoParametersI3D (HDC hDC, int iAttribute, int* piValue)
			public readonly GetDigitalVideoParametersDelegate GetDigitalVideoParameters;
			// BOOL wglSetDigitalVideoParametersI3D (HDC hDC, int iAttribute, int* piValue)
			public readonly SetDigitalVideoParametersDelegate SetDigitalVideoParameters;
			#endregion // commands
			public I3dDigitalVideoControl (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetDigitalVideoParametersI3D", out GetDigitalVideoParameters);
				resolver.LoadHandle ("wglSetDigitalVideoParametersI3D", out SetDigitalVideoParameters);
			}
		}
		public partial class I3dGamma
		{
			public enum All
			{
				// WGL_GAMMA_TABLE_SIZE_I3D = 0x204E
				GammaTableSize = unchecked((int)8270),
				// WGL_GAMMA_EXCLUDE_DESKTOP_I3D = 0x204F
				GammaExcludeDesktop = unchecked((int)8271),
			}
			public const string NAME_STRING = "WGL_I3D_gamma";
			#region command delegates
			// BOOL wglGetGammaTableParametersI3D (HDC hDC, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGammaTableParametersDelegate (System.IntPtr hDC, System.Int32 iAttribute, IntPtr piValue);
			// BOOL wglGetGammaTableI3D (HDC hDC, int iEntries, USHORT* puRed, USHORT* puGreen, USHORT* puBlue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGammaTableDelegate (System.IntPtr hDC, System.Int32 iEntries, IntPtr puRed, IntPtr puGreen, IntPtr puBlue);
			// BOOL wglSetGammaTableParametersI3D (HDC hDC, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SetGammaTableParametersDelegate (System.IntPtr hDC, System.Int32 iAttribute, IntPtr piValue);
			// BOOL wglSetGammaTableI3D (HDC hDC, int iEntries, USHORT* puRed, USHORT* puGreen, USHORT* puBlue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SetGammaTableDelegate (System.IntPtr hDC, System.Int32 iEntries, IntPtr puRed, IntPtr puGreen, IntPtr puBlue);
			#endregion // command delegates
			#region commands
			// BOOL wglGetGammaTableParametersI3D (HDC hDC, int iAttribute, int* piValue)
			public readonly GetGammaTableParametersDelegate GetGammaTableParameters;
			// BOOL wglGetGammaTableI3D (HDC hDC, int iEntries, USHORT* puRed, USHORT* puGreen, USHORT* puBlue)
			public readonly GetGammaTableDelegate GetGammaTable;
			// BOOL wglSetGammaTableParametersI3D (HDC hDC, int iAttribute, int* piValue)
			public readonly SetGammaTableParametersDelegate SetGammaTableParameters;
			// BOOL wglSetGammaTableI3D (HDC hDC, int iEntries, USHORT* puRed, USHORT* puGreen, USHORT* puBlue)
			public readonly SetGammaTableDelegate SetGammaTable;
			#endregion // commands
			public I3dGamma (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetGammaTableParametersI3D", out GetGammaTableParameters);
				resolver.LoadHandle ("wglGetGammaTableI3D", out GetGammaTable);
				resolver.LoadHandle ("wglSetGammaTableParametersI3D", out SetGammaTableParameters);
				resolver.LoadHandle ("wglSetGammaTableI3D", out SetGammaTable);
			}
		}
		public partial class I3dGenlock
		{
			public enum All
			{
				// WGL_GENLOCK_SOURCE_MULTIVIEW_I3D = 0x2044
				GenlockSourceMultiview = unchecked((int)8260),
				// WGL_GENLOCK_SOURCE_EXTERNAL_SYNC_I3D = 0x2045
				GenlockSourceExternalSync = unchecked((int)8261),
				// WGL_GENLOCK_SOURCE_EXTERNAL_FIELD_I3D = 0x2046
				GenlockSourceExternalField = unchecked((int)8262),
				// WGL_GENLOCK_SOURCE_EXTERNAL_TTL_I3D = 0x2047
				GenlockSourceExternalTtl = unchecked((int)8263),
				// WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D = 0x2048
				GenlockSourceDigitalSync = unchecked((int)8264),
				// WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D = 0x2049
				GenlockSourceDigitalField = unchecked((int)8265),
				// WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D = 0x204A
				GenlockSourceEdgeFalling = unchecked((int)8266),
				// WGL_GENLOCK_SOURCE_EDGE_RISING_I3D = 0x204B
				GenlockSourceEdgeRising = unchecked((int)8267),
				// WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D = 0x204C
				GenlockSourceEdgeBoth = unchecked((int)8268),
			}
			public const string NAME_STRING = "WGL_I3D_genlock";
			#region command delegates
			// BOOL wglDisableGenlockI3D (HDC hDC)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DisableGenlockDelegate (System.IntPtr hDC);
			// BOOL wglEnableGenlockI3D (HDC hDC)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EnableGenlockDelegate (System.IntPtr hDC);
			// BOOL wglGenlockSampleRateI3D (HDC hDC, UINT uRate)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GenlockSampleRateDelegate (System.IntPtr hDC, System.UInt32 uRate);
			// BOOL wglGenlockSourceDelayI3D (HDC hDC, UINT uDelay)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GenlockSourceDelayDelegate (System.IntPtr hDC, System.UInt32 uDelay);
			// BOOL wglGenlockSourceEdgeI3D (HDC hDC, UINT uEdge)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GenlockSourceEdgeDelegate (System.IntPtr hDC, System.UInt32 uEdge);
			// BOOL wglGenlockSourceI3D (HDC hDC, UINT uSource)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GenlockSourceDelegate (System.IntPtr hDC, System.UInt32 uSource);
			// BOOL wglGetGenlockSampleRateI3D (HDC hDC, UINT* uRate)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGenlockSampleRateDelegate (System.IntPtr hDC, IntPtr uRate);
			// BOOL wglGetGenlockSourceDelayI3D (HDC hDC, UINT* uDelay)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGenlockSourceDelayDelegate (System.IntPtr hDC, IntPtr uDelay);
			// BOOL wglGetGenlockSourceEdgeI3D (HDC hDC, UINT* uEdge)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGenlockSourceEdgeDelegate (System.IntPtr hDC, IntPtr uEdge);
			// BOOL wglGetGenlockSourceI3D (HDC hDC, UINT* uSource)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetGenlockSourceDelegate (System.IntPtr hDC, IntPtr uSource);
			// BOOL wglIsEnabledGenlockI3D (HDC hDC, BOOL* pFlag)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsEnabledGenlockDelegate (System.IntPtr hDC, IntPtr pFlag);
			// BOOL wglQueryGenlockMaxSourceDelayI3D (HDC hDC, UINT* uMaxLineDelay, UINT* uMaxPixelDelay)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryGenlockMaxSourceDelayDelegate (System.IntPtr hDC, IntPtr uMaxLineDelay, IntPtr uMaxPixelDelay);
			#endregion // command delegates
			#region commands
			// BOOL wglDisableGenlockI3D (HDC hDC)
			public readonly DisableGenlockDelegate DisableGenlock;
			// BOOL wglEnableGenlockI3D (HDC hDC)
			public readonly EnableGenlockDelegate EnableGenlock;
			// BOOL wglGenlockSampleRateI3D (HDC hDC, UINT uRate)
			public readonly GenlockSampleRateDelegate GenlockSampleRate;
			// BOOL wglGenlockSourceDelayI3D (HDC hDC, UINT uDelay)
			public readonly GenlockSourceDelayDelegate GenlockSourceDelay;
			// BOOL wglGenlockSourceEdgeI3D (HDC hDC, UINT uEdge)
			public readonly GenlockSourceEdgeDelegate GenlockSourceEdge;
			// BOOL wglGenlockSourceI3D (HDC hDC, UINT uSource)
			public readonly GenlockSourceDelegate GenlockSource;
			// BOOL wglGetGenlockSampleRateI3D (HDC hDC, UINT* uRate)
			public readonly GetGenlockSampleRateDelegate GetGenlockSampleRate;
			// BOOL wglGetGenlockSourceDelayI3D (HDC hDC, UINT* uDelay)
			public readonly GetGenlockSourceDelayDelegate GetGenlockSourceDelay;
			// BOOL wglGetGenlockSourceEdgeI3D (HDC hDC, UINT* uEdge)
			public readonly GetGenlockSourceEdgeDelegate GetGenlockSourceEdge;
			// BOOL wglGetGenlockSourceI3D (HDC hDC, UINT* uSource)
			public readonly GetGenlockSourceDelegate GetGenlockSource;
			// BOOL wglIsEnabledGenlockI3D (HDC hDC, BOOL* pFlag)
			public readonly IsEnabledGenlockDelegate IsEnabledGenlock;
			// BOOL wglQueryGenlockMaxSourceDelayI3D (HDC hDC, UINT* uMaxLineDelay, UINT* uMaxPixelDelay)
			public readonly QueryGenlockMaxSourceDelayDelegate QueryGenlockMaxSourceDelay;
			#endregion // commands
			public I3dGenlock (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglDisableGenlockI3D", out DisableGenlock);
				resolver.LoadHandle ("wglEnableGenlockI3D", out EnableGenlock);
				resolver.LoadHandle ("wglGenlockSampleRateI3D", out GenlockSampleRate);
				resolver.LoadHandle ("wglGenlockSourceDelayI3D", out GenlockSourceDelay);
				resolver.LoadHandle ("wglGenlockSourceEdgeI3D", out GenlockSourceEdge);
				resolver.LoadHandle ("wglGenlockSourceI3D", out GenlockSource);
				resolver.LoadHandle ("wglGetGenlockSampleRateI3D", out GetGenlockSampleRate);
				resolver.LoadHandle ("wglGetGenlockSourceDelayI3D", out GetGenlockSourceDelay);
				resolver.LoadHandle ("wglGetGenlockSourceEdgeI3D", out GetGenlockSourceEdge);
				resolver.LoadHandle ("wglGetGenlockSourceI3D", out GetGenlockSource);
				resolver.LoadHandle ("wglIsEnabledGenlockI3D", out IsEnabledGenlock);
				resolver.LoadHandle ("wglQueryGenlockMaxSourceDelayI3D", out QueryGenlockMaxSourceDelay);
			}
		}
		public partial class I3dImageBuffer
		{
			public enum All
			{
				// WGL_IMAGE_BUFFER_MIN_ACCESS_I3D = 0x1
				ImageBufferMinAccess = unchecked((int)1),
				// WGL_IMAGE_BUFFER_LOCK_I3D = 0x2
				ImageBufferLock = unchecked((int)2),
			}
			public const string NAME_STRING = "WGL_I3D_image_buffer";
			#region command delegates
			// BOOL wglAssociateImageBufferEventsI3D (HDC hDC, HANDLE* pEvent, LPVOID* pAddress, DWORD* pSize, UINT count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean AssociateImageBufferEventsDelegate (System.IntPtr hDC, IntPtr pEvent, IntPtr pAddress, IntPtr pSize, System.UInt32 count);
			// LPVOID wglCreateImageBufferI3D (HDC hDC, DWORD dwSize, UINT uFlags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateImageBufferDelegate (System.IntPtr hDC, System.Int16 dwSize, System.UInt32 uFlags);
			// BOOL wglDestroyImageBufferI3D (HDC hDC, LPVOID pAddress)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DestroyImageBufferDelegate (System.IntPtr hDC, System.IntPtr pAddress);
			// BOOL wglReleaseImageBufferEventsI3D (HDC hDC, LPVOID* pAddress, UINT count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ReleaseImageBufferEventsDelegate (System.IntPtr hDC, IntPtr pAddress, System.UInt32 count);
			#endregion // command delegates
			#region commands
			// BOOL wglAssociateImageBufferEventsI3D (HDC hDC, HANDLE* pEvent, LPVOID* pAddress, DWORD* pSize, UINT count)
			public readonly AssociateImageBufferEventsDelegate AssociateImageBufferEvents;
			// LPVOID wglCreateImageBufferI3D (HDC hDC, DWORD dwSize, UINT uFlags)
			public readonly CreateImageBufferDelegate CreateImageBuffer;
			// BOOL wglDestroyImageBufferI3D (HDC hDC, LPVOID pAddress)
			public readonly DestroyImageBufferDelegate DestroyImageBuffer;
			// BOOL wglReleaseImageBufferEventsI3D (HDC hDC, LPVOID* pAddress, UINT count)
			public readonly ReleaseImageBufferEventsDelegate ReleaseImageBufferEvents;
			#endregion // commands
			public I3dImageBuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglAssociateImageBufferEventsI3D", out AssociateImageBufferEvents);
				resolver.LoadHandle ("wglCreateImageBufferI3D", out CreateImageBuffer);
				resolver.LoadHandle ("wglDestroyImageBufferI3D", out DestroyImageBuffer);
				resolver.LoadHandle ("wglReleaseImageBufferEventsI3D", out ReleaseImageBufferEvents);
			}
		}
		public partial class I3dSwapFrameLock
		{
			public const string NAME_STRING = "WGL_I3D_swap_frame_lock";
			#region command delegates
			// BOOL wglDisableFrameLockI3D ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DisableFrameLockDelegate ();
			// BOOL wglEnableFrameLockI3D ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EnableFrameLockDelegate ();
			// BOOL wglIsEnabledFrameLockI3D (BOOL* pFlag)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsEnabledFrameLockDelegate (IntPtr pFlag);
			// BOOL wglQueryFrameLockMasterI3D (BOOL* pFlag)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryFrameLockMasterDelegate (IntPtr pFlag);
			#endregion // command delegates
			#region commands
			// BOOL wglDisableFrameLockI3D ()
			public readonly DisableFrameLockDelegate DisableFrameLock;
			// BOOL wglEnableFrameLockI3D ()
			public readonly EnableFrameLockDelegate EnableFrameLock;
			// BOOL wglIsEnabledFrameLockI3D (BOOL* pFlag)
			public readonly IsEnabledFrameLockDelegate IsEnabledFrameLock;
			// BOOL wglQueryFrameLockMasterI3D (BOOL* pFlag)
			public readonly QueryFrameLockMasterDelegate QueryFrameLockMaster;
			#endregion // commands
			public I3dSwapFrameLock (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglDisableFrameLockI3D", out DisableFrameLock);
				resolver.LoadHandle ("wglEnableFrameLockI3D", out EnableFrameLock);
				resolver.LoadHandle ("wglIsEnabledFrameLockI3D", out IsEnabledFrameLock);
				resolver.LoadHandle ("wglQueryFrameLockMasterI3D", out QueryFrameLockMaster);
			}
		}
		public partial class I3dSwapFrameUsage
		{
			public const string NAME_STRING = "WGL_I3D_swap_frame_usage";
			#region command delegates
			// BOOL wglBeginFrameTrackingI3D ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BeginFrameTrackingDelegate ();
			// BOOL wglEndFrameTrackingI3D ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EndFrameTrackingDelegate ();
			// BOOL wglGetFrameUsageI3D (void* pUsage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetFrameUsageDelegate (IntPtr pUsage);
			// BOOL wglQueryFrameTrackingI3D (DWORD* pFrameCount, DWORD* pMissedFrames, void* pLastMissedUsage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryFrameTrackingDelegate (IntPtr pFrameCount, IntPtr pMissedFrames, IntPtr pLastMissedUsage);
			#endregion // command delegates
			#region commands
			// BOOL wglBeginFrameTrackingI3D ()
			public readonly BeginFrameTrackingDelegate BeginFrameTracking;
			// BOOL wglEndFrameTrackingI3D ()
			public readonly EndFrameTrackingDelegate EndFrameTracking;
			// BOOL wglGetFrameUsageI3D (void* pUsage)
			public readonly GetFrameUsageDelegate GetFrameUsage;
			// BOOL wglQueryFrameTrackingI3D (DWORD* pFrameCount, DWORD* pMissedFrames, void* pLastMissedUsage)
			public readonly QueryFrameTrackingDelegate QueryFrameTracking;
			#endregion // commands
			public I3dSwapFrameUsage (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBeginFrameTrackingI3D", out BeginFrameTracking);
				resolver.LoadHandle ("wglEndFrameTrackingI3D", out EndFrameTracking);
				resolver.LoadHandle ("wglGetFrameUsageI3D", out GetFrameUsage);
				resolver.LoadHandle ("wglQueryFrameTrackingI3D", out QueryFrameTracking);
			}
		}
	}
}

