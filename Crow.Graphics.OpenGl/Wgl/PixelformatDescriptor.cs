using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.OpenGl.Wgl
{
	//typedef struct tagPIXELFORMATDESCRIPTOR
	//{
	//	WORD nSize;
	//	WORD nVersion;
	//	DWORD dwFlags;
	//	BYTE iPixelType;
	//	BYTE cColorBits;
	//	BYTE cRedBits;
	//	BYTE cRedShift;
	//	BYTE cGreenBits;
	//	BYTE cGreenShift;
	//	BYTE cBlueBits;
	//	BYTE cBlueShift;
	//	BYTE cAlphaBits;
	//	BYTE cAlphaShift;
	//	BYTE cAccumBits;
	//	BYTE cAccumRedBits;
	//	BYTE cAccumGreenBits;
	//	BYTE cAccumBlueBits;
	//	BYTE cAccumAlphaBits;
	//	BYTE cDepthBits;
	//	BYTE cStencilBits;
	//	BYTE cAuxBuffers;
	//	BYTE iLayerType;
	//	BYTE bReserved;
	//	DWORD dwLayerMask;
	//	DWORD dwVisibleMask;
	//	DWORD dwDamageMask;
	//}

	[StructLayout ( LayoutKind.Sequential )]
	public struct PixelformatDescriptor
	{
		public ushort nSize;
		public ushort nVersion;
		public PFD_FLAGS dwFlags;
		public PFD_PIXEL_TYPE iPixelType;
		public byte cColorBits;
		public byte cRedBits;
		public byte cRedShift;
		public byte cGreenBits;
		public byte cGreenShift;
		public byte cBlueBits;
		public byte cBlueShift;
		public byte cAlphaBits;
		public byte cAlphaShift;
		public byte cAccumBits;
		public byte cAccumRedBits;
		public byte cAccumGreenBits;
		public byte cAccumBlueBits;
		public byte cAccumAlphaBits;
		public byte cDepthBits;
		public byte cStencilBits;
		public byte cAuxBuffers;
		public PFD_LAYER_TYPES iLayerType;
		public byte bReserved;
		public uint dwLayerMask;
		public uint dwVisibleMask;
		public uint dwDamageMask;
	}


	[Flags]
	public enum PFD_FLAGS : uint
	{
		DOUBLEBUFFER = 0x00000001,
		STEREO = 0x00000002,
		DRAW_TO_WINDOW = 0x00000004,
		DRAW_TO_BITMAP = 0x00000008,
		SUPPORT_GDI = 0x00000010,
		SUPPORT_OPENGL = 0x00000020,
		GENERIC_FORMAT = 0x00000040,
		NEED_PALETTE = 0x00000080,
		NEED_SYSTEM_PALETTE = 0x00000100,
		SWAP_EXCHANGE = 0x00000200,
		SWAP_COPY = 0x00000400,
		SWAP_LAYER_BUFFERS = 0x00000800,
		GENERIC_ACCELERATED = 0x00001000,
		SUPPORT_DIRECTDRAW = 0x00002000,
		DIRECT3D_ACCELERATED = 0x00004000,
		SUPPORT_COMPOSITION = 0x00008000,
		DEPTH_DONTCARE = 0x20000000,
		DOUBLEBUFFER_DONTCARE = 0x40000000,
		STEREO_DONTCARE = 0x80000000
	}

	public enum PFD_LAYER_TYPES : byte
	{
		MAIN_PLANE = 0,
		OVERLAY_PLANE = 1,
		UNDERLAY_PLANE = 255
	}

	public enum PFD_PIXEL_TYPE : byte
	{
		RGBA = 0,
		COLORINDEX = 1
	}

}
