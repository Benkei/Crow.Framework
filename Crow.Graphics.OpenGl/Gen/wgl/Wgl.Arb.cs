using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class ArbBufferRegion
		{
			public enum All
			{
				// WGL_FRONT_COLOR_BUFFER_BIT_ARB = 0x1
				FrontColorBufferBit = unchecked((int)1),
				// WGL_BACK_COLOR_BUFFER_BIT_ARB = 0x2
				BackColorBufferBit = unchecked((int)2),
				// WGL_DEPTH_BUFFER_BIT_ARB = 0x4
				DepthBufferBit = unchecked((int)4),
				// WGL_STENCIL_BUFFER_BIT_ARB = 0x8
				StencilBufferBit = unchecked((int)8),
			}
			public const string NAME_STRING = "WGL_ARB_buffer_region";
			#region command delegates
			// HANDLE wglCreateBufferRegionARB (HDC hDC, int iLayerPlane, UINT uType)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateBufferRegionDelegate (System.IntPtr hDC, System.Int32 iLayerPlane, System.UInt32 uType);
			// VOID wglDeleteBufferRegionARB (HANDLE hRegion)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr DeleteBufferRegionDelegate (System.IntPtr hRegion);
			// BOOL wglRestoreBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean RestoreBufferRegionDelegate (System.IntPtr hRegion, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 xSrc, System.Int32 ySrc);
			// BOOL wglSaveBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SaveBufferRegionDelegate (System.IntPtr hRegion, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
			#endregion // command delegates
			#region commands
			// HANDLE wglCreateBufferRegionARB (HDC hDC, int iLayerPlane, UINT uType)
			public readonly CreateBufferRegionDelegate CreateBufferRegion;
			// VOID wglDeleteBufferRegionARB (HANDLE hRegion)
			public readonly DeleteBufferRegionDelegate DeleteBufferRegion;
			// BOOL wglRestoreBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
			public readonly RestoreBufferRegionDelegate RestoreBufferRegion;
			// BOOL wglSaveBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height)
			public readonly SaveBufferRegionDelegate SaveBufferRegion;
			#endregion // commands
			public ArbBufferRegion (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCreateBufferRegionARB", out CreateBufferRegion);
				resolver.LoadHandle ("wglDeleteBufferRegionARB", out DeleteBufferRegion);
				resolver.LoadHandle ("wglRestoreBufferRegionARB", out RestoreBufferRegion);
				resolver.LoadHandle ("wglSaveBufferRegionARB", out SaveBufferRegion);
			}
		}
		public partial class ArbContextFlushControl
		{
			public enum All
			{
				// WGL_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB = 0x0
				ContextReleaseBehaviorNone = unchecked((int)0),
				// WGL_CONTEXT_RELEASE_BEHAVIOR_ARB = 0x2097
				ContextReleaseBehavior = unchecked((int)8343),
				// WGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB = 0x2098
				ContextReleaseBehaviorFlush = unchecked((int)8344),
			}
			public const string NAME_STRING = "WGL_ARB_context_flush_control";
		}
		public partial class ArbCreateContext
		{
			public enum All
			{
				// WGL_CONTEXT_DEBUG_BIT_ARB = 0x1
				ContextDebugBit = unchecked((int)1),
				// WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x2
				ContextForwardCompatibleBit = unchecked((int)2),
				// WGL_CONTEXT_MAJOR_VERSION_ARB = 0x2091
				ContextMajorVersion = unchecked((int)8337),
				// WGL_CONTEXT_MINOR_VERSION_ARB = 0x2092
				ContextMinorVersion = unchecked((int)8338),
				// WGL_CONTEXT_LAYER_PLANE_ARB = 0x2093
				ContextLayerPlane = unchecked((int)8339),
				// WGL_CONTEXT_FLAGS_ARB = 0x2094
				ContextFlags = unchecked((int)8340),
				// ERROR_INVALID_VERSION_ARB = 0x2095
				ErrorInvalidVersion = unchecked((int)8341),
			}
			public const string NAME_STRING = "WGL_ARB_create_context";
			#region command delegates
			// HGLRC wglCreateContextAttribsARB (HDC hDC, HGLRC hShareContext, int* attribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateContextAttribsDelegate (System.IntPtr hDC, System.IntPtr hShareContext, IntPtr attribList);
			#endregion // command delegates
			#region commands
			// HGLRC wglCreateContextAttribsARB (HDC hDC, HGLRC hShareContext, int* attribList)
			public readonly CreateContextAttribsDelegate CreateContextAttribs;
			#endregion // commands
			public ArbCreateContext (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCreateContextAttribsARB", out CreateContextAttribs);
			}
		}
		public partial class ArbCreateContextProfile
		{
			public enum All
			{
				// WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x1
				ContextCoreProfileBit = unchecked((int)1),
				// WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x2
				ContextCompatibilityProfileBit = unchecked((int)2),
				// ERROR_INVALID_PROFILE_ARB = 0x2096
				ErrorInvalidProfile = unchecked((int)8342),
				// WGL_CONTEXT_PROFILE_MASK_ARB = 0x9126
				ContextProfileMask = unchecked((int)37158),
			}
			public const string NAME_STRING = "WGL_ARB_create_context_profile";
		}
		public partial class ArbCreateContextRobustness
		{
			public enum All
			{
				// WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB = 0x4
				ContextRobustAccessBit = unchecked((int)4),
				// WGL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252
				LoseContextOnReset = unchecked((int)33362),
				// WGL_CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256
				ContextResetNotificationStrategy = unchecked((int)33366),
				// WGL_NO_RESET_NOTIFICATION_ARB = 0x8261
				NoResetNotification = unchecked((int)33377),
			}
			public const string NAME_STRING = "WGL_ARB_create_context_robustness";
		}
		public partial class ArbExtensionsString
		{
			public const string NAME_STRING = "WGL_ARB_extensions_string";
			#region command delegates
			// void* wglGetExtensionsStringARB (HDC hdc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr GetExtensionsStringDelegate (System.IntPtr hdc);
			#endregion // command delegates
			#region commands
			// void* wglGetExtensionsStringARB (HDC hdc)
			public readonly GetExtensionsStringDelegate GetExtensionsString;
			#endregion // commands
			public ArbExtensionsString (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetExtensionsStringARB", out GetExtensionsString);
			}
		}
		public partial class ArbFramebufferSrgb
		{
			public enum All
			{
				// WGL_FRAMEBUFFER_SRGB_CAPABLE_ARB = 0x20A9
				FramebufferSrgbCapable = unchecked((int)8361),
			}
			public const string NAME_STRING = "WGL_ARB_framebuffer_sRGB";
		}
		public partial class ArbMakeCurrentRead
		{
			public enum All
			{
				// ERROR_INVALID_PIXEL_TYPE_ARB = 0x2043
				ErrorInvalidPixelType = unchecked((int)8259),
				// ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = 0x2054
				ErrorIncompatibleDeviceContexts = unchecked((int)8276),
			}
			public const string NAME_STRING = "WGL_ARB_make_current_read";
			#region command delegates
			// HDC wglGetCurrentReadDCARB ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetCurrentReadDCDelegate ();
			// BOOL wglMakeContextCurrentARB (HDC hDrawDC, HDC hReadDC, HGLRC hglrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean MakeContextCurrentDelegate (System.IntPtr hDrawDC, System.IntPtr hReadDC, System.IntPtr hglrc);
			#endregion // command delegates
			#region commands
			// HDC wglGetCurrentReadDCARB ()
			public readonly GetCurrentReadDCDelegate GetCurrentReadDC;
			// BOOL wglMakeContextCurrentARB (HDC hDrawDC, HDC hReadDC, HGLRC hglrc)
			public readonly MakeContextCurrentDelegate MakeContextCurrent;
			#endregion // commands
			public ArbMakeCurrentRead (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetCurrentReadDCARB", out GetCurrentReadDC);
				resolver.LoadHandle ("wglMakeContextCurrentARB", out MakeContextCurrent);
			}
		}
		public partial class ArbMultisample
		{
			public enum All
			{
				// WGL_SAMPLE_BUFFERS_ARB = 0x2041
				SampleBuffers = unchecked((int)8257),
				// WGL_SAMPLES_ARB = 0x2042
				Samples = unchecked((int)8258),
			}
			public const string NAME_STRING = "WGL_ARB_multisample";
		}
		public partial class ArbPbuffer
		{
			public enum All
			{
				// WGL_DRAW_TO_PBUFFER_ARB = 0x202D
				DrawToPbuffer = unchecked((int)8237),
				// WGL_MAX_PBUFFER_PIXELS_ARB = 0x202E
				MaxPbufferPixels = unchecked((int)8238),
				// WGL_MAX_PBUFFER_WIDTH_ARB = 0x202F
				MaxPbufferWidth = unchecked((int)8239),
				// WGL_MAX_PBUFFER_HEIGHT_ARB = 0x2030
				MaxPbufferHeight = unchecked((int)8240),
				// WGL_PBUFFER_LARGEST_ARB = 0x2033
				PbufferLargest = unchecked((int)8243),
				// WGL_PBUFFER_WIDTH_ARB = 0x2034
				PbufferWidth = unchecked((int)8244),
				// WGL_PBUFFER_HEIGHT_ARB = 0x2035
				PbufferHeight = unchecked((int)8245),
				// WGL_PBUFFER_LOST_ARB = 0x2036
				PbufferLost = unchecked((int)8246),
			}
			public const string NAME_STRING = "WGL_ARB_pbuffer";
			#region command delegates
			// HPBUFFERARB wglCreatePbufferARB (HDC hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreatePbufferDelegate (System.IntPtr hDC, System.Int32 iPixelFormat, System.Int32 iWidth, System.Int32 iHeight, IntPtr piAttribList);
			// BOOL wglDestroyPbufferARB (HPBUFFERARB hPbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DestroyPbufferDelegate (System.IntPtr hPbuffer);
			// HDC wglGetPbufferDCARB (HPBUFFERARB hPbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetPbufferDCDelegate (System.IntPtr hPbuffer);
			// BOOL wglQueryPbufferARB (HPBUFFERARB hPbuffer, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryPbufferDelegate (System.IntPtr hPbuffer, System.Int32 iAttribute, IntPtr piValue);
			// int wglReleasePbufferDCARB (HPBUFFERARB hPbuffer, HDC hDC)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 ReleasePbufferDCDelegate (System.IntPtr hPbuffer, System.IntPtr hDC);
			#endregion // command delegates
			#region commands
			// HPBUFFERARB wglCreatePbufferARB (HDC hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
			public readonly CreatePbufferDelegate CreatePbuffer;
			// BOOL wglDestroyPbufferARB (HPBUFFERARB hPbuffer)
			public readonly DestroyPbufferDelegate DestroyPbuffer;
			// HDC wglGetPbufferDCARB (HPBUFFERARB hPbuffer)
			public readonly GetPbufferDCDelegate GetPbufferDC;
			// BOOL wglQueryPbufferARB (HPBUFFERARB hPbuffer, int iAttribute, int* piValue)
			public readonly QueryPbufferDelegate QueryPbuffer;
			// int wglReleasePbufferDCARB (HPBUFFERARB hPbuffer, HDC hDC)
			public readonly ReleasePbufferDCDelegate ReleasePbufferDC;
			#endregion // commands
			public ArbPbuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCreatePbufferARB", out CreatePbuffer);
				resolver.LoadHandle ("wglDestroyPbufferARB", out DestroyPbuffer);
				resolver.LoadHandle ("wglGetPbufferDCARB", out GetPbufferDC);
				resolver.LoadHandle ("wglQueryPbufferARB", out QueryPbuffer);
				resolver.LoadHandle ("wglReleasePbufferDCARB", out ReleasePbufferDC);
			}
		}
		public partial class ArbPixelFormat
		{
			public enum All
			{
				// WGL_NUMBER_PIXEL_FORMATS_ARB = 0x2000
				NumberPixelFormats = unchecked((int)8192),
				// WGL_DRAW_TO_WINDOW_ARB = 0x2001
				DrawToWindow = unchecked((int)8193),
				// WGL_DRAW_TO_BITMAP_ARB = 0x2002
				DrawToBitmap = unchecked((int)8194),
				// WGL_ACCELERATION_ARB = 0x2003
				Acceleration = unchecked((int)8195),
				// WGL_NEED_PALETTE_ARB = 0x2004
				NeedPalette = unchecked((int)8196),
				// WGL_NEED_SYSTEM_PALETTE_ARB = 0x2005
				NeedSystemPalette = unchecked((int)8197),
				// WGL_SWAP_LAYER_BUFFERS_ARB = 0x2006
				SwapLayerBuffers = unchecked((int)8198),
				// WGL_SWAP_METHOD_ARB = 0x2007
				SwapMethod = unchecked((int)8199),
				// WGL_NUMBER_OVERLAYS_ARB = 0x2008
				NumberOverlays = unchecked((int)8200),
				// WGL_NUMBER_UNDERLAYS_ARB = 0x2009
				NumberUnderlays = unchecked((int)8201),
				// WGL_TRANSPARENT_ARB = 0x200A
				Transparent = unchecked((int)8202),
				// WGL_SHARE_DEPTH_ARB = 0x200C
				ShareDepth = unchecked((int)8204),
				// WGL_SHARE_STENCIL_ARB = 0x200D
				ShareStencil = unchecked((int)8205),
				// WGL_SHARE_ACCUM_ARB = 0x200E
				ShareAccum = unchecked((int)8206),
				// WGL_SUPPORT_GDI_ARB = 0x200F
				SupportGdi = unchecked((int)8207),
				// WGL_SUPPORT_OPENGL_ARB = 0x2010
				SupportOpengl = unchecked((int)8208),
				// WGL_DOUBLE_BUFFER_ARB = 0x2011
				DoubleBuffer = unchecked((int)8209),
				// WGL_STEREO_ARB = 0x2012
				Stereo = unchecked((int)8210),
				// WGL_PIXEL_TYPE_ARB = 0x2013
				PixelType = unchecked((int)8211),
				// WGL_COLOR_BITS_ARB = 0x2014
				ColorBits = unchecked((int)8212),
				// WGL_RED_BITS_ARB = 0x2015
				RedBits = unchecked((int)8213),
				// WGL_RED_SHIFT_ARB = 0x2016
				RedShift = unchecked((int)8214),
				// WGL_GREEN_BITS_ARB = 0x2017
				GreenBits = unchecked((int)8215),
				// WGL_GREEN_SHIFT_ARB = 0x2018
				GreenShift = unchecked((int)8216),
				// WGL_BLUE_BITS_ARB = 0x2019
				BlueBits = unchecked((int)8217),
				// WGL_BLUE_SHIFT_ARB = 0x201A
				BlueShift = unchecked((int)8218),
				// WGL_ALPHA_BITS_ARB = 0x201B
				AlphaBits = unchecked((int)8219),
				// WGL_ALPHA_SHIFT_ARB = 0x201C
				AlphaShift = unchecked((int)8220),
				// WGL_ACCUM_BITS_ARB = 0x201D
				AccumBits = unchecked((int)8221),
				// WGL_ACCUM_RED_BITS_ARB = 0x201E
				AccumRedBits = unchecked((int)8222),
				// WGL_ACCUM_GREEN_BITS_ARB = 0x201F
				AccumGreenBits = unchecked((int)8223),
				// WGL_ACCUM_BLUE_BITS_ARB = 0x2020
				AccumBlueBits = unchecked((int)8224),
				// WGL_ACCUM_ALPHA_BITS_ARB = 0x2021
				AccumAlphaBits = unchecked((int)8225),
				// WGL_DEPTH_BITS_ARB = 0x2022
				DepthBits = unchecked((int)8226),
				// WGL_STENCIL_BITS_ARB = 0x2023
				StencilBits = unchecked((int)8227),
				// WGL_AUX_BUFFERS_ARB = 0x2024
				AuxBuffers = unchecked((int)8228),
				// WGL_NO_ACCELERATION_ARB = 0x2025
				NoAcceleration = unchecked((int)8229),
				// WGL_GENERIC_ACCELERATION_ARB = 0x2026
				GenericAcceleration = unchecked((int)8230),
				// WGL_FULL_ACCELERATION_ARB = 0x2027
				FullAcceleration = unchecked((int)8231),
				// WGL_SWAP_EXCHANGE_ARB = 0x2028
				SwapExchange = unchecked((int)8232),
				// WGL_SWAP_COPY_ARB = 0x2029
				SwapCopy = unchecked((int)8233),
				// WGL_SWAP_UNDEFINED_ARB = 0x202A
				SwapUndefined = unchecked((int)8234),
				// WGL_TYPE_RGBA_ARB = 0x202B
				TypeRgba = unchecked((int)8235),
				// WGL_TYPE_COLORINDEX_ARB = 0x202C
				TypeColorindex = unchecked((int)8236),
				// WGL_TRANSPARENT_RED_VALUE_ARB = 0x2037
				TransparentRedValue = unchecked((int)8247),
				// WGL_TRANSPARENT_GREEN_VALUE_ARB = 0x2038
				TransparentGreenValue = unchecked((int)8248),
				// WGL_TRANSPARENT_BLUE_VALUE_ARB = 0x2039
				TransparentBlueValue = unchecked((int)8249),
				// WGL_TRANSPARENT_ALPHA_VALUE_ARB = 0x203A
				TransparentAlphaValue = unchecked((int)8250),
				// WGL_TRANSPARENT_INDEX_VALUE_ARB = 0x203B
				TransparentIndexValue = unchecked((int)8251),
			}
			public const string NAME_STRING = "WGL_ARB_pixel_format";
			#region command delegates
			// BOOL wglChoosePixelFormatARB (HDC hdc, int* piAttribIList, FLOAT* pfAttribFList, UINT nMaxFormats, int* piFormats, UINT* nNumFormats)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ChoosePixelFormatDelegate (System.IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, System.UInt32 nMaxFormats, IntPtr piFormats, IntPtr nNumFormats);
			// BOOL wglGetPixelFormatAttribfvARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, FLOAT* pfValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetPixelFormatAttribfvDelegate (System.IntPtr hdc, System.Int32 iPixelFormat, System.Int32 iLayerPlane, System.UInt32 nAttributes, IntPtr piAttributes, IntPtr pfValues);
			// BOOL wglGetPixelFormatAttribivARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, int* piValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetPixelFormatAttribivDelegate (System.IntPtr hdc, System.Int32 iPixelFormat, System.Int32 iLayerPlane, System.UInt32 nAttributes, IntPtr piAttributes, IntPtr piValues);
			#endregion // command delegates
			#region commands
			// BOOL wglChoosePixelFormatARB (HDC hdc, int* piAttribIList, FLOAT* pfAttribFList, UINT nMaxFormats, int* piFormats, UINT* nNumFormats)
			public readonly ChoosePixelFormatDelegate ChoosePixelFormat;
			// BOOL wglGetPixelFormatAttribfvARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, FLOAT* pfValues)
			public readonly GetPixelFormatAttribfvDelegate GetPixelFormatAttribfv;
			// BOOL wglGetPixelFormatAttribivARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, int* piValues)
			public readonly GetPixelFormatAttribivDelegate GetPixelFormatAttribiv;
			#endregion // commands
			public ArbPixelFormat (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglChoosePixelFormatARB", out ChoosePixelFormat);
				resolver.LoadHandle ("wglGetPixelFormatAttribfvARB", out GetPixelFormatAttribfv);
				resolver.LoadHandle ("wglGetPixelFormatAttribivARB", out GetPixelFormatAttribiv);
			}
		}
		public partial class ArbPixelFormatFloat
		{
			public enum All
			{
				// WGL_TYPE_RGBA_FLOAT_ARB = 0x21A0
				TypeRgbaFloat = unchecked((int)8608),
			}
			public const string NAME_STRING = "WGL_ARB_pixel_format_float";
		}
		public partial class ArbRenderTexture
		{
			public enum All
			{
				// WGL_BIND_TO_TEXTURE_RGB_ARB = 0x2070
				BindToTextureRgb = unchecked((int)8304),
				// WGL_BIND_TO_TEXTURE_RGBA_ARB = 0x2071
				BindToTextureRgba = unchecked((int)8305),
				// WGL_TEXTURE_FORMAT_ARB = 0x2072
				TextureFormat = unchecked((int)8306),
				// WGL_TEXTURE_TARGET_ARB = 0x2073
				TextureTarget = unchecked((int)8307),
				// WGL_MIPMAP_TEXTURE_ARB = 0x2074
				MipmapTexture = unchecked((int)8308),
				// WGL_TEXTURE_RGB_ARB = 0x2075
				TextureRgb = unchecked((int)8309),
				// WGL_TEXTURE_RGBA_ARB = 0x2076
				TextureRgba = unchecked((int)8310),
				// WGL_NO_TEXTURE_ARB = 0x2077
				NoTexture = unchecked((int)8311),
				// WGL_TEXTURE_CUBE_MAP_ARB = 0x2078
				TextureCubeMap = unchecked((int)8312),
				// WGL_TEXTURE_1D_ARB = 0x2079
				Texture1d = unchecked((int)8313),
				// WGL_TEXTURE_2D_ARB = 0x207A
				Texture2d = unchecked((int)8314),
				// WGL_MIPMAP_LEVEL_ARB = 0x207B
				MipmapLevel = unchecked((int)8315),
				// WGL_CUBE_MAP_FACE_ARB = 0x207C
				CubeMapFace = unchecked((int)8316),
				// WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x207D
				TextureCubeMapPositiveX = unchecked((int)8317),
				// WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x207E
				TextureCubeMapNegativeX = unchecked((int)8318),
				// WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x207F
				TextureCubeMapPositiveY = unchecked((int)8319),
				// WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x2080
				TextureCubeMapNegativeY = unchecked((int)8320),
				// WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x2081
				TextureCubeMapPositiveZ = unchecked((int)8321),
				// WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x2082
				TextureCubeMapNegativeZ = unchecked((int)8322),
				// WGL_FRONT_LEFT_ARB = 0x2083
				FrontLeft = unchecked((int)8323),
				// WGL_FRONT_RIGHT_ARB = 0x2084
				FrontRight = unchecked((int)8324),
				// WGL_BACK_LEFT_ARB = 0x2085
				BackLeft = unchecked((int)8325),
				// WGL_BACK_RIGHT_ARB = 0x2086
				BackRight = unchecked((int)8326),
				// WGL_AUX0_ARB = 0x2087
				Aux0 = unchecked((int)8327),
				// WGL_AUX1_ARB = 0x2088
				Aux1 = unchecked((int)8328),
				// WGL_AUX2_ARB = 0x2089
				Aux2 = unchecked((int)8329),
				// WGL_AUX3_ARB = 0x208A
				Aux3 = unchecked((int)8330),
				// WGL_AUX4_ARB = 0x208B
				Aux4 = unchecked((int)8331),
				// WGL_AUX5_ARB = 0x208C
				Aux5 = unchecked((int)8332),
				// WGL_AUX6_ARB = 0x208D
				Aux6 = unchecked((int)8333),
				// WGL_AUX7_ARB = 0x208E
				Aux7 = unchecked((int)8334),
				// WGL_AUX8_ARB = 0x208F
				Aux8 = unchecked((int)8335),
				// WGL_AUX9_ARB = 0x2090
				Aux9 = unchecked((int)8336),
			}
			public const string NAME_STRING = "WGL_ARB_render_texture";
			#region command delegates
			// BOOL wglBindTexImageARB (HPBUFFERARB hPbuffer, int iBuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindTexImageDelegate (System.IntPtr hPbuffer, System.Int32 iBuffer);
			// BOOL wglReleaseTexImageARB (HPBUFFERARB hPbuffer, int iBuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ReleaseTexImageDelegate (System.IntPtr hPbuffer, System.Int32 iBuffer);
			// BOOL wglSetPbufferAttribARB (HPBUFFERARB hPbuffer, int* piAttribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SetPbufferAttribDelegate (System.IntPtr hPbuffer, IntPtr piAttribList);
			#endregion // command delegates
			#region commands
			// BOOL wglBindTexImageARB (HPBUFFERARB hPbuffer, int iBuffer)
			public readonly BindTexImageDelegate BindTexImage;
			// BOOL wglReleaseTexImageARB (HPBUFFERARB hPbuffer, int iBuffer)
			public readonly ReleaseTexImageDelegate ReleaseTexImage;
			// BOOL wglSetPbufferAttribARB (HPBUFFERARB hPbuffer, int* piAttribList)
			public readonly SetPbufferAttribDelegate SetPbufferAttrib;
			#endregion // commands
			public ArbRenderTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindTexImageARB", out BindTexImage);
				resolver.LoadHandle ("wglReleaseTexImageARB", out ReleaseTexImage);
				resolver.LoadHandle ("wglSetPbufferAttribARB", out SetPbufferAttrib);
			}
		}
		public partial class ArbRobustnessApplicationIsolation
		{
			public enum All
			{
				// WGL_CONTEXT_RESET_ISOLATION_BIT_ARB = 0x8
				ContextResetIsolationBit = unchecked((int)8),
			}
			public const string NAME_STRING = "WGL_ARB_robustness_application_isolation";
		}
	}
}

