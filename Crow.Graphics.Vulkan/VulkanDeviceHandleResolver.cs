using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Crow.Graphics.Vulkan
{
	public class VulkanDeviceHandleResolver : IHandleResolver
	{
		private Vk vulkan;

		public Device Device { get; set; }


		public VulkanDeviceHandleResolver(Vk vulkan, Device device = default ( Device ))
		{
			if ( vulkan == null )
				throw new ArgumentNullException ( nameof ( vulkan ) );

			this.vulkan = vulkan;
			Device = device;
		}

		public unsafe void LoadHandle<TDelegate>(IntPtr functionName, out TDelegate result)
			where TDelegate : class
		{
			if ( Device.IsZero )
				throw new InvalidOperationException ( "Instance pointer not defined!" );

			IntPtr proc = vulkan.GetDeviceProcAddr ( Device, (byte*)functionName );
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
