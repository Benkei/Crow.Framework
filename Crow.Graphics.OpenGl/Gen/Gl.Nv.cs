using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class NvBindlessMultiDrawIndirect
		{
			public const string NAME_STRING = "GL_NV_bindless_multi_draw_indirect";
			#region command delegates
			// void glMultiDrawArraysIndirectBindlessNV (GLenum mode, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawArraysIndirectBindlessDelegate (System.UInt32 mode, IntPtr indirect, System.Int32 drawCount, System.Int32 stride, System.Int32 vertexBufferCount);
			// void glMultiDrawElementsIndirectBindlessNV (GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementsIndirectBindlessDelegate (System.UInt32 mode, System.UInt32 type, IntPtr indirect, System.Int32 drawCount, System.Int32 stride, System.Int32 vertexBufferCount);
			#endregion // command delegates
			#region commands
			// void glMultiDrawArraysIndirectBindlessNV (GLenum mode, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
			public readonly MultiDrawArraysIndirectBindlessDelegate MultiDrawArraysIndirectBindless;
			// void glMultiDrawElementsIndirectBindlessNV (GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
			public readonly MultiDrawElementsIndirectBindlessDelegate MultiDrawElementsIndirectBindless;
			#endregion // commands
			public NvBindlessMultiDrawIndirect (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiDrawArraysIndirectBindlessNV", out MultiDrawArraysIndirectBindless);
				resolver.LoadHandle ("glMultiDrawElementsIndirectBindlessNV", out MultiDrawElementsIndirectBindless);
			}
		}
		public partial class NvBindlessMultiDrawIndirectCount
		{
			public const string NAME_STRING = "GL_NV_bindless_multi_draw_indirect_count";
			#region command delegates
			// void glMultiDrawArraysIndirectBindlessCountNV (GLenum mode, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawArraysIndirectBindlessCountDelegate (System.UInt32 mode, IntPtr indirect, System.Int32 drawCount, System.Int32 maxDrawCount, System.Int32 stride, System.Int32 vertexBufferCount);
			// void glMultiDrawElementsIndirectBindlessCountNV (GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementsIndirectBindlessCountDelegate (System.UInt32 mode, System.UInt32 type, IntPtr indirect, System.Int32 drawCount, System.Int32 maxDrawCount, System.Int32 stride, System.Int32 vertexBufferCount);
			#endregion // command delegates
			#region commands
			// void glMultiDrawArraysIndirectBindlessCountNV (GLenum mode, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)
			public readonly MultiDrawArraysIndirectBindlessCountDelegate MultiDrawArraysIndirectBindlessCount;
			// void glMultiDrawElementsIndirectBindlessCountNV (GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount)
			public readonly MultiDrawElementsIndirectBindlessCountDelegate MultiDrawElementsIndirectBindlessCount;
			#endregion // commands
			public NvBindlessMultiDrawIndirectCount (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiDrawArraysIndirectBindlessCountNV", out MultiDrawArraysIndirectBindlessCount);
				resolver.LoadHandle ("glMultiDrawElementsIndirectBindlessCountNV", out MultiDrawElementsIndirectBindlessCount);
			}
		}
		public partial class NvBindlessTexture
		{
			public const string NAME_STRING = "GL_NV_bindless_texture";
			#region command delegates
			// GLuint64 glGetImageHandleNV (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetImageHandleDelegate (System.UInt32 texture, System.Int32 level, Boolean layered, System.Int32 layer, System.UInt32 format);
			// GLuint64 glGetTextureHandleNV (GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetTextureHandleDelegate (System.UInt32 texture);
			// GLuint64 glGetTextureSamplerHandleNV (GLuint texture, GLuint sampler)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt64 GetTextureSamplerHandleDelegate (System.UInt32 texture, System.UInt32 sampler);
			// GLboolean glIsImageHandleResidentNV (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsImageHandleResidentDelegate (System.UInt64 handle);
			// GLboolean glIsTextureHandleResidentNV (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsTextureHandleResidentDelegate (System.UInt64 handle);
			// void glMakeImageHandleNonResidentNV (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeImageHandleNonResidentDelegate (System.UInt64 handle);
			// void glMakeImageHandleResidentNV (GLuint64 handle, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeImageHandleResidentDelegate (System.UInt64 handle, System.UInt32 access);
			// void glMakeTextureHandleNonResidentNV (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeTextureHandleNonResidentDelegate (System.UInt64 handle);
			// void glMakeTextureHandleResidentNV (GLuint64 handle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeTextureHandleResidentDelegate (System.UInt64 handle);
			// void glProgramUniformHandleui64NV (GLuint program, GLint location, GLuint64 value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformHandleui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 value);
			// void glProgramUniformHandleui64vNV (GLuint program, GLint location, GLsizei count, GLuint64* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformHandleui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr values);
			// void glUniformHandleui64NV (GLint location, GLuint64 value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformHandleui64Delegate (System.Int32 location, System.UInt64 value);
			// void glUniformHandleui64vNV (GLint location, GLsizei count, GLuint64* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UniformHandleui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			#endregion // command delegates
			#region commands
			// GLuint64 glGetImageHandleNV (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
			public readonly GetImageHandleDelegate GetImageHandle;
			// GLuint64 glGetTextureHandleNV (GLuint texture)
			public readonly GetTextureHandleDelegate GetTextureHandle;
			// GLuint64 glGetTextureSamplerHandleNV (GLuint texture, GLuint sampler)
			public readonly GetTextureSamplerHandleDelegate GetTextureSamplerHandle;
			// GLboolean glIsImageHandleResidentNV (GLuint64 handle)
			public readonly IsImageHandleResidentDelegate IsImageHandleResident;
			// GLboolean glIsTextureHandleResidentNV (GLuint64 handle)
			public readonly IsTextureHandleResidentDelegate IsTextureHandleResident;
			// void glMakeImageHandleNonResidentNV (GLuint64 handle)
			public readonly MakeImageHandleNonResidentDelegate MakeImageHandleNonResident;
			// void glMakeImageHandleResidentNV (GLuint64 handle, GLenum access)
			public readonly MakeImageHandleResidentDelegate MakeImageHandleResident;
			// void glMakeTextureHandleNonResidentNV (GLuint64 handle)
			public readonly MakeTextureHandleNonResidentDelegate MakeTextureHandleNonResident;
			// void glMakeTextureHandleResidentNV (GLuint64 handle)
			public readonly MakeTextureHandleResidentDelegate MakeTextureHandleResident;
			// void glProgramUniformHandleui64NV (GLuint program, GLint location, GLuint64 value)
			public readonly ProgramUniformHandleui64Delegate ProgramUniformHandleui64;
			// void glProgramUniformHandleui64vNV (GLuint program, GLint location, GLsizei count, GLuint64* values)
			public readonly ProgramUniformHandleui64vDelegate ProgramUniformHandleui64v;
			// void glUniformHandleui64NV (GLint location, GLuint64 value)
			public readonly UniformHandleui64Delegate UniformHandleui64;
			// void glUniformHandleui64vNV (GLint location, GLsizei count, GLuint64* value)
			public readonly UniformHandleui64vDelegate UniformHandleui64v;
			#endregion // commands
			public NvBindlessTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetImageHandleNV", out GetImageHandle);
				resolver.LoadHandle ("glGetTextureHandleNV", out GetTextureHandle);
				resolver.LoadHandle ("glGetTextureSamplerHandleNV", out GetTextureSamplerHandle);
				resolver.LoadHandle ("glIsImageHandleResidentNV", out IsImageHandleResident);
				resolver.LoadHandle ("glIsTextureHandleResidentNV", out IsTextureHandleResident);
				resolver.LoadHandle ("glMakeImageHandleNonResidentNV", out MakeImageHandleNonResident);
				resolver.LoadHandle ("glMakeImageHandleResidentNV", out MakeImageHandleResident);
				resolver.LoadHandle ("glMakeTextureHandleNonResidentNV", out MakeTextureHandleNonResident);
				resolver.LoadHandle ("glMakeTextureHandleResidentNV", out MakeTextureHandleResident);
				resolver.LoadHandle ("glProgramUniformHandleui64NV", out ProgramUniformHandleui64);
				resolver.LoadHandle ("glProgramUniformHandleui64vNV", out ProgramUniformHandleui64v);
				resolver.LoadHandle ("glUniformHandleui64NV", out UniformHandleui64);
				resolver.LoadHandle ("glUniformHandleui64vNV", out UniformHandleui64v);
			}
		}
		public partial class NvBlendEquationAdvanced
		{
			public enum All
			{
				// GL_XOR_NV = 0x1506
				Xor = unchecked((int)5382),
				// GL_RED_NV = 0x1903
				Red = unchecked((int)6403),
				// GL_GREEN_NV = 0x1904
				Green = unchecked((int)6404),
				// GL_BLUE_NV = 0x1905
				Blue = unchecked((int)6405),
				// GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280
				BlendPremultipliedSrc = unchecked((int)37504),
				// GL_BLEND_OVERLAP_NV = 0x9281
				BlendOverlap = unchecked((int)37505),
				// GL_UNCORRELATED_NV = 0x9282
				Uncorrelated = unchecked((int)37506),
				// GL_DISJOINT_NV = 0x9283
				Disjoint = unchecked((int)37507),
				// GL_CONJOINT_NV = 0x9284
				Conjoint = unchecked((int)37508),
				// GL_SRC_NV = 0x9286
				Src = unchecked((int)37510),
				// GL_DST_NV = 0x9287
				Dst = unchecked((int)37511),
				// GL_SRC_OVER_NV = 0x9288
				SrcOver = unchecked((int)37512),
				// GL_DST_OVER_NV = 0x9289
				DstOver = unchecked((int)37513),
				// GL_SRC_IN_NV = 0x928A
				SrcIn = unchecked((int)37514),
				// GL_DST_IN_NV = 0x928B
				DstIn = unchecked((int)37515),
				// GL_SRC_OUT_NV = 0x928C
				SrcOut = unchecked((int)37516),
				// GL_DST_OUT_NV = 0x928D
				DstOut = unchecked((int)37517),
				// GL_SRC_ATOP_NV = 0x928E
				SrcAtop = unchecked((int)37518),
				// GL_DST_ATOP_NV = 0x928F
				DstAtop = unchecked((int)37519),
				// GL_PLUS_NV = 0x9291
				Plus = unchecked((int)37521),
				// GL_PLUS_DARKER_NV = 0x9292
				PlusDarker = unchecked((int)37522),
				// GL_MULTIPLY_NV = 0x9294
				Multiply = unchecked((int)37524),
				// GL_SCREEN_NV = 0x9295
				Screen = unchecked((int)37525),
				// GL_OVERLAY_NV = 0x9296
				Overlay = unchecked((int)37526),
				// GL_DARKEN_NV = 0x9297
				Darken = unchecked((int)37527),
				// GL_LIGHTEN_NV = 0x9298
				Lighten = unchecked((int)37528),
				// GL_COLORDODGE_NV = 0x9299
				Colordodge = unchecked((int)37529),
				// GL_COLORBURN_NV = 0x929A
				Colorburn = unchecked((int)37530),
				// GL_HARDLIGHT_NV = 0x929B
				Hardlight = unchecked((int)37531),
				// GL_SOFTLIGHT_NV = 0x929C
				Softlight = unchecked((int)37532),
				// GL_DIFFERENCE_NV = 0x929E
				Difference = unchecked((int)37534),
				// GL_MINUS_NV = 0x929F
				Minus = unchecked((int)37535),
				// GL_EXCLUSION_NV = 0x92A0
				Exclusion = unchecked((int)37536),
				// GL_CONTRAST_NV = 0x92A1
				Contrast = unchecked((int)37537),
				// GL_INVERT_RGB_NV = 0x92A3
				InvertRgb = unchecked((int)37539),
				// GL_LINEARDODGE_NV = 0x92A4
				Lineardodge = unchecked((int)37540),
				// GL_LINEARBURN_NV = 0x92A5
				Linearburn = unchecked((int)37541),
				// GL_VIVIDLIGHT_NV = 0x92A6
				Vividlight = unchecked((int)37542),
				// GL_LINEARLIGHT_NV = 0x92A7
				Linearlight = unchecked((int)37543),
				// GL_PINLIGHT_NV = 0x92A8
				Pinlight = unchecked((int)37544),
				// GL_HARDMIX_NV = 0x92A9
				Hardmix = unchecked((int)37545),
				// GL_HSL_HUE_NV = 0x92AD
				HslHue = unchecked((int)37549),
				// GL_HSL_SATURATION_NV = 0x92AE
				HslSaturation = unchecked((int)37550),
				// GL_HSL_COLOR_NV = 0x92AF
				HslColor = unchecked((int)37551),
				// GL_HSL_LUMINOSITY_NV = 0x92B0
				HslLuminosity = unchecked((int)37552),
				// GL_PLUS_CLAMPED_NV = 0x92B1
				PlusClamped = unchecked((int)37553),
				// GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2
				PlusClampedAlpha = unchecked((int)37554),
				// GL_MINUS_CLAMPED_NV = 0x92B3
				MinusClamped = unchecked((int)37555),
				// GL_INVERT_OVG_NV = 0x92B4
				InvertOvg = unchecked((int)37556),
			}
			public const string NAME_STRING = "GL_NV_blend_equation_advanced";
			#region command delegates
			// void glBlendBarrierNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendBarrierDelegate ();
			// void glBlendParameteriNV (GLenum pname, GLint value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendParameteriDelegate (System.UInt32 pname, System.Int32 value);
			#endregion // command delegates
			#region commands
			// void glBlendBarrierNV ()
			public readonly BlendBarrierDelegate BlendBarrier;
			// void glBlendParameteriNV (GLenum pname, GLint value)
			public readonly BlendParameteriDelegate BlendParameteri;
			#endregion // commands
			public NvBlendEquationAdvanced (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBlendBarrierNV", out BlendBarrier);
				resolver.LoadHandle ("glBlendParameteriNV", out BlendParameteri);
			}
		}
		public partial class NvBlendEquationAdvancedCoherent
		{
			public enum All
			{
				// GL_BLEND_ADVANCED_COHERENT_NV = 0x9285
				BlendAdvancedCoherent = unchecked((int)37509),
			}
			public const string NAME_STRING = "GL_NV_blend_equation_advanced_coherent";
		}
		public partial class NvClipSpaceWScaling
		{
			public enum All
			{
				// GL_VIEWPORT_POSITION_W_SCALE_NV = 0x937C
				ViewportPositionWScale = unchecked((int)37756),
				// GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D
				ViewportPositionWScaleXCoeff = unchecked((int)37757),
				// GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E
				ViewportPositionWScaleYCoeff = unchecked((int)37758),
			}
			public const string NAME_STRING = "GL_NV_clip_space_w_scaling";
			#region command delegates
			// void glViewportPositionWScaleNV (GLuint index, GLfloat xcoeff, GLfloat ycoeff)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ViewportPositionWScaleDelegate (System.UInt32 index, System.Single xcoeff, System.Single ycoeff);
			#endregion // command delegates
			#region commands
			// void glViewportPositionWScaleNV (GLuint index, GLfloat xcoeff, GLfloat ycoeff)
			public readonly ViewportPositionWScaleDelegate ViewportPositionWScale;
			#endregion // commands
			public NvClipSpaceWScaling (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glViewportPositionWScaleNV", out ViewportPositionWScale);
			}
		}
		public partial class NvCommandList
		{
			public enum All
			{
				// GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0
				TerminateSequenceCommand = unchecked((int)0),
				// GL_NOP_COMMAND_NV = 0x1
				NopCommand = unchecked((int)1),
				// GL_DRAW_ELEMENTS_COMMAND_NV = 0x2
				DrawElementsCommand = unchecked((int)2),
				// GL_DRAW_ARRAYS_COMMAND_NV = 0x3
				DrawArraysCommand = unchecked((int)3),
				// GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x4
				DrawElementsStripCommand = unchecked((int)4),
				// GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x5
				DrawArraysStripCommand = unchecked((int)5),
				// GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x6
				DrawElementsInstancedCommand = unchecked((int)6),
				// GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x7
				DrawArraysInstancedCommand = unchecked((int)7),
				// GL_ELEMENT_ADDRESS_COMMAND_NV = 0x8
				ElementAddressCommand = unchecked((int)8),
				// GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x9
				AttributeAddressCommand = unchecked((int)9),
				// GL_UNIFORM_ADDRESS_COMMAND_NV = 0xA
				UniformAddressCommand = unchecked((int)10),
				// GL_BLEND_COLOR_COMMAND_NV = 0xB
				BlendColorCommand = unchecked((int)11),
				// GL_STENCIL_REF_COMMAND_NV = 0xC
				StencilRefCommand = unchecked((int)12),
				// GL_LINE_WIDTH_COMMAND_NV = 0xD
				LineWidthCommand = unchecked((int)13),
				// GL_POLYGON_OFFSET_COMMAND_NV = 0xE
				PolygonOffsetCommand = unchecked((int)14),
				// GL_ALPHA_REF_COMMAND_NV = 0xF
				AlphaRefCommand = unchecked((int)15),
				// GL_VIEWPORT_COMMAND_NV = 0x10
				ViewportCommand = unchecked((int)16),
				// GL_SCISSOR_COMMAND_NV = 0x11
				ScissorCommand = unchecked((int)17),
				// GL_FRONT_FACE_COMMAND_NV = 0x12
				FrontFaceCommand = unchecked((int)18),
			}
			public const string NAME_STRING = "GL_NV_command_list";
			#region command delegates
			// void glCallCommandListNV (GLuint list)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CallCommandListDelegate (System.UInt32 list);
			// void glCommandListSegmentsNV (GLuint list, GLuint segments)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CommandListSegmentsDelegate (System.UInt32 list, System.UInt32 segments);
			// void glCompileCommandListNV (GLuint list)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CompileCommandListDelegate (System.UInt32 list);
			// void glCreateCommandListsNV (GLsizei n, GLuint* lists)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CreateCommandListsDelegate (System.Int32 n, IntPtr lists);
			// void glCreateStatesNV (GLsizei n, GLuint* states)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CreateStatesDelegate (System.Int32 n, IntPtr states);
			// void glDeleteCommandListsNV (GLsizei n, GLuint* lists)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteCommandListsDelegate (System.Int32 n, IntPtr lists);
			// void glDeleteStatesNV (GLsizei n, GLuint* states)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteStatesDelegate (System.Int32 n, IntPtr states);
			// void glDrawCommandsAddressNV (GLenum primitiveMode, GLuint64* indirects, GLsizei* sizes, GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawCommandsAddressDelegate (System.UInt32 primitiveMode, IntPtr indirects, IntPtr sizes, System.UInt32 count);
			// void glDrawCommandsNV (GLenum primitiveMode, GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawCommandsDelegate (System.UInt32 primitiveMode, System.UInt32 buffer, IntPtr indirects, IntPtr sizes, System.UInt32 count);
			// void glDrawCommandsStatesAddressNV (GLuint64* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawCommandsStatesAddressDelegate (IntPtr indirects, IntPtr sizes, IntPtr states, IntPtr fbos, System.UInt32 count);
			// void glDrawCommandsStatesNV (GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawCommandsStatesDelegate (System.UInt32 buffer, IntPtr indirects, IntPtr sizes, IntPtr states, IntPtr fbos, System.UInt32 count);
			// GLuint glGetCommandHeaderNV (GLenum tokenID, GLuint size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GetCommandHeaderDelegate (System.UInt32 tokenID, System.UInt32 size);
			// GLushort glGetStageIndexNV (GLenum shadertype)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt16 GetStageIndexDelegate (System.UInt32 shadertype);
			// GLboolean glIsCommandListNV (GLuint list)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsCommandListDelegate (System.UInt32 list);
			// GLboolean glIsStateNV (GLuint state)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean IsStateDelegate (System.UInt32 state);
			// void glListDrawCommandsStatesClientNV (GLuint list, GLuint segment, void** indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ListDrawCommandsStatesClientDelegate (System.UInt32 list, System.UInt32 segment, IntPtr indirects, IntPtr sizes, IntPtr states, IntPtr fbos, System.UInt32 count);
			// void glStateCaptureNV (GLuint state, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StateCaptureDelegate (System.UInt32 state, System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glCallCommandListNV (GLuint list)
			public readonly CallCommandListDelegate CallCommandList;
			// void glCommandListSegmentsNV (GLuint list, GLuint segments)
			public readonly CommandListSegmentsDelegate CommandListSegments;
			// void glCompileCommandListNV (GLuint list)
			public readonly CompileCommandListDelegate CompileCommandList;
			// void glCreateCommandListsNV (GLsizei n, GLuint* lists)
			public readonly CreateCommandListsDelegate CreateCommandLists;
			// void glCreateStatesNV (GLsizei n, GLuint* states)
			public readonly CreateStatesDelegate CreateStates;
			// void glDeleteCommandListsNV (GLsizei n, GLuint* lists)
			public readonly DeleteCommandListsDelegate DeleteCommandLists;
			// void glDeleteStatesNV (GLsizei n, GLuint* states)
			public readonly DeleteStatesDelegate DeleteStates;
			// void glDrawCommandsAddressNV (GLenum primitiveMode, GLuint64* indirects, GLsizei* sizes, GLuint count)
			public readonly DrawCommandsAddressDelegate DrawCommandsAddress;
			// void glDrawCommandsNV (GLenum primitiveMode, GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint count)
			public readonly DrawCommandsDelegate DrawCommands;
			// void glDrawCommandsStatesAddressNV (GLuint64* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			public readonly DrawCommandsStatesAddressDelegate DrawCommandsStatesAddress;
			// void glDrawCommandsStatesNV (GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			public readonly DrawCommandsStatesDelegate DrawCommandsStates;
			// GLuint glGetCommandHeaderNV (GLenum tokenID, GLuint size)
			public readonly GetCommandHeaderDelegate GetCommandHeader;
			// GLushort glGetStageIndexNV (GLenum shadertype)
			public readonly GetStageIndexDelegate GetStageIndex;
			// GLboolean glIsCommandListNV (GLuint list)
			public readonly IsCommandListDelegate IsCommandList;
			// GLboolean glIsStateNV (GLuint state)
			public readonly IsStateDelegate IsState;
			// void glListDrawCommandsStatesClientNV (GLuint list, GLuint segment, void** indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count)
			public readonly ListDrawCommandsStatesClientDelegate ListDrawCommandsStatesClient;
			// void glStateCaptureNV (GLuint state, GLenum mode)
			public readonly StateCaptureDelegate StateCapture;
			#endregion // commands
			public NvCommandList (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCallCommandListNV", out CallCommandList);
				resolver.LoadHandle ("glCommandListSegmentsNV", out CommandListSegments);
				resolver.LoadHandle ("glCompileCommandListNV", out CompileCommandList);
				resolver.LoadHandle ("glCreateCommandListsNV", out CreateCommandLists);
				resolver.LoadHandle ("glCreateStatesNV", out CreateStates);
				resolver.LoadHandle ("glDeleteCommandListsNV", out DeleteCommandLists);
				resolver.LoadHandle ("glDeleteStatesNV", out DeleteStates);
				resolver.LoadHandle ("glDrawCommandsAddressNV", out DrawCommandsAddress);
				resolver.LoadHandle ("glDrawCommandsNV", out DrawCommands);
				resolver.LoadHandle ("glDrawCommandsStatesAddressNV", out DrawCommandsStatesAddress);
				resolver.LoadHandle ("glDrawCommandsStatesNV", out DrawCommandsStates);
				resolver.LoadHandle ("glGetCommandHeaderNV", out GetCommandHeader);
				resolver.LoadHandle ("glGetStageIndexNV", out GetStageIndex);
				resolver.LoadHandle ("glIsCommandListNV", out IsCommandList);
				resolver.LoadHandle ("glIsStateNV", out IsState);
				resolver.LoadHandle ("glListDrawCommandsStatesClientNV", out ListDrawCommandsStatesClient);
				resolver.LoadHandle ("glStateCaptureNV", out StateCapture);
			}
		}
		public partial class NvComputeProgram5
		{
			public enum All
			{
				// GL_COMPUTE_PROGRAM_NV = 0x90FB
				ComputeProgram = unchecked((int)37115),
				// GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC
				ComputeProgramParameterBuffer = unchecked((int)37116),
			}
			public const string NAME_STRING = "GL_NV_compute_program5";
		}
		public partial class NvConditionalRender
		{
			public enum All
			{
				// GL_QUERY_WAIT_NV = 0x8E13
				QueryWait = unchecked((int)36371),
				// GL_QUERY_NO_WAIT_NV = 0x8E14
				QueryNoWait = unchecked((int)36372),
				// GL_QUERY_BY_REGION_WAIT_NV = 0x8E15
				QueryByRegionWait = unchecked((int)36373),
				// GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16
				QueryByRegionNoWait = unchecked((int)36374),
			}
			public const string NAME_STRING = "GL_NV_conditional_render";
			#region command delegates
			// void glBeginConditionalRenderNV (GLuint id, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginConditionalRenderDelegate (System.UInt32 id, System.UInt32 mode);
			// void glEndConditionalRenderNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndConditionalRenderDelegate ();
			#endregion // command delegates
			#region commands
			// void glBeginConditionalRenderNV (GLuint id, GLenum mode)
			public readonly BeginConditionalRenderDelegate BeginConditionalRender;
			// void glEndConditionalRenderNV ()
			public readonly EndConditionalRenderDelegate EndConditionalRender;
			#endregion // commands
			public NvConditionalRender (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginConditionalRenderNV", out BeginConditionalRender);
				resolver.LoadHandle ("glEndConditionalRenderNV", out EndConditionalRender);
			}
		}
		public partial class NvConservativeRaster
		{
			public enum All
			{
				// GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346
				ConservativeRasterization = unchecked((int)37702),
				// GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347
				SubpixelPrecisionBiasXBits = unchecked((int)37703),
				// GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348
				SubpixelPrecisionBiasYBits = unchecked((int)37704),
				// GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349
				MaxSubpixelPrecisionBiasBits = unchecked((int)37705),
			}
			public const string NAME_STRING = "GL_NV_conservative_raster";
			#region command delegates
			// void glSubpixelPrecisionBiasNV (GLuint xbits, GLuint ybits)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SubpixelPrecisionBiasDelegate (System.UInt32 xbits, System.UInt32 ybits);
			#endregion // command delegates
			#region commands
			// void glSubpixelPrecisionBiasNV (GLuint xbits, GLuint ybits)
			public readonly SubpixelPrecisionBiasDelegate SubpixelPrecisionBias;
			#endregion // commands
			public NvConservativeRaster (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSubpixelPrecisionBiasNV", out SubpixelPrecisionBias);
			}
		}
		public partial class NvConservativeRasterDilate
		{
			public enum All
			{
				// GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379
				ConservativeRasterDilate = unchecked((int)37753),
				// GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A
				ConservativeRasterDilateRange = unchecked((int)37754),
				// GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B
				ConservativeRasterDilateGranularity = unchecked((int)37755),
			}
			public const string NAME_STRING = "GL_NV_conservative_raster_dilate";
			#region command delegates
			// void glConservativeRasterParameterfNV (GLenum pname, GLfloat value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConservativeRasterParameterfDelegate (System.UInt32 pname, System.Single value);
			#endregion // command delegates
			#region commands
			// void glConservativeRasterParameterfNV (GLenum pname, GLfloat value)
			public readonly ConservativeRasterParameterfDelegate ConservativeRasterParameterf;
			#endregion // commands
			public NvConservativeRasterDilate (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glConservativeRasterParameterfNV", out ConservativeRasterParameterf);
			}
		}
		public partial class NvConservativeRasterPreSnapTriangles
		{
			public enum All
			{
				// GL_CONSERVATIVE_RASTER_MODE_NV = 0x954D
				ConservativeRasterMode = unchecked((int)38221),
				// GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E
				ConservativeRasterModePostSnap = unchecked((int)38222),
				// GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F
				ConservativeRasterModePreSnapTriangles = unchecked((int)38223),
			}
			public const string NAME_STRING = "GL_NV_conservative_raster_pre_snap_triangles";
			#region command delegates
			// void glConservativeRasterParameteriNV (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConservativeRasterParameteriDelegate (System.UInt32 pname, System.Int32 param);
			#endregion // command delegates
			#region commands
			// void glConservativeRasterParameteriNV (GLenum pname, GLint param)
			public readonly ConservativeRasterParameteriDelegate ConservativeRasterParameteri;
			#endregion // commands
			public NvConservativeRasterPreSnapTriangles (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glConservativeRasterParameteriNV", out ConservativeRasterParameteri);
			}
		}
		public partial class NvCopyDepthToColor
		{
			public enum All
			{
				// GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E
				DepthStencilToRgba = unchecked((int)34926),
				// GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F
				DepthStencilToBgra = unchecked((int)34927),
			}
			public const string NAME_STRING = "GL_NV_copy_depth_to_color";
		}
		public partial class NvCopyImage
		{
			public const string NAME_STRING = "GL_NV_copy_image";
			#region command delegates
			// void glCopyImageSubDataNV (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyImageSubDataDelegate (System.UInt32 srcName, System.UInt32 srcTarget, System.Int32 srcLevel, System.Int32 srcX, System.Int32 srcY, System.Int32 srcZ, System.UInt32 dstName, System.UInt32 dstTarget, System.Int32 dstLevel, System.Int32 dstX, System.Int32 dstY, System.Int32 dstZ, System.Int32 width, System.Int32 height, System.Int32 depth);
			#endregion // command delegates
			#region commands
			// void glCopyImageSubDataNV (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
			public readonly CopyImageSubDataDelegate CopyImageSubData;
			#endregion // commands
			public NvCopyImage (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCopyImageSubDataNV", out CopyImageSubData);
			}
		}
		public partial class NvDeepTexture3d
		{
			public enum All
			{
				// GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0
				MaxDeep3dTextureWidthHeight = unchecked((int)37072),
				// GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1
				MaxDeep3dTextureDepth = unchecked((int)37073),
			}
			public const string NAME_STRING = "GL_NV_deep_texture3D";
		}
		public partial class NvDepthBufferFloat
		{
			public enum All
			{
				// GL_DEPTH_COMPONENT32F_NV = 0x8DAB
				DepthComponent32f = unchecked((int)36267),
				// GL_DEPTH32F_STENCIL8_NV = 0x8DAC
				Depth32fStencil8 = unchecked((int)36268),
				// GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD
				Float32UnsignedInt248Rev = unchecked((int)36269),
				// GL_DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF
				DepthBufferFloatMode = unchecked((int)36271),
			}
			public const string NAME_STRING = "GL_NV_depth_buffer_float";
			#region command delegates
			// void glClearDepthdNV (GLdouble depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearDepthdDelegate (System.Double depth);
			// void glDepthBoundsdNV (GLdouble zmin, GLdouble zmax)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DepthBoundsdDelegate (System.Double zmin, System.Double zmax);
			// void glDepthRangedNV (GLdouble zNear, GLdouble zFar)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DepthRangedDelegate (System.Double zNear, System.Double zFar);
			#endregion // command delegates
			#region commands
			// void glClearDepthdNV (GLdouble depth)
			public readonly ClearDepthdDelegate ClearDepthd;
			// void glDepthBoundsdNV (GLdouble zmin, GLdouble zmax)
			public readonly DepthBoundsdDelegate DepthBoundsd;
			// void glDepthRangedNV (GLdouble zNear, GLdouble zFar)
			public readonly DepthRangedDelegate DepthRanged;
			#endregion // commands
			public NvDepthBufferFloat (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glClearDepthdNV", out ClearDepthd);
				resolver.LoadHandle ("glDepthBoundsdNV", out DepthBoundsd);
				resolver.LoadHandle ("glDepthRangedNV", out DepthRanged);
			}
		}
		public partial class NvDepthClamp
		{
			public enum All
			{
				// GL_DEPTH_CLAMP_NV = 0x864F
				DepthClamp = unchecked((int)34383),
			}
			public const string NAME_STRING = "GL_NV_depth_clamp";
		}
		public partial class NvDrawTexture
		{
			public const string NAME_STRING = "GL_NV_draw_texture";
			#region command delegates
			// void glDrawTextureNV (GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawTextureDelegate (System.UInt32 texture, System.UInt32 sampler, System.Single x0, System.Single y0, System.Single x1, System.Single y1, System.Single z, System.Single s0, System.Single t0, System.Single s1, System.Single t1);
			#endregion // command delegates
			#region commands
			// void glDrawTextureNV (GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1)
			public readonly DrawTextureDelegate DrawTexture;
			#endregion // commands
			public NvDrawTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawTextureNV", out DrawTexture);
			}
		}
		public partial class NvEvaluators
		{
			public enum All
			{
				// GL_EVAL_2D_NV = 0x86C0
				Eval2d = unchecked((int)34496),
				// GL_EVAL_TRIANGULAR_2D_NV = 0x86C1
				EvalTriangular2d = unchecked((int)34497),
				// GL_MAP_TESSELLATION_NV = 0x86C2
				MapTessellation = unchecked((int)34498),
				// GL_MAP_ATTRIB_U_ORDER_NV = 0x86C3
				MapAttribUOrder = unchecked((int)34499),
				// GL_MAP_ATTRIB_V_ORDER_NV = 0x86C4
				MapAttribVOrder = unchecked((int)34500),
				// GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5
				EvalFractionalTessellation = unchecked((int)34501),
				// GL_EVAL_VERTEX_ATTRIB0_NV = 0x86C6
				EvalVertexAttrib0 = unchecked((int)34502),
				// GL_EVAL_VERTEX_ATTRIB1_NV = 0x86C7
				EvalVertexAttrib1 = unchecked((int)34503),
				// GL_EVAL_VERTEX_ATTRIB2_NV = 0x86C8
				EvalVertexAttrib2 = unchecked((int)34504),
				// GL_EVAL_VERTEX_ATTRIB3_NV = 0x86C9
				EvalVertexAttrib3 = unchecked((int)34505),
				// GL_EVAL_VERTEX_ATTRIB4_NV = 0x86CA
				EvalVertexAttrib4 = unchecked((int)34506),
				// GL_EVAL_VERTEX_ATTRIB5_NV = 0x86CB
				EvalVertexAttrib5 = unchecked((int)34507),
				// GL_EVAL_VERTEX_ATTRIB6_NV = 0x86CC
				EvalVertexAttrib6 = unchecked((int)34508),
				// GL_EVAL_VERTEX_ATTRIB7_NV = 0x86CD
				EvalVertexAttrib7 = unchecked((int)34509),
				// GL_EVAL_VERTEX_ATTRIB8_NV = 0x86CE
				EvalVertexAttrib8 = unchecked((int)34510),
				// GL_EVAL_VERTEX_ATTRIB9_NV = 0x86CF
				EvalVertexAttrib9 = unchecked((int)34511),
				// GL_EVAL_VERTEX_ATTRIB10_NV = 0x86D0
				EvalVertexAttrib10 = unchecked((int)34512),
				// GL_EVAL_VERTEX_ATTRIB11_NV = 0x86D1
				EvalVertexAttrib11 = unchecked((int)34513),
				// GL_EVAL_VERTEX_ATTRIB12_NV = 0x86D2
				EvalVertexAttrib12 = unchecked((int)34514),
				// GL_EVAL_VERTEX_ATTRIB13_NV = 0x86D3
				EvalVertexAttrib13 = unchecked((int)34515),
				// GL_EVAL_VERTEX_ATTRIB14_NV = 0x86D4
				EvalVertexAttrib14 = unchecked((int)34516),
				// GL_EVAL_VERTEX_ATTRIB15_NV = 0x86D5
				EvalVertexAttrib15 = unchecked((int)34517),
				// GL_MAX_MAP_TESSELLATION_NV = 0x86D6
				MaxMapTessellation = unchecked((int)34518),
				// GL_MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7
				MaxRationalEvalOrder = unchecked((int)34519),
			}
			public const string NAME_STRING = "GL_NV_evaluators";
			#region command delegates
			// void glEvalMapsNV (GLenum target, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvalMapsDelegate (System.UInt32 target, System.UInt32 mode);
			// void glGetMapAttribParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapAttribParameterfvDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetMapAttribParameterivNV (GLenum target, GLuint index, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapAttribParameterivDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, void* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapControlPointsDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 type, System.Int32 ustride, System.Int32 vstride, Boolean packed, IntPtr points);
			// void glGetMapParameterfvNV (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapParameterfvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetMapParameterivNV (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, void* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapControlPointsDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 type, System.Int32 ustride, System.Int32 vstride, System.Int32 uorder, System.Int32 vorder, Boolean packed, IntPtr points);
			// void glMapParameterfvNV (GLenum target, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapParameterfvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glMapParameterivNV (GLenum target, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glEvalMapsNV (GLenum target, GLenum mode)
			public readonly EvalMapsDelegate EvalMaps;
			// void glGetMapAttribParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat* params)
			public readonly GetMapAttribParameterfvDelegate GetMapAttribParameterfv;
			// void glGetMapAttribParameterivNV (GLenum target, GLuint index, GLenum pname, GLint* params)
			public readonly GetMapAttribParameterivDelegate GetMapAttribParameteriv;
			// void glGetMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, void* points)
			public readonly GetMapControlPointsDelegate GetMapControlPoints;
			// void glGetMapParameterfvNV (GLenum target, GLenum pname, GLfloat* params)
			public readonly GetMapParameterfvDelegate GetMapParameterfv;
			// void glGetMapParameterivNV (GLenum target, GLenum pname, GLint* params)
			public readonly GetMapParameterivDelegate GetMapParameteriv;
			// void glMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, void* points)
			public readonly MapControlPointsDelegate MapControlPoints;
			// void glMapParameterfvNV (GLenum target, GLenum pname, GLfloat* params)
			public readonly MapParameterfvDelegate MapParameterfv;
			// void glMapParameterivNV (GLenum target, GLenum pname, GLint* params)
			public readonly MapParameterivDelegate MapParameteriv;
			#endregion // commands
			public NvEvaluators (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glEvalMapsNV", out EvalMaps);
				resolver.LoadHandle ("glGetMapAttribParameterfvNV", out GetMapAttribParameterfv);
				resolver.LoadHandle ("glGetMapAttribParameterivNV", out GetMapAttribParameteriv);
				resolver.LoadHandle ("glGetMapControlPointsNV", out GetMapControlPoints);
				resolver.LoadHandle ("glGetMapParameterfvNV", out GetMapParameterfv);
				resolver.LoadHandle ("glGetMapParameterivNV", out GetMapParameteriv);
				resolver.LoadHandle ("glMapControlPointsNV", out MapControlPoints);
				resolver.LoadHandle ("glMapParameterfvNV", out MapParameterfv);
				resolver.LoadHandle ("glMapParameterivNV", out MapParameteriv);
			}
		}
		public partial class NvExplicitMultisample
		{
			public enum All
			{
				// GL_SAMPLE_POSITION_NV = 0x8E50
				SamplePosition = unchecked((int)36432),
				// GL_SAMPLE_MASK_NV = 0x8E51
				SampleMask = unchecked((int)36433),
				// GL_SAMPLE_MASK_VALUE_NV = 0x8E52
				SampleMaskValue = unchecked((int)36434),
				// GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53
				TextureBindingRenderbuffer = unchecked((int)36435),
				// GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54
				TextureRenderbufferDataStoreBinding = unchecked((int)36436),
				// GL_TEXTURE_RENDERBUFFER_NV = 0x8E55
				TextureRenderbuffer = unchecked((int)36437),
				// GL_SAMPLER_RENDERBUFFER_NV = 0x8E56
				SamplerRenderbuffer = unchecked((int)36438),
				// GL_INT_SAMPLER_RENDERBUFFER_NV = 0x8E57
				IntSamplerRenderbuffer = unchecked((int)36439),
				// GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58
				UnsignedIntSamplerRenderbuffer = unchecked((int)36440),
				// GL_MAX_SAMPLE_MASK_WORDS_NV = 0x8E59
				MaxSampleMaskWords = unchecked((int)36441),
			}
			public const string NAME_STRING = "GL_NV_explicit_multisample";
			#region command delegates
			// void glGetMultisamplefvNV (GLenum pname, GLuint index, GLfloat* val)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMultisamplefvDelegate (System.UInt32 pname, System.UInt32 index, IntPtr val);
			// void glSampleMaskIndexedNV (GLuint index, GLbitfield mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SampleMaskIndexedDelegate (System.UInt32 index, System.UInt32 mask);
			// void glTexRenderbufferNV (GLenum target, GLuint renderbuffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexRenderbufferDelegate (TextureTarget target, System.UInt32 renderbuffer);
			#endregion // command delegates
			#region commands
			// void glGetMultisamplefvNV (GLenum pname, GLuint index, GLfloat* val)
			public readonly GetMultisamplefvDelegate GetMultisamplefv;
			// void glSampleMaskIndexedNV (GLuint index, GLbitfield mask)
			public readonly SampleMaskIndexedDelegate SampleMaskIndexed;
			// void glTexRenderbufferNV (GLenum target, GLuint renderbuffer)
			public readonly TexRenderbufferDelegate TexRenderbuffer;
			#endregion // commands
			public NvExplicitMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetMultisamplefvNV", out GetMultisamplefv);
				resolver.LoadHandle ("glSampleMaskIndexedNV", out SampleMaskIndexed);
				resolver.LoadHandle ("glTexRenderbufferNV", out TexRenderbuffer);
			}
		}
		public partial class NvFence
		{
			public enum All
			{
				// GL_ALL_COMPLETED_NV = 0x84F2
				AllCompleted = unchecked((int)34034),
				// GL_FENCE_STATUS_NV = 0x84F3
				FenceStatus = unchecked((int)34035),
				// GL_FENCE_CONDITION_NV = 0x84F4
				FenceCondition = unchecked((int)34036),
			}
			public const string NAME_STRING = "GL_NV_fence";
			#region command delegates
			// void glDeleteFencesNV (GLsizei n, GLuint* fences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteFencesDelegate (System.Int32 n, IntPtr fences);
			// void glFinishFenceNV (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FinishFenceDelegate (System.UInt32 fence);
			// void glGenFencesNV (GLsizei n, GLuint* fences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenFencesDelegate (System.Int32 n, IntPtr fences);
			// void glGetFenceivNV (GLuint fence, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFenceivDelegate (System.UInt32 fence, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsFenceNV (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsFenceDelegate (System.UInt32 fence);
			// void glSetFenceNV (GLuint fence, GLenum condition)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetFenceDelegate (System.UInt32 fence, System.UInt32 condition);
			// GLboolean glTestFenceNV (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean TestFenceDelegate (System.UInt32 fence);
			#endregion // command delegates
			#region commands
			// void glDeleteFencesNV (GLsizei n, GLuint* fences)
			public readonly DeleteFencesDelegate DeleteFences;
			// void glFinishFenceNV (GLuint fence)
			public readonly FinishFenceDelegate FinishFence;
			// void glGenFencesNV (GLsizei n, GLuint* fences)
			public readonly GenFencesDelegate GenFences;
			// void glGetFenceivNV (GLuint fence, GLenum pname, GLint* params)
			public readonly GetFenceivDelegate GetFenceiv;
			// GLboolean glIsFenceNV (GLuint fence)
			public readonly IsFenceDelegate IsFence;
			// void glSetFenceNV (GLuint fence, GLenum condition)
			public readonly SetFenceDelegate SetFence;
			// GLboolean glTestFenceNV (GLuint fence)
			public readonly TestFenceDelegate TestFence;
			#endregion // commands
			public NvFence (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDeleteFencesNV", out DeleteFences);
				resolver.LoadHandle ("glFinishFenceNV", out FinishFence);
				resolver.LoadHandle ("glGenFencesNV", out GenFences);
				resolver.LoadHandle ("glGetFenceivNV", out GetFenceiv);
				resolver.LoadHandle ("glIsFenceNV", out IsFence);
				resolver.LoadHandle ("glSetFenceNV", out SetFence);
				resolver.LoadHandle ("glTestFenceNV", out TestFence);
			}
		}
		public partial class NvFillRectangle
		{
			public enum All
			{
				// GL_FILL_RECTANGLE_NV = 0x933C
				FillRectangle = unchecked((int)37692),
			}
			public const string NAME_STRING = "GL_NV_fill_rectangle";
		}
		public partial class NvFloatBuffer
		{
			public enum All
			{
				// GL_FLOAT_R_NV = 0x8880
				FloatR = unchecked((int)34944),
				// GL_FLOAT_RG_NV = 0x8881
				FloatRg = unchecked((int)34945),
				// GL_FLOAT_RGB_NV = 0x8882
				FloatRgb = unchecked((int)34946),
				// GL_FLOAT_RGBA_NV = 0x8883
				FloatRgba = unchecked((int)34947),
				// GL_FLOAT_R16_NV = 0x8884
				FloatR16 = unchecked((int)34948),
				// GL_FLOAT_R32_NV = 0x8885
				FloatR32 = unchecked((int)34949),
				// GL_FLOAT_RG16_NV = 0x8886
				FloatRg16 = unchecked((int)34950),
				// GL_FLOAT_RG32_NV = 0x8887
				FloatRg32 = unchecked((int)34951),
				// GL_FLOAT_RGB16_NV = 0x8888
				FloatRgb16 = unchecked((int)34952),
				// GL_FLOAT_RGB32_NV = 0x8889
				FloatRgb32 = unchecked((int)34953),
				// GL_FLOAT_RGBA16_NV = 0x888A
				FloatRgba16 = unchecked((int)34954),
				// GL_FLOAT_RGBA32_NV = 0x888B
				FloatRgba32 = unchecked((int)34955),
				// GL_TEXTURE_FLOAT_COMPONENTS_NV = 0x888C
				TextureFloatComponents = unchecked((int)34956),
				// GL_FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D
				FloatClearColorValue = unchecked((int)34957),
				// GL_FLOAT_RGBA_MODE_NV = 0x888E
				FloatRgbaMode = unchecked((int)34958),
			}
			public const string NAME_STRING = "GL_NV_float_buffer";
		}
		public partial class NvFogDistance
		{
			public enum All
			{
				// GL_FOG_DISTANCE_MODE_NV = 0x855A
				FogDistanceMode = unchecked((int)34138),
				// GL_EYE_RADIAL_NV = 0x855B
				EyeRadial = unchecked((int)34139),
				// GL_EYE_PLANE_ABSOLUTE_NV = 0x855C
				EyePlaneAbsolute = unchecked((int)34140),
			}
			public const string NAME_STRING = "GL_NV_fog_distance";
		}
		public partial class NvFragmentCoverageToColor
		{
			public enum All
			{
				// GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD
				FragmentCoverageToColor = unchecked((int)37597),
				// GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE
				FragmentCoverageColor = unchecked((int)37598),
			}
			public const string NAME_STRING = "GL_NV_fragment_coverage_to_color";
			#region command delegates
			// void glFragmentCoverageColorNV (GLuint color)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentCoverageColorDelegate (System.UInt32 color);
			#endregion // command delegates
			#region commands
			// void glFragmentCoverageColorNV (GLuint color)
			public readonly FragmentCoverageColorDelegate FragmentCoverageColor;
			#endregion // commands
			public NvFragmentCoverageToColor (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFragmentCoverageColorNV", out FragmentCoverageColor);
			}
		}
		public partial class NvFragmentProgram
		{
			public enum All
			{
				// GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868
				MaxFragmentProgramLocalParameters = unchecked((int)34920),
				// GL_FRAGMENT_PROGRAM_NV = 0x8870
				FragmentProgram = unchecked((int)34928),
				// GL_MAX_TEXTURE_COORDS_NV = 0x8871
				MaxTextureCoords = unchecked((int)34929),
				// GL_MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872
				MaxTextureImageUnits = unchecked((int)34930),
				// GL_FRAGMENT_PROGRAM_BINDING_NV = 0x8873
				FragmentProgramBinding = unchecked((int)34931),
				// GL_PROGRAM_ERROR_STRING_NV = 0x8874
				ProgramErrorString = unchecked((int)34932),
			}
			public const string NAME_STRING = "GL_NV_fragment_program";
			#region command delegates
			// void glGetProgramNamedParameterdvNV (GLuint id, GLsizei len, GLubyte* name, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramNamedParameterdvDelegate (System.UInt32 id, System.Int32 len, StringPtr name, IntPtr @params);
			// void glGetProgramNamedParameterfvNV (GLuint id, GLsizei len, GLubyte* name, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramNamedParameterfvDelegate (System.UInt32 id, System.Int32 len, StringPtr name, IntPtr @params);
			// void glProgramNamedParameter4dNV (GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramNamedParameter4dDelegate (System.UInt32 id, System.Int32 len, IntPtr name, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glProgramNamedParameter4dvNV (GLuint id, GLsizei len, GLubyte* name, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramNamedParameter4dvDelegate (System.UInt32 id, System.Int32 len, IntPtr name, IntPtr v);
			// void glProgramNamedParameter4fNV (GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramNamedParameter4fDelegate (System.UInt32 id, System.Int32 len, IntPtr name, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glProgramNamedParameter4fvNV (GLuint id, GLsizei len, GLubyte* name, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramNamedParameter4fvDelegate (System.UInt32 id, System.Int32 len, IntPtr name, IntPtr v);
			#endregion // command delegates
			#region commands
			// void glGetProgramNamedParameterdvNV (GLuint id, GLsizei len, GLubyte* name, GLdouble* params)
			public readonly GetProgramNamedParameterdvDelegate GetProgramNamedParameterdv;
			// void glGetProgramNamedParameterfvNV (GLuint id, GLsizei len, GLubyte* name, GLfloat* params)
			public readonly GetProgramNamedParameterfvDelegate GetProgramNamedParameterfv;
			// void glProgramNamedParameter4dNV (GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly ProgramNamedParameter4dDelegate ProgramNamedParameter4d;
			// void glProgramNamedParameter4dvNV (GLuint id, GLsizei len, GLubyte* name, GLdouble* v)
			public readonly ProgramNamedParameter4dvDelegate ProgramNamedParameter4dv;
			// void glProgramNamedParameter4fNV (GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly ProgramNamedParameter4fDelegate ProgramNamedParameter4f;
			// void glProgramNamedParameter4fvNV (GLuint id, GLsizei len, GLubyte* name, GLfloat* v)
			public readonly ProgramNamedParameter4fvDelegate ProgramNamedParameter4fv;
			#endregion // commands
			public NvFragmentProgram (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetProgramNamedParameterdvNV", out GetProgramNamedParameterdv);
				resolver.LoadHandle ("glGetProgramNamedParameterfvNV", out GetProgramNamedParameterfv);
				resolver.LoadHandle ("glProgramNamedParameter4dNV", out ProgramNamedParameter4d);
				resolver.LoadHandle ("glProgramNamedParameter4dvNV", out ProgramNamedParameter4dv);
				resolver.LoadHandle ("glProgramNamedParameter4fNV", out ProgramNamedParameter4f);
				resolver.LoadHandle ("glProgramNamedParameter4fvNV", out ProgramNamedParameter4fv);
			}
		}
		public partial class NvFragmentProgram2
		{
			public enum All
			{
				// GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4
				MaxProgramExecInstructions = unchecked((int)35060),
				// GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5
				MaxProgramCallDepth = unchecked((int)35061),
				// GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6
				MaxProgramIfDepth = unchecked((int)35062),
				// GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7
				MaxProgramLoopDepth = unchecked((int)35063),
				// GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8
				MaxProgramLoopCount = unchecked((int)35064),
			}
			public const string NAME_STRING = "GL_NV_fragment_program2";
		}
		public partial class NvFramebufferMixedSamples
		{
			public enum All
			{
				// GL_COLOR_SAMPLES_NV = 0x8E20
				ColorSamples = unchecked((int)36384),
				// GL_DEPTH_SAMPLES_NV = 0x932D
				DepthSamples = unchecked((int)37677),
				// GL_STENCIL_SAMPLES_NV = 0x932E
				StencilSamples = unchecked((int)37678),
				// GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F
				MixedDepthSamplesSupported = unchecked((int)37679),
				// GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330
				MixedStencilSamplesSupported = unchecked((int)37680),
				// GL_COVERAGE_MODULATION_TABLE_NV = 0x9331
				CoverageModulationTable = unchecked((int)37681),
				// GL_COVERAGE_MODULATION_NV = 0x9332
				CoverageModulation = unchecked((int)37682),
				// GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333
				CoverageModulationTableSize = unchecked((int)37683),
			}
			public const string NAME_STRING = "GL_NV_framebuffer_mixed_samples";
			#region command delegates
			// void glCoverageModulationNV (GLenum components)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverageModulationDelegate (System.UInt32 components);
			// void glCoverageModulationTableNV (GLsizei n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverageModulationTableDelegate (System.Int32 n, IntPtr v);
			// void glGetCoverageModulationTableNV (GLsizei bufsize, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCoverageModulationTableDelegate (System.Int32 bufsize, IntPtr v);
			#endregion // command delegates
			#region commands
			// void glCoverageModulationNV (GLenum components)
			public readonly CoverageModulationDelegate CoverageModulation;
			// void glCoverageModulationTableNV (GLsizei n, GLfloat* v)
			public readonly CoverageModulationTableDelegate CoverageModulationTable;
			// void glGetCoverageModulationTableNV (GLsizei bufsize, GLfloat* v)
			public readonly GetCoverageModulationTableDelegate GetCoverageModulationTable;
			#endregion // commands
			public NvFramebufferMixedSamples (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCoverageModulationNV", out CoverageModulation);
				resolver.LoadHandle ("glCoverageModulationTableNV", out CoverageModulationTable);
				resolver.LoadHandle ("glGetCoverageModulationTableNV", out GetCoverageModulationTable);
			}
		}
		public partial class NvFramebufferMultisampleCoverage
		{
			public enum All
			{
				// GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB
				RenderbufferCoverageSamples = unchecked((int)36011),
				// GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10
				RenderbufferColorSamples = unchecked((int)36368),
				// GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11
				MaxMultisampleCoverageModes = unchecked((int)36369),
				// GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12
				MultisampleCoverageModes = unchecked((int)36370),
			}
			public const string NAME_STRING = "GL_NV_framebuffer_multisample_coverage";
			#region command delegates
			// void glRenderbufferStorageMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RenderbufferStorageMultisampleCoverageDelegate (System.UInt32 target, System.Int32 coverageSamples, System.Int32 colorSamples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
			#endregion // command delegates
			#region commands
			// void glRenderbufferStorageMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
			public readonly RenderbufferStorageMultisampleCoverageDelegate RenderbufferStorageMultisampleCoverage;
			#endregion // commands
			public NvFramebufferMultisampleCoverage (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glRenderbufferStorageMultisampleCoverageNV", out RenderbufferStorageMultisampleCoverage);
			}
		}
		public partial class NvGeometryProgram4
		{
			public enum All
			{
				// GL_GEOMETRY_PROGRAM_NV = 0x8C26
				GeometryProgram = unchecked((int)35878),
				// GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27
				MaxProgramOutputVertices = unchecked((int)35879),
				// GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28
				MaxProgramTotalOutputComponents = unchecked((int)35880),
			}
			public const string NAME_STRING = "GL_NV_geometry_program4";
			#region command delegates
			// void glFramebufferTextureFaceEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureFaceDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, TextureTarget face);
			// void glFramebufferTextureEXT (GLenum target, GLenum attachment, GLuint texture, GLint level)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level);
			// void glProgramVertexLimitNV (GLenum target, GLint limit)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramVertexLimitDelegate (System.UInt32 target, System.Int32 limit);
			#endregion // command delegates
			#region commands
			// void glFramebufferTextureFaceEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
			public readonly FramebufferTextureFaceDelegate FramebufferTextureFace;
			// void glFramebufferTextureEXT (GLenum target, GLenum attachment, GLuint texture, GLint level)
			public readonly FramebufferTextureDelegate FramebufferTexture;
			// void glProgramVertexLimitNV (GLenum target, GLint limit)
			public readonly ProgramVertexLimitDelegate ProgramVertexLimit;
			#endregion // commands
			public NvGeometryProgram4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFramebufferTextureFaceEXT", out FramebufferTextureFace);
				resolver.LoadHandle ("glFramebufferTextureEXT", out FramebufferTexture);
				resolver.LoadHandle ("glProgramVertexLimitNV", out ProgramVertexLimit);
			}
		}
		public partial class NvGpuProgram4
		{
			public enum All
			{
				// GL_MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904
				MinProgramTexelOffset = unchecked((int)35076),
				// GL_MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905
				MaxProgramTexelOffset = unchecked((int)35077),
				// GL_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906
				ProgramAttribComponents = unchecked((int)35078),
				// GL_PROGRAM_RESULT_COMPONENTS_NV = 0x8907
				ProgramResultComponents = unchecked((int)35079),
				// GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908
				MaxProgramAttribComponents = unchecked((int)35080),
				// GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909
				MaxProgramResultComponents = unchecked((int)35081),
				// GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5
				MaxProgramGenericAttribs = unchecked((int)36261),
				// GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6
				MaxProgramGenericResults = unchecked((int)36262),
			}
			public const string NAME_STRING = "GL_NV_gpu_program4";
			#region command delegates
			// void glGetProgramEnvParameterIivNV (GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramEnvParameterIivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramEnvParameterIuivNV (GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramEnvParameterIuivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramLocalParameterIivNV (GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramLocalParameterIivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glGetProgramLocalParameterIuivNV (GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramLocalParameterIuivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramEnvParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameterI4iDelegate (System.UInt32 target, System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glProgramEnvParameterI4ivNV (GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameterI4ivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramEnvParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameterI4uiDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w);
			// void glProgramEnvParameterI4uivNV (GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParameterI4uivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramEnvParametersI4ivNV (GLenum target, GLuint index, GLsizei count, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParametersI4ivDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glProgramEnvParametersI4uivNV (GLenum target, GLuint index, GLsizei count, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramEnvParametersI4uivDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glProgramLocalParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameterI4iDelegate (System.UInt32 target, System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glProgramLocalParameterI4ivNV (GLenum target, GLuint index, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameterI4ivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramLocalParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameterI4uiDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w);
			// void glProgramLocalParameterI4uivNV (GLenum target, GLuint index, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParameterI4uivDelegate (System.UInt32 target, System.UInt32 index, IntPtr @params);
			// void glProgramLocalParametersI4ivNV (GLenum target, GLuint index, GLsizei count, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParametersI4ivDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			// void glProgramLocalParametersI4uivNV (GLenum target, GLuint index, GLsizei count, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramLocalParametersI4uivDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetProgramEnvParameterIivNV (GLenum target, GLuint index, GLint* params)
			public readonly GetProgramEnvParameterIivDelegate GetProgramEnvParameterIiv;
			// void glGetProgramEnvParameterIuivNV (GLenum target, GLuint index, GLuint* params)
			public readonly GetProgramEnvParameterIuivDelegate GetProgramEnvParameterIuiv;
			// void glGetProgramLocalParameterIivNV (GLenum target, GLuint index, GLint* params)
			public readonly GetProgramLocalParameterIivDelegate GetProgramLocalParameterIiv;
			// void glGetProgramLocalParameterIuivNV (GLenum target, GLuint index, GLuint* params)
			public readonly GetProgramLocalParameterIuivDelegate GetProgramLocalParameterIuiv;
			// void glProgramEnvParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			public readonly ProgramEnvParameterI4iDelegate ProgramEnvParameterI4i;
			// void glProgramEnvParameterI4ivNV (GLenum target, GLuint index, GLint* params)
			public readonly ProgramEnvParameterI4ivDelegate ProgramEnvParameterI4iv;
			// void glProgramEnvParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			public readonly ProgramEnvParameterI4uiDelegate ProgramEnvParameterI4ui;
			// void glProgramEnvParameterI4uivNV (GLenum target, GLuint index, GLuint* params)
			public readonly ProgramEnvParameterI4uivDelegate ProgramEnvParameterI4uiv;
			// void glProgramEnvParametersI4ivNV (GLenum target, GLuint index, GLsizei count, GLint* params)
			public readonly ProgramEnvParametersI4ivDelegate ProgramEnvParametersI4iv;
			// void glProgramEnvParametersI4uivNV (GLenum target, GLuint index, GLsizei count, GLuint* params)
			public readonly ProgramEnvParametersI4uivDelegate ProgramEnvParametersI4uiv;
			// void glProgramLocalParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
			public readonly ProgramLocalParameterI4iDelegate ProgramLocalParameterI4i;
			// void glProgramLocalParameterI4ivNV (GLenum target, GLuint index, GLint* params)
			public readonly ProgramLocalParameterI4ivDelegate ProgramLocalParameterI4iv;
			// void glProgramLocalParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			public readonly ProgramLocalParameterI4uiDelegate ProgramLocalParameterI4ui;
			// void glProgramLocalParameterI4uivNV (GLenum target, GLuint index, GLuint* params)
			public readonly ProgramLocalParameterI4uivDelegate ProgramLocalParameterI4uiv;
			// void glProgramLocalParametersI4ivNV (GLenum target, GLuint index, GLsizei count, GLint* params)
			public readonly ProgramLocalParametersI4ivDelegate ProgramLocalParametersI4iv;
			// void glProgramLocalParametersI4uivNV (GLenum target, GLuint index, GLsizei count, GLuint* params)
			public readonly ProgramLocalParametersI4uivDelegate ProgramLocalParametersI4uiv;
			#endregion // commands
			public NvGpuProgram4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetProgramEnvParameterIivNV", out GetProgramEnvParameterIiv);
				resolver.LoadHandle ("glGetProgramEnvParameterIuivNV", out GetProgramEnvParameterIuiv);
				resolver.LoadHandle ("glGetProgramLocalParameterIivNV", out GetProgramLocalParameterIiv);
				resolver.LoadHandle ("glGetProgramLocalParameterIuivNV", out GetProgramLocalParameterIuiv);
				resolver.LoadHandle ("glProgramEnvParameterI4iNV", out ProgramEnvParameterI4i);
				resolver.LoadHandle ("glProgramEnvParameterI4ivNV", out ProgramEnvParameterI4iv);
				resolver.LoadHandle ("glProgramEnvParameterI4uiNV", out ProgramEnvParameterI4ui);
				resolver.LoadHandle ("glProgramEnvParameterI4uivNV", out ProgramEnvParameterI4uiv);
				resolver.LoadHandle ("glProgramEnvParametersI4ivNV", out ProgramEnvParametersI4iv);
				resolver.LoadHandle ("glProgramEnvParametersI4uivNV", out ProgramEnvParametersI4uiv);
				resolver.LoadHandle ("glProgramLocalParameterI4iNV", out ProgramLocalParameterI4i);
				resolver.LoadHandle ("glProgramLocalParameterI4ivNV", out ProgramLocalParameterI4iv);
				resolver.LoadHandle ("glProgramLocalParameterI4uiNV", out ProgramLocalParameterI4ui);
				resolver.LoadHandle ("glProgramLocalParameterI4uivNV", out ProgramLocalParameterI4uiv);
				resolver.LoadHandle ("glProgramLocalParametersI4ivNV", out ProgramLocalParametersI4iv);
				resolver.LoadHandle ("glProgramLocalParametersI4uivNV", out ProgramLocalParametersI4uiv);
			}
		}
		public partial class NvGpuProgram5
		{
			public enum All
			{
				// GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A
				MaxGeometryProgramInvocations = unchecked((int)36442),
				// GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B
				MinFragmentInterpolationOffset = unchecked((int)36443),
				// GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C
				MaxFragmentInterpolationOffset = unchecked((int)36444),
				// GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D
				FragmentProgramInterpolationOffsetBits = unchecked((int)36445),
				// GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E
				MinProgramTextureGatherOffset = unchecked((int)36446),
				// GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F
				MaxProgramTextureGatherOffset = unchecked((int)36447),
				// GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44
				MaxProgramSubroutineParameters = unchecked((int)36676),
				// GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45
				MaxProgramSubroutineNum = unchecked((int)36677),
			}
			public const string NAME_STRING = "GL_NV_gpu_program5";
			#region command delegates
			// void glGetProgramSubroutineParameteruivNV (GLenum target, GLuint index, GLuint* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramSubroutineParameteruivDelegate (System.UInt32 target, System.UInt32 index, IntPtr param);
			// void glProgramSubroutineParametersuivNV (GLenum target, GLsizei count, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramSubroutineParametersuivDelegate (System.UInt32 target, System.Int32 count, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetProgramSubroutineParameteruivNV (GLenum target, GLuint index, GLuint* param)
			public readonly GetProgramSubroutineParameteruivDelegate GetProgramSubroutineParameteruiv;
			// void glProgramSubroutineParametersuivNV (GLenum target, GLsizei count, GLuint* params)
			public readonly ProgramSubroutineParametersuivDelegate ProgramSubroutineParametersuiv;
			#endregion // commands
			public NvGpuProgram5 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetProgramSubroutineParameteruivNV", out GetProgramSubroutineParameteruiv);
				resolver.LoadHandle ("glProgramSubroutineParametersuivNV", out ProgramSubroutineParametersuiv);
			}
		}
		public partial class NvHalfFloat
		{
			public enum All
			{
				// GL_HALF_FLOAT_NV = 0x140B
				HalfFloat = unchecked((int)5131),
			}
			public const string NAME_STRING = "GL_NV_half_float";
			#region command delegates
			// void glColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3hDelegate (System.UInt16 red, System.UInt16 green, System.UInt16 blue);
			// void glColor3hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3hvDelegate (IntPtr v);
			// void glColor4hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4hDelegate (System.UInt16 red, System.UInt16 green, System.UInt16 blue, System.UInt16 alpha);
			// void glColor4hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4hvDelegate (IntPtr v);
			// void glFogCoordhNV (GLhalfNV fog)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordhDelegate (System.UInt16 fog);
			// void glFogCoordhvNV (GLhalfNV* fog)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordhvDelegate (IntPtr fog);
			// void glMultiTexCoord1hNV (GLenum target, GLhalfNV s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1hDelegate (System.UInt32 target, System.UInt16 s);
			// void glMultiTexCoord1hvNV (GLenum target, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1hvDelegate (System.UInt32 target, IntPtr v);
			// void glMultiTexCoord2hNV (GLenum target, GLhalfNV s, GLhalfNV t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2hDelegate (System.UInt32 target, System.UInt16 s, System.UInt16 t);
			// void glMultiTexCoord2hvNV (GLenum target, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2hvDelegate (System.UInt32 target, IntPtr v);
			// void glMultiTexCoord3hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3hDelegate (System.UInt32 target, System.UInt16 s, System.UInt16 t, System.UInt16 r);
			// void glMultiTexCoord3hvNV (GLenum target, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3hvDelegate (System.UInt32 target, IntPtr v);
			// void glMultiTexCoord4hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4hDelegate (System.UInt32 target, System.UInt16 s, System.UInt16 t, System.UInt16 r, System.UInt16 q);
			// void glMultiTexCoord4hvNV (GLenum target, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4hvDelegate (System.UInt32 target, IntPtr v);
			// void glNormal3hNV (GLhalfNV nx, GLhalfNV ny, GLhalfNV nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3hDelegate (System.UInt16 nx, System.UInt16 ny, System.UInt16 nz);
			// void glNormal3hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3hvDelegate (IntPtr v);
			// void glSecondaryColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3hDelegate (System.UInt16 red, System.UInt16 green, System.UInt16 blue);
			// void glSecondaryColor3hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColor3hvDelegate (IntPtr v);
			// void glTexCoord1hNV (GLhalfNV s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1hDelegate (System.UInt16 s);
			// void glTexCoord1hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1hvDelegate (IntPtr v);
			// void glTexCoord2hNV (GLhalfNV s, GLhalfNV t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2hDelegate (System.UInt16 s, System.UInt16 t);
			// void glTexCoord2hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2hvDelegate (IntPtr v);
			// void glTexCoord3hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3hDelegate (System.UInt16 s, System.UInt16 t, System.UInt16 r);
			// void glTexCoord3hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3hvDelegate (IntPtr v);
			// void glTexCoord4hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4hDelegate (System.UInt16 s, System.UInt16 t, System.UInt16 r, System.UInt16 q);
			// void glTexCoord4hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4hvDelegate (IntPtr v);
			// void glVertex2hNV (GLhalfNV x, GLhalfNV y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2hDelegate (System.UInt16 x, System.UInt16 y);
			// void glVertex2hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2hvDelegate (IntPtr v);
			// void glVertex3hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3hDelegate (System.UInt16 x, System.UInt16 y, System.UInt16 z);
			// void glVertex3hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3hvDelegate (IntPtr v);
			// void glVertex4hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4hDelegate (System.UInt16 x, System.UInt16 y, System.UInt16 z, System.UInt16 w);
			// void glVertex4hvNV (GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4hvDelegate (IntPtr v);
			// void glVertexAttrib1hNV (GLuint index, GLhalfNV x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1hDelegate (System.UInt32 index, System.UInt16 x);
			// void glVertexAttrib1hvNV (GLuint index, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1hvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2hNV (GLuint index, GLhalfNV x, GLhalfNV y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2hDelegate (System.UInt32 index, System.UInt16 x, System.UInt16 y);
			// void glVertexAttrib2hvNV (GLuint index, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2hvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3hDelegate (System.UInt32 index, System.UInt16 x, System.UInt16 y, System.UInt16 z);
			// void glVertexAttrib3hvNV (GLuint index, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3hvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4hDelegate (System.UInt32 index, System.UInt16 x, System.UInt16 y, System.UInt16 z, System.UInt16 w);
			// void glVertexAttrib4hvNV (GLuint index, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4hvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribs1hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs1hvDelegate (System.UInt32 index, System.Int32 n, IntPtr v);
			// void glVertexAttribs2hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs2hvDelegate (System.UInt32 index, System.Int32 n, IntPtr v);
			// void glVertexAttribs3hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs3hvDelegate (System.UInt32 index, System.Int32 n, IntPtr v);
			// void glVertexAttribs4hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs4hvDelegate (System.UInt32 index, System.Int32 n, IntPtr v);
			// void glVertexWeighthNV (GLhalfNV weight)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexWeighthDelegate (System.UInt16 weight);
			// void glVertexWeighthvNV (GLhalfNV* weight)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexWeighthvDelegate (IntPtr weight);
			#endregion // command delegates
			#region commands
			// void glColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue)
			public readonly Color3hDelegate Color3h;
			// void glColor3hvNV (GLhalfNV* v)
			public readonly Color3hvDelegate Color3hv;
			// void glColor4hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha)
			public readonly Color4hDelegate Color4h;
			// void glColor4hvNV (GLhalfNV* v)
			public readonly Color4hvDelegate Color4hv;
			// void glFogCoordhNV (GLhalfNV fog)
			public readonly FogCoordhDelegate FogCoordh;
			// void glFogCoordhvNV (GLhalfNV* fog)
			public readonly FogCoordhvDelegate FogCoordhv;
			// void glMultiTexCoord1hNV (GLenum target, GLhalfNV s)
			public readonly MultiTexCoord1hDelegate MultiTexCoord1h;
			// void glMultiTexCoord1hvNV (GLenum target, GLhalfNV* v)
			public readonly MultiTexCoord1hvDelegate MultiTexCoord1hv;
			// void glMultiTexCoord2hNV (GLenum target, GLhalfNV s, GLhalfNV t)
			public readonly MultiTexCoord2hDelegate MultiTexCoord2h;
			// void glMultiTexCoord2hvNV (GLenum target, GLhalfNV* v)
			public readonly MultiTexCoord2hvDelegate MultiTexCoord2hv;
			// void glMultiTexCoord3hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r)
			public readonly MultiTexCoord3hDelegate MultiTexCoord3h;
			// void glMultiTexCoord3hvNV (GLenum target, GLhalfNV* v)
			public readonly MultiTexCoord3hvDelegate MultiTexCoord3hv;
			// void glMultiTexCoord4hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
			public readonly MultiTexCoord4hDelegate MultiTexCoord4h;
			// void glMultiTexCoord4hvNV (GLenum target, GLhalfNV* v)
			public readonly MultiTexCoord4hvDelegate MultiTexCoord4hv;
			// void glNormal3hNV (GLhalfNV nx, GLhalfNV ny, GLhalfNV nz)
			public readonly Normal3hDelegate Normal3h;
			// void glNormal3hvNV (GLhalfNV* v)
			public readonly Normal3hvDelegate Normal3hv;
			// void glSecondaryColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue)
			public readonly SecondaryColor3hDelegate SecondaryColor3h;
			// void glSecondaryColor3hvNV (GLhalfNV* v)
			public readonly SecondaryColor3hvDelegate SecondaryColor3hv;
			// void glTexCoord1hNV (GLhalfNV s)
			public readonly TexCoord1hDelegate TexCoord1h;
			// void glTexCoord1hvNV (GLhalfNV* v)
			public readonly TexCoord1hvDelegate TexCoord1hv;
			// void glTexCoord2hNV (GLhalfNV s, GLhalfNV t)
			public readonly TexCoord2hDelegate TexCoord2h;
			// void glTexCoord2hvNV (GLhalfNV* v)
			public readonly TexCoord2hvDelegate TexCoord2hv;
			// void glTexCoord3hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r)
			public readonly TexCoord3hDelegate TexCoord3h;
			// void glTexCoord3hvNV (GLhalfNV* v)
			public readonly TexCoord3hvDelegate TexCoord3hv;
			// void glTexCoord4hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
			public readonly TexCoord4hDelegate TexCoord4h;
			// void glTexCoord4hvNV (GLhalfNV* v)
			public readonly TexCoord4hvDelegate TexCoord4hv;
			// void glVertex2hNV (GLhalfNV x, GLhalfNV y)
			public readonly Vertex2hDelegate Vertex2h;
			// void glVertex2hvNV (GLhalfNV* v)
			public readonly Vertex2hvDelegate Vertex2hv;
			// void glVertex3hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z)
			public readonly Vertex3hDelegate Vertex3h;
			// void glVertex3hvNV (GLhalfNV* v)
			public readonly Vertex3hvDelegate Vertex3hv;
			// void glVertex4hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
			public readonly Vertex4hDelegate Vertex4h;
			// void glVertex4hvNV (GLhalfNV* v)
			public readonly Vertex4hvDelegate Vertex4hv;
			// void glVertexAttrib1hNV (GLuint index, GLhalfNV x)
			public readonly VertexAttrib1hDelegate VertexAttrib1h;
			// void glVertexAttrib1hvNV (GLuint index, GLhalfNV* v)
			public readonly VertexAttrib1hvDelegate VertexAttrib1hv;
			// void glVertexAttrib2hNV (GLuint index, GLhalfNV x, GLhalfNV y)
			public readonly VertexAttrib2hDelegate VertexAttrib2h;
			// void glVertexAttrib2hvNV (GLuint index, GLhalfNV* v)
			public readonly VertexAttrib2hvDelegate VertexAttrib2hv;
			// void glVertexAttrib3hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z)
			public readonly VertexAttrib3hDelegate VertexAttrib3h;
			// void glVertexAttrib3hvNV (GLuint index, GLhalfNV* v)
			public readonly VertexAttrib3hvDelegate VertexAttrib3hv;
			// void glVertexAttrib4hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
			public readonly VertexAttrib4hDelegate VertexAttrib4h;
			// void glVertexAttrib4hvNV (GLuint index, GLhalfNV* v)
			public readonly VertexAttrib4hvDelegate VertexAttrib4hv;
			// void glVertexAttribs1hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			public readonly VertexAttribs1hvDelegate VertexAttribs1hv;
			// void glVertexAttribs2hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			public readonly VertexAttribs2hvDelegate VertexAttribs2hv;
			// void glVertexAttribs3hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			public readonly VertexAttribs3hvDelegate VertexAttribs3hv;
			// void glVertexAttribs4hvNV (GLuint index, GLsizei n, GLhalfNV* v)
			public readonly VertexAttribs4hvDelegate VertexAttribs4hv;
			// void glVertexWeighthNV (GLhalfNV weight)
			public readonly VertexWeighthDelegate VertexWeighth;
			// void glVertexWeighthvNV (GLhalfNV* weight)
			public readonly VertexWeighthvDelegate VertexWeighthv;
			#endregion // commands
			public NvHalfFloat (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColor3hNV", out Color3h);
				resolver.LoadHandle ("glColor3hvNV", out Color3hv);
				resolver.LoadHandle ("glColor4hNV", out Color4h);
				resolver.LoadHandle ("glColor4hvNV", out Color4hv);
				resolver.LoadHandle ("glFogCoordhNV", out FogCoordh);
				resolver.LoadHandle ("glFogCoordhvNV", out FogCoordhv);
				resolver.LoadHandle ("glMultiTexCoord1hNV", out MultiTexCoord1h);
				resolver.LoadHandle ("glMultiTexCoord1hvNV", out MultiTexCoord1hv);
				resolver.LoadHandle ("glMultiTexCoord2hNV", out MultiTexCoord2h);
				resolver.LoadHandle ("glMultiTexCoord2hvNV", out MultiTexCoord2hv);
				resolver.LoadHandle ("glMultiTexCoord3hNV", out MultiTexCoord3h);
				resolver.LoadHandle ("glMultiTexCoord3hvNV", out MultiTexCoord3hv);
				resolver.LoadHandle ("glMultiTexCoord4hNV", out MultiTexCoord4h);
				resolver.LoadHandle ("glMultiTexCoord4hvNV", out MultiTexCoord4hv);
				resolver.LoadHandle ("glNormal3hNV", out Normal3h);
				resolver.LoadHandle ("glNormal3hvNV", out Normal3hv);
				resolver.LoadHandle ("glSecondaryColor3hNV", out SecondaryColor3h);
				resolver.LoadHandle ("glSecondaryColor3hvNV", out SecondaryColor3hv);
				resolver.LoadHandle ("glTexCoord1hNV", out TexCoord1h);
				resolver.LoadHandle ("glTexCoord1hvNV", out TexCoord1hv);
				resolver.LoadHandle ("glTexCoord2hNV", out TexCoord2h);
				resolver.LoadHandle ("glTexCoord2hvNV", out TexCoord2hv);
				resolver.LoadHandle ("glTexCoord3hNV", out TexCoord3h);
				resolver.LoadHandle ("glTexCoord3hvNV", out TexCoord3hv);
				resolver.LoadHandle ("glTexCoord4hNV", out TexCoord4h);
				resolver.LoadHandle ("glTexCoord4hvNV", out TexCoord4hv);
				resolver.LoadHandle ("glVertex2hNV", out Vertex2h);
				resolver.LoadHandle ("glVertex2hvNV", out Vertex2hv);
				resolver.LoadHandle ("glVertex3hNV", out Vertex3h);
				resolver.LoadHandle ("glVertex3hvNV", out Vertex3hv);
				resolver.LoadHandle ("glVertex4hNV", out Vertex4h);
				resolver.LoadHandle ("glVertex4hvNV", out Vertex4hv);
				resolver.LoadHandle ("glVertexAttrib1hNV", out VertexAttrib1h);
				resolver.LoadHandle ("glVertexAttrib1hvNV", out VertexAttrib1hv);
				resolver.LoadHandle ("glVertexAttrib2hNV", out VertexAttrib2h);
				resolver.LoadHandle ("glVertexAttrib2hvNV", out VertexAttrib2hv);
				resolver.LoadHandle ("glVertexAttrib3hNV", out VertexAttrib3h);
				resolver.LoadHandle ("glVertexAttrib3hvNV", out VertexAttrib3hv);
				resolver.LoadHandle ("glVertexAttrib4hNV", out VertexAttrib4h);
				resolver.LoadHandle ("glVertexAttrib4hvNV", out VertexAttrib4hv);
				resolver.LoadHandle ("glVertexAttribs1hvNV", out VertexAttribs1hv);
				resolver.LoadHandle ("glVertexAttribs2hvNV", out VertexAttribs2hv);
				resolver.LoadHandle ("glVertexAttribs3hvNV", out VertexAttribs3hv);
				resolver.LoadHandle ("glVertexAttribs4hvNV", out VertexAttribs4hv);
				resolver.LoadHandle ("glVertexWeighthNV", out VertexWeighth);
				resolver.LoadHandle ("glVertexWeighthvNV", out VertexWeighthv);
			}
		}
		public partial class NvInternalformatSampleQuery
		{
			public enum All
			{
				// GL_MULTISAMPLES_NV = 0x9371
				Multisamples = unchecked((int)37745),
				// GL_SUPERSAMPLE_SCALE_X_NV = 0x9372
				SupersampleScaleX = unchecked((int)37746),
				// GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373
				SupersampleScaleY = unchecked((int)37747),
				// GL_CONFORMANT_NV = 0x9374
				Conformant = unchecked((int)37748),
			}
			public const string NAME_STRING = "GL_NV_internalformat_sample_query";
			#region command delegates
			// void glGetInternalformatSampleivNV (GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei bufSize, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetInternalformatSampleivDelegate (System.UInt32 target, System.UInt32 internalformat, System.Int32 samples, System.UInt32 pname, System.Int32 bufSize, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetInternalformatSampleivNV (GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei bufSize, GLint* params)
			public readonly GetInternalformatSampleivDelegate GetInternalformatSampleiv;
			#endregion // commands
			public NvInternalformatSampleQuery (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetInternalformatSampleivNV", out GetInternalformatSampleiv);
			}
		}
		public partial class NvLightMaxExponent
		{
			public enum All
			{
				// GL_MAX_SHININESS_NV = 0x8504
				MaxShininess = unchecked((int)34052),
				// GL_MAX_SPOT_EXPONENT_NV = 0x8505
				MaxSpotExponent = unchecked((int)34053),
			}
			public const string NAME_STRING = "GL_NV_light_max_exponent";
		}
		public partial class NvMultisampleFilterHint
		{
			public enum All
			{
				// GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
				MultisampleFilterHint = unchecked((int)34100),
			}
			public const string NAME_STRING = "GL_NV_multisample_filter_hint";
		}
		public partial class NvOcclusionQuery
		{
			public enum All
			{
				// GL_PIXEL_COUNTER_BITS_NV = 0x8864
				PixelCounterBits = unchecked((int)34916),
				// GL_CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865
				CurrentOcclusionQueryId = unchecked((int)34917),
				// GL_PIXEL_COUNT_NV = 0x8866
				PixelCount = unchecked((int)34918),
				// GL_PIXEL_COUNT_AVAILABLE_NV = 0x8867
				PixelCountAvailable = unchecked((int)34919),
			}
			public const string NAME_STRING = "GL_NV_occlusion_query";
			#region command delegates
			// void glBeginOcclusionQueryNV (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginOcclusionQueryDelegate (System.UInt32 id);
			// void glDeleteOcclusionQueriesNV (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteOcclusionQueriesDelegate (System.Int32 n, IntPtr ids);
			// void glEndOcclusionQueryNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndOcclusionQueryDelegate ();
			// void glGenOcclusionQueriesNV (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenOcclusionQueriesDelegate (System.Int32 n, IntPtr ids);
			// void glGetOcclusionQueryivNV (GLuint id, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetOcclusionQueryivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// void glGetOcclusionQueryuivNV (GLuint id, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetOcclusionQueryuivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsOcclusionQueryNV (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsOcclusionQueryDelegate (System.UInt32 id);
			#endregion // command delegates
			#region commands
			// void glBeginOcclusionQueryNV (GLuint id)
			public readonly BeginOcclusionQueryDelegate BeginOcclusionQuery;
			// void glDeleteOcclusionQueriesNV (GLsizei n, GLuint* ids)
			public readonly DeleteOcclusionQueriesDelegate DeleteOcclusionQueries;
			// void glEndOcclusionQueryNV ()
			public readonly EndOcclusionQueryDelegate EndOcclusionQuery;
			// void glGenOcclusionQueriesNV (GLsizei n, GLuint* ids)
			public readonly GenOcclusionQueriesDelegate GenOcclusionQueries;
			// void glGetOcclusionQueryivNV (GLuint id, GLenum pname, GLint* params)
			public readonly GetOcclusionQueryivDelegate GetOcclusionQueryiv;
			// void glGetOcclusionQueryuivNV (GLuint id, GLenum pname, GLuint* params)
			public readonly GetOcclusionQueryuivDelegate GetOcclusionQueryuiv;
			// GLboolean glIsOcclusionQueryNV (GLuint id)
			public readonly IsOcclusionQueryDelegate IsOcclusionQuery;
			#endregion // commands
			public NvOcclusionQuery (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginOcclusionQueryNV", out BeginOcclusionQuery);
				resolver.LoadHandle ("glDeleteOcclusionQueriesNV", out DeleteOcclusionQueries);
				resolver.LoadHandle ("glEndOcclusionQueryNV", out EndOcclusionQuery);
				resolver.LoadHandle ("glGenOcclusionQueriesNV", out GenOcclusionQueries);
				resolver.LoadHandle ("glGetOcclusionQueryivNV", out GetOcclusionQueryiv);
				resolver.LoadHandle ("glGetOcclusionQueryuivNV", out GetOcclusionQueryuiv);
				resolver.LoadHandle ("glIsOcclusionQueryNV", out IsOcclusionQuery);
			}
		}
		public partial class NvPackedDepthStencil
		{
			public enum All
			{
				// GL_DEPTH_STENCIL_NV = 0x84F9
				DepthStencil = unchecked((int)34041),
				// GL_UNSIGNED_INT_24_8_NV = 0x84FA
				UnsignedInt248 = unchecked((int)34042),
			}
			public const string NAME_STRING = "GL_NV_packed_depth_stencil";
		}
		public partial class NvParameterBufferObject
		{
			public enum All
			{
				// GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0
				MaxProgramParameterBufferBindings = unchecked((int)36256),
				// GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1
				MaxProgramParameterBufferSize = unchecked((int)36257),
				// GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2
				VertexProgramParameterBuffer = unchecked((int)36258),
				// GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3
				GeometryProgramParameterBuffer = unchecked((int)36259),
				// GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4
				FragmentProgramParameterBuffer = unchecked((int)36260),
			}
			public const string NAME_STRING = "GL_NV_parameter_buffer_object";
			#region command delegates
			// void glProgramBufferParametersfvNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramBufferParametersfvDelegate (System.UInt32 target, System.UInt32 bindingIndex, System.UInt32 wordIndex, System.Int32 count, IntPtr @params);
			// void glProgramBufferParametersIivNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramBufferParametersIivDelegate (System.UInt32 target, System.UInt32 bindingIndex, System.UInt32 wordIndex, System.Int32 count, IntPtr @params);
			// void glProgramBufferParametersIuivNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramBufferParametersIuivDelegate (System.UInt32 target, System.UInt32 bindingIndex, System.UInt32 wordIndex, System.Int32 count, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glProgramBufferParametersfvNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLfloat* params)
			public readonly ProgramBufferParametersfvDelegate ProgramBufferParametersfv;
			// void glProgramBufferParametersIivNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLint* params)
			public readonly ProgramBufferParametersIivDelegate ProgramBufferParametersIiv;
			// void glProgramBufferParametersIuivNV (GLenum target, GLuint bindingIndex, GLuint wordIndex, GLsizei count, GLuint* params)
			public readonly ProgramBufferParametersIuivDelegate ProgramBufferParametersIuiv;
			#endregion // commands
			public NvParameterBufferObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glProgramBufferParametersfvNV", out ProgramBufferParametersfv);
				resolver.LoadHandle ("glProgramBufferParametersIivNV", out ProgramBufferParametersIiv);
				resolver.LoadHandle ("glProgramBufferParametersIuivNV", out ProgramBufferParametersIuiv);
			}
		}
		public partial class NvPathRendering
		{
			public enum All
			{
				// GL_CLOSE_PATH_NV = 0x0
				ClosePath = unchecked((int)0),
				// GL_BOLD_BIT_NV = 0x1
				BoldBit = unchecked((int)1),
				// GL_GLYPH_WIDTH_BIT_NV = 0x1
				GlyphWidthBit = unchecked((int)1),
				// GL_GLYPH_HEIGHT_BIT_NV = 0x2
				GlyphHeightBit = unchecked((int)2),
				// GL_ITALIC_BIT_NV = 0x2
				ItalicBit = unchecked((int)2),
				// GL_MOVE_TO_NV = 0x2
				MoveTo = unchecked((int)2),
				// GL_RELATIVE_MOVE_TO_NV = 0x3
				RelativeMoveTo = unchecked((int)3),
				// GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x4
				GlyphHorizontalBearingXBit = unchecked((int)4),
				// GL_LINE_TO_NV = 0x4
				LineTo = unchecked((int)4),
				// GL_RELATIVE_LINE_TO_NV = 0x5
				RelativeLineTo = unchecked((int)5),
				// GL_HORIZONTAL_LINE_TO_NV = 0x6
				HorizontalLineTo = unchecked((int)6),
				// GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x7
				RelativeHorizontalLineTo = unchecked((int)7),
				// GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x8
				GlyphHorizontalBearingYBit = unchecked((int)8),
				// GL_VERTICAL_LINE_TO_NV = 0x8
				VerticalLineTo = unchecked((int)8),
				// GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x9
				RelativeVerticalLineTo = unchecked((int)9),
				// GL_QUADRATIC_CURVE_TO_NV = 0xA
				QuadraticCurveTo = unchecked((int)10),
				// GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0xB
				RelativeQuadraticCurveTo = unchecked((int)11),
				// GL_CUBIC_CURVE_TO_NV = 0xC
				CubicCurveTo = unchecked((int)12),
				// GL_RELATIVE_CUBIC_CURVE_TO_NV = 0xD
				RelativeCubicCurveTo = unchecked((int)13),
				// GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0xE
				SmoothQuadraticCurveTo = unchecked((int)14),
				// GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0xF
				RelativeSmoothQuadraticCurveTo = unchecked((int)15),
				// GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
				GlyphHorizontalBearingAdvanceBit = unchecked((int)16),
				// GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10
				SmoothCubicCurveTo = unchecked((int)16),
				// GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11
				RelativeSmoothCubicCurveTo = unchecked((int)17),
				// GL_SMALL_CCW_ARC_TO_NV = 0x12
				SmallCcwArcTo = unchecked((int)18),
				// GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13
				RelativeSmallCcwArcTo = unchecked((int)19),
				// GL_SMALL_CW_ARC_TO_NV = 0x14
				SmallCwArcTo = unchecked((int)20),
				// GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15
				RelativeSmallCwArcTo = unchecked((int)21),
				// GL_LARGE_CCW_ARC_TO_NV = 0x16
				LargeCcwArcTo = unchecked((int)22),
				// GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17
				RelativeLargeCcwArcTo = unchecked((int)23),
				// GL_LARGE_CW_ARC_TO_NV = 0x18
				LargeCwArcTo = unchecked((int)24),
				// GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19
				RelativeLargeCwArcTo = unchecked((int)25),
				// GL_CONIC_CURVE_TO_NV = 0x1A
				ConicCurveTo = unchecked((int)26),
				// GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B
				RelativeConicCurveTo = unchecked((int)27),
				// GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
				GlyphVerticalBearingXBit = unchecked((int)32),
				// GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
				GlyphVerticalBearingYBit = unchecked((int)64),
				// GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
				GlyphVerticalBearingAdvanceBit = unchecked((int)128),
				// GL_ROUNDED_RECT_NV = 0xE8
				RoundedRect = unchecked((int)232),
				// GL_RELATIVE_ROUNDED_RECT_NV = 0xE9
				RelativeRoundedRect = unchecked((int)233),
				// GL_ROUNDED_RECT2_NV = 0xEA
				RoundedRect2 = unchecked((int)234),
				// GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB
				RelativeRoundedRect2 = unchecked((int)235),
				// GL_ROUNDED_RECT4_NV = 0xEC
				RoundedRect4 = unchecked((int)236),
				// GL_RELATIVE_ROUNDED_RECT4_NV = 0xED
				RelativeRoundedRect4 = unchecked((int)237),
				// GL_ROUNDED_RECT8_NV = 0xEE
				RoundedRect8 = unchecked((int)238),
				// GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF
				RelativeRoundedRect8 = unchecked((int)239),
				// GL_RESTART_PATH_NV = 0xF0
				RestartPath = unchecked((int)240),
				// GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2
				DupFirstCubicCurveTo = unchecked((int)242),
				// GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4
				DupLastCubicCurveTo = unchecked((int)244),
				// GL_RECT_NV = 0xF6
				Rect = unchecked((int)246),
				// GL_RELATIVE_RECT_NV = 0xF7
				RelativeRect = unchecked((int)247),
				// GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8
				CircularCcwArcTo = unchecked((int)248),
				// GL_CIRCULAR_CW_ARC_TO_NV = 0xFA
				CircularCwArcTo = unchecked((int)250),
				// GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC
				CircularTangentArcTo = unchecked((int)252),
				// GL_ARC_TO_NV = 0xFE
				ArcTo = unchecked((int)254),
				// GL_RELATIVE_ARC_TO_NV = 0xFF
				RelativeArcTo = unchecked((int)255),
				// GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
				GlyphHasKerningBit = unchecked((int)256),
				// GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0xBA3
				PathModelviewStackDepth = unchecked((int)2979),
				// GL_PATH_PROJECTION_STACK_DEPTH_NV = 0xBA4
				PathProjectionStackDepth = unchecked((int)2980),
				// GL_PATH_MODELVIEW_MATRIX_NV = 0xBA6
				PathModelviewMatrix = unchecked((int)2982),
				// GL_PATH_PROJECTION_MATRIX_NV = 0xBA7
				PathProjectionMatrix = unchecked((int)2983),
				// GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0xD36
				PathMaxModelviewStackDepth = unchecked((int)3382),
				// GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0xD38
				PathMaxProjectionStackDepth = unchecked((int)3384),
				// GL_PATH_MODELVIEW_NV = 0x1700
				PathModelview = unchecked((int)5888),
				// GL_PATH_PROJECTION_NV = 0x1701
				PathProjection = unchecked((int)5889),
				// GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3
				PathTransposeModelviewMatrix = unchecked((int)34019),
				// GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4
				PathTransposeProjectionMatrix = unchecked((int)34020),
				// GL_PATH_FORMAT_SVG_NV = 0x9070
				PathFormatSvg = unchecked((int)36976),
				// GL_PATH_FORMAT_PS_NV = 0x9071
				PathFormatPs = unchecked((int)36977),
				// GL_STANDARD_FONT_NAME_NV = 0x9072
				StandardFontName = unchecked((int)36978),
				// GL_SYSTEM_FONT_NAME_NV = 0x9073
				SystemFontName = unchecked((int)36979),
				// GL_FILE_NAME_NV = 0x9074
				FileName = unchecked((int)36980),
				// GL_PATH_STROKE_WIDTH_NV = 0x9075
				PathStrokeWidth = unchecked((int)36981),
				// GL_PATH_END_CAPS_NV = 0x9076
				PathEndCaps = unchecked((int)36982),
				// GL_PATH_INITIAL_END_CAP_NV = 0x9077
				PathInitialEndCap = unchecked((int)36983),
				// GL_PATH_TERMINAL_END_CAP_NV = 0x9078
				PathTerminalEndCap = unchecked((int)36984),
				// GL_PATH_JOIN_STYLE_NV = 0x9079
				PathJoinStyle = unchecked((int)36985),
				// GL_PATH_MITER_LIMIT_NV = 0x907A
				PathMiterLimit = unchecked((int)36986),
				// GL_PATH_DASH_CAPS_NV = 0x907B
				PathDashCaps = unchecked((int)36987),
				// GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
				PathInitialDashCap = unchecked((int)36988),
				// GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
				PathTerminalDashCap = unchecked((int)36989),
				// GL_PATH_DASH_OFFSET_NV = 0x907E
				PathDashOffset = unchecked((int)36990),
				// GL_PATH_CLIENT_LENGTH_NV = 0x907F
				PathClientLength = unchecked((int)36991),
				// GL_PATH_FILL_MODE_NV = 0x9080
				PathFillMode = unchecked((int)36992),
				// GL_PATH_FILL_MASK_NV = 0x9081
				PathFillMask = unchecked((int)36993),
				// GL_PATH_FILL_COVER_MODE_NV = 0x9082
				PathFillCoverMode = unchecked((int)36994),
				// GL_PATH_STROKE_COVER_MODE_NV = 0x9083
				PathStrokeCoverMode = unchecked((int)36995),
				// GL_PATH_STROKE_MASK_NV = 0x9084
				PathStrokeMask = unchecked((int)36996),
				// GL_COUNT_UP_NV = 0x9088
				CountUp = unchecked((int)37000),
				// GL_COUNT_DOWN_NV = 0x9089
				CountDown = unchecked((int)37001),
				// GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
				PathObjectBoundingBox = unchecked((int)37002),
				// GL_CONVEX_HULL_NV = 0x908B
				ConvexHull = unchecked((int)37003),
				// GL_BOUNDING_BOX_NV = 0x908D
				BoundingBox = unchecked((int)37005),
				// GL_TRANSLATE_X_NV = 0x908E
				TranslateX = unchecked((int)37006),
				// GL_TRANSLATE_Y_NV = 0x908F
				TranslateY = unchecked((int)37007),
				// GL_TRANSLATE_2D_NV = 0x9090
				Translate2d = unchecked((int)37008),
				// GL_TRANSLATE_3D_NV = 0x9091
				Translate3d = unchecked((int)37009),
				// GL_AFFINE_2D_NV = 0x9092
				Affine2d = unchecked((int)37010),
				// GL_AFFINE_3D_NV = 0x9094
				Affine3d = unchecked((int)37012),
				// GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
				TransposeAffine2d = unchecked((int)37014),
				// GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
				TransposeAffine3d = unchecked((int)37016),
				// GL_UTF8_NV = 0x909A
				Utf8 = unchecked((int)37018),
				// GL_UTF16_NV = 0x909B
				Utf16 = unchecked((int)37019),
				// GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
				BoundingBoxOfBoundingBoxes = unchecked((int)37020),
				// GL_PATH_COMMAND_COUNT_NV = 0x909D
				PathCommandCount = unchecked((int)37021),
				// GL_PATH_COORD_COUNT_NV = 0x909E
				PathCoordCount = unchecked((int)37022),
				// GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
				PathDashArrayCount = unchecked((int)37023),
				// GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
				PathComputedLength = unchecked((int)37024),
				// GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
				PathFillBoundingBox = unchecked((int)37025),
				// GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
				PathStrokeBoundingBox = unchecked((int)37026),
				// GL_SQUARE_NV = 0x90A3
				Square = unchecked((int)37027),
				// GL_ROUND_NV = 0x90A4
				Round = unchecked((int)37028),
				// GL_TRIANGULAR_NV = 0x90A5
				Triangular = unchecked((int)37029),
				// GL_BEVEL_NV = 0x90A6
				Bevel = unchecked((int)37030),
				// GL_MITER_REVERT_NV = 0x90A7
				MiterRevert = unchecked((int)37031),
				// GL_MITER_TRUNCATE_NV = 0x90A8
				MiterTruncate = unchecked((int)37032),
				// GL_SKIP_MISSING_GLYPH_NV = 0x90A9
				SkipMissingGlyph = unchecked((int)37033),
				// GL_USE_MISSING_GLYPH_NV = 0x90AA
				UseMissingGlyph = unchecked((int)37034),
				// GL_PATH_ERROR_POSITION_NV = 0x90AB
				PathErrorPosition = unchecked((int)37035),
				// GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
				AccumAdjacentPairs = unchecked((int)37037),
				// GL_ADJACENT_PAIRS_NV = 0x90AE
				AdjacentPairs = unchecked((int)37038),
				// GL_FIRST_TO_REST_NV = 0x90AF
				FirstToRest = unchecked((int)37039),
				// GL_PATH_GEN_MODE_NV = 0x90B0
				PathGenMode = unchecked((int)37040),
				// GL_PATH_GEN_COEFF_NV = 0x90B1
				PathGenCoeff = unchecked((int)37041),
				// GL_PATH_GEN_COMPONENTS_NV = 0x90B3
				PathGenComponents = unchecked((int)37043),
				// GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
				PathDashOffsetReset = unchecked((int)37044),
				// GL_MOVE_TO_RESETS_NV = 0x90B5
				MoveToResets = unchecked((int)37045),
				// GL_MOVE_TO_CONTINUES_NV = 0x90B6
				MoveToContinues = unchecked((int)37046),
				// GL_PATH_STENCIL_FUNC_NV = 0x90B7
				PathStencilFunc = unchecked((int)37047),
				// GL_PATH_STENCIL_REF_NV = 0x90B8
				PathStencilRef = unchecked((int)37048),
				// GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9
				PathStencilValueMask = unchecked((int)37049),
				// GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD
				PathStencilDepthOffsetFactor = unchecked((int)37053),
				// GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE
				PathStencilDepthOffsetUnits = unchecked((int)37054),
				// GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF
				PathCoverDepthFunc = unchecked((int)37055),
				// GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368
				FontGlyphsAvailable = unchecked((int)37736),
				// GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369
				FontTargetUnavailable = unchecked((int)37737),
				// GL_FONT_UNAVAILABLE_NV = 0x936A
				FontUnavailable = unchecked((int)37738),
				// GL_FONT_UNINTELLIGIBLE_NV = 0x936B
				FontUnintelligible = unchecked((int)37739),
				// GL_STANDARD_FONT_FORMAT_NV = 0x936C
				StandardFontFormat = unchecked((int)37740),
				// GL_FRAGMENT_INPUT_NV = 0x936D
				FragmentInput = unchecked((int)37741),
				// GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x10000
				FontXMinBoundsBit = unchecked((int)65536),
				// GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x20000
				FontYMinBoundsBit = unchecked((int)131072),
				// GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x40000
				FontXMaxBoundsBit = unchecked((int)262144),
				// GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x80000
				FontYMaxBoundsBit = unchecked((int)524288),
				// GL_FONT_UNITS_PER_EM_BIT_NV = 0x100000
				FontUnitsPerEmBit = unchecked((int)1048576),
				// GL_FONT_ASCENDER_BIT_NV = 0x200000
				FontAscenderBit = unchecked((int)2097152),
				// GL_FONT_DESCENDER_BIT_NV = 0x400000
				FontDescenderBit = unchecked((int)4194304),
				// GL_FONT_HEIGHT_BIT_NV = 0x800000
				FontHeightBit = unchecked((int)8388608),
				// GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x1000000
				FontMaxAdvanceWidthBit = unchecked((int)16777216),
				// GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x2000000
				FontMaxAdvanceHeightBit = unchecked((int)33554432),
				// GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x4000000
				FontUnderlinePositionBit = unchecked((int)67108864),
				// GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x8000000
				FontUnderlineThicknessBit = unchecked((int)134217728),
				// GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
				FontHasKerningBit = unchecked((int)268435456),
				// GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
				FontNumGlyphIndicesBit = unchecked((int)536870912),
			}
			public const string NAME_STRING = "GL_NV_path_rendering";
			#region command delegates
			// void glCopyPathNV (GLuint resultPath, GLuint srcPath)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CopyPathDelegate (System.UInt32 resultPath, System.UInt32 srcPath);
			// void glCoverFillPathNV (GLuint path, GLenum coverMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverFillPathDelegate (System.UInt32 path, System.UInt32 coverMode);
			// void glCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverFillPathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.UInt32 coverMode, System.UInt32 transformType, IntPtr transformValues);
			// void glCoverStrokePathNV (GLuint path, GLenum coverMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverStrokePathDelegate (System.UInt32 path, System.UInt32 coverMode);
			// void glCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CoverStrokePathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.UInt32 coverMode, System.UInt32 transformType, IntPtr transformValues);
			// void glDeletePathsNV (GLuint path, GLsizei range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeletePathsDelegate (System.UInt32 path, System.Int32 range);
			// GLuint glGenPathsNV (GLsizei range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GenPathsDelegate (System.Int32 range);
			// void glGetPathCommandsNV (GLuint path, GLubyte* commands)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathCommandsDelegate (System.UInt32 path, IntPtr commands);
			// void glGetPathCoordsNV (GLuint path, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathCoordsDelegate (System.UInt32 path, IntPtr coords);
			// void glGetPathDashArrayNV (GLuint path, GLfloat* dashArray)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathDashArrayDelegate (System.UInt32 path, IntPtr dashArray);
			// GLfloat glGetPathLengthNV (GLuint path, GLsizei startSegment, GLsizei numSegments)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Single GetPathLengthDelegate (System.UInt32 path, System.Int32 startSegment, System.Int32 numSegments);
			// void glGetPathMetricRangeNV (GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat* metrics)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathMetricRangeDelegate (System.UInt32 metricQueryMask, System.UInt32 firstPathName, System.Int32 numPaths, System.Int32 stride, IntPtr metrics);
			// void glGetPathMetricsNV (GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLsizei stride, GLfloat* metrics)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathMetricsDelegate (System.UInt32 metricQueryMask, System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.Int32 stride, IntPtr metrics);
			// void glGetPathParameterfvNV (GLuint path, GLenum pname, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathParameterfvDelegate (System.UInt32 path, System.UInt32 pname, IntPtr value);
			// void glGetPathParameterivNV (GLuint path, GLenum pname, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathParameterivDelegate (System.UInt32 path, System.UInt32 pname, IntPtr value);
			// void glGetPathSpacingNV (GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat* returnedSpacing)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPathSpacingDelegate (System.UInt32 pathListMode, System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.Single advanceScale, System.Single kerningScale, System.UInt32 transformType, IntPtr returnedSpacing);
			// void glGetProgramResourcefvNV (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramResourcefvDelegate (System.UInt32 program, System.UInt32 programInterface, System.UInt32 index, System.Int32 propCount, IntPtr props, System.Int32 bufSize, IntPtr length, IntPtr @params);
			// void glInterpolatePathsNV (GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void InterpolatePathsDelegate (System.UInt32 resultPath, System.UInt32 pathA, System.UInt32 pathB, System.Single weight);
			// GLboolean glIsPathNV (GLuint path)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsPathDelegate (System.UInt32 path);
			// GLboolean glIsPointInFillPathNV (GLuint path, GLuint mask, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsPointInFillPathDelegate (System.UInt32 path, System.UInt32 mask, System.Single x, System.Single y);
			// GLboolean glIsPointInStrokePathNV (GLuint path, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsPointInStrokePathDelegate (System.UInt32 path, System.Single x, System.Single y);
			// void glMatrixLoad3x2fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoad3x2fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glMatrixLoad3x3fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoad3x3fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glMatrixLoadTranspose3x3fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixLoadTranspose3x3fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glMatrixMult3x2fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMult3x2fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glMatrixMult3x3fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMult3x3fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glMatrixMultTranspose3x3fNV (GLenum matrixMode, GLfloat* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MatrixMultTranspose3x3fDelegate (System.UInt32 matrixMode, IntPtr m);
			// void glPathCommandsNV (GLuint path, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathCommandsDelegate (System.UInt32 path, System.Int32 numCommands, IntPtr commands, System.Int32 numCoords, System.UInt32 coordType, IntPtr coords);
			// void glPathCoordsNV (GLuint path, GLsizei numCoords, GLenum coordType, void* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathCoordsDelegate (System.UInt32 path, System.Int32 numCoords, System.UInt32 coordType, IntPtr coords);
			// void glPathCoverDepthFuncNV (GLenum func)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathCoverDepthFuncDelegate (DepthFunction func);
			// void glPathDashArrayNV (GLuint path, GLsizei dashCount, GLfloat* dashArray)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathDashArrayDelegate (System.UInt32 path, System.Int32 dashCount, IntPtr dashArray);
			// GLenum glPathGlyphIndexArrayNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 PathGlyphIndexArrayDelegate (System.UInt32 firstPathName, System.UInt32 fontTarget, IntPtr fontName, System.UInt32 fontStyle, System.UInt32 firstGlyphIndex, System.Int32 numGlyphs, System.UInt32 pathParameterTemplate, System.Single emScale);
			// GLenum glPathGlyphIndexRangeNV (GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint pathParameterTemplate, GLfloat emScale, GLuint baseAndCount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 PathGlyphIndexRangeDelegate (System.UInt32 fontTarget, IntPtr fontName, System.UInt32 fontStyle, System.UInt32 pathParameterTemplate, System.Single emScale, System.UInt32 baseAndCount);
			// void glPathGlyphRangeNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathGlyphRangeDelegate (System.UInt32 firstPathName, System.UInt32 fontTarget, IntPtr fontName, System.UInt32 fontStyle, System.UInt32 firstGlyph, System.Int32 numGlyphs, System.UInt32 handleMissingGlyphs, System.UInt32 pathParameterTemplate, System.Single emScale);
			// void glPathGlyphsNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, void* charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathGlyphsDelegate (System.UInt32 firstPathName, System.UInt32 fontTarget, IntPtr fontName, System.UInt32 fontStyle, System.Int32 numGlyphs, System.UInt32 type, IntPtr charcodes, System.UInt32 handleMissingGlyphs, System.UInt32 pathParameterTemplate, System.Single emScale);
			// GLenum glPathMemoryGlyphIndexArrayNV (GLuint firstPathName, GLenum fontTarget, GLsizeiptr fontSize, void* fontData, GLsizei faceIndex, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 PathMemoryGlyphIndexArrayDelegate (System.UInt32 firstPathName, System.UInt32 fontTarget, System.IntPtr fontSize, IntPtr fontData, System.Int32 faceIndex, System.UInt32 firstGlyphIndex, System.Int32 numGlyphs, System.UInt32 pathParameterTemplate, System.Single emScale);
			// void glPathParameterfNV (GLuint path, GLenum pname, GLfloat value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathParameterfDelegate (System.UInt32 path, System.UInt32 pname, System.Single value);
			// void glPathParameterfvNV (GLuint path, GLenum pname, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathParameterfvDelegate (System.UInt32 path, System.UInt32 pname, IntPtr value);
			// void glPathParameteriNV (GLuint path, GLenum pname, GLint value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathParameteriDelegate (System.UInt32 path, System.UInt32 pname, System.Int32 value);
			// void glPathParameterivNV (GLuint path, GLenum pname, GLint* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathParameterivDelegate (System.UInt32 path, System.UInt32 pname, IntPtr value);
			// void glPathStencilDepthOffsetNV (GLfloat factor, GLfloat units)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathStencilDepthOffsetDelegate (System.Single factor, System.Single units);
			// void glPathStencilFuncNV (GLenum func, GLint ref, GLuint mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathStencilFuncDelegate (StencilFunction func, System.Int32 @ref, System.UInt32 mask);
			// void glPathStringNV (GLuint path, GLenum format, GLsizei length, void* pathString)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathStringDelegate (System.UInt32 path, System.UInt32 format, System.Int32 length, IntPtr pathString);
			// void glPathSubCommandsNV (GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathSubCommandsDelegate (System.UInt32 path, System.Int32 commandStart, System.Int32 commandsToDelete, System.Int32 numCommands, IntPtr commands, System.Int32 numCoords, System.UInt32 coordType, IntPtr coords);
			// void glPathSubCoordsNV (GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, void* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PathSubCoordsDelegate (System.UInt32 path, System.Int32 coordStart, System.Int32 numCoords, System.UInt32 coordType, IntPtr coords);
			// GLboolean glPointAlongPathNV (GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat* x, GLfloat* y, GLfloat* tangentX, GLfloat* tangentY)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean PointAlongPathDelegate (System.UInt32 path, System.Int32 startSegment, System.Int32 numSegments, System.Single distance, IntPtr x, IntPtr y, IntPtr tangentX, IntPtr tangentY);
			// void glProgramPathFragmentInputGenNV (GLuint program, GLint location, GLenum genMode, GLint components, GLfloat* coeffs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramPathFragmentInputGenDelegate (System.UInt32 program, System.Int32 location, System.UInt32 genMode, System.Int32 components, IntPtr coeffs);
			// void glStencilFillPathNV (GLuint path, GLenum fillMode, GLuint mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilFillPathDelegate (System.UInt32 path, System.UInt32 fillMode, System.UInt32 mask);
			// void glStencilFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilFillPathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.UInt32 fillMode, System.UInt32 mask, System.UInt32 transformType, IntPtr transformValues);
			// void glStencilStrokePathNV (GLuint path, GLint reference, GLuint mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilStrokePathDelegate (System.UInt32 path, System.Int32 reference, System.UInt32 mask);
			// void glStencilStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilStrokePathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.Int32 reference, System.UInt32 mask, System.UInt32 transformType, IntPtr transformValues);
			// void glStencilThenCoverFillPathNV (GLuint path, GLenum fillMode, GLuint mask, GLenum coverMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilThenCoverFillPathDelegate (System.UInt32 path, System.UInt32 fillMode, System.UInt32 mask, System.UInt32 coverMode);
			// void glStencilThenCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilThenCoverFillPathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.UInt32 fillMode, System.UInt32 mask, System.UInt32 coverMode, System.UInt32 transformType, IntPtr transformValues);
			// void glStencilThenCoverStrokePathNV (GLuint path, GLint reference, GLuint mask, GLenum coverMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilThenCoverStrokePathDelegate (System.UInt32 path, System.Int32 reference, System.UInt32 mask, System.UInt32 coverMode);
			// void glStencilThenCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilThenCoverStrokePathInstancedDelegate (System.Int32 numPaths, System.UInt32 pathNameType, IntPtr paths, System.UInt32 pathBase, System.Int32 reference, System.UInt32 mask, System.UInt32 coverMode, System.UInt32 transformType, IntPtr transformValues);
			// void glTransformPathNV (GLuint resultPath, GLuint srcPath, GLenum transformType, GLfloat* transformValues)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TransformPathDelegate (System.UInt32 resultPath, System.UInt32 srcPath, System.UInt32 transformType, IntPtr transformValues);
			// void glWeightPathsNV (GLuint resultPath, GLsizei numPaths, GLuint* paths, GLfloat* weights)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WeightPathsDelegate (System.UInt32 resultPath, System.Int32 numPaths, IntPtr paths, IntPtr weights);
			#endregion // command delegates
			#region commands
			// void glCopyPathNV (GLuint resultPath, GLuint srcPath)
			public readonly CopyPathDelegate CopyPath;
			// void glCoverFillPathNV (GLuint path, GLenum coverMode)
			public readonly CoverFillPathDelegate CoverFillPath;
			// void glCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			public readonly CoverFillPathInstancedDelegate CoverFillPathInstanced;
			// void glCoverStrokePathNV (GLuint path, GLenum coverMode)
			public readonly CoverStrokePathDelegate CoverStrokePath;
			// void glCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			public readonly CoverStrokePathInstancedDelegate CoverStrokePathInstanced;
			// void glDeletePathsNV (GLuint path, GLsizei range)
			public readonly DeletePathsDelegate DeletePaths;
			// GLuint glGenPathsNV (GLsizei range)
			public readonly GenPathsDelegate GenPaths;
			// void glGetPathCommandsNV (GLuint path, GLubyte* commands)
			public readonly GetPathCommandsDelegate GetPathCommands;
			// void glGetPathCoordsNV (GLuint path, GLfloat* coords)
			public readonly GetPathCoordsDelegate GetPathCoords;
			// void glGetPathDashArrayNV (GLuint path, GLfloat* dashArray)
			public readonly GetPathDashArrayDelegate GetPathDashArray;
			// GLfloat glGetPathLengthNV (GLuint path, GLsizei startSegment, GLsizei numSegments)
			public readonly GetPathLengthDelegate GetPathLength;
			// void glGetPathMetricRangeNV (GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat* metrics)
			public readonly GetPathMetricRangeDelegate GetPathMetricRange;
			// void glGetPathMetricsNV (GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLsizei stride, GLfloat* metrics)
			public readonly GetPathMetricsDelegate GetPathMetrics;
			// void glGetPathParameterfvNV (GLuint path, GLenum pname, GLfloat* value)
			public readonly GetPathParameterfvDelegate GetPathParameterfv;
			// void glGetPathParameterivNV (GLuint path, GLenum pname, GLint* value)
			public readonly GetPathParameterivDelegate GetPathParameteriv;
			// void glGetPathSpacingNV (GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat* returnedSpacing)
			public readonly GetPathSpacingDelegate GetPathSpacing;
			// void glGetProgramResourcefvNV (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLfloat* params)
			public readonly GetProgramResourcefvDelegate GetProgramResourcefv;
			// void glInterpolatePathsNV (GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight)
			public readonly InterpolatePathsDelegate InterpolatePaths;
			// GLboolean glIsPathNV (GLuint path)
			public readonly IsPathDelegate IsPath;
			// GLboolean glIsPointInFillPathNV (GLuint path, GLuint mask, GLfloat x, GLfloat y)
			public readonly IsPointInFillPathDelegate IsPointInFillPath;
			// GLboolean glIsPointInStrokePathNV (GLuint path, GLfloat x, GLfloat y)
			public readonly IsPointInStrokePathDelegate IsPointInStrokePath;
			// void glMatrixLoad3x2fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixLoad3x2fDelegate MatrixLoad3x2f;
			// void glMatrixLoad3x3fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixLoad3x3fDelegate MatrixLoad3x3f;
			// void glMatrixLoadTranspose3x3fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixLoadTranspose3x3fDelegate MatrixLoadTranspose3x3f;
			// void glMatrixMult3x2fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixMult3x2fDelegate MatrixMult3x2f;
			// void glMatrixMult3x3fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixMult3x3fDelegate MatrixMult3x3f;
			// void glMatrixMultTranspose3x3fNV (GLenum matrixMode, GLfloat* m)
			public readonly MatrixMultTranspose3x3fDelegate MatrixMultTranspose3x3f;
			// void glPathCommandsNV (GLuint path, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords)
			public readonly PathCommandsDelegate PathCommands;
			// void glPathCoordsNV (GLuint path, GLsizei numCoords, GLenum coordType, void* coords)
			public readonly PathCoordsDelegate PathCoords;
			// void glPathCoverDepthFuncNV (GLenum func)
			public readonly PathCoverDepthFuncDelegate PathCoverDepthFunc;
			// void glPathDashArrayNV (GLuint path, GLsizei dashCount, GLfloat* dashArray)
			public readonly PathDashArrayDelegate PathDashArray;
			// GLenum glPathGlyphIndexArrayNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			public readonly PathGlyphIndexArrayDelegate PathGlyphIndexArray;
			// GLenum glPathGlyphIndexRangeNV (GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint pathParameterTemplate, GLfloat emScale, GLuint baseAndCount)
			public readonly PathGlyphIndexRangeDelegate PathGlyphIndexRange;
			// void glPathGlyphRangeNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			public readonly PathGlyphRangeDelegate PathGlyphRange;
			// void glPathGlyphsNV (GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, void* charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			public readonly PathGlyphsDelegate PathGlyphs;
			// GLenum glPathMemoryGlyphIndexArrayNV (GLuint firstPathName, GLenum fontTarget, GLsizeiptr fontSize, void* fontData, GLsizei faceIndex, GLuint firstGlyphIndex, GLsizei numGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
			public readonly PathMemoryGlyphIndexArrayDelegate PathMemoryGlyphIndexArray;
			// void glPathParameterfNV (GLuint path, GLenum pname, GLfloat value)
			public readonly PathParameterfDelegate PathParameterf;
			// void glPathParameterfvNV (GLuint path, GLenum pname, GLfloat* value)
			public readonly PathParameterfvDelegate PathParameterfv;
			// void glPathParameteriNV (GLuint path, GLenum pname, GLint value)
			public readonly PathParameteriDelegate PathParameteri;
			// void glPathParameterivNV (GLuint path, GLenum pname, GLint* value)
			public readonly PathParameterivDelegate PathParameteriv;
			// void glPathStencilDepthOffsetNV (GLfloat factor, GLfloat units)
			public readonly PathStencilDepthOffsetDelegate PathStencilDepthOffset;
			// void glPathStencilFuncNV (GLenum func, GLint ref, GLuint mask)
			public readonly PathStencilFuncDelegate PathStencilFunc;
			// void glPathStringNV (GLuint path, GLenum format, GLsizei length, void* pathString)
			public readonly PathStringDelegate PathString;
			// void glPathSubCommandsNV (GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords)
			public readonly PathSubCommandsDelegate PathSubCommands;
			// void glPathSubCoordsNV (GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, void* coords)
			public readonly PathSubCoordsDelegate PathSubCoords;
			// GLboolean glPointAlongPathNV (GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat* x, GLfloat* y, GLfloat* tangentX, GLfloat* tangentY)
			public readonly PointAlongPathDelegate PointAlongPath;
			// void glProgramPathFragmentInputGenNV (GLuint program, GLint location, GLenum genMode, GLint components, GLfloat* coeffs)
			public readonly ProgramPathFragmentInputGenDelegate ProgramPathFragmentInputGen;
			// void glStencilFillPathNV (GLuint path, GLenum fillMode, GLuint mask)
			public readonly StencilFillPathDelegate StencilFillPath;
			// void glStencilFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, GLfloat* transformValues)
			public readonly StencilFillPathInstancedDelegate StencilFillPathInstanced;
			// void glStencilStrokePathNV (GLuint path, GLint reference, GLuint mask)
			public readonly StencilStrokePathDelegate StencilStrokePath;
			// void glStencilStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, GLfloat* transformValues)
			public readonly StencilStrokePathInstancedDelegate StencilStrokePathInstanced;
			// void glStencilThenCoverFillPathNV (GLuint path, GLenum fillMode, GLuint mask, GLenum coverMode)
			public readonly StencilThenCoverFillPathDelegate StencilThenCoverFillPath;
			// void glStencilThenCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			public readonly StencilThenCoverFillPathInstancedDelegate StencilThenCoverFillPathInstanced;
			// void glStencilThenCoverStrokePathNV (GLuint path, GLint reference, GLuint mask, GLenum coverMode)
			public readonly StencilThenCoverStrokePathDelegate StencilThenCoverStrokePath;
			// void glStencilThenCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum coverMode, GLenum transformType, GLfloat* transformValues)
			public readonly StencilThenCoverStrokePathInstancedDelegate StencilThenCoverStrokePathInstanced;
			// void glTransformPathNV (GLuint resultPath, GLuint srcPath, GLenum transformType, GLfloat* transformValues)
			public readonly TransformPathDelegate TransformPath;
			// void glWeightPathsNV (GLuint resultPath, GLsizei numPaths, GLuint* paths, GLfloat* weights)
			public readonly WeightPathsDelegate WeightPaths;
			#endregion // commands
			public NvPathRendering (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCopyPathNV", out CopyPath);
				resolver.LoadHandle ("glCoverFillPathNV", out CoverFillPath);
				resolver.LoadHandle ("glCoverFillPathInstancedNV", out CoverFillPathInstanced);
				resolver.LoadHandle ("glCoverStrokePathNV", out CoverStrokePath);
				resolver.LoadHandle ("glCoverStrokePathInstancedNV", out CoverStrokePathInstanced);
				resolver.LoadHandle ("glDeletePathsNV", out DeletePaths);
				resolver.LoadHandle ("glGenPathsNV", out GenPaths);
				resolver.LoadHandle ("glGetPathCommandsNV", out GetPathCommands);
				resolver.LoadHandle ("glGetPathCoordsNV", out GetPathCoords);
				resolver.LoadHandle ("glGetPathDashArrayNV", out GetPathDashArray);
				resolver.LoadHandle ("glGetPathLengthNV", out GetPathLength);
				resolver.LoadHandle ("glGetPathMetricRangeNV", out GetPathMetricRange);
				resolver.LoadHandle ("glGetPathMetricsNV", out GetPathMetrics);
				resolver.LoadHandle ("glGetPathParameterfvNV", out GetPathParameterfv);
				resolver.LoadHandle ("glGetPathParameterivNV", out GetPathParameteriv);
				resolver.LoadHandle ("glGetPathSpacingNV", out GetPathSpacing);
				resolver.LoadHandle ("glGetProgramResourcefvNV", out GetProgramResourcefv);
				resolver.LoadHandle ("glInterpolatePathsNV", out InterpolatePaths);
				resolver.LoadHandle ("glIsPathNV", out IsPath);
				resolver.LoadHandle ("glIsPointInFillPathNV", out IsPointInFillPath);
				resolver.LoadHandle ("glIsPointInStrokePathNV", out IsPointInStrokePath);
				resolver.LoadHandle ("glMatrixLoad3x2fNV", out MatrixLoad3x2f);
				resolver.LoadHandle ("glMatrixLoad3x3fNV", out MatrixLoad3x3f);
				resolver.LoadHandle ("glMatrixLoadTranspose3x3fNV", out MatrixLoadTranspose3x3f);
				resolver.LoadHandle ("glMatrixMult3x2fNV", out MatrixMult3x2f);
				resolver.LoadHandle ("glMatrixMult3x3fNV", out MatrixMult3x3f);
				resolver.LoadHandle ("glMatrixMultTranspose3x3fNV", out MatrixMultTranspose3x3f);
				resolver.LoadHandle ("glPathCommandsNV", out PathCommands);
				resolver.LoadHandle ("glPathCoordsNV", out PathCoords);
				resolver.LoadHandle ("glPathCoverDepthFuncNV", out PathCoverDepthFunc);
				resolver.LoadHandle ("glPathDashArrayNV", out PathDashArray);
				resolver.LoadHandle ("glPathGlyphIndexArrayNV", out PathGlyphIndexArray);
				resolver.LoadHandle ("glPathGlyphIndexRangeNV", out PathGlyphIndexRange);
				resolver.LoadHandle ("glPathGlyphRangeNV", out PathGlyphRange);
				resolver.LoadHandle ("glPathGlyphsNV", out PathGlyphs);
				resolver.LoadHandle ("glPathMemoryGlyphIndexArrayNV", out PathMemoryGlyphIndexArray);
				resolver.LoadHandle ("glPathParameterfNV", out PathParameterf);
				resolver.LoadHandle ("glPathParameterfvNV", out PathParameterfv);
				resolver.LoadHandle ("glPathParameteriNV", out PathParameteri);
				resolver.LoadHandle ("glPathParameterivNV", out PathParameteriv);
				resolver.LoadHandle ("glPathStencilDepthOffsetNV", out PathStencilDepthOffset);
				resolver.LoadHandle ("glPathStencilFuncNV", out PathStencilFunc);
				resolver.LoadHandle ("glPathStringNV", out PathString);
				resolver.LoadHandle ("glPathSubCommandsNV", out PathSubCommands);
				resolver.LoadHandle ("glPathSubCoordsNV", out PathSubCoords);
				resolver.LoadHandle ("glPointAlongPathNV", out PointAlongPath);
				resolver.LoadHandle ("glProgramPathFragmentInputGenNV", out ProgramPathFragmentInputGen);
				resolver.LoadHandle ("glStencilFillPathNV", out StencilFillPath);
				resolver.LoadHandle ("glStencilFillPathInstancedNV", out StencilFillPathInstanced);
				resolver.LoadHandle ("glStencilStrokePathNV", out StencilStrokePath);
				resolver.LoadHandle ("glStencilStrokePathInstancedNV", out StencilStrokePathInstanced);
				resolver.LoadHandle ("glStencilThenCoverFillPathNV", out StencilThenCoverFillPath);
				resolver.LoadHandle ("glStencilThenCoverFillPathInstancedNV", out StencilThenCoverFillPathInstanced);
				resolver.LoadHandle ("glStencilThenCoverStrokePathNV", out StencilThenCoverStrokePath);
				resolver.LoadHandle ("glStencilThenCoverStrokePathInstancedNV", out StencilThenCoverStrokePathInstanced);
				resolver.LoadHandle ("glTransformPathNV", out TransformPath);
				resolver.LoadHandle ("glWeightPathsNV", out WeightPaths);
			}
		}
		public partial class NvPathRenderingSharedEdge
		{
			public enum All
			{
				// GL_SHARED_EDGE_NV = 0xC0
				SharedEdge = unchecked((int)192),
			}
			public const string NAME_STRING = "GL_NV_path_rendering_shared_edge";
		}
		public partial class NvPixelDataRange
		{
			public enum All
			{
				// GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878
				WritePixelDataRange = unchecked((int)34936),
				// GL_READ_PIXEL_DATA_RANGE_NV = 0x8879
				ReadPixelDataRange = unchecked((int)34937),
				// GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A
				WritePixelDataRangeLength = unchecked((int)34938),
				// GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B
				ReadPixelDataRangeLength = unchecked((int)34939),
				// GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C
				WritePixelDataRangePointer = unchecked((int)34940),
				// GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D
				ReadPixelDataRangePointer = unchecked((int)34941),
			}
			public const string NAME_STRING = "GL_NV_pixel_data_range";
			#region command delegates
			// void glFlushPixelDataRangeNV (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushPixelDataRangeDelegate (System.UInt32 target);
			// void glPixelDataRangeNV (GLenum target, GLsizei length, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelDataRangeDelegate (System.UInt32 target, System.Int32 length, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glFlushPixelDataRangeNV (GLenum target)
			public readonly FlushPixelDataRangeDelegate FlushPixelDataRange;
			// void glPixelDataRangeNV (GLenum target, GLsizei length, void* pointer)
			public readonly PixelDataRangeDelegate PixelDataRange;
			#endregion // commands
			public NvPixelDataRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFlushPixelDataRangeNV", out FlushPixelDataRange);
				resolver.LoadHandle ("glPixelDataRangeNV", out PixelDataRange);
			}
		}
		public partial class NvPointSprite
		{
			public enum All
			{
				// GL_POINT_SPRITE_NV = 0x8861
				PointSprite = unchecked((int)34913),
				// GL_COORD_REPLACE_NV = 0x8862
				CoordReplace = unchecked((int)34914),
				// GL_POINT_SPRITE_R_MODE_NV = 0x8863
				PointSpriteRMode = unchecked((int)34915),
			}
			public const string NAME_STRING = "GL_NV_point_sprite";
			#region command delegates
			// void glPointParameteriNV (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameteriDelegate (System.UInt32 pname, System.Int32 param);
			// void glPointParameterivNV (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterivDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glPointParameteriNV (GLenum pname, GLint param)
			public readonly PointParameteriDelegate PointParameteri;
			// void glPointParameterivNV (GLenum pname, GLint* params)
			public readonly PointParameterivDelegate PointParameteriv;
			#endregion // commands
			public NvPointSprite (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPointParameteriNV", out PointParameteri);
				resolver.LoadHandle ("glPointParameterivNV", out PointParameteriv);
			}
		}
		public partial class NvPresentVideo
		{
			public enum All
			{
				// GL_FRAME_NV = 0x8E26
				Frame = unchecked((int)36390),
				// GL_FIELDS_NV = 0x8E27
				Fields = unchecked((int)36391),
				// GL_CURRENT_TIME_NV = 0x8E28
				CurrentTime = unchecked((int)36392),
				// GL_NUM_FILL_STREAMS_NV = 0x8E29
				NumFillStreams = unchecked((int)36393),
				// GL_PRESENT_TIME_NV = 0x8E2A
				PresentTime = unchecked((int)36394),
				// GL_PRESENT_DURATION_NV = 0x8E2B
				PresentDuration = unchecked((int)36395),
			}
			public const string NAME_STRING = "GL_NV_present_video";
			#region command delegates
			// void glGetVideoi64vNV (GLuint video_slot, GLenum pname, GLint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoi64vDelegate (System.UInt32 video_slot, System.UInt32 pname, IntPtr @params);
			// void glGetVideoivNV (GLuint video_slot, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoivDelegate (System.UInt32 video_slot, System.UInt32 pname, IntPtr @params);
			// void glGetVideoui64vNV (GLuint video_slot, GLenum pname, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoui64vDelegate (System.UInt32 video_slot, System.UInt32 pname, IntPtr @params);
			// void glGetVideouivNV (GLuint video_slot, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideouivDelegate (System.UInt32 video_slot, System.UInt32 pname, IntPtr @params);
			// void glPresentFrameDualFillNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PresentFrameDualFillDelegate (System.UInt32 video_slot, System.UInt64 minPresentTime, System.UInt32 beginPresentTimeId, System.UInt32 presentDurationId, System.UInt32 type, System.UInt32 target0, System.UInt32 fill0, System.UInt32 target1, System.UInt32 fill1, System.UInt32 target2, System.UInt32 fill2, System.UInt32 target3, System.UInt32 fill3);
			// void glPresentFrameKeyedNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PresentFrameKeyedDelegate (System.UInt32 video_slot, System.UInt64 minPresentTime, System.UInt32 beginPresentTimeId, System.UInt32 presentDurationId, System.UInt32 type, System.UInt32 target0, System.UInt32 fill0, System.UInt32 key0, System.UInt32 target1, System.UInt32 fill1, System.UInt32 key1);
			#endregion // command delegates
			#region commands
			// void glGetVideoi64vNV (GLuint video_slot, GLenum pname, GLint64EXT* params)
			public readonly GetVideoi64vDelegate GetVideoi64v;
			// void glGetVideoivNV (GLuint video_slot, GLenum pname, GLint* params)
			public readonly GetVideoivDelegate GetVideoiv;
			// void glGetVideoui64vNV (GLuint video_slot, GLenum pname, GLuint64EXT* params)
			public readonly GetVideoui64vDelegate GetVideoui64v;
			// void glGetVideouivNV (GLuint video_slot, GLenum pname, GLuint* params)
			public readonly GetVideouivDelegate GetVideouiv;
			// void glPresentFrameDualFillNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3)
			public readonly PresentFrameDualFillDelegate PresentFrameDualFill;
			// void glPresentFrameKeyedNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1)
			public readonly PresentFrameKeyedDelegate PresentFrameKeyed;
			#endregion // commands
			public NvPresentVideo (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetVideoi64vNV", out GetVideoi64v);
				resolver.LoadHandle ("glGetVideoivNV", out GetVideoiv);
				resolver.LoadHandle ("glGetVideoui64vNV", out GetVideoui64v);
				resolver.LoadHandle ("glGetVideouivNV", out GetVideouiv);
				resolver.LoadHandle ("glPresentFrameDualFillNV", out PresentFrameDualFill);
				resolver.LoadHandle ("glPresentFrameKeyedNV", out PresentFrameKeyed);
			}
		}
		public partial class NvPrimitiveRestart
		{
			public enum All
			{
				// GL_PRIMITIVE_RESTART_NV = 0x8558
				PrimitiveRestart = unchecked((int)34136),
				// GL_PRIMITIVE_RESTART_INDEX_NV = 0x8559
				PrimitiveRestartIndex = unchecked((int)34137),
			}
			public const string NAME_STRING = "GL_NV_primitive_restart";
			#region command delegates
			// void glPrimitiveRestartNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PrimitiveRestartDelegate ();
			// void glPrimitiveRestartIndexNV (GLuint index)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PrimitiveRestartIndexDelegate (System.UInt32 index);
			#endregion // command delegates
			#region commands
			// void glPrimitiveRestartNV ()
			public readonly PrimitiveRestartDelegate PrimitiveRestart;
			// void glPrimitiveRestartIndexNV (GLuint index)
			public readonly PrimitiveRestartIndexDelegate PrimitiveRestartIndex;
			#endregion // commands
			public NvPrimitiveRestart (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPrimitiveRestartNV", out PrimitiveRestart);
				resolver.LoadHandle ("glPrimitiveRestartIndexNV", out PrimitiveRestartIndex);
			}
		}
		public partial class NvRegisterCombiners
		{
			public enum All
			{
				// GL_REGISTER_COMBINERS_NV = 0x8522
				RegisterCombiners = unchecked((int)34082),
				// GL_VARIABLE_A_NV = 0x8523
				VariableA = unchecked((int)34083),
				// GL_VARIABLE_B_NV = 0x8524
				VariableB = unchecked((int)34084),
				// GL_VARIABLE_C_NV = 0x8525
				VariableC = unchecked((int)34085),
				// GL_VARIABLE_D_NV = 0x8526
				VariableD = unchecked((int)34086),
				// GL_VARIABLE_E_NV = 0x8527
				VariableE = unchecked((int)34087),
				// GL_VARIABLE_F_NV = 0x8528
				VariableF = unchecked((int)34088),
				// GL_VARIABLE_G_NV = 0x8529
				VariableG = unchecked((int)34089),
				// GL_CONSTANT_COLOR0_NV = 0x852A
				ConstantColor0 = unchecked((int)34090),
				// GL_CONSTANT_COLOR1_NV = 0x852B
				ConstantColor1 = unchecked((int)34091),
				// GL_PRIMARY_COLOR_NV = 0x852C
				PrimaryColor = unchecked((int)34092),
				// GL_SECONDARY_COLOR_NV = 0x852D
				SecondaryColor = unchecked((int)34093),
				// GL_SPARE0_NV = 0x852E
				Spare0 = unchecked((int)34094),
				// GL_SPARE1_NV = 0x852F
				Spare1 = unchecked((int)34095),
				// GL_DISCARD_NV = 0x8530
				Discard = unchecked((int)34096),
				// GL_E_TIMES_F_NV = 0x8531
				ETimesF = unchecked((int)34097),
				// GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532
				Spare0PlusSecondaryColor = unchecked((int)34098),
				// GL_UNSIGNED_IDENTITY_NV = 0x8536
				UnsignedIdentity = unchecked((int)34102),
				// GL_UNSIGNED_INVERT_NV = 0x8537
				UnsignedInvert = unchecked((int)34103),
				// GL_EXPAND_NORMAL_NV = 0x8538
				ExpandNormal = unchecked((int)34104),
				// GL_EXPAND_NEGATE_NV = 0x8539
				ExpandNegate = unchecked((int)34105),
				// GL_HALF_BIAS_NORMAL_NV = 0x853A
				HalfBiasNormal = unchecked((int)34106),
				// GL_HALF_BIAS_NEGATE_NV = 0x853B
				HalfBiasNegate = unchecked((int)34107),
				// GL_SIGNED_IDENTITY_NV = 0x853C
				SignedIdentity = unchecked((int)34108),
				// GL_SIGNED_NEGATE_NV = 0x853D
				SignedNegate = unchecked((int)34109),
				// GL_SCALE_BY_TWO_NV = 0x853E
				ScaleByTwo = unchecked((int)34110),
				// GL_SCALE_BY_FOUR_NV = 0x853F
				ScaleByFour = unchecked((int)34111),
				// GL_SCALE_BY_ONE_HALF_NV = 0x8540
				ScaleByOneHalf = unchecked((int)34112),
				// GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541
				BiasByNegativeOneHalf = unchecked((int)34113),
				// GL_COMBINER_INPUT_NV = 0x8542
				CombinerInput = unchecked((int)34114),
				// GL_COMBINER_MAPPING_NV = 0x8543
				CombinerMapping = unchecked((int)34115),
				// GL_COMBINER_COMPONENT_USAGE_NV = 0x8544
				CombinerComponentUsage = unchecked((int)34116),
				// GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545
				CombinerAbDotProduct = unchecked((int)34117),
				// GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546
				CombinerCdDotProduct = unchecked((int)34118),
				// GL_COMBINER_MUX_SUM_NV = 0x8547
				CombinerMuxSum = unchecked((int)34119),
				// GL_COMBINER_SCALE_NV = 0x8548
				CombinerScale = unchecked((int)34120),
				// GL_COMBINER_BIAS_NV = 0x8549
				CombinerBias = unchecked((int)34121),
				// GL_COMBINER_AB_OUTPUT_NV = 0x854A
				CombinerAbOutput = unchecked((int)34122),
				// GL_COMBINER_CD_OUTPUT_NV = 0x854B
				CombinerCdOutput = unchecked((int)34123),
				// GL_COMBINER_SUM_OUTPUT_NV = 0x854C
				CombinerSumOutput = unchecked((int)34124),
				// GL_MAX_GENERAL_COMBINERS_NV = 0x854D
				MaxGeneralCombiners = unchecked((int)34125),
				// GL_NUM_GENERAL_COMBINERS_NV = 0x854E
				NumGeneralCombiners = unchecked((int)34126),
				// GL_COLOR_SUM_CLAMP_NV = 0x854F
				ColorSumClamp = unchecked((int)34127),
				// GL_COMBINER0_NV = 0x8550
				Combiner0 = unchecked((int)34128),
				// GL_COMBINER1_NV = 0x8551
				Combiner1 = unchecked((int)34129),
				// GL_COMBINER2_NV = 0x8552
				Combiner2 = unchecked((int)34130),
				// GL_COMBINER3_NV = 0x8553
				Combiner3 = unchecked((int)34131),
				// GL_COMBINER4_NV = 0x8554
				Combiner4 = unchecked((int)34132),
				// GL_COMBINER5_NV = 0x8555
				Combiner5 = unchecked((int)34133),
				// GL_COMBINER6_NV = 0x8556
				Combiner6 = unchecked((int)34134),
				// GL_COMBINER7_NV = 0x8557
				Combiner7 = unchecked((int)34135),
			}
			public const string NAME_STRING = "GL_NV_register_combiners";
			#region command delegates
			// void glCombinerInputNV (GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerInputDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 variable, System.UInt32 input, System.UInt32 mapping, System.UInt32 componentUsage);
			// void glCombinerOutputNV (GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerOutputDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 abOutput, System.UInt32 cdOutput, System.UInt32 sumOutput, System.UInt32 scale, System.UInt32 bias, Boolean abDotProduct, Boolean cdDotProduct, Boolean muxSum);
			// void glCombinerParameterfNV (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerParameterfDelegate (System.UInt32 pname, System.Single param);
			// void glCombinerParameterfvNV (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			// void glCombinerParameteriNV (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerParameteriDelegate (System.UInt32 pname, System.Int32 param);
			// void glCombinerParameterivNV (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerParameterivDelegate (System.UInt32 pname, IntPtr @params);
			// void glFinalCombinerInputNV (GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FinalCombinerInputDelegate (System.UInt32 variable, System.UInt32 input, System.UInt32 mapping, System.UInt32 componentUsage);
			// void glGetCombinerInputParameterfvNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCombinerInputParameterfvDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 variable, System.UInt32 pname, IntPtr @params);
			// void glGetCombinerInputParameterivNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCombinerInputParameterivDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 variable, System.UInt32 pname, IntPtr @params);
			// void glGetCombinerOutputParameterfvNV (GLenum stage, GLenum portion, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCombinerOutputParameterfvDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 pname, IntPtr @params);
			// void glGetCombinerOutputParameterivNV (GLenum stage, GLenum portion, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCombinerOutputParameterivDelegate (System.UInt32 stage, System.UInt32 portion, System.UInt32 pname, IntPtr @params);
			// void glGetFinalCombinerInputParameterfvNV (GLenum variable, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFinalCombinerInputParameterfvDelegate (System.UInt32 variable, System.UInt32 pname, IntPtr @params);
			// void glGetFinalCombinerInputParameterivNV (GLenum variable, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFinalCombinerInputParameterivDelegate (System.UInt32 variable, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glCombinerInputNV (GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
			public readonly CombinerInputDelegate CombinerInput;
			// void glCombinerOutputNV (GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum)
			public readonly CombinerOutputDelegate CombinerOutput;
			// void glCombinerParameterfNV (GLenum pname, GLfloat param)
			public readonly CombinerParameterfDelegate CombinerParameterf;
			// void glCombinerParameterfvNV (GLenum pname, GLfloat* params)
			public readonly CombinerParameterfvDelegate CombinerParameterfv;
			// void glCombinerParameteriNV (GLenum pname, GLint param)
			public readonly CombinerParameteriDelegate CombinerParameteri;
			// void glCombinerParameterivNV (GLenum pname, GLint* params)
			public readonly CombinerParameterivDelegate CombinerParameteriv;
			// void glFinalCombinerInputNV (GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
			public readonly FinalCombinerInputDelegate FinalCombinerInput;
			// void glGetCombinerInputParameterfvNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat* params)
			public readonly GetCombinerInputParameterfvDelegate GetCombinerInputParameterfv;
			// void glGetCombinerInputParameterivNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint* params)
			public readonly GetCombinerInputParameterivDelegate GetCombinerInputParameteriv;
			// void glGetCombinerOutputParameterfvNV (GLenum stage, GLenum portion, GLenum pname, GLfloat* params)
			public readonly GetCombinerOutputParameterfvDelegate GetCombinerOutputParameterfv;
			// void glGetCombinerOutputParameterivNV (GLenum stage, GLenum portion, GLenum pname, GLint* params)
			public readonly GetCombinerOutputParameterivDelegate GetCombinerOutputParameteriv;
			// void glGetFinalCombinerInputParameterfvNV (GLenum variable, GLenum pname, GLfloat* params)
			public readonly GetFinalCombinerInputParameterfvDelegate GetFinalCombinerInputParameterfv;
			// void glGetFinalCombinerInputParameterivNV (GLenum variable, GLenum pname, GLint* params)
			public readonly GetFinalCombinerInputParameterivDelegate GetFinalCombinerInputParameteriv;
			#endregion // commands
			public NvRegisterCombiners (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCombinerInputNV", out CombinerInput);
				resolver.LoadHandle ("glCombinerOutputNV", out CombinerOutput);
				resolver.LoadHandle ("glCombinerParameterfNV", out CombinerParameterf);
				resolver.LoadHandle ("glCombinerParameterfvNV", out CombinerParameterfv);
				resolver.LoadHandle ("glCombinerParameteriNV", out CombinerParameteri);
				resolver.LoadHandle ("glCombinerParameterivNV", out CombinerParameteriv);
				resolver.LoadHandle ("glFinalCombinerInputNV", out FinalCombinerInput);
				resolver.LoadHandle ("glGetCombinerInputParameterfvNV", out GetCombinerInputParameterfv);
				resolver.LoadHandle ("glGetCombinerInputParameterivNV", out GetCombinerInputParameteriv);
				resolver.LoadHandle ("glGetCombinerOutputParameterfvNV", out GetCombinerOutputParameterfv);
				resolver.LoadHandle ("glGetCombinerOutputParameterivNV", out GetCombinerOutputParameteriv);
				resolver.LoadHandle ("glGetFinalCombinerInputParameterfvNV", out GetFinalCombinerInputParameterfv);
				resolver.LoadHandle ("glGetFinalCombinerInputParameterivNV", out GetFinalCombinerInputParameteriv);
			}
		}
		public partial class NvRegisterCombiners2
		{
			public enum All
			{
				// GL_PER_STAGE_CONSTANTS_NV = 0x8535
				PerStageConstants = unchecked((int)34101),
			}
			public const string NAME_STRING = "GL_NV_register_combiners2";
			#region command delegates
			// void glCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void CombinerStageParameterfvDelegate (System.UInt32 stage, System.UInt32 pname, IntPtr @params);
			// void glGetCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetCombinerStageParameterfvDelegate (System.UInt32 stage, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat* params)
			public readonly CombinerStageParameterfvDelegate CombinerStageParameterfv;
			// void glGetCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat* params)
			public readonly GetCombinerStageParameterfvDelegate GetCombinerStageParameterfv;
			#endregion // commands
			public NvRegisterCombiners2 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glCombinerStageParameterfvNV", out CombinerStageParameterfv);
				resolver.LoadHandle ("glGetCombinerStageParameterfvNV", out GetCombinerStageParameterfv);
			}
		}
		public partial class NvRobustnessVideoMemoryPurge
		{
			public enum All
			{
				// GL_PURGED_CONTEXT_RESET_NV = 0x92BB
				PurgedContextReset = unchecked((int)37563),
			}
			public const string NAME_STRING = "GL_NV_robustness_video_memory_purge";
		}
		public partial class NvSampleLocations
		{
			public enum All
			{
				// GL_SAMPLE_LOCATION_NV = 0x8E50
				SampleLocation = unchecked((int)36432),
				// GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D
				SampleLocationSubpixelBits = unchecked((int)37693),
				// GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E
				SampleLocationPixelGridWidth = unchecked((int)37694),
				// GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F
				SampleLocationPixelGridHeight = unchecked((int)37695),
				// GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340
				ProgrammableSampleLocationTableSize = unchecked((int)37696),
				// GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341
				ProgrammableSampleLocation = unchecked((int)37697),
				// GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342
				FramebufferProgrammableSampleLocations = unchecked((int)37698),
				// GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343
				FramebufferSampleLocationPixelGrid = unchecked((int)37699),
			}
			public const string NAME_STRING = "GL_NV_sample_locations";
			#region command delegates
			// void glFramebufferSampleLocationsfvNV (GLenum target, GLuint start, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferSampleLocationsfvDelegate (System.UInt32 target, System.UInt32 start, System.Int32 count, IntPtr v);
			// void glNamedFramebufferSampleLocationsfvNV (GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NamedFramebufferSampleLocationsfvDelegate (System.UInt32 framebuffer, System.UInt32 start, System.Int32 count, IntPtr v);
			// void glResolveDepthValuesNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ResolveDepthValuesDelegate ();
			#endregion // command delegates
			#region commands
			// void glFramebufferSampleLocationsfvNV (GLenum target, GLuint start, GLsizei count, GLfloat* v)
			public readonly FramebufferSampleLocationsfvDelegate FramebufferSampleLocationsfv;
			// void glNamedFramebufferSampleLocationsfvNV (GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v)
			public readonly NamedFramebufferSampleLocationsfvDelegate NamedFramebufferSampleLocationsfv;
			// void glResolveDepthValuesNV ()
			public readonly ResolveDepthValuesDelegate ResolveDepthValues;
			#endregion // commands
			public NvSampleLocations (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFramebufferSampleLocationsfvNV", out FramebufferSampleLocationsfv);
				resolver.LoadHandle ("glNamedFramebufferSampleLocationsfvNV", out NamedFramebufferSampleLocationsfv);
				resolver.LoadHandle ("glResolveDepthValuesNV", out ResolveDepthValues);
			}
		}
		public partial class NvShaderBufferLoad
		{
			public enum All
			{
				// GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D
				BufferGpuAddress = unchecked((int)36637),
				// GL_GPU_ADDRESS_NV = 0x8F34
				GpuAddress = unchecked((int)36660),
				// GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35
				MaxShaderBufferAddress = unchecked((int)36661),
			}
			public const string NAME_STRING = "GL_NV_shader_buffer_load";
			#region command delegates
			// void glGetBufferParameterui64vNV (GLenum target, GLenum pname, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetBufferParameterui64vDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetIntegerui64vNV (GLenum value, GLuint64EXT* result)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetIntegerui64vDelegate (System.UInt32 value, IntPtr result);
			// void glGetNamedBufferParameterui64vNV (GLuint buffer, GLenum pname, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetNamedBufferParameterui64vDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsBufferResidentNV (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsBufferResidentDelegate (System.UInt32 target);
			// GLboolean glIsNamedBufferResidentNV (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsNamedBufferResidentDelegate (System.UInt32 buffer);
			// void glMakeBufferNonResidentNV (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeBufferNonResidentDelegate (System.UInt32 target);
			// void glMakeBufferResidentNV (GLenum target, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeBufferResidentDelegate (System.UInt32 target, System.UInt32 access);
			// void glMakeNamedBufferNonResidentNV (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeNamedBufferNonResidentDelegate (System.UInt32 buffer);
			// void glMakeNamedBufferResidentNV (GLuint buffer, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MakeNamedBufferResidentDelegate (System.UInt32 buffer, System.UInt32 access);
			// void glProgramUniformui64NV (GLuint program, GLint location, GLuint64EXT value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformui64Delegate (System.UInt32 program, System.Int32 location, System.UInt64 value);
			// void glProgramUniformui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramUniformui64vDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
			// void glUniformui64NV (GLint location, GLuint64EXT value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniformui64Delegate (System.Int32 location, System.UInt64 value);
			// void glUniformui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Uniformui64vDelegate (System.Int32 location, System.Int32 count, IntPtr value);
			#endregion // command delegates
			#region commands
			// void glGetBufferParameterui64vNV (GLenum target, GLenum pname, GLuint64EXT* params)
			public readonly GetBufferParameterui64vDelegate GetBufferParameterui64v;
			// void glGetIntegerui64vNV (GLenum value, GLuint64EXT* result)
			public readonly GetIntegerui64vDelegate GetIntegerui64v;
			// void glGetNamedBufferParameterui64vNV (GLuint buffer, GLenum pname, GLuint64EXT* params)
			public readonly GetNamedBufferParameterui64vDelegate GetNamedBufferParameterui64v;
			// GLboolean glIsBufferResidentNV (GLenum target)
			public readonly IsBufferResidentDelegate IsBufferResident;
			// GLboolean glIsNamedBufferResidentNV (GLuint buffer)
			public readonly IsNamedBufferResidentDelegate IsNamedBufferResident;
			// void glMakeBufferNonResidentNV (GLenum target)
			public readonly MakeBufferNonResidentDelegate MakeBufferNonResident;
			// void glMakeBufferResidentNV (GLenum target, GLenum access)
			public readonly MakeBufferResidentDelegate MakeBufferResident;
			// void glMakeNamedBufferNonResidentNV (GLuint buffer)
			public readonly MakeNamedBufferNonResidentDelegate MakeNamedBufferNonResident;
			// void glMakeNamedBufferResidentNV (GLuint buffer, GLenum access)
			public readonly MakeNamedBufferResidentDelegate MakeNamedBufferResident;
			// void glProgramUniformui64NV (GLuint program, GLint location, GLuint64EXT value)
			public readonly ProgramUniformui64Delegate ProgramUniformui64;
			// void glProgramUniformui64vNV (GLuint program, GLint location, GLsizei count, GLuint64EXT* value)
			public readonly ProgramUniformui64vDelegate ProgramUniformui64v;
			// void glUniformui64NV (GLint location, GLuint64EXT value)
			public readonly Uniformui64Delegate Uniformui64;
			// void glUniformui64vNV (GLint location, GLsizei count, GLuint64EXT* value)
			public readonly Uniformui64vDelegate Uniformui64v;
			#endregion // commands
			public NvShaderBufferLoad (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetBufferParameterui64vNV", out GetBufferParameterui64v);
				resolver.LoadHandle ("glGetIntegerui64vNV", out GetIntegerui64v);
				resolver.LoadHandle ("glGetNamedBufferParameterui64vNV", out GetNamedBufferParameterui64v);
				resolver.LoadHandle ("glIsBufferResidentNV", out IsBufferResident);
				resolver.LoadHandle ("glIsNamedBufferResidentNV", out IsNamedBufferResident);
				resolver.LoadHandle ("glMakeBufferNonResidentNV", out MakeBufferNonResident);
				resolver.LoadHandle ("glMakeBufferResidentNV", out MakeBufferResident);
				resolver.LoadHandle ("glMakeNamedBufferNonResidentNV", out MakeNamedBufferNonResident);
				resolver.LoadHandle ("glMakeNamedBufferResidentNV", out MakeNamedBufferResident);
				resolver.LoadHandle ("glProgramUniformui64NV", out ProgramUniformui64);
				resolver.LoadHandle ("glProgramUniformui64vNV", out ProgramUniformui64v);
				resolver.LoadHandle ("glUniformui64NV", out Uniformui64);
				resolver.LoadHandle ("glUniformui64vNV", out Uniformui64v);
			}
		}
		public partial class NvShaderBufferStore
		{
			public enum All
			{
				// GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x10
				ShaderGlobalAccessBarrierBit = unchecked((int)16),
			}
			public const string NAME_STRING = "GL_NV_shader_buffer_store";
		}
		public partial class NvShaderThreadGroup
		{
			public enum All
			{
				// GL_WARP_SIZE_NV = 0x9339
				WarpSize = unchecked((int)37689),
				// GL_WARPS_PER_SM_NV = 0x933A
				WarpsPerSm = unchecked((int)37690),
				// GL_SM_COUNT_NV = 0x933B
				SmCount = unchecked((int)37691),
			}
			public const string NAME_STRING = "GL_NV_shader_thread_group";
		}
		public partial class NvTessellationProgram5
		{
			public enum All
			{
				// GL_MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8
				MaxProgramPatchAttribs = unchecked((int)34520),
				// GL_TESS_CONTROL_PROGRAM_NV = 0x891E
				TessControlProgram = unchecked((int)35102),
				// GL_TESS_EVALUATION_PROGRAM_NV = 0x891F
				TessEvaluationProgram = unchecked((int)35103),
				// GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74
				TessControlProgramParameterBuffer = unchecked((int)35956),
				// GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75
				TessEvaluationProgramParameterBuffer = unchecked((int)35957),
			}
			public const string NAME_STRING = "GL_NV_tessellation_program5";
		}
		public partial class NvTexgenEmboss
		{
			public enum All
			{
				// GL_EMBOSS_LIGHT_NV = 0x855D
				EmbossLight = unchecked((int)34141),
				// GL_EMBOSS_CONSTANT_NV = 0x855E
				EmbossConstant = unchecked((int)34142),
				// GL_EMBOSS_MAP_NV = 0x855F
				EmbossMap = unchecked((int)34143),
			}
			public const string NAME_STRING = "GL_NV_texgen_emboss";
		}
		public partial class NvTexgenReflection
		{
			public enum All
			{
				// GL_NORMAL_MAP_NV = 0x8511
				NormalMap = unchecked((int)34065),
				// GL_REFLECTION_MAP_NV = 0x8512
				ReflectionMap = unchecked((int)34066),
			}
			public const string NAME_STRING = "GL_NV_texgen_reflection";
		}
		public partial class NvTextureBarrier
		{
			public const string NAME_STRING = "GL_NV_texture_barrier";
			#region command delegates
			// void glTextureBarrierNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureBarrierDelegate ();
			#endregion // command delegates
			#region commands
			// void glTextureBarrierNV ()
			public readonly TextureBarrierDelegate TextureBarrier;
			#endregion // commands
			public NvTextureBarrier (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTextureBarrierNV", out TextureBarrier);
			}
		}
		public partial class NvTextureEnvCombine4
		{
			public enum All
			{
				// GL_COMBINE4_NV = 0x8503
				Combine4 = unchecked((int)34051),
				// GL_SOURCE3_RGB_NV = 0x8583
				Source3Rgb = unchecked((int)34179),
				// GL_SOURCE3_ALPHA_NV = 0x858B
				Source3Alpha = unchecked((int)34187),
				// GL_OPERAND3_RGB_NV = 0x8593
				Operand3Rgb = unchecked((int)34195),
				// GL_OPERAND3_ALPHA_NV = 0x859B
				Operand3Alpha = unchecked((int)34203),
			}
			public const string NAME_STRING = "GL_NV_texture_env_combine4";
		}
		public partial class NvTextureExpandNormal
		{
			public enum All
			{
				// GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F
				TextureUnsignedRemapMode = unchecked((int)34959),
			}
			public const string NAME_STRING = "GL_NV_texture_expand_normal";
		}
		public partial class NvTextureMultisample
		{
			public enum All
			{
				// GL_TEXTURE_COVERAGE_SAMPLES_NV = 0x9045
				TextureCoverageSamples = unchecked((int)36933),
				// GL_TEXTURE_COLOR_SAMPLES_NV = 0x9046
				TextureColorSamples = unchecked((int)36934),
			}
			public const string NAME_STRING = "GL_NV_texture_multisample";
			#region command delegates
			// void glTexImage2DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexImage2DMultisampleCoverageDelegate (System.UInt32 target, System.Int32 coverageSamples, System.Int32 colorSamples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, Boolean fixedSampleLocations);
			// void glTexImage3DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexImage3DMultisampleCoverageDelegate (System.UInt32 target, System.Int32 coverageSamples, System.Int32 colorSamples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedSampleLocations);
			// void glTextureImage2DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage2DMultisampleCoverageDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 coverageSamples, System.Int32 colorSamples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, Boolean fixedSampleLocations);
			// void glTextureImage2DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage2DMultisampleDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 samples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, Boolean fixedSampleLocations);
			// void glTextureImage3DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage3DMultisampleCoverageDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 coverageSamples, System.Int32 colorSamples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedSampleLocations);
			// void glTextureImage3DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureImage3DMultisampleDelegate (System.UInt32 texture, System.UInt32 target, System.Int32 samples, System.Int32 internalFormat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedSampleLocations);
			#endregion // command delegates
			#region commands
			// void glTexImage2DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			public readonly TexImage2DMultisampleCoverageDelegate TexImage2DMultisampleCoverage;
			// void glTexImage3DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			public readonly TexImage3DMultisampleCoverageDelegate TexImage3DMultisampleCoverage;
			// void glTextureImage2DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			public readonly TextureImage2DMultisampleCoverageDelegate TextureImage2DMultisampleCoverage;
			// void glTextureImage2DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
			public readonly TextureImage2DMultisampleDelegate TextureImage2DMultisample;
			// void glTextureImage3DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			public readonly TextureImage3DMultisampleCoverageDelegate TextureImage3DMultisampleCoverage;
			// void glTextureImage3DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
			public readonly TextureImage3DMultisampleDelegate TextureImage3DMultisample;
			#endregion // commands
			public NvTextureMultisample (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTexImage2DMultisampleCoverageNV", out TexImage2DMultisampleCoverage);
				resolver.LoadHandle ("glTexImage3DMultisampleCoverageNV", out TexImage3DMultisampleCoverage);
				resolver.LoadHandle ("glTextureImage2DMultisampleCoverageNV", out TextureImage2DMultisampleCoverage);
				resolver.LoadHandle ("glTextureImage2DMultisampleNV", out TextureImage2DMultisample);
				resolver.LoadHandle ("glTextureImage3DMultisampleCoverageNV", out TextureImage3DMultisampleCoverage);
				resolver.LoadHandle ("glTextureImage3DMultisampleNV", out TextureImage3DMultisample);
			}
		}
		public partial class NvTextureRectangle
		{
			public enum All
			{
				// GL_TEXTURE_RECTANGLE_NV = 0x84F5
				TextureRectangle = unchecked((int)34037),
				// GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6
				TextureBindingRectangle = unchecked((int)34038),
				// GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
				ProxyTextureRectangle = unchecked((int)34039),
				// GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8
				MaxRectangleTextureSize = unchecked((int)34040),
			}
			public const string NAME_STRING = "GL_NV_texture_rectangle";
		}
		public partial class NvTextureShader
		{
			public enum All
			{
				// GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C
				OffsetTextureRectangle = unchecked((int)34380),
				// GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D
				OffsetTextureRectangleScale = unchecked((int)34381),
				// GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E
				DotProductTextureRectangle = unchecked((int)34382),
				// GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9
				RgbaUnsignedDotProductMapping = unchecked((int)34521),
				// GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA
				UnsignedIntS8S888 = unchecked((int)34522),
				// GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB
				UnsignedInt88S8S8Rev = unchecked((int)34523),
				// GL_DSDT_MAG_INTENSITY_NV = 0x86DC
				DsdtMagIntensity = unchecked((int)34524),
				// GL_SHADER_CONSISTENT_NV = 0x86DD
				ShaderConsistent = unchecked((int)34525),
				// GL_TEXTURE_SHADER_NV = 0x86DE
				TextureShader = unchecked((int)34526),
				// GL_SHADER_OPERATION_NV = 0x86DF
				ShaderOperation = unchecked((int)34527),
				// GL_CULL_MODES_NV = 0x86E0
				CullModes = unchecked((int)34528),
				// GL_OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1
				OffsetTexture2dMatrix = unchecked((int)34529),
				// GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1
				OffsetTextureMatrix = unchecked((int)34529),
				// GL_OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2
				OffsetTexture2dScale = unchecked((int)34530),
				// GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2
				OffsetTextureScale = unchecked((int)34530),
				// GL_OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3
				OffsetTexture2dBias = unchecked((int)34531),
				// GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3
				OffsetTextureBias = unchecked((int)34531),
				// GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4
				PreviousTextureInput = unchecked((int)34532),
				// GL_CONST_EYE_NV = 0x86E5
				ConstEye = unchecked((int)34533),
				// GL_PASS_THROUGH_NV = 0x86E6
				PassThrough = unchecked((int)34534),
				// GL_CULL_FRAGMENT_NV = 0x86E7
				CullFragment = unchecked((int)34535),
				// GL_OFFSET_TEXTURE_2D_NV = 0x86E8
				OffsetTexture2d = unchecked((int)34536),
				// GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9
				DependentArTexture2d = unchecked((int)34537),
				// GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA
				DependentGbTexture2d = unchecked((int)34538),
				// GL_DOT_PRODUCT_NV = 0x86EC
				DotProduct = unchecked((int)34540),
				// GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED
				DotProductDepthReplace = unchecked((int)34541),
				// GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE
				DotProductTexture2d = unchecked((int)34542),
				// GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0
				DotProductTextureCubeMap = unchecked((int)34544),
				// GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1
				DotProductDiffuseCubeMap = unchecked((int)34545),
				// GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2
				DotProductReflectCubeMap = unchecked((int)34546),
				// GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3
				DotProductConstEyeReflectCubeMap = unchecked((int)34547),
				// GL_HILO_NV = 0x86F4
				Hilo = unchecked((int)34548),
				// GL_DSDT_NV = 0x86F5
				Dsdt = unchecked((int)34549),
				// GL_DSDT_MAG_NV = 0x86F6
				DsdtMag = unchecked((int)34550),
				// GL_DSDT_MAG_VIB_NV = 0x86F7
				DsdtMagVib = unchecked((int)34551),
				// GL_HILO16_NV = 0x86F8
				Hilo16 = unchecked((int)34552),
				// GL_SIGNED_HILO_NV = 0x86F9
				SignedHilo = unchecked((int)34553),
				// GL_SIGNED_HILO16_NV = 0x86FA
				SignedHilo16 = unchecked((int)34554),
				// GL_SIGNED_RGBA_NV = 0x86FB
				SignedRgba = unchecked((int)34555),
				// GL_SIGNED_RGBA8_NV = 0x86FC
				SignedRgba8 = unchecked((int)34556),
				// GL_SIGNED_RGB_NV = 0x86FE
				SignedRgb = unchecked((int)34558),
				// GL_SIGNED_RGB8_NV = 0x86FF
				SignedRgb8 = unchecked((int)34559),
				// GL_SIGNED_LUMINANCE_NV = 0x8701
				SignedLuminance = unchecked((int)34561),
				// GL_SIGNED_LUMINANCE8_NV = 0x8702
				SignedLuminance8 = unchecked((int)34562),
				// GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703
				SignedLuminanceAlpha = unchecked((int)34563),
				// GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704
				SignedLuminance8Alpha8 = unchecked((int)34564),
				// GL_SIGNED_ALPHA_NV = 0x8705
				SignedAlpha = unchecked((int)34565),
				// GL_SIGNED_ALPHA8_NV = 0x8706
				SignedAlpha8 = unchecked((int)34566),
				// GL_SIGNED_INTENSITY_NV = 0x8707
				SignedIntensity = unchecked((int)34567),
				// GL_SIGNED_INTENSITY8_NV = 0x8708
				SignedIntensity8 = unchecked((int)34568),
				// GL_DSDT8_NV = 0x8709
				Dsdt8 = unchecked((int)34569),
				// GL_DSDT8_MAG8_NV = 0x870A
				Dsdt8Mag8 = unchecked((int)34570),
				// GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B
				Dsdt8Mag8Intensity8 = unchecked((int)34571),
				// GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C
				SignedRgbUnsignedAlpha = unchecked((int)34572),
				// GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D
				SignedRgb8UnsignedAlpha8 = unchecked((int)34573),
				// GL_HI_SCALE_NV = 0x870E
				HiScale = unchecked((int)34574),
				// GL_LO_SCALE_NV = 0x870F
				LoScale = unchecked((int)34575),
				// GL_DS_SCALE_NV = 0x8710
				DsScale = unchecked((int)34576),
				// GL_DT_SCALE_NV = 0x8711
				DtScale = unchecked((int)34577),
				// GL_MAGNITUDE_SCALE_NV = 0x8712
				MagnitudeScale = unchecked((int)34578),
				// GL_VIBRANCE_SCALE_NV = 0x8713
				VibranceScale = unchecked((int)34579),
				// GL_HI_BIAS_NV = 0x8714
				HiBias = unchecked((int)34580),
				// GL_LO_BIAS_NV = 0x8715
				LoBias = unchecked((int)34581),
				// GL_DS_BIAS_NV = 0x8716
				DsBias = unchecked((int)34582),
				// GL_DT_BIAS_NV = 0x8717
				DtBias = unchecked((int)34583),
				// GL_MAGNITUDE_BIAS_NV = 0x8718
				MagnitudeBias = unchecked((int)34584),
				// GL_VIBRANCE_BIAS_NV = 0x8719
				VibranceBias = unchecked((int)34585),
				// GL_TEXTURE_BORDER_VALUES_NV = 0x871A
				TextureBorderValues = unchecked((int)34586),
				// GL_TEXTURE_HI_SIZE_NV = 0x871B
				TextureHiSize = unchecked((int)34587),
				// GL_TEXTURE_LO_SIZE_NV = 0x871C
				TextureLoSize = unchecked((int)34588),
				// GL_TEXTURE_DS_SIZE_NV = 0x871D
				TextureDsSize = unchecked((int)34589),
				// GL_TEXTURE_DT_SIZE_NV = 0x871E
				TextureDtSize = unchecked((int)34590),
				// GL_TEXTURE_MAG_SIZE_NV = 0x871F
				TextureMagSize = unchecked((int)34591),
			}
			public const string NAME_STRING = "GL_NV_texture_shader";
		}
		public partial class NvTextureShader2
		{
			public enum All
			{
				// GL_DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF
				DotProductTexture3d = unchecked((int)34543),
			}
			public const string NAME_STRING = "GL_NV_texture_shader2";
		}
		public partial class NvTextureShader3
		{
			public enum All
			{
				// GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850
				OffsetProjectiveTexture2d = unchecked((int)34896),
				// GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851
				OffsetProjectiveTexture2dScale = unchecked((int)34897),
				// GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852
				OffsetProjectiveTextureRectangle = unchecked((int)34898),
				// GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853
				OffsetProjectiveTextureRectangleScale = unchecked((int)34899),
				// GL_OFFSET_HILO_TEXTURE_2D_NV = 0x8854
				OffsetHiloTexture2d = unchecked((int)34900),
				// GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855
				OffsetHiloTextureRectangle = unchecked((int)34901),
				// GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856
				OffsetHiloProjectiveTexture2d = unchecked((int)34902),
				// GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857
				OffsetHiloProjectiveTextureRectangle = unchecked((int)34903),
				// GL_DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858
				DependentHiloTexture2d = unchecked((int)34904),
				// GL_DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859
				DependentRgbTexture3d = unchecked((int)34905),
				// GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A
				DependentRgbTextureCubeMap = unchecked((int)34906),
				// GL_DOT_PRODUCT_PASS_THROUGH_NV = 0x885B
				DotProductPassThrough = unchecked((int)34907),
				// GL_DOT_PRODUCT_TEXTURE_1D_NV = 0x885C
				DotProductTexture1d = unchecked((int)34908),
				// GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D
				DotProductAffineDepthReplace = unchecked((int)34909),
				// GL_HILO8_NV = 0x885E
				Hilo8 = unchecked((int)34910),
				// GL_SIGNED_HILO8_NV = 0x885F
				SignedHilo8 = unchecked((int)34911),
				// GL_FORCE_BLUE_TO_ONE_NV = 0x8860
				ForceBlueToOne = unchecked((int)34912),
			}
			public const string NAME_STRING = "GL_NV_texture_shader3";
		}
		public partial class NvTransformFeedback
		{
			public enum All
			{
				// GL_SKIP_COMPONENTS1_NV = 0xFFFFFFFFFFFFFFFA
				SkipComponents1 = unchecked((int)-6),
				// GL_SKIP_COMPONENTS2_NV = 0xFFFFFFFFFFFFFFFB
				SkipComponents2 = unchecked((int)-5),
				// GL_SKIP_COMPONENTS3_NV = 0xFFFFFFFFFFFFFFFC
				SkipComponents3 = unchecked((int)-4),
				// GL_SKIP_COMPONENTS4_NV = 0xFFFFFFFFFFFFFFFD
				SkipComponents4 = unchecked((int)-3),
				// GL_NEXT_BUFFER_NV = 0xFFFFFFFFFFFFFFFE
				NextBuffer = unchecked((int)-2),
				// GL_BACK_PRIMARY_COLOR_NV = 0x8C77
				BackPrimaryColor = unchecked((int)35959),
				// GL_BACK_SECONDARY_COLOR_NV = 0x8C78
				BackSecondaryColor = unchecked((int)35960),
				// GL_TEXTURE_COORD_NV = 0x8C79
				TextureCoord = unchecked((int)35961),
				// GL_CLIP_DISTANCE_NV = 0x8C7A
				ClipDistance = unchecked((int)35962),
				// GL_VERTEX_ID_NV = 0x8C7B
				VertexId = unchecked((int)35963),
				// GL_PRIMITIVE_ID_NV = 0x8C7C
				PrimitiveId = unchecked((int)35964),
				// GL_GENERIC_ATTRIB_NV = 0x8C7D
				GenericAttrib = unchecked((int)35965),
				// GL_TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E
				TransformFeedbackAttribs = unchecked((int)35966),
				// GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F
				TransformFeedbackBufferMode = unchecked((int)35967),
				// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80
				MaxTransformFeedbackSeparateComponents = unchecked((int)35968),
				// GL_ACTIVE_VARYINGS_NV = 0x8C81
				ActiveVaryings = unchecked((int)35969),
				// GL_ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82
				ActiveVaryingMaxLength = unchecked((int)35970),
				// GL_TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83
				TransformFeedbackVaryings = unchecked((int)35971),
				// GL_TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84
				TransformFeedbackBufferStart = unchecked((int)35972),
				// GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85
				TransformFeedbackBufferSize = unchecked((int)35973),
				// GL_TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86
				TransformFeedbackRecord = unchecked((int)35974),
				// GL_PRIMITIVES_GENERATED_NV = 0x8C87
				PrimitivesGenerated = unchecked((int)35975),
				// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88
				TransformFeedbackPrimitivesWritten = unchecked((int)35976),
				// GL_RASTERIZER_DISCARD_NV = 0x8C89
				RasterizerDiscard = unchecked((int)35977),
				// GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A
				MaxTransformFeedbackInterleavedComponents = unchecked((int)35978),
				// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B
				MaxTransformFeedbackSeparateAttribs = unchecked((int)35979),
				// GL_INTERLEAVED_ATTRIBS_NV = 0x8C8C
				InterleavedAttribs = unchecked((int)35980),
				// GL_SEPARATE_ATTRIBS_NV = 0x8C8D
				SeparateAttribs = unchecked((int)35981),
				// GL_TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E
				TransformFeedbackBuffer = unchecked((int)35982),
				// GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F
				TransformFeedbackBufferBinding = unchecked((int)35983),
				// GL_LAYER_NV = 0x8DAA
				Layer = unchecked((int)36266),
			}
			public const string NAME_STRING = "GL_NV_transform_feedback";
			#region command delegates
			// void glActiveVaryingNV (GLuint program, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ActiveVaryingDelegate (System.UInt32 program, IntPtr name);
			// void glBeginTransformFeedbackNV (GLenum primitiveMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginTransformFeedbackDelegate (System.UInt32 primitiveMode);
			// void glBindBufferBaseNV (GLenum target, GLuint index, GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferBaseDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer);
			// void glBindBufferOffsetNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferOffsetDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset);
			// void glBindBufferRangeNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindBufferRangeDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
			// void glEndTransformFeedbackNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndTransformFeedbackDelegate ();
			// void glGetActiveVaryingNV (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetActiveVaryingDelegate (System.UInt32 program, System.UInt32 index, System.Int32 bufSize, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
			// void glGetTransformFeedbackVaryingNV (GLuint program, GLuint index, GLint* location)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTransformFeedbackVaryingDelegate (System.UInt32 program, System.UInt32 index, IntPtr location);
			// GLint glGetVaryingLocationNV (GLuint program, GLchar* name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetVaryingLocationDelegate (System.UInt32 program, IntPtr name);
			// void glTransformFeedbackAttribsNV (GLsizei count, GLint* attribs, GLenum bufferMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TransformFeedbackAttribsDelegate (System.Int32 count, IntPtr attribs, System.UInt32 bufferMode);
			// void glTransformFeedbackStreamAttribsNV (GLsizei count, GLint* attribs, GLsizei nbuffers, GLint* bufstreams, GLenum bufferMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TransformFeedbackStreamAttribsDelegate (System.Int32 count, IntPtr attribs, System.Int32 nbuffers, IntPtr bufstreams, System.UInt32 bufferMode);
			// void glTransformFeedbackVaryingsNV (GLuint program, GLsizei count, GLint* locations, GLenum bufferMode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TransformFeedbackVaryingsDelegate (System.UInt32 program, System.Int32 count, IntPtr locations, System.UInt32 bufferMode);
			#endregion // command delegates
			#region commands
			// void glActiveVaryingNV (GLuint program, GLchar* name)
			public readonly ActiveVaryingDelegate ActiveVarying;
			// void glBeginTransformFeedbackNV (GLenum primitiveMode)
			public readonly BeginTransformFeedbackDelegate BeginTransformFeedback;
			// void glBindBufferBaseNV (GLenum target, GLuint index, GLuint buffer)
			public readonly BindBufferBaseDelegate BindBufferBase;
			// void glBindBufferOffsetNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset)
			public readonly BindBufferOffsetDelegate BindBufferOffset;
			// void glBindBufferRangeNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
			public readonly BindBufferRangeDelegate BindBufferRange;
			// void glEndTransformFeedbackNV ()
			public readonly EndTransformFeedbackDelegate EndTransformFeedback;
			// void glGetActiveVaryingNV (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
			public readonly GetActiveVaryingDelegate GetActiveVarying;
			// void glGetTransformFeedbackVaryingNV (GLuint program, GLuint index, GLint* location)
			public readonly GetTransformFeedbackVaryingDelegate GetTransformFeedbackVarying;
			// GLint glGetVaryingLocationNV (GLuint program, GLchar* name)
			public readonly GetVaryingLocationDelegate GetVaryingLocation;
			// void glTransformFeedbackAttribsNV (GLsizei count, GLint* attribs, GLenum bufferMode)
			public readonly TransformFeedbackAttribsDelegate TransformFeedbackAttribs;
			// void glTransformFeedbackStreamAttribsNV (GLsizei count, GLint* attribs, GLsizei nbuffers, GLint* bufstreams, GLenum bufferMode)
			public readonly TransformFeedbackStreamAttribsDelegate TransformFeedbackStreamAttribs;
			// void glTransformFeedbackVaryingsNV (GLuint program, GLsizei count, GLint* locations, GLenum bufferMode)
			public readonly TransformFeedbackVaryingsDelegate TransformFeedbackVaryings;
			#endregion // commands
			public NvTransformFeedback (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glActiveVaryingNV", out ActiveVarying);
				resolver.LoadHandle ("glBeginTransformFeedbackNV", out BeginTransformFeedback);
				resolver.LoadHandle ("glBindBufferBaseNV", out BindBufferBase);
				resolver.LoadHandle ("glBindBufferOffsetNV", out BindBufferOffset);
				resolver.LoadHandle ("glBindBufferRangeNV", out BindBufferRange);
				resolver.LoadHandle ("glEndTransformFeedbackNV", out EndTransformFeedback);
				resolver.LoadHandle ("glGetActiveVaryingNV", out GetActiveVarying);
				resolver.LoadHandle ("glGetTransformFeedbackVaryingNV", out GetTransformFeedbackVarying);
				resolver.LoadHandle ("glGetVaryingLocationNV", out GetVaryingLocation);
				resolver.LoadHandle ("glTransformFeedbackAttribsNV", out TransformFeedbackAttribs);
				resolver.LoadHandle ("glTransformFeedbackStreamAttribsNV", out TransformFeedbackStreamAttribs);
				resolver.LoadHandle ("glTransformFeedbackVaryingsNV", out TransformFeedbackVaryings);
			}
		}
		public partial class NvTransformFeedback2
		{
			public enum All
			{
				// GL_TRANSFORM_FEEDBACK_NV = 0x8E22
				TransformFeedback = unchecked((int)36386),
				// GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23
				TransformFeedbackBufferPaused = unchecked((int)36387),
				// GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24
				TransformFeedbackBufferActive = unchecked((int)36388),
				// GL_TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25
				TransformFeedbackBinding = unchecked((int)36389),
			}
			public const string NAME_STRING = "GL_NV_transform_feedback2";
			#region command delegates
			// void glBindTransformFeedbackNV (GLenum target, GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindTransformFeedbackDelegate (System.UInt32 target, System.UInt32 id);
			// void glDeleteTransformFeedbacksNV (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteTransformFeedbacksDelegate (System.Int32 n, IntPtr ids);
			// void glDrawTransformFeedbackNV (GLenum mode, GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawTransformFeedbackDelegate (PrimitiveType mode, System.UInt32 id);
			// void glGenTransformFeedbacksNV (GLsizei n, GLuint* ids)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenTransformFeedbacksDelegate (System.Int32 n, IntPtr ids);
			// GLboolean glIsTransformFeedbackNV (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsTransformFeedbackDelegate (System.UInt32 id);
			// void glPauseTransformFeedbackNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PauseTransformFeedbackDelegate ();
			// void glResumeTransformFeedbackNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ResumeTransformFeedbackDelegate ();
			#endregion // command delegates
			#region commands
			// void glBindTransformFeedbackNV (GLenum target, GLuint id)
			public readonly BindTransformFeedbackDelegate BindTransformFeedback;
			// void glDeleteTransformFeedbacksNV (GLsizei n, GLuint* ids)
			public readonly DeleteTransformFeedbacksDelegate DeleteTransformFeedbacks;
			// void glDrawTransformFeedbackNV (GLenum mode, GLuint id)
			public readonly DrawTransformFeedbackDelegate DrawTransformFeedback;
			// void glGenTransformFeedbacksNV (GLsizei n, GLuint* ids)
			public readonly GenTransformFeedbacksDelegate GenTransformFeedbacks;
			// GLboolean glIsTransformFeedbackNV (GLuint id)
			public readonly IsTransformFeedbackDelegate IsTransformFeedback;
			// void glPauseTransformFeedbackNV ()
			public readonly PauseTransformFeedbackDelegate PauseTransformFeedback;
			// void glResumeTransformFeedbackNV ()
			public readonly ResumeTransformFeedbackDelegate ResumeTransformFeedback;
			#endregion // commands
			public NvTransformFeedback2 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindTransformFeedbackNV", out BindTransformFeedback);
				resolver.LoadHandle ("glDeleteTransformFeedbacksNV", out DeleteTransformFeedbacks);
				resolver.LoadHandle ("glDrawTransformFeedbackNV", out DrawTransformFeedback);
				resolver.LoadHandle ("glGenTransformFeedbacksNV", out GenTransformFeedbacks);
				resolver.LoadHandle ("glIsTransformFeedbackNV", out IsTransformFeedback);
				resolver.LoadHandle ("glPauseTransformFeedbackNV", out PauseTransformFeedback);
				resolver.LoadHandle ("glResumeTransformFeedbackNV", out ResumeTransformFeedback);
			}
		}
		public partial class NvUniformBufferUnifiedMemory
		{
			public enum All
			{
				// GL_UNIFORM_BUFFER_UNIFIED_NV = 0x936E
				UniformBufferUnified = unchecked((int)37742),
				// GL_UNIFORM_BUFFER_ADDRESS_NV = 0x936F
				UniformBufferAddress = unchecked((int)37743),
				// GL_UNIFORM_BUFFER_LENGTH_NV = 0x9370
				UniformBufferLength = unchecked((int)37744),
			}
			public const string NAME_STRING = "GL_NV_uniform_buffer_unified_memory";
		}
		public partial class NvVdpauInterop
		{
			public enum All
			{
				// GL_SURFACE_STATE_NV = 0x86EB
				SurfaceState = unchecked((int)34539),
				// GL_SURFACE_REGISTERED_NV = 0x86FD
				SurfaceRegistered = unchecked((int)34557),
				// GL_SURFACE_MAPPED_NV = 0x8700
				SurfaceMapped = unchecked((int)34560),
				// GL_WRITE_DISCARD_NV = 0x88BE
				WriteDiscard = unchecked((int)35006),
			}
			public const string NAME_STRING = "GL_NV_vdpau_interop";
			#region command delegates
			// void glVDPAUFiniNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUFiniDelegate ();
			// void glVDPAUGetSurfaceivNV (GLvdpauSurfaceNV surface, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUGetSurfaceivDelegate (System.IntPtr surface, System.UInt32 pname, System.Int32 bufSize, IntPtr length, IntPtr values);
			// void glVDPAUInitNV (void* vdpDevice, void* getProcAddress)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUInitDelegate (IntPtr vdpDevice, IntPtr getProcAddress);
			// GLboolean glVDPAUIsSurfaceNV (GLvdpauSurfaceNV surface)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Boolean VDPAUIsSurfaceDelegate (System.IntPtr surface);
			// void glVDPAUMapSurfacesNV (GLsizei numSurfaces, GLvdpauSurfaceNV* surfaces)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUMapSurfacesDelegate (System.Int32 numSurfaces, IntPtr surfaces);
			// GLvdpauSurfaceNV glVDPAURegisterOutputSurfaceNV (void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr VDPAURegisterOutputSurfaceDelegate (IntPtr vdpSurface, System.UInt32 target, System.Int32 numTextureNames, IntPtr textureNames);
			// GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceNV (void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.IntPtr VDPAURegisterVideoSurfaceDelegate (IntPtr vdpSurface, System.UInt32 target, System.Int32 numTextureNames, IntPtr textureNames);
			// void glVDPAUSurfaceAccessNV (GLvdpauSurfaceNV surface, GLenum access)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUSurfaceAccessDelegate (System.IntPtr surface, System.UInt32 access);
			// void glVDPAUUnmapSurfacesNV (GLsizei numSurface, GLvdpauSurfaceNV* surfaces)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUUnmapSurfacesDelegate (System.Int32 numSurface, IntPtr surfaces);
			// void glVDPAUUnregisterSurfaceNV (GLvdpauSurfaceNV surface)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VDPAUUnregisterSurfaceDelegate (System.IntPtr surface);
			#endregion // command delegates
			#region commands
			// void glVDPAUFiniNV ()
			public readonly VDPAUFiniDelegate VDPAUFini;
			// void glVDPAUGetSurfaceivNV (GLvdpauSurfaceNV surface, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values)
			public readonly VDPAUGetSurfaceivDelegate VDPAUGetSurfaceiv;
			// void glVDPAUInitNV (void* vdpDevice, void* getProcAddress)
			public readonly VDPAUInitDelegate VDPAUInit;
			// GLboolean glVDPAUIsSurfaceNV (GLvdpauSurfaceNV surface)
			public readonly VDPAUIsSurfaceDelegate VDPAUIsSurface;
			// void glVDPAUMapSurfacesNV (GLsizei numSurfaces, GLvdpauSurfaceNV* surfaces)
			public readonly VDPAUMapSurfacesDelegate VDPAUMapSurfaces;
			// GLvdpauSurfaceNV glVDPAURegisterOutputSurfaceNV (void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames)
			public readonly VDPAURegisterOutputSurfaceDelegate VDPAURegisterOutputSurface;
			// GLvdpauSurfaceNV glVDPAURegisterVideoSurfaceNV (void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames)
			public readonly VDPAURegisterVideoSurfaceDelegate VDPAURegisterVideoSurface;
			// void glVDPAUSurfaceAccessNV (GLvdpauSurfaceNV surface, GLenum access)
			public readonly VDPAUSurfaceAccessDelegate VDPAUSurfaceAccess;
			// void glVDPAUUnmapSurfacesNV (GLsizei numSurface, GLvdpauSurfaceNV* surfaces)
			public readonly VDPAUUnmapSurfacesDelegate VDPAUUnmapSurfaces;
			// void glVDPAUUnregisterSurfaceNV (GLvdpauSurfaceNV surface)
			public readonly VDPAUUnregisterSurfaceDelegate VDPAUUnregisterSurface;
			#endregion // commands
			public NvVdpauInterop (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glVDPAUFiniNV", out VDPAUFini);
				resolver.LoadHandle ("glVDPAUGetSurfaceivNV", out VDPAUGetSurfaceiv);
				resolver.LoadHandle ("glVDPAUInitNV", out VDPAUInit);
				resolver.LoadHandle ("glVDPAUIsSurfaceNV", out VDPAUIsSurface);
				resolver.LoadHandle ("glVDPAUMapSurfacesNV", out VDPAUMapSurfaces);
				resolver.LoadHandle ("glVDPAURegisterOutputSurfaceNV", out VDPAURegisterOutputSurface);
				resolver.LoadHandle ("glVDPAURegisterVideoSurfaceNV", out VDPAURegisterVideoSurface);
				resolver.LoadHandle ("glVDPAUSurfaceAccessNV", out VDPAUSurfaceAccess);
				resolver.LoadHandle ("glVDPAUUnmapSurfacesNV", out VDPAUUnmapSurfaces);
				resolver.LoadHandle ("glVDPAUUnregisterSurfaceNV", out VDPAUUnregisterSurface);
			}
		}
		public partial class NvVertexArrayRange
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_RANGE_NV = 0x851D
				VertexArrayRange = unchecked((int)34077),
				// GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E
				VertexArrayRangeLength = unchecked((int)34078),
				// GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F
				VertexArrayRangeValid = unchecked((int)34079),
				// GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520
				MaxVertexArrayRangeElement = unchecked((int)34080),
				// GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521
				VertexArrayRangePointer = unchecked((int)34081),
			}
			public const string NAME_STRING = "GL_NV_vertex_array_range";
			#region command delegates
			// void glFlushVertexArrayRangeNV ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushVertexArrayRangeDelegate ();
			// void glVertexArrayRangeNV (GLsizei length, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayRangeDelegate (System.Int32 length, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glFlushVertexArrayRangeNV ()
			public readonly FlushVertexArrayRangeDelegate FlushVertexArrayRange;
			// void glVertexArrayRangeNV (GLsizei length, void* pointer)
			public readonly VertexArrayRangeDelegate VertexArrayRange;
			#endregion // commands
			public NvVertexArrayRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFlushVertexArrayRangeNV", out FlushVertexArrayRange);
				resolver.LoadHandle ("glVertexArrayRangeNV", out VertexArrayRange);
			}
		}
		public partial class NvVertexArrayRange2
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533
				VertexArrayRangeWithoutFlush = unchecked((int)34099),
			}
			public const string NAME_STRING = "GL_NV_vertex_array_range2";
		}
		public partial class NvVertexAttribInteger64bit
		{
			public const string NAME_STRING = "GL_NV_vertex_attrib_integer_64bit";
			#region command delegates
			// void glGetVertexAttribLi64vNV (GLuint index, GLenum pname, GLint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribLi64vDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribLui64vNV (GLuint index, GLenum pname, GLuint64EXT* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribLui64vDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glVertexAttribL1i64NV (GLuint index, GLint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1i64Delegate (System.UInt32 index, System.Int64 x);
			// void glVertexAttribL1i64vNV (GLuint index, GLint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1i64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL1ui64NV (GLuint index, GLuint64EXT x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1ui64Delegate (System.UInt32 index, System.UInt64 x);
			// void glVertexAttribL1ui64vNV (GLuint index, GLuint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL1ui64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL2i64NV (GLuint index, GLint64EXT x, GLint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2i64Delegate (System.UInt32 index, System.Int64 x, System.Int64 y);
			// void glVertexAttribL2i64vNV (GLuint index, GLint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2i64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL2ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2ui64Delegate (System.UInt32 index, System.UInt64 x, System.UInt64 y);
			// void glVertexAttribL2ui64vNV (GLuint index, GLuint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL2ui64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL3i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3i64Delegate (System.UInt32 index, System.Int64 x, System.Int64 y, System.Int64 z);
			// void glVertexAttribL3i64vNV (GLuint index, GLint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3i64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL3ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3ui64Delegate (System.UInt32 index, System.UInt64 x, System.UInt64 y, System.UInt64 z);
			// void glVertexAttribL3ui64vNV (GLuint index, GLuint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL3ui64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL4i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4i64Delegate (System.UInt32 index, System.Int64 x, System.Int64 y, System.Int64 z, System.Int64 w);
			// void glVertexAttribL4i64vNV (GLuint index, GLint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4i64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribL4ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4ui64Delegate (System.UInt32 index, System.UInt64 x, System.UInt64 y, System.UInt64 z, System.UInt64 w);
			// void glVertexAttribL4ui64vNV (GLuint index, GLuint64EXT* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribL4ui64vDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribLFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribLFormatDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride);
			#endregion // command delegates
			#region commands
			// void glGetVertexAttribLi64vNV (GLuint index, GLenum pname, GLint64EXT* params)
			public readonly GetVertexAttribLi64vDelegate GetVertexAttribLi64v;
			// void glGetVertexAttribLui64vNV (GLuint index, GLenum pname, GLuint64EXT* params)
			public readonly GetVertexAttribLui64vDelegate GetVertexAttribLui64v;
			// void glVertexAttribL1i64NV (GLuint index, GLint64EXT x)
			public readonly VertexAttribL1i64Delegate VertexAttribL1i64;
			// void glVertexAttribL1i64vNV (GLuint index, GLint64EXT* v)
			public readonly VertexAttribL1i64vDelegate VertexAttribL1i64v;
			// void glVertexAttribL1ui64NV (GLuint index, GLuint64EXT x)
			public readonly VertexAttribL1ui64Delegate VertexAttribL1ui64;
			// void glVertexAttribL1ui64vNV (GLuint index, GLuint64EXT* v)
			public readonly VertexAttribL1ui64vDelegate VertexAttribL1ui64v;
			// void glVertexAttribL2i64NV (GLuint index, GLint64EXT x, GLint64EXT y)
			public readonly VertexAttribL2i64Delegate VertexAttribL2i64;
			// void glVertexAttribL2i64vNV (GLuint index, GLint64EXT* v)
			public readonly VertexAttribL2i64vDelegate VertexAttribL2i64v;
			// void glVertexAttribL2ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y)
			public readonly VertexAttribL2ui64Delegate VertexAttribL2ui64;
			// void glVertexAttribL2ui64vNV (GLuint index, GLuint64EXT* v)
			public readonly VertexAttribL2ui64vDelegate VertexAttribL2ui64v;
			// void glVertexAttribL3i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z)
			public readonly VertexAttribL3i64Delegate VertexAttribL3i64;
			// void glVertexAttribL3i64vNV (GLuint index, GLint64EXT* v)
			public readonly VertexAttribL3i64vDelegate VertexAttribL3i64v;
			// void glVertexAttribL3ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z)
			public readonly VertexAttribL3ui64Delegate VertexAttribL3ui64;
			// void glVertexAttribL3ui64vNV (GLuint index, GLuint64EXT* v)
			public readonly VertexAttribL3ui64vDelegate VertexAttribL3ui64v;
			// void glVertexAttribL4i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w)
			public readonly VertexAttribL4i64Delegate VertexAttribL4i64;
			// void glVertexAttribL4i64vNV (GLuint index, GLint64EXT* v)
			public readonly VertexAttribL4i64vDelegate VertexAttribL4i64v;
			// void glVertexAttribL4ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w)
			public readonly VertexAttribL4ui64Delegate VertexAttribL4ui64;
			// void glVertexAttribL4ui64vNV (GLuint index, GLuint64EXT* v)
			public readonly VertexAttribL4ui64vDelegate VertexAttribL4ui64v;
			// void glVertexAttribLFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride)
			public readonly VertexAttribLFormatDelegate VertexAttribLFormat;
			#endregion // commands
			public NvVertexAttribInteger64bit (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetVertexAttribLi64vNV", out GetVertexAttribLi64v);
				resolver.LoadHandle ("glGetVertexAttribLui64vNV", out GetVertexAttribLui64v);
				resolver.LoadHandle ("glVertexAttribL1i64NV", out VertexAttribL1i64);
				resolver.LoadHandle ("glVertexAttribL1i64vNV", out VertexAttribL1i64v);
				resolver.LoadHandle ("glVertexAttribL1ui64NV", out VertexAttribL1ui64);
				resolver.LoadHandle ("glVertexAttribL1ui64vNV", out VertexAttribL1ui64v);
				resolver.LoadHandle ("glVertexAttribL2i64NV", out VertexAttribL2i64);
				resolver.LoadHandle ("glVertexAttribL2i64vNV", out VertexAttribL2i64v);
				resolver.LoadHandle ("glVertexAttribL2ui64NV", out VertexAttribL2ui64);
				resolver.LoadHandle ("glVertexAttribL2ui64vNV", out VertexAttribL2ui64v);
				resolver.LoadHandle ("glVertexAttribL3i64NV", out VertexAttribL3i64);
				resolver.LoadHandle ("glVertexAttribL3i64vNV", out VertexAttribL3i64v);
				resolver.LoadHandle ("glVertexAttribL3ui64NV", out VertexAttribL3ui64);
				resolver.LoadHandle ("glVertexAttribL3ui64vNV", out VertexAttribL3ui64v);
				resolver.LoadHandle ("glVertexAttribL4i64NV", out VertexAttribL4i64);
				resolver.LoadHandle ("glVertexAttribL4i64vNV", out VertexAttribL4i64v);
				resolver.LoadHandle ("glVertexAttribL4ui64NV", out VertexAttribL4ui64);
				resolver.LoadHandle ("glVertexAttribL4ui64vNV", out VertexAttribL4ui64v);
				resolver.LoadHandle ("glVertexAttribLFormatNV", out VertexAttribLFormat);
			}
		}
		public partial class NvVertexBufferUnifiedMemory
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E
				VertexAttribArrayUnified = unchecked((int)36638),
				// GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F
				ElementArrayUnified = unchecked((int)36639),
				// GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20
				VertexAttribArrayAddress = unchecked((int)36640),
				// GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21
				VertexArrayAddress = unchecked((int)36641),
				// GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22
				NormalArrayAddress = unchecked((int)36642),
				// GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23
				ColorArrayAddress = unchecked((int)36643),
				// GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24
				IndexArrayAddress = unchecked((int)36644),
				// GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25
				TextureCoordArrayAddress = unchecked((int)36645),
				// GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26
				EdgeFlagArrayAddress = unchecked((int)36646),
				// GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27
				SecondaryColorArrayAddress = unchecked((int)36647),
				// GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28
				FogCoordArrayAddress = unchecked((int)36648),
				// GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29
				ElementArrayAddress = unchecked((int)36649),
				// GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A
				VertexAttribArrayLength = unchecked((int)36650),
				// GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B
				VertexArrayLength = unchecked((int)36651),
				// GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C
				NormalArrayLength = unchecked((int)36652),
				// GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D
				ColorArrayLength = unchecked((int)36653),
				// GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E
				IndexArrayLength = unchecked((int)36654),
				// GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F
				TextureCoordArrayLength = unchecked((int)36655),
				// GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30
				EdgeFlagArrayLength = unchecked((int)36656),
				// GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31
				SecondaryColorArrayLength = unchecked((int)36657),
				// GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32
				FogCoordArrayLength = unchecked((int)36658),
				// GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33
				ElementArrayLength = unchecked((int)36659),
				// GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40
				DrawIndirectUnified = unchecked((int)36672),
				// GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41
				DrawIndirectAddress = unchecked((int)36673),
				// GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42
				DrawIndirectLength = unchecked((int)36674),
			}
			public const string NAME_STRING = "GL_NV_vertex_buffer_unified_memory";
			#region command delegates
			// void glBufferAddressRangeNV (GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BufferAddressRangeDelegate (System.UInt32 pname, System.UInt32 index, System.UInt64 address, System.IntPtr length);
			// void glColorFormatNV (GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorFormatDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride);
			// void glEdgeFlagFormatNV (GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EdgeFlagFormatDelegate (System.Int32 stride);
			// void glFogCoordFormatNV (GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordFormatDelegate (System.UInt32 type, System.Int32 stride);
			// void glGetIntegerui64i_vNV (GLenum value, GLuint index, GLuint64EXT* result)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetIntegerui64i_vDelegate (System.UInt32 value, System.UInt32 index, IntPtr result);
			// void glIndexFormatNV (GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexFormatDelegate (System.UInt32 type, System.Int32 stride);
			// void glNormalFormatNV (GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalFormatDelegate (System.UInt32 type, System.Int32 stride);
			// void glSecondaryColorFormatNV (GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColorFormatDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride);
			// void glTexCoordFormatNV (GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoordFormatDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride);
			// void glVertexAttribFormatNV (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribFormatDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, Boolean normalized, System.Int32 stride);
			// void glVertexAttribIFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribIFormatDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride);
			// void glVertexFormatNV (GLint size, GLenum type, GLsizei stride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexFormatDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride);
			#endregion // command delegates
			#region commands
			// void glBufferAddressRangeNV (GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length)
			public readonly BufferAddressRangeDelegate BufferAddressRange;
			// void glColorFormatNV (GLint size, GLenum type, GLsizei stride)
			public readonly ColorFormatDelegate ColorFormat;
			// void glEdgeFlagFormatNV (GLsizei stride)
			public readonly EdgeFlagFormatDelegate EdgeFlagFormat;
			// void glFogCoordFormatNV (GLenum type, GLsizei stride)
			public readonly FogCoordFormatDelegate FogCoordFormat;
			// void glGetIntegerui64i_vNV (GLenum value, GLuint index, GLuint64EXT* result)
			public readonly GetIntegerui64i_vDelegate GetIntegerui64i_v;
			// void glIndexFormatNV (GLenum type, GLsizei stride)
			public readonly IndexFormatDelegate IndexFormat;
			// void glNormalFormatNV (GLenum type, GLsizei stride)
			public readonly NormalFormatDelegate NormalFormat;
			// void glSecondaryColorFormatNV (GLint size, GLenum type, GLsizei stride)
			public readonly SecondaryColorFormatDelegate SecondaryColorFormat;
			// void glTexCoordFormatNV (GLint size, GLenum type, GLsizei stride)
			public readonly TexCoordFormatDelegate TexCoordFormat;
			// void glVertexAttribFormatNV (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride)
			public readonly VertexAttribFormatDelegate VertexAttribFormat;
			// void glVertexAttribIFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride)
			public readonly VertexAttribIFormatDelegate VertexAttribIFormat;
			// void glVertexFormatNV (GLint size, GLenum type, GLsizei stride)
			public readonly VertexFormatDelegate VertexFormat;
			#endregion // commands
			public NvVertexBufferUnifiedMemory (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBufferAddressRangeNV", out BufferAddressRange);
				resolver.LoadHandle ("glColorFormatNV", out ColorFormat);
				resolver.LoadHandle ("glEdgeFlagFormatNV", out EdgeFlagFormat);
				resolver.LoadHandle ("glFogCoordFormatNV", out FogCoordFormat);
				resolver.LoadHandle ("glGetIntegerui64i_vNV", out GetIntegerui64i_v);
				resolver.LoadHandle ("glIndexFormatNV", out IndexFormat);
				resolver.LoadHandle ("glNormalFormatNV", out NormalFormat);
				resolver.LoadHandle ("glSecondaryColorFormatNV", out SecondaryColorFormat);
				resolver.LoadHandle ("glTexCoordFormatNV", out TexCoordFormat);
				resolver.LoadHandle ("glVertexAttribFormatNV", out VertexAttribFormat);
				resolver.LoadHandle ("glVertexAttribIFormatNV", out VertexAttribIFormat);
				resolver.LoadHandle ("glVertexFormatNV", out VertexFormat);
			}
		}
		public partial class NvVertexProgram
		{
			public enum All
			{
				// GL_VERTEX_PROGRAM_NV = 0x8620
				VertexProgram = unchecked((int)34336),
				// GL_VERTEX_STATE_PROGRAM_NV = 0x8621
				VertexStateProgram = unchecked((int)34337),
				// GL_ATTRIB_ARRAY_SIZE_NV = 0x8623
				AttribArraySize = unchecked((int)34339),
				// GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624
				AttribArrayStride = unchecked((int)34340),
				// GL_ATTRIB_ARRAY_TYPE_NV = 0x8625
				AttribArrayType = unchecked((int)34341),
				// GL_CURRENT_ATTRIB_NV = 0x8626
				CurrentAttrib = unchecked((int)34342),
				// GL_PROGRAM_LENGTH_NV = 0x8627
				ProgramLength = unchecked((int)34343),
				// GL_PROGRAM_STRING_NV = 0x8628
				ProgramString = unchecked((int)34344),
				// GL_MODELVIEW_PROJECTION_NV = 0x8629
				ModelviewProjection = unchecked((int)34345),
				// GL_IDENTITY_NV = 0x862A
				Identity = unchecked((int)34346),
				// GL_INVERSE_NV = 0x862B
				Inverse = unchecked((int)34347),
				// GL_TRANSPOSE_NV = 0x862C
				Transpose = unchecked((int)34348),
				// GL_INVERSE_TRANSPOSE_NV = 0x862D
				InverseTranspose = unchecked((int)34349),
				// GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E
				MaxTrackMatrixStackDepth = unchecked((int)34350),
				// GL_MAX_TRACK_MATRICES_NV = 0x862F
				MaxTrackMatrices = unchecked((int)34351),
				// GL_MATRIX0_NV = 0x8630
				Matrix0 = unchecked((int)34352),
				// GL_MATRIX1_NV = 0x8631
				Matrix1 = unchecked((int)34353),
				// GL_MATRIX2_NV = 0x8632
				Matrix2 = unchecked((int)34354),
				// GL_MATRIX3_NV = 0x8633
				Matrix3 = unchecked((int)34355),
				// GL_MATRIX4_NV = 0x8634
				Matrix4 = unchecked((int)34356),
				// GL_MATRIX5_NV = 0x8635
				Matrix5 = unchecked((int)34357),
				// GL_MATRIX6_NV = 0x8636
				Matrix6 = unchecked((int)34358),
				// GL_MATRIX7_NV = 0x8637
				Matrix7 = unchecked((int)34359),
				// GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640
				CurrentMatrixStackDepth = unchecked((int)34368),
				// GL_CURRENT_MATRIX_NV = 0x8641
				CurrentMatrix = unchecked((int)34369),
				// GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642
				VertexProgramPointSize = unchecked((int)34370),
				// GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643
				VertexProgramTwoSide = unchecked((int)34371),
				// GL_PROGRAM_PARAMETER_NV = 0x8644
				ProgramParameter = unchecked((int)34372),
				// GL_ATTRIB_ARRAY_POINTER_NV = 0x8645
				AttribArrayPointer = unchecked((int)34373),
				// GL_PROGRAM_TARGET_NV = 0x8646
				ProgramTarget = unchecked((int)34374),
				// GL_PROGRAM_RESIDENT_NV = 0x8647
				ProgramResident = unchecked((int)34375),
				// GL_TRACK_MATRIX_NV = 0x8648
				TrackMatrix = unchecked((int)34376),
				// GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649
				TrackMatrixTransform = unchecked((int)34377),
				// GL_VERTEX_PROGRAM_BINDING_NV = 0x864A
				VertexProgramBinding = unchecked((int)34378),
				// GL_PROGRAM_ERROR_POSITION_NV = 0x864B
				ProgramErrorPosition = unchecked((int)34379),
				// GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650
				VertexAttribArray0 = unchecked((int)34384),
				// GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651
				VertexAttribArray1 = unchecked((int)34385),
				// GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652
				VertexAttribArray2 = unchecked((int)34386),
				// GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653
				VertexAttribArray3 = unchecked((int)34387),
				// GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654
				VertexAttribArray4 = unchecked((int)34388),
				// GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655
				VertexAttribArray5 = unchecked((int)34389),
				// GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656
				VertexAttribArray6 = unchecked((int)34390),
				// GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657
				VertexAttribArray7 = unchecked((int)34391),
				// GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658
				VertexAttribArray8 = unchecked((int)34392),
				// GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659
				VertexAttribArray9 = unchecked((int)34393),
				// GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A
				VertexAttribArray10 = unchecked((int)34394),
				// GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B
				VertexAttribArray11 = unchecked((int)34395),
				// GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C
				VertexAttribArray12 = unchecked((int)34396),
				// GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D
				VertexAttribArray13 = unchecked((int)34397),
				// GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E
				VertexAttribArray14 = unchecked((int)34398),
				// GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F
				VertexAttribArray15 = unchecked((int)34399),
				// GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660
				Map1VertexAttrib04 = unchecked((int)34400),
				// GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661
				Map1VertexAttrib14 = unchecked((int)34401),
				// GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662
				Map1VertexAttrib24 = unchecked((int)34402),
				// GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663
				Map1VertexAttrib34 = unchecked((int)34403),
				// GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664
				Map1VertexAttrib44 = unchecked((int)34404),
				// GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665
				Map1VertexAttrib54 = unchecked((int)34405),
				// GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666
				Map1VertexAttrib64 = unchecked((int)34406),
				// GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667
				Map1VertexAttrib74 = unchecked((int)34407),
				// GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668
				Map1VertexAttrib84 = unchecked((int)34408),
				// GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669
				Map1VertexAttrib94 = unchecked((int)34409),
				// GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A
				Map1VertexAttrib104 = unchecked((int)34410),
				// GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B
				Map1VertexAttrib114 = unchecked((int)34411),
				// GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C
				Map1VertexAttrib124 = unchecked((int)34412),
				// GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D
				Map1VertexAttrib134 = unchecked((int)34413),
				// GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E
				Map1VertexAttrib144 = unchecked((int)34414),
				// GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F
				Map1VertexAttrib154 = unchecked((int)34415),
				// GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670
				Map2VertexAttrib04 = unchecked((int)34416),
				// GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671
				Map2VertexAttrib14 = unchecked((int)34417),
				// GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672
				Map2VertexAttrib24 = unchecked((int)34418),
				// GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673
				Map2VertexAttrib34 = unchecked((int)34419),
				// GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674
				Map2VertexAttrib44 = unchecked((int)34420),
				// GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675
				Map2VertexAttrib54 = unchecked((int)34421),
				// GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676
				Map2VertexAttrib64 = unchecked((int)34422),
				// GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677
				Map2VertexAttrib74 = unchecked((int)34423),
				// GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678
				Map2VertexAttrib84 = unchecked((int)34424),
				// GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679
				Map2VertexAttrib94 = unchecked((int)34425),
				// GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A
				Map2VertexAttrib104 = unchecked((int)34426),
				// GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B
				Map2VertexAttrib114 = unchecked((int)34427),
				// GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C
				Map2VertexAttrib124 = unchecked((int)34428),
				// GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D
				Map2VertexAttrib134 = unchecked((int)34429),
				// GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E
				Map2VertexAttrib144 = unchecked((int)34430),
				// GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F
				Map2VertexAttrib154 = unchecked((int)34431),
			}
			public const string NAME_STRING = "GL_NV_vertex_program";
			#region command delegates
			// GLboolean glAreProgramsResidentNV (GLsizei n, GLuint* programs, GLboolean* residences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean AreProgramsResidentDelegate (System.Int32 n, IntPtr programs, Boolean residences);
			// void glBindProgramNV (GLenum target, GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindProgramDelegate (System.UInt32 target, System.UInt32 id);
			// void glDeleteProgramsNV (GLsizei n, GLuint* programs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteProgramsDelegate (System.Int32 n, IntPtr programs);
			// void glExecuteProgramNV (GLenum target, GLuint id, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ExecuteProgramDelegate (System.UInt32 target, System.UInt32 id, IntPtr @params);
			// void glGenProgramsNV (GLsizei n, GLuint* programs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenProgramsDelegate (System.Int32 n, IntPtr programs);
			// void glGetProgramivNV (GLuint id, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// void glGetProgramParameterdvNV (GLenum target, GLuint index, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramParameterdvDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetProgramParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramParameterfvDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetProgramStringNV (GLuint id, GLenum pname, GLubyte* program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetProgramStringDelegate (System.UInt32 id, System.UInt32 pname, IntPtr program);
			// void glGetTrackMatrixivNV (GLenum target, GLuint address, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTrackMatrixivDelegate (System.UInt32 target, System.UInt32 address, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribdvNV (GLuint index, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribdvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribfvNV (GLuint index, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribfvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribivNV (GLuint index, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribPointervNV (GLuint index, GLenum pname, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribPointervDelegate (System.UInt32 index, System.UInt32 pname, IntPtr pointer);
			// GLboolean glIsProgramNV (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsProgramDelegate (System.UInt32 id);
			// void glLoadProgramNV (GLenum target, GLuint id, GLsizei len, GLubyte* program)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadProgramDelegate (System.UInt32 target, System.UInt32 id, System.Int32 len, IntPtr program);
			// void glProgramParameter4dNV (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameter4dDelegate (System.UInt32 target, System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glProgramParameter4dvNV (GLenum target, GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameter4dvDelegate (System.UInt32 target, System.UInt32 index, IntPtr v);
			// void glProgramParameter4fNV (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameter4fDelegate (System.UInt32 target, System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glProgramParameter4fvNV (GLenum target, GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameter4fvDelegate (System.UInt32 target, System.UInt32 index, IntPtr v);
			// void glProgramParameters4dvNV (GLenum target, GLuint index, GLsizei count, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameters4dvDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr v);
			// void glProgramParameters4fvNV (GLenum target, GLuint index, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ProgramParameters4fvDelegate (System.UInt32 target, System.UInt32 index, System.Int32 count, IntPtr v);
			// void glRequestResidentProgramsNV (GLsizei n, GLuint* programs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RequestResidentProgramsDelegate (System.Int32 n, IntPtr programs);
			// void glTrackMatrixNV (GLenum target, GLuint address, GLenum matrix, GLenum transform)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TrackMatrixDelegate (System.UInt32 target, System.UInt32 address, System.UInt32 matrix, System.UInt32 transform);
			// void glVertexAttrib1dNV (GLuint index, GLdouble x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1dDelegate (System.UInt32 index, System.Double x);
			// void glVertexAttrib1dvNV (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib1fNV (GLuint index, GLfloat x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1fDelegate (System.UInt32 index, System.Single x);
			// void glVertexAttrib1fvNV (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib1sNV (GLuint index, GLshort x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1sDelegate (System.UInt32 index, System.Int16 x);
			// void glVertexAttrib1svNV (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib1svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2dNV (GLuint index, GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2dDelegate (System.UInt32 index, System.Double x, System.Double y);
			// void glVertexAttrib2dvNV (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2fNV (GLuint index, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2fDelegate (System.UInt32 index, System.Single x, System.Single y);
			// void glVertexAttrib2fvNV (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib2sNV (GLuint index, GLshort x, GLshort y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y);
			// void glVertexAttrib2svNV (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib2svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z);
			// void glVertexAttrib3dvNV (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z);
			// void glVertexAttrib3fvNV (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib3sNV (GLuint index, GLshort x, GLshort y, GLshort z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z);
			// void glVertexAttrib3svNV (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib3svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glVertexAttrib4dvNV (GLuint index, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4dvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glVertexAttrib4fvNV (GLuint index, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4fvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4sNV (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w);
			// void glVertexAttrib4svNV (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttrib4ubNV (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4ubDelegate (System.UInt32 index, System.Byte x, System.Byte y, System.Byte z, System.Byte w);
			// void glVertexAttrib4ubvNV (GLuint index, GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttrib4ubvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribPointerNV (GLuint index, GLint fsize, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribPointerDelegate (System.UInt32 index, System.Int32 fsize, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			// void glVertexAttribs1dvNV (GLuint index, GLsizei count, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs1dvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs1fvNV (GLuint index, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs1fvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs1svNV (GLuint index, GLsizei count, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs1svDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs2dvNV (GLuint index, GLsizei count, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs2dvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs2fvNV (GLuint index, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs2fvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs2svNV (GLuint index, GLsizei count, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs2svDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs3dvNV (GLuint index, GLsizei count, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs3dvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs3fvNV (GLuint index, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs3fvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs3svNV (GLuint index, GLsizei count, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs3svDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs4dvNV (GLuint index, GLsizei count, GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs4dvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs4fvNV (GLuint index, GLsizei count, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs4fvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs4svNV (GLuint index, GLsizei count, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs4svDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			// void glVertexAttribs4ubvNV (GLuint index, GLsizei count, GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribs4ubvDelegate (System.UInt32 index, System.Int32 count, IntPtr v);
			#endregion // command delegates
			#region commands
			// GLboolean glAreProgramsResidentNV (GLsizei n, GLuint* programs, GLboolean* residences)
			public readonly AreProgramsResidentDelegate AreProgramsResident;
			// void glBindProgramNV (GLenum target, GLuint id)
			public readonly BindProgramDelegate BindProgram;
			// void glDeleteProgramsNV (GLsizei n, GLuint* programs)
			public readonly DeleteProgramsDelegate DeletePrograms;
			// void glExecuteProgramNV (GLenum target, GLuint id, GLfloat* params)
			public readonly ExecuteProgramDelegate ExecuteProgram;
			// void glGenProgramsNV (GLsizei n, GLuint* programs)
			public readonly GenProgramsDelegate GenPrograms;
			// void glGetProgramivNV (GLuint id, GLenum pname, GLint* params)
			public readonly GetProgramivDelegate GetProgramiv;
			// void glGetProgramParameterdvNV (GLenum target, GLuint index, GLenum pname, GLdouble* params)
			public readonly GetProgramParameterdvDelegate GetProgramParameterdv;
			// void glGetProgramParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat* params)
			public readonly GetProgramParameterfvDelegate GetProgramParameterfv;
			// void glGetProgramStringNV (GLuint id, GLenum pname, GLubyte* program)
			public readonly GetProgramStringDelegate GetProgramString;
			// void glGetTrackMatrixivNV (GLenum target, GLuint address, GLenum pname, GLint* params)
			public readonly GetTrackMatrixivDelegate GetTrackMatrixiv;
			// void glGetVertexAttribdvNV (GLuint index, GLenum pname, GLdouble* params)
			public readonly GetVertexAttribdvDelegate GetVertexAttribdv;
			// void glGetVertexAttribfvNV (GLuint index, GLenum pname, GLfloat* params)
			public readonly GetVertexAttribfvDelegate GetVertexAttribfv;
			// void glGetVertexAttribivNV (GLuint index, GLenum pname, GLint* params)
			public readonly GetVertexAttribivDelegate GetVertexAttribiv;
			// void glGetVertexAttribPointervNV (GLuint index, GLenum pname, void** pointer)
			public readonly GetVertexAttribPointervDelegate GetVertexAttribPointerv;
			// GLboolean glIsProgramNV (GLuint id)
			public readonly IsProgramDelegate IsProgram;
			// void glLoadProgramNV (GLenum target, GLuint id, GLsizei len, GLubyte* program)
			public readonly LoadProgramDelegate LoadProgram;
			// void glProgramParameter4dNV (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly ProgramParameter4dDelegate ProgramParameter4d;
			// void glProgramParameter4dvNV (GLenum target, GLuint index, GLdouble* v)
			public readonly ProgramParameter4dvDelegate ProgramParameter4dv;
			// void glProgramParameter4fNV (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly ProgramParameter4fDelegate ProgramParameter4f;
			// void glProgramParameter4fvNV (GLenum target, GLuint index, GLfloat* v)
			public readonly ProgramParameter4fvDelegate ProgramParameter4fv;
			// void glProgramParameters4dvNV (GLenum target, GLuint index, GLsizei count, GLdouble* v)
			public readonly ProgramParameters4dvDelegate ProgramParameters4dv;
			// void glProgramParameters4fvNV (GLenum target, GLuint index, GLsizei count, GLfloat* v)
			public readonly ProgramParameters4fvDelegate ProgramParameters4fv;
			// void glRequestResidentProgramsNV (GLsizei n, GLuint* programs)
			public readonly RequestResidentProgramsDelegate RequestResidentPrograms;
			// void glTrackMatrixNV (GLenum target, GLuint address, GLenum matrix, GLenum transform)
			public readonly TrackMatrixDelegate TrackMatrix;
			// void glVertexAttrib1dNV (GLuint index, GLdouble x)
			public readonly VertexAttrib1dDelegate VertexAttrib1d;
			// void glVertexAttrib1dvNV (GLuint index, GLdouble* v)
			public readonly VertexAttrib1dvDelegate VertexAttrib1dv;
			// void glVertexAttrib1fNV (GLuint index, GLfloat x)
			public readonly VertexAttrib1fDelegate VertexAttrib1f;
			// void glVertexAttrib1fvNV (GLuint index, GLfloat* v)
			public readonly VertexAttrib1fvDelegate VertexAttrib1fv;
			// void glVertexAttrib1sNV (GLuint index, GLshort x)
			public readonly VertexAttrib1sDelegate VertexAttrib1s;
			// void glVertexAttrib1svNV (GLuint index, GLshort* v)
			public readonly VertexAttrib1svDelegate VertexAttrib1sv;
			// void glVertexAttrib2dNV (GLuint index, GLdouble x, GLdouble y)
			public readonly VertexAttrib2dDelegate VertexAttrib2d;
			// void glVertexAttrib2dvNV (GLuint index, GLdouble* v)
			public readonly VertexAttrib2dvDelegate VertexAttrib2dv;
			// void glVertexAttrib2fNV (GLuint index, GLfloat x, GLfloat y)
			public readonly VertexAttrib2fDelegate VertexAttrib2f;
			// void glVertexAttrib2fvNV (GLuint index, GLfloat* v)
			public readonly VertexAttrib2fvDelegate VertexAttrib2fv;
			// void glVertexAttrib2sNV (GLuint index, GLshort x, GLshort y)
			public readonly VertexAttrib2sDelegate VertexAttrib2s;
			// void glVertexAttrib2svNV (GLuint index, GLshort* v)
			public readonly VertexAttrib2svDelegate VertexAttrib2sv;
			// void glVertexAttrib3dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z)
			public readonly VertexAttrib3dDelegate VertexAttrib3d;
			// void glVertexAttrib3dvNV (GLuint index, GLdouble* v)
			public readonly VertexAttrib3dvDelegate VertexAttrib3dv;
			// void glVertexAttrib3fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z)
			public readonly VertexAttrib3fDelegate VertexAttrib3f;
			// void glVertexAttrib3fvNV (GLuint index, GLfloat* v)
			public readonly VertexAttrib3fvDelegate VertexAttrib3fv;
			// void glVertexAttrib3sNV (GLuint index, GLshort x, GLshort y, GLshort z)
			public readonly VertexAttrib3sDelegate VertexAttrib3s;
			// void glVertexAttrib3svNV (GLuint index, GLshort* v)
			public readonly VertexAttrib3svDelegate VertexAttrib3sv;
			// void glVertexAttrib4dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly VertexAttrib4dDelegate VertexAttrib4d;
			// void glVertexAttrib4dvNV (GLuint index, GLdouble* v)
			public readonly VertexAttrib4dvDelegate VertexAttrib4dv;
			// void glVertexAttrib4fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly VertexAttrib4fDelegate VertexAttrib4f;
			// void glVertexAttrib4fvNV (GLuint index, GLfloat* v)
			public readonly VertexAttrib4fvDelegate VertexAttrib4fv;
			// void glVertexAttrib4sNV (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
			public readonly VertexAttrib4sDelegate VertexAttrib4s;
			// void glVertexAttrib4svNV (GLuint index, GLshort* v)
			public readonly VertexAttrib4svDelegate VertexAttrib4sv;
			// void glVertexAttrib4ubNV (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
			public readonly VertexAttrib4ubDelegate VertexAttrib4ub;
			// void glVertexAttrib4ubvNV (GLuint index, GLubyte* v)
			public readonly VertexAttrib4ubvDelegate VertexAttrib4ubv;
			// void glVertexAttribPointerNV (GLuint index, GLint fsize, GLenum type, GLsizei stride, void* pointer)
			public readonly VertexAttribPointerDelegate VertexAttribPointer;
			// void glVertexAttribs1dvNV (GLuint index, GLsizei count, GLdouble* v)
			public readonly VertexAttribs1dvDelegate VertexAttribs1dv;
			// void glVertexAttribs1fvNV (GLuint index, GLsizei count, GLfloat* v)
			public readonly VertexAttribs1fvDelegate VertexAttribs1fv;
			// void glVertexAttribs1svNV (GLuint index, GLsizei count, GLshort* v)
			public readonly VertexAttribs1svDelegate VertexAttribs1sv;
			// void glVertexAttribs2dvNV (GLuint index, GLsizei count, GLdouble* v)
			public readonly VertexAttribs2dvDelegate VertexAttribs2dv;
			// void glVertexAttribs2fvNV (GLuint index, GLsizei count, GLfloat* v)
			public readonly VertexAttribs2fvDelegate VertexAttribs2fv;
			// void glVertexAttribs2svNV (GLuint index, GLsizei count, GLshort* v)
			public readonly VertexAttribs2svDelegate VertexAttribs2sv;
			// void glVertexAttribs3dvNV (GLuint index, GLsizei count, GLdouble* v)
			public readonly VertexAttribs3dvDelegate VertexAttribs3dv;
			// void glVertexAttribs3fvNV (GLuint index, GLsizei count, GLfloat* v)
			public readonly VertexAttribs3fvDelegate VertexAttribs3fv;
			// void glVertexAttribs3svNV (GLuint index, GLsizei count, GLshort* v)
			public readonly VertexAttribs3svDelegate VertexAttribs3sv;
			// void glVertexAttribs4dvNV (GLuint index, GLsizei count, GLdouble* v)
			public readonly VertexAttribs4dvDelegate VertexAttribs4dv;
			// void glVertexAttribs4fvNV (GLuint index, GLsizei count, GLfloat* v)
			public readonly VertexAttribs4fvDelegate VertexAttribs4fv;
			// void glVertexAttribs4svNV (GLuint index, GLsizei count, GLshort* v)
			public readonly VertexAttribs4svDelegate VertexAttribs4sv;
			// void glVertexAttribs4ubvNV (GLuint index, GLsizei count, GLubyte* v)
			public readonly VertexAttribs4ubvDelegate VertexAttribs4ubv;
			#endregion // commands
			public NvVertexProgram (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAreProgramsResidentNV", out AreProgramsResident);
				resolver.LoadHandle ("glBindProgramNV", out BindProgram);
				resolver.LoadHandle ("glDeleteProgramsNV", out DeletePrograms);
				resolver.LoadHandle ("glExecuteProgramNV", out ExecuteProgram);
				resolver.LoadHandle ("glGenProgramsNV", out GenPrograms);
				resolver.LoadHandle ("glGetProgramivNV", out GetProgramiv);
				resolver.LoadHandle ("glGetProgramParameterdvNV", out GetProgramParameterdv);
				resolver.LoadHandle ("glGetProgramParameterfvNV", out GetProgramParameterfv);
				resolver.LoadHandle ("glGetProgramStringNV", out GetProgramString);
				resolver.LoadHandle ("glGetTrackMatrixivNV", out GetTrackMatrixiv);
				resolver.LoadHandle ("glGetVertexAttribdvNV", out GetVertexAttribdv);
				resolver.LoadHandle ("glGetVertexAttribfvNV", out GetVertexAttribfv);
				resolver.LoadHandle ("glGetVertexAttribivNV", out GetVertexAttribiv);
				resolver.LoadHandle ("glGetVertexAttribPointervNV", out GetVertexAttribPointerv);
				resolver.LoadHandle ("glIsProgramNV", out IsProgram);
				resolver.LoadHandle ("glLoadProgramNV", out LoadProgram);
				resolver.LoadHandle ("glProgramParameter4dNV", out ProgramParameter4d);
				resolver.LoadHandle ("glProgramParameter4dvNV", out ProgramParameter4dv);
				resolver.LoadHandle ("glProgramParameter4fNV", out ProgramParameter4f);
				resolver.LoadHandle ("glProgramParameter4fvNV", out ProgramParameter4fv);
				resolver.LoadHandle ("glProgramParameters4dvNV", out ProgramParameters4dv);
				resolver.LoadHandle ("glProgramParameters4fvNV", out ProgramParameters4fv);
				resolver.LoadHandle ("glRequestResidentProgramsNV", out RequestResidentPrograms);
				resolver.LoadHandle ("glTrackMatrixNV", out TrackMatrix);
				resolver.LoadHandle ("glVertexAttrib1dNV", out VertexAttrib1d);
				resolver.LoadHandle ("glVertexAttrib1dvNV", out VertexAttrib1dv);
				resolver.LoadHandle ("glVertexAttrib1fNV", out VertexAttrib1f);
				resolver.LoadHandle ("glVertexAttrib1fvNV", out VertexAttrib1fv);
				resolver.LoadHandle ("glVertexAttrib1sNV", out VertexAttrib1s);
				resolver.LoadHandle ("glVertexAttrib1svNV", out VertexAttrib1sv);
				resolver.LoadHandle ("glVertexAttrib2dNV", out VertexAttrib2d);
				resolver.LoadHandle ("glVertexAttrib2dvNV", out VertexAttrib2dv);
				resolver.LoadHandle ("glVertexAttrib2fNV", out VertexAttrib2f);
				resolver.LoadHandle ("glVertexAttrib2fvNV", out VertexAttrib2fv);
				resolver.LoadHandle ("glVertexAttrib2sNV", out VertexAttrib2s);
				resolver.LoadHandle ("glVertexAttrib2svNV", out VertexAttrib2sv);
				resolver.LoadHandle ("glVertexAttrib3dNV", out VertexAttrib3d);
				resolver.LoadHandle ("glVertexAttrib3dvNV", out VertexAttrib3dv);
				resolver.LoadHandle ("glVertexAttrib3fNV", out VertexAttrib3f);
				resolver.LoadHandle ("glVertexAttrib3fvNV", out VertexAttrib3fv);
				resolver.LoadHandle ("glVertexAttrib3sNV", out VertexAttrib3s);
				resolver.LoadHandle ("glVertexAttrib3svNV", out VertexAttrib3sv);
				resolver.LoadHandle ("glVertexAttrib4dNV", out VertexAttrib4d);
				resolver.LoadHandle ("glVertexAttrib4dvNV", out VertexAttrib4dv);
				resolver.LoadHandle ("glVertexAttrib4fNV", out VertexAttrib4f);
				resolver.LoadHandle ("glVertexAttrib4fvNV", out VertexAttrib4fv);
				resolver.LoadHandle ("glVertexAttrib4sNV", out VertexAttrib4s);
				resolver.LoadHandle ("glVertexAttrib4svNV", out VertexAttrib4sv);
				resolver.LoadHandle ("glVertexAttrib4ubNV", out VertexAttrib4ub);
				resolver.LoadHandle ("glVertexAttrib4ubvNV", out VertexAttrib4ubv);
				resolver.LoadHandle ("glVertexAttribPointerNV", out VertexAttribPointer);
				resolver.LoadHandle ("glVertexAttribs1dvNV", out VertexAttribs1dv);
				resolver.LoadHandle ("glVertexAttribs1fvNV", out VertexAttribs1fv);
				resolver.LoadHandle ("glVertexAttribs1svNV", out VertexAttribs1sv);
				resolver.LoadHandle ("glVertexAttribs2dvNV", out VertexAttribs2dv);
				resolver.LoadHandle ("glVertexAttribs2fvNV", out VertexAttribs2fv);
				resolver.LoadHandle ("glVertexAttribs2svNV", out VertexAttribs2sv);
				resolver.LoadHandle ("glVertexAttribs3dvNV", out VertexAttribs3dv);
				resolver.LoadHandle ("glVertexAttribs3fvNV", out VertexAttribs3fv);
				resolver.LoadHandle ("glVertexAttribs3svNV", out VertexAttribs3sv);
				resolver.LoadHandle ("glVertexAttribs4dvNV", out VertexAttribs4dv);
				resolver.LoadHandle ("glVertexAttribs4fvNV", out VertexAttribs4fv);
				resolver.LoadHandle ("glVertexAttribs4svNV", out VertexAttribs4sv);
				resolver.LoadHandle ("glVertexAttribs4ubvNV", out VertexAttribs4ubv);
			}
		}
		public partial class NvVertexProgram4
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD
				VertexAttribArrayInteger = unchecked((int)35069),
			}
			public const string NAME_STRING = "GL_NV_vertex_program4";
			#region command delegates
			// void glGetVertexAttribIivEXT (GLuint index, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribIivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribIuivEXT (GLuint index, GLenum pname, GLuint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribIuivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glVertexAttribI1iEXT (GLuint index, GLint x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI1iDelegate (System.UInt32 index, System.Int32 x);
			// void glVertexAttribI1ivEXT (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI1ivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI1uiEXT (GLuint index, GLuint x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI1uiDelegate (System.UInt32 index, System.UInt32 x);
			// void glVertexAttribI1uivEXT (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI1uivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI2iEXT (GLuint index, GLint x, GLint y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI2iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y);
			// void glVertexAttribI2ivEXT (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI2ivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI2uiEXT (GLuint index, GLuint x, GLuint y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI2uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y);
			// void glVertexAttribI2uivEXT (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI2uivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI3iEXT (GLuint index, GLint x, GLint y, GLint z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI3iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z);
			// void glVertexAttribI3ivEXT (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI3ivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI3uiEXT (GLuint index, GLuint x, GLuint y, GLuint z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI3uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z);
			// void glVertexAttribI3uivEXT (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI3uivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4bvEXT (GLuint index, GLbyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4bvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4iEXT (GLuint index, GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glVertexAttribI4ivEXT (GLuint index, GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4ivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4svEXT (GLuint index, GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4svDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4ubvEXT (GLuint index, GLubyte* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4ubvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4uiEXT (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w);
			// void glVertexAttribI4uivEXT (GLuint index, GLuint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4uivDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribI4usvEXT (GLuint index, GLushort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribI4usvDelegate (System.UInt32 index, IntPtr v);
			// void glVertexAttribIPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribIPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glGetVertexAttribIivEXT (GLuint index, GLenum pname, GLint* params)
			public readonly GetVertexAttribIivDelegate GetVertexAttribIiv;
			// void glGetVertexAttribIuivEXT (GLuint index, GLenum pname, GLuint* params)
			public readonly GetVertexAttribIuivDelegate GetVertexAttribIuiv;
			// void glVertexAttribI1iEXT (GLuint index, GLint x)
			public readonly VertexAttribI1iDelegate VertexAttribI1i;
			// void glVertexAttribI1ivEXT (GLuint index, GLint* v)
			public readonly VertexAttribI1ivDelegate VertexAttribI1iv;
			// void glVertexAttribI1uiEXT (GLuint index, GLuint x)
			public readonly VertexAttribI1uiDelegate VertexAttribI1ui;
			// void glVertexAttribI1uivEXT (GLuint index, GLuint* v)
			public readonly VertexAttribI1uivDelegate VertexAttribI1uiv;
			// void glVertexAttribI2iEXT (GLuint index, GLint x, GLint y)
			public readonly VertexAttribI2iDelegate VertexAttribI2i;
			// void glVertexAttribI2ivEXT (GLuint index, GLint* v)
			public readonly VertexAttribI2ivDelegate VertexAttribI2iv;
			// void glVertexAttribI2uiEXT (GLuint index, GLuint x, GLuint y)
			public readonly VertexAttribI2uiDelegate VertexAttribI2ui;
			// void glVertexAttribI2uivEXT (GLuint index, GLuint* v)
			public readonly VertexAttribI2uivDelegate VertexAttribI2uiv;
			// void glVertexAttribI3iEXT (GLuint index, GLint x, GLint y, GLint z)
			public readonly VertexAttribI3iDelegate VertexAttribI3i;
			// void glVertexAttribI3ivEXT (GLuint index, GLint* v)
			public readonly VertexAttribI3ivDelegate VertexAttribI3iv;
			// void glVertexAttribI3uiEXT (GLuint index, GLuint x, GLuint y, GLuint z)
			public readonly VertexAttribI3uiDelegate VertexAttribI3ui;
			// void glVertexAttribI3uivEXT (GLuint index, GLuint* v)
			public readonly VertexAttribI3uivDelegate VertexAttribI3uiv;
			// void glVertexAttribI4bvEXT (GLuint index, GLbyte* v)
			public readonly VertexAttribI4bvDelegate VertexAttribI4bv;
			// void glVertexAttribI4iEXT (GLuint index, GLint x, GLint y, GLint z, GLint w)
			public readonly VertexAttribI4iDelegate VertexAttribI4i;
			// void glVertexAttribI4ivEXT (GLuint index, GLint* v)
			public readonly VertexAttribI4ivDelegate VertexAttribI4iv;
			// void glVertexAttribI4svEXT (GLuint index, GLshort* v)
			public readonly VertexAttribI4svDelegate VertexAttribI4sv;
			// void glVertexAttribI4ubvEXT (GLuint index, GLubyte* v)
			public readonly VertexAttribI4ubvDelegate VertexAttribI4ubv;
			// void glVertexAttribI4uiEXT (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
			public readonly VertexAttribI4uiDelegate VertexAttribI4ui;
			// void glVertexAttribI4uivEXT (GLuint index, GLuint* v)
			public readonly VertexAttribI4uivDelegate VertexAttribI4uiv;
			// void glVertexAttribI4usvEXT (GLuint index, GLushort* v)
			public readonly VertexAttribI4usvDelegate VertexAttribI4usv;
			// void glVertexAttribIPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
			public readonly VertexAttribIPointerDelegate VertexAttribIPointer;
			#endregion // commands
			public NvVertexProgram4 (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetVertexAttribIivEXT", out GetVertexAttribIiv);
				resolver.LoadHandle ("glGetVertexAttribIuivEXT", out GetVertexAttribIuiv);
				resolver.LoadHandle ("glVertexAttribI1iEXT", out VertexAttribI1i);
				resolver.LoadHandle ("glVertexAttribI1ivEXT", out VertexAttribI1iv);
				resolver.LoadHandle ("glVertexAttribI1uiEXT", out VertexAttribI1ui);
				resolver.LoadHandle ("glVertexAttribI1uivEXT", out VertexAttribI1uiv);
				resolver.LoadHandle ("glVertexAttribI2iEXT", out VertexAttribI2i);
				resolver.LoadHandle ("glVertexAttribI2ivEXT", out VertexAttribI2iv);
				resolver.LoadHandle ("glVertexAttribI2uiEXT", out VertexAttribI2ui);
				resolver.LoadHandle ("glVertexAttribI2uivEXT", out VertexAttribI2uiv);
				resolver.LoadHandle ("glVertexAttribI3iEXT", out VertexAttribI3i);
				resolver.LoadHandle ("glVertexAttribI3ivEXT", out VertexAttribI3iv);
				resolver.LoadHandle ("glVertexAttribI3uiEXT", out VertexAttribI3ui);
				resolver.LoadHandle ("glVertexAttribI3uivEXT", out VertexAttribI3uiv);
				resolver.LoadHandle ("glVertexAttribI4bvEXT", out VertexAttribI4bv);
				resolver.LoadHandle ("glVertexAttribI4iEXT", out VertexAttribI4i);
				resolver.LoadHandle ("glVertexAttribI4ivEXT", out VertexAttribI4iv);
				resolver.LoadHandle ("glVertexAttribI4svEXT", out VertexAttribI4sv);
				resolver.LoadHandle ("glVertexAttribI4ubvEXT", out VertexAttribI4ubv);
				resolver.LoadHandle ("glVertexAttribI4uiEXT", out VertexAttribI4ui);
				resolver.LoadHandle ("glVertexAttribI4uivEXT", out VertexAttribI4uiv);
				resolver.LoadHandle ("glVertexAttribI4usvEXT", out VertexAttribI4usv);
				resolver.LoadHandle ("glVertexAttribIPointerEXT", out VertexAttribIPointer);
			}
		}
		public partial class NvVideoCapture
		{
			public enum All
			{
				// GL_VIDEO_BUFFER_NV = 0x9020
				VideoBuffer = unchecked((int)36896),
				// GL_VIDEO_BUFFER_BINDING_NV = 0x9021
				VideoBufferBinding = unchecked((int)36897),
				// GL_FIELD_UPPER_NV = 0x9022
				FieldUpper = unchecked((int)36898),
				// GL_FIELD_LOWER_NV = 0x9023
				FieldLower = unchecked((int)36899),
				// GL_NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024
				NumVideoCaptureStreams = unchecked((int)36900),
				// GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025
				NextVideoCaptureBufferStatus = unchecked((int)36901),
				// GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026
				VideoCaptureTo422Supported = unchecked((int)36902),
				// GL_LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027
				LastVideoCaptureStatus = unchecked((int)36903),
				// GL_VIDEO_BUFFER_PITCH_NV = 0x9028
				VideoBufferPitch = unchecked((int)36904),
				// GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029
				VideoColorConversionMatrix = unchecked((int)36905),
				// GL_VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A
				VideoColorConversionMax = unchecked((int)36906),
				// GL_VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B
				VideoColorConversionMin = unchecked((int)36907),
				// GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C
				VideoColorConversionOffset = unchecked((int)36908),
				// GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D
				VideoBufferInternalFormat = unchecked((int)36909),
				// GL_PARTIAL_SUCCESS_NV = 0x902E
				PartialSuccess = unchecked((int)36910),
				// GL_SUCCESS_NV = 0x902F
				Success = unchecked((int)36911),
				// GL_FAILURE_NV = 0x9030
				Failure = unchecked((int)36912),
				// GL_YCBYCR8_422_NV = 0x9031
				Ycbycr8422 = unchecked((int)36913),
				// GL_YCBAYCR8A_4224_NV = 0x9032
				Ycbaycr8a4224 = unchecked((int)36914),
				// GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033
				Z6y10z6cb10z6y10z6cr10422 = unchecked((int)36915),
				// GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034
				Z6y10z6cb10z6a10z6y10z6cr10z6a104224 = unchecked((int)36916),
				// GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035
				Z4y12z4cb12z4y12z4cr12422 = unchecked((int)36917),
				// GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036
				Z4y12z4cb12z4a12z4y12z4cr12z4a124224 = unchecked((int)36918),
				// GL_Z4Y12Z4CB12Z4CR12_444_NV = 0x9037
				Z4y12z4cb12z4cr12444 = unchecked((int)36919),
				// GL_VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038
				VideoCaptureFrameWidth = unchecked((int)36920),
				// GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039
				VideoCaptureFrameHeight = unchecked((int)36921),
				// GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A
				VideoCaptureFieldUpperHeight = unchecked((int)36922),
				// GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B
				VideoCaptureFieldLowerHeight = unchecked((int)36923),
				// GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C
				VideoCaptureSurfaceOrigin = unchecked((int)36924),
			}
			public const string NAME_STRING = "GL_NV_video_capture";
			#region command delegates
			// void glBeginVideoCaptureNV (GLuint video_capture_slot)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginVideoCaptureDelegate (System.UInt32 video_capture_slot);
			// void glBindVideoCaptureStreamBufferNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindVideoCaptureStreamBufferDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 frame_region, System.IntPtr offset);
			// void glBindVideoCaptureStreamTextureNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindVideoCaptureStreamTextureDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 frame_region, System.UInt32 target, System.UInt32 texture);
			// void glEndVideoCaptureNV (GLuint video_capture_slot)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndVideoCaptureDelegate (System.UInt32 video_capture_slot);
			// void glGetVideoCaptureivNV (GLuint video_capture_slot, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoCaptureivDelegate (System.UInt32 video_capture_slot, System.UInt32 pname, IntPtr @params);
			// void glGetVideoCaptureStreamdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoCaptureStreamdvDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			// void glGetVideoCaptureStreamfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoCaptureStreamfvDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			// void glGetVideoCaptureStreamivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVideoCaptureStreamivDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			// GLenum glVideoCaptureNV (GLuint video_capture_slot, GLuint* sequence_num, GLuint64EXT* capture_time)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 VideoCaptureDelegate (System.UInt32 video_capture_slot, IntPtr sequence_num, IntPtr capture_time);
			// void glVideoCaptureStreamParameterdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VideoCaptureStreamParameterdvDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			// void glVideoCaptureStreamParameterfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VideoCaptureStreamParameterfvDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			// void glVideoCaptureStreamParameterivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VideoCaptureStreamParameterivDelegate (System.UInt32 video_capture_slot, System.UInt32 stream, System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glBeginVideoCaptureNV (GLuint video_capture_slot)
			public readonly BeginVideoCaptureDelegate BeginVideoCapture;
			// void glBindVideoCaptureStreamBufferNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset)
			public readonly BindVideoCaptureStreamBufferDelegate BindVideoCaptureStreamBuffer;
			// void glBindVideoCaptureStreamTextureNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture)
			public readonly BindVideoCaptureStreamTextureDelegate BindVideoCaptureStreamTexture;
			// void glEndVideoCaptureNV (GLuint video_capture_slot)
			public readonly EndVideoCaptureDelegate EndVideoCapture;
			// void glGetVideoCaptureivNV (GLuint video_capture_slot, GLenum pname, GLint* params)
			public readonly GetVideoCaptureivDelegate GetVideoCaptureiv;
			// void glGetVideoCaptureStreamdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params)
			public readonly GetVideoCaptureStreamdvDelegate GetVideoCaptureStreamdv;
			// void glGetVideoCaptureStreamfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params)
			public readonly GetVideoCaptureStreamfvDelegate GetVideoCaptureStreamfv;
			// void glGetVideoCaptureStreamivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params)
			public readonly GetVideoCaptureStreamivDelegate GetVideoCaptureStreamiv;
			// GLenum glVideoCaptureNV (GLuint video_capture_slot, GLuint* sequence_num, GLuint64EXT* capture_time)
			public readonly VideoCaptureDelegate VideoCapture;
			// void glVideoCaptureStreamParameterdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* params)
			public readonly VideoCaptureStreamParameterdvDelegate VideoCaptureStreamParameterdv;
			// void glVideoCaptureStreamParameterfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* params)
			public readonly VideoCaptureStreamParameterfvDelegate VideoCaptureStreamParameterfv;
			// void glVideoCaptureStreamParameterivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* params)
			public readonly VideoCaptureStreamParameterivDelegate VideoCaptureStreamParameteriv;
			#endregion // commands
			public NvVideoCapture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBeginVideoCaptureNV", out BeginVideoCapture);
				resolver.LoadHandle ("glBindVideoCaptureStreamBufferNV", out BindVideoCaptureStreamBuffer);
				resolver.LoadHandle ("glBindVideoCaptureStreamTextureNV", out BindVideoCaptureStreamTexture);
				resolver.LoadHandle ("glEndVideoCaptureNV", out EndVideoCapture);
				resolver.LoadHandle ("glGetVideoCaptureivNV", out GetVideoCaptureiv);
				resolver.LoadHandle ("glGetVideoCaptureStreamdvNV", out GetVideoCaptureStreamdv);
				resolver.LoadHandle ("glGetVideoCaptureStreamfvNV", out GetVideoCaptureStreamfv);
				resolver.LoadHandle ("glGetVideoCaptureStreamivNV", out GetVideoCaptureStreamiv);
				resolver.LoadHandle ("glVideoCaptureNV", out VideoCapture);
				resolver.LoadHandle ("glVideoCaptureStreamParameterdvNV", out VideoCaptureStreamParameterdv);
				resolver.LoadHandle ("glVideoCaptureStreamParameterfvNV", out VideoCaptureStreamParameterfv);
				resolver.LoadHandle ("glVideoCaptureStreamParameterivNV", out VideoCaptureStreamParameteriv);
			}
		}
		public partial class NvViewportSwizzle
		{
			public enum All
			{
				// GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350
				ViewportSwizzlePositiveX = unchecked((int)37712),
				// GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351
				ViewportSwizzleNegativeX = unchecked((int)37713),
				// GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352
				ViewportSwizzlePositiveY = unchecked((int)37714),
				// GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353
				ViewportSwizzleNegativeY = unchecked((int)37715),
				// GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354
				ViewportSwizzlePositiveZ = unchecked((int)37716),
				// GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355
				ViewportSwizzleNegativeZ = unchecked((int)37717),
				// GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356
				ViewportSwizzlePositiveW = unchecked((int)37718),
				// GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357
				ViewportSwizzleNegativeW = unchecked((int)37719),
				// GL_VIEWPORT_SWIZZLE_X_NV = 0x9358
				ViewportSwizzleX = unchecked((int)37720),
				// GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359
				ViewportSwizzleY = unchecked((int)37721),
				// GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A
				ViewportSwizzleZ = unchecked((int)37722),
				// GL_VIEWPORT_SWIZZLE_W_NV = 0x935B
				ViewportSwizzleW = unchecked((int)37723),
			}
			public const string NAME_STRING = "GL_NV_viewport_swizzle";
			#region command delegates
			// void glViewportSwizzleNV (GLuint index, GLenum swizzlex, GLenum swizzley, GLenum swizzlez, GLenum swizzlew)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ViewportSwizzleDelegate (System.UInt32 index, System.UInt32 swizzlex, System.UInt32 swizzley, System.UInt32 swizzlez, System.UInt32 swizzlew);
			#endregion // command delegates
			#region commands
			// void glViewportSwizzleNV (GLuint index, GLenum swizzlex, GLenum swizzley, GLenum swizzlez, GLenum swizzlew)
			public readonly ViewportSwizzleDelegate ViewportSwizzle;
			#endregion // commands
			public NvViewportSwizzle (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glViewportSwizzleNV", out ViewportSwizzle);
			}
		}
	}
}

