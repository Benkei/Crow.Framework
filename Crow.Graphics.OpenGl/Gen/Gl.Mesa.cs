using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class MesaPackInvert
		{
			public enum All
			{
				// GL_PACK_INVERT_MESA = 0x8758
				PackInvert = unchecked((int)34648),
			}
			public const string NAME_STRING = "GL_MESA_pack_invert";
		}
		public partial class MesaResizeBuffers
		{
			public const string NAME_STRING = "GL_MESA_resize_buffers";
			#region command delegates
			// void glResizeBuffersMESA ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ResizeBuffersDelegate ();
			#endregion // command delegates
			#region commands
			// void glResizeBuffersMESA ()
			public readonly ResizeBuffersDelegate ResizeBuffers;
			#endregion // commands
			public MesaResizeBuffers (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glResizeBuffersMESA", out ResizeBuffers);
			}
		}
		public partial class MesaWindowPos
		{
			public const string NAME_STRING = "GL_MESA_window_pos";
			#region command delegates
			// void glWindowPos2dMESA (GLdouble x, GLdouble y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2dDelegate (System.Double x, System.Double y);
			// void glWindowPos2dvMESA (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2dvDelegate (IntPtr v);
			// void glWindowPos2fMESA (GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2fDelegate (System.Single x, System.Single y);
			// void glWindowPos2fvMESA (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2fvDelegate (IntPtr v);
			// void glWindowPos2iMESA (GLint x, GLint y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2iDelegate (System.Int32 x, System.Int32 y);
			// void glWindowPos2ivMESA (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2ivDelegate (IntPtr v);
			// void glWindowPos2sMESA (GLshort x, GLshort y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2sDelegate (System.Int16 x, System.Int16 y);
			// void glWindowPos2svMESA (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos2svDelegate (IntPtr v);
			// void glWindowPos3dMESA (GLdouble x, GLdouble y, GLdouble z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3dDelegate (System.Double x, System.Double y, System.Double z);
			// void glWindowPos3dvMESA (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3dvDelegate (IntPtr v);
			// void glWindowPos3fMESA (GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3fDelegate (System.Single x, System.Single y, System.Single z);
			// void glWindowPos3fvMESA (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3fvDelegate (IntPtr v);
			// void glWindowPos3iMESA (GLint x, GLint y, GLint z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3iDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glWindowPos3ivMESA (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3ivDelegate (IntPtr v);
			// void glWindowPos3sMESA (GLshort x, GLshort y, GLshort z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3sDelegate (System.Int16 x, System.Int16 y, System.Int16 z);
			// void glWindowPos3svMESA (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos3svDelegate (IntPtr v);
			// void glWindowPos4dMESA (GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4dDelegate (System.Double x, System.Double y, System.Double z, System.Double w);
			// void glWindowPos4dvMESA (GLdouble* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4dvDelegate (IntPtr v);
			// void glWindowPos4fMESA (GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4fDelegate (System.Single x, System.Single y, System.Single z, System.Single w);
			// void glWindowPos4fvMESA (GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4fvDelegate (IntPtr v);
			// void glWindowPos4iMESA (GLint x, GLint y, GLint z, GLint w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4iDelegate (System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glWindowPos4ivMESA (GLint* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4ivDelegate (IntPtr v);
			// void glWindowPos4sMESA (GLshort x, GLshort y, GLshort z, GLshort w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4sDelegate (System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w);
			// void glWindowPos4svMESA (GLshort* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void WindowPos4svDelegate (IntPtr v);
			#endregion // command delegates
			#region commands
			// void glWindowPos2dMESA (GLdouble x, GLdouble y)
			public readonly WindowPos2dDelegate WindowPos2d;
			// void glWindowPos2dvMESA (GLdouble* v)
			public readonly WindowPos2dvDelegate WindowPos2dv;
			// void glWindowPos2fMESA (GLfloat x, GLfloat y)
			public readonly WindowPos2fDelegate WindowPos2f;
			// void glWindowPos2fvMESA (GLfloat* v)
			public readonly WindowPos2fvDelegate WindowPos2fv;
			// void glWindowPos2iMESA (GLint x, GLint y)
			public readonly WindowPos2iDelegate WindowPos2i;
			// void glWindowPos2ivMESA (GLint* v)
			public readonly WindowPos2ivDelegate WindowPos2iv;
			// void glWindowPos2sMESA (GLshort x, GLshort y)
			public readonly WindowPos2sDelegate WindowPos2s;
			// void glWindowPos2svMESA (GLshort* v)
			public readonly WindowPos2svDelegate WindowPos2sv;
			// void glWindowPos3dMESA (GLdouble x, GLdouble y, GLdouble z)
			public readonly WindowPos3dDelegate WindowPos3d;
			// void glWindowPos3dvMESA (GLdouble* v)
			public readonly WindowPos3dvDelegate WindowPos3dv;
			// void glWindowPos3fMESA (GLfloat x, GLfloat y, GLfloat z)
			public readonly WindowPos3fDelegate WindowPos3f;
			// void glWindowPos3fvMESA (GLfloat* v)
			public readonly WindowPos3fvDelegate WindowPos3fv;
			// void glWindowPos3iMESA (GLint x, GLint y, GLint z)
			public readonly WindowPos3iDelegate WindowPos3i;
			// void glWindowPos3ivMESA (GLint* v)
			public readonly WindowPos3ivDelegate WindowPos3iv;
			// void glWindowPos3sMESA (GLshort x, GLshort y, GLshort z)
			public readonly WindowPos3sDelegate WindowPos3s;
			// void glWindowPos3svMESA (GLshort* v)
			public readonly WindowPos3svDelegate WindowPos3sv;
			// void glWindowPos4dMESA (GLdouble x, GLdouble y, GLdouble z, GLdouble w)
			public readonly WindowPos4dDelegate WindowPos4d;
			// void glWindowPos4dvMESA (GLdouble* v)
			public readonly WindowPos4dvDelegate WindowPos4dv;
			// void glWindowPos4fMESA (GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly WindowPos4fDelegate WindowPos4f;
			// void glWindowPos4fvMESA (GLfloat* v)
			public readonly WindowPos4fvDelegate WindowPos4fv;
			// void glWindowPos4iMESA (GLint x, GLint y, GLint z, GLint w)
			public readonly WindowPos4iDelegate WindowPos4i;
			// void glWindowPos4ivMESA (GLint* v)
			public readonly WindowPos4ivDelegate WindowPos4iv;
			// void glWindowPos4sMESA (GLshort x, GLshort y, GLshort z, GLshort w)
			public readonly WindowPos4sDelegate WindowPos4s;
			// void glWindowPos4svMESA (GLshort* v)
			public readonly WindowPos4svDelegate WindowPos4sv;
			#endregion // commands
			public MesaWindowPos (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glWindowPos2dMESA", out WindowPos2d);
				resolver.LoadHandle ("glWindowPos2dvMESA", out WindowPos2dv);
				resolver.LoadHandle ("glWindowPos2fMESA", out WindowPos2f);
				resolver.LoadHandle ("glWindowPos2fvMESA", out WindowPos2fv);
				resolver.LoadHandle ("glWindowPos2iMESA", out WindowPos2i);
				resolver.LoadHandle ("glWindowPos2ivMESA", out WindowPos2iv);
				resolver.LoadHandle ("glWindowPos2sMESA", out WindowPos2s);
				resolver.LoadHandle ("glWindowPos2svMESA", out WindowPos2sv);
				resolver.LoadHandle ("glWindowPos3dMESA", out WindowPos3d);
				resolver.LoadHandle ("glWindowPos3dvMESA", out WindowPos3dv);
				resolver.LoadHandle ("glWindowPos3fMESA", out WindowPos3f);
				resolver.LoadHandle ("glWindowPos3fvMESA", out WindowPos3fv);
				resolver.LoadHandle ("glWindowPos3iMESA", out WindowPos3i);
				resolver.LoadHandle ("glWindowPos3ivMESA", out WindowPos3iv);
				resolver.LoadHandle ("glWindowPos3sMESA", out WindowPos3s);
				resolver.LoadHandle ("glWindowPos3svMESA", out WindowPos3sv);
				resolver.LoadHandle ("glWindowPos4dMESA", out WindowPos4d);
				resolver.LoadHandle ("glWindowPos4dvMESA", out WindowPos4dv);
				resolver.LoadHandle ("glWindowPos4fMESA", out WindowPos4f);
				resolver.LoadHandle ("glWindowPos4fvMESA", out WindowPos4fv);
				resolver.LoadHandle ("glWindowPos4iMESA", out WindowPos4i);
				resolver.LoadHandle ("glWindowPos4ivMESA", out WindowPos4iv);
				resolver.LoadHandle ("glWindowPos4sMESA", out WindowPos4s);
				resolver.LoadHandle ("glWindowPos4svMESA", out WindowPos4sv);
			}
		}
		public partial class MesaYcbcrTexture
		{
			public enum All
			{
				// GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA
				UnsignedShort88 = unchecked((int)34234),
				// GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB
				UnsignedShort88Rev = unchecked((int)34235),
				// GL_YCBCR_MESA = 0x8757
				Ycbcr = unchecked((int)34647),
			}
			public const string NAME_STRING = "GL_MESA_ycbcr_texture";
		}
	}
}

