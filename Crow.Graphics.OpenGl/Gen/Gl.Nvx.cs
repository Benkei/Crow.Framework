using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class NvxConditionalRender
		{
			public const string NAME_STRING = "GL_NVX_conditional_render";
			#region command delegates
			// void glBeginConditionalRenderNVX (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginConditionalRenderNVXDelegate (System.UInt32 id);
			// void glEndConditionalRenderNVX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndConditionalRenderNVXDelegate ();
			#endregion // command delegates
			#region commands
			// void glBeginConditionalRenderNVX (GLuint id)
			public readonly BeginConditionalRenderNVXDelegate BeginConditionalRenderNVX;
			// void glEndConditionalRenderNVX ()
			public readonly EndConditionalRenderNVXDelegate EndConditionalRenderNVX;
			#endregion // commands
			public NvxConditionalRender (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginConditionalRenderNVX", out BeginConditionalRenderNVX);
				resolver.LoadHandle ("glEndConditionalRenderNVX", out EndConditionalRenderNVX);
			}
		}
		public partial class NvxGpuMemoryInfo
		{
			public enum All
			{
				// GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047
				GpuMemoryInfoDedicatedVidmem = unchecked((int)36935),
				// GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048
				GpuMemoryInfoTotalAvailableMemory = unchecked((int)36936),
				// GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049
				GpuMemoryInfoCurrentAvailableVidmem = unchecked((int)36937),
				// GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A
				GpuMemoryInfoEvictionCount = unchecked((int)36938),
				// GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B
				GpuMemoryInfoEvictedMemory = unchecked((int)36939),
			}
			public const string NAME_STRING = "GL_NVX_gpu_memory_info";
		}
	}
}

