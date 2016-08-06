using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class PgiMiscHints
		{
			public enum All
			{
				// GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
				PreferDoublebufferHint = unchecked((int)107000),
				// GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
				ConserveMemoryHint = unchecked((int)107005),
				// GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
				ReclaimMemoryHint = unchecked((int)107006),
				// GL_NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202
				NativeGraphicsHandle = unchecked((int)107010),
				// GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
				NativeGraphicsBeginHint = unchecked((int)107011),
				// GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
				NativeGraphicsEndHint = unchecked((int)107012),
				// GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
				AlwaysFastHint = unchecked((int)107020),
				// GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
				AlwaysSoftHint = unchecked((int)107021),
				// GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
				AllowDrawObjHint = unchecked((int)107022),
				// GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
				AllowDrawWinHint = unchecked((int)107023),
				// GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
				AllowDrawFrgHint = unchecked((int)107024),
				// GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
				AllowDrawMemHint = unchecked((int)107025),
				// GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
				StrictDepthfuncHint = unchecked((int)107030),
				// GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
				StrictLightingHint = unchecked((int)107031),
				// GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
				StrictScissorHint = unchecked((int)107032),
				// GL_FULL_STIPPLE_HINT_PGI = 0x1A219
				FullStippleHint = unchecked((int)107033),
				// GL_CLIP_NEAR_HINT_PGI = 0x1A220
				ClipNearHint = unchecked((int)107040),
				// GL_CLIP_FAR_HINT_PGI = 0x1A221
				ClipFarHint = unchecked((int)107041),
				// GL_WIDE_LINE_HINT_PGI = 0x1A222
				WideLineHint = unchecked((int)107042),
				// GL_BACK_NORMALS_HINT_PGI = 0x1A223
				BackNormalsHint = unchecked((int)107043),
			}
			public const string NAME_STRING = "GL_PGI_misc_hints";
			#region command delegates
			// void glHintPGI (GLenum target, GLint mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void HintDelegate (System.UInt32 target, System.Int32 mode);
			#endregion // command delegates
			#region commands
			// void glHintPGI (GLenum target, GLint mode)
			public readonly HintDelegate Hint;
			#endregion // commands
			public PgiMiscHints (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glHintPGI", out Hint);
			}
		}
		public partial class PgiVertexHints
		{
			public enum All
			{
				// GL_VERTEX23_BIT_PGI = 0x4
				Vertex23Bit = unchecked((int)4),
				// GL_VERTEX4_BIT_PGI = 0x8
				Vertex4Bit = unchecked((int)8),
				// GL_COLOR3_BIT_PGI = 0x10000
				Color3Bit = unchecked((int)65536),
				// GL_VERTEX_DATA_HINT_PGI = 0x1A22A
				VertexDataHint = unchecked((int)107050),
				// GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
				VertexConsistentHint = unchecked((int)107051),
				// GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
				MaterialSideHint = unchecked((int)107052),
				// GL_MAX_VERTEX_HINT_PGI = 0x1A22D
				MaxVertexHint = unchecked((int)107053),
				// GL_COLOR4_BIT_PGI = 0x20000
				Color4Bit = unchecked((int)131072),
				// GL_EDGEFLAG_BIT_PGI = 0x40000
				EdgeflagBit = unchecked((int)262144),
				// GL_INDEX_BIT_PGI = 0x80000
				IndexBit = unchecked((int)524288),
				// GL_MAT_AMBIENT_BIT_PGI = 0x100000
				MatAmbientBit = unchecked((int)1048576),
				// GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x200000
				MatAmbientAndDiffuseBit = unchecked((int)2097152),
				// GL_MAT_DIFFUSE_BIT_PGI = 0x400000
				MatDiffuseBit = unchecked((int)4194304),
				// GL_MAT_EMISSION_BIT_PGI = 0x800000
				MatEmissionBit = unchecked((int)8388608),
				// GL_MAT_COLOR_INDEXES_BIT_PGI = 0x1000000
				MatColorIndexesBit = unchecked((int)16777216),
				// GL_MAT_SHININESS_BIT_PGI = 0x2000000
				MatShininessBit = unchecked((int)33554432),
				// GL_MAT_SPECULAR_BIT_PGI = 0x4000000
				MatSpecularBit = unchecked((int)67108864),
				// GL_NORMAL_BIT_PGI = 0x8000000
				NormalBit = unchecked((int)134217728),
				// GL_TEXCOORD1_BIT_PGI = 0x10000000
				Texcoord1Bit = unchecked((int)268435456),
				// GL_TEXCOORD2_BIT_PGI = 0x20000000
				Texcoord2Bit = unchecked((int)536870912),
				// GL_TEXCOORD3_BIT_PGI = 0x40000000
				Texcoord3Bit = unchecked((int)1073741824),
				// GL_TEXCOORD4_BIT_PGI = 0x80000000
				Texcoord4Bit = unchecked((int)2147483648),
			}
			public const string NAME_STRING = "GL_PGI_vertex_hints";
		}
	}
}

