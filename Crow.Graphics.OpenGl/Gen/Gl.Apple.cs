using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class AppleAuxDepthStencil
		{
			public enum All
			{
				// GL_AUX_DEPTH_STENCIL_APPLE = 0x8A14
				AuxDepthStencil = unchecked((int)35348),
			}
			public const string NAME_STRING = "GL_APPLE_aux_depth_stencil";
		}
		public partial class AppleClientStorage
		{
			public enum All
			{
				// GL_UNPACK_CLIENT_STORAGE_APPLE = 0x85B2
				UnpackClientStorage = unchecked((int)34226),
			}
			public const string NAME_STRING = "GL_APPLE_client_storage";
		}
		public partial class AppleElementArray
		{
			public enum All
			{
				// GL_ELEMENT_ARRAY_APPLE = 0x8A0C
				ElementArray = unchecked((int)35340),
				// GL_ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D
				ElementArrayType = unchecked((int)35341),
				// GL_ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E
				ElementArrayPointer = unchecked((int)35342),
			}
			public const string NAME_STRING = "GL_APPLE_element_array";
			#region command delegates
			// void glDrawElementArrayAPPLE (GLenum mode, GLint first, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawElementArrayDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count);
			// void glDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DrawRangeElementArrayDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, System.Int32 first, System.Int32 count);
			// void glElementPointerAPPLE (GLenum type, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ElementPointerDelegate (System.UInt32 type, IntPtr pointer);
			// void glMultiDrawElementArrayAPPLE (GLenum mode, GLint* first, GLsizei* count, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawElementArrayDelegate (PrimitiveType mode, IntPtr first, IntPtr count, System.Int32 primcount);
			// void glMultiDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MultiDrawRangeElementArrayDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, IntPtr first, IntPtr count, System.Int32 primcount);
			#endregion // command delegates
			#region commands
			// void glDrawElementArrayAPPLE (GLenum mode, GLint first, GLsizei count)
			public readonly DrawElementArrayDelegate DrawElementArray;
			// void glDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count)
			public readonly DrawRangeElementArrayDelegate DrawRangeElementArray;
			// void glElementPointerAPPLE (GLenum type, void* pointer)
			public readonly ElementPointerDelegate ElementPointer;
			// void glMultiDrawElementArrayAPPLE (GLenum mode, GLint* first, GLsizei* count, GLsizei primcount)
			public readonly MultiDrawElementArrayDelegate MultiDrawElementArray;
			// void glMultiDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount)
			public readonly MultiDrawRangeElementArrayDelegate MultiDrawRangeElementArray;
			#endregion // commands
			public AppleElementArray (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDrawElementArrayAPPLE", out DrawElementArray);
				resolver.LoadHandle ("glDrawRangeElementArrayAPPLE", out DrawRangeElementArray);
				resolver.LoadHandle ("glElementPointerAPPLE", out ElementPointer);
				resolver.LoadHandle ("glMultiDrawElementArrayAPPLE", out MultiDrawElementArray);
				resolver.LoadHandle ("glMultiDrawRangeElementArrayAPPLE", out MultiDrawRangeElementArray);
			}
		}
		public partial class AppleFence
		{
			public enum All
			{
				// GL_DRAW_PIXELS_APPLE = 0x8A0A
				DrawPixels = unchecked((int)35338),
				// GL_FENCE_APPLE = 0x8A0B
				Fence = unchecked((int)35339),
			}
			public const string NAME_STRING = "GL_APPLE_fence";
			#region command delegates
			// void glDeleteFencesAPPLE (GLsizei n, GLuint* fences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteFencesDelegate (System.Int32 n, IntPtr fences);
			// void glFinishFenceAPPLE (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FinishFenceDelegate (System.UInt32 fence);
			// void glFinishObjectAPPLE (GLenum object, GLint name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FinishObjectDelegate (System.UInt32 @object, System.Int32 name);
			// void glGenFencesAPPLE (GLsizei n, GLuint* fences)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenFencesDelegate (System.Int32 n, IntPtr fences);
			// GLboolean glIsFenceAPPLE (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsFenceDelegate (System.UInt32 fence);
			// void glSetFenceAPPLE (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SetFenceDelegate (System.UInt32 fence);
			// GLboolean glTestFenceAPPLE (GLuint fence)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean TestFenceDelegate (System.UInt32 fence);
			// GLboolean glTestObjectAPPLE (GLenum object, GLuint name)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean TestObjectDelegate (System.UInt32 @object, System.UInt32 name);
			#endregion // command delegates
			#region commands
			// void glDeleteFencesAPPLE (GLsizei n, GLuint* fences)
			public readonly DeleteFencesDelegate DeleteFences;
			// void glFinishFenceAPPLE (GLuint fence)
			public readonly FinishFenceDelegate FinishFence;
			// void glFinishObjectAPPLE (GLenum object, GLint name)
			public readonly FinishObjectDelegate FinishObject;
			// void glGenFencesAPPLE (GLsizei n, GLuint* fences)
			public readonly GenFencesDelegate GenFences;
			// GLboolean glIsFenceAPPLE (GLuint fence)
			public readonly IsFenceDelegate IsFence;
			// void glSetFenceAPPLE (GLuint fence)
			public readonly SetFenceDelegate SetFence;
			// GLboolean glTestFenceAPPLE (GLuint fence)
			public readonly TestFenceDelegate TestFence;
			// GLboolean glTestObjectAPPLE (GLenum object, GLuint name)
			public readonly TestObjectDelegate TestObject;
			#endregion // commands
			public AppleFence (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDeleteFencesAPPLE", out DeleteFences);
				resolver.LoadHandle ("glFinishFenceAPPLE", out FinishFence);
				resolver.LoadHandle ("glFinishObjectAPPLE", out FinishObject);
				resolver.LoadHandle ("glGenFencesAPPLE", out GenFences);
				resolver.LoadHandle ("glIsFenceAPPLE", out IsFence);
				resolver.LoadHandle ("glSetFenceAPPLE", out SetFence);
				resolver.LoadHandle ("glTestFenceAPPLE", out TestFence);
				resolver.LoadHandle ("glTestObjectAPPLE", out TestObject);
			}
		}
		public partial class AppleFloatPixels
		{
			public enum All
			{
				// GL_HALF_APPLE = 0x140B
				Half = unchecked((int)5131),
				// GL_RGBA_FLOAT32_APPLE = 0x8814
				RgbaFloat32 = unchecked((int)34836),
				// GL_RGB_FLOAT32_APPLE = 0x8815
				RgbFloat32 = unchecked((int)34837),
				// GL_ALPHA_FLOAT32_APPLE = 0x8816
				AlphaFloat32 = unchecked((int)34838),
				// GL_INTENSITY_FLOAT32_APPLE = 0x8817
				IntensityFloat32 = unchecked((int)34839),
				// GL_LUMINANCE_FLOAT32_APPLE = 0x8818
				LuminanceFloat32 = unchecked((int)34840),
				// GL_LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819
				LuminanceAlphaFloat32 = unchecked((int)34841),
				// GL_RGBA_FLOAT16_APPLE = 0x881A
				RgbaFloat16 = unchecked((int)34842),
				// GL_RGB_FLOAT16_APPLE = 0x881B
				RgbFloat16 = unchecked((int)34843),
				// GL_ALPHA_FLOAT16_APPLE = 0x881C
				AlphaFloat16 = unchecked((int)34844),
				// GL_INTENSITY_FLOAT16_APPLE = 0x881D
				IntensityFloat16 = unchecked((int)34845),
				// GL_LUMINANCE_FLOAT16_APPLE = 0x881E
				LuminanceFloat16 = unchecked((int)34846),
				// GL_LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F
				LuminanceAlphaFloat16 = unchecked((int)34847),
				// GL_COLOR_FLOAT_APPLE = 0x8A0F
				ColorFloat = unchecked((int)35343),
			}
			public const string NAME_STRING = "GL_APPLE_float_pixels";
		}
		public partial class AppleFlushBufferRange
		{
			public enum All
			{
				// GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12
				BufferSerializedModify = unchecked((int)35346),
				// GL_BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13
				BufferFlushingUnmap = unchecked((int)35347),
			}
			public const string NAME_STRING = "GL_APPLE_flush_buffer_range";
			#region command delegates
			// void glBufferParameteriAPPLE (GLenum target, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BufferParameteriDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
			// void glFlushMappedBufferRangeAPPLE (GLenum target, GLintptr offset, GLsizeiptr size)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushMappedBufferRangeDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size);
			#endregion // command delegates
			#region commands
			// void glBufferParameteriAPPLE (GLenum target, GLenum pname, GLint param)
			public readonly BufferParameteriDelegate BufferParameteri;
			// void glFlushMappedBufferRangeAPPLE (GLenum target, GLintptr offset, GLsizeiptr size)
			public readonly FlushMappedBufferRangeDelegate FlushMappedBufferRange;
			#endregion // commands
			public AppleFlushBufferRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBufferParameteriAPPLE", out BufferParameteri);
				resolver.LoadHandle ("glFlushMappedBufferRangeAPPLE", out FlushMappedBufferRange);
			}
		}
		public partial class AppleObjectPurgeable
		{
			public enum All
			{
				// GL_BUFFER_OBJECT_APPLE = 0x85B3
				BufferObject = unchecked((int)34227),
				// GL_RELEASED_APPLE = 0x8A19
				Released = unchecked((int)35353),
				// GL_VOLATILE_APPLE = 0x8A1A
				Volatile = unchecked((int)35354),
				// GL_RETAINED_APPLE = 0x8A1B
				Retained = unchecked((int)35355),
				// GL_UNDEFINED_APPLE = 0x8A1C
				Undefined = unchecked((int)35356),
				// GL_PURGEABLE_APPLE = 0x8A1D
				Purgeable = unchecked((int)35357),
			}
			public const string NAME_STRING = "GL_APPLE_object_purgeable";
			#region command delegates
			// void glGetObjectParameterivAPPLE (GLenum objectType, GLuint name, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetObjectParameterivDelegate (System.UInt32 objectType, System.UInt32 name, System.UInt32 pname, IntPtr @params);
			// GLenum glObjectPurgeableAPPLE (GLenum objectType, GLuint name, GLenum option)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 ObjectPurgeableDelegate (System.UInt32 objectType, StringPtr name, System.UInt32 option);
			// GLenum glObjectUnpurgeableAPPLE (GLenum objectType, GLuint name, GLenum option)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 ObjectUnpurgeableDelegate (System.UInt32 objectType, StringPtr name, System.UInt32 option);
			#endregion // command delegates
			#region commands
			// void glGetObjectParameterivAPPLE (GLenum objectType, GLuint name, GLenum pname, GLint* params)
			public readonly GetObjectParameterivDelegate GetObjectParameteriv;
			// GLenum glObjectPurgeableAPPLE (GLenum objectType, GLuint name, GLenum option)
			public readonly ObjectPurgeableDelegate ObjectPurgeable;
			// GLenum glObjectUnpurgeableAPPLE (GLenum objectType, GLuint name, GLenum option)
			public readonly ObjectUnpurgeableDelegate ObjectUnpurgeable;
			#endregion // commands
			public AppleObjectPurgeable (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetObjectParameterivAPPLE", out GetObjectParameteriv);
				resolver.LoadHandle ("glObjectPurgeableAPPLE", out ObjectPurgeable);
				resolver.LoadHandle ("glObjectUnpurgeableAPPLE", out ObjectUnpurgeable);
			}
		}
		public partial class AppleRgb422
		{
			public enum All
			{
				// GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
				UnsignedShort88 = unchecked((int)34234),
				// GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
				UnsignedShort88Rev = unchecked((int)34235),
				// GL_RGB_422_APPLE = 0x8A1F
				Rgb422 = unchecked((int)35359),
				// GL_RGB_RAW_422_APPLE = 0x8A51
				RgbRaw422 = unchecked((int)35409),
			}
			public const string NAME_STRING = "GL_APPLE_rgb_422";
		}
		public partial class AppleRowBytes
		{
			public enum All
			{
				// GL_PACK_ROW_BYTES_APPLE = 0x8A15
				PackRowBytes = unchecked((int)35349),
				// GL_UNPACK_ROW_BYTES_APPLE = 0x8A16
				UnpackRowBytes = unchecked((int)35350),
			}
			public const string NAME_STRING = "GL_APPLE_row_bytes";
		}
		public partial class AppleSpecularVector
		{
			public enum All
			{
				// GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0
				LightModelSpecularVector = unchecked((int)34224),
			}
			public const string NAME_STRING = "GL_APPLE_specular_vector";
		}
		public partial class AppleTextureRange
		{
			public enum All
			{
				// GL_TEXTURE_RANGE_LENGTH_APPLE = 0x85B7
				TextureRangeLength = unchecked((int)34231),
				// GL_TEXTURE_RANGE_POINTER_APPLE = 0x85B8
				TextureRangePointer = unchecked((int)34232),
				// GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
				TextureStorageHint = unchecked((int)34236),
				// GL_STORAGE_PRIVATE_APPLE = 0x85BD
				StoragePrivate = unchecked((int)34237),
				// GL_STORAGE_CACHED_APPLE = 0x85BE
				StorageCached = unchecked((int)34238),
				// GL_STORAGE_SHARED_APPLE = 0x85BF
				StorageShared = unchecked((int)34239),
			}
			public const string NAME_STRING = "GL_APPLE_texture_range";
			#region command delegates
			// void glGetTexParameterPointervAPPLE (GLenum target, GLenum pname, void** params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetTexParameterPointervDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
			// void glTextureRangeAPPLE (GLenum target, GLsizei length, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TextureRangeDelegate (System.UInt32 target, System.Int32 length, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glGetTexParameterPointervAPPLE (GLenum target, GLenum pname, void** params)
			public readonly GetTexParameterPointervDelegate GetTexParameterPointerv;
			// void glTextureRangeAPPLE (GLenum target, GLsizei length, void* pointer)
			public readonly TextureRangeDelegate TextureRange;
			#endregion // commands
			public AppleTextureRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetTexParameterPointervAPPLE", out GetTexParameterPointerv);
				resolver.LoadHandle ("glTextureRangeAPPLE", out TextureRange);
			}
		}
		public partial class AppleTransformHint
		{
			public enum All
			{
				// GL_TRANSFORM_HINT_APPLE = 0x85B1
				TransformHint = unchecked((int)34225),
			}
			public const string NAME_STRING = "GL_APPLE_transform_hint";
		}
		public partial class AppleVertexArrayObject
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_BINDING_APPLE = 0x85B5
				VertexArrayBinding = unchecked((int)34229),
			}
			public const string NAME_STRING = "GL_APPLE_vertex_array_object";
			#region command delegates
			// void glBindVertexArrayAPPLE (GLuint array)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void BindVertexArrayDelegate (System.UInt32 array);
			// void glDeleteVertexArraysAPPLE (GLsizei n, GLuint* arrays)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteVertexArraysDelegate (System.Int32 n, IntPtr arrays);
			// void glGenVertexArraysAPPLE (GLsizei n, GLuint* arrays)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GenVertexArraysDelegate (System.Int32 n, IntPtr arrays);
			// GLboolean glIsVertexArrayAPPLE (GLuint array)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsVertexArrayDelegate (System.UInt32 array);
			#endregion // command delegates
			#region commands
			// void glBindVertexArrayAPPLE (GLuint array)
			public readonly BindVertexArrayDelegate BindVertexArray;
			// void glDeleteVertexArraysAPPLE (GLsizei n, GLuint* arrays)
			public readonly DeleteVertexArraysDelegate DeleteVertexArrays;
			// void glGenVertexArraysAPPLE (GLsizei n, GLuint* arrays)
			public readonly GenVertexArraysDelegate GenVertexArrays;
			// GLboolean glIsVertexArrayAPPLE (GLuint array)
			public readonly IsVertexArrayDelegate IsVertexArray;
			#endregion // commands
			public AppleVertexArrayObject (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glBindVertexArrayAPPLE", out BindVertexArray);
				resolver.LoadHandle ("glDeleteVertexArraysAPPLE", out DeleteVertexArrays);
				resolver.LoadHandle ("glGenVertexArraysAPPLE", out GenVertexArrays);
				resolver.LoadHandle ("glIsVertexArrayAPPLE", out IsVertexArray);
			}
		}
		public partial class AppleVertexArrayRange
		{
			public enum All
			{
				// GL_VERTEX_ARRAY_RANGE_APPLE = 0x851D
				VertexArrayRange = unchecked((int)34077),
				// GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E
				VertexArrayRangeLength = unchecked((int)34078),
				// GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
				VertexArrayStorageHint = unchecked((int)34079),
				// GL_VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521
				VertexArrayRangePointer = unchecked((int)34081),
				// GL_STORAGE_CLIENT_APPLE = 0x85B4
				StorageClient = unchecked((int)34228),
			}
			public const string NAME_STRING = "GL_APPLE_vertex_array_range";
			#region command delegates
			// void glFlushVertexArrayRangeAPPLE (GLsizei length, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushVertexArrayRangeDelegate (System.Int32 length, IntPtr pointer);
			// void glVertexArrayParameteriAPPLE (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayParameteriDelegate (System.UInt32 pname, System.Int32 param);
			// void glVertexArrayRangeAPPLE (GLsizei length, void* pointer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void VertexArrayRangeDelegate (System.Int32 length, IntPtr pointer);
			#endregion // command delegates
			#region commands
			// void glFlushVertexArrayRangeAPPLE (GLsizei length, void* pointer)
			public readonly FlushVertexArrayRangeDelegate FlushVertexArrayRange;
			// void glVertexArrayParameteriAPPLE (GLenum pname, GLint param)
			public readonly VertexArrayParameteriDelegate VertexArrayParameteri;
			// void glVertexArrayRangeAPPLE (GLsizei length, void* pointer)
			public readonly VertexArrayRangeDelegate VertexArrayRange;
			#endregion // commands
			public AppleVertexArrayRange (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFlushVertexArrayRangeAPPLE", out FlushVertexArrayRange);
				resolver.LoadHandle ("glVertexArrayParameteriAPPLE", out VertexArrayParameteri);
				resolver.LoadHandle ("glVertexArrayRangeAPPLE", out VertexArrayRange);
			}
		}
		public partial class AppleVertexProgramEvaluators
		{
			public enum All
			{
				// GL_VERTEX_ATTRIB_MAP1_APPLE = 0x8A00
				VertexAttribMap1 = unchecked((int)35328),
				// GL_VERTEX_ATTRIB_MAP2_APPLE = 0x8A01
				VertexAttribMap2 = unchecked((int)35329),
				// GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02
				VertexAttribMap1Size = unchecked((int)35330),
				// GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03
				VertexAttribMap1Coeff = unchecked((int)35331),
				// GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04
				VertexAttribMap1Order = unchecked((int)35332),
				// GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05
				VertexAttribMap1Domain = unchecked((int)35333),
				// GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06
				VertexAttribMap2Size = unchecked((int)35334),
				// GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07
				VertexAttribMap2Coeff = unchecked((int)35335),
				// GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08
				VertexAttribMap2Order = unchecked((int)35336),
				// GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09
				VertexAttribMap2Domain = unchecked((int)35337),
			}
			public const string NAME_STRING = "GL_APPLE_vertex_program_evaluators";
			#region command delegates
			// void glDisableVertexAttribAPPLE (GLuint index, GLenum pname)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DisableVertexAttribDelegate (System.UInt32 index, System.UInt32 pname);
			// void glEnableVertexAttribAPPLE (GLuint index, GLenum pname)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void EnableVertexAttribDelegate (System.UInt32 index, System.UInt32 pname);
			// GLboolean glIsVertexAttribEnabledAPPLE (GLuint index, GLenum pname)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsVertexAttribEnabledDelegate (System.UInt32 index, System.UInt32 pname);
			// void glMapVertexAttrib1dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapVertexAttrib1dDelegate (System.UInt32 index, System.UInt32 size, System.Double u1, System.Double u2, System.Int32 stride, System.Int32 order, IntPtr points);
			// void glMapVertexAttrib1fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapVertexAttrib1fDelegate (System.UInt32 index, System.UInt32 size, System.Single u1, System.Single u2, System.Int32 stride, System.Int32 order, IntPtr points);
			// void glMapVertexAttrib2dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapVertexAttrib2dDelegate (System.UInt32 index, System.UInt32 size, System.Double u1, System.Double u2, System.Int32 ustride, System.Int32 uorder, System.Double v1, System.Double v2, System.Int32 vstride, System.Int32 vorder, IntPtr points);
			// void glMapVertexAttrib2fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void MapVertexAttrib2fDelegate (System.UInt32 index, System.UInt32 size, System.Single u1, System.Single u2, System.Int32 ustride, System.Int32 uorder, System.Single v1, System.Single v2, System.Int32 vstride, System.Int32 vorder, IntPtr points);
			#endregion // command delegates
			#region commands
			// void glDisableVertexAttribAPPLE (GLuint index, GLenum pname)
			public readonly DisableVertexAttribDelegate DisableVertexAttrib;
			// void glEnableVertexAttribAPPLE (GLuint index, GLenum pname)
			public readonly EnableVertexAttribDelegate EnableVertexAttrib;
			// GLboolean glIsVertexAttribEnabledAPPLE (GLuint index, GLenum pname)
			public readonly IsVertexAttribEnabledDelegate IsVertexAttribEnabled;
			// void glMapVertexAttrib1dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points)
			public readonly MapVertexAttrib1dDelegate MapVertexAttrib1d;
			// void glMapVertexAttrib1fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points)
			public readonly MapVertexAttrib1fDelegate MapVertexAttrib1f;
			// void glMapVertexAttrib2dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points)
			public readonly MapVertexAttrib2dDelegate MapVertexAttrib2d;
			// void glMapVertexAttrib2fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points)
			public readonly MapVertexAttrib2fDelegate MapVertexAttrib2f;
			#endregion // commands
			public AppleVertexProgramEvaluators (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDisableVertexAttribAPPLE", out DisableVertexAttrib);
				resolver.LoadHandle ("glEnableVertexAttribAPPLE", out EnableVertexAttrib);
				resolver.LoadHandle ("glIsVertexAttribEnabledAPPLE", out IsVertexAttribEnabled);
				resolver.LoadHandle ("glMapVertexAttrib1dAPPLE", out MapVertexAttrib1d);
				resolver.LoadHandle ("glMapVertexAttrib1fAPPLE", out MapVertexAttrib1f);
				resolver.LoadHandle ("glMapVertexAttrib2dAPPLE", out MapVertexAttrib2d);
				resolver.LoadHandle ("glMapVertexAttrib2fAPPLE", out MapVertexAttrib2f);
			}
		}
		public partial class AppleYcbcr422
		{
			public enum All
			{
				// GL_YCBCR_422_APPLE = 0x85B9
				Ycbcr422 = unchecked((int)34233),
			}
			public const string NAME_STRING = "GL_APPLE_ycbcr_422";
		}
	}
}

