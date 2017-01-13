using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Crow.Graphics.Vulkan;

namespace TestConsole.VulkanTutorial
{
	// ************************************************************ //
	// DescriptorParameters                                         //
	//                                                              //
	// Container class for descriptor related resources             //
	// ************************************************************ //
	public struct DescriptorSetParameters
	{
		public DescriptorPool Pool;
		public DescriptorSetLayout Layout;
		public DescriptorSet Handle;
	}

	// ************************************************************ //
	// VertexData                                                   //
	//                                                              //
	// Struct describing data type and format of vertex attributes  //
	// ************************************************************ //
	public struct VertexData06
	{
		public float x, y, z, w;
		public float u, v;
	}

	// ************************************************************ //
	// RenderingResourcesData                                       //
	//                                                              //
	// Struct containing data used during rendering process         //
	// ************************************************************ //
	public struct RenderingResourcesData06
	{
		public Framebuffer Framebuffer;
		public CommandBuffer CommandBuffer;
		public Semaphore ImageAvailableSemaphore;
		public Semaphore FinishedRenderingSemaphore;
		public Fence Fence;
	}

	// ************************************************************ //
	// VulkanTutorial04Parameters                                   //
	//                                                              //
	// Vulkan specific parameters                                   //
	// ************************************************************ //
	public struct VulkanTutorial06Parameters
	{
		public RenderPass RenderPass;
		public ImageParameters Image;
		public DescriptorSetParameters DescriptorSet;
		public PipelineLayout PipelineLayout;
		public Pipeline GraphicsPipeline;
		public BufferParameters VertexBuffer;
		public BufferParameters StagingBuffer;
		public CommandPool CommandPool;
		public RenderingResourcesData06[] RenderingResources;

		public const int ResourcesCount = 3;
	}

	[StructLayout ( LayoutKind.Sequential )]
	struct BGRA
	{
		public byte B, G, R, A;
	}

	public unsafe class Tutorial06 : VulkanCommon
	{
		private VulkanTutorial06Parameters Vulkan;


		public Tutorial06()
		{
			Vulkan.RenderingResources = new RenderingResourcesData06[VulkanTutorial06Parameters.ResourcesCount];
		}


		public void Init()
		{
			CreateRenderingResources ();
			CreateStagingBuffer ();
			CreateTexture ();
			CreateDescriptorSetLayout ();
			CreateDescriptorPool ();
			AllocateDescriptorSet ();
			UpdateDescriptorSet ();
			CreateRenderPass ();
			CreatePipelineLayout ();
			CreatePipeline ();
			CreateVertexBuffer ();
		}

		void CreateRenderingResources()
		{
			CreateCommandBuffers ();
			CreateSemaphores ();
			CreateFences ();
		}

		void CreateCommandBuffers()
		{
			CreateCommandPool ( GetGraphicsQueue.FamilyIndex, out Vulkan.CommandPool );
			for ( int i = 0; i < Vulkan.RenderingResources.Length; ++i )
			{
				AllocateCommandBuffers ( Vulkan.CommandPool, 1, out Vulkan.RenderingResources[i].CommandBuffer );
			}
		}

		void CreateCommandPool(uint queue_family_index, out CommandPool pool)
		{
			var cmd_pool_create_info = new CommandPoolCreateInfo
			{
				sType = StructureType.CommandPoolCreateInfo,         // VkStructureType                sType
				pNext = IntPtr.Zero,                                 // const void                    *pNext
				flags = CommandPoolCreateFlagBits.ResetCommandBufferBit    // VkCommandPoolCreateFlagBits       flags
				| CommandPoolCreateFlagBits.TransientBit,
				queueFamilyIndex = queue_family_index                // uint32_t                       queueFamilyIndex
			};

			vk.CreateCommandPool ( GetDevice, ref cmd_pool_create_info, (AllocationCallbacks*)0, out pool );
		}

		void AllocateCommandBuffers(CommandPool pool, uint count, out CommandBuffer command_buffers)
		{
			var command_buffer_allocate_info = new CommandBufferAllocateInfo
			{
				sType = StructureType.CommandBufferAllocateInfo,  // VkStructureType                sType
				pNext = IntPtr.Zero,                              // const void                    *pNext
				commandPool = pool,                               // VkCommandPool                  commandPool
				level = CommandBufferLevel.Primary,               // VkCommandBufferLevel           level
				commandBufferCount = count                        // uint32_t                       bufferCount
			};

			CommandBuffer cb;
			vk.AllocateCommandBuffers ( GetDevice, ref command_buffer_allocate_info, &cb ).CheckError ();
			command_buffers = cb;
		}

		void CreateSemaphores()
		{
			var semaphore_create_info = new SemaphoreCreateInfo
			{
				sType = StructureType.SemaphoreCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                       // const void*                    pNext
				flags = 0                                  // VkSemaphoreCreateFlagBits         flags
			};

			for ( int i = 0; i < Vulkan.RenderingResources.Length; ++i )
			{
				vk.CreateSemaphore ( GetDevice, ref semaphore_create_info, (AllocationCallbacks*)0, out Vulkan.RenderingResources[i].ImageAvailableSemaphore ).CheckError ();
				vk.CreateSemaphore ( GetDevice, ref semaphore_create_info, (AllocationCallbacks*)0, out Vulkan.RenderingResources[i].FinishedRenderingSemaphore ).CheckError ();
			}
		}

		void CreateFences()
		{
			var fence_create_info = new FenceCreateInfo
			{
				sType = StructureType.FenceCreateInfo,  // VkStructureType                sType
				pNext = IntPtr.Zero,                    // const void                    *pNext
				flags = FenceCreateFlagBits.SignaledBit       // VkFenceCreateFlagBits             flags
			};

			for ( int i = 0; i < Vulkan.RenderingResources.Length; ++i )
			{
				vk.CreateFence ( GetDevice, ref fence_create_info, (AllocationCallbacks*)0, out Vulkan.RenderingResources[i].Fence ).CheckError ();
			}
		}

		void CreateStagingBuffer()
		{
			Vulkan.StagingBuffer.Size = 1000000;
			CreateBuffer ( BufferUsageFlagBits.TransferSourceBit, MemoryPropertyFlagBits.HostVisibleBit, ref Vulkan.StagingBuffer );
		}

		void CreateBuffer(BufferUsageFlagBits usage, MemoryPropertyFlagBits memoryProperty, ref BufferParameters buffer)
		{
			var buffer_create_info = new BufferCreateInfo
			{
				sType = StructureType.BufferCreateInfo,   // VkStructureType                sType
				pNext = IntPtr.Zero,                      // const void                    *pNext
				flags = 0,                                // VkBufferCreateFlagBits            flags
				size = buffer.Size,                       // VkDeviceSize                   size
				usage = usage,                            // VkBufferUsageFlagBits             usage
				sharingMode = SharingMode.Exclusive,      // VkSharingMode                  sharingMode
				queueFamilyIndexCount = 0,                // uint32_t                       queueFamilyIndexCount
				pQueueFamilyIndices = (uint*)0            // const uint32_t                *pQueueFamilyIndices
			};

			vk.CreateBuffer ( GetDevice, ref buffer_create_info, (AllocationCallbacks*)0, out buffer.Handle ).CheckError ();

			AllocateBufferMemory ( buffer.Handle, memoryProperty, out buffer.Memory );

			vk.BindBufferMemory ( GetDevice, buffer.Handle, buffer.Memory, 0 ).CheckError ();
		}

		void AllocateBufferMemory(Crow.Graphics.Vulkan.Buffer buffer, MemoryPropertyFlagBits property, out DeviceMemory memory)
		{
			memory = new DeviceMemory ();

			MemoryRequirements buffer_memory_requirements;
			vk.GetBufferMemoryRequirements ( GetDevice, buffer, out buffer_memory_requirements );

			PhysicalDeviceMemoryProperties memory_properties;
			vk.GetPhysicalDeviceMemoryProperties ( GetPhysicalDevice, out memory_properties );

			for ( int i = 0; i < memory_properties.memoryTypeCount; ++i )
			{
				if ( (buffer_memory_requirements.memoryTypeBits & (1 << i)) != 0
					&& (((MemoryType*)memory_properties.memoryTypes)[i].propertyFlags & property) != 0 )
				{
					var memory_allocate_info = new MemoryAllocateInfo
					{
						sType = StructureType.MemoryAllocateInfo,         // VkStructureType                        sType
						pNext = IntPtr.Zero,                              // const void                            *pNext
						allocationSize = buffer_memory_requirements.size, // VkDeviceSize                           allocationSize
						memoryTypeIndex = (uint)i                         // uint32_t                               memoryTypeIndex
					};

					if ( vk.AllocateMemory ( GetDevice, ref memory_allocate_info, (AllocationCallbacks*)0, out memory ).CheckError ().Success () )
						return;
				}
			}
		}

		void CreateTexture()
		{
			uint width = 0, height = 0, data_size = 0;

			var img = new System.Drawing.Bitmap ( "assets/texture.png" );
			width = (uint)img.Width;
			height = (uint)img.Height;
			var imgLock = img.LockBits (
				new System.Drawing.Rectangle ( 0, 0, img.Width, img.Height ),
				System.Drawing.Imaging.ImageLockMode.ReadOnly,
				System.Drawing.Imaging.PixelFormat.Format32bppArgb );

			data_size = (uint)(Math.Abs ( imgLock.Stride ) * img.Height);

			CreateImage ( width, height, out Vulkan.Image.Handle );

			AllocateImageMemory ( Vulkan.Image.Handle, MemoryPropertyFlagBits.DeviceLocalBit, out Vulkan.Image.Memory );

			vk.BindImageMemory ( GetDevice, Vulkan.Image.Handle, Vulkan.Image.Memory, 0 );

			CreateImageView ( ref Vulkan.Image );

			CreateSampler ( out Vulkan.Image.Sampler );

			CopyTextureData ( (byte*)imgLock.Scan0, data_size, width, height );

			img.UnlockBits ( imgLock );
			img.Dispose ();
		}

		void CreateImage(uint width, uint height, out Image image)
		{
			var image_create_info = new ImageCreateInfo
			{
				sType = StructureType.ImageCreateInfo,          // VkStructureType            sType;
				pNext = IntPtr.Zero,                            // const void                *pNext
				flags = 0,                                      // VkImageCreateFlagBits         flags
				imageType = ImageType._2d,                      // VkImageType                imageType
				format = Format.R8g8b8a8Unorm,                  // VkFormat                   format
				extent = new Extent3D (                         // VkExtent3D                 extent
					width,                                       // uint32_t                   width
					height,                                      // uint32_t                   height
					1                                            // uint32_t                   depth
					),
				mipLevels = 1,                                  // uint32_t                   mipLevels
				arrayLayers = 1,                                // uint32_t                   arrayLayers
				samples = SampleCountFlagBits._1Bit,                  // VkSampleCountFlagBits      samples
				tiling = ImageTiling.Optimal,                   // VkImageTiling              tiling
				usage = ImageUsageFlagBits.TransferDestinationBit |   // VkImageUsageFlagBits          usage
				ImageUsageFlagBits.SampledBit,
				sharingMode = SharingMode.Exclusive,            // VkSharingMode              sharingMode
				queueFamilyIndexCount = 0,                      // uint32_t                   queueFamilyIndexCount
				pQueueFamilyIndices = (uint*)0,                 // const uint32_t*            pQueueFamilyIndices
				initialLayout = ImageLayout.Undefined           // VkImageLayout              initialLayout
			};

			vk.CreateImage ( GetDevice, ref image_create_info, (AllocationCallbacks*)0, out image ).CheckError ();
		}

		void AllocateImageMemory(Image image, MemoryPropertyFlagBits property, out DeviceMemory memory)
		{
			memory = new DeviceMemory ();

			MemoryRequirements image_memory_requirements;
			vk.GetImageMemoryRequirements ( GetDevice, Vulkan.Image.Handle, out image_memory_requirements );

			PhysicalDeviceMemoryProperties memory_properties;
			vk.GetPhysicalDeviceMemoryProperties ( GetPhysicalDevice, out memory_properties );

			for ( int i = 0; i < memory_properties.memoryTypeCount; ++i )
			{
				if ( (image_memory_requirements.memoryTypeBits & (1 << i)) != 0
					&& (((MemoryType*)memory_properties.memoryTypes)[i].propertyFlags & property) != 0 )
				{
					var memory_allocate_info = new MemoryAllocateInfo
					{
						sType = StructureType.MemoryAllocateInfo,     // VkStructureType                        sType
						pNext = IntPtr.Zero,                                    // const void                            *pNext
						allocationSize = image_memory_requirements.size,             // VkDeviceSize                           allocationSize
						memoryTypeIndex = (uint)i                                           // uint32_t                               memoryTypeIndex
					};

					if ( vk.AllocateMemory ( GetDevice, ref memory_allocate_info, (AllocationCallbacks*)0, out memory ).CheckError ().Success () )
						return;
				}
			}
		}

		void CreateImageView(ref ImageParameters image_parameters)
		{
			var image_view_create_info = new ImageViewCreateInfo
			{
				sType = StructureType.ImageViewCreateInfo,    // VkStructureType            sType
				pNext = IntPtr.Zero,                          // const void                *pNext
				flags = 0,                                    // VkImageViewCreateFlagBits     flags
				image = image_parameters.Handle,              // VkImage                    image
				viewType = ImageViewType._2d,                 // VkImageViewType            viewType
				format = Format.R8g8b8a8Unorm,                // VkFormat                   format
				components = new ComponentMapping
				{                                             // VkComponentMapping         components
					r = ComponentSwizzle.Identity,             // VkComponentSwizzle         r
					g = ComponentSwizzle.Identity,             // VkComponentSwizzle         g
					b = ComponentSwizzle.Identity,             // VkComponentSwizzle         b
					a = ComponentSwizzle.Identity              // VkComponentSwizzle         a
				},
				subresourceRange = new ImageSubresourceRange
				{                                             // VkImageSubresourceRange    subresourceRange
					aspectMask = ImageAspectFlagBits.ColorBit,       // VkImageAspectFlagBits         aspectMask
					baseMipLevel = 0,                          // uint32_t                   baseMipLevel
					levelCount = 1,                            // uint32_t                   levelCount
					baseArrayLayer = 0,                        // uint32_t                   baseArrayLayer
					layerCount = 1                             // uint32_t                   layerCount
				}
			};

			vk.CreateImageView ( GetDevice, ref image_view_create_info, (AllocationCallbacks*)0, out image_parameters.View ).CheckError ();
		}

		void CreateSampler(out Sampler sampler)
		{
			var sampler_create_info = new SamplerCreateInfo
			{
				sType = StructureType.SamplerCreateInfo,           // VkStructureType            sType
				pNext = IntPtr.Zero,                               // const void*                pNext
				flags = 0,                                         // VkSamplerCreateFlagBits       flags
				magFilter = Filter.Linear,                         // VkFilter                   magFilter
				minFilter = Filter.Linear,                         // VkFilter                   minFilter
				mipmapMode = SamplerMipmapMode.Nearest,            // VkSamplerMipmapMode        mipmapMode
				addressModeU = SamplerAddressMode.ClampToEdge,     // VkSamplerAddressMode       addressModeU
				addressModeV = SamplerAddressMode.ClampToEdge,     // VkSamplerAddressMode       addressModeV
				addressModeW = SamplerAddressMode.ClampToEdge,     // VkSamplerAddressMode       addressModeW
				mipLodBias = 0.0f,                                 // float                      mipLodBias
				anisotropyEnable = false,                          // VkBool32                   anisotropyEnable
				maxAnisotropy = 1.0f,                              // float                      maxAnisotropy
				compareEnable = false,                             // VkBool32                   compareEnable
				compareOperation = CompareOperation.Always,        // VkCompareOp                compareOp
				minLod = 0.0f,                                     // float                      minLod
				maxLod = 0.0f,                                     // float                      maxLod
				borderColor = BorderColor.FloatTransparentBlack,   // VkBorderColor              borderColor
				unnormalizedCoordinates = false                    // VkBool32                   unnormalizedCoordinates
			};

			vk.CreateSampler ( GetDevice, ref sampler_create_info, (AllocationCallbacks*)0, out sampler ).CheckError ();
		}

		void CopyTextureData(byte* texture_data, uint data_size, uint width, uint height)
		{
			// Prepare data in staging buffer

			IntPtr staging_buffer_memory_pointer;
			vk.MapMemory ( GetDevice, Vulkan.StagingBuffer.Memory, 0, data_size, 0, out staging_buffer_memory_pointer ).CheckError ();

			//memcpy ( staging_buffer_memory_pointer, texture_data, data_size );
			// Format32bppArgb (store BGRA) to RGBA
			var colors = data_size / (sizeof ( byte ) * 4);
			BGRA* dest = (BGRA*)staging_buffer_memory_pointer;
			BGRA* source = (BGRA*)texture_data;
			for ( int i = 0; i < colors; i++ )
			{
				// BGRA to RGBA
				dest[i].B = source[i].R;
				dest[i].G = source[i].G;
				dest[i].R = source[i].B;
				dest[i].A = source[i].A;
			}

			var flush_range = new MappedMemoryRange
			{
				sType = StructureType.MappedMemoryRange,   // VkStructureType                        sType
				pNext = IntPtr.Zero,                       // const void                            *pNext
				memory = Vulkan.StagingBuffer.Memory,      // VkDeviceMemory                         memory
				offset = 0,                                // VkDeviceSize                           offset
				size = data_size            // VkDeviceSize                           size
			};
			vk.FlushMappedMemoryRanges ( GetDevice, 1, &flush_range );

			vk.UnmapMemory ( GetDevice, Vulkan.StagingBuffer.Memory );

			// Prepare command buffer to copy data from staging buffer to a vertex buffer
			var command_buffer_begin_info = new CommandBufferBeginInfo
			{
				sType = StructureType.CommandBufferBeginInfo,         // VkStructureType                        sType
				pNext = IntPtr.Zero,                                  // const void                            *pNext
				flags = CommandBufferUsageFlagBits.OneTimeSubmitBit,        // VkCommandBufferUsageFlagBits              flags
				pInheritanceInfo = (CommandBufferInheritanceInfo*)0   // const VkCommandBufferInheritanceInfo  *pInheritanceInfo
			};

			CommandBuffer command_buffer = Vulkan.RenderingResources[0].CommandBuffer;

			vk.BeginCommandBuffer ( command_buffer, ref command_buffer_begin_info );

			var image_subresource_range = new ImageSubresourceRange
			{
				aspectMask = ImageAspectFlagBits.ColorBit,  // VkImageAspectFlagBits                     aspectMask
				baseMipLevel = 0,                     // uint32_t                               baseMipLevel
				layerCount = 1,                       // uint32_t                               levelCount
				baseArrayLayer = 0,                   // uint32_t                               baseArrayLayer
				levelCount = 1                        // uint32_t                               layerCount
			};

			var image_memory_barrier_from_undefined_to_transfer_dst = new ImageMemoryBarrier
			{
				sType = StructureType.ImageMemoryBarrier,                         // VkStructureType                        sType
				pNext = IntPtr.Zero,                                              // const void                            *pNext
				sourceAccessMask = 0,                                             // VkAccessFlagBits                          srcAccessMask
				destinationAccessMask = AccessFlagBits.TransferWriteBit,                // VkAccessFlagBits                          dstAccessMask
				oldLayout = ImageLayout.Undefined,                                // VkImageLayout                          oldLayout
				newLayout = ImageLayout.TransferDestinationOptimal,               // VkImageLayout                          newLayout
				sourceQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,        // uint32_t                               srcQueueFamilyIndex
				destinationQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,   // uint32_t                               dstQueueFamilyIndex
				image = Vulkan.Image.Handle,                                      // VkImage                                image
				subresourceRange = image_subresource_range                        // VkImageSubresourceRange                subresourceRange
			};
			vk.CmdPipelineBarrier ( command_buffer,
				PipelineStageFlagBits.TopOfPipeBit,
				PipelineStageFlagBits.TransferBit,
				(DependencyFlagBits)0,
				0, (MemoryBarrier*)0,
				0, (BufferMemoryBarrier*)0,
				1, &image_memory_barrier_from_undefined_to_transfer_dst
			);

			var buffer_image_copy_info = new BufferImageCopy
			{
				bufferOffset = 0,                               // VkDeviceSize                           bufferOffset
				bufferRowLength = 0,                            // uint32_t                               bufferRowLength
				bufferImageHeight = 0,                          // uint32_t                               bufferImageHeight
				imageSubresource = new ImageSubresourceLayers
				{                                               // VkImageSubresourceLayers               imageSubresource
					aspectMask = ImageAspectFlagBits.ColorBit,         // VkImageAspectFlagBits                     aspectMask
					mipLevel = 0,                                // uint32_t                               mipLevel
					baseArrayLayer = 0,                          // uint32_t                               baseArrayLayer
					layerCount = 1                               // uint32_t                               layerCount
				},
				imageOffset = new Offset3D (                    // VkOffset3D                             imageOffset
					0,                                           // int32_t                                x
					0,                                           // int32_t                                y
					0                                            // int32_t                                z
					),
				imageExtent = new Extent3D (                    // VkExtent3D                             imageExtent
					width,                                       // uint32_t                               width
					height,                                      // uint32_t                               height
					1                                            // uint32_t                               depth
					)
			};
			vk.CmdCopyBufferToImage ( command_buffer,
				Vulkan.StagingBuffer.Handle,
				Vulkan.Image.Handle,
				ImageLayout.TransferDestinationOptimal,
				1, &buffer_image_copy_info
			);

			var image_memory_barrier_from_transfer_to_shader_read = new ImageMemoryBarrier
			{
				sType = StructureType.ImageMemoryBarrier,                        // VkStructureType                        sType
				pNext = IntPtr.Zero,                                             // const void                            *pNext
				sourceAccessMask = AccessFlagBits.TransferWriteBit,                    // VkAccessFlagBits                          srcAccessMask
				destinationAccessMask = AccessFlagBits.ShaderReadBit,                  // VkAccessFlagBits                          dstAccessMask
				oldLayout = ImageLayout.TransferDestinationOptimal,              // VkImageLayout                          oldLayout
				newLayout = ImageLayout.ShaderReadOnlyOptimal,                   // VkImageLayout                          newLayout
				sourceQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,       // uint32_t                               srcQueueFamilyIndex
				destinationQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,  // uint32_t                               dstQueueFamilyIndex
				image = Vulkan.Image.Handle,                                     // VkImage                                image
				subresourceRange = image_subresource_range                       // VkImageSubresourceRange                subresourceRange
			};
			vk.CmdPipelineBarrier ( command_buffer,
				PipelineStageFlagBits.TransferBit,
				PipelineStageFlagBits.FragmentShaderBit,
				(DependencyFlagBits)0,
				0, (MemoryBarrier*)0,
				0, (BufferMemoryBarrier*)0,
				1, &image_memory_barrier_from_transfer_to_shader_read );

			vk.EndCommandBuffer ( command_buffer ).CheckError ();

			// Submit command buffer and copy data from staging buffer to a vertex buffer
			var submit_info = new SubmitInfo
			{
				sType = StructureType.SubmitInfo,                      // VkStructureType                        sType
				pNext = IntPtr.Zero,                                   // const void                            *pNext
				waitSemaphoreCount = 0,                                // uint32_t                               waitSemaphoreCount
				pWaitSemaphores = (Semaphore*)0,                       // const VkSemaphore                     *pWaitSemaphores
				pWaitDestinationStageMask = (PipelineStageFlagBits*)0,    // const VkPipelineStageFlagBits            *pWaitDstStageMask;
				commandBufferCount = 1,                                // uint32_t                               commandBufferCount
				pCommandBuffers = &command_buffer,                     // const VkCommandBuffer                 *pCommandBuffers
				signalSemaphoreCount = 0,                              // uint32_t                               signalSemaphoreCount
				pSignalSemaphores = (Semaphore*)0                      // const VkSemaphore                     *pSignalSemaphores
			};

			vk.QueueSubmit ( GetGraphicsQueue.Handle, 1, &submit_info, default ( Fence ) ).CheckError ();

			vk.DeviceWaitIdle ( GetDevice );
		}

		void CreateDescriptorSetLayout()
		{
			var layout_binding = new DescriptorSetLayoutBinding
			{
				binding = 0,                                                            // uint32_t                             binding
				descriptorType = DescriptorType.CombinedImageSampler,                   // VkDescriptorType                     descriptorType
				descriptorCount = 1,                                                    // uint32_t                             descriptorCount
				stageFlags = ShaderStageFlagBits.FragmentBit,                                 // VkShaderStageFlagBits                   stageFlags
				pImmutableSamplers = (Sampler*)0                                        // const VkSampler                     *pImmutableSamplers
			};

			var descriptor_set_layout_create_info = new DescriptorSetLayoutCreateInfo
			{
				sType = StructureType.DescriptorSetLayoutCreateInfo,                    // VkStructureType                      sType
				pNext = IntPtr.Zero,                                                    // const void                          *pNext
				flags = 0,                                                              // VkDescriptorSetLayoutCreateFlagBits     flags
				bindingCount = 1,                                                       // uint32_t                             bindingCount
				pBindings = &layout_binding                                             // const VkDescriptorSetLayoutBinding  *pBindings
			};

			vk.CreateDescriptorSetLayout ( GetDevice, ref descriptor_set_layout_create_info, (AllocationCallbacks*)0, out Vulkan.DescriptorSet.Layout ).CheckError ();
		}

		void CreateDescriptorPool()
		{
			var pool_size = new DescriptorPoolSize
			{
				type = DescriptorType.CombinedImageSampler,  // VkDescriptorType               type
				descriptorCount = 1                          // uint32_t                       descriptorCount
			};

			var descriptor_pool_create_info = new DescriptorPoolCreateInfo
			{
				sType = StructureType.DescriptorPoolCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                            // const void                    *pNext
				flags = 0,                                      // VkDescriptorPoolCreateFlagBits    flags
				maxSets = 1,                                    // uint32_t                       maxSets
				poolSizeCount = 1,                              // uint32_t                       poolSizeCount
				pPoolSizes = &pool_size                         // const VkDescriptorPoolSize    *pPoolSizes
			};

			vk.CreateDescriptorPool ( GetDevice, ref descriptor_pool_create_info, (AllocationCallbacks*)0, out Vulkan.DescriptorSet.Pool );
		}

		void AllocateDescriptorSet()
		{
			var layout = Vulkan.DescriptorSet.Layout;
			var descriptor_set_allocate_info = new DescriptorSetAllocateInfo
			{
				sType = StructureType.DescriptorSetAllocateInfo,  // VkStructureType                sType
				pNext = IntPtr.Zero,                              // const void                    *pNext
				descriptorPool = Vulkan.DescriptorSet.Pool,       // VkDescriptorPool               descriptorPool
				descriptorSetCount = 1,                           // uint32_t                       descriptorSetCount
				pSetLayouts = &layout                             // const VkDescriptorSetLayout   *pSetLayouts
			};

			DescriptorSet ds;
			vk.AllocateDescriptorSets ( GetDevice, ref descriptor_set_allocate_info, &ds ).CheckError ();
			Vulkan.DescriptorSet.Handle = ds;
		}

		void UpdateDescriptorSet()
		{
			var image_info = new DescriptorImageInfo
			{
				sampler = Vulkan.Image.Sampler,                        // VkSampler                      sampler
				imageView = Vulkan.Image.View,                         // VkImageView                    imageView
				imageLayout = ImageLayout.ShaderReadOnlyOptimal        // VkImageLayout                  imageLayout
			};

			var descriptor_writes = new WriteDescriptorSet
			{
				sType = StructureType.WriteDescriptorSet,              // VkStructureType                sType
				pNext = IntPtr.Zero,                                   // const void                    *pNext
				destinationSet = Vulkan.DescriptorSet.Handle,          // VkDescriptorSet                dstSet
				destinationBinding = 0,                                // uint32_t                       dstBinding
				destinationArrayElement = 0,                           // uint32_t                       dstArrayElement
				descriptorCount = 1,                                   // uint32_t                       descriptorCount
				descriptorType = DescriptorType.CombinedImageSampler,  // VkDescriptorType               descriptorType
				pImageInfo = &image_info,                              // const VkDescriptorImageInfo   *pImageInfo
				pBufferInfo = (DescriptorBufferInfo*)0,                // const VkDescriptorBufferInfo  *pBufferInfo
				pTexelBufferView = (BufferView*)0                      // const VkBufferView            *pTexelBufferView
			};

			vk.UpdateDescriptorSets ( GetDevice, 1, &descriptor_writes, 0, (CopyDescriptorSet*)0 );
		}

		void CreateRenderPass()
		{
			var attachment_descriptions = stackalloc AttachmentDescription[1];
			attachment_descriptions[0] = new AttachmentDescription
			{
				flags = 0,                                                           // VkAttachmentDescriptionFlagBits   flags
				format = GetSwapChain.Format,                                        // VkFormat                       format
				samples = SampleCountFlagBits._1Bit,                                       // VkSampleCountFlagBits          samples
				loadOperation = AttachmentLoadOperation.Clear,                       // VkAttachmentLoadOp             loadOp
				storeOperation = AttachmentStoreOperation.Store,                     // VkAttachmentStoreOp            storeOp
				stencilLoadOperation = AttachmentLoadOperation.DontCare,             // VkAttachmentLoadOp             stencilLoadOp
				stencilStoreOperation = AttachmentStoreOperation.DontCare,           // VkAttachmentStoreOp            stencilStoreOp
				initialLayout = ImageLayout.ColorAttachmentOptimal,                  // VkImageLayout                  initialLayout;
				finalLayout = ImageLayout.ColorAttachmentOptimal                     // VkImageLayout                  finalLayout
			};

			var color_attachment_references = stackalloc AttachmentReference[1];
			color_attachment_references[0] = new AttachmentReference
			{
				attachment = 0,                             // uint32_t                       attachment
				layout = ImageLayout.ColorAttachmentOptimal // VkImageLayout                  layout
			};

			var subpass_descriptions = stackalloc SubpassDescription[1];
			subpass_descriptions[0] = new SubpassDescription
			{
				flags = 0,                                           // VkSubpassDescriptionFlagBits      flags
				pipelineBindPoint = PipelineBindPoint.Graphics,      // VkPipelineBindPoint            pipelineBindPoint
				inputAttachmentCount = 0,                            // uint32_t                       inputAttachmentCount
				pInputAttachments = (AttachmentReference*)0,         // const VkAttachmentReference   *pInputAttachments
				colorAttachmentCount = 1,                            // uint32_t                       colorAttachmentCount
				pColorAttachments = color_attachment_references,     // const VkAttachmentReference   *pColorAttachments
				pResolveAttachments = (AttachmentReference*)0,       // const VkAttachmentReference   *pResolveAttachments
				pDepthStencilAttachment = (AttachmentReference*)0,   // const VkAttachmentReference   *pDepthStencilAttachment
				preserveAttachmentCount = 0,                         // uint32_t                       preserveAttachmentCount
				pPreserveAttachments = (uint*)0                      // const uint32_t*                pPreserveAttachments
			};

			var render_pass_create_info = new RenderPassCreateInfo
			{
				sType = StructureType.RenderPassCreateInfo,   // VkStructureType                sType
				pNext = IntPtr.Zero,                          // const void                    *pNext
				flags = 0,                                    // VkRenderPassCreateFlagBits        flags
				attachmentCount = 1,                          // uint32_t                       attachmentCount
				pAttachments = attachment_descriptions,       // const VkAttachmentDescription *pAttachments
				subpassCount = 1,                             // uint32_t                       subpassCount
				pSubpasses = subpass_descriptions,            // const VkSubpassDescription    *pSubpasses
				dependencyCount = 0,                          // uint32_t                       dependencyCount
				pDependencies = (SubpassDependency*)0         // const VkSubpassDependency     *pDependencies
			};

			vk.CreateRenderPass ( GetDevice, ref render_pass_create_info, (AllocationCallbacks*)0, out Vulkan.RenderPass ).CheckError ();
		}

		void CreatePipelineLayout()
		{
			var layout = Vulkan.DescriptorSet.Layout;
			var layout_create_info = new PipelineLayoutCreateInfo
			{
				sType = StructureType.PipelineLayoutCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                            // const void                    *pNext
				flags = 0,                                      // VkPipelineLayoutCreateFlagBits    flags
				setLayoutCount = 1,                             // uint32_t                       setLayoutCount
				pSetLayouts = &layout,                          // const VkDescriptorSetLayout   *pSetLayouts
				pushConstantRangeCount = 0,                     // uint32_t                       pushConstantRangeCount
				pPushConstantRanges = (PushConstantRange*)0     // const VkPushConstantRange     *pPushConstantRanges
			};

			vk.CreatePipelineLayout ( GetDevice, ref layout_create_info, (AllocationCallbacks*)0, out Vulkan.PipelineLayout ).CheckError ();
		}

		void CreatePipeline()
		{
			ShaderModule vertex_shader_module = CreateShaderModule ( "assets/shader06.vert.spv" );
			ShaderModule fragment_shader_module = CreateShaderModule ( "assets/shader06.frag.spv" );

			var shader_stage_create_infos = stackalloc PipelineShaderStageCreateInfo[2];
			// Vertex shader
			shader_stage_create_infos[0] = new PipelineShaderStageCreateInfo
			{
				sType = StructureType.PipelineShaderStageCreateInfo,   // VkStructureType                                sType
				pNext = IntPtr.Zero,                                   // const void                                    *pNext
				flags = 0,                                             // VkPipelineShaderStageCreateFlagBits               flags
				stage = ShaderStageFlagBits.VertexBit,                       // VkShaderStageFlagBits                          stage
				module = vertex_shader_module,                         // VkShaderModule                                 module
				pName = (byte*)Marshal.StringToHGlobalAnsi ( "main" ), // const char                                    *pName
				pSpecializationInfo = (SpecializationInfo*)0           // const VkSpecializationInfo                    *pSpecializationInfo
			};
			// Fragment shader
			shader_stage_create_infos[1] = new PipelineShaderStageCreateInfo
			{
				sType = StructureType.PipelineShaderStageCreateInfo,   // VkStructureType                                sType
				pNext = IntPtr.Zero,                                   // const void                                    *pNext
				flags = 0,                                             // VkPipelineShaderStageCreateFlagBits               flags
				stage = ShaderStageFlagBits.FragmentBit,                     // VkShaderStageFlagBits                          stage
				module = fragment_shader_module,                       // VkShaderModule                                 module
				pName = (byte*)Marshal.StringToHGlobalAnsi ( "main" ), // const char                                    *pName
				pSpecializationInfo = (SpecializationInfo*)0           // const VkSpecializationInfo                    *pSpecializationInfo
			};

			var vertex_binding_descriptions = stackalloc VertexInputBindingDescription[1];
			vertex_binding_descriptions[0] = new VertexInputBindingDescription
			{
				binding = 0,                                     // uint32_t                                       binding
				stride = (uint)Marshal.SizeOf<VertexData06> (),  // uint32_t                                       stride
				inputRate = VertexInputRate.Vertex               // VkVertexInputRate                              inputRate
			};

			var vertex_attribute_descriptions = stackalloc VertexInputAttributeDescription[2];
			vertex_attribute_descriptions[0] = new VertexInputAttributeDescription
			{
				location = 0,                                        // uint32_t                                       location
				binding = vertex_binding_descriptions[0].binding,    // uint32_t                                       binding
				format = Format.R32g32b32a32Sfloat,                  // VkFormat                                       format
				offset = (uint)Marshal.OffsetOf<VertexData06> ( "x" )  // uint32_t                                       offset
			};
			vertex_attribute_descriptions[1] = new VertexInputAttributeDescription
			{
				location = 1,                                        // uint32_t                                       location
				binding = vertex_binding_descriptions[0].binding,    // uint32_t                                       binding
				format = Format.R32g32b32a32Sfloat,                  // VkFormat                                       format
				offset = (uint)Marshal.OffsetOf<VertexData06> ( "u" )  // uint32_t                                       offset
			};

			var vertex_input_state_create_info = new PipelineVertexInputStateCreateInfo
			{
				sType = StructureType.PipelineVertexInputStateCreateInfo,           // VkStructureType                                sType
				pNext = IntPtr.Zero,                                                // const void                                    *pNext
				flags = 0,                                                          // VkPipelineVertexInputStateCreateFlagBits          flags;
				vertexBindingDescriptionCount = 1,                                  // uint32_t                                       vertexBindingDescriptionCount
				pVertexBindingDescriptions = vertex_binding_descriptions,           // const VkVertexInputBindingDescription         *pVertexBindingDescriptions
				vertexAttributeDescriptionCount = 2,                                // uint32_t                                       vertexAttributeDescriptionCount
				pVertexAttributeDescriptions = vertex_attribute_descriptions        // const VkVertexInputAttributeDescription       *pVertexAttributeDescriptions
			};

			var input_assembly_state_create_info = new PipelineInputAssemblyStateCreateInfo
			{
				sType = StructureType.PipelineInputAssemblyStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                        // const void                                    *pNext
				flags = 0,                                                  // VkPipelineInputAssemblyStateCreateFlagBits        flags
				topology = PrimitiveTopology.TriangleStrip,                 // VkPrimitiveTopology                            topology
				primitiveRestartEnable = false                              // VkBool32                                       primitiveRestartEnable
			};

			var viewport_state_create_info = new PipelineViewportStateCreateInfo
			{
				sType = StructureType.PipelineViewportStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                   // const void                                    *pNext
				flags = 0,                                             // VkPipelineViewportStateCreateFlagBits             flags
				viewportCount = 1,                                     // uint32_t                                       viewportCount
				pViewports = (Viewport*)0,                             // const VkViewport                              *pViewports
				scissorCount = 1,                                      // uint32_t                                       scissorCount
				pScissors = (Rect2D*)0                                 // const VkRect2D                                *pScissors
			};

			var rasterization_state_create_info = new PipelineRasterizationStateCreateInfo
			{
				sType = StructureType.PipelineRasterizationStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                        // const void                                    *pNext
				flags = 0,                                                  // VkPipelineRasterizationStateCreateFlagBits        flags
				depthClampEnable = false,                                   // VkBool32                                       depthClampEnable
				rasterizerDiscardEnable = false,                            // VkBool32                                       rasterizerDiscardEnable
				polygonMode = PolygonMode.Fill,                             // VkPolygonMode                                  polygonMode
				cullMode = CullModeFlagBits.BackBit,                              // VkCullModeFlagBits                                cullMode
				frontFace = FrontFace.CounterClockwise,                     // VkFrontFace                                    frontFace
				depthBiasEnable = false,                                    // VkBool32                                       depthBiasEnable
				depthBiasConstantFactor = 0.0f,                             // float                                          depthBiasConstantFactor
				depthBiasClamp = 0.0f,                                      // float                                          depthBiasClamp
				depthBiasSlopeFactor = 0.0f,                                // float                                          depthBiasSlopeFactor
				lineWidth = 1.0f                                            // float                                          lineWidth
			};

			var multisample_state_create_info = new PipelineMultisampleStateCreateInfo
			{
				sType = StructureType.PipelineMultisampleStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                      // const void                                    *pNext
				flags = 0,                                                // VkPipelineMultisampleStateCreateFlagBits          flags
				rasterizationSamples = SampleCountFlagBits._1Bit,               // VkSampleCountFlagBits                          rasterizationSamples
				sampleShadingEnable = false,                              // VkBool32                                       sampleShadingEnable
				minSampleShading = 1.0f,                                  // float                                          minSampleShading
				pSampleMask = (uint*)0,                                   // const VkSampleMask                            *pSampleMask
				alphaToCoverageEnable = false,                            // VkBool32                                       alphaToCoverageEnable
				alphaToOneEnable = false                                  // VkBool32                                       alphaToOneEnable
			};

			var color_blend_attachment_state = new PipelineColorBlendAttachmentState
			{
				blendEnable = false,                                            // VkBool32                                       blendEnable
				sourceColorBlendFactor = BlendFactor.One,                       // VkBlendFactor                                  srcColorBlendFactor
				destinationColorBlendFactor = BlendFactor.Zero,                 // VkBlendFactor                                  dstColorBlendFactor
				colorBlendOperation = BlendOperation.Add,                       // VkBlendOp                                      colorBlendOp
				sourceAlphaBlendFactor = BlendFactor.One,                       // VkBlendFactor                                  srcAlphaBlendFactor
				destinationAlphaBlendFactor = BlendFactor.Zero,                 // VkBlendFactor                                  dstAlphaBlendFactor
				alphaBlendOperation = BlendOperation.Add,                       // VkBlendOp                                      alphaBlendOp
				colorWriteMask = ColorComponentFlagBits.RBit | ColorComponentFlagBits.GBit  // VkColorComponentFlagBits                          colorWriteMask
				| ColorComponentFlagBits.BBit | ColorComponentFlagBits.ABit
			};

			var color_blend_state_create_info = new PipelineColorBlendStateCreateInfo
			{
				sType = StructureType.PipelineColorBlendStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                     // const void                                    *pNext
				flags = 0,                                               // VkPipelineColorBlendStateCreateFlagBits           flags
				logicOperationEnable = false,                            // VkBool32                                       logicOpEnable
				logicOperation = LogicOperation.Copy,                    // VkLogicOp                                      logicOp
				attachmentCount = 1,                                     // uint32_t                                       attachmentCount
				pAttachments = &color_blend_attachment_state,            // const VkPipelineColorBlendAttachmentState     *pAttachments
			};
			//blendConstants = { 0.0f, 0.0f, 0.0f, 0.0f }              // float                                          blendConstants[4]
			color_blend_state_create_info.blendConstants[0] = 0;
			color_blend_state_create_info.blendConstants[1] = 0;
			color_blend_state_create_info.blendConstants[2] = 0;
			color_blend_state_create_info.blendConstants[3] = 0;


			var dynamic_states = stackalloc DynamicState[2];
			dynamic_states[0] = DynamicState.Viewport;
			dynamic_states[1] = DynamicState.Scissor;

			var dynamic_state_create_info = new PipelineDynamicStateCreateInfo
			{
				sType = StructureType.PipelineDynamicStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                  // const void                                    *pNext
				flags = 0,                                            // VkPipelineDynamicStateCreateFlagBits              flags
				dynamicStateCount = 2,                                // uint32_t                                       dynamicStateCount
				pDynamicStates = dynamic_states                       // const VkDynamicState                          *pDynamicStates
			};

			var pipeline_create_info = new GraphicsPipelineCreateInfo
			{
				sType = StructureType.GraphicsPipelineCreateInfo,             // VkStructureType                                sType
				pNext = IntPtr.Zero,                                          // const void                                    *pNext
				flags = 0,                                                    // VkPipelineCreateFlagBits                          flags
				stageCount = 2,                                               // uint32_t                                       stageCount
				pStages = shader_stage_create_infos,                          // const VkPipelineShaderStageCreateInfo         *pStages
				pVertexInputState = &vertex_input_state_create_info,          // const VkPipelineVertexInputStateCreateInfo    *pVertexInputState;
				pInputAssemblyState = &input_assembly_state_create_info,      // const VkPipelineInputAssemblyStateCreateInfo  *pInputAssemblyState
				pTessellationState = (PipelineTessellationStateCreateInfo*)0, // const VkPipelineTessellationStateCreateInfo   *pTessellationState
				pViewportState = &viewport_state_create_info,                 // const VkPipelineViewportStateCreateInfo       *pViewportState
				pRasterizationState = &rasterization_state_create_info,       // const VkPipelineRasterizationStateCreateInfo  *pRasterizationState
				pMultisampleState = &multisample_state_create_info,           // const VkPipelineMultisampleStateCreateInfo    *pMultisampleState
				pDepthStencilState = (PipelineDepthStencilStateCreateInfo*)0, // const VkPipelineDepthStencilStateCreateInfo   *pDepthStencilState
				pColorBlendState = &color_blend_state_create_info,            // const VkPipelineColorBlendStateCreateInfo     *pColorBlendState
				pDynamicState = &dynamic_state_create_info,                   // const VkPipelineDynamicStateCreateInfo        *pDynamicState
				layout = Vulkan.PipelineLayout,                               // VkPipelineLayout                               layout
				renderPass = Vulkan.RenderPass,                               // VkRenderPass                                   renderPass
				subpass = 0,                                                  // uint32_t                                       subpass
				basePipelineHandle = default ( Pipeline ),                    // VkPipeline                                     basePipelineHandle
				basePipelineIndex = -1                                        // int32_t                                        basePipelineIndex
			};

			vk.CreateGraphicsPipelines ( GetDevice, default ( PipelineCache ), 1, &pipeline_create_info, (AllocationCallbacks*)0, out Vulkan.GraphicsPipeline ).CheckError ();

			Marshal.FreeHGlobal ( (IntPtr)shader_stage_create_infos[0].pName );
			Marshal.FreeHGlobal ( (IntPtr)shader_stage_create_infos[1].pName );
		}

		ShaderModule CreateShaderModule(string filename)
		{
			byte[] stream;
			using ( var code = System.IO.File.OpenRead ( filename ) )
			{
				stream = new byte[code.Length];
				code.Read ( stream, 0, stream.Length );
			}
			fixed ( byte* ptr = stream )
			{
				var shader_module_create_info = new ShaderModuleCreateInfo
				{
					sType = StructureType.ShaderModuleCreateInfo, // VkStructureType                sType
					pNext = IntPtr.Zero,                          // const void                    *pNext
					flags = 0,                                    // VkShaderModuleCreateFlagBits      flags
					codeSize = stream.Length,                     // size_t                         codeSize
					pCode = (uint*)ptr                            // const uint32_t                *pCode
				};

				ShaderModule shader_module;
				vk.CreateShaderModule ( GetDevice, ref shader_module_create_info, (AllocationCallbacks*)0, out shader_module ).CheckError ();
				return shader_module;
			}
		}

		static float[] vertex_data = new[]
		{
			-0.7f, -0.7f, 0.0f, 1.0f,
			-0.1f, -0.1f,
			//
			-0.7f, 0.7f, 0.0f, 1.0f,
			-0.1f, 1.1f,
			//
			0.7f, -0.7f, 0.0f, 1.0f,
			1.1f, -0.1f,
			//
			0.7f, 0.7f, 0.0f, 1.0f,
			1.1f, 1.1f,
		};

		float[] GetVertexData()
		{
			return vertex_data;
		}

		void CreateVertexBuffer()
		{
			float[] vertex_data = GetVertexData ();

			Vulkan.VertexBuffer.Size = (uint)(vertex_data.Length * sizeof ( float ));
			CreateBuffer ( BufferUsageFlagBits.VertexBufferBit | BufferUsageFlagBits.TransferSourceBit, MemoryPropertyFlagBits.DeviceLocalBit, ref Vulkan.VertexBuffer );
			CopyVertexData ();
		}

		void CopyVertexData()
		{
			// Prepare data in a staging buffer
			float[] vertex_data = GetVertexData ();

			IntPtr staging_buffer_memory_pointer;
			vk.MapMemory ( GetDevice, Vulkan.StagingBuffer.Memory, 0, Vulkan.VertexBuffer.Size, 0, out staging_buffer_memory_pointer ).CheckError ();

			//memcpy ( staging_buffer_memory_pointer, &vertex_data[0], Vulkan.VertexBuffer.Size );
			fixed ( float* ptr = vertex_data )
			{
				for ( int i = 0; i < Vulkan.VertexBuffer.Size; i++ )
				{
					((byte*)staging_buffer_memory_pointer)[i] = ((byte*)ptr)[i];
				}
			}

			var flush_range = new MappedMemoryRange
			{
				sType = StructureType.MappedMemoryRange,   // VkStructureType                        sType
				pNext = IntPtr.Zero,                       // const void                            *pNext
				memory = Vulkan.StagingBuffer.Memory,      // VkDeviceMemory                         memory
				offset = 0,                                // VkDeviceSize                           offset
				size = Vulkan.VertexBuffer.Size            // VkDeviceSize                           size
			};
			vk.FlushMappedMemoryRanges ( GetDevice, 1, &flush_range );

			vk.UnmapMemory ( GetDevice, Vulkan.StagingBuffer.Memory );

			// Prepare command buffer to copy data from staging buffer to a vertex buffer
			var command_buffer_begin_info = new CommandBufferBeginInfo
			{
				sType = StructureType.CommandBufferBeginInfo,         // VkStructureType                        sType
				pNext = IntPtr.Zero,                                  // const void                            *pNext
				flags = CommandBufferUsageFlagBits.OneTimeSubmitBit,        // VkCommandBufferUsageFlagBits              flags
				pInheritanceInfo = (CommandBufferInheritanceInfo*)0   // const VkCommandBufferInheritanceInfo  *pInheritanceInfo
			};

			CommandBuffer command_buffer = Vulkan.RenderingResources[0].CommandBuffer;

			vk.BeginCommandBuffer ( command_buffer, ref command_buffer_begin_info );

			var buffer_copy_info = new BufferCopy
			{
				sourceOffset = 0,                   // VkDeviceSize                           srcOffset
				destinationOffset = 0,              // VkDeviceSize                           dstOffset
				size = Vulkan.VertexBuffer.Size     // VkDeviceSize                           size
			};
			vk.CmdCopyBuffer ( command_buffer, Vulkan.StagingBuffer.Handle, Vulkan.VertexBuffer.Handle, 1, &buffer_copy_info );

			var buffer_memory_barrier = new BufferMemoryBarrier
			{
				sType = StructureType.BufferMemoryBarrier,                       // VkStructureType                        sType
				pNext = IntPtr.Zero,                                             // const void                            *pNext
				sourceAccessMask = AccessFlagBits.MemoryWriteBit,                      // VkAccessFlagBits                          srcAccessMask
				destinationAccessMask = AccessFlagBits.VertexAttributeReadBit,         // VkAccessFlagBits                          dstAccessMask
				sourceQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,       // uint32_t                               srcQueueFamilyIndex
				destinationQueueFamilyIndex = (~0U)/*VK_QUEUE_FAMILY_IGNORED*/,  // uint32_t                               dstQueueFamilyIndex
				buffer = Vulkan.VertexBuffer.Handle,                             // VkBuffer                               buffer
				offset = 0,                                                      // VkDeviceSize                           offset
				size = (~0UL)/*VK_WHOLE_SIZE*/                                   // VkDeviceSize                           size
			};
			vk.CmdPipelineBarrier ( command_buffer,
				PipelineStageFlagBits.TransferBit,
				PipelineStageFlagBits.VertexInputBit,
				(DependencyFlagBits)0,
				0, (MemoryBarrier*)0,
				1, &buffer_memory_barrier,
				0, (ImageMemoryBarrier*)0
			);

			vk.EndCommandBuffer ( command_buffer );

			// Submit command buffer and copy data from staging buffer to a vertex buffer
			var submit_info = new SubmitInfo
			{
				sType = StructureType.SubmitInfo,                    // VkStructureType                        sType
				pNext = IntPtr.Zero,                                 // const void                            *pNext
				waitSemaphoreCount = 0,                              // uint32_t                               waitSemaphoreCount
				pWaitSemaphores = (Semaphore*)0,                     // const VkSemaphore                     *pWaitSemaphores
				pWaitDestinationStageMask = (PipelineStageFlagBits*)0,  // const VkPipelineStageFlagBits            *pWaitDstStageMask;
				commandBufferCount = 1,                              // uint32_t                               commandBufferCount
				pCommandBuffers = &command_buffer,                   // const VkCommandBuffer                 *pCommandBuffers
				signalSemaphoreCount = 0,                            // uint32_t                               signalSemaphoreCount
				pSignalSemaphores = (Semaphore*)0                    // const VkSemaphore                     *pSignalSemaphores
			};

			vk.QueueSubmit ( GetGraphicsQueue.Handle, 1, &submit_info, default ( Fence ) ).CheckError ();

			vk.DeviceWaitIdle ( GetDevice );
		}

		void PrepareFrame(CommandBuffer command_buffer, ref ImageParameters image_parameters, ref Framebuffer framebuffer)
		{
			CreateFramebuffer ( ref framebuffer, image_parameters.View );

			var command_buffer_begin_info = new CommandBufferBeginInfo
			{
				sType = StructureType.CommandBufferBeginInfo,        // VkStructureType                        sType
				pNext = IntPtr.Zero,                                 // const void                            *pNext
				flags = CommandBufferUsageFlagBits.OneTimeSubmitBit,       // VkCommandBufferUsageFlagBits              flags
				pInheritanceInfo = (CommandBufferInheritanceInfo*)0  // const VkCommandBufferInheritanceInfo  *pInheritanceInfo
			};


			vk.BeginCommandBuffer ( command_buffer, ref command_buffer_begin_info ).CheckError ();

			var image_subresource_range = new ImageSubresourceRange
			{
				aspectMask = ImageAspectFlagBits.ColorBit,    // VkImageAspectFlagBits                     aspectMask
				baseMipLevel = 0,                       // uint32_t                               baseMipLevel
				levelCount = 1,                         // uint32_t                               levelCount
				baseArrayLayer = 0,                     // uint32_t                               baseArrayLayer
				layerCount = 1                          // uint32_t                               layerCount
			};

			uint present_queue_family_index = (GetPresentQueue.Handle != GetGraphicsQueue.Handle) ? GetPresentQueue.FamilyIndex : (~0U)/*VK_QUEUE_FAMILY_IGNORED*/;
			uint graphics_queue_family_index = (GetPresentQueue.Handle != GetGraphicsQueue.Handle) ? GetGraphicsQueue.FamilyIndex : (~0U)/*VK_QUEUE_FAMILY_IGNORED*/;
			var barrier_from_present_to_draw = new ImageMemoryBarrier
			{
				sType = StructureType.ImageMemoryBarrier,                     // VkStructureType                        sType
				pNext = IntPtr.Zero,                                          // const void                            *pNext
				sourceAccessMask = AccessFlagBits.MemoryReadBit,                    // VkAccessFlagBits                          srcAccessMask
				destinationAccessMask = AccessFlagBits.ColorAttachmentWriteBit,     // VkAccessFlagBits                          dstAccessMask
				oldLayout = ImageLayout.Undefined,                            // VkImageLayout                          oldLayout
				newLayout = ImageLayout.ColorAttachmentOptimal,               // VkImageLayout                          newLayout
				sourceQueueFamilyIndex = present_queue_family_index,          // uint32_t                               srcQueueFamilyIndex
				destinationQueueFamilyIndex = graphics_queue_family_index,    // uint32_t                               dstQueueFamilyIndex
				image = image_parameters.Handle,                              // VkImage                                image
				subresourceRange = image_subresource_range                    // VkImageSubresourceRange                subresourceRange
			};

			vk.CmdPipelineBarrier (
				command_buffer,
				PipelineStageFlagBits.ColorAttachmentOutputBit,
				PipelineStageFlagBits.ColorAttachmentOutputBit,
				(DependencyFlagBits)0,
				0, (MemoryBarrier*)0,
				0, (BufferMemoryBarrier*)0,
				1, &barrier_from_present_to_draw
			);

			var clear_value = new ClearValue ( new ClearColorValue ( 1.0f, 0.8f, 0.4f, 0.0f ) );

			var render_pass_begin_info = new RenderPassBeginInfo
			{
				sType = StructureType.RenderPassBeginInfo,                            // VkStructureType                        sType
				pNext = IntPtr.Zero,                                                  // const void                            *pNext
				renderPass = Vulkan.RenderPass,                                       // VkRenderPass                           renderPass
				framebuffer = framebuffer,                                            // VkFramebuffer                          framebuffer
				renderArea = new Rect2D ( new Offset2D (), GetSwapChain.Extent ),     // VkRect2D                               renderArea
				clearValueCount = 1,                                                  // uint32_t                               clearValueCount
				pClearValues = &clear_value                                           // const VkClearValue                    *pClearValues
			};

			vk.CmdBeginRenderPass ( command_buffer, ref render_pass_begin_info, SubpassContents.Inline );

			vk.CmdBindPipeline ( command_buffer, PipelineBindPoint.Graphics, Vulkan.GraphicsPipeline );

			var viewport = new Viewport (
				0.0f,                          // float                                  x
				0.0f,                          // float                                  y
				GetSwapChain.Extent.width,     // float                                  width
				GetSwapChain.Extent.height,    // float                                  height
				0.0f,                          // float                                  minDepth
				1.0f                           // float                                  maxDepth
			);

			Rect2D scissor = new Rect2D ( new Offset2D (), GetSwapChain.Extent );

			vk.CmdSetViewport ( command_buffer, 0, 1, &viewport );

			vk.CmdSetScissor ( command_buffer, 0, 1, &scissor );

			var buffer = Vulkan.VertexBuffer.Handle;
			ulong offset = 0;
			vk.CmdBindVertexBuffers ( command_buffer, 0, 1, &buffer, &offset );

			var desSet = Vulkan.DescriptorSet.Handle;
			vk.CmdBindDescriptorSets ( command_buffer, PipelineBindPoint.Graphics, Vulkan.PipelineLayout, 0, 1, &desSet, 0, (uint*)0 );

			vk.CmdDraw ( command_buffer, 4, 1, 0, 0 );

			vk.CmdEndRenderPass ( command_buffer );

			var barrier_from_draw_to_present = new ImageMemoryBarrier
			{
				sType = StructureType.ImageMemoryBarrier,                   // VkStructureType                        sType
				pNext = IntPtr.Zero,                                        // const void                            *pNext
				sourceAccessMask = AccessFlagBits.ColorAttachmentWriteBit,        // VkAccessFlagBits                          srcAccessMask
				destinationAccessMask = AccessFlagBits.MemoryReadBit,             // VkAccessFlagBits                          dstAccessMask
				oldLayout = ImageLayout.ColorAttachmentOptimal,             // VkImageLayout                          oldLayout
				newLayout = ImageLayout.PresentSourceKhr,                   // VkImageLayout                          newLayout
				sourceQueueFamilyIndex = graphics_queue_family_index,       // uint32_t                               srcQueueFamilyIndex
				destinationQueueFamilyIndex = present_queue_family_index,   // uint32_t                               dstQueueFamilyIndex
				image = image_parameters.Handle,                            // VkImage                                image
				subresourceRange = image_subresource_range                  // VkImageSubresourceRange                subresourceRange
			};

			vk.CmdPipelineBarrier ( command_buffer,
				PipelineStageFlagBits.ColorAttachmentOutputBit,
				PipelineStageFlagBits.BottomOfPipeBit,
				(DependencyFlagBits)0,
				0, (MemoryBarrier*)0,
				0, (BufferMemoryBarrier*)0,
				1, &barrier_from_draw_to_present );

			vk.EndCommandBuffer ( command_buffer ).CheckError ();
		}

		void CreateFramebuffer(ref Framebuffer framebuffer, ImageView image_view)
		{
			if ( !framebuffer.IsZero )
			{
				vk.DestroyFramebuffer ( GetDevice, framebuffer );
				framebuffer = new Framebuffer ();
			}

			var framebuffer_create_info = new FramebufferCreateInfo
			{
				sType = StructureType.FramebufferCreateInfo,  // VkStructureType                sType
				pNext = IntPtr.Zero,                          // const void                    *pNext
				flags = 0,                                    // VkFramebufferCreateFlagBits       flags
				renderPass = Vulkan.RenderPass,               // VkRenderPass                   renderPass
				attachmentCount = 1,                          // uint32_t                       attachmentCount
				pAttachments = &image_view,                   // const VkImageView             *pAttachments
				width = GetSwapChain.Extent.width,            // uint32_t                       width
				height = GetSwapChain.Extent.height,          // uint32_t                       height
				layers = 1                                    // uint32_t                       layers
			};

			vk.CreateFramebuffer ( GetDevice, ref framebuffer_create_info, (AllocationCallbacks*)0, out framebuffer );
		}

		static int resource_index = 0;

		public override void Draw()
		{
			var idx = resource_index;
			var current_rendering_resource = Vulkan.RenderingResources[idx];
			SwapchainKHR swap_chain = GetSwapChain.Handle;
			uint image_index;

			resource_index = (resource_index + 1) % VulkanTutorial04Parameters.ResourcesCount;

			vk.WaitForFences ( GetDevice, 1, &current_rendering_resource.Fence, false, 1000000000 ).CheckError ();
			vk.ResetFences ( GetDevice, 1, &current_rendering_resource.Fence );

			Result result = khrSwapChain.AcquireNextImageKHR ( GetDevice, swap_chain, ulong.MaxValue, current_rendering_resource.ImageAvailableSemaphore, default ( Fence ), out image_index );
			switch ( result )
			{
				case Result.Success:
				case Result.SuboptimalKhr:
					break;
				case Result.ErrorOutOfDateKhr:
					OnWindowSizeChanged ();
					return;
				default:
					//std::cout << "Problem occurred during swap chain image acquisition!" << std::endl;
					return;
			}

			PrepareFrame ( current_rendering_resource.CommandBuffer, ref GetSwapChain.Images[image_index], ref Vulkan.RenderingResources[idx].Framebuffer );

			current_rendering_resource = Vulkan.RenderingResources[idx];

			PipelineStageFlagBits wait_dst_stage_mask = PipelineStageFlagBits.ColorAttachmentOutputBit;
			SubmitInfo submit_info = new SubmitInfo
			{
				sType = StructureType.SubmitInfo,                                           // VkStructureType              sType
				pNext = IntPtr.Zero,                                                        // const void                  *pNext
				waitSemaphoreCount = 1,                                                     // uint32_t                     waitSemaphoreCount
				pWaitSemaphores = &current_rendering_resource.ImageAvailableSemaphore,      // const VkSemaphore           *pWaitSemaphores
				pWaitDestinationStageMask = &wait_dst_stage_mask,                           // const VkPipelineStageFlagBits  *pWaitDstStageMask;
				commandBufferCount = 1,                                                     // uint32_t                     commandBufferCount
				pCommandBuffers = &current_rendering_resource.CommandBuffer,                // const VkCommandBuffer       *pCommandBuffers
				signalSemaphoreCount = 1,                                                   // uint32_t                     signalSemaphoreCount
				pSignalSemaphores = &current_rendering_resource.FinishedRenderingSemaphore  // const VkSemaphore           *pSignalSemaphores
			};

			vk.QueueSubmit ( GetGraphicsQueue.Handle, 1, &submit_info, current_rendering_resource.Fence ).CheckError ();

			var present_info = new PresentInfoKHR
			{
				sType = StructureType.PresentInfoKhr,                                      // VkStructureType              sType
				pNext = IntPtr.Zero,                                                       // const void                  *pNext
				waitSemaphoreCount = 1,                                                    // uint32_t                     waitSemaphoreCount
				pWaitSemaphores = &current_rendering_resource.FinishedRenderingSemaphore,  // const VkSemaphore           *pWaitSemaphores
				swapchainCount = 1,                                                        // uint32_t                     swapchainCount
				pSwapchains = &swap_chain,                                                 // const VkSwapchainKHR        *pSwapchains
				pImageIndices = &image_index,                                              // const uint32_t              *pImageIndices
				pResults = (Result*)0                                                      // VkResult                    *pResults
			};

			result = khrSwapChain.QueuePresentKHR ( GetPresentQueue.Handle, ref present_info );

			switch ( result )
			{
				case Result.Success:
					break;
				case Result.ErrorOutOfDateKhr:
				case Result.SuboptimalKhr:
					OnWindowSizeChanged ();
					return;
				default:
					//std::cout << "Problem occurred during image presentation!" << std::endl;
					return;
			}
		}

		public override void Dispose()
		{
			if ( !GetDevice.IsZero )
			{
				vk.DeviceWaitIdle ( GetDevice );

				for ( int i = 0; i < Vulkan.RenderingResources.Length; ++i )
				{
					if ( !Vulkan.RenderingResources[i].Framebuffer.IsZero )
					{
						vk.DestroyFramebuffer ( GetDevice, Vulkan.RenderingResources[i].Framebuffer );
					}
					if ( !Vulkan.RenderingResources[i].CommandBuffer.IsZero )
					{
						var cb = Vulkan.RenderingResources[i].CommandBuffer;
						vk.FreeCommandBuffers ( GetDevice, Vulkan.CommandPool, 1, &cb );
					}
					if ( !Vulkan.RenderingResources[i].ImageAvailableSemaphore.IsZero )
					{
						vk.DestroySemaphore ( GetDevice, Vulkan.RenderingResources[i].ImageAvailableSemaphore );
					}
					if ( !Vulkan.RenderingResources[i].FinishedRenderingSemaphore.IsZero )
					{
						vk.DestroySemaphore ( GetDevice, Vulkan.RenderingResources[i].FinishedRenderingSemaphore );
					}
					if ( !Vulkan.RenderingResources[i].Fence.IsZero )
					{
						vk.DestroyFence ( GetDevice, Vulkan.RenderingResources[i].Fence );
					}
				}

				if ( !Vulkan.CommandPool.IsZero )
				{
					vk.DestroyCommandPool ( GetDevice, Vulkan.CommandPool );
					Vulkan.CommandPool = new CommandPool ();
				}

				DestroyBuffer ( ref Vulkan.VertexBuffer );

				DestroyBuffer ( ref Vulkan.StagingBuffer );

				if ( !Vulkan.GraphicsPipeline.IsZero )
				{
					vk.DestroyPipeline ( GetDevice, Vulkan.GraphicsPipeline );
					Vulkan.GraphicsPipeline = new Pipeline ();
				}

				if ( !Vulkan.PipelineLayout.IsZero )
				{
					vk.DestroyPipelineLayout ( GetDevice, Vulkan.PipelineLayout );
					Vulkan.PipelineLayout = new PipelineLayout ();
				}

				if ( !Vulkan.RenderPass.IsZero )
				{
					vk.DestroyRenderPass ( GetDevice, Vulkan.RenderPass );
					Vulkan.RenderPass = new RenderPass ();
				}

				if ( !Vulkan.DescriptorSet.Pool.IsZero )
				{
					vk.DestroyDescriptorPool ( GetDevice, Vulkan.DescriptorSet.Pool );
					Vulkan.DescriptorSet.Pool = new DescriptorPool ();
				}

				if ( !Vulkan.DescriptorSet.Layout.IsZero )
				{
					vk.DestroyDescriptorSetLayout ( GetDevice, Vulkan.DescriptorSet.Layout );
					Vulkan.DescriptorSet.Layout = new DescriptorSetLayout ();
				}

				if ( !Vulkan.Image.Sampler.IsZero )
				{
					vk.DestroySampler ( GetDevice, Vulkan.Image.Sampler );
					Vulkan.Image.Sampler = new Sampler ();
				}

				if ( !Vulkan.Image.View.IsZero )
				{
					vk.DestroyImageView ( GetDevice, Vulkan.Image.View );
					Vulkan.Image.View = new ImageView ();
				}

				if ( !Vulkan.Image.Handle.IsZero )
				{
					vk.DestroyImage ( GetDevice, Vulkan.Image.Handle );
					Vulkan.Image.Handle = new Image ();
				}

				if ( !Vulkan.Image.Memory.IsZero )
				{
					vk.FreeMemory ( GetDevice, Vulkan.Image.Memory );
					Vulkan.Image.Memory = new DeviceMemory ();
				}
			}

			base.Dispose ();
		}

		void DestroyBuffer(ref BufferParameters buffer)
		{
			if ( !buffer.Handle.IsZero )
			{
				vk.DestroyBuffer ( GetDevice, buffer.Handle );
				buffer.Handle = new Crow.Graphics.Vulkan.Buffer ();
			}
			if ( !buffer.Memory.IsZero )
			{
				vk.FreeMemory ( GetDevice, buffer.Memory );
				buffer.Memory = new DeviceMemory ();
			}
		}
	}
}
