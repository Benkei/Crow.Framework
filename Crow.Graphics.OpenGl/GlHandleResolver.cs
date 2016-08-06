using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.OpenGl
{
	public class GlHandleResolver : IDisposable, IHandleResolver
	{
		[DllImport ( "opengl32.dll" )]
		static extern IntPtr wglGetProcAddress(IntPtr name);

		[DllImport ( "kernel32.dll" )]
		static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
		[DllImport ( "kernel32.dll" )]
		static extern IntPtr LoadLibrary(string dllToLoad);
		[DllImport ( "kernel32.dll" )]
		static extern bool FreeLibrary(IntPtr hModule);


		private IntPtr openglModule;

		public void Dispose()
		{
			if ( openglModule != IntPtr.Zero )
			{
				FreeLibrary ( openglModule );
				openglModule = IntPtr.Zero;
			}
		}

		public void LoadHandle<T>(string name, out T result) where T : class
		{
			IntPtr proc = GetAnyGLFuncAddress ( name );
			if ( proc == IntPtr.Zero )
			{
				//throw new Exception ( "Extension function '" + name + "' not supported" );
				result = null;
				return;
			}
			Type delegateType = typeof ( T );
			result = Marshal.GetDelegateForFunctionPointer ( proc, delegateType ) as T;
		}

		// https://www.opengl.org/wiki/Load_OpenGL_Functions
		private IntPtr GetAnyGLFuncAddress(string name)
		{
			var namePtr = Marshal.StringToHGlobalAnsi ( name );
			try
			{
				var p = wglGetProcAddress ( namePtr );
				if ( p == (IntPtr)0
					|| (p == (IntPtr)0x1)
					|| (p == (IntPtr)0x2)
					|| (p == (IntPtr)0x3)
					|| (p == (IntPtr)(-1)) )
				{
					if ( openglModule == IntPtr.Zero )
						openglModule = LoadLibrary ( "opengl32.dll" );
					p = GetProcAddress ( openglModule, name );
				}
				return p;
			}
			finally
			{
				Marshal.FreeHGlobal ( namePtr );
			}
		}
	}
}
