using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class AmdBlendMinmaxFactor
		{
			public enum All
			{
				// GL_FACTOR_MIN_AMD = 0x901C
				FactorMin = unchecked((int)36892),
				// GL_FACTOR_MAX_AMD = 0x901D
				FactorMax = unchecked((int)36893),
			}
			public const string NAME_STRING = "GL_AMD_blend_minmax_factor";
		}
		public partial class AmdDebugOutput
		{
			public enum All
			{
				// GL_MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143
				MaxDebugMessageLength = unchecked((int)37187),
				// GL_MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144
				MaxDebugLoggedMessages = unchecked((int)37188),
				// GL_DEBUG_LOGGED_MESSAGES_AMD = 0x9145
				DebugLoggedMessages = unchecked((int)37189),
				// GL_DEBUG_SEVERITY_HIGH_AMD = 0x9146
				DebugSeverityHigh = unchecked((int)37190),
				// GL_DEBUG_SEVERITY_MEDIUM_AMD = 0x9147
				DebugSeverityMedium = unchecked((int)37191),
				// GL_DEBUG_SEVERITY_LOW_AMD = 0x9148
				DebugSeverityLow = unchecked((int)37192),
				// GL_DEBUG_CATEGORY_API_ERROR_AMD = 0x9149
				DebugCategoryApiError = unchecked((int)37193),
				// GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A
				DebugCategoryWindowSystem = unchecked((int)37194),
				// GL_DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B
				DebugCategoryDeprecation = unchecked((int)37195),
				// GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C
				DebugCategoryUndefinedBehavior = unchecked((int)37196),
				// GL_DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D
				DebugCategoryPerformance = unchecked((int)37197),
				// GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E
				DebugCategoryShaderCompiler = unchecked((int)37198),
				// GL_DEBUG_CATEGORY_APPLICATION_AMD = 0x914F
				DebugCategoryApplication = unchecked((int)37199),
				// GL_DEBUG_CATEGORY_OTHER_AMD = 0x9150
				DebugCategoryOther = unchecked((int)37200),
			}
			public const string NAME_STRING = "GL_AMD_debug_output";
			#region command delegates
			// void glDebugMessageCallbackAMD (GLDEBUGPROCAMD callback, void* userParam)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageCallbackDelegate (System.IntPtr callback, IntPtr userParam);
			// void glDebugMessageEnableAMD (GLenum category, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageEnableDelegate (System.UInt32 category, System.UInt32 severity, System.Int32 count, IntPtr ids, Boolean enabled);
			// void glDebugMessageInsertAMD (GLenum category, GLenum severity, GLuint id, GLsizei length, GLchar* buf)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DebugMessageInsertDelegate (System.UInt32 category, System.UInt32 severity, System.UInt32 id, System.Int32 length, IntPtr buf);
			// GLuint glGetDebugMessageLogAMD (GLuint count, GLsizei bufsize, GLenum* categories, GLuint* severities, GLuint* ids, GLsizei* lengths, GLchar* message)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetDebugMessageLogDelegate (System.UInt32 count, System.Int32 bufsize, IntPtr categories, IntPtr severities, IntPtr ids, IntPtr lengths, IntPtr message);
			#endregion // command delegates
			#region commands
			// void glDebugMessageCallbackAMD (GLDEBUGPROCAMD callback, void* userParam)
			public readonly DebugMessageCallbackDelegate DebugMessageCallback;
			// void glDebugMessageEnableAMD (GLenum category, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
			public readonly DebugMessageEnableDelegate DebugMessageEnable;
			// void glDebugMessageInsertAMD (GLenum category, GLenum severity, GLuint id, GLsizei length, GLchar* buf)
			public readonly DebugMessageInsertDelegate DebugMessageInsert;
			// GLuint glGetDebugMessageLogAMD (GLuint count, GLsizei bufsize, GLenum* categories, GLuint* severities, GLuint* ids, GLsizei* lengths, GLchar* message)
			public readonly GetDebugMessageLogDelegate GetDebugMessageLog;
			#endregion // commands
			public AmdDebugOutput (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDebugMessageCallbackAMD", out DebugMessageCallback);
				resolver.LoadHandle ("glDebugMessageEnableAMD", out DebugMessageEnable);
				resolver.LoadHandle ("glDebugMessageInsertAMD", out DebugMessageInsert);
				resolver.LoadHandle ("glGetDebugMessageLogAMD", out GetDebugMessageLog);
			}
		}
		public partial class AmdDepthClampSeparate
		{
			public enum All
			{
				// GL_DEPTH_CLAMP_NEAR_AMD = 0x901E
				DepthClampNear = unchecked((int)36894),
				// GL_DEPTH_CLAMP_FAR_AMD = 0x901F
				DepthClampFar = unchecked((int)36895),
			}
			public const string NAME_STRING = "GL_AMD_depth_clamp_separate";
		}
		public partial class AmdDrawBuffersBlend
		{
			public const string NAME_STRING = "GL_AMD_draw_buffers_blend";
			#region command delegates
			// void glBlendEquationIndexedAMD (GLuint buf, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationIndexedDelegate (System.UInt32 buf, System.UInt32 mode);
			// void glBlendEquationSeparateIndexedAMD (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendEquationSeparateIndexedDelegate (System.UInt32 buf, System.UInt32 modeRGB, System.UInt32 modeAlpha);
			// void glBlendFuncIndexedAMD (GLuint buf, GLenum src, GLenum dst)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFuncIndexedDelegate (System.UInt32 buf, System.UInt32 src, System.UInt32 dst);
			// void glBlendFuncSeparateIndexedAMD (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendFuncSeparateIndexedDelegate (System.UInt32 buf, System.UInt32 srcRGB, System.UInt32 dstRGB, System.UInt32 srcAlpha, System.UInt32 dstAlpha);
			#endregion // command delegates
			#region commands
			// void glBlendEquationIndexedAMD (GLuint buf, GLenum mode)
			public readonly BlendEquationIndexedDelegate BlendEquationIndexed;
			// void glBlendEquationSeparateIndexedAMD (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
			public readonly BlendEquationSeparateIndexedDelegate BlendEquationSeparateIndexed;
			// void glBlendFuncIndexedAMD (GLuint buf, GLenum src, GLenum dst)
			public readonly BlendFuncIndexedDelegate BlendFuncIndexed;
			// void glBlendFuncSeparateIndexedAMD (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
			public readonly BlendFuncSeparateIndexedDelegate BlendFuncSeparateIndexed;
			#endregion // commands
			public AmdDrawBuffersBlend (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendEquationIndexedAMD", out BlendEquationIndexed);
				resolver.LoadHandle ("glBlendEquationSeparateIndexedAMD", out BlendEquationSeparateIndexed);
				resolver.LoadHandle ("glBlendFuncIndexedAMD", out BlendFuncIndexed);
				resolver.LoadHandle ("glBlendFuncSeparateIndexedAMD", out BlendFuncSeparateIndexed);
			}
		}
		public partial class AmdGpuShaderHalfFloat
		{
			public enum All
			{
				// GL_FLOAT16_NV = 0x8FF8
				Float16 = unchecked((int)36856),
				// GL_FLOAT16_VEC2_NV = 0x8FF9
				Float16Vec2 = unchecked((int)36857),
				// GL_FLOAT16_VEC3_NV = 0x8FFA
				Float16Vec3 = unchecked((int)36858),
				// GL_FLOAT16_VEC4_NV = 0x8FFB
				Float16Vec4 = unchecked((int)36859),
				// GL_FLOAT16_MAT2_AMD = 0x91C5
				Float16Mat2 = unchecked((int)37317),
				// GL_FLOAT16_MAT3_AMD = 0x91C6
				Float16Mat3 = unchecked((int)37318),
				// GL_FLOAT16_MAT4_AMD = 0x91C7
				Float16Mat4 = unchecked((int)37319),
				// GL_FLOAT16_MAT2x3_AMD = 0x91C8
				Float16Mat2x3 = unchecked((int)37320),
				// GL_FLOAT16_MAT2x4_AMD = 0x91C9
				Float16Mat2x4 = unchecked((int)37321),
				// GL_FLOAT16_MAT3x2_AMD = 0x91CA
				Float16Mat3x2 = unchecked((int)37322),
				// GL_FLOAT16_MAT3x4_AMD = 0x91CB
				Float16Mat3x4 = unchecked((int)37323),
				// GL_FLOAT16_MAT4x2_AMD = 0x91CC
				Float16Mat4x2 = unchecked((int)37324),
				// GL_FLOAT16_MAT4x3_AMD = 0x91CD
				Float16Mat4x3 = unchecked((int)37325),
			}
			public const string NAME_STRING = "GL_AMD_gpu_shader_half_float";
		}
		public partial class AmdGpuShaderInt64
		{
			public enum All
			{
				// GL_INT64_NV = 0x140E
				Int64 = unchecked((int)5134),
				// GL_UNSIGNED_INT64_NV = 0x140F
				UnsignedInt64 = unchecked((int)5135),
				// GL_INT8_NV = 0x8FE0
				Int8 = unchecked((int)36832),
				// GL_INT8_VEC2_NV = 0x8FE1
				Int8Vec2 = unchecked((int)36833),
				// GL_INT8_VEC3_NV = 0x8FE2
				Int8Vec3 = unchecked((int)36834),
				// GL_INT8_VEC4_NV = 0x8FE3
				Int8Vec4 = unchecked((int)36835),
				// GL_INT16_NV = 0x8FE4
				Int16 = unchecked((int)36836),
				// GL_INT16_VEC2_NV = 0x8FE5
				Int16Vec2 = unchecked((int)36837),
				// GL_INT16_VEC3_NV = 0x8FE6
				Int16Vec3 = unchecked((int)36838),
				// GL_INT16_VEC4_NV = 0x8FE7
				Int16Vec4 = unchecked((int)36839),
				// GL_INT64_VEC2_NV = 0x8FE9
				Int64Vec2 = unchecked((int)36841),
				// GL_INT64_VEC3_NV = 0x8FEA
				Int64Vec3 = unchecked((int)36842),
				// GL_INT64_VEC4_NV = 0x8FEB
				Int64Vec4 = unchecked((int)36843),
				// GL_UNSIGNED_INT8_NV = 0x8FEC
				UnsignedInt8 = unchecked((int)36844),
				// GL_UNSIGNED_INT8_VEC2_NV = 0x8FED
				UnsignedInt8Vec2 = unchecked((int)36845),
				// GL_UNSIGNED_INT8_VEC3_NV = 0x8FEE
				UnsignedInt8Vec3 = unchecked((int)36846),
				// GL_UNSIGNED_INT8_VEC4_NV = 0x8FEF
				UnsignedInt8Vec4 = unchecked((int)36847),
				// GL_UNSIGNED_INT16_NV = 0x8FF0
				UnsignedInt16 = unchecked((int)36848),
				// GL_UNSIGNED_INT16_VEC2_NV = 0x8FF1
				UnsignedInt16Vec2 = unchecked((int)36849),
				// GL_UNSIGNED_INT16_VEC3_NV = 0x8FF2
				UnsignedInt16Vec3 = unchecked((int)36850),
				// GL_UNSIGNED_INT16_VEC4_NV = 0x8FF3
				UnsignedInt16Vec4 = unchecked((int)36851),
				// GL_UNSIGNED_INT64_VEC2_NV = 0x8FF5
				UnsignedInt64Vec2 = unchecked((int)36853),
				// GL_UNSIGNED_INT64_VEC3_NV = 0x8FF6
				UnsignedInt64Vec3 = unchecked((int)36854),
				// GL_UNSIGNED_INT64_VEC4_NV = 0x8FF7
				UnsignedInt64Vec4 = unchecked((int)36855),
			}
			public const string NAME_STRING = "GL_AMD_gpu_shader_int64";
			#region command delegates
			// void glGetUniformi64vNV (GLuint program, GLint location, GLint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformi64vDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
			// void glGetUniformui64vNV (GLuint program, GLint location, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetUniformui64vDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
			// void glProgramUniform1i64NV (GLuint program, GLint location, GLint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x);
			// void glProgramUniform1i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform1ui64NV (GLuint program, GLint location, GLuint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x);
			// void glProgramUniform1ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform1ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y);
			// void glProgramUniform2i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform2ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y);
			// void glProgramUniform2ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform2ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z);
			// void glProgramUniform3i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform3ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z);
			// void glProgramUniform3ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform3ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4i64Delegate (System.UInt32 program, System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z, System.Int64 w);
			// void glProgramUniform4i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4i64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glProgramUniform4ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4ui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z, System.UInt64 w);
			// void glProgramUniform4ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniform4ui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform1i64NV (GLint location, GLint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1i64Delegate (System.Int32 location, System.Int64 x);
			// void glUniform1i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform1ui64NV (GLint location, GLuint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1ui64Delegate (System.Int32 location, System.UInt64 x);
			// void glUniform1ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform1ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2i64NV (GLint location, GLint64EXT x, GLint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y);
			// void glUniform2i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform2ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y);
			// void glUniform2ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform2ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z);
			// void glUniform3i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform3ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z);
			// void glUniform3ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform3ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4i64Delegate (System.Int32 location, System.Int64 x, System.Int64 y, System.Int64 z, System.Int64 w);
			// void glUniform4i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4i64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniform4ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4ui64Delegate (System.Int32 location, System.UInt64 x, System.UInt64 y, System.UInt64 z, System.UInt64 w);
			// void glUniform4ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniform4ui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			#endregion // command delegates
			#region commands
			// void glGetUniformi64vNV (GLuint program, GLint location, GLint64EXT* params)
			public readonly GetUniformi64vDelegate GetUniformi64v;
			// void glGetUniformui64vNV (GLuint program, GLint location, GLuint64EXT* params)
			public readonly GetUniformui64vDelegate GetUniformui64v;
			// void glProgramUniform1i64NV (GLuint program, GLint location, GLint64EXT x)
			public readonly ProgramUniform1i64Delegate ProgramUniform1i64;
			// void glProgramUniform1i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			public readonly ProgramUniform1i64vDelegate ProgramUniform1i64v;
			// void glProgramUniform1ui64NV (GLuint program, GLint location, GLuint64EXT x)
			public readonly ProgramUniform1ui64Delegate ProgramUniform1ui64;
			// void glProgramUniform1ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			public readonly ProgramUniform1ui64vDelegate ProgramUniform1ui64v;
			// void glProgramUniform2i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y)
			public readonly ProgramUniform2i64Delegate ProgramUniform2i64;
			// void glProgramUniform2i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			public readonly ProgramUniform2i64vDelegate ProgramUniform2i64v;
			// void glProgramUniform2ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y)
			public readonly ProgramUniform2ui64Delegate ProgramUniform2ui64;
			// void glProgramUniform2ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			public readonly ProgramUniform2ui64vDelegate ProgramUniform2ui64v;
			// void glProgramUniform3i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			public readonly ProgramUniform3i64Delegate ProgramUniform3i64;
			// void glProgramUniform3i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			public readonly ProgramUniform3i64vDelegate ProgramUniform3i64v;
			// void glProgramUniform3ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			public readonly ProgramUniform3ui64Delegate ProgramUniform3ui64;
			// void glProgramUniform3ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			public readonly ProgramUniform3ui64vDelegate ProgramUniform3ui64v;
			// void glProgramUniform4i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			public readonly ProgramUniform4i64Delegate ProgramUniform4i64;
			// void glProgramUniform4i64vNV (GLuint program, GLint location, GLsizei count, GLint64EXT* value)
			public readonly ProgramUniform4i64vDelegate ProgramUniform4i64v;
			// void glProgramUniform4ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			public readonly ProgramUniform4ui64Delegate ProgramUniform4ui64;
			// void glProgramUniform4ui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			public readonly ProgramUniform4ui64vDelegate ProgramUniform4ui64v;
			// void glUniform1i64NV (GLint location, GLint64EXT x)
			public readonly Uniform1i64Delegate Uniform1i64;
			// void glUniform1i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			public readonly Uniform1i64vDelegate Uniform1i64v;
			// void glUniform1ui64NV (GLint location, GLuint64EXT x)
			public readonly Uniform1ui64Delegate Uniform1ui64;
			// void glUniform1ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			public readonly Uniform1ui64vDelegate Uniform1ui64v;
			// void glUniform2i64NV (GLint location, GLint64EXT x, GLint64EXT y)
			public readonly Uniform2i64Delegate Uniform2i64;
			// void glUniform2i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			public readonly Uniform2i64vDelegate Uniform2i64v;
			// void glUniform2ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y)
			public readonly Uniform2ui64Delegate Uniform2ui64;
			// void glUniform2ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			public readonly Uniform2ui64vDelegate Uniform2ui64v;
			// void glUniform3i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			public readonly Uniform3i64Delegate Uniform3i64;
			// void glUniform3i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			public readonly Uniform3i64vDelegate Uniform3i64v;
			// void glUniform3ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			public readonly Uniform3ui64Delegate Uniform3ui64;
			// void glUniform3ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			public readonly Uniform3ui64vDelegate Uniform3ui64v;
			// void glUniform4i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			public readonly Uniform4i64Delegate Uniform4i64;
			// void glUniform4i64vNV (GLint location, GLsizei count, GLint64EXT* value)
			public readonly Uniform4i64vDelegate Uniform4i64v;
			// void glUniform4ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			public readonly Uniform4ui64Delegate Uniform4ui64;
			// void glUniform4ui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			public readonly Uniform4ui64vDelegate Uniform4ui64v;
			#endregion // commands
			public AmdGpuShaderInt64 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetUniformi64vNV", out GetUniformi64v);
				resolver.LoadHandle ("glGetUniformui64vNV", out GetUniformui64v);
				resolver.LoadHandle ("glProgramUniform1i64NV", out ProgramUniform1i64);
				resolver.LoadHandle ("glProgramUniform1i64vNV", out ProgramUniform1i64v);
				resolver.LoadHandle ("glProgramUniform1ui64NV", out ProgramUniform1ui64);
				resolver.LoadHandle ("glProgramUniform1ui64vNV", out ProgramUniform1ui64v);
				resolver.LoadHandle ("glProgramUniform2i64NV", out ProgramUniform2i64);
				resolver.LoadHandle ("glProgramUniform2i64vNV", out ProgramUniform2i64v);
				resolver.LoadHandle ("glProgramUniform2ui64NV", out ProgramUniform2ui64);
				resolver.LoadHandle ("glProgramUniform2ui64vNV", out ProgramUniform2ui64v);
				resolver.LoadHandle ("glProgramUniform3i64NV", out ProgramUniform3i64);
				resolver.LoadHandle ("glProgramUniform3i64vNV", out ProgramUniform3i64v);
				resolver.LoadHandle ("glProgramUniform3ui64NV", out ProgramUniform3ui64);
				resolver.LoadHandle ("glProgramUniform3ui64vNV", out ProgramUniform3ui64v);
				resolver.LoadHandle ("glProgramUniform4i64NV", out ProgramUniform4i64);
				resolver.LoadHandle ("glProgramUniform4i64vNV", out ProgramUniform4i64v);
				resolver.LoadHandle ("glProgramUniform4ui64NV", out ProgramUniform4ui64);
				resolver.LoadHandle ("glProgramUniform4ui64vNV", out ProgramUniform4ui64v);
				resolver.LoadHandle ("glUniform1i64NV", out Uniform1i64);
				resolver.LoadHandle ("glUniform1i64vNV", out Uniform1i64v);
				resolver.LoadHandle ("glUniform1ui64NV", out Uniform1ui64);
				resolver.LoadHandle ("glUniform1ui64vNV", out Uniform1ui64v);
				resolver.LoadHandle ("glUniform2i64NV", out Uniform2i64);
				resolver.LoadHandle ("glUniform2i64vNV", out Uniform2i64v);
				resolver.LoadHandle ("glUniform2ui64NV", out Uniform2ui64);
				resolver.LoadHandle ("glUniform2ui64vNV", out Uniform2ui64v);
				resolver.LoadHandle ("glUniform3i64NV", out Uniform3i64);
				resolver.LoadHandle ("glUniform3i64vNV", out Uniform3i64v);
				resolver.LoadHandle ("glUniform3ui64NV", out Uniform3ui64);
				resolver.LoadHandle ("glUniform3ui64vNV", out Uniform3ui64v);
				resolver.LoadHandle ("glUniform4i64NV", out Uniform4i64);
				resolver.LoadHandle ("glUniform4i64vNV", out Uniform4i64v);
				resolver.LoadHandle ("glUniform4ui64NV", out Uniform4ui64);
				resolver.LoadHandle ("glUniform4ui64vNV", out Uniform4ui64v);
			}
		}
		public partial class AmdInterleavedElements
		{
			public enum All
			{
				// GL_VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4
				VertexElementSwizzle = unchecked((int)37284),
				// GL_VERTEX_ID_SWIZZLE_AMD = 0x91A5
				VertexIdSwizzle = unchecked((int)37285),
			}
			public const string NAME_STRING = "GL_AMD_interleaved_elements";
			#region command delegates
			// void glVertexAttribParameteriAMD (GLuint index, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribParameteriDelegate (System.UInt32 index, System.UInt32 pname, System.Int32 param);
			#endregion // command delegates
			#region commands
			// void glVertexAttribParameteriAMD (GLuint index, GLenum pname, GLint param)
			public readonly VertexAttribParameteriDelegate VertexAttribParameteri;
			#endregion // commands
			public AmdInterleavedElements (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glVertexAttribParameteriAMD", out VertexAttribParameteri);
			}
		}
		public partial class AmdMultiDrawIndirect
		{
			public const string NAME_STRING = "GL_AMD_multi_draw_indirect";
			#region command delegates
			// void glMultiDrawArraysIndirectAMD (GLenum mode, void* indirect, GLsizei primcount, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawArraysIndirectDelegate (System.UInt32 mode, IntPtr indirect, System.Int32 primcount, System.Int32 stride);
			// void glMultiDrawElementsIndirectAMD (GLenum mode, GLenum type, void* indirect, GLsizei primcount, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementsIndirectDelegate (System.UInt32 mode, System.UInt32 type, IntPtr indirect, System.Int32 primcount, System.Int32 stride);
			#endregion // command delegates
			#region commands
			// void glMultiDrawArraysIndirectAMD (GLenum mode, void* indirect, GLsizei primcount, GLsizei stride)
			public readonly MultiDrawArraysIndirectDelegate MultiDrawArraysIndirect;
			// void glMultiDrawElementsIndirectAMD (GLenum mode, GLenum type, void* indirect, GLsizei primcount, GLsizei stride)
			public readonly MultiDrawElementsIndirectDelegate MultiDrawElementsIndirect;
			#endregion // commands
			public AmdMultiDrawIndirect (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiDrawArraysIndirectAMD", out MultiDrawArraysIndirect);
				resolver.LoadHandle ("glMultiDrawElementsIndirectAMD", out MultiDrawElementsIndirect);
			}
		}
		public partial class AmdNameGenDelete
		{
			public enum All
			{
				// GL_DATA_BUFFER_AMD = 0x9151
				DataBuffer = unchecked((int)37201),
				// GL_PERFORMANCE_MONITOR_AMD = 0x9152
				PerformanceMonitor = unchecked((int)37202),
				// GL_QUERY_OBJECT_AMD = 0x9153
				QueryObject = unchecked((int)37203),
				// GL_VERTEX_ARRAY_OBJECT_AMD = 0x9154
				VertexArrayObject = unchecked((int)37204),
				// GL_SAMPLER_OBJECT_AMD = 0x9155
				SamplerObject = unchecked((int)37205),
			}
			public const string NAME_STRING = "GL_AMD_name_gen_delete";
			#region command delegates
			// void glDeleteNamesAMD (GLenum identifier, GLuint num, GLuint* names)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteNamesDelegate (System.UInt32 identifier, System.UInt32 num, IntPtr names);
			// void glGenNamesAMD (GLenum identifier, GLuint num, GLuint* names)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenNamesDelegate (System.UInt32 identifier, System.UInt32 num, IntPtr names);
			// GLboolean glIsNameAMD (GLenum identifier, GLuint name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsNameDelegate (System.UInt32 identifier, System.UInt32 name);
			#endregion // command delegates
			#region commands
			// void glDeleteNamesAMD (GLenum identifier, GLuint num, GLuint* names)
			public readonly DeleteNamesDelegate DeleteNames;
			// void glGenNamesAMD (GLenum identifier, GLuint num, GLuint* names)
			public readonly GenNamesDelegate GenNames;
			// GLboolean glIsNameAMD (GLenum identifier, GLuint name)
			public readonly IsNameDelegate IsName;
			#endregion // commands
			public AmdNameGenDelete (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDeleteNamesAMD", out DeleteNames);
				resolver.LoadHandle ("glGenNamesAMD", out GenNames);
				resolver.LoadHandle ("glIsNameAMD", out IsName);
			}
		}
		public partial class AmdOcclusionQueryEvent
		{
			public enum All
			{
				// GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x1
				QueryDepthPassEventBit = unchecked((int)1),
				// GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x2
				QueryDepthFailEventBit = unchecked((int)2),
				// GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x4
				QueryStencilFailEventBit = unchecked((int)4),
				// GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x8
				QueryDepthBoundsFailEventBit = unchecked((int)8),
				// GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F
				OcclusionQueryEventMask = unchecked((int)34639),
				// GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
				QueryAllEventBits = unchecked((int)4294967295),
			}
			public const string NAME_STRING = "GL_AMD_occlusion_query_event";
			#region command delegates
			// void glQueryObjectParameteruiAMD (GLenum target, GLuint id, GLenum pname, GLuint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void QueryObjectParameteruiDelegate (System.UInt32 target, System.UInt32 id, System.UInt32 pname, OcclusionQueryEventMaskAMD param);
			#endregion // command delegates
			#region commands
			// void glQueryObjectParameteruiAMD (GLenum target, GLuint id, GLenum pname, GLuint param)
			public readonly QueryObjectParameteruiDelegate QueryObjectParameterui;
			#endregion // commands
			public AmdOcclusionQueryEvent (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glQueryObjectParameteruiAMD", out QueryObjectParameterui);
			}
		}
		public partial class AmdPerformanceMonitor
		{
			public enum All
			{
				// GL_COUNTER_TYPE_AMD = 0x8BC0
				CounterType = unchecked((int)35776),
				// GL_COUNTER_RANGE_AMD = 0x8BC1
				CounterRange = unchecked((int)35777),
				// GL_UNSIGNED_INT64_AMD = 0x8BC2
				UnsignedInt64 = unchecked((int)35778),
				// GL_PERCENTAGE_AMD = 0x8BC3
				Percentage = unchecked((int)35779),
				// GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4
				PerfmonResultAvailable = unchecked((int)35780),
				// GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5
				PerfmonResultSize = unchecked((int)35781),
				// GL_PERFMON_RESULT_AMD = 0x8BC6
				PerfmonResult = unchecked((int)35782),
			}
			public const string NAME_STRING = "GL_AMD_performance_monitor";
			#region command delegates
			// void glBeginPerfMonitorAMD (GLuint monitor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginPerfMonitorDelegate (System.UInt32 monitor);
			// void glDeletePerfMonitorsAMD (GLsizei n, GLuint* monitors)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeletePerfMonitorsDelegate (System.Int32 n, IntPtr monitors);
			// void glEndPerfMonitorAMD (GLuint monitor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndPerfMonitorDelegate (System.UInt32 monitor);
			// void glGenPerfMonitorsAMD (GLsizei n, GLuint* monitors)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenPerfMonitorsDelegate (System.Int32 n, IntPtr monitors);
			// void glGetPerfMonitorCounterDataAMD (GLuint monitor, GLenum pname, GLsizei dataSize, GLuint* data, GLint* bytesWritten)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorCounterDataDelegate (System.UInt32 monitor, System.UInt32 pname, System.Int32 dataSize, IntPtr data, IntPtr bytesWritten);
			// void glGetPerfMonitorCounterInfoAMD (GLuint group, GLuint counter, GLenum pname, void* data)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorCounterInfoDelegate (System.UInt32 group, System.UInt32 counter, System.UInt32 pname, IntPtr data);
			// void glGetPerfMonitorCountersAMD (GLuint group, GLint* numCounters, GLint* maxActiveCounters, GLsizei counterSize, GLuint* counters)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorCountersDelegate (System.UInt32 group, IntPtr numCounters, IntPtr maxActiveCounters, System.Int32 counterSize, IntPtr counters);
			// void glGetPerfMonitorCounterStringAMD (GLuint group, GLuint counter, GLsizei bufSize, GLsizei* length, GLchar* counterString)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorCounterStringDelegate (System.UInt32 group, System.UInt32 counter, System.Int32 bufSize, IntPtr length, IntPtr counterString);
			// void glGetPerfMonitorGroupsAMD (GLint* numGroups, GLsizei groupsSize, GLuint* groups)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorGroupsDelegate (IntPtr numGroups, System.Int32 groupsSize, IntPtr groups);
			// void glGetPerfMonitorGroupStringAMD (GLuint group, GLsizei bufSize, GLsizei* length, GLchar* groupString)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPerfMonitorGroupStringDelegate (System.UInt32 group, System.Int32 bufSize, IntPtr length, IntPtr groupString);
			// void glSelectPerfMonitorCountersAMD (GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint* counterList)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SelectPerfMonitorCountersDelegate (System.UInt32 monitor, Boolean enable, System.UInt32 group, System.Int32 numCounters, IntPtr counterList);
			#endregion // command delegates
			#region commands
			// void glBeginPerfMonitorAMD (GLuint monitor)
			public readonly BeginPerfMonitorDelegate BeginPerfMonitor;
			// void glDeletePerfMonitorsAMD (GLsizei n, GLuint* monitors)
			public readonly DeletePerfMonitorsDelegate DeletePerfMonitors;
			// void glEndPerfMonitorAMD (GLuint monitor)
			public readonly EndPerfMonitorDelegate EndPerfMonitor;
			// void glGenPerfMonitorsAMD (GLsizei n, GLuint* monitors)
			public readonly GenPerfMonitorsDelegate GenPerfMonitors;
			// void glGetPerfMonitorCounterDataAMD (GLuint monitor, GLenum pname, GLsizei dataSize, GLuint* data, GLint* bytesWritten)
			public readonly GetPerfMonitorCounterDataDelegate GetPerfMonitorCounterData;
			// void glGetPerfMonitorCounterInfoAMD (GLuint group, GLuint counter, GLenum pname, void* data)
			public readonly GetPerfMonitorCounterInfoDelegate GetPerfMonitorCounterInfo;
			// void glGetPerfMonitorCountersAMD (GLuint group, GLint* numCounters, GLint* maxActiveCounters, GLsizei counterSize, GLuint* counters)
			public readonly GetPerfMonitorCountersDelegate GetPerfMonitorCounters;
			// void glGetPerfMonitorCounterStringAMD (GLuint group, GLuint counter, GLsizei bufSize, GLsizei* length, GLchar* counterString)
			public readonly GetPerfMonitorCounterStringDelegate GetPerfMonitorCounterString;
			// void glGetPerfMonitorGroupsAMD (GLint* numGroups, GLsizei groupsSize, GLuint* groups)
			public readonly GetPerfMonitorGroupsDelegate GetPerfMonitorGroups;
			// void glGetPerfMonitorGroupStringAMD (GLuint group, GLsizei bufSize, GLsizei* length, GLchar* groupString)
			public readonly GetPerfMonitorGroupStringDelegate GetPerfMonitorGroupString;
			// void glSelectPerfMonitorCountersAMD (GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint* counterList)
			public readonly SelectPerfMonitorCountersDelegate SelectPerfMonitorCounters;
			#endregion // commands
			public AmdPerformanceMonitor (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginPerfMonitorAMD", out BeginPerfMonitor);
				resolver.LoadHandle ("glDeletePerfMonitorsAMD", out DeletePerfMonitors);
				resolver.LoadHandle ("glEndPerfMonitorAMD", out EndPerfMonitor);
				resolver.LoadHandle ("glGenPerfMonitorsAMD", out GenPerfMonitors);
				resolver.LoadHandle ("glGetPerfMonitorCounterDataAMD", out GetPerfMonitorCounterData);
				resolver.LoadHandle ("glGetPerfMonitorCounterInfoAMD", out GetPerfMonitorCounterInfo);
				resolver.LoadHandle ("glGetPerfMonitorCountersAMD", out GetPerfMonitorCounters);
				resolver.LoadHandle ("glGetPerfMonitorCounterStringAMD", out GetPerfMonitorCounterString);
				resolver.LoadHandle ("glGetPerfMonitorGroupsAMD", out GetPerfMonitorGroups);
				resolver.LoadHandle ("glGetPerfMonitorGroupStringAMD", out GetPerfMonitorGroupString);
				resolver.LoadHandle ("glSelectPerfMonitorCountersAMD", out SelectPerfMonitorCounters);
			}
		}
		public partial class AmdPinnedMemory
		{
			public enum All
			{
				// GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160
				ExternalVirtualMemoryBuffer = unchecked((int)37216),
			}
			public const string NAME_STRING = "GL_AMD_pinned_memory";
		}
		public partial class AmdQueryBufferObject
		{
			public enum All
			{
				// GL_QUERY_BUFFER_AMD = 0x9192
				QueryBuffer = unchecked((int)37266),
				// GL_QUERY_BUFFER_BINDING_AMD = 0x9193
				QueryBufferBinding = unchecked((int)37267),
				// GL_QUERY_RESULT_NO_WAIT_AMD = 0x9194
				QueryResultNoWait = unchecked((int)37268),
			}
			public const string NAME_STRING = "GL_AMD_query_buffer_object";
		}
		public partial class AmdSamplePositions
		{
			public enum All
			{
				// GL_SUBSAMPLE_DISTANCE_AMD = 0x883F
				SubsampleDistance = unchecked((int)34879),
			}
			public const string NAME_STRING = "GL_AMD_sample_positions";
			#region command delegates
			// void glSetMultisamplefvAMD (GLenum pname, GLuint index, GLfloat* val)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetMultisamplefvDelegate (System.UInt32 pname, System.UInt32 index, IntPtr val);
			#endregion // command delegates
			#region commands
			// void glSetMultisamplefvAMD (GLenum pname, GLuint index, GLfloat* val)
			public readonly SetMultisamplefvDelegate SetMultisamplefv;
			#endregion // commands
			public AmdSamplePositions (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSetMultisamplefvAMD", out SetMultisamplefv);
			}
		}
		public partial class AmdSparseTexture
		{
			public enum All
			{
				// GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x1
				TextureStorageSparseBit = unchecked((int)1),
				// GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195
				VirtualPageSizeX = unchecked((int)37269),
				// GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196
				VirtualPageSizeY = unchecked((int)37270),
				// GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197
				VirtualPageSizeZ = unchecked((int)37271),
				// GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198
				MaxSparseTextureSize = unchecked((int)37272),
				// GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199
				MaxSparse3dTextureSize = unchecked((int)37273),
				// GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A
				MaxSparseArrayTextureLayers = unchecked((int)37274),
				// GL_MIN_SPARSE_LEVEL_AMD = 0x919B
				MinSparseLevel = unchecked((int)37275),
				// GL_MIN_LOD_WARNING_AMD = 0x919C
				MinLodWarning = unchecked((int)37276),
			}
			public const string NAME_STRING = "GL_AMD_sparse_texture";
			#region command delegates
			// void glTexStorageSparseAMD (GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexStorageSparseDelegate (System.UInt32 target, System.UInt32 internalFormat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 layers, System.UInt32 flags);
			// void glTextureStorageSparseAMD (GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureStorageSparseDelegate (System.UInt32 texture, System.UInt32 target, System.UInt32 internalFormat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 layers, System.UInt32 flags);
			#endregion // command delegates
			#region commands
			// void glTexStorageSparseAMD (GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
			public readonly TexStorageSparseDelegate TexStorageSparse;
			// void glTextureStorageSparseAMD (GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
			public readonly TextureStorageSparseDelegate TextureStorageSparse;
			#endregion // commands
			public AmdSparseTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexStorageSparseAMD", out TexStorageSparse);
				resolver.LoadHandle ("glTextureStorageSparseAMD", out TextureStorageSparse);
			}
		}
		public partial class AmdStencilOperationExtended
		{
			public enum All
			{
				// GL_SET_AMD = 0x874A
				Set = unchecked((int)34634),
				// GL_REPLACE_VALUE_AMD = 0x874B
				ReplaceValue = unchecked((int)34635),
				// GL_STENCIL_OP_VALUE_AMD = 0x874C
				StencilOpValue = unchecked((int)34636),
				// GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D
				StencilBackOpValue = unchecked((int)34637),
			}
			public const string NAME_STRING = "GL_AMD_stencil_operation_extended";
			#region command delegates
			// void glStencilOpValueAMD (GLenum face, GLuint value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilOpValueDelegate (System.UInt32 face, System.UInt32 value);
			#endregion // command delegates
			#region commands
			// void glStencilOpValueAMD (GLenum face, GLuint value)
			public readonly StencilOpValueDelegate StencilOpValue;
			#endregion // commands
			public AmdStencilOperationExtended (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glStencilOpValueAMD", out StencilOpValue);
			}
		}
		public partial class AmdTransformFeedback4
		{
			public enum All
			{
				// GL_STREAM_RASTERIZATION_AMD = 0x91A0
				StreamRasterization = unchecked((int)37280),
			}
			public const string NAME_STRING = "GL_AMD_transform_feedback4";
		}
		public partial class AmdVertexShaderTessellator
		{
			public enum All
			{
				// GL_SAMPLER_BUFFER_AMD = 0x9001
				SamplerBuffer = unchecked((int)36865),
				// GL_INT_SAMPLER_BUFFER_AMD = 0x9002
				IntSamplerBuffer = unchecked((int)36866),
				// GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003
				UnsignedIntSamplerBuffer = unchecked((int)36867),
				// GL_TESSELLATION_MODE_AMD = 0x9004
				TessellationMode = unchecked((int)36868),
				// GL_TESSELLATION_FACTOR_AMD = 0x9005
				TessellationFactor = unchecked((int)36869),
				// GL_DISCRETE_AMD = 0x9006
				Discrete = unchecked((int)36870),
				// GL_CONTINUOUS_AMD = 0x9007
				Continuous = unchecked((int)36871),
			}
			public const string NAME_STRING = "GL_AMD_vertex_shader_tessellator";
			#region command delegates
			// void glTessellationFactorAMD (GLfloat factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TessellationFactorDelegate (System.Single factor);
			// void glTessellationModeAMD (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TessellationModeDelegate (System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glTessellationFactorAMD (GLfloat factor)
			public readonly TessellationFactorDelegate TessellationFactor;
			// void glTessellationModeAMD (GLenum mode)
			public readonly TessellationModeDelegate TessellationMode;
			#endregion // commands
			public AmdVertexShaderTessellator (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTessellationFactorAMD", out TessellationFactor);
				resolver.LoadHandle ("glTessellationModeAMD", out TessellationMode);
			}
		}
	}
}

