using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public partial class SgixAsync
		{
			public enum All
			{
				// GL_ASYNC_MARKER_SGIX = 0x8329
				AsyncMarker = unchecked((int)33577),
			}
			public const string NAME_STRING = "GL_SGIX_async";
			#region command delegates
			// void glAsyncMarkerSGIX (GLuint marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void AsyncMarkerDelegate (System.UInt32 marker);
			// void glDeleteAsyncMarkersSGIX (GLuint marker, GLsizei range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeleteAsyncMarkersDelegate (System.UInt32 marker, System.Int32 range);
			// GLint glFinishAsyncSGIX (GLuint* markerp)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 FinishAsyncDelegate (IntPtr markerp);
			// GLuint glGenAsyncMarkersSGIX (GLsizei range)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.UInt32 GenAsyncMarkersDelegate (System.Int32 range);
			// GLboolean glIsAsyncMarkerSGIX (GLuint marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate Boolean IsAsyncMarkerDelegate (System.UInt32 marker);
			// GLint glPollAsyncSGIX (GLuint* markerp)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 PollAsyncDelegate (IntPtr markerp);
			#endregion // command delegates
			#region commands
			// void glAsyncMarkerSGIX (GLuint marker)
			public readonly AsyncMarkerDelegate AsyncMarker;
			// void glDeleteAsyncMarkersSGIX (GLuint marker, GLsizei range)
			public readonly DeleteAsyncMarkersDelegate DeleteAsyncMarkers;
			// GLint glFinishAsyncSGIX (GLuint* markerp)
			public readonly FinishAsyncDelegate FinishAsync;
			// GLuint glGenAsyncMarkersSGIX (GLsizei range)
			public readonly GenAsyncMarkersDelegate GenAsyncMarkers;
			// GLboolean glIsAsyncMarkerSGIX (GLuint marker)
			public readonly IsAsyncMarkerDelegate IsAsyncMarker;
			// GLint glPollAsyncSGIX (GLuint* markerp)
			public readonly PollAsyncDelegate PollAsync;
			#endregion // commands
			public SgixAsync (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glAsyncMarkerSGIX", out AsyncMarker);
				resolver.LoadHandle ("glDeleteAsyncMarkersSGIX", out DeleteAsyncMarkers);
				resolver.LoadHandle ("glFinishAsyncSGIX", out FinishAsync);
				resolver.LoadHandle ("glGenAsyncMarkersSGIX", out GenAsyncMarkers);
				resolver.LoadHandle ("glIsAsyncMarkerSGIX", out IsAsyncMarker);
				resolver.LoadHandle ("glPollAsyncSGIX", out PollAsync);
			}
		}
		public partial class SgixAsyncHistogram
		{
			public enum All
			{
				// GL_ASYNC_HISTOGRAM_SGIX = 0x832C
				AsyncHistogram = unchecked((int)33580),
				// GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
				MaxAsyncHistogram = unchecked((int)33581),
			}
			public const string NAME_STRING = "GL_SGIX_async_histogram";
		}
		public partial class SgixAsyncPixel
		{
			public enum All
			{
				// GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
				AsyncTexImage = unchecked((int)33628),
				// GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
				AsyncDrawPixels = unchecked((int)33629),
				// GL_ASYNC_READ_PIXELS_SGIX = 0x835E
				AsyncReadPixels = unchecked((int)33630),
				// GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
				MaxAsyncTexImage = unchecked((int)33631),
				// GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
				MaxAsyncDrawPixels = unchecked((int)33632),
				// GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
				MaxAsyncReadPixels = unchecked((int)33633),
			}
			public const string NAME_STRING = "GL_SGIX_async_pixel";
		}
		public partial class SgixBlendAlphaMinmax
		{
			public enum All
			{
				// GL_ALPHA_MIN_SGIX = 0x8320
				AlphaMin = unchecked((int)33568),
				// GL_ALPHA_MAX_SGIX = 0x8321
				AlphaMax = unchecked((int)33569),
			}
			public const string NAME_STRING = "GL_SGIX_blend_alpha_minmax";
		}
		public partial class SgixCalligraphicFragment
		{
			public enum All
			{
				// GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
				CalligraphicFragment = unchecked((int)33155),
			}
			public const string NAME_STRING = "GL_SGIX_calligraphic_fragment";
		}
		public partial class SgixClipmap
		{
			public enum All
			{
				// GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
				LinearClipmapLinear = unchecked((int)33136),
				// GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
				TextureClipmapCenter = unchecked((int)33137),
				// GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
				TextureClipmapFrame = unchecked((int)33138),
				// GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
				TextureClipmapOffset = unchecked((int)33139),
				// GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
				TextureClipmapVirtualDepth = unchecked((int)33140),
				// GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
				TextureClipmapLodOffset = unchecked((int)33141),
				// GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
				TextureClipmapDepth = unchecked((int)33142),
				// GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
				MaxClipmapDepth = unchecked((int)33143),
				// GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
				MaxClipmapVirtualDepth = unchecked((int)33144),
				// GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
				NearestClipmapNearest = unchecked((int)33869),
				// GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
				NearestClipmapLinear = unchecked((int)33870),
				// GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
				LinearClipmapNearest = unchecked((int)33871),
			}
			public const string NAME_STRING = "GL_SGIX_clipmap";
		}
		public partial class SgixConvolutionAccuracy
		{
			public enum All
			{
				// GL_CONVOLUTION_HINT_SGIX = 0x8316
				ConvolutionHint = unchecked((int)33558),
			}
			public const string NAME_STRING = "GL_SGIX_convolution_accuracy";
		}
		public partial class SgixDepthTexture
		{
			public enum All
			{
				// GL_DEPTH_COMPONENT16_SGIX = 0x81A5
				DepthComponent16 = unchecked((int)33189),
				// GL_DEPTH_COMPONENT24_SGIX = 0x81A6
				DepthComponent24 = unchecked((int)33190),
				// GL_DEPTH_COMPONENT32_SGIX = 0x81A7
				DepthComponent32 = unchecked((int)33191),
			}
			public const string NAME_STRING = "GL_SGIX_depth_texture";
		}
		public partial class SgixFlushRaster
		{
			public const string NAME_STRING = "GL_SGIX_flush_raster";
			#region command delegates
			// void glFlushRasterSGIX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FlushRasterDelegate ();
			#endregion // command delegates
			#region commands
			// void glFlushRasterSGIX ()
			public readonly FlushRasterDelegate FlushRaster;
			#endregion // commands
			public SgixFlushRaster (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFlushRasterSGIX", out FlushRaster);
			}
		}
		public partial class SgixFogOffset
		{
			public enum All
			{
				// GL_FOG_OFFSET_SGIX = 0x8198
				FogOffset = unchecked((int)33176),
				// GL_FOG_OFFSET_VALUE_SGIX = 0x8199
				FogOffsetValue = unchecked((int)33177),
			}
			public const string NAME_STRING = "GL_SGIX_fog_offset";
		}
		public partial class SgixFragmentLighting
		{
			public enum All
			{
				// GL_FRAGMENT_LIGHTING_SGIX = 0x8400
				FragmentLighting = unchecked((int)33792),
				// GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
				FragmentColorMaterial = unchecked((int)33793),
				// GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
				FragmentColorMaterialFace = unchecked((int)33794),
				// GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
				FragmentColorMaterialParameter = unchecked((int)33795),
				// GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
				MaxFragmentLights = unchecked((int)33796),
				// GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
				MaxActiveLights = unchecked((int)33797),
				// GL_CURRENT_RASTER_NORMAL_SGIX = 0x8406
				CurrentRasterNormal = unchecked((int)33798),
				// GL_LIGHT_ENV_MODE_SGIX = 0x8407
				LightEnvMode = unchecked((int)33799),
				// GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
				FragmentLightModelLocalViewer = unchecked((int)33800),
				// GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
				FragmentLightModelTwoSide = unchecked((int)33801),
				// GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
				FragmentLightModelAmbient = unchecked((int)33802),
				// GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
				FragmentLightModelNormalInterpolation = unchecked((int)33803),
				// GL_FRAGMENT_LIGHT0_SGIX = 0x840C
				FragmentLight0 = unchecked((int)33804),
				// GL_FRAGMENT_LIGHT1_SGIX = 0x840D
				FragmentLight1 = unchecked((int)33805),
				// GL_FRAGMENT_LIGHT2_SGIX = 0x840E
				FragmentLight2 = unchecked((int)33806),
				// GL_FRAGMENT_LIGHT3_SGIX = 0x840F
				FragmentLight3 = unchecked((int)33807),
				// GL_FRAGMENT_LIGHT4_SGIX = 0x8410
				FragmentLight4 = unchecked((int)33808),
				// GL_FRAGMENT_LIGHT5_SGIX = 0x8411
				FragmentLight5 = unchecked((int)33809),
				// GL_FRAGMENT_LIGHT6_SGIX = 0x8412
				FragmentLight6 = unchecked((int)33810),
				// GL_FRAGMENT_LIGHT7_SGIX = 0x8413
				FragmentLight7 = unchecked((int)33811),
			}
			public const string NAME_STRING = "GL_SGIX_fragment_lighting";
			#region command delegates
			// void glFragmentColorMaterialSGIX (GLenum face, GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentColorMaterialDelegate (MaterialFace face, MaterialParameter mode);
			// void glFragmentLightfSGIX (GLenum light, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightfDelegate (System.UInt32 light, System.UInt32 pname, System.Single param);
			// void glFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightfvDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glFragmentLightiSGIX (GLenum light, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightiDelegate (System.UInt32 light, System.UInt32 pname, System.Int32 param);
			// void glFragmentLightivSGIX (GLenum light, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightivDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glFragmentLightModelfSGIX (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightModelfDelegate (FragmentLightModelParameterSGIX pname, System.Single param);
			// void glFragmentLightModelfvSGIX (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightModelfvDelegate (FragmentLightModelParameterSGIX pname, IntPtr @params);
			// void glFragmentLightModeliSGIX (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightModeliDelegate (FragmentLightModelParameterSGIX pname, System.Int32 param);
			// void glFragmentLightModelivSGIX (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentLightModelivDelegate (FragmentLightModelParameterSGIX pname, IntPtr @params);
			// void glFragmentMaterialfSGIX (GLenum face, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentMaterialfDelegate (MaterialFace face, MaterialParameter pname, System.Single param);
			// void glFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentMaterialfvDelegate (MaterialFace face, MaterialParameter pname, IntPtr @params);
			// void glFragmentMaterialiSGIX (GLenum face, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentMaterialiDelegate (MaterialFace face, MaterialParameter pname, System.Int32 param);
			// void glFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FragmentMaterialivDelegate (MaterialFace face, MaterialParameter pname, IntPtr @params);
			// void glGetFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFragmentLightfvDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glGetFragmentLightivSGIX (GLenum light, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFragmentLightivDelegate (System.UInt32 light, System.UInt32 pname, IntPtr @params);
			// void glGetFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFragmentMaterialfvDelegate (MaterialFace face, MaterialParameter pname, IntPtr @params);
			// void glGetFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetFragmentMaterialivDelegate (MaterialFace face, MaterialParameter pname, IntPtr @params);
			// void glLightEnviSGIX (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LightEnviDelegate (LightEnvParameterSGIX pname, System.Int32 param);
			#endregion // command delegates
			#region commands
			// void glFragmentColorMaterialSGIX (GLenum face, GLenum mode)
			public readonly FragmentColorMaterialDelegate FragmentColorMaterial;
			// void glFragmentLightfSGIX (GLenum light, GLenum pname, GLfloat param)
			public readonly FragmentLightfDelegate FragmentLightf;
			// void glFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat* params)
			public readonly FragmentLightfvDelegate FragmentLightfv;
			// void glFragmentLightiSGIX (GLenum light, GLenum pname, GLint param)
			public readonly FragmentLightiDelegate FragmentLighti;
			// void glFragmentLightivSGIX (GLenum light, GLenum pname, GLint* params)
			public readonly FragmentLightivDelegate FragmentLightiv;
			// void glFragmentLightModelfSGIX (GLenum pname, GLfloat param)
			public readonly FragmentLightModelfDelegate FragmentLightModelf;
			// void glFragmentLightModelfvSGIX (GLenum pname, GLfloat* params)
			public readonly FragmentLightModelfvDelegate FragmentLightModelfv;
			// void glFragmentLightModeliSGIX (GLenum pname, GLint param)
			public readonly FragmentLightModeliDelegate FragmentLightModeli;
			// void glFragmentLightModelivSGIX (GLenum pname, GLint* params)
			public readonly FragmentLightModelivDelegate FragmentLightModeliv;
			// void glFragmentMaterialfSGIX (GLenum face, GLenum pname, GLfloat param)
			public readonly FragmentMaterialfDelegate FragmentMaterialf;
			// void glFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat* params)
			public readonly FragmentMaterialfvDelegate FragmentMaterialfv;
			// void glFragmentMaterialiSGIX (GLenum face, GLenum pname, GLint param)
			public readonly FragmentMaterialiDelegate FragmentMateriali;
			// void glFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint* params)
			public readonly FragmentMaterialivDelegate FragmentMaterialiv;
			// void glGetFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat* params)
			public readonly GetFragmentLightfvDelegate GetFragmentLightfv;
			// void glGetFragmentLightivSGIX (GLenum light, GLenum pname, GLint* params)
			public readonly GetFragmentLightivDelegate GetFragmentLightiv;
			// void glGetFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat* params)
			public readonly GetFragmentMaterialfvDelegate GetFragmentMaterialfv;
			// void glGetFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint* params)
			public readonly GetFragmentMaterialivDelegate GetFragmentMaterialiv;
			// void glLightEnviSGIX (GLenum pname, GLint param)
			public readonly LightEnviDelegate LightEnvi;
			#endregion // commands
			public SgixFragmentLighting (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFragmentColorMaterialSGIX", out FragmentColorMaterial);
				resolver.LoadHandle ("glFragmentLightfSGIX", out FragmentLightf);
				resolver.LoadHandle ("glFragmentLightfvSGIX", out FragmentLightfv);
				resolver.LoadHandle ("glFragmentLightiSGIX", out FragmentLighti);
				resolver.LoadHandle ("glFragmentLightivSGIX", out FragmentLightiv);
				resolver.LoadHandle ("glFragmentLightModelfSGIX", out FragmentLightModelf);
				resolver.LoadHandle ("glFragmentLightModelfvSGIX", out FragmentLightModelfv);
				resolver.LoadHandle ("glFragmentLightModeliSGIX", out FragmentLightModeli);
				resolver.LoadHandle ("glFragmentLightModelivSGIX", out FragmentLightModeliv);
				resolver.LoadHandle ("glFragmentMaterialfSGIX", out FragmentMaterialf);
				resolver.LoadHandle ("glFragmentMaterialfvSGIX", out FragmentMaterialfv);
				resolver.LoadHandle ("glFragmentMaterialiSGIX", out FragmentMateriali);
				resolver.LoadHandle ("glFragmentMaterialivSGIX", out FragmentMaterialiv);
				resolver.LoadHandle ("glGetFragmentLightfvSGIX", out GetFragmentLightfv);
				resolver.LoadHandle ("glGetFragmentLightivSGIX", out GetFragmentLightiv);
				resolver.LoadHandle ("glGetFragmentMaterialfvSGIX", out GetFragmentMaterialfv);
				resolver.LoadHandle ("glGetFragmentMaterialivSGIX", out GetFragmentMaterialiv);
				resolver.LoadHandle ("glLightEnviSGIX", out LightEnvi);
			}
		}
		public partial class SgixFramezoom
		{
			public enum All
			{
				// GL_FRAMEZOOM_SGIX = 0x818B
				Framezoom = unchecked((int)33163),
				// GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
				FramezoomFactor = unchecked((int)33164),
				// GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
				MaxFramezoomFactor = unchecked((int)33165),
			}
			public const string NAME_STRING = "GL_SGIX_framezoom";
			#region command delegates
			// void glFrameZoomSGIX (GLint factor)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void FrameZoomDelegate (System.Int32 factor);
			#endregion // command delegates
			#region commands
			// void glFrameZoomSGIX (GLint factor)
			public readonly FrameZoomDelegate FrameZoom;
			#endregion // commands
			public SgixFramezoom (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glFrameZoomSGIX", out FrameZoom);
			}
		}
		public partial class SgixIglooInterface
		{
			public const string NAME_STRING = "GL_SGIX_igloo_interface";
			#region command delegates
			// void glIglooInterfaceSGIX (GLenum pname, void* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void IglooInterfaceDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glIglooInterfaceSGIX (GLenum pname, void* params)
			public readonly IglooInterfaceDelegate IglooInterface;
			#endregion // commands
			public SgixIglooInterface (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glIglooInterfaceSGIX", out IglooInterface);
			}
		}
		public partial class SgixInstruments
		{
			public enum All
			{
				// GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
				InstrumentBufferPointer = unchecked((int)33152),
				// GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
				InstrumentMeasurements = unchecked((int)33153),
			}
			public const string NAME_STRING = "GL_SGIX_instruments";
			#region command delegates
			// GLint glGetInstrumentsSGIX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 GetInstrumentsDelegate ();
			// void glInstrumentsBufferSGIX (GLsizei size, GLint* buffer)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void InstrumentsBufferDelegate (System.Int32 size, IntPtr buffer);
			// GLint glPollInstrumentsSGIX (GLint* marker_p)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate System.Int32 PollInstrumentsDelegate (IntPtr marker_p);
			// void glReadInstrumentsSGIX (GLint marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReadInstrumentsDelegate (System.Int32 marker);
			// void glStartInstrumentsSGIX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StartInstrumentsDelegate ();
			// void glStopInstrumentsSGIX (GLint marker)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void StopInstrumentsDelegate (System.Int32 marker);
			#endregion // command delegates
			#region commands
			// GLint glGetInstrumentsSGIX ()
			public readonly GetInstrumentsDelegate GetInstruments;
			// void glInstrumentsBufferSGIX (GLsizei size, GLint* buffer)
			public readonly InstrumentsBufferDelegate InstrumentsBuffer;
			// GLint glPollInstrumentsSGIX (GLint* marker_p)
			public readonly PollInstrumentsDelegate PollInstruments;
			// void glReadInstrumentsSGIX (GLint marker)
			public readonly ReadInstrumentsDelegate ReadInstruments;
			// void glStartInstrumentsSGIX ()
			public readonly StartInstrumentsDelegate StartInstruments;
			// void glStopInstrumentsSGIX (GLint marker)
			public readonly StopInstrumentsDelegate StopInstruments;
			#endregion // commands
			public SgixInstruments (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetInstrumentsSGIX", out GetInstruments);
				resolver.LoadHandle ("glInstrumentsBufferSGIX", out InstrumentsBuffer);
				resolver.LoadHandle ("glPollInstrumentsSGIX", out PollInstruments);
				resolver.LoadHandle ("glReadInstrumentsSGIX", out ReadInstruments);
				resolver.LoadHandle ("glStartInstrumentsSGIX", out StartInstruments);
				resolver.LoadHandle ("glStopInstrumentsSGIX", out StopInstruments);
			}
		}
		public partial class SgixInterlace
		{
			public enum All
			{
				// GL_INTERLACE_SGIX = 0x8094
				Interlace = unchecked((int)32916),
			}
			public const string NAME_STRING = "GL_SGIX_interlace";
		}
		public partial class SgixIrInstrument1
		{
			public enum All
			{
				// GL_IR_INSTRUMENT1_SGIX = 0x817F
				IrInstrument1 = unchecked((int)33151),
			}
			public const string NAME_STRING = "GL_SGIX_ir_instrument1";
		}
		public partial class SgixListPriority
		{
			public enum All
			{
				// GL_LIST_PRIORITY_SGIX = 0x8182
				ListPriority = unchecked((int)33154),
			}
			public const string NAME_STRING = "GL_SGIX_list_priority";
			#region command delegates
			// void glGetListParameterfvSGIX (GLuint list, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetListParameterfvDelegate (System.UInt32 list, ListParameterName pname, IntPtr @params);
			// void glGetListParameterivSGIX (GLuint list, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void GetListParameterivDelegate (System.UInt32 list, ListParameterName pname, IntPtr @params);
			// void glListParameterfSGIX (GLuint list, GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ListParameterfDelegate (System.UInt32 list, ListParameterName pname, System.Single param);
			// void glListParameterfvSGIX (GLuint list, GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ListParameterfvDelegate (System.UInt32 list, ListParameterName pname, IntPtr @params);
			// void glListParameteriSGIX (GLuint list, GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ListParameteriDelegate (System.UInt32 list, ListParameterName pname, System.Int32 param);
			// void glListParameterivSGIX (GLuint list, GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ListParameterivDelegate (System.UInt32 list, ListParameterName pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glGetListParameterfvSGIX (GLuint list, GLenum pname, GLfloat* params)
			public readonly GetListParameterfvDelegate GetListParameterfv;
			// void glGetListParameterivSGIX (GLuint list, GLenum pname, GLint* params)
			public readonly GetListParameterivDelegate GetListParameteriv;
			// void glListParameterfSGIX (GLuint list, GLenum pname, GLfloat param)
			public readonly ListParameterfDelegate ListParameterf;
			// void glListParameterfvSGIX (GLuint list, GLenum pname, GLfloat* params)
			public readonly ListParameterfvDelegate ListParameterfv;
			// void glListParameteriSGIX (GLuint list, GLenum pname, GLint param)
			public readonly ListParameteriDelegate ListParameteri;
			// void glListParameterivSGIX (GLuint list, GLenum pname, GLint* params)
			public readonly ListParameterivDelegate ListParameteriv;
			#endregion // commands
			public SgixListPriority (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glGetListParameterfvSGIX", out GetListParameterfv);
				resolver.LoadHandle ("glGetListParameterivSGIX", out GetListParameteriv);
				resolver.LoadHandle ("glListParameterfSGIX", out ListParameterf);
				resolver.LoadHandle ("glListParameterfvSGIX", out ListParameterfv);
				resolver.LoadHandle ("glListParameteriSGIX", out ListParameteri);
				resolver.LoadHandle ("glListParameterivSGIX", out ListParameteriv);
			}
		}
		public partial class SgixPixelTexture
		{
			public enum All
			{
				// GL_PIXEL_TEX_GEN_SGIX = 0x8139
				PixelTexGen = unchecked((int)33081),
				// GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
				PixelTexGenMode = unchecked((int)33579),
			}
			public const string NAME_STRING = "GL_SGIX_pixel_texture";
			#region command delegates
			// void glPixelTexGenSGIX (GLenum mode)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void PixelTexGenDelegate (System.UInt32 mode);
			#endregion // command delegates
			#region commands
			// void glPixelTexGenSGIX (GLenum mode)
			public readonly PixelTexGenDelegate PixelTexGen;
			#endregion // commands
			public SgixPixelTexture (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glPixelTexGenSGIX", out PixelTexGen);
			}
		}
		public partial class SgixPixelTiles
		{
			public enum All
			{
				// GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
				PixelTileBestAlignment = unchecked((int)33086),
				// GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
				PixelTileCacheIncrement = unchecked((int)33087),
				// GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
				PixelTileWidth = unchecked((int)33088),
				// GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
				PixelTileHeight = unchecked((int)33089),
				// GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
				PixelTileGridWidth = unchecked((int)33090),
				// GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
				PixelTileGridHeight = unchecked((int)33091),
				// GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
				PixelTileGridDepth = unchecked((int)33092),
				// GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
				PixelTileCacheSize = unchecked((int)33093),
			}
			public const string NAME_STRING = "GL_SGIX_pixel_tiles";
		}
		public partial class SgixPolynomialFfd
		{
			public enum All
			{
				// GL_TEXTURE_DEFORMATION_BIT_SGIX = 0x1
				TextureDeformationBit = unchecked((int)1),
				// GL_GEOMETRY_DEFORMATION_BIT_SGIX = 0x2
				GeometryDeformationBit = unchecked((int)2),
				// GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
				GeometryDeformation = unchecked((int)33172),
				// GL_TEXTURE_DEFORMATION_SGIX = 0x8195
				TextureDeformation = unchecked((int)33173),
				// GL_DEFORMATIONS_MASK_SGIX = 0x8196
				DeformationsMask = unchecked((int)33174),
				// GL_MAX_DEFORMATION_ORDER_SGIX = 0x8197
				MaxDeformationOrder = unchecked((int)33175),
			}
			public const string NAME_STRING = "GL_SGIX_polynomial_ffd";
			#region command delegates
			// void glDeformationMap3dSGIX (GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeformationMap3dDelegate (FfdTargetSGIX target, System.Double u1, System.Double u2, System.Int32 ustride, System.Int32 uorder, System.Double v1, System.Double v2, System.Int32 vstride, System.Int32 vorder, System.Double w1, System.Double w2, System.Int32 wstride, System.Int32 worder, IntPtr points);
			// void glDeformationMap3fSGIX (GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeformationMap3fDelegate (FfdTargetSGIX target, System.Single u1, System.Single u2, System.Int32 ustride, System.Int32 uorder, System.Single v1, System.Single v2, System.Int32 vstride, System.Int32 vorder, System.Single w1, System.Single w2, System.Int32 wstride, System.Int32 worder, IntPtr points);
			// void glDeformSGIX (GLbitfield mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void DeformDelegate (FfdMaskSGIX mask);
			// void glLoadIdentityDeformationMapSGIX (GLbitfield mask)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void LoadIdentityDeformationMapDelegate (FfdMaskSGIX mask);
			#endregion // command delegates
			#region commands
			// void glDeformationMap3dSGIX (GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points)
			public readonly DeformationMap3dDelegate DeformationMap3d;
			// void glDeformationMap3fSGIX (GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points)
			public readonly DeformationMap3fDelegate DeformationMap3f;
			// void glDeformSGIX (GLbitfield mask)
			public readonly DeformDelegate Deform;
			// void glLoadIdentityDeformationMapSGIX (GLbitfield mask)
			public readonly LoadIdentityDeformationMapDelegate LoadIdentityDeformationMap;
			#endregion // commands
			public SgixPolynomialFfd (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glDeformationMap3dSGIX", out DeformationMap3d);
				resolver.LoadHandle ("glDeformationMap3fSGIX", out DeformationMap3f);
				resolver.LoadHandle ("glDeformSGIX", out Deform);
				resolver.LoadHandle ("glLoadIdentityDeformationMapSGIX", out LoadIdentityDeformationMap);
			}
		}
		public partial class SgixReferencePlane
		{
			public enum All
			{
				// GL_REFERENCE_PLANE_SGIX = 0x817D
				ReferencePlane = unchecked((int)33149),
				// GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
				ReferencePlaneEquation = unchecked((int)33150),
			}
			public const string NAME_STRING = "GL_SGIX_reference_plane";
			#region command delegates
			// void glReferencePlaneSGIX (GLdouble* equation)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void ReferencePlaneDelegate (IntPtr equation);
			#endregion // command delegates
			#region commands
			// void glReferencePlaneSGIX (GLdouble* equation)
			public readonly ReferencePlaneDelegate ReferencePlane;
			#endregion // commands
			public SgixReferencePlane (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glReferencePlaneSGIX", out ReferencePlane);
			}
		}
		public partial class SgixResample
		{
			public enum All
			{
				// GL_PACK_RESAMPLE_SGIX = 0x842E
				PackResample = unchecked((int)33838),
				// GL_UNPACK_RESAMPLE_SGIX = 0x842F
				UnpackResample = unchecked((int)33839),
				// GL_RESAMPLE_DECIMATE_SGIX = 0x8430
				ResampleDecimate = unchecked((int)33840),
				// GL_RESAMPLE_REPLICATE_SGIX = 0x8433
				ResampleReplicate = unchecked((int)33843),
				// GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
				ResampleZeroFill = unchecked((int)33844),
			}
			public const string NAME_STRING = "GL_SGIX_resample";
		}
		public partial class SgixScalebiasHint
		{
			public enum All
			{
				// GL_SCALEBIAS_HINT_SGIX = 0x8322
				ScalebiasHint = unchecked((int)33570),
			}
			public const string NAME_STRING = "GL_SGIX_scalebias_hint";
		}
		public partial class SgixShadow
		{
			public enum All
			{
				// GL_TEXTURE_COMPARE_SGIX = 0x819A
				TextureCompare = unchecked((int)33178),
				// GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
				TextureCompareOperator = unchecked((int)33179),
				// GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
				TextureLequalR = unchecked((int)33180),
				// GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
				TextureGequalR = unchecked((int)33181),
			}
			public const string NAME_STRING = "GL_SGIX_shadow";
		}
		public partial class SgixShadowAmbient
		{
			public enum All
			{
				// GL_SHADOW_AMBIENT_SGIX = 0x80BF
				ShadowAmbient = unchecked((int)32959),
			}
			public const string NAME_STRING = "GL_SGIX_shadow_ambient";
		}
		public partial class SgixSprite
		{
			public enum All
			{
				// GL_SPRITE_SGIX = 0x8148
				Sprite = unchecked((int)33096),
				// GL_SPRITE_MODE_SGIX = 0x8149
				SpriteMode = unchecked((int)33097),
				// GL_SPRITE_AXIS_SGIX = 0x814A
				SpriteAxis = unchecked((int)33098),
				// GL_SPRITE_TRANSLATION_SGIX = 0x814B
				SpriteTranslation = unchecked((int)33099),
				// GL_SPRITE_AXIAL_SGIX = 0x814C
				SpriteAxial = unchecked((int)33100),
				// GL_SPRITE_OBJECT_ALIGNED_SGIX = 0x814D
				SpriteObjectAligned = unchecked((int)33101),
				// GL_SPRITE_EYE_ALIGNED_SGIX = 0x814E
				SpriteEyeAligned = unchecked((int)33102),
			}
			public const string NAME_STRING = "GL_SGIX_sprite";
			#region command delegates
			// void glSpriteParameterfSGIX (GLenum pname, GLfloat param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SpriteParameterfDelegate (System.UInt32 pname, System.Single param);
			// void glSpriteParameterfvSGIX (GLenum pname, GLfloat* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SpriteParameterfvDelegate (System.UInt32 pname, IntPtr @params);
			// void glSpriteParameteriSGIX (GLenum pname, GLint param)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SpriteParameteriDelegate (System.UInt32 pname, System.Int32 param);
			// void glSpriteParameterivSGIX (GLenum pname, GLint* params)
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void SpriteParameterivDelegate (System.UInt32 pname, IntPtr @params);
			#endregion // command delegates
			#region commands
			// void glSpriteParameterfSGIX (GLenum pname, GLfloat param)
			public readonly SpriteParameterfDelegate SpriteParameterf;
			// void glSpriteParameterfvSGIX (GLenum pname, GLfloat* params)
			public readonly SpriteParameterfvDelegate SpriteParameterfv;
			// void glSpriteParameteriSGIX (GLenum pname, GLint param)
			public readonly SpriteParameteriDelegate SpriteParameteri;
			// void glSpriteParameterivSGIX (GLenum pname, GLint* params)
			public readonly SpriteParameterivDelegate SpriteParameteriv;
			#endregion // commands
			public SgixSprite (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glSpriteParameterfSGIX", out SpriteParameterf);
				resolver.LoadHandle ("glSpriteParameterfvSGIX", out SpriteParameterfv);
				resolver.LoadHandle ("glSpriteParameteriSGIX", out SpriteParameteri);
				resolver.LoadHandle ("glSpriteParameterivSGIX", out SpriteParameteriv);
			}
		}
		public partial class SgixSubsample
		{
			public enum All
			{
				// GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
				PackSubsampleRate = unchecked((int)34208),
				// GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
				UnpackSubsampleRate = unchecked((int)34209),
				// GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
				PixelSubsample4444 = unchecked((int)34210),
				// GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
				PixelSubsample2424 = unchecked((int)34211),
				// GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
				PixelSubsample4242 = unchecked((int)34212),
			}
			public const string NAME_STRING = "GL_SGIX_subsample";
		}
		public partial class SgixTagSampleBuffer
		{
			public const string NAME_STRING = "GL_SGIX_tag_sample_buffer";
			#region command delegates
			// void glTagSampleBufferSGIX ()
			[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
			public delegate void TagSampleBufferDelegate ();
			#endregion // command delegates
			#region commands
			// void glTagSampleBufferSGIX ()
			public readonly TagSampleBufferDelegate TagSampleBuffer;
			#endregion // commands
			public SgixTagSampleBuffer (IHandleResolver resolver)
			{
				if (resolver == null) throw new ArgumentNullException ("resolver");
				resolver.LoadHandle ("glTagSampleBufferSGIX", out TagSampleBuffer);
			}
		}
		public partial class SgixTextureAddEnv
		{
			public enum All
			{
				// GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
				TextureEnvBias = unchecked((int)32958),
			}
			public const string NAME_STRING = "GL_SGIX_texture_add_env";
		}
		public partial class SgixTextureCoordinateClamp
		{
			public enum All
			{
				// GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
				TextureMaxClampS = unchecked((int)33641),
				// GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
				TextureMaxClampT = unchecked((int)33642),
				// GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
				TextureMaxClampR = unchecked((int)33643),
			}
			public const string NAME_STRING = "GL_SGIX_texture_coordinate_clamp";
		}
		public partial class SgixTextureLodBias
		{
			public enum All
			{
				// GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
				TextureLodBiasS = unchecked((int)33166),
				// GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
				TextureLodBiasT = unchecked((int)33167),
				// GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
				TextureLodBiasR = unchecked((int)33168),
			}
			public const string NAME_STRING = "GL_SGIX_texture_lod_bias";
		}
		public partial class SgixTextureMultiBuffer
		{
			public enum All
			{
				// GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
				TextureMultiBufferHint = unchecked((int)33070),
			}
			public const string NAME_STRING = "GL_SGIX_texture_multi_buffer";
		}
		public partial class SgixTextureScaleBias
		{
			public enum All
			{
				// GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
				PostTextureFilterBias = unchecked((int)33145),
				// GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
				PostTextureFilterScale = unchecked((int)33146),
				// GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
				PostTextureFilterBiasRange = unchecked((int)33147),
				// GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
				PostTextureFilterScaleRange = unchecked((int)33148),
			}
			public const string NAME_STRING = "GL_SGIX_texture_scale_bias";
		}
		public partial class SgixVertexPreclip
		{
			public enum All
			{
				// GL_VERTEX_PRECLIP_SGIX = 0x83EE
				VertexPreclip = unchecked((int)33774),
				// GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
				VertexPreclipHint = unchecked((int)33775),
			}
			public const string NAME_STRING = "GL_SGIX_vertex_preclip";
		}
		public partial class SgixYcrcb
		{
			public enum All
			{
				// GL_YCRCB_422_SGIX = 0x81BB
				Ycrcb422 = unchecked((int)33211),
				// GL_YCRCB_444_SGIX = 0x81BC
				Ycrcb444 = unchecked((int)33212),
			}
			public const string NAME_STRING = "GL_SGIX_ycrcb";
		}
		public partial class SgixYcrcba
		{
			public enum All
			{
				// GL_YCRCB_SGIX = 0x8318
				Ycrcb = unchecked((int)33560),
				// GL_YCRCBA_SGIX = 0x8319
				Ycrcba = unchecked((int)33561),
			}
			public const string NAME_STRING = "GL_SGIX_ycrcba";
		}
	}
}

