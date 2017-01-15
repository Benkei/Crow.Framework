using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class AtiDrawBuffers
		{
			public enum All
			{
				// GL_MAX_DRAW_BUFFERS_ATI = 0x8824
				MaxDrawBuffers = unchecked((int)34852),
				// GL_DRAW_BUFFER0_ATI = 0x8825
				DrawBuffer0 = unchecked((int)34853),
				// GL_DRAW_BUFFER1_ATI = 0x8826
				DrawBuffer1 = unchecked((int)34854),
				// GL_DRAW_BUFFER2_ATI = 0x8827
				DrawBuffer2 = unchecked((int)34855),
				// GL_DRAW_BUFFER3_ATI = 0x8828
				DrawBuffer3 = unchecked((int)34856),
				// GL_DRAW_BUFFER4_ATI = 0x8829
				DrawBuffer4 = unchecked((int)34857),
				// GL_DRAW_BUFFER5_ATI = 0x882A
				DrawBuffer5 = unchecked((int)34858),
				// GL_DRAW_BUFFER6_ATI = 0x882B
				DrawBuffer6 = unchecked((int)34859),
				// GL_DRAW_BUFFER7_ATI = 0x882C
				DrawBuffer7 = unchecked((int)34860),
				// GL_DRAW_BUFFER8_ATI = 0x882D
				DrawBuffer8 = unchecked((int)34861),
				// GL_DRAW_BUFFER9_ATI = 0x882E
				DrawBuffer9 = unchecked((int)34862),
				// GL_DRAW_BUFFER10_ATI = 0x882F
				DrawBuffer10 = unchecked((int)34863),
				// GL_DRAW_BUFFER11_ATI = 0x8830
				DrawBuffer11 = unchecked((int)34864),
				// GL_DRAW_BUFFER12_ATI = 0x8831
				DrawBuffer12 = unchecked((int)34865),
				// GL_DRAW_BUFFER13_ATI = 0x8832
				DrawBuffer13 = unchecked((int)34866),
				// GL_DRAW_BUFFER14_ATI = 0x8833
				DrawBuffer14 = unchecked((int)34867),
				// GL_DRAW_BUFFER15_ATI = 0x8834
				DrawBuffer15 = unchecked((int)34868),
			}
			public const string NAME_STRING = "GL_ATI_draw_buffers";
			#region command delegates
			// void glDrawBuffersATI (GLsizei n, GLenum* bufs)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawBuffersDelegate (System.Int32 n, IntPtr bufs);
			#endregion // command delegates
			#region commands
			// void glDrawBuffersATI (GLsizei n, GLenum* bufs)
			public readonly DrawBuffersDelegate DrawBuffers;
			#endregion // commands
			public AtiDrawBuffers (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawBuffersATI", out DrawBuffers);
			}
		}
		public partial class AtiElementArray
		{
			public enum All
			{
				// GL_ELEMENT_ARRAY_ATI = 0x8768
				ElementArray = unchecked((int)34664),
				// GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769
				ElementArrayType = unchecked((int)34665),
				// GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A
				ElementArrayPointer = unchecked((int)34666),
			}
			public const string NAME_STRING = "GL_ATI_element_array";
			#region command delegates
			// void glDrawElementArrayATI (GLenum mode, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawElementArrayDelegate (PrimitiveType mode, System.Int32 count);
			// void glDrawRangeElementArrayATI (GLenum mode, GLuint start, GLuint end, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawRangeElementArrayDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, System.Int32 count);
			// void glElementPointerATI (GLenum type, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ElementPointerDelegate (System.UInt32 type, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glDrawElementArrayATI (GLenum mode, GLsizei count)
			public readonly DrawElementArrayDelegate DrawElementArray;
			// void glDrawRangeElementArrayATI (GLenum mode, GLuint start, GLuint end, GLsizei count)
			public readonly DrawRangeElementArrayDelegate DrawRangeElementArray;
			// void glElementPointerATI (GLenum type, void* pointer)
			public readonly ElementPointerDelegate ElementPointer;
			#endregion // commands
			public AtiElementArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawElementArrayATI", out DrawElementArray);
				resolver.LoadHandle ("glDrawRangeElementArrayATI", out DrawRangeElementArray);
				resolver.LoadHandle ("glElementPointerATI", out ElementPointer);
			}
		}
		public partial class AtiEnvmapBumpmap
		{
			public enum All
			{
				// GL_BUMP_ROT_MATRIX_ATI = 0x8775
				BumpRotMatrix = unchecked((int)34677),
				// GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776
				BumpRotMatrixSize = unchecked((int)34678),
				// GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777
				BumpNumTexUnits = unchecked((int)34679),
				// GL_BUMP_TEX_UNITS_ATI = 0x8778
				BumpTexUnits = unchecked((int)34680),
				// GL_DUDV_ATI = 0x8779
				Dudv = unchecked((int)34681),
				// GL_DU8DV8_ATI = 0x877A
				Du8dv8 = unchecked((int)34682),
				// GL_BUMP_ENVMAP_ATI = 0x877B
				BumpEnvmap = unchecked((int)34683),
				// GL_BUMP_TARGET_ATI = 0x877C
				BumpTarget = unchecked((int)34684),
			}
			public const string NAME_STRING = "GL_ATI_envmap_bumpmap";
			#region command delegates
			// void glGetTexBumpParameterfvATI (GLenum pname, GLfloat* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexBumpParameterfvDelegate (System.UInt32 pname, IntPtr param);
			// void glGetTexBumpParameterivATI (GLenum pname, GLint* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexBumpParameterivDelegate (System.UInt32 pname, IntPtr param);
			// void glTexBumpParameterfvATI (GLenum pname, GLfloat* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexBumpParameterfvDelegate (System.UInt32 pname, IntPtr param);
			// void glTexBumpParameterivATI (GLenum pname, GLint* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexBumpParameterivDelegate (System.UInt32 pname, IntPtr param);
			#endregion // command delegates
			#region commands
			// void glGetTexBumpParameterfvATI (GLenum pname, GLfloat* param)
			public readonly GetTexBumpParameterfvDelegate GetTexBumpParameterfv;
			// void glGetTexBumpParameterivATI (GLenum pname, GLint* param)
			public readonly GetTexBumpParameterivDelegate GetTexBumpParameteriv;
			// void glTexBumpParameterfvATI (GLenum pname, GLfloat* param)
			public readonly TexBumpParameterfvDelegate TexBumpParameterfv;
			// void glTexBumpParameterivATI (GLenum pname, GLint* param)
			public readonly TexBumpParameterivDelegate TexBumpParameteriv;
			#endregion // commands
			public AtiEnvmapBumpmap (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetTexBumpParameterfvATI", out GetTexBumpParameterfv);
				resolver.LoadHandle ("glGetTexBumpParameterivATI", out GetTexBumpParameteriv);
				resolver.LoadHandle ("glTexBumpParameterfvATI", out TexBumpParameterfv);
				resolver.LoadHandle ("glTexBumpParameterivATI", out TexBumpParameteriv);
			}
		}
		public partial class AtiFragmentShader
		{
			public enum All
			{
				// GL_2X_BIT_ATI = 0x1
				_2xBit = unchecked((int)1),
				// GL_RED_BIT_ATI = 0x1
				RedBit = unchecked((int)1),
				// GL_4X_BIT_ATI = 0x2
				_4xBit = unchecked((int)2),
				// GL_COMP_BIT_ATI = 0x2
				CompBit = unchecked((int)2),
				// GL_GREEN_BIT_ATI = 0x2
				GreenBit = unchecked((int)2),
				// GL_8X_BIT_ATI = 0x4
				_8xBit = unchecked((int)4),
				// GL_BLUE_BIT_ATI = 0x4
				BlueBit = unchecked((int)4),
				// GL_NEGATE_BIT_ATI = 0x4
				NegateBit = unchecked((int)4),
				// GL_BIAS_BIT_ATI = 0x8
				BiasBit = unchecked((int)8),
				// GL_HALF_BIT_ATI = 0x8
				HalfBit = unchecked((int)8),
				// GL_QUARTER_BIT_ATI = 0x10
				QuarterBit = unchecked((int)16),
				// GL_EIGHTH_BIT_ATI = 0x20
				EighthBit = unchecked((int)32),
				// GL_SATURATE_BIT_ATI = 0x40
				SaturateBit = unchecked((int)64),
				// GL_FRAGMENT_SHADER_ATI = 0x8920
				FragmentShader = unchecked((int)35104),
				// GL_REG_0_ATI = 0x8921
				Reg0 = unchecked((int)35105),
				// GL_REG_1_ATI = 0x8922
				Reg1 = unchecked((int)35106),
				// GL_REG_2_ATI = 0x8923
				Reg2 = unchecked((int)35107),
				// GL_REG_3_ATI = 0x8924
				Reg3 = unchecked((int)35108),
				// GL_REG_4_ATI = 0x8925
				Reg4 = unchecked((int)35109),
				// GL_REG_5_ATI = 0x8926
				Reg5 = unchecked((int)35110),
				// GL_REG_6_ATI = 0x8927
				Reg6 = unchecked((int)35111),
				// GL_REG_7_ATI = 0x8928
				Reg7 = unchecked((int)35112),
				// GL_REG_8_ATI = 0x8929
				Reg8 = unchecked((int)35113),
				// GL_REG_9_ATI = 0x892A
				Reg9 = unchecked((int)35114),
				// GL_REG_10_ATI = 0x892B
				Reg10 = unchecked((int)35115),
				// GL_REG_11_ATI = 0x892C
				Reg11 = unchecked((int)35116),
				// GL_REG_12_ATI = 0x892D
				Reg12 = unchecked((int)35117),
				// GL_REG_13_ATI = 0x892E
				Reg13 = unchecked((int)35118),
				// GL_REG_14_ATI = 0x892F
				Reg14 = unchecked((int)35119),
				// GL_REG_15_ATI = 0x8930
				Reg15 = unchecked((int)35120),
				// GL_REG_16_ATI = 0x8931
				Reg16 = unchecked((int)35121),
				// GL_REG_17_ATI = 0x8932
				Reg17 = unchecked((int)35122),
				// GL_REG_18_ATI = 0x8933
				Reg18 = unchecked((int)35123),
				// GL_REG_19_ATI = 0x8934
				Reg19 = unchecked((int)35124),
				// GL_REG_20_ATI = 0x8935
				Reg20 = unchecked((int)35125),
				// GL_REG_21_ATI = 0x8936
				Reg21 = unchecked((int)35126),
				// GL_REG_22_ATI = 0x8937
				Reg22 = unchecked((int)35127),
				// GL_REG_23_ATI = 0x8938
				Reg23 = unchecked((int)35128),
				// GL_REG_24_ATI = 0x8939
				Reg24 = unchecked((int)35129),
				// GL_REG_25_ATI = 0x893A
				Reg25 = unchecked((int)35130),
				// GL_REG_26_ATI = 0x893B
				Reg26 = unchecked((int)35131),
				// GL_REG_27_ATI = 0x893C
				Reg27 = unchecked((int)35132),
				// GL_REG_28_ATI = 0x893D
				Reg28 = unchecked((int)35133),
				// GL_REG_29_ATI = 0x893E
				Reg29 = unchecked((int)35134),
				// GL_REG_30_ATI = 0x893F
				Reg30 = unchecked((int)35135),
				// GL_REG_31_ATI = 0x8940
				Reg31 = unchecked((int)35136),
				// GL_CON_0_ATI = 0x8941
				Con0 = unchecked((int)35137),
				// GL_CON_1_ATI = 0x8942
				Con1 = unchecked((int)35138),
				// GL_CON_2_ATI = 0x8943
				Con2 = unchecked((int)35139),
				// GL_CON_3_ATI = 0x8944
				Con3 = unchecked((int)35140),
				// GL_CON_4_ATI = 0x8945
				Con4 = unchecked((int)35141),
				// GL_CON_5_ATI = 0x8946
				Con5 = unchecked((int)35142),
				// GL_CON_6_ATI = 0x8947
				Con6 = unchecked((int)35143),
				// GL_CON_7_ATI = 0x8948
				Con7 = unchecked((int)35144),
				// GL_CON_8_ATI = 0x8949
				Con8 = unchecked((int)35145),
				// GL_CON_9_ATI = 0x894A
				Con9 = unchecked((int)35146),
				// GL_CON_10_ATI = 0x894B
				Con10 = unchecked((int)35147),
				// GL_CON_11_ATI = 0x894C
				Con11 = unchecked((int)35148),
				// GL_CON_12_ATI = 0x894D
				Con12 = unchecked((int)35149),
				// GL_CON_13_ATI = 0x894E
				Con13 = unchecked((int)35150),
				// GL_CON_14_ATI = 0x894F
				Con14 = unchecked((int)35151),
				// GL_CON_15_ATI = 0x8950
				Con15 = unchecked((int)35152),
				// GL_CON_16_ATI = 0x8951
				Con16 = unchecked((int)35153),
				// GL_CON_17_ATI = 0x8952
				Con17 = unchecked((int)35154),
				// GL_CON_18_ATI = 0x8953
				Con18 = unchecked((int)35155),
				// GL_CON_19_ATI = 0x8954
				Con19 = unchecked((int)35156),
				// GL_CON_20_ATI = 0x8955
				Con20 = unchecked((int)35157),
				// GL_CON_21_ATI = 0x8956
				Con21 = unchecked((int)35158),
				// GL_CON_22_ATI = 0x8957
				Con22 = unchecked((int)35159),
				// GL_CON_23_ATI = 0x8958
				Con23 = unchecked((int)35160),
				// GL_CON_24_ATI = 0x8959
				Con24 = unchecked((int)35161),
				// GL_CON_25_ATI = 0x895A
				Con25 = unchecked((int)35162),
				// GL_CON_26_ATI = 0x895B
				Con26 = unchecked((int)35163),
				// GL_CON_27_ATI = 0x895C
				Con27 = unchecked((int)35164),
				// GL_CON_28_ATI = 0x895D
				Con28 = unchecked((int)35165),
				// GL_CON_29_ATI = 0x895E
				Con29 = unchecked((int)35166),
				// GL_CON_30_ATI = 0x895F
				Con30 = unchecked((int)35167),
				// GL_CON_31_ATI = 0x8960
				Con31 = unchecked((int)35168),
				// GL_MOV_ATI = 0x8961
				Mov = unchecked((int)35169),
				// GL_ADD_ATI = 0x8963
				Add = unchecked((int)35171),
				// GL_MUL_ATI = 0x8964
				Mul = unchecked((int)35172),
				// GL_SUB_ATI = 0x8965
				Sub = unchecked((int)35173),
				// GL_DOT3_ATI = 0x8966
				Dot3 = unchecked((int)35174),
				// GL_DOT4_ATI = 0x8967
				Dot4 = unchecked((int)35175),
				// GL_MAD_ATI = 0x8968
				Mad = unchecked((int)35176),
				// GL_LERP_ATI = 0x8969
				Lerp = unchecked((int)35177),
				// GL_CND_ATI = 0x896A
				Cnd = unchecked((int)35178),
				// GL_CND0_ATI = 0x896B
				Cnd0 = unchecked((int)35179),
				// GL_DOT2_ADD_ATI = 0x896C
				Dot2Add = unchecked((int)35180),
				// GL_SECONDARY_INTERPOLATOR_ATI = 0x896D
				SecondaryInterpolator = unchecked((int)35181),
				// GL_NUM_FRAGMENT_REGISTERS_ATI = 0x896E
				NumFragmentRegisters = unchecked((int)35182),
				// GL_NUM_FRAGMENT_CONSTANTS_ATI = 0x896F
				NumFragmentConstants = unchecked((int)35183),
				// GL_NUM_PASSES_ATI = 0x8970
				NumPasses = unchecked((int)35184),
				// GL_NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971
				NumInstructionsPerPass = unchecked((int)35185),
				// GL_NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972
				NumInstructionsTotal = unchecked((int)35186),
				// GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973
				NumInputInterpolatorComponents = unchecked((int)35187),
				// GL_NUM_LOOPBACK_COMPONENTS_ATI = 0x8974
				NumLoopbackComponents = unchecked((int)35188),
				// GL_COLOR_ALPHA_PAIRING_ATI = 0x8975
				ColorAlphaPairing = unchecked((int)35189),
				// GL_SWIZZLE_STR_ATI = 0x8976
				SwizzleStr = unchecked((int)35190),
				// GL_SWIZZLE_STQ_ATI = 0x8977
				SwizzleStq = unchecked((int)35191),
				// GL_SWIZZLE_STR_DR_ATI = 0x8978
				SwizzleStrDr = unchecked((int)35192),
				// GL_SWIZZLE_STQ_DQ_ATI = 0x8979
				SwizzleStqDq = unchecked((int)35193),
				// GL_SWIZZLE_STRQ_ATI = 0x897A
				SwizzleStrq = unchecked((int)35194),
				// GL_SWIZZLE_STRQ_DQ_ATI = 0x897B
				SwizzleStrqDq = unchecked((int)35195),
			}
			public const string NAME_STRING = "GL_ATI_fragment_shader";
			#region command delegates
			// void glAlphaFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AlphaFragmentOp1Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod);
			// void glAlphaFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AlphaFragmentOp2Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod, System.UInt32 arg2, System.UInt32 arg2Rep, System.UInt32 arg2Mod);
			// void glAlphaFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AlphaFragmentOp3Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod, System.UInt32 arg2, System.UInt32 arg2Rep, System.UInt32 arg2Mod, System.UInt32 arg3, System.UInt32 arg3Rep, System.UInt32 arg3Mod);
			// void glBeginFragmentShaderATI ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BeginFragmentShaderDelegate ();
			// void glBindFragmentShaderATI (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindFragmentShaderDelegate (System.UInt32 id);
			// void glColorFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorFragmentOp1Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMask, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod);
			// void glColorFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorFragmentOp2Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMask, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod, System.UInt32 arg2, System.UInt32 arg2Rep, System.UInt32 arg2Mod);
			// void glColorFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorFragmentOp3Delegate (System.UInt32 op, System.UInt32 dst, System.UInt32 dstMask, System.UInt32 dstMod, System.UInt32 arg1, System.UInt32 arg1Rep, System.UInt32 arg1Mod, System.UInt32 arg2, System.UInt32 arg2Rep, System.UInt32 arg2Mod, System.UInt32 arg3, System.UInt32 arg3Rep, System.UInt32 arg3Mod);
			// void glDeleteFragmentShaderATI (GLuint id)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteFragmentShaderDelegate (System.UInt32 id);
			// void glEndFragmentShaderATI ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EndFragmentShaderDelegate ();
			// GLuint glGenFragmentShadersATI (GLuint range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GenFragmentShadersDelegate (System.UInt32 range);
			// void glPassTexCoordATI (GLuint dst, GLuint coord, GLenum swizzle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PassTexCoordDelegate (System.UInt32 dst, System.UInt32 coord, System.UInt32 swizzle);
			// void glSampleMapATI (GLuint dst, GLuint interp, GLenum swizzle)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SampleMapDelegate (System.UInt32 dst, System.UInt32 interp, System.UInt32 swizzle);
			// void glSetFragmentShaderConstantATI (GLuint dst, GLfloat* value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetFragmentShaderConstantDelegate (System.UInt32 dst, IntPtr value);
			#endregion // command delegates
			#region commands
			// void glAlphaFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
			public readonly AlphaFragmentOp1Delegate AlphaFragmentOp1;
			// void glAlphaFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
			public readonly AlphaFragmentOp2Delegate AlphaFragmentOp2;
			// void glAlphaFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
			public readonly AlphaFragmentOp3Delegate AlphaFragmentOp3;
			// void glBeginFragmentShaderATI ()
			public readonly BeginFragmentShaderDelegate BeginFragmentShader;
			// void glBindFragmentShaderATI (GLuint id)
			public readonly BindFragmentShaderDelegate BindFragmentShader;
			// void glColorFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
			public readonly ColorFragmentOp1Delegate ColorFragmentOp1;
			// void glColorFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
			public readonly ColorFragmentOp2Delegate ColorFragmentOp2;
			// void glColorFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
			public readonly ColorFragmentOp3Delegate ColorFragmentOp3;
			// void glDeleteFragmentShaderATI (GLuint id)
			public readonly DeleteFragmentShaderDelegate DeleteFragmentShader;
			// void glEndFragmentShaderATI ()
			public readonly EndFragmentShaderDelegate EndFragmentShader;
			// GLuint glGenFragmentShadersATI (GLuint range)
			public readonly GenFragmentShadersDelegate GenFragmentShaders;
			// void glPassTexCoordATI (GLuint dst, GLuint coord, GLenum swizzle)
			public readonly PassTexCoordDelegate PassTexCoord;
			// void glSampleMapATI (GLuint dst, GLuint interp, GLenum swizzle)
			public readonly SampleMapDelegate SampleMap;
			// void glSetFragmentShaderConstantATI (GLuint dst, GLfloat* value)
			public readonly SetFragmentShaderConstantDelegate SetFragmentShaderConstant;
			#endregion // commands
			public AtiFragmentShader (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAlphaFragmentOp1ATI", out AlphaFragmentOp1);
				resolver.LoadHandle ("glAlphaFragmentOp2ATI", out AlphaFragmentOp2);
				resolver.LoadHandle ("glAlphaFragmentOp3ATI", out AlphaFragmentOp3);
				resolver.LoadHandle ("glBeginFragmentShaderATI", out BeginFragmentShader);
				resolver.LoadHandle ("glBindFragmentShaderATI", out BindFragmentShader);
				resolver.LoadHandle ("glColorFragmentOp1ATI", out ColorFragmentOp1);
				resolver.LoadHandle ("glColorFragmentOp2ATI", out ColorFragmentOp2);
				resolver.LoadHandle ("glColorFragmentOp3ATI", out ColorFragmentOp3);
				resolver.LoadHandle ("glDeleteFragmentShaderATI", out DeleteFragmentShader);
				resolver.LoadHandle ("glEndFragmentShaderATI", out EndFragmentShader);
				resolver.LoadHandle ("glGenFragmentShadersATI", out GenFragmentShaders);
				resolver.LoadHandle ("glPassTexCoordATI", out PassTexCoord);
				resolver.LoadHandle ("glSampleMapATI", out SampleMap);
				resolver.LoadHandle ("glSetFragmentShaderConstantATI", out SetFragmentShaderConstant);
			}
		}
		public partial class AtiMapObjectBuffer
		{
			public const string NAME_STRING = "GL_ATI_map_object_buffer";
			#region command delegates
			// void* glMapObjectBufferATI (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate IntPtr MapObjectBufferDelegate (System.UInt32 buffer);
			// void glUnmapObjectBufferATI (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UnmapObjectBufferDelegate (System.UInt32 buffer);
			#endregion // command delegates
			#region commands
			// void* glMapObjectBufferATI (GLuint buffer)
			public readonly MapObjectBufferDelegate MapObjectBuffer;
			// void glUnmapObjectBufferATI (GLuint buffer)
			public readonly UnmapObjectBufferDelegate UnmapObjectBuffer;
			#endregion // commands
			public AtiMapObjectBuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMapObjectBufferATI", out MapObjectBuffer);
				resolver.LoadHandle ("glUnmapObjectBufferATI", out UnmapObjectBuffer);
			}
		}
		public partial class AtiMeminfo
		{
			public enum All
			{
				// GL_VBO_FREE_MEMORY_ATI = 0x87FB
				VboFreeMemory = unchecked((int)34811),
				// GL_TEXTURE_FREE_MEMORY_ATI = 0x87FC
				TextureFreeMemory = unchecked((int)34812),
				// GL_RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD
				RenderbufferFreeMemory = unchecked((int)34813),
			}
			public const string NAME_STRING = "GL_ATI_meminfo";
		}
		public partial class AtiPixelFormatFloat
		{
			public enum All
			{
				// GL_RGBA_FLOAT_MODE_ATI = 0x8820
				RgbaFloatMode = unchecked((int)34848),
				// GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835
				ColorClearUnclampedValue = unchecked((int)34869),
			}
			public const string NAME_STRING = "GL_ATI_pixel_format_float";
		}
		public partial class AtiPnTriangles
		{
			public enum All
			{
				// GL_PN_TRIANGLES_ATI = 0x87F0
				PnTriangles = unchecked((int)34800),
				// GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1
				MaxPnTrianglesTesselationLevel = unchecked((int)34801),
				// GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2
				PnTrianglesPointMode = unchecked((int)34802),
				// GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3
				PnTrianglesNormalMode = unchecked((int)34803),
				// GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4
				PnTrianglesTesselationLevel = unchecked((int)34804),
				// GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5
				PnTrianglesPointModeLinear = unchecked((int)34805),
				// GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6
				PnTrianglesPointModeCubic = unchecked((int)34806),
				// GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7
				PnTrianglesNormalModeLinear = unchecked((int)34807),
				// GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8
				PnTrianglesNormalModeQuadratic = unchecked((int)34808),
			}
			public const string NAME_STRING = "GL_ATI_pn_triangles";
			#region command delegates
			// void glPNTrianglesfATI (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PNTrianglesfDelegate (System.UInt32 pname, System.Single param);
			// void glPNTrianglesiATI (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PNTrianglesiDelegate (System.UInt32 pname, System.Int32 param);
			#endregion // command delegates
			#region commands
			// void glPNTrianglesfATI (GLenum pname, GLfloat param)
			public readonly PNTrianglesfDelegate PNTrianglesf;
			// void glPNTrianglesiATI (GLenum pname, GLint param)
			public readonly PNTrianglesiDelegate PNTrianglesi;
			#endregion // commands
			public AtiPnTriangles (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPNTrianglesfATI", out PNTrianglesf);
				resolver.LoadHandle ("glPNTrianglesiATI", out PNTrianglesi);
			}
		}
		public partial class AtiSeparateStencil
		{
			public enum All
			{
				// GL_STENCIL_BACK_FUNC_ATI = 0x8800
				StencilBackFunc = unchecked((int)34816),
				// GL_STENCIL_BACK_FAIL_ATI = 0x8801
				StencilBackFail = unchecked((int)34817),
				// GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802
				StencilBackPassDepthFail = unchecked((int)34818),
				// GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803
				StencilBackPassDepthPass = unchecked((int)34819),
			}
			public const string NAME_STRING = "GL_ATI_separate_stencil";
			#region command delegates
			// void glStencilFuncSeparateATI (GLenum frontfunc, GLenum backfunc, GLint ref, GLuint mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilFuncSeparateDelegate (StencilFunction frontfunc, StencilFunction backfunc, System.Int32 @ref, System.UInt32 mask);
			// void glStencilOpSeparateATI (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StencilOpSeparateDelegate (System.UInt32 face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
			#endregion // command delegates
			#region commands
			// void glStencilFuncSeparateATI (GLenum frontfunc, GLenum backfunc, GLint ref, GLuint mask)
			public readonly StencilFuncSeparateDelegate StencilFuncSeparate;
			// void glStencilOpSeparateATI (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
			public readonly StencilOpSeparateDelegate StencilOpSeparate;
			#endregion // commands
			public AtiSeparateStencil (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glStencilFuncSeparateATI", out StencilFuncSeparate);
				resolver.LoadHandle ("glStencilOpSeparateATI", out StencilOpSeparate);
			}
		}
		public partial class AtiTextFragmentShader
		{
			public enum All
			{
				// GL_TEXT_FRAGMENT_SHADER_ATI = 0x8200
				TextFragmentShader = unchecked((int)33280),
			}
			public const string NAME_STRING = "GL_ATI_text_fragment_shader";
		}
		public partial class AtiTextureEnvCombine3
		{
			public enum All
			{
				// GL_MODULATE_ADD_ATI = 0x8744
				ModulateAdd = unchecked((int)34628),
				// GL_MODULATE_SIGNED_ADD_ATI = 0x8745
				ModulateSignedAdd = unchecked((int)34629),
				// GL_MODULATE_SUBTRACT_ATI = 0x8746
				ModulateSubtract = unchecked((int)34630),
			}
			public const string NAME_STRING = "GL_ATI_texture_env_combine3";
		}
		public partial class AtiTextureFloat
		{
			public enum All
			{
				// GL_RGBA_FLOAT32_ATI = 0x8814
				RgbaFloat32 = unchecked((int)34836),
				// GL_RGB_FLOAT32_ATI = 0x8815
				RgbFloat32 = unchecked((int)34837),
				// GL_ALPHA_FLOAT32_ATI = 0x8816
				AlphaFloat32 = unchecked((int)34838),
				// GL_INTENSITY_FLOAT32_ATI = 0x8817
				IntensityFloat32 = unchecked((int)34839),
				// GL_LUMINANCE_FLOAT32_ATI = 0x8818
				LuminanceFloat32 = unchecked((int)34840),
				// GL_LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819
				LuminanceAlphaFloat32 = unchecked((int)34841),
				// GL_RGBA_FLOAT16_ATI = 0x881A
				RgbaFloat16 = unchecked((int)34842),
				// GL_RGB_FLOAT16_ATI = 0x881B
				RgbFloat16 = unchecked((int)34843),
				// GL_ALPHA_FLOAT16_ATI = 0x881C
				AlphaFloat16 = unchecked((int)34844),
				// GL_INTENSITY_FLOAT16_ATI = 0x881D
				IntensityFloat16 = unchecked((int)34845),
				// GL_LUMINANCE_FLOAT16_ATI = 0x881E
				LuminanceFloat16 = unchecked((int)34846),
				// GL_LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F
				LuminanceAlphaFloat16 = unchecked((int)34847),
			}
			public const string NAME_STRING = "GL_ATI_texture_float";
		}
		public partial class AtiTextureMirrorOnce
		{
			public enum All
			{
				// GL_MIRROR_CLAMP_ATI = 0x8742
				MirrorClamp = unchecked((int)34626),
				// GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743
				MirrorClampToEdge = unchecked((int)34627),
			}
			public const string NAME_STRING = "GL_ATI_texture_mirror_once";
		}
		public partial class AtiVertexArrayObject
		{
			public enum All
			{
				// GL_STATIC_ATI = 0x8760
				Static = unchecked((int)34656),
				// GL_DYNAMIC_ATI = 0x8761
				Dynamic = unchecked((int)34657),
				// GL_PRESERVE_ATI = 0x8762
				Preserve = unchecked((int)34658),
				// GL_DISCARD_ATI = 0x8763
				Discard = unchecked((int)34659),
				// GL_OBJECT_BUFFER_SIZE_ATI = 0x8764
				ObjectBufferSize = unchecked((int)34660),
				// GL_OBJECT_BUFFER_USAGE_ATI = 0x8765
				ObjectBufferUsage = unchecked((int)34661),
				// GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766
				ArrayObjectBuffer = unchecked((int)34662),
				// GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767
				ArrayObjectOffset = unchecked((int)34663),
			}
			public const string NAME_STRING = "GL_ATI_vertex_array_object";
			#region command delegates
			// void glArrayObjectATI (GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ArrayObjectDelegate (EnableCap array, System.Int32 size, System.UInt32 type, System.Int32 stride, System.UInt32 buffer, System.UInt32 offset);
			// void glFreeObjectBufferATI (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FreeObjectBufferDelegate (System.UInt32 buffer);
			// void glGetArrayObjectfvATI (GLenum array, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetArrayObjectfvDelegate (EnableCap array, System.UInt32 pname, IntPtr @params);
			// void glGetArrayObjectivATI (GLenum array, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetArrayObjectivDelegate (EnableCap array, System.UInt32 pname, IntPtr @params);
			// void glGetObjectBufferfvATI (GLuint buffer, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectBufferfvDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
			// void glGetObjectBufferivATI (GLuint buffer, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectBufferivDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
			// void glGetVariantArrayObjectfvATI (GLuint id, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantArrayObjectfvDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// void glGetVariantArrayObjectivATI (GLuint id, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVariantArrayObjectivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
			// GLboolean glIsObjectBufferATI (GLuint buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsObjectBufferDelegate (System.UInt32 buffer);
			// GLuint glNewObjectBufferATI (GLsizei size, void* pointer, GLenum usage)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 NewObjectBufferDelegate (System.Int32 size, IntPtr pointer, System.UInt32 usage);
			// void glUpdateObjectBufferATI (GLuint buffer, GLuint offset, GLsizei size, void* pointer, GLenum preserve)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void UpdateObjectBufferDelegate (System.UInt32 buffer, System.UInt32 offset, System.Int32 size, IntPtr pointer, System.UInt32 preserve);
			// void glVariantArrayObjectATI (GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VariantArrayObjectDelegate (System.UInt32 id, System.UInt32 type, System.Int32 stride, System.UInt32 buffer, System.UInt32 offset);
			#endregion // command delegates
			#region commands
			// void glArrayObjectATI (GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
			public readonly ArrayObjectDelegate ArrayObject;
			// void glFreeObjectBufferATI (GLuint buffer)
			public readonly FreeObjectBufferDelegate FreeObjectBuffer;
			// void glGetArrayObjectfvATI (GLenum array, GLenum pname, GLfloat* params)
			public readonly GetArrayObjectfvDelegate GetArrayObjectfv;
			// void glGetArrayObjectivATI (GLenum array, GLenum pname, GLint* params)
			public readonly GetArrayObjectivDelegate GetArrayObjectiv;
			// void glGetObjectBufferfvATI (GLuint buffer, GLenum pname, GLfloat* params)
			public readonly GetObjectBufferfvDelegate GetObjectBufferfv;
			// void glGetObjectBufferivATI (GLuint buffer, GLenum pname, GLint* params)
			public readonly GetObjectBufferivDelegate GetObjectBufferiv;
			// void glGetVariantArrayObjectfvATI (GLuint id, GLenum pname, GLfloat* params)
			public readonly GetVariantArrayObjectfvDelegate GetVariantArrayObjectfv;
			// void glGetVariantArrayObjectivATI (GLuint id, GLenum pname, GLint* params)
			public readonly GetVariantArrayObjectivDelegate GetVariantArrayObjectiv;
			// GLboolean glIsObjectBufferATI (GLuint buffer)
			public readonly IsObjectBufferDelegate IsObjectBuffer;
			// GLuint glNewObjectBufferATI (GLsizei size, void* pointer, GLenum usage)
			public readonly NewObjectBufferDelegate NewObjectBuffer;
			// void glUpdateObjectBufferATI (GLuint buffer, GLuint offset, GLsizei size, void* pointer, GLenum preserve)
			public readonly UpdateObjectBufferDelegate UpdateObjectBuffer;
			// void glVariantArrayObjectATI (GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
			public readonly VariantArrayObjectDelegate VariantArrayObject;
			#endregion // commands
			public AtiVertexArrayObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glArrayObjectATI", out ArrayObject);
				resolver.LoadHandle ("glFreeObjectBufferATI", out FreeObjectBuffer);
				resolver.LoadHandle ("glGetArrayObjectfvATI", out GetArrayObjectfv);
				resolver.LoadHandle ("glGetArrayObjectivATI", out GetArrayObjectiv);
				resolver.LoadHandle ("glGetObjectBufferfvATI", out GetObjectBufferfv);
				resolver.LoadHandle ("glGetObjectBufferivATI", out GetObjectBufferiv);
				resolver.LoadHandle ("glGetVariantArrayObjectfvATI", out GetVariantArrayObjectfv);
				resolver.LoadHandle ("glGetVariantArrayObjectivATI", out GetVariantArrayObjectiv);
				resolver.LoadHandle ("glIsObjectBufferATI", out IsObjectBuffer);
				resolver.LoadHandle ("glNewObjectBufferATI", out NewObjectBuffer);
				resolver.LoadHandle ("glUpdateObjectBufferATI", out UpdateObjectBuffer);
				resolver.LoadHandle ("glVariantArrayObjectATI", out VariantArrayObject);
			}
		}
		public partial class AtiVertexAttribArrayObject
		{
			public const string NAME_STRING = "GL_ATI_vertex_attrib_array_object";
			#region command delegates
			// void glGetVertexAttribArrayObjectfvATI (GLuint index, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribArrayObjectfvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glGetVertexAttribArrayObjectivATI (GLuint index, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetVertexAttribArrayObjectivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
			// void glVertexAttribArrayObjectATI (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexAttribArrayObjectDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, Boolean normalized, System.Int32 stride, System.UInt32 buffer, System.UInt32 offset);
			#endregion // command delegates
			#region commands
			// void glGetVertexAttribArrayObjectfvATI (GLuint index, GLenum pname, GLfloat* params)
			public readonly GetVertexAttribArrayObjectfvDelegate GetVertexAttribArrayObjectfv;
			// void glGetVertexAttribArrayObjectivATI (GLuint index, GLenum pname, GLint* params)
			public readonly GetVertexAttribArrayObjectivDelegate GetVertexAttribArrayObjectiv;
			// void glVertexAttribArrayObjectATI (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset)
			public readonly VertexAttribArrayObjectDelegate VertexAttribArrayObject;
			#endregion // commands
			public AtiVertexAttribArrayObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetVertexAttribArrayObjectfvATI", out GetVertexAttribArrayObjectfv);
				resolver.LoadHandle ("glGetVertexAttribArrayObjectivATI", out GetVertexAttribArrayObjectiv);
				resolver.LoadHandle ("glVertexAttribArrayObjectATI", out VertexAttribArrayObject);
			}
		}
		public partial class AtiVertexStreams
		{
			public enum All
			{
				// GL_MAX_VERTEX_STREAMS_ATI = 0x876B
				MaxVertexStreams = unchecked((int)34667),
				// GL_VERTEX_STREAM0_ATI = 0x876C
				VertexStream0 = unchecked((int)34668),
				// GL_VERTEX_STREAM1_ATI = 0x876D
				VertexStream1 = unchecked((int)34669),
				// GL_VERTEX_STREAM2_ATI = 0x876E
				VertexStream2 = unchecked((int)34670),
				// GL_VERTEX_STREAM3_ATI = 0x876F
				VertexStream3 = unchecked((int)34671),
				// GL_VERTEX_STREAM4_ATI = 0x8770
				VertexStream4 = unchecked((int)34672),
				// GL_VERTEX_STREAM5_ATI = 0x8771
				VertexStream5 = unchecked((int)34673),
				// GL_VERTEX_STREAM6_ATI = 0x8772
				VertexStream6 = unchecked((int)34674),
				// GL_VERTEX_STREAM7_ATI = 0x8773
				VertexStream7 = unchecked((int)34675),
				// GL_VERTEX_SOURCE_ATI = 0x8774
				VertexSource = unchecked((int)34676),
			}
			public const string NAME_STRING = "GL_ATI_vertex_streams";
			#region command delegates
			// void glClientActiveVertexStreamATI (GLenum stream)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClientActiveVertexStreamDelegate (System.UInt32 stream);
			// void glNormalStream3bATI (GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3bDelegate (System.UInt32 stream, System.SByte nx, System.SByte ny, System.SByte nz);
			// void glNormalStream3bvATI (GLenum stream, GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3bvDelegate (System.UInt32 stream, IntPtr coords);
			// void glNormalStream3dATI (GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3dDelegate (System.UInt32 stream, System.Double nx, System.Double ny, System.Double nz);
			// void glNormalStream3dvATI (GLenum stream, GLdouble* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3dvDelegate (System.UInt32 stream, IntPtr coords);
			// void glNormalStream3fATI (GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3fDelegate (System.UInt32 stream, System.Single nx, System.Single ny, System.Single nz);
			// void glNormalStream3fvATI (GLenum stream, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3fvDelegate (System.UInt32 stream, IntPtr coords);
			// void glNormalStream3iATI (GLenum stream, GLint nx, GLint ny, GLint nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3iDelegate (System.UInt32 stream, System.Int32 nx, System.Int32 ny, System.Int32 nz);
			// void glNormalStream3ivATI (GLenum stream, GLint* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3ivDelegate (System.UInt32 stream, IntPtr coords);
			// void glNormalStream3sATI (GLenum stream, GLshort nx, GLshort ny, GLshort nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3sDelegate (System.UInt32 stream, System.Int16 nx, System.Int16 ny, System.Int16 nz);
			// void glNormalStream3svATI (GLenum stream, GLshort* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalStream3svDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexBlendEnvfATI (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexBlendEnvfDelegate (System.UInt32 pname, System.Single param);
			// void glVertexBlendEnviATI (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexBlendEnviDelegate (System.UInt32 pname, System.Int32 param);
			// void glVertexStream1dATI (GLenum stream, GLdouble x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1dDelegate (System.UInt32 stream, System.Double x);
			// void glVertexStream1dvATI (GLenum stream, GLdouble* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1dvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream1fATI (GLenum stream, GLfloat x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1fDelegate (System.UInt32 stream, System.Single x);
			// void glVertexStream1fvATI (GLenum stream, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1fvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream1iATI (GLenum stream, GLint x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1iDelegate (System.UInt32 stream, System.Int32 x);
			// void glVertexStream1ivATI (GLenum stream, GLint* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1ivDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream1sATI (GLenum stream, GLshort x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1sDelegate (System.UInt32 stream, System.Int16 x);
			// void glVertexStream1svATI (GLenum stream, GLshort* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream1svDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream2dATI (GLenum stream, GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2dDelegate (System.UInt32 stream, System.Double x, System.Double y);
			// void glVertexStream2dvATI (GLenum stream, GLdouble* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2dvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream2fATI (GLenum stream, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2fDelegate (System.UInt32 stream, System.Single x, System.Single y);
			// void glVertexStream2fvATI (GLenum stream, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2fvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream2iATI (GLenum stream, GLint x, GLint y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2iDelegate (System.UInt32 stream, System.Int32 x, System.Int32 y);
			// void glVertexStream2ivATI (GLenum stream, GLint* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2ivDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream2sATI (GLenum stream, GLshort x, GLshort y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2sDelegate (System.UInt32 stream, System.Int16 x, System.Int16 y);
			// void glVertexStream2svATI (GLenum stream, GLshort* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream2svDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream3dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3dDelegate (System.UInt32 stream, System.Double x, System.Double y, System.Double z);
			// void glVertexStream3dvATI (GLenum stream, GLdouble* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3dvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream3fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3fDelegate (System.UInt32 stream, System.Single x, System.Single y, System.Single z);
			// void glVertexStream3fvATI (GLenum stream, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3fvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream3iATI (GLenum stream, GLint x, GLint y, GLint z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3iDelegate (System.UInt32 stream, System.Int32 x, System.Int32 y, System.Int32 z);
			// void glVertexStream3ivATI (GLenum stream, GLint* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3ivDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream3sATI (GLenum stream, GLshort x, GLshort y, GLshort z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3sDelegate (System.UInt32 stream, System.Int16 x, System.Int16 y, System.Int16 z);
			// void glVertexStream3svATI (GLenum stream, GLshort* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream3svDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream4dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4dDelegate (System.UInt32 stream, System.Double x, System.Double y, System.Double z, System.Double w);
			// void glVertexStream4dvATI (GLenum stream, GLdouble* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4dvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream4fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4fDelegate (System.UInt32 stream, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glVertexStream4fvATI (GLenum stream, GLfloat* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4fvDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream4iATI (GLenum stream, GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4iDelegate (System.UInt32 stream, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glVertexStream4ivATI (GLenum stream, GLint* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4ivDelegate (System.UInt32 stream, IntPtr coords);
			// void glVertexStream4sATI (GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4sDelegate (System.UInt32 stream, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w);
			// void glVertexStream4svATI (GLenum stream, GLshort* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexStream4svDelegate (System.UInt32 stream, IntPtr coords);
			#endregion // command delegates
			#region commands
			// void glClientActiveVertexStreamATI (GLenum stream)
			public readonly ClientActiveVertexStreamDelegate ClientActiveVertexStream;
			// void glNormalStream3bATI (GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz)
			public readonly NormalStream3bDelegate NormalStream3b;
			// void glNormalStream3bvATI (GLenum stream, GLbyte* coords)
			public readonly NormalStream3bvDelegate NormalStream3bv;
			// void glNormalStream3dATI (GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz)
			public readonly NormalStream3dDelegate NormalStream3d;
			// void glNormalStream3dvATI (GLenum stream, GLdouble* coords)
			public readonly NormalStream3dvDelegate NormalStream3dv;
			// void glNormalStream3fATI (GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz)
			public readonly NormalStream3fDelegate NormalStream3f;
			// void glNormalStream3fvATI (GLenum stream, GLfloat* coords)
			public readonly NormalStream3fvDelegate NormalStream3fv;
			// void glNormalStream3iATI (GLenum stream, GLint nx, GLint ny, GLint nz)
			public readonly NormalStream3iDelegate NormalStream3i;
			// void glNormalStream3ivATI (GLenum stream, GLint* coords)
			public readonly NormalStream3ivDelegate NormalStream3iv;
			// void glNormalStream3sATI (GLenum stream, GLshort nx, GLshort ny, GLshort nz)
			public readonly NormalStream3sDelegate NormalStream3s;
			// void glNormalStream3svATI (GLenum stream, GLshort* coords)
			public readonly NormalStream3svDelegate NormalStream3sv;
			// void glVertexBlendEnvfATI (GLenum pname, GLfloat param)
			public readonly VertexBlendEnvfDelegate VertexBlendEnvf;
			// void glVertexBlendEnviATI (GLenum pname, GLint param)
			public readonly VertexBlendEnviDelegate VertexBlendEnvi;
			// void glVertexStream1dATI (GLenum stream, GLdouble x)
			public readonly VertexStream1dDelegate VertexStream1d;
			// void glVertexStream1dvATI (GLenum stream, GLdouble* coords)
			public readonly VertexStream1dvDelegate VertexStream1dv;
			// void glVertexStream1fATI (GLenum stream, GLfloat x)
			public readonly VertexStream1fDelegate VertexStream1f;
			// void glVertexStream1fvATI (GLenum stream, GLfloat* coords)
			public readonly VertexStream1fvDelegate VertexStream1fv;
			// void glVertexStream1iATI (GLenum stream, GLint x)
			public readonly VertexStream1iDelegate VertexStream1i;
			// void glVertexStream1ivATI (GLenum stream, GLint* coords)
			public readonly VertexStream1ivDelegate VertexStream1iv;
			// void glVertexStream1sATI (GLenum stream, GLshort x)
			public readonly VertexStream1sDelegate VertexStream1s;
			// void glVertexStream1svATI (GLenum stream, GLshort* coords)
			public readonly VertexStream1svDelegate VertexStream1sv;
			// void glVertexStream2dATI (GLenum stream, GLdouble x, GLdouble y)
			public readonly VertexStream2dDelegate VertexStream2d;
			// void glVertexStream2dvATI (GLenum stream, GLdouble* coords)
			public readonly VertexStream2dvDelegate VertexStream2dv;
			// void glVertexStream2fATI (GLenum stream, GLfloat x, GLfloat y)
			public readonly VertexStream2fDelegate VertexStream2f;
			// void glVertexStream2fvATI (GLenum stream, GLfloat* coords)
			public readonly VertexStream2fvDelegate VertexStream2fv;
			// void glVertexStream2iATI (GLenum stream, GLint x, GLint y)
			public readonly VertexStream2iDelegate VertexStream2i;
			// void glVertexStream2ivATI (GLenum stream, GLint* coords)
			public readonly VertexStream2ivDelegate VertexStream2iv;
			// void glVertexStream2sATI (GLenum stream, GLshort x, GLshort y)
			public readonly VertexStream2sDelegate VertexStream2s;
			// void glVertexStream2svATI (GLenum stream, GLshort* coords)
			public readonly VertexStream2svDelegate VertexStream2sv;
			// void glVertexStream3dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z)
			public readonly VertexStream3dDelegate VertexStream3d;
			// void glVertexStream3dvATI (GLenum stream, GLdouble* coords)
			public readonly VertexStream3dvDelegate VertexStream3dv;
			// void glVertexStream3fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z)
			public readonly VertexStream3fDelegate VertexStream3f;
			// void glVertexStream3fvATI (GLenum stream, GLfloat* coords)
			public readonly VertexStream3fvDelegate VertexStream3fv;
			// void glVertexStream3iATI (GLenum stream, GLint x, GLint y, GLint z)
			public readonly VertexStream3iDelegate VertexStream3i;
			// void glVertexStream3ivATI (GLenum stream, GLint* coords)
			public readonly VertexStream3ivDelegate VertexStream3iv;
			// void glVertexStream3sATI (GLenum stream, GLshort x, GLshort y, GLshort z)
			public readonly VertexStream3sDelegate VertexStream3s;
			// void glVertexStream3svATI (GLenum stream, GLshort* coords)
			public readonly VertexStream3svDelegate VertexStream3sv;
			// void glVertexStream4dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly VertexStream4dDelegate VertexStream4d;
			// void glVertexStream4dvATI (GLenum stream, GLdouble* coords)
			public readonly VertexStream4dvDelegate VertexStream4dv;
			// void glVertexStream4fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly VertexStream4fDelegate VertexStream4f;
			// void glVertexStream4fvATI (GLenum stream, GLfloat* coords)
			public readonly VertexStream4fvDelegate VertexStream4fv;
			// void glVertexStream4iATI (GLenum stream, GLint x, GLint y, GLint z, GLint w)
			public readonly VertexStream4iDelegate VertexStream4i;
			// void glVertexStream4ivATI (GLenum stream, GLint* coords)
			public readonly VertexStream4ivDelegate VertexStream4iv;
			// void glVertexStream4sATI (GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w)
			public readonly VertexStream4sDelegate VertexStream4s;
			// void glVertexStream4svATI (GLenum stream, GLshort* coords)
			public readonly VertexStream4svDelegate VertexStream4sv;
			#endregion // commands
			public AtiVertexStreams (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glClientActiveVertexStreamATI", out ClientActiveVertexStream);
				resolver.LoadHandle ("glNormalStream3bATI", out NormalStream3b);
				resolver.LoadHandle ("glNormalStream3bvATI", out NormalStream3bv);
				resolver.LoadHandle ("glNormalStream3dATI", out NormalStream3d);
				resolver.LoadHandle ("glNormalStream3dvATI", out NormalStream3dv);
				resolver.LoadHandle ("glNormalStream3fATI", out NormalStream3f);
				resolver.LoadHandle ("glNormalStream3fvATI", out NormalStream3fv);
				resolver.LoadHandle ("glNormalStream3iATI", out NormalStream3i);
				resolver.LoadHandle ("glNormalStream3ivATI", out NormalStream3iv);
				resolver.LoadHandle ("glNormalStream3sATI", out NormalStream3s);
				resolver.LoadHandle ("glNormalStream3svATI", out NormalStream3sv);
				resolver.LoadHandle ("glVertexBlendEnvfATI", out VertexBlendEnvf);
				resolver.LoadHandle ("glVertexBlendEnviATI", out VertexBlendEnvi);
				resolver.LoadHandle ("glVertexStream1dATI", out VertexStream1d);
				resolver.LoadHandle ("glVertexStream1dvATI", out VertexStream1dv);
				resolver.LoadHandle ("glVertexStream1fATI", out VertexStream1f);
				resolver.LoadHandle ("glVertexStream1fvATI", out VertexStream1fv);
				resolver.LoadHandle ("glVertexStream1iATI", out VertexStream1i);
				resolver.LoadHandle ("glVertexStream1ivATI", out VertexStream1iv);
				resolver.LoadHandle ("glVertexStream1sATI", out VertexStream1s);
				resolver.LoadHandle ("glVertexStream1svATI", out VertexStream1sv);
				resolver.LoadHandle ("glVertexStream2dATI", out VertexStream2d);
				resolver.LoadHandle ("glVertexStream2dvATI", out VertexStream2dv);
				resolver.LoadHandle ("glVertexStream2fATI", out VertexStream2f);
				resolver.LoadHandle ("glVertexStream2fvATI", out VertexStream2fv);
				resolver.LoadHandle ("glVertexStream2iATI", out VertexStream2i);
				resolver.LoadHandle ("glVertexStream2ivATI", out VertexStream2iv);
				resolver.LoadHandle ("glVertexStream2sATI", out VertexStream2s);
				resolver.LoadHandle ("glVertexStream2svATI", out VertexStream2sv);
				resolver.LoadHandle ("glVertexStream3dATI", out VertexStream3d);
				resolver.LoadHandle ("glVertexStream3dvATI", out VertexStream3dv);
				resolver.LoadHandle ("glVertexStream3fATI", out VertexStream3f);
				resolver.LoadHandle ("glVertexStream3fvATI", out VertexStream3fv);
				resolver.LoadHandle ("glVertexStream3iATI", out VertexStream3i);
				resolver.LoadHandle ("glVertexStream3ivATI", out VertexStream3iv);
				resolver.LoadHandle ("glVertexStream3sATI", out VertexStream3s);
				resolver.LoadHandle ("glVertexStream3svATI", out VertexStream3sv);
				resolver.LoadHandle ("glVertexStream4dATI", out VertexStream4d);
				resolver.LoadHandle ("glVertexStream4dvATI", out VertexStream4dv);
				resolver.LoadHandle ("glVertexStream4fATI", out VertexStream4f);
				resolver.LoadHandle ("glVertexStream4fvATI", out VertexStream4fv);
				resolver.LoadHandle ("glVertexStream4iATI", out VertexStream4i);
				resolver.LoadHandle ("glVertexStream4ivATI", out VertexStream4iv);
				resolver.LoadHandle ("glVertexStream4sATI", out VertexStream4s);
				resolver.LoadHandle ("glVertexStream4svATI", out VertexStream4sv);
			}
		}
	}
}

