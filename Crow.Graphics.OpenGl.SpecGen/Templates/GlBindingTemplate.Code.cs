using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenGlSpecGen.Spec;

namespace OpenGlSpecGen.Templates
{
	partial class GlBindingTemplate
	{
		public string FileNamespace;

		public List<ClassInfo> Class = new List<ClassInfo> ();

		public List<EnumClassInfo> Enums = new List<EnumClassInfo> ();

		private string CommandToString(SpecCommand cmd)
		{
			var dec = cmd.Prototype.Declaration.Type ?? "void";
			for ( int i = cmd.Prototype.Declaration.Pointers - 1; i >= 0; i-- )
			{
				dec += "*";
			}
			dec += " " + cmd.Prototype.Declaration.Name;
			if ( cmd.Parameters.Count > 0 )
			{
				dec += " (";
				for ( int i = 0; i < cmd.Parameters.Count; i++ )
				{
					var item = cmd.Parameters[i];
					dec += item.Declaration.Type ?? "void";
					for ( int j = item.Declaration.Pointers - 1; j >= 0; j-- )
					{
						dec += "*";
					}
					dec += " " + item.Declaration.Name;
					if ( i < cmd.Parameters.Count - 1 )
					{
						dec += ", ";
					}
				}
				dec += ")";
			}
			else
			{
				dec += " ()";
			}
			return dec;
		}
	}
}

class InteropMethods
{
	private static byte[] NameBuffer;
	private static GCHandle NameBufferHandle;
	public static IntPtr[] Names;


	public IntPtr[] Pointers;


	static InteropMethods()
	{
		NameBuffer = new byte[] { 0, 0, 0, 0 };
		NameBufferHandle = GCHandle.Alloc ( NameBuffer, GCHandleType.Pinned );
		var ptr = NameBufferHandle.AddrOfPinnedObject ();
		Names = new IntPtr[] { ptr + 0, ptr + 2 };
	}
}
