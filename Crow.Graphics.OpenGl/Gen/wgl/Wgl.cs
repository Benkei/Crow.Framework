using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public enum All
		{
			// WGL_FONT_LINES = 0x0
			FontLines = unchecked((int)0),
			// WGL_FONT_POLYGONS = 0x1
			FontPolygons = unchecked((int)1),
			// WGL_SWAP_MAIN_PLANE = 0x1
			SwapMainPlane = unchecked((int)1),
			// WGL_SWAP_OVERLAY1 = 0x2
			SwapOverlay1 = unchecked((int)2),
			// WGL_SWAP_OVERLAY2 = 0x4
			SwapOverlay2 = unchecked((int)4),
			// WGL_SWAP_OVERLAY3 = 0x8
			SwapOverlay3 = unchecked((int)8),
			// WGL_SWAP_OVERLAY4 = 0x10
			SwapOverlay4 = unchecked((int)16),
			// WGL_SWAP_OVERLAY5 = 0x20
			SwapOverlay5 = unchecked((int)32),
			// WGL_SWAP_OVERLAY6 = 0x40
			SwapOverlay6 = unchecked((int)64),
			// WGL_SWAP_OVERLAY7 = 0x80
			SwapOverlay7 = unchecked((int)128),
			// WGL_SWAP_OVERLAY8 = 0x100
			SwapOverlay8 = unchecked((int)256),
			// WGL_SWAP_OVERLAY9 = 0x200
			SwapOverlay9 = unchecked((int)512),
			// WGL_SWAP_OVERLAY10 = 0x400
			SwapOverlay10 = unchecked((int)1024),
			// WGL_SWAP_OVERLAY11 = 0x800
			SwapOverlay11 = unchecked((int)2048),
			// WGL_SWAP_OVERLAY12 = 0x1000
			SwapOverlay12 = unchecked((int)4096),
			// WGL_SWAP_OVERLAY13 = 0x2000
			SwapOverlay13 = unchecked((int)8192),
			// WGL_SWAP_OVERLAY14 = 0x4000
			SwapOverlay14 = unchecked((int)16384),
			// WGL_SWAP_OVERLAY15 = 0x8000
			SwapOverlay15 = unchecked((int)32768),
			// WGL_SWAP_UNDERLAY1 = 0x10000
			SwapUnderlay1 = unchecked((int)65536),
			// WGL_SWAP_UNDERLAY2 = 0x20000
			SwapUnderlay2 = unchecked((int)131072),
			// WGL_SWAP_UNDERLAY3 = 0x40000
			SwapUnderlay3 = unchecked((int)262144),
			// WGL_SWAP_UNDERLAY4 = 0x80000
			SwapUnderlay4 = unchecked((int)524288),
			// WGL_SWAP_UNDERLAY5 = 0x100000
			SwapUnderlay5 = unchecked((int)1048576),
			// WGL_SWAP_UNDERLAY6 = 0x200000
			SwapUnderlay6 = unchecked((int)2097152),
			// WGL_SWAP_UNDERLAY7 = 0x400000
			SwapUnderlay7 = unchecked((int)4194304),
			// WGL_SWAP_UNDERLAY8 = 0x800000
			SwapUnderlay8 = unchecked((int)8388608),
			// WGL_SWAP_UNDERLAY9 = 0x1000000
			SwapUnderlay9 = unchecked((int)16777216),
			// WGL_SWAP_UNDERLAY10 = 0x2000000
			SwapUnderlay10 = unchecked((int)33554432),
			// WGL_SWAP_UNDERLAY11 = 0x4000000
			SwapUnderlay11 = unchecked((int)67108864),
			// WGL_SWAP_UNDERLAY12 = 0x8000000
			SwapUnderlay12 = unchecked((int)134217728),
			// WGL_SWAP_UNDERLAY13 = 0x10000000
			SwapUnderlay13 = unchecked((int)268435456),
			// WGL_SWAP_UNDERLAY14 = 0x20000000
			SwapUnderlay14 = unchecked((int)536870912),
			// WGL_SWAP_UNDERLAY15 = 0x40000000
			SwapUnderlay15 = unchecked((int)1073741824),
		}
		#region command delegates
		// int ChoosePixelFormat (HDC hDc, PIXELFORMATDESCRIPTOR* pPfd)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 ChoosePixelFormatDelegate (System.IntPtr hDc, IntPtr pPfd);
		// BOOL wglCopyContext (HGLRC hglrcSrc, HGLRC hglrcDst, UINT mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean CopyContextDelegate (System.IntPtr hglrcSrc, System.IntPtr hglrcDst, System.UInt32 mask);
		// HGLRC wglCreateContext (HDC hDc)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr CreateContextDelegate (System.IntPtr hDc);
		// HGLRC wglCreateLayerContext (HDC hDc, int level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr CreateLayerContextDelegate (System.IntPtr hDc, System.Int32 level);
		// BOOL wglDeleteContext (HGLRC oldContext)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean DeleteContextDelegate (System.IntPtr oldContext);
		// BOOL wglDescribeLayerPlane (HDC hDc, int pixelFormat, int layerPlane, UINT nBytes, LAYERPLANEDESCRIPTOR* plpd)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean DescribeLayerPlaneDelegate (System.IntPtr hDc, System.Int32 pixelFormat, System.Int32 layerPlane, System.UInt32 nBytes, IntPtr plpd);
		// int DescribePixelFormat (HDC hdc, int ipfd, UINT cjpfd, PIXELFORMATDESCRIPTOR* ppfd)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 DescribePixelFormatDelegate (System.IntPtr hdc, System.Int32 ipfd, System.UInt32 cjpfd, IntPtr ppfd);
		// HGLRC wglGetCurrentContext ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr GetCurrentContextDelegate ();
		// HDC wglGetCurrentDC ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr GetCurrentDCDelegate ();
		// UINT GetEnhMetaFilePixelFormat (HENHMETAFILE hemf, PIXELFORMATDESCRIPTOR* ppfd)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetEnhMetaFilePixelFormatDelegate (System.IntPtr hemf, IntPtr ppfd);
		// int wglGetLayerPaletteEntries (HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF* pcr)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetLayerPaletteEntriesDelegate (System.IntPtr hdc, System.Int32 iLayerPlane, System.Int32 iStart, System.Int32 cEntries, IntPtr pcr);
		// int GetPixelFormat (HDC hdc)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetPixelFormatDelegate (System.IntPtr hdc);
		// PROC wglGetProcAddress (LPCSTR lpszProc)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr GetProcAddressDelegate (System.IntPtr lpszProc);
		// BOOL wglMakeCurrent (HDC hDc, HGLRC newContext)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean MakeCurrentDelegate (System.IntPtr hDc, System.IntPtr newContext);
		// BOOL wglRealizeLayerPalette (HDC hdc, int iLayerPlane, BOOL bRealize)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean RealizeLayerPaletteDelegate (System.IntPtr hdc, System.Int32 iLayerPlane, System.Boolean bRealize);
		// int wglSetLayerPaletteEntries (HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF* pcr)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 SetLayerPaletteEntriesDelegate (System.IntPtr hdc, System.Int32 iLayerPlane, System.Int32 iStart, System.Int32 cEntries, IntPtr pcr);
		// BOOL SetPixelFormat (HDC hdc, int ipfd, PIXELFORMATDESCRIPTOR* ppfd)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean SetPixelFormatDelegate (System.IntPtr hdc, System.Int32 ipfd, IntPtr ppfd);
		// BOOL wglShareLists (HGLRC hrcSrvShare, HGLRC hrcSrvSource)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean ShareListsDelegate (System.IntPtr hrcSrvShare, System.IntPtr hrcSrvSource);
		// BOOL SwapBuffers (HDC hdc)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean SwapBuffersDelegate (System.IntPtr hdc);
		// BOOL wglSwapLayerBuffers (HDC hdc, UINT fuFlags)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean SwapLayerBuffersDelegate (System.IntPtr hdc, System.UInt32 fuFlags);
		// BOOL wglUseFontBitmapsA (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontBitmapsADelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase);
		// BOOL wglUseFontBitmaps (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontBitmapsDelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase);
		// BOOL wglUseFontBitmapsW (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontBitmapsWDelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase);
		// BOOL wglUseFontOutlinesA (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontOutlinesADelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase, System.Single deviation, System.Single extrusion, System.Int32 format, System.IntPtr lpgmf);
		// BOOL wglUseFontOutlines (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontOutlinesDelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase, System.Single deviation, System.Single extrusion, System.Int32 format, System.IntPtr lpgmf);
		// BOOL wglUseFontOutlinesW (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UseFontOutlinesWDelegate (System.IntPtr hDC, System.Int16 first, System.Int16 count, System.Int16 listBase, System.Single deviation, System.Single extrusion, System.Int32 format, System.IntPtr lpgmf);
		#endregion // command delegates
		#region commands
		// int ChoosePixelFormat (HDC hDc, PIXELFORMATDESCRIPTOR* pPfd)
		public readonly ChoosePixelFormatDelegate ChoosePixelFormat;
		// BOOL wglCopyContext (HGLRC hglrcSrc, HGLRC hglrcDst, UINT mask)
		public readonly CopyContextDelegate CopyContext;
		// HGLRC wglCreateContext (HDC hDc)
		public readonly CreateContextDelegate CreateContext;
		// HGLRC wglCreateLayerContext (HDC hDc, int level)
		public readonly CreateLayerContextDelegate CreateLayerContext;
		// BOOL wglDeleteContext (HGLRC oldContext)
		public readonly DeleteContextDelegate DeleteContext;
		// BOOL wglDescribeLayerPlane (HDC hDc, int pixelFormat, int layerPlane, UINT nBytes, LAYERPLANEDESCRIPTOR* plpd)
		public readonly DescribeLayerPlaneDelegate DescribeLayerPlane;
		// int DescribePixelFormat (HDC hdc, int ipfd, UINT cjpfd, PIXELFORMATDESCRIPTOR* ppfd)
		public readonly DescribePixelFormatDelegate DescribePixelFormat;
		// HGLRC wglGetCurrentContext ()
		public readonly GetCurrentContextDelegate GetCurrentContext;
		// HDC wglGetCurrentDC ()
		public readonly GetCurrentDCDelegate GetCurrentDC;
		// UINT GetEnhMetaFilePixelFormat (HENHMETAFILE hemf, PIXELFORMATDESCRIPTOR* ppfd)
		public readonly GetEnhMetaFilePixelFormatDelegate GetEnhMetaFilePixelFormat;
		// int wglGetLayerPaletteEntries (HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF* pcr)
		public readonly GetLayerPaletteEntriesDelegate GetLayerPaletteEntries;
		// int GetPixelFormat (HDC hdc)
		public readonly GetPixelFormatDelegate GetPixelFormat;
		// PROC wglGetProcAddress (LPCSTR lpszProc)
		public readonly GetProcAddressDelegate GetProcAddress;
		// BOOL wglMakeCurrent (HDC hDc, HGLRC newContext)
		public readonly MakeCurrentDelegate MakeCurrent;
		// BOOL wglRealizeLayerPalette (HDC hdc, int iLayerPlane, BOOL bRealize)
		public readonly RealizeLayerPaletteDelegate RealizeLayerPalette;
		// int wglSetLayerPaletteEntries (HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF* pcr)
		public readonly SetLayerPaletteEntriesDelegate SetLayerPaletteEntries;
		// BOOL SetPixelFormat (HDC hdc, int ipfd, PIXELFORMATDESCRIPTOR* ppfd)
		public readonly SetPixelFormatDelegate SetPixelFormat;
		// BOOL wglShareLists (HGLRC hrcSrvShare, HGLRC hrcSrvSource)
		public readonly ShareListsDelegate ShareLists;
		// BOOL SwapBuffers (HDC hdc)
		public readonly SwapBuffersDelegate SwapBuffers;
		// BOOL wglSwapLayerBuffers (HDC hdc, UINT fuFlags)
		public readonly SwapLayerBuffersDelegate SwapLayerBuffers;
		// BOOL wglUseFontBitmapsA (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		public readonly UseFontBitmapsADelegate UseFontBitmapsA;
		// BOOL wglUseFontBitmaps (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		public readonly UseFontBitmapsDelegate UseFontBitmaps;
		// BOOL wglUseFontBitmapsW (HDC hDC, DWORD first, DWORD count, DWORD listBase)
		public readonly UseFontBitmapsWDelegate UseFontBitmapsW;
		// BOOL wglUseFontOutlinesA (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		public readonly UseFontOutlinesADelegate UseFontOutlinesA;
		// BOOL wglUseFontOutlines (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		public readonly UseFontOutlinesDelegate UseFontOutlines;
		// BOOL wglUseFontOutlinesW (HDC hDC, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf)
		public readonly UseFontOutlinesWDelegate UseFontOutlinesW;
		#endregion // commands
		public Wgl (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			resolver.LoadHandle ("ChoosePixelFormat", out ChoosePixelFormat);
			resolver.LoadHandle ("wglCopyContext", out CopyContext);
			resolver.LoadHandle ("wglCreateContext", out CreateContext);
			resolver.LoadHandle ("wglCreateLayerContext", out CreateLayerContext);
			resolver.LoadHandle ("wglDeleteContext", out DeleteContext);
			resolver.LoadHandle ("wglDescribeLayerPlane", out DescribeLayerPlane);
			resolver.LoadHandle ("DescribePixelFormat", out DescribePixelFormat);
			resolver.LoadHandle ("wglGetCurrentContext", out GetCurrentContext);
			resolver.LoadHandle ("wglGetCurrentDC", out GetCurrentDC);
			resolver.LoadHandle ("GetEnhMetaFilePixelFormat", out GetEnhMetaFilePixelFormat);
			resolver.LoadHandle ("wglGetLayerPaletteEntries", out GetLayerPaletteEntries);
			resolver.LoadHandle ("GetPixelFormat", out GetPixelFormat);
			resolver.LoadHandle ("wglGetProcAddress", out GetProcAddress);
			resolver.LoadHandle ("wglMakeCurrent", out MakeCurrent);
			resolver.LoadHandle ("wglRealizeLayerPalette", out RealizeLayerPalette);
			resolver.LoadHandle ("wglSetLayerPaletteEntries", out SetLayerPaletteEntries);
			resolver.LoadHandle ("SetPixelFormat", out SetPixelFormat);
			resolver.LoadHandle ("wglShareLists", out ShareLists);
			resolver.LoadHandle ("SwapBuffers", out SwapBuffers);
			resolver.LoadHandle ("wglSwapLayerBuffers", out SwapLayerBuffers);
			resolver.LoadHandle ("wglUseFontBitmapsA", out UseFontBitmapsA);
			resolver.LoadHandle ("wglUseFontBitmaps", out UseFontBitmaps);
			resolver.LoadHandle ("wglUseFontBitmapsW", out UseFontBitmapsW);
			resolver.LoadHandle ("wglUseFontOutlinesA", out UseFontOutlinesA);
			resolver.LoadHandle ("wglUseFontOutlines", out UseFontOutlines);
			resolver.LoadHandle ("wglUseFontOutlinesW", out UseFontOutlinesW);
		}
	}
}

