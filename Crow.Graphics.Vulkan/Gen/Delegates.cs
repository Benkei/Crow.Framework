using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Crow.Graphics.Vulkan
{
	/// <summary>void* PFN_vkAllocationFunction (void* pUserData, size_t size, size_t alignment, VkSystemAllocationScope allocationScope)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate IntPtr AllocationFunctionCallback (IntPtr pUserData, int size, int alignment, SystemAllocationScope allocationScope);
	/// <summary>VkBool32 PFN_vkDebugReportCallbackEXT (VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, uint64_t object, size_t location, int32_t messageCode, char* pLayerPrefix, char* pMessage, void* pUserData)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate Boolean32 DebugReportCallbackEXTCallback (DebugReportFlagBitsEXT flags, DebugReportObjectTypeEXT objectType, ulong @object, int location, int messageCode, byte* pLayerPrefix, byte* pMessage, IntPtr pUserData);
	/// <summary>void PFN_vkFreeFunction (void* pUserData, void* pMemory)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate void FreeFunctionCallback (IntPtr pUserData, IntPtr pMemory);
	/// <summary>void PFN_vkInternalAllocationNotification (void* pUserData, size_t size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate void InternalAllocationNotificationCallback (IntPtr pUserData, int size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);
	/// <summary>void PFN_vkInternalFreeNotification (void* pUserData, size_t size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate void InternalFreeNotificationCallback (IntPtr pUserData, int size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);
	/// <summary>void* PFN_vkReallocationFunction (void* pUserData, void* pOriginal, size_t size, size_t alignment, VkSystemAllocationScope allocationScope)</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate IntPtr ReallocationFunctionCallback (IntPtr pUserData, IntPtr pOriginal, int size, int alignment, SystemAllocationScope allocationScope);
	/// <summary>void PFN_vkVoidFunction ()</summary>
	[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public unsafe delegate void VoidFunctionCallback ();
}

