using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class IntelFramebufferCmaa
		{
			public const string NAME_STRING = "GL_INTEL_framebuffer_CMAA";
			#region command delegates
			// void glApplyFramebufferAttachmentCMAAINTEL ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ApplyFramebufferAttachmentCMAADelegate ();
			#endregion // command delegates
			#region commands
			// void glApplyFramebufferAttachmentCMAAINTEL ()
			public readonly ApplyFramebufferAttachmentCMAADelegate ApplyFramebufferAttachmentCMAA;
			#endregion // commands
			public IntelFramebufferCmaa (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glApplyFramebufferAttachmentCMAAINTEL", out ApplyFramebufferAttachmentCMAA);
			}
		}
		public partial class IntelMapTexture
		{
			public enum All
			{
				// GL_LAYOUT_DEFAULT_INTEL = 0x0
				LayoutDefault = unchecked((int)0),
				// GL_LAYOUT_LINEAR_INTEL = 0x1
				LayoutLinear = unchecked((int)1),
				// GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 0x2
				LayoutLinearCpuCached = unchecked((int)2),
				// GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF
				TextureMemoryLayout = unchecked((int)33791),
			}
			public const string NAME_STRING = "GL_INTEL_map_texture";
			#region command delegates
			// void* glMapTexture2DINTEL (GLuint texture, GLint level, GLbitfield access, GLint* stride, GLenum* layout)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr MapTexture2DDelegate (System.UInt32 texture, System.Int32 level, System.UInt32 access, IntPtr stride, IntPtr layout);
			// void glSyncTextureINTEL (GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SyncTextureDelegate (System.UInt32 texture);
			// void glUnmapTexture2DINTEL (GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UnmapTexture2DDelegate (System.UInt32 texture, System.Int32 level);
			#endregion // command delegates
			#region commands
			// void* glMapTexture2DINTEL (GLuint texture, GLint level, GLbitfield access, GLint* stride, GLenum* layout)
			public readonly MapTexture2DDelegate MapTexture2D;
			// void glSyncTextureINTEL (GLuint texture)
			public readonly SyncTextureDelegate SyncTexture;
			// void glUnmapTexture2DINTEL (GLuint texture, GLint level)
			public readonly UnmapTexture2DDelegate UnmapTexture2D;
			#endregion // commands
			public IntelMapTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMapTexture2DINTEL", out MapTexture2D);
				resolver.LoadHandle ("glSyncTextureINTEL", out SyncTexture);
				resolver.LoadHandle ("glUnmapTexture2DINTEL", out UnmapTexture2D);
			}
		}
		public partial class IntelParallelArrays
		{
			public enum All
			{
				// GL_PARALLEL_ARRAYS_INTEL = 0x83F4
				ParallelArrays = unchecked((int)33780),
				// GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5
				VertexArrayParallelPointers = unchecked((int)33781),
				// GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6
				NormalArrayParallelPointers = unchecked((int)33782),
				// GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7
				ColorArrayParallelPointers = unchecked((int)33783),
				// GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8
				TextureCoordArrayParallelPointers = unchecked((int)33784),
			}
			public const string NAME_STRING = "GL_INTEL_parallel_arrays";
			#region command delegates
			// void glColorPointervINTEL (GLint size, GLenum type, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorPointervDelegate (System.Int32 size, VertexPointerType type, IntPtr pointer);
			// void glNormalPointervINTEL (GLenum type, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalPointervDelegate (NormalPointerType type, IntPtr pointer);
			// void glTexCoordPointervINTEL (GLint size, GLenum type, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoordPointervDelegate (System.Int32 size, VertexPointerType type, IntPtr pointer);
			// void glVertexPointervINTEL (GLint size, GLenum type, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexPointervDelegate (System.Int32 size, VertexPointerType type, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glColorPointervINTEL (GLint size, GLenum type, void** pointer)
			public readonly ColorPointervDelegate ColorPointerv;
			// void glNormalPointervINTEL (GLenum type, void** pointer)
			public readonly NormalPointervDelegate NormalPointerv;
			// void glTexCoordPointervINTEL (GLint size, GLenum type, void** pointer)
			public readonly TexCoordPointervDelegate TexCoordPointerv;
			// void glVertexPointervINTEL (GLint size, GLenum type, void** pointer)
			public readonly VertexPointervDelegate VertexPointerv;
			#endregion // commands
			public IntelParallelArrays (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorPointervINTEL", out ColorPointerv);
				resolver.LoadHandle ("glNormalPointervINTEL", out NormalPointerv);
				resolver.LoadHandle ("glTexCoordPointervINTEL", out TexCoordPointerv);
				resolver.LoadHandle ("glVertexPointervINTEL", out VertexPointerv);
			}
		}
		public partial class IntelPerformanceQuery
		{
			public enum All
			{
				// GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x0
				PerfquerySingleContext = unchecked((int)0),
				// GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x1
				PerfqueryGlobalContext = unchecked((int)1),
				// GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9
				PerfqueryDonotFlush = unchecked((int)33785),
				// GL_PERFQUERY_FLUSH_INTEL = 0x83FA
				PerfqueryFlush = unchecked((int)33786),
				// GL_PERFQUERY_WAIT_INTEL = 0x83FB
				PerfqueryWait = unchecked((int)33787),
				// GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0
				PerfqueryCounterEvent = unchecked((int)38128),
				// GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1
				PerfqueryCounterDurationNorm = unchecked((int)38129),
				// GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2
				PerfqueryCounterDurationRaw = unchecked((int)38130),
				// GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3
				PerfqueryCounterThroughput = unchecked((int)38131),
				// GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4
				PerfqueryCounterRaw = unchecked((int)38132),
				// GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5
				PerfqueryCounterTimestamp = unchecked((int)38133),
				// GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8
				PerfqueryCounterDataUint32 = unchecked((int)38136),
				// GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9
				PerfqueryCounterDataUint64 = unchecked((int)38137),
				// GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA
				PerfqueryCounterDataFloat = unchecked((int)38138),
				// GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB
				PerfqueryCounterDataDouble = unchecked((int)38139),
				// GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC
				PerfqueryCounterDataBool32 = unchecked((int)38140),
				// GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD
				PerfqueryQueryNameLengthMax = unchecked((int)38141),
				// GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE
				PerfqueryCounterNameLengthMax = unchecked((int)38142),
				// GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF
				PerfqueryCounterDescLengthMax = unchecked((int)38143),
				// GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500
				PerfqueryGpaExtendedCounters = unchecked((int)38144),
			}
			public const string NAME_STRING = "GL_INTEL_performance_query";
			#region command delegates
			// void glBeginPerfQueryINTEL (GLuint queryHandle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginPerfQueryDelegate (System.UInt32 queryHandle);
			// void glCreatePerfQueryINTEL (GLuint queryId, GLuint* queryHandle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CreatePerfQueryDelegate (System.UInt32 queryId, IntPtr queryHandle);
			// void glDeletePerfQueryINTEL (GLuint queryHandle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeletePerfQueryDelegate (System.UInt32 queryHandle);
			// void glEndPerfQueryINTEL (GLuint queryHandle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndPerfQueryDelegate (System.UInt32 queryHandle);
			// void glGetFirstPerfQueryIdINTEL (GLuint* queryId)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFirstPerfQueryIdDelegate (IntPtr queryId);
			// void glGetNextPerfQueryIdINTEL (GLuint queryId, GLuint* nextQueryId)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNextPerfQueryIdDelegate (System.UInt32 queryId, IntPtr nextQueryId);
			// void glGetPerfCounterInfoINTEL (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar* counterName, GLuint counterDescLength, GLchar* counterDesc, GLuint* counterOffset, GLuint* counterDataSize, GLuint* counterTypeEnum, GLuint* counterDataTypeEnum, GLuint64* rawCounterMaxValue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfCounterInfoDelegate (System.UInt32 queryId, System.UInt32 counterId, System.UInt32 counterNameLength, IntPtr counterName, System.UInt32 counterDescLength, IntPtr counterDesc, IntPtr counterOffset, IntPtr counterDataSize, IntPtr counterTypeEnum, IntPtr counterDataTypeEnum, IntPtr rawCounterMaxValue);
			// void glGetPerfQueryDataINTEL (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid* data, GLuint* bytesWritten)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfQueryDataDelegate (System.UInt32 queryHandle, System.UInt32 flags, System.Int32 dataSize, IntPtr data, IntPtr bytesWritten);
			// void glGetPerfQueryIdByNameINTEL (GLchar* queryName, GLuint* queryId)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfQueryIdByNameDelegate (IntPtr queryName, IntPtr queryId);
			// void glGetPerfQueryInfoINTEL (GLuint queryId, GLuint queryNameLength, GLchar* queryName, GLuint* dataSize, GLuint* noCounters, GLuint* noInstances, GLuint* capsMask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfQueryInfoDelegate (System.UInt32 queryId, System.UInt32 queryNameLength, IntPtr queryName, IntPtr dataSize, IntPtr noCounters, IntPtr noInstances, IntPtr capsMask);
			#endregion // command delegates
			#region commands
			// void glBeginPerfQueryINTEL (GLuint queryHandle)
			public readonly BeginPerfQueryDelegate BeginPerfQuery;
			// void glCreatePerfQueryINTEL (GLuint queryId, GLuint* queryHandle)
			public readonly CreatePerfQueryDelegate CreatePerfQuery;
			// void glDeletePerfQueryINTEL (GLuint queryHandle)
			public readonly DeletePerfQueryDelegate DeletePerfQuery;
			// void glEndPerfQueryINTEL (GLuint queryHandle)
			public readonly EndPerfQueryDelegate EndPerfQuery;
			// void glGetFirstPerfQueryIdINTEL (GLuint* queryId)
			public readonly GetFirstPerfQueryIdDelegate GetFirstPerfQueryId;
			// void glGetNextPerfQueryIdINTEL (GLuint queryId, GLuint* nextQueryId)
			public readonly GetNextPerfQueryIdDelegate GetNextPerfQueryId;
			// void glGetPerfCounterInfoINTEL (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar* counterName, GLuint counterDescLength, GLchar* counterDesc, GLuint* counterOffset, GLuint* counterDataSize, GLuint* counterTypeEnum, GLuint* counterDataTypeEnum, GLuint64* rawCounterMaxValue)
			public readonly GetPerfCounterInfoDelegate GetPerfCounterInfo;
			// void glGetPerfQueryDataINTEL (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid* data, GLuint* bytesWritten)
			public readonly GetPerfQueryDataDelegate GetPerfQueryData;
			// void glGetPerfQueryIdByNameINTEL (GLchar* queryName, GLuint* queryId)
			public readonly GetPerfQueryIdByNameDelegate GetPerfQueryIdByName;
			// void glGetPerfQueryInfoINTEL (GLuint queryId, GLuint queryNameLength, GLchar* queryName, GLuint* dataSize, GLuint* noCounters, GLuint* noInstances, GLuint* capsMask)
			public readonly GetPerfQueryInfoDelegate GetPerfQueryInfo;
			#endregion // commands
			public IntelPerformanceQuery (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginPerfQueryINTEL", out BeginPerfQuery);
				resolver.LoadHandle ("glCreatePerfQueryINTEL", out CreatePerfQuery);
				resolver.LoadHandle ("glDeletePerfQueryINTEL", out DeletePerfQuery);
				resolver.LoadHandle ("glEndPerfQueryINTEL", out EndPerfQuery);
				resolver.LoadHandle ("glGetFirstPerfQueryIdINTEL", out GetFirstPerfQueryId);
				resolver.LoadHandle ("glGetNextPerfQueryIdINTEL", out GetNextPerfQueryId);
				resolver.LoadHandle ("glGetPerfCounterInfoINTEL", out GetPerfCounterInfo);
				resolver.LoadHandle ("glGetPerfQueryDataINTEL", out GetPerfQueryData);
				resolver.LoadHandle ("glGetPerfQueryIdByNameINTEL", out GetPerfQueryIdByName);
				resolver.LoadHandle ("glGetPerfQueryInfoINTEL", out GetPerfQueryInfo);
			}
		}
	}
}

