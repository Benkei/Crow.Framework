using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace Crow.Graphics.Vulkan
{
	public static class MarshalUtility
	{
		public unsafe static IntPtr AllocateString(IList<string> values)
		{
			IntPtr* ptr = (IntPtr*)Marshal.AllocHGlobal ( sizeof ( IntPtr ) * values.Count );
			for ( int i = 0; i < values.Count; i++ )
			{
				ptr[i] = Marshal.StringToHGlobalAnsi ( values[i] );
			}
			return (IntPtr)ptr;
		}

		/*
		public static IntPtr AllocateArray<T>(T values)
			where T : struct
		{
			IntPtr ptr = Marshal.AllocHGlobal ( Marshal.SizeOf<T> () );
			Marshal.StructureToPtr<T> ( values, ptr, false );
			return ptr;
		}

		public static IntPtr AllocateArray<T>(IList<T> values)
			where T : struct
		{
			IntPtr ptr = Marshal.AllocHGlobal ( Marshal.SizeOf<T> () * values.Count );
			for ( int i = 0; i < values.Count; i++ )
			{
				Marshal.StructureToPtr<T> ( values[i], IntPtr.Add ( ptr, Marshal.SizeOf<T> () * i ), false );
			}
			return ptr;
		}
		*/

		public unsafe static void FreeString(IntPtr values, int length)
		{
			IntPtr* ptr = (IntPtr*)values;
			for ( int i = 0; i < length; i++ )
			{
				Marshal.FreeHGlobal ( ptr[i] );
			}
			Marshal.FreeHGlobal ( values );
		}

		public static void FreeArray(IntPtr value)
		{
			Marshal.FreeHGlobal ( value );
		}

		public unsafe static bool Equals(this string source, void* value, int length = -1)
		{
			if ( length < 0 ) length = source.Length;
			fixed ( char* ptr = source )
			{
				char* strPtr = ptr;
				byte* otherPtr = (byte*)value;
				while ( length > 0 && *strPtr == *otherPtr )
				{
					if ( *strPtr == '\0' )
						return false;
					strPtr++;
					otherPtr++;
					length--;
				}
				return length == 0;
			}
		}
	}

	public static class DelegateUtility
	{
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer ( CallingConvention.Winapi )]
		unsafe delegate Result Function0(IntPtr arg1, IntPtr arg2);
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer ( CallingConvention.Winapi )]
		unsafe delegate Result Function1(IntPtr arg1, IntPtr arg2, IntPtr arg3);
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer ( CallingConvention.Winapi )]
		unsafe delegate Result Function2(IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer ( CallingConvention.Winapi )]
		unsafe delegate Result Function3(ulong arg1, IntPtr arg2, IntPtr arg3);
		[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer ( CallingConvention.Winapi )]
		unsafe delegate Result Function4(IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		public unsafe static TReturn[] EnumerateToArray<TReturn>(Delegate enumerator)
			where TReturn : struct
		{
			var funPtr = Marshal.GetFunctionPointerForDelegate ( enumerator );
			var func = (Function0)(object)Marshal.GetDelegateForFunctionPointer ( funPtr, typeof ( Function0 ) );

			uint count = 0;
			func ( (IntPtr)(&count), IntPtr.Zero ).CheckError ();

			if ( count == 0 )
				return null;

			TReturn[] values = new TReturn[count];
			var h = GCHandle.Alloc ( values, GCHandleType.Pinned );
			try
			{
				func ( (IntPtr)(&count), h.AddrOfPinnedObject () ).CheckError ();
			}
			finally
			{
				h.Free ();
			}
			return values;
		}

		public unsafe static TReturn[] EnumerateToArray<TReturn>(Delegate enumerator, IntPtr arg1)
			where TReturn : struct
		{
			var funPtr = Marshal.GetFunctionPointerForDelegate ( enumerator );
			var func = (Function1)(object)Marshal.GetDelegateForFunctionPointer ( funPtr, typeof ( Function1 ) );

			uint count = 0;
			func ( arg1, (IntPtr)(&count), IntPtr.Zero ).CheckError ();

			if ( count == 0 )
				return null;

			TReturn[] values = new TReturn[count];
			var h = GCHandle.Alloc ( values, GCHandleType.Pinned );
			try
			{
				func ( arg1, (IntPtr)(&count), h.AddrOfPinnedObject () ).CheckError ();
			}
			finally
			{
				h.Free ();
			}
			return values;
		}

		public unsafe static TReturn[] EnumerateToArray<TReturn>(Delegate enumerator, IntPtr arg1, IntPtr arg2)
			where TReturn : struct
		{
			var funPtr = Marshal.GetFunctionPointerForDelegate ( enumerator );
			var func = (Function2)(object)Marshal.GetDelegateForFunctionPointer ( funPtr, typeof ( Function2 ) );

			uint count = 0;
			func ( arg1, arg2, (IntPtr)(&count), IntPtr.Zero ).CheckError ();

			if ( count == 0 )
				return null;

			TReturn[] values = new TReturn[count];
			var h = GCHandle.Alloc ( values, GCHandleType.Pinned );
			try
			{
				func ( arg1, arg2, (IntPtr)(&count), h.AddrOfPinnedObject () ).CheckError ();
			}
			finally
			{
				h.Free ();
			}
			return values;
		}

		public unsafe static TReturn[] EnumerateToArray<TReturn>(Delegate enumerator, ulong arg1)
			where TReturn : struct
		{
			var funPtr = Marshal.GetFunctionPointerForDelegate ( enumerator );
			var func = (Function3)(object)Marshal.GetDelegateForFunctionPointer ( funPtr, typeof ( Function3 ) );

			uint count = 0;
			func ( arg1, (IntPtr)(&count), IntPtr.Zero ).CheckError ();

			if ( count == 0 )
				return null;

			TReturn[] values = new TReturn[count];
			var h = GCHandle.Alloc ( values, GCHandleType.Pinned );
			try
			{
				func ( arg1, (IntPtr)(&count), h.AddrOfPinnedObject () ).CheckError ();
			}
			finally
			{
				h.Free ();
			}
			return values;
		}

		public unsafe static TReturn[] EnumerateToArray<TReturn>(Delegate enumerator, IntPtr arg1, ulong arg2)
			where TReturn : struct
		{
			var funPtr = Marshal.GetFunctionPointerForDelegate ( enumerator );
			var func = (Function4)(object)Marshal.GetDelegateForFunctionPointer ( funPtr, typeof ( Function4 ) );

			uint count = 0;
			func ( arg1, arg2, (IntPtr)(&count), IntPtr.Zero ).CheckError ();

			if ( count == 0 )
				return null;

			TReturn[] values = new TReturn[count];
			var h = GCHandle.Alloc ( values, GCHandleType.Pinned );
			try
			{
				func ( arg1, arg2, (IntPtr)(&count), h.AddrOfPinnedObject () ).CheckError ();
			}
			finally
			{
				h.Free ();
			}
			return values;
		}
	}
}
