using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Crow.Graphics.Vulkan
{
	// VkAllocationCallbacks
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct AllocationCallbacks
	{
		// void* pUserData
		public IntPtr pUserData;
		// PFN_vkAllocationFunction pfnAllocation
		public IntPtr pfnAllocation;
		// PFN_vkReallocationFunction pfnReallocation
		public IntPtr pfnReallocation;
		// PFN_vkFreeFunction pfnFree
		public IntPtr pfnFree;
		// PFN_vkInternalAllocationNotification pfnInternalAllocation
		public IntPtr pfnInternalAllocation;
		// PFN_vkInternalFreeNotification pfnInternalFree
		public IntPtr pfnInternalFree;
	}
	// VkAndroidSurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct AndroidSurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkAndroidSurfaceCreateFlagsKHR flags
		public uint flags;
		// ANativeWindow* window
		public IntPtr* window;
	}
	// VkApplicationInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ApplicationInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// char* pApplicationName
		public byte* pApplicationName;
		// uint32_t applicationVersion
		public Version applicationVersion;
		// char* pEngineName
		public byte* pEngineName;
		// uint32_t engineVersion
		public Version engineVersion;
		// uint32_t apiVersion
		public Version apiVersion;
	}
	// VkAttachmentDescription
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct AttachmentDescription
	{
		// VkAttachmentDescriptionFlags flags
		public AttachmentDescriptionFlagBits flags;
		// VkFormat format
		public Format format;
		// VkSampleCountFlagBits samples
		public SampleCountFlagBits samples;
		// VkAttachmentLoadOp loadOp
		public AttachmentLoadOperation loadOperation;
		// VkAttachmentStoreOp storeOp
		public AttachmentStoreOperation storeOperation;
		// VkAttachmentLoadOp stencilLoadOp
		public AttachmentLoadOperation stencilLoadOperation;
		// VkAttachmentStoreOp stencilStoreOp
		public AttachmentStoreOperation stencilStoreOperation;
		// VkImageLayout initialLayout
		public ImageLayout initialLayout;
		// VkImageLayout finalLayout
		public ImageLayout finalLayout;
	}
	// VkAttachmentReference
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct AttachmentReference
	{
		// uint32_t attachment
		public uint attachment;
		// VkImageLayout layout
		public ImageLayout layout;
	}
	// VkBindSparseInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BindSparseInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t waitSemaphoreCount
		public uint waitSemaphoreCount;
		// VkSemaphore* pWaitSemaphores
		public Semaphore* pWaitSemaphores;
		// uint32_t bufferBindCount
		public uint bufferBindCount;
		// VkSparseBufferMemoryBindInfo* pBufferBinds
		public SparseBufferMemoryBindInfo* pBufferBinds;
		// uint32_t imageOpaqueBindCount
		public uint imageOpaqueBindCount;
		// VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds
		public SparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
		// uint32_t imageBindCount
		public uint imageBindCount;
		// VkSparseImageMemoryBindInfo* pImageBinds
		public SparseImageMemoryBindInfo* pImageBinds;
		// uint32_t signalSemaphoreCount
		public uint signalSemaphoreCount;
		// VkSemaphore* pSignalSemaphores
		public Semaphore* pSignalSemaphores;
	}
	// VkBuffer
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Buffer : IEquatable<Buffer>
	{
		private ulong handle;
	
		public static readonly Buffer Zero;
	
		public Buffer(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Buffer other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Buffer && ((Buffer)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Buffer value1, Buffer value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Buffer value1, Buffer value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Buffer value)
		{
			return value.handle;
		}
		public static explicit operator Buffer(ulong value)
		{
			return new Buffer (value);
		}
	}
	// VkBufferCopy
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BufferCopy
	{
		// VkDeviceSize srcOffset
		public ulong sourceOffset;
		// VkDeviceSize dstOffset
		public ulong destinationOffset;
		// VkDeviceSize size
		public ulong size;
	}
	// VkBufferCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BufferCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkBufferCreateFlags flags
		public BufferCreateFlagBits flags;
		// VkDeviceSize size
		public ulong size;
		// VkBufferUsageFlags usage
		public BufferUsageFlagBits usage;
		// VkSharingMode sharingMode
		public SharingMode sharingMode;
		// uint32_t queueFamilyIndexCount
		public uint queueFamilyIndexCount;
		// uint32_t* pQueueFamilyIndices
		public uint* pQueueFamilyIndices;
	}
	// VkBufferImageCopy
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BufferImageCopy
	{
		// VkDeviceSize bufferOffset
		public ulong bufferOffset;
		// uint32_t bufferRowLength
		public uint bufferRowLength;
		// uint32_t bufferImageHeight
		public uint bufferImageHeight;
		// VkImageSubresourceLayers imageSubresource
		public ImageSubresourceLayers imageSubresource;
		// VkOffset3D imageOffset
		public Offset3D imageOffset;
		// VkExtent3D imageExtent
		public Extent3D imageExtent;
	}
	// VkBufferMemoryBarrier
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BufferMemoryBarrier
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkAccessFlags srcAccessMask
		public AccessFlagBits sourceAccessMask;
		// VkAccessFlags dstAccessMask
		public AccessFlagBits destinationAccessMask;
		// uint32_t srcQueueFamilyIndex
		public uint sourceQueueFamilyIndex;
		// uint32_t dstQueueFamilyIndex
		public uint destinationQueueFamilyIndex;
		// VkBuffer buffer
		public Buffer buffer;
		// VkDeviceSize offset
		public ulong offset;
		// VkDeviceSize size
		public ulong size;
	}
	// VkBufferView
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct BufferView : IEquatable<BufferView>
	{
		private ulong handle;
	
		public static readonly BufferView Zero;
	
		public BufferView(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(BufferView other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is BufferView && ((BufferView)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(BufferView value1, BufferView value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(BufferView value1, BufferView value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(BufferView value)
		{
			return value.handle;
		}
		public static explicit operator BufferView(ulong value)
		{
			return new BufferView (value);
		}
	}
	// VkBufferViewCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct BufferViewCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkBufferViewCreateFlags flags
		public uint flags;
		// VkBuffer buffer
		public Buffer buffer;
		// VkFormat format
		public Format format;
		// VkDeviceSize offset
		public ulong offset;
		// VkDeviceSize range
		public ulong range;
	}
	// VkClearAttachment
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ClearAttachment
	{
		// VkImageAspectFlags aspectMask
		public ImageAspectFlagBits aspectMask;
		// uint32_t colorAttachment
		public uint colorAttachment;
		// VkClearValue clearValue
		public ClearValue clearValue;
	}
	// VkClearColorValue
	[StructLayout (LayoutKind.Explicit)]
	public unsafe partial struct ClearColorValue
	{
		// float float32
		[FieldOffset (0)]
		public fixed float float32[4];
		// int32_t int32
		[FieldOffset (0)]
		public fixed int int32[4];
		// uint32_t uint32
		[FieldOffset (0)]
		public fixed uint uint32[4];
	}
	// VkClearDepthStencilValue
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ClearDepthStencilValue
	{
		// float depth
		public float depth;
		// uint32_t stencil
		public uint stencil;
	}
	// VkClearRect
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ClearRect
	{
		// VkRect2D rect
		public Rect2D rect;
		// uint32_t baseArrayLayer
		public uint baseArrayLayer;
		// uint32_t layerCount
		public uint layerCount;
	}
	// VkClearValue
	[StructLayout (LayoutKind.Explicit)]
	public unsafe partial struct ClearValue
	{
		// VkClearColorValue color
		[FieldOffset (0)]
		public ClearColorValue color;
		// VkClearDepthStencilValue depthStencil
		[FieldOffset (0)]
		public ClearDepthStencilValue depthStencil;
	}
	// VkCmdProcessCommandsInfoNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CmdProcessCommandsInfoNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkObjectTableNVX objectTable
		public ObjectTableNVX objectTable;
		// VkIndirectCommandsLayoutNVX indirectCommandsLayout
		public IndirectCommandsLayoutNVX indirectCommandsLayout;
		// uint32_t indirectCommandsTokenCount
		public uint indirectCommandsTokenCount;
		// VkIndirectCommandsTokenNVX* pIndirectCommandsTokens
		public IndirectCommandsTokenNVX* pIndirectCommandsTokens;
		// uint32_t maxSequencesCount
		public uint maxSequencesCount;
		// VkCommandBuffer targetCommandBuffer
		public CommandBuffer targetCommandBuffer;
		// VkBuffer sequencesCountBuffer
		public Buffer sequencesCountBuffer;
		// VkDeviceSize sequencesCountOffset
		public ulong sequencesCountOffset;
		// VkBuffer sequencesIndexBuffer
		public Buffer sequencesIndexBuffer;
		// VkDeviceSize sequencesIndexOffset
		public ulong sequencesIndexOffset;
	}
	// VkCmdReserveSpaceForCommandsInfoNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CmdReserveSpaceForCommandsInfoNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkObjectTableNVX objectTable
		public ObjectTableNVX objectTable;
		// VkIndirectCommandsLayoutNVX indirectCommandsLayout
		public IndirectCommandsLayoutNVX indirectCommandsLayout;
		// uint32_t maxSequencesCount
		public uint maxSequencesCount;
	}
	// VkCommandBuffer
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct CommandBuffer : IEquatable<CommandBuffer>
	{
		private IntPtr handle;
	
		public static readonly CommandBuffer Zero;
	
		public CommandBuffer(IntPtr value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == IntPtr.Zero; } }
		
		public bool Equals(CommandBuffer other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is CommandBuffer && ((CommandBuffer)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString ();
		}
		
		public static bool operator ==(CommandBuffer value1, CommandBuffer value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(CommandBuffer value1, CommandBuffer value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator IntPtr(CommandBuffer value)
		{
			return value.handle;
		}
		public static explicit operator CommandBuffer(IntPtr value)
		{
			return new CommandBuffer (value);
		}
	}
	// VkCommandBufferAllocateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CommandBufferAllocateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkCommandPool commandPool
		public CommandPool commandPool;
		// VkCommandBufferLevel level
		public CommandBufferLevel level;
		// uint32_t commandBufferCount
		public uint commandBufferCount;
	}
	// VkCommandBufferBeginInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CommandBufferBeginInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkCommandBufferUsageFlags flags
		public CommandBufferUsageFlagBits flags;
		// VkCommandBufferInheritanceInfo* pInheritanceInfo
		public CommandBufferInheritanceInfo* pInheritanceInfo;
	}
	// VkCommandBufferInheritanceInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CommandBufferInheritanceInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkRenderPass renderPass
		public RenderPass renderPass;
		// uint32_t subpass
		public uint subpass;
		// VkFramebuffer framebuffer
		public Framebuffer framebuffer;
		// VkBool32 occlusionQueryEnable
		public Boolean32 occlusionQueryEnable;
		// VkQueryControlFlags queryFlags
		public QueryControlFlagBits queryFlags;
		// VkQueryPipelineStatisticFlags pipelineStatistics
		public QueryPipelineStatisticFlagBits pipelineStatistics;
	}
	// VkCommandPool
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct CommandPool : IEquatable<CommandPool>
	{
		private ulong handle;
	
		public static readonly CommandPool Zero;
	
		public CommandPool(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(CommandPool other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is CommandPool && ((CommandPool)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(CommandPool value1, CommandPool value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(CommandPool value1, CommandPool value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(CommandPool value)
		{
			return value.handle;
		}
		public static explicit operator CommandPool(ulong value)
		{
			return new CommandPool (value);
		}
	}
	// VkCommandPoolCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CommandPoolCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkCommandPoolCreateFlags flags
		public CommandPoolCreateFlagBits flags;
		// uint32_t queueFamilyIndex
		public uint queueFamilyIndex;
	}
	// VkComponentMapping
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ComponentMapping
	{
		// VkComponentSwizzle r
		public ComponentSwizzle r;
		// VkComponentSwizzle g
		public ComponentSwizzle g;
		// VkComponentSwizzle b
		public ComponentSwizzle b;
		// VkComponentSwizzle a
		public ComponentSwizzle a;
	}
	// VkComputePipelineCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ComputePipelineCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineCreateFlags flags
		public PipelineCreateFlagBits flags;
		// VkPipelineShaderStageCreateInfo stage
		public PipelineShaderStageCreateInfo stage;
		// VkPipelineLayout layout
		public PipelineLayout layout;
		// VkPipeline basePipelineHandle
		public Pipeline basePipelineHandle;
		// int32_t basePipelineIndex
		public int basePipelineIndex;
	}
	// VkCopyDescriptorSet
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct CopyDescriptorSet
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDescriptorSet srcSet
		public DescriptorSet sourceSet;
		// uint32_t srcBinding
		public uint sourceBinding;
		// uint32_t srcArrayElement
		public uint sourceArrayElement;
		// VkDescriptorSet dstSet
		public DescriptorSet destinationSet;
		// uint32_t dstBinding
		public uint destinationBinding;
		// uint32_t dstArrayElement
		public uint destinationArrayElement;
		// uint32_t descriptorCount
		public uint descriptorCount;
	}
	// VkDebugMarkerMarkerInfoEXT
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DebugMarkerMarkerInfoEXT
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// char* pMarkerName
		public byte* pMarkerName;
		// float color
		public fixed float color[4];
	}
	// VkDebugMarkerObjectNameInfoEXT
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DebugMarkerObjectNameInfoEXT
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDebugReportObjectTypeEXT objectType
		public DebugReportObjectTypeEXT objectType;
		// uint64_t object
		public ulong @object;
		// char* pObjectName
		public byte* pObjectName;
	}
	// VkDebugMarkerObjectTagInfoEXT
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DebugMarkerObjectTagInfoEXT
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDebugReportObjectTypeEXT objectType
		public DebugReportObjectTypeEXT objectType;
		// uint64_t object
		public ulong @object;
		// uint64_t tagName
		public ulong tagName;
		// size_t tagSize
		public int tagSize;
		// void* pTag
		public IntPtr pTag;
	}
	// VkDebugReportCallbackCreateInfoEXT
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DebugReportCallbackCreateInfoEXT
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDebugReportFlagsEXT flags
		public DebugReportFlagBitsEXT flags;
		// PFN_vkDebugReportCallbackEXT pfnCallback
		public IntPtr pfnCallback;
		// void* pUserData
		public IntPtr pUserData;
	}
	// VkDebugReportCallbackEXT
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DebugReportCallbackEXT : IEquatable<DebugReportCallbackEXT>
	{
		private ulong handle;
	
		public static readonly DebugReportCallbackEXT Zero;
	
		public DebugReportCallbackEXT(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DebugReportCallbackEXT other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DebugReportCallbackEXT && ((DebugReportCallbackEXT)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DebugReportCallbackEXT value1, DebugReportCallbackEXT value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DebugReportCallbackEXT value1, DebugReportCallbackEXT value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DebugReportCallbackEXT value)
		{
			return value.handle;
		}
		public static explicit operator DebugReportCallbackEXT(ulong value)
		{
			return new DebugReportCallbackEXT (value);
		}
	}
	// VkDedicatedAllocationBufferCreateInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DedicatedAllocationBufferCreateInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkBool32 dedicatedAllocation
		public Boolean32 dedicatedAllocation;
	}
	// VkDedicatedAllocationImageCreateInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DedicatedAllocationImageCreateInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkBool32 dedicatedAllocation
		public Boolean32 dedicatedAllocation;
	}
	// VkDedicatedAllocationMemoryAllocateInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DedicatedAllocationMemoryAllocateInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkImage image
		public Image image;
		// VkBuffer buffer
		public Buffer buffer;
	}
	// VkDescriptorBufferInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorBufferInfo
	{
		// VkBuffer buffer
		public Buffer buffer;
		// VkDeviceSize offset
		public ulong offset;
		// VkDeviceSize range
		public ulong range;
	}
	// VkDescriptorImageInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorImageInfo
	{
		// VkSampler sampler
		public Sampler sampler;
		// VkImageView imageView
		public ImageView imageView;
		// VkImageLayout imageLayout
		public ImageLayout imageLayout;
	}
	// VkDescriptorPool
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DescriptorPool : IEquatable<DescriptorPool>
	{
		private ulong handle;
	
		public static readonly DescriptorPool Zero;
	
		public DescriptorPool(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DescriptorPool other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DescriptorPool && ((DescriptorPool)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DescriptorPool value1, DescriptorPool value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DescriptorPool value1, DescriptorPool value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DescriptorPool value)
		{
			return value.handle;
		}
		public static explicit operator DescriptorPool(ulong value)
		{
			return new DescriptorPool (value);
		}
	}
	// VkDescriptorPoolCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorPoolCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDescriptorPoolCreateFlags flags
		public DescriptorPoolCreateFlagBits flags;
		// uint32_t maxSets
		public uint maxSets;
		// uint32_t poolSizeCount
		public uint poolSizeCount;
		// VkDescriptorPoolSize* pPoolSizes
		public DescriptorPoolSize* pPoolSizes;
	}
	// VkDescriptorPoolSize
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorPoolSize
	{
		// VkDescriptorType type
		public DescriptorType type;
		// uint32_t descriptorCount
		public uint descriptorCount;
	}
	// VkDescriptorSet
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DescriptorSet : IEquatable<DescriptorSet>
	{
		private ulong handle;
	
		public static readonly DescriptorSet Zero;
	
		public DescriptorSet(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DescriptorSet other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DescriptorSet && ((DescriptorSet)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DescriptorSet value1, DescriptorSet value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DescriptorSet value1, DescriptorSet value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DescriptorSet value)
		{
			return value.handle;
		}
		public static explicit operator DescriptorSet(ulong value)
		{
			return new DescriptorSet (value);
		}
	}
	// VkDescriptorSetAllocateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorSetAllocateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDescriptorPool descriptorPool
		public DescriptorPool descriptorPool;
		// uint32_t descriptorSetCount
		public uint descriptorSetCount;
		// VkDescriptorSetLayout* pSetLayouts
		public DescriptorSetLayout* pSetLayouts;
	}
	// VkDescriptorSetLayout
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DescriptorSetLayout : IEquatable<DescriptorSetLayout>
	{
		private ulong handle;
	
		public static readonly DescriptorSetLayout Zero;
	
		public DescriptorSetLayout(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DescriptorSetLayout other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DescriptorSetLayout && ((DescriptorSetLayout)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DescriptorSetLayout value1, DescriptorSetLayout value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DescriptorSetLayout value1, DescriptorSetLayout value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DescriptorSetLayout value)
		{
			return value.handle;
		}
		public static explicit operator DescriptorSetLayout(ulong value)
		{
			return new DescriptorSetLayout (value);
		}
	}
	// VkDescriptorSetLayoutBinding
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorSetLayoutBinding
	{
		// uint32_t binding
		public uint binding;
		// VkDescriptorType descriptorType
		public DescriptorType descriptorType;
		// uint32_t descriptorCount
		public uint descriptorCount;
		// VkShaderStageFlags stageFlags
		public ShaderStageFlagBits stageFlags;
		// VkSampler* pImmutableSamplers
		public Sampler* pImmutableSamplers;
	}
	// VkDescriptorSetLayoutCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DescriptorSetLayoutCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDescriptorSetLayoutCreateFlags flags
		public uint flags;
		// uint32_t bindingCount
		public uint bindingCount;
		// VkDescriptorSetLayoutBinding* pBindings
		public DescriptorSetLayoutBinding* pBindings;
	}
	// VkDevice
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Device : IEquatable<Device>
	{
		private IntPtr handle;
	
		public static readonly Device Zero;
	
		public Device(IntPtr value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == IntPtr.Zero; } }
		
		public bool Equals(Device other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Device && ((Device)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString ();
		}
		
		public static bool operator ==(Device value1, Device value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Device value1, Device value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator IntPtr(Device value)
		{
			return value.handle;
		}
		public static explicit operator Device(IntPtr value)
		{
			return new Device (value);
		}
	}
	// VkDeviceCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DeviceCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDeviceCreateFlags flags
		public uint flags;
		// uint32_t queueCreateInfoCount
		public uint queueCreateInfoCount;
		// VkDeviceQueueCreateInfo* pQueueCreateInfos
		public DeviceQueueCreateInfo* pQueueCreateInfos;
		// uint32_t enabledLayerCount
		public uint enabledLayerCount;
		// char* ppEnabledLayerNames
		public byte* ppEnabledLayerNames;
		// uint32_t enabledExtensionCount
		public uint enabledExtensionCount;
		// char* ppEnabledExtensionNames
		public byte* ppEnabledExtensionNames;
		// VkPhysicalDeviceFeatures* pEnabledFeatures
		public PhysicalDeviceFeatures* pEnabledFeatures;
	}
	// VkDeviceGeneratedCommandsFeaturesNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DeviceGeneratedCommandsFeaturesNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkBool32 computeBindingPointSupport
		public Boolean32 computeBindingPointSupport;
	}
	// VkDeviceGeneratedCommandsLimitsNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DeviceGeneratedCommandsLimitsNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t maxIndirectCommandsLayoutTokenCount
		public uint maxIndirectCommandsLayoutTokenCount;
		// uint32_t maxObjectEntryCounts
		public uint maxObjectEntryCounts;
		// uint32_t minSequenceCountBufferOffsetAlignment
		public uint minSequenceCountBufferOffsetAlignment;
		// uint32_t minSequenceIndexBufferOffsetAlignment
		public uint minSequenceIndexBufferOffsetAlignment;
		// uint32_t minCommandsTokenBufferOffsetAlignment
		public uint minCommandsTokenBufferOffsetAlignment;
	}
	// VkDeviceMemory
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DeviceMemory : IEquatable<DeviceMemory>
	{
		private ulong handle;
	
		public static readonly DeviceMemory Zero;
	
		public DeviceMemory(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DeviceMemory other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DeviceMemory && ((DeviceMemory)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DeviceMemory value1, DeviceMemory value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DeviceMemory value1, DeviceMemory value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DeviceMemory value)
		{
			return value.handle;
		}
		public static explicit operator DeviceMemory(ulong value)
		{
			return new DeviceMemory (value);
		}
	}
	// VkDeviceQueueCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DeviceQueueCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDeviceQueueCreateFlags flags
		public uint flags;
		// uint32_t queueFamilyIndex
		public uint queueFamilyIndex;
		// uint32_t queueCount
		public uint queueCount;
		// float* pQueuePriorities
		public float* pQueuePriorities;
	}
	// VkDispatchIndirectCommand
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DispatchIndirectCommand
	{
		// uint32_t x
		public uint x;
		// uint32_t y
		public uint y;
		// uint32_t z
		public uint z;
	}
	// VkDisplayKHR
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DisplayKHR : IEquatable<DisplayKHR>
	{
		private ulong handle;
	
		public static readonly DisplayKHR Zero;
	
		public DisplayKHR(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DisplayKHR other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DisplayKHR && ((DisplayKHR)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DisplayKHR value1, DisplayKHR value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DisplayKHR value1, DisplayKHR value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DisplayKHR value)
		{
			return value.handle;
		}
		public static explicit operator DisplayKHR(ulong value)
		{
			return new DisplayKHR (value);
		}
	}
	// VkDisplayModeCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayModeCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDisplayModeCreateFlagsKHR flags
		public uint flags;
		// VkDisplayModeParametersKHR parameters
		public DisplayModeParametersKHR parameters;
	}
	// VkDisplayModeKHR
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct DisplayModeKHR : IEquatable<DisplayModeKHR>
	{
		private ulong handle;
	
		public static readonly DisplayModeKHR Zero;
	
		public DisplayModeKHR(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(DisplayModeKHR other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is DisplayModeKHR && ((DisplayModeKHR)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(DisplayModeKHR value1, DisplayModeKHR value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(DisplayModeKHR value1, DisplayModeKHR value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(DisplayModeKHR value)
		{
			return value.handle;
		}
		public static explicit operator DisplayModeKHR(ulong value)
		{
			return new DisplayModeKHR (value);
		}
	}
	// VkDisplayModeParametersKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayModeParametersKHR
	{
		// VkExtent2D visibleRegion
		public Extent2D visibleRegion;
		// uint32_t refreshRate
		public uint refreshRate;
	}
	// VkDisplayModePropertiesKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayModePropertiesKHR
	{
		// VkDisplayModeKHR displayMode
		public DisplayModeKHR displayMode;
		// VkDisplayModeParametersKHR parameters
		public DisplayModeParametersKHR parameters;
	}
	// VkDisplayPlaneCapabilitiesKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayPlaneCapabilitiesKHR
	{
		// VkDisplayPlaneAlphaFlagsKHR supportedAlpha
		public DisplayPlaneAlphaFlagBitsKHR supportedAlpha;
		// VkOffset2D minSrcPosition
		public Offset2D minSourcePosition;
		// VkOffset2D maxSrcPosition
		public Offset2D maxSourcePosition;
		// VkExtent2D minSrcExtent
		public Extent2D minSourceExtent;
		// VkExtent2D maxSrcExtent
		public Extent2D maxSourceExtent;
		// VkOffset2D minDstPosition
		public Offset2D minDestinationPosition;
		// VkOffset2D maxDstPosition
		public Offset2D maxDestinationPosition;
		// VkExtent2D minDstExtent
		public Extent2D minDestinationExtent;
		// VkExtent2D maxDstExtent
		public Extent2D maxDestinationExtent;
	}
	// VkDisplayPlanePropertiesKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayPlanePropertiesKHR
	{
		// VkDisplayKHR currentDisplay
		public DisplayKHR currentDisplay;
		// uint32_t currentStackIndex
		public uint currentStackIndex;
	}
	// VkDisplayPresentInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayPresentInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkRect2D srcRect
		public Rect2D sourceRect;
		// VkRect2D dstRect
		public Rect2D destinationRect;
		// VkBool32 persistent
		public Boolean32 persistent;
	}
	// VkDisplayPropertiesKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplayPropertiesKHR
	{
		// VkDisplayKHR display
		public DisplayKHR display;
		// char* displayName
		public byte* displayName;
		// VkExtent2D physicalDimensions
		public Extent2D physicalDimensions;
		// VkExtent2D physicalResolution
		public Extent2D physicalResolution;
		// VkSurfaceTransformFlagsKHR supportedTransforms
		public SurfaceTransformFlagBitsKHR supportedTransforms;
		// VkBool32 planeReorderPossible
		public Boolean32 planeReorderPossible;
		// VkBool32 persistentContent
		public Boolean32 persistentContent;
	}
	// VkDisplaySurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DisplaySurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDisplaySurfaceCreateFlagsKHR flags
		public uint flags;
		// VkDisplayModeKHR displayMode
		public DisplayModeKHR displayMode;
		// uint32_t planeIndex
		public uint planeIndex;
		// uint32_t planeStackIndex
		public uint planeStackIndex;
		// VkSurfaceTransformFlagBitsKHR transform
		public SurfaceTransformFlagBitsKHR transform;
		// float globalAlpha
		public float globalAlpha;
		// VkDisplayPlaneAlphaFlagBitsKHR alphaMode
		public DisplayPlaneAlphaFlagBitsKHR alphaMode;
		// VkExtent2D imageExtent
		public Extent2D imageExtent;
	}
	// VkDrawIndexedIndirectCommand
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DrawIndexedIndirectCommand
	{
		// uint32_t indexCount
		public uint indexCount;
		// uint32_t instanceCount
		public uint instanceCount;
		// uint32_t firstIndex
		public uint firstIndex;
		// int32_t vertexOffset
		public int vertexOffset;
		// uint32_t firstInstance
		public uint firstInstance;
	}
	// VkDrawIndirectCommand
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct DrawIndirectCommand
	{
		// uint32_t vertexCount
		public uint vertexCount;
		// uint32_t instanceCount
		public uint instanceCount;
		// uint32_t firstVertex
		public uint firstVertex;
		// uint32_t firstInstance
		public uint firstInstance;
	}
	// VkEvent
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Event : IEquatable<Event>
	{
		private ulong handle;
	
		public static readonly Event Zero;
	
		public Event(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Event other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Event && ((Event)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Event value1, Event value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Event value1, Event value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Event value)
		{
			return value.handle;
		}
		public static explicit operator Event(ulong value)
		{
			return new Event (value);
		}
	}
	// VkEventCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct EventCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkEventCreateFlags flags
		public uint flags;
	}
	// VkExportMemoryAllocateInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ExportMemoryAllocateInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkExternalMemoryHandleTypeFlagsNV handleTypes
		public ExternalMemoryHandleTypeFlagBitsNV handleTypes;
	}
	// VkExportMemoryWin32HandleInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ExportMemoryWin32HandleInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// SECURITY_ATTRIBUTES* pAttributes
		public IntPtr* pAttributes;
		// DWORD dwAccess
		public uint dwAccess;
	}
	// VkExtensionProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ExtensionProperties
	{
		// char extensionName
		public fixed byte extensionName[256];
		// uint32_t specVersion
		public uint specVersion;
	}
	// VkExtent2D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Extent2D
	{
		// uint32_t width
		public uint width;
		// uint32_t height
		public uint height;
	}
	// VkExtent3D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Extent3D
	{
		// uint32_t width
		public uint width;
		// uint32_t height
		public uint height;
		// uint32_t depth
		public uint depth;
	}
	// VkExternalImageFormatPropertiesNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ExternalImageFormatPropertiesNV
	{
		// VkImageFormatProperties imageFormatProperties
		public ImageFormatProperties imageFormatProperties;
		// VkExternalMemoryFeatureFlagsNV externalMemoryFeatures
		public ExternalMemoryFeatureFlagBitsNV externalMemoryFeatures;
		// VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes
		public ExternalMemoryHandleTypeFlagBitsNV exportFromImportedHandleTypes;
		// VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes
		public ExternalMemoryHandleTypeFlagBitsNV compatibleHandleTypes;
	}
	// VkExternalMemoryImageCreateInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ExternalMemoryImageCreateInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkExternalMemoryHandleTypeFlagsNV handleTypes
		public ExternalMemoryHandleTypeFlagBitsNV handleTypes;
	}
	// VkFence
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Fence : IEquatable<Fence>
	{
		private ulong handle;
	
		public static readonly Fence Zero;
	
		public Fence(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Fence other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Fence && ((Fence)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Fence value1, Fence value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Fence value1, Fence value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Fence value)
		{
			return value.handle;
		}
		public static explicit operator Fence(ulong value)
		{
			return new Fence (value);
		}
	}
	// VkFenceCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct FenceCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkFenceCreateFlags flags
		public FenceCreateFlagBits flags;
	}
	// VkFormatProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct FormatProperties
	{
		// VkFormatFeatureFlags linearTilingFeatures
		public FormatFeatureFlagBits linearTilingFeatures;
		// VkFormatFeatureFlags optimalTilingFeatures
		public FormatFeatureFlagBits optimalTilingFeatures;
		// VkFormatFeatureFlags bufferFeatures
		public FormatFeatureFlagBits bufferFeatures;
	}
	// VkFramebuffer
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Framebuffer : IEquatable<Framebuffer>
	{
		private ulong handle;
	
		public static readonly Framebuffer Zero;
	
		public Framebuffer(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Framebuffer other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Framebuffer && ((Framebuffer)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Framebuffer value1, Framebuffer value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Framebuffer value1, Framebuffer value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Framebuffer value)
		{
			return value.handle;
		}
		public static explicit operator Framebuffer(ulong value)
		{
			return new Framebuffer (value);
		}
	}
	// VkFramebufferCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct FramebufferCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkFramebufferCreateFlags flags
		public uint flags;
		// VkRenderPass renderPass
		public RenderPass renderPass;
		// uint32_t attachmentCount
		public uint attachmentCount;
		// VkImageView* pAttachments
		public ImageView* pAttachments;
		// uint32_t width
		public uint width;
		// uint32_t height
		public uint height;
		// uint32_t layers
		public uint layers;
	}
	// VkGraphicsPipelineCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct GraphicsPipelineCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineCreateFlags flags
		public PipelineCreateFlagBits flags;
		// uint32_t stageCount
		public uint stageCount;
		// VkPipelineShaderStageCreateInfo* pStages
		public PipelineShaderStageCreateInfo* pStages;
		// VkPipelineVertexInputStateCreateInfo* pVertexInputState
		public PipelineVertexInputStateCreateInfo* pVertexInputState;
		// VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState
		public PipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
		// VkPipelineTessellationStateCreateInfo* pTessellationState
		public PipelineTessellationStateCreateInfo* pTessellationState;
		// VkPipelineViewportStateCreateInfo* pViewportState
		public PipelineViewportStateCreateInfo* pViewportState;
		// VkPipelineRasterizationStateCreateInfo* pRasterizationState
		public PipelineRasterizationStateCreateInfo* pRasterizationState;
		// VkPipelineMultisampleStateCreateInfo* pMultisampleState
		public PipelineMultisampleStateCreateInfo* pMultisampleState;
		// VkPipelineDepthStencilStateCreateInfo* pDepthStencilState
		public PipelineDepthStencilStateCreateInfo* pDepthStencilState;
		// VkPipelineColorBlendStateCreateInfo* pColorBlendState
		public PipelineColorBlendStateCreateInfo* pColorBlendState;
		// VkPipelineDynamicStateCreateInfo* pDynamicState
		public PipelineDynamicStateCreateInfo* pDynamicState;
		// VkPipelineLayout layout
		public PipelineLayout layout;
		// VkRenderPass renderPass
		public RenderPass renderPass;
		// uint32_t subpass
		public uint subpass;
		// VkPipeline basePipelineHandle
		public Pipeline basePipelineHandle;
		// int32_t basePipelineIndex
		public int basePipelineIndex;
	}
	// VkImage
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Image : IEquatable<Image>
	{
		private ulong handle;
	
		public static readonly Image Zero;
	
		public Image(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Image other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Image && ((Image)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Image value1, Image value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Image value1, Image value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Image value)
		{
			return value.handle;
		}
		public static explicit operator Image(ulong value)
		{
			return new Image (value);
		}
	}
	// VkImageBlit
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageBlit
	{
		// VkImageSubresourceLayers srcSubresource
		public ImageSubresourceLayers sourceSubresource;
		// VkOffset3D srcOffsets
		public fixed int sourceOffsets[6];
		// VkImageSubresourceLayers dstSubresource
		public ImageSubresourceLayers destinationSubresource;
		// VkOffset3D dstOffsets
		public fixed int destinationOffsets[6];
	}
	// VkImageCopy
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageCopy
	{
		// VkImageSubresourceLayers srcSubresource
		public ImageSubresourceLayers sourceSubresource;
		// VkOffset3D srcOffset
		public Offset3D sourceOffset;
		// VkImageSubresourceLayers dstSubresource
		public ImageSubresourceLayers destinationSubresource;
		// VkOffset3D dstOffset
		public Offset3D destinationOffset;
		// VkExtent3D extent
		public Extent3D extent;
	}
	// VkImageCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkImageCreateFlags flags
		public ImageCreateFlagBits flags;
		// VkImageType imageType
		public ImageType imageType;
		// VkFormat format
		public Format format;
		// VkExtent3D extent
		public Extent3D extent;
		// uint32_t mipLevels
		public uint mipLevels;
		// uint32_t arrayLayers
		public uint arrayLayers;
		// VkSampleCountFlagBits samples
		public SampleCountFlagBits samples;
		// VkImageTiling tiling
		public ImageTiling tiling;
		// VkImageUsageFlags usage
		public ImageUsageFlagBits usage;
		// VkSharingMode sharingMode
		public SharingMode sharingMode;
		// uint32_t queueFamilyIndexCount
		public uint queueFamilyIndexCount;
		// uint32_t* pQueueFamilyIndices
		public uint* pQueueFamilyIndices;
		// VkImageLayout initialLayout
		public ImageLayout initialLayout;
	}
	// VkImageFormatProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageFormatProperties
	{
		// VkExtent3D maxExtent
		public Extent3D maxExtent;
		// uint32_t maxMipLevels
		public uint maxMipLevels;
		// uint32_t maxArrayLayers
		public uint maxArrayLayers;
		// VkSampleCountFlags sampleCounts
		public SampleCountFlagBits sampleCounts;
		// VkDeviceSize maxResourceSize
		public ulong maxResourceSize;
	}
	// VkImageMemoryBarrier
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageMemoryBarrier
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkAccessFlags srcAccessMask
		public AccessFlagBits sourceAccessMask;
		// VkAccessFlags dstAccessMask
		public AccessFlagBits destinationAccessMask;
		// VkImageLayout oldLayout
		public ImageLayout oldLayout;
		// VkImageLayout newLayout
		public ImageLayout newLayout;
		// uint32_t srcQueueFamilyIndex
		public uint sourceQueueFamilyIndex;
		// uint32_t dstQueueFamilyIndex
		public uint destinationQueueFamilyIndex;
		// VkImage image
		public Image image;
		// VkImageSubresourceRange subresourceRange
		public ImageSubresourceRange subresourceRange;
	}
	// VkImageResolve
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageResolve
	{
		// VkImageSubresourceLayers srcSubresource
		public ImageSubresourceLayers sourceSubresource;
		// VkOffset3D srcOffset
		public Offset3D sourceOffset;
		// VkImageSubresourceLayers dstSubresource
		public ImageSubresourceLayers destinationSubresource;
		// VkOffset3D dstOffset
		public Offset3D destinationOffset;
		// VkExtent3D extent
		public Extent3D extent;
	}
	// VkImageSubresource
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageSubresource
	{
		// VkImageAspectFlags aspectMask
		public ImageAspectFlagBits aspectMask;
		// uint32_t mipLevel
		public uint mipLevel;
		// uint32_t arrayLayer
		public uint arrayLayer;
	}
	// VkImageSubresourceLayers
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageSubresourceLayers
	{
		// VkImageAspectFlags aspectMask
		public ImageAspectFlagBits aspectMask;
		// uint32_t mipLevel
		public uint mipLevel;
		// uint32_t baseArrayLayer
		public uint baseArrayLayer;
		// uint32_t layerCount
		public uint layerCount;
	}
	// VkImageSubresourceRange
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageSubresourceRange
	{
		// VkImageAspectFlags aspectMask
		public ImageAspectFlagBits aspectMask;
		// uint32_t baseMipLevel
		public uint baseMipLevel;
		// uint32_t levelCount
		public uint levelCount;
		// uint32_t baseArrayLayer
		public uint baseArrayLayer;
		// uint32_t layerCount
		public uint layerCount;
	}
	// VkImageView
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct ImageView : IEquatable<ImageView>
	{
		private ulong handle;
	
		public static readonly ImageView Zero;
	
		public ImageView(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(ImageView other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is ImageView && ((ImageView)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(ImageView value1, ImageView value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(ImageView value1, ImageView value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(ImageView value)
		{
			return value.handle;
		}
		public static explicit operator ImageView(ulong value)
		{
			return new ImageView (value);
		}
	}
	// VkImageViewCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImageViewCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkImageViewCreateFlags flags
		public uint flags;
		// VkImage image
		public Image image;
		// VkImageViewType viewType
		public ImageViewType viewType;
		// VkFormat format
		public Format format;
		// VkComponentMapping components
		public ComponentMapping components;
		// VkImageSubresourceRange subresourceRange
		public ImageSubresourceRange subresourceRange;
	}
	// VkImportMemoryWin32HandleInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ImportMemoryWin32HandleInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkExternalMemoryHandleTypeFlagsNV handleType
		public ExternalMemoryHandleTypeFlagBitsNV handleType;
		// HANDLE handle
		public IntPtr handle;
	}
	// VkIndirectCommandsLayoutCreateInfoNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct IndirectCommandsLayoutCreateInfoNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineBindPoint pipelineBindPoint
		public PipelineBindPoint pipelineBindPoint;
		// VkIndirectCommandsLayoutUsageFlagsNVX flags
		public IndirectCommandsLayoutUsageFlagBitsNVX flags;
		// uint32_t tokenCount
		public uint tokenCount;
		// VkIndirectCommandsLayoutTokenNVX* pTokens
		public IndirectCommandsLayoutTokenNVX* pTokens;
	}
	// VkIndirectCommandsLayoutNVX
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct IndirectCommandsLayoutNVX : IEquatable<IndirectCommandsLayoutNVX>
	{
		private ulong handle;
	
		public static readonly IndirectCommandsLayoutNVX Zero;
	
		public IndirectCommandsLayoutNVX(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(IndirectCommandsLayoutNVX other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is IndirectCommandsLayoutNVX && ((IndirectCommandsLayoutNVX)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(IndirectCommandsLayoutNVX value1, IndirectCommandsLayoutNVX value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(IndirectCommandsLayoutNVX value1, IndirectCommandsLayoutNVX value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(IndirectCommandsLayoutNVX value)
		{
			return value.handle;
		}
		public static explicit operator IndirectCommandsLayoutNVX(ulong value)
		{
			return new IndirectCommandsLayoutNVX (value);
		}
	}
	// VkIndirectCommandsLayoutTokenNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct IndirectCommandsLayoutTokenNVX
	{
		// VkIndirectCommandsTokenTypeNVX tokenType
		public IndirectCommandsTokenTypeNVX tokenType;
		// uint32_t bindingUnit
		public uint bindingUnit;
		// uint32_t dynamicCount
		public uint dynamicCount;
		// uint32_t divisor
		public uint divisor;
	}
	// VkIndirectCommandsTokenNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct IndirectCommandsTokenNVX
	{
		// VkIndirectCommandsTokenTypeNVX tokenType
		public IndirectCommandsTokenTypeNVX tokenType;
		// VkBuffer buffer
		public Buffer buffer;
		// VkDeviceSize offset
		public ulong offset;
	}
	// VkInstance
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Instance : IEquatable<Instance>
	{
		private IntPtr handle;
	
		public static readonly Instance Zero;
	
		public Instance(IntPtr value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == IntPtr.Zero; } }
		
		public bool Equals(Instance other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Instance && ((Instance)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString ();
		}
		
		public static bool operator ==(Instance value1, Instance value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Instance value1, Instance value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator IntPtr(Instance value)
		{
			return value.handle;
		}
		public static explicit operator Instance(IntPtr value)
		{
			return new Instance (value);
		}
	}
	// VkInstanceCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct InstanceCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkInstanceCreateFlags flags
		public uint flags;
		// VkApplicationInfo* pApplicationInfo
		public ApplicationInfo* pApplicationInfo;
		// uint32_t enabledLayerCount
		public uint enabledLayerCount;
		// char* ppEnabledLayerNames
		public byte* ppEnabledLayerNames;
		// uint32_t enabledExtensionCount
		public uint enabledExtensionCount;
		// char* ppEnabledExtensionNames
		public byte* ppEnabledExtensionNames;
	}
	// VkLayerProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct LayerProperties
	{
		// char layerName
		public fixed byte layerName[256];
		// uint32_t specVersion
		public Version specVersion;
		// uint32_t implementationVersion
		public Version implementationVersion;
		// char description
		public fixed byte description[256];
	}
	// VkMappedMemoryRange
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MappedMemoryRange
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDeviceMemory memory
		public DeviceMemory memory;
		// VkDeviceSize offset
		public ulong offset;
		// VkDeviceSize size
		public ulong size;
	}
	// VkMemoryAllocateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MemoryAllocateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDeviceSize allocationSize
		public ulong allocationSize;
		// uint32_t memoryTypeIndex
		public uint memoryTypeIndex;
	}
	// VkMemoryBarrier
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MemoryBarrier
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkAccessFlags srcAccessMask
		public AccessFlagBits sourceAccessMask;
		// VkAccessFlags dstAccessMask
		public AccessFlagBits destinationAccessMask;
	}
	// VkMemoryHeap
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MemoryHeap
	{
		// VkDeviceSize size
		public ulong size;
		// VkMemoryHeapFlags flags
		public MemoryHeapFlagBits flags;
	}
	// VkMemoryRequirements
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MemoryRequirements
	{
		// VkDeviceSize size
		public ulong size;
		// VkDeviceSize alignment
		public ulong alignment;
		// uint32_t memoryTypeBits
		public uint memoryTypeBits;
	}
	// VkMemoryType
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MemoryType
	{
		// VkMemoryPropertyFlags propertyFlags
		public MemoryPropertyFlagBits propertyFlags;
		// uint32_t heapIndex
		public uint heapIndex;
	}
	// VkMirSurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct MirSurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkMirSurfaceCreateFlagsKHR flags
		public uint flags;
		// MirConnection* connection
		public IntPtr* connection;
		// MirSurface* mirSurface
		public IntPtr* mirSurface;
	}
	// VkObjectTableCreateInfoNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTableCreateInfoNVX
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t objectCount
		public uint objectCount;
		// VkObjectEntryTypeNVX* pObjectEntryTypes
		public ObjectEntryTypeNVX* pObjectEntryTypes;
		// uint32_t* pObjectEntryCounts
		public uint* pObjectEntryCounts;
		// VkObjectEntryUsageFlagsNVX* pObjectEntryUsageFlags
		public ObjectEntryUsageFlagBitsNVX* pObjectEntryUsageFlags;
		// uint32_t maxUniformBuffersPerDescriptor
		public uint maxUniformBuffersPerDescriptor;
		// uint32_t maxStorageBuffersPerDescriptor
		public uint maxStorageBuffersPerDescriptor;
		// uint32_t maxStorageImagesPerDescriptor
		public uint maxStorageImagesPerDescriptor;
		// uint32_t maxSampledImagesPerDescriptor
		public uint maxSampledImagesPerDescriptor;
		// uint32_t maxPipelineLayouts
		public uint maxPipelineLayouts;
	}
	// VkObjectTableDescriptorSetEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTableDescriptorSetEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
		// VkPipelineLayout pipelineLayout
		public PipelineLayout pipelineLayout;
		// VkDescriptorSet descriptorSet
		public DescriptorSet descriptorSet;
	}
	// VkObjectTableEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTableEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
	}
	// VkObjectTableIndexBufferEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTableIndexBufferEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
		// VkBuffer buffer
		public Buffer buffer;
	}
	// VkObjectTableNVX
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct ObjectTableNVX : IEquatable<ObjectTableNVX>
	{
		private ulong handle;
	
		public static readonly ObjectTableNVX Zero;
	
		public ObjectTableNVX(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(ObjectTableNVX other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is ObjectTableNVX && ((ObjectTableNVX)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(ObjectTableNVX value1, ObjectTableNVX value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(ObjectTableNVX value1, ObjectTableNVX value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(ObjectTableNVX value)
		{
			return value.handle;
		}
		public static explicit operator ObjectTableNVX(ulong value)
		{
			return new ObjectTableNVX (value);
		}
	}
	// VkObjectTablePipelineEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTablePipelineEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
		// VkPipeline pipeline
		public Pipeline pipeline;
	}
	// VkObjectTablePushConstantEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTablePushConstantEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
		// VkPipelineLayout pipelineLayout
		public PipelineLayout pipelineLayout;
		// VkShaderStageFlags stageFlags
		public ShaderStageFlagBits stageFlags;
	}
	// VkObjectTableVertexBufferEntryNVX
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ObjectTableVertexBufferEntryNVX
	{
		// VkObjectEntryTypeNVX type
		public ObjectEntryTypeNVX type;
		// VkObjectEntryUsageFlagsNVX flags
		public ObjectEntryUsageFlagBitsNVX flags;
		// VkBuffer buffer
		public Buffer buffer;
	}
	// VkOffset2D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Offset2D
	{
		// int32_t x
		public int x;
		// int32_t y
		public int y;
	}
	// VkOffset3D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Offset3D
	{
		// int32_t x
		public int x;
		// int32_t y
		public int y;
		// int32_t z
		public int z;
	}
	// VkPhysicalDevice
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct PhysicalDevice : IEquatable<PhysicalDevice>
	{
		private IntPtr handle;
	
		public static readonly PhysicalDevice Zero;
	
		public PhysicalDevice(IntPtr value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == IntPtr.Zero; } }
		
		public bool Equals(PhysicalDevice other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is PhysicalDevice && ((PhysicalDevice)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString ();
		}
		
		public static bool operator ==(PhysicalDevice value1, PhysicalDevice value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(PhysicalDevice value1, PhysicalDevice value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator IntPtr(PhysicalDevice value)
		{
			return value.handle;
		}
		public static explicit operator PhysicalDevice(IntPtr value)
		{
			return new PhysicalDevice (value);
		}
	}
	// VkPhysicalDeviceFeatures
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PhysicalDeviceFeatures
	{
		// VkBool32 robustBufferAccess
		public Boolean32 robustBufferAccess;
		// VkBool32 fullDrawIndexUint32
		public Boolean32 fullDrawIndexUint32;
		// VkBool32 imageCubeArray
		public Boolean32 imageCubeArray;
		// VkBool32 independentBlend
		public Boolean32 independentBlend;
		// VkBool32 geometryShader
		public Boolean32 geometryShader;
		// VkBool32 tessellationShader
		public Boolean32 tessellationShader;
		// VkBool32 sampleRateShading
		public Boolean32 sampleRateShading;
		// VkBool32 dualSrcBlend
		public Boolean32 dualSourceBlend;
		// VkBool32 logicOp
		public Boolean32 logicOperation;
		// VkBool32 multiDrawIndirect
		public Boolean32 multiDrawIndirect;
		// VkBool32 drawIndirectFirstInstance
		public Boolean32 drawIndirectFirstInstance;
		// VkBool32 depthClamp
		public Boolean32 depthClamp;
		// VkBool32 depthBiasClamp
		public Boolean32 depthBiasClamp;
		// VkBool32 fillModeNonSolid
		public Boolean32 fillModeNonSolid;
		// VkBool32 depthBounds
		public Boolean32 depthBounds;
		// VkBool32 wideLines
		public Boolean32 wideLines;
		// VkBool32 largePoints
		public Boolean32 largePoints;
		// VkBool32 alphaToOne
		public Boolean32 alphaToOne;
		// VkBool32 multiViewport
		public Boolean32 multiViewport;
		// VkBool32 samplerAnisotropy
		public Boolean32 samplerAnisotropy;
		// VkBool32 textureCompressionETC2
		public Boolean32 textureCompressionETC2;
		// VkBool32 textureCompressionASTC_LDR
		public Boolean32 textureCompressionASTC_LDR;
		// VkBool32 textureCompressionBC
		public Boolean32 textureCompressionBC;
		// VkBool32 occlusionQueryPrecise
		public Boolean32 occlusionQueryPrecise;
		// VkBool32 pipelineStatisticsQuery
		public Boolean32 pipelineStatisticsQuery;
		// VkBool32 vertexPipelineStoresAndAtomics
		public Boolean32 vertexPipelineStoresAndAtomics;
		// VkBool32 fragmentStoresAndAtomics
		public Boolean32 fragmentStoresAndAtomics;
		// VkBool32 shaderTessellationAndGeometryPointSize
		public Boolean32 shaderTessellationAndGeometryPointSize;
		// VkBool32 shaderImageGatherExtended
		public Boolean32 shaderImageGatherExtended;
		// VkBool32 shaderStorageImageExtendedFormats
		public Boolean32 shaderStorageImageExtendedFormats;
		// VkBool32 shaderStorageImageMultisample
		public Boolean32 shaderStorageImageMultisample;
		// VkBool32 shaderStorageImageReadWithoutFormat
		public Boolean32 shaderStorageImageReadWithoutFormat;
		// VkBool32 shaderStorageImageWriteWithoutFormat
		public Boolean32 shaderStorageImageWriteWithoutFormat;
		// VkBool32 shaderUniformBufferArrayDynamicIndexing
		public Boolean32 shaderUniformBufferArrayDynamicIndexing;
		// VkBool32 shaderSampledImageArrayDynamicIndexing
		public Boolean32 shaderSampledImageArrayDynamicIndexing;
		// VkBool32 shaderStorageBufferArrayDynamicIndexing
		public Boolean32 shaderStorageBufferArrayDynamicIndexing;
		// VkBool32 shaderStorageImageArrayDynamicIndexing
		public Boolean32 shaderStorageImageArrayDynamicIndexing;
		// VkBool32 shaderClipDistance
		public Boolean32 shaderClipDistance;
		// VkBool32 shaderCullDistance
		public Boolean32 shaderCullDistance;
		// VkBool32 shaderFloat64
		public Boolean32 shaderFloat64;
		// VkBool32 shaderInt64
		public Boolean32 shaderInt64;
		// VkBool32 shaderInt16
		public Boolean32 shaderInt16;
		// VkBool32 shaderResourceResidency
		public Boolean32 shaderResourceResidency;
		// VkBool32 shaderResourceMinLod
		public Boolean32 shaderResourceMinLod;
		// VkBool32 sparseBinding
		public Boolean32 sparseBinding;
		// VkBool32 sparseResidencyBuffer
		public Boolean32 sparseResidencyBuffer;
		// VkBool32 sparseResidencyImage2D
		public Boolean32 sparseResidencyImage2D;
		// VkBool32 sparseResidencyImage3D
		public Boolean32 sparseResidencyImage3D;
		// VkBool32 sparseResidency2Samples
		public Boolean32 sparseResidency2Samples;
		// VkBool32 sparseResidency4Samples
		public Boolean32 sparseResidency4Samples;
		// VkBool32 sparseResidency8Samples
		public Boolean32 sparseResidency8Samples;
		// VkBool32 sparseResidency16Samples
		public Boolean32 sparseResidency16Samples;
		// VkBool32 sparseResidencyAliased
		public Boolean32 sparseResidencyAliased;
		// VkBool32 variableMultisampleRate
		public Boolean32 variableMultisampleRate;
		// VkBool32 inheritedQueries
		public Boolean32 inheritedQueries;
	}
	// VkPhysicalDeviceLimits
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PhysicalDeviceLimits
	{
		// uint32_t maxImageDimension1D
		public uint maxImageDimension1D;
		// uint32_t maxImageDimension2D
		public uint maxImageDimension2D;
		// uint32_t maxImageDimension3D
		public uint maxImageDimension3D;
		// uint32_t maxImageDimensionCube
		public uint maxImageDimensionCube;
		// uint32_t maxImageArrayLayers
		public uint maxImageArrayLayers;
		// uint32_t maxTexelBufferElements
		public uint maxTexelBufferElements;
		// uint32_t maxUniformBufferRange
		public uint maxUniformBufferRange;
		// uint32_t maxStorageBufferRange
		public uint maxStorageBufferRange;
		// uint32_t maxPushConstantsSize
		public uint maxPushConstantsSize;
		// uint32_t maxMemoryAllocationCount
		public uint maxMemoryAllocationCount;
		// uint32_t maxSamplerAllocationCount
		public uint maxSamplerAllocationCount;
		// VkDeviceSize bufferImageGranularity
		public ulong bufferImageGranularity;
		// VkDeviceSize sparseAddressSpaceSize
		public ulong sparseAddressSpaceSize;
		// uint32_t maxBoundDescriptorSets
		public uint maxBoundDescriptorSets;
		// uint32_t maxPerStageDescriptorSamplers
		public uint maxPerStageDescriptorSamplers;
		// uint32_t maxPerStageDescriptorUniformBuffers
		public uint maxPerStageDescriptorUniformBuffers;
		// uint32_t maxPerStageDescriptorStorageBuffers
		public uint maxPerStageDescriptorStorageBuffers;
		// uint32_t maxPerStageDescriptorSampledImages
		public uint maxPerStageDescriptorSampledImages;
		// uint32_t maxPerStageDescriptorStorageImages
		public uint maxPerStageDescriptorStorageImages;
		// uint32_t maxPerStageDescriptorInputAttachments
		public uint maxPerStageDescriptorInputAttachments;
		// uint32_t maxPerStageResources
		public uint maxPerStageResources;
		// uint32_t maxDescriptorSetSamplers
		public uint maxDescriptorSetSamplers;
		// uint32_t maxDescriptorSetUniformBuffers
		public uint maxDescriptorSetUniformBuffers;
		// uint32_t maxDescriptorSetUniformBuffersDynamic
		public uint maxDescriptorSetUniformBuffersDynamic;
		// uint32_t maxDescriptorSetStorageBuffers
		public uint maxDescriptorSetStorageBuffers;
		// uint32_t maxDescriptorSetStorageBuffersDynamic
		public uint maxDescriptorSetStorageBuffersDynamic;
		// uint32_t maxDescriptorSetSampledImages
		public uint maxDescriptorSetSampledImages;
		// uint32_t maxDescriptorSetStorageImages
		public uint maxDescriptorSetStorageImages;
		// uint32_t maxDescriptorSetInputAttachments
		public uint maxDescriptorSetInputAttachments;
		// uint32_t maxVertexInputAttributes
		public uint maxVertexInputAttributes;
		// uint32_t maxVertexInputBindings
		public uint maxVertexInputBindings;
		// uint32_t maxVertexInputAttributeOffset
		public uint maxVertexInputAttributeOffset;
		// uint32_t maxVertexInputBindingStride
		public uint maxVertexInputBindingStride;
		// uint32_t maxVertexOutputComponents
		public uint maxVertexOutputComponents;
		// uint32_t maxTessellationGenerationLevel
		public uint maxTessellationGenerationLevel;
		// uint32_t maxTessellationPatchSize
		public uint maxTessellationPatchSize;
		// uint32_t maxTessellationControlPerVertexInputComponents
		public uint maxTessellationControlPerVertexInputComponents;
		// uint32_t maxTessellationControlPerVertexOutputComponents
		public uint maxTessellationControlPerVertexOutputComponents;
		// uint32_t maxTessellationControlPerPatchOutputComponents
		public uint maxTessellationControlPerPatchOutputComponents;
		// uint32_t maxTessellationControlTotalOutputComponents
		public uint maxTessellationControlTotalOutputComponents;
		// uint32_t maxTessellationEvaluationInputComponents
		public uint maxTessellationEvaluationInputComponents;
		// uint32_t maxTessellationEvaluationOutputComponents
		public uint maxTessellationEvaluationOutputComponents;
		// uint32_t maxGeometryShaderInvocations
		public uint maxGeometryShaderInvocations;
		// uint32_t maxGeometryInputComponents
		public uint maxGeometryInputComponents;
		// uint32_t maxGeometryOutputComponents
		public uint maxGeometryOutputComponents;
		// uint32_t maxGeometryOutputVertices
		public uint maxGeometryOutputVertices;
		// uint32_t maxGeometryTotalOutputComponents
		public uint maxGeometryTotalOutputComponents;
		// uint32_t maxFragmentInputComponents
		public uint maxFragmentInputComponents;
		// uint32_t maxFragmentOutputAttachments
		public uint maxFragmentOutputAttachments;
		// uint32_t maxFragmentDualSrcAttachments
		public uint maxFragmentDualSourceAttachments;
		// uint32_t maxFragmentCombinedOutputResources
		public uint maxFragmentCombinedOutputResources;
		// uint32_t maxComputeSharedMemorySize
		public uint maxComputeSharedMemorySize;
		// uint32_t maxComputeWorkGroupCount
		public fixed uint maxComputeWorkGroupCount[3];
		// uint32_t maxComputeWorkGroupInvocations
		public uint maxComputeWorkGroupInvocations;
		// uint32_t maxComputeWorkGroupSize
		public fixed uint maxComputeWorkGroupSize[3];
		// uint32_t subPixelPrecisionBits
		public uint subPixelPrecisionBits;
		// uint32_t subTexelPrecisionBits
		public uint subTexelPrecisionBits;
		// uint32_t mipmapPrecisionBits
		public uint mipmapPrecisionBits;
		// uint32_t maxDrawIndexedIndexValue
		public uint maxDrawIndexedIndexValue;
		// uint32_t maxDrawIndirectCount
		public uint maxDrawIndirectCount;
		// float maxSamplerLodBias
		public float maxSamplerLodBias;
		// float maxSamplerAnisotropy
		public float maxSamplerAnisotropy;
		// uint32_t maxViewports
		public uint maxViewports;
		// uint32_t maxViewportDimensions
		public fixed uint maxViewportDimensions[2];
		// float viewportBoundsRange
		public fixed float viewportBoundsRange[2];
		// uint32_t viewportSubPixelBits
		public uint viewportSubPixelBits;
		// size_t minMemoryMapAlignment
		public int minMemoryMapAlignment;
		// VkDeviceSize minTexelBufferOffsetAlignment
		public ulong minTexelBufferOffsetAlignment;
		// VkDeviceSize minUniformBufferOffsetAlignment
		public ulong minUniformBufferOffsetAlignment;
		// VkDeviceSize minStorageBufferOffsetAlignment
		public ulong minStorageBufferOffsetAlignment;
		// int32_t minTexelOffset
		public int minTexelOffset;
		// uint32_t maxTexelOffset
		public uint maxTexelOffset;
		// int32_t minTexelGatherOffset
		public int minTexelGatherOffset;
		// uint32_t maxTexelGatherOffset
		public uint maxTexelGatherOffset;
		// float minInterpolationOffset
		public float minInterpolationOffset;
		// float maxInterpolationOffset
		public float maxInterpolationOffset;
		// uint32_t subPixelInterpolationOffsetBits
		public uint subPixelInterpolationOffsetBits;
		// uint32_t maxFramebufferWidth
		public uint maxFramebufferWidth;
		// uint32_t maxFramebufferHeight
		public uint maxFramebufferHeight;
		// uint32_t maxFramebufferLayers
		public uint maxFramebufferLayers;
		// VkSampleCountFlags framebufferColorSampleCounts
		public SampleCountFlagBits framebufferColorSampleCounts;
		// VkSampleCountFlags framebufferDepthSampleCounts
		public SampleCountFlagBits framebufferDepthSampleCounts;
		// VkSampleCountFlags framebufferStencilSampleCounts
		public SampleCountFlagBits framebufferStencilSampleCounts;
		// VkSampleCountFlags framebufferNoAttachmentsSampleCounts
		public SampleCountFlagBits framebufferNoAttachmentsSampleCounts;
		// uint32_t maxColorAttachments
		public uint maxColorAttachments;
		// VkSampleCountFlags sampledImageColorSampleCounts
		public SampleCountFlagBits sampledImageColorSampleCounts;
		// VkSampleCountFlags sampledImageIntegerSampleCounts
		public SampleCountFlagBits sampledImageIntegerSampleCounts;
		// VkSampleCountFlags sampledImageDepthSampleCounts
		public SampleCountFlagBits sampledImageDepthSampleCounts;
		// VkSampleCountFlags sampledImageStencilSampleCounts
		public SampleCountFlagBits sampledImageStencilSampleCounts;
		// VkSampleCountFlags storageImageSampleCounts
		public SampleCountFlagBits storageImageSampleCounts;
		// uint32_t maxSampleMaskWords
		public uint maxSampleMaskWords;
		// VkBool32 timestampComputeAndGraphics
		public Boolean32 timestampComputeAndGraphics;
		// float timestampPeriod
		public float timestampPeriod;
		// uint32_t maxClipDistances
		public uint maxClipDistances;
		// uint32_t maxCullDistances
		public uint maxCullDistances;
		// uint32_t maxCombinedClipAndCullDistances
		public uint maxCombinedClipAndCullDistances;
		// uint32_t discreteQueuePriorities
		public uint discreteQueuePriorities;
		// float pointSizeRange
		public fixed float pointSizeRange[2];
		// float lineWidthRange
		public fixed float lineWidthRange[2];
		// float pointSizeGranularity
		public float pointSizeGranularity;
		// float lineWidthGranularity
		public float lineWidthGranularity;
		// VkBool32 strictLines
		public Boolean32 strictLines;
		// VkBool32 standardSampleLocations
		public Boolean32 standardSampleLocations;
		// VkDeviceSize optimalBufferCopyOffsetAlignment
		public ulong optimalBufferCopyOffsetAlignment;
		// VkDeviceSize optimalBufferCopyRowPitchAlignment
		public ulong optimalBufferCopyRowPitchAlignment;
		// VkDeviceSize nonCoherentAtomSize
		public ulong nonCoherentAtomSize;
	}
	// VkPhysicalDeviceMemoryProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PhysicalDeviceMemoryProperties
	{
		// uint32_t memoryTypeCount
		public uint memoryTypeCount;
		// VkMemoryType memoryTypes
		public fixed int memoryTypes[64];
		// uint32_t memoryHeapCount
		public uint memoryHeapCount;
		// VkMemoryHeap memoryHeaps
		public fixed int memoryHeaps[48];
	}
	// VkPhysicalDeviceProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PhysicalDeviceProperties
	{
		// uint32_t apiVersion
		public Version apiVersion;
		// uint32_t driverVersion
		public uint driverVersion;
		// uint32_t vendorID
		public uint vendorID;
		// uint32_t deviceID
		public uint deviceID;
		// VkPhysicalDeviceType deviceType
		public PhysicalDeviceType deviceType;
		// char deviceName
		public fixed byte deviceName[256];
		// uint8_t pipelineCacheUUID
		public fixed byte pipelineCacheUUID[16];
		// VkPhysicalDeviceLimits limits
		public PhysicalDeviceLimits limits;
		// VkPhysicalDeviceSparseProperties sparseProperties
		public PhysicalDeviceSparseProperties sparseProperties;
	}
	// VkPhysicalDeviceSparseProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PhysicalDeviceSparseProperties
	{
		// VkBool32 residencyStandard2DBlockShape
		public Boolean32 residencyStandard2DBlockShape;
		// VkBool32 residencyStandard2DMultisampleBlockShape
		public Boolean32 residencyStandard2DMultisampleBlockShape;
		// VkBool32 residencyStandard3DBlockShape
		public Boolean32 residencyStandard3DBlockShape;
		// VkBool32 residencyAlignedMipSize
		public Boolean32 residencyAlignedMipSize;
		// VkBool32 residencyNonResidentStrict
		public Boolean32 residencyNonResidentStrict;
	}
	// VkPipeline
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Pipeline : IEquatable<Pipeline>
	{
		private ulong handle;
	
		public static readonly Pipeline Zero;
	
		public Pipeline(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Pipeline other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Pipeline && ((Pipeline)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Pipeline value1, Pipeline value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Pipeline value1, Pipeline value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Pipeline value)
		{
			return value.handle;
		}
		public static explicit operator Pipeline(ulong value)
		{
			return new Pipeline (value);
		}
	}
	// VkPipelineCache
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct PipelineCache : IEquatable<PipelineCache>
	{
		private ulong handle;
	
		public static readonly PipelineCache Zero;
	
		public PipelineCache(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(PipelineCache other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is PipelineCache && ((PipelineCache)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(PipelineCache value1, PipelineCache value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(PipelineCache value1, PipelineCache value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(PipelineCache value)
		{
			return value.handle;
		}
		public static explicit operator PipelineCache(ulong value)
		{
			return new PipelineCache (value);
		}
	}
	// VkPipelineCacheCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineCacheCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineCacheCreateFlags flags
		public uint flags;
		// size_t initialDataSize
		public int initialDataSize;
		// void* pInitialData
		public IntPtr pInitialData;
	}
	// VkPipelineColorBlendAttachmentState
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineColorBlendAttachmentState
	{
		// VkBool32 blendEnable
		public Boolean32 blendEnable;
		// VkBlendFactor srcColorBlendFactor
		public BlendFactor sourceColorBlendFactor;
		// VkBlendFactor dstColorBlendFactor
		public BlendFactor destinationColorBlendFactor;
		// VkBlendOp colorBlendOp
		public BlendOperation colorBlendOperation;
		// VkBlendFactor srcAlphaBlendFactor
		public BlendFactor sourceAlphaBlendFactor;
		// VkBlendFactor dstAlphaBlendFactor
		public BlendFactor destinationAlphaBlendFactor;
		// VkBlendOp alphaBlendOp
		public BlendOperation alphaBlendOperation;
		// VkColorComponentFlags colorWriteMask
		public ColorComponentFlagBits colorWriteMask;
	}
	// VkPipelineColorBlendStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineColorBlendStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineColorBlendStateCreateFlags flags
		public uint flags;
		// VkBool32 logicOpEnable
		public Boolean32 logicOperationEnable;
		// VkLogicOp logicOp
		public LogicOperation logicOperation;
		// uint32_t attachmentCount
		public uint attachmentCount;
		// VkPipelineColorBlendAttachmentState* pAttachments
		public PipelineColorBlendAttachmentState* pAttachments;
		// float blendConstants
		public fixed float blendConstants[4];
	}
	// VkPipelineDepthStencilStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineDepthStencilStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineDepthStencilStateCreateFlags flags
		public uint flags;
		// VkBool32 depthTestEnable
		public Boolean32 depthTestEnable;
		// VkBool32 depthWriteEnable
		public Boolean32 depthWriteEnable;
		// VkCompareOp depthCompareOp
		public CompareOperation depthCompareOperation;
		// VkBool32 depthBoundsTestEnable
		public Boolean32 depthBoundsTestEnable;
		// VkBool32 stencilTestEnable
		public Boolean32 stencilTestEnable;
		// VkStencilOpState front
		public StencilOpState front;
		// VkStencilOpState back
		public StencilOpState back;
		// float minDepthBounds
		public float minDepthBounds;
		// float maxDepthBounds
		public float maxDepthBounds;
	}
	// VkPipelineDynamicStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineDynamicStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineDynamicStateCreateFlags flags
		public uint flags;
		// uint32_t dynamicStateCount
		public uint dynamicStateCount;
		// VkDynamicState* pDynamicStates
		public DynamicState* pDynamicStates;
	}
	// VkPipelineInputAssemblyStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineInputAssemblyStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineInputAssemblyStateCreateFlags flags
		public uint flags;
		// VkPrimitiveTopology topology
		public PrimitiveTopology topology;
		// VkBool32 primitiveRestartEnable
		public Boolean32 primitiveRestartEnable;
	}
	// VkPipelineLayout
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct PipelineLayout : IEquatable<PipelineLayout>
	{
		private ulong handle;
	
		public static readonly PipelineLayout Zero;
	
		public PipelineLayout(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(PipelineLayout other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is PipelineLayout && ((PipelineLayout)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(PipelineLayout value1, PipelineLayout value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(PipelineLayout value1, PipelineLayout value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(PipelineLayout value)
		{
			return value.handle;
		}
		public static explicit operator PipelineLayout(ulong value)
		{
			return new PipelineLayout (value);
		}
	}
	// VkPipelineLayoutCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineLayoutCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineLayoutCreateFlags flags
		public uint flags;
		// uint32_t setLayoutCount
		public uint setLayoutCount;
		// VkDescriptorSetLayout* pSetLayouts
		public DescriptorSetLayout* pSetLayouts;
		// uint32_t pushConstantRangeCount
		public uint pushConstantRangeCount;
		// VkPushConstantRange* pPushConstantRanges
		public PushConstantRange* pPushConstantRanges;
	}
	// VkPipelineMultisampleStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineMultisampleStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineMultisampleStateCreateFlags flags
		public uint flags;
		// VkSampleCountFlagBits rasterizationSamples
		public SampleCountFlagBits rasterizationSamples;
		// VkBool32 sampleShadingEnable
		public Boolean32 sampleShadingEnable;
		// float minSampleShading
		public float minSampleShading;
		// VkSampleMask* pSampleMask
		public uint* pSampleMask;
		// VkBool32 alphaToCoverageEnable
		public Boolean32 alphaToCoverageEnable;
		// VkBool32 alphaToOneEnable
		public Boolean32 alphaToOneEnable;
	}
	// VkPipelineRasterizationStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineRasterizationStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineRasterizationStateCreateFlags flags
		public uint flags;
		// VkBool32 depthClampEnable
		public Boolean32 depthClampEnable;
		// VkBool32 rasterizerDiscardEnable
		public Boolean32 rasterizerDiscardEnable;
		// VkPolygonMode polygonMode
		public PolygonMode polygonMode;
		// VkCullModeFlags cullMode
		public CullModeFlagBits cullMode;
		// VkFrontFace frontFace
		public FrontFace frontFace;
		// VkBool32 depthBiasEnable
		public Boolean32 depthBiasEnable;
		// float depthBiasConstantFactor
		public float depthBiasConstantFactor;
		// float depthBiasClamp
		public float depthBiasClamp;
		// float depthBiasSlopeFactor
		public float depthBiasSlopeFactor;
		// float lineWidth
		public float lineWidth;
	}
	// VkPipelineRasterizationStateRasterizationOrderAMD
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineRasterizationStateRasterizationOrderAMD
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkRasterizationOrderAMD rasterizationOrder
		public RasterizationOrderAMD rasterizationOrder;
	}
	// VkPipelineShaderStageCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineShaderStageCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineShaderStageCreateFlags flags
		public uint flags;
		// VkShaderStageFlagBits stage
		public ShaderStageFlagBits stage;
		// VkShaderModule module
		public ShaderModule module;
		// char* pName
		public byte* pName;
		// VkSpecializationInfo* pSpecializationInfo
		public SpecializationInfo* pSpecializationInfo;
	}
	// VkPipelineTessellationStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineTessellationStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineTessellationStateCreateFlags flags
		public uint flags;
		// uint32_t patchControlPoints
		public uint patchControlPoints;
	}
	// VkPipelineVertexInputStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineVertexInputStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineVertexInputStateCreateFlags flags
		public uint flags;
		// uint32_t vertexBindingDescriptionCount
		public uint vertexBindingDescriptionCount;
		// VkVertexInputBindingDescription* pVertexBindingDescriptions
		public VertexInputBindingDescription* pVertexBindingDescriptions;
		// uint32_t vertexAttributeDescriptionCount
		public uint vertexAttributeDescriptionCount;
		// VkVertexInputAttributeDescription* pVertexAttributeDescriptions
		public VertexInputAttributeDescription* pVertexAttributeDescriptions;
	}
	// VkPipelineViewportStateCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PipelineViewportStateCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkPipelineViewportStateCreateFlags flags
		public uint flags;
		// uint32_t viewportCount
		public uint viewportCount;
		// VkViewport* pViewports
		public Viewport* pViewports;
		// uint32_t scissorCount
		public uint scissorCount;
		// VkRect2D* pScissors
		public Rect2D* pScissors;
	}
	// VkPresentInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PresentInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t waitSemaphoreCount
		public uint waitSemaphoreCount;
		// VkSemaphore* pWaitSemaphores
		public Semaphore* pWaitSemaphores;
		// uint32_t swapchainCount
		public uint swapchainCount;
		// VkSwapchainKHR* pSwapchains
		public SwapchainKHR* pSwapchains;
		// uint32_t* pImageIndices
		public uint* pImageIndices;
		// VkResult* pResults
		public Result* pResults;
	}
	// VkPushConstantRange
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct PushConstantRange
	{
		// VkShaderStageFlags stageFlags
		public ShaderStageFlagBits stageFlags;
		// uint32_t offset
		public uint offset;
		// uint32_t size
		public uint size;
	}
	// VkQueryPool
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct QueryPool : IEquatable<QueryPool>
	{
		private ulong handle;
	
		public static readonly QueryPool Zero;
	
		public QueryPool(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(QueryPool other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is QueryPool && ((QueryPool)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(QueryPool value1, QueryPool value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(QueryPool value1, QueryPool value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(QueryPool value)
		{
			return value.handle;
		}
		public static explicit operator QueryPool(ulong value)
		{
			return new QueryPool (value);
		}
	}
	// VkQueryPoolCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct QueryPoolCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkQueryPoolCreateFlags flags
		public uint flags;
		// VkQueryType queryType
		public QueryType queryType;
		// uint32_t queryCount
		public uint queryCount;
		// VkQueryPipelineStatisticFlags pipelineStatistics
		public QueryPipelineStatisticFlagBits pipelineStatistics;
	}
	// VkQueue
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Queue : IEquatable<Queue>
	{
		private IntPtr handle;
	
		public static readonly Queue Zero;
	
		public Queue(IntPtr value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == IntPtr.Zero; } }
		
		public bool Equals(Queue other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Queue && ((Queue)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString ();
		}
		
		public static bool operator ==(Queue value1, Queue value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Queue value1, Queue value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator IntPtr(Queue value)
		{
			return value.handle;
		}
		public static explicit operator Queue(IntPtr value)
		{
			return new Queue (value);
		}
	}
	// VkQueueFamilyProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct QueueFamilyProperties
	{
		// VkQueueFlags queueFlags
		public QueueFlagBits queueFlags;
		// uint32_t queueCount
		public uint queueCount;
		// uint32_t timestampValidBits
		public uint timestampValidBits;
		// VkExtent3D minImageTransferGranularity
		public Extent3D minImageTransferGranularity;
	}
	// VkRect2D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Rect2D
	{
		// VkOffset2D offset
		public Offset2D offset;
		// VkExtent2D extent
		public Extent2D extent;
	}
	// VkRect3D
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Rect3D
	{
		// VkOffset3D offset
		public Offset3D offset;
		// VkExtent3D extent
		public Extent3D extent;
	}
	// VkRenderPass
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct RenderPass : IEquatable<RenderPass>
	{
		private ulong handle;
	
		public static readonly RenderPass Zero;
	
		public RenderPass(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(RenderPass other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is RenderPass && ((RenderPass)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(RenderPass value1, RenderPass value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(RenderPass value1, RenderPass value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(RenderPass value)
		{
			return value.handle;
		}
		public static explicit operator RenderPass(ulong value)
		{
			return new RenderPass (value);
		}
	}
	// VkRenderPassBeginInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct RenderPassBeginInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkRenderPass renderPass
		public RenderPass renderPass;
		// VkFramebuffer framebuffer
		public Framebuffer framebuffer;
		// VkRect2D renderArea
		public Rect2D renderArea;
		// uint32_t clearValueCount
		public uint clearValueCount;
		// VkClearValue* pClearValues
		public ClearValue* pClearValues;
	}
	// VkRenderPassCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct RenderPassCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkRenderPassCreateFlags flags
		public uint flags;
		// uint32_t attachmentCount
		public uint attachmentCount;
		// VkAttachmentDescription* pAttachments
		public AttachmentDescription* pAttachments;
		// uint32_t subpassCount
		public uint subpassCount;
		// VkSubpassDescription* pSubpasses
		public SubpassDescription* pSubpasses;
		// uint32_t dependencyCount
		public uint dependencyCount;
		// VkSubpassDependency* pDependencies
		public SubpassDependency* pDependencies;
	}
	// VkSampler
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Sampler : IEquatable<Sampler>
	{
		private ulong handle;
	
		public static readonly Sampler Zero;
	
		public Sampler(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Sampler other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Sampler && ((Sampler)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Sampler value1, Sampler value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Sampler value1, Sampler value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Sampler value)
		{
			return value.handle;
		}
		public static explicit operator Sampler(ulong value)
		{
			return new Sampler (value);
		}
	}
	// VkSamplerCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SamplerCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkSamplerCreateFlags flags
		public uint flags;
		// VkFilter magFilter
		public Filter magFilter;
		// VkFilter minFilter
		public Filter minFilter;
		// VkSamplerMipmapMode mipmapMode
		public SamplerMipmapMode mipmapMode;
		// VkSamplerAddressMode addressModeU
		public SamplerAddressMode addressModeU;
		// VkSamplerAddressMode addressModeV
		public SamplerAddressMode addressModeV;
		// VkSamplerAddressMode addressModeW
		public SamplerAddressMode addressModeW;
		// float mipLodBias
		public float mipLodBias;
		// VkBool32 anisotropyEnable
		public Boolean32 anisotropyEnable;
		// float maxAnisotropy
		public float maxAnisotropy;
		// VkBool32 compareEnable
		public Boolean32 compareEnable;
		// VkCompareOp compareOp
		public CompareOperation compareOperation;
		// float minLod
		public float minLod;
		// float maxLod
		public float maxLod;
		// VkBorderColor borderColor
		public BorderColor borderColor;
		// VkBool32 unnormalizedCoordinates
		public Boolean32 unnormalizedCoordinates;
	}
	// VkSemaphore
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct Semaphore : IEquatable<Semaphore>
	{
		private ulong handle;
	
		public static readonly Semaphore Zero;
	
		public Semaphore(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(Semaphore other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is Semaphore && ((Semaphore)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(Semaphore value1, Semaphore value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(Semaphore value1, Semaphore value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(Semaphore value)
		{
			return value.handle;
		}
		public static explicit operator Semaphore(ulong value)
		{
			return new Semaphore (value);
		}
	}
	// VkSemaphoreCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SemaphoreCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkSemaphoreCreateFlags flags
		public uint flags;
	}
	// VkShaderModule
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct ShaderModule : IEquatable<ShaderModule>
	{
		private ulong handle;
	
		public static readonly ShaderModule Zero;
	
		public ShaderModule(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(ShaderModule other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is ShaderModule && ((ShaderModule)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(ShaderModule value1, ShaderModule value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(ShaderModule value1, ShaderModule value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(ShaderModule value)
		{
			return value.handle;
		}
		public static explicit operator ShaderModule(ulong value)
		{
			return new ShaderModule (value);
		}
	}
	// VkShaderModuleCreateInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ShaderModuleCreateInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkShaderModuleCreateFlags flags
		public uint flags;
		// size_t codeSize
		public int codeSize;
		// uint32_t* pCode
		public uint* pCode;
	}
	// VkSparseBufferMemoryBindInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseBufferMemoryBindInfo
	{
		// VkBuffer buffer
		public Buffer buffer;
		// uint32_t bindCount
		public uint bindCount;
		// VkSparseMemoryBind* pBinds
		public SparseMemoryBind* pBinds;
	}
	// VkSparseImageFormatProperties
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseImageFormatProperties
	{
		// VkImageAspectFlags aspectMask
		public ImageAspectFlagBits aspectMask;
		// VkExtent3D imageGranularity
		public Extent3D imageGranularity;
		// VkSparseImageFormatFlags flags
		public SparseImageFormatFlagBits flags;
	}
	// VkSparseImageMemoryBind
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseImageMemoryBind
	{
		// VkImageSubresource subresource
		public ImageSubresource subresource;
		// VkOffset3D offset
		public Offset3D offset;
		// VkExtent3D extent
		public Extent3D extent;
		// VkDeviceMemory memory
		public DeviceMemory memory;
		// VkDeviceSize memoryOffset
		public ulong memoryOffset;
		// VkSparseMemoryBindFlags flags
		public SparseMemoryBindFlagBits flags;
	}
	// VkSparseImageMemoryBindInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseImageMemoryBindInfo
	{
		// VkImage image
		public Image image;
		// uint32_t bindCount
		public uint bindCount;
		// VkSparseImageMemoryBind* pBinds
		public SparseImageMemoryBind* pBinds;
	}
	// VkSparseImageMemoryRequirements
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseImageMemoryRequirements
	{
		// VkSparseImageFormatProperties formatProperties
		public SparseImageFormatProperties formatProperties;
		// uint32_t imageMipTailFirstLod
		public uint imageMipTailFirstLod;
		// VkDeviceSize imageMipTailSize
		public ulong imageMipTailSize;
		// VkDeviceSize imageMipTailOffset
		public ulong imageMipTailOffset;
		// VkDeviceSize imageMipTailStride
		public ulong imageMipTailStride;
	}
	// VkSparseImageOpaqueMemoryBindInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseImageOpaqueMemoryBindInfo
	{
		// VkImage image
		public Image image;
		// uint32_t bindCount
		public uint bindCount;
		// VkSparseMemoryBind* pBinds
		public SparseMemoryBind* pBinds;
	}
	// VkSparseMemoryBind
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SparseMemoryBind
	{
		// VkDeviceSize resourceOffset
		public ulong resourceOffset;
		// VkDeviceSize size
		public ulong size;
		// VkDeviceMemory memory
		public DeviceMemory memory;
		// VkDeviceSize memoryOffset
		public ulong memoryOffset;
		// VkSparseMemoryBindFlags flags
		public SparseMemoryBindFlagBits flags;
	}
	// VkSpecializationInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SpecializationInfo
	{
		// uint32_t mapEntryCount
		public uint mapEntryCount;
		// VkSpecializationMapEntry* pMapEntries
		public SpecializationMapEntry* pMapEntries;
		// size_t dataSize
		public int dataSize;
		// void* pData
		public IntPtr pData;
	}
	// VkSpecializationMapEntry
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SpecializationMapEntry
	{
		// uint32_t constantID
		public uint constantID;
		// uint32_t offset
		public uint offset;
		// size_t size
		public int size;
	}
	// VkStencilOpState
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct StencilOpState
	{
		// VkStencilOp failOp
		public StencilOperation failOperation;
		// VkStencilOp passOp
		public StencilOperation passOperation;
		// VkStencilOp depthFailOp
		public StencilOperation depthFailOperation;
		// VkCompareOp compareOp
		public CompareOperation compareOperation;
		// uint32_t compareMask
		public uint compareMask;
		// uint32_t writeMask
		public uint writeMask;
		// uint32_t reference
		public uint reference;
	}
	// VkSubmitInfo
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SubmitInfo
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t waitSemaphoreCount
		public uint waitSemaphoreCount;
		// VkSemaphore* pWaitSemaphores
		public Semaphore* pWaitSemaphores;
		// VkPipelineStageFlags* pWaitDstStageMask
		public PipelineStageFlagBits* pWaitDestinationStageMask;
		// uint32_t commandBufferCount
		public uint commandBufferCount;
		// VkCommandBuffer* pCommandBuffers
		public CommandBuffer* pCommandBuffers;
		// uint32_t signalSemaphoreCount
		public uint signalSemaphoreCount;
		// VkSemaphore* pSignalSemaphores
		public Semaphore* pSignalSemaphores;
	}
	// VkSubpassDependency
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SubpassDependency
	{
		// uint32_t srcSubpass
		public uint sourceSubpass;
		// uint32_t dstSubpass
		public uint destinationSubpass;
		// VkPipelineStageFlags srcStageMask
		public PipelineStageFlagBits sourceStageMask;
		// VkPipelineStageFlags dstStageMask
		public PipelineStageFlagBits destinationStageMask;
		// VkAccessFlags srcAccessMask
		public AccessFlagBits sourceAccessMask;
		// VkAccessFlags dstAccessMask
		public AccessFlagBits destinationAccessMask;
		// VkDependencyFlags dependencyFlags
		public DependencyFlagBits dependencyFlags;
	}
	// VkSubpassDescription
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SubpassDescription
	{
		// VkSubpassDescriptionFlags flags
		public uint flags;
		// VkPipelineBindPoint pipelineBindPoint
		public PipelineBindPoint pipelineBindPoint;
		// uint32_t inputAttachmentCount
		public uint inputAttachmentCount;
		// VkAttachmentReference* pInputAttachments
		public AttachmentReference* pInputAttachments;
		// uint32_t colorAttachmentCount
		public uint colorAttachmentCount;
		// VkAttachmentReference* pColorAttachments
		public AttachmentReference* pColorAttachments;
		// VkAttachmentReference* pResolveAttachments
		public AttachmentReference* pResolveAttachments;
		// VkAttachmentReference* pDepthStencilAttachment
		public AttachmentReference* pDepthStencilAttachment;
		// uint32_t preserveAttachmentCount
		public uint preserveAttachmentCount;
		// uint32_t* pPreserveAttachments
		public uint* pPreserveAttachments;
	}
	// VkSubresourceLayout
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SubresourceLayout
	{
		// VkDeviceSize offset
		public ulong offset;
		// VkDeviceSize size
		public ulong size;
		// VkDeviceSize rowPitch
		public ulong rowPitch;
		// VkDeviceSize arrayPitch
		public ulong arrayPitch;
		// VkDeviceSize depthPitch
		public ulong depthPitch;
	}
	// VkSurfaceCapabilitiesKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SurfaceCapabilitiesKHR
	{
		// uint32_t minImageCount
		public uint minImageCount;
		// uint32_t maxImageCount
		public uint maxImageCount;
		// VkExtent2D currentExtent
		public Extent2D currentExtent;
		// VkExtent2D minImageExtent
		public Extent2D minImageExtent;
		// VkExtent2D maxImageExtent
		public Extent2D maxImageExtent;
		// uint32_t maxImageArrayLayers
		public uint maxImageArrayLayers;
		// VkSurfaceTransformFlagsKHR supportedTransforms
		public SurfaceTransformFlagBitsKHR supportedTransforms;
		// VkSurfaceTransformFlagBitsKHR currentTransform
		public SurfaceTransformFlagBitsKHR currentTransform;
		// VkCompositeAlphaFlagsKHR supportedCompositeAlpha
		public CompositeAlphaFlagBitsKHR supportedCompositeAlpha;
		// VkImageUsageFlags supportedUsageFlags
		public ImageUsageFlagBits supportedUsageFlags;
	}
	// VkSurfaceFormatKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SurfaceFormatKHR
	{
		// VkFormat format
		public Format format;
		// VkColorSpaceKHR colorSpace
		public ColorSpaceKHR colorSpace;
	}
	// VkSurfaceKHR
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct SurfaceKHR : IEquatable<SurfaceKHR>
	{
		private ulong handle;
	
		public static readonly SurfaceKHR Zero;
	
		public SurfaceKHR(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(SurfaceKHR other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is SurfaceKHR && ((SurfaceKHR)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(SurfaceKHR value1, SurfaceKHR value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(SurfaceKHR value1, SurfaceKHR value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(SurfaceKHR value)
		{
			return value.handle;
		}
		public static explicit operator SurfaceKHR(ulong value)
		{
			return new SurfaceKHR (value);
		}
	}
	// VkSwapchainCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct SwapchainCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkSwapchainCreateFlagsKHR flags
		public uint flags;
		// VkSurfaceKHR surface
		public SurfaceKHR surface;
		// uint32_t minImageCount
		public uint minImageCount;
		// VkFormat imageFormat
		public Format imageFormat;
		// VkColorSpaceKHR imageColorSpace
		public ColorSpaceKHR imageColorSpace;
		// VkExtent2D imageExtent
		public Extent2D imageExtent;
		// uint32_t imageArrayLayers
		public uint imageArrayLayers;
		// VkImageUsageFlags imageUsage
		public ImageUsageFlagBits imageUsage;
		// VkSharingMode imageSharingMode
		public SharingMode imageSharingMode;
		// uint32_t queueFamilyIndexCount
		public uint queueFamilyIndexCount;
		// uint32_t* pQueueFamilyIndices
		public uint* pQueueFamilyIndices;
		// VkSurfaceTransformFlagBitsKHR preTransform
		public SurfaceTransformFlagBitsKHR preTransform;
		// VkCompositeAlphaFlagBitsKHR compositeAlpha
		public CompositeAlphaFlagBitsKHR compositeAlpha;
		// VkPresentModeKHR presentMode
		public PresentModeKHR presentMode;
		// VkBool32 clipped
		public Boolean32 clipped;
		// VkSwapchainKHR oldSwapchain
		public SwapchainKHR oldSwapchain;
	}
	// VkSwapchainKHR
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe partial struct SwapchainKHR : IEquatable<SwapchainKHR>
	{
		private ulong handle;
	
		public static readonly SwapchainKHR Zero;
	
		public SwapchainKHR(ulong value)
		{
			handle = value;
		}
	
		public bool IsZero { get { return handle == 0; } }
		
		public bool Equals(SwapchainKHR other)
		{
			return other.handle == handle;
		}
		public override bool Equals(object obj)
		{
			return obj is SwapchainKHR && ((SwapchainKHR)obj).handle == handle;
		}
		public override int GetHashCode()
		{
			return handle.GetHashCode ();
		}
		public override string ToString()
		{
			return handle.ToString (CultureInfo.InvariantCulture);
		}
		
		public static bool operator ==(SwapchainKHR value1, SwapchainKHR value2)
		{
			return value1.handle == value2.handle;
		}
		public static bool operator !=(SwapchainKHR value1, SwapchainKHR value2)
		{
			return value1.handle != value2.handle;
		}
		public static explicit operator ulong(SwapchainKHR value)
		{
			return value.handle;
		}
		public static explicit operator SwapchainKHR(ulong value)
		{
			return new SwapchainKHR (value);
		}
	}
	// VkValidationFlagsEXT
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct ValidationFlagsEXT
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t disabledValidationCheckCount
		public uint disabledValidationCheckCount;
		// VkValidationCheckEXT* pDisabledValidationChecks
		public ValidationCheckEXT* pDisabledValidationChecks;
	}
	// VkVertexInputAttributeDescription
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct VertexInputAttributeDescription
	{
		// uint32_t location
		public uint location;
		// uint32_t binding
		public uint binding;
		// VkFormat format
		public Format format;
		// uint32_t offset
		public uint offset;
	}
	// VkVertexInputBindingDescription
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct VertexInputBindingDescription
	{
		// uint32_t binding
		public uint binding;
		// uint32_t stride
		public uint stride;
		// VkVertexInputRate inputRate
		public VertexInputRate inputRate;
	}
	// VkViewport
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Viewport
	{
		// float x
		public float x;
		// float y
		public float y;
		// float width
		public float width;
		// float height
		public float height;
		// float minDepth
		public float minDepth;
		// float maxDepth
		public float maxDepth;
	}
	// VkWaylandSurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct WaylandSurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkWaylandSurfaceCreateFlagsKHR flags
		public uint flags;
		// wl_display* display
		public IntPtr* display;
		// wl_surface* surface
		public IntPtr* surface;
	}
	// VkWin32KeyedMutexAcquireReleaseInfoNV
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Win32KeyedMutexAcquireReleaseInfoNV
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// uint32_t acquireCount
		public uint acquireCount;
		// VkDeviceMemory* pAcquireSyncs
		public DeviceMemory* pAcquireSyncs;
		// uint64_t* pAcquireKeys
		public ulong* pAcquireKeys;
		// uint32_t* pAcquireTimeoutMilliseconds
		public uint* pAcquireTimeoutMilliseconds;
		// uint32_t releaseCount
		public uint releaseCount;
		// VkDeviceMemory* pReleaseSyncs
		public DeviceMemory* pReleaseSyncs;
		// uint64_t* pReleaseKeys
		public ulong* pReleaseKeys;
	}
	// VkWin32SurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct Win32SurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkWin32SurfaceCreateFlagsKHR flags
		public uint flags;
		// HINSTANCE hinstance
		public IntPtr hinstance;
		// HWND hwnd
		public IntPtr hwnd;
	}
	// VkWriteDescriptorSet
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct WriteDescriptorSet
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkDescriptorSet dstSet
		public DescriptorSet destinationSet;
		// uint32_t dstBinding
		public uint destinationBinding;
		// uint32_t dstArrayElement
		public uint destinationArrayElement;
		// uint32_t descriptorCount
		public uint descriptorCount;
		// VkDescriptorType descriptorType
		public DescriptorType descriptorType;
		// VkDescriptorImageInfo* pImageInfo
		public DescriptorImageInfo* pImageInfo;
		// VkDescriptorBufferInfo* pBufferInfo
		public DescriptorBufferInfo* pBufferInfo;
		// VkBufferView* pTexelBufferView
		public BufferView* pTexelBufferView;
	}
	// VkXcbSurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct XcbSurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkXcbSurfaceCreateFlagsKHR flags
		public uint flags;
		// xcb_connection_t* connection
		public IntPtr* connection;
		// xcb_window_t window
		public IntPtr window;
	}
	// VkXlibSurfaceCreateInfoKHR
	[StructLayout (LayoutKind.Sequential)]
	public unsafe partial struct XlibSurfaceCreateInfoKHR
	{
		// VkStructureType sType
		public StructureType sType;
		// void* pNext
		public IntPtr pNext;
		// VkXlibSurfaceCreateFlagsKHR flags
		public uint flags;
		// Display* dpy
		public IntPtr* dpy;
		// Window window
		public IntPtr window;
	}
}

