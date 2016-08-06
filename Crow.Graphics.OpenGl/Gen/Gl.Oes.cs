using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class OesByteCoordinates
		{
			public const string NAME_STRING = "GL_OES_byte_coordinates";
			#region command delegates
			// void glMultiTexCoord1bOES (GLenum texture, GLbyte s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1bDelegate (System.UInt32 texture, System.SByte s);
			// void glMultiTexCoord1bvOES (GLenum texture, GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1bvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord2bOES (GLenum texture, GLbyte s, GLbyte t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2bDelegate (System.UInt32 texture, System.SByte s, System.SByte t);
			// void glMultiTexCoord2bvOES (GLenum texture, GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2bvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord3bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3bDelegate (System.UInt32 texture, System.SByte s, System.SByte t, System.SByte r);
			// void glMultiTexCoord3bvOES (GLenum texture, GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3bvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord4bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4bDelegate (System.UInt32 texture, System.SByte s, System.SByte t, System.SByte r, System.SByte q);
			// void glMultiTexCoord4bvOES (GLenum texture, GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4bvDelegate (System.UInt32 texture, IntPtr coords);
			// void glTexCoord1bOES (GLbyte s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1bDelegate (System.SByte s);
			// void glTexCoord1bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1bvDelegate (IntPtr coords);
			// void glTexCoord2bOES (GLbyte s, GLbyte t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2bDelegate (System.SByte s, System.SByte t);
			// void glTexCoord2bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2bvDelegate (IntPtr coords);
			// void glTexCoord3bOES (GLbyte s, GLbyte t, GLbyte r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3bDelegate (System.SByte s, System.SByte t, System.SByte r);
			// void glTexCoord3bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3bvDelegate (IntPtr coords);
			// void glTexCoord4bOES (GLbyte s, GLbyte t, GLbyte r, GLbyte q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4bDelegate (System.SByte s, System.SByte t, System.SByte r, System.SByte q);
			// void glTexCoord4bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4bvDelegate (IntPtr coords);
			// void glVertex2bOES (GLbyte x, GLbyte y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2bDelegate (System.SByte x, System.SByte y);
			// void glVertex2bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2bvDelegate (IntPtr coords);
			// void glVertex3bOES (GLbyte x, GLbyte y, GLbyte z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3bDelegate (System.SByte x, System.SByte y, System.SByte z);
			// void glVertex3bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3bvDelegate (IntPtr coords);
			// void glVertex4bOES (GLbyte x, GLbyte y, GLbyte z, GLbyte w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4bDelegate (System.SByte x, System.SByte y, System.SByte z, System.SByte w);
			// void glVertex4bvOES (GLbyte* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4bvDelegate (IntPtr coords);
			#endregion // command delegates
			#region commands
			// void glMultiTexCoord1bOES (GLenum texture, GLbyte s)
			public readonly MultiTexCoord1bDelegate MultiTexCoord1b;
			// void glMultiTexCoord1bvOES (GLenum texture, GLbyte* coords)
			public readonly MultiTexCoord1bvDelegate MultiTexCoord1bv;
			// void glMultiTexCoord2bOES (GLenum texture, GLbyte s, GLbyte t)
			public readonly MultiTexCoord2bDelegate MultiTexCoord2b;
			// void glMultiTexCoord2bvOES (GLenum texture, GLbyte* coords)
			public readonly MultiTexCoord2bvDelegate MultiTexCoord2bv;
			// void glMultiTexCoord3bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r)
			public readonly MultiTexCoord3bDelegate MultiTexCoord3b;
			// void glMultiTexCoord3bvOES (GLenum texture, GLbyte* coords)
			public readonly MultiTexCoord3bvDelegate MultiTexCoord3bv;
			// void glMultiTexCoord4bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q)
			public readonly MultiTexCoord4bDelegate MultiTexCoord4b;
			// void glMultiTexCoord4bvOES (GLenum texture, GLbyte* coords)
			public readonly MultiTexCoord4bvDelegate MultiTexCoord4bv;
			// void glTexCoord1bOES (GLbyte s)
			public readonly TexCoord1bDelegate TexCoord1b;
			// void glTexCoord1bvOES (GLbyte* coords)
			public readonly TexCoord1bvDelegate TexCoord1bv;
			// void glTexCoord2bOES (GLbyte s, GLbyte t)
			public readonly TexCoord2bDelegate TexCoord2b;
			// void glTexCoord2bvOES (GLbyte* coords)
			public readonly TexCoord2bvDelegate TexCoord2bv;
			// void glTexCoord3bOES (GLbyte s, GLbyte t, GLbyte r)
			public readonly TexCoord3bDelegate TexCoord3b;
			// void glTexCoord3bvOES (GLbyte* coords)
			public readonly TexCoord3bvDelegate TexCoord3bv;
			// void glTexCoord4bOES (GLbyte s, GLbyte t, GLbyte r, GLbyte q)
			public readonly TexCoord4bDelegate TexCoord4b;
			// void glTexCoord4bvOES (GLbyte* coords)
			public readonly TexCoord4bvDelegate TexCoord4bv;
			// void glVertex2bOES (GLbyte x, GLbyte y)
			public readonly Vertex2bDelegate Vertex2b;
			// void glVertex2bvOES (GLbyte* coords)
			public readonly Vertex2bvDelegate Vertex2bv;
			// void glVertex3bOES (GLbyte x, GLbyte y, GLbyte z)
			public readonly Vertex3bDelegate Vertex3b;
			// void glVertex3bvOES (GLbyte* coords)
			public readonly Vertex3bvDelegate Vertex3bv;
			// void glVertex4bOES (GLbyte x, GLbyte y, GLbyte z, GLbyte w)
			public readonly Vertex4bDelegate Vertex4b;
			// void glVertex4bvOES (GLbyte* coords)
			public readonly Vertex4bvDelegate Vertex4bv;
			#endregion // commands
			public OesByteCoordinates (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glMultiTexCoord1bOES", out MultiTexCoord1b);
				resolver.LoadHandle ("glMultiTexCoord1bvOES", out MultiTexCoord1bv);
				resolver.LoadHandle ("glMultiTexCoord2bOES", out MultiTexCoord2b);
				resolver.LoadHandle ("glMultiTexCoord2bvOES", out MultiTexCoord2bv);
				resolver.LoadHandle ("glMultiTexCoord3bOES", out MultiTexCoord3b);
				resolver.LoadHandle ("glMultiTexCoord3bvOES", out MultiTexCoord3bv);
				resolver.LoadHandle ("glMultiTexCoord4bOES", out MultiTexCoord4b);
				resolver.LoadHandle ("glMultiTexCoord4bvOES", out MultiTexCoord4bv);
				resolver.LoadHandle ("glTexCoord1bOES", out TexCoord1b);
				resolver.LoadHandle ("glTexCoord1bvOES", out TexCoord1bv);
				resolver.LoadHandle ("glTexCoord2bOES", out TexCoord2b);
				resolver.LoadHandle ("glTexCoord2bvOES", out TexCoord2bv);
				resolver.LoadHandle ("glTexCoord3bOES", out TexCoord3b);
				resolver.LoadHandle ("glTexCoord3bvOES", out TexCoord3bv);
				resolver.LoadHandle ("glTexCoord4bOES", out TexCoord4b);
				resolver.LoadHandle ("glTexCoord4bvOES", out TexCoord4bv);
				resolver.LoadHandle ("glVertex2bOES", out Vertex2b);
				resolver.LoadHandle ("glVertex2bvOES", out Vertex2bv);
				resolver.LoadHandle ("glVertex3bOES", out Vertex3b);
				resolver.LoadHandle ("glVertex3bvOES", out Vertex3bv);
				resolver.LoadHandle ("glVertex4bOES", out Vertex4b);
				resolver.LoadHandle ("glVertex4bvOES", out Vertex4bv);
			}
		}
		public partial class OesCompressedPalettedTexture
		{
			public enum All
			{
				// GL_PALETTE4_RGB8_OES = 0x8B90
				Palette4Rgb8 = unchecked((int)35728),
				// GL_PALETTE4_RGBA8_OES = 0x8B91
				Palette4Rgba8 = unchecked((int)35729),
				// GL_PALETTE4_R5_G6_B5_OES = 0x8B92
				Palette4R5G6B5 = unchecked((int)35730),
				// GL_PALETTE4_RGBA4_OES = 0x8B93
				Palette4Rgba4 = unchecked((int)35731),
				// GL_PALETTE4_RGB5_A1_OES = 0x8B94
				Palette4Rgb5A1 = unchecked((int)35732),
				// GL_PALETTE8_RGB8_OES = 0x8B95
				Palette8Rgb8 = unchecked((int)35733),
				// GL_PALETTE8_RGBA8_OES = 0x8B96
				Palette8Rgba8 = unchecked((int)35734),
				// GL_PALETTE8_R5_G6_B5_OES = 0x8B97
				Palette8R5G6B5 = unchecked((int)35735),
				// GL_PALETTE8_RGBA4_OES = 0x8B98
				Palette8Rgba4 = unchecked((int)35736),
				// GL_PALETTE8_RGB5_A1_OES = 0x8B99
				Palette8Rgb5A1 = unchecked((int)35737),
			}
			public const string NAME_STRING = "GL_OES_compressed_paletted_texture";
		}
		public partial class OesFixedPoint
		{
			public enum All
			{
				// GL_FIXED_OES = 0x140C
				Fixed = unchecked((int)5132),
			}
			public const string NAME_STRING = "GL_OES_fixed_point";
			#region command delegates
			// void glAccumxOES (GLenum op, GLfixed value)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AccumxDelegate (System.UInt32 op, System.Int32 value);
			// void glAlphaFuncxOES (GLenum func, GLfixed ref)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AlphaFuncxDelegate (System.UInt32 func, System.Int32 @ref);
			// void glBitmapxOES (GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte* bitmap)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BitmapxDelegate (System.Int32 width, System.Int32 height, System.Int32 xorig, System.Int32 yorig, System.Int32 xmove, System.Int32 ymove, IntPtr bitmap);
			// void glBlendColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BlendColorxDelegate (System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha);
			// void glClearAccumxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearAccumxDelegate (System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha);
			// void glClearColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearColorxDelegate (System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha);
			// void glClearDepthxOES (GLfixed depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearDepthxDelegate (System.Int32 depth);
			// void glClipPlanexOES (GLenum plane, GLfixed* equation)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClipPlanexDelegate (System.UInt32 plane, IntPtr equation);
			// void glColor3xOES (GLfixed red, GLfixed green, GLfixed blue)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3xDelegate (System.Int32 red, System.Int32 green, System.Int32 blue);
			// void glColor3xvOES (GLfixed* components)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color3xvDelegate (IntPtr components);
			// void glColor4xOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4xDelegate (System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha);
			// void glColor4xvOES (GLfixed* components)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Color4xvDelegate (IntPtr components);
			// void glConvolutionParameterxOES (GLenum target, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameterxDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ConvolutionParameterxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glDepthRangexOES (GLfixed n, GLfixed f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DepthRangexDelegate (System.Int32 n, System.Int32 f);
			// void glEvalCoord1xOES (GLfixed u)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvalCoord1xDelegate (System.Int32 u);
			// void glEvalCoord1xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvalCoord1xvDelegate (IntPtr coords);
			// void glEvalCoord2xOES (GLfixed u, GLfixed v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvalCoord2xDelegate (System.Int32 u, System.Int32 v);
			// void glEvalCoord2xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EvalCoord2xvDelegate (IntPtr coords);
			// void glFeedbackBufferxOES (GLsizei n, GLenum type, GLfixed* buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FeedbackBufferxDelegate (System.Int32 n, System.UInt32 type, IntPtr buffer);
			// void glFogxOES (GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogxDelegate (System.UInt32 pname, System.Int32 param);
			// void glFogxvOES (GLenum pname, GLfixed* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FogxvDelegate (System.UInt32 pname, IntPtr param);
			// void glFrustumxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FrustumxDelegate (System.Int32 l, System.Int32 r, System.Int32 b, System.Int32 t, System.Int32 n, System.Int32 f);
			// void glGetClipPlanexOES (GLenum plane, GLfixed* equation)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetClipPlanexDelegate (System.UInt32 plane, IntPtr equation);
			// void glGetConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetConvolutionParameterxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetFixedvOES (GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFixedvDelegate (System.UInt32 pname, IntPtr @params);
			// void glGetHistogramParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetHistogramParameterxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetLightxOES (GLenum light, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetLightxDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glGetMapxvOES (GLenum target, GLenum query, GLfixed* v)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMapxvDelegate (System.UInt32 target, System.UInt32 query, IntPtr v);
			// void glGetMaterialxOES (GLenum face, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetMaterialxDelegate (System.UInt32 face, System.UInt32 pname, System.Int32 param);
			// void glGetPixelMapxv (GLenum map, GLint size, GLfixed* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetPixelMapxvDelegate (System.UInt32 map, System.Int32 size, IntPtr values);
			// void glGetTexEnvxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexEnvxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glGetTexGenxvOES (GLenum coord, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexGenxvDelegate (System.UInt32 coord, System.UInt32 pname, IntPtr @params);
			// void glGetTexLevelParameterxvOES (GLenum target, GLint level, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexLevelParameterxvDelegate (System.UInt32 target, System.Int32 level, System.UInt32 pname, IntPtr @params);
			// void glGetTexParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexParameterxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glIndexxOES (GLfixed component)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexxDelegate (System.Int32 component);
			// void glIndexxvOES (GLfixed* component)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IndexxvDelegate (IntPtr component);
			// void glLightModelxOES (GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LightModelxDelegate (System.UInt32 pname, System.Int32 param);
			// void glLightModelxvOES (GLenum pname, GLfixed* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LightModelxvDelegate (System.UInt32 pname, IntPtr param);
			// void glLightxOES (GLenum light, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LightxDelegate (System.UInt32 light, System.UInt32 pname, System.Int32 param);
			// void glLightxvOES (GLenum light, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LightxvDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glLineWidthxOES (GLfixed width)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LineWidthxDelegate (System.Int32 width);
			// void glLoadMatrixxOES (GLfixed* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadMatrixxDelegate (IntPtr m);
			// void glLoadTransposeMatrixxOES (GLfixed* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadTransposeMatrixxDelegate (IntPtr m);
			// void glMap1xOES (GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Map1xDelegate (System.UInt32 target, System.Int32 u1, System.Int32 u2, System.Int32 stride, System.Int32 order, System.Int32 points);
			// void glMap2xOES (GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Map2xDelegate (System.UInt32 target, System.Int32 u1, System.Int32 u2, System.Int32 ustride, System.Int32 uorder, System.Int32 v1, System.Int32 v2, System.Int32 vstride, System.Int32 vorder, System.Int32 points);
			// void glMapGrid1xOES (GLint n, GLfixed u1, GLfixed u2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapGrid1xDelegate (System.Int32 n, System.Int32 u1, System.Int32 u2);
			// void glMapGrid2xOES (GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapGrid2xDelegate (System.Int32 n, System.Int32 u1, System.Int32 u2, System.Int32 v1, System.Int32 v2);
			// void glMaterialxOES (GLenum face, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MaterialxDelegate (System.UInt32 face, System.UInt32 pname, System.Int32 param);
			// void glMaterialxvOES (GLenum face, GLenum pname, GLfixed* param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MaterialxvDelegate (System.UInt32 face, System.UInt32 pname, IntPtr param);
			// void glMultiTexCoord1xOES (GLenum texture, GLfixed s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1xDelegate (System.UInt32 texture, System.Int32 s);
			// void glMultiTexCoord1xvOES (GLenum texture, GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord1xvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord2xOES (GLenum texture, GLfixed s, GLfixed t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2xDelegate (System.UInt32 texture, System.Int32 s, System.Int32 t);
			// void glMultiTexCoord2xvOES (GLenum texture, GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord2xvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord3xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3xDelegate (System.UInt32 texture, System.Int32 s, System.Int32 t, System.Int32 r);
			// void glMultiTexCoord3xvOES (GLenum texture, GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord3xvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultiTexCoord4xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4xDelegate (System.UInt32 texture, System.Int32 s, System.Int32 t, System.Int32 r, System.Int32 q);
			// void glMultiTexCoord4xvOES (GLenum texture, GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiTexCoord4xvDelegate (System.UInt32 texture, IntPtr coords);
			// void glMultMatrixxOES (GLfixed* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultMatrixxDelegate (IntPtr m);
			// void glMultTransposeMatrixxOES (GLfixed* m)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultTransposeMatrixxDelegate (IntPtr m);
			// void glNormal3xOES (GLfixed nx, GLfixed ny, GLfixed nz)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3xDelegate (System.Int32 nx, System.Int32 ny, System.Int32 nz);
			// void glNormal3xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Normal3xvDelegate (IntPtr coords);
			// void glOrthoxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void OrthoxDelegate (System.Int32 l, System.Int32 r, System.Int32 b, System.Int32 t, System.Int32 n, System.Int32 f);
			// void glPassThroughxOES (GLfixed token)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PassThroughxDelegate (System.Int32 token);
			// void glPixelMapx (GLenum map, GLint size, GLfixed* values)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelMapxDelegate (System.UInt32 map, System.Int32 size, IntPtr values);
			// void glPixelStorex (GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelStorexDelegate (System.UInt32 pname, System.Int32 param);
			// void glPixelTransferxOES (GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTransferxDelegate (System.UInt32 pname, System.Int32 param);
			// void glPixelZoomxOES (GLfixed xfactor, GLfixed yfactor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelZoomxDelegate (System.Int32 xfactor, System.Int32 yfactor);
			// void glPointParameterxvOES (GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointParameterxvDelegate (System.UInt32 pname, IntPtr @params);
			// void glPointSizexOES (GLfixed size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PointSizexDelegate (System.Int32 size);
			// void glPolygonOffsetxOES (GLfixed factor, GLfixed units)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PolygonOffsetxDelegate (System.Int32 factor, System.Int32 units);
			// void glPrioritizeTexturesxOES (GLsizei n, GLuint* textures, GLfixed* priorities)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PrioritizeTexturesxDelegate (System.Int32 n, IntPtr textures, IntPtr priorities);
			// void glRasterPos2xOES (GLfixed x, GLfixed y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos2xDelegate (System.Int32 x, System.Int32 y);
			// void glRasterPos2xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos2xvDelegate (IntPtr coords);
			// void glRasterPos3xOES (GLfixed x, GLfixed y, GLfixed z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos3xDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glRasterPos3xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos3xvDelegate (IntPtr coords);
			// void glRasterPos4xOES (GLfixed x, GLfixed y, GLfixed z, GLfixed w)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos4xDelegate (System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
			// void glRasterPos4xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RasterPos4xvDelegate (IntPtr coords);
			// void glRectxOES (GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RectxDelegate (System.Int32 x1, System.Int32 y1, System.Int32 x2, System.Int32 y2);
			// void glRectxvOES (GLfixed* v1, GLfixed* v2)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RectxvDelegate (IntPtr v1, IntPtr v2);
			// void glRotatexOES (GLfixed angle, GLfixed x, GLfixed y, GLfixed z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void RotatexDelegate (System.Int32 angle, System.Int32 x, System.Int32 y, System.Int32 z);
			// void glScalexOES (GLfixed x, GLfixed y, GLfixed z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ScalexDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glTexCoord1xOES (GLfixed s)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1xDelegate (System.Int32 s);
			// void glTexCoord1xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord1xvDelegate (IntPtr coords);
			// void glTexCoord2xOES (GLfixed s, GLfixed t)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2xDelegate (System.Int32 s, System.Int32 t);
			// void glTexCoord2xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord2xvDelegate (IntPtr coords);
			// void glTexCoord3xOES (GLfixed s, GLfixed t, GLfixed r)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3xDelegate (System.Int32 s, System.Int32 t, System.Int32 r);
			// void glTexCoord3xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord3xvDelegate (IntPtr coords);
			// void glTexCoord4xOES (GLfixed s, GLfixed t, GLfixed r, GLfixed q)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4xDelegate (System.Int32 s, System.Int32 t, System.Int32 r, System.Int32 q);
			// void glTexCoord4xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexCoord4xvDelegate (IntPtr coords);
			// void glTexEnvxOES (GLenum target, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexEnvxDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glTexEnvxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexEnvxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glTexGenxOES (GLenum coord, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexGenxDelegate (System.UInt32 coord, System.UInt32 pname, System.Int32 param);
			// void glTexGenxvOES (GLenum coord, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexGenxvDelegate (System.UInt32 coord, System.UInt32 pname, IntPtr @params);
			// void glTexParameterxOES (GLenum target, GLenum pname, GLfixed param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexParameterxDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glTexParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TexParameterxvDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glTranslatexOES (GLfixed x, GLfixed y, GLfixed z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TranslatexDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glVertex2xOES (GLfixed x)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2xDelegate (System.Int32 x);
			// void glVertex2xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex2xvDelegate (IntPtr coords);
			// void glVertex3xOES (GLfixed x, GLfixed y)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3xDelegate (System.Int32 x, System.Int32 y);
			// void glVertex3xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex3xvDelegate (IntPtr coords);
			// void glVertex4xOES (GLfixed x, GLfixed y, GLfixed z)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4xDelegate (System.Int32 x, System.Int32 y, System.Int32 z);
			// void glVertex4xvOES (GLfixed* coords)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void Vertex4xvDelegate (IntPtr coords);
			#endregion // command delegates
			#region commands
			// void glAccumxOES (GLenum op, GLfixed value)
			public readonly AccumxDelegate Accumx;
			// void glAlphaFuncxOES (GLenum func, GLfixed ref)
			public readonly AlphaFuncxDelegate AlphaFuncx;
			// void glBitmapxOES (GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte* bitmap)
			public readonly BitmapxDelegate Bitmapx;
			// void glBlendColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			public readonly BlendColorxDelegate BlendColorx;
			// void glClearAccumxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			public readonly ClearAccumxDelegate ClearAccumx;
			// void glClearColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			public readonly ClearColorxDelegate ClearColorx;
			// void glClearDepthxOES (GLfixed depth)
			public readonly ClearDepthxDelegate ClearDepthx;
			// void glClipPlanexOES (GLenum plane, GLfixed* equation)
			public readonly ClipPlanexDelegate ClipPlanex;
			// void glColor3xOES (GLfixed red, GLfixed green, GLfixed blue)
			public readonly Color3xDelegate Color3x;
			// void glColor3xvOES (GLfixed* components)
			public readonly Color3xvDelegate Color3xv;
			// void glColor4xOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
			public readonly Color4xDelegate Color4x;
			// void glColor4xvOES (GLfixed* components)
			public readonly Color4xvDelegate Color4xv;
			// void glConvolutionParameterxOES (GLenum target, GLenum pname, GLfixed param)
			public readonly ConvolutionParameterxDelegate ConvolutionParameterx;
			// void glConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly ConvolutionParameterxvDelegate ConvolutionParameterxv;
			// void glDepthRangexOES (GLfixed n, GLfixed f)
			public readonly DepthRangexDelegate DepthRangex;
			// void glEvalCoord1xOES (GLfixed u)
			public readonly EvalCoord1xDelegate EvalCoord1x;
			// void glEvalCoord1xvOES (GLfixed* coords)
			public readonly EvalCoord1xvDelegate EvalCoord1xv;
			// void glEvalCoord2xOES (GLfixed u, GLfixed v)
			public readonly EvalCoord2xDelegate EvalCoord2x;
			// void glEvalCoord2xvOES (GLfixed* coords)
			public readonly EvalCoord2xvDelegate EvalCoord2xv;
			// void glFeedbackBufferxOES (GLsizei n, GLenum type, GLfixed* buffer)
			public readonly FeedbackBufferxDelegate FeedbackBufferx;
			// void glFogxOES (GLenum pname, GLfixed param)
			public readonly FogxDelegate Fogx;
			// void glFogxvOES (GLenum pname, GLfixed* param)
			public readonly FogxvDelegate Fogxv;
			// void glFrustumxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
			public readonly FrustumxDelegate Frustumx;
			// void glGetClipPlanexOES (GLenum plane, GLfixed* equation)
			public readonly GetClipPlanexDelegate GetClipPlanex;
			// void glGetConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly GetConvolutionParameterxvDelegate GetConvolutionParameterxv;
			// void glGetFixedvOES (GLenum pname, GLfixed* params)
			public readonly GetFixedvDelegate GetFixedv;
			// void glGetHistogramParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly GetHistogramParameterxvDelegate GetHistogramParameterxv;
			// void glGetLightxOES (GLenum light, GLenum pname, GLfixed* params)
			public readonly GetLightxDelegate GetLightx;
			// void glGetMapxvOES (GLenum target, GLenum query, GLfixed* v)
			public readonly GetMapxvDelegate GetMapxv;
			// void glGetMaterialxOES (GLenum face, GLenum pname, GLfixed param)
			public readonly GetMaterialxDelegate GetMaterialx;
			// void glGetPixelMapxv (GLenum map, GLint size, GLfixed* values)
			public readonly GetPixelMapxvDelegate GetPixelMapxv;
			// void glGetTexEnvxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly GetTexEnvxvDelegate GetTexEnvxv;
			// void glGetTexGenxvOES (GLenum coord, GLenum pname, GLfixed* params)
			public readonly GetTexGenxvDelegate GetTexGenxv;
			// void glGetTexLevelParameterxvOES (GLenum target, GLint level, GLenum pname, GLfixed* params)
			public readonly GetTexLevelParameterxvDelegate GetTexLevelParameterxv;
			// void glGetTexParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly GetTexParameterxvDelegate GetTexParameterxv;
			// void glIndexxOES (GLfixed component)
			public readonly IndexxDelegate Indexx;
			// void glIndexxvOES (GLfixed* component)
			public readonly IndexxvDelegate Indexxv;
			// void glLightModelxOES (GLenum pname, GLfixed param)
			public readonly LightModelxDelegate LightModelx;
			// void glLightModelxvOES (GLenum pname, GLfixed* param)
			public readonly LightModelxvDelegate LightModelxv;
			// void glLightxOES (GLenum light, GLenum pname, GLfixed param)
			public readonly LightxDelegate Lightx;
			// void glLightxvOES (GLenum light, GLenum pname, GLfixed* params)
			public readonly LightxvDelegate Lightxv;
			// void glLineWidthxOES (GLfixed width)
			public readonly LineWidthxDelegate LineWidthx;
			// void glLoadMatrixxOES (GLfixed* m)
			public readonly LoadMatrixxDelegate LoadMatrixx;
			// void glLoadTransposeMatrixxOES (GLfixed* m)
			public readonly LoadTransposeMatrixxDelegate LoadTransposeMatrixx;
			// void glMap1xOES (GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points)
			public readonly Map1xDelegate Map1x;
			// void glMap2xOES (GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points)
			public readonly Map2xDelegate Map2x;
			// void glMapGrid1xOES (GLint n, GLfixed u1, GLfixed u2)
			public readonly MapGrid1xDelegate MapGrid1x;
			// void glMapGrid2xOES (GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2)
			public readonly MapGrid2xDelegate MapGrid2x;
			// void glMaterialxOES (GLenum face, GLenum pname, GLfixed param)
			public readonly MaterialxDelegate Materialx;
			// void glMaterialxvOES (GLenum face, GLenum pname, GLfixed* param)
			public readonly MaterialxvDelegate Materialxv;
			// void glMultiTexCoord1xOES (GLenum texture, GLfixed s)
			public readonly MultiTexCoord1xDelegate MultiTexCoord1x;
			// void glMultiTexCoord1xvOES (GLenum texture, GLfixed* coords)
			public readonly MultiTexCoord1xvDelegate MultiTexCoord1xv;
			// void glMultiTexCoord2xOES (GLenum texture, GLfixed s, GLfixed t)
			public readonly MultiTexCoord2xDelegate MultiTexCoord2x;
			// void glMultiTexCoord2xvOES (GLenum texture, GLfixed* coords)
			public readonly MultiTexCoord2xvDelegate MultiTexCoord2xv;
			// void glMultiTexCoord3xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r)
			public readonly MultiTexCoord3xDelegate MultiTexCoord3x;
			// void glMultiTexCoord3xvOES (GLenum texture, GLfixed* coords)
			public readonly MultiTexCoord3xvDelegate MultiTexCoord3xv;
			// void glMultiTexCoord4xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q)
			public readonly MultiTexCoord4xDelegate MultiTexCoord4x;
			// void glMultiTexCoord4xvOES (GLenum texture, GLfixed* coords)
			public readonly MultiTexCoord4xvDelegate MultiTexCoord4xv;
			// void glMultMatrixxOES (GLfixed* m)
			public readonly MultMatrixxDelegate MultMatrixx;
			// void glMultTransposeMatrixxOES (GLfixed* m)
			public readonly MultTransposeMatrixxDelegate MultTransposeMatrixx;
			// void glNormal3xOES (GLfixed nx, GLfixed ny, GLfixed nz)
			public readonly Normal3xDelegate Normal3x;
			// void glNormal3xvOES (GLfixed* coords)
			public readonly Normal3xvDelegate Normal3xv;
			// void glOrthoxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
			public readonly OrthoxDelegate Orthox;
			// void glPassThroughxOES (GLfixed token)
			public readonly PassThroughxDelegate PassThroughx;
			// void glPixelMapx (GLenum map, GLint size, GLfixed* values)
			public readonly PixelMapxDelegate PixelMapx;
			// void glPixelStorex (GLenum pname, GLfixed param)
			public readonly PixelStorexDelegate PixelStorex;
			// void glPixelTransferxOES (GLenum pname, GLfixed param)
			public readonly PixelTransferxDelegate PixelTransferx;
			// void glPixelZoomxOES (GLfixed xfactor, GLfixed yfactor)
			public readonly PixelZoomxDelegate PixelZoomx;
			// void glPointParameterxvOES (GLenum pname, GLfixed* params)
			public readonly PointParameterxvDelegate PointParameterxv;
			// void glPointSizexOES (GLfixed size)
			public readonly PointSizexDelegate PointSizex;
			// void glPolygonOffsetxOES (GLfixed factor, GLfixed units)
			public readonly PolygonOffsetxDelegate PolygonOffsetx;
			// void glPrioritizeTexturesxOES (GLsizei n, GLuint* textures, GLfixed* priorities)
			public readonly PrioritizeTexturesxDelegate PrioritizeTexturesx;
			// void glRasterPos2xOES (GLfixed x, GLfixed y)
			public readonly RasterPos2xDelegate RasterPos2x;
			// void glRasterPos2xvOES (GLfixed* coords)
			public readonly RasterPos2xvDelegate RasterPos2xv;
			// void glRasterPos3xOES (GLfixed x, GLfixed y, GLfixed z)
			public readonly RasterPos3xDelegate RasterPos3x;
			// void glRasterPos3xvOES (GLfixed* coords)
			public readonly RasterPos3xvDelegate RasterPos3xv;
			// void glRasterPos4xOES (GLfixed x, GLfixed y, GLfixed z, GLfixed w)
			public readonly RasterPos4xDelegate RasterPos4x;
			// void glRasterPos4xvOES (GLfixed* coords)
			public readonly RasterPos4xvDelegate RasterPos4xv;
			// void glRectxOES (GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2)
			public readonly RectxDelegate Rectx;
			// void glRectxvOES (GLfixed* v1, GLfixed* v2)
			public readonly RectxvDelegate Rectxv;
			// void glRotatexOES (GLfixed angle, GLfixed x, GLfixed y, GLfixed z)
			public readonly RotatexDelegate Rotatex;
			// void glScalexOES (GLfixed x, GLfixed y, GLfixed z)
			public readonly ScalexDelegate Scalex;
			// void glTexCoord1xOES (GLfixed s)
			public readonly TexCoord1xDelegate TexCoord1x;
			// void glTexCoord1xvOES (GLfixed* coords)
			public readonly TexCoord1xvDelegate TexCoord1xv;
			// void glTexCoord2xOES (GLfixed s, GLfixed t)
			public readonly TexCoord2xDelegate TexCoord2x;
			// void glTexCoord2xvOES (GLfixed* coords)
			public readonly TexCoord2xvDelegate TexCoord2xv;
			// void glTexCoord3xOES (GLfixed s, GLfixed t, GLfixed r)
			public readonly TexCoord3xDelegate TexCoord3x;
			// void glTexCoord3xvOES (GLfixed* coords)
			public readonly TexCoord3xvDelegate TexCoord3xv;
			// void glTexCoord4xOES (GLfixed s, GLfixed t, GLfixed r, GLfixed q)
			public readonly TexCoord4xDelegate TexCoord4x;
			// void glTexCoord4xvOES (GLfixed* coords)
			public readonly TexCoord4xvDelegate TexCoord4xv;
			// void glTexEnvxOES (GLenum target, GLenum pname, GLfixed param)
			public readonly TexEnvxDelegate TexEnvx;
			// void glTexEnvxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly TexEnvxvDelegate TexEnvxv;
			// void glTexGenxOES (GLenum coord, GLenum pname, GLfixed param)
			public readonly TexGenxDelegate TexGenx;
			// void glTexGenxvOES (GLenum coord, GLenum pname, GLfixed* params)
			public readonly TexGenxvDelegate TexGenxv;
			// void glTexParameterxOES (GLenum target, GLenum pname, GLfixed param)
			public readonly TexParameterxDelegate TexParameterx;
			// void glTexParameterxvOES (GLenum target, GLenum pname, GLfixed* params)
			public readonly TexParameterxvDelegate TexParameterxv;
			// void glTranslatexOES (GLfixed x, GLfixed y, GLfixed z)
			public readonly TranslatexDelegate Translatex;
			// void glVertex2xOES (GLfixed x)
			public readonly Vertex2xDelegate Vertex2x;
			// void glVertex2xvOES (GLfixed* coords)
			public readonly Vertex2xvDelegate Vertex2xv;
			// void glVertex3xOES (GLfixed x, GLfixed y)
			public readonly Vertex3xDelegate Vertex3x;
			// void glVertex3xvOES (GLfixed* coords)
			public readonly Vertex3xvDelegate Vertex3xv;
			// void glVertex4xOES (GLfixed x, GLfixed y, GLfixed z)
			public readonly Vertex4xDelegate Vertex4x;
			// void glVertex4xvOES (GLfixed* coords)
			public readonly Vertex4xvDelegate Vertex4xv;
			#endregion // commands
			public OesFixedPoint (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAccumxOES", out Accumx);
				resolver.LoadHandle ("glAlphaFuncxOES", out AlphaFuncx);
				resolver.LoadHandle ("glBitmapxOES", out Bitmapx);
				resolver.LoadHandle ("glBlendColorxOES", out BlendColorx);
				resolver.LoadHandle ("glClearAccumxOES", out ClearAccumx);
				resolver.LoadHandle ("glClearColorxOES", out ClearColorx);
				resolver.LoadHandle ("glClearDepthxOES", out ClearDepthx);
				resolver.LoadHandle ("glClipPlanexOES", out ClipPlanex);
				resolver.LoadHandle ("glColor3xOES", out Color3x);
				resolver.LoadHandle ("glColor3xvOES", out Color3xv);
				resolver.LoadHandle ("glColor4xOES", out Color4x);
				resolver.LoadHandle ("glColor4xvOES", out Color4xv);
				resolver.LoadHandle ("glConvolutionParameterxOES", out ConvolutionParameterx);
				resolver.LoadHandle ("glConvolutionParameterxvOES", out ConvolutionParameterxv);
				resolver.LoadHandle ("glDepthRangexOES", out DepthRangex);
				resolver.LoadHandle ("glEvalCoord1xOES", out EvalCoord1x);
				resolver.LoadHandle ("glEvalCoord1xvOES", out EvalCoord1xv);
				resolver.LoadHandle ("glEvalCoord2xOES", out EvalCoord2x);
				resolver.LoadHandle ("glEvalCoord2xvOES", out EvalCoord2xv);
				resolver.LoadHandle ("glFeedbackBufferxOES", out FeedbackBufferx);
				resolver.LoadHandle ("glFogxOES", out Fogx);
				resolver.LoadHandle ("glFogxvOES", out Fogxv);
				resolver.LoadHandle ("glFrustumxOES", out Frustumx);
				resolver.LoadHandle ("glGetClipPlanexOES", out GetClipPlanex);
				resolver.LoadHandle ("glGetConvolutionParameterxvOES", out GetConvolutionParameterxv);
				resolver.LoadHandle ("glGetFixedvOES", out GetFixedv);
				resolver.LoadHandle ("glGetHistogramParameterxvOES", out GetHistogramParameterxv);
				resolver.LoadHandle ("glGetLightxOES", out GetLightx);
				resolver.LoadHandle ("glGetMapxvOES", out GetMapxv);
				resolver.LoadHandle ("glGetMaterialxOES", out GetMaterialx);
				resolver.LoadHandle ("glGetPixelMapxv", out GetPixelMapxv);
				resolver.LoadHandle ("glGetTexEnvxvOES", out GetTexEnvxv);
				resolver.LoadHandle ("glGetTexGenxvOES", out GetTexGenxv);
				resolver.LoadHandle ("glGetTexLevelParameterxvOES", out GetTexLevelParameterxv);
				resolver.LoadHandle ("glGetTexParameterxvOES", out GetTexParameterxv);
				resolver.LoadHandle ("glIndexxOES", out Indexx);
				resolver.LoadHandle ("glIndexxvOES", out Indexxv);
				resolver.LoadHandle ("glLightModelxOES", out LightModelx);
				resolver.LoadHandle ("glLightModelxvOES", out LightModelxv);
				resolver.LoadHandle ("glLightxOES", out Lightx);
				resolver.LoadHandle ("glLightxvOES", out Lightxv);
				resolver.LoadHandle ("glLineWidthxOES", out LineWidthx);
				resolver.LoadHandle ("glLoadMatrixxOES", out LoadMatrixx);
				resolver.LoadHandle ("glLoadTransposeMatrixxOES", out LoadTransposeMatrixx);
				resolver.LoadHandle ("glMap1xOES", out Map1x);
				resolver.LoadHandle ("glMap2xOES", out Map2x);
				resolver.LoadHandle ("glMapGrid1xOES", out MapGrid1x);
				resolver.LoadHandle ("glMapGrid2xOES", out MapGrid2x);
				resolver.LoadHandle ("glMaterialxOES", out Materialx);
				resolver.LoadHandle ("glMaterialxvOES", out Materialxv);
				resolver.LoadHandle ("glMultiTexCoord1xOES", out MultiTexCoord1x);
				resolver.LoadHandle ("glMultiTexCoord1xvOES", out MultiTexCoord1xv);
				resolver.LoadHandle ("glMultiTexCoord2xOES", out MultiTexCoord2x);
				resolver.LoadHandle ("glMultiTexCoord2xvOES", out MultiTexCoord2xv);
				resolver.LoadHandle ("glMultiTexCoord3xOES", out MultiTexCoord3x);
				resolver.LoadHandle ("glMultiTexCoord3xvOES", out MultiTexCoord3xv);
				resolver.LoadHandle ("glMultiTexCoord4xOES", out MultiTexCoord4x);
				resolver.LoadHandle ("glMultiTexCoord4xvOES", out MultiTexCoord4xv);
				resolver.LoadHandle ("glMultMatrixxOES", out MultMatrixx);
				resolver.LoadHandle ("glMultTransposeMatrixxOES", out MultTransposeMatrixx);
				resolver.LoadHandle ("glNormal3xOES", out Normal3x);
				resolver.LoadHandle ("glNormal3xvOES", out Normal3xv);
				resolver.LoadHandle ("glOrthoxOES", out Orthox);
				resolver.LoadHandle ("glPassThroughxOES", out PassThroughx);
				resolver.LoadHandle ("glPixelMapx", out PixelMapx);
				resolver.LoadHandle ("glPixelStorex", out PixelStorex);
				resolver.LoadHandle ("glPixelTransferxOES", out PixelTransferx);
				resolver.LoadHandle ("glPixelZoomxOES", out PixelZoomx);
				resolver.LoadHandle ("glPointParameterxvOES", out PointParameterxv);
				resolver.LoadHandle ("glPointSizexOES", out PointSizex);
				resolver.LoadHandle ("glPolygonOffsetxOES", out PolygonOffsetx);
				resolver.LoadHandle ("glPrioritizeTexturesxOES", out PrioritizeTexturesx);
				resolver.LoadHandle ("glRasterPos2xOES", out RasterPos2x);
				resolver.LoadHandle ("glRasterPos2xvOES", out RasterPos2xv);
				resolver.LoadHandle ("glRasterPos3xOES", out RasterPos3x);
				resolver.LoadHandle ("glRasterPos3xvOES", out RasterPos3xv);
				resolver.LoadHandle ("glRasterPos4xOES", out RasterPos4x);
				resolver.LoadHandle ("glRasterPos4xvOES", out RasterPos4xv);
				resolver.LoadHandle ("glRectxOES", out Rectx);
				resolver.LoadHandle ("glRectxvOES", out Rectxv);
				resolver.LoadHandle ("glRotatexOES", out Rotatex);
				resolver.LoadHandle ("glScalexOES", out Scalex);
				resolver.LoadHandle ("glTexCoord1xOES", out TexCoord1x);
				resolver.LoadHandle ("glTexCoord1xvOES", out TexCoord1xv);
				resolver.LoadHandle ("glTexCoord2xOES", out TexCoord2x);
				resolver.LoadHandle ("glTexCoord2xvOES", out TexCoord2xv);
				resolver.LoadHandle ("glTexCoord3xOES", out TexCoord3x);
				resolver.LoadHandle ("glTexCoord3xvOES", out TexCoord3xv);
				resolver.LoadHandle ("glTexCoord4xOES", out TexCoord4x);
				resolver.LoadHandle ("glTexCoord4xvOES", out TexCoord4xv);
				resolver.LoadHandle ("glTexEnvxOES", out TexEnvx);
				resolver.LoadHandle ("glTexEnvxvOES", out TexEnvxv);
				resolver.LoadHandle ("glTexGenxOES", out TexGenx);
				resolver.LoadHandle ("glTexGenxvOES", out TexGenxv);
				resolver.LoadHandle ("glTexParameterxOES", out TexParameterx);
				resolver.LoadHandle ("glTexParameterxvOES", out TexParameterxv);
				resolver.LoadHandle ("glTranslatexOES", out Translatex);
				resolver.LoadHandle ("glVertex2xOES", out Vertex2x);
				resolver.LoadHandle ("glVertex2xvOES", out Vertex2xv);
				resolver.LoadHandle ("glVertex3xOES", out Vertex3x);
				resolver.LoadHandle ("glVertex3xvOES", out Vertex3xv);
				resolver.LoadHandle ("glVertex4xOES", out Vertex4x);
				resolver.LoadHandle ("glVertex4xvOES", out Vertex4xv);
			}
		}
		public partial class OesQueryMatrix
		{
			public const string NAME_STRING = "GL_OES_query_matrix";
			#region command delegates
			// GLbitfield glQueryMatrixxOES (GLfixed* mantissa, GLint* exponent)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 QueryMatrixxDelegate (IntPtr mantissa, IntPtr exponent);
			#endregion // command delegates
			#region commands
			// GLbitfield glQueryMatrixxOES (GLfixed* mantissa, GLint* exponent)
			public readonly QueryMatrixxDelegate QueryMatrixx;
			#endregion // commands
			public OesQueryMatrix (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glQueryMatrixxOES", out QueryMatrixx);
			}
		}
		public partial class OesReadFormat
		{
			public enum All
			{
				// GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
				ImplementationColorReadType = unchecked((int)35738),
				// GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
				ImplementationColorReadFormat = unchecked((int)35739),
			}
			public const string NAME_STRING = "GL_OES_read_format";
		}
		public partial class OesSinglePrecision
		{
			public const string NAME_STRING = "GL_OES_single_precision";
			#region command delegates
			// void glClearDepthfOES (GLclampf depth)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClearDepthfDelegate (System.Single depth);
			// void glClipPlanefOES (GLenum plane, GLfloat* equation)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ClipPlanefDelegate (System.UInt32 plane, IntPtr equation);
			// void glDepthRangefOES (GLclampf n, GLclampf f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DepthRangefDelegate (System.Single n, System.Single f);
			// void glFrustumfOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FrustumfDelegate (System.Single l, System.Single r, System.Single b, System.Single t, System.Single n, System.Single f);
			// void glGetClipPlanefOES (GLenum plane, GLfloat* equation)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetClipPlanefDelegate (System.UInt32 plane, IntPtr equation);
			// void glOrthofOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void OrthofDelegate (System.Single l, System.Single r, System.Single b, System.Single t, System.Single n, System.Single f);
			#endregion // command delegates
			#region commands
			// void glClearDepthfOES (GLclampf depth)
			public readonly ClearDepthfDelegate ClearDepthf;
			// void glClipPlanefOES (GLenum plane, GLfloat* equation)
			public readonly ClipPlanefDelegate ClipPlanef;
			// void glDepthRangefOES (GLclampf n, GLclampf f)
			public readonly DepthRangefDelegate DepthRangef;
			// void glFrustumfOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
			public readonly FrustumfDelegate Frustumf;
			// void glGetClipPlanefOES (GLenum plane, GLfloat* equation)
			public readonly GetClipPlanefDelegate GetClipPlanef;
			// void glOrthofOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
			public readonly OrthofDelegate Orthof;
			#endregion // commands
			public OesSinglePrecision (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glClearDepthfOES", out ClearDepthf);
				resolver.LoadHandle ("glClipPlanefOES", out ClipPlanef);
				resolver.LoadHandle ("glDepthRangefOES", out DepthRangef);
				resolver.LoadHandle ("glFrustumfOES", out Frustumf);
				resolver.LoadHandle ("glGetClipPlanefOES", out GetClipPlanef);
				resolver.LoadHandle ("glOrthofOES", out Orthof);
			}
		}
	}
}

