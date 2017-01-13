using System;
using System.Threading;
using Crow.Win32;

namespace TestConsole
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			using ( var win = new RenderForm () )
			using ( var tut = new VulkanTutorial.Tutorial07 () )
			{
				win.Resize += (e, arg) => { tut.OnWindowSizeChanged (); };

				tut.PrepareVulkan ( win );

				tut.Init ();

				RenderLoop.Run ( win,
					() =>
					{
						if ( tut.ReadyToDraw ) { tut.Draw (); }
						Thread.Sleep ( 0 );
					}
				);
			}
		}
	}
}
