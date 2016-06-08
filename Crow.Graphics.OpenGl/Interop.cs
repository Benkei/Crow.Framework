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
			//		[ILSub ( @"
			//sizeof !T
			//ret" )]
			[MethodImpl ( MethodImplOptions.AggressiveInlining )]
			get
			{
				//return sizeof ( T );
				throw new NotImplementedException ();
			}
		}

		//		[ILSub ( @"
		//	ldarg.2
		//	ldarg.0
		//	ldfld native int valuetype OpenGl.Ptr`1<!T>::Pointer
		//	ldarg.1
		//	call native int [mscorlib]System.IntPtr::op_Addition(native int, int32)
		//	call void* [mscorlib]System.IntPtr::op_Explicit(native int)
		//	ldobj !T
		//	stobj !T
		//	ret
		//" )]
		[MethodImpl ( MethodImplOptions.AggressiveInlining )]
		public unsafe void Read(int byteOffset, out T value)
		{
			//value = *(Muh*)(Pointer + byteOffset);
			throw new NotImplementedException ();
		}

		//		[ILSub ( @"
		//	ldarg.0
		//	ldfld native int valuetype OpenGl.Ptr`1<!T>::Pointer
		//	ldarg.1
		//	call native int [mscorlib]System.IntPtr::op_Addition(native int, int32)
		//	call void* [mscorlib]System.IntPtr::op_Explicit(native int)
		//	ldarg.2
		//	ldobj !T
		//	stobj !T
		//	ret
		//" )]
		[MethodImpl ( MethodImplOptions.AggressiveInlining )]
		public unsafe void Write(int byteOffset, ref T value)
		{
			//*(T*)(Pointer + byteOffset) = value;
			throw new NotImplementedException ();
		}

		public static implicit operator IntPtr(Ptr<T> pointer)
		{
			return pointer.Pointer;
		}
		public static implicit operator Ptr<T>(IntPtr pointer)
		{
			return new Ptr<T> () { Pointer = pointer };
		}
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
