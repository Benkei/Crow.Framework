using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class ExtCreateContextEs2Profile
		{
			public enum All
			{
				// WGL_CONTEXT_ES2_PROFILE_BIT_EXT = 0x4
				ContextEs2ProfileBit = unchecked((int)4),
			}
			public const string NAME_STRING = "WGL_EXT_create_context_es2_profile";
		}
		public partial class ExtCreateContextEsProfile
		{
			public enum All
			{
				// WGL_CONTEXT_ES_PROFILE_BIT_EXT = 0x4
				ContextEsProfileBit = unchecked((int)4),
			}
			public const string NAME_STRING = "WGL_EXT_create_context_es_profile";
		}
		public partial class ExtDepthFloat
		{
			public enum All
			{
				// WGL_DEPTH_FLOAT_EXT = 0x2040
				DepthFloat = unchecked((int)8256),
			}
			public const string NAME_STRING = "WGL_EXT_depth_float";
		}
		public partial class ExtDisplayColorTable
		{
			public const string NAME_STRING = "WGL_EXT_display_color_table";
			#region command delegates
			// GLboolean wglBindDisplayColorTableEXT (GLushort id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindDisplayColorTableDelegate (System.UInt16 id);
			// GLboolean wglCreateDisplayColorTableEXT (GLushort id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean CreateDisplayColorTableDelegate (System.UInt16 id);
			// VOID wglDestroyDisplayColorTableEXT (GLushort id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr DestroyDisplayColorTableDelegate (System.UInt16 id);
			// GLboolean wglLoadDisplayColorTableEXT (GLushort* table, GLuint length)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean LoadDisplayColorTableDelegate (IntPtr table, System.UInt32 length);
			#endregion // command delegates
			#region commands
			// GLboolean wglBindDisplayColorTableEXT (GLushort id)
			public readonly BindDisplayColorTableDelegate BindDisplayColorTable;
			// GLboolean wglCreateDisplayColorTableEXT (GLushort id)
			public readonly CreateDisplayColorTableDelegate CreateDisplayColorTable;
			// VOID wglDestroyDisplayColorTableEXT (GLushort id)
			public readonly DestroyDisplayColorTableDelegate DestroyDisplayColorTable;
			// GLboolean wglLoadDisplayColorTableEXT (GLushort* table, GLuint length)
			public readonly LoadDisplayColorTableDelegate LoadDisplayColorTable;
			#endregion // commands
			public ExtDisplayColorTable (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindDisplayColorTableEXT", out BindDisplayColorTable);
				resolver.LoadHandle ("wglCreateDisplayColorTableEXT", out CreateDisplayColorTable);
				resolver.LoadHandle ("wglDestroyDisplayColorTableEXT", out DestroyDisplayColorTable);
				resolver.LoadHandle ("wglLoadDisplayColorTableEXT", out LoadDisplayColorTable);
			}
		}
		public partial class ExtExtensionsString
		{
			public const string NAME_STRING = "WGL_EXT_extensions_string";
			#region command delegates
			// void* wglGetExtensionsStringEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr GetExtensionsStringDelegate ();
			#endregion // command delegates
			#region commands
			// void* wglGetExtensionsStringEXT ()
			public readonly GetExtensionsStringDelegate GetExtensionsString;
			#endregion // commands
			public ExtExtensionsString (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetExtensionsStringEXT", out GetExtensionsString);
			}
		}
		public partial class ExtFramebufferSrgb
		{
			public enum All
			{
				// WGL_FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x20A9
				FramebufferSrgbCapable = unchecked((int)8361),
			}
			public const string NAME_STRING = "WGL_EXT_framebuffer_sRGB";
		}
		public partial class ExtMakeCurrentRead
		{
			public enum All
			{
				// ERROR_INVALID_PIXEL_TYPE_EXT = 0x2043
				ErrorInvalidPixelType = unchecked((int)8259),
			}
			public const string NAME_STRING = "WGL_EXT_make_current_read";
			#region command delegates
			// HDC wglGetCurrentReadDCEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetCurrentReadDCDelegate ();
			// BOOL wglMakeContextCurrentEXT (HDC hDrawDC, HDC hReadDC, HGLRC hglrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean MakeContextCurrentDelegate (System.IntPtr hDrawDC, System.IntPtr hReadDC, System.IntPtr hglrc);
			#endregion // command delegates
			#region commands
			// HDC wglGetCurrentReadDCEXT ()
			public readonly GetCurrentReadDCDelegate GetCurrentReadDC;
			// BOOL wglMakeContextCurrentEXT (HDC hDrawDC, HDC hReadDC, HGLRC hglrc)
			public readonly MakeContextCurrentDelegate MakeContextCurrent;
			#endregion // commands
			public ExtMakeCurrentRead (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetCurrentReadDCEXT", out GetCurrentReadDC);
				resolver.LoadHandle ("wglMakeContextCurrentEXT", out MakeContextCurrent);
			}
		}
		public partial class ExtMultisample
		{
			public enum All
			{
				// WGL_SAMPLE_BUFFERS_EXT = 0x2041
				SampleBuffers = unchecked((int)8257),
				// WGL_SAMPLES_EXT = 0x2042
				Samples = unchecked((int)8258),
			}
			public const string NAME_STRING = "WGL_EXT_multisample";
		}
		public partial class ExtPbuffer
		{
			public enum All
			{
				// WGL_DRAW_TO_PBUFFER_EXT = 0x202D
				DrawToPbuffer = unchecked((int)8237),
				// WGL_MAX_PBUFFER_PIXELS_EXT = 0x202E
				MaxPbufferPixels = unchecked((int)8238),
				// WGL_MAX_PBUFFER_WIDTH_EXT = 0x202F
				MaxPbufferWidth = unchecked((int)8239),
				// WGL_MAX_PBUFFER_HEIGHT_EXT = 0x2030
				MaxPbufferHeight = unchecked((int)8240),
				// WGL_OPTIMAL_PBUFFER_WIDTH_EXT = 0x2031
				OptimalPbufferWidth = unchecked((int)8241),
				// WGL_OPTIMAL_PBUFFER_HEIGHT_EXT = 0x2032
				OptimalPbufferHeight = unchecked((int)8242),
				// WGL_PBUFFER_LARGEST_EXT = 0x2033
				PbufferLargest = unchecked((int)8243),
				// WGL_PBUFFER_WIDTH_EXT = 0x2034
				PbufferWidth = unchecked((int)8244),
				// WGL_PBUFFER_HEIGHT_EXT = 0x2035
				PbufferHeight = unchecked((int)8245),
			}
			public const string NAME_STRING = "WGL_EXT_pbuffer";
			#region command delegates
			// HPBUFFEREXT wglCreatePbufferEXT (HDC hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreatePbufferDelegate (System.IntPtr hDC, System.Int32 iPixelFormat, System.Int32 iWidth, System.Int32 iHeight, IntPtr piAttribList);
			// BOOL wglDestroyPbufferEXT (HPBUFFEREXT hPbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DestroyPbufferDelegate (System.IntPtr hPbuffer);
			// HDC wglGetPbufferDCEXT (HPBUFFEREXT hPbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetPbufferDCDelegate (System.IntPtr hPbuffer);
			// BOOL wglQueryPbufferEXT (HPBUFFEREXT hPbuffer, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryPbufferDelegate (System.IntPtr hPbuffer, System.Int32 iAttribute, IntPtr piValue);
			// int wglReleasePbufferDCEXT (HPBUFFEREXT hPbuffer, HDC hDC)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 ReleasePbufferDCDelegate (System.IntPtr hPbuffer, System.IntPtr hDC);
			#endregion // command delegates
			#region commands
			// HPBUFFEREXT wglCreatePbufferEXT (HDC hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
			public readonly CreatePbufferDelegate CreatePbuffer;
			// BOOL wglDestroyPbufferEXT (HPBUFFEREXT hPbuffer)
			public readonly DestroyPbufferDelegate DestroyPbuffer;
			// HDC wglGetPbufferDCEXT (HPBUFFEREXT hPbuffer)
			public readonly GetPbufferDCDelegate GetPbufferDC;
			// BOOL wglQueryPbufferEXT (HPBUFFEREXT hPbuffer, int iAttribute, int* piValue)
			public readonly QueryPbufferDelegate QueryPbuffer;
			// int wglReleasePbufferDCEXT (HPBUFFEREXT hPbuffer, HDC hDC)
			public readonly ReleasePbufferDCDelegate ReleasePbufferDC;
			#endregion // commands
			public ExtPbuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCreatePbufferEXT", out CreatePbuffer);
				resolver.LoadHandle ("wglDestroyPbufferEXT", out DestroyPbuffer);
				resolver.LoadHandle ("wglGetPbufferDCEXT", out GetPbufferDC);
				resolver.LoadHandle ("wglQueryPbufferEXT", out QueryPbuffer);
				resolver.LoadHandle ("wglReleasePbufferDCEXT", out ReleasePbufferDC);
			}
		}
		public partial class ExtPixelFormat
		{
			public enum All
			{
				// WGL_NUMBER_PIXEL_FORMATS_EXT = 0x2000
				NumberPixelFormats = unchecked((int)8192),
				// WGL_DRAW_TO_WINDOW_EXT = 0x2001
				DrawToWindow = unchecked((int)8193),
				// WGL_DRAW_TO_BITMAP_EXT = 0x2002
				DrawToBitmap = unchecked((int)8194),
				// WGL_ACCELERATION_EXT = 0x2003
				Acceleration = unchecked((int)8195),
				// WGL_NEED_PALETTE_EXT = 0x2004
				NeedPalette = unchecked((int)8196),
				// WGL_NEED_SYSTEM_PALETTE_EXT = 0x2005
				NeedSystemPalette = unchecked((int)8197),
				// WGL_SWAP_LAYER_BUFFERS_EXT = 0x2006
				SwapLayerBuffers = unchecked((int)8198),
				// WGL_SWAP_METHOD_EXT = 0x2007
				SwapMethod = unchecked((int)8199),
				// WGL_NUMBER_OVERLAYS_EXT = 0x2008
				NumberOverlays = unchecked((int)8200),
				// WGL_NUMBER_UNDERLAYS_EXT = 0x2009
				NumberUnderlays = unchecked((int)8201),
				// WGL_TRANSPARENT_EXT = 0x200A
				Transparent = unchecked((int)8202),
				// WGL_TRANSPARENT_VALUE_EXT = 0x200B
				TransparentValue = unchecked((int)8203),
				// WGL_SHARE_DEPTH_EXT = 0x200C
				ShareDepth = unchecked((int)8204),
				// WGL_SHARE_STENCIL_EXT = 0x200D
				ShareStencil = unchecked((int)8205),
				// WGL_SHARE_ACCUM_EXT = 0x200E
				ShareAccum = unchecked((int)8206),
				// WGL_SUPPORT_GDI_EXT = 0x200F
				SupportGdi = unchecked((int)8207),
				// WGL_SUPPORT_OPENGL_EXT = 0x2010
				SupportOpengl = unchecked((int)8208),
				// WGL_DOUBLE_BUFFER_EXT = 0x2011
				DoubleBuffer = unchecked((int)8209),
				// WGL_STEREO_EXT = 0x2012
				Stereo = unchecked((int)8210),
				// WGL_PIXEL_TYPE_EXT = 0x2013
				PixelType = unchecked((int)8211),
				// WGL_COLOR_BITS_EXT = 0x2014
				ColorBits = unchecked((int)8212),
				// WGL_RED_BITS_EXT = 0x2015
				RedBits = unchecked((int)8213),
				// WGL_RED_SHIFT_EXT = 0x2016
				RedShift = unchecked((int)8214),
				// WGL_GREEN_BITS_EXT = 0x2017
				GreenBits = unchecked((int)8215),
				// WGL_GREEN_SHIFT_EXT = 0x2018
				GreenShift = unchecked((int)8216),
				// WGL_BLUE_BITS_EXT = 0x2019
				BlueBits = unchecked((int)8217),
				// WGL_BLUE_SHIFT_EXT = 0x201A
				BlueShift = unchecked((int)8218),
				// WGL_ALPHA_BITS_EXT = 0x201B
				AlphaBits = unchecked((int)8219),
				// WGL_ALPHA_SHIFT_EXT = 0x201C
				AlphaShift = unchecked((int)8220),
				// WGL_ACCUM_BITS_EXT = 0x201D
				AccumBits = unchecked((int)8221),
				// WGL_ACCUM_RED_BITS_EXT = 0x201E
				AccumRedBits = unchecked((int)8222),
				// WGL_ACCUM_GREEN_BITS_EXT = 0x201F
				AccumGreenBits = unchecked((int)8223),
				// WGL_ACCUM_BLUE_BITS_EXT = 0x2020
				AccumBlueBits = unchecked((int)8224),
				// WGL_ACCUM_ALPHA_BITS_EXT = 0x2021
				AccumAlphaBits = unchecked((int)8225),
				// WGL_DEPTH_BITS_EXT = 0x2022
				DepthBits = unchecked((int)8226),
				// WGL_STENCIL_BITS_EXT = 0x2023
				StencilBits = unchecked((int)8227),
				// WGL_AUX_BUFFERS_EXT = 0x2024
				AuxBuffers = unchecked((int)8228),
				// WGL_NO_ACCELERATION_EXT = 0x2025
				NoAcceleration = unchecked((int)8229),
				// WGL_GENERIC_ACCELERATION_EXT = 0x2026
				GenericAcceleration = unchecked((int)8230),
				// WGL_FULL_ACCELERATION_EXT = 0x2027
				FullAcceleration = unchecked((int)8231),
				// WGL_SWAP_EXCHANGE_EXT = 0x2028
				SwapExchange = unchecked((int)8232),
				// WGL_SWAP_COPY_EXT = 0x2029
				SwapCopy = unchecked((int)8233),
				// WGL_SWAP_UNDEFINED_EXT = 0x202A
				SwapUndefined = unchecked((int)8234),
				// WGL_TYPE_RGBA_EXT = 0x202B
				TypeRgba = unchecked((int)8235),
				// WGL_TYPE_COLORINDEX_EXT = 0x202C
				TypeColorindex = unchecked((int)8236),
			}
			public const string NAME_STRING = "WGL_EXT_pixel_format";
			#region command delegates
			// BOOL wglChoosePixelFormatEXT (HDC hdc, int* piAttribIList, FLOAT* pfAttribFList, UINT nMaxFormats, int* piFormats, UINT* nNumFormats)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ChoosePixelFormatDelegate (System.IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, System.UInt32 nMaxFormats, IntPtr piFormats, IntPtr nNumFormats);
			// BOOL wglGetPixelFormatAttribfvEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, FLOAT* pfValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetPixelFormatAttribfvDelegate (System.IntPtr hdc, System.Int32 iPixelFormat, System.Int32 iLayerPlane, System.UInt32 nAttributes, IntPtr piAttributes, IntPtr pfValues);
			// BOOL wglGetPixelFormatAttribivEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, int* piValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetPixelFormatAttribivDelegate (System.IntPtr hdc, System.Int32 iPixelFormat, System.Int32 iLayerPlane, System.UInt32 nAttributes, IntPtr piAttributes, IntPtr piValues);
			#endregion // command delegates
			#region commands
			// BOOL wglChoosePixelFormatEXT (HDC hdc, int* piAttribIList, FLOAT* pfAttribFList, UINT nMaxFormats, int* piFormats, UINT* nNumFormats)
			public readonly ChoosePixelFormatDelegate ChoosePixelFormat;
			// BOOL wglGetPixelFormatAttribfvEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, FLOAT* pfValues)
			public readonly GetPixelFormatAttribfvDelegate GetPixelFormatAttribfv;
			// BOOL wglGetPixelFormatAttribivEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int* piAttributes, int* piValues)
			public readonly GetPixelFormatAttribivDelegate GetPixelFormatAttribiv;
			#endregion // commands
			public ExtPixelFormat (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglChoosePixelFormatEXT", out ChoosePixelFormat);
				resolver.LoadHandle ("wglGetPixelFormatAttribfvEXT", out GetPixelFormatAttribfv);
				resolver.LoadHandle ("wglGetPixelFormatAttribivEXT", out GetPixelFormatAttribiv);
			}
		}
		public partial class ExtPixelFormatPackedFloat
		{
			public enum All
			{
				// WGL_TYPE_RGBA_UNSIGNED_FLOAT_EXT = 0x20A8
				TypeRgbaUnsignedFloat = unchecked((int)8360),
			}
			public const string NAME_STRING = "WGL_EXT_pixel_format_packed_float";
		}
		public partial class ExtSwapControl
		{
			public const string NAME_STRING = "WGL_EXT_swap_control";
			#region command delegates
			// int wglGetSwapIntervalEXT ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetSwapIntervalDelegate ();
			// BOOL wglSwapIntervalEXT (int interval)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SwapIntervalDelegate (System.Int32 interval);
			#endregion // command delegates
			#region commands
			// int wglGetSwapIntervalEXT ()
			public readonly GetSwapIntervalDelegate GetSwapInterval;
			// BOOL wglSwapIntervalEXT (int interval)
			public readonly SwapIntervalDelegate SwapInterval;
			#endregion // commands
			public ExtSwapControl (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglGetSwapIntervalEXT", out GetSwapInterval);
				resolver.LoadHandle ("wglSwapIntervalEXT", out SwapInterval);
			}
		}
	}
}

