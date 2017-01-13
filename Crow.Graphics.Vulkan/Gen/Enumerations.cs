using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Crow.Graphics.Vulkan
{
	// <summary>VkAccessFlagBits</summary>
	[Flags]
	public enum AccessFlagBits
	{
		// <summary>VK_ACCESS_INDIRECT_COMMAND_READ_BIT</summary>
		IndirectCommandReadBit = unchecked(1 << 0),
		// <summary>VK_ACCESS_INDEX_READ_BIT</summary>
		IndexReadBit = unchecked(1 << 1),
		// <summary>VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT</summary>
		VertexAttributeReadBit = unchecked(1 << 2),
		// <summary>VK_ACCESS_UNIFORM_READ_BIT</summary>
		UniformReadBit = unchecked(1 << 3),
		// <summary>VK_ACCESS_INPUT_ATTACHMENT_READ_BIT</summary>
		InputAttachmentReadBit = unchecked(1 << 4),
		// <summary>VK_ACCESS_SHADER_READ_BIT</summary>
		ShaderReadBit = unchecked(1 << 5),
		// <summary>VK_ACCESS_SHADER_WRITE_BIT</summary>
		ShaderWriteBit = unchecked(1 << 6),
		// <summary>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT</summary>
		ColorAttachmentReadBit = unchecked(1 << 7),
		// <summary>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</summary>
		ColorAttachmentWriteBit = unchecked(1 << 8),
		// <summary>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT</summary>
		DepthStencilAttachmentReadBit = unchecked(1 << 9),
		// <summary>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</summary>
		DepthStencilAttachmentWriteBit = unchecked(1 << 10),
		// <summary>VK_ACCESS_TRANSFER_READ_BIT</summary>
		TransferReadBit = unchecked(1 << 11),
		// <summary>VK_ACCESS_TRANSFER_WRITE_BIT</summary>
		TransferWriteBit = unchecked(1 << 12),
		// <summary>VK_ACCESS_HOST_READ_BIT</summary>
		HostReadBit = unchecked(1 << 13),
		// <summary>VK_ACCESS_HOST_WRITE_BIT</summary>
		HostWriteBit = unchecked(1 << 14),
		// <summary>VK_ACCESS_MEMORY_READ_BIT</summary>
		MemoryReadBit = unchecked(1 << 15),
		// <summary>VK_ACCESS_MEMORY_WRITE_BIT</summary>
		MemoryWriteBit = unchecked(1 << 16),
		// <summary>VK_ACCESS_COMMAND_PROCESS_READ_BIT_NVX</summary>
		CommandProcessReadBitNvx = unchecked(1 << 17),
		// <summary>VK_ACCESS_COMMAND_PROCESS_WRITE_BIT_NVX</summary>
		CommandProcessWriteBitNvx = unchecked(1 << 18),
	}
	// <summary>VkAttachmentDescriptionFlagBits</summary>
	[Flags]
	public enum AttachmentDescriptionFlagBits
	{
		// <summary>VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT</summary>
		MayAliasBit = unchecked(1 << 0),
	}
	// <summary>VkAttachmentLoadOp</summary>
	public enum AttachmentLoadOperation
	{
		// <summary>VK_ATTACHMENT_LOAD_OP_LOAD</summary>
		Load = unchecked(0),
		// <summary>VK_ATTACHMENT_LOAD_OP_CLEAR</summary>
		Clear = unchecked(1),
		// <summary>VK_ATTACHMENT_LOAD_OP_DONT_CARE</summary>
		DontCare = unchecked(2),
	}
	// <summary>VkAttachmentStoreOp</summary>
	public enum AttachmentStoreOperation
	{
		// <summary>VK_ATTACHMENT_STORE_OP_STORE</summary>
		Store = unchecked(0),
		// <summary>VK_ATTACHMENT_STORE_OP_DONT_CARE</summary>
		DontCare = unchecked(1),
	}
	// <summary>VkBlendFactor</summary>
	public enum BlendFactor
	{
		// <summary>VK_BLEND_FACTOR_ZERO</summary>
		Zero = unchecked(0),
		// <summary>VK_BLEND_FACTOR_ONE</summary>
		One = unchecked(1),
		// <summary>VK_BLEND_FACTOR_SRC_COLOR</summary>
		SourceColor = unchecked(2),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR</summary>
		OneMinusSourceColor = unchecked(3),
		// <summary>VK_BLEND_FACTOR_DST_COLOR</summary>
		DestinationColor = unchecked(4),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR</summary>
		OneMinusDestinationColor = unchecked(5),
		// <summary>VK_BLEND_FACTOR_SRC_ALPHA</summary>
		SourceAlpha = unchecked(6),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA</summary>
		OneMinusSourceAlpha = unchecked(7),
		// <summary>VK_BLEND_FACTOR_DST_ALPHA</summary>
		DestinationAlpha = unchecked(8),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA</summary>
		OneMinusDestinationAlpha = unchecked(9),
		// <summary>VK_BLEND_FACTOR_CONSTANT_COLOR</summary>
		ConstantColor = unchecked(10),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR</summary>
		OneMinusConstantColor = unchecked(11),
		// <summary>VK_BLEND_FACTOR_CONSTANT_ALPHA</summary>
		ConstantAlpha = unchecked(12),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA</summary>
		OneMinusConstantAlpha = unchecked(13),
		// <summary>VK_BLEND_FACTOR_SRC_ALPHA_SATURATE</summary>
		SourceAlphaSaturate = unchecked(14),
		// <summary>VK_BLEND_FACTOR_SRC1_COLOR</summary>
		Source1Color = unchecked(15),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR</summary>
		OneMinusSource1Color = unchecked(16),
		// <summary>VK_BLEND_FACTOR_SRC1_ALPHA</summary>
		Source1Alpha = unchecked(17),
		// <summary>VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA</summary>
		OneMinusSource1Alpha = unchecked(18),
	}
	// <summary>VkBlendOp</summary>
	public enum BlendOperation
	{
		// <summary>VK_BLEND_OP_ADD</summary>
		Add = unchecked(0),
		// <summary>VK_BLEND_OP_SUBTRACT</summary>
		Subtract = unchecked(1),
		// <summary>VK_BLEND_OP_REVERSE_SUBTRACT</summary>
		ReverseSubtract = unchecked(2),
		// <summary>VK_BLEND_OP_MIN</summary>
		Min = unchecked(3),
		// <summary>VK_BLEND_OP_MAX</summary>
		Max = unchecked(4),
	}
	// <summary>VkBorderColor</summary>
	public enum BorderColor
	{
		// <summary>VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK</summary>
		FloatTransparentBlack = unchecked(0),
		// <summary>VK_BORDER_COLOR_INT_TRANSPARENT_BLACK</summary>
		IntTransparentBlack = unchecked(1),
		// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK</summary>
		FloatOpaqueBlack = unchecked(2),
		// <summary>VK_BORDER_COLOR_INT_OPAQUE_BLACK</summary>
		IntOpaqueBlack = unchecked(3),
		// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE</summary>
		FloatOpaqueWhite = unchecked(4),
		// <summary>VK_BORDER_COLOR_INT_OPAQUE_WHITE</summary>
		IntOpaqueWhite = unchecked(5),
	}
	// <summary>VkBufferCreateFlagBits</summary>
	[Flags]
	public enum BufferCreateFlagBits
	{
		// <summary>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</summary>
		SparseBindingBit = unchecked(1 << 0),
		// <summary>VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT</summary>
		SparseResidencyBit = unchecked(1 << 1),
		// <summary>VK_BUFFER_CREATE_SPARSE_ALIASED_BIT</summary>
		SparseAliasedBit = unchecked(1 << 2),
	}
	// <summary>VkBufferUsageFlagBits</summary>
	[Flags]
	public enum BufferUsageFlagBits
	{
		// <summary>VK_BUFFER_USAGE_TRANSFER_SRC_BIT</summary>
		TransferSourceBit = unchecked(1 << 0),
		// <summary>VK_BUFFER_USAGE_TRANSFER_DST_BIT</summary>
		TransferDestinationBit = unchecked(1 << 1),
		// <summary>VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT</summary>
		UniformTexelBufferBit = unchecked(1 << 2),
		// <summary>VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT</summary>
		StorageTexelBufferBit = unchecked(1 << 3),
		// <summary>VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT</summary>
		UniformBufferBit = unchecked(1 << 4),
		// <summary>VK_BUFFER_USAGE_STORAGE_BUFFER_BIT</summary>
		StorageBufferBit = unchecked(1 << 5),
		// <summary>VK_BUFFER_USAGE_INDEX_BUFFER_BIT</summary>
		IndexBufferBit = unchecked(1 << 6),
		// <summary>VK_BUFFER_USAGE_VERTEX_BUFFER_BIT</summary>
		VertexBufferBit = unchecked(1 << 7),
		// <summary>VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT</summary>
		IndirectBufferBit = unchecked(1 << 8),
	}
	// <summary>VkColorComponentFlagBits</summary>
	[Flags]
	public enum ColorComponentFlagBits
	{
		// <summary>VK_COLOR_COMPONENT_R_BIT</summary>
		RBit = unchecked(1 << 0),
		// <summary>VK_COLOR_COMPONENT_G_BIT</summary>
		GBit = unchecked(1 << 1),
		// <summary>VK_COLOR_COMPONENT_B_BIT</summary>
		BBit = unchecked(1 << 2),
		// <summary>VK_COLOR_COMPONENT_A_BIT</summary>
		ABit = unchecked(1 << 3),
	}
	// <summary>VkColorSpaceKHR</summary>
	public enum ColorSpaceKHR
	{
		// <summary>VK_COLOR_SPACE_SRGB_NONLINEAR_KHR</summary>
		SrgbNonlinearKhr = unchecked(0),
	}
	// <summary>VkCommandBufferLevel</summary>
	public enum CommandBufferLevel
	{
		// <summary>VK_COMMAND_BUFFER_LEVEL_PRIMARY</summary>
		Primary = unchecked(0),
		// <summary>VK_COMMAND_BUFFER_LEVEL_SECONDARY</summary>
		Secondary = unchecked(1),
	}
	// <summary>VkCommandBufferResetFlagBits</summary>
	[Flags]
	public enum CommandBufferResetFlagBits
	{
		// <summary>VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT</summary>
		ReleaseResourcesBit = unchecked(1 << 0),
	}
	// <summary>VkCommandBufferUsageFlagBits</summary>
	[Flags]
	public enum CommandBufferUsageFlagBits
	{
		// <summary>VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT</summary>
		OneTimeSubmitBit = unchecked(1 << 0),
		// <summary>VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT</summary>
		RenderPassContinueBit = unchecked(1 << 1),
		// <summary>VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT</summary>
		SimultaneousUseBit = unchecked(1 << 2),
	}
	// <summary>VkCommandPoolCreateFlagBits</summary>
	[Flags]
	public enum CommandPoolCreateFlagBits
	{
		// <summary>VK_COMMAND_POOL_CREATE_TRANSIENT_BIT</summary>
		TransientBit = unchecked(1 << 0),
		// <summary>VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT</summary>
		ResetCommandBufferBit = unchecked(1 << 1),
	}
	// <summary>VkCommandPoolResetFlagBits</summary>
	[Flags]
	public enum CommandPoolResetFlagBits
	{
		// <summary>VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT</summary>
		ReleaseResourcesBit = unchecked(1 << 0),
	}
	// <summary>VkCompareOp</summary>
	public enum CompareOperation
	{
		// <summary>VK_COMPARE_OP_NEVER</summary>
		Never = unchecked(0),
		// <summary>VK_COMPARE_OP_LESS</summary>
		Less = unchecked(1),
		// <summary>VK_COMPARE_OP_EQUAL</summary>
		Equal = unchecked(2),
		// <summary>VK_COMPARE_OP_LESS_OR_EQUAL</summary>
		LessOrEqual = unchecked(3),
		// <summary>VK_COMPARE_OP_GREATER</summary>
		Greater = unchecked(4),
		// <summary>VK_COMPARE_OP_NOT_EQUAL</summary>
		NotEqual = unchecked(5),
		// <summary>VK_COMPARE_OP_GREATER_OR_EQUAL</summary>
		GreaterOrEqual = unchecked(6),
		// <summary>VK_COMPARE_OP_ALWAYS</summary>
		Always = unchecked(7),
	}
	// <summary>VkComponentSwizzle</summary>
	public enum ComponentSwizzle
	{
		// <summary>VK_COMPONENT_SWIZZLE_IDENTITY</summary>
		Identity = unchecked(0),
		// <summary>VK_COMPONENT_SWIZZLE_ZERO</summary>
		Zero = unchecked(1),
		// <summary>VK_COMPONENT_SWIZZLE_ONE</summary>
		One = unchecked(2),
		// <summary>VK_COMPONENT_SWIZZLE_R</summary>
		R = unchecked(3),
		// <summary>VK_COMPONENT_SWIZZLE_G</summary>
		G = unchecked(4),
		// <summary>VK_COMPONENT_SWIZZLE_B</summary>
		B = unchecked(5),
		// <summary>VK_COMPONENT_SWIZZLE_A</summary>
		A = unchecked(6),
	}
	// <summary>VkCompositeAlphaFlagBitsKHR</summary>
	[Flags]
	public enum CompositeAlphaFlagBitsKHR
	{
		// <summary>VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR</summary>
		OpaqueBitKhr = unchecked(1 << 0),
		// <summary>VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR</summary>
		PreMultipliedBitKhr = unchecked(1 << 1),
		// <summary>VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR</summary>
		PostMultipliedBitKhr = unchecked(1 << 2),
		// <summary>VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR</summary>
		InheritBitKhr = unchecked(1 << 3),
	}
	// <summary>API Constants</summary>
	public enum Constant
	{
		// <summary>VK_MAX_PHYSICAL_DEVICE_NAME_SIZE</summary>
		MaxPhysicalDeviceNameSize = unchecked(256),
		// <summary>VK_UUID_SIZE</summary>
		UuidSize = unchecked(16),
		// <summary>VK_MAX_EXTENSION_NAME_SIZE</summary>
		MaxExtensionNameSize = unchecked(256),
		// <summary>VK_MAX_DESCRIPTION_SIZE</summary>
		MaxDescriptionSize = unchecked(256),
		// <summary>VK_MAX_MEMORY_TYPES</summary>
		MaxMemoryTypes = unchecked(32),
		// <summary>VK_MAX_MEMORY_HEAPS</summary>
		MaxMemoryHeaps = unchecked(16),
		// <summary>VK_LOD_CLAMP_NONE</summary>
		LodClampNone = unchecked((int)1000.0f),
		// <summary>VK_REMAINING_MIP_LEVELS</summary>
		RemainingMipLevels = unchecked((int)(~0U)),
		// <summary>VK_REMAINING_ARRAY_LAYERS</summary>
		RemainingArrayLayers = unchecked((int)(~0U)),
		// <summary>VK_WHOLE_SIZE</summary>
		WholeSize = unchecked((int)(~0ul)),
		// <summary>VK_ATTACHMENT_UNUSED</summary>
		AttachmentUnused = unchecked((int)(~0U)),
		// <summary>VK_TRUE</summary>
		True = unchecked(1),
		// <summary>VK_FALSE</summary>
		False = unchecked(0),
		// <summary>VK_QUEUE_FAMILY_IGNORED</summary>
		FamilyIgnored = unchecked((int)(~0U)),
		// <summary>VK_SUBPASS_EXTERNAL</summary>
		SubpassExternal = unchecked((int)(~0U)),
	}
	// <summary>VkCullModeFlagBits</summary>
	[Flags]
	public enum CullModeFlagBits
	{
		// <summary>VK_CULL_MODE_NONE</summary>
		None = unchecked(0),
		// <summary>VK_CULL_MODE_FRONT_BIT</summary>
		FrontBit = unchecked(1 << 0),
		// <summary>VK_CULL_MODE_BACK_BIT</summary>
		BackBit = unchecked(1 << 1),
		// <summary>VK_CULL_MODE_FRONT_AND_BACK</summary>
		FrontAndBack = unchecked(0x00000003),
	}
	// <summary>VkDebugReportErrorEXT</summary>
	public enum DebugReportErrorEXT
	{
		// <summary>VK_DEBUG_REPORT_ERROR_NONE_EXT</summary>
		NoneExt = unchecked(0),
		// <summary>VK_DEBUG_REPORT_ERROR_CALLBACK_REF_EXT</summary>
		CallbackRefExt = unchecked(1),
	}
	// <summary>VkDebugReportFlagBitsEXT</summary>
	[Flags]
	public enum DebugReportFlagBitsEXT
	{
		// <summary>VK_DEBUG_REPORT_INFORMATION_BIT_EXT</summary>
		InformationBitExt = unchecked(1 << 0),
		// <summary>VK_DEBUG_REPORT_WARNING_BIT_EXT</summary>
		WarningBitExt = unchecked(1 << 1),
		// <summary>VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT</summary>
		PerformanceWarningBitExt = unchecked(1 << 2),
		// <summary>VK_DEBUG_REPORT_ERROR_BIT_EXT</summary>
		ErrorExt = unchecked(1 << 3),
		// <summary>VK_DEBUG_REPORT_DEBUG_BIT_EXT</summary>
		DebugBitExt = unchecked(1 << 4),
	}
	// <summary>VkDebugReportObjectTypeEXT</summary>
	public enum DebugReportObjectTypeEXT
	{
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT</summary>
		UnknownExt = unchecked(0),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT</summary>
		InstanceExt = unchecked(1),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT</summary>
		PhysicalDeviceExt = unchecked(2),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT</summary>
		DeviceExt = unchecked(3),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT</summary>
		QueueExt = unchecked(4),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT</summary>
		SemaphoreExt = unchecked(5),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT</summary>
		CommandBufferExt = unchecked(6),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT</summary>
		FenceExt = unchecked(7),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT</summary>
		DeviceMemoryExt = unchecked(8),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT</summary>
		BufferExt = unchecked(9),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT</summary>
		ImageExt = unchecked(10),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT</summary>
		EventExt = unchecked(11),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT</summary>
		QueryPoolExt = unchecked(12),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT</summary>
		BufferViewExt = unchecked(13),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT</summary>
		ImageViewExt = unchecked(14),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT</summary>
		ShaderModuleExt = unchecked(15),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT</summary>
		PipelineCacheExt = unchecked(16),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT</summary>
		PipelineLayoutExt = unchecked(17),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT</summary>
		RenderPassExt = unchecked(18),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT</summary>
		PipelineExt = unchecked(19),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT</summary>
		DescriptorSetLayoutExt = unchecked(20),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT</summary>
		SamplerExt = unchecked(21),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT</summary>
		DescriptorPoolExt = unchecked(22),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT</summary>
		DescriptorSetExt = unchecked(23),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT</summary>
		FramebufferExt = unchecked(24),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT</summary>
		CommandPoolExt = unchecked(25),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT</summary>
		SurfaceKhrExt = unchecked(26),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT</summary>
		SwapchainKhrExt = unchecked(27),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT</summary>
		DebugReportExt = unchecked(28),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT</summary>
		DisplayKhrExt = unchecked(29),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT</summary>
		DisplayModeKhrExt = unchecked(30),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_OBJECT_TABLE_NVX_EXT</summary>
		ObjectTableNvxExt = unchecked(31),
		// <summary>VK_DEBUG_REPORT_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX_EXT</summary>
		IndirectCommandsLayoutNvxExt = unchecked(32),
	}
	// <summary>VkDependencyFlagBits</summary>
	[Flags]
	public enum DependencyFlagBits
	{
		// <summary>VK_DEPENDENCY_BY_REGION_BIT</summary>
		ByRegionBit = unchecked(1 << 0),
	}
	// <summary>VkDescriptorPoolCreateFlagBits</summary>
	[Flags]
	public enum DescriptorPoolCreateFlagBits
	{
		// <summary>VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT</summary>
		FreeDescriptorSetBit = unchecked(1 << 0),
	}
	// <summary>VkDescriptorType</summary>
	public enum DescriptorType
	{
		// <summary>VK_DESCRIPTOR_TYPE_SAMPLER</summary>
		Sampler = unchecked(0),
		// <summary>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</summary>
		CombinedImageSampler = unchecked(1),
		// <summary>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</summary>
		SampledImage = unchecked(2),
		// <summary>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</summary>
		StorageImage = unchecked(3),
		// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</summary>
		UniformTexelBuffer = unchecked(4),
		// <summary>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</summary>
		StorageTexelBuffer = unchecked(5),
		// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</summary>
		UniformBuffer = unchecked(6),
		// <summary>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</summary>
		StorageBuffer = unchecked(7),
		// <summary>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC</summary>
		UniformBufferDynamic = unchecked(8),
		// <summary>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC</summary>
		StorageBufferDynamic = unchecked(9),
		// <summary>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</summary>
		InputAttachment = unchecked(10),
	}
	// <summary>VkDisplayPlaneAlphaFlagBitsKHR</summary>
	[Flags]
	public enum DisplayPlaneAlphaFlagBitsKHR
	{
		// <summary>VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR</summary>
		OpaqueBitKhr = unchecked(1 << 0),
		// <summary>VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR</summary>
		GlobalBitKhr = unchecked(1 << 1),
		// <summary>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR</summary>
		PerPixelBitKhr = unchecked(1 << 2),
		// <summary>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR</summary>
		PerPixelPremultipliedBitKhr = unchecked(1 << 3),
	}
	// <summary>VkDynamicState</summary>
	public enum DynamicState
	{
		// <summary>VK_DYNAMIC_STATE_VIEWPORT</summary>
		Viewport = unchecked(0),
		// <summary>VK_DYNAMIC_STATE_SCISSOR</summary>
		Scissor = unchecked(1),
		// <summary>VK_DYNAMIC_STATE_LINE_WIDTH</summary>
		LineWidth = unchecked(2),
		// <summary>VK_DYNAMIC_STATE_DEPTH_BIAS</summary>
		DepthBias = unchecked(3),
		// <summary>VK_DYNAMIC_STATE_BLEND_CONSTANTS</summary>
		BlendConstants = unchecked(4),
		// <summary>VK_DYNAMIC_STATE_DEPTH_BOUNDS</summary>
		DepthBounds = unchecked(5),
		// <summary>VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK</summary>
		StencilCompareMask = unchecked(6),
		// <summary>VK_DYNAMIC_STATE_STENCIL_WRITE_MASK</summary>
		StencilWriteMask = unchecked(7),
		// <summary>VK_DYNAMIC_STATE_STENCIL_REFERENCE</summary>
		StencilReference = unchecked(8),
	}
	// <summary>VkExternalMemoryFeatureFlagBitsNV</summary>
	[Flags]
	public enum ExternalMemoryFeatureFlagBitsNV
	{
		// <summary>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV</summary>
		ExternalMemoryFeatureDedicatedOnlyBitNv = unchecked(1 << 0),
		// <summary>VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV</summary>
		ExternalMemoryFeatureExportableBitNv = unchecked(1 << 1),
		// <summary>VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV</summary>
		ExternalMemoryFeatureImportableBitNv = unchecked(1 << 2),
	}
	// <summary>VkExternalMemoryHandleTypeFlagBitsNV</summary>
	[Flags]
	public enum ExternalMemoryHandleTypeFlagBitsNV
	{
		// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV</summary>
		ExternalMemoryHandleTypeOpaqueWin32BitNv = unchecked(1 << 0),
		// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV</summary>
		ExternalMemoryHandleTypeOpaqueWin32KmtBitNv = unchecked(1 << 1),
		// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV</summary>
		ExternalMemoryHandleTypeD3d11ImageBitNv = unchecked(1 << 2),
		// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV</summary>
		ExternalMemoryHandleTypeD3d11ImageKmtBitNv = unchecked(1 << 3),
	}
	// <summary>VkFenceCreateFlagBits</summary>
	[Flags]
	public enum FenceCreateFlagBits
	{
		// <summary>VK_FENCE_CREATE_SIGNALED_BIT</summary>
		SignaledBit = unchecked(1 << 0),
	}
	// <summary>VkFilter</summary>
	public enum Filter
	{
		// <summary>VK_FILTER_NEAREST</summary>
		Nearest = unchecked(0),
		// <summary>VK_FILTER_LINEAR</summary>
		Linear = unchecked(1),
		// <summary>VK_FILTER_CUBIC_IMG</summary>
		CubicImg = unchecked((1000000000 + 1000 * (16 - 1) + 0)),
	}
	// <summary>VkFormat</summary>
	public enum Format
	{
		// <summary>VK_FORMAT_UNDEFINED</summary>
		Undefined = unchecked(0),
		// <summary>VK_FORMAT_R4G4_UNORM_PACK8</summary>
		R4g4UnormPack8 = unchecked(1),
		// <summary>VK_FORMAT_R4G4B4A4_UNORM_PACK16</summary>
		R4g4b4a4UnormPack16 = unchecked(2),
		// <summary>VK_FORMAT_B4G4R4A4_UNORM_PACK16</summary>
		B4g4r4a4UnormPack16 = unchecked(3),
		// <summary>VK_FORMAT_R5G6B5_UNORM_PACK16</summary>
		R5g6b5UnormPack16 = unchecked(4),
		// <summary>VK_FORMAT_B5G6R5_UNORM_PACK16</summary>
		B5g6r5UnormPack16 = unchecked(5),
		// <summary>VK_FORMAT_R5G5B5A1_UNORM_PACK16</summary>
		R5g5b5a1UnormPack16 = unchecked(6),
		// <summary>VK_FORMAT_B5G5R5A1_UNORM_PACK16</summary>
		B5g5r5a1UnormPack16 = unchecked(7),
		// <summary>VK_FORMAT_A1R5G5B5_UNORM_PACK16</summary>
		A1r5g5b5UnormPack16 = unchecked(8),
		// <summary>VK_FORMAT_R8_UNORM</summary>
		R8Unorm = unchecked(9),
		// <summary>VK_FORMAT_R8_SNORM</summary>
		R8Snorm = unchecked(10),
		// <summary>VK_FORMAT_R8_USCALED</summary>
		R8Uscaled = unchecked(11),
		// <summary>VK_FORMAT_R8_SSCALED</summary>
		R8Sscaled = unchecked(12),
		// <summary>VK_FORMAT_R8_UINT</summary>
		R8Uint = unchecked(13),
		// <summary>VK_FORMAT_R8_SINT</summary>
		R8Sint = unchecked(14),
		// <summary>VK_FORMAT_R8_SRGB</summary>
		R8Srgb = unchecked(15),
		// <summary>VK_FORMAT_R8G8_UNORM</summary>
		R8g8Unorm = unchecked(16),
		// <summary>VK_FORMAT_R8G8_SNORM</summary>
		R8g8Snorm = unchecked(17),
		// <summary>VK_FORMAT_R8G8_USCALED</summary>
		R8g8Uscaled = unchecked(18),
		// <summary>VK_FORMAT_R8G8_SSCALED</summary>
		R8g8Sscaled = unchecked(19),
		// <summary>VK_FORMAT_R8G8_UINT</summary>
		R8g8Uint = unchecked(20),
		// <summary>VK_FORMAT_R8G8_SINT</summary>
		R8g8Sint = unchecked(21),
		// <summary>VK_FORMAT_R8G8_SRGB</summary>
		R8g8Srgb = unchecked(22),
		// <summary>VK_FORMAT_R8G8B8_UNORM</summary>
		R8g8b8Unorm = unchecked(23),
		// <summary>VK_FORMAT_R8G8B8_SNORM</summary>
		R8g8b8Snorm = unchecked(24),
		// <summary>VK_FORMAT_R8G8B8_USCALED</summary>
		R8g8b8Uscaled = unchecked(25),
		// <summary>VK_FORMAT_R8G8B8_SSCALED</summary>
		R8g8b8Sscaled = unchecked(26),
		// <summary>VK_FORMAT_R8G8B8_UINT</summary>
		R8g8b8Uint = unchecked(27),
		// <summary>VK_FORMAT_R8G8B8_SINT</summary>
		R8g8b8Sint = unchecked(28),
		// <summary>VK_FORMAT_R8G8B8_SRGB</summary>
		R8g8b8Srgb = unchecked(29),
		// <summary>VK_FORMAT_B8G8R8_UNORM</summary>
		B8g8r8Unorm = unchecked(30),
		// <summary>VK_FORMAT_B8G8R8_SNORM</summary>
		B8g8r8Snorm = unchecked(31),
		// <summary>VK_FORMAT_B8G8R8_USCALED</summary>
		B8g8r8Uscaled = unchecked(32),
		// <summary>VK_FORMAT_B8G8R8_SSCALED</summary>
		B8g8r8Sscaled = unchecked(33),
		// <summary>VK_FORMAT_B8G8R8_UINT</summary>
		B8g8r8Uint = unchecked(34),
		// <summary>VK_FORMAT_B8G8R8_SINT</summary>
		B8g8r8Sint = unchecked(35),
		// <summary>VK_FORMAT_B8G8R8_SRGB</summary>
		B8g8r8Srgb = unchecked(36),
		// <summary>VK_FORMAT_R8G8B8A8_UNORM</summary>
		R8g8b8a8Unorm = unchecked(37),
		// <summary>VK_FORMAT_R8G8B8A8_SNORM</summary>
		R8g8b8a8Snorm = unchecked(38),
		// <summary>VK_FORMAT_R8G8B8A8_USCALED</summary>
		R8g8b8a8Uscaled = unchecked(39),
		// <summary>VK_FORMAT_R8G8B8A8_SSCALED</summary>
		R8g8b8a8Sscaled = unchecked(40),
		// <summary>VK_FORMAT_R8G8B8A8_UINT</summary>
		R8g8b8a8Uint = unchecked(41),
		// <summary>VK_FORMAT_R8G8B8A8_SINT</summary>
		R8g8b8a8Sint = unchecked(42),
		// <summary>VK_FORMAT_R8G8B8A8_SRGB</summary>
		R8g8b8a8Srgb = unchecked(43),
		// <summary>VK_FORMAT_B8G8R8A8_UNORM</summary>
		B8g8r8a8Unorm = unchecked(44),
		// <summary>VK_FORMAT_B8G8R8A8_SNORM</summary>
		B8g8r8a8Snorm = unchecked(45),
		// <summary>VK_FORMAT_B8G8R8A8_USCALED</summary>
		B8g8r8a8Uscaled = unchecked(46),
		// <summary>VK_FORMAT_B8G8R8A8_SSCALED</summary>
		B8g8r8a8Sscaled = unchecked(47),
		// <summary>VK_FORMAT_B8G8R8A8_UINT</summary>
		B8g8r8a8Uint = unchecked(48),
		// <summary>VK_FORMAT_B8G8R8A8_SINT</summary>
		B8g8r8a8Sint = unchecked(49),
		// <summary>VK_FORMAT_B8G8R8A8_SRGB</summary>
		B8g8r8a8Srgb = unchecked(50),
		// <summary>VK_FORMAT_A8B8G8R8_UNORM_PACK32</summary>
		A8b8g8r8UnormPack32 = unchecked(51),
		// <summary>VK_FORMAT_A8B8G8R8_SNORM_PACK32</summary>
		A8b8g8r8SnormPack32 = unchecked(52),
		// <summary>VK_FORMAT_A8B8G8R8_USCALED_PACK32</summary>
		A8b8g8r8UscaledPack32 = unchecked(53),
		// <summary>VK_FORMAT_A8B8G8R8_SSCALED_PACK32</summary>
		A8b8g8r8SscaledPack32 = unchecked(54),
		// <summary>VK_FORMAT_A8B8G8R8_UINT_PACK32</summary>
		A8b8g8r8UintPack32 = unchecked(55),
		// <summary>VK_FORMAT_A8B8G8R8_SINT_PACK32</summary>
		A8b8g8r8SintPack32 = unchecked(56),
		// <summary>VK_FORMAT_A8B8G8R8_SRGB_PACK32</summary>
		A8b8g8r8SrgbPack32 = unchecked(57),
		// <summary>VK_FORMAT_A2R10G10B10_UNORM_PACK32</summary>
		A2r10g10b10UnormPack32 = unchecked(58),
		// <summary>VK_FORMAT_A2R10G10B10_SNORM_PACK32</summary>
		A2r10g10b10SnormPack32 = unchecked(59),
		// <summary>VK_FORMAT_A2R10G10B10_USCALED_PACK32</summary>
		A2r10g10b10UscaledPack32 = unchecked(60),
		// <summary>VK_FORMAT_A2R10G10B10_SSCALED_PACK32</summary>
		A2r10g10b10SscaledPack32 = unchecked(61),
		// <summary>VK_FORMAT_A2R10G10B10_UINT_PACK32</summary>
		A2r10g10b10UintPack32 = unchecked(62),
		// <summary>VK_FORMAT_A2R10G10B10_SINT_PACK32</summary>
		A2r10g10b10SintPack32 = unchecked(63),
		// <summary>VK_FORMAT_A2B10G10R10_UNORM_PACK32</summary>
		A2b10g10r10UnormPack32 = unchecked(64),
		// <summary>VK_FORMAT_A2B10G10R10_SNORM_PACK32</summary>
		A2b10g10r10SnormPack32 = unchecked(65),
		// <summary>VK_FORMAT_A2B10G10R10_USCALED_PACK32</summary>
		A2b10g10r10UscaledPack32 = unchecked(66),
		// <summary>VK_FORMAT_A2B10G10R10_SSCALED_PACK32</summary>
		A2b10g10r10SscaledPack32 = unchecked(67),
		// <summary>VK_FORMAT_A2B10G10R10_UINT_PACK32</summary>
		A2b10g10r10UintPack32 = unchecked(68),
		// <summary>VK_FORMAT_A2B10G10R10_SINT_PACK32</summary>
		A2b10g10r10SintPack32 = unchecked(69),
		// <summary>VK_FORMAT_R16_UNORM</summary>
		R16Unorm = unchecked(70),
		// <summary>VK_FORMAT_R16_SNORM</summary>
		R16Snorm = unchecked(71),
		// <summary>VK_FORMAT_R16_USCALED</summary>
		R16Uscaled = unchecked(72),
		// <summary>VK_FORMAT_R16_SSCALED</summary>
		R16Sscaled = unchecked(73),
		// <summary>VK_FORMAT_R16_UINT</summary>
		R16Uint = unchecked(74),
		// <summary>VK_FORMAT_R16_SINT</summary>
		R16Sint = unchecked(75),
		// <summary>VK_FORMAT_R16_SFLOAT</summary>
		R16Sfloat = unchecked(76),
		// <summary>VK_FORMAT_R16G16_UNORM</summary>
		R16g16Unorm = unchecked(77),
		// <summary>VK_FORMAT_R16G16_SNORM</summary>
		R16g16Snorm = unchecked(78),
		// <summary>VK_FORMAT_R16G16_USCALED</summary>
		R16g16Uscaled = unchecked(79),
		// <summary>VK_FORMAT_R16G16_SSCALED</summary>
		R16g16Sscaled = unchecked(80),
		// <summary>VK_FORMAT_R16G16_UINT</summary>
		R16g16Uint = unchecked(81),
		// <summary>VK_FORMAT_R16G16_SINT</summary>
		R16g16Sint = unchecked(82),
		// <summary>VK_FORMAT_R16G16_SFLOAT</summary>
		R16g16Sfloat = unchecked(83),
		// <summary>VK_FORMAT_R16G16B16_UNORM</summary>
		R16g16b16Unorm = unchecked(84),
		// <summary>VK_FORMAT_R16G16B16_SNORM</summary>
		R16g16b16Snorm = unchecked(85),
		// <summary>VK_FORMAT_R16G16B16_USCALED</summary>
		R16g16b16Uscaled = unchecked(86),
		// <summary>VK_FORMAT_R16G16B16_SSCALED</summary>
		R16g16b16Sscaled = unchecked(87),
		// <summary>VK_FORMAT_R16G16B16_UINT</summary>
		R16g16b16Uint = unchecked(88),
		// <summary>VK_FORMAT_R16G16B16_SINT</summary>
		R16g16b16Sint = unchecked(89),
		// <summary>VK_FORMAT_R16G16B16_SFLOAT</summary>
		R16g16b16Sfloat = unchecked(90),
		// <summary>VK_FORMAT_R16G16B16A16_UNORM</summary>
		R16g16b16a16Unorm = unchecked(91),
		// <summary>VK_FORMAT_R16G16B16A16_SNORM</summary>
		R16g16b16a16Snorm = unchecked(92),
		// <summary>VK_FORMAT_R16G16B16A16_USCALED</summary>
		R16g16b16a16Uscaled = unchecked(93),
		// <summary>VK_FORMAT_R16G16B16A16_SSCALED</summary>
		R16g16b16a16Sscaled = unchecked(94),
		// <summary>VK_FORMAT_R16G16B16A16_UINT</summary>
		R16g16b16a16Uint = unchecked(95),
		// <summary>VK_FORMAT_R16G16B16A16_SINT</summary>
		R16g16b16a16Sint = unchecked(96),
		// <summary>VK_FORMAT_R16G16B16A16_SFLOAT</summary>
		R16g16b16a16Sfloat = unchecked(97),
		// <summary>VK_FORMAT_R32_UINT</summary>
		R32Uint = unchecked(98),
		// <summary>VK_FORMAT_R32_SINT</summary>
		R32Sint = unchecked(99),
		// <summary>VK_FORMAT_R32_SFLOAT</summary>
		R32Sfloat = unchecked(100),
		// <summary>VK_FORMAT_R32G32_UINT</summary>
		R32g32Uint = unchecked(101),
		// <summary>VK_FORMAT_R32G32_SINT</summary>
		R32g32Sint = unchecked(102),
		// <summary>VK_FORMAT_R32G32_SFLOAT</summary>
		R32g32Sfloat = unchecked(103),
		// <summary>VK_FORMAT_R32G32B32_UINT</summary>
		R32g32b32Uint = unchecked(104),
		// <summary>VK_FORMAT_R32G32B32_SINT</summary>
		R32g32b32Sint = unchecked(105),
		// <summary>VK_FORMAT_R32G32B32_SFLOAT</summary>
		R32g32b32Sfloat = unchecked(106),
		// <summary>VK_FORMAT_R32G32B32A32_UINT</summary>
		R32g32b32a32Uint = unchecked(107),
		// <summary>VK_FORMAT_R32G32B32A32_SINT</summary>
		R32g32b32a32Sint = unchecked(108),
		// <summary>VK_FORMAT_R32G32B32A32_SFLOAT</summary>
		R32g32b32a32Sfloat = unchecked(109),
		// <summary>VK_FORMAT_R64_UINT</summary>
		R64Uint = unchecked(110),
		// <summary>VK_FORMAT_R64_SINT</summary>
		R64Sint = unchecked(111),
		// <summary>VK_FORMAT_R64_SFLOAT</summary>
		R64Sfloat = unchecked(112),
		// <summary>VK_FORMAT_R64G64_UINT</summary>
		R64g64Uint = unchecked(113),
		// <summary>VK_FORMAT_R64G64_SINT</summary>
		R64g64Sint = unchecked(114),
		// <summary>VK_FORMAT_R64G64_SFLOAT</summary>
		R64g64Sfloat = unchecked(115),
		// <summary>VK_FORMAT_R64G64B64_UINT</summary>
		R64g64b64Uint = unchecked(116),
		// <summary>VK_FORMAT_R64G64B64_SINT</summary>
		R64g64b64Sint = unchecked(117),
		// <summary>VK_FORMAT_R64G64B64_SFLOAT</summary>
		R64g64b64Sfloat = unchecked(118),
		// <summary>VK_FORMAT_R64G64B64A64_UINT</summary>
		R64g64b64a64Uint = unchecked(119),
		// <summary>VK_FORMAT_R64G64B64A64_SINT</summary>
		R64g64b64a64Sint = unchecked(120),
		// <summary>VK_FORMAT_R64G64B64A64_SFLOAT</summary>
		R64g64b64a64Sfloat = unchecked(121),
		// <summary>VK_FORMAT_B10G11R11_UFLOAT_PACK32</summary>
		B10g11r11UfloatPack32 = unchecked(122),
		// <summary>VK_FORMAT_E5B9G9R9_UFLOAT_PACK32</summary>
		E5b9g9r9UfloatPack32 = unchecked(123),
		// <summary>VK_FORMAT_D16_UNORM</summary>
		D16Unorm = unchecked(124),
		// <summary>VK_FORMAT_X8_D24_UNORM_PACK32</summary>
		X8D24UnormPack32 = unchecked(125),
		// <summary>VK_FORMAT_D32_SFLOAT</summary>
		D32Sfloat = unchecked(126),
		// <summary>VK_FORMAT_S8_UINT</summary>
		S8Uint = unchecked(127),
		// <summary>VK_FORMAT_D16_UNORM_S8_UINT</summary>
		D16UnormS8Uint = unchecked(128),
		// <summary>VK_FORMAT_D24_UNORM_S8_UINT</summary>
		D24UnormS8Uint = unchecked(129),
		// <summary>VK_FORMAT_D32_SFLOAT_S8_UINT</summary>
		D32SfloatS8Uint = unchecked(130),
		// <summary>VK_FORMAT_BC1_RGB_UNORM_BLOCK</summary>
		Bc1RgbUnormBlock = unchecked(131),
		// <summary>VK_FORMAT_BC1_RGB_SRGB_BLOCK</summary>
		Bc1RgbSrgbBlock = unchecked(132),
		// <summary>VK_FORMAT_BC1_RGBA_UNORM_BLOCK</summary>
		Bc1RgbaUnormBlock = unchecked(133),
		// <summary>VK_FORMAT_BC1_RGBA_SRGB_BLOCK</summary>
		Bc1RgbaSrgbBlock = unchecked(134),
		// <summary>VK_FORMAT_BC2_UNORM_BLOCK</summary>
		Bc2UnormBlock = unchecked(135),
		// <summary>VK_FORMAT_BC2_SRGB_BLOCK</summary>
		Bc2SrgbBlock = unchecked(136),
		// <summary>VK_FORMAT_BC3_UNORM_BLOCK</summary>
		Bc3UnormBlock = unchecked(137),
		// <summary>VK_FORMAT_BC3_SRGB_BLOCK</summary>
		Bc3SrgbBlock = unchecked(138),
		// <summary>VK_FORMAT_BC4_UNORM_BLOCK</summary>
		Bc4UnormBlock = unchecked(139),
		// <summary>VK_FORMAT_BC4_SNORM_BLOCK</summary>
		Bc4SnormBlock = unchecked(140),
		// <summary>VK_FORMAT_BC5_UNORM_BLOCK</summary>
		Bc5UnormBlock = unchecked(141),
		// <summary>VK_FORMAT_BC5_SNORM_BLOCK</summary>
		Bc5SnormBlock = unchecked(142),
		// <summary>VK_FORMAT_BC6H_UFLOAT_BLOCK</summary>
		Bc6hUfloatBlock = unchecked(143),
		// <summary>VK_FORMAT_BC6H_SFLOAT_BLOCK</summary>
		Bc6hSfloatBlock = unchecked(144),
		// <summary>VK_FORMAT_BC7_UNORM_BLOCK</summary>
		Bc7UnormBlock = unchecked(145),
		// <summary>VK_FORMAT_BC7_SRGB_BLOCK</summary>
		Bc7SrgbBlock = unchecked(146),
		// <summary>VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK</summary>
		Etc2R8g8b8UnormBlock = unchecked(147),
		// <summary>VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK</summary>
		Etc2R8g8b8SrgbBlock = unchecked(148),
		// <summary>VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK</summary>
		Etc2R8g8b8a1UnormBlock = unchecked(149),
		// <summary>VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK</summary>
		Etc2R8g8b8a1SrgbBlock = unchecked(150),
		// <summary>VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK</summary>
		Etc2R8g8b8a8UnormBlock = unchecked(151),
		// <summary>VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK</summary>
		Etc2R8g8b8a8SrgbBlock = unchecked(152),
		// <summary>VK_FORMAT_EAC_R11_UNORM_BLOCK</summary>
		EacR11UnormBlock = unchecked(153),
		// <summary>VK_FORMAT_EAC_R11_SNORM_BLOCK</summary>
		EacR11SnormBlock = unchecked(154),
		// <summary>VK_FORMAT_EAC_R11G11_UNORM_BLOCK</summary>
		EacR11g11UnormBlock = unchecked(155),
		// <summary>VK_FORMAT_EAC_R11G11_SNORM_BLOCK</summary>
		EacR11g11SnormBlock = unchecked(156),
		// <summary>VK_FORMAT_ASTC_4x4_UNORM_BLOCK</summary>
		Astc4x4UnormBlock = unchecked(157),
		// <summary>VK_FORMAT_ASTC_4x4_SRGB_BLOCK</summary>
		Astc4x4SrgbBlock = unchecked(158),
		// <summary>VK_FORMAT_ASTC_5x4_UNORM_BLOCK</summary>
		Astc5x4UnormBlock = unchecked(159),
		// <summary>VK_FORMAT_ASTC_5x4_SRGB_BLOCK</summary>
		Astc5x4SrgbBlock = unchecked(160),
		// <summary>VK_FORMAT_ASTC_5x5_UNORM_BLOCK</summary>
		Astc5x5UnormBlock = unchecked(161),
		// <summary>VK_FORMAT_ASTC_5x5_SRGB_BLOCK</summary>
		Astc5x5SrgbBlock = unchecked(162),
		// <summary>VK_FORMAT_ASTC_6x5_UNORM_BLOCK</summary>
		Astc6x5UnormBlock = unchecked(163),
		// <summary>VK_FORMAT_ASTC_6x5_SRGB_BLOCK</summary>
		Astc6x5SrgbBlock = unchecked(164),
		// <summary>VK_FORMAT_ASTC_6x6_UNORM_BLOCK</summary>
		Astc6x6UnormBlock = unchecked(165),
		// <summary>VK_FORMAT_ASTC_6x6_SRGB_BLOCK</summary>
		Astc6x6SrgbBlock = unchecked(166),
		// <summary>VK_FORMAT_ASTC_8x5_UNORM_BLOCK</summary>
		Astc8x5UnormBlock = unchecked(167),
		// <summary>VK_FORMAT_ASTC_8x5_SRGB_BLOCK</summary>
		Astc8x5SrgbBlock = unchecked(168),
		// <summary>VK_FORMAT_ASTC_8x6_UNORM_BLOCK</summary>
		Astc8x6UnormBlock = unchecked(169),
		// <summary>VK_FORMAT_ASTC_8x6_SRGB_BLOCK</summary>
		Astc8x6SrgbBlock = unchecked(170),
		// <summary>VK_FORMAT_ASTC_8x8_UNORM_BLOCK</summary>
		Astc8x8UnormBlock = unchecked(171),
		// <summary>VK_FORMAT_ASTC_8x8_SRGB_BLOCK</summary>
		Astc8x8SrgbBlock = unchecked(172),
		// <summary>VK_FORMAT_ASTC_10x5_UNORM_BLOCK</summary>
		Astc10x5UnormBlock = unchecked(173),
		// <summary>VK_FORMAT_ASTC_10x5_SRGB_BLOCK</summary>
		Astc10x5SrgbBlock = unchecked(174),
		// <summary>VK_FORMAT_ASTC_10x6_UNORM_BLOCK</summary>
		Astc10x6UnormBlock = unchecked(175),
		// <summary>VK_FORMAT_ASTC_10x6_SRGB_BLOCK</summary>
		Astc10x6SrgbBlock = unchecked(176),
		// <summary>VK_FORMAT_ASTC_10x8_UNORM_BLOCK</summary>
		Astc10x8UnormBlock = unchecked(177),
		// <summary>VK_FORMAT_ASTC_10x8_SRGB_BLOCK</summary>
		Astc10x8SrgbBlock = unchecked(178),
		// <summary>VK_FORMAT_ASTC_10x10_UNORM_BLOCK</summary>
		Astc10x10UnormBlock = unchecked(179),
		// <summary>VK_FORMAT_ASTC_10x10_SRGB_BLOCK</summary>
		Astc10x10SrgbBlock = unchecked(180),
		// <summary>VK_FORMAT_ASTC_12x10_UNORM_BLOCK</summary>
		Astc12x10UnormBlock = unchecked(181),
		// <summary>VK_FORMAT_ASTC_12x10_SRGB_BLOCK</summary>
		Astc12x10SrgbBlock = unchecked(182),
		// <summary>VK_FORMAT_ASTC_12x12_UNORM_BLOCK</summary>
		Astc12x12UnormBlock = unchecked(183),
		// <summary>VK_FORMAT_ASTC_12x12_SRGB_BLOCK</summary>
		Astc12x12SrgbBlock = unchecked(184),
		// <summary>VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG</summary>
		Pvrtc12bppUnormBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 0)),
		// <summary>VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG</summary>
		Pvrtc14bppUnormBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 1)),
		// <summary>VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG</summary>
		Pvrtc22bppUnormBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 2)),
		// <summary>VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG</summary>
		Pvrtc24bppUnormBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 3)),
		// <summary>VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG</summary>
		Pvrtc12bppSrgbBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 4)),
		// <summary>VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG</summary>
		Pvrtc14bppSrgbBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 5)),
		// <summary>VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG</summary>
		Pvrtc22bppSrgbBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 6)),
		// <summary>VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG</summary>
		Pvrtc24bppSrgbBlockImg = unchecked((1000000000 + 1000 * (55 - 1) + 7)),
	}
	// <summary>VkFormatFeatureFlagBits</summary>
	[Flags]
	public enum FormatFeatureFlagBits
	{
		// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</summary>
		FeatureSampledImageBit = unchecked(1 << 0),
		// <summary>VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT</summary>
		FeatureStorageImageBit = unchecked(1 << 1),
		// <summary>VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT</summary>
		FeatureStorageImageAtomicBit = unchecked(1 << 2),
		// <summary>VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT</summary>
		FeatureUniformTexelBufferBit = unchecked(1 << 3),
		// <summary>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT</summary>
		FeatureStorageTexelBufferBit = unchecked(1 << 4),
		// <summary>VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT</summary>
		FeatureStorageTexelBufferAtomicBit = unchecked(1 << 5),
		// <summary>VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT</summary>
		FeatureVertexBufferBit = unchecked(1 << 6),
		// <summary>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT</summary>
		FeatureColorAttachmentBit = unchecked(1 << 7),
		// <summary>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT</summary>
		FeatureColorAttachmentBlendBit = unchecked(1 << 8),
		// <summary>VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT</summary>
		FeatureDepthStencilAttachmentBit = unchecked(1 << 9),
		// <summary>VK_FORMAT_FEATURE_BLIT_SRC_BIT</summary>
		FeatureBlitSourceBit = unchecked(1 << 10),
		// <summary>VK_FORMAT_FEATURE_BLIT_DST_BIT</summary>
		FeatureBlitDestinationBit = unchecked(1 << 11),
		// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT</summary>
		FeatureSampledImageFilterLinearBit = unchecked(1 << 12),
		// <summary>VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG</summary>
		FeatureSampledImageFilterCubicBitImg = unchecked(1 << 13),
	}
	// <summary>VkFrontFace</summary>
	public enum FrontFace
	{
		// <summary>VK_FRONT_FACE_COUNTER_CLOCKWISE</summary>
		CounterClockwise = unchecked(0),
		// <summary>VK_FRONT_FACE_CLOCKWISE</summary>
		Clockwise = unchecked(1),
	}
	// <summary>VkImageAspectFlagBits</summary>
	[Flags]
	public enum ImageAspectFlagBits
	{
		// <summary>VK_IMAGE_ASPECT_COLOR_BIT</summary>
		ColorBit = unchecked(1 << 0),
		// <summary>VK_IMAGE_ASPECT_DEPTH_BIT</summary>
		DepthBit = unchecked(1 << 1),
		// <summary>VK_IMAGE_ASPECT_STENCIL_BIT</summary>
		StencilBit = unchecked(1 << 2),
		// <summary>VK_IMAGE_ASPECT_METADATA_BIT</summary>
		MetadataBit = unchecked(1 << 3),
	}
	// <summary>VkImageCreateFlagBits</summary>
	[Flags]
	public enum ImageCreateFlagBits
	{
		// <summary>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</summary>
		SparseBindingBit = unchecked(1 << 0),
		// <summary>VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT</summary>
		SparseResidencyBit = unchecked(1 << 1),
		// <summary>VK_IMAGE_CREATE_SPARSE_ALIASED_BIT</summary>
		SparseAliasedBit = unchecked(1 << 2),
		// <summary>VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT</summary>
		MutableFormatBit = unchecked(1 << 3),
		// <summary>VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT</summary>
		CubeCompatibleBit = unchecked(1 << 4),
	}
	// <summary>VkImageLayout</summary>
	public enum ImageLayout
	{
		// <summary>VK_IMAGE_LAYOUT_UNDEFINED</summary>
		Undefined = unchecked(0),
		// <summary>VK_IMAGE_LAYOUT_GENERAL</summary>
		General = unchecked(1),
		// <summary>VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL</summary>
		ColorAttachmentOptimal = unchecked(2),
		// <summary>VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL</summary>
		DepthStencilAttachmentOptimal = unchecked(3),
		// <summary>VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL</summary>
		DepthStencilReadOnlyOptimal = unchecked(4),
		// <summary>VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL</summary>
		ShaderReadOnlyOptimal = unchecked(5),
		// <summary>VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL</summary>
		TransferSourceOptimal = unchecked(6),
		// <summary>VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL</summary>
		TransferDestinationOptimal = unchecked(7),
		// <summary>VK_IMAGE_LAYOUT_PREINITIALIZED</summary>
		Preinitialized = unchecked(8),
		// <summary>VK_IMAGE_LAYOUT_PRESENT_SRC_KHR</summary>
		PresentSourceKhr = unchecked((1000000000 + 1000 * (2 - 1) + 2)),
	}
	// <summary>VkImageTiling</summary>
	public enum ImageTiling
	{
		// <summary>VK_IMAGE_TILING_OPTIMAL</summary>
		Optimal = unchecked(0),
		// <summary>VK_IMAGE_TILING_LINEAR</summary>
		Linear = unchecked(1),
	}
	// <summary>VkImageType</summary>
	public enum ImageType
	{
		// <summary>VK_IMAGE_TYPE_1D</summary>
		_1d = unchecked(0),
		// <summary>VK_IMAGE_TYPE_2D</summary>
		_2d = unchecked(1),
		// <summary>VK_IMAGE_TYPE_3D</summary>
		_3d = unchecked(2),
	}
	// <summary>VkImageUsageFlagBits</summary>
	[Flags]
	public enum ImageUsageFlagBits
	{
		// <summary>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</summary>
		TransferSourceBit = unchecked(1 << 0),
		// <summary>VK_IMAGE_USAGE_TRANSFER_DST_BIT</summary>
		TransferDestinationBit = unchecked(1 << 1),
		// <summary>VK_IMAGE_USAGE_SAMPLED_BIT</summary>
		SampledBit = unchecked(1 << 2),
		// <summary>VK_IMAGE_USAGE_STORAGE_BIT</summary>
		StorageBit = unchecked(1 << 3),
		// <summary>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT</summary>
		ColorAttachmentBit = unchecked(1 << 4),
		// <summary>VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT</summary>
		DepthStencilAttachmentBit = unchecked(1 << 5),
		// <summary>VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT</summary>
		TransientAttachmentBit = unchecked(1 << 6),
		// <summary>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</summary>
		InputAttachmentBit = unchecked(1 << 7),
	}
	// <summary>VkImageViewType</summary>
	public enum ImageViewType
	{
		// <summary>VK_IMAGE_VIEW_TYPE_1D</summary>
		_1d = unchecked(0),
		// <summary>VK_IMAGE_VIEW_TYPE_2D</summary>
		_2d = unchecked(1),
		// <summary>VK_IMAGE_VIEW_TYPE_3D</summary>
		_3d = unchecked(2),
		// <summary>VK_IMAGE_VIEW_TYPE_CUBE</summary>
		Cube = unchecked(3),
		// <summary>VK_IMAGE_VIEW_TYPE_1D_ARRAY</summary>
		_1dArray = unchecked(4),
		// <summary>VK_IMAGE_VIEW_TYPE_2D_ARRAY</summary>
		_2dArray = unchecked(5),
		// <summary>VK_IMAGE_VIEW_TYPE_CUBE_ARRAY</summary>
		CubeArray = unchecked(6),
	}
	// <summary>VkIndexType</summary>
	public enum IndexType
	{
		// <summary>VK_INDEX_TYPE_UINT16</summary>
		Uint16 = unchecked(0),
		// <summary>VK_INDEX_TYPE_UINT32</summary>
		Uint32 = unchecked(1),
	}
	// <summary>VkIndirectCommandsLayoutUsageFlagBitsNVX</summary>
	[Flags]
	public enum IndirectCommandsLayoutUsageFlagBitsNVX
	{
		// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX</summary>
		IndirectCommandsLayoutUsageUnorderedSequencesBitNvx = unchecked(1 << 0),
		// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_SPARSE_SEQUENCES_BIT_NVX</summary>
		IndirectCommandsLayoutUsageSparseSequencesBitNvx = unchecked(1 << 1),
		// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EMPTY_EXECUTIONS_BIT_NVX</summary>
		IndirectCommandsLayoutUsageEmptyExecutionsBitNvx = unchecked(1 << 2),
		// <summary>VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX</summary>
		IndirectCommandsLayoutUsageIndexedSequencesBitNvx = unchecked(1 << 3),
	}
	// <summary>VkIndirectCommandsTokenTypeNVX</summary>
	public enum IndirectCommandsTokenTypeNVX
	{
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_PIPELINE_NVX</summary>
		IndirectCommandsTokenPipelineNvx = unchecked(0),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_DESCRIPTOR_SET_NVX</summary>
		IndirectCommandsTokenDescriptorSetNvx = unchecked(1),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_INDEX_BUFFER_NVX</summary>
		IndirectCommandsTokenIndexBufferNvx = unchecked(2),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_VERTEX_BUFFER_NVX</summary>
		IndirectCommandsTokenVertexBufferNvx = unchecked(3),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_PUSH_CONSTANT_NVX</summary>
		IndirectCommandsTokenPushConstantNvx = unchecked(4),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_DRAW_INDEXED_NVX</summary>
		IndirectCommandsTokenDrawIndexedNvx = unchecked(5),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_DRAW_NVX</summary>
		IndirectCommandsTokenDrawNvx = unchecked(6),
		// <summary>VK_INDIRECT_COMMANDS_TOKEN_DISPATCH_NVX</summary>
		IndirectCommandsTokenDispatchNvx = unchecked(7),
	}
	// <summary>VkInternalAllocationType</summary>
	public enum InternalAllocationType
	{
		// <summary>VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE</summary>
		Executable = unchecked(0),
	}
	// <summary>VkLogicOp</summary>
	public enum LogicOperation
	{
		// <summary>VK_LOGIC_OP_CLEAR</summary>
		Clear = unchecked(0),
		// <summary>VK_LOGIC_OP_AND</summary>
		And = unchecked(1),
		// <summary>VK_LOGIC_OP_AND_REVERSE</summary>
		AndReverse = unchecked(2),
		// <summary>VK_LOGIC_OP_COPY</summary>
		Copy = unchecked(3),
		// <summary>VK_LOGIC_OP_AND_INVERTED</summary>
		AndInverted = unchecked(4),
		// <summary>VK_LOGIC_OP_NO_OP</summary>
		NoOperation = unchecked(5),
		// <summary>VK_LOGIC_OP_XOR</summary>
		Xor = unchecked(6),
		// <summary>VK_LOGIC_OP_OR</summary>
		Or = unchecked(7),
		// <summary>VK_LOGIC_OP_NOR</summary>
		Nor = unchecked(8),
		// <summary>VK_LOGIC_OP_EQUIVALENT</summary>
		Equivalent = unchecked(9),
		// <summary>VK_LOGIC_OP_INVERT</summary>
		Invert = unchecked(10),
		// <summary>VK_LOGIC_OP_OR_REVERSE</summary>
		OrReverse = unchecked(11),
		// <summary>VK_LOGIC_OP_COPY_INVERTED</summary>
		CopyInverted = unchecked(12),
		// <summary>VK_LOGIC_OP_OR_INVERTED</summary>
		OrInverted = unchecked(13),
		// <summary>VK_LOGIC_OP_NAND</summary>
		Nand = unchecked(14),
		// <summary>VK_LOGIC_OP_SET</summary>
		Set = unchecked(15),
	}
	// <summary>VkMemoryHeapFlagBits</summary>
	[Flags]
	public enum MemoryHeapFlagBits
	{
		// <summary>VK_MEMORY_HEAP_DEVICE_LOCAL_BIT</summary>
		DeviceLocalBit = unchecked(1 << 0),
	}
	// <summary>VkMemoryPropertyFlagBits</summary>
	[Flags]
	public enum MemoryPropertyFlagBits
	{
		// <summary>VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT</summary>
		DeviceLocalBit = unchecked(1 << 0),
		// <summary>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT</summary>
		HostVisibleBit = unchecked(1 << 1),
		// <summary>VK_MEMORY_PROPERTY_HOST_COHERENT_BIT</summary>
		HostCoherentBit = unchecked(1 << 2),
		// <summary>VK_MEMORY_PROPERTY_HOST_CACHED_BIT</summary>
		HostCachedBit = unchecked(1 << 3),
		// <summary>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</summary>
		LazilyAllocatedBit = unchecked(1 << 4),
	}
	// <summary>VkObjectEntryTypeNVX</summary>
	public enum ObjectEntryTypeNVX
	{
		// <summary>VK_OBJECT_ENTRY_DESCRIPTOR_SET_NVX</summary>
		ObjectEntryDescriptorSetNvx = unchecked(0),
		// <summary>VK_OBJECT_ENTRY_PIPELINE_NVX</summary>
		ObjectEntryPipelineNvx = unchecked(1),
		// <summary>VK_OBJECT_ENTRY_INDEX_BUFFER_NVX</summary>
		ObjectEntryIndexBufferNvx = unchecked(2),
		// <summary>VK_OBJECT_ENTRY_VERTEX_BUFFER_NVX</summary>
		ObjectEntryVertexBufferNvx = unchecked(3),
		// <summary>VK_OBJECT_ENTRY_PUSH_CONSTANT_NVX</summary>
		ObjectEntryPushConstantNvx = unchecked(4),
	}
	// <summary>VkObjectEntryUsageFlagBitsNVX</summary>
	[Flags]
	public enum ObjectEntryUsageFlagBitsNVX
	{
		// <summary>VK_OBJECT_ENTRY_USAGE_GRAPHICS_BIT_NVX</summary>
		ObjectEntryUsageGraphicsBitNvx = unchecked(1 << 0),
		// <summary>VK_OBJECT_ENTRY_USAGE_COMPUTE_BIT_NVX</summary>
		ObjectEntryUsageComputeBitNvx = unchecked(1 << 1),
	}
	// <summary>VkPhysicalDeviceType</summary>
	public enum PhysicalDeviceType
	{
		// <summary>VK_PHYSICAL_DEVICE_TYPE_OTHER</summary>
		Other = unchecked(0),
		// <summary>VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU</summary>
		IntegratedGpu = unchecked(1),
		// <summary>VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU</summary>
		DiscreteGpu = unchecked(2),
		// <summary>VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU</summary>
		VirtualGpu = unchecked(3),
		// <summary>VK_PHYSICAL_DEVICE_TYPE_CPU</summary>
		Cpu = unchecked(4),
	}
	// <summary>VkPipelineBindPoint</summary>
	public enum PipelineBindPoint
	{
		// <summary>VK_PIPELINE_BIND_POINT_GRAPHICS</summary>
		Graphics = unchecked(0),
		// <summary>VK_PIPELINE_BIND_POINT_COMPUTE</summary>
		Compute = unchecked(1),
	}
	// <summary>VkPipelineCacheHeaderVersion</summary>
	public enum PipelineCacheHeaderVersion
	{
		// <summary>VK_PIPELINE_CACHE_HEADER_VERSION_ONE</summary>
		One = unchecked(1),
	}
	// <summary>VkPipelineCreateFlagBits</summary>
	[Flags]
	public enum PipelineCreateFlagBits
	{
		// <summary>VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT</summary>
		DisableOptimizationBit = unchecked(1 << 0),
		// <summary>VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT</summary>
		AllowDerivativesBit = unchecked(1 << 1),
		// <summary>VK_PIPELINE_CREATE_DERIVATIVE_BIT</summary>
		DerivativeBit = unchecked(1 << 2),
	}
	// <summary>VkPipelineStageFlagBits</summary>
	[Flags]
	public enum PipelineStageFlagBits
	{
		// <summary>VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT</summary>
		TopOfPipeBit = unchecked(1 << 0),
		// <summary>VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT</summary>
		DrawIndirectBit = unchecked(1 << 1),
		// <summary>VK_PIPELINE_STAGE_VERTEX_INPUT_BIT</summary>
		VertexInputBit = unchecked(1 << 2),
		// <summary>VK_PIPELINE_STAGE_VERTEX_SHADER_BIT</summary>
		VertexShaderBit = unchecked(1 << 3),
		// <summary>VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT</summary>
		TessellationControlShaderBit = unchecked(1 << 4),
		// <summary>VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT</summary>
		TessellationEvaluationShaderBit = unchecked(1 << 5),
		// <summary>VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT</summary>
		GeometryShaderBit = unchecked(1 << 6),
		// <summary>VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT</summary>
		FragmentShaderBit = unchecked(1 << 7),
		// <summary>VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT</summary>
		EarlyFragmentTestsBit = unchecked(1 << 8),
		// <summary>VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT</summary>
		LateFragmentTestsBit = unchecked(1 << 9),
		// <summary>VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT</summary>
		ColorAttachmentOutputBit = unchecked(1 << 10),
		// <summary>VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT</summary>
		ComputeShaderBit = unchecked(1 << 11),
		// <summary>VK_PIPELINE_STAGE_TRANSFER_BIT</summary>
		TransferBit = unchecked(1 << 12),
		// <summary>VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT</summary>
		BottomOfPipeBit = unchecked(1 << 13),
		// <summary>VK_PIPELINE_STAGE_HOST_BIT</summary>
		HostBit = unchecked(1 << 14),
		// <summary>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</summary>
		AllGraphicsBit = unchecked(1 << 15),
		// <summary>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</summary>
		AllCommandsBit = unchecked(1 << 16),
		// <summary>VK_PIPELINE_STAGE_COMMAND_PROCESS_BIT_NVX</summary>
		CommandProcessBitNvx = unchecked(1 << 17),
	}
	// <summary>VkPolygonMode</summary>
	public enum PolygonMode
	{
		// <summary>VK_POLYGON_MODE_FILL</summary>
		Fill = unchecked(0),
		// <summary>VK_POLYGON_MODE_LINE</summary>
		Line = unchecked(1),
		// <summary>VK_POLYGON_MODE_POINT</summary>
		Point = unchecked(2),
	}
	// <summary>VkPresentModeKHR</summary>
	public enum PresentModeKHR
	{
		// <summary>VK_PRESENT_MODE_IMMEDIATE_KHR</summary>
		ImmediateKhr = unchecked(0),
		// <summary>VK_PRESENT_MODE_MAILBOX_KHR</summary>
		MailboxKhr = unchecked(1),
		// <summary>VK_PRESENT_MODE_FIFO_KHR</summary>
		FifoKhr = unchecked(2),
		// <summary>VK_PRESENT_MODE_FIFO_RELAXED_KHR</summary>
		FifoRelaxedKhr = unchecked(3),
	}
	// <summary>VkPrimitiveTopology</summary>
	public enum PrimitiveTopology
	{
		// <summary>VK_PRIMITIVE_TOPOLOGY_POINT_LIST</summary>
		PointList = unchecked(0),
		// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_LIST</summary>
		LineList = unchecked(1),
		// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP</summary>
		LineStrip = unchecked(2),
		// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST</summary>
		TriangleList = unchecked(3),
		// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP</summary>
		TriangleStrip = unchecked(4),
		// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN</summary>
		TriangleFan = unchecked(5),
		// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY</summary>
		LineListWithAdjacency = unchecked(6),
		// <summary>VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY</summary>
		LineStripWithAdjacency = unchecked(7),
		// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY</summary>
		TriangleListWithAdjacency = unchecked(8),
		// <summary>VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY</summary>
		TriangleStripWithAdjacency = unchecked(9),
		// <summary>VK_PRIMITIVE_TOPOLOGY_PATCH_LIST</summary>
		PatchList = unchecked(10),
	}
	// <summary>VkQueryControlFlagBits</summary>
	[Flags]
	public enum QueryControlFlagBits
	{
		// <summary>VK_QUERY_CONTROL_PRECISE_BIT</summary>
		PreciseBit = unchecked(1 << 0),
	}
	// <summary>VkQueryPipelineStatisticFlagBits</summary>
	[Flags]
	public enum QueryPipelineStatisticFlagBits
	{
		// <summary>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT</summary>
		InputAssemblyVerticesBit = unchecked(1 << 0),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT</summary>
		InputAssemblyPrimitivesBit = unchecked(1 << 1),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT</summary>
		VertexShaderInvocationsBit = unchecked(1 << 2),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT</summary>
		GeometryShaderInvocationsBit = unchecked(1 << 3),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT</summary>
		GeometryShaderPrimitivesBit = unchecked(1 << 4),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT</summary>
		ClippingInvocationsBit = unchecked(1 << 5),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT</summary>
		ClippingPrimitivesBit = unchecked(1 << 6),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT</summary>
		FragmentShaderInvocationsBit = unchecked(1 << 7),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT</summary>
		TessellationControlShaderPatchesBit = unchecked(1 << 8),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT</summary>
		TessellationEvaluationShaderInvocationsBit = unchecked(1 << 9),
		// <summary>VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT</summary>
		ComputeShaderInvocationsBit = unchecked(1 << 10),
	}
	// <summary>VkQueryResultFlagBits</summary>
	[Flags]
	public enum QueryResultFlagBits
	{
		// <summary>VK_QUERY_RESULT_64_BIT</summary>
		_64Bit = unchecked(1 << 0),
		// <summary>VK_QUERY_RESULT_WAIT_BIT</summary>
		WaitBit = unchecked(1 << 1),
		// <summary>VK_QUERY_RESULT_WITH_AVAILABILITY_BIT</summary>
		WithAvailabilityBit = unchecked(1 << 2),
		// <summary>VK_QUERY_RESULT_PARTIAL_BIT</summary>
		PartialBit = unchecked(1 << 3),
	}
	// <summary>VkQueryType</summary>
	public enum QueryType
	{
		// <summary>VK_QUERY_TYPE_OCCLUSION</summary>
		Occlusion = unchecked(0),
		// <summary>VK_QUERY_TYPE_PIPELINE_STATISTICS</summary>
		PipelineStatistics = unchecked(1),
		// <summary>VK_QUERY_TYPE_TIMESTAMP</summary>
		Timestamp = unchecked(2),
	}
	// <summary>VkQueueFlagBits</summary>
	[Flags]
	public enum QueueFlagBits
	{
		// <summary>VK_QUEUE_GRAPHICS_BIT</summary>
		GraphicsBit = unchecked(1 << 0),
		// <summary>VK_QUEUE_COMPUTE_BIT</summary>
		ComputeBit = unchecked(1 << 1),
		// <summary>VK_QUEUE_TRANSFER_BIT</summary>
		TransferBit = unchecked(1 << 2),
		// <summary>VK_QUEUE_SPARSE_BINDING_BIT</summary>
		SparseBindingBit = unchecked(1 << 3),
	}
	// <summary>VkRasterizationOrderAMD</summary>
	public enum RasterizationOrderAMD
	{
		// <summary>VK_RASTERIZATION_ORDER_STRICT_AMD</summary>
		StrictAmd = unchecked(0),
		// <summary>VK_RASTERIZATION_ORDER_RELAXED_AMD</summary>
		RelaxedAmd = unchecked(1),
	}
	// <summary>VkResult</summary>
	public enum Result
	{
		// <summary>VK_SUCCESS</summary>
		Success = unchecked(0),
		// <summary>VK_NOT_READY</summary>
		NotReady = unchecked(1),
		// <summary>VK_TIMEOUT</summary>
		Timeout = unchecked(2),
		// <summary>VK_EVENT_SET</summary>
		EventSet = unchecked(3),
		// <summary>VK_EVENT_RESET</summary>
		EventReset = unchecked(4),
		// <summary>VK_INCOMPLETE</summary>
		Incomplete = unchecked(5),
		// <summary>VK_ERROR_OUT_OF_HOST_MEMORY</summary>
		ErrorOutOfHostMemory = unchecked(-1),
		// <summary>VK_ERROR_OUT_OF_DEVICE_MEMORY</summary>
		ErrorOutOfDeviceMemory = unchecked(-2),
		// <summary>VK_ERROR_INITIALIZATION_FAILED</summary>
		ErrorInitializationFailed = unchecked(-3),
		// <summary>VK_ERROR_DEVICE_LOST</summary>
		ErrorDeviceLost = unchecked(-4),
		// <summary>VK_ERROR_MEMORY_MAP_FAILED</summary>
		ErrorMemoryMapFailed = unchecked(-5),
		// <summary>VK_ERROR_LAYER_NOT_PRESENT</summary>
		ErrorLayerNotPresent = unchecked(-6),
		// <summary>VK_ERROR_EXTENSION_NOT_PRESENT</summary>
		ErrorExtensionNotPresent = unchecked(-7),
		// <summary>VK_ERROR_FEATURE_NOT_PRESENT</summary>
		ErrorFeatureNotPresent = unchecked(-8),
		// <summary>VK_ERROR_INCOMPATIBLE_DRIVER</summary>
		ErrorIncompatibleDriver = unchecked(-9),
		// <summary>VK_ERROR_TOO_MANY_OBJECTS</summary>
		ErrorTooManyObjects = unchecked(-10),
		// <summary>VK_ERROR_FORMAT_NOT_SUPPORTED</summary>
		ErrorFormatNotSupported = unchecked(-11),
		// <summary>VK_ERROR_FRAGMENTED_POOL</summary>
		ErrorFragmentedPool = unchecked(-12),
		// <summary>VK_ERROR_SURFACE_LOST_KHR</summary>
		ErrorSurfaceLostKhr = unchecked(-(1000000000 + 1000 * (1 - 1) + 0)),
		// <summary>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</summary>
		ErrorNativeWindowInUseKhr = unchecked(-(1000000000 + 1000 * (1 - 1) + 1)),
		// <summary>VK_SUBOPTIMAL_KHR</summary>
		SuboptimalKhr = unchecked((1000000000 + 1000 * (2 - 1) + 3)),
		// <summary>VK_ERROR_OUT_OF_DATE_KHR</summary>
		ErrorOutOfDateKhr = unchecked(-(1000000000 + 1000 * (2 - 1) + 4)),
		// <summary>VK_ERROR_INCOMPATIBLE_DISPLAY_KHR</summary>
		ErrorIncompatibleDisplayKhr = unchecked(-(1000000000 + 1000 * (4 - 1) + 1)),
		// <summary>VK_ERROR_VALIDATION_FAILED_EXT</summary>
		ErrorValidationFailedExt = unchecked(-(1000000000 + 1000 * (12 - 1) + 1)),
		// <summary>VK_ERROR_INVALID_SHADER_NV</summary>
		ErrorInvalidShaderNv = unchecked(-(1000000000 + 1000 * (13 - 1) + 0)),
	}
	// <summary>VkSampleCountFlagBits</summary>
	[Flags]
	public enum SampleCountFlagBits
	{
		// <summary>VK_SAMPLE_COUNT_1_BIT</summary>
		_1Bit = unchecked(1 << 0),
		// <summary>VK_SAMPLE_COUNT_2_BIT</summary>
		_2Bit = unchecked(1 << 1),
		// <summary>VK_SAMPLE_COUNT_4_BIT</summary>
		_4Bit = unchecked(1 << 2),
		// <summary>VK_SAMPLE_COUNT_8_BIT</summary>
		_8Bit = unchecked(1 << 3),
		// <summary>VK_SAMPLE_COUNT_16_BIT</summary>
		_16Bit = unchecked(1 << 4),
		// <summary>VK_SAMPLE_COUNT_32_BIT</summary>
		_32Bit = unchecked(1 << 5),
		// <summary>VK_SAMPLE_COUNT_64_BIT</summary>
		_64Bit = unchecked(1 << 6),
	}
	// <summary>VkSamplerAddressMode</summary>
	public enum SamplerAddressMode
	{
		// <summary>VK_SAMPLER_ADDRESS_MODE_REPEAT</summary>
		Repeat = unchecked(0),
		// <summary>VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT</summary>
		MirroredRepeat = unchecked(1),
		// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE</summary>
		ClampToEdge = unchecked(2),
		// <summary>VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER</summary>
		ClampToBorder = unchecked(3),
	}
	// <summary>VkSamplerMipmapMode</summary>
	public enum SamplerMipmapMode
	{
		// <summary>VK_SAMPLER_MIPMAP_MODE_NEAREST</summary>
		Nearest = unchecked(0),
		// <summary>VK_SAMPLER_MIPMAP_MODE_LINEAR</summary>
		Linear = unchecked(1),
	}
	// <summary>VkShaderStageFlagBits</summary>
	[Flags]
	public enum ShaderStageFlagBits
	{
		// <summary>VK_SHADER_STAGE_VERTEX_BIT</summary>
		VertexBit = unchecked(1 << 0),
		// <summary>VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT</summary>
		TessellationControlBit = unchecked(1 << 1),
		// <summary>VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT</summary>
		TessellationEvaluationBit = unchecked(1 << 2),
		// <summary>VK_SHADER_STAGE_GEOMETRY_BIT</summary>
		GeometryBit = unchecked(1 << 3),
		// <summary>VK_SHADER_STAGE_FRAGMENT_BIT</summary>
		FragmentBit = unchecked(1 << 4),
		// <summary>VK_SHADER_STAGE_COMPUTE_BIT</summary>
		ComputeBit = unchecked(1 << 5),
		// <summary>VK_SHADER_STAGE_ALL_GRAPHICS</summary>
		AllGraphics = unchecked((int)0x0000001F),
		// <summary>VK_SHADER_STAGE_ALL</summary>
		All = unchecked((int)0x7FFFFFFF),
	}
	// <summary>VkSharingMode</summary>
	public enum SharingMode
	{
		// <summary>VK_SHARING_MODE_EXCLUSIVE</summary>
		Exclusive = unchecked(0),
		// <summary>VK_SHARING_MODE_CONCURRENT</summary>
		Concurrent = unchecked(1),
	}
	// <summary>VkSparseImageFormatFlagBits</summary>
	[Flags]
	public enum SparseImageFormatFlagBits
	{
		// <summary>VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT</summary>
		SingleMiptailBit = unchecked(1 << 0),
		// <summary>VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT</summary>
		AlignedMipSizeBit = unchecked(1 << 1),
		// <summary>VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT</summary>
		NonstandardBlockSizeBit = unchecked(1 << 2),
	}
	// <summary>VkSparseMemoryBindFlagBits</summary>
	[Flags]
	public enum SparseMemoryBindFlagBits
	{
		// <summary>VK_SPARSE_MEMORY_BIND_METADATA_BIT</summary>
		MetadataBit = unchecked(1 << 0),
	}
	// <summary>VkStencilFaceFlagBits</summary>
	[Flags]
	public enum StencilFaceFlagBits
	{
		// <summary>VK_STENCIL_FACE_FRONT_BIT</summary>
		FrontBit = unchecked(1 << 0),
		// <summary>VK_STENCIL_FACE_BACK_BIT</summary>
		BackBit = unchecked(1 << 1),
		// <summary>VK_STENCIL_FRONT_AND_BACK</summary>
		FrontAndBack = unchecked(0x00000003),
	}
	// <summary>VkStencilOp</summary>
	public enum StencilOperation
	{
		// <summary>VK_STENCIL_OP_KEEP</summary>
		Keep = unchecked(0),
		// <summary>VK_STENCIL_OP_ZERO</summary>
		Zero = unchecked(1),
		// <summary>VK_STENCIL_OP_REPLACE</summary>
		Replace = unchecked(2),
		// <summary>VK_STENCIL_OP_INCREMENT_AND_CLAMP</summary>
		IncrementAndClamp = unchecked(3),
		// <summary>VK_STENCIL_OP_DECREMENT_AND_CLAMP</summary>
		DecrementAndClamp = unchecked(4),
		// <summary>VK_STENCIL_OP_INVERT</summary>
		Invert = unchecked(5),
		// <summary>VK_STENCIL_OP_INCREMENT_AND_WRAP</summary>
		IncrementAndWrap = unchecked(6),
		// <summary>VK_STENCIL_OP_DECREMENT_AND_WRAP</summary>
		DecrementAndWrap = unchecked(7),
	}
	// <summary>VkStructureType</summary>
	public enum StructureType
	{
		// <summary>VK_STRUCTURE_TYPE_APPLICATION_INFO</summary>
		ApplicationInfo = unchecked(0),
		// <summary>VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO</summary>
		InstanceCreateInfo = unchecked(1),
		// <summary>VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO</summary>
		DeviceQueueCreateInfo = unchecked(2),
		// <summary>VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO</summary>
		DeviceCreateInfo = unchecked(3),
		// <summary>VK_STRUCTURE_TYPE_SUBMIT_INFO</summary>
		SubmitInfo = unchecked(4),
		// <summary>VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO</summary>
		MemoryAllocateInfo = unchecked(5),
		// <summary>VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE</summary>
		MappedMemoryRange = unchecked(6),
		// <summary>VK_STRUCTURE_TYPE_BIND_SPARSE_INFO</summary>
		BindSparseInfo = unchecked(7),
		// <summary>VK_STRUCTURE_TYPE_FENCE_CREATE_INFO</summary>
		FenceCreateInfo = unchecked(8),
		// <summary>VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO</summary>
		SemaphoreCreateInfo = unchecked(9),
		// <summary>VK_STRUCTURE_TYPE_EVENT_CREATE_INFO</summary>
		EventCreateInfo = unchecked(10),
		// <summary>VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO</summary>
		QueryPoolCreateInfo = unchecked(11),
		// <summary>VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO</summary>
		BufferCreateInfo = unchecked(12),
		// <summary>VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO</summary>
		BufferViewCreateInfo = unchecked(13),
		// <summary>VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO</summary>
		ImageCreateInfo = unchecked(14),
		// <summary>VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO</summary>
		ImageViewCreateInfo = unchecked(15),
		// <summary>VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO</summary>
		ShaderModuleCreateInfo = unchecked(16),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO</summary>
		PipelineCacheCreateInfo = unchecked(17),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO</summary>
		PipelineShaderStageCreateInfo = unchecked(18),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO</summary>
		PipelineVertexInputStateCreateInfo = unchecked(19),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO</summary>
		PipelineInputAssemblyStateCreateInfo = unchecked(20),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO</summary>
		PipelineTessellationStateCreateInfo = unchecked(21),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO</summary>
		PipelineViewportStateCreateInfo = unchecked(22),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO</summary>
		PipelineRasterizationStateCreateInfo = unchecked(23),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO</summary>
		PipelineMultisampleStateCreateInfo = unchecked(24),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO</summary>
		PipelineDepthStencilStateCreateInfo = unchecked(25),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO</summary>
		PipelineColorBlendStateCreateInfo = unchecked(26),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO</summary>
		PipelineDynamicStateCreateInfo = unchecked(27),
		// <summary>VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO</summary>
		GraphicsPipelineCreateInfo = unchecked(28),
		// <summary>VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO</summary>
		ComputePipelineCreateInfo = unchecked(29),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO</summary>
		PipelineLayoutCreateInfo = unchecked(30),
		// <summary>VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO</summary>
		SamplerCreateInfo = unchecked(31),
		// <summary>VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO</summary>
		DescriptorSetLayoutCreateInfo = unchecked(32),
		// <summary>VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO</summary>
		DescriptorPoolCreateInfo = unchecked(33),
		// <summary>VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO</summary>
		DescriptorSetAllocateInfo = unchecked(34),
		// <summary>VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET</summary>
		WriteDescriptorSet = unchecked(35),
		// <summary>VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET</summary>
		CopyDescriptorSet = unchecked(36),
		// <summary>VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO</summary>
		FramebufferCreateInfo = unchecked(37),
		// <summary>VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO</summary>
		RenderPassCreateInfo = unchecked(38),
		// <summary>VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO</summary>
		CommandPoolCreateInfo = unchecked(39),
		// <summary>VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO</summary>
		CommandBufferAllocateInfo = unchecked(40),
		// <summary>VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO</summary>
		CommandBufferInheritanceInfo = unchecked(41),
		// <summary>VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO</summary>
		CommandBufferBeginInfo = unchecked(42),
		// <summary>VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO</summary>
		RenderPassBeginInfo = unchecked(43),
		// <summary>VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER</summary>
		BufferMemoryBarrier = unchecked(44),
		// <summary>VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER</summary>
		ImageMemoryBarrier = unchecked(45),
		// <summary>VK_STRUCTURE_TYPE_MEMORY_BARRIER</summary>
		MemoryBarrier = unchecked(46),
		// <summary>VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO</summary>
		LoaderInstanceCreateInfo = unchecked(47),
		// <summary>VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO</summary>
		LoaderDeviceCreateInfo = unchecked(48),
		// <summary>VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR</summary>
		SwapchainCreateInfoKhr = unchecked((1000000000 + 1000 * (2 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_PRESENT_INFO_KHR</summary>
		PresentInfoKhr = unchecked((1000000000 + 1000 * (2 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR</summary>
		DisplayModeCreateInfoKhr = unchecked((1000000000 + 1000 * (3 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR</summary>
		DisplaySurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (3 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR</summary>
		DisplayPresentInfoKhr = unchecked((1000000000 + 1000 * (4 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR</summary>
		XlibSurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (5 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR</summary>
		XcbSurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (6 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR</summary>
		WaylandSurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (7 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_MIR_SURFACE_CREATE_INFO_KHR</summary>
		MirSurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (8 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR</summary>
		AndroidSurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (9 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR</summary>
		Win32SurfaceCreateInfoKhr = unchecked((1000000000 + 1000 * (10 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT</summary>
		DebugReportCallbackCreateInfoExt = unchecked((1000000000 + 1000 * (12 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD</summary>
		PipelineRasterizationStateRasterizationOrderAmd = unchecked((1000000000 + 1000 * (19 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT</summary>
		DebugMarkerObjectNameInfoExt = unchecked((1000000000 + 1000 * (23 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT</summary>
		DebugMarkerObjectTagInfoExt = unchecked((1000000000 + 1000 * (23 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT</summary>
		DebugMarkerMarkerInfoExt = unchecked((1000000000 + 1000 * (23 - 1) + 2)),
		// <summary>VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV</summary>
		DedicatedAllocationImageCreateInfoNv = unchecked((1000000000 + 1000 * (27 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV</summary>
		DedicatedAllocationBufferCreateInfoNv = unchecked((1000000000 + 1000 * (27 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV</summary>
		DedicatedAllocationMemoryAllocateInfoNv = unchecked((1000000000 + 1000 * (27 - 1) + 2)),
		// <summary>VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV</summary>
		ExternalMemoryImageCreateInfoNv = unchecked((1000000000 + 1000 * (57 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV</summary>
		ExportMemoryAllocateInfoNv = unchecked((1000000000 + 1000 * (57 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV</summary>
		ImportMemoryWin32HandleInfoNv = unchecked((1000000000 + 1000 * (58 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV</summary>
		ExportMemoryWin32HandleInfoNv = unchecked((1000000000 + 1000 * (58 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV</summary>
		Win32KeyedMutexAcquireReleaseInfoNv = unchecked((1000000000 + 1000 * (59 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT</summary>
		ValidationFlagsExt = unchecked((1000000000 + 1000 * (62 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_OBJECT_TABLE_CREATE_INFO_NVX</summary>
		ObjectTableCreateInfoNvx = unchecked((1000000000 + 1000 * (87 - 1) + 0)),
		// <summary>VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NVX</summary>
		IndirectCommandsLayoutCreateInfoNvx = unchecked((1000000000 + 1000 * (87 - 1) + 1)),
		// <summary>VK_STRUCTURE_TYPE_CMD_PROCESS_COMMANDS_INFO_NVX</summary>
		CmdProcessCommandsInfoNvx = unchecked((1000000000 + 1000 * (87 - 1) + 2)),
		// <summary>VK_STRUCTURE_TYPE_CMD_RESERVE_SPACE_FOR_COMMANDS_INFO_NVX</summary>
		CmdReserveSpaceForCommandsInfoNvx = unchecked((1000000000 + 1000 * (87 - 1) + 3)),
		// <summary>VK_STRUCTURE_TYPE_DEVICE_GENERATED_COMMANDS_LIMITS_NVX</summary>
		DeviceGeneratedCommandsLimitsNvx = unchecked((1000000000 + 1000 * (87 - 1) + 4)),
		// <summary>VK_STRUCTURE_TYPE_DEVICE_GENERATED_COMMANDS_FEATURES_NVX</summary>
		DeviceGeneratedCommandsFeaturesNvx = unchecked((1000000000 + 1000 * (87 - 1) + 5)),
	}
	// <summary>VkSubpassContents</summary>
	public enum SubpassContents
	{
		// <summary>VK_SUBPASS_CONTENTS_INLINE</summary>
		Inline = unchecked(0),
		// <summary>VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS</summary>
		SecondaryCommandBuffers = unchecked(1),
	}
	// <summary>VkSurfaceTransformFlagBitsKHR</summary>
	[Flags]
	public enum SurfaceTransformFlagBitsKHR
	{
		// <summary>VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR</summary>
		IdentityBitKhr = unchecked(1 << 0),
		// <summary>VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR</summary>
		Rotate90BitKhr = unchecked(1 << 1),
		// <summary>VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR</summary>
		Rotate180BitKhr = unchecked(1 << 2),
		// <summary>VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR</summary>
		Rotate270BitKhr = unchecked(1 << 3),
		// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR</summary>
		HorizontalMirrorBitKhr = unchecked(1 << 4),
		// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR</summary>
		HorizontalMirrorRotate90BitKhr = unchecked(1 << 5),
		// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR</summary>
		HorizontalMirrorRotate180BitKhr = unchecked(1 << 6),
		// <summary>VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR</summary>
		HorizontalMirrorRotate270BitKhr = unchecked(1 << 7),
		// <summary>VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR</summary>
		InheritBitKhr = unchecked(1 << 8),
	}
	// <summary>VkSystemAllocationScope</summary>
	public enum SystemAllocationScope
	{
		// <summary>VK_SYSTEM_ALLOCATION_SCOPE_COMMAND</summary>
		Command = unchecked(0),
		// <summary>VK_SYSTEM_ALLOCATION_SCOPE_OBJECT</summary>
		Object = unchecked(1),
		// <summary>VK_SYSTEM_ALLOCATION_SCOPE_CACHE</summary>
		Cache = unchecked(2),
		// <summary>VK_SYSTEM_ALLOCATION_SCOPE_DEVICE</summary>
		Device = unchecked(3),
		// <summary>VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE</summary>
		Instance = unchecked(4),
	}
	// <summary>VkValidationCheckEXT</summary>
	public enum ValidationCheckEXT
	{
		// <summary>VK_VALIDATION_CHECK_ALL_EXT</summary>
		ValidationCheckAllExt = unchecked(0),
	}
	// <summary>VkVertexInputRate</summary>
	public enum VertexInputRate
	{
		// <summary>VK_VERTEX_INPUT_RATE_VERTEX</summary>
		Vertex = unchecked(0),
		// <summary>VK_VERTEX_INPUT_RATE_INSTANCE</summary>
		Instance = unchecked(1),
	}
}

