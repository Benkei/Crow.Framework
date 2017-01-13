using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

		public unsafe void LoadHandle<TDelegate>(IntPtr functionName, out TDelegate result) where TDelegate : class
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
			result = Marshal.GetDelegateForFunctionPointer<TDelegate> ( proc );
		}
	}
}
