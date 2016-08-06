using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class ArbBindlessTexture
		{
			public enum All
			{
				// GL_UNSIGNED_INT64_ARB = 0x140F
				UnsignedInt64 = unchecked((int)5135),
			}
			public const string NAME_STRING = "GL_ARB_bindless_texture";
			#region command delegates
			// GLuint64 glGetImageHandleARB (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetImageHandleDelegate (System.UInt32 texture, System.Int32 level, System.Boolean layered, System.Int32 layer, System.UInt32 format);
			// GLuint64 glGetTextureHandleARB (GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetTextureHandleDelegate (System.UInt32 texture);
			// GLuint64 glGetTextureSamplerHandleARB (GLuint texture, GLuint sampler)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetTextureSamplerHandleDelegate (System.UInt32 texture, System.UInt32 sampler);
			// void glGetVertexAttribLui64vARB (GLuint index, GLenum pname, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribLui64vDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsImageHandleResidentARB (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsImageHandleResidentDelegate (System.UInt64 handle);
			// GLboolean glIsTextureHandleResidentARB (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsTextureHandleResidentDelegate (System.UInt64 handle);
			// void glMakeImageHandleNonResidentARB (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeImageHandleNonResidentDelegate (System.UInt64 handle);
			// void glMakeImageHandleResidentARB (GLuint64 handle, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeImageHandleResidentDelegate (System.UInt64 handle, System.UInt32 access);
			// void glMakeTextureHandleNonResidentARB (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeTextureHandleNonResidentDelegate (System.UInt64 handle);
			// void glMakeTextureHandleResidentARB (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeTextureHandleResidentDelegate (System.UInt64 handle);
			// void glProgramUniformHandleui64ARB (GLuint program, GLint location, GLuint64 value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformHandleui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 value);
			// void glProgramUniformHandleui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformHandleui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr values);
			// void glUniformHandleui64ARB (GLint location, GLuint64 value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformHandleui64Delegate (System.Int32 location, System.UInt64 value);
			// void glUniformHandleui64vARB (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformHandleui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glVertexAttribL1ui64ARB (GLuint index, GLuint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1ui64Delegate (System.UInt32 index, System.UInt64 x);
			// void glVertexAttribL1ui64vARB (GLuint index, GLuint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1ui64vDelegate (System.UInt32 index, IntPtr v);
			#endregion // command delegates
			#region commands
			// GLuint64 glGetImageHandleARB (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
			public readonly GetImageHandleDelegate GetImageHandle;
			// GLuint64 glGetTextureHandleARB (GLuint texture)
			public readonly GetTextureHandleDelegate GetTextureHandle;
			// GLuint64 glGetTextureSamplerHandleARB (GLuint texture, GLuint sampler)
			public readonly GetTextureSamplerHandleDelegate GetTextureSamplerHandle;
			// void glGetVertexAttribLui64vARB (GLuint index, GLenum pname, GLuint64EXT* params)
			public readonly GetVertexAttribLui64vDelegate GetVertexAttribLui64v;
			// GLboolean glIsImageHandleResidentARB (GLuint64 handle)
			public readonly IsImageHandleResidentDelegate IsImageHandleResident;
			// GLboolean glIsTextureHandleResidentARB (GLuint64 handle)
			public readonly IsTextureHandleResidentDelegate IsTextureHandleResident;
			// void glMakeImageHandleNonResidentARB (GLuint64 handle)
			public readonly MakeImageHandleNonResidentDelegate MakeImageHandleNonResident;
			// void glMakeImageHandleResidentARB (GLuint64 handle, GLenum access)
			public readonly MakeImageHandleResidentDelegate MakeImageHandleResident;
			// void glMakeTextureHandleNonResidentARB (GLuint64 handle)
			public readonly MakeTextureHandleNonResidentDelegate MakeTextureHandleNonResident;
			// void glMakeTextureHandleResidentARB (GLuint64 handle)
			public readonly MakeTextureHandleResidentDelegate MakeTextureHandleResident;
			// void glProgramUniformHandleui64ARB (GLuint program, GLint location, GLuint64 value)
			public readonly ProgramUniformHandleui64Delegate ProgramUniformHandleui64;
			// void glProgramUniformHandleui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* values)
			public readonly ProgramUniformHandleui64vDelegate ProgramUniformHandleui64v;
			// void glUniformHandleui64ARB (GLint location, GLuint64 value)
			public readonly UniformHandleui64Delegate UniformHandleui64;
			// void glUniformHandleui64vARB (GLint location, GLsizei count, GLuint64* value)
			public readonly UniformHandleui64vDelegate UniformHandleui64v;
			// void glVertexAttribL1ui64ARB (GLuint index, GLuint64EXT x)
			public readonly VertexAttribL1ui64Delegate VertexAttribL1ui64;
			// void glVertexAttribL1ui64vARB (GLuint index, GLuint64EXT* v)
			public readonly VertexAttribL1ui64vDelegate VertexAttribL1ui64v;
			#endregion // commands
			public ArbBindlessTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetImageHandleARB", out GetImageHandle);
				resolver.LoadHandle ("glGetTextureHandleARB", out GetTextureHandle);
				resolver.LoadHandle ("glGetTextureSamplerHandleARB", out GetTextureSamplerHandle);
				resolver.LoadHandle ("glGetVertexAttribLui64vARB", out GetVertexAttribLui64v);
				resolver.LoadHandle ("glIsImageHandleResidentARB", out IsImageHandleResident);
				resolver.LoadHandle ("glIsTextureHandleResidentARB", out IsTextureHandleResident);
				resolver.LoadHandle ("glMakeImageHandleNonResidentARB", out MakeImageHandleNonResident);
				resolver.LoadHandle ("glMakeImageHandleResidentARB", out MakeImageHandleResident);
				resolver.LoadHandle ("glMakeTextureHandleNonResidentARB", out MakeTextureHandleNonResident);
				resolver.LoadHandle ("glMakeTextureHandleResidentARB", out MakeTextureHandleResident);
				resolver.LoadHandle ("glProgramUniformHandleui64ARB", out ProgramUniformHandleui64);
				resolver.LoadHandle ("glProgramUniformHandleui64vARB", out ProgramUniformHandleui64v);
				resolver.LoadHandle ("glUniformHandleui64ARB", out UniformHandleui64);
				resolver.LoadHandle ("glUniformHandleui64vARB", out UniformHandleui64v);
				resolver.LoadHandle ("glVertexAttribL1ui64ARB", out VertexAttribL1ui64);
				resolver.LoadHandle ("glVertexAttribL1ui64vARB", out VertexAttribL1ui64v);
			}
		}
		public partial class ArbClEvent
		{
			public enum All
			{
				// GL_SYNC_CL_EVENT_ARB = 0x8240
				SyncClEvent = unchecked((int)33344),
				// GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241
				SyncClEventComplete = unchecked((int)33345),
			}
			public const string NAME_STRING = "GL_ARB_cl_event";
			#region command delegates
			// GLsync glCreateSyncFromCLeventARB (struct _cl_context* context, struct _cl_event* event, GLbitfield flags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateSyncFromCLeventDelegate (IntPtr context, IntPtr @event, System.UInt32 flags);
			#endregion // command delegates
			#region commands
			// GLsync glCreateSyncFromCLeventARB (struct _cl_context* context, struct _cl_event* event, GLbitfield flags)
			public readonly CreateSyncFromCLeventDelegate CreateSyncFromCLevent;
			#endregion // commands
			public ArbClEvent (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCreateSyncFromCLeventARB", out CreateSyncFromCLevent);
			}
		}
		public partial class ArbColorBufferFloat
		{
			public enum All
			{
				// GL_RGBA_FLOAT_MODE_ARB = 0x8820
				RgbaFloatMode = unchecked((int)34848),
				// GL_CLAMP_VERTEX_COLOR_ARB = 0x891A
				ClampVertexColor = unchecked((int)35098),
				// GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B
				ClampFragmentColor = unchecked((int)35099),
				// GL_CLAMP_READ_COLOR_ARB = 0x891C
				ClampReadColor = unchecked((int)35100),
				// GL_FIXED_ONLY_ARB = 0x891D
				FixedOnly = unchecked((int)35101),
			}
			public const string NAME_STRING = "GL_ARB_color_buffer_float";
			#region command delegates
			// void glClampColorARB (GLenum target, GLenum clamp)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClampColorDelegate (System.UInt32 target, System.UInt32 clamp);
			#endregion // command delegates
			#region commands
			// void glClampColorARB (GLenum target, GLenum clamp)
			public readonly ClampColorDelegate ClampColor;
			#endregion // commands
			public ArbColorBufferFloat (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glClampColorARB", out ClampColor);
			}
		}
		public partial class ArbComputeVariableGroupSize
		{
			public enum All
			{
				// GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB
				MaxComputeFixedGroupInvocations = unchecked((int)37099),
				// GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF
				MaxComputeFixedGroupSize = unchecked((int)37311),
				// GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344
				MaxComputeVariableGroupInvocations = unchecked((int)37700),
				// GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345
				MaxComputeVariableGroupSize = unchecked((int)37701),
			}
			public const string NAME_STRING = "GL_ARB_compute_variable_group_size";
			#region command delegates
			// void glDispatchComputeGroupSizeARB (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DispatchComputeGroupSizeDelegate (System.UInt32 num_groups_x, System.UInt32 num_groups_y, System.UInt32 num_groups_z, System.UInt32 group_size_x, System.UInt32 group_size_y, System.UInt32 group_size_z);
			#endregion // command delegates
			#region commands
			// void glDispatchComputeGroupSizeARB (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z)
			public readonly DispatchComputeGroupSizeDelegate DispatchComputeGroupSize;
			#endregion // commands
			public ArbComputeVariableGroupSize (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDispatchComputeGroupSizeARB", out DispatchComputeGroupSize);
			}
		}
		public partial class ArbDebugOutput
		{
			public enum All
			{
				// GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242
				DebugOutputSynchronous = unchecked((int)33346),
				// GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243
				DebugNextLoggedMessageLength = unchecked((int)33347),
				// GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244
				DebugCallbackFunction = unchecked((int)33348),
				// GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245
				DebugCallbackUserParam = unchecked((int)33349),
				// GL_DEBUG_SOURCE_API_ARB = 0x8246
				DebugSourceApi = unchecked((int)33350),
				// GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247
				DebugSourceWindowSystem = unchecked((int)33351),
				// GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248
				DebugSourceShaderCompiler = unchecked((int)33352),
				// GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249
				DebugSourceThirdParty = unchecked((int)33353),
				// GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A
				DebugSourceApplication = unchecked((int)33354),
				// GL_DEBUG_SOURCE_OTHER_ARB = 0x824B
				DebugSourceOther = unchecked((int)33355),
				// GL_DEBUG_TYPE_ERROR_ARB = 0x824C
				DebugTypeError = unchecked((int)33356),
				// GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D
				DebugTypeDeprecatedBehavior = unchecked((int)33357),
				// GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E
				DebugTypeUndefinedBehavior = unchecked((int)33358),
				// GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F
				DebugTypePortability = unchecked((int)33359),
				// GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250
				DebugTypePerformance = unchecked((int)33360),
				// GL_DEBUG_TYPE_OTHER_ARB = 0x8251
				DebugTypeOther = unchecked((int)33361),
				// GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143
				MaxDebugMessageLength = unchecked((int)37187),
				// GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144
				MaxDebugLoggedMessages = unchecked((int)37188),
				// GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145
				DebugLoggedMessages = unchecked((int)37189),
				// GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146
				DebugSeverityHigh = unchecked((int)37190),
				// GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147
				DebugSeverityMedium = unchecked((int)37191),
				// GL_DEBUG_SEVERITY_LOW_ARB = 0x9148
				DebugSeverityLow = unchecked((int)37192),
			}
			public const string NAME_STRING = "GL_ARB_debug_output";
			#region command delegates
			// void glDebugMessageCallbackARB (GLDEBUGPROCARB callback, void* userParam)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageCallbackDelegate (System.IntPtr callback, IntPtr userParam);
			// void glDebugMessageControlARB (GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageControlDelegate (System.UInt32 source, System.UInt32 type, System.UInt32 severity, System.Int32 count, IntPtr ids, Boolean enabled);
			// void glDebugMessageInsertARB (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageInsertDelegate (System.UInt32 source, System.UInt32 type, System.UInt32 id, System.UInt32 severity, System.Int32 length, IntPtr buf);
			// GLuint glGetDebugMessageLogARB (GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetDebugMessageLogDelegate (System.UInt32 count, System.Int32 bufSize, IntPtr sources, IntPtr types, IntPtr ids, IntPtr severities, IntPtr lengths, IntPtr messageLog);
			#endregion // command delegates
			#region commands
			// void glDebugMessageCallbackARB (GLDEBUGPROCARB callback, void* userParam)
			public readonly DebugMessageCallbackDelegate DebugMessageCallback;
			// void glDebugMessageControlARB (GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
			public readonly DebugMessageControlDelegate DebugMessageControl;
			// void glDebugMessageInsertARB (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf)
			public readonly DebugMessageInsertDelegate DebugMessageInsert;
			// GLuint glGetDebugMessageLogARB (GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog)
			public readonly GetDebugMessageLogDelegate GetDebugMessageLog;
			#endregion // commands
			public ArbDebugOutput (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDebugMessageCallbackARB", out DebugMessageCallback);
				resolver.LoadHandle ("glDebugMessageControlARB", out DebugMessageControl);
				resolver.LoadHandle ("glDebugMessageInsertARB", out DebugMessageInsert);
				resolver.LoadHandle ("glGetDebugMessageLogARB", out GetDebugMessageLog);
			}
		}
		public partial class ArbDepthTexture
		{
			public enum All
			{
				// GL_DEPTH_COMPONENT16_ARB = 0x81A5
				DepthComponent16 = unchecked((int)33189),
				// GL_DEPTH_COMPONENT24_ARB = 0x81A6
				DepthComponent24 = unchecked((int)33190),
				// GL_DEPTH_COMPONENT32_ARB = 0x81A7
				DepthComponent32 = unchecked((int)33191),
				// GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A
				TextureDepthSize = unchecked((int)34890),
				// GL_DEPTH_TEXTURE_MODE_ARB = 0x884B
				DepthTextureMode = unchecked((int)34891),
			}
			public const string NAME_STRING = "GL_ARB_depth_texture";
		}
		public partial class ArbDrawBuffers
		{
			public enum All
			{
				// GL_MAX_DRAW_BUFFERS_ARB = 0x8824
				MaxDrawBuffers = unchecked((int)34852),
				// GL_DRAW_BUFFER0_ARB = 0x8825
				DrawBuffer0 = unchecked((int)34853),
				// GL_DRAW_BUFFER1_ARB = 0x8826
				DrawBuffer1 = unchecked((int)34854),
				// GL_DRAW_BUFFER2_ARB = 0x8827
				DrawBuffer2 = unchecked((int)34855),
				// GL_DRAW_BUFFER3_ARB = 0x8828
				DrawBuffer3 = unchecked((int)34856),
				// GL_DRAW_BUFFER4_ARB = 0x8829
				DrawBuffer4 = unchecked((int)34857),
				// GL_DRAW_BUFFER5_ARB = 0x882A
				DrawBuffer5 = unchecked((int)34858),
				// GL_DRAW_BUFFER6_ARB = 0x882B
				DrawBuffer6 = unchecked((int)34859),
				// GL_DRAW_BUFFER7_ARB = 0x882C
				DrawBuffer7 = unchecked((int)34860),
				// GL_DRAW_BUFFER8_ARB = 0x882D
				DrawBuffer8 = unchecked((int)34861),
				// GL_DRAW_BUFFER9_ARB = 0x882E
				DrawBuffer9 = unchecked((int)34862),
				// GL_DRAW_BUFFER10_ARB = 0x882F
				DrawBuffer10 = unchecked((int)34863),
				// GL_DRAW_BUFFER11_ARB = 0x8830
				DrawBuffer11 = unchecked((int)34864),
				// GL_DRAW_BUFFER12_ARB = 0x8831
				DrawBuffer12 = unchecked((int)34865),
				// GL_DRAW_BUFFER13_ARB = 0x8832
				DrawBuffer13 = unchecked((int)34866),
				// GL_DRAW_BUFFER14_ARB = 0x8833
				DrawBuffer14 = unchecked((int)34867),
				// GL_DRAW_BUFFER15_ARB = 0x8834
				DrawBuffer15 = unchecked((int)34868),
			}
			public const string NAME_STRING = "GL_ARB_draw_buffers";
			#region command delegates
			// void glDrawBuffersARB (GLsizei n, GLenum* bufs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawBuffersDelegate (System.Int32 n, IntPtr bufs);
			#endregion // command delegates
			#region commands
			// void glDrawBuffersARB (GLsizei n, GLenum* bufs)
			public readonly DrawBuffersDelegate DrawBuffers;
			#endregion // commands
			public ArbDrawBuffers (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawBuffersARB", out DrawBuffers);
			}
		}
		public partial class ArbDrawBuffersBlend
		{
			public const string NAME_STRING = "GL_ARB_draw_buffers_blend";
			#region command delegates
			// void glBlendEquationiARB (GLuint buf, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationiDelegate (System.UInt32 buf, System.UInt32 mode);
			// void glBlendEquationSeparateiARB (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationSeparateiDelegate (System.UInt32 buf, System.UInt32 modeRGB, System.UInt32 modeAlpha);
			// void glBlendFunciARB (GLuint buf, GLenum src, GLenum dst)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFunciDelegate (System.UInt32 buf, System.UInt32 src, System.UInt32 dst);
			// void glBlendFuncSeparateiARB (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFuncSeparateiDelegate (System.UInt32 buf, System.UInt32 srcRGB, System.UInt32 dstRGB, System.UInt32 srcAlpha, System.UInt32 dstAlpha);
			#endregion // command delegates
			#region commands
			// void glBlendEquationiARB (GLuint buf, GLenum mode)
			public readonly BlendEquationiDelegate BlendEquationi;
			// void glBlendEquationSeparateiARB (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
			public readonly BlendEquationSeparateiDelegate BlendEquationSeparatei;
			// void glBlendFunciARB (GLuint buf, GLenum src, GLenum dst)
			public readonly BlendFunciDelegate BlendFunci;
			// void glBlendFuncSeparateiARB (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
			public readonly BlendFuncSeparateiDelegate BlendFuncSeparatei;
			#endregion // commands
			public ArbDrawBuffersBlend (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendEquationiARB", out BlendEquationi);
				resolver.LoadHandle ("glBlendEquationSeparateiARB", out BlendEquationSeparatei);
				resolver.LoadHandle ("glBlendFunciARB", out BlendFunci);
				resolver.LoadHandle ("glBlendFuncSeparateiARB", out BlendFuncSeparatei);
			}
		}
		public partial class ArbDrawInstanced
		{
			public const string NAME_STRING = "GL_ARB_draw_instanced";
			#region command delegates
			// void glDrawArraysInstancedARB (GLenum mode, GLint first, GLsizei count, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawArraysInstancedDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count, System.Int32 primcount);
			// void glDrawElementsInstancedARB (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawElementsInstancedDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 primcount);
			#endregion // command delegates
			#region commands
			// void glDrawArraysInstancedARB (GLenum mode, GLint first, GLsizei count, GLsizei primcount)
			public readonly DrawArraysInstancedDelegate DrawArraysInstanced;
			// void glDrawElementsInstancedARB (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount)
			public readonly DrawElementsInstancedDelegate DrawElementsInstanced;
			#endregion // commands
			public ArbDrawInstanced (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawArraysInstancedARB", out DrawArraysInstanced);
				resolver.LoadHandle ("glDrawElementsInstancedARB", out DrawElementsInstanced);
			}
		}
		public partial class ArbEs32Compatibility
		{
			public enum All
			{
				// GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE
				PrimitiveBoundingBox = unchecked((int)37566),
				// GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381
				MultisampleLineWidthRange = unchecked((int)37761),
				// GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382
				MultisampleLineWidthGranularity = unchecked((int)37762),
			}
			public const string NAME_STRING = "GL_ARB_ES3_2_compatibility";
			#region command delegates
			// void glPrimitiveBoundingBoxARB (GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PrimitiveBoundingBoxDelegate (System.Single minX, System.Single minY, System.Single minZ, System.Single minW, System.Single maxX, System.Single maxY, System.Single maxZ, System.Single maxW);
			#endregion // command delegates
			#region commands
			// void glPrimitiveBoundingBoxARB (GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW)
			public readonly PrimitiveBoundingBoxDelegate PrimitiveBoundingBox;
			#endregion // commands
			public ArbEs32Compatibility (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPrimitiveBoundingBoxARB", out PrimitiveBoundingBox);
			}
		}
		public partial class ArbFragmentProgram
		{
			public enum All
			{
				// GL_PROGRAM_LENGTH_ARB = 0x8627
				ProgramLength = unchecked((int)34343),
				// GL_PROGRAM_STRING_ARB = 0x8628
				ProgramString = unchecked((int)34344),
				// GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E
				MaxProgramMatrixStackDepth = unchecked((int)34350),
				// GL_MAX_PROGRAM_MATRICES_ARB = 0x862F
				MaxProgramMatrices = unchecked((int)34351),
				// GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640
				CurrentMatrixStackDepth = unchecked((int)34368),
				// GL_CURRENT_MATRIX_ARB = 0x8641
				CurrentMatrix = unchecked((int)34369),
				// GL_PROGRAM_ERROR_POSITION_ARB = 0x864B
				ProgramErrorPosition = unchecked((int)34379),
				// GL_PROGRAM_BINDING_ARB = 0x8677
				ProgramBinding = unchecked((int)34423),
				// GL_FRAGMENT_PROGRAM_ARB = 0x8804
				FragmentProgram = unchecked((int)34820),
				// GL_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805
				ProgramAluInstructions = unchecked((int)34821),
				// GL_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806
				ProgramTexInstructions = unchecked((int)34822),
				// GL_PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807
				ProgramTexIndirections = unchecked((int)34823),
				// GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808
				ProgramNativeAluInstructions = unchecked((int)34824),
				// GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809
				ProgramNativeTexInstructions = unchecked((int)34825),
				// GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A
				ProgramNativeTexIndirections = unchecked((int)34826),
				// GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B
				MaxProgramAluInstructions = unchecked((int)34827),
				// GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C
				MaxProgramTexInstructions = unchecked((int)34828),
				// GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D
				MaxProgramTexIndirections = unchecked((int)34829),
				// GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E
				MaxProgramNativeAluInstructions = unchecked((int)34830),
				// GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F
				MaxProgramNativeTexInstructions = unchecked((int)34831),
				// GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810
				MaxProgramNativeTexIndirections = unchecked((int)34832),
				// GL_MAX_TEXTURE_COORDS_ARB = 0x8871
				MaxTextureCoords = unchecked((int)34929),
				// GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872
				MaxTextureImageUnits = unchecked((int)34930),
				// GL_PROGRAM_ERROR_STRING_ARB = 0x8874
				ProgramErrorString = unchecked((int)34932),
				// GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875
				ProgramFormatAscii = unchecked((int)34933),
				// GL_PROGRAM_FORMAT_ARB = 0x8876
				ProgramFormat = unchecked((int)34934),
				// GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0
				ProgramInstructions = unchecked((int)34976),
				// GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1
				MaxProgramInstructions = unchecked((int)34977),
				// GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2
				ProgramNativeInstructions = unchecked((int)34978),
				// GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3
				MaxProgramNativeInstructions = unchecked((int)34979),
				// GL_PROGRAM_TEMPORARIES_ARB = 0x88A4
				ProgramTemporaries = unchecked((int)34980),
				// GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5
				MaxProgramTemporaries = unchecked((int)34981),
				// GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6
				ProgramNativeTemporaries = unchecked((int)34982),
				// GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7
				MaxProgramNativeTemporaries = unchecked((int)34983),
				// GL_PROGRAM_PARAMETERS_ARB = 0x88A8
				ProgramParameters = unchecked((int)34984),
				// GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9
				MaxProgramParameters = unchecked((int)34985),
				// GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA
				ProgramNativeParameters = unchecked((int)34986),
				// GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB
				MaxProgramNativeParameters = unchecked((int)34987),
				// GL_PROGRAM_ATTRIBS_ARB = 0x88AC
				ProgramAttribs = unchecked((int)34988),
				// GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD
				MaxProgramAttribs = unchecked((int)34989),
				// GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE
				ProgramNativeAttribs = unchecked((int)34990),
				// GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF
				MaxProgramNativeAttribs = unchecked((int)34991),
				// GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4
				MaxProgramLocalParameters = unchecked((int)34996),
				// GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5
				MaxProgramEnvParameters = unchecked((int)34997),
				// GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6
				ProgramUnderNativeLimits = unchecked((int)34998),
				// GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7
				TransposeCurrentMatrix = unchecked((int)34999),
				// GL_MATRIX0_ARB = 0x88C0
				Matrix0 = unchecked((int)35008),
				// GL_MATRIX1_ARB = 0x88C1
				Matrix1 = unchecked((int)35009),
				// GL_MATRIX2_ARB = 0x88C2
				Matrix2 = unchecked((int)35010),
				// GL_MATRIX3_ARB = 0x88C3
				Matrix3 = unchecked((int)35011),
				// GL_MATRIX4_ARB = 0x88C4
				Matrix4 = unchecked((int)35012),
				// GL_MATRIX5_ARB = 0x88C5
				Matrix5 = unchecked((int)35013),
				// GL_MATRIX6_ARB = 0x88C6
				Matrix6 = unchecked((int)35014),
				// GL_MATRIX7_ARB = 0x88C7
				Matrix7 = unchecked((int)35015),
				// GL_MATRIX8_ARB = 0x88C8
				Matrix8 = unchecked((int)35016),
				// GL_MATRIX9_ARB = 0x88C9
				Matrix9 = unchecked((int)35017),
				// GL_MATRIX10_ARB = 0x88CA
				Matrix10 = unchecked((int)35018),
				// GL_MATRIX11_ARB = 0x88CB
				Matrix11 = unchecked((int)35019),
				// GL_MATRIX12_ARB = 0x88CC
				Matrix12 = unchecked((int)35020),
				// GL_MATRIX13_ARB = 0x88CD
				Matrix13 = unchecked((int)35021),
				// GL_MATRIX14_ARB = 0x88CE
				Matrix14 = unchecked((int)35022),
				// GL_MATRIX15_ARB = 0x88CF
				Matrix15 = unchecked((int)35023),
				// GL_MATRIX16_ARB = 0x88D0
				Matrix16 = unchecked((int)35024),
				// GL_MATRIX17_ARB = 0x88D1
				Matrix17 = unchecked((int)35025),
				// GL_MATRIX18_ARB = 0x88D2
				Matrix18 = unchecked((int)35026),
				// GL_MATRIX19_ARB = 0x88D3
				Matrix19 = unchecked((int)35027),
				// GL_MATRIX20_ARB = 0x88D4
				Matrix20 = unchecked((int)35028),
				// GL_MATRIX21_ARB = 0x88D5
				Matrix21 = unchecked((int)35029),
				// GL_MATRIX22_ARB = 0x88D6
				Matrix22 = unchecked((int)35030),
				// GL_MATRIX23_ARB = 0x88D7
				Matrix23 = unchecked((int)35031),
				// GL_MATRIX24_ARB = 0x88D8
				Matrix24 = unchecked((int)35032),
				// GL_MATRIX25_ARB = 0x88D9
				Matrix25 = unchecked((int)35033),
				// GL_MATRIX26_ARB = 0x88DA
				Matrix26 = unchecked((int)35034),
				// GL_MATRIX27_ARB = 0x88DB
				Matrix27 = unchecked((int)35035),
				// GL_MATRIX28_ARB = 0x88DC
				Matrix28 = unchecked((int)35036),
				// GL_MATRIX29_ARB = 0x88DD
				Matrix29 = unchecked((int)35037),
				// GL_MATRIX30_ARB = 0x88DE
				Matrix30 = unchecked((int)35038),
				// GL_MATRIX31_ARB = 0x88DF
				Matrix31 = unchecked((int)35039),
			}
			public const string NAME_STRING = "GL_ARB_fragment_program";
			#region command delegates
			// void glBindProgramARB (GLenum target, GLuint program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindProgramDelegate (System.UInt32 target, System.UInt32 program);
			// void glDeleteProgramsARB (GLsizei n, GLuint* programs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteProgramsDelegate (System.Int32 n, IntPtr programs);
			// void glGenProgramsARB (GLsizei n, GLuint* programs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenProgramsDelegate (System.Int32 n, IntPtr programs);
			// void glGetProgramEnvParameterdvARB (GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramEnvParameterdvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramEnvParameterfvARB (GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramEnvParameterfvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramivARB (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetProgramLocalParameterdvARB (GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramLocalParameterdvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramLocalParameterfvARB (GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramLocalParameterfvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramStringARB (GLenum target, GLenum pname, void* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramStringDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @string);
			// GLboolean glIsProgramARB (GLuint program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsProgramDelegate (System.UInt32 program);
			// void glProgramEnvParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameter4dDelegate (System.UInt32 target, System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glProgramEnvParameter4dvARB (GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameter4dvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramEnvParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameter4fDelegate (System.UInt32 target, System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glProgramEnvParameter4fvARB (GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameter4fvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramLocalParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameter4dDelegate (System.UInt32 target, System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glProgramLocalParameter4dvARB (GLenum target, GLuint index, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameter4dvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramLocalParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameter4fDelegate (System.UInt32 target, System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glProgramLocalParameter4fvARB (GLenum target, GLuint index, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameter4fvDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramStringARB (GLenum target, GLenum format, GLsizei len, void* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramStringDelegate (System.UInt32 target, System.UInt32 format, System.Int32 len, IntPtr @string);
			#endregion // command delegates
			#region commands
			// void glBindProgramARB (GLenum target, GLuint program)
			public readonly BindProgramDelegate BindProgram;
			// void glDeleteProgramsARB (GLsizei n, GLuint* programs)
			public readonly DeleteProgramsDelegate DeletePrograms;
			// void glGenProgramsARB (GLsizei n, GLuint* programs)
			public readonly GenProgramsDelegate GenPrograms;
			// void glGetProgramEnvParameterdvARB (GLenum target, GLuint index, GLdouble* params)
			public readonly GetProgramEnvParameterdvDelegate GetProgramEnvParameterdv;
			// void glGetProgramEnvParameterfvARB (GLenum target, GLuint index, GLfloat* params)
			public readonly GetProgramEnvParameterfvDelegate GetProgramEnvParameterfv;
			// void glGetProgramivARB (GLenum target, GLenum pname, GLint* params)
			public readonly GetProgramivDelegate GetProgramiv;
			// void glGetProgramLocalParameterdvARB (GLenum target, GLuint index, GLdouble* params)
			public readonly GetProgramLocalParameterdvDelegate GetProgramLocalParameterdv;
			// void glGetProgramLocalParameterfvARB (GLenum target, GLuint index, GLfloat* params)
			public readonly GetProgramLocalParameterfvDelegate GetProgramLocalParameterfv;
			// void glGetProgramStringARB (GLenum target, GLenum pname, void* string)
			public readonly GetProgramStringDelegate GetProgramString;
			// GLboolean glIsProgramARB (GLuint program)
			public readonly IsProgramDelegate IsProgram;
			// void glProgramEnvParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly ProgramEnvParameter4dDelegate ProgramEnvParameter4d;
			// void glProgramEnvParameter4dvARB (GLenum target, GLuint index, GLdouble* params)
			public readonly ProgramEnvParameter4dvDelegate ProgramEnvParameter4dv;
			// void glProgramEnvParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly ProgramEnvParameter4fDelegate ProgramEnvParameter4f;
			// void glProgramEnvParameter4fvARB (GLenum target, GLuint index, GLfloat* params)
			public readonly ProgramEnvParameter4fvDelegate ProgramEnvParameter4fv;
			// void glProgramLocalParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly ProgramLocalParameter4dDelegate ProgramLocalParameter4d;
			// void glProgramLocalParameter4dvARB (GLenum target, GLuint index, GLdouble* params)
			public readonly ProgramLocalParameter4dvDelegate ProgramLocalParameter4dv;
			// void glProgramLocalParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly ProgramLocalParameter4fDelegate ProgramLocalParameter4f;
			// void glProgramLocalParameter4fvARB (GLenum target, GLuint index, GLfloat* params)
			public readonly ProgramLocalParameter4fvDelegate ProgramLocalParameter4fv;
			// void glProgramStringARB (GLenum target, GLenum format, GLsizei len, void* string)
			public readonly ProgramStringDelegate ProgramString;
			#endregion // commands
			public ArbFragmentProgram (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindProgramARB", out BindProgram);
				resolver.LoadHandle ("glDeleteProgramsARB", out DeletePrograms);
				resolver.LoadHandle ("glGenProgramsARB", out GenPrograms);
				resolver.LoadHandle ("glGetProgramEnvParameterdvARB", out GetProgramEnvParameterdv);
				resolver.LoadHandle ("glGetProgramEnvParameterfvARB", out GetProgramEnvParameterfv);
				resolver.LoadHandle ("glGetProgramivARB", out GetProgramiv);
				resolver.LoadHandle ("glGetProgramLocalParameterdvARB", out GetProgramLocalParameterdv);
				resolver.LoadHandle ("glGetProgramLocalParameterfvARB", out GetProgramLocalParameterfv);
				resolver.LoadHandle ("glGetProgramStringARB", out GetProgramString);
				resolver.LoadHandle ("glIsProgramARB", out IsProgram);
				resolver.LoadHandle ("glProgramEnvParameter4dARB", out ProgramEnvParameter4d);
				resolver.LoadHandle ("glProgramEnvParameter4dvARB", out ProgramEnvParameter4dv);
				resolver.LoadHandle ("glProgramEnvParameter4fARB", out ProgramEnvParameter4f);
				resolver.LoadHandle ("glProgramEnvParameter4fvARB", out ProgramEnvParameter4fv);
				resolver.LoadHandle ("glProgramLocalParameter4dARB", out ProgramLocalParameter4d);
				resolver.LoadHandle ("glProgramLocalParameter4dvARB", out ProgramLocalParameter4dv);
				resolver.LoadHandle ("glProgramLocalParameter4fARB", out ProgramLocalParameter4f);
				resolver.LoadHandle ("glProgramLocalParameter4fvARB", out ProgramLocalParameter4fv);
				resolver.LoadHandle ("glProgramStringARB", out ProgramString);
			}
		}
		public partial class ArbFragmentShader
		{
			public enum All
			{
				// GL_FRAGMENT_SHADER_ARB = 0x8B30
				FragmentShader = unchecked((int)35632),
				// GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49
				MaxFragmentUniformComponents = unchecked((int)35657),
				// GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
				FragmentShaderDerivativeHint = unchecked((int)35723),
			}
			public const string NAME_STRING = "GL_ARB_fragment_shader";
		}
		public partial class ArbGeometryShader4
		{
			public enum All
			{
				// GL_LINES_ADJACENCY_ARB = 0xA
				LinesAdjacency = unchecked((int)10),
				// GL_LINE_STRIP_ADJACENCY_ARB = 0xB
				LineStripAdjacency = unchecked((int)11),
				// GL_TRIANGLES_ADJACENCY_ARB = 0xC
				TrianglesAdjacency = unchecked((int)12),
				// GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0xD
				TriangleStripAdjacency = unchecked((int)13),
				// GL_PROGRAM_POINT_SIZE_ARB = 0x8642
				ProgramPointSize = unchecked((int)34370),
				// GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29
				MaxGeometryTextureImageUnits = unchecked((int)35881),
				// GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7
				FramebufferAttachmentLayered = unchecked((int)36263),
				// GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8
				FramebufferIncompleteLayerTargets = unchecked((int)36264),
				// GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9
				FramebufferIncompleteLayerCount = unchecked((int)36265),
				// GL_GEOMETRY_SHADER_ARB = 0x8DD9
				GeometryShader = unchecked((int)36313),
				// GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA
				GeometryVerticesOut = unchecked((int)36314),
				// GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB
				GeometryInputType = unchecked((int)36315),
				// GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC
				GeometryOutputType = unchecked((int)36316),
				// GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD
				MaxGeometryVaryingComponents = unchecked((int)36317),
				// GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE
				MaxVertexVaryingComponents = unchecked((int)36318),
				// GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF
				MaxGeometryUniformComponents = unchecked((int)36319),
				// GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0
				MaxGeometryOutputVertices = unchecked((int)36320),
				// GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1
				MaxGeometryTotalOutputComponents = unchecked((int)36321),
			}
			public const string NAME_STRING = "GL_ARB_geometry_shader4";
			#region command delegates
			// void glFramebufferTextureFaceARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureFaceDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, TextureTarget face);
			// void glFramebufferTextureARB (GLenum target, GLenum attachment, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level);
			// void glFramebufferTextureLayerARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureLayerDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer);
			// void glProgramParameteriARB (GLuint program, GLenum pname, GLint value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameteriDelegate (System.UInt32 program, System.UInt32 pname, System.Int32 value);
			#endregion // command delegates
			#region commands
			// void glFramebufferTextureFaceARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
			public readonly FramebufferTextureFaceDelegate FramebufferTextureFace;
			// void glFramebufferTextureARB (GLenum target, GLenum attachment, GLuint texture, GLint level)
			public readonly FramebufferTextureDelegate FramebufferTexture;
			// void glFramebufferTextureLayerARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
			public readonly FramebufferTextureLayerDelegate FramebufferTextureLayer;
			// void glProgramParameteriARB (GLuint program, GLenum pname, GLint value)
			public readonly ProgramParameteriDelegate ProgramParameteri;
			#endregion // commands
			public ArbGeometryShader4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFramebufferTextureFaceARB", out FramebufferTextureFace);
				resolver.LoadHandle ("glFramebufferTextureARB", out FramebufferTexture);
				resolver.LoadHandle ("glFramebufferTextureLayerARB", out FramebufferTextureLayer);
				resolver.LoadHandle ("glProgramParameteriARB", out ProgramParameteri);
			}
		}
		public partial class ArbGpuShaderInt64
		{
			public enum All
			{
				// GL_INT64_ARB = 0x140E
				Int64 = unchecked((int)5134),
				// GL_INT64_VEC2_ARB = 0x8FE9
				Int64Vec2 = unchecked((int)36841),
				// GL_INT64_VEC3_ARB = 0x8FEA
				Int64Vec3 = unchecked((int)36842),
				// GL_INT64_VEC4_ARB = 0x8FEB
				Int64Vec4 = unchecked((int)36843),
				// GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5
				UnsignedInt64Vec2 = unchecked((int)36853),
				// GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6
				UnsignedInt64Vec3 = unchecked((int)36854),
				// GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7
				UnsignedInt64Vec4 = unchecked((int)36855),
			}
			public const string NAME_STRING = "GL_ARB_gpu_shader_int64";
			#region command delegates
			// void glGetnUniformi64vARB (GLuint program, GLint location, GLsizei bufSize, GLint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformi64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glGetnUniformui64vARB (GLuint program, GLint location, GLsizei bufSize, GLuint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glGetUniformi64vARB (GLuint program, GLint location, GLint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformi64vDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
			// void glGetUniformui64vARB (GLuint program, GLint location, GLuint64* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformui64vDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
			// void glProgramUniform1i64ARB (GLuint program, GLint location, GLint64 x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x);
			// void glProgramUniform1i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform1ui64ARB (GLuint program, GLint location, GLuint64 x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x);
			// void glProgramUniform1ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y);
			// void glProgramUniform2i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y);
			// void glProgramUniform2ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z);
			// void glProgramUniform3i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z);
			// void glProgramUniform3ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z, System.Int64 w);
			// void glProgramUniform4i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z, System.UInt64 w);
			// void glProgramUniform4ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform1i64ARB (GLint location, GLint64 x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1i64Delegate (System.Int32 location, System.Int64 x);
			// void glUniform1i64vARB (GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform1ui64ARB (GLint location, GLuint64 x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1ui64Delegate (System.Int32 location, System.UInt64 x);
			// void glUniform1ui64vARB (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2i64ARB (GLint location, GLint64 x, GLint64 y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y);
			// void glUniform2i64vARB (GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2ui64ARB (GLint location, GLuint64 x, GLuint64 y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y);
			// void glUniform2ui64vARB (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z);
			// void glUniform3i64vARB (GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z);
			// void glUniform3ui64vARB (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z, System.Int64 w);
			// void glUniform4i64vARB (GLint location, GLsizei count, GLint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z, System.UInt64 w);
			// void glUniform4ui64vARB (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			#endregion // command delegates
			#region commands
			// void glGetnUniformi64vARB (GLuint program, GLint location, GLsizei bufSize, GLint64* params)
			public readonly GetnUniformi64vDelegate GetnUniformi64v;
			// void glGetnUniformui64vARB (GLuint program, GLint location, GLsizei bufSize, GLuint64* params)
			public readonly GetnUniformui64vDelegate GetnUniformui64v;
			// void glGetUniformi64vARB (GLuint program, GLint location, GLint64* params)
			public readonly GetUniformi64vDelegate GetUniformi64v;
			// void glGetUniformui64vARB (GLuint program, GLint location, GLuint64* params)
			public readonly GetUniformui64vDelegate GetUniformui64v;
			// void glProgramUniform1i64ARB (GLuint program, GLint location, GLint64 x)
			public readonly ProgramUniform1i64Delegate ProgramUniform1i64;
			// void glProgramUniform1i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			public readonly ProgramUniform1i64vDelegate ProgramUniform1i64v;
			// void glProgramUniform1ui64ARB (GLuint program, GLint location, GLuint64 x)
			public readonly ProgramUniform1ui64Delegate ProgramUniform1ui64;
			// void glProgramUniform1ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			public readonly ProgramUniform1ui64vDelegate ProgramUniform1ui64v;
			// void glProgramUniform2i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y)
			public readonly ProgramUniform2i64Delegate ProgramUniform2i64;
			// void glProgramUniform2i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			public readonly ProgramUniform2i64vDelegate ProgramUniform2i64v;
			// void glProgramUniform2ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y)
			public readonly ProgramUniform2ui64Delegate ProgramUniform2ui64;
			// void glProgramUniform2ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			public readonly ProgramUniform2ui64vDelegate ProgramUniform2ui64v;
			// void glProgramUniform3i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z)
			public readonly ProgramUniform3i64Delegate ProgramUniform3i64;
			// void glProgramUniform3i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			public readonly ProgramUniform3i64vDelegate ProgramUniform3i64v;
			// void glProgramUniform3ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
			public readonly ProgramUniform3ui64Delegate ProgramUniform3ui64;
			// void glProgramUniform3ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			public readonly ProgramUniform3ui64vDelegate ProgramUniform3ui64v;
			// void glProgramUniform4i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
			public readonly ProgramUniform4i64Delegate ProgramUniform4i64;
			// void glProgramUniform4i64vARB (GLuint program, GLint location, GLsizei count, GLint64* value)
			public readonly ProgramUniform4i64vDelegate ProgramUniform4i64v;
			// void glProgramUniform4ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
			public readonly ProgramUniform4ui64Delegate ProgramUniform4ui64;
			// void glProgramUniform4ui64vARB (GLuint program, GLint location, GLsizei count, GLuint64* value)
			public readonly ProgramUniform4ui64vDelegate ProgramUniform4ui64v;
			// void glUniform1i64ARB (GLint location, GLint64 x)
			public readonly Uniform1i64Delegate Uniform1i64;
			// void glUniform1i64vARB (GLint location, GLsizei count, GLint64* value)
			public readonly Uniform1i64vDelegate Uniform1i64v;
			// void glUniform1ui64ARB (GLint location, GLuint64 x)
			public readonly Uniform1ui64Delegate Uniform1ui64;
			// void glUniform1ui64vARB (GLint location, GLsizei count, GLuint64* value)
			public readonly Uniform1ui64vDelegate Uniform1ui64v;
			// void glUniform2i64ARB (GLint location, GLint64 x, GLint64 y)
			public readonly Uniform2i64Delegate Uniform2i64;
			// void glUniform2i64vARB (GLint location, GLsizei count, GLint64* value)
			public readonly Uniform2i64vDelegate Uniform2i64v;
			// void glUniform2ui64ARB (GLint location, GLuint64 x, GLuint64 y)
			public readonly Uniform2ui64Delegate Uniform2ui64;
			// void glUniform2ui64vARB (GLint location, GLsizei count, GLuint64* value)
			public readonly Uniform2ui64vDelegate Uniform2ui64v;
			// void glUniform3i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z)
			public readonly Uniform3i64Delegate Uniform3i64;
			// void glUniform3i64vARB (GLint location, GLsizei count, GLint64* value)
			public readonly Uniform3i64vDelegate Uniform3i64v;
			// void glUniform3ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
			public readonly Uniform3ui64Delegate Uniform3ui64;
			// void glUniform3ui64vARB (GLint location, GLsizei count, GLuint64* value)
			public readonly Uniform3ui64vDelegate Uniform3ui64v;
			// void glUniform4i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
			public readonly Uniform4i64Delegate Uniform4i64;
			// void glUniform4i64vARB (GLint location, GLsizei count, GLint64* value)
			public readonly Uniform4i64vDelegate Uniform4i64v;
			// void glUniform4ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
			public readonly Uniform4ui64Delegate Uniform4ui64;
			// void glUniform4ui64vARB (GLint location, GLsizei count, GLuint64* value)
			public readonly Uniform4ui64vDelegate Uniform4ui64v;
			#endregion // commands
			public ArbGpuShaderInt64 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetnUniformi64vARB", out GetnUniformi64v);
				resolver.LoadHandle ("glGetnUniformui64vARB", out GetnUniformui64v);
				resolver.LoadHandle ("glGetUniformi64vARB", out GetUniformi64v);
				resolver.LoadHandle ("glGetUniformui64vARB", out GetUniformui64v);
				resolver.LoadHandle ("glProgramUniform1i64ARB", out ProgramUniform1i64);
				resolver.LoadHandle ("glProgramUniform1i64vARB", out ProgramUniform1i64v);
				resolver.LoadHandle ("glProgramUniform1ui64ARB", out ProgramUniform1ui64);
				resolver.LoadHandle ("glProgramUniform1ui64vARB", out ProgramUniform1ui64v);
				resolver.LoadHandle ("glProgramUniform2i64ARB", out ProgramUniform2i64);
				resolver.LoadHandle ("glProgramUniform2i64vARB", out ProgramUniform2i64v);
				resolver.LoadHandle ("glProgramUniform2ui64ARB", out ProgramUniform2ui64);
				resolver.LoadHandle ("glProgramUniform2ui64vARB", out ProgramUniform2ui64v);
				resolver.LoadHandle ("glProgramUniform3i64ARB", out ProgramUniform3i64);
				resolver.LoadHandle ("glProgramUniform3i64vARB", out ProgramUniform3i64v);
				resolver.LoadHandle ("glProgramUniform3ui64ARB", out ProgramUniform3ui64);
				resolver.LoadHandle ("glProgramUniform3ui64vARB", out ProgramUniform3ui64v);
				resolver.LoadHandle ("glProgramUniform4i64ARB", out ProgramUniform4i64);
				resolver.LoadHandle ("glProgramUniform4i64vARB", out ProgramUniform4i64v);
				resolver.LoadHandle ("glProgramUniform4ui64ARB", out ProgramUniform4ui64);
				resolver.LoadHandle ("glProgramUniform4ui64vARB", out ProgramUniform4ui64v);
				resolver.LoadHandle ("glUniform1i64ARB", out Uniform1i64);
				resolver.LoadHandle ("glUniform1i64vARB", out Uniform1i64v);
				resolver.LoadHandle ("glUniform1ui64ARB", out Uniform1ui64);
				resolver.LoadHandle ("glUniform1ui64vARB", out Uniform1ui64v);
				resolver.LoadHandle ("glUniform2i64ARB", out Uniform2i64);
				resolver.LoadHandle ("glUniform2i64vARB", out Uniform2i64v);
				resolver.LoadHandle ("glUniform2ui64ARB", out Uniform2ui64);
				resolver.LoadHandle ("glUniform2ui64vARB", out Uniform2ui64v);
				resolver.LoadHandle ("glUniform3i64ARB", out Uniform3i64);
				resolver.LoadHandle ("glUniform3i64vARB", out Uniform3i64v);
				resolver.LoadHandle ("glUniform3ui64ARB", out Uniform3ui64);
				resolver.LoadHandle ("glUniform3ui64vARB", out Uniform3ui64v);
				resolver.LoadHandle ("glUniform4i64ARB", out Uniform4i64);
				resolver.LoadHandle ("glUniform4i64vARB", out Uniform4i64v);
				resolver.LoadHandle ("glUniform4ui64ARB", out Uniform4ui64);
				resolver.LoadHandle ("glUniform4ui64vARB", out Uniform4ui64v);
			}
		}
		public partial class ArbHalfFloatPixel
		{
			public enum All
			{
				// GL_HALF_FLOAT_ARB = 0x140B
				HalfFloat = unchecked((int)5131),
			}
			public const string NAME_STRING = "GL_ARB_half_float_pixel";
		}
		public partial class ArbImaging
		{
			public enum All
			{
				// GL_BLEND_COLOR = 0x8005
				BlendColor = unchecked((int)32773),
				// GL_BLEND_EQUATION = 0x8009
				BlendEquation = unchecked((int)32777),
			}
			public const string NAME_STRING = "GL_ARB_imaging";
		}
		public partial class ArbIndirectParameters
		{
			public enum All
			{
				// GL_PARAMETER_BUFFER_ARB = 0x80EE
				ParameterBuffer = unchecked((int)33006),
				// GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF
				ParameterBufferBinding = unchecked((int)33007),
			}
			public const string NAME_STRING = "GL_ARB_indirect_parameters";
			#region command delegates
			// void glMultiDrawArraysIndirectCountARB (GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawArraysIndirectCountDelegate (System.UInt32 mode, System.IntPtr indirect, System.IntPtr drawcount, System.Int32 maxdrawcount, System.Int32 stride);
			// void glMultiDrawElementsIndirectCountARB (GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementsIndirectCountDelegate (System.UInt32 mode, System.UInt32 type, System.IntPtr indirect, System.IntPtr drawcount, System.Int32 maxdrawcount, System.Int32 stride);
			#endregion // command delegates
			#region commands
			// void glMultiDrawArraysIndirectCountARB (GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
			public readonly MultiDrawArraysIndirectCountDelegate MultiDrawArraysIndirectCount;
			// void glMultiDrawElementsIndirectCountARB (GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
			public readonly MultiDrawElementsIndirectCountDelegate MultiDrawElementsIndirectCount;
			#endregion // commands
			public ArbIndirectParameters (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiDrawArraysIndirectCountARB", out MultiDrawArraysIndirectCount);
				resolver.LoadHandle ("glMultiDrawElementsIndirectCountARB", out MultiDrawElementsIndirectCount);
			}
		}
		public partial class ArbInstancedArrays
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE
				VertexAttribArrayDivisor = unchecked((int)35070),
			}
			public const string NAME_STRING = "GL_ARB_instanced_arrays";
			#region command delegates
			// void glVertexAttribDivisorARB (GLuint index, GLuint divisor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribDivisorDelegate (System.UInt32 index, System.UInt32 divisor);
			#endregion // command delegates
			#region commands
			// void glVertexAttribDivisorARB (GLuint index, GLuint divisor)
			public readonly VertexAttribDivisorDelegate VertexAttribDivisor;
			#endregion // commands
			public ArbInstancedArrays (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glVertexAttribDivisorARB", out VertexAttribDivisor);
			}
		}
		public partial class ArbInternalformatQuery2
		{
			public enum All
			{
				// GL_SRGB_DECODE_ARB = 0x8299
				SrgbDecode = unchecked((int)33433),
			}
			public const string NAME_STRING = "GL_ARB_internalformat_query2";
		}
		public partial class ArbMatrixPalette
		{
			public enum All
			{
				// GL_MATRIX_PALETTE_ARB = 0x8840
				MatrixPalette = unchecked((int)34880),
				// GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841
				MaxMatrixPaletteStackDepth = unchecked((int)34881),
				// GL_MAX_PALETTE_MATRICES_ARB = 0x8842
				MaxPaletteMatrices = unchecked((int)34882),
				// GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843
				CurrentPaletteMatrix = unchecked((int)34883),
				// GL_MATRIX_INDEX_ARRAY_ARB = 0x8844
				MatrixIndexArray = unchecked((int)34884),
				// GL_CURRENT_MATRIX_INDEX_ARB = 0x8845
				CurrentMatrixIndex = unchecked((int)34885),
				// GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846
				MatrixIndexArraySize = unchecked((int)34886),
				// GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847
				MatrixIndexArrayType = unchecked((int)34887),
				// GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848
				MatrixIndexArrayStride = unchecked((int)34888),
				// GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849
				MatrixIndexArrayPointer = unchecked((int)34889),
			}
			public const string NAME_STRING = "GL_ARB_matrix_palette";
			#region command delegates
			// void glCurrentPaletteMatrixARB (GLint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CurrentPaletteMatrixDelegate (System.Int32 index);
			// void glMatrixIndexPointerARB (GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixIndexPointerDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			// void glMatrixIndexubvARB (GLint size, GLubyte* indices)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixIndexubvDelegate (System.Int32 size, IntPtr indices);
			// void glMatrixIndexuivARB (GLint size, GLuint* indices)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixIndexuivDelegate (System.Int32 size, IntPtr indices);
			// void glMatrixIndexusvARB (GLint size, GLushort* indices)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixIndexusvDelegate (System.Int32 size, IntPtr indices);
			#endregion // command delegates
			#region commands
			// void glCurrentPaletteMatrixARB (GLint index)
			public readonly CurrentPaletteMatrixDelegate CurrentPaletteMatrix;
			// void glMatrixIndexPointerARB (GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly MatrixIndexPointerDelegate MatrixIndexPointer;
			// void glMatrixIndexubvARB (GLint size, GLubyte* indices)
			public readonly MatrixIndexubvDelegate MatrixIndexubv;
			// void glMatrixIndexuivARB (GLint size, GLuint* indices)
			public readonly MatrixIndexuivDelegate MatrixIndexuiv;
			// void glMatrixIndexusvARB (GLint size, GLushort* indices)
			public readonly MatrixIndexusvDelegate MatrixIndexusv;
			#endregion // commands
			public ArbMatrixPalette (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCurrentPaletteMatrixARB", out CurrentPaletteMatrix);
				resolver.LoadHandle ("glMatrixIndexPointerARB", out MatrixIndexPointer);
				resolver.LoadHandle ("glMatrixIndexubvARB", out MatrixIndexubv);
				resolver.LoadHandle ("glMatrixIndexuivARB", out MatrixIndexuiv);
				resolver.LoadHandle ("glMatrixIndexusvARB", out MatrixIndexusv);
			}
		}
		public partial class ArbMultisample
		{
			public enum All
			{
				// GL_MULTISAMPLE_ARB = 0x809D
				Multisample = unchecked((int)32925),
				// GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E
				SampleAlphaToCoverage = unchecked((int)32926),
				// GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F
				SampleAlphaToOne = unchecked((int)32927),
				// GL_SAMPLE_COVERAGE_ARB = 0x80A0
				SampleCoverage = unchecked((int)32928),
				// GL_SAMPLE_BUFFERS_ARB = 0x80A8
				SampleBuffers = unchecked((int)32936),
				// GL_SAMPLES_ARB = 0x80A9
				Samples = unchecked((int)32937),
				// GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA
				SampleCoverageValue = unchecked((int)32938),
				// GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB
				SampleCoverageInvert = unchecked((int)32939),
				// GL_MULTISAMPLE_BIT_ARB = 0x20000000
				MultisampleBit = unchecked((int)536870912),
			}
			public const string NAME_STRING = "GL_ARB_multisample";
			#region command delegates
			// void glSampleCoverageARB (GLfloat value, GLboolean invert)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SampleCoverageDelegate (System.Single value, Boolean invert);
			#endregion // command delegates
			#region commands
			// void glSampleCoverageARB (GLfloat value, GLboolean invert)
			public readonly SampleCoverageDelegate SampleCoverage;
			#endregion // commands
			public ArbMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSampleCoverageARB", out SampleCoverage);
			}
		}
		public partial class ArbMultitexture
		{
			public enum All
			{
				// GL_TEXTURE0_ARB = 0x84C0
				Texture0 = unchecked((int)33984),
				// GL_TEXTURE1_ARB = 0x84C1
				Texture1 = unchecked((int)33985),
				// GL_TEXTURE2_ARB = 0x84C2
				Texture2 = unchecked((int)33986),
				// GL_TEXTURE3_ARB = 0x84C3
				Texture3 = unchecked((int)33987),
				// GL_TEXTURE4_ARB = 0x84C4
				Texture4 = unchecked((int)33988),
				// GL_TEXTURE5_ARB = 0x84C5
				Texture5 = unchecked((int)33989),
				// GL_TEXTURE6_ARB = 0x84C6
				Texture6 = unchecked((int)33990),
				// GL_TEXTURE7_ARB = 0x84C7
				Texture7 = unchecked((int)33991),
				// GL_TEXTURE8_ARB = 0x84C8
				Texture8 = unchecked((int)33992),
				// GL_TEXTURE9_ARB = 0x84C9
				Texture9 = unchecked((int)33993),
				// GL_TEXTURE10_ARB = 0x84CA
				Texture10 = unchecked((int)33994),
				// GL_TEXTURE11_ARB = 0x84CB
				Texture11 = unchecked((int)33995),
				// GL_TEXTURE12_ARB = 0x84CC
				Texture12 = unchecked((int)33996),
				// GL_TEXTURE13_ARB = 0x84CD
				Texture13 = unchecked((int)33997),
				// GL_TEXTURE14_ARB = 0x84CE
				Texture14 = unchecked((int)33998),
				// GL_TEXTURE15_ARB = 0x84CF
				Texture15 = unchecked((int)33999),
				// GL_TEXTURE16_ARB = 0x84D0
				Texture16 = unchecked((int)34000),
				// GL_TEXTURE17_ARB = 0x84D1
				Texture17 = unchecked((int)34001),
				// GL_TEXTURE18_ARB = 0x84D2
				Texture18 = unchecked((int)34002),
				// GL_TEXTURE19_ARB = 0x84D3
				Texture19 = unchecked((int)34003),
				// GL_TEXTURE20_ARB = 0x84D4
				Texture20 = unchecked((int)34004),
				// GL_TEXTURE21_ARB = 0x84D5
				Texture21 = unchecked((int)34005),
				// GL_TEXTURE22_ARB = 0x84D6
				Texture22 = unchecked((int)34006),
				// GL_TEXTURE23_ARB = 0x84D7
				Texture23 = unchecked((int)34007),
				// GL_TEXTURE24_ARB = 0x84D8
				Texture24 = unchecked((int)34008),
				// GL_TEXTURE25_ARB = 0x84D9
				Texture25 = unchecked((int)34009),
				// GL_TEXTURE26_ARB = 0x84DA
				Texture26 = unchecked((int)34010),
				// GL_TEXTURE27_ARB = 0x84DB
				Texture27 = unchecked((int)34011),
				// GL_TEXTURE28_ARB = 0x84DC
				Texture28 = unchecked((int)34012),
				// GL_TEXTURE29_ARB = 0x84DD
				Texture29 = unchecked((int)34013),
				// GL_TEXTURE30_ARB = 0x84DE
				Texture30 = unchecked((int)34014),
				// GL_TEXTURE31_ARB = 0x84DF
				Texture31 = unchecked((int)34015),
				// GL_ACTIVE_TEXTURE_ARB = 0x84E0
				ActiveTexture = unchecked((int)34016),
				// GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1
				ClientActiveTexture = unchecked((int)34017),
				// GL_MAX_TEXTURE_UNITS_ARB = 0x84E2
				MaxTextureUnits = unchecked((int)34018),
			}
			public const string NAME_STRING = "GL_ARB_multitexture";
			#region command delegates
			// void glActiveTextureARB (GLenum texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ActiveTextureDelegate (TextureUnit texture);
			// void glClientActiveTextureARB (GLenum texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClientActiveTextureDelegate (TextureUnit texture);
			// void glMultiTexCoord1dARB (GLenum target, GLdouble s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1dDelegate (TextureUnit target, System.Double s);
			// void glMultiTexCoord1dvARB (GLenum target, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1dvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord1fARB (GLenum target, GLfloat s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1fDelegate (TextureUnit target, System.Single s);
			// void glMultiTexCoord1fvARB (GLenum target, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1fvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord1iARB (GLenum target, GLint s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1iDelegate (TextureUnit target, System.Int32 s);
			// void glMultiTexCoord1ivARB (GLenum target, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1ivDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord1sARB (GLenum target, GLshort s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1sDelegate (TextureUnit target, System.Int16 s);
			// void glMultiTexCoord1svARB (GLenum target, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1svDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord2dARB (GLenum target, GLdouble s, GLdouble t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2dDelegate (TextureUnit target, System.Double s, System.Double t);
			// void glMultiTexCoord2dvARB (GLenum target, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2dvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord2fARB (GLenum target, GLfloat s, GLfloat t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2fDelegate (TextureUnit target, System.Single s, System.Single t);
			// void glMultiTexCoord2fvARB (GLenum target, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2fvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord2iARB (GLenum target, GLint s, GLint t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2iDelegate (TextureUnit target, System.Int32 s, System.Int32 t);
			// void glMultiTexCoord2ivARB (GLenum target, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2ivDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord2sARB (GLenum target, GLshort s, GLshort t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2sDelegate (TextureUnit target, System.Int16 s, System.Int16 t);
			// void glMultiTexCoord2svARB (GLenum target, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2svDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord3dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3dDelegate (TextureUnit target, System.Double s, System.Double t, System.Double r);
			// void glMultiTexCoord3dvARB (GLenum target, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3dvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord3fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3fDelegate (TextureUnit target, System.Single s, System.Single t, System.Single r);
			// void glMultiTexCoord3fvARB (GLenum target, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3fvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord3iARB (GLenum target, GLint s, GLint t, GLint r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3iDelegate (TextureUnit target, System.Int32 s, System.Int32 t, System.Int32 r);
			// void glMultiTexCoord3ivARB (GLenum target, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3ivDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord3sARB (GLenum target, GLshort s, GLshort t, GLshort r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3sDelegate (TextureUnit target, System.Int16 s, System.Int16 t, System.Int16 r);
			// void glMultiTexCoord3svARB (GLenum target, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3svDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord4dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4dDelegate (TextureUnit target, System.Double s, System.Double t, System.Double r, System.Double q);
			// void glMultiTexCoord4dvARB (GLenum target, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4dvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord4fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4fDelegate (TextureUnit target, System.Single s, System.Single t, System.Single r, System.Single q);
			// void glMultiTexCoord4fvARB (GLenum target, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4fvDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord4iARB (GLenum target, GLint s, GLint t, GLint r, GLint q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4iDelegate (TextureUnit target, System.Int32 s, System.Int32 t, System.Int32 r, System.Int32 q);
			// void glMultiTexCoord4ivARB (GLenum target, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4ivDelegate (TextureUnit target, IntPtr v);
			// void glMultiTexCoord4sARB (GLenum target, GLshort s, GLshort t, GLshort r, GLshort q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4sDelegate (TextureUnit target, System.Int16 s, System.Int16 t, System.Int16 r, System.Int16 q);
			// void glMultiTexCoord4svARB (GLenum target, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4svDelegate (TextureUnit target, IntPtr v);
			#endregion // command delegates
			#region commands
			// void glActiveTextureARB (GLenum texture)
			public readonly ActiveTextureDelegate ActiveTexture;
			// void glClientActiveTextureARB (GLenum texture)
			public readonly ClientActiveTextureDelegate ClientActiveTexture;
			// void glMultiTexCoord1dARB (GLenum target, GLdouble s)
			public readonly MultiTexCoord1dDelegate MultiTexCoord1d;
			// void glMultiTexCoord1dvARB (GLenum target, GLdouble* v)
			public readonly MultiTexCoord1dvDelegate MultiTexCoord1dv;
			// void glMultiTexCoord1fARB (GLenum target, GLfloat s)
			public readonly MultiTexCoord1fDelegate MultiTexCoord1f;
			// void glMultiTexCoord1fvARB (GLenum target, GLfloat* v)
			public readonly MultiTexCoord1fvDelegate MultiTexCoord1fv;
			// void glMultiTexCoord1iARB (GLenum target, GLint s)
			public readonly MultiTexCoord1iDelegate MultiTexCoord1i;
			// void glMultiTexCoord1ivARB (GLenum target, GLint* v)
			public readonly MultiTexCoord1ivDelegate MultiTexCoord1iv;
			// void glMultiTexCoord1sARB (GLenum target, GLshort s)
			public readonly MultiTexCoord1sDelegate MultiTexCoord1s;
			// void glMultiTexCoord1svARB (GLenum target, GLshort* v)
			public readonly MultiTexCoord1svDelegate MultiTexCoord1sv;
			// void glMultiTexCoord2dARB (GLenum target, GLdouble s, GLdouble t)
			public readonly MultiTexCoord2dDelegate MultiTexCoord2d;
			// void glMultiTexCoord2dvARB (GLenum target, GLdouble* v)
			public readonly MultiTexCoord2dvDelegate MultiTexCoord2dv;
			// void glMultiTexCoord2fARB (GLenum target, GLfloat s, GLfloat t)
			public readonly MultiTexCoord2fDelegate MultiTexCoord2f;
			// void glMultiTexCoord2fvARB (GLenum target, GLfloat* v)
			public readonly MultiTexCoord2fvDelegate MultiTexCoord2fv;
			// void glMultiTexCoord2iARB (GLenum target, GLint s, GLint t)
			public readonly MultiTexCoord2iDelegate MultiTexCoord2i;
			// void glMultiTexCoord2ivARB (GLenum target, GLint* v)
			public readonly MultiTexCoord2ivDelegate MultiTexCoord2iv;
			// void glMultiTexCoord2sARB (GLenum target, GLshort s, GLshort t)
			public readonly MultiTexCoord2sDelegate MultiTexCoord2s;
			// void glMultiTexCoord2svARB (GLenum target, GLshort* v)
			public readonly MultiTexCoord2svDelegate MultiTexCoord2sv;
			// void glMultiTexCoord3dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r)
			public readonly MultiTexCoord3dDelegate MultiTexCoord3d;
			// void glMultiTexCoord3dvARB (GLenum target, GLdouble* v)
			public readonly MultiTexCoord3dvDelegate MultiTexCoord3dv;
			// void glMultiTexCoord3fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r)
			public readonly MultiTexCoord3fDelegate MultiTexCoord3f;
			// void glMultiTexCoord3fvARB (GLenum target, GLfloat* v)
			public readonly MultiTexCoord3fvDelegate MultiTexCoord3fv;
			// void glMultiTexCoord3iARB (GLenum target, GLint s, GLint t, GLint r)
			public readonly MultiTexCoord3iDelegate MultiTexCoord3i;
			// void glMultiTexCoord3ivARB (GLenum target, GLint* v)
			public readonly MultiTexCoord3ivDelegate MultiTexCoord3iv;
			// void glMultiTexCoord3sARB (GLenum target, GLshort s, GLshort t, GLshort r)
			public readonly MultiTexCoord3sDelegate MultiTexCoord3s;
			// void glMultiTexCoord3svARB (GLenum target, GLshort* v)
			public readonly MultiTexCoord3svDelegate MultiTexCoord3sv;
			// void glMultiTexCoord4dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
			public readonly MultiTexCoord4dDelegate MultiTexCoord4d;
			// void glMultiTexCoord4dvARB (GLenum target, GLdouble* v)
			public readonly MultiTexCoord4dvDelegate MultiTexCoord4dv;
			// void glMultiTexCoord4fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
			public readonly MultiTexCoord4fDelegate MultiTexCoord4f;
			// void glMultiTexCoord4fvARB (GLenum target, GLfloat* v)
			public readonly MultiTexCoord4fvDelegate MultiTexCoord4fv;
			// void glMultiTexCoord4iARB (GLenum target, GLint s, GLint t, GLint r, GLint q)
			public readonly MultiTexCoord4iDelegate MultiTexCoord4i;
			// void glMultiTexCoord4ivARB (GLenum target, GLint* v)
			public readonly MultiTexCoord4ivDelegate MultiTexCoord4iv;
			// void glMultiTexCoord4sARB (GLenum target, GLshort s, GLshort t, GLshort r, GLshort q)
			public readonly MultiTexCoord4sDelegate MultiTexCoord4s;
			// void glMultiTexCoord4svARB (GLenum target, GLshort* v)
			public readonly MultiTexCoord4svDelegate MultiTexCoord4sv;
			#endregion // commands
			public ArbMultitexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glActiveTextureARB", out ActiveTexture);
				resolver.LoadHandle ("glClientActiveTextureARB", out ClientActiveTexture);
				resolver.LoadHandle ("glMultiTexCoord1dARB", out MultiTexCoord1d);
				resolver.LoadHandle ("glMultiTexCoord1dvARB", out MultiTexCoord1dv);
				resolver.LoadHandle ("glMultiTexCoord1fARB", out MultiTexCoord1f);
				resolver.LoadHandle ("glMultiTexCoord1fvARB", out MultiTexCoord1fv);
				resolver.LoadHandle ("glMultiTexCoord1iARB", out MultiTexCoord1i);
				resolver.LoadHandle ("glMultiTexCoord1ivARB", out MultiTexCoord1iv);
				resolver.LoadHandle ("glMultiTexCoord1sARB", out MultiTexCoord1s);
				resolver.LoadHandle ("glMultiTexCoord1svARB", out MultiTexCoord1sv);
				resolver.LoadHandle ("glMultiTexCoord2dARB", out MultiTexCoord2d);
				resolver.LoadHandle ("glMultiTexCoord2dvARB", out MultiTexCoord2dv);
				resolver.LoadHandle ("glMultiTexCoord2fARB", out MultiTexCoord2f);
				resolver.LoadHandle ("glMultiTexCoord2fvARB", out MultiTexCoord2fv);
				resolver.LoadHandle ("glMultiTexCoord2iARB", out MultiTexCoord2i);
				resolver.LoadHandle ("glMultiTexCoord2ivARB", out MultiTexCoord2iv);
				resolver.LoadHandle ("glMultiTexCoord2sARB", out MultiTexCoord2s);
				resolver.LoadHandle ("glMultiTexCoord2svARB", out MultiTexCoord2sv);
				resolver.LoadHandle ("glMultiTexCoord3dARB", out MultiTexCoord3d);
				resolver.LoadHandle ("glMultiTexCoord3dvARB", out MultiTexCoord3dv);
				resolver.LoadHandle ("glMultiTexCoord3fARB", out MultiTexCoord3f);
				resolver.LoadHandle ("glMultiTexCoord3fvARB", out MultiTexCoord3fv);
				resolver.LoadHandle ("glMultiTexCoord3iARB", out MultiTexCoord3i);
				resolver.LoadHandle ("glMultiTexCoord3ivARB", out MultiTexCoord3iv);
				resolver.LoadHandle ("glMultiTexCoord3sARB", out MultiTexCoord3s);
				resolver.LoadHandle ("glMultiTexCoord3svARB", out MultiTexCoord3sv);
				resolver.LoadHandle ("glMultiTexCoord4dARB", out MultiTexCoord4d);
				resolver.LoadHandle ("glMultiTexCoord4dvARB", out MultiTexCoord4dv);
				resolver.LoadHandle ("glMultiTexCoord4fARB", out MultiTexCoord4f);
				resolver.LoadHandle ("glMultiTexCoord4fvARB", out MultiTexCoord4fv);
				resolver.LoadHandle ("glMultiTexCoord4iARB", out MultiTexCoord4i);
				resolver.LoadHandle ("glMultiTexCoord4ivARB", out MultiTexCoord4iv);
				resolver.LoadHandle ("glMultiTexCoord4sARB", out MultiTexCoord4s);
				resolver.LoadHandle ("glMultiTexCoord4svARB", out MultiTexCoord4sv);
			}
		}
		public partial class ArbOcclusionQuery
		{
			public enum All
			{
				// GL_QUERY_COUNTER_BITS_ARB = 0x8864
				QueryCounterBits = unchecked((int)34916),
				// GL_CURRENT_QUERY_ARB = 0x8865
				CurrentQuery = unchecked((int)34917),
				// GL_QUERY_RESULT_ARB = 0x8866
				QueryResult = unchecked((int)34918),
				// GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867
				QueryResultAvailable = unchecked((int)34919),
				// GL_SAMPLES_PASSED_ARB = 0x8914
				SamplesPassed = unchecked((int)35092),
			}
			public const string NAME_STRING = "GL_ARB_occlusion_query";
			#region command delegates
			// void glBeginQueryARB (GLenum target, GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginQueryDelegate (System.UInt32 target, System.UInt32 id);
			// void glDeleteQueriesARB (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteQueriesDelegate (System.Int32 n, IntPtr ids);
			// void glEndQueryARB (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndQueryDelegate (System.UInt32 target);
			// void glGenQueriesARB (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenQueriesDelegate (System.Int32 n, IntPtr ids);
			// void glGetQueryivARB (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetQueryivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetQueryObjectivARB (GLuint id, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetQueryObjectivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// void glGetQueryObjectuivARB (GLuint id, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetQueryObjectuivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsQueryARB (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsQueryDelegate (System.UInt32 id);
			#endregion // command delegates
			#region commands
			// void glBeginQueryARB (GLenum target, GLuint id)
			public readonly BeginQueryDelegate BeginQuery;
			// void glDeleteQueriesARB (GLsizei n, GLuint* ids)
			public readonly DeleteQueriesDelegate DeleteQueries;
			// void glEndQueryARB (GLenum target)
			public readonly EndQueryDelegate EndQuery;
			// void glGenQueriesARB (GLsizei n, GLuint* ids)
			public readonly GenQueriesDelegate GenQueries;
			// void glGetQueryivARB (GLenum target, GLenum pname, GLint* params)
			public readonly GetQueryivDelegate GetQueryiv;
			// void glGetQueryObjectivARB (GLuint id, GLenum pname, GLint* params)
			public readonly GetQueryObjectivDelegate GetQueryObjectiv;
			// void glGetQueryObjectuivARB (GLuint id, GLenum pname, GLuint* params)
			public readonly GetQueryObjectuivDelegate GetQueryObjectuiv;
			// GLboolean glIsQueryARB (GLuint id)
			public readonly IsQueryDelegate IsQuery;
			#endregion // commands
			public ArbOcclusionQuery (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginQueryARB", out BeginQuery);
				resolver.LoadHandle ("glDeleteQueriesARB", out DeleteQueries);
				resolver.LoadHandle ("glEndQueryARB", out EndQuery);
				resolver.LoadHandle ("glGenQueriesARB", out GenQueries);
				resolver.LoadHandle ("glGetQueryivARB", out GetQueryiv);
				resolver.LoadHandle ("glGetQueryObjectivARB", out GetQueryObjectiv);
				resolver.LoadHandle ("glGetQueryObjectuivARB", out GetQueryObjectuiv);
				resolver.LoadHandle ("glIsQueryARB", out IsQuery);
			}
		}
		public partial class ArbParallelShaderCompile
		{
			public enum All
			{
				// GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0
				MaxShaderCompilerThreads = unchecked((int)37296),
				// GL_COMPLETION_STATUS_ARB = 0x91B1
				CompletionStatus = unchecked((int)37297),
			}
			public const string NAME_STRING = "GL_ARB_parallel_shader_compile";
			#region command delegates
			// void glMaxShaderCompilerThreadsARB (GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MaxShaderCompilerThreadsDelegate (System.UInt32 count);
			#endregion // command delegates
			#region commands
			// void glMaxShaderCompilerThreadsARB (GLuint count)
			public readonly MaxShaderCompilerThreadsDelegate MaxShaderCompilerThreads;
			#endregion // commands
			public ArbParallelShaderCompile (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMaxShaderCompilerThreadsARB", out MaxShaderCompilerThreads);
			}
		}
		public partial class ArbPipelineStatisticsQuery
		{
			public enum All
			{
				// GL_VERTICES_SUBMITTED_ARB = 0x82EE
				VerticesSubmitted = unchecked((int)33518),
				// GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF
				PrimitivesSubmitted = unchecked((int)33519),
				// GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0
				VertexShaderInvocations = unchecked((int)33520),
				// GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1
				TessControlShaderPatches = unchecked((int)33521),
				// GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2
				TessEvaluationShaderInvocations = unchecked((int)33522),
				// GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3
				GeometryShaderPrimitivesEmitted = unchecked((int)33523),
				// GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4
				FragmentShaderInvocations = unchecked((int)33524),
				// GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5
				ComputeShaderInvocations = unchecked((int)33525),
				// GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6
				ClippingInputPrimitives = unchecked((int)33526),
				// GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7
				ClippingOutputPrimitives = unchecked((int)33527),
			}
			public const string NAME_STRING = "GL_ARB_pipeline_statistics_query";
		}
		public partial class ArbPixelBufferObject
		{
			public enum All
			{
				// GL_PIXEL_PACK_BUFFER_ARB = 0x88EB
				PixelPackBuffer = unchecked((int)35051),
				// GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC
				PixelUnpackBuffer = unchecked((int)35052),
				// GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED
				PixelPackBufferBinding = unchecked((int)35053),
				// GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF
				PixelUnpackBufferBinding = unchecked((int)35055),
			}
			public const string NAME_STRING = "GL_ARB_pixel_buffer_object";
		}
		public partial class ArbPointParameters
		{
			public enum All
			{
				// GL_POINT_SIZE_MIN_ARB = 0x8126
				PointSizeMin = unchecked((int)33062),
				// GL_POINT_SIZE_MAX_ARB = 0x8127
				PointSizeMax = unchecked((int)33063),
				// GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
				PointFadeThresholdSize = unchecked((int)33064),
				// GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
				PointDistanceAttenuation = unchecked((int)33065),
			}
			public const string NAME_STRING = "GL_ARB_point_parameters";
			#region command delegates
			// void glPointParameterfARB (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfDelegate (System.UInt32 pname, System.Single param);
			// void glPointParameterfvARB (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glPointParameterfARB (GLenum pname, GLfloat param)
			public readonly PointParameterfDelegate PointParameterf;
			// void glPointParameterfvARB (GLenum pname, GLfloat* params)
			public readonly PointParameterfvDelegate PointParameterfv;
			#endregion // commands
			public ArbPointParameters (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPointParameterfARB", out PointParameterf);
				resolver.LoadHandle ("glPointParameterfvARB", out PointParameterfv);
			}
		}
		public partial class ArbPointSprite
		{
			public enum All
			{
				// GL_POINT_SPRITE_ARB = 0x8861
				PointSprite = unchecked((int)34913),
				// GL_COORD_REPLACE_ARB = 0x8862
				CoordReplace = unchecked((int)34914),
			}
			public const string NAME_STRING = "GL_ARB_point_sprite";
		}
		public partial class ArbRobustness
		{
			public enum All
			{
				// GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x4
				ContextFlagRobustAccessBit = unchecked((int)4),
				// GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252
				LoseContextOnReset = unchecked((int)33362),
				// GL_GUILTY_CONTEXT_RESET_ARB = 0x8253
				GuiltyContextReset = unchecked((int)33363),
				// GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254
				InnocentContextReset = unchecked((int)33364),
				// GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255
				UnknownContextReset = unchecked((int)33365),
				// GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256
				ResetNotificationStrategy = unchecked((int)33366),
				// GL_NO_RESET_NOTIFICATION_ARB = 0x8261
				NoResetNotification = unchecked((int)33377),
			}
			public const string NAME_STRING = "GL_ARB_robustness";
			#region command delegates
			// GLenum glGetGraphicsResetStatusARB ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetGraphicsResetStatusDelegate ();
			// void glGetnCompressedTexImageARB (GLenum target, GLint lod, GLsizei bufSize, void* img)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnCompressedTexImageDelegate (System.UInt32 target, System.Int32 lod, System.Int32 bufSize, IntPtr img);
			// void glGetnTexImageARB (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnTexImageDelegate (System.UInt32 target, System.Int32 level, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr img);
			// void glGetnUniformdvARB (GLuint program, GLint location, GLsizei bufSize, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformdvDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glGetnUniformfvARB (GLuint program, GLint location, GLsizei bufSize, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformfvDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glGetnUniformivARB (GLuint program, GLint location, GLsizei bufSize, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformivDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glGetnUniformuivARB (GLuint program, GLint location, GLsizei bufSize, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetnUniformuivDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
			// void glReadnPixelsARB (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReadnPixelsDelegate (System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr data);
			#endregion // command delegates
			#region commands
			// GLenum glGetGraphicsResetStatusARB ()
			public readonly GetGraphicsResetStatusDelegate GetGraphicsResetStatus;
			// void glGetnCompressedTexImageARB (GLenum target, GLint lod, GLsizei bufSize, void* img)
			public readonly GetnCompressedTexImageDelegate GetnCompressedTexImage;
			// void glGetnTexImageARB (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img)
			public readonly GetnTexImageDelegate GetnTexImage;
			// void glGetnUniformdvARB (GLuint program, GLint location, GLsizei bufSize, GLdouble* params)
			public readonly GetnUniformdvDelegate GetnUniformdv;
			// void glGetnUniformfvARB (GLuint program, GLint location, GLsizei bufSize, GLfloat* params)
			public readonly GetnUniformfvDelegate GetnUniformfv;
			// void glGetnUniformivARB (GLuint program, GLint location, GLsizei bufSize, GLint* params)
			public readonly GetnUniformivDelegate GetnUniformiv;
			// void glGetnUniformuivARB (GLuint program, GLint location, GLsizei bufSize, GLuint* params)
			public readonly GetnUniformuivDelegate GetnUniformuiv;
			// void glReadnPixelsARB (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)
			public readonly ReadnPixelsDelegate ReadnPixels;
			#endregion // commands
			public ArbRobustness (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetGraphicsResetStatusARB", out GetGraphicsResetStatus);
				resolver.LoadHandle ("glGetnCompressedTexImageARB", out GetnCompressedTexImage);
				resolver.LoadHandle ("glGetnTexImageARB", out GetnTexImage);
				resolver.LoadHandle ("glGetnUniformdvARB", out GetnUniformdv);
				resolver.LoadHandle ("glGetnUniformfvARB", out GetnUniformfv);
				resolver.LoadHandle ("glGetnUniformivARB", out GetnUniformiv);
				resolver.LoadHandle ("glGetnUniformuivARB", out GetnUniformuiv);
				resolver.LoadHandle ("glReadnPixelsARB", out ReadnPixels);
			}
		}
		public partial class ArbSampleLocations
		{
			public enum All
			{
				// GL_SAMPLE_LOCATION_ARB = 0x8E50
				SampleLocation = unchecked((int)36432),
				// GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D
				SampleLocationSubpixelBits = unchecked((int)37693),
				// GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E
				SampleLocationPixelGridWidth = unchecked((int)37694),
				// GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F
				SampleLocationPixelGridHeight = unchecked((int)37695),
				// GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340
				ProgrammableSampleLocationTableSize = unchecked((int)37696),
				// GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341
				ProgrammableSampleLocation = unchecked((int)37697),
				// GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342
				FramebufferProgrammableSampleLocations = unchecked((int)37698),
				// GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343
				FramebufferSampleLocationPixelGrid = unchecked((int)37699),
			}
			public const string NAME_STRING = "GL_ARB_sample_locations";
			#region command delegates
			// void glEvaluateDepthValuesARB ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvaluateDepthValuesDelegate ();
			// void glFramebufferSampleLocationsfvARB (GLenum target, GLuint start, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferSampleLocationsfvDelegate (System.UInt32 target, System.UInt32 start, System.Int32 count, IntPtr v);
			// void glNamedFramebufferSampleLocationsfvARB (GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferSampleLocationsfvDelegate (System.UInt32 framebuffer, System.UInt32 start, System.Int32 count, IntPtr v);
			#endregion // command delegates
			#region commands
			// void glEvaluateDepthValuesARB ()
			public readonly EvaluateDepthValuesDelegate EvaluateDepthValues;
			// void glFramebufferSampleLocationsfvARB (GLenum target, GLuint start, GLsizei count, GLfloat* v)
			public readonly FramebufferSampleLocationsfvDelegate FramebufferSampleLocationsfv;
			// void glNamedFramebufferSampleLocationsfvARB (GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v)
			public readonly NamedFramebufferSampleLocationsfvDelegate NamedFramebufferSampleLocationsfv;
			#endregion // commands
			public ArbSampleLocations (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glEvaluateDepthValuesARB", out EvaluateDepthValues);
				resolver.LoadHandle ("glFramebufferSampleLocationsfvARB", out FramebufferSampleLocationsfv);
				resolver.LoadHandle ("glNamedFramebufferSampleLocationsfvARB", out NamedFramebufferSampleLocationsfv);
			}
		}
		public partial class ArbSampleShading
		{
			public enum All
			{
				// GL_SAMPLE_SHADING_ARB = 0x8C36
				SampleShading = unchecked((int)35894),
				// GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37
				MinSampleShadingValue = unchecked((int)35895),
			}
			public const string NAME_STRING = "GL_ARB_sample_shading";
			#region command delegates
			// void glMinSampleShadingARB (GLfloat value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MinSampleShadingDelegate (System.Single value);
			#endregion // command delegates
			#region commands
			// void glMinSampleShadingARB (GLfloat value)
			public readonly MinSampleShadingDelegate MinSampleShading;
			#endregion // commands
			public ArbSampleShading (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMinSampleShadingARB", out MinSampleShading);
			}
		}
		public partial class ArbShaderObjects
		{
			public enum All
			{
				// GL_PROGRAM_OBJECT_ARB = 0x8B40
				ProgramObject = unchecked((int)35648),
				// GL_SHADER_OBJECT_ARB = 0x8B48
				ShaderObject = unchecked((int)35656),
				// GL_OBJECT_TYPE_ARB = 0x8B4E
				ObjectType = unchecked((int)35662),
				// GL_OBJECT_SUBTYPE_ARB = 0x8B4F
				ObjectSubtype = unchecked((int)35663),
				// GL_FLOAT_VEC2_ARB = 0x8B50
				FloatVec2 = unchecked((int)35664),
				// GL_FLOAT_VEC3_ARB = 0x8B51
				FloatVec3 = unchecked((int)35665),
				// GL_FLOAT_VEC4_ARB = 0x8B52
				FloatVec4 = unchecked((int)35666),
				// GL_INT_VEC2_ARB = 0x8B53
				IntVec2 = unchecked((int)35667),
				// GL_INT_VEC3_ARB = 0x8B54
				IntVec3 = unchecked((int)35668),
				// GL_INT_VEC4_ARB = 0x8B55
				IntVec4 = unchecked((int)35669),
				// GL_BOOL_ARB = 0x8B56
				Bool = unchecked((int)35670),
				// GL_BOOL_VEC2_ARB = 0x8B57
				BoolVec2 = unchecked((int)35671),
				// GL_BOOL_VEC3_ARB = 0x8B58
				BoolVec3 = unchecked((int)35672),
				// GL_BOOL_VEC4_ARB = 0x8B59
				BoolVec4 = unchecked((int)35673),
				// GL_FLOAT_MAT2_ARB = 0x8B5A
				FloatMat2 = unchecked((int)35674),
				// GL_FLOAT_MAT3_ARB = 0x8B5B
				FloatMat3 = unchecked((int)35675),
				// GL_FLOAT_MAT4_ARB = 0x8B5C
				FloatMat4 = unchecked((int)35676),
				// GL_SAMPLER_1D_ARB = 0x8B5D
				Sampler1d = unchecked((int)35677),
				// GL_SAMPLER_2D_ARB = 0x8B5E
				Sampler2d = unchecked((int)35678),
				// GL_SAMPLER_3D_ARB = 0x8B5F
				Sampler3d = unchecked((int)35679),
				// GL_SAMPLER_CUBE_ARB = 0x8B60
				SamplerCube = unchecked((int)35680),
				// GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
				Sampler1dShadow = unchecked((int)35681),
				// GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
				Sampler2dShadow = unchecked((int)35682),
				// GL_SAMPLER_2D_RECT_ARB = 0x8B63
				Sampler2dRect = unchecked((int)35683),
				// GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
				Sampler2dRectShadow = unchecked((int)35684),
				// GL_OBJECT_DELETE_STATUS_ARB = 0x8B80
				ObjectDeleteStatus = unchecked((int)35712),
				// GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81
				ObjectCompileStatus = unchecked((int)35713),
				// GL_OBJECT_LINK_STATUS_ARB = 0x8B82
				ObjectLinkStatus = unchecked((int)35714),
				// GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83
				ObjectValidateStatus = unchecked((int)35715),
				// GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84
				ObjectInfoLogLength = unchecked((int)35716),
				// GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85
				ObjectAttachedObjects = unchecked((int)35717),
				// GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86
				ObjectActiveUniforms = unchecked((int)35718),
				// GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87
				ObjectActiveUniformMaxLength = unchecked((int)35719),
				// GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88
				ObjectShaderSourceLength = unchecked((int)35720),
			}
			public const string NAME_STRING = "GL_ARB_shader_objects";
			#region command delegates
			// void glAttachObjectARB (GLhandleARB containerObj, GLhandleARB obj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AttachObjectDelegate (System.IntPtr containerObj, System.IntPtr obj);
			// void glCompileShaderARB (GLhandleARB shaderObj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompileShaderDelegate (System.IntPtr shaderObj);
			// GLhandleARB glCreateProgramObjectARB ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateProgramObjectDelegate ();
			// GLhandleARB glCreateShaderObjectARB (GLenum shaderType)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr CreateShaderObjectDelegate (System.UInt32 shaderType);
			// void glDeleteObjectARB (GLhandleARB obj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteObjectDelegate (System.IntPtr obj);
			// void glDetachObjectARB (GLhandleARB containerObj, GLhandleARB attachedObj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DetachObjectDelegate (System.IntPtr containerObj, System.IntPtr attachedObj);
			// void glGetActiveUniformARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetActiveUniformDelegate (System.IntPtr programObj, System.UInt32 index, System.Int32 maxLength, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
			// void glGetAttachedObjectsARB (GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetAttachedObjectsDelegate (System.IntPtr containerObj, System.Int32 maxCount, IntPtr count, IntPtr obj);
			// GLhandleARB glGetHandleARB (GLenum pname)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr GetHandleDelegate (System.UInt32 pname);
			// void glGetInfoLogARB (GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* infoLog)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetInfoLogDelegate (System.IntPtr obj, System.Int32 maxLength, IntPtr length, IntPtr infoLog);
			// void glGetObjectParameterfvARB (GLhandleARB obj, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectParameterfvDelegate (System.IntPtr obj, System.UInt32 pname, IntPtr @params);
			// void glGetObjectParameterivARB (GLhandleARB obj, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectParameterivDelegate (System.IntPtr obj, System.UInt32 pname, IntPtr @params);
			// void glGetShaderSourceARB (GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* source)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetShaderSourceDelegate (System.IntPtr obj, System.Int32 maxLength, IntPtr length, IntPtr source);
			// void glGetUniformfvARB (GLhandleARB programObj, GLint location, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformfvDelegate (System.IntPtr programObj, System.Int32 location, IntPtr @params);
			// void glGetUniformivARB (GLhandleARB programObj, GLint location, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformivDelegate (System.IntPtr programObj, System.Int32 location, IntPtr @params);
			// GLint glGetUniformLocationARB (GLhandleARB programObj, GLcharARB* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetUniformLocationDelegate (System.IntPtr programObj, StringPtr name);
			// void glLinkProgramARB (GLhandleARB programObj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LinkProgramDelegate (System.IntPtr programObj);
			// void glShaderSourceARB (GLhandleARB shaderObj, GLsizei count, GLcharARB** string, GLint* length)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ShaderSourceDelegate (System.IntPtr shaderObj, System.Int32 count, IntPtr @string, IntPtr length);
			// void glUniform1fARB (GLint location, GLfloat v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1fDelegate (System.Int32 location, System.Single v0);
			// void glUniform1fvARB (GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform1iARB (GLint location, GLint v0)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1iDelegate (System.Int32 location, System.Int32 v0);
			// void glUniform1ivARB (GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2fARB (GLint location, GLfloat v0, GLfloat v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2fDelegate (System.Int32 location, System.Single v0, System.Single v1);
			// void glUniform2fvARB (GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2iARB (GLint location, GLint v0, GLint v1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1);
			// void glUniform2ivARB (GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3fDelegate (System.Int32 location, System.Single v0, System.Single v1, System.Single v2);
			// void glUniform3fvARB (GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3iARB (GLint location, GLint v0, GLint v1, GLint v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2);
			// void glUniform3ivARB (GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4fDelegate (System.Int32 location, System.Single v0, System.Single v1, System.Single v2, System.Single v3);
			// void glUniform4fvARB (GLint location, GLsizei count, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4iARB (GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3);
			// void glUniform4ivARB (GLint location, GLsizei count, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniformMatrix2fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformMatrix2fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glUniformMatrix3fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformMatrix3fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glUniformMatrix4fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformMatrix4fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
			// void glUseProgramObjectARB (GLhandleARB programObj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UseProgramObjectDelegate (System.IntPtr programObj);
			// void glValidateProgramARB (GLhandleARB programObj)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ValidateProgramDelegate (System.IntPtr programObj);
			#endregion // command delegates
			#region commands
			// void glAttachObjectARB (GLhandleARB containerObj, GLhandleARB obj)
			public readonly AttachObjectDelegate AttachObject;
			// void glCompileShaderARB (GLhandleARB shaderObj)
			public readonly CompileShaderDelegate CompileShader;
			// GLhandleARB glCreateProgramObjectARB ()
			public readonly CreateProgramObjectDelegate CreateProgramObject;
			// GLhandleARB glCreateShaderObjectARB (GLenum shaderType)
			public readonly CreateShaderObjectDelegate CreateShaderObject;
			// void glDeleteObjectARB (GLhandleARB obj)
			public readonly DeleteObjectDelegate DeleteObject;
			// void glDetachObjectARB (GLhandleARB containerObj, GLhandleARB attachedObj)
			public readonly DetachObjectDelegate DetachObject;
			// void glGetActiveUniformARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name)
			public readonly GetActiveUniformDelegate GetActiveUniform;
			// void glGetAttachedObjectsARB (GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj)
			public readonly GetAttachedObjectsDelegate GetAttachedObjects;
			// GLhandleARB glGetHandleARB (GLenum pname)
			public readonly GetHandleDelegate GetHandle;
			// void glGetInfoLogARB (GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* infoLog)
			public readonly GetInfoLogDelegate GetInfoLog;
			// void glGetObjectParameterfvARB (GLhandleARB obj, GLenum pname, GLfloat* params)
			public readonly GetObjectParameterfvDelegate GetObjectParameterfv;
			// void glGetObjectParameterivARB (GLhandleARB obj, GLenum pname, GLint* params)
			public readonly GetObjectParameterivDelegate GetObjectParameteriv;
			// void glGetShaderSourceARB (GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* source)
			public readonly GetShaderSourceDelegate GetShaderSource;
			// void glGetUniformfvARB (GLhandleARB programObj, GLint location, GLfloat* params)
			public readonly GetUniformfvDelegate GetUniformfv;
			// void glGetUniformivARB (GLhandleARB programObj, GLint location, GLint* params)
			public readonly GetUniformivDelegate GetUniformiv;
			// GLint glGetUniformLocationARB (GLhandleARB programObj, GLcharARB* name)
			public readonly GetUniformLocationDelegate GetUniformLocation;
			// void glLinkProgramARB (GLhandleARB programObj)
			public readonly LinkProgramDelegate LinkProgram;
			// void glShaderSourceARB (GLhandleARB shaderObj, GLsizei count, GLcharARB** string, GLint* length)
			public readonly ShaderSourceDelegate ShaderSource;
			// void glUniform1fARB (GLint location, GLfloat v0)
			public readonly Uniform1fDelegate Uniform1f;
			// void glUniform1fvARB (GLint location, GLsizei count, GLfloat* value)
			public readonly Uniform1fvDelegate Uniform1fv;
			// void glUniform1iARB (GLint location, GLint v0)
			public readonly Uniform1iDelegate Uniform1i;
			// void glUniform1ivARB (GLint location, GLsizei count, GLint* value)
			public readonly Uniform1ivDelegate Uniform1iv;
			// void glUniform2fARB (GLint location, GLfloat v0, GLfloat v1)
			public readonly Uniform2fDelegate Uniform2f;
			// void glUniform2fvARB (GLint location, GLsizei count, GLfloat* value)
			public readonly Uniform2fvDelegate Uniform2fv;
			// void glUniform2iARB (GLint location, GLint v0, GLint v1)
			public readonly Uniform2iDelegate Uniform2i;
			// void glUniform2ivARB (GLint location, GLsizei count, GLint* value)
			public readonly Uniform2ivDelegate Uniform2iv;
			// void glUniform3fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
			public readonly Uniform3fDelegate Uniform3f;
			// void glUniform3fvARB (GLint location, GLsizei count, GLfloat* value)
			public readonly Uniform3fvDelegate Uniform3fv;
			// void glUniform3iARB (GLint location, GLint v0, GLint v1, GLint v2)
			public readonly Uniform3iDelegate Uniform3i;
			// void glUniform3ivARB (GLint location, GLsizei count, GLint* value)
			public readonly Uniform3ivDelegate Uniform3iv;
			// void glUniform4fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
			public readonly Uniform4fDelegate Uniform4f;
			// void glUniform4fvARB (GLint location, GLsizei count, GLfloat* value)
			public readonly Uniform4fvDelegate Uniform4fv;
			// void glUniform4iARB (GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
			public readonly Uniform4iDelegate Uniform4i;
			// void glUniform4ivARB (GLint location, GLsizei count, GLint* value)
			public readonly Uniform4ivDelegate Uniform4iv;
			// void glUniformMatrix2fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly UniformMatrix2fvDelegate UniformMatrix2fv;
			// void glUniformMatrix3fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly UniformMatrix3fvDelegate UniformMatrix3fv;
			// void glUniformMatrix4fvARB (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
			public readonly UniformMatrix4fvDelegate UniformMatrix4fv;
			// void glUseProgramObjectARB (GLhandleARB programObj)
			public readonly UseProgramObjectDelegate UseProgramObject;
			// void glValidateProgramARB (GLhandleARB programObj)
			public readonly ValidateProgramDelegate ValidateProgram;
			#endregion // commands
			public ArbShaderObjects (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAttachObjectARB", out AttachObject);
				resolver.LoadHandle ("glCompileShaderARB", out CompileShader);
				resolver.LoadHandle ("glCreateProgramObjectARB", out CreateProgramObject);
				resolver.LoadHandle ("glCreateShaderObjectARB", out CreateShaderObject);
				resolver.LoadHandle ("glDeleteObjectARB", out DeleteObject);
				resolver.LoadHandle ("glDetachObjectARB", out DetachObject);
				resolver.LoadHandle ("glGetActiveUniformARB", out GetActiveUniform);
				resolver.LoadHandle ("glGetAttachedObjectsARB", out GetAttachedObjects);
				resolver.LoadHandle ("glGetHandleARB", out GetHandle);
				resolver.LoadHandle ("glGetInfoLogARB", out GetInfoLog);
				resolver.LoadHandle ("glGetObjectParameterfvARB", out GetObjectParameterfv);
				resolver.LoadHandle ("glGetObjectParameterivARB", out GetObjectParameteriv);
				resolver.LoadHandle ("glGetShaderSourceARB", out GetShaderSource);
				resolver.LoadHandle ("glGetUniformfvARB", out GetUniformfv);
				resolver.LoadHandle ("glGetUniformivARB", out GetUniformiv);
				resolver.LoadHandle ("glGetUniformLocationARB", out GetUniformLocation);
				resolver.LoadHandle ("glLinkProgramARB", out LinkProgram);
				resolver.LoadHandle ("glShaderSourceARB", out ShaderSource);
				resolver.LoadHandle ("glUniform1fARB", out Uniform1f);
				resolver.LoadHandle ("glUniform1fvARB", out Uniform1fv);
				resolver.LoadHandle ("glUniform1iARB", out Uniform1i);
				resolver.LoadHandle ("glUniform1ivARB", out Uniform1iv);
				resolver.LoadHandle ("glUniform2fARB", out Uniform2f);
				resolver.LoadHandle ("glUniform2fvARB", out Uniform2fv);
				resolver.LoadHandle ("glUniform2iARB", out Uniform2i);
				resolver.LoadHandle ("glUniform2ivARB", out Uniform2iv);
				resolver.LoadHandle ("glUniform3fARB", out Uniform3f);
				resolver.LoadHandle ("glUniform3fvARB", out Uniform3fv);
				resolver.LoadHandle ("glUniform3iARB", out Uniform3i);
				resolver.LoadHandle ("glUniform3ivARB", out Uniform3iv);
				resolver.LoadHandle ("glUniform4fARB", out Uniform4f);
				resolver.LoadHandle ("glUniform4fvARB", out Uniform4fv);
				resolver.LoadHandle ("glUniform4iARB", out Uniform4i);
				resolver.LoadHandle ("glUniform4ivARB", out Uniform4iv);
				resolver.LoadHandle ("glUniformMatrix2fvARB", out UniformMatrix2fv);
				resolver.LoadHandle ("glUniformMatrix3fvARB", out UniformMatrix3fv);
				resolver.LoadHandle ("glUniformMatrix4fvARB", out UniformMatrix4fv);
				resolver.LoadHandle ("glUseProgramObjectARB", out UseProgramObject);
				resolver.LoadHandle ("glValidateProgramARB", out ValidateProgram);
			}
		}
		public partial class ArbShadingLanguage100
		{
			public enum All
			{
				// GL_SHADING_LANGUAGE_VERSION_ARB = 0x8B8C
				ShadingLanguageVersion = unchecked((int)35724),
			}
			public const string NAME_STRING = "GL_ARB_shading_language_100";
		}
		public partial class ArbShadingLanguageInclude
		{
			public enum All
			{
				// GL_SHADER_INCLUDE_ARB = 0x8DAE
				ShaderInclude = unchecked((int)36270),
				// GL_NAMED_STRING_LENGTH_ARB = 0x8DE9
				NamedStringLength = unchecked((int)36329),
				// GL_NAMED_STRING_TYPE_ARB = 0x8DEA
				NamedStringType = unchecked((int)36330),
			}
			public const string NAME_STRING = "GL_ARB_shading_language_include";
			#region command delegates
			// void glCompileShaderIncludeARB (GLuint shader, GLsizei count, GLchar** path, GLint* length)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompileShaderIncludeDelegate (System.UInt32 shader, System.Int32 count, IntPtr path, IntPtr length);
			// void glDeleteNamedStringARB (GLint namelen, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteNamedStringDelegate (System.Int32 namelen, IntPtr name);
			// void glGetNamedStringARB (GLint namelen, GLchar* name, GLsizei bufSize, GLint* stringlen, GLchar* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedStringDelegate (System.Int32 namelen, IntPtr name, System.Int32 bufSize, IntPtr stringlen, IntPtr @string);
			// void glGetNamedStringivARB (GLint namelen, GLchar* name, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedStringivDelegate (System.Int32 namelen, IntPtr name, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsNamedStringARB (GLint namelen, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsNamedStringDelegate (System.Int32 namelen, IntPtr name);
			// void glNamedStringARB (GLenum type, GLint namelen, GLchar* name, GLint stringlen, GLchar* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedStringDelegate (System.UInt32 type, System.Int32 namelen, IntPtr name, System.Int32 stringlen, IntPtr @string);
			#endregion // command delegates
			#region commands
			// void glCompileShaderIncludeARB (GLuint shader, GLsizei count, GLchar** path, GLint* length)
			public readonly CompileShaderIncludeDelegate CompileShaderInclude;
			// void glDeleteNamedStringARB (GLint namelen, GLchar* name)
			public readonly DeleteNamedStringDelegate DeleteNamedString;
			// void glGetNamedStringARB (GLint namelen, GLchar* name, GLsizei bufSize, GLint* stringlen, GLchar* string)
			public readonly GetNamedStringDelegate GetNamedString;
			// void glGetNamedStringivARB (GLint namelen, GLchar* name, GLenum pname, GLint* params)
			public readonly GetNamedStringivDelegate GetNamedStringiv;
			// GLboolean glIsNamedStringARB (GLint namelen, GLchar* name)
			public readonly IsNamedStringDelegate IsNamedString;
			// void glNamedStringARB (GLenum type, GLint namelen, GLchar* name, GLint stringlen, GLchar* string)
			public readonly NamedStringDelegate NamedString;
			#endregion // commands
			public ArbShadingLanguageInclude (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCompileShaderIncludeARB", out CompileShaderInclude);
				resolver.LoadHandle ("glDeleteNamedStringARB", out DeleteNamedString);
				resolver.LoadHandle ("glGetNamedStringARB", out GetNamedString);
				resolver.LoadHandle ("glGetNamedStringivARB", out GetNamedStringiv);
				resolver.LoadHandle ("glIsNamedStringARB", out IsNamedString);
				resolver.LoadHandle ("glNamedStringARB", out NamedString);
			}
		}
		public partial class ArbShadow
		{
			public enum All
			{
				// GL_TEXTURE_COMPARE_MODE_ARB = 0x884C
				TextureCompareMode = unchecked((int)34892),
				// GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D
				TextureCompareFunc = unchecked((int)34893),
				// GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E
				CompareRToTexture = unchecked((int)34894),
			}
			public const string NAME_STRING = "GL_ARB_shadow";
		}
		public partial class ArbShadowAmbient
		{
			public enum All
			{
				// GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF
				TextureCompareFailValue = unchecked((int)32959),
			}
			public const string NAME_STRING = "GL_ARB_shadow_ambient";
		}
		public partial class ArbSparseBuffer
		{
			public enum All
			{
				// GL_SPARSE_STORAGE_BIT_ARB = 0x400
				SparseStorageBit = unchecked((int)1024),
				// GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8
				SparseBufferPageSize = unchecked((int)33528),
			}
			public const string NAME_STRING = "GL_ARB_sparse_buffer";
			#region command delegates
			// void glBufferPageCommitmentARB (GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BufferPageCommitmentDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size, System.Boolean commit);
			// void glNamedBufferPageCommitmentARB (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedBufferPageCommitmentARB_Delegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, System.Boolean commit);
			// void glNamedBufferPageCommitmentEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedBufferPageCommitmentEXT_Delegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, System.Boolean commit);
			#endregion // command delegates
			#region commands
			// void glBufferPageCommitmentARB (GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit)
			public readonly BufferPageCommitmentDelegate BufferPageCommitment;
			// void glNamedBufferPageCommitmentARB (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
			public readonly NamedBufferPageCommitmentARB_Delegate NamedBufferPageCommitmentARB_;
			// void glNamedBufferPageCommitmentEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
			public readonly NamedBufferPageCommitmentEXT_Delegate NamedBufferPageCommitmentEXT_;
			#endregion // commands
			public ArbSparseBuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBufferPageCommitmentARB", out BufferPageCommitment);
				resolver.LoadHandle ("glNamedBufferPageCommitmentARB", out NamedBufferPageCommitmentARB_);
				resolver.LoadHandle ("glNamedBufferPageCommitmentEXT", out NamedBufferPageCommitmentEXT_);
			}
		}
		public partial class ArbSparseTexture
		{
			public enum All
			{
				// GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195
				VirtualPageSizeX = unchecked((int)37269),
				// GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196
				VirtualPageSizeY = unchecked((int)37270),
				// GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197
				VirtualPageSizeZ = unchecked((int)37271),
				// GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198
				MaxSparseTextureSize = unchecked((int)37272),
				// GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199
				MaxSparse3dTextureSize = unchecked((int)37273),
				// GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A
				MaxSparseArrayTextureLayers = unchecked((int)37274),
				// GL_TEXTURE_SPARSE_ARB = 0x91A6
				TextureSparse = unchecked((int)37286),
				// GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7
				VirtualPageSizeIndex = unchecked((int)37287),
				// GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8
				NumVirtualPageSizes = unchecked((int)37288),
				// GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9
				SparseTextureFullArrayCubeMipmaps = unchecked((int)37289),
				// GL_NUM_SPARSE_LEVELS_ARB = 0x91AA
				NumSparseLevels = unchecked((int)37290),
			}
			public const string NAME_STRING = "GL_ARB_sparse_texture";
			#region command delegates
			// void glTexPageCommitmentARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexPageCommitmentDelegate (System.UInt32 target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.Boolean commit);
			#endregion // command delegates
			#region commands
			// void glTexPageCommitmentARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean commit)
			public readonly TexPageCommitmentDelegate TexPageCommitment;
			#endregion // commands
			public ArbSparseTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexPageCommitmentARB", out TexPageCommitment);
			}
		}
		public partial class ArbTextureBorderClamp
		{
			public enum All
			{
				// GL_CLAMP_TO_BORDER_ARB = 0x812D
				ClampToBorder = unchecked((int)33069),
			}
			public const string NAME_STRING = "GL_ARB_texture_border_clamp";
		}
		public partial class ArbTextureBufferObject
		{
			public enum All
			{
				// GL_TEXTURE_BUFFER_ARB = 0x8C2A
				TextureBuffer = unchecked((int)35882),
				// GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B
				MaxTextureBufferSize = unchecked((int)35883),
				// GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C
				TextureBindingBuffer = unchecked((int)35884),
				// GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D
				TextureBufferDataStoreBinding = unchecked((int)35885),
				// GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E
				TextureBufferFormat = unchecked((int)35886),
			}
			public const string NAME_STRING = "GL_ARB_texture_buffer_object";
			#region command delegates
			// void glTexBufferARB (GLenum target, GLenum internalformat, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexBufferDelegate (TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer);
			#endregion // command delegates
			#region commands
			// void glTexBufferARB (GLenum target, GLenum internalformat, GLuint buffer)
			public readonly TexBufferDelegate TexBuffer;
			#endregion // commands
			public ArbTextureBufferObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexBufferARB", out TexBuffer);
			}
		}
		public partial class ArbTextureCompression
		{
			public enum All
			{
				// GL_COMPRESSED_ALPHA_ARB = 0x84E9
				CompressedAlpha = unchecked((int)34025),
				// GL_COMPRESSED_LUMINANCE_ARB = 0x84EA
				CompressedLuminance = unchecked((int)34026),
				// GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB
				CompressedLuminanceAlpha = unchecked((int)34027),
				// GL_COMPRESSED_INTENSITY_ARB = 0x84EC
				CompressedIntensity = unchecked((int)34028),
				// GL_COMPRESSED_RGB_ARB = 0x84ED
				CompressedRgb = unchecked((int)34029),
				// GL_COMPRESSED_RGBA_ARB = 0x84EE
				CompressedRgba = unchecked((int)34030),
				// GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
				TextureCompressionHint = unchecked((int)34031),
				// GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0
				TextureCompressedImageSize = unchecked((int)34464),
				// GL_TEXTURE_COMPRESSED_ARB = 0x86A1
				TextureCompressed = unchecked((int)34465),
				// GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2
				NumCompressedTextureFormats = unchecked((int)34466),
				// GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3
				CompressedTextureFormats = unchecked((int)34467),
			}
			public const string NAME_STRING = "GL_ARB_texture_compression";
			#region command delegates
			// void glCompressedTexImage1DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexImage1DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, IntPtr data);
			// void glCompressedTexImage2DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexImage2DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, IntPtr data);
			// void glCompressedTexImage3DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexImage3DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, IntPtr data);
			// void glCompressedTexSubImage1DARB (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, System.Int32 imageSize, IntPtr data);
			// void glCompressedTexSubImage2DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, System.Int32 imageSize, IntPtr data);
			// void glCompressedTexSubImage3DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompressedTexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, System.Int32 imageSize, IntPtr data);
			// void glGetCompressedTexImageARB (GLenum target, GLint level, void* img)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCompressedTexImageDelegate (TextureTarget target, System.Int32 level, IntPtr img);
			#endregion // command delegates
			#region commands
			// void glCompressedTexImage1DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
			public readonly CompressedTexImage1DDelegate CompressedTexImage1D;
			// void glCompressedTexImage2DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
			public readonly CompressedTexImage2DDelegate CompressedTexImage2D;
			// void glCompressedTexImage3DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
			public readonly CompressedTexImage3DDelegate CompressedTexImage3D;
			// void glCompressedTexSubImage1DARB (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
			public readonly CompressedTexSubImage1DDelegate CompressedTexSubImage1D;
			// void glCompressedTexSubImage2DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
			public readonly CompressedTexSubImage2DDelegate CompressedTexSubImage2D;
			// void glCompressedTexSubImage3DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
			public readonly CompressedTexSubImage3DDelegate CompressedTexSubImage3D;
			// void glGetCompressedTexImageARB (GLenum target, GLint level, void* img)
			public readonly GetCompressedTexImageDelegate GetCompressedTexImage;
			#endregion // commands
			public ArbTextureCompression (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCompressedTexImage1DARB", out CompressedTexImage1D);
				resolver.LoadHandle ("glCompressedTexImage2DARB", out CompressedTexImage2D);
				resolver.LoadHandle ("glCompressedTexImage3DARB", out CompressedTexImage3D);
				resolver.LoadHandle ("glCompressedTexSubImage1DARB", out CompressedTexSubImage1D);
				resolver.LoadHandle ("glCompressedTexSubImage2DARB", out CompressedTexSubImage2D);
				resolver.LoadHandle ("glCompressedTexSubImage3DARB", out CompressedTexSubImage3D);
				resolver.LoadHandle ("glGetCompressedTexImageARB", out GetCompressedTexImage);
			}
		}
		public partial class ArbTextureCompressionBptc
		{
			public enum All
			{
				// GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C
				CompressedRgbaBptcUnorm = unchecked((int)36492),
				// GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D
				CompressedSrgbAlphaBptcUnorm = unchecked((int)36493),
				// GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E
				CompressedRgbBptcSignedFloat = unchecked((int)36494),
				// GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F
				CompressedRgbBptcUnsignedFloat = unchecked((int)36495),
			}
			public const string NAME_STRING = "GL_ARB_texture_compression_bptc";
		}
		public partial class ArbTextureCubeMap
		{
			public enum All
			{
				// GL_NORMAL_MAP_ARB = 0x8511
				NormalMap = unchecked((int)34065),
				// GL_REFLECTION_MAP_ARB = 0x8512
				ReflectionMap = unchecked((int)34066),
				// GL_TEXTURE_CUBE_MAP_ARB = 0x8513
				TextureCubeMap = unchecked((int)34067),
				// GL_TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514
				TextureBindingCubeMap = unchecked((int)34068),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515
				TextureCubeMapPositiveX = unchecked((int)34069),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516
				TextureCubeMapNegativeX = unchecked((int)34070),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517
				TextureCubeMapPositiveY = unchecked((int)34071),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518
				TextureCubeMapNegativeY = unchecked((int)34072),
				// GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519
				TextureCubeMapPositiveZ = unchecked((int)34073),
				// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A
				TextureCubeMapNegativeZ = unchecked((int)34074),
				// GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
				ProxyTextureCubeMap = unchecked((int)34075),
				// GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C
				MaxCubeMapTextureSize = unchecked((int)34076),
			}
			public const string NAME_STRING = "GL_ARB_texture_cube_map";
		}
		public partial class ArbTextureCubeMapArray
		{
			public enum All
			{
				// GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
				TextureCubeMapArray = unchecked((int)36873),
				// GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A
				TextureBindingCubeMapArray = unchecked((int)36874),
				// GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
				ProxyTextureCubeMapArray = unchecked((int)36875),
				// GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C
				SamplerCubeMapArray = unchecked((int)36876),
				// GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D
				SamplerCubeMapArrayShadow = unchecked((int)36877),
				// GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E
				IntSamplerCubeMapArray = unchecked((int)36878),
				// GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F
				UnsignedIntSamplerCubeMapArray = unchecked((int)36879),
			}
			public const string NAME_STRING = "GL_ARB_texture_cube_map_array";
		}
		public partial class ArbTextureEnvCombine
		{
			public enum All
			{
				// GL_SUBTRACT_ARB = 0x84E7
				Subtract = unchecked((int)34023),
				// GL_COMBINE_ARB = 0x8570
				Combine = unchecked((int)34160),
				// GL_COMBINE_RGB_ARB = 0x8571
				CombineRgb = unchecked((int)34161),
				// GL_COMBINE_ALPHA_ARB = 0x8572
				CombineAlpha = unchecked((int)34162),
				// GL_RGB_SCALE_ARB = 0x8573
				RgbScale = unchecked((int)34163),
				// GL_ADD_SIGNED_ARB = 0x8574
				AddSigned = unchecked((int)34164),
				// GL_INTERPOLATE_ARB = 0x8575
				Interpolate = unchecked((int)34165),
				// GL_CONSTANT_ARB = 0x8576
				Constant = unchecked((int)34166),
				// GL_PRIMARY_COLOR_ARB = 0x8577
				PrimaryColor = unchecked((int)34167),
				// GL_PREVIOUS_ARB = 0x8578
				Previous = unchecked((int)34168),
				// GL_SOURCE0_RGB_ARB = 0x8580
				Source0Rgb = unchecked((int)34176),
				// GL_SOURCE1_RGB_ARB = 0x8581
				Source1Rgb = unchecked((int)34177),
				// GL_SOURCE2_RGB_ARB = 0x8582
				Source2Rgb = unchecked((int)34178),
				// GL_SOURCE0_ALPHA_ARB = 0x8588
				Source0Alpha = unchecked((int)34184),
				// GL_SOURCE1_ALPHA_ARB = 0x8589
				Source1Alpha = unchecked((int)34185),
				// GL_SOURCE2_ALPHA_ARB = 0x858A
				Source2Alpha = unchecked((int)34186),
				// GL_OPERAND0_RGB_ARB = 0x8590
				Operand0Rgb = unchecked((int)34192),
				// GL_OPERAND1_RGB_ARB = 0x8591
				Operand1Rgb = unchecked((int)34193),
				// GL_OPERAND2_RGB_ARB = 0x8592
				Operand2Rgb = unchecked((int)34194),
				// GL_OPERAND0_ALPHA_ARB = 0x8598
				Operand0Alpha = unchecked((int)34200),
				// GL_OPERAND1_ALPHA_ARB = 0x8599
				Operand1Alpha = unchecked((int)34201),
				// GL_OPERAND2_ALPHA_ARB = 0x859A
				Operand2Alpha = unchecked((int)34202),
			}
			public const string NAME_STRING = "GL_ARB_texture_env_combine";
		}
		public partial class ArbTextureEnvDot3
		{
			public enum All
			{
				// GL_DOT3_RGB_ARB = 0x86AE
				Dot3Rgb = unchecked((int)34478),
				// GL_DOT3_RGBA_ARB = 0x86AF
				Dot3Rgba = unchecked((int)34479),
			}
			public const string NAME_STRING = "GL_ARB_texture_env_dot3";
		}
		public partial class ArbTextureFilterMinmax
		{
			public enum All
			{
				// GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366
				TextureReductionMode = unchecked((int)37734),
				// GL_WEIGHTED_AVERAGE_ARB = 0x9367
				WeightedAverage = unchecked((int)37735),
			}
			public const string NAME_STRING = "GL_ARB_texture_filter_minmax";
		}
		public partial class ArbTextureFloat
		{
			public enum All
			{
				// GL_RGBA32F_ARB = 0x8814
				Rgba32f = unchecked((int)34836),
				// GL_RGB32F_ARB = 0x8815
				Rgb32f = unchecked((int)34837),
				// GL_ALPHA32F_ARB = 0x8816
				Alpha32f = unchecked((int)34838),
				// GL_INTENSITY32F_ARB = 0x8817
				Intensity32f = unchecked((int)34839),
				// GL_LUMINANCE32F_ARB = 0x8818
				Luminance32f = unchecked((int)34840),
				// GL_LUMINANCE_ALPHA32F_ARB = 0x8819
				LuminanceAlpha32f = unchecked((int)34841),
				// GL_RGBA16F_ARB = 0x881A
				Rgba16f = unchecked((int)34842),
				// GL_RGB16F_ARB = 0x881B
				Rgb16f = unchecked((int)34843),
				// GL_ALPHA16F_ARB = 0x881C
				Alpha16f = unchecked((int)34844),
				// GL_INTENSITY16F_ARB = 0x881D
				Intensity16f = unchecked((int)34845),
				// GL_LUMINANCE16F_ARB = 0x881E
				Luminance16f = unchecked((int)34846),
				// GL_LUMINANCE_ALPHA16F_ARB = 0x881F
				LuminanceAlpha16f = unchecked((int)34847),
				// GL_TEXTURE_RED_TYPE_ARB = 0x8C10
				TextureRedType = unchecked((int)35856),
				// GL_TEXTURE_GREEN_TYPE_ARB = 0x8C11
				TextureGreenType = unchecked((int)35857),
				// GL_TEXTURE_BLUE_TYPE_ARB = 0x8C12
				TextureBlueType = unchecked((int)35858),
				// GL_TEXTURE_ALPHA_TYPE_ARB = 0x8C13
				TextureAlphaType = unchecked((int)35859),
				// GL_TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14
				TextureLuminanceType = unchecked((int)35860),
				// GL_TEXTURE_INTENSITY_TYPE_ARB = 0x8C15
				TextureIntensityType = unchecked((int)35861),
				// GL_TEXTURE_DEPTH_TYPE_ARB = 0x8C16
				TextureDepthType = unchecked((int)35862),
				// GL_UNSIGNED_NORMALIZED_ARB = 0x8C17
				UnsignedNormalized = unchecked((int)35863),
			}
			public const string NAME_STRING = "GL_ARB_texture_float";
		}
		public partial class ArbTextureGather
		{
			public enum All
			{
				// GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E
				MinProgramTextureGatherOffset = unchecked((int)36446),
				// GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F
				MaxProgramTextureGatherOffset = unchecked((int)36447),
				// GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F
				MaxProgramTextureGatherComponents = unchecked((int)36767),
			}
			public const string NAME_STRING = "GL_ARB_texture_gather";
		}
		public partial class ArbTextureMirroredRepeat
		{
			public enum All
			{
				// GL_MIRRORED_REPEAT_ARB = 0x8370
				MirroredRepeat = unchecked((int)33648),
			}
			public const string NAME_STRING = "GL_ARB_texture_mirrored_repeat";
		}
		public partial class ArbTextureRectangle
		{
			public enum All
			{
				// GL_TEXTURE_RECTANGLE_ARB = 0x84F5
				TextureRectangle = unchecked((int)34037),
				// GL_TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6
				TextureBindingRectangle = unchecked((int)34038),
				// GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
				ProxyTextureRectangle = unchecked((int)34039),
				// GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8
				MaxRectangleTextureSize = unchecked((int)34040),
			}
			public const string NAME_STRING = "GL_ARB_texture_rectangle";
		}
		public partial class ArbTransformFeedbackOverflowQuery
		{
			public enum All
			{
				// GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC
				TransformFeedbackOverflow = unchecked((int)33516),
				// GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED
				TransformFeedbackStreamOverflow = unchecked((int)33517),
			}
			public const string NAME_STRING = "GL_ARB_transform_feedback_overflow_query";
		}
		public partial class ArbTransposeMatrix
		{
			public enum All
			{
				// GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3
				TransposeModelviewMatrix = unchecked((int)34019),
				// GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4
				TransposeProjectionMatrix = unchecked((int)34020),
				// GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5
				TransposeTextureMatrix = unchecked((int)34021),
				// GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6
				TransposeColorMatrix = unchecked((int)34022),
			}
			public const string NAME_STRING = "GL_ARB_transpose_matrix";
			#region command delegates
			// void glLoadTransposeMatrixdARB (GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadTransposeMatrixdDelegate (IntPtr m);
			// void glLoadTransposeMatrixfARB (GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadTransposeMatrixfDelegate (IntPtr m);
			// void glMultTransposeMatrixdARB (GLdouble* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultTransposeMatrixdDelegate (IntPtr m);
			// void glMultTransposeMatrixfARB (GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultTransposeMatrixfDelegate (IntPtr m);
			#endregion // command delegates
			#region commands
			// void glLoadTransposeMatrixdARB (GLdouble* m)
			public readonly LoadTransposeMatrixdDelegate LoadTransposeMatrixd;
			// void glLoadTransposeMatrixfARB (GLfloat* m)
			public readonly LoadTransposeMatrixfDelegate LoadTransposeMatrixf;
			// void glMultTransposeMatrixdARB (GLdouble* m)
			public readonly MultTransposeMatrixdDelegate MultTransposeMatrixd;
			// void glMultTransposeMatrixfARB (GLfloat* m)
			public readonly MultTransposeMatrixfDelegate MultTransposeMatrixf;
			#endregion // commands
			public ArbTransposeMatrix (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glLoadTransposeMatrixdARB", out LoadTransposeMatrixd);
				resolver.LoadHandle ("glLoadTransposeMatrixfARB", out LoadTransposeMatrixf);
				resolver.LoadHandle ("glMultTransposeMatrixdARB", out MultTransposeMatrixd);
				resolver.LoadHandle ("glMultTransposeMatrixfARB", out MultTransposeMatrixf);
			}
		}
		public partial class ArbVertexBlend
		{
			public enum All
			{
				// GL_MODELVIEW0_ARB = 0x1700
				Modelview0 = unchecked((int)5888),
				// GL_MODELVIEW1_ARB = 0x850A
				Modelview1 = unchecked((int)34058),
				// GL_MAX_VERTEX_UNITS_ARB = 0x86A4
				MaxVertexUnits = unchecked((int)34468),
				// GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5
				ActiveVertexUnits = unchecked((int)34469),
				// GL_WEIGHT_SUM_UNITY_ARB = 0x86A6
				WeightSumUnity = unchecked((int)34470),
				// GL_VERTEX_BLEND_ARB = 0x86A7
				VertexBlend = unchecked((int)34471),
				// GL_CURRENT_WEIGHT_ARB = 0x86A8
				CurrentWeight = unchecked((int)34472),
				// GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9
				WeightArrayType = unchecked((int)34473),
				// GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA
				WeightArrayStride = unchecked((int)34474),
				// GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB
				WeightArraySize = unchecked((int)34475),
				// GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC
				WeightArrayPointer = unchecked((int)34476),
				// GL_WEIGHT_ARRAY_ARB = 0x86AD
				WeightArray = unchecked((int)34477),
				// GL_MODELVIEW2_ARB = 0x8722
				Modelview2 = unchecked((int)34594),
				// GL_MODELVIEW3_ARB = 0x8723
				Modelview3 = unchecked((int)34595),
				// GL_MODELVIEW4_ARB = 0x8724
				Modelview4 = unchecked((int)34596),
				// GL_MODELVIEW5_ARB = 0x8725
				Modelview5 = unchecked((int)34597),
				// GL_MODELVIEW6_ARB = 0x8726
				Modelview6 = unchecked((int)34598),
				// GL_MODELVIEW7_ARB = 0x8727
				Modelview7 = unchecked((int)34599),
				// GL_MODELVIEW8_ARB = 0x8728
				Modelview8 = unchecked((int)34600),
				// GL_MODELVIEW9_ARB = 0x8729
				Modelview9 = unchecked((int)34601),
				// GL_MODELVIEW10_ARB = 0x872A
				Modelview10 = unchecked((int)34602),
				// GL_MODELVIEW11_ARB = 0x872B
				Modelview11 = unchecked((int)34603),
				// GL_MODELVIEW12_ARB = 0x872C
				Modelview12 = unchecked((int)34604),
				// GL_MODELVIEW13_ARB = 0x872D
				Modelview13 = unchecked((int)34605),
				// GL_MODELVIEW14_ARB = 0x872E
				Modelview14 = unchecked((int)34606),
				// GL_MODELVIEW15_ARB = 0x872F
				Modelview15 = unchecked((int)34607),
				// GL_MODELVIEW16_ARB = 0x8730
				Modelview16 = unchecked((int)34608),
				// GL_MODELVIEW17_ARB = 0x8731
				Modelview17 = unchecked((int)34609),
				// GL_MODELVIEW18_ARB = 0x8732
				Modelview18 = unchecked((int)34610),
				// GL_MODELVIEW19_ARB = 0x8733
				Modelview19 = unchecked((int)34611),
				// GL_MODELVIEW20_ARB = 0x8734
				Modelview20 = unchecked((int)34612),
				// GL_MODELVIEW21_ARB = 0x8735
				Modelview21 = unchecked((int)34613),
				// GL_MODELVIEW22_ARB = 0x8736
				Modelview22 = unchecked((int)34614),
				// GL_MODELVIEW23_ARB = 0x8737
				Modelview23 = unchecked((int)34615),
				// GL_MODELVIEW24_ARB = 0x8738
				Modelview24 = unchecked((int)34616),
				// GL_MODELVIEW25_ARB = 0x8739
				Modelview25 = unchecked((int)34617),
				// GL_MODELVIEW26_ARB = 0x873A
				Modelview26 = unchecked((int)34618),
				// GL_MODELVIEW27_ARB = 0x873B
				Modelview27 = unchecked((int)34619),
				// GL_MODELVIEW28_ARB = 0x873C
				Modelview28 = unchecked((int)34620),
				// GL_MODELVIEW29_ARB = 0x873D
				Modelview29 = unchecked((int)34621),
				// GL_MODELVIEW30_ARB = 0x873E
				Modelview30 = unchecked((int)34622),
				// GL_MODELVIEW31_ARB = 0x873F
				Modelview31 = unchecked((int)34623),
			}
			public const string NAME_STRING = "GL_ARB_vertex_blend";
			#region command delegates
			// void glVertexBlendARB (GLint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexBlendDelegate (System.Int32 count);
			// void glWeightbvARB (GLint size, GLbyte* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightbvDelegate (System.Int32 size, IntPtr weights);
			// void glWeightdvARB (GLint size, GLdouble* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightdvDelegate (System.Int32 size, IntPtr weights);
			// void glWeightfvARB (GLint size, GLfloat* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightfvDelegate (System.Int32 size, IntPtr weights);
			// void glWeightivARB (GLint size, GLint* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightivDelegate (System.Int32 size, IntPtr weights);
			// void glWeightPointerARB (GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightPointerDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			// void glWeightsvARB (GLint size, GLshort* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightsvDelegate (System.Int32 size, IntPtr weights);
			// void glWeightubvARB (GLint size, GLubyte* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightubvDelegate (System.Int32 size, IntPtr weights);
			// void glWeightuivARB (GLint size, GLuint* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightuivDelegate (System.Int32 size, IntPtr weights);
			// void glWeightusvARB (GLint size, GLushort* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightusvDelegate (System.Int32 size, IntPtr weights);
			#endregion // command delegates
			#region commands
			// void glVertexBlendARB (GLint count)
			public readonly VertexBlendDelegate VertexBlend;
			// void glWeightbvARB (GLint size, GLbyte* weights)
			public readonly WeightbvDelegate Weightbv;
			// void glWeightdvARB (GLint size, GLdouble* weights)
			public readonly WeightdvDelegate Weightdv;
			// void glWeightfvARB (GLint size, GLfloat* weights)
			public readonly WeightfvDelegate Weightfv;
			// void glWeightivARB (GLint size, GLint* weights)
			public readonly WeightivDelegate Weightiv;
			// void glWeightPointerARB (GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly WeightPointerDelegate WeightPointer;
			// void glWeightsvARB (GLint size, GLshort* weights)
			public readonly WeightsvDelegate Weightsv;
			// void glWeightubvARB (GLint size, GLubyte* weights)
			public readonly WeightubvDelegate Weightubv;
			// void glWeightuivARB (GLint size, GLuint* weights)
			public readonly WeightuivDelegate Weightuiv;
			// void glWeightusvARB (GLint size, GLushort* weights)
			public readonly WeightusvDelegate Weightusv;
			#endregion // commands
			public ArbVertexBlend (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glVertexBlendARB", out VertexBlend);
				resolver.LoadHandle ("glWeightbvARB", out Weightbv);
				resolver.LoadHandle ("glWeightdvARB", out Weightdv);
				resolver.LoadHandle ("glWeightfvARB", out Weightfv);
				resolver.LoadHandle ("glWeightivARB", out Weightiv);
				resolver.LoadHandle ("glWeightPointerARB", out WeightPointer);
				resolver.LoadHandle ("glWeightsvARB", out Weightsv);
				resolver.LoadHandle ("glWeightubvARB", out Weightubv);
				resolver.LoadHandle ("glWeightuivARB", out Weightuiv);
				resolver.LoadHandle ("glWeightusvARB", out Weightusv);
			}
		}
		public partial class ArbVertexBufferObject
		{
			public enum All
			{
				// GL_BUFFER_SIZE_ARB = 0x8764
				BufferSize = unchecked((int)34660),
				// GL_BUFFER_USAGE_ARB = 0x8765
				BufferUsage = unchecked((int)34661),
				// GL_ARRAY_BUFFER_ARB = 0x8892
				ArrayBuffer = unchecked((int)34962),
				// GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893
				ElementArrayBuffer = unchecked((int)34963),
				// GL_ARRAY_BUFFER_BINDING_ARB = 0x8894
				ArrayBufferBinding = unchecked((int)34964),
				// GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895
				ElementArrayBufferBinding = unchecked((int)34965),
				// GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896
				VertexArrayBufferBinding = unchecked((int)34966),
				// GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897
				NormalArrayBufferBinding = unchecked((int)34967),
				// GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898
				ColorArrayBufferBinding = unchecked((int)34968),
				// GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899
				IndexArrayBufferBinding = unchecked((int)34969),
				// GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A
				TextureCoordArrayBufferBinding = unchecked((int)34970),
				// GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B
				EdgeFlagArrayBufferBinding = unchecked((int)34971),
				// GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C
				SecondaryColorArrayBufferBinding = unchecked((int)34972),
				// GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D
				FogCoordinateArrayBufferBinding = unchecked((int)34973),
				// GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E
				WeightArrayBufferBinding = unchecked((int)34974),
				// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F
				VertexAttribArrayBufferBinding = unchecked((int)34975),
				// GL_READ_ONLY_ARB = 0x88B8
				ReadOnly = unchecked((int)35000),
				// GL_WRITE_ONLY_ARB = 0x88B9
				WriteOnly = unchecked((int)35001),
				// GL_READ_WRITE_ARB = 0x88BA
				ReadWrite = unchecked((int)35002),
				// GL_BUFFER_ACCESS_ARB = 0x88BB
				BufferAccess = unchecked((int)35003),
				// GL_BUFFER_MAPPED_ARB = 0x88BC
				BufferMapped = unchecked((int)35004),
				// GL_BUFFER_MAP_POINTER_ARB = 0x88BD
				BufferMapPointer = unchecked((int)35005),
				// GL_STREAM_DRAW_ARB = 0x88E0
				StreamDraw = unchecked((int)35040),
				// GL_STREAM_READ_ARB = 0x88E1
				StreamRead = unchecked((int)35041),
				// GL_STREAM_COPY_ARB = 0x88E2
				StreamCopy = unchecked((int)35042),
				// GL_STATIC_DRAW_ARB = 0x88E4
				StaticDraw = unchecked((int)35044),
				// GL_STATIC_READ_ARB = 0x88E5
				StaticRead = unchecked((int)35045),
				// GL_STATIC_COPY_ARB = 0x88E6
				StaticCopy = unchecked((int)35046),
				// GL_DYNAMIC_DRAW_ARB = 0x88E8
				DynamicDraw = unchecked((int)35048),
				// GL_DYNAMIC_READ_ARB = 0x88E9
				DynamicRead = unchecked((int)35049),
				// GL_DYNAMIC_COPY_ARB = 0x88EA
				DynamicCopy = unchecked((int)35050),
			}
			public const string NAME_STRING = "GL_ARB_vertex_buffer_object";
			#region command delegates
			// void glBindBufferARB (GLenum target, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferDelegate (System.UInt32 target, System.UInt32 buffer);
			// void glBufferDataARB (GLenum target, GLsizeiptrARB size, void* data, GLenum usage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BufferDataDelegate (System.UInt32 target, System.IntPtr size, IntPtr data, System.UInt32 usage);
			// void glBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BufferSubDataDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size, IntPtr data);
			// void glDeleteBuffersARB (GLsizei n, GLuint* buffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteBuffersDelegate (System.Int32 n, IntPtr buffers);
			// void glGenBuffersARB (GLsizei n, GLuint* buffers)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenBuffersDelegate (System.Int32 n, IntPtr buffers);
			// void glGetBufferParameterivARB (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetBufferParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetBufferPointervARB (GLenum target, GLenum pname, void** params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetBufferPointervDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetBufferSubDataDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size, IntPtr data);
			// GLboolean glIsBufferARB (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsBufferDelegate (System.UInt32 buffer);
			// void* glMapBufferARB (GLenum target, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr MapBufferDelegate (System.UInt32 target, System.UInt32 access);
			// GLboolean glUnmapBufferARB (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean UnmapBufferDelegate (System.UInt32 target);
			#endregion // command delegates
			#region commands
			// void glBindBufferARB (GLenum target, GLuint buffer)
			public readonly BindBufferDelegate BindBuffer;
			// void glBufferDataARB (GLenum target, GLsizeiptrARB size, void* data, GLenum usage)
			public readonly BufferDataDelegate BufferData;
			// void glBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data)
			public readonly BufferSubDataDelegate BufferSubData;
			// void glDeleteBuffersARB (GLsizei n, GLuint* buffers)
			public readonly DeleteBuffersDelegate DeleteBuffers;
			// void glGenBuffersARB (GLsizei n, GLuint* buffers)
			public readonly GenBuffersDelegate GenBuffers;
			// void glGetBufferParameterivARB (GLenum target, GLenum pname, GLint* params)
			public readonly GetBufferParameterivDelegate GetBufferParameteriv;
			// void glGetBufferPointervARB (GLenum target, GLenum pname, void** params)
			public readonly GetBufferPointervDelegate GetBufferPointerv;
			// void glGetBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, void* data)
			public readonly GetBufferSubDataDelegate GetBufferSubData;
			// GLboolean glIsBufferARB (GLuint buffer)
			public readonly IsBufferDelegate IsBuffer;
			// void* glMapBufferARB (GLenum target, GLenum access)
			public readonly MapBufferDelegate MapBuffer;
			// GLboolean glUnmapBufferARB (GLenum target)
			public readonly UnmapBufferDelegate UnmapBuffer;
			#endregion // commands
			public ArbVertexBufferObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindBufferARB", out BindBuffer);
				resolver.LoadHandle ("glBufferDataARB", out BufferData);
				resolver.LoadHandle ("glBufferSubDataARB", out BufferSubData);
				resolver.LoadHandle ("glDeleteBuffersARB", out DeleteBuffers);
				resolver.LoadHandle ("glGenBuffersARB", out GenBuffers);
				resolver.LoadHandle ("glGetBufferParameterivARB", out GetBufferParameteriv);
				resolver.LoadHandle ("glGetBufferPointervARB", out GetBufferPointerv);
				resolver.LoadHandle ("glGetBufferSubDataARB", out GetBufferSubData);
				resolver.LoadHandle ("glIsBufferARB", out IsBuffer);
				resolver.LoadHandle ("glMapBufferARB", out MapBuffer);
				resolver.LoadHandle ("glUnmapBufferARB", out UnmapBuffer);
			}
		}
		public partial class ArbVertexProgram
		{
			public enum All
			{
				// GL_COLOR_SUM_ARB = 0x8458
				ColorSum = unchecked((int)33880),
				// GL_VERTEX_PROGRAM_ARB = 0x8620
				VertexProgram = unchecked((int)34336),
				// GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622
				VertexAttribArrayEnabled = unchecked((int)34338),
				// GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623
				VertexAttribArraySize = unchecked((int)34339),
				// GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624
				VertexAttribArrayStride = unchecked((int)34340),
				// GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625
				VertexAttribArrayType = unchecked((int)34341),
				// GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626
				CurrentVertexAttrib = unchecked((int)34342),
				// GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642
				VertexProgramPointSize = unchecked((int)34370),
				// GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643
				VertexProgramTwoSide = unchecked((int)34371),
				// GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645
				VertexAttribArrayPointer = unchecked((int)34373),
				// GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869
				MaxVertexAttribs = unchecked((int)34921),
				// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A
				VertexAttribArrayNormalized = unchecked((int)34922),
				// GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0
				ProgramAddressRegisters = unchecked((int)34992),
				// GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1
				MaxProgramAddressRegisters = unchecked((int)34993),
				// GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2
				ProgramNativeAddressRegisters = unchecked((int)34994),
				// GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3
				MaxProgramNativeAddressRegisters = unchecked((int)34995),
			}
			public const string NAME_STRING = "GL_ARB_vertex_program";
			#region command delegates
			// void glDisableVertexAttribArrayARB (GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableVertexAttribArrayDelegate (System.UInt32 index);
			// void glEnableVertexAttribArrayARB (GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableVertexAttribArrayDelegate (System.UInt32 index);
			// void glGetVertexAttribdvARB (GLuint index, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribdvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribfvARB (GLuint index, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribfvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribivARB (GLuint index, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribPointervARB (GLuint index, GLenum pname, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribPointervDelegate (System.UInt32 index, System.UInt32 pname, IntPtr pointer);
			// void glVertexAttrib1dARB (GLuint index, GLdouble x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1dDelegate (System.UInt32 index, System.Double x);
			// void glVertexAttrib1dvARB (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib1fARB (GLuint index, GLfloat x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1fDelegate (System.UInt32 index, System.Single x);
			// void glVertexAttrib1fvARB (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib1sARB (GLuint index, GLshort x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1sDelegate (System.UInt32 index, System.Int16 x);
			// void glVertexAttrib1svARB (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2dARB (GLuint index, GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2dDelegate (System.UInt32 index, System.Double x, System.Double y);
			// void glVertexAttrib2dvARB (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2fARB (GLuint index, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2fDelegate (System.UInt32 index, System.Single x, System.Single y);
			// void glVertexAttrib2fvARB (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2sARB (GLuint index, GLshort x, GLshort y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y);
			// void glVertexAttrib2svARB (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z);
			// void glVertexAttrib3dvARB (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z);
			// void glVertexAttrib3fvARB (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3sARB (GLuint index, GLshort x, GLshort y, GLshort z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z);
			// void glVertexAttrib3svARB (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4bvARB (GLuint index, GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4bvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glVertexAttrib4dvARB (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glVertexAttrib4fvARB (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4ivARB (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4ivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NbvARB (GLuint index, GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NbvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NivARB (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NsvARB (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NsvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NubARB (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NubDelegate (System.UInt32 index, System.Byte x, System.Byte y, System.Byte z, System.Byte w);
			// void glVertexAttrib4NubvARB (GLuint index, GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NubvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NuivARB (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NuivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4NusvARB (GLuint index, GLushort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4NusvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4sARB (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w);
			// void glVertexAttrib4svARB (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4ubvARB (GLuint index, GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4ubvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4uivARB (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4uivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4usvARB (GLuint index, GLushort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4usvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribPointerARB (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, Boolean normalized, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glDisableVertexAttribArrayARB (GLuint index)
			public readonly DisableVertexAttribArrayDelegate DisableVertexAttribArray;
			// void glEnableVertexAttribArrayARB (GLuint index)
			public readonly EnableVertexAttribArrayDelegate EnableVertexAttribArray;
			// void glGetVertexAttribdvARB (GLuint index, GLenum pname, GLdouble* params)
			public readonly GetVertexAttribdvDelegate GetVertexAttribdv;
			// void glGetVertexAttribfvARB (GLuint index, GLenum pname, GLfloat* params)
			public readonly GetVertexAttribfvDelegate GetVertexAttribfv;
			// void glGetVertexAttribivARB (GLuint index, GLenum pname, GLint* params)
			public readonly GetVertexAttribivDelegate GetVertexAttribiv;
			// void glGetVertexAttribPointervARB (GLuint index, GLenum pname, void** pointer)
			public readonly GetVertexAttribPointervDelegate GetVertexAttribPointerv;
			// void glVertexAttrib1dARB (GLuint index, GLdouble x)
			public readonly VertexAttrib1dDelegate VertexAttrib1d;
			// void glVertexAttrib1dvARB (GLuint index, GLdouble* v)
			public readonly VertexAttrib1dvDelegate VertexAttrib1dv;
			// void glVertexAttrib1fARB (GLuint index, GLfloat x)
			public readonly VertexAttrib1fDelegate VertexAttrib1f;
			// void glVertexAttrib1fvARB (GLuint index, GLfloat* v)
			public readonly VertexAttrib1fvDelegate VertexAttrib1fv;
			// void glVertexAttrib1sARB (GLuint index, GLshort x)
			public readonly VertexAttrib1sDelegate VertexAttrib1s;
			// void glVertexAttrib1svARB (GLuint index, GLshort* v)
			public readonly VertexAttrib1svDelegate VertexAttrib1sv;
			// void glVertexAttrib2dARB (GLuint index, GLdouble x, GLdouble y)
			public readonly VertexAttrib2dDelegate VertexAttrib2d;
			// void glVertexAttrib2dvARB (GLuint index, GLdouble* v)
			public readonly VertexAttrib2dvDelegate VertexAttrib2dv;
			// void glVertexAttrib2fARB (GLuint index, GLfloat x, GLfloat y)
			public readonly VertexAttrib2fDelegate VertexAttrib2f;
			// void glVertexAttrib2fvARB (GLuint index, GLfloat* v)
			public readonly VertexAttrib2fvDelegate VertexAttrib2fv;
			// void glVertexAttrib2sARB (GLuint index, GLshort x, GLshort y)
			public readonly VertexAttrib2sDelegate VertexAttrib2s;
			// void glVertexAttrib2svARB (GLuint index, GLshort* v)
			public readonly VertexAttrib2svDelegate VertexAttrib2sv;
			// void glVertexAttrib3dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			public readonly VertexAttrib3dDelegate VertexAttrib3d;
			// void glVertexAttrib3dvARB (GLuint index, GLdouble* v)
			public readonly VertexAttrib3dvDelegate VertexAttrib3dv;
			// void glVertexAttrib3fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z)
			public readonly VertexAttrib3fDelegate VertexAttrib3f;
			// void glVertexAttrib3fvARB (GLuint index, GLfloat* v)
			public readonly VertexAttrib3fvDelegate VertexAttrib3fv;
			// void glVertexAttrib3sARB (GLuint index, GLshort x, GLshort y, GLshort z)
			public readonly VertexAttrib3sDelegate VertexAttrib3s;
			// void glVertexAttrib3svARB (GLuint index, GLshort* v)
			public readonly VertexAttrib3svDelegate VertexAttrib3sv;
			// void glVertexAttrib4bvARB (GLuint index, GLbyte* v)
			public readonly VertexAttrib4bvDelegate VertexAttrib4bv;
			// void glVertexAttrib4dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly VertexAttrib4dDelegate VertexAttrib4d;
			// void glVertexAttrib4dvARB (GLuint index, GLdouble* v)
			public readonly VertexAttrib4dvDelegate VertexAttrib4dv;
			// void glVertexAttrib4fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly VertexAttrib4fDelegate VertexAttrib4f;
			// void glVertexAttrib4fvARB (GLuint index, GLfloat* v)
			public readonly VertexAttrib4fvDelegate VertexAttrib4fv;
			// void glVertexAttrib4ivARB (GLuint index, GLint* v)
			public readonly VertexAttrib4ivDelegate VertexAttrib4iv;
			// void glVertexAttrib4NbvARB (GLuint index, GLbyte* v)
			public readonly VertexAttrib4NbvDelegate VertexAttrib4Nbv;
			// void glVertexAttrib4NivARB (GLuint index, GLint* v)
			public readonly VertexAttrib4NivDelegate VertexAttrib4Niv;
			// void glVertexAttrib4NsvARB (GLuint index, GLshort* v)
			public readonly VertexAttrib4NsvDelegate VertexAttrib4Nsv;
			// void glVertexAttrib4NubARB (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
			public readonly VertexAttrib4NubDelegate VertexAttrib4Nub;
			// void glVertexAttrib4NubvARB (GLuint index, GLubyte* v)
			public readonly VertexAttrib4NubvDelegate VertexAttrib4Nubv;
			// void glVertexAttrib4NuivARB (GLuint index, GLuint* v)
			public readonly VertexAttrib4NuivDelegate VertexAttrib4Nuiv;
			// void glVertexAttrib4NusvARB (GLuint index, GLushort* v)
			public readonly VertexAttrib4NusvDelegate VertexAttrib4Nusv;
			// void glVertexAttrib4sARB (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
			public readonly VertexAttrib4sDelegate VertexAttrib4s;
			// void glVertexAttrib4svARB (GLuint index, GLshort* v)
			public readonly VertexAttrib4svDelegate VertexAttrib4sv;
			// void glVertexAttrib4ubvARB (GLuint index, GLubyte* v)
			public readonly VertexAttrib4ubvDelegate VertexAttrib4ubv;
			// void glVertexAttrib4uivARB (GLuint index, GLuint* v)
			public readonly VertexAttrib4uivDelegate VertexAttrib4uiv;
			// void glVertexAttrib4usvARB (GLuint index, GLushort* v)
			public readonly VertexAttrib4usvDelegate VertexAttrib4usv;
			// void glVertexAttribPointerARB (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer)
			public readonly VertexAttribPointerDelegate VertexAttribPointer;
			#endregion // commands
			public ArbVertexProgram (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDisableVertexAttribArrayARB", out DisableVertexAttribArray);
				resolver.LoadHandle ("glEnableVertexAttribArrayARB", out EnableVertexAttribArray);
				resolver.LoadHandle ("glGetVertexAttribdvARB", out GetVertexAttribdv);
				resolver.LoadHandle ("glGetVertexAttribfvARB", out GetVertexAttribfv);
				resolver.LoadHandle ("glGetVertexAttribivARB", out GetVertexAttribiv);
				resolver.LoadHandle ("glGetVertexAttribPointervARB", out GetVertexAttribPointerv);
				resolver.LoadHandle ("glVertexAttrib1dARB", out VertexAttrib1d);
				resolver.LoadHandle ("glVertexAttrib1dvARB", out VertexAttrib1dv);
				resolver.LoadHandle ("glVertexAttrib1fARB", out VertexAttrib1f);
				resolver.LoadHandle ("glVertexAttrib1fvARB", out VertexAttrib1fv);
				resolver.LoadHandle ("glVertexAttrib1sARB", out VertexAttrib1s);
				resolver.LoadHandle ("glVertexAttrib1svARB", out VertexAttrib1sv);
				resolver.LoadHandle ("glVertexAttrib2dARB", out VertexAttrib2d);
				resolver.LoadHandle ("glVertexAttrib2dvARB", out VertexAttrib2dv);
				resolver.LoadHandle ("glVertexAttrib2fARB", out VertexAttrib2f);
				resolver.LoadHandle ("glVertexAttrib2fvARB", out VertexAttrib2fv);
				resolver.LoadHandle ("glVertexAttrib2sARB", out VertexAttrib2s);
				resolver.LoadHandle ("glVertexAttrib2svARB", out VertexAttrib2sv);
				resolver.LoadHandle ("glVertexAttrib3dARB", out VertexAttrib3d);
				resolver.LoadHandle ("glVertexAttrib3dvARB", out VertexAttrib3dv);
				resolver.LoadHandle ("glVertexAttrib3fARB", out VertexAttrib3f);
				resolver.LoadHandle ("glVertexAttrib3fvARB", out VertexAttrib3fv);
				resolver.LoadHandle ("glVertexAttrib3sARB", out VertexAttrib3s);
				resolver.LoadHandle ("glVertexAttrib3svARB", out VertexAttrib3sv);
				resolver.LoadHandle ("glVertexAttrib4bvARB", out VertexAttrib4bv);
				resolver.LoadHandle ("glVertexAttrib4dARB", out VertexAttrib4d);
				resolver.LoadHandle ("glVertexAttrib4dvARB", out VertexAttrib4dv);
				resolver.LoadHandle ("glVertexAttrib4fARB", out VertexAttrib4f);
				resolver.LoadHandle ("glVertexAttrib4fvARB", out VertexAttrib4fv);
				resolver.LoadHandle ("glVertexAttrib4ivARB", out VertexAttrib4iv);
				resolver.LoadHandle ("glVertexAttrib4NbvARB", out VertexAttrib4Nbv);
				resolver.LoadHandle ("glVertexAttrib4NivARB", out VertexAttrib4Niv);
				resolver.LoadHandle ("glVertexAttrib4NsvARB", out VertexAttrib4Nsv);
				resolver.LoadHandle ("glVertexAttrib4NubARB", out VertexAttrib4Nub);
				resolver.LoadHandle ("glVertexAttrib4NubvARB", out VertexAttrib4Nubv);
				resolver.LoadHandle ("glVertexAttrib4NuivARB", out VertexAttrib4Nuiv);
				resolver.LoadHandle ("glVertexAttrib4NusvARB", out VertexAttrib4Nusv);
				resolver.LoadHandle ("glVertexAttrib4sARB", out VertexAttrib4s);
				resolver.LoadHandle ("glVertexAttrib4svARB", out VertexAttrib4sv);
				resolver.LoadHandle ("glVertexAttrib4ubvARB", out VertexAttrib4ubv);
				resolver.LoadHandle ("glVertexAttrib4uivARB", out VertexAttrib4uiv);
				resolver.LoadHandle ("glVertexAttrib4usvARB", out VertexAttrib4usv);
				resolver.LoadHandle ("glVertexAttribPointerARB", out VertexAttribPointer);
			}
		}
		public partial class ArbVertexShader
		{
			public enum All
			{
				// GL_VERTEX_SHADER_ARB = 0x8B31
				VertexShader = unchecked((int)35633),
				// GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A
				MaxVertexUniformComponents = unchecked((int)35658),
				// GL_MAX_VARYING_FLOATS_ARB = 0x8B4B
				MaxVaryingFloats = unchecked((int)35659),
				// GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C
				MaxVertexTextureImageUnits = unchecked((int)35660),
				// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D
				MaxCombinedTextureImageUnits = unchecked((int)35661),
				// GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89
				ObjectActiveAttributes = unchecked((int)35721),
				// GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A
				ObjectActiveAttributeMaxLength = unchecked((int)35722),
			}
			public const string NAME_STRING = "GL_ARB_vertex_shader";
			#region command delegates
			// void glBindAttribLocationARB (GLhandleARB programObj, GLuint index, GLcharARB* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindAttribLocationDelegate (System.IntPtr programObj, System.UInt32 index, IntPtr name);
			// void glGetActiveAttribARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetActiveAttribDelegate (System.IntPtr programObj, System.UInt32 index, System.Int32 maxLength, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
			// GLint glGetAttribLocationARB (GLhandleARB programObj, GLcharARB* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetAttribLocationDelegate (System.IntPtr programObj, StringPtr name);
			#endregion // command delegates
			#region commands
			// void glBindAttribLocationARB (GLhandleARB programObj, GLuint index, GLcharARB* name)
			public readonly BindAttribLocationDelegate BindAttribLocation;
			// void glGetActiveAttribARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name)
			public readonly GetActiveAttribDelegate GetActiveAttrib;
			// GLint glGetAttribLocationARB (GLhandleARB programObj, GLcharARB* name)
			public readonly GetAttribLocationDelegate GetAttribLocation;
			#endregion // commands
			public ArbVertexShader (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindAttribLocationARB", out BindAttribLocation);
				resolver.LoadHandle ("glGetActiveAttribARB", out GetActiveAttrib);
				resolver.LoadHandle ("glGetAttribLocationARB", out GetAttribLocation);
			}
		}
		public partial class ArbWindowPos
		{
			public const string NAME_STRING = "GL_ARB_window_pos";
			#region command delegates
			// void glWindowPos2dARB (GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2dDelegate (System.Double x, System.Double y);
			// void glWindowPos2dvARB (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2dvDelegate (IntPtr v);
			// void glWindowPos2fARB (GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2fDelegate (System.Single x, System.Single y);
			// void glWindowPos2fvARB (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2fvDelegate (IntPtr v);
			// void glWindowPos2iARB (GLint x, GLint y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2iDelegate (System.Int32 x, System.Int32 y);
			// void glWindowPos2ivARB (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2ivDelegate (IntPtr v);
			// void glWindowPos2sARB (GLshort x, GLshort y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2sDelegate (System.Int16 x, System.Int16 y);
			// void glWindowPos2svARB (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2svDelegate (IntPtr v);
			// void glWindowPos3dARB (GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3dDelegate (System.Double x, System.Double y, System.Double z);
			// void glWindowPos3dvARB (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3dvDelegate (IntPtr v);
			// void glWindowPos3fARB (GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3fDelegate (System.Single x, System.Single y, System.Single z);
			// void glWindowPos3fvARB (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3fvDelegate (IntPtr v);
			// void glWindowPos3iARB (GLint x, GLint y, GLint z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3iDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glWindowPos3ivARB (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3ivDelegate (IntPtr v);
			// void glWindowPos3sARB (GLshort x, GLshort y, GLshort z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3sDelegate (System.Int16 x, System.Int16 y, System.Int16 z);
			// void glWindowPos3svARB (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3svDelegate (IntPtr v);
			#endregion // command delegates
			#region commands
			// void glWindowPos2dARB (GLdouble x, GLdouble y)
			public readonly WindowPos2dDelegate WindowPos2d;
			// void glWindowPos2dvARB (GLdouble* v)
			public readonly WindowPos2dvDelegate WindowPos2dv;
			// void glWindowPos2fARB (GLfloat x, GLfloat y)
			public readonly WindowPos2fDelegate WindowPos2f;
			// void glWindowPos2fvARB (GLfloat* v)
			public readonly WindowPos2fvDelegate WindowPos2fv;
			// void glWindowPos2iARB (GLint x, GLint y)
			public readonly WindowPos2iDelegate WindowPos2i;
			// void glWindowPos2ivARB (GLint* v)
			public readonly WindowPos2ivDelegate WindowPos2iv;
			// void glWindowPos2sARB (GLshort x, GLshort y)
			public readonly WindowPos2sDelegate WindowPos2s;
			// void glWindowPos2svARB (GLshort* v)
			public readonly WindowPos2svDelegate WindowPos2sv;
			// void glWindowPos3dARB (GLdouble x, GLdouble y, GLdouble z)
			public readonly WindowPos3dDelegate WindowPos3d;
			// void glWindowPos3dvARB (GLdouble* v)
			public readonly WindowPos3dvDelegate WindowPos3dv;
			// void glWindowPos3fARB (GLfloat x, GLfloat y, GLfloat z)
			public readonly WindowPos3fDelegate WindowPos3f;
			// void glWindowPos3fvARB (GLfloat* v)
			public readonly WindowPos3fvDelegate WindowPos3fv;
			// void glWindowPos3iARB (GLint x, GLint y, GLint z)
			public readonly WindowPos3iDelegate WindowPos3i;
			// void glWindowPos3ivARB (GLint* v)
			public readonly WindowPos3ivDelegate WindowPos3iv;
			// void glWindowPos3sARB (GLshort x, GLshort y, GLshort z)
			public readonly WindowPos3sDelegate WindowPos3s;
			// void glWindowPos3svARB (GLshort* v)
			public readonly WindowPos3svDelegate WindowPos3sv;
			#endregion // commands
			public ArbWindowPos (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glWindowPos2dARB", out WindowPos2d);
				resolver.LoadHandle ("glWindowPos2dvARB", out WindowPos2dv);
				resolver.LoadHandle ("glWindowPos2fARB", out WindowPos2f);
				resolver.LoadHandle ("glWindowPos2fvARB", out WindowPos2fv);
				resolver.LoadHandle ("glWindowPos2iARB", out WindowPos2i);
				resolver.LoadHandle ("glWindowPos2ivARB", out WindowPos2iv);
				resolver.LoadHandle ("glWindowPos2sARB", out WindowPos2s);
				resolver.LoadHandle ("glWindowPos2svARB", out WindowPos2sv);
				resolver.LoadHandle ("glWindowPos3dARB", out WindowPos3d);
				resolver.LoadHandle ("glWindowPos3dvARB", out WindowPos3dv);
				resolver.LoadHandle ("glWindowPos3fARB", out WindowPos3f);
				resolver.LoadHandle ("glWindowPos3fvARB", out WindowPos3fv);
				resolver.LoadHandle ("glWindowPos3iARB", out WindowPos3i);
				resolver.LoadHandle ("glWindowPos3ivARB", out WindowPos3iv);
				resolver.LoadHandle ("glWindowPos3sARB", out WindowPos3s);
				resolver.LoadHandle ("glWindowPos3svARB", out WindowPos3sv);
			}
		}
	}
}

