using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Crow.Graphics.Vulkan;
using Crow.Win32;

namespace TestConsole.VulkanTutorial
{
	// ************************************************************ //
	// VulkanTutorial03Parameters                                   //
	//                                                              //
	// Vulkan specific parameters                                   //
	// ************************************************************ //
	struct VulkanTutorial03Parameters
	{
		public RenderPass RenderPass;
		public Framebuffer[] Framebuffers;
		public Pipeline GraphicsPipeline;
		public Semaphore ImageAvailableSemaphore;
		public Semaphore RenderingFinishedSemaphore;
		public CommandPool GraphicsCommandPool;
		public CommandBuffer[] GraphicsCommandBuffers;
	}

	unsafe class Tutorial03 : VulkanCommon
	{
		VulkanTutorial03Parameters Vulkan;


		public void Init()
		{
			CreateRenderPass ();
			CreateFramebuffers ();
			CreatePipeline ();
			CreateSemaphores ();
			CreateCommandBuffers ();
			RecordCommandBuffers ();
		}

		void CreateRenderPass()
		{
			var attachment_descriptions = new AttachmentDescription
			{
				flags = (AttachmentDescriptionFlagBits)0,                  // VkAttachmentDescriptionFlagBits   flags
				format = GetSwapChain.Format,                              // VkFormat                       format
				samples = SampleCountFlagBits._1Bit,                          // VkSampleCountFlagBits          samples
				loadOperation = AttachmentLoadOperation.Clear,             // VkAttachmentLoadOp             loadOp
				storeOperation = AttachmentStoreOperation.Store,           // VkAttachmentStoreOp            storeOp
				stencilLoadOperation = AttachmentLoadOperation.DontCare,   // VkAttachmentLoadOp             stencilLoadOp
				stencilStoreOperation = AttachmentStoreOperation.DontCare, // VkAttachmentStoreOp            stencilStoreOp
				initialLayout = ImageLayout.Undefined,                     // VkImageLayout                  initialLayout;
				finalLayout = ImageLayout.PresentSourceKhr                 // VkImageLayout                  finalLayout
			};

			var color_attachment_references = new AttachmentReference
			{
				attachment = 0,                                            // uint32_t                       attachment
				layout = ImageLayout.ColorAttachmentOptimal                // VkImageLayout                  layout
			};

			var subpass_descriptions = new SubpassDescription
			{
				flags = 0,                                         // VkSubpassDescriptionFlagBits      flags
				pipelineBindPoint = PipelineBindPoint.Graphics,    // VkPipelineBindPoint            pipelineBindPoint
				inputAttachmentCount = 0,                          // uint32_t                       inputAttachmentCount
				pInputAttachments = (AttachmentReference*)0,       // const VkAttachmentReference   *pInputAttachments
				colorAttachmentCount = 1,                          // uint32_t                       colorAttachmentCount
				pColorAttachments = &color_attachment_references,  // const VkAttachmentReference   *pColorAttachments
				pResolveAttachments = (AttachmentReference*)0,     // const VkAttachmentReference   *pResolveAttachments
				pDepthStencilAttachment = (AttachmentReference*)0, // const VkAttachmentReference   *pDepthStencilAttachment
				preserveAttachmentCount = 0,                       // uint32_t                       preserveAttachmentCount
				pPreserveAttachments = (uint*)0                    // const uint32_t*                pPreserveAttachments
			};

			var render_pass_create_info = new RenderPassCreateInfo
			{
				sType = StructureType.RenderPassCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                        // const void                    *pNext
				flags = 0,                                  // VkRenderPassCreateFlagBits        flags
				attachmentCount = 1,                        // uint32_t                       attachmentCount
				pAttachments = &attachment_descriptions,    // const VkAttachmentDescription *pAttachments
				subpassCount = 1,                           // uint32_t                       subpassCount
				pSubpasses = &subpass_descriptions,         // const VkSubpassDescription    *pSubpasses
				dependencyCount = 0,                        // uint32_t                       dependencyCount
				pDependencies = (SubpassDependency*)0       // const VkSubpassDependency     *pDependencies
			};

			vk.CreateRenderPass ( GetDevice, ref render_pass_create_info, (AllocationCallbacks*)0, out Vulkan.RenderPass ).CheckError ();
		}

		void CreateFramebuffers()
		{
			var swap_chain_images = GetSwapChain.Images;
			Vulkan.Framebuffers = new Framebuffer[swap_chain_images.Length];

			for ( int i = 0; i < swap_chain_images.Length; ++i )
			{
				ImageView view = swap_chain_images[i].View;

				var framebuffer_create_info = new FramebufferCreateInfo
				{
					sType = StructureType.FramebufferCreateInfo, // VkStructureType                sType
					pNext = IntPtr.Zero,                         // const void                    *pNext
					flags = 0,                                   // VkFramebufferCreateFlagBits       flags
					renderPass = Vulkan.RenderPass,              // VkRenderPass                   renderPass
					attachmentCount = 1,                         // uint32_t                       attachmentCount
					pAttachments = &view,                        // const VkImageView             *pAttachments
					width = 300,                                 // uint32_t                       width
					height = 300,                                // uint32_t                       height
					layers = 1                                   // uint32_t                       layers
				};

				vk.CreateFramebuffer ( GetDevice, ref framebuffer_create_info, (AllocationCallbacks*)0, out Vulkan.Framebuffers[i] ).CheckError ();
			}
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

		PipelineLayout CreatePipelineLayout()
		{
			var layout_create_info = new PipelineLayoutCreateInfo
			{
				sType = StructureType.PipelineLayoutCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                            // const void                    *pNext
				flags = 0,                                      // VkPipelineLayoutCreateFlagBits    flags
				setLayoutCount = 0,                             // uint32_t                       setLayoutCount
				pSetLayouts = (DescriptorSetLayout*)0,          // const VkDescriptorSetLayout   *pSetLayouts
				pushConstantRangeCount = 0,                     // uint32_t                       pushConstantRangeCount
				pPushConstantRanges = (PushConstantRange*)0     // const VkPushConstantRange     *pPushConstantRanges
			};

			PipelineLayout pipeline_layout;
			vk.CreatePipelineLayout ( GetDevice, ref layout_create_info, (AllocationCallbacks*)0, out pipeline_layout ).CheckError ();
			return pipeline_layout;
		}

		void CreatePipeline()
		{
			ShaderModule vertex_shader_module = CreateShaderModule ( "assets/shader03.vert.spv" );
			ShaderModule fragment_shader_module = CreateShaderModule ( "assets/shader03.frag.spv" );

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

			var vertex_input_state_create_info = new PipelineVertexInputStateCreateInfo
			{
				sType = StructureType.PipelineVertexInputStateCreateInfo,           // VkStructureType                                sType
				pNext = IntPtr.Zero,                                                // const void                                    *pNext
				flags = 0,                                                          // VkPipelineVertexInputStateCreateFlagBits          flags;
				vertexBindingDescriptionCount = 0,                                  // uint32_t                                       vertexBindingDescriptionCount
				pVertexBindingDescriptions = (VertexInputBindingDescription*)0,     // const VkVertexInputBindingDescription         *pVertexBindingDescriptions
				vertexAttributeDescriptionCount = 0,                                // uint32_t                                       vertexAttributeDescriptionCount
				pVertexAttributeDescriptions = (VertexInputAttributeDescription*)0  // const VkVertexInputAttributeDescription       *pVertexAttributeDescriptions
			};

			var input_assembly_state_create_info = new PipelineInputAssemblyStateCreateInfo
			{
				sType = StructureType.PipelineInputAssemblyStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                        // const void                                    *pNext
				flags = 0,                                                  // VkPipelineInputAssemblyStateCreateFlagBits        flags
				topology = PrimitiveTopology.TriangleList,                  // VkPrimitiveTopology                            topology
				primitiveRestartEnable = false                              // VkBool32                                       primitiveRestartEnable
			};

			Viewport viewport = new Viewport
			{
				x = 0.0f,               // float       x
				y = 0.0f,               // float       y
				width = 300.0f,         // float       width
				height = 300.0f,        // float       height
				minDepth = 0.0f,        // float       minDepth
				maxDepth = 1.0f         // float       maxDepth
			};

			Rect2D scissor = new Rect2D
			{
				offset = new Offset2D
				{                       // VkOffset2D  offset
					x = 0,               // int32_t     x
					y = 0                // int32_t     y
				},
				extent = new Extent2D
				{                       // VkExtent2D  extent
					width = 300,         // int32_t     width
					height = 300         // int32_t     height
				}
			};

			var viewport_state_create_info = new PipelineViewportStateCreateInfo
			{
				sType = StructureType.PipelineViewportStateCreateInfo, // VkStructureType                                sType
				pNext = IntPtr.Zero,                                   // const void                                    *pNext
				flags = 0,                                             // VkPipelineViewportStateCreateFlagBits             flags
				viewportCount = 1,                                     // uint32_t                                       viewportCount
				pViewports = &viewport,                                // const VkViewport                              *pViewports
				scissorCount = 1,                                      // uint32_t                                       scissorCount
				pScissors = &scissor                                   // const VkRect2D                                *pScissors
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

			var pipeline_layout = CreatePipelineLayout ();

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
				pDynamicState = (PipelineDynamicStateCreateInfo*)0,           // const VkPipelineDynamicStateCreateInfo        *pDynamicState
				layout = pipeline_layout,                                     // VkPipelineLayout                               layout
				renderPass = Vulkan.RenderPass,                               // VkRenderPass                                   renderPass
				subpass = 0,                                                  // uint32_t                                       subpass
				basePipelineHandle = default ( Pipeline ),                    // VkPipeline                                     basePipelineHandle
				basePipelineIndex = -1                                        // int32_t                                        basePipelineIndex
			};

			vk.CreateGraphicsPipelines ( GetDevice, default ( PipelineCache ), 1, &pipeline_create_info, (AllocationCallbacks*)0, out Vulkan.GraphicsPipeline ).CheckError ();

			Marshal.FreeHGlobal ( (IntPtr)shader_stage_create_infos[0].pName );
			Marshal.FreeHGlobal ( (IntPtr)shader_stage_create_infos[1].pName );
		}

		void CreateSemaphores()
		{
			var semaphore_create_info = new SemaphoreCreateInfo
			{
				sType = StructureType.SemaphoreCreateInfo,
				pNext = IntPtr.Zero,
				flags = 0,
			};

			vk.CreateSemaphore ( GetDevice, ref semaphore_create_info, (AllocationCallbacks*)0, out Vulkan.ImageAvailableSemaphore ).CheckError ();
			vk.CreateSemaphore ( GetDevice, ref semaphore_create_info, (AllocationCallbacks*)0, out Vulkan.RenderingFinishedSemaphore ).CheckError ();
		}

		void CreateCommandBuffers()
		{
			CreateCommandPool ( GetGraphicsQueue.FamilyIndex, out Vulkan.GraphicsCommandPool );

			uint image_count = (uint)GetSwapChain.Images.Length;

			Vulkan.GraphicsCommandBuffers = new CommandBuffer[image_count];

			AllocateCommandBuffers ( Vulkan.GraphicsCommandPool, Vulkan.GraphicsCommandBuffers );
		}

		void CreateCommandPool(uint queue_family_index, out CommandPool pool)
		{
			var cmd_pool_create_info = new CommandPoolCreateInfo
			{
				sType = StructureType.CommandPoolCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                         // const void                    *pNext
				flags = 0,                                   // VkCommandPoolCreateFlagBits       flags
				queueFamilyIndex = queue_family_index        // uint32_t                       queueFamilyIndex
			};

			vk.CreateCommandPool ( GetDevice, ref cmd_pool_create_info, (AllocationCallbacks*)0, out pool ).CheckError ();
		}

		void AllocateCommandBuffers(CommandPool pool, CommandBuffer[] command_buffers)
		{
			var command_buffer_allocate_info = new CommandBufferAllocateInfo
			{
				sType = StructureType.CommandBufferAllocateInfo,  // VkStructureType                sType
				pNext = IntPtr.Zero,                              // const void                    *pNext
				commandPool = pool,                               // VkCommandPool                  commandPool
				level = CommandBufferLevel.Primary,               // VkCommandBufferLevel           level
				commandBufferCount = (uint)command_buffers.Length // uint32_t                       bufferCount
			};

			fixed ( CommandBuffer* ptr = command_buffers )
				vk.AllocateCommandBuffers ( GetDevice, ref command_buffer_allocate_info, ptr );
		}


		void RecordCommandBuffers()
		{
			var graphics_commandd_buffer_begin_info = new CommandBufferBeginInfo
			{
				sType = StructureType.CommandBufferBeginInfo,        // VkStructureType                        sType
				pNext = IntPtr.Zero,                                 // const void                            *pNext
				flags = CommandBufferUsageFlagBits.SimultaneousUseBit,     // VkCommandBufferUsageFlagBits              flags
				pInheritanceInfo = (CommandBufferInheritanceInfo*)0  // const VkCommandBufferInheritanceInfo  *pInheritanceInfo
			};

			var image_subresource_range = new ImageSubresourceRange
			{
				aspectMask = ImageAspectFlagBits.ColorBit, // VkImageAspectFlagBits             aspectMask
				baseMipLevel = 0,                    // uint32_t                       baseMipLevel
				layerCount = 1,                      // uint32_t                       levelCount
				baseArrayLayer = 0,                  // uint32_t                       baseArrayLayer
				levelCount = 1                       // uint32_t                       layerCount
			};

			var clear_value = new ClearValue
			{
				color = new ClearColorValue ( 1.0f, 0.8f, 0.4f, 0.0f ), // VkClearColorValue              color
			};

			ImageParameters[] swap_chain_images = GetSwapChain.Images;

			for ( int i = 0; i < Vulkan.GraphicsCommandBuffers.Length; ++i )
			{
				vk.BeginCommandBuffer ( Vulkan.GraphicsCommandBuffers[i], ref graphics_commandd_buffer_begin_info ).CheckError ();

				if ( GetPresentQueue.Handle != GetGraphicsQueue.Handle )
				{
					var barrier_from_present_to_draw = new ImageMemoryBarrier
					{
						sType = StructureType.ImageMemoryBarrier,                   // VkStructureType                sType
						pNext = IntPtr.Zero,                                        // const void                    *pNext
						sourceAccessMask = AccessFlagBits.MemoryReadBit,                  // VkAccessFlagBits                  srcAccessMask
						destinationAccessMask = AccessFlagBits.ColorAttachmentWriteBit,   // VkAccessFlagBits                  dstAccessMask
						oldLayout = ImageLayout.Undefined,                          // VkImageLayout                  oldLayout
						newLayout = ImageLayout.PresentSourceKhr,                   // VkImageLayout                  newLayout
						sourceQueueFamilyIndex = GetPresentQueue.FamilyIndex,       // uint32_t                       srcQueueFamilyIndex
						destinationQueueFamilyIndex = GetGraphicsQueue.FamilyIndex, // uint32_t                       dstQueueFamilyIndex
						image = swap_chain_images[i].Handle,                        // VkImage                        image
						subresourceRange = image_subresource_range                  // VkImageSubresourceRange        subresourceRange
					};
					vk.CmdPipelineBarrier (
						Vulkan.GraphicsCommandBuffers[i],
						PipelineStageFlagBits.ColorAttachmentOutputBit,
						PipelineStageFlagBits.ColorAttachmentOutputBit,
						(DependencyFlagBits)0,
						0, (MemoryBarrier*)0,
						0, (BufferMemoryBarrier*)0,
						1, &barrier_from_present_to_draw );
				}

				var render_pass_begin_info = new RenderPassBeginInfo
				{
					sType = StructureType.RenderPassBeginInfo, // VkStructureType                sType
					pNext = IntPtr.Zero,                       // const void                    *pNext
					renderPass = Vulkan.RenderPass,            // VkRenderPass                   renderPass
					framebuffer = Vulkan.Framebuffers[i],      // VkFramebuffer                  framebuffer
					renderArea = new Rect2D
					{                                          // VkRect2D                       renderArea
						offset = new Offset2D
						{                                       // VkOffset2D                     offset
							x = 0,                               // int32_t                        x
							y = 0                                // int32_t                        y
						},
						extent = new Extent2D
						{                                       // VkExtent2D                     extent
							width = 300,                         // int32_t                        width
							height = 300,                        // int32_t                        height
						}
					},
					clearValueCount = 1,                       // uint32_t                       clearValueCount
					pClearValues = &clear_value                // const VkClearValue            *pClearValues
				};

				vk.CmdBeginRenderPass ( Vulkan.GraphicsCommandBuffers[i], ref render_pass_begin_info, SubpassContents.Inline );

				vk.CmdBindPipeline ( Vulkan.GraphicsCommandBuffers[i], PipelineBindPoint.Graphics, Vulkan.GraphicsPipeline );

				vk.CmdDraw ( Vulkan.GraphicsCommandBuffers[i], 3, 1, 0, 0 );

				vk.CmdEndRenderPass ( Vulkan.GraphicsCommandBuffers[i] );

				if ( GetGraphicsQueue.Handle != GetPresentQueue.Handle )
				{
					var barrier_from_draw_to_present = new ImageMemoryBarrier
					{
						sType = StructureType.ImageMemoryBarrier,                  // VkStructureType              sType
						pNext = IntPtr.Zero,                                       // const void                  *pNext
						sourceAccessMask = AccessFlagBits.ColorAttachmentWriteBit,       // VkAccessFlagBits                srcAccessMask
						destinationAccessMask = AccessFlagBits.MemoryReadBit,            // VkAccessFlagBits                dstAccessMask
						oldLayout = ImageLayout.PresentSourceKhr,                  // VkImageLayout                oldLayout
						newLayout = ImageLayout.PresentSourceKhr,                  // VkImageLayout                newLayout
						sourceQueueFamilyIndex = GetGraphicsQueue.FamilyIndex,     // uint32_t                     srcQueueFamilyIndex
						destinationQueueFamilyIndex = GetPresentQueue.FamilyIndex, // uint32_t                     dstQueueFamilyIndex
						image = swap_chain_images[i].Handle,                       // VkImage                      image
						subresourceRange = image_subresource_range                 // VkImageSubresourceRange      subresourceRange
					};
					vk.CmdPipelineBarrier (
						Vulkan.GraphicsCommandBuffers[i],
						PipelineStageFlagBits.ColorAttachmentOutputBit,
						PipelineStageFlagBits.BottomOfPipeBit,
						(DependencyFlagBits)0,
						0, (MemoryBarrier*)0,
						0, (BufferMemoryBarrier*)0,
						1, &barrier_from_draw_to_present );
				}
				vk.EndCommandBuffer ( Vulkan.GraphicsCommandBuffers[i] ).CheckError ();
			}

		}

		protected override void ChildOnWindowSizeChanged()
		{
			CreateRenderPass ();
			CreateFramebuffers ();
			CreatePipeline ();
			CreateCommandBuffers ();
			RecordCommandBuffers ();

			base.ChildOnWindowSizeChanged ();
		}

		protected override void ChildClear()
		{
			if ( !GetDevice.IsZero )
			{
				vk.DeviceWaitIdle ( GetDevice );

				if ( Vulkan.GraphicsCommandBuffers != null
					&& Vulkan.GraphicsCommandBuffers.Length > 0
					&& !Vulkan.GraphicsCommandBuffers[0].IsZero )
				{
					fixed ( CommandBuffer* ptr = Vulkan.GraphicsCommandBuffers )
						vk.FreeCommandBuffers ( GetDevice, Vulkan.GraphicsCommandPool, (uint)Vulkan.GraphicsCommandBuffers.Length, ptr );
					Vulkan.GraphicsCommandBuffers = null;
				}

				if ( !Vulkan.GraphicsCommandPool.IsZero )
				{
					vk.DestroyCommandPool ( GetDevice, Vulkan.GraphicsCommandPool );
					Vulkan.GraphicsCommandPool = new CommandPool ();
				}

				if ( !Vulkan.GraphicsPipeline.IsZero )
				{
					vk.DestroyPipeline ( GetDevice, Vulkan.GraphicsPipeline );
					Vulkan.GraphicsPipeline = new Pipeline ();
				}

				if ( !Vulkan.RenderPass.IsZero )
				{
					vk.DestroyRenderPass ( GetDevice, Vulkan.RenderPass );
					Vulkan.RenderPass = new RenderPass ();
				}

				if ( Vulkan.Framebuffers != null )
				{
					for ( int i = 0; i < Vulkan.Framebuffers.Length; ++i )
					{
						if ( !Vulkan.Framebuffers[i].IsZero )
						{
							vk.DestroyFramebuffer ( GetDevice, Vulkan.Framebuffers[i] );
							Vulkan.Framebuffers[i] = new Framebuffer ();
						}
					}
					Vulkan.Framebuffers = null;
				}
			}

			base.ChildClear ();
		}


		public override void Draw()
		{
			SwapchainKHR swap_chain = GetSwapChain.Handle;
			uint image_index;

			var result = khrSwapChain.AcquireNextImageKHR ( GetDevice, swap_chain, ulong.MaxValue, Vulkan.ImageAvailableSemaphore, default ( Fence ), out image_index );
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

			var a = Vulkan.ImageAvailableSemaphore;
			var b = Vulkan.GraphicsCommandBuffers[image_index];
			var c = Vulkan.RenderingFinishedSemaphore;

			PipelineStageFlagBits wait_dst_stage_mask = PipelineStageFlagBits.ColorAttachmentOutputBit;
			var submit_info = new SubmitInfo
			{
				sType = StructureType.SubmitInfo,                  // VkStructureType              sType
				pNext = IntPtr.Zero,                               // const void                  *pNext
				waitSemaphoreCount = 1,                            // uint32_t                     waitSemaphoreCount
				pWaitSemaphores = &a,                              // const VkSemaphore           *pWaitSemaphores
				pWaitDestinationStageMask = &wait_dst_stage_mask,  // const VkPipelineStageFlagBits  *pWaitDstStageMask;
				commandBufferCount = 1,                            // uint32_t                     commandBufferCount
				pCommandBuffers = &b,                              // const VkCommandBuffer       *pCommandBuffers
				signalSemaphoreCount = 1,                          // uint32_t                     signalSemaphoreCount
				pSignalSemaphores = &c                             // const VkSemaphore           *pSignalSemaphores
			};

			vk.QueueSubmit ( GetGraphicsQueue.Handle, 1, &submit_info, default ( Fence ) ).CheckError ();

			var present_info = new PresentInfoKHR
			{
				sType = StructureType.PresentInfoKhr,  // VkStructureType              sType
				pNext = IntPtr.Zero,                   // const void                  *pNext
				waitSemaphoreCount = 1,                // uint32_t                     waitSemaphoreCount
				pWaitSemaphores = &c,                  // const VkSemaphore           *pWaitSemaphores
				swapchainCount = 1,                    // uint32_t                     swapchainCount
				pSwapchains = &swap_chain,             // const VkSwapchainKHR        *pSwapchains
				pImageIndices = &image_index,          // const uint32_t              *pImageIndices
				pResults = (Result*)0                  // VkResult                    *pResults
			};

			result = khrSwapChain.QueuePresentKHR ( GetPresentQueue.Handle, ref present_info );

			switch ( result )
			{
				case Result.Success:
					break;
				case Result.SuboptimalKhr:
				case Result.ErrorOutOfDateKhr:
					OnWindowSizeChanged ();
					return;
				default:
					//std::cout << "Problem occurred during image presentation!" << std::endl;
					return;
			}
		}

		public override void Dispose()
		{
			ChildClear ();

			if ( !GetDevice.IsZero )
			{
				vk.DeviceWaitIdle ( GetDevice );

				if ( !Vulkan.ImageAvailableSemaphore.IsZero )
				{
					vk.DestroySemaphore ( GetDevice, Vulkan.ImageAvailableSemaphore );
				}

				if ( !Vulkan.RenderingFinishedSemaphore.IsZero )
				{
					vk.DestroySemaphore ( GetDevice, Vulkan.RenderingFinishedSemaphore );
				}
			}

			base.Dispose ();
		}

	}
}
