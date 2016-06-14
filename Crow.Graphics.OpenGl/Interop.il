.class public OpenGl.Ptr`1<valuetype .ctor ([mscorlib]System.ValueType) T>
	extends [mscorlib]System.ValueType
{
	.method private static int32 _Size () cil managed
	{
		.maxstack 1
		sizeof !T
		ret
	}

	//value = *(Muh*)(Pointer + byteOffset);
	.method public int32 Read (int32 byteOffset,[out] !T& 'value') cil managed
	{
		ldarg.2
		ldarg.0
		ldfld native int valuetype OpenGl.Ptr`1<!T>::Pointer
		ldarg.1
		call native int [mscorlib]System.IntPtr::op_Addition(native int, int32)
		call void* [mscorlib]System.IntPtr::op_Explicit(native int)
		ldobj !T
		stobj !T
		ret
	}

	//*(T*)(Pointer + byteOffset) = value;
	.method public int32 Write (int32 byteOffset,[in] !T& 'value') cil managed
	{
		ldarg.0
		ldfld native int valuetype OpenGl.Ptr`1<!T>::Pointer
		ldarg.1
		call native int [mscorlib]System.IntPtr::op_Addition(native int, int32)
		call void* [mscorlib]System.IntPtr::op_Explicit(native int)
		ldarg.2
		ldobj !T
		stobj !T
		ret
	}
}
