using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Crow.Graphics.Vulkan;
using Crow.Win32;
using Version = Crow.Graphics.Vulkan.Version;

namespace TestConsole.VulkanTutorial
{
	// ************************************************************ //
	// QueueParameters                                              //
	//                                                              //
	// Vulkan Queue's parameters container class                    //
	// ************************************************************ //
	public struct QueueParameters
	{
		public Queue Handle;
		public uint FamilyIndex;
	}

	// ************************************************************ //
	// ImageParameters                                              //
	//                                                              //
	// Vulkan Image's parameters container class                    //
	// ************************************************************ //
	public struct ImageParameters
	{
		public Image Handle;
		public ImageView View;
		public Sampler Sampler;
		public DeviceMemory Memory;
	}

	// ************************************************************ //
	// SwapChainParameters                                          //
	//                                                              //
	// Vulkan SwapChain's parameters container class                //
	// ************************************************************ //
	public struct SwapChainParameters
	{
		public SwapchainKHR Handle;
		public Format Format;
		public ImageParameters[] Images;
		public Extent2D Extent;
	}

	// ************************************************************ //
	// VulkanCommonParameters                                       //
	//                                                              //
	// General Vulkan parameters' container class                   //
	// ************************************************************ //
	struct VulkanCommonParameters
	{
		public Instance Instance;
		public PhysicalDevice PhysicalDevice;
		public Device Device;
		public QueueParameters GraphicsQueue;
		public QueueParameters PresentQueue;
		public SurfaceKHR PresentationSurface;
		public SwapChainParameters SwapChain;
	}

	// ************************************************************ //
	// VulkanCommon                                                 //
	//                                                              //
	// Base class for Vulkan more advanced tutorial classes         //
	// ************************************************************ //
	public unsafe abstract class VulkanCommon : IDisposable
	{
		protected Vk vk;
		protected KhrSurface khrSurface;
		protected KhrWin32Surface khrW32surface;
		protected KhrSwapchain khrSwapChain;
		protected bool CanRender;


		VulkanCommonParameters vulkan;

		RenderForm window;
		VulkanGlobalHandleResolver vulkanLibrary;
		ExtDebugReport extDebugReport;

		bool supportDebugReport;
		DebugReportCallbackEXTCallback debugReportCallback;
		DebugReportCallbackEXT debugReportHandle;



		public virtual bool ReadyToDraw
		{
			get { return CanRender; }
		}



		public virtual void Dispose()
		{
			if ( !vulkan.Device.IsZero )
			{
				vk.DeviceWaitIdle ( vulkan.Device );

				for ( int i = 0; i < vulkan.SwapChain.Images.Length; ++i )
				{
					if ( !vulkan.SwapChain.Images[i].View.IsZero )
					{
						vk.DestroyImageView ( vulkan.Device, vulkan.SwapChain.Images[i].View );
					}
				}

				if ( !vulkan.SwapChain.Handle.IsZero )
				{
					khrSwapChain.DestroySwapchainKHR ( vulkan.Device, vulkan.SwapChain.Handle );
				}

				vk.DestroyDevice ( vulkan.Device );
			}

			if ( !vulkan.PresentationSurface.IsZero )
			{
				khrSurface.DestroySurfaceKHR ( vulkan.Instance, vulkan.PresentationSurface );
			}

			if ( !debugReportHandle.IsZero )
			{
				extDebugReport.DestroyDebugReportCallbackEXT ( vulkan.Instance, debugReportHandle );
				debugReportHandle = new DebugReportCallbackEXT ();
			}

			if ( !vulkan.Instance.IsZero )
			{
				vk.DestroyInstance ( vulkan.Instance );
			}

			vulkanLibrary.Dispose ();
		}


		public void PrepareVulkan(RenderForm form)
		{
			window = form;

			LoadVulkanLibrary ();
			LoadExportedEntryPoints ();
			LoadGlobalLevelEntryPoints ();
			CreateInstance ();
			LoadInstanceLevelEntryPoints ();
			CreatePresentationSurface ();
			CreateDevice ();
			LoadDeviceLevelEntryPoints ();
			GetDeviceQueue ();
			CreateSwapChain ();
		}

		public virtual void OnWindowSizeChanged()
		{
			ChildClear ();
			CreateSwapChain ();

			if ( CanRender )
			{
				ChildOnWindowSizeChanged ();
			}
		}

		public virtual void Draw() { }

		public PhysicalDevice GetPhysicalDevice { get { return vulkan.PhysicalDevice; } }
		public Device GetDevice { get { return vulkan.Device; } }
		public QueueParameters GetGraphicsQueue { get { return vulkan.GraphicsQueue; } }
		public QueueParameters GetPresentQueue { get { return vulkan.PresentQueue; } }
		public SwapChainParameters GetSwapChain { get { return vulkan.SwapChain; } }

		void LoadVulkanLibrary()
		{
			vulkanLibrary = new VulkanGlobalHandleResolver ();
		}
		void LoadExportedEntryPoints()
		{
			vk = new Vk ( vulkanLibrary );
		}
		void LoadGlobalLevelEntryPoints() { }
		void CreateInstance()
		{
			//LayerProperties[] available_layers = DelegateUtility.EnumerateToArray<LayerProperties> ( vk.EnumerateInstanceLayerProperties );

			ExtensionProperties[] available_extensions = DelegateUtility.EnumerateToArray<ExtensionProperties> ( vk.EnumerateInstanceExtensionProperties, IntPtr.Zero );

			List<string> extensions = new List<string> { KhrWin32Surface.EXTENSION_NAME, KhrSurface.EXTENSION_NAME };

			for ( int i = 0; i < extensions.Count; ++i )
			{
				if ( !CheckExtensionAvailability ( extensions[i], available_extensions ) )
				{
					//std::cout << "Could not find instance extension named \"" << extensions[i] << "\"!" << std::endl;
					return;
				}
			}

			if ( CheckExtensionAvailability ( ExtDebugReport.EXTENSION_NAME, available_extensions ) )
			{
				extensions.Add ( ExtDebugReport.EXTENSION_NAME );
				supportDebugReport = true;
			}


			var exPtr = MarshalUtility.AllocateString ( extensions );

			ApplicationInfo application_info = new ApplicationInfo
			{
				sType = StructureType.ApplicationInfo,
				pNext = IntPtr.Zero,
				pApplicationName = (byte*)Marshal.StringToHGlobalAnsi ( "Vulkan Window" ),
				applicationVersion = new Version ( 1, 0, 0 ),
				pEngineName = (byte*)Marshal.StringToHGlobalAnsi ( "Vulkan Tutorial" ),
				engineVersion = new Version ( 1, 0, 0 ),
				apiVersion = new Version ( 1, 0, 0 ),
			};

			InstanceCreateInfo instance_create_info = new InstanceCreateInfo
			{
				sType = StructureType.InstanceCreateInfo,
				pNext = IntPtr.Zero,
				flags = 0,
				pApplicationInfo = &application_info,
				enabledLayerCount = 0,
				ppEnabledLayerNames = (byte*)0,
				enabledExtensionCount = (uint)extensions.Count,
				ppEnabledExtensionNames = (byte*)exPtr,
			};

			vk.CreateInstance ( ref instance_create_info, (AllocationCallbacks*)0, out vulkan.Instance ).CheckError ();

			MarshalUtility.FreeString ( exPtr, extensions.Count );

			Marshal.FreeHGlobal ( (IntPtr)application_info.pApplicationName );
			Marshal.FreeHGlobal ( (IntPtr)application_info.pEngineName );
		}
		void LoadInstanceLevelEntryPoints()
		{
			var instLoad = new VulkanInstanceHandleResolver ( vk, vulkan.Instance );
			khrSurface = new KhrSurface ( instLoad );
			khrW32surface = new KhrWin32Surface ( instLoad );
			if ( supportDebugReport )
			{
				extDebugReport = new ExtDebugReport ( instLoad );

				debugReportCallback = OnDebugReport;

				var inf = new DebugReportCallbackCreateInfoEXT ()
				{
					sType = StructureType.DebugReportCallbackCreateInfoExt,
					pNext = IntPtr.Zero,
					flags = DebugReportFlagBitsEXT.InformationBitExt | DebugReportFlagBitsEXT.WarningBitExt
					| DebugReportFlagBitsEXT.PerformanceWarningBitExt | DebugReportFlagBitsEXT.ErrorExt | DebugReportFlagBitsEXT.DebugBitExt,
					pfnCallback = Marshal.GetFunctionPointerForDelegate ( debugReportCallback ),
					pUserData = IntPtr.Zero,
				};
				extDebugReport.CreateDebugReportCallbackEXT ( vulkan.Instance, ref inf, (AllocationCallbacks*)0, out debugReportHandle ).CheckError ();
			}
		}
		void CreatePresentationSurface()
		{
			IntPtr hwnd = window.Handle;
			IntPtr hinstance = Marshal.GetHINSTANCE ( typeof ( VulkanCommon ).Module );

			Win32SurfaceCreateInfoKHR surface_create_info = new Win32SurfaceCreateInfoKHR
			{
				sType = StructureType.Win32SurfaceCreateInfoKhr, // VkStructureType                  sType
				pNext = IntPtr.Zero,                             // const void                      *pNext
				flags = 0,                                       // VkWin32SurfaceCreateFlagBitsKHR     flags
				hinstance = hinstance,                           // HINSTANCE                        hinstance
				hwnd = hwnd                                      // HWND                             hwnd
			};

			khrW32surface.CreateWin32SurfaceKHR ( vulkan.Instance, ref surface_create_info, (AllocationCallbacks*)0, out vulkan.PresentationSurface ).CheckError ();
		}
		void CreateDevice()
		{
			PhysicalDevice[] physical_devices = DelegateUtility.EnumerateToArray<PhysicalDevice> ( vk.EnumeratePhysicalDevices, (IntPtr)vulkan.Instance );

			if ( physical_devices == null )
			{
				//std::cout << "Error occurred during physical devices enumeration!" << std::endl;
				return;
			}

			uint selected_graphics_queue_family_index = uint.MaxValue;
			uint selected_present_queue_family_index = uint.MaxValue;

			for ( int i = 0; i < physical_devices.Length; ++i )
			{
				if ( CheckPhysicalDeviceProperties ( physical_devices[i],
					out selected_graphics_queue_family_index, out selected_present_queue_family_index ) )
				{
					vulkan.PhysicalDevice = physical_devices[i];
				}
			}

			if ( vulkan.PhysicalDevice.IsZero
				|| selected_graphics_queue_family_index == uint.MaxValue
				|| selected_present_queue_family_index == uint.MaxValue )
			{
				//std::cout << "Could not select physical device based on the chosen properties!" << std::endl;
				return;
			}

			var queue_create_infos = stackalloc DeviceQueueCreateInfo[2];
			uint count = 1;
			float* queue_priorities = stackalloc float[1];
			queue_priorities[0] = 1.0f;

			queue_create_infos[0] = new DeviceQueueCreateInfo
			{
				sType = StructureType.DeviceQueueCreateInfo,             // VkStructureType              sType
				pNext = IntPtr.Zero,                                     // const void                  *pNext
				flags = 0,                                               // VkDeviceQueueCreateFlagBits     flags
				queueFamilyIndex = selected_graphics_queue_family_index, // uint32_t                     queueFamilyIndex
				queueCount = 1,                                          // uint32_t                     queueCount
				pQueuePriorities = queue_priorities                      // const float                 *pQueuePriorities
			};

			if ( selected_graphics_queue_family_index != selected_present_queue_family_index )
			{
				queue_create_infos[1] = new DeviceQueueCreateInfo
				{
					sType = StructureType.DeviceQueueCreateInfo,            // VkStructureType              sType
					pNext = IntPtr.Zero,                                    // const void                  *pNext
					flags = 0,                                              // VkDeviceQueueCreateFlagBits     flags
					queueFamilyIndex = selected_present_queue_family_index, // uint32_t                     queueFamilyIndex
					queueCount = 1,                                         // uint32_t                     queueCount
					pQueuePriorities = queue_priorities                     // const float                 *pQueuePriorities
				};
				count++;
			}

			const uint exCount = 1;
			var exPtr = MarshalUtility.AllocateString ( new string[] { KhrSwapchain.EXTENSION_NAME } );

			DeviceCreateInfo device_create_info = new DeviceCreateInfo
			{
				sType = StructureType.DeviceCreateInfo,        // VkStructureType                    sType
				pNext = IntPtr.Zero,                           // const void                        *pNext
				flags = 0,                                     // VkDeviceCreateFlagBits                flags
				queueCreateInfoCount = count,                  // uint32_t                           queueCreateInfoCount
				pQueueCreateInfos = queue_create_infos,        // const VkDeviceQueueCreateInfo     *pQueueCreateInfos
				enabledLayerCount = 0,                         // uint32_t                           enabledLayerCount
				ppEnabledLayerNames = (byte*)0,                // const char * const                *ppEnabledLayerNames
				enabledExtensionCount = exCount,               // uint32_t                           enabledExtensionCount
				ppEnabledExtensionNames = (byte*)exPtr,        // const char * const                *ppEnabledExtensionNames
				pEnabledFeatures = (PhysicalDeviceFeatures*)0  // const VkPhysicalDeviceFeatures    *pEnabledFeatures
			};

			vk.CreateDevice ( vulkan.PhysicalDevice, ref device_create_info, (AllocationCallbacks*)0, out vulkan.Device ).CheckError ();

			MarshalUtility.FreeString ( exPtr, (int)exCount );
		}
		bool CheckPhysicalDeviceProperties(PhysicalDevice physical_device,
			out uint graphics_queue_family_index,
			out uint present_queue_family_index)
		{
			graphics_queue_family_index = uint.MaxValue;
			present_queue_family_index = uint.MaxValue;


			ExtensionProperties[] available_extensions = DelegateUtility.EnumerateToArray<ExtensionProperties> (
				vk.EnumerateDeviceExtensionProperties, (IntPtr)physical_device, IntPtr.Zero );

			if ( available_extensions == null )
			{
				//std::cout << "Error occurred during physical device " << physical_device << " extensions enumeration!" << std::endl;
				return false;
			}

			string[] device_extensions = { KhrSwapchain.EXTENSION_NAME };

			for ( int i = 0; i < device_extensions.Length; ++i )
			{
				if ( !CheckExtensionAvailability ( device_extensions[i], available_extensions ) )
				{
					//std::cout << "Physical device " << physical_device << " doesn't support extension named \"" << device_extensions[i] << "\"!" << std::endl;
					return false;
				}
			}

			PhysicalDeviceProperties device_properties;
			PhysicalDeviceFeatures device_features;

			vk.GetPhysicalDeviceProperties ( physical_device, out device_properties );
			vk.GetPhysicalDeviceFeatures ( physical_device, out device_features );

			if ( device_properties.apiVersion.Major < 1
				|| device_properties.limits.maxImageDimension2D < 4096 )
			{
				//std::cout << "Physical device " << physical_device << " doesn't support required parameters!" << std::endl;
				return false;
			}

			QueueFamilyProperties[] queue_family_properties = DelegateUtility.EnumerateToArray<QueueFamilyProperties> (
				vk.GetPhysicalDeviceQueueFamilyProperties, (IntPtr)physical_device );

			if ( queue_family_properties == null )
			{
				//std::cout << "Physical device " << physical_device << " doesn't have any queue families!" << std::endl;
				return false;
			}

			bool[] queue_present_support = new bool[queue_family_properties.Length];

			for ( uint i = 0; i < queue_family_properties.Length; ++i )
			{
				Boolean32 support;
				khrSurface.GetPhysicalDeviceSurfaceSupportKHR ( physical_device, i, vulkan.PresentationSurface, out support ).CheckError ();
				queue_present_support[i] = support;

				if ( (queue_family_properties[i].queueCount > 0)
					&& (queue_family_properties[i].queueFlags & QueueFlagBits.GraphicsBit) > 0 )
				{
					// Select first queue that supports graphics
					if ( graphics_queue_family_index == uint.MaxValue )
					{
						graphics_queue_family_index = i;
					}

					// If there is queue that supports both graphics and present - prefer it
					if ( support )
					{
						graphics_queue_family_index = i;
						present_queue_family_index = i;

						return true;
					}
				}
			}

			if ( present_queue_family_index == uint.MaxValue )
			{
				present_queue_family_index = (uint)Array.IndexOf ( queue_present_support, true );
			}

			if ( present_queue_family_index == uint.MaxValue || graphics_queue_family_index == uint.MaxValue )
			{
				//std::cout << "Could not find queue families with required properties on physical device " << physical_device << "!" << std::endl;
				return false;
			}

			return true;
		}
		void LoadDeviceLevelEntryPoints()
		{
			var devLoad = new VulkanDeviceHandleResolver ( vk, vulkan.Device );
			khrSwapChain = new KhrSwapchain ( devLoad );
		}
		void GetDeviceQueue()
		{
			vk.GetDeviceQueue ( vulkan.Device, vulkan.GraphicsQueue.FamilyIndex, 0, out vulkan.GraphicsQueue.Handle );
			vk.GetDeviceQueue ( vulkan.Device, vulkan.PresentQueue.FamilyIndex, 0, out vulkan.PresentQueue.Handle );
		}
		void CreateSwapChain()
		{
			CanRender = false;

			if ( !vulkan.Device.IsZero )
			{
				vk.DeviceWaitIdle ( vulkan.Device );
			}

			if ( vulkan.SwapChain.Images != null )
			{
				for ( int i = 0; i < vulkan.SwapChain.Images.Length; ++i )
				{
					if ( vulkan.SwapChain.Images[i].View != ImageView.Zero )
					{
						vk.DestroyImageView ( vulkan.Device, vulkan.SwapChain.Images[i].View );
					}
				}
			}

			SurfaceCapabilitiesKHR surface_capabilities;
			khrSurface.GetPhysicalDeviceSurfaceCapabilitiesKHR ( vulkan.PhysicalDevice, vulkan.PresentationSurface, out surface_capabilities ).CheckError ();

			var surface_formats = DelegateUtility.EnumerateToArray<SurfaceFormatKHR> ( khrSurface.GetPhysicalDeviceSurfaceFormatsKHR,
				(IntPtr)vulkan.PhysicalDevice, (ulong)vulkan.PresentationSurface );

			var present_modes = DelegateUtility.EnumerateToArray<int> ( khrSurface.GetPhysicalDeviceSurfacePresentModesKHR,
				(IntPtr)vulkan.PhysicalDevice, (ulong)vulkan.PresentationSurface );


			uint desired_number_of_images = GetSwapChainNumImages ( ref surface_capabilities );
			SurfaceFormatKHR desired_format = GetSwapChainFormat ( surface_formats );
			Extent2D desired_extent = GetSwapChainExtent ( ref surface_capabilities );
			ImageUsageFlagBits desired_usage = GetSwapChainUsageFlagBits ( ref surface_capabilities );
			SurfaceTransformFlagBitsKHR desired_transform = GetSwapChainTransform ( ref surface_capabilities );
			PresentModeKHR desired_present_mode = GetSwapChainPresentMode ( present_modes );
			SwapchainKHR old_swap_chain = vulkan.SwapChain.Handle;

			if ( desired_usage == (ImageUsageFlagBits)(-1) )
			{
				return;
			}
			if ( desired_present_mode == (PresentModeKHR)(-1) )
			{
				return;
			}

			if ( (desired_extent.width == 0) || (desired_extent.height == 0) )
			{
				// Current surface size is (0, 0) so we can't create a swap chain and render anything (CanRender == false)
				// But we don't wont to kill the application as this situation may occur i.e. when window gets minimized
				return;
			}

			SwapchainCreateInfoKHR swap_chain_create_info = new SwapchainCreateInfoKHR
			{
				sType = StructureType.SwapchainCreateInfoKhr,         // VkStructureType                sType
				pNext = IntPtr.Zero,                                  // const void                    *pNext
				flags = 0,                                            // VkSwapchainCreateFlagBitsKHR      flags
				surface = vulkan.PresentationSurface,                 // VkSurfaceKHR                   surface
				minImageCount = desired_number_of_images,             // uint32_t                       minImageCount
				imageFormat = desired_format.format,                  // VkFormat                       imageFormat
				imageColorSpace = desired_format.colorSpace,          // VkColorSpaceKHR                imageColorSpace
				imageExtent = desired_extent,                         // VkExtent2D                     imageExtent
				imageArrayLayers = 1,                                 // uint32_t                       imageArrayLayers
				imageUsage = desired_usage,                           // VkImageUsageFlagBits              imageUsage
				imageSharingMode = SharingMode.Exclusive,             // VkSharingMode                  imageSharingMode
				queueFamilyIndexCount = 0,                            // uint32_t                       queueFamilyIndexCount
				pQueueFamilyIndices = (uint*)0,                       // const uint32_t                *pQueueFamilyIndices
				preTransform = desired_transform,                     // VkSurfaceTransformFlagBitsKHR  preTransform
				compositeAlpha = CompositeAlphaFlagBitsKHR.OpaqueBitKhr,    // VkCompositeAlphaFlagBitsKHR    compositeAlpha
				presentMode = desired_present_mode,                   // VkPresentModeKHR               presentMode
				clipped = Boolean32.True,                             // VkBool32                       clipped
				oldSwapchain = old_swap_chain                         // VkSwapchainKHR                 oldSwapchain
			};

			khrSwapChain.CreateSwapchainKHR ( vulkan.Device, ref swap_chain_create_info, (AllocationCallbacks*)0, out vulkan.SwapChain.Handle ).CheckError ();

			if ( !old_swap_chain.IsZero )
			{
				khrSwapChain.DestroySwapchainKHR ( vulkan.Device, old_swap_chain );
			}

			vulkan.SwapChain.Format = desired_format.format;

			var images = DelegateUtility.EnumerateToArray<Image> ( khrSwapChain.GetSwapchainImagesKHR,
				(IntPtr)vulkan.Device, (ulong)vulkan.SwapChain.Handle );

			if ( vulkan.SwapChain.Images == null || vulkan.SwapChain.Images.Length != images.Length )
			{
				vulkan.SwapChain.Images = new ImageParameters[images.Length];
			}

			for ( int i = 0; i < images.Length; ++i )
			{
				vulkan.SwapChain.Images[i].Handle = images[i];
			}

			vulkan.SwapChain.Extent = desired_extent;

			CreateSwapChainImageViews ();
		}
		void CreateSwapChainImageViews()
		{
			var image_view_create_info = new ImageViewCreateInfo
			{
				sType = StructureType.ImageViewCreateInfo,   // VkStructureType                sType
				pNext = IntPtr.Zero,                         // const void                    *pNext
				flags = 0,                                   // VkImageViewCreateFlagBits         flags
																			//image = vulkan.SwapChain.Images[i].Handle,   // VkImage                        image
				viewType = ImageViewType._2d,                // VkImageViewType                viewType
				format = vulkan.SwapChain.Format,            // VkFormat                       format
				components = new ComponentMapping
				{                                            // VkComponentMapping             components
					r = ComponentSwizzle.Identity,            // VkComponentSwizzle             r
					g = ComponentSwizzle.Identity,            // VkComponentSwizzle             g
					b = ComponentSwizzle.Identity,            // VkComponentSwizzle             b
					a = ComponentSwizzle.Identity             // VkComponentSwizzle             a
				},
				subresourceRange = new ImageSubresourceRange
				{                                            // VkImageSubresourceRange        subresourceRange
					aspectMask = ImageAspectFlagBits.ColorBit,      // VkImageAspectFlagBits             aspectMask
					baseMipLevel = 0,                         // uint32_t                       baseMipLevel
					levelCount = 1,                           // uint32_t                       levelCount
					baseArrayLayer = 0,                       // uint32_t                       baseArrayLayer
					layerCount = 1                            // uint32_t                       layerCount
				}
			};

			for ( int i = 0; i < vulkan.SwapChain.Images.Length; ++i )
			{
				image_view_create_info.image = vulkan.SwapChain.Images[i].Handle;
				vk.CreateImageView ( vulkan.Device, ref image_view_create_info, (AllocationCallbacks*)0, out vulkan.SwapChain.Images[i].View );
			}

			CanRender = true;
		}
		protected virtual void ChildOnWindowSizeChanged() { }
		protected virtual void ChildClear() { }


		Boolean32 OnDebugReport(
			DebugReportFlagBitsEXT flags,
			DebugReportObjectTypeEXT objectType,
			ulong @object,
			int location,
			int messageCode,
			byte* pLayerPrefix,
			byte* pMessage,
			IntPtr pUserData)
		{
			var layerPrefix = new string ( (sbyte*)pLayerPrefix );
			var message = new string ( (sbyte*)pMessage );
			Console.WriteLine ( "FlagBits:{0}; ObjType:{1}; Obj:0x{2:x}; Loc:{3}; MsgCode:{4}; Layer:{5}; Msg:{6};",
				flags, objectType, @object, location, messageCode, layerPrefix, message );
			return false;
		}

		bool CheckExtensionAvailability(string extension_name, ExtensionProperties[] available_extensions)
		{
			for ( int i = 0; i < available_extensions.Length; i++ )
			{
				var ex = available_extensions[i];
				if ( extension_name.Equals ( ex.extensionName ) )
				{
					return true;
				}
			}
			return false;
		}
		uint GetSwapChainNumImages(ref SurfaceCapabilitiesKHR surface_capabilities)
		{
			// Set of images defined in a swap chain may not always be available for application to render to:
			// One may be displayed and one may wait in a queue to be presented
			// If application wants to use more images at the same time it must ask for more images
			uint image_count = surface_capabilities.minImageCount + 1;
			if ( (surface_capabilities.maxImageCount > 0) &&
				 (image_count > surface_capabilities.maxImageCount) )
			{
				image_count = surface_capabilities.maxImageCount;
			}
			return image_count;
		}
		SurfaceFormatKHR GetSwapChainFormat(SurfaceFormatKHR[] surface_formats)
		{
			// If the list contains only one entry with undefined format
			// it means that there are no preferred surface formats and any can be chosen
			if ( surface_formats.Length == 1 && surface_formats[0].format == Format.Undefined )
			{
				return new SurfaceFormatKHR
				{
					format = Format.R8g8b8a8Unorm,
					colorSpace = ColorSpaceKHR.SrgbNonlinearKhr
				};
			}

			// Check if list contains most widely used R8 G8 B8 A8 format
			// with nonlinear color space
			for ( int i = 0; i < surface_formats.Length; i++ )
			{
				if ( surface_formats[i].format == Format.R8g8b8a8Unorm )
				{
					return surface_formats[i];
				}
			}

			// Return the first format from the list
			return surface_formats[0];
		}
		Extent2D GetSwapChainExtent(ref SurfaceCapabilitiesKHR surface_capabilities)
		{
			// Special value of surface extent is width == height == -1
			// If this is so we define the size by ourselves but it must fit within defined confines
			if ( surface_capabilities.currentExtent.width == unchecked((uint)(-1)) )
			{
				Extent2D swap_chain_extent = new Extent2D { width = 640, height = 480 };
				if ( swap_chain_extent.width < surface_capabilities.minImageExtent.width )
				{
					swap_chain_extent.width = surface_capabilities.minImageExtent.width;
				}
				if ( swap_chain_extent.height < surface_capabilities.minImageExtent.height )
				{
					swap_chain_extent.height = surface_capabilities.minImageExtent.height;
				}
				if ( swap_chain_extent.width > surface_capabilities.maxImageExtent.width )
				{
					swap_chain_extent.width = surface_capabilities.maxImageExtent.width;
				}
				if ( swap_chain_extent.height > surface_capabilities.maxImageExtent.height )
				{
					swap_chain_extent.height = surface_capabilities.maxImageExtent.height;
				}
				return swap_chain_extent;
			}

			// Most of the cases we define size of the swap_chain images equal to current window's size
			return surface_capabilities.currentExtent;
		}
		ImageUsageFlagBits GetSwapChainUsageFlagBits(ref SurfaceCapabilitiesKHR surface_capabilities)
		{
			// Color attachment flag must always be supported
			// We can define other usage flags but we always need to check if they are supported
			if ( (surface_capabilities.supportedUsageFlags & ImageUsageFlagBits.ColorAttachmentBit) > 0 )
			{
				return ImageUsageFlagBits.ColorAttachmentBit;
			}
			//std::cout << "VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT image usage is not supported by the swap chain!" << std::endl
			//  << "Supported swap chain's image usages include:" << std::endl
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_TRANSFER_SRC_BIT ? "    VK_IMAGE_USAGE_TRANSFER_SRC\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_TRANSFER_DST_BIT ? "    VK_IMAGE_USAGE_TRANSFER_DST\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_SAMPLED_BIT ? "    VK_IMAGE_USAGE_SAMPLED\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_STORAGE_BIT ? "    VK_IMAGE_USAGE_STORAGE\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT ? "    VK_IMAGE_USAGE_COLOR_ATTACHMENT\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT ? "    VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT ? "    VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT\n" : "")
			//  << (surface_capabilities.supportedUsageFlagBits & VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT ? "    VK_IMAGE_USAGE_INPUT_ATTACHMENT" : "")
			//  << std::endl;
			return (ImageUsageFlagBits)(-1);
		}
		SurfaceTransformFlagBitsKHR GetSwapChainTransform(ref SurfaceCapabilitiesKHR surface_capabilities)
		{
			// Sometimes images must be transformed before they are presented (i.e. due to device's orienation
			// being other than default orientation)
			// If the specified transform is other than current transform, presentation engine will transform image
			// during presentation operation; this operation may hit performance on some platforms
			// Here we don't want any transformations to occur so if the identity transform is supported use it
			// otherwise just use the same transform as current transform
			if ( (surface_capabilities.supportedTransforms & SurfaceTransformFlagBitsKHR.IdentityBitKhr) > 0 )
			{
				return SurfaceTransformFlagBitsKHR.IdentityBitKhr;
			}
			else
			{
				return surface_capabilities.currentTransform;
			}
		}
		PresentModeKHR GetSwapChainPresentMode(int[] present_modes)
		{
			// FIFO present mode is always available
			// MAILBOX is the lowest latency V-Sync enabled mode (something like triple-buffering) so use it if available
			for ( int i = 0; i < present_modes.Length; i++ )
			{
				if ( (PresentModeKHR)present_modes[i] == PresentModeKHR.MailboxKhr )
				{
					return PresentModeKHR.MailboxKhr;
				}
			}
			for ( int i = 0; i < present_modes.Length; i++ )
			{
				if ( (PresentModeKHR)present_modes[i] == PresentModeKHR.FifoKhr )
				{
					return PresentModeKHR.FifoKhr;
				}
			}
			//std::cout << "FIFO present mode is not supported by the swap chain!" << std::endl;
			return (PresentModeKHR)(-1);
		}

	};
}
