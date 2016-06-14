using System;
using System.Runtime.CompilerServices;

namespace OpenGl
{
	public struct Ptr<T>
		where T : struct
	{
		public IntPtr Pointer;

		public static int Size
		{
			[MethodImpl ( MethodImplOptions.AggressiveInlining )]
			get { return _Size (); }
		}
		
		[MethodImpl ( MethodImplOptions.ForwardRef )]
		public extern void Read(int byteOffset, out T value);
		
		[MethodImpl ( MethodImplOptions.ForwardRef )]
		public extern void Write(int byteOffset, ref T value);

		public static implicit operator IntPtr(Ptr<T> pointer)
		{
			return pointer.Pointer;
		}
		public static implicit operator Ptr<T>(IntPtr pointer)
		{
			return new Ptr<T> () { Pointer = pointer };
		}
		
		[MethodImpl ( MethodImplOptions.ForwardRef )]
		private static extern int _Size();
	}

	public struct StringPtr
	{
		public IntPtr Pointer;
	}

	public struct RawVector2<T>
		where T : struct
	{
		public T X, Y;
	}
	public struct RawVector3<T>
		where T : struct
	{
		public T X, Y, Z;
	}
	public struct RawVector4<T>
		where T : struct
	{
		public T X, Y, Z, W;
	}

	public struct RawMatrix2<T>
		where T : struct
	{
		public T M00, M01, M02, M03;
	}
	public struct RawMatrix2x3<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05;
	}
	public struct RawMatrix2x4<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07;
	}

	public struct RawMatrix3<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07, M08;
	}
	public struct RawMatrix3x2<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05;
	}
	public struct RawMatrix3x4<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07, M08, M09, M10, M11;
	}

	public struct RawMatrix4<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07, M08, M09, M10, M11, M12, M13, M14, M15;
	}
	public struct RawMatrix4x2<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07;
	}
	public struct RawMatrix4x3<T>
		where T : struct
	{
		public T M00, M01, M02, M03, M04, M05, M06, M07, M08, M09, M10, M11;
	}
}
