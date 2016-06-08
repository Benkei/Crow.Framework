.class public abstract sealed Crow.Graphics.OpenGl.Class1
{
	.class nested private abstract sealed MyClass
		extends [mscorlib]System.Object
	{
		.method public static void XXX (valuetype Crow.Graphics.OpenGl.data`1<int32> number) cil managed 
		{
			ret
		}
	}

	.method public static int32 Square(int32 number) cil managed
	{
		.maxstack 2
		ldarg.1
		dup
		mul
		ret
	}
}
