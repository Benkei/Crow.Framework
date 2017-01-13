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
	// BufferParameters                                             //
	//                                                              //
	// Vulkan Buffer's parameters container class                   //
	// ************************************************************ //
	public struct BufferParameters
	{
		public Crow.Graphics.Vulkan.Buffer Handle;
		public DeviceMemory Memory;
		public uint Size;
	}

	// ************************************************************ //
	// VertexData                                                   //
	//                                                              //
	// Struct describing data type and format of vertex attributes  //
	// ************************************************************ //
	public struct VertexData
	{
		public float x, y, z, w;
		public float r, g, b, a;
		public VertexData(float x, float y, float z, float w, float r, float g, float b, float a)
		{
			this.x = x; this.y = y; this.z = z; this.w = w;
			this.r = r; this.g = g; this.b = b; this.a = a;
		}
	}

	// ************************************************************ //
	// RenderingResourcesData                                       //
	//                                                              //
	// Struct containing data used during rendering process         //
	// ************************************************************ //
	public struct RenderingResourcesData
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
	public struct VulkanTutorial04Parameters
	{
		public RenderPass RenderPass;
		public Pipeline GraphicsPipeline;
		public BufferParameters VertexBuffer;
		public CommandPool CommandPool;
		public RenderingResourcesData[] RenderingResources;

		public const int ResourcesCount = 3;
	}

	public unsafe class Tutorial04 : VulkanCommon
	{
		VulkanTutorial04Parameters Vulkan;

		public Tutorial04()
		{
			Vulkan.RenderingResources = new RenderingResourcesData[VulkanTutorial04Parameters.ResourcesCount];
		}

		public void Init()
		{
			CreateRenderPass ();
			CreatePipeline ();
			CreateVertexBuffer ();
			CreateRenderingResources ();
		}

		void CreateRenderPass()
		{
			var attachment_descriptions = stackalloc AttachmentDescription[1];
			attachment_descriptions[0] = new AttachmentDescription
			{
				flags = (AttachmentDescriptionFlagBits)0,                     // VkAttachmentDescriptionFlagBits   flags
				format = GetSwapChain.Format,                              // VkFormat                       format
				samples = SampleCountFlagBits._1Bit,                             // VkSampleCountFlagBits          samples
				loadOperation = AttachmentLoadOperation.Clear,             // VkAttachmentLoadOp             loadOp
				storeOperation = AttachmentStoreOperation.Store,           // VkAttachmentStoreOp            storeOp
				stencilLoadOperation = AttachmentLoadOperation.DontCare,   // VkAttachmentLoadOp             stencilLoadOp
				stencilStoreOperation = AttachmentStoreOperation.DontCare, // VkAttachmentStoreOp            stencilStoreOp
				initialLayout = ImageLayout.Undefined,                     // VkImageLayout                  initialLayout;
				finalLayout = ImageLayout.PresentSourceKhr                 // VkImageLayout                  finalLayout
			};

			var color_attachment_references = stackalloc AttachmentReference[1];
			color_attachment_references[0] = new AttachmentReference
			{
				attachment = 0,                                            // uint32_t                       attachment
				layout = ImageLayout.ColorAttachmentOptimal                // VkImageLayout                  layout
			};

			var subpass_descriptions = stackalloc SubpassDescription[1];
			subpass_descriptions[0] = new SubpassDescription
			{
				flags = 0,                                         // VkSubpassDescriptionFlagBits      flags
				pipelineBindPoint = PipelineBindPoint.Graphics,    // VkPipelineBindPoint            pipelineBindPoint
				inputAttachmentCount = 0,                          // uint32_t                       inputAttachmentCount
				pInputAttachments = (AttachmentReference*)0,       // const VkAttachmentReference   *pInputAttachments
				colorAttachmentCount = 1,                          // uint32_t                       colorAttachmentCount
				pColorAttachments = color_attachment_references,   // const VkAttachmentReference   *pColorAttachments
				pResolveAttachments = (AttachmentReference*)0,     // const VkAttachmentReference   *pResolveAttachments
				pDepthStencilAttachment = (AttachmentReference*)0, // const VkAttachmentReference   *pDepthStencilAttachment
				preserveAttachmentCount = 0,                       // uint32_t                       preserveAttachmentCount
				pPreserveAttachments = (uint*)0                    // const uint32_t*                pPreserveAttachments
			};

			var dependencies = stackalloc SubpassDependency[2];
			dependencies[0] = new SubpassDependency
			{
				sourceSubpass = unchecked((uint)Constant.SubpassExternal),        // uint32_t                       srcSubpass
				destinationSubpass = 0,                                           // uint32_t                       dstSubpass
				sourceStageMask = PipelineStageFlagBits.BottomOfPipeBit,                // VkPipelineStageFlagBits           srcStageMask
				destinationStageMask = PipelineStageFlagBits.ColorAttachmentOutputBit,  // VkPipelineStageFlagBits           dstStageMask
				sourceAccessMask = AccessFlagBits.MemoryReadBit,                        // VkAccessFlagBits                  srcAccessMask
				destinationAccessMask = AccessFlagBits.ColorAttachmentWriteBit,         // VkAccessFlagBits                  dstAccessMask
				dependencyFlags = DependencyFlagBits.ByRegionBit                        // VkDependencyFlagBits              dependencyFlags
			};
			dependencies[1] = new SubpassDependency
			{
				sourceSubpass = 0,                                              // uint32_t                       srcSubpass
				destinationSubpass = unchecked((uint)Constant.SubpassExternal), // uint32_t                       dstSubpass
				sourceStageMask = PipelineStageFlagBits.ColorAttachmentOutputBit,     // VkPipelineStageFlagBits           srcStageMask
				destinationStageMask = PipelineStageFlagBits.BottomOfPipeBit,         // VkPipelineStageFlagBits           dstStageMask
				sourceAccessMask = AccessFlagBits.ColorAttachmentWriteBit,            // VkAccessFlagBits                  srcAccessMask
				destinationAccessMask = AccessFlagBits.MemoryReadBit,                 // VkAccessFlagBits                  dstAccessMask
				dependencyFlags = DependencyFlagBits.ByRegionBit                      // VkDependencyFlagBits              dependencyFlags
			};

			var render_pass_create_info = new RenderPassCreateInfo
			{
				sType = StructureType.RenderPassCreateInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                        // const void                    *pNext
				flags = 0,                                  // VkRenderPassCreateFlagBits        flags
				attachmentCount = 1,                        // uint32_t                       attachmentCount
				pAttachments = attachment_descriptions,     // const VkAttachmentDescription *pAttachments
				subpassCount = 1,                           // uint32_t                       subpassCount
				pSubpasses = subpass_descriptions,          // const VkSubpassDescription    *pSubpasses
				dependencyCount = 2,                        // uint32_t                       dependencyCount
				pDependencies = dependencies                // const VkSubpassDependency     *pDependencies
			};

			vk.CreateRenderPass ( GetDevice, ref render_pass_create_info, (AllocationCallbacks*)0, out Vulkan.RenderPass ).CheckError ();
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
			ShaderModule vertex_shader_module = CreateShaderModule ( "assets/shader04.vert.spv" );
			ShaderModule fragment_shader_module = CreateShaderModule ( "assets/shader04.frag.spv" );

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
				binding = 0,                                   // uint32_t                                       binding
				stride = (uint)Marshal.SizeOf<VertexData> (),  // uint32_t                                       stride
				inputRate = VertexInputRate.Vertex             // VkVertexInputRate                              inputRate
			};

			var vertex_attribute_descriptions = stackalloc VertexInputAttributeDescription[2];
			vertex_attribute_descriptions[0] = new VertexInputAttributeDescription
			{
				location = 0,                                        // uint32_t                                       location
				binding = vertex_binding_descriptions[0].binding,    // uint32_t                                       binding
				format = Format.R32g32b32a32Sfloat,                  // VkFormat                                       format
				offset = (uint)Marshal.OffsetOf<VertexData> ( "x" )  // uint32_t                                       offset
			};
			vertex_attribute_descriptions[1] = new VertexInputAttributeDescription
			{
				location = 1,                                        // uint32_t                                       location
				binding = vertex_binding_descriptions[0].binding,    // uint32_t                                       binding
				format = Format.R32g32b32a32Sfloat,                  // VkFormat                                       format
				offset = (uint)Marshal.OffsetOf<VertexData> ( "r" )  // uint32_t                                       offset
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
				pDynamicState = &dynamic_state_create_info,                   // const VkPipelineDynamicStateCreateInfo        *pDynamicState
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

		void CreateVertexBuffer()
		{
			var vertex_data = stackalloc VertexData[4];
			vertex_data[0] = new VertexData ( -0.7f, -0.7f, 0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f );
			vertex_data[1] = new VertexData ( -0.7f, 0.7f, 0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 0.0f );
			vertex_data[2] = new VertexData ( 0.7f, -0.7f, 0.0f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f );
			vertex_data[3] = new VertexData ( 0.7f, 0.7f, 0.0f, 1.0f, 0.3f, 0.3f, 0.3f, 0.0f );

			Vulkan.VertexBuffer.Size = (uint)Marshal.SizeOf<VertexData> () * 4;

			var buffer_create_info = new BufferCreateInfo
			{
				sType = StructureType.BufferCreateInfo,  // VkStructureType        sType
				pNext = IntPtr.Zero,                     // const void            *pNext
				flags = 0,                               // VkBufferCreateFlagBits    flags
				size = Vulkan.VertexBuffer.Size,         // VkDeviceSize           size
				usage = BufferUsageFlagBits.VertexBufferBit,   // VkBufferUsageFlagBits     usage
				sharingMode = SharingMode.Exclusive,     // VkSharingMode          sharingMode
				queueFamilyIndexCount = 0,               // uint32_t               queueFamilyIndexCount
				pQueueFamilyIndices = (uint*)0           // const uint32_t        *pQueueFamilyIndices
			};

			vk.CreateBuffer ( GetDevice, ref buffer_create_info, (AllocationCallbacks*)0, out Vulkan.VertexBuffer.Handle ).CheckError ();

			AllocateBufferMemory ( Vulkan.VertexBuffer.Handle, out Vulkan.VertexBuffer.Memory );

			vk.BindBufferMemory ( GetDevice, Vulkan.VertexBuffer.Handle, Vulkan.VertexBuffer.Memory, 0 ).CheckError ();

			IntPtr vertex_buffer_memory_pointer;
			vk.MapMemory ( GetDevice, Vulkan.VertexBuffer.Memory, 0, Vulkan.VertexBuffer.Size, 0, out vertex_buffer_memory_pointer ).CheckError ();

			//memcpy ( vertex_buffer_memory_pointer, vertex_data, Vulkan.VertexBuffer.Size );
			for ( int i = 0; i < Vulkan.VertexBuffer.Size; i++ )
			{
				((byte*)vertex_buffer_memory_pointer)[i] = ((byte*)vertex_data)[i];
			}

			var flush_range = new MappedMemoryRange
			{
				sType = StructureType.MappedMemoryRange,  // VkStructureType        sType
				pNext = IntPtr.Zero,                      // const void            *pNext
				memory = Vulkan.VertexBuffer.Memory,      // VkDeviceMemory         memory
				offset = 0,                               // VkDeviceSize           offset
				size = unchecked((ulong)(~0))             //Constant.WholeSize // VkDeviceSize           size
			};

			vk.FlushMappedMemoryRanges ( GetDevice, 1, &flush_range ).CheckError ();

			vk.UnmapMemory ( GetDevice, Vulkan.VertexBuffer.Memory );
		}


		void AllocateBufferMemory(Crow.Graphics.Vulkan.Buffer buffer, out DeviceMemory memory)
		{
			memory = new DeviceMemory ();

			MemoryRequirements buffer_memory_requirements;
			vk.GetBufferMemoryRequirements ( GetDevice, buffer, out buffer_memory_requirements );

			PhysicalDeviceMemoryProperties memory_properties;
			vk.GetPhysicalDeviceMemoryProperties ( GetPhysicalDevice, out memory_properties );

			//var s = memory_properties.GetMemoryHeaps;
			//var x = memory_properties.GetMemoryTypes;

			for ( int i = 0; i < memory_properties.memoryTypeCount; ++i )
			{
				if ( (buffer_memory_requirements.memoryTypeBits & (1 << i)) != 0
					&& (((MemoryType*)memory_properties.memoryTypes)[i].propertyFlags & MemoryPropertyFlagBits.HostVisibleBit) != 0 )
				{
					var memory_allocate_info = new MemoryAllocateInfo
					{
						sType = StructureType.MemoryAllocateInfo,         // VkStructureType                        sType
						pNext = IntPtr.Zero,                              // const void                            *pNext
						allocationSize = buffer_memory_requirements.size, // VkDeviceSize                           allocationSize
						memoryTypeIndex = (uint)i                         // uint32_t                               memoryTypeIndex
					};

					if ( vk.AllocateMemory ( GetDevice, ref memory_allocate_info, (AllocationCallbacks*)0, out memory ).CheckError ().Success () )
					{
						return;
					}
				}
			}
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
				sType = StructureType.CommandPoolCreateInfo,                                          // VkStructureType                sType
				pNext = IntPtr.Zero,                                                                  // const void                    *pNext
				flags = CommandPoolCreateFlagBits.ResetCommandBufferBit | CommandPoolCreateFlagBits.TransientBit, // VkCommandPoolCreateFlagBits       flags
				queueFamilyIndex = queue_family_index                                                 // uint32_t                       queueFamilyIndex
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


		void PrepareFrame(CommandBuffer command_buffer, ref ImageParameters image_parameters, ref Framebuffer framebuffer)
		{
			CreateFramebuffer ( ref framebuffer, image_parameters.View );

			var command_buffer_begin_info = new CommandBufferBeginInfo
			{
				sType = StructureType.CommandBufferBeginInfo,         // VkStructureType                        sType
				pNext = IntPtr.Zero,                                  // const void                            *pNext
				flags = CommandBufferUsageFlagBits.OneTimeSubmitBit,        // VkCommandBufferUsageFlagBits              flags
				pInheritanceInfo = (CommandBufferInheritanceInfo*)0   // const VkCommandBufferInheritanceInfo  *pInheritanceInfo
			};

			vk.BeginCommandBuffer ( command_buffer, ref command_buffer_begin_info ).CheckError ();

			var image_subresource_range = new ImageSubresourceRange
			{
				aspectMask = ImageAspectFlagBits.ColorBit,  // VkImageAspectFlagBits                     aspectMask
				baseMipLevel = 0,                     // uint32_t                               baseMipLevel
				levelCount = 1,                       // uint32_t                               levelCount
				baseArrayLayer = 0,                   // uint32_t                               baseArrayLayer
				layerCount = 1                        // uint32_t                               layerCount
			};

			if ( GetPresentQueue.Handle != GetGraphicsQueue.Handle )
			{
				var barrier_from_present_to_draw = new ImageMemoryBarrier
				{
					sType = StructureType.ImageMemoryBarrier,                    // VkStructureType                        sType
					pNext = IntPtr.Zero,                                         // const void                            *pNext
					sourceAccessMask = AccessFlagBits.MemoryReadBit,                   // VkAccessFlagBits                          srcAccessMask
					destinationAccessMask = AccessFlagBits.MemoryReadBit,              // VkAccessFlagBits                          dstAccessMask
					oldLayout = ImageLayout.Undefined,                           // VkImageLayout                          oldLayout
					newLayout = ImageLayout.PresentSourceKhr,                    // VkImageLayout                          newLayout
					sourceQueueFamilyIndex = GetPresentQueue.FamilyIndex,        // uint32_t                               srcQueueFamilyIndex
					destinationQueueFamilyIndex = GetGraphicsQueue.FamilyIndex,  // uint32_t                               dstQueueFamilyIndex
					image = image_parameters.Handle,                             // VkImage                                image
					subresourceRange = image_subresource_range                   // VkImageSubresourceRange                subresourceRange
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
			}

			var clear_value = new ClearValue
			{
				color = new ClearColorValue ( 1.0f, 0.8f, 0.4f, 0.0f ), // VkClearColorValue              color
			};

			var render_pass_begin_info = new RenderPassBeginInfo
			{
				sType = StructureType.RenderPassBeginInfo, // VkStructureType                sType
				pNext = IntPtr.Zero,                       // const void                    *pNext
				renderPass = Vulkan.RenderPass,            // VkRenderPass                   renderPass
				framebuffer = framebuffer,                 // VkFramebuffer                  framebuffer
				renderArea = new Rect2D
				{                                          // VkRect2D                       renderArea
					offset = new Offset2D
					{                                       // VkOffset2D                     offset
						x = 0,                               // int32_t                        x
						y = 0                                // int32_t                        y
					},
					extent = GetSwapChain.Extent,           // VkExtent2D                     extent
				},
				clearValueCount = 1,                       // uint32_t                       clearValueCount
				pClearValues = &clear_value                // const VkClearValue            *pClearValues
			};

			vk.CmdBeginRenderPass ( command_buffer, ref render_pass_begin_info, SubpassContents.Inline );

			vk.CmdBindPipeline ( command_buffer, PipelineBindPoint.Graphics, Vulkan.GraphicsPipeline );

			var viewport = new Viewport (
				0.0f,                        // float                                  x
				0.0f,                        // float                                  y
				GetSwapChain.Extent.width,   // float                                  width
				GetSwapChain.Extent.height,  // float                                  height
				0.0f,                        // float                                  minDepth
				1.0f                         // float                                  maxDepth
			);

			var scissor = new Rect2D ( new Offset2D ( 0, 0 ), GetSwapChain.Extent );

			vk.CmdSetViewport ( command_buffer, 0, 1, &viewport );

			vk.CmdSetScissor ( command_buffer, 0, 1, &scissor );

			ulong offset = 0;
			Crow.Graphics.Vulkan.Buffer vertexBuffer = Vulkan.VertexBuffer.Handle;

			vk.CmdBindVertexBuffers ( command_buffer, 0, 1, &vertexBuffer, &offset );

			vk.CmdDraw ( command_buffer, 4, 1, 0, 0 );

			vk.CmdEndRenderPass ( command_buffer );

			if ( GetGraphicsQueue.Handle != GetPresentQueue.Handle )
			{
				var barrier_from_draw_to_present = new ImageMemoryBarrier
				{
					sType = StructureType.ImageMemoryBarrier,                   // VkStructureType                        sType
					pNext = IntPtr.Zero,                                        // const void                            *pNext
					sourceAccessMask = AccessFlagBits.MemoryReadBit,                  // VkAccessFlagBits                          srcAccessMask
					destinationAccessMask = AccessFlagBits.MemoryReadBit,             // VkAccessFlagBits                          dstAccessMask
					oldLayout = ImageLayout.PresentSourceKhr,                   // VkImageLayout                          oldLayout
					newLayout = ImageLayout.PresentSourceKhr,                   // VkImageLayout                          newLayout
					sourceQueueFamilyIndex = GetGraphicsQueue.FamilyIndex,      // uint32_t                               srcQueueFamilyIndex
					destinationQueueFamilyIndex = GetPresentQueue.FamilyIndex,  // uint32_t                               dstQueueFamilyIndex
					image = image_parameters.Handle,                            // VkImage                                image
					subresourceRange = image_subresource_range                  // VkImageSubresourceRange                subresourceRange
				};

				vk.CmdPipelineBarrier (
					command_buffer,
					PipelineStageFlagBits.ColorAttachmentOutputBit,
					PipelineStageFlagBits.BottomOfPipeBit,
					(DependencyFlagBits)0,
					0, (MemoryBarrier*)0,
					0, (BufferMemoryBarrier*)0,
					1, &barrier_from_draw_to_present
				);
			}

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
			RenderingResourcesData current_rendering_resource = Vulkan.RenderingResources[idx];
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

				if ( !Vulkan.VertexBuffer.Handle.IsZero )
				{
					vk.DestroyBuffer ( GetDevice, Vulkan.VertexBuffer.Handle );
					Vulkan.VertexBuffer.Handle = new Crow.Graphics.Vulkan.Buffer ();
				}

				if ( !Vulkan.VertexBuffer.Memory.IsZero )
				{
					vk.FreeMemory ( GetDevice, Vulkan.VertexBuffer.Memory );
					Vulkan.VertexBuffer.Memory = new DeviceMemory ();
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
			}


			base.Dispose ();

		}



	}
}
