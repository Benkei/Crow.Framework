using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.OpenGl
{
	public class WglHandleResolver : IDisposable, IHandleResolver
	{
		const string gdi32 = "gdi32.dll";
		const string opengl32 = "opengl32.dll";

		[DllImport ( "kernel32.dll" )]
		static extern IntPtr GetProcAddress(IntPtr hModule, IntPtr procedureName);
		[DllImport ( "kernel32.dll" )]
		static extern IntPtr LoadLibrary(string dllToLoad);
		[DllImport ( "kernel32.dll" )]
		static extern bool FreeLibrary(IntPtr hModule);


		private IntPtr gdiModule;
		private IntPtr openglModule;

		public void Dispose()
		{
			if ( gdiModule != IntPtr.Zero )
			{
				FreeLibrary ( gdiModule );
				gdiModule = IntPtr.Zero;
			}
			if ( openglModule != IntPtr.Zero )
			{
				FreeLibrary ( openglModule );
				openglModule = IntPtr.Zero;
			}
		}

		public void LoadHandle<T>(string name, out T result) where T : class
		{
			IntPtr proc = GetWglFuncAddress ( name );
			if ( proc == IntPtr.Zero )
			{
				//throw new Exception ( "Extension function '" + name + "' not supported" );
				result = null;
				return;
			}
			Type delegateType = typeof ( T );
			result = Marshal.GetDelegateForFunctionPointer ( proc, delegateType ) as T;
		}
		
		private IntPtr GetWglFuncAddress(string name)
		{
			var namePtr = Marshal.StringToHGlobalAnsi ( name );
			try
			{
				if ( gdiModule == IntPtr.Zero )
					gdiModule = LoadLibrary ( gdi32 );
				var p = GetProcAddress ( gdiModule, namePtr );
				if ( p == IntPtr.Zero )
				{
					if ( openglModule == IntPtr.Zero )
						openglModule = LoadLibrary ( opengl32 );
					p = GetProcAddress ( openglModule, namePtr );
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
