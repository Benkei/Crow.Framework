using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class IbmCullVertex
		{
			public enum All
			{
				// GL_CULL_VERTEX_IBM = 0x1928A
				CullVertex = unchecked((int)103050),
			}
			public const string NAME_STRING = "GL_IBM_cull_vertex";
		}
		public partial class IbmMultimodeDrawArrays
		{
			public const string NAME_STRING = "GL_IBM_multimode_draw_arrays";
			#region command delegates
			// void glMultiModeDrawArraysIBM (GLenum* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiModeDrawArraysDelegate (PrimitiveType mode, IntPtr first, IntPtr count, System.Int32 primcount, System.Int32 modestride);
			// void glMultiModeDrawElementsIBM (GLenum* mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint modestride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiModeDrawElementsDelegate (PrimitiveType mode, IntPtr count, System.UInt32 type, IntPtr indices, System.Int32 primcount, System.Int32 modestride);
			#endregion // command delegates
			#region commands
			// void glMultiModeDrawArraysIBM (GLenum* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
			public readonly MultiModeDrawArraysDelegate MultiModeDrawArrays;
			// void glMultiModeDrawElementsIBM (GLenum* mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint modestride)
			public readonly MultiModeDrawElementsDelegate MultiModeDrawElements;
			#endregion // commands
			public IbmMultimodeDrawArrays (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiModeDrawArraysIBM", out MultiModeDrawArrays);
				resolver.LoadHandle ("glMultiModeDrawElementsIBM", out MultiModeDrawElements);
			}
		}
		public partial class IbmRasterposClip
		{
			public enum All
			{
				// GL_RASTER_POSITION_UNCLIPPED_IBM = 0x19262
				RasterPositionUnclipped = unchecked((int)103010),
			}
			public const string NAME_STRING = "GL_IBM_rasterpos_clip";
		}
		public partial class IbmStaticData
		{
			public enum All
			{
				// GL_ALL_STATIC_DATA_IBM = 0x19294
				AllStaticData = unchecked((int)103060),
				// GL_STATIC_VERTEX_ARRAY_IBM = 0x19295
				StaticVertexArray = unchecked((int)103061),
			}
			public const string NAME_STRING = "GL_IBM_static_data";
			#region command delegates
			// void glFlushStaticDataIBM (GLenum target)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushStaticDataDelegate (System.UInt32 target);
			#endregion // command delegates
			#region commands
			// void glFlushStaticDataIBM (GLenum target)
			public readonly FlushStaticDataDelegate FlushStaticData;
			#endregion // commands
			public IbmStaticData (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFlushStaticDataIBM", out FlushStaticData);
			}
		}
		public partial class IbmTextureMirroredRepeat
		{
			public enum All
			{
				// GL_MIRRORED_REPEAT_IBM = 0x8370
				MirroredRepeat = unchecked((int)33648),
			}
			public const string NAME_STRING = "GL_IBM_texture_mirrored_repeat";
		}
		public partial class IbmVertexArrayLists
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_LIST_IBM = 0x1929E
				VertexArrayList = unchecked((int)103070),
				// GL_NORMAL_ARRAY_LIST_IBM = 0x1929F
				NormalArrayList = unchecked((int)103071),
				// GL_COLOR_ARRAY_LIST_IBM = 0x192A0
				ColorArrayList = unchecked((int)103072),
				// GL_INDEX_ARRAY_LIST_IBM = 0x192A1
				IndexArrayList = unchecked((int)103073),
				// GL_TEXTURE_COORD_ARRAY_LIST_IBM = 0x192A2
				TextureCoordArrayList = unchecked((int)103074),
				// GL_EDGE_FLAG_ARRAY_LIST_IBM = 0x192A3
				EdgeFlagArrayList = unchecked((int)103075),
				// GL_FOG_COORDINATE_ARRAY_LIST_IBM = 0x192A4
				FogCoordinateArrayList = unchecked((int)103076),
				// GL_SECONDARY_COLOR_ARRAY_LIST_IBM = 0x192A5
				SecondaryColorArrayList = unchecked((int)103077),
				// GL_VERTEX_ARRAY_LIST_STRIDE_IBM = 0x192A8
				VertexArrayListStride = unchecked((int)103080),
				// GL_NORMAL_ARRAY_LIST_STRIDE_IBM = 0x192A9
				NormalArrayListStride = unchecked((int)103081),
				// GL_COLOR_ARRAY_LIST_STRIDE_IBM = 0x192AA
				ColorArrayListStride = unchecked((int)103082),
				// GL_INDEX_ARRAY_LIST_STRIDE_IBM = 0x192AB
				IndexArrayListStride = unchecked((int)103083),
				// GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 0x192AC
				TextureCoordArrayListStride = unchecked((int)103084),
				// GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 0x192AD
				EdgeFlagArrayListStride = unchecked((int)103085),
				// GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 0x192AE
				FogCoordinateArrayListStride = unchecked((int)103086),
				// GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 0x192AF
				SecondaryColorArrayListStride = unchecked((int)103087),
			}
			public const string NAME_STRING = "GL_IBM_vertex_array_lists";
			#region command delegates
			// void glColorPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ColorPointerListDelegate (System.Int32 size, ColorPointerType type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glEdgeFlagPointerListIBM (GLint stride, GLboolean** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EdgeFlagPointerListDelegate (System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glFogCoordPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogCoordPointerListDelegate (FogPointerTypeIBM type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glIndexPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexPointerListDelegate (IndexPointerType type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glNormalPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void NormalPointerListDelegate (NormalPointerType type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glSecondaryColorPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SecondaryColorPointerListDelegate (System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glTexCoordPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoordPointerListDelegate (System.Int32 size, TexCoordPointerType type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			// void glVertexPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexPointerListDelegate (System.Int32 size, VertexPointerType type, System.Int32 stride, IntPtr pointer, System.Int32 ptrstride);
			#endregion // command delegates
			#region commands
			// void glColorPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly ColorPointerListDelegate ColorPointerList;
			// void glEdgeFlagPointerListIBM (GLint stride, GLboolean** pointer, GLint ptrstride)
			public readonly EdgeFlagPointerListDelegate EdgeFlagPointerList;
			// void glFogCoordPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly FogCoordPointerListDelegate FogCoordPointerList;
			// void glIndexPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly IndexPointerListDelegate IndexPointerList;
			// void glNormalPointerListIBM (GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly NormalPointerListDelegate NormalPointerList;
			// void glSecondaryColorPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly SecondaryColorPointerListDelegate SecondaryColorPointerList;
			// void glTexCoordPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly TexCoordPointerListDelegate TexCoordPointerList;
			// void glVertexPointerListIBM (GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride)
			public readonly VertexPointerListDelegate VertexPointerList;
			#endregion // commands
			public IbmVertexArrayLists (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColorPointerListIBM", out ColorPointerList);
				resolver.LoadHandle ("glEdgeFlagPointerListIBM", out EdgeFlagPointerList);
				resolver.LoadHandle ("glFogCoordPointerListIBM", out FogCoordPointerList);
				resolver.LoadHandle ("glIndexPointerListIBM", out IndexPointerList);
				resolver.LoadHandle ("glNormalPointerListIBM", out NormalPointerList);
				resolver.LoadHandle ("glSecondaryColorPointerListIBM", out SecondaryColorPointerList);
				resolver.LoadHandle ("glTexCoordPointerListIBM", out TexCoordPointerList);
				resolver.LoadHandle ("glVertexPointerListIBM", out VertexPointerList);
			}
		}
	}
}

