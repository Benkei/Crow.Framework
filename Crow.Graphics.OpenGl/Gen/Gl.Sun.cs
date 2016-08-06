using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class SunConvolutionBorderModes
		{
			public enum All
			{
				// GL_WRAP_BORDER_SUN = 0x81D4
				WrapBorder = unchecked((int)33236),
			}
			public const string NAME_STRING = "GL_SUN_convolution_border_modes";
		}
		public partial class SunGlobalAlpha
		{
			public enum All
			{
				// GL_GLOBAL_ALPHA_SUN = 0x81D9
				GlobalAlpha = unchecked((int)33241),
				// GL_GLOBAL_ALPHA_FACTOR_SUN = 0x81DA
				GlobalAlphaFactor = unchecked((int)33242),
			}
			public const string NAME_STRING = "GL_SUN_global_alpha";
			#region command delegates
			// void glGlobalAlphaFactorbSUN (GLbyte factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactorbDelegate (System.SByte factor);
			// void glGlobalAlphaFactordSUN (GLdouble factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactordDelegate (System.Double factor);
			// void glGlobalAlphaFactorfSUN (GLfloat factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactorfDelegate (System.Single factor);
			// void glGlobalAlphaFactoriSUN (GLint factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactoriDelegate (System.Int32 factor);
			// void glGlobalAlphaFactorsSUN (GLshort factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactorsDelegate (System.Int16 factor);
			// void glGlobalAlphaFactorubSUN (GLubyte factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactorubDelegate (System.Byte factor);
			// void glGlobalAlphaFactoruiSUN (GLuint factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactoruiDelegate (System.UInt32 factor);
			// void glGlobalAlphaFactorusSUN (GLushort factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GlobalAlphaFactorusDelegate (System.UInt16 factor);
			#endregion // command delegates
			#region commands
			// void glGlobalAlphaFactorbSUN (GLbyte factor)
			public readonly GlobalAlphaFactorbDelegate GlobalAlphaFactorb;
			// void glGlobalAlphaFactordSUN (GLdouble factor)
			public readonly GlobalAlphaFactordDelegate GlobalAlphaFactord;
			// void glGlobalAlphaFactorfSUN (GLfloat factor)
			public readonly GlobalAlphaFactorfDelegate GlobalAlphaFactorf;
			// void glGlobalAlphaFactoriSUN (GLint factor)
			public readonly GlobalAlphaFactoriDelegate GlobalAlphaFactori;
			// void glGlobalAlphaFactorsSUN (GLshort factor)
			public readonly GlobalAlphaFactorsDelegate GlobalAlphaFactors;
			// void glGlobalAlphaFactorubSUN (GLubyte factor)
			public readonly GlobalAlphaFactorubDelegate GlobalAlphaFactorub;
			// void glGlobalAlphaFactoruiSUN (GLuint factor)
			public readonly GlobalAlphaFactoruiDelegate GlobalAlphaFactorui;
			// void glGlobalAlphaFactorusSUN (GLushort factor)
			public readonly GlobalAlphaFactorusDelegate GlobalAlphaFactorus;
			#endregion // commands
			public SunGlobalAlpha (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGlobalAlphaFactorbSUN", out GlobalAlphaFactorb);
				resolver.LoadHandle ("glGlobalAlphaFactordSUN", out GlobalAlphaFactord);
				resolver.LoadHandle ("glGlobalAlphaFactorfSUN", out GlobalAlphaFactorf);
				resolver.LoadHandle ("glGlobalAlphaFactoriSUN", out GlobalAlphaFactori);
				resolver.LoadHandle ("glGlobalAlphaFactorsSUN", out GlobalAlphaFactors);
				resolver.LoadHandle ("glGlobalAlphaFactorubSUN", out GlobalAlphaFactorub);
				resolver.LoadHandle ("glGlobalAlphaFactoruiSUN", out GlobalAlphaFactorui);
				resolver.LoadHandle ("glGlobalAlphaFactorusSUN", out GlobalAlphaFactorus);
			}
		}
		public partial class SunMeshArray
		{
			public enum All
			{
				// GL_QUAD_MESH_SUN = 0x8614
				QuadMesh = unchecked((int)34324),
				// GL_TRIANGLE_MESH_SUN = 0x8615
				TriangleMesh = unchecked((int)34325),
			}
			public const string NAME_STRING = "GL_SUN_mesh_array";
			#region command delegates
			// void glDrawMeshArraysSUN (GLenum mode, GLint first, GLsizei count, GLsizei width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawMeshArraysDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count, System.Int32 width);
			#endregion // command delegates
			#region commands
			// void glDrawMeshArraysSUN (GLenum mode, GLint first, GLsizei count, GLsizei width)
			public readonly DrawMeshArraysDelegate DrawMeshArrays;
			#endregion // commands
			public SunMeshArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawMeshArraysSUN", out DrawMeshArrays);
			}
		}
		public partial class SunSliceAccum
		{
			public enum All
			{
				// GL_SLICE_ACCUM_SUN = 0x85CC
				SliceAccum = unchecked((int)34252),
			}
			public const string NAME_STRING = "GL_SUN_slice_accum";
		}
		public partial class SunTriangleList
		{
			public enum All
			{
				// GL_RESTART_SUN = 0x1
				Restart = unchecked((int)1),
				// GL_REPLACE_MIDDLE_SUN = 0x2
				ReplaceMiddle = unchecked((int)2),
				// GL_REPLACE_OLDEST_SUN = 0x3
				ReplaceOldest = unchecked((int)3),
				// GL_TRIANGLE_LIST_SUN = 0x81D7
				TriangleList = unchecked((int)33239),
				// GL_REPLACEMENT_CODE_SUN = 0x81D8
				ReplacementCode = unchecked((int)33240),
				// GL_REPLACEMENT_CODE_ARRAY_SUN = 0x85C0
				ReplacementCodeArray = unchecked((int)34240),
				// GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1
				ReplacementCodeArrayType = unchecked((int)34241),
				// GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2
				ReplacementCodeArrayStride = unchecked((int)34242),
				// GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3
				ReplacementCodeArrayPointer = unchecked((int)34243),
				// GL_R1UI_V3F_SUN = 0x85C4
				R1uiV3f = unchecked((int)34244),
				// GL_R1UI_C4UB_V3F_SUN = 0x85C5
				R1uiC4ubV3f = unchecked((int)34245),
				// GL_R1UI_C3F_V3F_SUN = 0x85C6
				R1uiC3fV3f = unchecked((int)34246),
				// GL_R1UI_N3F_V3F_SUN = 0x85C7
				R1uiN3fV3f = unchecked((int)34247),
				// GL_R1UI_C4F_N3F_V3F_SUN = 0x85C8
				R1uiC4fN3fV3f = unchecked((int)34248),
				// GL_R1UI_T2F_V3F_SUN = 0x85C9
				R1uiT2fV3f = unchecked((int)34249),
				// GL_R1UI_T2F_N3F_V3F_SUN = 0x85CA
				R1uiT2fN3fV3f = unchecked((int)34250),
				// GL_R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB
				R1uiT2fC4fN3fV3f = unchecked((int)34251),
			}
			public const string NAME_STRING = "GL_SUN_triangle_list";
			#region command delegates
			// void glReplacementCodePointerSUN (GLenum type, GLsizei stride, void** pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodePointerDelegate (System.UInt32 type, System.Int32 stride, IntPtr pointer);
			// void glReplacementCodeubSUN (GLubyte code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeubDelegate (System.Byte code);
			// void glReplacementCodeubvSUN (GLubyte* code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeubvDelegate (IntPtr code);
			// void glReplacementCodeuiSUN (GLuint code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiDelegate (System.UInt32 code);
			// void glReplacementCodeuivSUN (GLuint* code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuivDelegate (IntPtr code);
			// void glReplacementCodeusSUN (GLushort code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeusDelegate (System.UInt16 code);
			// void glReplacementCodeusvSUN (GLushort* code)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeusvDelegate (IntPtr code);
			#endregion // command delegates
			#region commands
			// void glReplacementCodePointerSUN (GLenum type, GLsizei stride, void** pointer)
			public readonly ReplacementCodePointerDelegate ReplacementCodePointer;
			// void glReplacementCodeubSUN (GLubyte code)
			public readonly ReplacementCodeubDelegate ReplacementCodeub;
			// void glReplacementCodeubvSUN (GLubyte* code)
			public readonly ReplacementCodeubvDelegate ReplacementCodeubv;
			// void glReplacementCodeuiSUN (GLuint code)
			public readonly ReplacementCodeuiDelegate ReplacementCodeui;
			// void glReplacementCodeuivSUN (GLuint* code)
			public readonly ReplacementCodeuivDelegate ReplacementCodeuiv;
			// void glReplacementCodeusSUN (GLushort code)
			public readonly ReplacementCodeusDelegate ReplacementCodeus;
			// void glReplacementCodeusvSUN (GLushort* code)
			public readonly ReplacementCodeusvDelegate ReplacementCodeusv;
			#endregion // commands
			public SunTriangleList (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glReplacementCodePointerSUN", out ReplacementCodePointer);
				resolver.LoadHandle ("glReplacementCodeubSUN", out ReplacementCodeub);
				resolver.LoadHandle ("glReplacementCodeubvSUN", out ReplacementCodeubv);
				resolver.LoadHandle ("glReplacementCodeuiSUN", out ReplacementCodeui);
				resolver.LoadHandle ("glReplacementCodeuivSUN", out ReplacementCodeuiv);
				resolver.LoadHandle ("glReplacementCodeusSUN", out ReplacementCodeus);
				resolver.LoadHandle ("glReplacementCodeusvSUN", out ReplacementCodeusv);
			}
		}
		public partial class SunVertex
		{
			public const string NAME_STRING = "GL_SUN_vertex";
			#region command delegates
			// void glColor3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3fVertex3fDelegate (System.Single r, System.Single g, System.Single b, System.Single x, System.Single y, System.Single z);
			// void glColor3fVertex3fvSUN (GLfloat* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3fVertex3fvDelegate (IntPtr c, IntPtr v);
			// void glColor4fNormal3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4fNormal3fVertex3fDelegate (System.Single r, System.Single g, System.Single b, System.Single a, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glColor4fNormal3fVertex3fvSUN (GLfloat* c, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4fNormal3fVertex3fvDelegate (IntPtr c, IntPtr n, IntPtr v);
			// void glColor4ubVertex2fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4ubVertex2fDelegate (System.Byte r, System.Byte g, System.Byte b, System.Byte a, System.Single x, System.Single y);
			// void glColor4ubVertex2fvSUN (GLubyte* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4ubVertex2fvDelegate (IntPtr c, IntPtr v);
			// void glColor4ubVertex3fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4ubVertex3fDelegate (System.Byte r, System.Byte g, System.Byte b, System.Byte a, System.Single x, System.Single y, System.Single z);
			// void glColor4ubVertex3fvSUN (GLubyte* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4ubVertex3fvDelegate (IntPtr c, IntPtr v);
			// void glNormal3fVertex3fSUN (GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3fVertex3fDelegate (System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glNormal3fVertex3fvSUN (GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3fVertex3fvDelegate (IntPtr n, IntPtr v);
			// void glReplacementCodeuiColor3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor3fVertex3fDelegate (System.UInt32 rc, System.Single r, System.Single g, System.Single b, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiColor3fVertex3fvSUN (GLuint* rc, GLfloat* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor3fVertex3fvDelegate (IntPtr rc, IntPtr c, IntPtr v);
			// void glReplacementCodeuiColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor4fNormal3fVertex3fDelegate (System.UInt32 rc, System.Single r, System.Single g, System.Single b, System.Single a, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiColor4fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor4fNormal3fVertex3fvDelegate (IntPtr rc, IntPtr c, IntPtr n, IntPtr v);
			// void glReplacementCodeuiColor4ubVertex3fSUN (GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor4ubVertex3fDelegate (System.UInt32 rc, System.Byte r, System.Byte g, System.Byte b, System.Byte a, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiColor4ubVertex3fvSUN (GLuint* rc, GLubyte* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiColor4ubVertex3fvDelegate (IntPtr rc, IntPtr c, IntPtr v);
			// void glReplacementCodeuiNormal3fVertex3fSUN (GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiNormal3fVertex3fDelegate (System.UInt32 rc, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiNormal3fVertex3fvSUN (GLuint* rc, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiNormal3fVertex3fvDelegate (IntPtr rc, IntPtr n, IntPtr v);
			// void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fDelegate (System.UInt32 rc, System.Single s, System.Single t, System.Single r, System.Single g, System.Single b, System.Single a, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvDelegate (IntPtr rc, IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
			// void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fDelegate (System.UInt32 rc, System.Single s, System.Single t, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvDelegate (IntPtr rc, IntPtr tc, IntPtr n, IntPtr v);
			// void glReplacementCodeuiTexCoord2fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fVertex3fDelegate (System.UInt32 rc, System.Single s, System.Single t, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiTexCoord2fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiTexCoord2fVertex3fvDelegate (IntPtr rc, IntPtr tc, IntPtr v);
			// void glReplacementCodeuiVertex3fSUN (GLuint rc, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiVertex3fDelegate (System.UInt32 rc, System.Single x, System.Single y, System.Single z);
			// void glReplacementCodeuiVertex3fvSUN (GLuint* rc, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReplacementCodeuiVertex3fvDelegate (IntPtr rc, IntPtr v);
			// void glTexCoord2fColor3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor3fVertex3fDelegate (System.Single s, System.Single t, System.Single r, System.Single g, System.Single b, System.Single x, System.Single y, System.Single z);
			// void glTexCoord2fColor3fVertex3fvSUN (GLfloat* tc, GLfloat* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor3fVertex3fvDelegate (IntPtr tc, IntPtr c, IntPtr v);
			// void glTexCoord2fColor4fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor4fNormal3fVertex3fDelegate (System.Single s, System.Single t, System.Single r, System.Single g, System.Single b, System.Single a, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glTexCoord2fColor4fNormal3fVertex3fvSUN (GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor4fNormal3fVertex3fvDelegate (IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
			// void glTexCoord2fColor4ubVertex3fSUN (GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor4ubVertex3fDelegate (System.Single s, System.Single t, System.Byte r, System.Byte g, System.Byte b, System.Byte a, System.Single x, System.Single y, System.Single z);
			// void glTexCoord2fColor4ubVertex3fvSUN (GLfloat* tc, GLubyte* c, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fColor4ubVertex3fvDelegate (IntPtr tc, IntPtr c, IntPtr v);
			// void glTexCoord2fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fNormal3fVertex3fDelegate (System.Single s, System.Single t, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z);
			// void glTexCoord2fNormal3fVertex3fvSUN (GLfloat* tc, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fNormal3fVertex3fvDelegate (IntPtr tc, IntPtr n, IntPtr v);
			// void glTexCoord2fVertex3fSUN (GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fVertex3fDelegate (System.Single s, System.Single t, System.Single x, System.Single y, System.Single z);
			// void glTexCoord2fVertex3fvSUN (GLfloat* tc, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2fVertex3fvDelegate (IntPtr tc, IntPtr v);
			// void glTexCoord4fColor4fNormal3fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4fColor4fNormal3fVertex4fDelegate (System.Single s, System.Single t, System.Single p, System.Single q, System.Single r, System.Single g, System.Single b, System.Single a, System.Single nx, System.Single ny, System.Single nz, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glTexCoord4fColor4fNormal3fVertex4fvSUN (GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4fColor4fNormal3fVertex4fvDelegate (IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
			// void glTexCoord4fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4fVertex4fDelegate (System.Single s, System.Single t, System.Single p, System.Single q, System.Single x, System.Single y, System.Single z, System.Single w);
			// void glTexCoord4fVertex4fvSUN (GLfloat* tc, GLfloat* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4fVertex4fvDelegate (IntPtr tc, IntPtr v);
			#endregion // command delegates
			#region commands
			// void glColor3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			public readonly Color3fVertex3fDelegate Color3fVertex3f;
			// void glColor3fVertex3fvSUN (GLfloat* c, GLfloat* v)
			public readonly Color3fVertex3fvDelegate Color3fVertex3fv;
			// void glColor4fNormal3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly Color4fNormal3fVertex3fDelegate Color4fNormal3fVertex3f;
			// void glColor4fNormal3fVertex3fvSUN (GLfloat* c, GLfloat* n, GLfloat* v)
			public readonly Color4fNormal3fVertex3fvDelegate Color4fNormal3fVertex3fv;
			// void glColor4ubVertex2fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)
			public readonly Color4ubVertex2fDelegate Color4ubVertex2f;
			// void glColor4ubVertex2fvSUN (GLubyte* c, GLfloat* v)
			public readonly Color4ubVertex2fvDelegate Color4ubVertex2fv;
			// void glColor4ubVertex3fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			public readonly Color4ubVertex3fDelegate Color4ubVertex3f;
			// void glColor4ubVertex3fvSUN (GLubyte* c, GLfloat* v)
			public readonly Color4ubVertex3fvDelegate Color4ubVertex3fv;
			// void glNormal3fVertex3fSUN (GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly Normal3fVertex3fDelegate Normal3fVertex3f;
			// void glNormal3fVertex3fvSUN (GLfloat* n, GLfloat* v)
			public readonly Normal3fVertex3fvDelegate Normal3fVertex3fv;
			// void glReplacementCodeuiColor3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiColor3fVertex3fDelegate ReplacementCodeuiColor3fVertex3f;
			// void glReplacementCodeuiColor3fVertex3fvSUN (GLuint* rc, GLfloat* c, GLfloat* v)
			public readonly ReplacementCodeuiColor3fVertex3fvDelegate ReplacementCodeuiColor3fVertex3fv;
			// void glReplacementCodeuiColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiColor4fNormal3fVertex3fDelegate ReplacementCodeuiColor4fNormal3fVertex3f;
			// void glReplacementCodeuiColor4fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v)
			public readonly ReplacementCodeuiColor4fNormal3fVertex3fvDelegate ReplacementCodeuiColor4fNormal3fVertex3fv;
			// void glReplacementCodeuiColor4ubVertex3fSUN (GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiColor4ubVertex3fDelegate ReplacementCodeuiColor4ubVertex3f;
			// void glReplacementCodeuiColor4ubVertex3fvSUN (GLuint* rc, GLubyte* c, GLfloat* v)
			public readonly ReplacementCodeuiColor4ubVertex3fvDelegate ReplacementCodeuiColor4ubVertex3fv;
			// void glReplacementCodeuiNormal3fVertex3fSUN (GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiNormal3fVertex3fDelegate ReplacementCodeuiNormal3fVertex3f;
			// void glReplacementCodeuiNormal3fVertex3fvSUN (GLuint* rc, GLfloat* n, GLfloat* v)
			public readonly ReplacementCodeuiNormal3fVertex3fvDelegate ReplacementCodeuiNormal3fVertex3fv;
			// void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fDelegate ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3f;
			// void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			public readonly ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvDelegate ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fv;
			// void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiTexCoord2fNormal3fVertex3fDelegate ReplacementCodeuiTexCoord2fNormal3fVertex3f;
			// void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v)
			public readonly ReplacementCodeuiTexCoord2fNormal3fVertex3fvDelegate ReplacementCodeuiTexCoord2fNormal3fVertex3fv;
			// void glReplacementCodeuiTexCoord2fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiTexCoord2fVertex3fDelegate ReplacementCodeuiTexCoord2fVertex3f;
			// void glReplacementCodeuiTexCoord2fVertex3fvSUN (GLuint* rc, GLfloat* tc, GLfloat* v)
			public readonly ReplacementCodeuiTexCoord2fVertex3fvDelegate ReplacementCodeuiTexCoord2fVertex3fv;
			// void glReplacementCodeuiVertex3fSUN (GLuint rc, GLfloat x, GLfloat y, GLfloat z)
			public readonly ReplacementCodeuiVertex3fDelegate ReplacementCodeuiVertex3f;
			// void glReplacementCodeuiVertex3fvSUN (GLuint* rc, GLfloat* v)
			public readonly ReplacementCodeuiVertex3fvDelegate ReplacementCodeuiVertex3fv;
			// void glTexCoord2fColor3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
			public readonly TexCoord2fColor3fVertex3fDelegate TexCoord2fColor3fVertex3f;
			// void glTexCoord2fColor3fVertex3fvSUN (GLfloat* tc, GLfloat* c, GLfloat* v)
			public readonly TexCoord2fColor3fVertex3fvDelegate TexCoord2fColor3fVertex3fv;
			// void glTexCoord2fColor4fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly TexCoord2fColor4fNormal3fVertex3fDelegate TexCoord2fColor4fNormal3fVertex3f;
			// void glTexCoord2fColor4fNormal3fVertex3fvSUN (GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			public readonly TexCoord2fColor4fNormal3fVertex3fvDelegate TexCoord2fColor4fNormal3fVertex3fv;
			// void glTexCoord2fColor4ubVertex3fSUN (GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
			public readonly TexCoord2fColor4ubVertex3fDelegate TexCoord2fColor4ubVertex3f;
			// void glTexCoord2fColor4ubVertex3fvSUN (GLfloat* tc, GLubyte* c, GLfloat* v)
			public readonly TexCoord2fColor4ubVertex3fvDelegate TexCoord2fColor4ubVertex3fv;
			// void glTexCoord2fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
			public readonly TexCoord2fNormal3fVertex3fDelegate TexCoord2fNormal3fVertex3f;
			// void glTexCoord2fNormal3fVertex3fvSUN (GLfloat* tc, GLfloat* n, GLfloat* v)
			public readonly TexCoord2fNormal3fVertex3fvDelegate TexCoord2fNormal3fVertex3fv;
			// void glTexCoord2fVertex3fSUN (GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
			public readonly TexCoord2fVertex3fDelegate TexCoord2fVertex3f;
			// void glTexCoord2fVertex3fvSUN (GLfloat* tc, GLfloat* v)
			public readonly TexCoord2fVertex3fvDelegate TexCoord2fVertex3fv;
			// void glTexCoord4fColor4fNormal3fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly TexCoord4fColor4fNormal3fVertex4fDelegate TexCoord4fColor4fNormal3fVertex4f;
			// void glTexCoord4fColor4fNormal3fVertex4fvSUN (GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
			public readonly TexCoord4fColor4fNormal3fVertex4fvDelegate TexCoord4fColor4fNormal3fVertex4fv;
			// void glTexCoord4fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
			public readonly TexCoord4fVertex4fDelegate TexCoord4fVertex4f;
			// void glTexCoord4fVertex4fvSUN (GLfloat* tc, GLfloat* v)
			public readonly TexCoord4fVertex4fvDelegate TexCoord4fVertex4fv;
			#endregion // commands
			public SunVertex (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glColor3fVertex3fSUN", out Color3fVertex3f);
				resolver.LoadHandle ("glColor3fVertex3fvSUN", out Color3fVertex3fv);
				resolver.LoadHandle ("glColor4fNormal3fVertex3fSUN", out Color4fNormal3fVertex3f);
				resolver.LoadHandle ("glColor4fNormal3fVertex3fvSUN", out Color4fNormal3fVertex3fv);
				resolver.LoadHandle ("glColor4ubVertex2fSUN", out Color4ubVertex2f);
				resolver.LoadHandle ("glColor4ubVertex2fvSUN", out Color4ubVertex2fv);
				resolver.LoadHandle ("glColor4ubVertex3fSUN", out Color4ubVertex3f);
				resolver.LoadHandle ("glColor4ubVertex3fvSUN", out Color4ubVertex3fv);
				resolver.LoadHandle ("glNormal3fVertex3fSUN", out Normal3fVertex3f);
				resolver.LoadHandle ("glNormal3fVertex3fvSUN", out Normal3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiColor3fVertex3fSUN", out ReplacementCodeuiColor3fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiColor3fVertex3fvSUN", out ReplacementCodeuiColor3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiColor4fNormal3fVertex3fSUN", out ReplacementCodeuiColor4fNormal3fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", out ReplacementCodeuiColor4fNormal3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiColor4ubVertex3fSUN", out ReplacementCodeuiColor4ubVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiColor4ubVertex3fvSUN", out ReplacementCodeuiColor4ubVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiNormal3fVertex3fSUN", out ReplacementCodeuiNormal3fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiNormal3fVertex3fvSUN", out ReplacementCodeuiNormal3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", out ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", out ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", out ReplacementCodeuiTexCoord2fNormal3fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", out ReplacementCodeuiTexCoord2fNormal3fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fVertex3fSUN", out ReplacementCodeuiTexCoord2fVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiTexCoord2fVertex3fvSUN", out ReplacementCodeuiTexCoord2fVertex3fv);
				resolver.LoadHandle ("glReplacementCodeuiVertex3fSUN", out ReplacementCodeuiVertex3f);
				resolver.LoadHandle ("glReplacementCodeuiVertex3fvSUN", out ReplacementCodeuiVertex3fv);
				resolver.LoadHandle ("glTexCoord2fColor3fVertex3fSUN", out TexCoord2fColor3fVertex3f);
				resolver.LoadHandle ("glTexCoord2fColor3fVertex3fvSUN", out TexCoord2fColor3fVertex3fv);
				resolver.LoadHandle ("glTexCoord2fColor4fNormal3fVertex3fSUN", out TexCoord2fColor4fNormal3fVertex3f);
				resolver.LoadHandle ("glTexCoord2fColor4fNormal3fVertex3fvSUN", out TexCoord2fColor4fNormal3fVertex3fv);
				resolver.LoadHandle ("glTexCoord2fColor4ubVertex3fSUN", out TexCoord2fColor4ubVertex3f);
				resolver.LoadHandle ("glTexCoord2fColor4ubVertex3fvSUN", out TexCoord2fColor4ubVertex3fv);
				resolver.LoadHandle ("glTexCoord2fNormal3fVertex3fSUN", out TexCoord2fNormal3fVertex3f);
				resolver.LoadHandle ("glTexCoord2fNormal3fVertex3fvSUN", out TexCoord2fNormal3fVertex3fv);
				resolver.LoadHandle ("glTexCoord2fVertex3fSUN", out TexCoord2fVertex3f);
				resolver.LoadHandle ("glTexCoord2fVertex3fvSUN", out TexCoord2fVertex3fv);
				resolver.LoadHandle ("glTexCoord4fColor4fNormal3fVertex4fSUN", out TexCoord4fColor4fNormal3fVertex4f);
				resolver.LoadHandle ("glTexCoord4fColor4fNormal3fVertex4fvSUN", out TexCoord4fColor4fNormal3fVertex4fv);
				resolver.LoadHandle ("glTexCoord4fVertex4fSUN", out TexCoord4fVertex4f);
				resolver.LoadHandle ("glTexCoord4fVertex4fvSUN", out TexCoord4fVertex4fv);
			}
		}
	}
}

