using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Wgl
	{
		public partial class NvCopyImage
		{
			public const string NAME_STRING = "WGL_NV_copy_image";
			#region command delegates
			// BOOL wglCopyImageSubDataNV (HGLRC hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, HGLRC hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean CopyImageSubDataDelegate (System.IntPtr hSrcRC, System.UInt32 srcName, System.UInt32 srcTarget, System.Int32 srcLevel, System.Int32 srcX, System.Int32 srcY, System.Int32 srcZ, System.IntPtr hDstRC, System.UInt32 dstName, System.UInt32 dstTarget, System.Int32 dstLevel, System.Int32 dstX, System.Int32 dstY, System.Int32 dstZ, System.Int32 width, System.Int32 height, System.Int32 depth);
			#endregion // command delegates
			#region commands
			// BOOL wglCopyImageSubDataNV (HGLRC hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, HGLRC hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
			public readonly CopyImageSubDataDelegate CopyImageSubData;
			#endregion // commands
			public NvCopyImage (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCopyImageSubDataNV", out CopyImageSubData);
			}
		}
		public partial class NvDelayBeforeSwap
		{
			public const string NAME_STRING = "WGL_NV_delay_before_swap";
			#region command delegates
			// BOOL wglDelayBeforeSwapNV (HDC hDC, GLfloat seconds)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DelayBeforeSwapDelegate (System.IntPtr hDC, System.Single seconds);
			#endregion // command delegates
			#region commands
			// BOOL wglDelayBeforeSwapNV (HDC hDC, GLfloat seconds)
			public readonly DelayBeforeSwapDelegate DelayBeforeSwap;
			#endregion // commands
			public NvDelayBeforeSwap (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglDelayBeforeSwapNV", out DelayBeforeSwap);
			}
		}
		public partial class NvDxInterop
		{
			public enum All
			{
				// WGL_ACCESS_READ_ONLY_NV = 0x0
				AccessReadOnly = unchecked((int)0),
				// WGL_ACCESS_READ_WRITE_NV = 0x1
				AccessReadWrite = unchecked((int)1),
				// WGL_ACCESS_WRITE_DISCARD_NV = 0x2
				AccessWriteDiscard = unchecked((int)2),
			}
			public const string NAME_STRING = "WGL_NV_DX_interop";
			#region command delegates
			// BOOL wglDXCloseDeviceNV (HANDLE hDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXCloseDeviceDelegate (System.IntPtr hDevice);
			// BOOL wglDXLockObjectsNV (HANDLE hDevice, GLint count, HANDLE* hObjects)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXLockObjectsDelegate (System.IntPtr hDevice, System.Int32 count, IntPtr hObjects);
			// BOOL wglDXObjectAccessNV (HANDLE hObject, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXObjectAccessDelegate (System.IntPtr hObject, System.UInt32 access);
			// HANDLE wglDXOpenDeviceNV (void* dxDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr DXOpenDeviceDelegate (IntPtr dxDevice);
			// HANDLE wglDXRegisterObjectNV (HANDLE hDevice, void* dxObject, GLuint name, GLenum type, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr DXRegisterObjectDelegate (System.IntPtr hDevice, IntPtr dxObject, System.UInt32 name, System.UInt32 type, System.UInt32 access);
			// BOOL wglDXSetResourceShareHandleNV (void* dxObject, HANDLE shareHandle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXSetResourceShareHandleDelegate (IntPtr dxObject, System.IntPtr shareHandle);
			// BOOL wglDXUnlockObjectsNV (HANDLE hDevice, GLint count, HANDLE* hObjects)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXUnlockObjectsDelegate (System.IntPtr hDevice, System.Int32 count, IntPtr hObjects);
			// BOOL wglDXUnregisterObjectNV (HANDLE hDevice, HANDLE hObject)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DXUnregisterObjectDelegate (System.IntPtr hDevice, System.IntPtr hObject);
			#endregion // command delegates
			#region commands
			// BOOL wglDXCloseDeviceNV (HANDLE hDevice)
			public readonly DXCloseDeviceDelegate DXCloseDevice;
			// BOOL wglDXLockObjectsNV (HANDLE hDevice, GLint count, HANDLE* hObjects)
			public readonly DXLockObjectsDelegate DXLockObjects;
			// BOOL wglDXObjectAccessNV (HANDLE hObject, GLenum access)
			public readonly DXObjectAccessDelegate DXObjectAccess;
			// HANDLE wglDXOpenDeviceNV (void* dxDevice)
			public readonly DXOpenDeviceDelegate DXOpenDevice;
			// HANDLE wglDXRegisterObjectNV (HANDLE hDevice, void* dxObject, GLuint name, GLenum type, GLenum access)
			public readonly DXRegisterObjectDelegate DXRegisterObject;
			// BOOL wglDXSetResourceShareHandleNV (void* dxObject, HANDLE shareHandle)
			public readonly DXSetResourceShareHandleDelegate DXSetResourceShareHandle;
			// BOOL wglDXUnlockObjectsNV (HANDLE hDevice, GLint count, HANDLE* hObjects)
			public readonly DXUnlockObjectsDelegate DXUnlockObjects;
			// BOOL wglDXUnregisterObjectNV (HANDLE hDevice, HANDLE hObject)
			public readonly DXUnregisterObjectDelegate DXUnregisterObject;
			#endregion // commands
			public NvDxInterop (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglDXCloseDeviceNV", out DXCloseDevice);
				resolver.LoadHandle ("wglDXLockObjectsNV", out DXLockObjects);
				resolver.LoadHandle ("wglDXObjectAccessNV", out DXObjectAccess);
				resolver.LoadHandle ("wglDXOpenDeviceNV", out DXOpenDevice);
				resolver.LoadHandle ("wglDXRegisterObjectNV", out DXRegisterObject);
				resolver.LoadHandle ("wglDXSetResourceShareHandleNV", out DXSetResourceShareHandle);
				resolver.LoadHandle ("wglDXUnlockObjectsNV", out DXUnlockObjects);
				resolver.LoadHandle ("wglDXUnregisterObjectNV", out DXUnregisterObject);
			}
		}
		public partial class NvFloatBuffer
		{
			public enum All
			{
				// WGL_FLOAT_COMPONENTS_NV = 0x20B0
				FloatComponents = unchecked((int)8368),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = 0x20B1
				BindToTextureRectangleFloatR = unchecked((int)8369),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = 0x20B2
				BindToTextureRectangleFloatRg = unchecked((int)8370),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = 0x20B3
				BindToTextureRectangleFloatRgb = unchecked((int)8371),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = 0x20B4
				BindToTextureRectangleFloatRgba = unchecked((int)8372),
				// WGL_TEXTURE_FLOAT_R_NV = 0x20B5
				TextureFloatR = unchecked((int)8373),
				// WGL_TEXTURE_FLOAT_RG_NV = 0x20B6
				TextureFloatRg = unchecked((int)8374),
				// WGL_TEXTURE_FLOAT_RGB_NV = 0x20B7
				TextureFloatRgb = unchecked((int)8375),
				// WGL_TEXTURE_FLOAT_RGBA_NV = 0x20B8
				TextureFloatRgba = unchecked((int)8376),
			}
			public const string NAME_STRING = "WGL_NV_float_buffer";
		}
		public partial class NvGpuAffinity
		{
			public enum All
			{
				// ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV = 0x20D0
				ErrorIncompatibleAffinityMasks = unchecked((int)8400),
				// ERROR_MISSING_AFFINITY_MASK_NV = 0x20D1
				ErrorMissingAffinityMask = unchecked((int)8401),
			}
			public const string NAME_STRING = "WGL_NV_gpu_affinity";
			#region command delegates
			// HDC wglCreateAffinityDCNV (HGPUNV* phGpuList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateAffinityDCDelegate (IntPtr phGpuList);
			// BOOL wglDeleteDCNV (HDC hdc)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean DeleteDCDelegate (System.IntPtr hdc);
			// BOOL wglEnumGpuDevicesNV (HGPUNV hGpu, UINT iDeviceIndex, PGPU_DEVICE lpGpuDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EnumGpuDevicesDelegate (System.IntPtr hGpu, System.UInt32 iDeviceIndex, System.IntPtr lpGpuDevice);
			// BOOL wglEnumGpusFromAffinityDCNV (HDC hAffinityDC, UINT iGpuIndex, HGPUNV* hGpu)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EnumGpusFromAffinityDCDelegate (System.IntPtr hAffinityDC, System.UInt32 iGpuIndex, IntPtr hGpu);
			// BOOL wglEnumGpusNV (UINT iGpuIndex, HGPUNV* phGpu)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean EnumGpusDelegate (System.UInt32 iGpuIndex, IntPtr phGpu);
			#endregion // command delegates
			#region commands
			// HDC wglCreateAffinityDCNV (HGPUNV* phGpuList)
			public readonly CreateAffinityDCDelegate CreateAffinityDC;
			// BOOL wglDeleteDCNV (HDC hdc)
			public readonly DeleteDCDelegate DeleteDC;
			// BOOL wglEnumGpuDevicesNV (HGPUNV hGpu, UINT iDeviceIndex, PGPU_DEVICE lpGpuDevice)
			public readonly EnumGpuDevicesDelegate EnumGpuDevices;
			// BOOL wglEnumGpusFromAffinityDCNV (HDC hAffinityDC, UINT iGpuIndex, HGPUNV* hGpu)
			public readonly EnumGpusFromAffinityDCDelegate EnumGpusFromAffinityDC;
			// BOOL wglEnumGpusNV (UINT iGpuIndex, HGPUNV* phGpu)
			public readonly EnumGpusDelegate EnumGpus;
			#endregion // commands
			public NvGpuAffinity (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglCreateAffinityDCNV", out CreateAffinityDC);
				resolver.LoadHandle ("wglDeleteDCNV", out DeleteDC);
				resolver.LoadHandle ("wglEnumGpuDevicesNV", out EnumGpuDevices);
				resolver.LoadHandle ("wglEnumGpusFromAffinityDCNV", out EnumGpusFromAffinityDC);
				resolver.LoadHandle ("wglEnumGpusNV", out EnumGpus);
			}
		}
		public partial class NvMultisampleCoverage
		{
			public enum All
			{
				// WGL_COVERAGE_SAMPLES_NV = 0x2042
				CoverageSamples = unchecked((int)8258),
				// WGL_COLOR_SAMPLES_NV = 0x20B9
				ColorSamples = unchecked((int)8377),
			}
			public const string NAME_STRING = "WGL_NV_multisample_coverage";
		}
		public partial class NvPresentVideo
		{
			public enum All
			{
				// WGL_NUM_VIDEO_SLOTS_NV = 0x20F0
				NumVideoSlots = unchecked((int)8432),
			}
			public const string NAME_STRING = "WGL_NV_present_video";
			#region command delegates
			// BOOL wglBindVideoDeviceNV (HDC hDC, unsigned int uVideoSlot, HVIDEOOUTPUTDEVICENV hVideoDevice, int* piAttribList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindVideoDeviceDelegate (System.IntPtr hDC, System.UInt32 uVideoSlot, System.IntPtr hVideoDevice, IntPtr piAttribList);
			// int wglEnumerateVideoDevicesNV (HDC hDC, HVIDEOOUTPUTDEVICENV* phDeviceList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 EnumerateVideoDevicesDelegate (System.IntPtr hDC, IntPtr phDeviceList);
			// BOOL wglQueryCurrentContextNV (int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryCurrentContextDelegate (System.Int32 iAttribute, IntPtr piValue);
			#endregion // command delegates
			#region commands
			// BOOL wglBindVideoDeviceNV (HDC hDC, unsigned int uVideoSlot, HVIDEOOUTPUTDEVICENV hVideoDevice, int* piAttribList)
			public readonly BindVideoDeviceDelegate BindVideoDevice;
			// int wglEnumerateVideoDevicesNV (HDC hDC, HVIDEOOUTPUTDEVICENV* phDeviceList)
			public readonly EnumerateVideoDevicesDelegate EnumerateVideoDevices;
			// BOOL wglQueryCurrentContextNV (int iAttribute, int* piValue)
			public readonly QueryCurrentContextDelegate QueryCurrentContext;
			#endregion // commands
			public NvPresentVideo (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindVideoDeviceNV", out BindVideoDevice);
				resolver.LoadHandle ("wglEnumerateVideoDevicesNV", out EnumerateVideoDevices);
				resolver.LoadHandle ("wglQueryCurrentContextNV", out QueryCurrentContext);
			}
		}
		public partial class NvRenderDepthTexture
		{
			public enum All
			{
				// WGL_BIND_TO_TEXTURE_DEPTH_NV = 0x20A3
				BindToTextureDepth = unchecked((int)8355),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = 0x20A4
				BindToTextureRectangleDepth = unchecked((int)8356),
				// WGL_DEPTH_TEXTURE_FORMAT_NV = 0x20A5
				DepthTextureFormat = unchecked((int)8357),
				// WGL_TEXTURE_DEPTH_COMPONENT_NV = 0x20A6
				TextureDepthComponent = unchecked((int)8358),
				// WGL_DEPTH_COMPONENT_NV = 0x20A7
				DepthComponent = unchecked((int)8359),
			}
			public const string NAME_STRING = "WGL_NV_render_depth_texture";
		}
		public partial class NvRenderTextureRectangle
		{
			public enum All
			{
				// WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV = 0x20A0
				BindToTextureRectangleRgb = unchecked((int)8352),
				// WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = 0x20A1
				BindToTextureRectangleRgba = unchecked((int)8353),
				// WGL_TEXTURE_RECTANGLE_NV = 0x20A2
				TextureRectangle = unchecked((int)8354),
			}
			public const string NAME_STRING = "WGL_NV_render_texture_rectangle";
		}
		public partial class NvSwapGroup
		{
			public const string NAME_STRING = "WGL_NV_swap_group";
			#region command delegates
			// BOOL wglBindSwapBarrierNV (GLuint group, GLuint barrier)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindSwapBarrierDelegate (System.UInt32 group, System.UInt32 barrier);
			// BOOL wglJoinSwapGroupNV (HDC hDC, GLuint group)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean JoinSwapGroupDelegate (System.IntPtr hDC, System.UInt32 group);
			// BOOL wglQueryFrameCountNV (HDC hDC, GLuint* count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryFrameCountDelegate (System.IntPtr hDC, IntPtr count);
			// BOOL wglQueryMaxSwapGroupsNV (HDC hDC, GLuint* maxGroups, GLuint* maxBarriers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryMaxSwapGroupsDelegate (System.IntPtr hDC, IntPtr maxGroups, IntPtr maxBarriers);
			// BOOL wglQuerySwapGroupNV (HDC hDC, GLuint* group, GLuint* barrier)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QuerySwapGroupDelegate (System.IntPtr hDC, IntPtr group, IntPtr barrier);
			// BOOL wglResetFrameCountNV (HDC hDC)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ResetFrameCountDelegate (System.IntPtr hDC);
			#endregion // command delegates
			#region commands
			// BOOL wglBindSwapBarrierNV (GLuint group, GLuint barrier)
			public readonly BindSwapBarrierDelegate BindSwapBarrier;
			// BOOL wglJoinSwapGroupNV (HDC hDC, GLuint group)
			public readonly JoinSwapGroupDelegate JoinSwapGroup;
			// BOOL wglQueryFrameCountNV (HDC hDC, GLuint* count)
			public readonly QueryFrameCountDelegate QueryFrameCount;
			// BOOL wglQueryMaxSwapGroupsNV (HDC hDC, GLuint* maxGroups, GLuint* maxBarriers)
			public readonly QueryMaxSwapGroupsDelegate QueryMaxSwapGroups;
			// BOOL wglQuerySwapGroupNV (HDC hDC, GLuint* group, GLuint* barrier)
			public readonly QuerySwapGroupDelegate QuerySwapGroup;
			// BOOL wglResetFrameCountNV (HDC hDC)
			public readonly ResetFrameCountDelegate ResetFrameCount;
			#endregion // commands
			public NvSwapGroup (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindSwapBarrierNV", out BindSwapBarrier);
				resolver.LoadHandle ("wglJoinSwapGroupNV", out JoinSwapGroup);
				resolver.LoadHandle ("wglQueryFrameCountNV", out QueryFrameCount);
				resolver.LoadHandle ("wglQueryMaxSwapGroupsNV", out QueryMaxSwapGroups);
				resolver.LoadHandle ("wglQuerySwapGroupNV", out QuerySwapGroup);
				resolver.LoadHandle ("wglResetFrameCountNV", out ResetFrameCount);
			}
		}
		public partial class NvVertexArrayRange
		{
			public const string NAME_STRING = "WGL_NV_vertex_array_range";
			#region command delegates
			// void* wglAllocateMemoryNV (GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr AllocateMemoryDelegate (System.Int32 size, System.Single readfreq, System.Single writefreq, System.Single priority);
			// void wglFreeMemoryNV (void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FreeMemoryDelegate (IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void* wglAllocateMemoryNV (GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority)
			public readonly AllocateMemoryDelegate AllocateMemory;
			// void wglFreeMemoryNV (void* pointer)
			public readonly FreeMemoryDelegate FreeMemory;
			#endregion // commands
			public NvVertexArrayRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglAllocateMemoryNV", out AllocateMemory);
				resolver.LoadHandle ("wglFreeMemoryNV", out FreeMemory);
			}
		}
		public partial class NvVideoCapture
		{
			public enum All
			{
				// WGL_UNIQUE_ID_NV = 0x20CE
				UniqueId = unchecked((int)8398),
				// WGL_NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF
				NumVideoCaptureSlots = unchecked((int)8399),
			}
			public const string NAME_STRING = "WGL_NV_video_capture";
			#region command delegates
			// BOOL wglBindVideoCaptureDeviceNV (UINT uVideoSlot, HVIDEOINPUTDEVICENV hDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindVideoCaptureDeviceDelegate (System.UInt32 uVideoSlot, System.IntPtr hDevice);
			// UINT wglEnumerateVideoCaptureDevicesNV (HDC hDc, HVIDEOINPUTDEVICENV* phDeviceList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 EnumerateVideoCaptureDevicesDelegate (System.IntPtr hDc, IntPtr phDeviceList);
			// BOOL wglLockVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean LockVideoCaptureDeviceDelegate (System.IntPtr hDc, System.IntPtr hDevice);
			// BOOL wglQueryVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice, int iAttribute, int* piValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean QueryVideoCaptureDeviceDelegate (System.IntPtr hDc, System.IntPtr hDevice, System.Int32 iAttribute, IntPtr piValue);
			// BOOL wglReleaseVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ReleaseVideoCaptureDeviceDelegate (System.IntPtr hDc, System.IntPtr hDevice);
			#endregion // command delegates
			#region commands
			// BOOL wglBindVideoCaptureDeviceNV (UINT uVideoSlot, HVIDEOINPUTDEVICENV hDevice)
			public readonly BindVideoCaptureDeviceDelegate BindVideoCaptureDevice;
			// UINT wglEnumerateVideoCaptureDevicesNV (HDC hDc, HVIDEOINPUTDEVICENV* phDeviceList)
			public readonly EnumerateVideoCaptureDevicesDelegate EnumerateVideoCaptureDevices;
			// BOOL wglLockVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice)
			public readonly LockVideoCaptureDeviceDelegate LockVideoCaptureDevice;
			// BOOL wglQueryVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice, int iAttribute, int* piValue)
			public readonly QueryVideoCaptureDeviceDelegate QueryVideoCaptureDevice;
			// BOOL wglReleaseVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice)
			public readonly ReleaseVideoCaptureDeviceDelegate ReleaseVideoCaptureDevice;
			#endregion // commands
			public NvVideoCapture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindVideoCaptureDeviceNV", out BindVideoCaptureDevice);
				resolver.LoadHandle ("wglEnumerateVideoCaptureDevicesNV", out EnumerateVideoCaptureDevices);
				resolver.LoadHandle ("wglLockVideoCaptureDeviceNV", out LockVideoCaptureDevice);
				resolver.LoadHandle ("wglQueryVideoCaptureDeviceNV", out QueryVideoCaptureDevice);
				resolver.LoadHandle ("wglReleaseVideoCaptureDeviceNV", out ReleaseVideoCaptureDevice);
			}
		}
		public partial class NvVideoOutput
		{
			public enum All
			{
				// WGL_BIND_TO_VIDEO_RGB_NV = 0x20C0
				BindToVideoRgb = unchecked((int)8384),
				// WGL_BIND_TO_VIDEO_RGBA_NV = 0x20C1
				BindToVideoRgba = unchecked((int)8385),
				// WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV = 0x20C2
				BindToVideoRgbAndDepth = unchecked((int)8386),
				// WGL_VIDEO_OUT_COLOR_NV = 0x20C3
				VideoOutColor = unchecked((int)8387),
				// WGL_VIDEO_OUT_ALPHA_NV = 0x20C4
				VideoOutAlpha = unchecked((int)8388),
				// WGL_VIDEO_OUT_DEPTH_NV = 0x20C5
				VideoOutDepth = unchecked((int)8389),
				// WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV = 0x20C6
				VideoOutColorAndAlpha = unchecked((int)8390),
				// WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV = 0x20C7
				VideoOutColorAndDepth = unchecked((int)8391),
				// WGL_VIDEO_OUT_FRAME = 0x20C8
				VideoOutFrame = unchecked((int)8392),
				// WGL_VIDEO_OUT_FIELD_1 = 0x20C9
				VideoOutField1 = unchecked((int)8393),
				// WGL_VIDEO_OUT_FIELD_2 = 0x20CA
				VideoOutField2 = unchecked((int)8394),
				// WGL_VIDEO_OUT_STACKED_FIELDS_1_2 = 0x20CB
				VideoOutStackedFields12 = unchecked((int)8395),
				// WGL_VIDEO_OUT_STACKED_FIELDS_2_1 = 0x20CC
				VideoOutStackedFields21 = unchecked((int)8396),
			}
			public const string NAME_STRING = "WGL_NV_video_output";
			#region command delegates
			// BOOL wglBindVideoImageNV (HPVIDEODEV hVideoDevice, HPBUFFERARB hPbuffer, int iVideoBuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean BindVideoImageDelegate (System.IntPtr hVideoDevice, System.IntPtr hPbuffer, System.Int32 iVideoBuffer);
			// BOOL wglGetVideoDeviceNV (HDC hDC, int numDevices, HPVIDEODEV* hVideoDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetVideoDeviceDelegate (System.IntPtr hDC, System.Int32 numDevices, IntPtr hVideoDevice);
			// BOOL wglGetVideoInfoNV (HPVIDEODEV hpVideoDevice, void* pulCounterOutputPbuffer, void* pulCounterOutputVideo)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean GetVideoInfoDelegate (System.IntPtr hpVideoDevice, IntPtr pulCounterOutputPbuffer, IntPtr pulCounterOutputVideo);
			// BOOL wglReleaseVideoDeviceNV (HPVIDEODEV hVideoDevice)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ReleaseVideoDeviceDelegate (System.IntPtr hVideoDevice);
			// BOOL wglReleaseVideoImageNV (HPBUFFERARB hPbuffer, int iVideoBuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean ReleaseVideoImageDelegate (System.IntPtr hPbuffer, System.Int32 iVideoBuffer);
			// BOOL wglSendPbufferToVideoNV (HPBUFFERARB hPbuffer, int iBufferType, void* pulCounterPbuffer, BOOL bBlock)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean SendPbufferToVideoDelegate (System.IntPtr hPbuffer, System.Int32 iBufferType, IntPtr pulCounterPbuffer, System.Boolean bBlock);
			#endregion // command delegates
			#region commands
			// BOOL wglBindVideoImageNV (HPVIDEODEV hVideoDevice, HPBUFFERARB hPbuffer, int iVideoBuffer)
			public readonly BindVideoImageDelegate BindVideoImage;
			// BOOL wglGetVideoDeviceNV (HDC hDC, int numDevices, HPVIDEODEV* hVideoDevice)
			public readonly GetVideoDeviceDelegate GetVideoDevice;
			// BOOL wglGetVideoInfoNV (HPVIDEODEV hpVideoDevice, void* pulCounterOutputPbuffer, void* pulCounterOutputVideo)
			public readonly GetVideoInfoDelegate GetVideoInfo;
			// BOOL wglReleaseVideoDeviceNV (HPVIDEODEV hVideoDevice)
			public readonly ReleaseVideoDeviceDelegate ReleaseVideoDevice;
			// BOOL wglReleaseVideoImageNV (HPBUFFERARB hPbuffer, int iVideoBuffer)
			public readonly ReleaseVideoImageDelegate ReleaseVideoImage;
			// BOOL wglSendPbufferToVideoNV (HPBUFFERARB hPbuffer, int iBufferType, void* pulCounterPbuffer, BOOL bBlock)
			public readonly SendPbufferToVideoDelegate SendPbufferToVideo;
			#endregion // commands
			public NvVideoOutput (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("wglBindVideoImageNV", out BindVideoImage);
				resolver.LoadHandle ("wglGetVideoDeviceNV", out GetVideoDevice);
				resolver.LoadHandle ("wglGetVideoInfoNV", out GetVideoInfo);
				resolver.LoadHandle ("wglReleaseVideoDeviceNV", out ReleaseVideoDevice);
				resolver.LoadHandle ("wglReleaseVideoImageNV", out ReleaseVideoImage);
				resolver.LoadHandle ("wglSendPbufferToVideoNV", out SendPbufferToVideo);
			}
		}
	}
}

