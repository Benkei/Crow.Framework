using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class GremedyFrameTerminator
		{
			public const string NAME_STRING = "GL_GREMEDY_frame_terminator";
			#region command delegates
			// void glFrameTerminatorGREMEDY ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FrameTerminatorDelegate ();
			#endregion // command delegates
			#region commands
			// void glFrameTerminatorGREMEDY ()
			public readonly FrameTerminatorDelegate FrameTerminator;
			#endregion // commands
			public GremedyFrameTerminator (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFrameTerminatorGREMEDY", out FrameTerminator);
			}
		}
		public partial class GremedyStringMarker
		{
			public const string NAME_STRING = "GL_GREMEDY_string_marker";
			#region command delegates
			// void glStringMarkerGREMEDY (GLsizei len, void* string)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StringMarkerDelegate (System.Int32 len, IntPtr @string);
			#endregion // command delegates
			#region commands
			// void glStringMarkerGREMEDY (GLsizei len, void* string)
			public readonly StringMarkerDelegate StringMarker;
			#endregion // commands
			public GremedyStringMarker (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glStringMarkerGREMEDY", out StringMarker);
			}
		}
	}
}

