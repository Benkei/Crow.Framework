using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Crow.Graphics.Vulkan
{
	public class VulkanInstanceHandleResolver : IHandleResolver
	{
		private Vk vulkan;

		public Instance Instance { get; set; }


		public VulkanInstanceHandleResolver(Vk vulkan, Instance instance = default ( Instance ))
		{
			if ( vulkan == null )
				throw new ArgumentNullException ( nameof ( vulkan ) );

			this.vulkan = vulkan;
			Instance = instance;
		}

		public unsafe void LoadHandle<TDelegate>(IntPtr functionName, out TDelegate result)
			where TDelegate : class
		{
			if ( Instance.IsZero )
				throw new InvalidOperationException ( "Instance pointer not defined!" );

			IntPtr proc = vulkan.GetInstanceProcAddr ( Instance, (byte*)functionName );
			if ( proc == IntPtr.Zero )
			{
				Debug.WriteLine ( "Could not load function: {0}", functionName );
				result = null;
				return;
			}
			result = (TDelegate)(object)Marshal.GetDelegateForFunctionPointer ( proc, typeof ( TDelegate ) );
		}
	}
}
