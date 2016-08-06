using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class OvrMultiview
		{
			public enum All
			{
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630
				FramebufferAttachmentTextureNumViews = unchecked((int)38448),
				// GL_MAX_VIEWS_OVR = 0x9631
				MaxViews = unchecked((int)38449),
				// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632
				FramebufferAttachmentTextureBaseViewIndex = unchecked((int)38450),
			}
			public const string NAME_STRING = "GL_OVR_multiview";
			#region command delegates
			// void glFramebufferTextureMultiviewOVR (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint baseViewIndex, GLsizei numViews)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FramebufferTextureMultiviewDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 baseViewIndex, System.Int32 numViews);
			#endregion // command delegates
			#region commands
			// void glFramebufferTextureMultiviewOVR (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint baseViewIndex, GLsizei numViews)
			public readonly FramebufferTextureMultiviewDelegate FramebufferTextureMultiview;
			#endregion // commands
			public OvrMultiview (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFramebufferTextureMultiviewOVR", out FramebufferTextureMultiview);
			}
		}
	}
}

