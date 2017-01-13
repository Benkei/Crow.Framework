using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Crow.Graphics.Vulkan
{
	public partial class Vk
	{
		/// <summary>VkResult vkAllocateCommandBuffers (VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result AllocateCommandBuffersDelegate (Device device, ref CommandBufferAllocateInfo pAllocateInfo, CommandBuffer* pCommandBuffers);
		/// <summary>VkResult vkAllocateDescriptorSets (VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result AllocateDescriptorSetsDelegate (Device device, ref DescriptorSetAllocateInfo pAllocateInfo, DescriptorSet* pDescriptorSets);
		/// <summary>VkResult vkAllocateMemory (VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result AllocateMemoryDelegate (Device device, ref MemoryAllocateInfo pAllocateInfo, AllocationCallbacks* pAllocator, out DeviceMemory pMemory);
		/// <summary>VkResult vkBeginCommandBuffer (VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result BeginCommandBufferDelegate (CommandBuffer commandBuffer, ref CommandBufferBeginInfo pBeginInfo);
		/// <summary>VkResult vkBindBufferMemory (VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result BindBufferMemoryDelegate (Device device, Buffer buffer, DeviceMemory memory, ulong memoryOffset);
		/// <summary>VkResult vkBindImageMemory (VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result BindImageMemoryDelegate (Device device, Image image, DeviceMemory memory, ulong memoryOffset);
		/// <summary>void vkCmdBeginQuery (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBeginQueryDelegate (CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlagBits flags);
		/// <summary>void vkCmdBeginRenderPass (VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBeginRenderPassDelegate (CommandBuffer commandBuffer, ref RenderPassBeginInfo pRenderPassBegin, SubpassContents contents);
		/// <summary>void vkCmdBindDescriptorSets (VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t firstSet, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint32_t dynamicOffsetCount, uint32_t* pDynamicOffsets)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBindDescriptorSetsDelegate (CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		/// <summary>void vkCmdBindIndexBuffer (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBindIndexBufferDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset, IndexType indexType);
		/// <summary>void vkCmdBindPipeline (VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBindPipelineDelegate (CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);
		/// <summary>void vkCmdBindVertexBuffers (VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBindVertexBuffersDelegate (CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* pBuffers, ulong* pOffsets);
		/// <summary>void vkCmdBlitImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageBlit* pRegions, VkFilter filter)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdBlitImageDelegate (CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* pRegions, Filter filter);
		/// <summary>void vkCmdClearAttachments (VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkClearAttachment* pAttachments, uint32_t rectCount, VkClearRect* pRects)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdClearAttachmentsDelegate (CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* pAttachments, uint rectCount, ClearRect* pRects);
		/// <summary>void vkCmdClearColorImage (VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint32_t rangeCount, VkImageSubresourceRange* pRanges)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdClearColorImageDelegate (CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* pColor, uint rangeCount, ImageSubresourceRange* pRanges);
		/// <summary>void vkCmdClearDepthStencilImage (VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint32_t rangeCount, VkImageSubresourceRange* pRanges)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdClearDepthStencilImageDelegate (CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* pDepthStencil, uint rangeCount, ImageSubresourceRange* pRanges);
		/// <summary>void vkCmdCopyBuffer (VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint32_t regionCount, VkBufferCopy* pRegions)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdCopyBufferDelegate (CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* pRegions);
		/// <summary>void vkCmdCopyBufferToImage (VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkBufferImageCopy* pRegions)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdCopyBufferToImageDelegate (CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* pRegions);
		/// <summary>void vkCmdCopyImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageCopy* pRegions)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdCopyImageDelegate (CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* pRegions);
		/// <summary>void vkCmdCopyImageToBuffer (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint32_t regionCount, VkBufferImageCopy* pRegions)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdCopyImageToBufferDelegate (CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* pRegions);
		/// <summary>void vkCmdCopyQueryPoolResults (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdCopyQueryPoolResultsDelegate (CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlagBits flags);
		/// <summary>void vkCmdDispatch (VkCommandBuffer commandBuffer, uint32_t x, uint32_t y, uint32_t z)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDispatchDelegate (CommandBuffer commandBuffer, uint x, uint y, uint z);
		/// <summary>void vkCmdDispatchIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDispatchIndirectDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset);
		/// <summary>void vkCmdDraw (VkCommandBuffer commandBuffer, uint32_t vertexCount, uint32_t instanceCount, uint32_t firstVertex, uint32_t firstInstance)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawDelegate (CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		/// <summary>void vkCmdDrawIndexed (VkCommandBuffer commandBuffer, uint32_t indexCount, uint32_t instanceCount, uint32_t firstIndex, int32_t vertexOffset, uint32_t firstInstance)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawIndexedDelegate (CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		/// <summary>void vkCmdDrawIndexedIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawIndexedIndirectDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);
		/// <summary>void vkCmdDrawIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawIndirectDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);
		/// <summary>void vkCmdEndQuery (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdEndQueryDelegate (CommandBuffer commandBuffer, QueryPool queryPool, uint query);
		/// <summary>void vkCmdEndRenderPass (VkCommandBuffer commandBuffer)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdEndRenderPassDelegate (CommandBuffer commandBuffer);
		/// <summary>void vkCmdExecuteCommands (VkCommandBuffer commandBuffer, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdExecuteCommandsDelegate (CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* pCommandBuffers);
		/// <summary>void vkCmdFillBuffer (VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint32_t data)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdFillBufferDelegate (CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data);
		/// <summary>void vkCmdNextSubpass (VkCommandBuffer commandBuffer, VkSubpassContents contents)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdNextSubpassDelegate (CommandBuffer commandBuffer, SubpassContents contents);
		/// <summary>void vkCmdPipelineBarrier (VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdPipelineBarrierDelegate (CommandBuffer commandBuffer, PipelineStageFlagBits sourceStageMask, PipelineStageFlagBits destinationStageMask, DependencyFlagBits dependencyFlags, uint memoryBarrierCount, MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* pImageMemoryBarriers);
		/// <summary>void vkCmdPushConstants (VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint32_t offset, uint32_t size, void* pValues)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdPushConstantsDelegate (CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlagBits stageFlags, uint offset, uint size, IntPtr pValues);
		/// <summary>void vkCmdResetEvent (VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdResetEventDelegate (CommandBuffer commandBuffer, Event @event, PipelineStageFlagBits stageMask);
		/// <summary>void vkCmdResetQueryPool (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdResetQueryPoolDelegate (CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);
		/// <summary>void vkCmdResolveImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageResolve* pRegions)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdResolveImageDelegate (CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* pRegions);
		/// <summary>void vkCmdSetBlendConstants (VkCommandBuffer commandBuffer, float blendConstants)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetBlendConstantsDelegate (CommandBuffer commandBuffer, float blendConstants);
		/// <summary>void vkCmdSetDepthBias (VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetDepthBiasDelegate (CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		/// <summary>void vkCmdSetDepthBounds (VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetDepthBoundsDelegate (CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		/// <summary>void vkCmdSetEvent (VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetEventDelegate (CommandBuffer commandBuffer, Event @event, PipelineStageFlagBits stageMask);
		/// <summary>void vkCmdSetLineWidth (VkCommandBuffer commandBuffer, float lineWidth)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetLineWidthDelegate (CommandBuffer commandBuffer, float lineWidth);
		/// <summary>void vkCmdSetScissor (VkCommandBuffer commandBuffer, uint32_t firstScissor, uint32_t scissorCount, VkRect2D* pScissors)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetScissorDelegate (CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* pScissors);
		/// <summary>void vkCmdSetStencilCompareMask (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t compareMask)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetStencilCompareMaskDelegate (CommandBuffer commandBuffer, StencilFaceFlagBits faceMask, uint compareMask);
		/// <summary>void vkCmdSetStencilReference (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t reference)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetStencilReferenceDelegate (CommandBuffer commandBuffer, StencilFaceFlagBits faceMask, uint reference);
		/// <summary>void vkCmdSetStencilWriteMask (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t writeMask)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetStencilWriteMaskDelegate (CommandBuffer commandBuffer, StencilFaceFlagBits faceMask, uint writeMask);
		/// <summary>void vkCmdSetViewport (VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewport* pViewports)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdSetViewportDelegate (CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* pViewports);
		/// <summary>void vkCmdUpdateBuffer (VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdUpdateBufferDelegate (CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong dataSize, IntPtr pData);
		/// <summary>void vkCmdWaitEvents (VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdWaitEventsDelegate (CommandBuffer commandBuffer, uint eventCount, Event* pEvents, PipelineStageFlagBits sourceStageMask, PipelineStageFlagBits destinationStageMask, uint memoryBarrierCount, MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* pImageMemoryBarriers);
		/// <summary>void vkCmdWriteTimestamp (VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint32_t query)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdWriteTimestampDelegate (CommandBuffer commandBuffer, PipelineStageFlagBits pipelineStage, QueryPool queryPool, uint query);
		/// <summary>VkResult vkCreateBuffer (VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateBufferDelegate (Device device, ref BufferCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Buffer pBuffer);
		/// <summary>VkResult vkCreateBufferView (VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateBufferViewDelegate (Device device, ref BufferViewCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out BufferView pView);
		/// <summary>VkResult vkCreateCommandPool (VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateCommandPoolDelegate (Device device, ref CommandPoolCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out CommandPool pCommandPool);
		/// <summary>VkResult vkCreateComputePipelines (VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateComputePipelinesDelegate (Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* pCreateInfos, AllocationCallbacks* pAllocator, out Pipeline pPipelines);
		/// <summary>VkResult vkCreateDescriptorPool (VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDescriptorPoolDelegate (Device device, ref DescriptorPoolCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out DescriptorPool pDescriptorPool);
		/// <summary>VkResult vkCreateDescriptorSetLayout (VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDescriptorSetLayoutDelegate (Device device, ref DescriptorSetLayoutCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out DescriptorSetLayout pSetLayout);
		/// <summary>VkResult vkCreateDevice (VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDeviceDelegate (PhysicalDevice physicalDevice, ref DeviceCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Device pDevice);
		/// <summary>VkResult vkCreateEvent (VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateEventDelegate (Device device, ref EventCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Event pEvent);
		/// <summary>VkResult vkCreateFence (VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateFenceDelegate (Device device, ref FenceCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Fence pFence);
		/// <summary>VkResult vkCreateFramebuffer (VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateFramebufferDelegate (Device device, ref FramebufferCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Framebuffer pFramebuffer);
		/// <summary>VkResult vkCreateGraphicsPipelines (VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateGraphicsPipelinesDelegate (Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* pCreateInfos, AllocationCallbacks* pAllocator, out Pipeline pPipelines);
		/// <summary>VkResult vkCreateImage (VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateImageDelegate (Device device, ref ImageCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Image pImage);
		/// <summary>VkResult vkCreateImageView (VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateImageViewDelegate (Device device, ref ImageViewCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out ImageView pView);
		/// <summary>VkResult vkCreateInstance (VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateInstanceDelegate (ref InstanceCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Instance pInstance);
		/// <summary>VkResult vkCreatePipelineCache (VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreatePipelineCacheDelegate (Device device, ref PipelineCacheCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out PipelineCache pPipelineCache);
		/// <summary>VkResult vkCreatePipelineLayout (VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreatePipelineLayoutDelegate (Device device, ref PipelineLayoutCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out PipelineLayout pPipelineLayout);
		/// <summary>VkResult vkCreateQueryPool (VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateQueryPoolDelegate (Device device, ref QueryPoolCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out QueryPool pQueryPool);
		/// <summary>VkResult vkCreateRenderPass (VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateRenderPassDelegate (Device device, ref RenderPassCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out RenderPass pRenderPass);
		/// <summary>VkResult vkCreateSampler (VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateSamplerDelegate (Device device, ref SamplerCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Sampler pSampler);
		/// <summary>VkResult vkCreateSemaphore (VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateSemaphoreDelegate (Device device, ref SemaphoreCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out Semaphore pSemaphore);
		/// <summary>VkResult vkCreateShaderModule (VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateShaderModuleDelegate (Device device, ref ShaderModuleCreateInfo pCreateInfo, AllocationCallbacks* pAllocator, out ShaderModule pShaderModule);
		/// <summary>void vkDestroyBuffer (VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyBufferDelegate (Device device, Buffer buffer, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyBufferView (VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyBufferViewDelegate (Device device, BufferView bufferView, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyCommandPool (VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyCommandPoolDelegate (Device device, CommandPool commandPool, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyDescriptorPool (VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyDescriptorPoolDelegate (Device device, DescriptorPool descriptorPool, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyDescriptorSetLayout (VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyDescriptorSetLayoutDelegate (Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyDevice (VkDevice device, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyDeviceDelegate (Device device, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyEvent (VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyEventDelegate (Device device, Event @event, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyFence (VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyFenceDelegate (Device device, Fence fence, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyFramebuffer (VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyFramebufferDelegate (Device device, Framebuffer framebuffer, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyImage (VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyImageDelegate (Device device, Image image, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyImageView (VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyImageViewDelegate (Device device, ImageView imageView, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyInstance (VkInstance instance, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyInstanceDelegate (Instance instance, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyPipeline (VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyPipelineDelegate (Device device, Pipeline pipeline, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyPipelineCache (VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyPipelineCacheDelegate (Device device, PipelineCache pipelineCache, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyPipelineLayout (VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyPipelineLayoutDelegate (Device device, PipelineLayout pipelineLayout, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyQueryPool (VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyQueryPoolDelegate (Device device, QueryPool queryPool, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyRenderPass (VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyRenderPassDelegate (Device device, RenderPass renderPass, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroySampler (VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroySamplerDelegate (Device device, Sampler sampler, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroySemaphore (VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroySemaphoreDelegate (Device device, Semaphore semaphore, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyShaderModule (VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyShaderModuleDelegate (Device device, ShaderModule shaderModule, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>VkResult vkDeviceWaitIdle (VkDevice device)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result DeviceWaitIdleDelegate (Device device);
		/// <summary>VkResult vkEndCommandBuffer (VkCommandBuffer commandBuffer)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EndCommandBufferDelegate (CommandBuffer commandBuffer);
		/// <summary>VkResult vkEnumerateDeviceExtensionProperties (VkPhysicalDevice physicalDevice, char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EnumerateDeviceExtensionPropertiesDelegate (PhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, ExtensionProperties* pProperties);
		/// <summary>VkResult vkEnumerateDeviceLayerProperties (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkLayerProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EnumerateDeviceLayerPropertiesDelegate (PhysicalDevice physicalDevice, uint* pPropertyCount, LayerProperties* pProperties);
		/// <summary>VkResult vkEnumerateInstanceExtensionProperties (char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EnumerateInstanceExtensionPropertiesDelegate (byte* pLayerName, uint* pPropertyCount, ExtensionProperties* pProperties);
		/// <summary>VkResult vkEnumerateInstanceLayerProperties (uint32_t* pPropertyCount, VkLayerProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EnumerateInstanceLayerPropertiesDelegate (uint* pPropertyCount, LayerProperties* pProperties);
		/// <summary>VkResult vkEnumeratePhysicalDevices (VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result EnumeratePhysicalDevicesDelegate (Instance instance, uint* pPhysicalDeviceCount, PhysicalDevice* pPhysicalDevices);
		/// <summary>VkResult vkFlushMappedMemoryRanges (VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result FlushMappedMemoryRangesDelegate (Device device, uint memoryRangeCount, MappedMemoryRange* pMemoryRanges);
		/// <summary>void vkFreeCommandBuffers (VkDevice device, VkCommandPool commandPool, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void FreeCommandBuffersDelegate (Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* pCommandBuffers);
		/// <summary>VkResult vkFreeDescriptorSets (VkDevice device, VkDescriptorPool descriptorPool, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result FreeDescriptorSetsDelegate (Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* pDescriptorSets);
		/// <summary>void vkFreeMemory (VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void FreeMemoryDelegate (Device device, DeviceMemory memory, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkGetBufferMemoryRequirements (VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetBufferMemoryRequirementsDelegate (Device device, Buffer buffer, out MemoryRequirements pMemoryRequirements);
		/// <summary>void vkGetDeviceMemoryCommitment (VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetDeviceMemoryCommitmentDelegate (Device device, DeviceMemory memory, out ulong pCommittedMemoryInBytes);
		/// <summary>PFN_vkVoidFunction vkGetDeviceProcAddr (VkDevice device, char* pName)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate IntPtr GetDeviceProcAddrDelegate (Device device, byte* pName);
		/// <summary>void vkGetDeviceQueue (VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetDeviceQueueDelegate (Device device, uint queueFamilyIndex, uint queueIndex, out Queue pQueue);
		/// <summary>VkResult vkGetEventStatus (VkDevice device, VkEvent event)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetEventStatusDelegate (Device device, Event @event);
		/// <summary>VkResult vkGetFenceStatus (VkDevice device, VkFence fence)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetFenceStatusDelegate (Device device, Fence fence);
		/// <summary>void vkGetImageMemoryRequirements (VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetImageMemoryRequirementsDelegate (Device device, Image image, out MemoryRequirements pMemoryRequirements);
		/// <summary>void vkGetImageSparseMemoryRequirements (VkDevice device, VkImage image, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetImageSparseMemoryRequirementsDelegate (Device device, Image image, uint* pSparseMemoryRequirementCount, SparseImageMemoryRequirements* pSparseMemoryRequirements);
		/// <summary>void vkGetImageSubresourceLayout (VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetImageSubresourceLayoutDelegate (Device device, Image image, out ImageSubresource pSubresource, out SubresourceLayout pLayout);
		/// <summary>PFN_vkVoidFunction vkGetInstanceProcAddr (VkInstance instance, char* pName)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate IntPtr GetInstanceProcAddrDelegate (Instance instance, byte* pName);
		/// <summary>void vkGetPhysicalDeviceFeatures (VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceFeaturesDelegate (PhysicalDevice physicalDevice, out PhysicalDeviceFeatures pFeatures);
		/// <summary>void vkGetPhysicalDeviceFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceFormatPropertiesDelegate (PhysicalDevice physicalDevice, Format format, out FormatProperties pFormatProperties);
		/// <summary>VkResult vkGetPhysicalDeviceImageFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceImageFormatPropertiesDelegate (PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlagBits usage, ImageCreateFlagBits flags, out ImageFormatProperties pImageFormatProperties);
		/// <summary>void vkGetPhysicalDeviceMemoryProperties (VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceMemoryPropertiesDelegate (PhysicalDevice physicalDevice, out PhysicalDeviceMemoryProperties pMemoryProperties);
		/// <summary>void vkGetPhysicalDeviceProperties (VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDevicePropertiesDelegate (PhysicalDevice physicalDevice, out PhysicalDeviceProperties pProperties);
		/// <summary>void vkGetPhysicalDeviceQueueFamilyProperties (VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceQueueFamilyPropertiesDelegate (PhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, QueueFamilyProperties* pQueueFamilyProperties);
		/// <summary>void vkGetPhysicalDeviceSparseImageFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint32_t* pPropertyCount, VkSparseImageFormatProperties* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceSparseImageFormatPropertiesDelegate (PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlagBits samples, ImageUsageFlagBits usage, ImageTiling tiling, uint* pPropertyCount, SparseImageFormatProperties* pProperties);
		/// <summary>VkResult vkGetPipelineCacheData (VkDevice device, VkPipelineCache pipelineCache, size_t* pDataSize, void* pData)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPipelineCacheDataDelegate (Device device, PipelineCache pipelineCache, int* pDataSize, IntPtr pData);
		/// <summary>VkResult vkGetQueryPoolResults (VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, size_t dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetQueryPoolResultsDelegate (Device device, QueryPool queryPool, uint firstQuery, uint queryCount, int dataSize, IntPtr pData, ulong stride, QueryResultFlagBits flags);
		/// <summary>void vkGetRenderAreaGranularity (VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetRenderAreaGranularityDelegate (Device device, RenderPass renderPass, out Extent2D pGranularity);
		/// <summary>VkResult vkInvalidateMappedMemoryRanges (VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result InvalidateMappedMemoryRangesDelegate (Device device, uint memoryRangeCount, MappedMemoryRange* pMemoryRanges);
		/// <summary>VkResult vkMapMemory (VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void* ppData)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result MapMemoryDelegate (Device device, DeviceMemory memory, ulong offset, ulong size, uint flags, out IntPtr ppData);
		/// <summary>VkResult vkMergePipelineCaches (VkDevice device, VkPipelineCache dstCache, uint32_t srcCacheCount, VkPipelineCache* pSrcCaches)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result MergePipelineCachesDelegate (Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* pSourceCaches);
		/// <summary>VkResult vkQueueBindSparse (VkQueue queue, uint32_t bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result QueueBindSparseDelegate (Queue queue, uint bindInfoCount, BindSparseInfo* pBindInfo, Fence fence);
		/// <summary>VkResult vkQueueSubmit (VkQueue queue, uint32_t submitCount, VkSubmitInfo* pSubmits, VkFence fence)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result QueueSubmitDelegate (Queue queue, uint submitCount, SubmitInfo* pSubmits, Fence fence);
		/// <summary>VkResult vkQueueWaitIdle (VkQueue queue)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result QueueWaitIdleDelegate (Queue queue);
		/// <summary>VkResult vkResetCommandBuffer (VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result ResetCommandBufferDelegate (CommandBuffer commandBuffer, CommandBufferResetFlagBits flags);
		/// <summary>VkResult vkResetCommandPool (VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result ResetCommandPoolDelegate (Device device, CommandPool commandPool, CommandPoolResetFlagBits flags);
		/// <summary>VkResult vkResetDescriptorPool (VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result ResetDescriptorPoolDelegate (Device device, DescriptorPool descriptorPool, uint flags);
		/// <summary>VkResult vkResetEvent (VkDevice device, VkEvent event)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result ResetEventDelegate (Device device, Event @event);
		/// <summary>VkResult vkResetFences (VkDevice device, uint32_t fenceCount, VkFence* pFences)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result ResetFencesDelegate (Device device, uint fenceCount, Fence* pFences);
		/// <summary>VkResult vkSetEvent (VkDevice device, VkEvent event)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result SetEventDelegate (Device device, Event @event);
		/// <summary>void vkUnmapMemory (VkDevice device, VkDeviceMemory memory)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void UnmapMemoryDelegate (Device device, DeviceMemory memory);
		/// <summary>void vkUpdateDescriptorSets (VkDevice device, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint32_t descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void UpdateDescriptorSetsDelegate (Device device, uint descriptorWriteCount, WriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* pDescriptorCopies);
		/// <summary>VkResult vkWaitForFences (VkDevice device, uint32_t fenceCount, VkFence* pFences, VkBool32 waitAll, uint64_t timeout)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result WaitForFencesDelegate (Device device, uint fenceCount, Fence* pFences, Boolean32 waitAll, ulong timeout);

		/// <summary>VkResult vkAllocateCommandBuffers (VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)</summary>
		public readonly AllocateCommandBuffersDelegate AllocateCommandBuffers;
		/// <summary>VkResult vkAllocateDescriptorSets (VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)</summary>
		public readonly AllocateDescriptorSetsDelegate AllocateDescriptorSets;
		/// <summary>VkResult vkAllocateMemory (VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)</summary>
		public readonly AllocateMemoryDelegate AllocateMemory;
		/// <summary>VkResult vkBeginCommandBuffer (VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)</summary>
		public readonly BeginCommandBufferDelegate BeginCommandBuffer;
		/// <summary>VkResult vkBindBufferMemory (VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset)</summary>
		public readonly BindBufferMemoryDelegate BindBufferMemory;
		/// <summary>VkResult vkBindImageMemory (VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset)</summary>
		public readonly BindImageMemoryDelegate BindImageMemory;
		/// <summary>void vkCmdBeginQuery (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags)</summary>
		public readonly CmdBeginQueryDelegate CmdBeginQuery;
		/// <summary>void vkCmdBeginRenderPass (VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)</summary>
		public readonly CmdBeginRenderPassDelegate CmdBeginRenderPass;
		/// <summary>void vkCmdBindDescriptorSets (VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t firstSet, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint32_t dynamicOffsetCount, uint32_t* pDynamicOffsets)</summary>
		public readonly CmdBindDescriptorSetsDelegate CmdBindDescriptorSets;
		/// <summary>void vkCmdBindIndexBuffer (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType)</summary>
		public readonly CmdBindIndexBufferDelegate CmdBindIndexBuffer;
		/// <summary>void vkCmdBindPipeline (VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)</summary>
		public readonly CmdBindPipelineDelegate CmdBindPipeline;
		/// <summary>void vkCmdBindVertexBuffers (VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets)</summary>
		public readonly CmdBindVertexBuffersDelegate CmdBindVertexBuffers;
		/// <summary>void vkCmdBlitImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageBlit* pRegions, VkFilter filter)</summary>
		public readonly CmdBlitImageDelegate CmdBlitImage;
		/// <summary>void vkCmdClearAttachments (VkCommandBuffer commandBuffer, uint32_t attachmentCount, VkClearAttachment* pAttachments, uint32_t rectCount, VkClearRect* pRects)</summary>
		public readonly CmdClearAttachmentsDelegate CmdClearAttachments;
		/// <summary>void vkCmdClearColorImage (VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint32_t rangeCount, VkImageSubresourceRange* pRanges)</summary>
		public readonly CmdClearColorImageDelegate CmdClearColorImage;
		/// <summary>void vkCmdClearDepthStencilImage (VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint32_t rangeCount, VkImageSubresourceRange* pRanges)</summary>
		public readonly CmdClearDepthStencilImageDelegate CmdClearDepthStencilImage;
		/// <summary>void vkCmdCopyBuffer (VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint32_t regionCount, VkBufferCopy* pRegions)</summary>
		public readonly CmdCopyBufferDelegate CmdCopyBuffer;
		/// <summary>void vkCmdCopyBufferToImage (VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkBufferImageCopy* pRegions)</summary>
		public readonly CmdCopyBufferToImageDelegate CmdCopyBufferToImage;
		/// <summary>void vkCmdCopyImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageCopy* pRegions)</summary>
		public readonly CmdCopyImageDelegate CmdCopyImage;
		/// <summary>void vkCmdCopyImageToBuffer (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint32_t regionCount, VkBufferImageCopy* pRegions)</summary>
		public readonly CmdCopyImageToBufferDelegate CmdCopyImageToBuffer;
		/// <summary>void vkCmdCopyQueryPoolResults (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags)</summary>
		public readonly CmdCopyQueryPoolResultsDelegate CmdCopyQueryPoolResults;
		/// <summary>void vkCmdDispatch (VkCommandBuffer commandBuffer, uint32_t x, uint32_t y, uint32_t z)</summary>
		public readonly CmdDispatchDelegate CmdDispatch;
		/// <summary>void vkCmdDispatchIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset)</summary>
		public readonly CmdDispatchIndirectDelegate CmdDispatchIndirect;
		/// <summary>void vkCmdDraw (VkCommandBuffer commandBuffer, uint32_t vertexCount, uint32_t instanceCount, uint32_t firstVertex, uint32_t firstInstance)</summary>
		public readonly CmdDrawDelegate CmdDraw;
		/// <summary>void vkCmdDrawIndexed (VkCommandBuffer commandBuffer, uint32_t indexCount, uint32_t instanceCount, uint32_t firstIndex, int32_t vertexOffset, uint32_t firstInstance)</summary>
		public readonly CmdDrawIndexedDelegate CmdDrawIndexed;
		/// <summary>void vkCmdDrawIndexedIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride)</summary>
		public readonly CmdDrawIndexedIndirectDelegate CmdDrawIndexedIndirect;
		/// <summary>void vkCmdDrawIndirect (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride)</summary>
		public readonly CmdDrawIndirectDelegate CmdDrawIndirect;
		/// <summary>void vkCmdEndQuery (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query)</summary>
		public readonly CmdEndQueryDelegate CmdEndQuery;
		/// <summary>void vkCmdEndRenderPass (VkCommandBuffer commandBuffer)</summary>
		public readonly CmdEndRenderPassDelegate CmdEndRenderPass;
		/// <summary>void vkCmdExecuteCommands (VkCommandBuffer commandBuffer, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers)</summary>
		public readonly CmdExecuteCommandsDelegate CmdExecuteCommands;
		/// <summary>void vkCmdFillBuffer (VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint32_t data)</summary>
		public readonly CmdFillBufferDelegate CmdFillBuffer;
		/// <summary>void vkCmdNextSubpass (VkCommandBuffer commandBuffer, VkSubpassContents contents)</summary>
		public readonly CmdNextSubpassDelegate CmdNextSubpass;
		/// <summary>void vkCmdPipelineBarrier (VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)</summary>
		public readonly CmdPipelineBarrierDelegate CmdPipelineBarrier;
		/// <summary>void vkCmdPushConstants (VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint32_t offset, uint32_t size, void* pValues)</summary>
		public readonly CmdPushConstantsDelegate CmdPushConstants;
		/// <summary>void vkCmdResetEvent (VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask)</summary>
		public readonly CmdResetEventDelegate CmdResetEvent;
		/// <summary>void vkCmdResetQueryPool (VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount)</summary>
		public readonly CmdResetQueryPoolDelegate CmdResetQueryPool;
		/// <summary>void vkCmdResolveImage (VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, VkImageResolve* pRegions)</summary>
		public readonly CmdResolveImageDelegate CmdResolveImage;
		/// <summary>void vkCmdSetBlendConstants (VkCommandBuffer commandBuffer, float blendConstants)</summary>
		public readonly CmdSetBlendConstantsDelegate CmdSetBlendConstants;
		/// <summary>void vkCmdSetDepthBias (VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)</summary>
		public readonly CmdSetDepthBiasDelegate CmdSetDepthBias;
		/// <summary>void vkCmdSetDepthBounds (VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)</summary>
		public readonly CmdSetDepthBoundsDelegate CmdSetDepthBounds;
		/// <summary>void vkCmdSetEvent (VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask)</summary>
		public readonly CmdSetEventDelegate CmdSetEvent;
		/// <summary>void vkCmdSetLineWidth (VkCommandBuffer commandBuffer, float lineWidth)</summary>
		public readonly CmdSetLineWidthDelegate CmdSetLineWidth;
		/// <summary>void vkCmdSetScissor (VkCommandBuffer commandBuffer, uint32_t firstScissor, uint32_t scissorCount, VkRect2D* pScissors)</summary>
		public readonly CmdSetScissorDelegate CmdSetScissor;
		/// <summary>void vkCmdSetStencilCompareMask (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t compareMask)</summary>
		public readonly CmdSetStencilCompareMaskDelegate CmdSetStencilCompareMask;
		/// <summary>void vkCmdSetStencilReference (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t reference)</summary>
		public readonly CmdSetStencilReferenceDelegate CmdSetStencilReference;
		/// <summary>void vkCmdSetStencilWriteMask (VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t writeMask)</summary>
		public readonly CmdSetStencilWriteMaskDelegate CmdSetStencilWriteMask;
		/// <summary>void vkCmdSetViewport (VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, VkViewport* pViewports)</summary>
		public readonly CmdSetViewportDelegate CmdSetViewport;
		/// <summary>void vkCmdUpdateBuffer (VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData)</summary>
		public readonly CmdUpdateBufferDelegate CmdUpdateBuffer;
		/// <summary>void vkCmdWaitEvents (VkCommandBuffer commandBuffer, uint32_t eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint32_t memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)</summary>
		public readonly CmdWaitEventsDelegate CmdWaitEvents;
		/// <summary>void vkCmdWriteTimestamp (VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint32_t query)</summary>
		public readonly CmdWriteTimestampDelegate CmdWriteTimestamp;
		/// <summary>VkResult vkCreateBuffer (VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)</summary>
		public readonly CreateBufferDelegate CreateBuffer;
		/// <summary>VkResult vkCreateBufferView (VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)</summary>
		public readonly CreateBufferViewDelegate CreateBufferView;
		/// <summary>VkResult vkCreateCommandPool (VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)</summary>
		public readonly CreateCommandPoolDelegate CreateCommandPool;
		/// <summary>VkResult vkCreateComputePipelines (VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)</summary>
		public readonly CreateComputePipelinesDelegate CreateComputePipelines;
		/// <summary>VkResult vkCreateDescriptorPool (VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)</summary>
		public readonly CreateDescriptorPoolDelegate CreateDescriptorPool;
		/// <summary>VkResult vkCreateDescriptorSetLayout (VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)</summary>
		public readonly CreateDescriptorSetLayoutDelegate CreateDescriptorSetLayout;
		/// <summary>VkResult vkCreateDevice (VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)</summary>
		public readonly CreateDeviceDelegate CreateDevice;
		/// <summary>VkResult vkCreateEvent (VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)</summary>
		public readonly CreateEventDelegate CreateEvent;
		/// <summary>VkResult vkCreateFence (VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)</summary>
		public readonly CreateFenceDelegate CreateFence;
		/// <summary>VkResult vkCreateFramebuffer (VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)</summary>
		public readonly CreateFramebufferDelegate CreateFramebuffer;
		/// <summary>VkResult vkCreateGraphicsPipelines (VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)</summary>
		public readonly CreateGraphicsPipelinesDelegate CreateGraphicsPipelines;
		/// <summary>VkResult vkCreateImage (VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)</summary>
		public readonly CreateImageDelegate CreateImage;
		/// <summary>VkResult vkCreateImageView (VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)</summary>
		public readonly CreateImageViewDelegate CreateImageView;
		/// <summary>VkResult vkCreateInstance (VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)</summary>
		public readonly CreateInstanceDelegate CreateInstance;
		/// <summary>VkResult vkCreatePipelineCache (VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)</summary>
		public readonly CreatePipelineCacheDelegate CreatePipelineCache;
		/// <summary>VkResult vkCreatePipelineLayout (VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)</summary>
		public readonly CreatePipelineLayoutDelegate CreatePipelineLayout;
		/// <summary>VkResult vkCreateQueryPool (VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)</summary>
		public readonly CreateQueryPoolDelegate CreateQueryPool;
		/// <summary>VkResult vkCreateRenderPass (VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)</summary>
		public readonly CreateRenderPassDelegate CreateRenderPass;
		/// <summary>VkResult vkCreateSampler (VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)</summary>
		public readonly CreateSamplerDelegate CreateSampler;
		/// <summary>VkResult vkCreateSemaphore (VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)</summary>
		public readonly CreateSemaphoreDelegate CreateSemaphore;
		/// <summary>VkResult vkCreateShaderModule (VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)</summary>
		public readonly CreateShaderModuleDelegate CreateShaderModule;
		/// <summary>void vkDestroyBuffer (VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyBufferDelegate DestroyBuffer;
		/// <summary>void vkDestroyBufferView (VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyBufferViewDelegate DestroyBufferView;
		/// <summary>void vkDestroyCommandPool (VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyCommandPoolDelegate DestroyCommandPool;
		/// <summary>void vkDestroyDescriptorPool (VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyDescriptorPoolDelegate DestroyDescriptorPool;
		/// <summary>void vkDestroyDescriptorSetLayout (VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyDescriptorSetLayoutDelegate DestroyDescriptorSetLayout;
		/// <summary>void vkDestroyDevice (VkDevice device, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyDeviceDelegate DestroyDevice;
		/// <summary>void vkDestroyEvent (VkDevice device, VkEvent event, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyEventDelegate DestroyEvent;
		/// <summary>void vkDestroyFence (VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyFenceDelegate DestroyFence;
		/// <summary>void vkDestroyFramebuffer (VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyFramebufferDelegate DestroyFramebuffer;
		/// <summary>void vkDestroyImage (VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyImageDelegate DestroyImage;
		/// <summary>void vkDestroyImageView (VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyImageViewDelegate DestroyImageView;
		/// <summary>void vkDestroyInstance (VkInstance instance, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyInstanceDelegate DestroyInstance;
		/// <summary>void vkDestroyPipeline (VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyPipelineDelegate DestroyPipeline;
		/// <summary>void vkDestroyPipelineCache (VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyPipelineCacheDelegate DestroyPipelineCache;
		/// <summary>void vkDestroyPipelineLayout (VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyPipelineLayoutDelegate DestroyPipelineLayout;
		/// <summary>void vkDestroyQueryPool (VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyQueryPoolDelegate DestroyQueryPool;
		/// <summary>void vkDestroyRenderPass (VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyRenderPassDelegate DestroyRenderPass;
		/// <summary>void vkDestroySampler (VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroySamplerDelegate DestroySampler;
		/// <summary>void vkDestroySemaphore (VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroySemaphoreDelegate DestroySemaphore;
		/// <summary>void vkDestroyShaderModule (VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyShaderModuleDelegate DestroyShaderModule;
		/// <summary>VkResult vkDeviceWaitIdle (VkDevice device)</summary>
		public readonly DeviceWaitIdleDelegate DeviceWaitIdle;
		/// <summary>VkResult vkEndCommandBuffer (VkCommandBuffer commandBuffer)</summary>
		public readonly EndCommandBufferDelegate EndCommandBuffer;
		/// <summary>VkResult vkEnumerateDeviceExtensionProperties (VkPhysicalDevice physicalDevice, char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties)</summary>
		public readonly EnumerateDeviceExtensionPropertiesDelegate EnumerateDeviceExtensionProperties;
		/// <summary>VkResult vkEnumerateDeviceLayerProperties (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkLayerProperties* pProperties)</summary>
		public readonly EnumerateDeviceLayerPropertiesDelegate EnumerateDeviceLayerProperties;
		/// <summary>VkResult vkEnumerateInstanceExtensionProperties (char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties)</summary>
		public readonly EnumerateInstanceExtensionPropertiesDelegate EnumerateInstanceExtensionProperties;
		/// <summary>VkResult vkEnumerateInstanceLayerProperties (uint32_t* pPropertyCount, VkLayerProperties* pProperties)</summary>
		public readonly EnumerateInstanceLayerPropertiesDelegate EnumerateInstanceLayerProperties;
		/// <summary>VkResult vkEnumeratePhysicalDevices (VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)</summary>
		public readonly EnumeratePhysicalDevicesDelegate EnumeratePhysicalDevices;
		/// <summary>VkResult vkFlushMappedMemoryRanges (VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)</summary>
		public readonly FlushMappedMemoryRangesDelegate FlushMappedMemoryRanges;
		/// <summary>void vkFreeCommandBuffers (VkDevice device, VkCommandPool commandPool, uint32_t commandBufferCount, VkCommandBuffer* pCommandBuffers)</summary>
		public readonly FreeCommandBuffersDelegate FreeCommandBuffers;
		/// <summary>VkResult vkFreeDescriptorSets (VkDevice device, VkDescriptorPool descriptorPool, uint32_t descriptorSetCount, VkDescriptorSet* pDescriptorSets)</summary>
		public readonly FreeDescriptorSetsDelegate FreeDescriptorSets;
		/// <summary>void vkFreeMemory (VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)</summary>
		public readonly FreeMemoryDelegate FreeMemory;
		/// <summary>void vkGetBufferMemoryRequirements (VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)</summary>
		public readonly GetBufferMemoryRequirementsDelegate GetBufferMemoryRequirements;
		/// <summary>void vkGetDeviceMemoryCommitment (VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes)</summary>
		public readonly GetDeviceMemoryCommitmentDelegate GetDeviceMemoryCommitment;
		/// <summary>PFN_vkVoidFunction vkGetDeviceProcAddr (VkDevice device, char* pName)</summary>
		public readonly GetDeviceProcAddrDelegate GetDeviceProcAddr;
		/// <summary>void vkGetDeviceQueue (VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue)</summary>
		public readonly GetDeviceQueueDelegate GetDeviceQueue;
		/// <summary>VkResult vkGetEventStatus (VkDevice device, VkEvent event)</summary>
		public readonly GetEventStatusDelegate GetEventStatus;
		/// <summary>VkResult vkGetFenceStatus (VkDevice device, VkFence fence)</summary>
		public readonly GetFenceStatusDelegate GetFenceStatus;
		/// <summary>void vkGetImageMemoryRequirements (VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)</summary>
		public readonly GetImageMemoryRequirementsDelegate GetImageMemoryRequirements;
		/// <summary>void vkGetImageSparseMemoryRequirements (VkDevice device, VkImage image, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)</summary>
		public readonly GetImageSparseMemoryRequirementsDelegate GetImageSparseMemoryRequirements;
		/// <summary>void vkGetImageSubresourceLayout (VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)</summary>
		public readonly GetImageSubresourceLayoutDelegate GetImageSubresourceLayout;
		/// <summary>PFN_vkVoidFunction vkGetInstanceProcAddr (VkInstance instance, char* pName)</summary>
		public readonly GetInstanceProcAddrDelegate GetInstanceProcAddr;
		/// <summary>void vkGetPhysicalDeviceFeatures (VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)</summary>
		public readonly GetPhysicalDeviceFeaturesDelegate GetPhysicalDeviceFeatures;
		/// <summary>void vkGetPhysicalDeviceFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)</summary>
		public readonly GetPhysicalDeviceFormatPropertiesDelegate GetPhysicalDeviceFormatProperties;
		/// <summary>VkResult vkGetPhysicalDeviceImageFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties)</summary>
		public readonly GetPhysicalDeviceImageFormatPropertiesDelegate GetPhysicalDeviceImageFormatProperties;
		/// <summary>void vkGetPhysicalDeviceMemoryProperties (VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)</summary>
		public readonly GetPhysicalDeviceMemoryPropertiesDelegate GetPhysicalDeviceMemoryProperties;
		/// <summary>void vkGetPhysicalDeviceProperties (VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)</summary>
		public readonly GetPhysicalDevicePropertiesDelegate GetPhysicalDeviceProperties;
		/// <summary>void vkGetPhysicalDeviceQueueFamilyProperties (VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)</summary>
		public readonly GetPhysicalDeviceQueueFamilyPropertiesDelegate GetPhysicalDeviceQueueFamilyProperties;
		/// <summary>void vkGetPhysicalDeviceSparseImageFormatProperties (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint32_t* pPropertyCount, VkSparseImageFormatProperties* pProperties)</summary>
		public readonly GetPhysicalDeviceSparseImageFormatPropertiesDelegate GetPhysicalDeviceSparseImageFormatProperties;
		/// <summary>VkResult vkGetPipelineCacheData (VkDevice device, VkPipelineCache pipelineCache, size_t* pDataSize, void* pData)</summary>
		public readonly GetPipelineCacheDataDelegate GetPipelineCacheData;
		/// <summary>VkResult vkGetQueryPoolResults (VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, size_t dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags)</summary>
		public readonly GetQueryPoolResultsDelegate GetQueryPoolResults;
		/// <summary>void vkGetRenderAreaGranularity (VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)</summary>
		public readonly GetRenderAreaGranularityDelegate GetRenderAreaGranularity;
		/// <summary>VkResult vkInvalidateMappedMemoryRanges (VkDevice device, uint32_t memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)</summary>
		public readonly InvalidateMappedMemoryRangesDelegate InvalidateMappedMemoryRanges;
		/// <summary>VkResult vkMapMemory (VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void* ppData)</summary>
		public readonly MapMemoryDelegate MapMemory;
		/// <summary>VkResult vkMergePipelineCaches (VkDevice device, VkPipelineCache dstCache, uint32_t srcCacheCount, VkPipelineCache* pSrcCaches)</summary>
		public readonly MergePipelineCachesDelegate MergePipelineCaches;
		/// <summary>VkResult vkQueueBindSparse (VkQueue queue, uint32_t bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)</summary>
		public readonly QueueBindSparseDelegate QueueBindSparse;
		/// <summary>VkResult vkQueueSubmit (VkQueue queue, uint32_t submitCount, VkSubmitInfo* pSubmits, VkFence fence)</summary>
		public readonly QueueSubmitDelegate QueueSubmit;
		/// <summary>VkResult vkQueueWaitIdle (VkQueue queue)</summary>
		public readonly QueueWaitIdleDelegate QueueWaitIdle;
		/// <summary>VkResult vkResetCommandBuffer (VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags)</summary>
		public readonly ResetCommandBufferDelegate ResetCommandBuffer;
		/// <summary>VkResult vkResetCommandPool (VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags)</summary>
		public readonly ResetCommandPoolDelegate ResetCommandPool;
		/// <summary>VkResult vkResetDescriptorPool (VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)</summary>
		public readonly ResetDescriptorPoolDelegate ResetDescriptorPool;
		/// <summary>VkResult vkResetEvent (VkDevice device, VkEvent event)</summary>
		public readonly ResetEventDelegate ResetEvent;
		/// <summary>VkResult vkResetFences (VkDevice device, uint32_t fenceCount, VkFence* pFences)</summary>
		public readonly ResetFencesDelegate ResetFences;
		/// <summary>VkResult vkSetEvent (VkDevice device, VkEvent event)</summary>
		public readonly SetEventDelegate SetEvent;
		/// <summary>void vkUnmapMemory (VkDevice device, VkDeviceMemory memory)</summary>
		public readonly UnmapMemoryDelegate UnmapMemory;
		/// <summary>void vkUpdateDescriptorSets (VkDevice device, uint32_t descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint32_t descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)</summary>
		public readonly UpdateDescriptorSetsDelegate UpdateDescriptorSets;
		/// <summary>VkResult vkWaitForFences (VkDevice device, uint32_t fenceCount, VkFence* pFences, VkBool32 waitAll, uint64_t timeout)</summary>
		public readonly WaitForFencesDelegate WaitForFences;

		public unsafe Vk (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,65,108,108,111,99,97,116,101,67,111,109,109,97,110,100,66,117,102,102,101,114,115,0, // vkAllocateCommandBuffers
				118,107,65,108,108,111,99,97,116,101,68,101,115,99,114,105,112,116,111,114,83,101,116,115,0, // vkAllocateDescriptorSets
				118,107,65,108,108,111,99,97,116,101,77,101,109,111,114,121,0, // vkAllocateMemory
				118,107,66,101,103,105,110,67,111,109,109,97,110,100,66,117,102,102,101,114,0, // vkBeginCommandBuffer
				118,107,66,105,110,100,66,117,102,102,101,114,77,101,109,111,114,121,0, // vkBindBufferMemory
				118,107,66,105,110,100,73,109,97,103,101,77,101,109,111,114,121,0, // vkBindImageMemory
				118,107,67,109,100,66,101,103,105,110,81,117,101,114,121,0, // vkCmdBeginQuery
				118,107,67,109,100,66,101,103,105,110,82,101,110,100,101,114,80,97,115,115,0, // vkCmdBeginRenderPass
				118,107,67,109,100,66,105,110,100,68,101,115,99,114,105,112,116,111,114,83,101,116,115,0, // vkCmdBindDescriptorSets
				118,107,67,109,100,66,105,110,100,73,110,100,101,120,66,117,102,102,101,114,0, // vkCmdBindIndexBuffer
				118,107,67,109,100,66,105,110,100,80,105,112,101,108,105,110,101,0, // vkCmdBindPipeline
				118,107,67,109,100,66,105,110,100,86,101,114,116,101,120,66,117,102,102,101,114,115,0, // vkCmdBindVertexBuffers
				118,107,67,109,100,66,108,105,116,73,109,97,103,101,0, // vkCmdBlitImage
				118,107,67,109,100,67,108,101,97,114,65,116,116,97,99,104,109,101,110,116,115,0, // vkCmdClearAttachments
				118,107,67,109,100,67,108,101,97,114,67,111,108,111,114,73,109,97,103,101,0, // vkCmdClearColorImage
				118,107,67,109,100,67,108,101,97,114,68,101,112,116,104,83,116,101,110,99,105,108,73,109,97,103,101,0, // vkCmdClearDepthStencilImage
				118,107,67,109,100,67,111,112,121,66,117,102,102,101,114,0, // vkCmdCopyBuffer
				118,107,67,109,100,67,111,112,121,66,117,102,102,101,114,84,111,73,109,97,103,101,0, // vkCmdCopyBufferToImage
				118,107,67,109,100,67,111,112,121,73,109,97,103,101,0, // vkCmdCopyImage
				118,107,67,109,100,67,111,112,121,73,109,97,103,101,84,111,66,117,102,102,101,114,0, // vkCmdCopyImageToBuffer
				118,107,67,109,100,67,111,112,121,81,117,101,114,121,80,111,111,108,82,101,115,117,108,116,115,0, // vkCmdCopyQueryPoolResults
				118,107,67,109,100,68,105,115,112,97,116,99,104,0, // vkCmdDispatch
				118,107,67,109,100,68,105,115,112,97,116,99,104,73,110,100,105,114,101,99,116,0, // vkCmdDispatchIndirect
				118,107,67,109,100,68,114,97,119,0, // vkCmdDraw
				118,107,67,109,100,68,114,97,119,73,110,100,101,120,101,100,0, // vkCmdDrawIndexed
				118,107,67,109,100,68,114,97,119,73,110,100,101,120,101,100,73,110,100,105,114,101,99,116,0, // vkCmdDrawIndexedIndirect
				118,107,67,109,100,68,114,97,119,73,110,100,105,114,101,99,116,0, // vkCmdDrawIndirect
				118,107,67,109,100,69,110,100,81,117,101,114,121,0, // vkCmdEndQuery
				118,107,67,109,100,69,110,100,82,101,110,100,101,114,80,97,115,115,0, // vkCmdEndRenderPass
				118,107,67,109,100,69,120,101,99,117,116,101,67,111,109,109,97,110,100,115,0, // vkCmdExecuteCommands
				118,107,67,109,100,70,105,108,108,66,117,102,102,101,114,0, // vkCmdFillBuffer
				118,107,67,109,100,78,101,120,116,83,117,98,112,97,115,115,0, // vkCmdNextSubpass
				118,107,67,109,100,80,105,112,101,108,105,110,101,66,97,114,114,105,101,114,0, // vkCmdPipelineBarrier
				118,107,67,109,100,80,117,115,104,67,111,110,115,116,97,110,116,115,0, // vkCmdPushConstants
				118,107,67,109,100,82,101,115,101,116,69,118,101,110,116,0, // vkCmdResetEvent
				118,107,67,109,100,82,101,115,101,116,81,117,101,114,121,80,111,111,108,0, // vkCmdResetQueryPool
				118,107,67,109,100,82,101,115,111,108,118,101,73,109,97,103,101,0, // vkCmdResolveImage
				118,107,67,109,100,83,101,116,66,108,101,110,100,67,111,110,115,116,97,110,116,115,0, // vkCmdSetBlendConstants
				118,107,67,109,100,83,101,116,68,101,112,116,104,66,105,97,115,0, // vkCmdSetDepthBias
				118,107,67,109,100,83,101,116,68,101,112,116,104,66,111,117,110,100,115,0, // vkCmdSetDepthBounds
				118,107,67,109,100,83,101,116,69,118,101,110,116,0, // vkCmdSetEvent
				118,107,67,109,100,83,101,116,76,105,110,101,87,105,100,116,104,0, // vkCmdSetLineWidth
				118,107,67,109,100,83,101,116,83,99,105,115,115,111,114,0, // vkCmdSetScissor
				118,107,67,109,100,83,101,116,83,116,101,110,99,105,108,67,111,109,112,97,114,101,77,97,115,107,0, // vkCmdSetStencilCompareMask
				118,107,67,109,100,83,101,116,83,116,101,110,99,105,108,82,101,102,101,114,101,110,99,101,0, // vkCmdSetStencilReference
				118,107,67,109,100,83,101,116,83,116,101,110,99,105,108,87,114,105,116,101,77,97,115,107,0, // vkCmdSetStencilWriteMask
				118,107,67,109,100,83,101,116,86,105,101,119,112,111,114,116,0, // vkCmdSetViewport
				118,107,67,109,100,85,112,100,97,116,101,66,117,102,102,101,114,0, // vkCmdUpdateBuffer
				118,107,67,109,100,87,97,105,116,69,118,101,110,116,115,0, // vkCmdWaitEvents
				118,107,67,109,100,87,114,105,116,101,84,105,109,101,115,116,97,109,112,0, // vkCmdWriteTimestamp
				118,107,67,114,101,97,116,101,66,117,102,102,101,114,0, // vkCreateBuffer
				118,107,67,114,101,97,116,101,66,117,102,102,101,114,86,105,101,119,0, // vkCreateBufferView
				118,107,67,114,101,97,116,101,67,111,109,109,97,110,100,80,111,111,108,0, // vkCreateCommandPool
				118,107,67,114,101,97,116,101,67,111,109,112,117,116,101,80,105,112,101,108,105,110,101,115,0, // vkCreateComputePipelines
				118,107,67,114,101,97,116,101,68,101,115,99,114,105,112,116,111,114,80,111,111,108,0, // vkCreateDescriptorPool
				118,107,67,114,101,97,116,101,68,101,115,99,114,105,112,116,111,114,83,101,116,76,97,121,111,117,116,0, // vkCreateDescriptorSetLayout
				118,107,67,114,101,97,116,101,68,101,118,105,99,101,0, // vkCreateDevice
				118,107,67,114,101,97,116,101,69,118,101,110,116,0, // vkCreateEvent
				118,107,67,114,101,97,116,101,70,101,110,99,101,0, // vkCreateFence
				118,107,67,114,101,97,116,101,70,114,97,109,101,98,117,102,102,101,114,0, // vkCreateFramebuffer
				118,107,67,114,101,97,116,101,71,114,97,112,104,105,99,115,80,105,112,101,108,105,110,101,115,0, // vkCreateGraphicsPipelines
				118,107,67,114,101,97,116,101,73,109,97,103,101,0, // vkCreateImage
				118,107,67,114,101,97,116,101,73,109,97,103,101,86,105,101,119,0, // vkCreateImageView
				118,107,67,114,101,97,116,101,73,110,115,116,97,110,99,101,0, // vkCreateInstance
				118,107,67,114,101,97,116,101,80,105,112,101,108,105,110,101,67,97,99,104,101,0, // vkCreatePipelineCache
				118,107,67,114,101,97,116,101,80,105,112,101,108,105,110,101,76,97,121,111,117,116,0, // vkCreatePipelineLayout
				118,107,67,114,101,97,116,101,81,117,101,114,121,80,111,111,108,0, // vkCreateQueryPool
				118,107,67,114,101,97,116,101,82,101,110,100,101,114,80,97,115,115,0, // vkCreateRenderPass
				118,107,67,114,101,97,116,101,83,97,109,112,108,101,114,0, // vkCreateSampler
				118,107,67,114,101,97,116,101,83,101,109,97,112,104,111,114,101,0, // vkCreateSemaphore
				118,107,67,114,101,97,116,101,83,104,97,100,101,114,77,111,100,117,108,101,0, // vkCreateShaderModule
				118,107,68,101,115,116,114,111,121,66,117,102,102,101,114,0, // vkDestroyBuffer
				118,107,68,101,115,116,114,111,121,66,117,102,102,101,114,86,105,101,119,0, // vkDestroyBufferView
				118,107,68,101,115,116,114,111,121,67,111,109,109,97,110,100,80,111,111,108,0, // vkDestroyCommandPool
				118,107,68,101,115,116,114,111,121,68,101,115,99,114,105,112,116,111,114,80,111,111,108,0, // vkDestroyDescriptorPool
				118,107,68,101,115,116,114,111,121,68,101,115,99,114,105,112,116,111,114,83,101,116,76,97,121,111,117,116,0, // vkDestroyDescriptorSetLayout
				118,107,68,101,115,116,114,111,121,68,101,118,105,99,101,0, // vkDestroyDevice
				118,107,68,101,115,116,114,111,121,69,118,101,110,116,0, // vkDestroyEvent
				118,107,68,101,115,116,114,111,121,70,101,110,99,101,0, // vkDestroyFence
				118,107,68,101,115,116,114,111,121,70,114,97,109,101,98,117,102,102,101,114,0, // vkDestroyFramebuffer
				118,107,68,101,115,116,114,111,121,73,109,97,103,101,0, // vkDestroyImage
				118,107,68,101,115,116,114,111,121,73,109,97,103,101,86,105,101,119,0, // vkDestroyImageView
				118,107,68,101,115,116,114,111,121,73,110,115,116,97,110,99,101,0, // vkDestroyInstance
				118,107,68,101,115,116,114,111,121,80,105,112,101,108,105,110,101,0, // vkDestroyPipeline
				118,107,68,101,115,116,114,111,121,80,105,112,101,108,105,110,101,67,97,99,104,101,0, // vkDestroyPipelineCache
				118,107,68,101,115,116,114,111,121,80,105,112,101,108,105,110,101,76,97,121,111,117,116,0, // vkDestroyPipelineLayout
				118,107,68,101,115,116,114,111,121,81,117,101,114,121,80,111,111,108,0, // vkDestroyQueryPool
				118,107,68,101,115,116,114,111,121,82,101,110,100,101,114,80,97,115,115,0, // vkDestroyRenderPass
				118,107,68,101,115,116,114,111,121,83,97,109,112,108,101,114,0, // vkDestroySampler
				118,107,68,101,115,116,114,111,121,83,101,109,97,112,104,111,114,101,0, // vkDestroySemaphore
				118,107,68,101,115,116,114,111,121,83,104,97,100,101,114,77,111,100,117,108,101,0, // vkDestroyShaderModule
				118,107,68,101,118,105,99,101,87,97,105,116,73,100,108,101,0, // vkDeviceWaitIdle
				118,107,69,110,100,67,111,109,109,97,110,100,66,117,102,102,101,114,0, // vkEndCommandBuffer
				118,107,69,110,117,109,101,114,97,116,101,68,101,118,105,99,101,69,120,116,101,110,115,105,111,110,80,114,111,112,101,114,116,105,101,115,0, // vkEnumerateDeviceExtensionProperties
				118,107,69,110,117,109,101,114,97,116,101,68,101,118,105,99,101,76,97,121,101,114,80,114,111,112,101,114,116,105,101,115,0, // vkEnumerateDeviceLayerProperties
				118,107,69,110,117,109,101,114,97,116,101,73,110,115,116,97,110,99,101,69,120,116,101,110,115,105,111,110,80,114,111,112,101,114,116,105,101,115,0, // vkEnumerateInstanceExtensionProperties
				118,107,69,110,117,109,101,114,97,116,101,73,110,115,116,97,110,99,101,76,97,121,101,114,80,114,111,112,101,114,116,105,101,115,0, // vkEnumerateInstanceLayerProperties
				118,107,69,110,117,109,101,114,97,116,101,80,104,121,115,105,99,97,108,68,101,118,105,99,101,115,0, // vkEnumeratePhysicalDevices
				118,107,70,108,117,115,104,77,97,112,112,101,100,77,101,109,111,114,121,82,97,110,103,101,115,0, // vkFlushMappedMemoryRanges
				118,107,70,114,101,101,67,111,109,109,97,110,100,66,117,102,102,101,114,115,0, // vkFreeCommandBuffers
				118,107,70,114,101,101,68,101,115,99,114,105,112,116,111,114,83,101,116,115,0, // vkFreeDescriptorSets
				118,107,70,114,101,101,77,101,109,111,114,121,0, // vkFreeMemory
				118,107,71,101,116,66,117,102,102,101,114,77,101,109,111,114,121,82,101,113,117,105,114,101,109,101,110,116,115,0, // vkGetBufferMemoryRequirements
				118,107,71,101,116,68,101,118,105,99,101,77,101,109,111,114,121,67,111,109,109,105,116,109,101,110,116,0, // vkGetDeviceMemoryCommitment
				118,107,71,101,116,68,101,118,105,99,101,80,114,111,99,65,100,100,114,0, // vkGetDeviceProcAddr
				118,107,71,101,116,68,101,118,105,99,101,81,117,101,117,101,0, // vkGetDeviceQueue
				118,107,71,101,116,69,118,101,110,116,83,116,97,116,117,115,0, // vkGetEventStatus
				118,107,71,101,116,70,101,110,99,101,83,116,97,116,117,115,0, // vkGetFenceStatus
				118,107,71,101,116,73,109,97,103,101,77,101,109,111,114,121,82,101,113,117,105,114,101,109,101,110,116,115,0, // vkGetImageMemoryRequirements
				118,107,71,101,116,73,109,97,103,101,83,112,97,114,115,101,77,101,109,111,114,121,82,101,113,117,105,114,101,109,101,110,116,115,0, // vkGetImageSparseMemoryRequirements
				118,107,71,101,116,73,109,97,103,101,83,117,98,114,101,115,111,117,114,99,101,76,97,121,111,117,116,0, // vkGetImageSubresourceLayout
				118,107,71,101,116,73,110,115,116,97,110,99,101,80,114,111,99,65,100,100,114,0, // vkGetInstanceProcAddr
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,70,101,97,116,117,114,101,115,0, // vkGetPhysicalDeviceFeatures
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,70,111,114,109,97,116,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceFormatProperties
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,73,109,97,103,101,70,111,114,109,97,116,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceImageFormatProperties
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,77,101,109,111,114,121,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceMemoryProperties
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceProperties
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,81,117,101,117,101,70,97,109,105,108,121,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceQueueFamilyProperties
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,83,112,97,114,115,101,73,109,97,103,101,70,111,114,109,97,116,80,114,111,112,101,114,116,105,101,115,0, // vkGetPhysicalDeviceSparseImageFormatProperties
				118,107,71,101,116,80,105,112,101,108,105,110,101,67,97,99,104,101,68,97,116,97,0, // vkGetPipelineCacheData
				118,107,71,101,116,81,117,101,114,121,80,111,111,108,82,101,115,117,108,116,115,0, // vkGetQueryPoolResults
				118,107,71,101,116,82,101,110,100,101,114,65,114,101,97,71,114,97,110,117,108,97,114,105,116,121,0, // vkGetRenderAreaGranularity
				118,107,73,110,118,97,108,105,100,97,116,101,77,97,112,112,101,100,77,101,109,111,114,121,82,97,110,103,101,115,0, // vkInvalidateMappedMemoryRanges
				118,107,77,97,112,77,101,109,111,114,121,0, // vkMapMemory
				118,107,77,101,114,103,101,80,105,112,101,108,105,110,101,67,97,99,104,101,115,0, // vkMergePipelineCaches
				118,107,81,117,101,117,101,66,105,110,100,83,112,97,114,115,101,0, // vkQueueBindSparse
				118,107,81,117,101,117,101,83,117,98,109,105,116,0, // vkQueueSubmit
				118,107,81,117,101,117,101,87,97,105,116,73,100,108,101,0, // vkQueueWaitIdle
				118,107,82,101,115,101,116,67,111,109,109,97,110,100,66,117,102,102,101,114,0, // vkResetCommandBuffer
				118,107,82,101,115,101,116,67,111,109,109,97,110,100,80,111,111,108,0, // vkResetCommandPool
				118,107,82,101,115,101,116,68,101,115,99,114,105,112,116,111,114,80,111,111,108,0, // vkResetDescriptorPool
				118,107,82,101,115,101,116,69,118,101,110,116,0, // vkResetEvent
				118,107,82,101,115,101,116,70,101,110,99,101,115,0, // vkResetFences
				118,107,83,101,116,69,118,101,110,116,0, // vkSetEvent
				118,107,85,110,109,97,112,77,101,109,111,114,121,0, // vkUnmapMemory
				118,107,85,112,100,97,116,101,68,101,115,99,114,105,112,116,111,114,83,101,116,115,0, // vkUpdateDescriptorSets
				118,107,87,97,105,116,70,111,114,70,101,110,99,101,115,0, // vkWaitForFences
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out AllocateCommandBuffers);
				resolver.LoadHandle(p + 25, out AllocateDescriptorSets);
				resolver.LoadHandle(p + 50, out AllocateMemory);
				resolver.LoadHandle(p + 67, out BeginCommandBuffer);
				resolver.LoadHandle(p + 88, out BindBufferMemory);
				resolver.LoadHandle(p + 107, out BindImageMemory);
				resolver.LoadHandle(p + 125, out CmdBeginQuery);
				resolver.LoadHandle(p + 141, out CmdBeginRenderPass);
				resolver.LoadHandle(p + 162, out CmdBindDescriptorSets);
				resolver.LoadHandle(p + 186, out CmdBindIndexBuffer);
				resolver.LoadHandle(p + 207, out CmdBindPipeline);
				resolver.LoadHandle(p + 225, out CmdBindVertexBuffers);
				resolver.LoadHandle(p + 248, out CmdBlitImage);
				resolver.LoadHandle(p + 263, out CmdClearAttachments);
				resolver.LoadHandle(p + 285, out CmdClearColorImage);
				resolver.LoadHandle(p + 306, out CmdClearDepthStencilImage);
				resolver.LoadHandle(p + 334, out CmdCopyBuffer);
				resolver.LoadHandle(p + 350, out CmdCopyBufferToImage);
				resolver.LoadHandle(p + 373, out CmdCopyImage);
				resolver.LoadHandle(p + 388, out CmdCopyImageToBuffer);
				resolver.LoadHandle(p + 411, out CmdCopyQueryPoolResults);
				resolver.LoadHandle(p + 437, out CmdDispatch);
				resolver.LoadHandle(p + 451, out CmdDispatchIndirect);
				resolver.LoadHandle(p + 473, out CmdDraw);
				resolver.LoadHandle(p + 483, out CmdDrawIndexed);
				resolver.LoadHandle(p + 500, out CmdDrawIndexedIndirect);
				resolver.LoadHandle(p + 525, out CmdDrawIndirect);
				resolver.LoadHandle(p + 543, out CmdEndQuery);
				resolver.LoadHandle(p + 557, out CmdEndRenderPass);
				resolver.LoadHandle(p + 576, out CmdExecuteCommands);
				resolver.LoadHandle(p + 597, out CmdFillBuffer);
				resolver.LoadHandle(p + 613, out CmdNextSubpass);
				resolver.LoadHandle(p + 630, out CmdPipelineBarrier);
				resolver.LoadHandle(p + 651, out CmdPushConstants);
				resolver.LoadHandle(p + 670, out CmdResetEvent);
				resolver.LoadHandle(p + 686, out CmdResetQueryPool);
				resolver.LoadHandle(p + 706, out CmdResolveImage);
				resolver.LoadHandle(p + 724, out CmdSetBlendConstants);
				resolver.LoadHandle(p + 747, out CmdSetDepthBias);
				resolver.LoadHandle(p + 765, out CmdSetDepthBounds);
				resolver.LoadHandle(p + 785, out CmdSetEvent);
				resolver.LoadHandle(p + 799, out CmdSetLineWidth);
				resolver.LoadHandle(p + 817, out CmdSetScissor);
				resolver.LoadHandle(p + 833, out CmdSetStencilCompareMask);
				resolver.LoadHandle(p + 860, out CmdSetStencilReference);
				resolver.LoadHandle(p + 885, out CmdSetStencilWriteMask);
				resolver.LoadHandle(p + 910, out CmdSetViewport);
				resolver.LoadHandle(p + 927, out CmdUpdateBuffer);
				resolver.LoadHandle(p + 945, out CmdWaitEvents);
				resolver.LoadHandle(p + 961, out CmdWriteTimestamp);
				resolver.LoadHandle(p + 981, out CreateBuffer);
				resolver.LoadHandle(p + 996, out CreateBufferView);
				resolver.LoadHandle(p + 1015, out CreateCommandPool);
				resolver.LoadHandle(p + 1035, out CreateComputePipelines);
				resolver.LoadHandle(p + 1060, out CreateDescriptorPool);
				resolver.LoadHandle(p + 1083, out CreateDescriptorSetLayout);
				resolver.LoadHandle(p + 1111, out CreateDevice);
				resolver.LoadHandle(p + 1126, out CreateEvent);
				resolver.LoadHandle(p + 1140, out CreateFence);
				resolver.LoadHandle(p + 1154, out CreateFramebuffer);
				resolver.LoadHandle(p + 1174, out CreateGraphicsPipelines);
				resolver.LoadHandle(p + 1200, out CreateImage);
				resolver.LoadHandle(p + 1214, out CreateImageView);
				resolver.LoadHandle(p + 1232, out CreateInstance);
				resolver.LoadHandle(p + 1249, out CreatePipelineCache);
				resolver.LoadHandle(p + 1271, out CreatePipelineLayout);
				resolver.LoadHandle(p + 1294, out CreateQueryPool);
				resolver.LoadHandle(p + 1312, out CreateRenderPass);
				resolver.LoadHandle(p + 1331, out CreateSampler);
				resolver.LoadHandle(p + 1347, out CreateSemaphore);
				resolver.LoadHandle(p + 1365, out CreateShaderModule);
				resolver.LoadHandle(p + 1386, out DestroyBuffer);
				resolver.LoadHandle(p + 1402, out DestroyBufferView);
				resolver.LoadHandle(p + 1422, out DestroyCommandPool);
				resolver.LoadHandle(p + 1443, out DestroyDescriptorPool);
				resolver.LoadHandle(p + 1467, out DestroyDescriptorSetLayout);
				resolver.LoadHandle(p + 1496, out DestroyDevice);
				resolver.LoadHandle(p + 1512, out DestroyEvent);
				resolver.LoadHandle(p + 1527, out DestroyFence);
				resolver.LoadHandle(p + 1542, out DestroyFramebuffer);
				resolver.LoadHandle(p + 1563, out DestroyImage);
				resolver.LoadHandle(p + 1578, out DestroyImageView);
				resolver.LoadHandle(p + 1597, out DestroyInstance);
				resolver.LoadHandle(p + 1615, out DestroyPipeline);
				resolver.LoadHandle(p + 1633, out DestroyPipelineCache);
				resolver.LoadHandle(p + 1656, out DestroyPipelineLayout);
				resolver.LoadHandle(p + 1680, out DestroyQueryPool);
				resolver.LoadHandle(p + 1699, out DestroyRenderPass);
				resolver.LoadHandle(p + 1719, out DestroySampler);
				resolver.LoadHandle(p + 1736, out DestroySemaphore);
				resolver.LoadHandle(p + 1755, out DestroyShaderModule);
				resolver.LoadHandle(p + 1777, out DeviceWaitIdle);
				resolver.LoadHandle(p + 1794, out EndCommandBuffer);
				resolver.LoadHandle(p + 1813, out EnumerateDeviceExtensionProperties);
				resolver.LoadHandle(p + 1850, out EnumerateDeviceLayerProperties);
				resolver.LoadHandle(p + 1883, out EnumerateInstanceExtensionProperties);
				resolver.LoadHandle(p + 1922, out EnumerateInstanceLayerProperties);
				resolver.LoadHandle(p + 1957, out EnumeratePhysicalDevices);
				resolver.LoadHandle(p + 1984, out FlushMappedMemoryRanges);
				resolver.LoadHandle(p + 2010, out FreeCommandBuffers);
				resolver.LoadHandle(p + 2031, out FreeDescriptorSets);
				resolver.LoadHandle(p + 2052, out FreeMemory);
				resolver.LoadHandle(p + 2065, out GetBufferMemoryRequirements);
				resolver.LoadHandle(p + 2095, out GetDeviceMemoryCommitment);
				resolver.LoadHandle(p + 2123, out GetDeviceProcAddr);
				resolver.LoadHandle(p + 2143, out GetDeviceQueue);
				resolver.LoadHandle(p + 2160, out GetEventStatus);
				resolver.LoadHandle(p + 2177, out GetFenceStatus);
				resolver.LoadHandle(p + 2194, out GetImageMemoryRequirements);
				resolver.LoadHandle(p + 2223, out GetImageSparseMemoryRequirements);
				resolver.LoadHandle(p + 2258, out GetImageSubresourceLayout);
				resolver.LoadHandle(p + 2286, out GetInstanceProcAddr);
				resolver.LoadHandle(p + 2308, out GetPhysicalDeviceFeatures);
				resolver.LoadHandle(p + 2336, out GetPhysicalDeviceFormatProperties);
				resolver.LoadHandle(p + 2372, out GetPhysicalDeviceImageFormatProperties);
				resolver.LoadHandle(p + 2413, out GetPhysicalDeviceMemoryProperties);
				resolver.LoadHandle(p + 2449, out GetPhysicalDeviceProperties);
				resolver.LoadHandle(p + 2479, out GetPhysicalDeviceQueueFamilyProperties);
				resolver.LoadHandle(p + 2520, out GetPhysicalDeviceSparseImageFormatProperties);
				resolver.LoadHandle(p + 2567, out GetPipelineCacheData);
				resolver.LoadHandle(p + 2590, out GetQueryPoolResults);
				resolver.LoadHandle(p + 2612, out GetRenderAreaGranularity);
				resolver.LoadHandle(p + 2639, out InvalidateMappedMemoryRanges);
				resolver.LoadHandle(p + 2670, out MapMemory);
				resolver.LoadHandle(p + 2682, out MergePipelineCaches);
				resolver.LoadHandle(p + 2704, out QueueBindSparse);
				resolver.LoadHandle(p + 2722, out QueueSubmit);
				resolver.LoadHandle(p + 2736, out QueueWaitIdle);
				resolver.LoadHandle(p + 2752, out ResetCommandBuffer);
				resolver.LoadHandle(p + 2773, out ResetCommandPool);
				resolver.LoadHandle(p + 2792, out ResetDescriptorPool);
				resolver.LoadHandle(p + 2814, out ResetEvent);
				resolver.LoadHandle(p + 2827, out ResetFences);
				resolver.LoadHandle(p + 2841, out SetEvent);
				resolver.LoadHandle(p + 2852, out UnmapMemory);
				resolver.LoadHandle(p + 2866, out UpdateDescriptorSets);
				resolver.LoadHandle(p + 2889, out WaitForFences);
			}
		}
	}
	// VK_AMD_draw_indirect_count
	public partial class AmdDrawIndirectCount
	{
		// VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_draw_indirect_count";

		/// <summary>void vkCmdDrawIndexedIndirectCountAMD (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawIndexedIndirectCountAMDDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		/// <summary>void vkCmdDrawIndirectCountAMD (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDrawIndirectCountAMDDelegate (CommandBuffer commandBuffer, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);

		/// <summary>void vkCmdDrawIndexedIndirectCountAMD (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride)</summary>
		public readonly CmdDrawIndexedIndirectCountAMDDelegate CmdDrawIndexedIndirectCountAMD;
		/// <summary>void vkCmdDrawIndirectCountAMD (VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint32_t maxDrawCount, uint32_t stride)</summary>
		public readonly CmdDrawIndirectCountAMDDelegate CmdDrawIndirectCountAMD;

		public unsafe AmdDrawIndirectCount (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,109,100,68,114,97,119,73,110,100,101,120,101,100,73,110,100,105,114,101,99,116,67,111,117,110,116,65,77,68,0, // vkCmdDrawIndexedIndirectCountAMD
				118,107,67,109,100,68,114,97,119,73,110,100,105,114,101,99,116,67,111,117,110,116,65,77,68,0, // vkCmdDrawIndirectCountAMD
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CmdDrawIndexedIndirectCountAMD);
				resolver.LoadHandle(p + 33, out CmdDrawIndirectCountAMD);
			}
		}
	}
	// VK_AMD_gcn_shader
	public partial class AmdGcnShader
	{
		// VK_AMD_GCN_SHADER_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_GCN_SHADER_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_gcn_shader";
	}
	// VK_AMD_gpu_shader_half_float
	public partial class AmdGpuShaderHalfFloat
	{
		// VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_gpu_shader_half_float";
	}
	// VK_AMD_negative_viewport_height
	public partial class AmdNegativeViewportHeight
	{
		// VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_negative_viewport_height";
	}
	// VK_AMD_rasterization_order
	public partial class AmdRasterizationOrder
	{
		// VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_rasterization_order";
	}
	// VK_AMD_shader_ballot
	public partial class AmdShaderBallot
	{
		// VK_AMD_SHADER_BALLOT_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_SHADER_BALLOT_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_shader_ballot";
	}
	// VK_AMD_shader_explicit_vertex_parameter
	public partial class AmdShaderExplicitVertexParameter
	{
		// VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_shader_explicit_vertex_parameter";
	}
	// VK_AMD_shader_trinary_minmax
	public partial class AmdShaderTrinaryMinmax
	{
		// VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_AMD_shader_trinary_minmax";
	}
	// VK_EXT_debug_marker
	public partial class ExtDebugMarker
	{
		// VK_EXT_DEBUG_MARKER_SPEC_VERSION
		public const int SPEC_VERSION = 3;
		// VK_EXT_DEBUG_MARKER_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_EXT_debug_marker";

		/// <summary>void vkCmdDebugMarkerBeginEXT (VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDebugMarkerBeginEXTDelegate (CommandBuffer commandBuffer, ref DebugMarkerMarkerInfoEXT pMarkerInfo);
		/// <summary>void vkCmdDebugMarkerEndEXT (VkCommandBuffer commandBuffer)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDebugMarkerEndEXTDelegate (CommandBuffer commandBuffer);
		/// <summary>void vkCmdDebugMarkerInsertEXT (VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdDebugMarkerInsertEXTDelegate (CommandBuffer commandBuffer, ref DebugMarkerMarkerInfoEXT pMarkerInfo);
		/// <summary>VkResult vkDebugMarkerSetObjectNameEXT (VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result DebugMarkerSetObjectNameEXTDelegate (Device device, ref DebugMarkerObjectNameInfoEXT pNameInfo);
		/// <summary>VkResult vkDebugMarkerSetObjectTagEXT (VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result DebugMarkerSetObjectTagEXTDelegate (Device device, ref DebugMarkerObjectTagInfoEXT pTagInfo);

		/// <summary>void vkCmdDebugMarkerBeginEXT (VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)</summary>
		public readonly CmdDebugMarkerBeginEXTDelegate CmdDebugMarkerBeginEXT;
		/// <summary>void vkCmdDebugMarkerEndEXT (VkCommandBuffer commandBuffer)</summary>
		public readonly CmdDebugMarkerEndEXTDelegate CmdDebugMarkerEndEXT;
		/// <summary>void vkCmdDebugMarkerInsertEXT (VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)</summary>
		public readonly CmdDebugMarkerInsertEXTDelegate CmdDebugMarkerInsertEXT;
		/// <summary>VkResult vkDebugMarkerSetObjectNameEXT (VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)</summary>
		public readonly DebugMarkerSetObjectNameEXTDelegate DebugMarkerSetObjectNameEXT;
		/// <summary>VkResult vkDebugMarkerSetObjectTagEXT (VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)</summary>
		public readonly DebugMarkerSetObjectTagEXTDelegate DebugMarkerSetObjectTagEXT;

		public unsafe ExtDebugMarker (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,109,100,68,101,98,117,103,77,97,114,107,101,114,66,101,103,105,110,69,88,84,0, // vkCmdDebugMarkerBeginEXT
				118,107,67,109,100,68,101,98,117,103,77,97,114,107,101,114,69,110,100,69,88,84,0, // vkCmdDebugMarkerEndEXT
				118,107,67,109,100,68,101,98,117,103,77,97,114,107,101,114,73,110,115,101,114,116,69,88,84,0, // vkCmdDebugMarkerInsertEXT
				118,107,68,101,98,117,103,77,97,114,107,101,114,83,101,116,79,98,106,101,99,116,78,97,109,101,69,88,84,0, // vkDebugMarkerSetObjectNameEXT
				118,107,68,101,98,117,103,77,97,114,107,101,114,83,101,116,79,98,106,101,99,116,84,97,103,69,88,84,0, // vkDebugMarkerSetObjectTagEXT
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CmdDebugMarkerBeginEXT);
				resolver.LoadHandle(p + 25, out CmdDebugMarkerEndEXT);
				resolver.LoadHandle(p + 48, out CmdDebugMarkerInsertEXT);
				resolver.LoadHandle(p + 74, out DebugMarkerSetObjectNameEXT);
				resolver.LoadHandle(p + 104, out DebugMarkerSetObjectTagEXT);
			}
		}
	}
	// VK_EXT_debug_report
	public partial class ExtDebugReport
	{
		// VK_EXT_DEBUG_REPORT_SPEC_VERSION
		public const int SPEC_VERSION = 4;
		// VK_EXT_DEBUG_REPORT_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_EXT_debug_report";
		// VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT
		public const int VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT = (1000000000 + 1000 * (12 - 1) + 0);

		/// <summary>VkResult vkCreateDebugReportCallbackEXT (VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDebugReportCallbackEXTDelegate (Instance instance, ref DebugReportCallbackCreateInfoEXT pCreateInfo, AllocationCallbacks* pAllocator, out DebugReportCallbackEXT pCallback);
		/// <summary>void vkDebugReportMessageEXT (VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DebugReportMessageEXTDelegate (Instance instance, DebugReportFlagBitsEXT flags, DebugReportObjectTypeEXT objectType, ulong @object, int location, int messageCode, byte* pLayerPrefix, byte* pMessage);
		/// <summary>void vkDestroyDebugReportCallbackEXT (VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyDebugReportCallbackEXTDelegate (Instance instance, DebugReportCallbackEXT callback, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));

		/// <summary>VkResult vkCreateDebugReportCallbackEXT (VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)</summary>
		public readonly CreateDebugReportCallbackEXTDelegate CreateDebugReportCallbackEXT;
		/// <summary>void vkDebugReportMessageEXT (VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage)</summary>
		public readonly DebugReportMessageEXTDelegate DebugReportMessageEXT;
		/// <summary>void vkDestroyDebugReportCallbackEXT (VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyDebugReportCallbackEXTDelegate DestroyDebugReportCallbackEXT;

		public unsafe ExtDebugReport (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,68,101,98,117,103,82,101,112,111,114,116,67,97,108,108,98,97,99,107,69,88,84,0, // vkCreateDebugReportCallbackEXT
				118,107,68,101,98,117,103,82,101,112,111,114,116,77,101,115,115,97,103,101,69,88,84,0, // vkDebugReportMessageEXT
				118,107,68,101,115,116,114,111,121,68,101,98,117,103,82,101,112,111,114,116,67,97,108,108,98,97,99,107,69,88,84,0, // vkDestroyDebugReportCallbackEXT
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateDebugReportCallbackEXT);
				resolver.LoadHandle(p + 31, out DebugReportMessageEXT);
				resolver.LoadHandle(p + 55, out DestroyDebugReportCallbackEXT);
			}
		}
	}
	// VK_EXT_validation_flags
	public partial class ExtValidationFlags
	{
		// VK_EXT_VALIDATION_FLAGS_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_EXT_validation_flags";
	}
	// VK_IMG_filter_cubic
	public partial class ImgFilterCubic
	{
		// VK_IMG_FILTER_CUBIC_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_IMG_FILTER_CUBIC_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_IMG_filter_cubic";
	}
	// VK_IMG_format_pvrtc
	public partial class ImgFormatPvrtc
	{
		// VK_IMG_FORMAT_PVRTC_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_IMG_FORMAT_PVRTC_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_IMG_format_pvrtc";
	}
	// VK_KHR_android_surface
	public partial class KhrAndroidSurface
	{
		// VK_KHR_ANDROID_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 6;
		// VK_KHR_ANDROID_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_android_surface";

		/// <summary>VkResult vkCreateAndroidSurfaceKHR (VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateAndroidSurfaceKHRDelegate (Instance instance, ref AndroidSurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);

		/// <summary>VkResult vkCreateAndroidSurfaceKHR (VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateAndroidSurfaceKHRDelegate CreateAndroidSurfaceKHR;

		public unsafe KhrAndroidSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,65,110,100,114,111,105,100,83,117,114,102,97,99,101,75,72,82,0, // vkCreateAndroidSurfaceKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateAndroidSurfaceKHR);
			}
		}
	}
	// VK_KHR_display
	public partial class KhrDisplay
	{
		// VK_KHR_DISPLAY_SPEC_VERSION
		public const int SPEC_VERSION = 21;
		// VK_KHR_DISPLAY_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_display";

		/// <summary>VkResult vkCreateDisplayModeKHR (VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDisplayModeKHRDelegate (PhysicalDevice physicalDevice, DisplayKHR display, ref DisplayModeCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, DisplayModeKHR* pMode);
		/// <summary>VkResult vkCreateDisplayPlaneSurfaceKHR (VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateDisplayPlaneSurfaceKHRDelegate (Instance instance, ref DisplaySurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkResult vkGetDisplayModePropertiesKHR (VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetDisplayModePropertiesKHRDelegate (PhysicalDevice physicalDevice, DisplayKHR display, uint* pPropertyCount, DisplayModePropertiesKHR* pProperties);
		/// <summary>VkResult vkGetDisplayPlaneCapabilitiesKHR (VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint32_t planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetDisplayPlaneCapabilitiesKHRDelegate (PhysicalDevice physicalDevice, DisplayModeKHR mode, uint planeIndex, DisplayPlaneCapabilitiesKHR* pCapabilities);
		/// <summary>VkResult vkGetDisplayPlaneSupportedDisplaysKHR (VkPhysicalDevice physicalDevice, uint32_t planeIndex, uint32_t* pDisplayCount, VkDisplayKHR* pDisplays)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetDisplayPlaneSupportedDisplaysKHRDelegate (PhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, DisplayKHR* pDisplays);
		/// <summary>VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate (PhysicalDevice physicalDevice, uint* pPropertyCount, DisplayPlanePropertiesKHR* pProperties);
		/// <summary>VkResult vkGetPhysicalDeviceDisplayPropertiesKHR (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPropertiesKHR* pProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceDisplayPropertiesKHRDelegate (PhysicalDevice physicalDevice, uint* pPropertyCount, DisplayPropertiesKHR* pProperties);

		/// <summary>VkResult vkCreateDisplayModeKHR (VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)</summary>
		public readonly CreateDisplayModeKHRDelegate CreateDisplayModeKHR;
		/// <summary>VkResult vkCreateDisplayPlaneSurfaceKHR (VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateDisplayPlaneSurfaceKHRDelegate CreateDisplayPlaneSurfaceKHR;
		/// <summary>VkResult vkGetDisplayModePropertiesKHR (VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint32_t* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)</summary>
		public readonly GetDisplayModePropertiesKHRDelegate GetDisplayModePropertiesKHR;
		/// <summary>VkResult vkGetDisplayPlaneCapabilitiesKHR (VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint32_t planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)</summary>
		public readonly GetDisplayPlaneCapabilitiesKHRDelegate GetDisplayPlaneCapabilitiesKHR;
		/// <summary>VkResult vkGetDisplayPlaneSupportedDisplaysKHR (VkPhysicalDevice physicalDevice, uint32_t planeIndex, uint32_t* pDisplayCount, VkDisplayKHR* pDisplays)</summary>
		public readonly GetDisplayPlaneSupportedDisplaysKHRDelegate GetDisplayPlaneSupportedDisplaysKHR;
		/// <summary>VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)</summary>
		public readonly GetPhysicalDeviceDisplayPlanePropertiesKHRDelegate GetPhysicalDeviceDisplayPlanePropertiesKHR;
		/// <summary>VkResult vkGetPhysicalDeviceDisplayPropertiesKHR (VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkDisplayPropertiesKHR* pProperties)</summary>
		public readonly GetPhysicalDeviceDisplayPropertiesKHRDelegate GetPhysicalDeviceDisplayPropertiesKHR;

		public unsafe KhrDisplay (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,68,105,115,112,108,97,121,77,111,100,101,75,72,82,0, // vkCreateDisplayModeKHR
				118,107,67,114,101,97,116,101,68,105,115,112,108,97,121,80,108,97,110,101,83,117,114,102,97,99,101,75,72,82,0, // vkCreateDisplayPlaneSurfaceKHR
				118,107,71,101,116,68,105,115,112,108,97,121,77,111,100,101,80,114,111,112,101,114,116,105,101,115,75,72,82,0, // vkGetDisplayModePropertiesKHR
				118,107,71,101,116,68,105,115,112,108,97,121,80,108,97,110,101,67,97,112,97,98,105,108,105,116,105,101,115,75,72,82,0, // vkGetDisplayPlaneCapabilitiesKHR
				118,107,71,101,116,68,105,115,112,108,97,121,80,108,97,110,101,83,117,112,112,111,114,116,101,100,68,105,115,112,108,97,121,115,75,72,82,0, // vkGetDisplayPlaneSupportedDisplaysKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,68,105,115,112,108,97,121,80,108,97,110,101,80,114,111,112,101,114,116,105,101,115,75,72,82,0, // vkGetPhysicalDeviceDisplayPlanePropertiesKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,68,105,115,112,108,97,121,80,114,111,112,101,114,116,105,101,115,75,72,82,0, // vkGetPhysicalDeviceDisplayPropertiesKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateDisplayModeKHR);
				resolver.LoadHandle(p + 23, out CreateDisplayPlaneSurfaceKHR);
				resolver.LoadHandle(p + 54, out GetDisplayModePropertiesKHR);
				resolver.LoadHandle(p + 84, out GetDisplayPlaneCapabilitiesKHR);
				resolver.LoadHandle(p + 117, out GetDisplayPlaneSupportedDisplaysKHR);
				resolver.LoadHandle(p + 155, out GetPhysicalDeviceDisplayPlanePropertiesKHR);
				resolver.LoadHandle(p + 200, out GetPhysicalDeviceDisplayPropertiesKHR);
			}
		}
	}
	// VK_KHR_display_swapchain
	public partial class KhrDisplaySwapchain
	{
		// VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION
		public const int SPEC_VERSION = 9;
		// VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_display_swapchain";

		/// <summary>VkResult vkCreateSharedSwapchainsKHR (VkDevice device, uint32_t swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateSharedSwapchainsKHRDelegate (Device device, uint swapchainCount, SwapchainCreateInfoKHR* pCreateInfos, AllocationCallbacks* pAllocator, SwapchainKHR* pSwapchains);

		/// <summary>VkResult vkCreateSharedSwapchainsKHR (VkDevice device, uint32_t swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)</summary>
		public readonly CreateSharedSwapchainsKHRDelegate CreateSharedSwapchainsKHR;

		public unsafe KhrDisplaySwapchain (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,83,104,97,114,101,100,83,119,97,112,99,104,97,105,110,115,75,72,82,0, // vkCreateSharedSwapchainsKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateSharedSwapchainsKHR);
			}
		}
	}
	// VK_KHR_mir_surface
	public partial class KhrMirSurface
	{
		// VK_KHR_MIR_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 4;
		// VK_KHR_MIR_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_mir_surface";

		/// <summary>VkResult vkCreateMirSurfaceKHR (VkInstance instance, VkMirSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateMirSurfaceKHRDelegate (Instance instance, ref MirSurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkBool32 vkGetPhysicalDeviceMirPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, MirConnection* connection)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Boolean32 GetPhysicalDeviceMirPresentationSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection);

		/// <summary>VkResult vkCreateMirSurfaceKHR (VkInstance instance, VkMirSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateMirSurfaceKHRDelegate CreateMirSurfaceKHR;
		/// <summary>VkBool32 vkGetPhysicalDeviceMirPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, MirConnection* connection)</summary>
		public readonly GetPhysicalDeviceMirPresentationSupportKHRDelegate GetPhysicalDeviceMirPresentationSupportKHR;

		public unsafe KhrMirSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,77,105,114,83,117,114,102,97,99,101,75,72,82,0, // vkCreateMirSurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,77,105,114,80,114,101,115,101,110,116,97,116,105,111,110,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceMirPresentationSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateMirSurfaceKHR);
				resolver.LoadHandle(p + 22, out GetPhysicalDeviceMirPresentationSupportKHR);
			}
		}
	}
	// VK_KHR_sampler_mirror_clamp_to_edge
	public partial class KhrSamplerMirrorClampToEdge
	{
		// VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_sampler_mirror_clamp_to_edge";
		// VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE
		public const int VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = 4;
	}
	// VK_KHR_surface
	public partial class KhrSurface
	{
		// VK_KHR_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 25;
		// VK_KHR_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_surface";
		// VK_COLORSPACE_SRGB_NONLINEAR_KHR
		public const int VK_COLORSPACE_SRGB_NONLINEAR_KHR = 0;

		/// <summary>void vkDestroySurfaceKHR (VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroySurfaceKHRDelegate (Instance instance, SurfaceKHR surface, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate (PhysicalDevice physicalDevice, SurfaceKHR surface, out SurfaceCapabilitiesKHR pSurfaceCapabilities);
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceFormatsKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceSurfaceFormatsKHRDelegate (PhysicalDevice physicalDevice, SurfaceKHR surface, uint* pSurfaceFormatCount, SurfaceFormatKHR* pSurfaceFormats);
		/// <summary>VkResult vkGetPhysicalDeviceSurfacePresentModesKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceSurfacePresentModesKHRDelegate (PhysicalDevice physicalDevice, SurfaceKHR surface, uint* pPresentModeCount, PresentModeKHR* pPresentModes);
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceSurfaceSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex, SurfaceKHR surface, out Boolean32 pSupported);

		/// <summary>void vkDestroySurfaceKHR (VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroySurfaceKHRDelegate DestroySurfaceKHR;
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)</summary>
		public readonly GetPhysicalDeviceSurfaceCapabilitiesKHRDelegate GetPhysicalDeviceSurfaceCapabilitiesKHR;
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceFormatsKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)</summary>
		public readonly GetPhysicalDeviceSurfaceFormatsKHRDelegate GetPhysicalDeviceSurfaceFormatsKHR;
		/// <summary>VkResult vkGetPhysicalDeviceSurfacePresentModesKHR (VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint32_t* pPresentModeCount, VkPresentModeKHR* pPresentModes)</summary>
		public readonly GetPhysicalDeviceSurfacePresentModesKHRDelegate GetPhysicalDeviceSurfacePresentModesKHR;
		/// <summary>VkResult vkGetPhysicalDeviceSurfaceSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)</summary>
		public readonly GetPhysicalDeviceSurfaceSupportKHRDelegate GetPhysicalDeviceSurfaceSupportKHR;

		public unsafe KhrSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,68,101,115,116,114,111,121,83,117,114,102,97,99,101,75,72,82,0, // vkDestroySurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,83,117,114,102,97,99,101,67,97,112,97,98,105,108,105,116,105,101,115,75,72,82,0, // vkGetPhysicalDeviceSurfaceCapabilitiesKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,83,117,114,102,97,99,101,70,111,114,109,97,116,115,75,72,82,0, // vkGetPhysicalDeviceSurfaceFormatsKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,83,117,114,102,97,99,101,80,114,101,115,101,110,116,77,111,100,101,115,75,72,82,0, // vkGetPhysicalDeviceSurfacePresentModesKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,83,117,114,102,97,99,101,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceSurfaceSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out DestroySurfaceKHR);
				resolver.LoadHandle(p + 20, out GetPhysicalDeviceSurfaceCapabilitiesKHR);
				resolver.LoadHandle(p + 62, out GetPhysicalDeviceSurfaceFormatsKHR);
				resolver.LoadHandle(p + 99, out GetPhysicalDeviceSurfacePresentModesKHR);
				resolver.LoadHandle(p + 141, out GetPhysicalDeviceSurfaceSupportKHR);
			}
		}
	}
	// VK_KHR_swapchain
	public partial class KhrSwapchain
	{
		// VK_KHR_SWAPCHAIN_SPEC_VERSION
		public const int SPEC_VERSION = 68;
		// VK_KHR_SWAPCHAIN_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_swapchain";

		/// <summary>VkResult vkAcquireNextImageKHR (VkDevice device, VkSwapchainKHR swapchain, uint64_t timeout, VkSemaphore semaphore, VkFence fence, uint32_t* pImageIndex)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result AcquireNextImageKHRDelegate (Device device, SwapchainKHR swapchain, ulong timeout, Semaphore semaphore, Fence fence, out uint pImageIndex);
		/// <summary>VkResult vkCreateSwapchainKHR (VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateSwapchainKHRDelegate (Device device, ref SwapchainCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SwapchainKHR pSwapchain);
		/// <summary>void vkDestroySwapchainKHR (VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroySwapchainKHRDelegate (Device device, SwapchainKHR swapchain, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>VkResult vkGetSwapchainImagesKHR (VkDevice device, VkSwapchainKHR swapchain, uint32_t* pSwapchainImageCount, VkImage* pSwapchainImages)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetSwapchainImagesKHRDelegate (Device device, SwapchainKHR swapchain, uint* pSwapchainImageCount, Image* pSwapchainImages);
		/// <summary>VkResult vkQueuePresentKHR (VkQueue queue, VkPresentInfoKHR* pPresentInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result QueuePresentKHRDelegate (Queue queue, ref PresentInfoKHR pPresentInfo);

		/// <summary>VkResult vkAcquireNextImageKHR (VkDevice device, VkSwapchainKHR swapchain, uint64_t timeout, VkSemaphore semaphore, VkFence fence, uint32_t* pImageIndex)</summary>
		public readonly AcquireNextImageKHRDelegate AcquireNextImageKHR;
		/// <summary>VkResult vkCreateSwapchainKHR (VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)</summary>
		public readonly CreateSwapchainKHRDelegate CreateSwapchainKHR;
		/// <summary>void vkDestroySwapchainKHR (VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroySwapchainKHRDelegate DestroySwapchainKHR;
		/// <summary>VkResult vkGetSwapchainImagesKHR (VkDevice device, VkSwapchainKHR swapchain, uint32_t* pSwapchainImageCount, VkImage* pSwapchainImages)</summary>
		public readonly GetSwapchainImagesKHRDelegate GetSwapchainImagesKHR;
		/// <summary>VkResult vkQueuePresentKHR (VkQueue queue, VkPresentInfoKHR* pPresentInfo)</summary>
		public readonly QueuePresentKHRDelegate QueuePresentKHR;

		public unsafe KhrSwapchain (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,65,99,113,117,105,114,101,78,101,120,116,73,109,97,103,101,75,72,82,0, // vkAcquireNextImageKHR
				118,107,67,114,101,97,116,101,83,119,97,112,99,104,97,105,110,75,72,82,0, // vkCreateSwapchainKHR
				118,107,68,101,115,116,114,111,121,83,119,97,112,99,104,97,105,110,75,72,82,0, // vkDestroySwapchainKHR
				118,107,71,101,116,83,119,97,112,99,104,97,105,110,73,109,97,103,101,115,75,72,82,0, // vkGetSwapchainImagesKHR
				118,107,81,117,101,117,101,80,114,101,115,101,110,116,75,72,82,0, // vkQueuePresentKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out AcquireNextImageKHR);
				resolver.LoadHandle(p + 22, out CreateSwapchainKHR);
				resolver.LoadHandle(p + 43, out DestroySwapchainKHR);
				resolver.LoadHandle(p + 65, out GetSwapchainImagesKHR);
				resolver.LoadHandle(p + 89, out QueuePresentKHR);
			}
		}
	}
	// VK_KHR_wayland_surface
	public partial class KhrWaylandSurface
	{
		// VK_KHR_WAYLAND_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 5;
		// VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_wayland_surface";

		/// <summary>VkResult vkCreateWaylandSurfaceKHR (VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateWaylandSurfaceKHRDelegate (Instance instance, ref WaylandSurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, wl_display* display)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Boolean32 GetPhysicalDeviceWaylandPresentationSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* display);

		/// <summary>VkResult vkCreateWaylandSurfaceKHR (VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateWaylandSurfaceKHRDelegate CreateWaylandSurfaceKHR;
		/// <summary>VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, wl_display* display)</summary>
		public readonly GetPhysicalDeviceWaylandPresentationSupportKHRDelegate GetPhysicalDeviceWaylandPresentationSupportKHR;

		public unsafe KhrWaylandSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,87,97,121,108,97,110,100,83,117,114,102,97,99,101,75,72,82,0, // vkCreateWaylandSurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,87,97,121,108,97,110,100,80,114,101,115,101,110,116,97,116,105,111,110,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceWaylandPresentationSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateWaylandSurfaceKHR);
				resolver.LoadHandle(p + 26, out GetPhysicalDeviceWaylandPresentationSupportKHR);
			}
		}
	}
	// VK_KHR_win32_surface
	public partial class KhrWin32Surface
	{
		// VK_KHR_WIN32_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 5;
		// VK_KHR_WIN32_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_win32_surface";

		/// <summary>VkResult vkCreateWin32SurfaceKHR (VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateWin32SurfaceKHRDelegate (Instance instance, ref Win32SurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Boolean32 GetPhysicalDeviceWin32PresentationSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex);

		/// <summary>VkResult vkCreateWin32SurfaceKHR (VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateWin32SurfaceKHRDelegate CreateWin32SurfaceKHR;
		/// <summary>VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex)</summary>
		public readonly GetPhysicalDeviceWin32PresentationSupportKHRDelegate GetPhysicalDeviceWin32PresentationSupportKHR;

		public unsafe KhrWin32Surface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,87,105,110,51,50,83,117,114,102,97,99,101,75,72,82,0, // vkCreateWin32SurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,87,105,110,51,50,80,114,101,115,101,110,116,97,116,105,111,110,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceWin32PresentationSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateWin32SurfaceKHR);
				resolver.LoadHandle(p + 24, out GetPhysicalDeviceWin32PresentationSupportKHR);
			}
		}
	}
	// VK_KHR_xcb_surface
	public partial class KhrXcbSurface
	{
		// VK_KHR_XCB_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 6;
		// VK_KHR_XCB_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_xcb_surface";

		/// <summary>VkResult vkCreateXcbSurfaceKHR (VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateXcbSurfaceKHRDelegate (Instance instance, ref XcbSurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, xcb_connection_t* connection, xcb_visualid_t visual_id)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Boolean32 GetPhysicalDeviceXcbPresentationSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection, IntPtr visual_id);

		/// <summary>VkResult vkCreateXcbSurfaceKHR (VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateXcbSurfaceKHRDelegate CreateXcbSurfaceKHR;
		/// <summary>VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, xcb_connection_t* connection, xcb_visualid_t visual_id)</summary>
		public readonly GetPhysicalDeviceXcbPresentationSupportKHRDelegate GetPhysicalDeviceXcbPresentationSupportKHR;

		public unsafe KhrXcbSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,88,99,98,83,117,114,102,97,99,101,75,72,82,0, // vkCreateXcbSurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,88,99,98,80,114,101,115,101,110,116,97,116,105,111,110,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceXcbPresentationSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateXcbSurfaceKHR);
				resolver.LoadHandle(p + 22, out GetPhysicalDeviceXcbPresentationSupportKHR);
			}
		}
	}
	// VK_KHR_xlib_surface
	public partial class KhrXlibSurface
	{
		// VK_KHR_XLIB_SURFACE_SPEC_VERSION
		public const int SPEC_VERSION = 6;
		// VK_KHR_XLIB_SURFACE_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_KHR_xlib_surface";

		/// <summary>VkResult vkCreateXlibSurfaceKHR (VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateXlibSurfaceKHRDelegate (Instance instance, ref XlibSurfaceCreateInfoKHR pCreateInfo, AllocationCallbacks* pAllocator, out SurfaceKHR pSurface);
		/// <summary>VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, Display* dpy, VisualID visualID)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Boolean32 GetPhysicalDeviceXlibPresentationSupportKHRDelegate (PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);

		/// <summary>VkResult vkCreateXlibSurfaceKHR (VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)</summary>
		public readonly CreateXlibSurfaceKHRDelegate CreateXlibSurfaceKHR;
		/// <summary>VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR (VkPhysicalDevice physicalDevice, uint32_t queueFamilyIndex, Display* dpy, VisualID visualID)</summary>
		public readonly GetPhysicalDeviceXlibPresentationSupportKHRDelegate GetPhysicalDeviceXlibPresentationSupportKHR;

		public unsafe KhrXlibSurface (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,114,101,97,116,101,88,108,105,98,83,117,114,102,97,99,101,75,72,82,0, // vkCreateXlibSurfaceKHR
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,88,108,105,98,80,114,101,115,101,110,116,97,116,105,111,110,83,117,112,112,111,114,116,75,72,82,0, // vkGetPhysicalDeviceXlibPresentationSupportKHR
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CreateXlibSurfaceKHR);
				resolver.LoadHandle(p + 23, out GetPhysicalDeviceXlibPresentationSupportKHR);
			}
		}
	}
	// VK_NV_dedicated_allocation
	public partial class NvDedicatedAllocation
	{
		// VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_dedicated_allocation";
	}
	// VK_NV_external_memory
	public partial class NvExternalMemory
	{
		// VK_NV_EXTERNAL_MEMORY_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_external_memory";
	}
	// VK_NV_external_memory_capabilities
	public partial class NvExternalMemoryCapabilities
	{
		// VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_external_memory_capabilities";

		/// <summary>VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate (PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlagBits usage, ImageCreateFlagBits flags, ExternalMemoryHandleTypeFlagBitsNV externalHandleType, ExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

		/// <summary>VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV (VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)</summary>
		public readonly GetPhysicalDeviceExternalImageFormatPropertiesNVDelegate GetPhysicalDeviceExternalImageFormatPropertiesNV;

		public unsafe NvExternalMemoryCapabilities (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,69,120,116,101,114,110,97,108,73,109,97,103,101,70,111,114,109,97,116,80,114,111,112,101,114,116,105,101,115,78,86,0, // vkGetPhysicalDeviceExternalImageFormatPropertiesNV
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out GetPhysicalDeviceExternalImageFormatPropertiesNV);
			}
		}
	}
	// VK_NV_external_memory_win32
	public partial class NvExternalMemoryWin32
	{
		// VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_external_memory_win32";

		/// <summary>VkResult vkGetMemoryWin32HandleNV (VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, HANDLE* pHandle)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result GetMemoryWin32HandleNVDelegate (Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle);

		/// <summary>VkResult vkGetMemoryWin32HandleNV (VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, HANDLE* pHandle)</summary>
		public readonly GetMemoryWin32HandleNVDelegate GetMemoryWin32HandleNV;

		public unsafe NvExternalMemoryWin32 (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,71,101,116,77,101,109,111,114,121,87,105,110,51,50,72,97,110,100,108,101,78,86,0, // vkGetMemoryWin32HandleNV
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out GetMemoryWin32HandleNV);
			}
		}
	}
	// VK_NV_glsl_shader
	public partial class NvGlslShader
	{
		// VK_NV_GLSL_SHADER_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_GLSL_SHADER_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_glsl_shader";
	}
	// VK_NV_win32_keyed_mutex
	public partial class NvWin32KeyedMutex
	{
		// VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NV_win32_keyed_mutex";
	}
	// VK_NVX_device_generated_commands
	public partial class NvxDeviceGeneratedCommands
	{
		// VK_NVX_DEVICE_GENERATED_COMMANDS_SPEC_VERSION
		public const int SPEC_VERSION = 1;
		// VK_NVX_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME
		public const string EXTENSION_NAME = "VK_NVX_device_generated_commands";

		/// <summary>void vkCmdProcessCommandsNVX (VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdProcessCommandsNVXDelegate (CommandBuffer commandBuffer, ref CmdProcessCommandsInfoNVX pProcessCommandsInfo);
		/// <summary>void vkCmdReserveSpaceForCommandsNVX (VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void CmdReserveSpaceForCommandsNVXDelegate (CommandBuffer commandBuffer, ref CmdReserveSpaceForCommandsInfoNVX pReserveSpaceInfo);
		/// <summary>VkResult vkCreateIndirectCommandsLayoutNVX (VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateIndirectCommandsLayoutNVXDelegate (Device device, ref IndirectCommandsLayoutCreateInfoNVX pCreateInfo, AllocationCallbacks* pAllocator, IndirectCommandsLayoutNVX* pIndirectCommandsLayout);
		/// <summary>VkResult vkCreateObjectTableNVX (VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result CreateObjectTableNVXDelegate (Device device, ref ObjectTableCreateInfoNVX pCreateInfo, AllocationCallbacks* pAllocator, ObjectTableNVX* pObjectTable);
		/// <summary>void vkDestroyIndirectCommandsLayoutNVX (VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyIndirectCommandsLayoutNVXDelegate (Device device, IndirectCommandsLayoutNVX indirectCommandsLayout, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkDestroyObjectTableNVX (VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void DestroyObjectTableNVXDelegate (Device device, ObjectTableNVX objectTable, AllocationCallbacks* pAllocator = default(AllocationCallbacks*));
		/// <summary>void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX (VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate void GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate (PhysicalDevice physicalDevice, out DeviceGeneratedCommandsFeaturesNVX pFeatures, DeviceGeneratedCommandsLimitsNVX* pLimits);
		/// <summary>VkResult vkRegisterObjectsNVX (VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectTableEntryNVX* ppObjectTableEntries, uint32_t* pObjectIndices)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result RegisterObjectsNVXDelegate (Device device, ObjectTableNVX objectTable, uint objectCount, ObjectTableEntryNVX* ppObjectTableEntries, uint* pObjectIndices);
		/// <summary>VkResult vkUnregisterObjectsNVX (VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint32_t* pObjectIndices)</summary>
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public unsafe delegate Result UnregisterObjectsNVXDelegate (Device device, ObjectTableNVX objectTable, uint objectCount, ObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices);

		/// <summary>void vkCmdProcessCommandsNVX (VkCommandBuffer commandBuffer, VkCmdProcessCommandsInfoNVX* pProcessCommandsInfo)</summary>
		public readonly CmdProcessCommandsNVXDelegate CmdProcessCommandsNVX;
		/// <summary>void vkCmdReserveSpaceForCommandsNVX (VkCommandBuffer commandBuffer, VkCmdReserveSpaceForCommandsInfoNVX* pReserveSpaceInfo)</summary>
		public readonly CmdReserveSpaceForCommandsNVXDelegate CmdReserveSpaceForCommandsNVX;
		/// <summary>VkResult vkCreateIndirectCommandsLayoutNVX (VkDevice device, VkIndirectCommandsLayoutCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNVX* pIndirectCommandsLayout)</summary>
		public readonly CreateIndirectCommandsLayoutNVXDelegate CreateIndirectCommandsLayoutNVX;
		/// <summary>VkResult vkCreateObjectTableNVX (VkDevice device, VkObjectTableCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkObjectTableNVX* pObjectTable)</summary>
		public readonly CreateObjectTableNVXDelegate CreateObjectTableNVX;
		/// <summary>void vkDestroyIndirectCommandsLayoutNVX (VkDevice device, VkIndirectCommandsLayoutNVX indirectCommandsLayout, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyIndirectCommandsLayoutNVXDelegate DestroyIndirectCommandsLayoutNVX;
		/// <summary>void vkDestroyObjectTableNVX (VkDevice device, VkObjectTableNVX objectTable, VkAllocationCallbacks* pAllocator)</summary>
		public readonly DestroyObjectTableNVXDelegate DestroyObjectTableNVX;
		/// <summary>void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX (VkPhysicalDevice physicalDevice, VkDeviceGeneratedCommandsFeaturesNVX* pFeatures, VkDeviceGeneratedCommandsLimitsNVX* pLimits)</summary>
		public readonly GetPhysicalDeviceGeneratedCommandsPropertiesNVXDelegate GetPhysicalDeviceGeneratedCommandsPropertiesNVX;
		/// <summary>VkResult vkRegisterObjectsNVX (VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectTableEntryNVX* ppObjectTableEntries, uint32_t* pObjectIndices)</summary>
		public readonly RegisterObjectsNVXDelegate RegisterObjectsNVX;
		/// <summary>VkResult vkUnregisterObjectsNVX (VkDevice device, VkObjectTableNVX objectTable, uint32_t objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint32_t* pObjectIndices)</summary>
		public readonly UnregisterObjectsNVXDelegate UnregisterObjectsNVX;

		public unsafe NvxDeviceGeneratedCommands (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			byte[] buffer = new byte[] {
				118,107,67,109,100,80,114,111,99,101,115,115,67,111,109,109,97,110,100,115,78,86,88,0, // vkCmdProcessCommandsNVX
				118,107,67,109,100,82,101,115,101,114,118,101,83,112,97,99,101,70,111,114,67,111,109,109,97,110,100,115,78,86,88,0, // vkCmdReserveSpaceForCommandsNVX
				118,107,67,114,101,97,116,101,73,110,100,105,114,101,99,116,67,111,109,109,97,110,100,115,76,97,121,111,117,116,78,86,88,0, // vkCreateIndirectCommandsLayoutNVX
				118,107,67,114,101,97,116,101,79,98,106,101,99,116,84,97,98,108,101,78,86,88,0, // vkCreateObjectTableNVX
				118,107,68,101,115,116,114,111,121,73,110,100,105,114,101,99,116,67,111,109,109,97,110,100,115,76,97,121,111,117,116,78,86,88,0, // vkDestroyIndirectCommandsLayoutNVX
				118,107,68,101,115,116,114,111,121,79,98,106,101,99,116,84,97,98,108,101,78,86,88,0, // vkDestroyObjectTableNVX
				118,107,71,101,116,80,104,121,115,105,99,97,108,68,101,118,105,99,101,71,101,110,101,114,97,116,101,100,67,111,109,109,97,110,100,115,80,114,111,112,101,114,116,105,101,115,78,86,88,0, // vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX
				118,107,82,101,103,105,115,116,101,114,79,98,106,101,99,116,115,78,86,88,0, // vkRegisterObjectsNVX
				118,107,85,110,114,101,103,105,115,116,101,114,79,98,106,101,99,116,115,78,86,88,0, // vkUnregisterObjectsNVX
			};
			fixed(byte* pBuffer = buffer)
			{
				IntPtr p = (IntPtr)pBuffer;
				resolver.LoadHandle(p, out CmdProcessCommandsNVX);
				resolver.LoadHandle(p + 24, out CmdReserveSpaceForCommandsNVX);
				resolver.LoadHandle(p + 56, out CreateIndirectCommandsLayoutNVX);
				resolver.LoadHandle(p + 90, out CreateObjectTableNVX);
				resolver.LoadHandle(p + 113, out DestroyIndirectCommandsLayoutNVX);
				resolver.LoadHandle(p + 148, out DestroyObjectTableNVX);
				resolver.LoadHandle(p + 172, out GetPhysicalDeviceGeneratedCommandsPropertiesNVX);
				resolver.LoadHandle(p + 222, out RegisterObjectsNVX);
				resolver.LoadHandle(p + 243, out UnregisterObjectsNVX);
			}
		}
	}
}

