using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crow.Graphics.OpenGl;
using Crow.Graphics.OpenGl.Wgl;
using OpenGl;

namespace TestConsole
{
	class GlWindow : Form
	{
		Wgl wgl;
		Gl gl;
		IntPtr deviceContext;
		IntPtr renderContext;

		[DllImport ( "user32.dll" )]
		static extern IntPtr GetDC(IntPtr hWnd);


		public GlWindow()
		{
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated ( e );


			using ( var wglRes = new WglHandleResolver () )
			{
				wgl = new Wgl ( wglRes );
			}


			deviceContext = GetDC ( this.Handle );

			InitPixelFormat ( deviceContext );


			using ( var glRes = new GlHandleResolver () )
			{
				gl = new Gl ( glRes );
			}

			var str = gl.GetString ( StringName.Version );
			var s = Marshal.PtrToStringAnsi ( str.Pointer );
		}


		unsafe void InitPixelFormat(IntPtr hdc)
		{
			// pfd Tells Windows How We Want Things To Be
			var pfd = new PixelformatDescriptor
			{
				nSize = (ushort)Marshal.SizeOf<PixelformatDescriptor> (),  // size of this pfd
				nVersion = 1,                              // version number
				dwFlags = PFD_FLAGS.DRAW_TO_WINDOW | PFD_FLAGS.SUPPORT_OPENGL | PFD_FLAGS.DOUBLEBUFFER, // support window, OpenGL, double buffered
				iPixelType = PFD_PIXEL_TYPE.RGBA,                  // RGBA type
				cColorBits = 24,                             // 24-bit color depth
				cRedBits = 0,
				cRedShift = 0,
				cGreenBits = 0,
				cGreenShift = 0,
				cBlueBits = 0,
				cBlueShift = 0,               // color bits ignored
				cAlphaBits = 0,                              // no alpha buffer
				cAlphaShift = 0,                              // shift bit ignored
				cAccumBits = 0,                              // no accumulation buffer
				cAccumRedBits = 0,
				cAccumGreenBits = 0,
				cAccumBlueBits = 0,
				cAccumAlphaBits = 0,                     // accum bits ignored
				cDepthBits = 32,                             // 16-bit z-buffer
				cStencilBits = 0,                              // no stencil buffer
				cAuxBuffers = 0,                              // no auxiliary buffer
				iLayerType = PFD_LAYER_TYPES.MAIN_PLANE,                 // main layer
				bReserved = 0,                              // reserved
				dwLayerMask = 0,
				dwVisibleMask = 0,
				dwDamageMask = 0                         // layer masks ignored
			};

			int iPixelFormat = wgl.ChoosePixelFormat ( hdc, (IntPtr)(&pfd) );

			// get the device context's best, available pixel format match 
			if ( iPixelFormat == 0 )
			{
				//MessageBox::Show ( "ChoosePixelFormat Failed" );
				return;
			}
			if ( wgl.SetPixelFormat ( hdc, iPixelFormat, (IntPtr)(&pfd) ) == false )
			{
				//MessageBox::Show ( "SetPixelFormat Failed" );
				return;
			}

			renderContext = wgl.CreateContext ( hdc );

			if ( renderContext == IntPtr.Zero )
			{
				//MessageBox::Show ( "wglCreateContext Failed" );
				return;
			}
			if ( (wgl.MakeCurrent ( hdc, renderContext )) == false )
			{
				//MessageBox::Show ( "wglMakeCurrent Failed" );
				return;
			}
		}
	}
}
