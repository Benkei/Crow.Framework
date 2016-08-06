using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class AmdGpuAssociation
		{
			public enum All
			{
				// WGL_GPU_VENDOR_AMD = 0x1F00
				GpuVendor = unchecked((int)7936),
				// WGL_GPU_RENDERER_STRING_AMD = 0x1F01
				GpuRendererString = unchecked((int)7937),
				// WGL_GPU_OPENGL_VERSION_STRING_AMD = 0x1F02
				GpuOpenglVersionString = unchecked((int)7938),
				// WGL_GPU_FASTEST_TARGET_GPUS_AMD = 0x21A2
				GpuFastestTargetGpus = unchecked((int)8610),
				// WGL_GPU_RAM_AMD = 0x21A3
				GpuRam = unchecked((int)8611),
				// WGL_GPU_CLOCK_AMD = 0x21A4
				GpuClock = unchecked((int)8612),
				// WGL_GPU_NUM_PIPES_AMD = 0x21A5
				GpuNumPipes = unchecked((int)8613),
				// WGL_GPU_NUM_SIMD_AMD = 0x21A6
				GpuNumSimd = unchecked((int)8614),
				// WGL_GPU_NUM_RB_AMD = 0x21A7
				GpuNumRb = unchecked((int)8615),
				// WGL_GPU_NUM_SPI_AMD = 0x21A8
				GpuNumSpi = unchecked((int)8616),
			}
			public const string NAME_STRING = "WGL_AMD_gpu_association";
			#region command delegates
			// VOID wglBlitContextFramebufferAMD (HGLRC dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr BlitContextFramebufferDelegate (System.IntPtr dstCtx, System.Int32 srcX0, System.Int32 srcY0, System.Int32 srcX1, System.Int32 srcY1, System.Int32 dstX0, System.Int32 dstY0, System.Int32 dstX1, System.Int32 dstY1, System.UInt32 mask, System.UInt32 filter);
			// HGLRC wglCreateAssociatedContextAttribsAMD (UINT id, HGLRC hShareContext, int* attribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateAssociatedContextAttribsDelegate (System.UInt32 id, System.IntPtr hShareContext, IntPtr attribList);
			// HGLRC wglCreateAssociatedContextAMD (UINT id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateAssociatedContextDelegate (System.UInt32 id);
			// BOOL wglDeleteAssociatedContextAMD (HGLRC hglrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DeleteAssociatedContextDelegate (System.IntPtr hglrc);
			// UINT wglGetContextGPUIDAMD (HGLRC hglrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetContextGPUIDDelegate (System.IntPtr hglrc);
			// HGLRC wglGetCurrentAssociatedContextAMD ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetCurrentAssociatedContextDelegate ();
			// UINT wglGetGPUIDsAMD (UINT maxCount, UINT* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetGPUIDsDelegate (System.UInt32 maxCount, IntPtr ids);
			// INT wglGetGPUInfoAMD (UINT id, int property, GLenum dataType, UINT size, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetGPUInfoDelegate (System.UInt32 id, System.Int32 property, System.UInt32 dataType, System.UInt32 size, IntPtr data);
			// BOOL wglMakeAssociatedContextCurrentAMD (HGLRC hglrc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean MakeAssociatedContextCurrentDelegate (System.IntPtr hglrc);
			#endregion // command delegates
			#region commands
			// VOID wglBlitContextFramebufferAMD (HGLRC dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
			public readonly BlitContextFramebufferDelegate BlitContextFramebuffer;
			// HGLRC wglCreateAssociatedContextAttribsAMD (UINT id, HGLRC hShareContext, int* attribList)
			public readonly CreateAssociatedContextAttribsDelegate CreateAssociatedContextAttribs;
			// HGLRC wglCreateAssociatedContextAMD (UINT id)
			public readonly CreateAssociatedContextDelegate CreateAssociatedContext;
			// BOOL wglDeleteAssociatedContextAMD (HGLRC hglrc)
			public readonly DeleteAssociatedContextDelegate DeleteAssociatedContext;
			// UINT wglGetContextGPUIDAMD (HGLRC hglrc)
			public readonly GetContextGPUIDDelegate GetContextGPUID;
			// HGLRC wglGetCurrentAssociatedContextAMD ()
			public readonly GetCurrentAssociatedContextDelegate GetCurrentAssociatedContext;
			// UINT wglGetGPUIDsAMD (UINT maxCount, UINT* ids)
			public readonly GetGPUIDsDelegate GetGPUIDs;
			// INT wglGetGPUInfoAMD (UINT id, int property, GLenum dataType, UINT size, void* data)
			public readonly GetGPUInfoDelegate GetGPUInfo;
			// BOOL wglMakeAssociatedContextCurrentAMD (HGLRC hglrc)
			public readonly MakeAssociatedContextCurrentDelegate MakeAssociatedContextCurrent;
			#endregion // commands
			public AmdGpuAssociation (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBlitContextFramebufferAMD", out BlitContextFramebuffer);
				resolver.LoadHandle ("wglCreateAssociatedContextAttribsAMD", out CreateAssociatedContextAttribs);
				resolver.LoadHandle ("wglCreateAssociatedContextAMD", out CreateAssociatedContext);
				resolver.LoadHandle ("wglDeleteAssociatedContextAMD", out DeleteAssociatedContext);
				resolver.LoadHandle ("wglGetContextGPUIDAMD", out GetContextGPUID);
				resolver.LoadHandle ("wglGetCurrentAssociatedContextAMD", out GetCurrentAssociatedContext);
				resolver.LoadHandle ("wglGetGPUIDsAMD", out GetGPUIDs);
				resolver.LoadHandle ("wglGetGPUInfoAMD", out GetGPUInfo);
				resolver.LoadHandle ("wglMakeAssociatedContextCurrentAMD", out MakeAssociatedContextCurrent);
			}
		}
	}
}

