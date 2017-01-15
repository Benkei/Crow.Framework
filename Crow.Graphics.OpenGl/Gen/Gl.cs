using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGl
{
	public partial class Gl
	{
		public enum All
		{
			// GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
			TimeoutIgnored = unchecked((int)-1),
			// GL_FALSE = 0x0
			False = unchecked((int)0),
			// GL_NO_ERROR = 0x0
			NoError = unchecked((int)0),
			// GL_NONE = 0x0
			None = unchecked((int)0),
			// GL_POINTS = 0x0
			Points = unchecked((int)0),
			// GL_ZERO = 0x0
			Zero = unchecked((int)0),
			// GL_CONTEXT_CORE_PROFILE_BIT = 0x1
			ContextCoreProfileBit = unchecked((int)1),
			// GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x1
			ContextFlagForwardCompatibleBit = unchecked((int)1),
			// GL_LINES = 0x1
			Lines = unchecked((int)1),
			// GL_MAP_READ_BIT = 0x1
			MapReadBit = unchecked((int)1),
			// GL_ONE = 0x1
			One = unchecked((int)1),
			// GL_SYNC_FLUSH_COMMANDS_BIT = 0x1
			SyncFlushCommandsBit = unchecked((int)1),
			// GL_TRUE = 0x1
			True = unchecked((int)1),
			// GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x1
			VertexAttribArrayBarrierBit = unchecked((int)1),
			// GL_VERTEX_SHADER_BIT = 0x1
			VertexShaderBit = unchecked((int)1),
			// GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x2
			ContextCompatibilityProfileBit = unchecked((int)2),
			// GL_CONTEXT_FLAG_DEBUG_BIT = 0x2
			ContextFlagDebugBit = unchecked((int)2),
			// GL_ELEMENT_ARRAY_BARRIER_BIT = 0x2
			ElementArrayBarrierBit = unchecked((int)2),
			// GL_FRAGMENT_SHADER_BIT = 0x2
			FragmentShaderBit = unchecked((int)2),
			// GL_LINE_LOOP = 0x2
			LineLoop = unchecked((int)2),
			// GL_MAP_WRITE_BIT = 0x2
			MapWriteBit = unchecked((int)2),
			// GL_LINE_STRIP = 0x3
			LineStrip = unchecked((int)3),
			// GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x4
			ContextFlagRobustAccessBit = unchecked((int)4),
			// GL_GEOMETRY_SHADER_BIT = 0x4
			GeometryShaderBit = unchecked((int)4),
			// GL_MAP_INVALIDATE_RANGE_BIT = 0x4
			MapInvalidateRangeBit = unchecked((int)4),
			// GL_TRIANGLES = 0x4
			Triangles = unchecked((int)4),
			// GL_UNIFORM_BARRIER_BIT = 0x4
			UniformBarrierBit = unchecked((int)4),
			// GL_TRIANGLE_STRIP = 0x5
			TriangleStrip = unchecked((int)5),
			// GL_TRIANGLE_FAN = 0x6
			TriangleFan = unchecked((int)6),
			// GL_MAP_INVALIDATE_BUFFER_BIT = 0x8
			MapInvalidateBufferBit = unchecked((int)8),
			// GL_TESS_CONTROL_SHADER_BIT = 0x8
			TessControlShaderBit = unchecked((int)8),
			// GL_TEXTURE_FETCH_BARRIER_BIT = 0x8
			TextureFetchBarrierBit = unchecked((int)8),
			// GL_LINES_ADJACENCY = 0xA
			LinesAdjacency = unchecked((int)10),
			// GL_LINE_STRIP_ADJACENCY = 0xB
			LineStripAdjacency = unchecked((int)11),
			// GL_TRIANGLES_ADJACENCY = 0xC
			TrianglesAdjacency = unchecked((int)12),
			// GL_TRIANGLE_STRIP_ADJACENCY = 0xD
			TriangleStripAdjacency = unchecked((int)13),
			// GL_PATCHES = 0xE
			Patches = unchecked((int)14),
			// GL_MAP_FLUSH_EXPLICIT_BIT = 0x10
			MapFlushExplicitBit = unchecked((int)16),
			// GL_TESS_EVALUATION_SHADER_BIT = 0x10
			TessEvaluationShaderBit = unchecked((int)16),
			// GL_COMPUTE_SHADER_BIT = 0x20
			ComputeShaderBit = unchecked((int)32),
			// GL_MAP_UNSYNCHRONIZED_BIT = 0x20
			MapUnsynchronizedBit = unchecked((int)32),
			// GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x20
			ShaderImageAccessBarrierBit = unchecked((int)32),
			// GL_COMMAND_BARRIER_BIT = 0x40
			CommandBarrierBit = unchecked((int)64),
			// GL_MAP_PERSISTENT_BIT = 0x40
			MapPersistentBit = unchecked((int)64),
			// GL_MAP_COHERENT_BIT = 0x80
			MapCoherentBit = unchecked((int)128),
			// GL_PIXEL_BUFFER_BARRIER_BIT = 0x80
			PixelBufferBarrierBit = unchecked((int)128),
			// GL_DEPTH_BUFFER_BIT = 0x100
			DepthBufferBit = unchecked((int)256),
			// GL_DYNAMIC_STORAGE_BIT = 0x100
			DynamicStorageBit = unchecked((int)256),
			// GL_TEXTURE_UPDATE_BARRIER_BIT = 0x100
			TextureUpdateBarrierBit = unchecked((int)256),
			// GL_BUFFER_UPDATE_BARRIER_BIT = 0x200
			BufferUpdateBarrierBit = unchecked((int)512),
			// GL_CLIENT_STORAGE_BIT = 0x200
			ClientStorageBit = unchecked((int)512),
			// GL_NEVER = 0x200
			Never = unchecked((int)512),
			// GL_LESS = 0x201
			Less = unchecked((int)513),
			// GL_EQUAL = 0x202
			Equal = unchecked((int)514),
			// GL_LEQUAL = 0x203
			Lequal = unchecked((int)515),
			// GL_GREATER = 0x204
			Greater = unchecked((int)516),
			// GL_NOTEQUAL = 0x205
			Notequal = unchecked((int)517),
			// GL_GEQUAL = 0x206
			Gequal = unchecked((int)518),
			// GL_ALWAYS = 0x207
			Always = unchecked((int)519),
			// GL_SRC_COLOR = 0x300
			SrcColor = unchecked((int)768),
			// GL_ONE_MINUS_SRC_COLOR = 0x301
			OneMinusSrcColor = unchecked((int)769),
			// GL_SRC_ALPHA = 0x302
			SrcAlpha = unchecked((int)770),
			// GL_ONE_MINUS_SRC_ALPHA = 0x303
			OneMinusSrcAlpha = unchecked((int)771),
			// GL_DST_ALPHA = 0x304
			DstAlpha = unchecked((int)772),
			// GL_ONE_MINUS_DST_ALPHA = 0x305
			OneMinusDstAlpha = unchecked((int)773),
			// GL_DST_COLOR = 0x306
			DstColor = unchecked((int)774),
			// GL_ONE_MINUS_DST_COLOR = 0x307
			OneMinusDstColor = unchecked((int)775),
			// GL_SRC_ALPHA_SATURATE = 0x308
			SrcAlphaSaturate = unchecked((int)776),
			// GL_FRAMEBUFFER_BARRIER_BIT = 0x400
			FramebufferBarrierBit = unchecked((int)1024),
			// GL_FRONT_LEFT = 0x400
			FrontLeft = unchecked((int)1024),
			// GL_STENCIL_BUFFER_BIT = 0x400
			StencilBufferBit = unchecked((int)1024),
			// GL_FRONT_RIGHT = 0x401
			FrontRight = unchecked((int)1025),
			// GL_BACK_LEFT = 0x402
			BackLeft = unchecked((int)1026),
			// GL_BACK_RIGHT = 0x403
			BackRight = unchecked((int)1027),
			// GL_FRONT = 0x404
			Front = unchecked((int)1028),
			// GL_BACK = 0x405
			Back = unchecked((int)1029),
			// GL_LEFT = 0x406
			Left = unchecked((int)1030),
			// GL_RIGHT = 0x407
			Right = unchecked((int)1031),
			// GL_FRONT_AND_BACK = 0x408
			FrontAndBack = unchecked((int)1032),
			// GL_INVALID_ENUM = 0x500
			InvalidEnum = unchecked((int)1280),
			// GL_INVALID_VALUE = 0x501
			InvalidValue = unchecked((int)1281),
			// GL_INVALID_OPERATION = 0x502
			InvalidOperation = unchecked((int)1282),
			// GL_OUT_OF_MEMORY = 0x505
			OutOfMemory = unchecked((int)1285),
			// GL_INVALID_FRAMEBUFFER_OPERATION = 0x506
			InvalidFramebufferOperation = unchecked((int)1286),
			// GL_CONTEXT_LOST = 0x507
			ContextLost = unchecked((int)1287),
			// GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x800
			TransformFeedbackBarrierBit = unchecked((int)2048),
			// GL_CW = 0x900
			Cw = unchecked((int)2304),
			// GL_CCW = 0x901
			Ccw = unchecked((int)2305),
			// GL_POINT_SIZE = 0xB11
			PointSize = unchecked((int)2833),
			// GL_POINT_SIZE_RANGE = 0xB12
			PointSizeRange = unchecked((int)2834),
			// GL_SMOOTH_POINT_SIZE_RANGE = 0xB12
			SmoothPointSizeRange = unchecked((int)2834),
			// GL_POINT_SIZE_GRANULARITY = 0xB13
			PointSizeGranularity = unchecked((int)2835),
			// GL_SMOOTH_POINT_SIZE_GRANULARITY = 0xB13
			SmoothPointSizeGranularity = unchecked((int)2835),
			// GL_LINE_SMOOTH = 0xB20
			LineSmooth = unchecked((int)2848),
			// GL_LINE_WIDTH = 0xB21
			LineWidth = unchecked((int)2849),
			// GL_LINE_WIDTH_RANGE = 0xB22
			LineWidthRange = unchecked((int)2850),
			// GL_SMOOTH_LINE_WIDTH_RANGE = 0xB22
			SmoothLineWidthRange = unchecked((int)2850),
			// GL_LINE_WIDTH_GRANULARITY = 0xB23
			LineWidthGranularity = unchecked((int)2851),
			// GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0xB23
			SmoothLineWidthGranularity = unchecked((int)2851),
			// GL_POLYGON_MODE = 0xB40
			PolygonMode = unchecked((int)2880),
			// GL_POLYGON_SMOOTH = 0xB41
			PolygonSmooth = unchecked((int)2881),
			// GL_CULL_FACE = 0xB44
			CullFace = unchecked((int)2884),
			// GL_CULL_FACE_MODE = 0xB45
			CullFaceMode = unchecked((int)2885),
			// GL_FRONT_FACE = 0xB46
			FrontFace = unchecked((int)2886),
			// GL_DEPTH_RANGE = 0xB70
			DepthRange = unchecked((int)2928),
			// GL_DEPTH_TEST = 0xB71
			DepthTest = unchecked((int)2929),
			// GL_DEPTH_WRITEMASK = 0xB72
			DepthWritemask = unchecked((int)2930),
			// GL_DEPTH_CLEAR_VALUE = 0xB73
			DepthClearValue = unchecked((int)2931),
			// GL_DEPTH_FUNC = 0xB74
			DepthFunc = unchecked((int)2932),
			// GL_STENCIL_TEST = 0xB90
			StencilTest = unchecked((int)2960),
			// GL_STENCIL_CLEAR_VALUE = 0xB91
			StencilClearValue = unchecked((int)2961),
			// GL_STENCIL_FUNC = 0xB92
			StencilFunc = unchecked((int)2962),
			// GL_STENCIL_VALUE_MASK = 0xB93
			StencilValueMask = unchecked((int)2963),
			// GL_STENCIL_FAIL = 0xB94
			StencilFail = unchecked((int)2964),
			// GL_STENCIL_PASS_DEPTH_FAIL = 0xB95
			StencilPassDepthFail = unchecked((int)2965),
			// GL_STENCIL_PASS_DEPTH_PASS = 0xB96
			StencilPassDepthPass = unchecked((int)2966),
			// GL_STENCIL_REF = 0xB97
			StencilRef = unchecked((int)2967),
			// GL_STENCIL_WRITEMASK = 0xB98
			StencilWritemask = unchecked((int)2968),
			// GL_VIEWPORT = 0xBA2
			Viewport = unchecked((int)2978),
			// GL_DITHER = 0xBD0
			Dither = unchecked((int)3024),
			// GL_BLEND_DST = 0xBE0
			BlendDst = unchecked((int)3040),
			// GL_BLEND_SRC = 0xBE1
			BlendSrc = unchecked((int)3041),
			// GL_BLEND = 0xBE2
			Blend = unchecked((int)3042),
			// GL_LOGIC_OP_MODE = 0xBF0
			LogicOpMode = unchecked((int)3056),
			// GL_COLOR_LOGIC_OP = 0xBF2
			ColorLogicOp = unchecked((int)3058),
			// GL_DRAW_BUFFER = 0xC01
			DrawBuffer = unchecked((int)3073),
			// GL_READ_BUFFER = 0xC02
			ReadBuffer = unchecked((int)3074),
			// GL_SCISSOR_BOX = 0xC10
			ScissorBox = unchecked((int)3088),
			// GL_SCISSOR_TEST = 0xC11
			ScissorTest = unchecked((int)3089),
			// GL_COLOR_CLEAR_VALUE = 0xC22
			ColorClearValue = unchecked((int)3106),
			// GL_COLOR_WRITEMASK = 0xC23
			ColorWritemask = unchecked((int)3107),
			// GL_DOUBLEBUFFER = 0xC32
			Doublebuffer = unchecked((int)3122),
			// GL_STEREO = 0xC33
			Stereo = unchecked((int)3123),
			// GL_LINE_SMOOTH_HINT = 0xC52
			LineSmoothHint = unchecked((int)3154),
			// GL_POLYGON_SMOOTH_HINT = 0xC53
			PolygonSmoothHint = unchecked((int)3155),
			// GL_UNPACK_SWAP_BYTES = 0xCF0
			UnpackSwapBytes = unchecked((int)3312),
			// GL_UNPACK_LSB_FIRST = 0xCF1
			UnpackLsbFirst = unchecked((int)3313),
			// GL_UNPACK_ROW_LENGTH = 0xCF2
			UnpackRowLength = unchecked((int)3314),
			// GL_UNPACK_SKIP_ROWS = 0xCF3
			UnpackSkipRows = unchecked((int)3315),
			// GL_UNPACK_SKIP_PIXELS = 0xCF4
			UnpackSkipPixels = unchecked((int)3316),
			// GL_UNPACK_ALIGNMENT = 0xCF5
			UnpackAlignment = unchecked((int)3317),
			// GL_PACK_SWAP_BYTES = 0xD00
			PackSwapBytes = unchecked((int)3328),
			// GL_PACK_LSB_FIRST = 0xD01
			PackLsbFirst = unchecked((int)3329),
			// GL_PACK_ROW_LENGTH = 0xD02
			PackRowLength = unchecked((int)3330),
			// GL_PACK_SKIP_ROWS = 0xD03
			PackSkipRows = unchecked((int)3331),
			// GL_PACK_SKIP_PIXELS = 0xD04
			PackSkipPixels = unchecked((int)3332),
			// GL_PACK_ALIGNMENT = 0xD05
			PackAlignment = unchecked((int)3333),
			// GL_MAX_CLIP_DISTANCES = 0xD32
			MaxClipDistances = unchecked((int)3378),
			// GL_MAX_TEXTURE_SIZE = 0xD33
			MaxTextureSize = unchecked((int)3379),
			// GL_MAX_VIEWPORT_DIMS = 0xD3A
			MaxViewportDims = unchecked((int)3386),
			// GL_SUBPIXEL_BITS = 0xD50
			SubpixelBits = unchecked((int)3408),
			// GL_TEXTURE_1D = 0xDE0
			Texture1d = unchecked((int)3552),
			// GL_TEXTURE_2D = 0xDE1
			Texture2d = unchecked((int)3553),
			// GL_ATOMIC_COUNTER_BARRIER_BIT = 0x1000
			AtomicCounterBarrierBit = unchecked((int)4096),
			// GL_TEXTURE_WIDTH = 0x1000
			TextureWidth = unchecked((int)4096),
			// GL_TEXTURE_HEIGHT = 0x1001
			TextureHeight = unchecked((int)4097),
			// GL_TEXTURE_INTERNAL_FORMAT = 0x1003
			TextureInternalFormat = unchecked((int)4099),
			// GL_TEXTURE_BORDER_COLOR = 0x1004
			TextureBorderColor = unchecked((int)4100),
			// GL_TEXTURE_TARGET = 0x1006
			TextureTarget = unchecked((int)4102),
			// GL_DONT_CARE = 0x1100
			DontCare = unchecked((int)4352),
			// GL_FASTEST = 0x1101
			Fastest = unchecked((int)4353),
			// GL_NICEST = 0x1102
			Nicest = unchecked((int)4354),
			// GL_BYTE = 0x1400
			Byte = unchecked((int)5120),
			// GL_UNSIGNED_BYTE = 0x1401
			UnsignedByte = unchecked((int)5121),
			// GL_SHORT = 0x1402
			Short = unchecked((int)5122),
			// GL_UNSIGNED_SHORT = 0x1403
			UnsignedShort = unchecked((int)5123),
			// GL_INT = 0x1404
			Int = unchecked((int)5124),
			// GL_UNSIGNED_INT = 0x1405
			UnsignedInt = unchecked((int)5125),
			// GL_FLOAT = 0x1406
			Float = unchecked((int)5126),
			// GL_DOUBLE = 0x140A
			Double = unchecked((int)5130),
			// GL_HALF_FLOAT = 0x140B
			HalfFloat = unchecked((int)5131),
			// GL_FIXED = 0x140C
			Fixed = unchecked((int)5132),
			// GL_CLEAR = 0x1500
			Clear = unchecked((int)5376),
			// GL_AND = 0x1501
			And = unchecked((int)5377),
			// GL_AND_REVERSE = 0x1502
			AndReverse = unchecked((int)5378),
			// GL_COPY = 0x1503
			Copy = unchecked((int)5379),
			// GL_AND_INVERTED = 0x1504
			AndInverted = unchecked((int)5380),
			// GL_NOOP = 0x1505
			Noop = unchecked((int)5381),
			// GL_XOR = 0x1506
			Xor = unchecked((int)5382),
			// GL_OR = 0x1507
			Or = unchecked((int)5383),
			// GL_NOR = 0x1508
			Nor = unchecked((int)5384),
			// GL_EQUIV = 0x1509
			Equiv = unchecked((int)5385),
			// GL_INVERT = 0x150A
			Invert = unchecked((int)5386),
			// GL_OR_REVERSE = 0x150B
			OrReverse = unchecked((int)5387),
			// GL_COPY_INVERTED = 0x150C
			CopyInverted = unchecked((int)5388),
			// GL_OR_INVERTED = 0x150D
			OrInverted = unchecked((int)5389),
			// GL_NAND = 0x150E
			Nand = unchecked((int)5390),
			// GL_SET = 0x150F
			Set = unchecked((int)5391),
			// GL_TEXTURE = 0x1702
			Texture = unchecked((int)5890),
			// GL_COLOR = 0x1800
			Color = unchecked((int)6144),
			// GL_DEPTH = 0x1801
			Depth = unchecked((int)6145),
			// GL_STENCIL = 0x1802
			Stencil = unchecked((int)6146),
			// GL_STENCIL_INDEX = 0x1901
			StencilIndex = unchecked((int)6401),
			// GL_DEPTH_COMPONENT = 0x1902
			DepthComponent = unchecked((int)6402),
			// GL_RED = 0x1903
			Red = unchecked((int)6403),
			// GL_GREEN = 0x1904
			Green = unchecked((int)6404),
			// GL_BLUE = 0x1905
			Blue = unchecked((int)6405),
			// GL_ALPHA = 0x1906
			Alpha = unchecked((int)6406),
			// GL_RGB = 0x1907
			Rgb = unchecked((int)6407),
			// GL_RGBA = 0x1908
			Rgba = unchecked((int)6408),
			// GL_POINT = 0x1B00
			Point = unchecked((int)6912),
			// GL_LINE = 0x1B01
			Line = unchecked((int)6913),
			// GL_FILL = 0x1B02
			Fill = unchecked((int)6914),
			// GL_KEEP = 0x1E00
			Keep = unchecked((int)7680),
			// GL_REPLACE = 0x1E01
			Replace = unchecked((int)7681),
			// GL_INCR = 0x1E02
			Incr = unchecked((int)7682),
			// GL_DECR = 0x1E03
			Decr = unchecked((int)7683),
			// GL_VENDOR = 0x1F00
			Vendor = unchecked((int)7936),
			// GL_RENDERER = 0x1F01
			Renderer = unchecked((int)7937),
			// GL_VERSION = 0x1F02
			Version = unchecked((int)7938),
			// GL_EXTENSIONS = 0x1F03
			Extensions = unchecked((int)7939),
			// GL_SHADER_STORAGE_BARRIER_BIT = 0x2000
			ShaderStorageBarrierBit = unchecked((int)8192),
			// GL_NEAREST = 0x2600
			Nearest = unchecked((int)9728),
			// GL_LINEAR = 0x2601
			Linear = unchecked((int)9729),
			// GL_NEAREST_MIPMAP_NEAREST = 0x2700
			NearestMipmapNearest = unchecked((int)9984),
			// GL_LINEAR_MIPMAP_NEAREST = 0x2701
			LinearMipmapNearest = unchecked((int)9985),
			// GL_NEAREST_MIPMAP_LINEAR = 0x2702
			NearestMipmapLinear = unchecked((int)9986),
			// GL_LINEAR_MIPMAP_LINEAR = 0x2703
			LinearMipmapLinear = unchecked((int)9987),
			// GL_TEXTURE_MAG_FILTER = 0x2800
			TextureMagFilter = unchecked((int)10240),
			// GL_TEXTURE_MIN_FILTER = 0x2801
			TextureMinFilter = unchecked((int)10241),
			// GL_TEXTURE_WRAP_S = 0x2802
			TextureWrapS = unchecked((int)10242),
			// GL_TEXTURE_WRAP_T = 0x2803
			TextureWrapT = unchecked((int)10243),
			// GL_REPEAT = 0x2901
			Repeat = unchecked((int)10497),
			// GL_POLYGON_OFFSET_UNITS = 0x2A00
			PolygonOffsetUnits = unchecked((int)10752),
			// GL_POLYGON_OFFSET_POINT = 0x2A01
			PolygonOffsetPoint = unchecked((int)10753),
			// GL_POLYGON_OFFSET_LINE = 0x2A02
			PolygonOffsetLine = unchecked((int)10754),
			// GL_R3_G3_B2 = 0x2A10
			R3G3B2 = unchecked((int)10768),
			// GL_CLIP_DISTANCE0 = 0x3000
			ClipDistance0 = unchecked((int)12288),
			// GL_CLIP_DISTANCE1 = 0x3001
			ClipDistance1 = unchecked((int)12289),
			// GL_CLIP_DISTANCE2 = 0x3002
			ClipDistance2 = unchecked((int)12290),
			// GL_CLIP_DISTANCE3 = 0x3003
			ClipDistance3 = unchecked((int)12291),
			// GL_CLIP_DISTANCE4 = 0x3004
			ClipDistance4 = unchecked((int)12292),
			// GL_CLIP_DISTANCE5 = 0x3005
			ClipDistance5 = unchecked((int)12293),
			// GL_CLIP_DISTANCE6 = 0x3006
			ClipDistance6 = unchecked((int)12294),
			// GL_CLIP_DISTANCE7 = 0x3007
			ClipDistance7 = unchecked((int)12295),
			// GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x4000
			ClientMappedBufferBarrierBit = unchecked((int)16384),
			// GL_COLOR_BUFFER_BIT = 0x4000
			ColorBufferBit = unchecked((int)16384),
			// GL_QUERY_BUFFER_BARRIER_BIT = 0x8000
			QueryBufferBarrierBit = unchecked((int)32768),
			// GL_CONSTANT_COLOR = 0x8001
			ConstantColor = unchecked((int)32769),
			// GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
			OneMinusConstantColor = unchecked((int)32770),
			// GL_CONSTANT_ALPHA = 0x8003
			ConstantAlpha = unchecked((int)32771),
			// GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
			OneMinusConstantAlpha = unchecked((int)32772),
			// GL_FUNC_ADD = 0x8006
			FuncAdd = unchecked((int)32774),
			// GL_MIN = 0x8007
			Min = unchecked((int)32775),
			// GL_MAX = 0x8008
			Max = unchecked((int)32776),
			// GL_BLEND_EQUATION_RGB = 0x8009
			BlendEquationRgb = unchecked((int)32777),
			// GL_FUNC_SUBTRACT = 0x800A
			FuncSubtract = unchecked((int)32778),
			// GL_FUNC_REVERSE_SUBTRACT = 0x800B
			FuncReverseSubtract = unchecked((int)32779),
			// GL_UNSIGNED_BYTE_3_3_2 = 0x8032
			UnsignedByte332 = unchecked((int)32818),
			// GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
			UnsignedShort4444 = unchecked((int)32819),
			// GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
			UnsignedShort5551 = unchecked((int)32820),
			// GL_UNSIGNED_INT_8_8_8_8 = 0x8035
			UnsignedInt8888 = unchecked((int)32821),
			// GL_UNSIGNED_INT_10_10_10_2 = 0x8036
			UnsignedInt1010102 = unchecked((int)32822),
			// GL_POLYGON_OFFSET_FILL = 0x8037
			PolygonOffsetFill = unchecked((int)32823),
			// GL_POLYGON_OFFSET_FACTOR = 0x8038
			PolygonOffsetFactor = unchecked((int)32824),
			// GL_RGB4 = 0x804F
			Rgb4 = unchecked((int)32847),
			// GL_RGB5 = 0x8050
			Rgb5 = unchecked((int)32848),
			// GL_RGB8 = 0x8051
			Rgb8 = unchecked((int)32849),
			// GL_RGB10 = 0x8052
			Rgb10 = unchecked((int)32850),
			// GL_RGB12 = 0x8053
			Rgb12 = unchecked((int)32851),
			// GL_RGB16 = 0x8054
			Rgb16 = unchecked((int)32852),
			// GL_RGBA2 = 0x8055
			Rgba2 = unchecked((int)32853),
			// GL_RGBA4 = 0x8056
			Rgba4 = unchecked((int)32854),
			// GL_RGB5_A1 = 0x8057
			Rgb5A1 = unchecked((int)32855),
			// GL_RGBA8 = 0x8058
			Rgba8 = unchecked((int)32856),
			// GL_RGB10_A2 = 0x8059
			Rgb10A2 = unchecked((int)32857),
			// GL_RGBA12 = 0x805A
			Rgba12 = unchecked((int)32858),
			// GL_RGBA16 = 0x805B
			Rgba16 = unchecked((int)32859),
			// GL_TEXTURE_RED_SIZE = 0x805C
			TextureRedSize = unchecked((int)32860),
			// GL_TEXTURE_GREEN_SIZE = 0x805D
			TextureGreenSize = unchecked((int)32861),
			// GL_TEXTURE_BLUE_SIZE = 0x805E
			TextureBlueSize = unchecked((int)32862),
			// GL_TEXTURE_ALPHA_SIZE = 0x805F
			TextureAlphaSize = unchecked((int)32863),
			// GL_PROXY_TEXTURE_1D = 0x8063
			ProxyTexture1d = unchecked((int)32867),
			// GL_PROXY_TEXTURE_2D = 0x8064
			ProxyTexture2d = unchecked((int)32868),
			// GL_TEXTURE_BINDING_1D = 0x8068
			TextureBinding1d = unchecked((int)32872),
			// GL_TEXTURE_BINDING_2D = 0x8069
			TextureBinding2d = unchecked((int)32873),
			// GL_TEXTURE_BINDING_3D = 0x806A
			TextureBinding3d = unchecked((int)32874),
			// GL_PACK_SKIP_IMAGES = 0x806B
			PackSkipImages = unchecked((int)32875),
			// GL_PACK_IMAGE_HEIGHT = 0x806C
			PackImageHeight = unchecked((int)32876),
			// GL_UNPACK_SKIP_IMAGES = 0x806D
			UnpackSkipImages = unchecked((int)32877),
			// GL_UNPACK_IMAGE_HEIGHT = 0x806E
			UnpackImageHeight = unchecked((int)32878),
			// GL_TEXTURE_3D = 0x806F
			Texture3d = unchecked((int)32879),
			// GL_PROXY_TEXTURE_3D = 0x8070
			ProxyTexture3d = unchecked((int)32880),
			// GL_TEXTURE_DEPTH = 0x8071
			TextureDepth = unchecked((int)32881),
			// GL_TEXTURE_WRAP_R = 0x8072
			TextureWrapR = unchecked((int)32882),
			// GL_MAX_3D_TEXTURE_SIZE = 0x8073
			Max3dTextureSize = unchecked((int)32883),
			// GL_MULTISAMPLE = 0x809D
			Multisample = unchecked((int)32925),
			// GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
			SampleAlphaToCoverage = unchecked((int)32926),
			// GL_SAMPLE_ALPHA_TO_ONE = 0x809F
			SampleAlphaToOne = unchecked((int)32927),
			// GL_SAMPLE_COVERAGE = 0x80A0
			SampleCoverage = unchecked((int)32928),
			// GL_SAMPLE_BUFFERS = 0x80A8
			SampleBuffers = unchecked((int)32936),
			// GL_SAMPLES = 0x80A9
			Samples = unchecked((int)32937),
			// GL_SAMPLE_COVERAGE_VALUE = 0x80AA
			SampleCoverageValue = unchecked((int)32938),
			// GL_SAMPLE_COVERAGE_INVERT = 0x80AB
			SampleCoverageInvert = unchecked((int)32939),
			// GL_BLEND_DST_RGB = 0x80C8
			BlendDstRgb = unchecked((int)32968),
			// GL_BLEND_SRC_RGB = 0x80C9
			BlendSrcRgb = unchecked((int)32969),
			// GL_BLEND_DST_ALPHA = 0x80CA
			BlendDstAlpha = unchecked((int)32970),
			// GL_BLEND_SRC_ALPHA = 0x80CB
			BlendSrcAlpha = unchecked((int)32971),
			// GL_BGR = 0x80E0
			Bgr = unchecked((int)32992),
			// GL_BGRA = 0x80E1
			Bgra = unchecked((int)32993),
			// GL_MAX_ELEMENTS_VERTICES = 0x80E8
			MaxElementsVertices = unchecked((int)33000),
			// GL_MAX_ELEMENTS_INDICES = 0x80E9
			MaxElementsIndices = unchecked((int)33001),
			// GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
			PointFadeThresholdSize = unchecked((int)33064),
			// GL_CLAMP_TO_BORDER = 0x812D
			ClampToBorder = unchecked((int)33069),
			// GL_CLAMP_TO_EDGE = 0x812F
			ClampToEdge = unchecked((int)33071),
			// GL_TEXTURE_MIN_LOD = 0x813A
			TextureMinLod = unchecked((int)33082),
			// GL_TEXTURE_MAX_LOD = 0x813B
			TextureMaxLod = unchecked((int)33083),
			// GL_TEXTURE_BASE_LEVEL = 0x813C
			TextureBaseLevel = unchecked((int)33084),
			// GL_TEXTURE_MAX_LEVEL = 0x813D
			TextureMaxLevel = unchecked((int)33085),
			// GL_DEPTH_COMPONENT16 = 0x81A5
			DepthComponent16 = unchecked((int)33189),
			// GL_DEPTH_COMPONENT24 = 0x81A6
			DepthComponent24 = unchecked((int)33190),
			// GL_DEPTH_COMPONENT32 = 0x81A7
			DepthComponent32 = unchecked((int)33191),
			// GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
			FramebufferAttachmentColorEncoding = unchecked((int)33296),
			// GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
			FramebufferAttachmentComponentType = unchecked((int)33297),
			// GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
			FramebufferAttachmentRedSize = unchecked((int)33298),
			// GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
			FramebufferAttachmentGreenSize = unchecked((int)33299),
			// GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
			FramebufferAttachmentBlueSize = unchecked((int)33300),
			// GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
			FramebufferAttachmentAlphaSize = unchecked((int)33301),
			// GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
			FramebufferAttachmentDepthSize = unchecked((int)33302),
			// GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
			FramebufferAttachmentStencilSize = unchecked((int)33303),
			// GL_FRAMEBUFFER_DEFAULT = 0x8218
			FramebufferDefault = unchecked((int)33304),
			// GL_FRAMEBUFFER_UNDEFINED = 0x8219
			FramebufferUndefined = unchecked((int)33305),
			// GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
			DepthStencilAttachment = unchecked((int)33306),
			// GL_MAJOR_VERSION = 0x821B
			MajorVersion = unchecked((int)33307),
			// GL_MINOR_VERSION = 0x821C
			MinorVersion = unchecked((int)33308),
			// GL_NUM_EXTENSIONS = 0x821D
			NumExtensions = unchecked((int)33309),
			// GL_CONTEXT_FLAGS = 0x821E
			ContextFlags = unchecked((int)33310),
			// GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
			BufferImmutableStorage = unchecked((int)33311),
			// GL_BUFFER_STORAGE_FLAGS = 0x8220
			BufferStorageFlags = unchecked((int)33312),
			// GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221
			PrimitiveRestartForPatchesSupported = unchecked((int)33313),
			// GL_COMPRESSED_RED = 0x8225
			CompressedRed = unchecked((int)33317),
			// GL_COMPRESSED_RG = 0x8226
			CompressedRg = unchecked((int)33318),
			// GL_RG = 0x8227
			Rg = unchecked((int)33319),
			// GL_RG_INTEGER = 0x8228
			RgInteger = unchecked((int)33320),
			// GL_R8 = 0x8229
			R8 = unchecked((int)33321),
			// GL_R16 = 0x822A
			R16 = unchecked((int)33322),
			// GL_RG8 = 0x822B
			Rg8 = unchecked((int)33323),
			// GL_RG16 = 0x822C
			Rg16 = unchecked((int)33324),
			// GL_R16F = 0x822D
			R16f = unchecked((int)33325),
			// GL_R32F = 0x822E
			R32f = unchecked((int)33326),
			// GL_RG16F = 0x822F
			Rg16f = unchecked((int)33327),
			// GL_RG32F = 0x8230
			Rg32f = unchecked((int)33328),
			// GL_R8I = 0x8231
			R8i = unchecked((int)33329),
			// GL_R8UI = 0x8232
			R8ui = unchecked((int)33330),
			// GL_R16I = 0x8233
			R16i = unchecked((int)33331),
			// GL_R16UI = 0x8234
			R16ui = unchecked((int)33332),
			// GL_R32I = 0x8235
			R32i = unchecked((int)33333),
			// GL_R32UI = 0x8236
			R32ui = unchecked((int)33334),
			// GL_RG8I = 0x8237
			Rg8i = unchecked((int)33335),
			// GL_RG8UI = 0x8238
			Rg8ui = unchecked((int)33336),
			// GL_RG16I = 0x8239
			Rg16i = unchecked((int)33337),
			// GL_RG16UI = 0x823A
			Rg16ui = unchecked((int)33338),
			// GL_RG32I = 0x823B
			Rg32i = unchecked((int)33339),
			// GL_RG32UI = 0x823C
			Rg32ui = unchecked((int)33340),
			// GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
			DebugOutputSynchronous = unchecked((int)33346),
			// GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
			DebugNextLoggedMessageLength = unchecked((int)33347),
			// GL_DEBUG_CALLBACK_FUNCTION = 0x8244
			DebugCallbackFunction = unchecked((int)33348),
			// GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
			DebugCallbackUserParam = unchecked((int)33349),
			// GL_DEBUG_SOURCE_API = 0x8246
			DebugSourceApi = unchecked((int)33350),
			// GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
			DebugSourceWindowSystem = unchecked((int)33351),
			// GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
			DebugSourceShaderCompiler = unchecked((int)33352),
			// GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
			DebugSourceThirdParty = unchecked((int)33353),
			// GL_DEBUG_SOURCE_APPLICATION = 0x824A
			DebugSourceApplication = unchecked((int)33354),
			// GL_DEBUG_SOURCE_OTHER = 0x824B
			DebugSourceOther = unchecked((int)33355),
			// GL_DEBUG_TYPE_ERROR = 0x824C
			DebugTypeError = unchecked((int)33356),
			// GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
			DebugTypeDeprecatedBehavior = unchecked((int)33357),
			// GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
			DebugTypeUndefinedBehavior = unchecked((int)33358),
			// GL_DEBUG_TYPE_PORTABILITY = 0x824F
			DebugTypePortability = unchecked((int)33359),
			// GL_DEBUG_TYPE_PERFORMANCE = 0x8250
			DebugTypePerformance = unchecked((int)33360),
			// GL_DEBUG_TYPE_OTHER = 0x8251
			DebugTypeOther = unchecked((int)33361),
			// GL_LOSE_CONTEXT_ON_RESET = 0x8252
			LoseContextOnReset = unchecked((int)33362),
			// GL_GUILTY_CONTEXT_RESET = 0x8253
			GuiltyContextReset = unchecked((int)33363),
			// GL_INNOCENT_CONTEXT_RESET = 0x8254
			InnocentContextReset = unchecked((int)33364),
			// GL_UNKNOWN_CONTEXT_RESET = 0x8255
			UnknownContextReset = unchecked((int)33365),
			// GL_RESET_NOTIFICATION_STRATEGY = 0x8256
			ResetNotificationStrategy = unchecked((int)33366),
			// GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
			ProgramBinaryRetrievableHint = unchecked((int)33367),
			// GL_PROGRAM_SEPARABLE = 0x8258
			ProgramSeparable = unchecked((int)33368),
			// GL_ACTIVE_PROGRAM = 0x8259
			ActiveProgram = unchecked((int)33369),
			// GL_PROGRAM_PIPELINE_BINDING = 0x825A
			ProgramPipelineBinding = unchecked((int)33370),
			// GL_MAX_VIEWPORTS = 0x825B
			MaxViewports = unchecked((int)33371),
			// GL_VIEWPORT_SUBPIXEL_BITS = 0x825C
			ViewportSubpixelBits = unchecked((int)33372),
			// GL_VIEWPORT_BOUNDS_RANGE = 0x825D
			ViewportBoundsRange = unchecked((int)33373),
			// GL_LAYER_PROVOKING_VERTEX = 0x825E
			LayerProvokingVertex = unchecked((int)33374),
			// GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F
			ViewportIndexProvokingVertex = unchecked((int)33375),
			// GL_UNDEFINED_VERTEX = 0x8260
			UndefinedVertex = unchecked((int)33376),
			// GL_NO_RESET_NOTIFICATION = 0x8261
			NoResetNotification = unchecked((int)33377),
			// GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262
			MaxComputeSharedMemorySize = unchecked((int)33378),
			// GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263
			MaxComputeUniformComponents = unchecked((int)33379),
			// GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264
			MaxComputeAtomicCounterBuffers = unchecked((int)33380),
			// GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265
			MaxComputeAtomicCounters = unchecked((int)33381),
			// GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266
			MaxCombinedComputeUniformComponents = unchecked((int)33382),
			// GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
			ComputeWorkGroupSize = unchecked((int)33383),
			// GL_DEBUG_TYPE_MARKER = 0x8268
			DebugTypeMarker = unchecked((int)33384),
			// GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
			DebugTypePushGroup = unchecked((int)33385),
			// GL_DEBUG_TYPE_POP_GROUP = 0x826A
			DebugTypePopGroup = unchecked((int)33386),
			// GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
			DebugSeverityNotification = unchecked((int)33387),
			// GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
			MaxDebugGroupStackDepth = unchecked((int)33388),
			// GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
			DebugGroupStackDepth = unchecked((int)33389),
			// GL_MAX_UNIFORM_LOCATIONS = 0x826E
			MaxUniformLocations = unchecked((int)33390),
			// GL_INTERNALFORMAT_SUPPORTED = 0x826F
			InternalformatSupported = unchecked((int)33391),
			// GL_INTERNALFORMAT_PREFERRED = 0x8270
			InternalformatPreferred = unchecked((int)33392),
			// GL_INTERNALFORMAT_RED_SIZE = 0x8271
			InternalformatRedSize = unchecked((int)33393),
			// GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
			InternalformatGreenSize = unchecked((int)33394),
			// GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
			InternalformatBlueSize = unchecked((int)33395),
			// GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
			InternalformatAlphaSize = unchecked((int)33396),
			// GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
			InternalformatDepthSize = unchecked((int)33397),
			// GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
			InternalformatStencilSize = unchecked((int)33398),
			// GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
			InternalformatSharedSize = unchecked((int)33399),
			// GL_INTERNALFORMAT_RED_TYPE = 0x8278
			InternalformatRedType = unchecked((int)33400),
			// GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
			InternalformatGreenType = unchecked((int)33401),
			// GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
			InternalformatBlueType = unchecked((int)33402),
			// GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
			InternalformatAlphaType = unchecked((int)33403),
			// GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
			InternalformatDepthType = unchecked((int)33404),
			// GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
			InternalformatStencilType = unchecked((int)33405),
			// GL_MAX_WIDTH = 0x827E
			MaxWidth = unchecked((int)33406),
			// GL_MAX_HEIGHT = 0x827F
			MaxHeight = unchecked((int)33407),
			// GL_MAX_DEPTH = 0x8280
			MaxDepth = unchecked((int)33408),
			// GL_MAX_LAYERS = 0x8281
			MaxLayers = unchecked((int)33409),
			// GL_MAX_COMBINED_DIMENSIONS = 0x8282
			MaxCombinedDimensions = unchecked((int)33410),
			// GL_COLOR_COMPONENTS = 0x8283
			ColorComponents = unchecked((int)33411),
			// GL_DEPTH_COMPONENTS = 0x8284
			DepthComponents = unchecked((int)33412),
			// GL_STENCIL_COMPONENTS = 0x8285
			StencilComponents = unchecked((int)33413),
			// GL_COLOR_RENDERABLE = 0x8286
			ColorRenderable = unchecked((int)33414),
			// GL_DEPTH_RENDERABLE = 0x8287
			DepthRenderable = unchecked((int)33415),
			// GL_STENCIL_RENDERABLE = 0x8288
			StencilRenderable = unchecked((int)33416),
			// GL_FRAMEBUFFER_RENDERABLE = 0x8289
			FramebufferRenderable = unchecked((int)33417),
			// GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
			FramebufferRenderableLayered = unchecked((int)33418),
			// GL_FRAMEBUFFER_BLEND = 0x828B
			FramebufferBlend = unchecked((int)33419),
			// GL_READ_PIXELS = 0x828C
			ReadPixels = unchecked((int)33420),
			// GL_READ_PIXELS_FORMAT = 0x828D
			ReadPixelsFormat = unchecked((int)33421),
			// GL_READ_PIXELS_TYPE = 0x828E
			ReadPixelsType = unchecked((int)33422),
			// GL_TEXTURE_IMAGE_FORMAT = 0x828F
			TextureImageFormat = unchecked((int)33423),
			// GL_TEXTURE_IMAGE_TYPE = 0x8290
			TextureImageType = unchecked((int)33424),
			// GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
			GetTextureImageFormat = unchecked((int)33425),
			// GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
			GetTextureImageType = unchecked((int)33426),
			// GL_MIPMAP = 0x8293
			Mipmap = unchecked((int)33427),
			// GL_MANUAL_GENERATE_MIPMAP = 0x8294
			ManualGenerateMipmap = unchecked((int)33428),
			// GL_AUTO_GENERATE_MIPMAP = 0x8295
			AutoGenerateMipmap = unchecked((int)33429),
			// GL_COLOR_ENCODING = 0x8296
			ColorEncoding = unchecked((int)33430),
			// GL_SRGB_READ = 0x8297
			SrgbRead = unchecked((int)33431),
			// GL_SRGB_WRITE = 0x8298
			SrgbWrite = unchecked((int)33432),
			// GL_FILTER = 0x829A
			Filter = unchecked((int)33434),
			// GL_VERTEX_TEXTURE = 0x829B
			VertexTexture = unchecked((int)33435),
			// GL_TESS_CONTROL_TEXTURE = 0x829C
			TessControlTexture = unchecked((int)33436),
			// GL_TESS_EVALUATION_TEXTURE = 0x829D
			TessEvaluationTexture = unchecked((int)33437),
			// GL_GEOMETRY_TEXTURE = 0x829E
			GeometryTexture = unchecked((int)33438),
			// GL_FRAGMENT_TEXTURE = 0x829F
			FragmentTexture = unchecked((int)33439),
			// GL_COMPUTE_TEXTURE = 0x82A0
			ComputeTexture = unchecked((int)33440),
			// GL_TEXTURE_SHADOW = 0x82A1
			TextureShadow = unchecked((int)33441),
			// GL_TEXTURE_GATHER = 0x82A2
			TextureGather = unchecked((int)33442),
			// GL_TEXTURE_GATHER_SHADOW = 0x82A3
			TextureGatherShadow = unchecked((int)33443),
			// GL_SHADER_IMAGE_LOAD = 0x82A4
			ShaderImageLoad = unchecked((int)33444),
			// GL_SHADER_IMAGE_STORE = 0x82A5
			ShaderImageStore = unchecked((int)33445),
			// GL_SHADER_IMAGE_ATOMIC = 0x82A6
			ShaderImageAtomic = unchecked((int)33446),
			// GL_IMAGE_TEXEL_SIZE = 0x82A7
			ImageTexelSize = unchecked((int)33447),
			// GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
			ImageCompatibilityClass = unchecked((int)33448),
			// GL_IMAGE_PIXEL_FORMAT = 0x82A9
			ImagePixelFormat = unchecked((int)33449),
			// GL_IMAGE_PIXEL_TYPE = 0x82AA
			ImagePixelType = unchecked((int)33450),
			// GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
			SimultaneousTextureAndDepthTest = unchecked((int)33452),
			// GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
			SimultaneousTextureAndStencilTest = unchecked((int)33453),
			// GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
			SimultaneousTextureAndDepthWrite = unchecked((int)33454),
			// GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
			SimultaneousTextureAndStencilWrite = unchecked((int)33455),
			// GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
			TextureCompressedBlockWidth = unchecked((int)33457),
			// GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
			TextureCompressedBlockHeight = unchecked((int)33458),
			// GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
			TextureCompressedBlockSize = unchecked((int)33459),
			// GL_CLEAR_BUFFER = 0x82B4
			ClearBuffer = unchecked((int)33460),
			// GL_TEXTURE_VIEW = 0x82B5
			TextureView = unchecked((int)33461),
			// GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
			ViewCompatibilityClass = unchecked((int)33462),
			// GL_FULL_SUPPORT = 0x82B7
			FullSupport = unchecked((int)33463),
			// GL_CAVEAT_SUPPORT = 0x82B8
			CaveatSupport = unchecked((int)33464),
			// GL_IMAGE_CLASS_4_X_32 = 0x82B9
			ImageClass4X32 = unchecked((int)33465),
			// GL_IMAGE_CLASS_2_X_32 = 0x82BA
			ImageClass2X32 = unchecked((int)33466),
			// GL_IMAGE_CLASS_1_X_32 = 0x82BB
			ImageClass1X32 = unchecked((int)33467),
			// GL_IMAGE_CLASS_4_X_16 = 0x82BC
			ImageClass4X16 = unchecked((int)33468),
			// GL_IMAGE_CLASS_2_X_16 = 0x82BD
			ImageClass2X16 = unchecked((int)33469),
			// GL_IMAGE_CLASS_1_X_16 = 0x82BE
			ImageClass1X16 = unchecked((int)33470),
			// GL_IMAGE_CLASS_4_X_8 = 0x82BF
			ImageClass4X8 = unchecked((int)33471),
			// GL_IMAGE_CLASS_2_X_8 = 0x82C0
			ImageClass2X8 = unchecked((int)33472),
			// GL_IMAGE_CLASS_1_X_8 = 0x82C1
			ImageClass1X8 = unchecked((int)33473),
			// GL_IMAGE_CLASS_11_11_10 = 0x82C2
			ImageClass111110 = unchecked((int)33474),
			// GL_IMAGE_CLASS_10_10_10_2 = 0x82C3
			ImageClass1010102 = unchecked((int)33475),
			// GL_VIEW_CLASS_128_BITS = 0x82C4
			ViewClass128Bits = unchecked((int)33476),
			// GL_VIEW_CLASS_96_BITS = 0x82C5
			ViewClass96Bits = unchecked((int)33477),
			// GL_VIEW_CLASS_64_BITS = 0x82C6
			ViewClass64Bits = unchecked((int)33478),
			// GL_VIEW_CLASS_48_BITS = 0x82C7
			ViewClass48Bits = unchecked((int)33479),
			// GL_VIEW_CLASS_32_BITS = 0x82C8
			ViewClass32Bits = unchecked((int)33480),
			// GL_VIEW_CLASS_24_BITS = 0x82C9
			ViewClass24Bits = unchecked((int)33481),
			// GL_VIEW_CLASS_16_BITS = 0x82CA
			ViewClass16Bits = unchecked((int)33482),
			// GL_VIEW_CLASS_8_BITS = 0x82CB
			ViewClass8Bits = unchecked((int)33483),
			// GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC
			ViewClassS3tcDxt1Rgb = unchecked((int)33484),
			// GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD
			ViewClassS3tcDxt1Rgba = unchecked((int)33485),
			// GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE
			ViewClassS3tcDxt3Rgba = unchecked((int)33486),
			// GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF
			ViewClassS3tcDxt5Rgba = unchecked((int)33487),
			// GL_VIEW_CLASS_RGTC1_RED = 0x82D0
			ViewClassRgtc1Red = unchecked((int)33488),
			// GL_VIEW_CLASS_RGTC2_RG = 0x82D1
			ViewClassRgtc2Rg = unchecked((int)33489),
			// GL_VIEW_CLASS_BPTC_UNORM = 0x82D2
			ViewClassBptcUnorm = unchecked((int)33490),
			// GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3
			ViewClassBptcFloat = unchecked((int)33491),
			// GL_VERTEX_ATTRIB_BINDING = 0x82D4
			VertexAttribBinding = unchecked((int)33492),
			// GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
			VertexAttribRelativeOffset = unchecked((int)33493),
			// GL_VERTEX_BINDING_DIVISOR = 0x82D6
			VertexBindingDivisor = unchecked((int)33494),
			// GL_VERTEX_BINDING_OFFSET = 0x82D7
			VertexBindingOffset = unchecked((int)33495),
			// GL_VERTEX_BINDING_STRIDE = 0x82D8
			VertexBindingStride = unchecked((int)33496),
			// GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9
			MaxVertexAttribRelativeOffset = unchecked((int)33497),
			// GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA
			MaxVertexAttribBindings = unchecked((int)33498),
			// GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB
			TextureViewMinLevel = unchecked((int)33499),
			// GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC
			TextureViewNumLevels = unchecked((int)33500),
			// GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD
			TextureViewMinLayer = unchecked((int)33501),
			// GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE
			TextureViewNumLayers = unchecked((int)33502),
			// GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
			TextureImmutableLevels = unchecked((int)33503),
			// GL_BUFFER = 0x82E0
			Buffer = unchecked((int)33504),
			// GL_SHADER = 0x82E1
			Shader = unchecked((int)33505),
			// GL_PROGRAM = 0x82E2
			Program = unchecked((int)33506),
			// GL_QUERY = 0x82E3
			Query = unchecked((int)33507),
			// GL_PROGRAM_PIPELINE = 0x82E4
			ProgramPipeline = unchecked((int)33508),
			// GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5
			MaxVertexAttribStride = unchecked((int)33509),
			// GL_SAMPLER = 0x82E6
			Sampler = unchecked((int)33510),
			// GL_MAX_LABEL_LENGTH = 0x82E8
			MaxLabelLength = unchecked((int)33512),
			// GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9
			NumShadingLanguageVersions = unchecked((int)33513),
			// GL_QUERY_TARGET = 0x82EA
			QueryTarget = unchecked((int)33514),
			// GL_MAX_CULL_DISTANCES = 0x82F9
			MaxCullDistances = unchecked((int)33529),
			// GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA
			MaxCombinedClipAndCullDistances = unchecked((int)33530),
			// GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB
			ContextReleaseBehavior = unchecked((int)33531),
			// GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC
			ContextReleaseBehaviorFlush = unchecked((int)33532),
			// GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362
			UnsignedByte233Rev = unchecked((int)33634),
			// GL_UNSIGNED_SHORT_5_6_5 = 0x8363
			UnsignedShort565 = unchecked((int)33635),
			// GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364
			UnsignedShort565Rev = unchecked((int)33636),
			// GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
			UnsignedShort4444Rev = unchecked((int)33637),
			// GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
			UnsignedShort1555Rev = unchecked((int)33638),
			// GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367
			UnsignedInt8888Rev = unchecked((int)33639),
			// GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
			UnsignedInt2101010Rev = unchecked((int)33640),
			// GL_MIRRORED_REPEAT = 0x8370
			MirroredRepeat = unchecked((int)33648),
			// GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
			AliasedLineWidthRange = unchecked((int)33902),
			// GL_TEXTURE0 = 0x84C0
			Texture0 = unchecked((int)33984),
			// GL_TEXTURE1 = 0x84C1
			Texture1 = unchecked((int)33985),
			// GL_TEXTURE2 = 0x84C2
			Texture2 = unchecked((int)33986),
			// GL_TEXTURE3 = 0x84C3
			Texture3 = unchecked((int)33987),
			// GL_TEXTURE4 = 0x84C4
			Texture4 = unchecked((int)33988),
			// GL_TEXTURE5 = 0x84C5
			Texture5 = unchecked((int)33989),
			// GL_TEXTURE6 = 0x84C6
			Texture6 = unchecked((int)33990),
			// GL_TEXTURE7 = 0x84C7
			Texture7 = unchecked((int)33991),
			// GL_TEXTURE8 = 0x84C8
			Texture8 = unchecked((int)33992),
			// GL_TEXTURE9 = 0x84C9
			Texture9 = unchecked((int)33993),
			// GL_TEXTURE10 = 0x84CA
			Texture10 = unchecked((int)33994),
			// GL_TEXTURE11 = 0x84CB
			Texture11 = unchecked((int)33995),
			// GL_TEXTURE12 = 0x84CC
			Texture12 = unchecked((int)33996),
			// GL_TEXTURE13 = 0x84CD
			Texture13 = unchecked((int)33997),
			// GL_TEXTURE14 = 0x84CE
			Texture14 = unchecked((int)33998),
			// GL_TEXTURE15 = 0x84CF
			Texture15 = unchecked((int)33999),
			// GL_TEXTURE16 = 0x84D0
			Texture16 = unchecked((int)34000),
			// GL_TEXTURE17 = 0x84D1
			Texture17 = unchecked((int)34001),
			// GL_TEXTURE18 = 0x84D2
			Texture18 = unchecked((int)34002),
			// GL_TEXTURE19 = 0x84D3
			Texture19 = unchecked((int)34003),
			// GL_TEXTURE20 = 0x84D4
			Texture20 = unchecked((int)34004),
			// GL_TEXTURE21 = 0x84D5
			Texture21 = unchecked((int)34005),
			// GL_TEXTURE22 = 0x84D6
			Texture22 = unchecked((int)34006),
			// GL_TEXTURE23 = 0x84D7
			Texture23 = unchecked((int)34007),
			// GL_TEXTURE24 = 0x84D8
			Texture24 = unchecked((int)34008),
			// GL_TEXTURE25 = 0x84D9
			Texture25 = unchecked((int)34009),
			// GL_TEXTURE26 = 0x84DA
			Texture26 = unchecked((int)34010),
			// GL_TEXTURE27 = 0x84DB
			Texture27 = unchecked((int)34011),
			// GL_TEXTURE28 = 0x84DC
			Texture28 = unchecked((int)34012),
			// GL_TEXTURE29 = 0x84DD
			Texture29 = unchecked((int)34013),
			// GL_TEXTURE30 = 0x84DE
			Texture30 = unchecked((int)34014),
			// GL_TEXTURE31 = 0x84DF
			Texture31 = unchecked((int)34015),
			// GL_ACTIVE_TEXTURE = 0x84E0
			ActiveTexture = unchecked((int)34016),
			// GL_MAX_RENDERBUFFER_SIZE = 0x84E8
			MaxRenderbufferSize = unchecked((int)34024),
			// GL_COMPRESSED_RGB = 0x84ED
			CompressedRgb = unchecked((int)34029),
			// GL_COMPRESSED_RGBA = 0x84EE
			CompressedRgba = unchecked((int)34030),
			// GL_TEXTURE_COMPRESSION_HINT = 0x84EF
			TextureCompressionHint = unchecked((int)34031),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
			UniformBlockReferencedByTessControlShader = unchecked((int)34032),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
			UniformBlockReferencedByTessEvaluationShader = unchecked((int)34033),
			// GL_TEXTURE_RECTANGLE = 0x84F5
			TextureRectangle = unchecked((int)34037),
			// GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
			TextureBindingRectangle = unchecked((int)34038),
			// GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
			ProxyTextureRectangle = unchecked((int)34039),
			// GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8
			MaxRectangleTextureSize = unchecked((int)34040),
			// GL_DEPTH_STENCIL = 0x84F9
			DepthStencil = unchecked((int)34041),
			// GL_UNSIGNED_INT_24_8 = 0x84FA
			UnsignedInt248 = unchecked((int)34042),
			// GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
			MaxTextureLodBias = unchecked((int)34045),
			// GL_TEXTURE_LOD_BIAS = 0x8501
			TextureLodBias = unchecked((int)34049),
			// GL_INCR_WRAP = 0x8507
			IncrWrap = unchecked((int)34055),
			// GL_DECR_WRAP = 0x8508
			DecrWrap = unchecked((int)34056),
			// GL_TEXTURE_CUBE_MAP = 0x8513
			TextureCubeMap = unchecked((int)34067),
			// GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
			TextureBindingCubeMap = unchecked((int)34068),
			// GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
			TextureCubeMapPositiveX = unchecked((int)34069),
			// GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
			TextureCubeMapNegativeX = unchecked((int)34070),
			// GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
			TextureCubeMapPositiveY = unchecked((int)34071),
			// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
			TextureCubeMapNegativeY = unchecked((int)34072),
			// GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
			TextureCubeMapPositiveZ = unchecked((int)34073),
			// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
			TextureCubeMapNegativeZ = unchecked((int)34074),
			// GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
			ProxyTextureCubeMap = unchecked((int)34075),
			// GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
			MaxCubeMapTextureSize = unchecked((int)34076),
			// GL_SRC1_ALPHA = 0x8589
			Src1Alpha = unchecked((int)34185),
			// GL_VERTEX_ARRAY_BINDING = 0x85B5
			VertexArrayBinding = unchecked((int)34229),
			// GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
			VertexAttribArrayEnabled = unchecked((int)34338),
			// GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
			VertexAttribArraySize = unchecked((int)34339),
			// GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
			VertexAttribArrayStride = unchecked((int)34340),
			// GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
			VertexAttribArrayType = unchecked((int)34341),
			// GL_CURRENT_VERTEX_ATTRIB = 0x8626
			CurrentVertexAttrib = unchecked((int)34342),
			// GL_PROGRAM_POINT_SIZE = 0x8642
			ProgramPointSize = unchecked((int)34370),
			// GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
			VertexProgramPointSize = unchecked((int)34370),
			// GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
			VertexAttribArrayPointer = unchecked((int)34373),
			// GL_DEPTH_CLAMP = 0x864F
			DepthClamp = unchecked((int)34383),
			// GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0
			TextureCompressedImageSize = unchecked((int)34464),
			// GL_TEXTURE_COMPRESSED = 0x86A1
			TextureCompressed = unchecked((int)34465),
			// GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
			NumCompressedTextureFormats = unchecked((int)34466),
			// GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
			CompressedTextureFormats = unchecked((int)34467),
			// GL_PROGRAM_BINARY_LENGTH = 0x8741
			ProgramBinaryLength = unchecked((int)34625),
			// GL_MIRROR_CLAMP_TO_EDGE = 0x8743
			MirrorClampToEdge = unchecked((int)34627),
			// GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
			VertexAttribArrayLong = unchecked((int)34638),
			// GL_BUFFER_SIZE = 0x8764
			BufferSize = unchecked((int)34660),
			// GL_BUFFER_USAGE = 0x8765
			BufferUsage = unchecked((int)34661),
			// GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE
			NumProgramBinaryFormats = unchecked((int)34814),
			// GL_PROGRAM_BINARY_FORMATS = 0x87FF
			ProgramBinaryFormats = unchecked((int)34815),
			// GL_STENCIL_BACK_FUNC = 0x8800
			StencilBackFunc = unchecked((int)34816),
			// GL_STENCIL_BACK_FAIL = 0x8801
			StencilBackFail = unchecked((int)34817),
			// GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
			StencilBackPassDepthFail = unchecked((int)34818),
			// GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
			StencilBackPassDepthPass = unchecked((int)34819),
			// GL_RGBA32F = 0x8814
			Rgba32f = unchecked((int)34836),
			// GL_RGB32F = 0x8815
			Rgb32f = unchecked((int)34837),
			// GL_RGBA16F = 0x881A
			Rgba16f = unchecked((int)34842),
			// GL_RGB16F = 0x881B
			Rgb16f = unchecked((int)34843),
			// GL_MAX_DRAW_BUFFERS = 0x8824
			MaxDrawBuffers = unchecked((int)34852),
			// GL_DRAW_BUFFER0 = 0x8825
			DrawBuffer0 = unchecked((int)34853),
			// GL_DRAW_BUFFER1 = 0x8826
			DrawBuffer1 = unchecked((int)34854),
			// GL_DRAW_BUFFER2 = 0x8827
			DrawBuffer2 = unchecked((int)34855),
			// GL_DRAW_BUFFER3 = 0x8828
			DrawBuffer3 = unchecked((int)34856),
			// GL_DRAW_BUFFER4 = 0x8829
			DrawBuffer4 = unchecked((int)34857),
			// GL_DRAW_BUFFER5 = 0x882A
			DrawBuffer5 = unchecked((int)34858),
			// GL_DRAW_BUFFER6 = 0x882B
			DrawBuffer6 = unchecked((int)34859),
			// GL_DRAW_BUFFER7 = 0x882C
			DrawBuffer7 = unchecked((int)34860),
			// GL_DRAW_BUFFER8 = 0x882D
			DrawBuffer8 = unchecked((int)34861),
			// GL_DRAW_BUFFER9 = 0x882E
			DrawBuffer9 = unchecked((int)34862),
			// GL_DRAW_BUFFER10 = 0x882F
			DrawBuffer10 = unchecked((int)34863),
			// GL_DRAW_BUFFER11 = 0x8830
			DrawBuffer11 = unchecked((int)34864),
			// GL_DRAW_BUFFER12 = 0x8831
			DrawBuffer12 = unchecked((int)34865),
			// GL_DRAW_BUFFER13 = 0x8832
			DrawBuffer13 = unchecked((int)34866),
			// GL_DRAW_BUFFER14 = 0x8833
			DrawBuffer14 = unchecked((int)34867),
			// GL_DRAW_BUFFER15 = 0x8834
			DrawBuffer15 = unchecked((int)34868),
			// GL_BLEND_EQUATION_ALPHA = 0x883D
			BlendEquationAlpha = unchecked((int)34877),
			// GL_TEXTURE_DEPTH_SIZE = 0x884A
			TextureDepthSize = unchecked((int)34890),
			// GL_TEXTURE_COMPARE_MODE = 0x884C
			TextureCompareMode = unchecked((int)34892),
			// GL_TEXTURE_COMPARE_FUNC = 0x884D
			TextureCompareFunc = unchecked((int)34893),
			// GL_COMPARE_REF_TO_TEXTURE = 0x884E
			CompareRefToTexture = unchecked((int)34894),
			// GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
			TextureCubeMapSeamless = unchecked((int)34895),
			// GL_QUERY_COUNTER_BITS = 0x8864
			QueryCounterBits = unchecked((int)34916),
			// GL_CURRENT_QUERY = 0x8865
			CurrentQuery = unchecked((int)34917),
			// GL_QUERY_RESULT = 0x8866
			QueryResult = unchecked((int)34918),
			// GL_QUERY_RESULT_AVAILABLE = 0x8867
			QueryResultAvailable = unchecked((int)34919),
			// GL_MAX_VERTEX_ATTRIBS = 0x8869
			MaxVertexAttribs = unchecked((int)34921),
			// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
			VertexAttribArrayNormalized = unchecked((int)34922),
			// GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C
			MaxTessControlInputComponents = unchecked((int)34924),
			// GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D
			MaxTessEvaluationInputComponents = unchecked((int)34925),
			// GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
			MaxTextureImageUnits = unchecked((int)34930),
			// GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
			GeometryShaderInvocations = unchecked((int)34943),
			// GL_ARRAY_BUFFER = 0x8892
			ArrayBuffer = unchecked((int)34962),
			// GL_ELEMENT_ARRAY_BUFFER = 0x8893
			ElementArrayBuffer = unchecked((int)34963),
			// GL_ARRAY_BUFFER_BINDING = 0x8894
			ArrayBufferBinding = unchecked((int)34964),
			// GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
			ElementArrayBufferBinding = unchecked((int)34965),
			// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
			VertexAttribArrayBufferBinding = unchecked((int)34975),
			// GL_READ_ONLY = 0x88B8
			ReadOnly = unchecked((int)35000),
			// GL_WRITE_ONLY = 0x88B9
			WriteOnly = unchecked((int)35001),
			// GL_READ_WRITE = 0x88BA
			ReadWrite = unchecked((int)35002),
			// GL_BUFFER_ACCESS = 0x88BB
			BufferAccess = unchecked((int)35003),
			// GL_BUFFER_MAPPED = 0x88BC
			BufferMapped = unchecked((int)35004),
			// GL_BUFFER_MAP_POINTER = 0x88BD
			BufferMapPointer = unchecked((int)35005),
			// GL_TIME_ELAPSED = 0x88BF
			TimeElapsed = unchecked((int)35007),
			// GL_STREAM_DRAW = 0x88E0
			StreamDraw = unchecked((int)35040),
			// GL_STREAM_READ = 0x88E1
			StreamRead = unchecked((int)35041),
			// GL_STREAM_COPY = 0x88E2
			StreamCopy = unchecked((int)35042),
			// GL_STATIC_DRAW = 0x88E4
			StaticDraw = unchecked((int)35044),
			// GL_STATIC_READ = 0x88E5
			StaticRead = unchecked((int)35045),
			// GL_STATIC_COPY = 0x88E6
			StaticCopy = unchecked((int)35046),
			// GL_DYNAMIC_DRAW = 0x88E8
			DynamicDraw = unchecked((int)35048),
			// GL_DYNAMIC_READ = 0x88E9
			DynamicRead = unchecked((int)35049),
			// GL_DYNAMIC_COPY = 0x88EA
			DynamicCopy = unchecked((int)35050),
			// GL_PIXEL_PACK_BUFFER = 0x88EB
			PixelPackBuffer = unchecked((int)35051),
			// GL_PIXEL_UNPACK_BUFFER = 0x88EC
			PixelUnpackBuffer = unchecked((int)35052),
			// GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
			PixelPackBufferBinding = unchecked((int)35053),
			// GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
			PixelUnpackBufferBinding = unchecked((int)35055),
			// GL_DEPTH24_STENCIL8 = 0x88F0
			Depth24Stencil8 = unchecked((int)35056),
			// GL_TEXTURE_STENCIL_SIZE = 0x88F1
			TextureStencilSize = unchecked((int)35057),
			// GL_SRC1_COLOR = 0x88F9
			Src1Color = unchecked((int)35065),
			// GL_ONE_MINUS_SRC1_COLOR = 0x88FA
			OneMinusSrc1Color = unchecked((int)35066),
			// GL_ONE_MINUS_SRC1_ALPHA = 0x88FB
			OneMinusSrc1Alpha = unchecked((int)35067),
			// GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC
			MaxDualSourceDrawBuffers = unchecked((int)35068),
			// GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
			VertexAttribArrayInteger = unchecked((int)35069),
			// GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
			VertexAttribArrayDivisor = unchecked((int)35070),
			// GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
			MaxArrayTextureLayers = unchecked((int)35071),
			// GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
			MinProgramTexelOffset = unchecked((int)35076),
			// GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
			MaxProgramTexelOffset = unchecked((int)35077),
			// GL_SAMPLES_PASSED = 0x8914
			SamplesPassed = unchecked((int)35092),
			// GL_GEOMETRY_VERTICES_OUT = 0x8916
			GeometryVerticesOut = unchecked((int)35094),
			// GL_GEOMETRY_INPUT_TYPE = 0x8917
			GeometryInputType = unchecked((int)35095),
			// GL_GEOMETRY_OUTPUT_TYPE = 0x8918
			GeometryOutputType = unchecked((int)35096),
			// GL_SAMPLER_BINDING = 0x8919
			SamplerBinding = unchecked((int)35097),
			// GL_CLAMP_READ_COLOR = 0x891C
			ClampReadColor = unchecked((int)35100),
			// GL_FIXED_ONLY = 0x891D
			FixedOnly = unchecked((int)35101),
			// GL_UNIFORM_BUFFER = 0x8A11
			UniformBuffer = unchecked((int)35345),
			// GL_UNIFORM_BUFFER_BINDING = 0x8A28
			UniformBufferBinding = unchecked((int)35368),
			// GL_UNIFORM_BUFFER_START = 0x8A29
			UniformBufferStart = unchecked((int)35369),
			// GL_UNIFORM_BUFFER_SIZE = 0x8A2A
			UniformBufferSize = unchecked((int)35370),
			// GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
			MaxVertexUniformBlocks = unchecked((int)35371),
			// GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C
			MaxGeometryUniformBlocks = unchecked((int)35372),
			// GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
			MaxFragmentUniformBlocks = unchecked((int)35373),
			// GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
			MaxCombinedUniformBlocks = unchecked((int)35374),
			// GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
			MaxUniformBufferBindings = unchecked((int)35375),
			// GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
			MaxUniformBlockSize = unchecked((int)35376),
			// GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
			MaxCombinedVertexUniformComponents = unchecked((int)35377),
			// GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32
			MaxCombinedGeometryUniformComponents = unchecked((int)35378),
			// GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
			MaxCombinedFragmentUniformComponents = unchecked((int)35379),
			// GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
			UniformBufferOffsetAlignment = unchecked((int)35380),
			// GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
			ActiveUniformBlockMaxNameLength = unchecked((int)35381),
			// GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
			ActiveUniformBlocks = unchecked((int)35382),
			// GL_UNIFORM_TYPE = 0x8A37
			UniformType = unchecked((int)35383),
			// GL_UNIFORM_SIZE = 0x8A38
			UniformSize = unchecked((int)35384),
			// GL_UNIFORM_NAME_LENGTH = 0x8A39
			UniformNameLength = unchecked((int)35385),
			// GL_UNIFORM_BLOCK_INDEX = 0x8A3A
			UniformBlockIndex = unchecked((int)35386),
			// GL_UNIFORM_OFFSET = 0x8A3B
			UniformOffset = unchecked((int)35387),
			// GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
			UniformArrayStride = unchecked((int)35388),
			// GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
			UniformMatrixStride = unchecked((int)35389),
			// GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
			UniformIsRowMajor = unchecked((int)35390),
			// GL_UNIFORM_BLOCK_BINDING = 0x8A3F
			UniformBlockBinding = unchecked((int)35391),
			// GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
			UniformBlockDataSize = unchecked((int)35392),
			// GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
			UniformBlockNameLength = unchecked((int)35393),
			// GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
			UniformBlockActiveUniforms = unchecked((int)35394),
			// GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
			UniformBlockActiveUniformIndices = unchecked((int)35395),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
			UniformBlockReferencedByVertexShader = unchecked((int)35396),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
			UniformBlockReferencedByGeometryShader = unchecked((int)35397),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
			UniformBlockReferencedByFragmentShader = unchecked((int)35398),
			// GL_FRAGMENT_SHADER = 0x8B30
			FragmentShader = unchecked((int)35632),
			// GL_VERTEX_SHADER = 0x8B31
			VertexShader = unchecked((int)35633),
			// GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
			MaxFragmentUniformComponents = unchecked((int)35657),
			// GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
			MaxVertexUniformComponents = unchecked((int)35658),
			// GL_MAX_VARYING_COMPONENTS = 0x8B4B
			MaxVaryingComponents = unchecked((int)35659),
			// GL_MAX_VARYING_FLOATS = 0x8B4B
			MaxVaryingFloats = unchecked((int)35659),
			// GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
			MaxVertexTextureImageUnits = unchecked((int)35660),
			// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
			MaxCombinedTextureImageUnits = unchecked((int)35661),
			// GL_SHADER_TYPE = 0x8B4F
			ShaderType = unchecked((int)35663),
			// GL_FLOAT_VEC2 = 0x8B50
			FloatVec2 = unchecked((int)35664),
			// GL_FLOAT_VEC3 = 0x8B51
			FloatVec3 = unchecked((int)35665),
			// GL_FLOAT_VEC4 = 0x8B52
			FloatVec4 = unchecked((int)35666),
			// GL_INT_VEC2 = 0x8B53
			IntVec2 = unchecked((int)35667),
			// GL_INT_VEC3 = 0x8B54
			IntVec3 = unchecked((int)35668),
			// GL_INT_VEC4 = 0x8B55
			IntVec4 = unchecked((int)35669),
			// GL_BOOL = 0x8B56
			Bool = unchecked((int)35670),
			// GL_BOOL_VEC2 = 0x8B57
			BoolVec2 = unchecked((int)35671),
			// GL_BOOL_VEC3 = 0x8B58
			BoolVec3 = unchecked((int)35672),
			// GL_BOOL_VEC4 = 0x8B59
			BoolVec4 = unchecked((int)35673),
			// GL_FLOAT_MAT2 = 0x8B5A
			FloatMat2 = unchecked((int)35674),
			// GL_FLOAT_MAT3 = 0x8B5B
			FloatMat3 = unchecked((int)35675),
			// GL_FLOAT_MAT4 = 0x8B5C
			FloatMat4 = unchecked((int)35676),
			// GL_SAMPLER_1D = 0x8B5D
			Sampler1d = unchecked((int)35677),
			// GL_SAMPLER_2D = 0x8B5E
			Sampler2d = unchecked((int)35678),
			// GL_SAMPLER_3D = 0x8B5F
			Sampler3d = unchecked((int)35679),
			// GL_SAMPLER_CUBE = 0x8B60
			SamplerCube = unchecked((int)35680),
			// GL_SAMPLER_1D_SHADOW = 0x8B61
			Sampler1dShadow = unchecked((int)35681),
			// GL_SAMPLER_2D_SHADOW = 0x8B62
			Sampler2dShadow = unchecked((int)35682),
			// GL_SAMPLER_2D_RECT = 0x8B63
			Sampler2dRect = unchecked((int)35683),
			// GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
			Sampler2dRectShadow = unchecked((int)35684),
			// GL_FLOAT_MAT2x3 = 0x8B65
			FloatMat2x3 = unchecked((int)35685),
			// GL_FLOAT_MAT2x4 = 0x8B66
			FloatMat2x4 = unchecked((int)35686),
			// GL_FLOAT_MAT3x2 = 0x8B67
			FloatMat3x2 = unchecked((int)35687),
			// GL_FLOAT_MAT3x4 = 0x8B68
			FloatMat3x4 = unchecked((int)35688),
			// GL_FLOAT_MAT4x2 = 0x8B69
			FloatMat4x2 = unchecked((int)35689),
			// GL_FLOAT_MAT4x3 = 0x8B6A
			FloatMat4x3 = unchecked((int)35690),
			// GL_DELETE_STATUS = 0x8B80
			DeleteStatus = unchecked((int)35712),
			// GL_COMPILE_STATUS = 0x8B81
			CompileStatus = unchecked((int)35713),
			// GL_LINK_STATUS = 0x8B82
			LinkStatus = unchecked((int)35714),
			// GL_VALIDATE_STATUS = 0x8B83
			ValidateStatus = unchecked((int)35715),
			// GL_INFO_LOG_LENGTH = 0x8B84
			InfoLogLength = unchecked((int)35716),
			// GL_ATTACHED_SHADERS = 0x8B85
			AttachedShaders = unchecked((int)35717),
			// GL_ACTIVE_UNIFORMS = 0x8B86
			ActiveUniforms = unchecked((int)35718),
			// GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
			ActiveUniformMaxLength = unchecked((int)35719),
			// GL_SHADER_SOURCE_LENGTH = 0x8B88
			ShaderSourceLength = unchecked((int)35720),
			// GL_ACTIVE_ATTRIBUTES = 0x8B89
			ActiveAttributes = unchecked((int)35721),
			// GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
			ActiveAttributeMaxLength = unchecked((int)35722),
			// GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
			FragmentShaderDerivativeHint = unchecked((int)35723),
			// GL_SHADING_LANGUAGE_VERSION = 0x8B8C
			ShadingLanguageVersion = unchecked((int)35724),
			// GL_CURRENT_PROGRAM = 0x8B8D
			CurrentProgram = unchecked((int)35725),
			// GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
			ImplementationColorReadType = unchecked((int)35738),
			// GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
			ImplementationColorReadFormat = unchecked((int)35739),
			// GL_TEXTURE_RED_TYPE = 0x8C10
			TextureRedType = unchecked((int)35856),
			// GL_TEXTURE_GREEN_TYPE = 0x8C11
			TextureGreenType = unchecked((int)35857),
			// GL_TEXTURE_BLUE_TYPE = 0x8C12
			TextureBlueType = unchecked((int)35858),
			// GL_TEXTURE_ALPHA_TYPE = 0x8C13
			TextureAlphaType = unchecked((int)35859),
			// GL_TEXTURE_DEPTH_TYPE = 0x8C16
			TextureDepthType = unchecked((int)35862),
			// GL_UNSIGNED_NORMALIZED = 0x8C17
			UnsignedNormalized = unchecked((int)35863),
			// GL_TEXTURE_1D_ARRAY = 0x8C18
			Texture1dArray = unchecked((int)35864),
			// GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
			ProxyTexture1dArray = unchecked((int)35865),
			// GL_TEXTURE_2D_ARRAY = 0x8C1A
			Texture2dArray = unchecked((int)35866),
			// GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
			ProxyTexture2dArray = unchecked((int)35867),
			// GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C
			TextureBinding1dArray = unchecked((int)35868),
			// GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
			TextureBinding2dArray = unchecked((int)35869),
			// GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29
			MaxGeometryTextureImageUnits = unchecked((int)35881),
			// GL_TEXTURE_BUFFER = 0x8C2A
			TextureBuffer = unchecked((int)35882),
			// GL_TEXTURE_BUFFER_BINDING = 0x8C2A
			TextureBufferBinding = unchecked((int)35882),
			// GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B
			MaxTextureBufferSize = unchecked((int)35883),
			// GL_TEXTURE_BINDING_BUFFER = 0x8C2C
			TextureBindingBuffer = unchecked((int)35884),
			// GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D
			TextureBufferDataStoreBinding = unchecked((int)35885),
			// GL_ANY_SAMPLES_PASSED = 0x8C2F
			AnySamplesPassed = unchecked((int)35887),
			// GL_SAMPLE_SHADING = 0x8C36
			SampleShading = unchecked((int)35894),
			// GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37
			MinSampleShadingValue = unchecked((int)35895),
			// GL_R11F_G11F_B10F = 0x8C3A
			R11fG11fB10f = unchecked((int)35898),
			// GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
			UnsignedInt10f11f11fRev = unchecked((int)35899),
			// GL_RGB9_E5 = 0x8C3D
			Rgb9E5 = unchecked((int)35901),
			// GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
			UnsignedInt5999Rev = unchecked((int)35902),
			// GL_TEXTURE_SHARED_SIZE = 0x8C3F
			TextureSharedSize = unchecked((int)35903),
			// GL_SRGB = 0x8C40
			Srgb = unchecked((int)35904),
			// GL_SRGB8 = 0x8C41
			Srgb8 = unchecked((int)35905),
			// GL_SRGB_ALPHA = 0x8C42
			SrgbAlpha = unchecked((int)35906),
			// GL_SRGB8_ALPHA8 = 0x8C43
			Srgb8Alpha8 = unchecked((int)35907),
			// GL_COMPRESSED_SRGB = 0x8C48
			CompressedSrgb = unchecked((int)35912),
			// GL_COMPRESSED_SRGB_ALPHA = 0x8C49
			CompressedSrgbAlpha = unchecked((int)35913),
			// GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
			TransformFeedbackVaryingMaxLength = unchecked((int)35958),
			// GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
			TransformFeedbackBufferMode = unchecked((int)35967),
			// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
			MaxTransformFeedbackSeparateComponents = unchecked((int)35968),
			// GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
			TransformFeedbackVaryings = unchecked((int)35971),
			// GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
			TransformFeedbackBufferStart = unchecked((int)35972),
			// GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
			TransformFeedbackBufferSize = unchecked((int)35973),
			// GL_PRIMITIVES_GENERATED = 0x8C87
			PrimitivesGenerated = unchecked((int)35975),
			// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
			TransformFeedbackPrimitivesWritten = unchecked((int)35976),
			// GL_RASTERIZER_DISCARD = 0x8C89
			RasterizerDiscard = unchecked((int)35977),
			// GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
			MaxTransformFeedbackInterleavedComponents = unchecked((int)35978),
			// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
			MaxTransformFeedbackSeparateAttribs = unchecked((int)35979),
			// GL_INTERLEAVED_ATTRIBS = 0x8C8C
			InterleavedAttribs = unchecked((int)35980),
			// GL_SEPARATE_ATTRIBS = 0x8C8D
			SeparateAttribs = unchecked((int)35981),
			// GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
			TransformFeedbackBuffer = unchecked((int)35982),
			// GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
			TransformFeedbackBufferBinding = unchecked((int)35983),
			// GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0
			PointSpriteCoordOrigin = unchecked((int)36000),
			// GL_LOWER_LEFT = 0x8CA1
			LowerLeft = unchecked((int)36001),
			// GL_UPPER_LEFT = 0x8CA2
			UpperLeft = unchecked((int)36002),
			// GL_STENCIL_BACK_REF = 0x8CA3
			StencilBackRef = unchecked((int)36003),
			// GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
			StencilBackValueMask = unchecked((int)36004),
			// GL_STENCIL_BACK_WRITEMASK = 0x8CA5
			StencilBackWritemask = unchecked((int)36005),
			// GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
			DrawFramebufferBinding = unchecked((int)36006),
			// GL_FRAMEBUFFER_BINDING = 0x8CA6
			FramebufferBinding = unchecked((int)36006),
			// GL_RENDERBUFFER_BINDING = 0x8CA7
			RenderbufferBinding = unchecked((int)36007),
			// GL_READ_FRAMEBUFFER = 0x8CA8
			ReadFramebuffer = unchecked((int)36008),
			// GL_DRAW_FRAMEBUFFER = 0x8CA9
			DrawFramebuffer = unchecked((int)36009),
			// GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
			ReadFramebufferBinding = unchecked((int)36010),
			// GL_RENDERBUFFER_SAMPLES = 0x8CAB
			RenderbufferSamples = unchecked((int)36011),
			// GL_DEPTH_COMPONENT32F = 0x8CAC
			DepthComponent32f = unchecked((int)36012),
			// GL_DEPTH32F_STENCIL8 = 0x8CAD
			Depth32fStencil8 = unchecked((int)36013),
			// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
			FramebufferAttachmentObjectType = unchecked((int)36048),
			// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
			FramebufferAttachmentObjectName = unchecked((int)36049),
			// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
			FramebufferAttachmentTextureLevel = unchecked((int)36050),
			// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
			FramebufferAttachmentTextureCubeMapFace = unchecked((int)36051),
			// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
			FramebufferAttachmentTextureLayer = unchecked((int)36052),
			// GL_FRAMEBUFFER_COMPLETE = 0x8CD5
			FramebufferComplete = unchecked((int)36053),
			// GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
			FramebufferIncompleteAttachment = unchecked((int)36054),
			// GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
			FramebufferIncompleteMissingAttachment = unchecked((int)36055),
			// GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
			FramebufferIncompleteDrawBuffer = unchecked((int)36059),
			// GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
			FramebufferIncompleteReadBuffer = unchecked((int)36060),
			// GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
			FramebufferUnsupported = unchecked((int)36061),
			// GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
			MaxColorAttachments = unchecked((int)36063),
			// GL_COLOR_ATTACHMENT0 = 0x8CE0
			ColorAttachment0 = unchecked((int)36064),
			// GL_COLOR_ATTACHMENT1 = 0x8CE1
			ColorAttachment1 = unchecked((int)36065),
			// GL_COLOR_ATTACHMENT2 = 0x8CE2
			ColorAttachment2 = unchecked((int)36066),
			// GL_COLOR_ATTACHMENT3 = 0x8CE3
			ColorAttachment3 = unchecked((int)36067),
			// GL_COLOR_ATTACHMENT4 = 0x8CE4
			ColorAttachment4 = unchecked((int)36068),
			// GL_COLOR_ATTACHMENT5 = 0x8CE5
			ColorAttachment5 = unchecked((int)36069),
			// GL_COLOR_ATTACHMENT6 = 0x8CE6
			ColorAttachment6 = unchecked((int)36070),
			// GL_COLOR_ATTACHMENT7 = 0x8CE7
			ColorAttachment7 = unchecked((int)36071),
			// GL_COLOR_ATTACHMENT8 = 0x8CE8
			ColorAttachment8 = unchecked((int)36072),
			// GL_COLOR_ATTACHMENT9 = 0x8CE9
			ColorAttachment9 = unchecked((int)36073),
			// GL_COLOR_ATTACHMENT10 = 0x8CEA
			ColorAttachment10 = unchecked((int)36074),
			// GL_COLOR_ATTACHMENT11 = 0x8CEB
			ColorAttachment11 = unchecked((int)36075),
			// GL_COLOR_ATTACHMENT12 = 0x8CEC
			ColorAttachment12 = unchecked((int)36076),
			// GL_COLOR_ATTACHMENT13 = 0x8CED
			ColorAttachment13 = unchecked((int)36077),
			// GL_COLOR_ATTACHMENT14 = 0x8CEE
			ColorAttachment14 = unchecked((int)36078),
			// GL_COLOR_ATTACHMENT15 = 0x8CEF
			ColorAttachment15 = unchecked((int)36079),
			// GL_COLOR_ATTACHMENT16 = 0x8CF0
			ColorAttachment16 = unchecked((int)36080),
			// GL_COLOR_ATTACHMENT17 = 0x8CF1
			ColorAttachment17 = unchecked((int)36081),
			// GL_COLOR_ATTACHMENT18 = 0x8CF2
			ColorAttachment18 = unchecked((int)36082),
			// GL_COLOR_ATTACHMENT19 = 0x8CF3
			ColorAttachment19 = unchecked((int)36083),
			// GL_COLOR_ATTACHMENT20 = 0x8CF4
			ColorAttachment20 = unchecked((int)36084),
			// GL_COLOR_ATTACHMENT21 = 0x8CF5
			ColorAttachment21 = unchecked((int)36085),
			// GL_COLOR_ATTACHMENT22 = 0x8CF6
			ColorAttachment22 = unchecked((int)36086),
			// GL_COLOR_ATTACHMENT23 = 0x8CF7
			ColorAttachment23 = unchecked((int)36087),
			// GL_COLOR_ATTACHMENT24 = 0x8CF8
			ColorAttachment24 = unchecked((int)36088),
			// GL_COLOR_ATTACHMENT25 = 0x8CF9
			ColorAttachment25 = unchecked((int)36089),
			// GL_COLOR_ATTACHMENT26 = 0x8CFA
			ColorAttachment26 = unchecked((int)36090),
			// GL_COLOR_ATTACHMENT27 = 0x8CFB
			ColorAttachment27 = unchecked((int)36091),
			// GL_COLOR_ATTACHMENT28 = 0x8CFC
			ColorAttachment28 = unchecked((int)36092),
			// GL_COLOR_ATTACHMENT29 = 0x8CFD
			ColorAttachment29 = unchecked((int)36093),
			// GL_COLOR_ATTACHMENT30 = 0x8CFE
			ColorAttachment30 = unchecked((int)36094),
			// GL_COLOR_ATTACHMENT31 = 0x8CFF
			ColorAttachment31 = unchecked((int)36095),
			// GL_DEPTH_ATTACHMENT = 0x8D00
			DepthAttachment = unchecked((int)36096),
			// GL_STENCIL_ATTACHMENT = 0x8D20
			StencilAttachment = unchecked((int)36128),
			// GL_FRAMEBUFFER = 0x8D40
			Framebuffer = unchecked((int)36160),
			// GL_RENDERBUFFER = 0x8D41
			Renderbuffer = unchecked((int)36161),
			// GL_RENDERBUFFER_WIDTH = 0x8D42
			RenderbufferWidth = unchecked((int)36162),
			// GL_RENDERBUFFER_HEIGHT = 0x8D43
			RenderbufferHeight = unchecked((int)36163),
			// GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
			RenderbufferInternalFormat = unchecked((int)36164),
			// GL_STENCIL_INDEX1 = 0x8D46
			StencilIndex1 = unchecked((int)36166),
			// GL_STENCIL_INDEX4 = 0x8D47
			StencilIndex4 = unchecked((int)36167),
			// GL_STENCIL_INDEX8 = 0x8D48
			StencilIndex8 = unchecked((int)36168),
			// GL_STENCIL_INDEX16 = 0x8D49
			StencilIndex16 = unchecked((int)36169),
			// GL_RENDERBUFFER_RED_SIZE = 0x8D50
			RenderbufferRedSize = unchecked((int)36176),
			// GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
			RenderbufferGreenSize = unchecked((int)36177),
			// GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
			RenderbufferBlueSize = unchecked((int)36178),
			// GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
			RenderbufferAlphaSize = unchecked((int)36179),
			// GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
			RenderbufferDepthSize = unchecked((int)36180),
			// GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
			RenderbufferStencilSize = unchecked((int)36181),
			// GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
			FramebufferIncompleteMultisample = unchecked((int)36182),
			// GL_MAX_SAMPLES = 0x8D57
			MaxSamples = unchecked((int)36183),
			// GL_RGB565 = 0x8D62
			Rgb565 = unchecked((int)36194),
			// GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
			PrimitiveRestartFixedIndex = unchecked((int)36201),
			// GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
			AnySamplesPassedConservative = unchecked((int)36202),
			// GL_MAX_ELEMENT_INDEX = 0x8D6B
			MaxElementIndex = unchecked((int)36203),
			// GL_RGBA32UI = 0x8D70
			Rgba32ui = unchecked((int)36208),
			// GL_RGB32UI = 0x8D71
			Rgb32ui = unchecked((int)36209),
			// GL_RGBA16UI = 0x8D76
			Rgba16ui = unchecked((int)36214),
			// GL_RGB16UI = 0x8D77
			Rgb16ui = unchecked((int)36215),
			// GL_RGBA8UI = 0x8D7C
			Rgba8ui = unchecked((int)36220),
			// GL_RGB8UI = 0x8D7D
			Rgb8ui = unchecked((int)36221),
			// GL_RGBA32I = 0x8D82
			Rgba32i = unchecked((int)36226),
			// GL_RGB32I = 0x8D83
			Rgb32i = unchecked((int)36227),
			// GL_RGBA16I = 0x8D88
			Rgba16i = unchecked((int)36232),
			// GL_RGB16I = 0x8D89
			Rgb16i = unchecked((int)36233),
			// GL_RGBA8I = 0x8D8E
			Rgba8i = unchecked((int)36238),
			// GL_RGB8I = 0x8D8F
			Rgb8i = unchecked((int)36239),
			// GL_RED_INTEGER = 0x8D94
			RedInteger = unchecked((int)36244),
			// GL_GREEN_INTEGER = 0x8D95
			GreenInteger = unchecked((int)36245),
			// GL_BLUE_INTEGER = 0x8D96
			BlueInteger = unchecked((int)36246),
			// GL_RGB_INTEGER = 0x8D98
			RgbInteger = unchecked((int)36248),
			// GL_RGBA_INTEGER = 0x8D99
			RgbaInteger = unchecked((int)36249),
			// GL_BGR_INTEGER = 0x8D9A
			BgrInteger = unchecked((int)36250),
			// GL_BGRA_INTEGER = 0x8D9B
			BgraInteger = unchecked((int)36251),
			// GL_INT_2_10_10_10_REV = 0x8D9F
			Int2101010Rev = unchecked((int)36255),
			// GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
			FramebufferAttachmentLayered = unchecked((int)36263),
			// GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
			FramebufferIncompleteLayerTargets = unchecked((int)36264),
			// GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
			Float32UnsignedInt248Rev = unchecked((int)36269),
			// GL_FRAMEBUFFER_SRGB = 0x8DB9
			FramebufferSrgb = unchecked((int)36281),
			// GL_COMPRESSED_RED_RGTC1 = 0x8DBB
			CompressedRedRgtc1 = unchecked((int)36283),
			// GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
			CompressedSignedRedRgtc1 = unchecked((int)36284),
			// GL_COMPRESSED_RG_RGTC2 = 0x8DBD
			CompressedRgRgtc2 = unchecked((int)36285),
			// GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
			CompressedSignedRgRgtc2 = unchecked((int)36286),
			// GL_SAMPLER_1D_ARRAY = 0x8DC0
			Sampler1dArray = unchecked((int)36288),
			// GL_SAMPLER_2D_ARRAY = 0x8DC1
			Sampler2dArray = unchecked((int)36289),
			// GL_SAMPLER_BUFFER = 0x8DC2
			SamplerBuffer = unchecked((int)36290),
			// GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3
			Sampler1dArrayShadow = unchecked((int)36291),
			// GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
			Sampler2dArrayShadow = unchecked((int)36292),
			// GL_SAMPLER_CUBE_SHADOW = 0x8DC5
			SamplerCubeShadow = unchecked((int)36293),
			// GL_UNSIGNED_INT_VEC2 = 0x8DC6
			UnsignedIntVec2 = unchecked((int)36294),
			// GL_UNSIGNED_INT_VEC3 = 0x8DC7
			UnsignedIntVec3 = unchecked((int)36295),
			// GL_UNSIGNED_INT_VEC4 = 0x8DC8
			UnsignedIntVec4 = unchecked((int)36296),
			// GL_INT_SAMPLER_1D = 0x8DC9
			IntSampler1d = unchecked((int)36297),
			// GL_INT_SAMPLER_2D = 0x8DCA
			IntSampler2d = unchecked((int)36298),
			// GL_INT_SAMPLER_3D = 0x8DCB
			IntSampler3d = unchecked((int)36299),
			// GL_INT_SAMPLER_CUBE = 0x8DCC
			IntSamplerCube = unchecked((int)36300),
			// GL_INT_SAMPLER_2D_RECT = 0x8DCD
			IntSampler2dRect = unchecked((int)36301),
			// GL_INT_SAMPLER_1D_ARRAY = 0x8DCE
			IntSampler1dArray = unchecked((int)36302),
			// GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
			IntSampler2dArray = unchecked((int)36303),
			// GL_INT_SAMPLER_BUFFER = 0x8DD0
			IntSamplerBuffer = unchecked((int)36304),
			// GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1
			UnsignedIntSampler1d = unchecked((int)36305),
			// GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
			UnsignedIntSampler2d = unchecked((int)36306),
			// GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
			UnsignedIntSampler3d = unchecked((int)36307),
			// GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
			UnsignedIntSamplerCube = unchecked((int)36308),
			// GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5
			UnsignedIntSampler2dRect = unchecked((int)36309),
			// GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6
			UnsignedIntSampler1dArray = unchecked((int)36310),
			// GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
			UnsignedIntSampler2dArray = unchecked((int)36311),
			// GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8
			UnsignedIntSamplerBuffer = unchecked((int)36312),
			// GL_GEOMETRY_SHADER = 0x8DD9
			GeometryShader = unchecked((int)36313),
			// GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF
			MaxGeometryUniformComponents = unchecked((int)36319),
			// GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0
			MaxGeometryOutputVertices = unchecked((int)36320),
			// GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1
			MaxGeometryTotalOutputComponents = unchecked((int)36321),
			// GL_ACTIVE_SUBROUTINES = 0x8DE5
			ActiveSubroutines = unchecked((int)36325),
			// GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
			ActiveSubroutineUniforms = unchecked((int)36326),
			// GL_MAX_SUBROUTINES = 0x8DE7
			MaxSubroutines = unchecked((int)36327),
			// GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8
			MaxSubroutineUniformLocations = unchecked((int)36328),
			// GL_LOW_FLOAT = 0x8DF0
			LowFloat = unchecked((int)36336),
			// GL_MEDIUM_FLOAT = 0x8DF1
			MediumFloat = unchecked((int)36337),
			// GL_HIGH_FLOAT = 0x8DF2
			HighFloat = unchecked((int)36338),
			// GL_LOW_INT = 0x8DF3
			LowInt = unchecked((int)36339),
			// GL_MEDIUM_INT = 0x8DF4
			MediumInt = unchecked((int)36340),
			// GL_HIGH_INT = 0x8DF5
			HighInt = unchecked((int)36341),
			// GL_SHADER_BINARY_FORMATS = 0x8DF8
			ShaderBinaryFormats = unchecked((int)36344),
			// GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
			NumShaderBinaryFormats = unchecked((int)36345),
			// GL_SHADER_COMPILER = 0x8DFA
			ShaderCompiler = unchecked((int)36346),
			// GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
			MaxVertexUniformVectors = unchecked((int)36347),
			// GL_MAX_VARYING_VECTORS = 0x8DFC
			MaxVaryingVectors = unchecked((int)36348),
			// GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
			MaxFragmentUniformVectors = unchecked((int)36349),
			// GL_QUERY_WAIT = 0x8E13
			QueryWait = unchecked((int)36371),
			// GL_QUERY_NO_WAIT = 0x8E14
			QueryNoWait = unchecked((int)36372),
			// GL_QUERY_BY_REGION_WAIT = 0x8E15
			QueryByRegionWait = unchecked((int)36373),
			// GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
			QueryByRegionNoWait = unchecked((int)36374),
			// GL_QUERY_WAIT_INVERTED = 0x8E17
			QueryWaitInverted = unchecked((int)36375),
			// GL_QUERY_NO_WAIT_INVERTED = 0x8E18
			QueryNoWaitInverted = unchecked((int)36376),
			// GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19
			QueryByRegionWaitInverted = unchecked((int)36377),
			// GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A
			QueryByRegionNoWaitInverted = unchecked((int)36378),
			// GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E
			MaxCombinedTessControlUniformComponents = unchecked((int)36382),
			// GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F
			MaxCombinedTessEvaluationUniformComponents = unchecked((int)36383),
			// GL_TRANSFORM_FEEDBACK = 0x8E22
			TransformFeedback = unchecked((int)36386),
			// GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23
			TransformFeedbackBufferPaused = unchecked((int)36387),
			// GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
			TransformFeedbackPaused = unchecked((int)36387),
			// GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
			TransformFeedbackActive = unchecked((int)36388),
			// GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24
			TransformFeedbackBufferActive = unchecked((int)36388),
			// GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
			TransformFeedbackBinding = unchecked((int)36389),
			// GL_TIMESTAMP = 0x8E28
			Timestamp = unchecked((int)36392),
			// GL_TEXTURE_SWIZZLE_R = 0x8E42
			TextureSwizzleR = unchecked((int)36418),
			// GL_TEXTURE_SWIZZLE_G = 0x8E43
			TextureSwizzleG = unchecked((int)36419),
			// GL_TEXTURE_SWIZZLE_B = 0x8E44
			TextureSwizzleB = unchecked((int)36420),
			// GL_TEXTURE_SWIZZLE_A = 0x8E45
			TextureSwizzleA = unchecked((int)36421),
			// GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
			TextureSwizzleRgba = unchecked((int)36422),
			// GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
			ActiveSubroutineUniformLocations = unchecked((int)36423),
			// GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
			ActiveSubroutineMaxLength = unchecked((int)36424),
			// GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
			ActiveSubroutineUniformMaxLength = unchecked((int)36425),
			// GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
			NumCompatibleSubroutines = unchecked((int)36426),
			// GL_COMPATIBLE_SUBROUTINES = 0x8E4B
			CompatibleSubroutines = unchecked((int)36427),
			// GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C
			QuadsFollowProvokingVertexConvention = unchecked((int)36428),
			// GL_FIRST_VERTEX_CONVENTION = 0x8E4D
			FirstVertexConvention = unchecked((int)36429),
			// GL_LAST_VERTEX_CONVENTION = 0x8E4E
			LastVertexConvention = unchecked((int)36430),
			// GL_PROVOKING_VERTEX = 0x8E4F
			ProvokingVertex = unchecked((int)36431),
			// GL_SAMPLE_POSITION = 0x8E50
			SamplePosition = unchecked((int)36432),
			// GL_SAMPLE_MASK = 0x8E51
			SampleMask = unchecked((int)36433),
			// GL_SAMPLE_MASK_VALUE = 0x8E52
			SampleMaskValue = unchecked((int)36434),
			// GL_MAX_SAMPLE_MASK_WORDS = 0x8E59
			MaxSampleMaskWords = unchecked((int)36441),
			// GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A
			MaxGeometryShaderInvocations = unchecked((int)36442),
			// GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B
			MinFragmentInterpolationOffset = unchecked((int)36443),
			// GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C
			MaxFragmentInterpolationOffset = unchecked((int)36444),
			// GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D
			FragmentInterpolationOffsetBits = unchecked((int)36445),
			// GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E
			MinProgramTextureGatherOffset = unchecked((int)36446),
			// GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F
			MaxProgramTextureGatherOffset = unchecked((int)36447),
			// GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70
			MaxTransformFeedbackBuffers = unchecked((int)36464),
			// GL_MAX_VERTEX_STREAMS = 0x8E71
			MaxVertexStreams = unchecked((int)36465),
			// GL_PATCH_VERTICES = 0x8E72
			PatchVertices = unchecked((int)36466),
			// GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
			PatchDefaultInnerLevel = unchecked((int)36467),
			// GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
			PatchDefaultOuterLevel = unchecked((int)36468),
			// GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75
			TessControlOutputVertices = unchecked((int)36469),
			// GL_TESS_GEN_MODE = 0x8E76
			TessGenMode = unchecked((int)36470),
			// GL_TESS_GEN_SPACING = 0x8E77
			TessGenSpacing = unchecked((int)36471),
			// GL_TESS_GEN_VERTEX_ORDER = 0x8E78
			TessGenVertexOrder = unchecked((int)36472),
			// GL_TESS_GEN_POINT_MODE = 0x8E79
			TessGenPointMode = unchecked((int)36473),
			// GL_ISOLINES = 0x8E7A
			Isolines = unchecked((int)36474),
			// GL_FRACTIONAL_ODD = 0x8E7B
			FractionalOdd = unchecked((int)36475),
			// GL_FRACTIONAL_EVEN = 0x8E7C
			FractionalEven = unchecked((int)36476),
			// GL_MAX_PATCH_VERTICES = 0x8E7D
			MaxPatchVertices = unchecked((int)36477),
			// GL_MAX_TESS_GEN_LEVEL = 0x8E7E
			MaxTessGenLevel = unchecked((int)36478),
			// GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F
			MaxTessControlUniformComponents = unchecked((int)36479),
			// GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80
			MaxTessEvaluationUniformComponents = unchecked((int)36480),
			// GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81
			MaxTessControlTextureImageUnits = unchecked((int)36481),
			// GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82
			MaxTessEvaluationTextureImageUnits = unchecked((int)36482),
			// GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83
			MaxTessControlOutputComponents = unchecked((int)36483),
			// GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84
			MaxTessPatchComponents = unchecked((int)36484),
			// GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85
			MaxTessControlTotalOutputComponents = unchecked((int)36485),
			// GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86
			MaxTessEvaluationOutputComponents = unchecked((int)36486),
			// GL_TESS_EVALUATION_SHADER = 0x8E87
			TessEvaluationShader = unchecked((int)36487),
			// GL_TESS_CONTROL_SHADER = 0x8E88
			TessControlShader = unchecked((int)36488),
			// GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89
			MaxTessControlUniformBlocks = unchecked((int)36489),
			// GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A
			MaxTessEvaluationUniformBlocks = unchecked((int)36490),
			// GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
			CompressedRgbaBptcUnorm = unchecked((int)36492),
			// GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
			CompressedSrgbAlphaBptcUnorm = unchecked((int)36493),
			// GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
			CompressedRgbBptcSignedFloat = unchecked((int)36494),
			// GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
			CompressedRgbBptcUnsignedFloat = unchecked((int)36495),
			// GL_COPY_READ_BUFFER = 0x8F36
			CopyReadBuffer = unchecked((int)36662),
			// GL_COPY_READ_BUFFER_BINDING = 0x8F36
			CopyReadBufferBinding = unchecked((int)36662),
			// GL_COPY_WRITE_BUFFER = 0x8F37
			CopyWriteBuffer = unchecked((int)36663),
			// GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
			CopyWriteBufferBinding = unchecked((int)36663),
			// GL_MAX_IMAGE_UNITS = 0x8F38
			MaxImageUnits = unchecked((int)36664),
			// GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39
			MaxCombinedImageUnitsAndFragmentOutputs = unchecked((int)36665),
			// GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39
			MaxCombinedShaderOutputResources = unchecked((int)36665),
			// GL_IMAGE_BINDING_NAME = 0x8F3A
			ImageBindingName = unchecked((int)36666),
			// GL_IMAGE_BINDING_LEVEL = 0x8F3B
			ImageBindingLevel = unchecked((int)36667),
			// GL_IMAGE_BINDING_LAYERED = 0x8F3C
			ImageBindingLayered = unchecked((int)36668),
			// GL_IMAGE_BINDING_LAYER = 0x8F3D
			ImageBindingLayer = unchecked((int)36669),
			// GL_IMAGE_BINDING_ACCESS = 0x8F3E
			ImageBindingAccess = unchecked((int)36670),
			// GL_DRAW_INDIRECT_BUFFER = 0x8F3F
			DrawIndirectBuffer = unchecked((int)36671),
			// GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43
			DrawIndirectBufferBinding = unchecked((int)36675),
			// GL_DOUBLE_MAT2 = 0x8F46
			DoubleMat2 = unchecked((int)36678),
			// GL_DOUBLE_MAT3 = 0x8F47
			DoubleMat3 = unchecked((int)36679),
			// GL_DOUBLE_MAT4 = 0x8F48
			DoubleMat4 = unchecked((int)36680),
			// GL_DOUBLE_MAT2x3 = 0x8F49
			DoubleMat2x3 = unchecked((int)36681),
			// GL_DOUBLE_MAT2x4 = 0x8F4A
			DoubleMat2x4 = unchecked((int)36682),
			// GL_DOUBLE_MAT3x2 = 0x8F4B
			DoubleMat3x2 = unchecked((int)36683),
			// GL_DOUBLE_MAT3x4 = 0x8F4C
			DoubleMat3x4 = unchecked((int)36684),
			// GL_DOUBLE_MAT4x2 = 0x8F4D
			DoubleMat4x2 = unchecked((int)36685),
			// GL_DOUBLE_MAT4x3 = 0x8F4E
			DoubleMat4x3 = unchecked((int)36686),
			// GL_VERTEX_BINDING_BUFFER = 0x8F4F
			VertexBindingBuffer = unchecked((int)36687),
			// GL_R8_SNORM = 0x8F94
			R8Snorm = unchecked((int)36756),
			// GL_RG8_SNORM = 0x8F95
			Rg8Snorm = unchecked((int)36757),
			// GL_RGB8_SNORM = 0x8F96
			Rgb8Snorm = unchecked((int)36758),
			// GL_RGBA8_SNORM = 0x8F97
			Rgba8Snorm = unchecked((int)36759),
			// GL_R16_SNORM = 0x8F98
			R16Snorm = unchecked((int)36760),
			// GL_RG16_SNORM = 0x8F99
			Rg16Snorm = unchecked((int)36761),
			// GL_RGB16_SNORM = 0x8F9A
			Rgb16Snorm = unchecked((int)36762),
			// GL_RGBA16_SNORM = 0x8F9B
			Rgba16Snorm = unchecked((int)36763),
			// GL_SIGNED_NORMALIZED = 0x8F9C
			SignedNormalized = unchecked((int)36764),
			// GL_PRIMITIVE_RESTART = 0x8F9D
			PrimitiveRestart = unchecked((int)36765),
			// GL_PRIMITIVE_RESTART_INDEX = 0x8F9E
			PrimitiveRestartIndex = unchecked((int)36766),
			// GL_DOUBLE_VEC2 = 0x8FFC
			DoubleVec2 = unchecked((int)36860),
			// GL_DOUBLE_VEC3 = 0x8FFD
			DoubleVec3 = unchecked((int)36861),
			// GL_DOUBLE_VEC4 = 0x8FFE
			DoubleVec4 = unchecked((int)36862),
			// GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
			TextureCubeMapArray = unchecked((int)36873),
			// GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
			TextureBindingCubeMapArray = unchecked((int)36874),
			// GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
			ProxyTextureCubeMapArray = unchecked((int)36875),
			// GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
			SamplerCubeMapArray = unchecked((int)36876),
			// GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
			SamplerCubeMapArrayShadow = unchecked((int)36877),
			// GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
			IntSamplerCubeMapArray = unchecked((int)36878),
			// GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
			UnsignedIntSamplerCubeMapArray = unchecked((int)36879),
			// GL_IMAGE_1D = 0x904C
			Image1d = unchecked((int)36940),
			// GL_IMAGE_2D = 0x904D
			Image2d = unchecked((int)36941),
			// GL_IMAGE_3D = 0x904E
			Image3d = unchecked((int)36942),
			// GL_IMAGE_2D_RECT = 0x904F
			Image2dRect = unchecked((int)36943),
			// GL_IMAGE_CUBE = 0x9050
			ImageCube = unchecked((int)36944),
			// GL_IMAGE_BUFFER = 0x9051
			ImageBuffer = unchecked((int)36945),
			// GL_IMAGE_1D_ARRAY = 0x9052
			Image1dArray = unchecked((int)36946),
			// GL_IMAGE_2D_ARRAY = 0x9053
			Image2dArray = unchecked((int)36947),
			// GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
			ImageCubeMapArray = unchecked((int)36948),
			// GL_IMAGE_2D_MULTISAMPLE = 0x9055
			Image2dMultisample = unchecked((int)36949),
			// GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056
			Image2dMultisampleArray = unchecked((int)36950),
			// GL_INT_IMAGE_1D = 0x9057
			IntImage1d = unchecked((int)36951),
			// GL_INT_IMAGE_2D = 0x9058
			IntImage2d = unchecked((int)36952),
			// GL_INT_IMAGE_3D = 0x9059
			IntImage3d = unchecked((int)36953),
			// GL_INT_IMAGE_2D_RECT = 0x905A
			IntImage2dRect = unchecked((int)36954),
			// GL_INT_IMAGE_CUBE = 0x905B
			IntImageCube = unchecked((int)36955),
			// GL_INT_IMAGE_BUFFER = 0x905C
			IntImageBuffer = unchecked((int)36956),
			// GL_INT_IMAGE_1D_ARRAY = 0x905D
			IntImage1dArray = unchecked((int)36957),
			// GL_INT_IMAGE_2D_ARRAY = 0x905E
			IntImage2dArray = unchecked((int)36958),
			// GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
			IntImageCubeMapArray = unchecked((int)36959),
			// GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060
			IntImage2dMultisample = unchecked((int)36960),
			// GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061
			IntImage2dMultisampleArray = unchecked((int)36961),
			// GL_UNSIGNED_INT_IMAGE_1D = 0x9062
			UnsignedIntImage1d = unchecked((int)36962),
			// GL_UNSIGNED_INT_IMAGE_2D = 0x9063
			UnsignedIntImage2d = unchecked((int)36963),
			// GL_UNSIGNED_INT_IMAGE_3D = 0x9064
			UnsignedIntImage3d = unchecked((int)36964),
			// GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065
			UnsignedIntImage2dRect = unchecked((int)36965),
			// GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
			UnsignedIntImageCube = unchecked((int)36966),
			// GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067
			UnsignedIntImageBuffer = unchecked((int)36967),
			// GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068
			UnsignedIntImage1dArray = unchecked((int)36968),
			// GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
			UnsignedIntImage2dArray = unchecked((int)36969),
			// GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
			UnsignedIntImageCubeMapArray = unchecked((int)36970),
			// GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B
			UnsignedIntImage2dMultisample = unchecked((int)36971),
			// GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C
			UnsignedIntImage2dMultisampleArray = unchecked((int)36972),
			// GL_MAX_IMAGE_SAMPLES = 0x906D
			MaxImageSamples = unchecked((int)36973),
			// GL_IMAGE_BINDING_FORMAT = 0x906E
			ImageBindingFormat = unchecked((int)36974),
			// GL_RGB10_A2UI = 0x906F
			Rgb10A2ui = unchecked((int)36975),
			// GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC
			MinMapBufferAlignment = unchecked((int)37052),
			// GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
			ImageFormatCompatibilityType = unchecked((int)37063),
			// GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8
			ImageFormatCompatibilityBySize = unchecked((int)37064),
			// GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9
			ImageFormatCompatibilityByClass = unchecked((int)37065),
			// GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA
			MaxVertexImageUniforms = unchecked((int)37066),
			// GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB
			MaxTessControlImageUniforms = unchecked((int)37067),
			// GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC
			MaxTessEvaluationImageUniforms = unchecked((int)37068),
			// GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD
			MaxGeometryImageUniforms = unchecked((int)37069),
			// GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE
			MaxFragmentImageUniforms = unchecked((int)37070),
			// GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF
			MaxCombinedImageUniforms = unchecked((int)37071),
			// GL_SHADER_STORAGE_BUFFER = 0x90D2
			ShaderStorageBuffer = unchecked((int)37074),
			// GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3
			ShaderStorageBufferBinding = unchecked((int)37075),
			// GL_SHADER_STORAGE_BUFFER_START = 0x90D4
			ShaderStorageBufferStart = unchecked((int)37076),
			// GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5
			ShaderStorageBufferSize = unchecked((int)37077),
			// GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6
			MaxVertexShaderStorageBlocks = unchecked((int)37078),
			// GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7
			MaxGeometryShaderStorageBlocks = unchecked((int)37079),
			// GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8
			MaxTessControlShaderStorageBlocks = unchecked((int)37080),
			// GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9
			MaxTessEvaluationShaderStorageBlocks = unchecked((int)37081),
			// GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA
			MaxFragmentShaderStorageBlocks = unchecked((int)37082),
			// GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB
			MaxComputeShaderStorageBlocks = unchecked((int)37083),
			// GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC
			MaxCombinedShaderStorageBlocks = unchecked((int)37084),
			// GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD
			MaxShaderStorageBufferBindings = unchecked((int)37085),
			// GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE
			MaxShaderStorageBlockSize = unchecked((int)37086),
			// GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF
			ShaderStorageBufferOffsetAlignment = unchecked((int)37087),
			// GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
			DepthStencilTextureMode = unchecked((int)37098),
			// GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB
			MaxComputeWorkGroupInvocations = unchecked((int)37099),
			// GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
			UniformBlockReferencedByComputeShader = unchecked((int)37100),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
			AtomicCounterBufferReferencedByComputeShader = unchecked((int)37101),
			// GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
			DispatchIndirectBuffer = unchecked((int)37102),
			// GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF
			DispatchIndirectBufferBinding = unchecked((int)37103),
			// GL_TEXTURE_2D_MULTISAMPLE = 0x9100
			Texture2dMultisample = unchecked((int)37120),
			// GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
			ProxyTexture2dMultisample = unchecked((int)37121),
			// GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
			Texture2dMultisampleArray = unchecked((int)37122),
			// GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
			ProxyTexture2dMultisampleArray = unchecked((int)37123),
			// GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104
			TextureBinding2dMultisample = unchecked((int)37124),
			// GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105
			TextureBinding2dMultisampleArray = unchecked((int)37125),
			// GL_TEXTURE_SAMPLES = 0x9106
			TextureSamples = unchecked((int)37126),
			// GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107
			TextureFixedSampleLocations = unchecked((int)37127),
			// GL_SAMPLER_2D_MULTISAMPLE = 0x9108
			Sampler2dMultisample = unchecked((int)37128),
			// GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109
			IntSampler2dMultisample = unchecked((int)37129),
			// GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A
			UnsignedIntSampler2dMultisample = unchecked((int)37130),
			// GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B
			Sampler2dMultisampleArray = unchecked((int)37131),
			// GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C
			IntSampler2dMultisampleArray = unchecked((int)37132),
			// GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D
			UnsignedIntSampler2dMultisampleArray = unchecked((int)37133),
			// GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E
			MaxColorTextureSamples = unchecked((int)37134),
			// GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F
			MaxDepthTextureSamples = unchecked((int)37135),
			// GL_MAX_INTEGER_SAMPLES = 0x9110
			MaxIntegerSamples = unchecked((int)37136),
			// GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
			MaxServerWaitTimeout = unchecked((int)37137),
			// GL_OBJECT_TYPE = 0x9112
			ObjectType = unchecked((int)37138),
			// GL_SYNC_CONDITION = 0x9113
			SyncCondition = unchecked((int)37139),
			// GL_SYNC_STATUS = 0x9114
			SyncStatus = unchecked((int)37140),
			// GL_SYNC_FLAGS = 0x9115
			SyncFlags = unchecked((int)37141),
			// GL_SYNC_FENCE = 0x9116
			SyncFence = unchecked((int)37142),
			// GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
			SyncGpuCommandsComplete = unchecked((int)37143),
			// GL_UNSIGNALED = 0x9118
			Unsignaled = unchecked((int)37144),
			// GL_SIGNALED = 0x9119
			Signaled = unchecked((int)37145),
			// GL_ALREADY_SIGNALED = 0x911A
			AlreadySignaled = unchecked((int)37146),
			// GL_TIMEOUT_EXPIRED = 0x911B
			TimeoutExpired = unchecked((int)37147),
			// GL_CONDITION_SATISFIED = 0x911C
			ConditionSatisfied = unchecked((int)37148),
			// GL_WAIT_FAILED = 0x911D
			WaitFailed = unchecked((int)37149),
			// GL_BUFFER_ACCESS_FLAGS = 0x911F
			BufferAccessFlags = unchecked((int)37151),
			// GL_BUFFER_MAP_LENGTH = 0x9120
			BufferMapLength = unchecked((int)37152),
			// GL_BUFFER_MAP_OFFSET = 0x9121
			BufferMapOffset = unchecked((int)37153),
			// GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
			MaxVertexOutputComponents = unchecked((int)37154),
			// GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123
			MaxGeometryInputComponents = unchecked((int)37155),
			// GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124
			MaxGeometryOutputComponents = unchecked((int)37156),
			// GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
			MaxFragmentInputComponents = unchecked((int)37157),
			// GL_CONTEXT_PROFILE_MASK = 0x9126
			ContextProfileMask = unchecked((int)37158),
			// GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127
			UnpackCompressedBlockWidth = unchecked((int)37159),
			// GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128
			UnpackCompressedBlockHeight = unchecked((int)37160),
			// GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129
			UnpackCompressedBlockDepth = unchecked((int)37161),
			// GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A
			UnpackCompressedBlockSize = unchecked((int)37162),
			// GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B
			PackCompressedBlockWidth = unchecked((int)37163),
			// GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C
			PackCompressedBlockHeight = unchecked((int)37164),
			// GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D
			PackCompressedBlockDepth = unchecked((int)37165),
			// GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E
			PackCompressedBlockSize = unchecked((int)37166),
			// GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
			TextureImmutableFormat = unchecked((int)37167),
			// GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
			MaxDebugMessageLength = unchecked((int)37187),
			// GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
			MaxDebugLoggedMessages = unchecked((int)37188),
			// GL_DEBUG_LOGGED_MESSAGES = 0x9145
			DebugLoggedMessages = unchecked((int)37189),
			// GL_DEBUG_SEVERITY_HIGH = 0x9146
			DebugSeverityHigh = unchecked((int)37190),
			// GL_DEBUG_SEVERITY_MEDIUM = 0x9147
			DebugSeverityMedium = unchecked((int)37191),
			// GL_DEBUG_SEVERITY_LOW = 0x9148
			DebugSeverityLow = unchecked((int)37192),
			// GL_QUERY_BUFFER = 0x9192
			QueryBuffer = unchecked((int)37266),
			// GL_QUERY_BUFFER_BINDING = 0x9193
			QueryBufferBinding = unchecked((int)37267),
			// GL_QUERY_RESULT_NO_WAIT = 0x9194
			QueryResultNoWait = unchecked((int)37268),
			// GL_TEXTURE_BUFFER_OFFSET = 0x919D
			TextureBufferOffset = unchecked((int)37277),
			// GL_TEXTURE_BUFFER_SIZE = 0x919E
			TextureBufferSize = unchecked((int)37278),
			// GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F
			TextureBufferOffsetAlignment = unchecked((int)37279),
			// GL_COMPUTE_SHADER = 0x91B9
			ComputeShader = unchecked((int)37305),
			// GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB
			MaxComputeUniformBlocks = unchecked((int)37307),
			// GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC
			MaxComputeTextureImageUnits = unchecked((int)37308),
			// GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD
			MaxComputeImageUniforms = unchecked((int)37309),
			// GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE
			MaxComputeWorkGroupCount = unchecked((int)37310),
			// GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
			MaxComputeWorkGroupSize = unchecked((int)37311),
			// GL_COMPRESSED_R11_EAC = 0x9270
			CompressedR11Eac = unchecked((int)37488),
			// GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
			CompressedSignedR11Eac = unchecked((int)37489),
			// GL_COMPRESSED_RG11_EAC = 0x9272
			CompressedRg11Eac = unchecked((int)37490),
			// GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
			CompressedSignedRg11Eac = unchecked((int)37491),
			// GL_COMPRESSED_RGB8_ETC2 = 0x9274
			CompressedRgb8Etc2 = unchecked((int)37492),
			// GL_COMPRESSED_SRGB8_ETC2 = 0x9275
			CompressedSrgb8Etc2 = unchecked((int)37493),
			// GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
			CompressedRgb8PunchthroughAlpha1Etc2 = unchecked((int)37494),
			// GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
			CompressedSrgb8PunchthroughAlpha1Etc2 = unchecked((int)37495),
			// GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
			CompressedRgba8Etc2Eac = unchecked((int)37496),
			// GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
			CompressedSrgb8Alpha8Etc2Eac = unchecked((int)37497),
			// GL_ATOMIC_COUNTER_BUFFER = 0x92C0
			AtomicCounterBuffer = unchecked((int)37568),
			// GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
			AtomicCounterBufferBinding = unchecked((int)37569),
			// GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2
			AtomicCounterBufferStart = unchecked((int)37570),
			// GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3
			AtomicCounterBufferSize = unchecked((int)37571),
			// GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
			AtomicCounterBufferDataSize = unchecked((int)37572),
			// GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
			AtomicCounterBufferActiveAtomicCounters = unchecked((int)37573),
			// GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
			AtomicCounterBufferActiveAtomicCounterIndices = unchecked((int)37574),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
			AtomicCounterBufferReferencedByVertexShader = unchecked((int)37575),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
			AtomicCounterBufferReferencedByTessControlShader = unchecked((int)37576),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9
			AtomicCounterBufferReferencedByTessEvaluationShader = unchecked((int)37577),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
			AtomicCounterBufferReferencedByGeometryShader = unchecked((int)37578),
			// GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
			AtomicCounterBufferReferencedByFragmentShader = unchecked((int)37579),
			// GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC
			MaxVertexAtomicCounterBuffers = unchecked((int)37580),
			// GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD
			MaxTessControlAtomicCounterBuffers = unchecked((int)37581),
			// GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE
			MaxTessEvaluationAtomicCounterBuffers = unchecked((int)37582),
			// GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF
			MaxGeometryAtomicCounterBuffers = unchecked((int)37583),
			// GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0
			MaxFragmentAtomicCounterBuffers = unchecked((int)37584),
			// GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1
			MaxCombinedAtomicCounterBuffers = unchecked((int)37585),
			// GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2
			MaxVertexAtomicCounters = unchecked((int)37586),
			// GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3
			MaxTessControlAtomicCounters = unchecked((int)37587),
			// GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4
			MaxTessEvaluationAtomicCounters = unchecked((int)37588),
			// GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5
			MaxGeometryAtomicCounters = unchecked((int)37589),
			// GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6
			MaxFragmentAtomicCounters = unchecked((int)37590),
			// GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7
			MaxCombinedAtomicCounters = unchecked((int)37591),
			// GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8
			MaxAtomicCounterBufferSize = unchecked((int)37592),
			// GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
			ActiveAtomicCounterBuffers = unchecked((int)37593),
			// GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
			UniformAtomicCounterBufferIndex = unchecked((int)37594),
			// GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
			UnsignedIntAtomicCounter = unchecked((int)37595),
			// GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC
			MaxAtomicCounterBufferBindings = unchecked((int)37596),
			// GL_DEBUG_OUTPUT = 0x92E0
			DebugOutput = unchecked((int)37600),
			// GL_UNIFORM = 0x92E1
			Uniform = unchecked((int)37601),
			// GL_UNIFORM_BLOCK = 0x92E2
			UniformBlock = unchecked((int)37602),
			// GL_PROGRAM_INPUT = 0x92E3
			ProgramInput = unchecked((int)37603),
			// GL_PROGRAM_OUTPUT = 0x92E4
			ProgramOutput = unchecked((int)37604),
			// GL_BUFFER_VARIABLE = 0x92E5
			BufferVariable = unchecked((int)37605),
			// GL_SHADER_STORAGE_BLOCK = 0x92E6
			ShaderStorageBlock = unchecked((int)37606),
			// GL_IS_PER_PATCH = 0x92E7
			IsPerPatch = unchecked((int)37607),
			// GL_VERTEX_SUBROUTINE = 0x92E8
			VertexSubroutine = unchecked((int)37608),
			// GL_TESS_CONTROL_SUBROUTINE = 0x92E9
			TessControlSubroutine = unchecked((int)37609),
			// GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
			TessEvaluationSubroutine = unchecked((int)37610),
			// GL_GEOMETRY_SUBROUTINE = 0x92EB
			GeometrySubroutine = unchecked((int)37611),
			// GL_FRAGMENT_SUBROUTINE = 0x92EC
			FragmentSubroutine = unchecked((int)37612),
			// GL_COMPUTE_SUBROUTINE = 0x92ED
			ComputeSubroutine = unchecked((int)37613),
			// GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
			VertexSubroutineUniform = unchecked((int)37614),
			// GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
			TessControlSubroutineUniform = unchecked((int)37615),
			// GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
			TessEvaluationSubroutineUniform = unchecked((int)37616),
			// GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
			GeometrySubroutineUniform = unchecked((int)37617),
			// GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
			FragmentSubroutineUniform = unchecked((int)37618),
			// GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
			ComputeSubroutineUniform = unchecked((int)37619),
			// GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
			TransformFeedbackVarying = unchecked((int)37620),
			// GL_ACTIVE_RESOURCES = 0x92F5
			ActiveResources = unchecked((int)37621),
			// GL_MAX_NAME_LENGTH = 0x92F6
			MaxNameLength = unchecked((int)37622),
			// GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
			MaxNumActiveVariables = unchecked((int)37623),
			// GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
			MaxNumCompatibleSubroutines = unchecked((int)37624),
			// GL_NAME_LENGTH = 0x92F9
			NameLength = unchecked((int)37625),
			// GL_TYPE = 0x92FA
			Type = unchecked((int)37626),
			// GL_ARRAY_SIZE = 0x92FB
			ArraySize = unchecked((int)37627),
			// GL_OFFSET = 0x92FC
			Offset = unchecked((int)37628),
			// GL_BLOCK_INDEX = 0x92FD
			BlockIndex = unchecked((int)37629),
			// GL_ARRAY_STRIDE = 0x92FE
			ArrayStride = unchecked((int)37630),
			// GL_MATRIX_STRIDE = 0x92FF
			MatrixStride = unchecked((int)37631),
			// GL_IS_ROW_MAJOR = 0x9300
			IsRowMajor = unchecked((int)37632),
			// GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301
			AtomicCounterBufferIndex = unchecked((int)37633),
			// GL_BUFFER_BINDING = 0x9302
			BufferBinding = unchecked((int)37634),
			// GL_BUFFER_DATA_SIZE = 0x9303
			BufferDataSize = unchecked((int)37635),
			// GL_NUM_ACTIVE_VARIABLES = 0x9304
			NumActiveVariables = unchecked((int)37636),
			// GL_ACTIVE_VARIABLES = 0x9305
			ActiveVariables = unchecked((int)37637),
			// GL_REFERENCED_BY_VERTEX_SHADER = 0x9306
			ReferencedByVertexShader = unchecked((int)37638),
			// GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307
			ReferencedByTessControlShader = unchecked((int)37639),
			// GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308
			ReferencedByTessEvaluationShader = unchecked((int)37640),
			// GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309
			ReferencedByGeometryShader = unchecked((int)37641),
			// GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A
			ReferencedByFragmentShader = unchecked((int)37642),
			// GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B
			ReferencedByComputeShader = unchecked((int)37643),
			// GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
			TopLevelArraySize = unchecked((int)37644),
			// GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
			TopLevelArrayStride = unchecked((int)37645),
			// GL_LOCATION = 0x930E
			Location = unchecked((int)37646),
			// GL_LOCATION_INDEX = 0x930F
			LocationIndex = unchecked((int)37647),
			// GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
			FramebufferDefaultWidth = unchecked((int)37648),
			// GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
			FramebufferDefaultHeight = unchecked((int)37649),
			// GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
			FramebufferDefaultLayers = unchecked((int)37650),
			// GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
			FramebufferDefaultSamples = unchecked((int)37651),
			// GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
			FramebufferDefaultFixedSampleLocations = unchecked((int)37652),
			// GL_MAX_FRAMEBUFFER_WIDTH = 0x9315
			MaxFramebufferWidth = unchecked((int)37653),
			// GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316
			MaxFramebufferHeight = unchecked((int)37654),
			// GL_MAX_FRAMEBUFFER_LAYERS = 0x9317
			MaxFramebufferLayers = unchecked((int)37655),
			// GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318
			MaxFramebufferSamples = unchecked((int)37656),
			// GL_LOCATION_COMPONENT = 0x934A
			LocationComponent = unchecked((int)37706),
			// GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B
			TransformFeedbackBufferIndex = unchecked((int)37707),
			// GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C
			TransformFeedbackBufferStride = unchecked((int)37708),
			// GL_CLIP_ORIGIN = 0x935C
			ClipOrigin = unchecked((int)37724),
			// GL_CLIP_DEPTH_MODE = 0x935D
			ClipDepthMode = unchecked((int)37725),
			// GL_NEGATIVE_ONE_TO_ONE = 0x935E
			NegativeOneToOne = unchecked((int)37726),
			// GL_ZERO_TO_ONE = 0x935F
			ZeroToOne = unchecked((int)37727),
			// GL_CLEAR_TEXTURE = 0x9365
			ClearTexture = unchecked((int)37733),
			// GL_NUM_SAMPLE_COUNTS = 0x9380
			NumSampleCounts = unchecked((int)37760),
			// GL_ALL_BARRIER_BITS = 0xFFFFFFFF
			AllBarrierBits = unchecked((int)4294967295),
			// GL_ALL_SHADER_BITS = 0xFFFFFFFF
			AllShaderBits = unchecked((int)4294967295),
			// GL_INVALID_INDEX = 0xFFFFFFFF
			InvalidIndex = unchecked((int)4294967295),
		}
		#region command delegates
		// void glActiveShaderProgram (GLuint pipeline, GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ActiveShaderProgramDelegate (System.UInt32 pipeline, System.UInt32 program);
		// void glActiveTexture (GLenum texture)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ActiveTextureDelegate (System.UInt32 texture);
		// void glAttachShader (GLuint program, GLuint shader)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void AttachShaderDelegate (System.UInt32 program, System.UInt32 shader);
		// void glBeginConditionalRender (GLuint id, GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BeginConditionalRenderDelegate (System.UInt32 id, System.UInt32 mode);
		// void glBeginQuery (GLenum target, GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BeginQueryDelegate (System.UInt32 target, System.UInt32 id);
		// void glBeginQueryIndexed (GLenum target, GLuint index, GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BeginQueryIndexedDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 id);
		// void glBeginTransformFeedback (GLenum primitiveMode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BeginTransformFeedbackDelegate (System.UInt32 primitiveMode);
		// void glBindAttribLocation (GLuint program, GLuint index, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindAttribLocationDelegate (System.UInt32 program, System.UInt32 index, StringPtr name);
		// void glBindBufferBase (GLenum target, GLuint index, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindBufferBaseDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer);
		// void glBindBuffer (GLenum target, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindBufferDelegate (System.UInt32 target, System.UInt32 buffer);
		// void glBindBufferRange (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindBufferRangeDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
		// void glBindBuffersBase (GLenum target, GLuint first, GLsizei count, GLuint* buffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindBuffersBaseDelegate (System.UInt32 target, System.UInt32 first, System.Int32 count, IntPtr buffers);
		// void glBindBuffersRange (GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindBuffersRangeDelegate (System.UInt32 target, System.UInt32 first, System.Int32 count, IntPtr buffers, IntPtr offsets, IntPtr sizes);
		// void glBindFragDataLocation (GLuint program, GLuint color, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindFragDataLocationDelegate (System.UInt32 program, System.UInt32 color, IntPtr name);
		// void glBindFragDataLocationIndexed (GLuint program, GLuint colorNumber, GLuint index, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindFragDataLocationIndexedDelegate (System.UInt32 program, System.UInt32 colorNumber, System.UInt32 index, IntPtr name);
		// void glBindFramebuffer (GLenum target, GLuint framebuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindFramebufferDelegate (System.UInt32 target, System.UInt32 framebuffer);
		// void glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindImageTextureDelegate (System.UInt32 unit, System.UInt32 texture, System.Int32 level, Boolean layered, System.Int32 layer, System.UInt32 access, System.UInt32 format);
		// void glBindImageTextures (GLuint first, GLsizei count, GLuint* textures)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindImageTexturesDelegate (System.UInt32 first, System.Int32 count, IntPtr textures);
		// void glBindProgramPipeline (GLuint pipeline)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindProgramPipelineDelegate (System.UInt32 pipeline);
		// void glBindRenderbuffer (GLenum target, GLuint renderbuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindRenderbufferDelegate (System.UInt32 target, System.UInt32 renderbuffer);
		// void glBindSampler (GLuint unit, GLuint sampler)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindSamplerDelegate (System.UInt32 unit, System.UInt32 sampler);
		// void glBindSamplers (GLuint first, GLsizei count, GLuint* samplers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindSamplersDelegate (System.UInt32 first, System.Int32 count, IntPtr samplers);
		// void glBindTexture (GLenum target, GLuint texture)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindTextureDelegate (TextureTarget target, System.UInt32 texture);
		// void glBindTextures (GLuint first, GLsizei count, GLuint* textures)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindTexturesDelegate (System.UInt32 first, System.Int32 count, IntPtr textures);
		// void glBindTextureUnit (GLuint unit, GLuint texture)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindTextureUnitDelegate (System.UInt32 unit, System.UInt32 texture);
		// void glBindTransformFeedback (GLenum target, GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindTransformFeedbackDelegate (System.UInt32 target, System.UInt32 id);
		// void glBindVertexArray (GLuint array)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindVertexArrayDelegate (System.UInt32 array);
		// void glBindVertexBuffer (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindVertexBufferDelegate (System.UInt32 bindingindex, System.UInt32 buffer, System.IntPtr offset, System.Int32 stride);
		// void glBindVertexBuffers (GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BindVertexBuffersDelegate (System.UInt32 first, System.Int32 count, IntPtr buffers, IntPtr offsets, IntPtr strides);
		// void glBlendColor (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendColorDelegate (System.Single red, System.Single green, System.Single blue, System.Single alpha);
		// void glBlendEquation (GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendEquationDelegate (System.UInt32 mode);
		// void glBlendEquationi (GLuint buf, GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendEquationiDelegate (System.UInt32 buf, System.UInt32 mode);
		// void glBlendEquationSeparate (GLenum modeRGB, GLenum modeAlpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendEquationSeparateDelegate (BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
		// void glBlendEquationSeparatei (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendEquationSeparateiDelegate (System.UInt32 buf, System.UInt32 modeRGB, System.UInt32 modeAlpha);
		// void glBlendFunc (GLenum sfactor, GLenum dfactor)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendFuncDelegate (BlendingFactorSrc sfactor, BlendingFactorDest dfactor);
		// void glBlendFunci (GLuint buf, GLenum src, GLenum dst)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendFunciDelegate (System.UInt32 buf, System.UInt32 src, System.UInt32 dst);
		// void glBlendFuncSeparate (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendFuncSeparateDelegate (System.UInt32 sfactorRGB, System.UInt32 dfactorRGB, System.UInt32 sfactorAlpha, System.UInt32 dfactorAlpha);
		// void glBlendFuncSeparatei (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlendFuncSeparateiDelegate (System.UInt32 buf, System.UInt32 srcRGB, System.UInt32 dstRGB, System.UInt32 srcAlpha, System.UInt32 dstAlpha);
		// void glBlitFramebuffer (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlitFramebufferDelegate (System.Int32 srcX0, System.Int32 srcY0, System.Int32 srcX1, System.Int32 srcY1, System.Int32 dstX0, System.Int32 dstY0, System.Int32 dstX1, System.Int32 dstY1, ClearBufferMask mask, System.UInt32 filter);
		// void glBlitNamedFramebuffer (GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BlitNamedFramebufferDelegate (System.UInt32 readFramebuffer, System.UInt32 drawFramebuffer, System.Int32 srcX0, System.Int32 srcY0, System.Int32 srcX1, System.Int32 srcY1, System.Int32 dstX0, System.Int32 dstY0, System.Int32 dstX1, System.Int32 dstY1, System.UInt32 mask, System.UInt32 filter);
		// void glBufferData (GLenum target, GLsizeiptr size, void* data, GLenum usage)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BufferDataDelegate (System.UInt32 target, System.IntPtr size, IntPtr data, System.UInt32 usage);
		// void glBufferStorage (GLenum target, GLsizeiptr size, void* data, GLbitfield flags)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BufferStorageDelegate (System.UInt32 target, System.IntPtr size, IntPtr data, System.UInt32 flags);
		// void glBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void BufferSubDataDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size, IntPtr data);
		// GLenum glCheckFramebufferStatus (GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 CheckFramebufferStatusDelegate (System.UInt32 target);
		// GLenum glCheckNamedFramebufferStatus (GLuint framebuffer, GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 CheckNamedFramebufferStatusDelegate (System.UInt32 framebuffer, System.UInt32 target);
		// void glClampColor (GLenum target, GLenum clamp)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClampColorDelegate (System.UInt32 target, System.UInt32 clamp);
		// void glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferDataDelegate (System.UInt32 target, System.UInt32 internalformat, System.UInt32 format, System.UInt32 type, IntPtr data);
		// void glClearBufferfi (GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferfiDelegate (System.UInt32 buffer, System.Int32 drawbuffer, System.Single depth, System.Int32 stencil);
		// void glClearBufferfv (GLenum buffer, GLint drawbuffer, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferfvDelegate (System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearBufferiv (GLenum buffer, GLint drawbuffer, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferivDelegate (System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferSubDataDelegate (System.UInt32 target, System.UInt32 internalformat, System.IntPtr offset, System.IntPtr size, System.UInt32 format, System.UInt32 type, IntPtr data);
		// void glClearBufferuiv (GLenum buffer, GLint drawbuffer, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearBufferuivDelegate (System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearColor (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearColorDelegate (System.Single red, System.Single green, System.Single blue, System.Single alpha);
		// void glClearDepthf (GLfloat d)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearDepthfDelegate (System.Single d);
		// void glClearDepth (GLdouble depth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearDepthDelegate (System.Double depth);
		// void glClear (GLbitfield mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearDelegate (ClearBufferMask mask);
		// void glClearNamedBufferData (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedBufferDataDelegate (System.UInt32 buffer, System.UInt32 internalformat, System.UInt32 format, System.UInt32 type, IntPtr data);
		// void glClearNamedBufferSubData (GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedBufferSubDataDelegate (System.UInt32 buffer, System.UInt32 internalformat, System.IntPtr offset, System.IntPtr size, System.UInt32 format, System.UInt32 type, IntPtr data);
		// void glClearNamedFramebufferfi (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedFramebufferfiDelegate (System.UInt32 framebuffer, System.UInt32 buffer, System.Int32 drawbuffer, System.Single depth, System.Int32 stencil);
		// void glClearNamedFramebufferfv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedFramebufferfvDelegate (System.UInt32 framebuffer, System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearNamedFramebufferiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedFramebufferivDelegate (System.UInt32 framebuffer, System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearNamedFramebufferuiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearNamedFramebufferuivDelegate (System.UInt32 framebuffer, System.UInt32 buffer, System.Int32 drawbuffer, IntPtr value);
		// void glClearStencil (GLint s)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearStencilDelegate (System.Int32 s);
		// void glClearTexImage (GLuint texture, GLint level, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearTexImageDelegate (System.UInt32 texture, System.Int32 level, System.UInt32 format, System.UInt32 type, IntPtr data);
		// void glClearTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClearTexSubImageDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.UInt32 format, System.UInt32 type, IntPtr data);
		// GLenum glClientWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 ClientWaitSyncDelegate (System.IntPtr sync, System.UInt32 flags, System.UInt64 timeout);
		// void glClipControl (GLenum origin, GLenum depth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ClipControlDelegate (System.UInt32 origin, System.UInt32 depth);
		// void glColorMask (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ColorMaskDelegate (Boolean red, Boolean green, Boolean blue, Boolean alpha);
		// void glColorMaski (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ColorMaskiDelegate (System.UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a);
		// void glCompileShader (GLuint shader)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompileShaderDelegate (System.UInt32 shader);
		// void glCompressedTexImage1D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexImage1DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, IntPtr data);
		// void glCompressedTexImage2D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexImage2DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, IntPtr data);
		// void glCompressedTexImage3D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexImage3DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, IntPtr data);
		// void glCompressedTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, System.Int32 imageSize, IntPtr data);
		// void glCompressedTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, System.Int32 imageSize, IntPtr data);
		// void glCompressedTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, System.Int32 imageSize, IntPtr data);
		// void glCompressedTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTextureSubImage1DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 width, System.UInt32 format, System.Int32 imageSize, IntPtr data);
		// void glCompressedTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTextureSubImage2DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, System.UInt32 format, System.Int32 imageSize, IntPtr data);
		// void glCompressedTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CompressedTextureSubImage3DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.UInt32 format, System.Int32 imageSize, IntPtr data);
		// void glCopyBufferSubData (GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyBufferSubDataDelegate (System.UInt32 readTarget, System.UInt32 writeTarget, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size);
		// void glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyImageSubDataDelegate (System.UInt32 srcName, System.UInt32 srcTarget, System.Int32 srcLevel, System.Int32 srcX, System.Int32 srcY, System.Int32 srcZ, System.UInt32 dstName, System.UInt32 dstTarget, System.Int32 dstLevel, System.Int32 dstX, System.Int32 dstY, System.Int32 dstZ, System.Int32 srcWidth, System.Int32 srcHeight, System.Int32 srcDepth);
		// void glCopyNamedBufferSubData (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyNamedBufferSubDataDelegate (System.UInt32 readBuffer, System.UInt32 writeBuffer, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size);
		// void glCopyTexImage1D (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTexImage1DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 border);
		// void glCopyTexImage2D (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTexImage2DDelegate (TextureTarget target, System.Int32 level, System.UInt32 internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 border);
		// void glCopyTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width);
		// void glCopyTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glCopyTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glCopyTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTextureSubImage1DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width);
		// void glCopyTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTextureSubImage2DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glCopyTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CopyTextureSubImage3DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glCreateBuffers (GLsizei n, GLuint* buffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateBuffersDelegate (System.Int32 n, IntPtr buffers);
		// void glCreateFramebuffers (GLsizei n, GLuint* framebuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateFramebuffersDelegate (System.Int32 n, IntPtr framebuffers);
		// GLuint glCreateProgram ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 CreateProgramDelegate ();
		// void glCreateProgramPipelines (GLsizei n, GLuint* pipelines)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateProgramPipelinesDelegate (System.Int32 n, IntPtr pipelines);
		// void glCreateQueries (GLenum target, GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateQueriesDelegate (System.UInt32 target, System.Int32 n, IntPtr ids);
		// void glCreateRenderbuffers (GLsizei n, GLuint* renderbuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateRenderbuffersDelegate (System.Int32 n, IntPtr renderbuffers);
		// void glCreateSamplers (GLsizei n, GLuint* samplers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateSamplersDelegate (System.Int32 n, IntPtr samplers);
		// GLuint glCreateShader (GLenum type)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 CreateShaderDelegate (System.UInt32 type);
		// GLuint glCreateShaderProgramv (GLenum type, GLsizei count, GLchar** strings)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 CreateShaderProgramvDelegate (System.UInt32 type, System.Int32 count, StringPtr strings);
		// void glCreateTextures (GLenum target, GLsizei n, GLuint* textures)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateTexturesDelegate (System.UInt32 target, System.Int32 n, IntPtr textures);
		// void glCreateTransformFeedbacks (GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateTransformFeedbacksDelegate (System.Int32 n, IntPtr ids);
		// void glCreateVertexArrays (GLsizei n, GLuint* arrays)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CreateVertexArraysDelegate (System.Int32 n, IntPtr arrays);
		// void glCullFace (GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void CullFaceDelegate (CullFaceMode mode);
		// void glDebugMessageCallback (GLDEBUGPROC callback, void* userParam)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DebugMessageCallbackDelegate (System.IntPtr callback, IntPtr userParam);
		// void glDebugMessageControl (GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DebugMessageControlDelegate (System.UInt32 source, System.UInt32 type, System.UInt32 severity, System.Int32 count, IntPtr ids, Boolean enabled);
		// void glDebugMessageInsert (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DebugMessageInsertDelegate (System.UInt32 source, System.UInt32 type, System.UInt32 id, System.UInt32 severity, System.Int32 length, IntPtr buf);
		// void glDeleteBuffers (GLsizei n, GLuint* buffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteBuffersDelegate (System.Int32 n, IntPtr buffers);
		// void glDeleteFramebuffers (GLsizei n, GLuint* framebuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteFramebuffersDelegate (System.Int32 n, IntPtr framebuffers);
		// void glDeleteProgram (GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteProgramDelegate (System.UInt32 program);
		// void glDeleteProgramPipelines (GLsizei n, GLuint* pipelines)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteProgramPipelinesDelegate (System.Int32 n, IntPtr pipelines);
		// void glDeleteQueries (GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteQueriesDelegate (System.Int32 n, IntPtr ids);
		// void glDeleteRenderbuffers (GLsizei n, GLuint* renderbuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteRenderbuffersDelegate (System.Int32 n, IntPtr renderbuffers);
		// void glDeleteSamplers (GLsizei count, GLuint* samplers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteSamplersDelegate (System.Int32 count, IntPtr samplers);
		// void glDeleteShader (GLuint shader)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteShaderDelegate (System.UInt32 shader);
		// void glDeleteSync (GLsync sync)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteSyncDelegate (System.IntPtr sync);
		// void glDeleteTextures (GLsizei n, GLuint* textures)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteTexturesDelegate (System.Int32 n, IntPtr textures);
		// void glDeleteTransformFeedbacks (GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteTransformFeedbacksDelegate (System.Int32 n, IntPtr ids);
		// void glDeleteVertexArrays (GLsizei n, GLuint* arrays)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DeleteVertexArraysDelegate (System.Int32 n, IntPtr arrays);
		// void glDepthFunc (GLenum func)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthFuncDelegate (DepthFunction func);
		// void glDepthMask (GLboolean flag)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthMaskDelegate (Boolean flag);
		// void glDepthRangeArrayv (GLuint first, GLsizei count, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthRangeArrayvDelegate (System.UInt32 first, System.Int32 count, IntPtr v);
		// void glDepthRangef (GLfloat n, GLfloat f)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthRangefDelegate (System.Single n, System.Single f);
		// void glDepthRange (GLdouble near, GLdouble far)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthRangeDelegate (System.Double near, System.Double far);
		// void glDepthRangeIndexed (GLuint index, GLdouble n, GLdouble f)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DepthRangeIndexedDelegate (System.UInt32 index, System.Double n, System.Double f);
		// void glDetachShader (GLuint program, GLuint shader)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DetachShaderDelegate (System.UInt32 program, System.UInt32 shader);
		// void glDisable (GLenum cap)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DisableDelegate (EnableCap cap);
		// void glDisablei (GLenum target, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DisableiDelegate (System.UInt32 target, System.UInt32 index);
		// void glDisableVertexArrayAttrib (GLuint vaobj, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DisableVertexArrayAttribDelegate (System.UInt32 vaobj, System.UInt32 index);
		// void glDisableVertexAttribArray (GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DisableVertexAttribArrayDelegate (System.UInt32 index);
		// void glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DispatchComputeDelegate (System.UInt32 num_groups_x, System.UInt32 num_groups_y, System.UInt32 num_groups_z);
		// void glDispatchComputeIndirect (GLintptr indirect)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DispatchComputeIndirectDelegate (System.IntPtr indirect);
		// void glDrawArrays (GLenum mode, GLint first, GLsizei count)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawArraysDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count);
		// void glDrawArraysIndirect (GLenum mode, void* indirect)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawArraysIndirectDelegate (PrimitiveType mode, IntPtr indirect);
		// void glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawArraysInstancedBaseInstanceDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count, System.Int32 instancecount, System.UInt32 baseinstance);
		// void glDrawArraysInstanced (GLenum mode, GLint first, GLsizei count, GLsizei instancecount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawArraysInstancedDelegate (PrimitiveType mode, System.Int32 first, System.Int32 count, System.Int32 instancecount);
		// void glDrawBuffer (GLenum buf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawBufferDelegate (DrawBufferMode buf);
		// void glDrawBuffers (GLsizei n, GLenum* bufs)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawBuffersDelegate (System.Int32 n, IntPtr bufs);
		// void glDrawElementsBaseVertex (GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsBaseVertexDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 basevertex);
		// void glDrawElements (GLenum mode, GLsizei count, GLenum type, void* indices)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices);
		// void glDrawElementsIndirect (GLenum mode, GLenum type, void* indirect)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsIndirectDelegate (PrimitiveType mode, System.UInt32 type, IntPtr indirect);
		// void glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLuint baseinstance)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsInstancedBaseInstanceDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 instancecount, System.UInt32 baseinstance);
		// void glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsInstancedBaseVertexBaseInstanceDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 instancecount, System.Int32 basevertex, System.UInt32 baseinstance);
		// void glDrawElementsInstancedBaseVertex (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsInstancedBaseVertexDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 instancecount, System.Int32 basevertex);
		// void glDrawElementsInstanced (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawElementsInstancedDelegate (PrimitiveType mode, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 instancecount);
		// void glDrawRangeElementsBaseVertex (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawRangeElementsBaseVertexDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, System.Int32 count, System.UInt32 type, IntPtr indices, System.Int32 basevertex);
		// void glDrawRangeElements (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawRangeElementsDelegate (PrimitiveType mode, System.UInt32 start, System.UInt32 end, System.Int32 count, System.UInt32 type, IntPtr indices);
		// void glDrawTransformFeedback (GLenum mode, GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawTransformFeedbackDelegate (PrimitiveType mode, System.UInt32 id);
		// void glDrawTransformFeedbackInstanced (GLenum mode, GLuint id, GLsizei instancecount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawTransformFeedbackInstancedDelegate (PrimitiveType mode, System.UInt32 id, System.Int32 instancecount);
		// void glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawTransformFeedbackStreamDelegate (PrimitiveType mode, System.UInt32 id, System.UInt32 stream);
		// void glDrawTransformFeedbackStreamInstanced (GLenum mode, GLuint id, GLuint stream, GLsizei instancecount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void DrawTransformFeedbackStreamInstancedDelegate (PrimitiveType mode, System.UInt32 id, System.UInt32 stream, System.Int32 instancecount);
		// void glEnable (GLenum cap)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EnableDelegate (EnableCap cap);
		// void glEnablei (GLenum target, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EnableiDelegate (System.UInt32 target, System.UInt32 index);
		// void glEnableVertexArrayAttrib (GLuint vaobj, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EnableVertexArrayAttribDelegate (System.UInt32 vaobj, System.UInt32 index);
		// void glEnableVertexAttribArray (GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EnableVertexAttribArrayDelegate (System.UInt32 index);
		// void glEndConditionalRender ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EndConditionalRenderDelegate ();
		// void glEndQuery (GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EndQueryDelegate (System.UInt32 target);
		// void glEndQueryIndexed (GLenum target, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EndQueryIndexedDelegate (System.UInt32 target, System.UInt32 index);
		// void glEndTransformFeedback ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void EndTransformFeedbackDelegate ();
		// GLsync glFenceSync (GLenum condition, GLbitfield flags)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.IntPtr FenceSyncDelegate (System.UInt32 condition, System.UInt32 flags);
		// void glFinish ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FinishDelegate ();
		// void glFlush ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FlushDelegate ();
		// void glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FlushMappedBufferRangeDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr length);
		// void glFlushMappedNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FlushMappedNamedBufferRangeDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr length);
		// void glFramebufferParameteri (GLenum target, GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferParameteriDelegate (System.UInt32 target, System.UInt32 pname, System.Int32 param);
		// void glFramebufferRenderbuffer (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferRenderbufferDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 renderbuffertarget, System.UInt32 renderbuffer);
		// void glFramebufferTexture1D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferTexture1DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level);
		// void glFramebufferTexture2D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferTexture2DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level);
		// void glFramebufferTexture3D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferTexture3DDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 textarget, System.UInt32 texture, System.Int32 level, System.Int32 zoffset);
		// void glFramebufferTexture (GLenum target, GLenum attachment, GLuint texture, GLint level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferTextureDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level);
		// void glFramebufferTextureLayer (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FramebufferTextureLayerDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer);
		// void glFrontFace (GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void FrontFaceDelegate (FrontFaceDirection mode);
		// void glGenBuffers (GLsizei n, GLuint* buffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenBuffersDelegate (System.Int32 n, IntPtr buffers);
		// void glGenerateMipmap (GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenerateMipmapDelegate (System.UInt32 target);
		// void glGenerateTextureMipmap (GLuint texture)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenerateTextureMipmapDelegate (System.UInt32 texture);
		// void glGenFramebuffers (GLsizei n, GLuint* framebuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenFramebuffersDelegate (System.Int32 n, IntPtr framebuffers);
		// void glGenProgramPipelines (GLsizei n, GLuint* pipelines)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenProgramPipelinesDelegate (System.Int32 n, IntPtr pipelines);
		// void glGenQueries (GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenQueriesDelegate (System.Int32 n, IntPtr ids);
		// void glGenRenderbuffers (GLsizei n, GLuint* renderbuffers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenRenderbuffersDelegate (System.Int32 n, IntPtr renderbuffers);
		// void glGenSamplers (GLsizei count, GLuint* samplers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenSamplersDelegate (System.Int32 count, IntPtr samplers);
		// void glGenTextures (GLsizei n, GLuint* textures)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenTexturesDelegate (System.Int32 n, IntPtr textures);
		// void glGenTransformFeedbacks (GLsizei n, GLuint* ids)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenTransformFeedbacksDelegate (System.Int32 n, IntPtr ids);
		// void glGenVertexArrays (GLsizei n, GLuint* arrays)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GenVertexArraysDelegate (System.Int32 n, IntPtr arrays);
		// void glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveAtomicCounterBufferivDelegate (System.UInt32 program, System.UInt32 bufferIndex, System.UInt32 pname, IntPtr @params);
		// void glGetActiveAttrib (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveAttribDelegate (System.UInt32 program, System.UInt32 index, System.Int32 bufSize, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
		// void glGetActiveSubroutineName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveSubroutineNameDelegate (System.UInt32 program, System.UInt32 shadertype, System.UInt32 index, System.Int32 bufsize, IntPtr length, StringPtr name);
		// void glGetActiveSubroutineUniformiv (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveSubroutineUniformivDelegate (System.UInt32 program, System.UInt32 shadertype, System.UInt32 index, System.UInt32 pname, IntPtr values);
		// void glGetActiveSubroutineUniformName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveSubroutineUniformNameDelegate (System.UInt32 program, System.UInt32 shadertype, System.UInt32 index, System.Int32 bufsize, IntPtr length, StringPtr name);
		// void glGetActiveUniformBlockiv (GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveUniformBlockivDelegate (System.UInt32 program, System.UInt32 uniformBlockIndex, System.UInt32 pname, IntPtr @params);
		// void glGetActiveUniformBlockName (GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveUniformBlockNameDelegate (System.UInt32 program, System.UInt32 uniformBlockIndex, System.Int32 bufSize, IntPtr length, StringPtr uniformBlockName);
		// void glGetActiveUniform (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveUniformDelegate (System.UInt32 program, System.UInt32 index, System.Int32 bufSize, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
		// void glGetActiveUniformName (GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveUniformNameDelegate (System.UInt32 program, System.UInt32 uniformIndex, System.Int32 bufSize, IntPtr length, StringPtr uniformName);
		// void glGetActiveUniformsiv (GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetActiveUniformsivDelegate (System.UInt32 program, System.Int32 uniformCount, IntPtr uniformIndices, System.UInt32 pname, IntPtr @params);
		// void glGetAttachedShaders (GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetAttachedShadersDelegate (System.UInt32 program, System.Int32 maxCount, IntPtr count, IntPtr shaders);
		// GLint glGetAttribLocation (GLuint program, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetAttribLocationDelegate (System.UInt32 program, StringPtr name);
		// void glGetBooleani_v (GLenum target, GLuint index, GLboolean* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBooleani_vDelegate (System.UInt32 target, System.UInt32 index, Boolean data);
		// void glGetBooleanv (GLenum pname, GLboolean* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBooleanvDelegate (GetPName pname, Boolean data);
		// void glGetBufferParameteri64v (GLenum target, GLenum pname, GLint64* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBufferParameteri64vDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// void glGetBufferParameteriv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBufferParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// void glGetBufferPointerv (GLenum target, GLenum pname, void** params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBufferPointervDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// void glGetBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetBufferSubDataDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr size, IntPtr data);
		// void glGetCompressedTexImage (GLenum target, GLint level, void* img)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetCompressedTexImageDelegate (TextureTarget target, System.Int32 level, IntPtr img);
		// void glGetCompressedTextureImage (GLuint texture, GLint level, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetCompressedTextureImageDelegate (System.UInt32 texture, System.Int32 level, System.Int32 bufSize, IntPtr pixels);
		// void glGetCompressedTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetCompressedTextureSubImageDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 bufSize, IntPtr pixels);
		// GLuint glGetDebugMessageLog (GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetDebugMessageLogDelegate (System.UInt32 count, System.Int32 bufSize, IntPtr sources, IntPtr types, IntPtr ids, IntPtr severities, IntPtr lengths, IntPtr messageLog);
		// void glGetDoublei_v (GLenum target, GLuint index, GLdouble* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetDoublei_vDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
		// void glGetDoublev (GLenum pname, GLdouble* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetDoublevDelegate (GetPName pname, IntPtr data);
		// GLenum glGetError ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate ErrorCode GetErrorDelegate ();
		// void glGetFloati_v (GLenum target, GLuint index, GLfloat* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetFloati_vDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
		// void glGetFloatv (GLenum pname, GLfloat* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetFloatvDelegate (GetPName pname, IntPtr data);
		// GLint glGetFragDataIndex (GLuint program, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetFragDataIndexDelegate (System.UInt32 program, StringPtr name);
		// GLint glGetFragDataLocation (GLuint program, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetFragDataLocationDelegate (System.UInt32 program, StringPtr name);
		// void glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetFramebufferAttachmentParameterivDelegate (System.UInt32 target, System.UInt32 attachment, System.UInt32 pname, IntPtr @params);
		// void glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetFramebufferParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// GLenum glGetGraphicsResetStatus ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetGraphicsResetStatusDelegate ();
		// void glGetInteger64i_v (GLenum target, GLuint index, GLint64* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetInteger64i_vDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
		// void glGetInteger64v (GLenum pname, GLint64* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetInteger64vDelegate (System.UInt32 pname, IntPtr data);
		// void glGetIntegeri_v (GLenum target, GLuint index, GLint* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetIntegeri_vDelegate (System.UInt32 target, System.UInt32 index, IntPtr data);
		// void glGetIntegerv (GLenum pname, GLint* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetIntegervDelegate (GetPName pname, IntPtr data);
		// void glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetInternalformati64vDelegate (System.UInt32 target, System.UInt32 internalformat, System.UInt32 pname, System.Int32 bufSize, IntPtr @params);
		// void glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetInternalformativDelegate (System.UInt32 target, System.UInt32 internalformat, System.UInt32 pname, System.Int32 bufSize, IntPtr @params);
		// void glGetMultisamplefv (GLenum pname, GLuint index, GLfloat* val)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetMultisamplefvDelegate (System.UInt32 pname, System.UInt32 index, IntPtr val);
		// void glGetNamedBufferParameteri64v (GLuint buffer, GLenum pname, GLint64* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedBufferParameteri64vDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
		// void glGetNamedBufferParameteriv (GLuint buffer, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedBufferParameterivDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
		// void glGetNamedBufferPointerv (GLuint buffer, GLenum pname, void** params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedBufferPointervDelegate (System.UInt32 buffer, System.UInt32 pname, IntPtr @params);
		// void glGetNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedBufferSubDataDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, IntPtr data);
		// void glGetNamedFramebufferAttachmentParameteriv (GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedFramebufferAttachmentParameterivDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 pname, IntPtr @params);
		// void glGetNamedFramebufferParameteriv (GLuint framebuffer, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedFramebufferParameterivDelegate (System.UInt32 framebuffer, System.UInt32 pname, IntPtr param);
		// void glGetNamedRenderbufferParameteriv (GLuint renderbuffer, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetNamedRenderbufferParameterivDelegate (System.UInt32 renderbuffer, System.UInt32 pname, IntPtr @params);
		// void glGetnCompressedTexImage (GLenum target, GLint lod, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnCompressedTexImageDelegate (System.UInt32 target, System.Int32 lod, System.Int32 bufSize, IntPtr pixels);
		// void glGetnTexImage (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnTexImageDelegate (System.UInt32 target, System.Int32 level, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr pixels);
		// void glGetnUniformdv (GLuint program, GLint location, GLsizei bufSize, GLdouble* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnUniformdvDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
		// void glGetnUniformfv (GLuint program, GLint location, GLsizei bufSize, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnUniformfvDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
		// void glGetnUniformiv (GLuint program, GLint location, GLsizei bufSize, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnUniformivDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
		// void glGetnUniformuiv (GLuint program, GLint location, GLsizei bufSize, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetnUniformuivDelegate (System.UInt32 program, System.Int32 location, System.Int32 bufSize, IntPtr @params);
		// void glGetObjectLabel (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetObjectLabelDelegate (System.UInt32 identifier, StringPtr name, System.Int32 bufSize, IntPtr length, StringPtr label);
		// void glGetObjectPtrLabel (void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetObjectPtrLabelDelegate (IntPtr ptr, System.Int32 bufSize, IntPtr length, StringPtr label);
		// void glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramBinaryDelegate (System.UInt32 program, System.Int32 bufSize, IntPtr length, IntPtr binaryFormat, IntPtr binary);
		// void glGetProgramInfoLog (GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramInfoLogDelegate (System.UInt32 program, System.Int32 bufSize, IntPtr length, StringPtr infoLog);
		// void glGetProgramInterfaceiv (GLuint program, GLenum programInterface, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramInterfaceivDelegate (System.UInt32 program, System.UInt32 programInterface, System.UInt32 pname, IntPtr @params);
		// void glGetProgramiv (GLuint program, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramivDelegate (System.UInt32 program, System.UInt32 pname, IntPtr @params);
		// void glGetProgramPipelineInfoLog (GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramPipelineInfoLogDelegate (System.UInt32 pipeline, System.Int32 bufSize, IntPtr length, StringPtr infoLog);
		// void glGetProgramPipelineiv (GLuint pipeline, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramPipelineivDelegate (System.UInt32 pipeline, System.UInt32 pname, IntPtr @params);
		// GLuint glGetProgramResourceIndex (GLuint program, GLenum programInterface, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetProgramResourceIndexDelegate (System.UInt32 program, System.UInt32 programInterface, StringPtr name);
		// void glGetProgramResourceiv (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramResourceivDelegate (System.UInt32 program, System.UInt32 programInterface, System.UInt32 index, System.Int32 propCount, IntPtr props, System.Int32 bufSize, IntPtr length, IntPtr @params);
		// GLint glGetProgramResourceLocation (GLuint program, GLenum programInterface, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetProgramResourceLocationDelegate (System.UInt32 program, System.UInt32 programInterface, StringPtr name);
		// GLint glGetProgramResourceLocationIndex (GLuint program, GLenum programInterface, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetProgramResourceLocationIndexDelegate (System.UInt32 program, System.UInt32 programInterface, StringPtr name);
		// void glGetProgramResourceName (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramResourceNameDelegate (System.UInt32 program, System.UInt32 programInterface, System.UInt32 index, System.Int32 bufSize, IntPtr length, StringPtr name);
		// void glGetProgramStageiv (GLuint program, GLenum shadertype, GLenum pname, GLint* values)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetProgramStageivDelegate (System.UInt32 program, System.UInt32 shadertype, System.UInt32 pname, IntPtr values);
		// void glGetQueryBufferObjecti64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryBufferObjecti64vDelegate (System.UInt32 id, System.UInt32 buffer, System.UInt32 pname, System.IntPtr offset);
		// void glGetQueryBufferObjectiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryBufferObjectivDelegate (System.UInt32 id, System.UInt32 buffer, System.UInt32 pname, System.IntPtr offset);
		// void glGetQueryBufferObjectui64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryBufferObjectui64vDelegate (System.UInt32 id, System.UInt32 buffer, System.UInt32 pname, System.IntPtr offset);
		// void glGetQueryBufferObjectuiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryBufferObjectuivDelegate (System.UInt32 id, System.UInt32 buffer, System.UInt32 pname, System.IntPtr offset);
		// void glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryIndexedivDelegate (System.UInt32 target, System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetQueryiv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// void glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryObjecti64vDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
		// void glGetQueryObjectiv (GLuint id, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryObjectivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
		// void glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryObjectui64vDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
		// void glGetQueryObjectuiv (GLuint id, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetQueryObjectuivDelegate (System.UInt32 id, System.UInt32 pname, IntPtr @params);
		// void glGetRenderbufferParameteriv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetRenderbufferParameterivDelegate (System.UInt32 target, System.UInt32 pname, IntPtr @params);
		// void glGetSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetSamplerParameterfvDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr @params);
		// void glGetSamplerParameterIiv (GLuint sampler, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetSamplerParameterIivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr @params);
		// void glGetSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetSamplerParameterIuivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr @params);
		// void glGetSamplerParameteriv (GLuint sampler, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetSamplerParameterivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr @params);
		// void glGetShaderInfoLog (GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetShaderInfoLogDelegate (System.UInt32 shader, System.Int32 bufSize, IntPtr length, StringPtr infoLog);
		// void glGetShaderiv (GLuint shader, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetShaderivDelegate (System.UInt32 shader, System.UInt32 pname, IntPtr @params);
		// void glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetShaderPrecisionFormatDelegate (System.UInt32 shadertype, System.UInt32 precisiontype, IntPtr range, IntPtr precision);
		// void glGetShaderSource (GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetShaderSourceDelegate (System.UInt32 shader, System.Int32 bufSize, IntPtr length, StringPtr source);
		// GLubyte* glGetString (GLenum name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate StringPtr GetStringDelegate (StringName name);
		// GLubyte* glGetStringi (GLenum name, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate StringPtr GetStringiDelegate (System.UInt32 name, System.UInt32 index);
		// GLuint glGetSubroutineIndex (GLuint program, GLenum shadertype, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetSubroutineIndexDelegate (System.UInt32 program, System.UInt32 shadertype, StringPtr name);
		// GLint glGetSubroutineUniformLocation (GLuint program, GLenum shadertype, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetSubroutineUniformLocationDelegate (System.UInt32 program, System.UInt32 shadertype, StringPtr name);
		// void glGetSynciv (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetSyncivDelegate (System.IntPtr sync, System.UInt32 pname, System.Int32 bufSize, IntPtr length, IntPtr values);
		// void glGetTexImage (GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexImageDelegate (TextureTarget target, System.Int32 level, PixelFormat format, PixelType type, IntPtr pixels);
		// void glGetTexLevelParameterfv (GLenum target, GLint level, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexLevelParameterfvDelegate (TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
		// void glGetTexLevelParameteriv (GLenum target, GLint level, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexLevelParameterivDelegate (TextureTarget target, System.Int32 level, GetTextureParameter pname, IntPtr @params);
		// void glGetTexParameterfv (GLenum target, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexParameterfvDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
		// void glGetTexParameterIiv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexParameterIivDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
		// void glGetTexParameterIuiv (GLenum target, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexParameterIuivDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
		// void glGetTexParameteriv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTexParameterivDelegate (TextureTarget target, GetTextureParameter pname, IntPtr @params);
		// void glGetTextureImage (GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureImageDelegate (System.UInt32 texture, System.Int32 level, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr pixels);
		// void glGetTextureLevelParameterfv (GLuint texture, GLint level, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureLevelParameterfvDelegate (System.UInt32 texture, System.Int32 level, System.UInt32 pname, IntPtr @params);
		// void glGetTextureLevelParameteriv (GLuint texture, GLint level, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureLevelParameterivDelegate (System.UInt32 texture, System.Int32 level, System.UInt32 pname, IntPtr @params);
		// void glGetTextureParameterfv (GLuint texture, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureParameterfvDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glGetTextureParameterIiv (GLuint texture, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureParameterIivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glGetTextureParameterIuiv (GLuint texture, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureParameterIuivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glGetTextureParameteriv (GLuint texture, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureParameterivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glGetTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTextureSubImageDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr pixels);
		// void glGetTransformFeedbacki_v (GLuint xfb, GLenum pname, GLuint index, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTransformFeedbacki_vDelegate (System.UInt32 xfb, System.UInt32 pname, System.UInt32 index, IntPtr param);
		// void glGetTransformFeedbacki64_v (GLuint xfb, GLenum pname, GLuint index, GLint64* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTransformFeedbacki64_vDelegate (System.UInt32 xfb, System.UInt32 pname, System.UInt32 index, IntPtr param);
		// void glGetTransformFeedbackiv (GLuint xfb, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTransformFeedbackivDelegate (System.UInt32 xfb, System.UInt32 pname, IntPtr param);
		// void glGetTransformFeedbackVarying (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetTransformFeedbackVaryingDelegate (System.UInt32 program, System.UInt32 index, System.Int32 bufSize, IntPtr length, IntPtr size, IntPtr type, StringPtr name);
		// GLuint glGetUniformBlockIndex (GLuint program, GLchar* uniformBlockName)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.UInt32 GetUniformBlockIndexDelegate (System.UInt32 program, StringPtr uniformBlockName);
		// void glGetUniformdv (GLuint program, GLint location, GLdouble* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformdvDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
		// void glGetUniformfv (GLuint program, GLint location, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformfvDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
		// void glGetUniformIndices (GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformIndicesDelegate (System.UInt32 program, System.Int32 uniformCount, IntPtr uniformNames, IntPtr uniformIndices);
		// void glGetUniformiv (GLuint program, GLint location, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformivDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
		// GLint glGetUniformLocation (GLuint program, GLchar* name)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Int32 GetUniformLocationDelegate (System.UInt32 program, StringPtr name);
		// void glGetUniformSubroutineuiv (GLenum shadertype, GLint location, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformSubroutineuivDelegate (System.UInt32 shadertype, System.Int32 location, IntPtr @params);
		// void glGetUniformuiv (GLuint program, GLint location, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetUniformuivDelegate (System.UInt32 program, System.Int32 location, IntPtr @params);
		// void glGetVertexArrayIndexed64iv (GLuint vaobj, GLuint index, GLenum pname, GLint64* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexArrayIndexed64ivDelegate (System.UInt32 vaobj, System.UInt32 index, System.UInt32 pname, IntPtr param);
		// void glGetVertexArrayIndexediv (GLuint vaobj, GLuint index, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexArrayIndexedivDelegate (System.UInt32 vaobj, System.UInt32 index, System.UInt32 pname, IntPtr param);
		// void glGetVertexArrayiv (GLuint vaobj, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexArrayivDelegate (System.UInt32 vaobj, System.UInt32 pname, IntPtr param);
		// void glGetVertexAttribdv (GLuint index, GLenum pname, GLdouble* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribdvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribfv (GLuint index, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribfvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribIiv (GLuint index, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribIivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribIuiv (GLuint index, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribIuivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribiv (GLuint index, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribivDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribLdv (GLuint index, GLenum pname, GLdouble* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribLdvDelegate (System.UInt32 index, System.UInt32 pname, IntPtr @params);
		// void glGetVertexAttribPointerv (GLuint index, GLenum pname, void** pointer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void GetVertexAttribPointervDelegate (System.UInt32 index, System.UInt32 pname, IntPtr pointer);
		// void glHint (GLenum target, GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void HintDelegate (HintTarget target, HintMode mode);
		// void glInvalidateBufferData (GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateBufferDataDelegate (System.UInt32 buffer);
		// void glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateBufferSubDataDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr length);
		// void glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, GLenum* attachments)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateFramebufferDelegate (System.UInt32 target, System.Int32 numAttachments, IntPtr attachments);
		// void glInvalidateNamedFramebufferData (GLuint framebuffer, GLsizei numAttachments, GLenum* attachments)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateNamedFramebufferDataDelegate (System.UInt32 framebuffer, System.Int32 numAttachments, IntPtr attachments);
		// void glInvalidateNamedFramebufferSubData (GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateNamedFramebufferSubDataDelegate (System.UInt32 framebuffer, System.Int32 numAttachments, IntPtr attachments, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateSubFramebufferDelegate (System.UInt32 target, System.Int32 numAttachments, IntPtr attachments, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glInvalidateTexImage (GLuint texture, GLint level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateTexImageDelegate (System.UInt32 texture, System.Int32 level);
		// void glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void InvalidateTexSubImageDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth);
		// GLboolean glIsBuffer (GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsBufferDelegate (System.UInt32 buffer);
		// GLboolean glIsEnabled (GLenum cap)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsEnabledDelegate (EnableCap cap);
		// GLboolean glIsEnabledi (GLenum target, GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsEnablediDelegate (System.UInt32 target, System.UInt32 index);
		// GLboolean glIsFramebuffer (GLuint framebuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsFramebufferDelegate (System.UInt32 framebuffer);
		// GLboolean glIsProgram (GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsProgramDelegate (System.UInt32 program);
		// GLboolean glIsProgramPipeline (GLuint pipeline)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsProgramPipelineDelegate (System.UInt32 pipeline);
		// GLboolean glIsQuery (GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsQueryDelegate (System.UInt32 id);
		// GLboolean glIsRenderbuffer (GLuint renderbuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsRenderbufferDelegate (System.UInt32 renderbuffer);
		// GLboolean glIsSampler (GLuint sampler)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsSamplerDelegate (System.UInt32 sampler);
		// GLboolean glIsShader (GLuint shader)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsShaderDelegate (System.UInt32 shader);
		// GLboolean glIsSync (GLsync sync)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsSyncDelegate (System.IntPtr sync);
		// GLboolean glIsTexture (GLuint texture)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsTextureDelegate (System.UInt32 texture);
		// GLboolean glIsTransformFeedback (GLuint id)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsTransformFeedbackDelegate (System.UInt32 id);
		// GLboolean glIsVertexArray (GLuint array)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean IsVertexArrayDelegate (System.UInt32 array);
		// void glLineWidth (GLfloat width)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void LineWidthDelegate (System.Single width);
		// void glLinkProgram (GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void LinkProgramDelegate (System.UInt32 program);
		// void glLogicOp (GLenum opcode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void LogicOpDelegate (LogicOp opcode);
		// void* glMapBuffer (GLenum target, GLenum access)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate IntPtr MapBufferDelegate (System.UInt32 target, System.UInt32 access);
		// void* glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate IntPtr MapBufferRangeDelegate (System.UInt32 target, System.IntPtr offset, System.IntPtr length, System.UInt32 access);
		// void* glMapNamedBuffer (GLuint buffer, GLenum access)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate IntPtr MapNamedBufferDelegate (System.UInt32 buffer, System.UInt32 access);
		// void* glMapNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate IntPtr MapNamedBufferRangeDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr length, System.UInt32 access);
		// void glMemoryBarrierByRegion (GLbitfield barriers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MemoryBarrierByRegionDelegate (System.UInt32 barriers);
		// void glMemoryBarrier (GLbitfield barriers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MemoryBarrierDelegate (System.UInt32 barriers);
		// void glMinSampleShading (GLfloat value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MinSampleShadingDelegate (System.Single value);
		// void glMultiDrawArrays (GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MultiDrawArraysDelegate (PrimitiveType mode, IntPtr first, IntPtr count, System.Int32 drawcount);
		// void glMultiDrawArraysIndirect (GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MultiDrawArraysIndirectDelegate (System.UInt32 mode, IntPtr indirect, System.Int32 drawcount, System.Int32 stride);
		// void glMultiDrawElementsBaseVertex (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MultiDrawElementsBaseVertexDelegate (System.UInt32 mode, IntPtr count, System.UInt32 type, IntPtr indices, System.Int32 drawcount, IntPtr basevertex);
		// void glMultiDrawElements (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MultiDrawElementsDelegate (PrimitiveType mode, IntPtr count, System.UInt32 type, IntPtr indices, System.Int32 drawcount);
		// void glMultiDrawElementsIndirect (GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void MultiDrawElementsIndirectDelegate (System.UInt32 mode, System.UInt32 type, IntPtr indirect, System.Int32 drawcount, System.Int32 stride);
		// void glNamedBufferData (GLuint buffer, GLsizeiptr size, void* data, GLenum usage)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedBufferDataDelegate (System.UInt32 buffer, System.IntPtr size, IntPtr data, System.UInt32 usage);
		// void glNamedBufferStorage (GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedBufferStorageDelegate (System.UInt32 buffer, System.IntPtr size, IntPtr data, System.UInt32 flags);
		// void glNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedBufferSubDataDelegate (System.UInt32 buffer, System.IntPtr offset, System.IntPtr size, IntPtr data);
		// void glNamedFramebufferDrawBuffer (GLuint framebuffer, GLenum buf)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferDrawBufferDelegate (System.UInt32 framebuffer, System.UInt32 buf);
		// void glNamedFramebufferDrawBuffers (GLuint framebuffer, GLsizei n, GLenum* bufs)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferDrawBuffersDelegate (System.UInt32 framebuffer, System.Int32 n, IntPtr bufs);
		// void glNamedFramebufferParameteri (GLuint framebuffer, GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferParameteriDelegate (System.UInt32 framebuffer, System.UInt32 pname, System.Int32 param);
		// void glNamedFramebufferReadBuffer (GLuint framebuffer, GLenum src)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferReadBufferDelegate (System.UInt32 framebuffer, System.UInt32 src);
		// void glNamedFramebufferRenderbuffer (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferRenderbufferDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 renderbuffertarget, System.UInt32 renderbuffer);
		// void glNamedFramebufferTexture (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferTextureDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 texture, System.Int32 level);
		// void glNamedFramebufferTextureLayer (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedFramebufferTextureLayerDelegate (System.UInt32 framebuffer, System.UInt32 attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer);
		// void glNamedRenderbufferStorage (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedRenderbufferStorageDelegate (System.UInt32 renderbuffer, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glNamedRenderbufferStorageMultisample (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void NamedRenderbufferStorageMultisampleDelegate (System.UInt32 renderbuffer, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glObjectLabel (GLenum identifier, GLuint name, GLsizei length, GLchar* label)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ObjectLabelDelegate (System.UInt32 identifier, StringPtr name, System.Int32 length, StringPtr label);
		// void glObjectPtrLabel (void* ptr, GLsizei length, GLchar* label)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ObjectPtrLabelDelegate (IntPtr ptr, System.Int32 length, StringPtr label);
		// void glPatchParameterfv (GLenum pname, GLfloat* values)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PatchParameterfvDelegate (System.UInt32 pname, IntPtr values);
		// void glPatchParameteri (GLenum pname, GLint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PatchParameteriDelegate (System.UInt32 pname, System.Int32 value);
		// void glPauseTransformFeedback ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PauseTransformFeedbackDelegate ();
		// void glPixelStoref (GLenum pname, GLfloat param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PixelStorefDelegate (PixelStoreParameter pname, System.Single param);
		// void glPixelStorei (GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PixelStoreiDelegate (PixelStoreParameter pname, System.Int32 param);
		// void glPointParameterf (GLenum pname, GLfloat param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PointParameterfDelegate (System.UInt32 pname, System.Single param);
		// void glPointParameterfv (GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PointParameterfvDelegate (System.UInt32 pname, IntPtr @params);
		// void glPointParameteri (GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PointParameteriDelegate (System.UInt32 pname, System.Int32 param);
		// void glPointParameteriv (GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PointParameterivDelegate (System.UInt32 pname, IntPtr @params);
		// void glPointSize (GLfloat size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PointSizeDelegate (System.Single size);
		// void glPolygonMode (GLenum face, GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PolygonModeDelegate (MaterialFace face, PolygonMode mode);
		// void glPolygonOffset (GLfloat factor, GLfloat units)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PolygonOffsetDelegate (System.Single factor, System.Single units);
		// void glPopDebugGroup ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PopDebugGroupDelegate ();
		// void glPrimitiveRestartIndex (GLuint index)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PrimitiveRestartIndexDelegate (System.UInt32 index);
		// void glProgramBinary (GLuint program, GLenum binaryFormat, void* binary, GLsizei length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramBinaryDelegate (System.UInt32 program, System.UInt32 binaryFormat, IntPtr binary, System.Int32 length);
		// void glProgramParameteri (GLuint program, GLenum pname, GLint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramParameteriDelegate (System.UInt32 program, System.UInt32 pname, System.Int32 value);
		// void glProgramUniform1d (GLuint program, GLint location, GLdouble v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1dDelegate (System.UInt32 program, System.Int32 location, System.Double v0);
		// void glProgramUniform1dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform1f (GLuint program, GLint location, GLfloat v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1fDelegate (System.UInt32 program, System.Int32 location, System.Single v0);
		// void glProgramUniform1fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform1i (GLuint program, GLint location, GLint v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0);
		// void glProgramUniform1iv (GLuint program, GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform1ui (GLuint program, GLint location, GLuint v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0);
		// void glProgramUniform1uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform1uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform2d (GLuint program, GLint location, GLdouble v0, GLdouble v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2dDelegate (System.UInt32 program, System.Int32 location, System.Double v0, System.Double v1);
		// void glProgramUniform2dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform2f (GLuint program, GLint location, GLfloat v0, GLfloat v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1);
		// void glProgramUniform2fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform2i (GLuint program, GLint location, GLint v0, GLint v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1);
		// void glProgramUniform2iv (GLuint program, GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform2ui (GLuint program, GLint location, GLuint v0, GLuint v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1);
		// void glProgramUniform2uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform2uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform3d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3dDelegate (System.UInt32 program, System.Int32 location, System.Double v0, System.Double v1, System.Double v2);
		// void glProgramUniform3dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform3f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1, System.Single v2);
		// void glProgramUniform3fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform3i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2);
		// void glProgramUniform3iv (GLuint program, GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform3ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2);
		// void glProgramUniform3uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform3uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform4d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4dDelegate (System.UInt32 program, System.Int32 location, System.Double v0, System.Double v1, System.Double v2, System.Double v3);
		// void glProgramUniform4dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform4f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4fDelegate (System.UInt32 program, System.Int32 location, System.Single v0, System.Single v1, System.Single v2, System.Single v3);
		// void glProgramUniform4fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform4i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4iDelegate (System.UInt32 program, System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3);
		// void glProgramUniform4iv (GLuint program, GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4ivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniform4ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4uiDelegate (System.UInt32 program, System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2, System.UInt32 v3);
		// void glProgramUniform4uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniform4uivDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, IntPtr value);
		// void glProgramUniformMatrix2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix2x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2x3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix2x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2x3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix2x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2x4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix2x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix2x4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3x2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3x2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3x4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix3x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix3x4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4x2dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4x2fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4x3dvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProgramUniformMatrix4x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProgramUniformMatrix4x3fvDelegate (System.UInt32 program, System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glProvokingVertex (GLenum mode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ProvokingVertexDelegate (System.UInt32 mode);
		// void glPushDebugGroup (GLenum source, GLuint id, GLsizei length, GLchar* message)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void PushDebugGroupDelegate (StringPtr source, System.UInt32 id, System.Int32 length, StringPtr message);
		// void glQueryCounter (GLuint id, GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void QueryCounterDelegate (System.UInt32 id, System.UInt32 target);
		// void glReadBuffer (GLenum src)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ReadBufferDelegate (ReadBufferMode src);
		// void glReadnPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ReadnPixelsDelegate (System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.UInt32 format, System.UInt32 type, System.Int32 bufSize, IntPtr data);
		// void glReadPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ReadPixelsDelegate (System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr pixels);
		// void glReleaseShaderCompiler ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ReleaseShaderCompilerDelegate ();
		// void glRenderbufferStorage (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void RenderbufferStorageDelegate (System.UInt32 target, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glRenderbufferStorageMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void RenderbufferStorageMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glResumeTransformFeedback ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ResumeTransformFeedbackDelegate ();
		// void glSampleCoverage (GLfloat value, GLboolean invert)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SampleCoverageDelegate (System.Single value, Boolean invert);
		// void glSampleMaski (GLuint maskNumber, GLbitfield mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SampleMaskiDelegate (System.UInt32 maskNumber, System.UInt32 mask);
		// void glSamplerParameterf (GLuint sampler, GLenum pname, GLfloat param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameterfDelegate (System.UInt32 sampler, System.UInt32 pname, System.Single param);
		// void glSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameterfvDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr param);
		// void glSamplerParameteri (GLuint sampler, GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameteriDelegate (System.UInt32 sampler, System.UInt32 pname, System.Int32 param);
		// void glSamplerParameterIiv (GLuint sampler, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameterIivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr param);
		// void glSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameterIuivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr param);
		// void glSamplerParameteriv (GLuint sampler, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void SamplerParameterivDelegate (System.UInt32 sampler, System.UInt32 pname, IntPtr param);
		// void glScissorArrayv (GLuint first, GLsizei count, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ScissorArrayvDelegate (System.UInt32 first, System.Int32 count, IntPtr v);
		// void glScissor (GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ScissorDelegate (System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glScissorIndexed (GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ScissorIndexedDelegate (System.UInt32 index, System.Int32 left, System.Int32 bottom, System.Int32 width, System.Int32 height);
		// void glScissorIndexedv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ScissorIndexedvDelegate (System.UInt32 index, IntPtr v);
		// void glShaderBinary (GLsizei count, GLuint* shaders, GLenum binaryformat, void* binary, GLsizei length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ShaderBinaryDelegate (System.Int32 count, IntPtr shaders, System.UInt32 binaryformat, IntPtr binary, System.Int32 length);
		// void glShaderSource (GLuint shader, GLsizei count, GLchar** string, GLint* length)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ShaderSourceDelegate (System.UInt32 shader, System.Int32 count, IntPtr @string, IntPtr length);
		// void glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ShaderStorageBlockBindingDelegate (System.UInt32 program, System.UInt32 storageBlockIndex, System.UInt32 storageBlockBinding);
		// void glStencilFunc (GLenum func, GLint ref, GLuint mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilFuncDelegate (StencilFunction func, System.Int32 @ref, System.UInt32 mask);
		// void glStencilFuncSeparate (GLenum face, GLenum func, GLint ref, GLuint mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilFuncSeparateDelegate (System.UInt32 face, StencilFunction func, System.Int32 @ref, System.UInt32 mask);
		// void glStencilMask (GLuint mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilMaskDelegate (System.UInt32 mask);
		// void glStencilMaskSeparate (GLenum face, GLuint mask)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilMaskSeparateDelegate (System.UInt32 face, System.UInt32 mask);
		// void glStencilOp (GLenum fail, GLenum zfail, GLenum zpass)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilOpDelegate (StencilOp fail, StencilOp zfail, StencilOp zpass);
		// void glStencilOpSeparate (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void StencilOpSeparateDelegate (System.UInt32 face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
		// void glTexBuffer (GLenum target, GLenum internalformat, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexBufferDelegate (TextureTarget target, System.UInt32 internalformat, System.UInt32 buffer);
		// void glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexBufferRangeDelegate (System.UInt32 target, System.UInt32 internalformat, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
		// void glTexImage1D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTexImage2D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTexImage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexImage2DMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, Boolean fixedsamplelocations);
		// void glTexImage3D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTexImage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexImage3DMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedsamplelocations);
		// void glTexParameterf (GLenum target, GLenum pname, GLfloat param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameterfDelegate (TextureTarget target, TextureParameterName pname, System.Single param);
		// void glTexParameterfv (GLenum target, GLenum pname, GLfloat* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameterfvDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
		// void glTexParameteri (GLenum target, GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameteriDelegate (TextureTarget target, TextureParameterName pname, System.Int32 param);
		// void glTexParameterIiv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameterIivDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
		// void glTexParameterIuiv (GLenum target, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameterIuivDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
		// void glTexParameteriv (GLenum target, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexParameterivDelegate (TextureTarget target, TextureParameterName pname, IntPtr @params);
		// void glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexStorage1DDelegate (System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width);
		// void glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexStorage2DDelegate (System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glTexStorage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexStorage2DMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, Boolean fixedsamplelocations);
		// void glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexStorage3DDelegate (System.UInt32 target, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth);
		// void glTexStorage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexStorage3DMultisampleDelegate (System.UInt32 target, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, Boolean fixedsamplelocations);
		// void glTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexSubImage1DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexSubImage2DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TexSubImage3DDelegate (TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, PixelFormat format, PixelType type, IntPtr pixels);
		// void glTextureBarrier ()
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureBarrierDelegate ();
		// void glTextureBuffer (GLuint texture, GLenum internalformat, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureBufferDelegate (System.UInt32 texture, System.UInt32 internalformat, System.UInt32 buffer);
		// void glTextureBufferRange (GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureBufferRangeDelegate (System.UInt32 texture, System.UInt32 internalformat, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
		// void glTextureParameterf (GLuint texture, GLenum pname, GLfloat param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameterfDelegate (System.UInt32 texture, System.UInt32 pname, System.Single param);
		// void glTextureParameterfv (GLuint texture, GLenum pname, GLfloat* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameterfvDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr param);
		// void glTextureParameteri (GLuint texture, GLenum pname, GLint param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameteriDelegate (System.UInt32 texture, System.UInt32 pname, System.Int32 param);
		// void glTextureParameterIiv (GLuint texture, GLenum pname, GLint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameterIivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glTextureParameterIuiv (GLuint texture, GLenum pname, GLuint* params)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameterIuivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr @params);
		// void glTextureParameteriv (GLuint texture, GLenum pname, GLint* param)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureParameterivDelegate (System.UInt32 texture, System.UInt32 pname, IntPtr param);
		// void glTextureStorage1D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureStorage1DDelegate (System.UInt32 texture, System.Int32 levels, System.UInt32 internalformat, System.Int32 width);
		// void glTextureStorage2D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureStorage2DDelegate (System.UInt32 texture, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height);
		// void glTextureStorage2DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureStorage2DMultisampleDelegate (System.UInt32 texture, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Boolean fixedsamplelocations);
		// void glTextureStorage3D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureStorage3DDelegate (System.UInt32 texture, System.Int32 levels, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth);
		// void glTextureStorage3DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureStorage3DMultisampleDelegate (System.UInt32 texture, System.Int32 samples, System.UInt32 internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Boolean fixedsamplelocations);
		// void glTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureSubImage1DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 width, System.UInt32 format, System.UInt32 type, IntPtr pixels);
		// void glTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureSubImage2DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, System.UInt32 format, System.UInt32 type, IntPtr pixels);
		// void glTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureSubImage3DDelegate (System.UInt32 texture, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, System.UInt32 format, System.UInt32 type, IntPtr pixels);
		// void glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TextureViewDelegate (System.UInt32 texture, System.UInt32 target, System.UInt32 origtexture, System.UInt32 internalformat, System.UInt32 minlevel, System.UInt32 numlevels, System.UInt32 minlayer, System.UInt32 numlayers);
		// void glTransformFeedbackBufferBase (GLuint xfb, GLuint index, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TransformFeedbackBufferBaseDelegate (System.UInt32 xfb, System.UInt32 index, System.UInt32 buffer);
		// void glTransformFeedbackBufferRange (GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TransformFeedbackBufferRangeDelegate (System.UInt32 xfb, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size);
		// void glTransformFeedbackVaryings (GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void TransformFeedbackVaryingsDelegate (System.UInt32 program, System.Int32 count, IntPtr varyings, System.UInt32 bufferMode);
		// void glUniform1d (GLint location, GLdouble x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1dDelegate (System.Int32 location, System.Double x);
		// void glUniform1dv (GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1dvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform1f (GLint location, GLfloat v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1fDelegate (System.Int32 location, System.Single v0);
		// void glUniform1fv (GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform1i (GLint location, GLint v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1iDelegate (System.Int32 location, System.Int32 v0);
		// void glUniform1iv (GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform1ui (GLint location, GLuint v0)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1uiDelegate (System.Int32 location, System.UInt32 v0);
		// void glUniform1uiv (GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform1uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform2d (GLint location, GLdouble x, GLdouble y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2dDelegate (System.Int32 location, System.Double x, System.Double y);
		// void glUniform2dv (GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2dvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform2f (GLint location, GLfloat v0, GLfloat v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2fDelegate (System.Int32 location, System.Single v0, System.Single v1);
		// void glUniform2fv (GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform2i (GLint location, GLint v0, GLint v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1);
		// void glUniform2iv (GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform2ui (GLint location, GLuint v0, GLuint v1)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1);
		// void glUniform2uiv (GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform2uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform3d (GLint location, GLdouble x, GLdouble y, GLdouble z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3dDelegate (System.Int32 location, System.Double x, System.Double y, System.Double z);
		// void glUniform3dv (GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3dvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform3f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3fDelegate (System.Int32 location, System.Single v0, System.Single v1, System.Single v2);
		// void glUniform3fv (GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform3i (GLint location, GLint v0, GLint v1, GLint v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2);
		// void glUniform3iv (GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform3ui (GLint location, GLuint v0, GLuint v1, GLuint v2)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2);
		// void glUniform3uiv (GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform3uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform4d (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4dDelegate (System.Int32 location, System.Double x, System.Double y, System.Double z, System.Double w);
		// void glUniform4dv (GLint location, GLsizei count, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4dvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform4f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4fDelegate (System.Int32 location, System.Single v0, System.Single v1, System.Single v2, System.Single v3);
		// void glUniform4fv (GLint location, GLsizei count, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4fvDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform4i (GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4iDelegate (System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3);
		// void glUniform4iv (GLint location, GLsizei count, GLint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4ivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniform4ui (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4uiDelegate (System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2, System.UInt32 v3);
		// void glUniform4uiv (GLint location, GLsizei count, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void Uniform4uivDelegate (System.Int32 location, System.Int32 count, IntPtr value);
		// void glUniformBlockBinding (GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformBlockBindingDelegate (System.UInt32 program, System.UInt32 uniformBlockIndex, System.UInt32 uniformBlockBinding);
		// void glUniformMatrix2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix2x3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2x3dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix2x3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2x3fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix2x4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2x4dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix2x4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix2x4fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3x2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3x2dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3x2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3x2fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3x4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3x4dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix3x4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix3x4fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4x2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4x2dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4x2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4x2fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4x3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4x3dvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformMatrix4x3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformMatrix4x3fvDelegate (System.Int32 location, System.Int32 count, Boolean transpose, IntPtr value);
		// void glUniformSubroutinesuiv (GLenum shadertype, GLsizei count, GLuint* indices)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UniformSubroutinesuivDelegate (System.UInt32 shadertype, System.Int32 count, IntPtr indices);
		// GLboolean glUnmapBuffer (GLenum target)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate Boolean UnmapBufferDelegate (System.UInt32 target);
		// GLboolean glUnmapNamedBuffer (GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate System.Boolean UnmapNamedBufferDelegate (System.UInt32 buffer);
		// void glUseProgram (GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UseProgramDelegate (System.UInt32 program);
		// void glUseProgramStages (GLuint pipeline, GLbitfield stages, GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void UseProgramStagesDelegate (System.UInt32 pipeline, System.UInt32 stages, System.UInt32 program);
		// void glValidateProgram (GLuint program)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ValidateProgramDelegate (System.UInt32 program);
		// void glValidateProgramPipeline (GLuint pipeline)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ValidateProgramPipelineDelegate (System.UInt32 pipeline);
		// void glVertexArrayAttribBinding (GLuint vaobj, GLuint attribindex, GLuint bindingindex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayAttribBindingDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.UInt32 bindingindex);
		// void glVertexArrayAttribFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayAttribFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.Boolean normalized, System.UInt32 relativeoffset);
		// void glVertexArrayAttribIFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayAttribIFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
		// void glVertexArrayAttribLFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayAttribLFormatDelegate (System.UInt32 vaobj, System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
		// void glVertexArrayBindingDivisor (GLuint vaobj, GLuint bindingindex, GLuint divisor)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayBindingDivisorDelegate (System.UInt32 vaobj, System.UInt32 bindingindex, System.UInt32 divisor);
		// void glVertexArrayElementBuffer (GLuint vaobj, GLuint buffer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayElementBufferDelegate (System.UInt32 vaobj, System.UInt32 buffer);
		// void glVertexArrayVertexBuffer (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayVertexBufferDelegate (System.UInt32 vaobj, System.UInt32 bindingindex, System.UInt32 buffer, System.IntPtr offset, System.Int32 stride);
		// void glVertexArrayVertexBuffers (GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexArrayVertexBuffersDelegate (System.UInt32 vaobj, System.UInt32 first, System.Int32 count, IntPtr buffers, IntPtr offsets, IntPtr strides);
		// void glVertexAttrib1d (GLuint index, GLdouble x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1dDelegate (System.UInt32 index, System.Double x);
		// void glVertexAttrib1dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib1f (GLuint index, GLfloat x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1fDelegate (System.UInt32 index, System.Single x);
		// void glVertexAttrib1fv (GLuint index, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1fvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib1s (GLuint index, GLshort x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1sDelegate (System.UInt32 index, System.Int16 x);
		// void glVertexAttrib1sv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib1svDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib2d (GLuint index, GLdouble x, GLdouble y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2dDelegate (System.UInt32 index, System.Double x, System.Double y);
		// void glVertexAttrib2dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib2f (GLuint index, GLfloat x, GLfloat y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2fDelegate (System.UInt32 index, System.Single x, System.Single y);
		// void glVertexAttrib2fv (GLuint index, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2fvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib2s (GLuint index, GLshort x, GLshort y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y);
		// void glVertexAttrib2sv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib2svDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z);
		// void glVertexAttrib3dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib3f (GLuint index, GLfloat x, GLfloat y, GLfloat z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z);
		// void glVertexAttrib3fv (GLuint index, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3fvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib3s (GLuint index, GLshort x, GLshort y, GLshort z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z);
		// void glVertexAttrib3sv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib3svDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4bv (GLuint index, GLbyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4bvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
		// void glVertexAttrib4dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4f (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4fDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w);
		// void glVertexAttrib4fv (GLuint index, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4fvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4iv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4ivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Nbv (GLuint index, GLbyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NbvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Niv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Nsv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NsvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Nub (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NubDelegate (System.UInt32 index, System.Byte x, System.Byte y, System.Byte z, System.Byte w);
		// void glVertexAttrib4Nubv (GLuint index, GLubyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NubvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Nuiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NuivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4Nusv (GLuint index, GLushort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4NusvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4s (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4sDelegate (System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w);
		// void glVertexAttrib4sv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4svDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4ubv (GLuint index, GLubyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4ubvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4uiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4uivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttrib4usv (GLuint index, GLushort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttrib4usvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribBinding (GLuint attribindex, GLuint bindingindex)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribBindingDelegate (System.UInt32 attribindex, System.UInt32 bindingindex);
		// void glVertexAttribDivisor (GLuint index, GLuint divisor)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribDivisorDelegate (System.UInt32 index, System.UInt32 divisor);
		// void glVertexAttribFormat (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribFormatDelegate (System.UInt32 attribindex, System.Int32 size, System.UInt32 type, Boolean normalized, System.UInt32 relativeoffset);
		// void glVertexAttribI1i (GLuint index, GLint x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI1iDelegate (System.UInt32 index, System.Int32 x);
		// void glVertexAttribI1iv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI1ivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI1ui (GLuint index, GLuint x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI1uiDelegate (System.UInt32 index, System.UInt32 x);
		// void glVertexAttribI1uiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI1uivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI2i (GLuint index, GLint x, GLint y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI2iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y);
		// void glVertexAttribI2iv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI2ivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI2ui (GLuint index, GLuint x, GLuint y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI2uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y);
		// void glVertexAttribI2uiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI2uivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI3i (GLuint index, GLint x, GLint y, GLint z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI3iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z);
		// void glVertexAttribI3iv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI3ivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI3ui (GLuint index, GLuint x, GLuint y, GLuint z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI3uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z);
		// void glVertexAttribI3uiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI3uivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4bv (GLuint index, GLbyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4bvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4i (GLuint index, GLint x, GLint y, GLint z, GLint w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4iDelegate (System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w);
		// void glVertexAttribI4iv (GLuint index, GLint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4ivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4sv (GLuint index, GLshort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4svDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4ubv (GLuint index, GLubyte* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4ubvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4ui (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4uiDelegate (System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w);
		// void glVertexAttribI4uiv (GLuint index, GLuint* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4uivDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribI4usv (GLuint index, GLushort* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribI4usvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribIFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribIFormatDelegate (System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
		// void glVertexAttribIPointer (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribIPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
		// void glVertexAttribL1d (GLuint index, GLdouble x)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL1dDelegate (System.UInt32 index, System.Double x);
		// void glVertexAttribL1dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL1dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribL2d (GLuint index, GLdouble x, GLdouble y)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL2dDelegate (System.UInt32 index, System.Double x, System.Double y);
		// void glVertexAttribL2dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL2dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribL3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL3dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z);
		// void glVertexAttribL3dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL3dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribL4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL4dDelegate (System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w);
		// void glVertexAttribL4dv (GLuint index, GLdouble* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribL4dvDelegate (System.UInt32 index, IntPtr v);
		// void glVertexAttribLFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribLFormatDelegate (System.UInt32 attribindex, System.Int32 size, System.UInt32 type, System.UInt32 relativeoffset);
		// void glVertexAttribLPointer (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribLPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, System.Int32 stride, IntPtr pointer);
		// void glVertexAttribP1ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP1uiDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, System.UInt32 value);
		// void glVertexAttribP1uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP1uivDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, IntPtr value);
		// void glVertexAttribP2ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP2uiDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, System.UInt32 value);
		// void glVertexAttribP2uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP2uivDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, IntPtr value);
		// void glVertexAttribP3ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP3uiDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, System.UInt32 value);
		// void glVertexAttribP3uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP3uivDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, IntPtr value);
		// void glVertexAttribP4ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP4uiDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, System.UInt32 value);
		// void glVertexAttribP4uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribP4uivDelegate (System.UInt32 index, System.UInt32 type, Boolean normalized, IntPtr value);
		// void glVertexAttribPointer (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexAttribPointerDelegate (System.UInt32 index, System.Int32 size, System.UInt32 type, Boolean normalized, System.Int32 stride, IntPtr pointer);
		// void glVertexBindingDivisor (GLuint bindingindex, GLuint divisor)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void VertexBindingDivisorDelegate (System.UInt32 bindingindex, System.UInt32 divisor);
		// void glViewportArrayv (GLuint first, GLsizei count, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ViewportArrayvDelegate (System.UInt32 first, System.Int32 count, IntPtr v);
		// void glViewport (GLint x, GLint y, GLsizei width, GLsizei height)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ViewportDelegate (System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height);
		// void glViewportIndexedf (GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ViewportIndexedfDelegate (System.UInt32 index, System.Single x, System.Single y, System.Single w, System.Single h);
		// void glViewportIndexedfv (GLuint index, GLfloat* v)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void ViewportIndexedfvDelegate (System.UInt32 index, IntPtr v);
		// void glWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
		[SuppressUnmanagedCodeSecurity/*, UnmanagedFunctionPointer(CallingConvention.Cdecl)*/]
		public delegate void WaitSyncDelegate (System.IntPtr sync, System.UInt32 flags, System.UInt64 timeout);
		#endregion // command delegates
		#region commands
		// void glActiveShaderProgram (GLuint pipeline, GLuint program)
		public readonly ActiveShaderProgramDelegate ActiveShaderProgram;
		// void glActiveTexture (GLenum texture)
		public readonly ActiveTextureDelegate ActiveTexture;
		// void glAttachShader (GLuint program, GLuint shader)
		public readonly AttachShaderDelegate AttachShader;
		// void glBeginConditionalRender (GLuint id, GLenum mode)
		public readonly BeginConditionalRenderDelegate BeginConditionalRender;
		// void glBeginQuery (GLenum target, GLuint id)
		public readonly BeginQueryDelegate BeginQuery;
		// void glBeginQueryIndexed (GLenum target, GLuint index, GLuint id)
		public readonly BeginQueryIndexedDelegate BeginQueryIndexed;
		// void glBeginTransformFeedback (GLenum primitiveMode)
		public readonly BeginTransformFeedbackDelegate BeginTransformFeedback;
		// void glBindAttribLocation (GLuint program, GLuint index, GLchar* name)
		public readonly BindAttribLocationDelegate BindAttribLocation;
		// void glBindBufferBase (GLenum target, GLuint index, GLuint buffer)
		public readonly BindBufferBaseDelegate BindBufferBase;
		// void glBindBuffer (GLenum target, GLuint buffer)
		public readonly BindBufferDelegate BindBuffer;
		// void glBindBufferRange (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
		public readonly BindBufferRangeDelegate BindBufferRange;
		// void glBindBuffersBase (GLenum target, GLuint first, GLsizei count, GLuint* buffers)
		public readonly BindBuffersBaseDelegate BindBuffersBase;
		// void glBindBuffersRange (GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes)
		public readonly BindBuffersRangeDelegate BindBuffersRange;
		// void glBindFragDataLocation (GLuint program, GLuint color, GLchar* name)
		public readonly BindFragDataLocationDelegate BindFragDataLocation;
		// void glBindFragDataLocationIndexed (GLuint program, GLuint colorNumber, GLuint index, GLchar* name)
		public readonly BindFragDataLocationIndexedDelegate BindFragDataLocationIndexed;
		// void glBindFramebuffer (GLenum target, GLuint framebuffer)
		public readonly BindFramebufferDelegate BindFramebuffer;
		// void glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format)
		public readonly BindImageTextureDelegate BindImageTexture;
		// void glBindImageTextures (GLuint first, GLsizei count, GLuint* textures)
		public readonly BindImageTexturesDelegate BindImageTextures;
		// void glBindProgramPipeline (GLuint pipeline)
		public readonly BindProgramPipelineDelegate BindProgramPipeline;
		// void glBindRenderbuffer (GLenum target, GLuint renderbuffer)
		public readonly BindRenderbufferDelegate BindRenderbuffer;
		// void glBindSampler (GLuint unit, GLuint sampler)
		public readonly BindSamplerDelegate BindSampler;
		// void glBindSamplers (GLuint first, GLsizei count, GLuint* samplers)
		public readonly BindSamplersDelegate BindSamplers;
		// void glBindTexture (GLenum target, GLuint texture)
		public readonly BindTextureDelegate BindTexture;
		// void glBindTextures (GLuint first, GLsizei count, GLuint* textures)
		public readonly BindTexturesDelegate BindTextures;
		// void glBindTextureUnit (GLuint unit, GLuint texture)
		public readonly BindTextureUnitDelegate BindTextureUnit;
		// void glBindTransformFeedback (GLenum target, GLuint id)
		public readonly BindTransformFeedbackDelegate BindTransformFeedback;
		// void glBindVertexArray (GLuint array)
		public readonly BindVertexArrayDelegate BindVertexArray;
		// void glBindVertexBuffer (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
		public readonly BindVertexBufferDelegate BindVertexBuffer;
		// void glBindVertexBuffers (GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides)
		public readonly BindVertexBuffersDelegate BindVertexBuffers;
		// void glBlendColor (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
		public readonly BlendColorDelegate BlendColor;
		// void glBlendEquation (GLenum mode)
		public readonly BlendEquationDelegate BlendEquation;
		// void glBlendEquationi (GLuint buf, GLenum mode)
		public readonly BlendEquationiDelegate BlendEquationi;
		// void glBlendEquationSeparate (GLenum modeRGB, GLenum modeAlpha)
		public readonly BlendEquationSeparateDelegate BlendEquationSeparate;
		// void glBlendEquationSeparatei (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
		public readonly BlendEquationSeparateiDelegate BlendEquationSeparatei;
		// void glBlendFunc (GLenum sfactor, GLenum dfactor)
		public readonly BlendFuncDelegate BlendFunc;
		// void glBlendFunci (GLuint buf, GLenum src, GLenum dst)
		public readonly BlendFunciDelegate BlendFunci;
		// void glBlendFuncSeparate (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
		public readonly BlendFuncSeparateDelegate BlendFuncSeparate;
		// void glBlendFuncSeparatei (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
		public readonly BlendFuncSeparateiDelegate BlendFuncSeparatei;
		// void glBlitFramebuffer (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
		public readonly BlitFramebufferDelegate BlitFramebuffer;
		// void glBlitNamedFramebuffer (GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
		public readonly BlitNamedFramebufferDelegate BlitNamedFramebuffer;
		// void glBufferData (GLenum target, GLsizeiptr size, void* data, GLenum usage)
		public readonly BufferDataDelegate BufferData;
		// void glBufferStorage (GLenum target, GLsizeiptr size, void* data, GLbitfield flags)
		public readonly BufferStorageDelegate BufferStorage;
		// void glBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, void* data)
		public readonly BufferSubDataDelegate BufferSubData;
		// GLenum glCheckFramebufferStatus (GLenum target)
		public readonly CheckFramebufferStatusDelegate CheckFramebufferStatus;
		// GLenum glCheckNamedFramebufferStatus (GLuint framebuffer, GLenum target)
		public readonly CheckNamedFramebufferStatusDelegate CheckNamedFramebufferStatus;
		// void glClampColor (GLenum target, GLenum clamp)
		public readonly ClampColorDelegate ClampColor;
		// void glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data)
		public readonly ClearBufferDataDelegate ClearBufferData;
		// void glClearBufferfi (GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
		public readonly ClearBufferfiDelegate ClearBufferfi;
		// void glClearBufferfv (GLenum buffer, GLint drawbuffer, GLfloat* value)
		public readonly ClearBufferfvDelegate ClearBufferfv;
		// void glClearBufferiv (GLenum buffer, GLint drawbuffer, GLint* value)
		public readonly ClearBufferivDelegate ClearBufferiv;
		// void glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
		public readonly ClearBufferSubDataDelegate ClearBufferSubData;
		// void glClearBufferuiv (GLenum buffer, GLint drawbuffer, GLuint* value)
		public readonly ClearBufferuivDelegate ClearBufferuiv;
		// void glClearColor (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
		public readonly ClearColorDelegate ClearColor;
		// void glClearDepthf (GLfloat d)
		public readonly ClearDepthfDelegate ClearDepthf;
		// void glClearDepth (GLdouble depth)
		public readonly ClearDepthDelegate ClearDepth;
		// void glClear (GLbitfield mask)
		public readonly ClearDelegate Clear;
		// void glClearNamedBufferData (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data)
		public readonly ClearNamedBufferDataDelegate ClearNamedBufferData;
		// void glClearNamedBufferSubData (GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data)
		public readonly ClearNamedBufferSubDataDelegate ClearNamedBufferSubData;
		// void glClearNamedFramebufferfi (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
		public readonly ClearNamedFramebufferfiDelegate ClearNamedFramebufferfi;
		// void glClearNamedFramebufferfv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value)
		public readonly ClearNamedFramebufferfvDelegate ClearNamedFramebufferfv;
		// void glClearNamedFramebufferiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value)
		public readonly ClearNamedFramebufferivDelegate ClearNamedFramebufferiv;
		// void glClearNamedFramebufferuiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value)
		public readonly ClearNamedFramebufferuivDelegate ClearNamedFramebufferuiv;
		// void glClearStencil (GLint s)
		public readonly ClearStencilDelegate ClearStencil;
		// void glClearTexImage (GLuint texture, GLint level, GLenum format, GLenum type, void* data)
		public readonly ClearTexImageDelegate ClearTexImage;
		// void glClearTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data)
		public readonly ClearTexSubImageDelegate ClearTexSubImage;
		// GLenum glClientWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
		public readonly ClientWaitSyncDelegate ClientWaitSync;
		// void glClipControl (GLenum origin, GLenum depth)
		public readonly ClipControlDelegate ClipControl;
		// void glColorMask (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
		public readonly ColorMaskDelegate ColorMask;
		// void glColorMaski (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
		public readonly ColorMaskiDelegate ColorMaski;
		// void glCompileShader (GLuint shader)
		public readonly CompileShaderDelegate CompileShader;
		// void glCompressedTexImage1D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
		public readonly CompressedTexImage1DDelegate CompressedTexImage1D;
		// void glCompressedTexImage2D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
		public readonly CompressedTexImage2DDelegate CompressedTexImage2D;
		// void glCompressedTexImage3D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
		public readonly CompressedTexImage3DDelegate CompressedTexImage3D;
		// void glCompressedTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTexSubImage1DDelegate CompressedTexSubImage1D;
		// void glCompressedTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTexSubImage2DDelegate CompressedTexSubImage2D;
		// void glCompressedTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTexSubImage3DDelegate CompressedTexSubImage3D;
		// void glCompressedTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTextureSubImage1DDelegate CompressedTextureSubImage1D;
		// void glCompressedTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTextureSubImage2DDelegate CompressedTextureSubImage2D;
		// void glCompressedTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data)
		public readonly CompressedTextureSubImage3DDelegate CompressedTextureSubImage3D;
		// void glCopyBufferSubData (GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
		public readonly CopyBufferSubDataDelegate CopyBufferSubData;
		// void glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)
		public readonly CopyImageSubDataDelegate CopyImageSubData;
		// void glCopyNamedBufferSubData (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
		public readonly CopyNamedBufferSubDataDelegate CopyNamedBufferSubData;
		// void glCopyTexImage1D (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
		public readonly CopyTexImage1DDelegate CopyTexImage1D;
		// void glCopyTexImage2D (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
		public readonly CopyTexImage2DDelegate CopyTexImage2D;
		// void glCopyTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
		public readonly CopyTexSubImage1DDelegate CopyTexSubImage1D;
		// void glCopyTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly CopyTexSubImage2DDelegate CopyTexSubImage2D;
		// void glCopyTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly CopyTexSubImage3DDelegate CopyTexSubImage3D;
		// void glCopyTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
		public readonly CopyTextureSubImage1DDelegate CopyTextureSubImage1D;
		// void glCopyTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly CopyTextureSubImage2DDelegate CopyTextureSubImage2D;
		// void glCopyTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly CopyTextureSubImage3DDelegate CopyTextureSubImage3D;
		// void glCreateBuffers (GLsizei n, GLuint* buffers)
		public readonly CreateBuffersDelegate CreateBuffers;
		// void glCreateFramebuffers (GLsizei n, GLuint* framebuffers)
		public readonly CreateFramebuffersDelegate CreateFramebuffers;
		// GLuint glCreateProgram ()
		public readonly CreateProgramDelegate CreateProgram;
		// void glCreateProgramPipelines (GLsizei n, GLuint* pipelines)
		public readonly CreateProgramPipelinesDelegate CreateProgramPipelines;
		// void glCreateQueries (GLenum target, GLsizei n, GLuint* ids)
		public readonly CreateQueriesDelegate CreateQueries;
		// void glCreateRenderbuffers (GLsizei n, GLuint* renderbuffers)
		public readonly CreateRenderbuffersDelegate CreateRenderbuffers;
		// void glCreateSamplers (GLsizei n, GLuint* samplers)
		public readonly CreateSamplersDelegate CreateSamplers;
		// GLuint glCreateShader (GLenum type)
		public readonly CreateShaderDelegate CreateShader;
		// GLuint glCreateShaderProgramv (GLenum type, GLsizei count, GLchar** strings)
		public readonly CreateShaderProgramvDelegate CreateShaderProgramv;
		// void glCreateTextures (GLenum target, GLsizei n, GLuint* textures)
		public readonly CreateTexturesDelegate CreateTextures;
		// void glCreateTransformFeedbacks (GLsizei n, GLuint* ids)
		public readonly CreateTransformFeedbacksDelegate CreateTransformFeedbacks;
		// void glCreateVertexArrays (GLsizei n, GLuint* arrays)
		public readonly CreateVertexArraysDelegate CreateVertexArrays;
		// void glCullFace (GLenum mode)
		public readonly CullFaceDelegate CullFace;
		// void glDebugMessageCallback (GLDEBUGPROC callback, void* userParam)
		public readonly DebugMessageCallbackDelegate DebugMessageCallback;
		// void glDebugMessageControl (GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled)
		public readonly DebugMessageControlDelegate DebugMessageControl;
		// void glDebugMessageInsert (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, GLchar* buf)
		public readonly DebugMessageInsertDelegate DebugMessageInsert;
		// void glDeleteBuffers (GLsizei n, GLuint* buffers)
		public readonly DeleteBuffersDelegate DeleteBuffers;
		// void glDeleteFramebuffers (GLsizei n, GLuint* framebuffers)
		public readonly DeleteFramebuffersDelegate DeleteFramebuffers;
		// void glDeleteProgram (GLuint program)
		public readonly DeleteProgramDelegate DeleteProgram;
		// void glDeleteProgramPipelines (GLsizei n, GLuint* pipelines)
		public readonly DeleteProgramPipelinesDelegate DeleteProgramPipelines;
		// void glDeleteQueries (GLsizei n, GLuint* ids)
		public readonly DeleteQueriesDelegate DeleteQueries;
		// void glDeleteRenderbuffers (GLsizei n, GLuint* renderbuffers)
		public readonly DeleteRenderbuffersDelegate DeleteRenderbuffers;
		// void glDeleteSamplers (GLsizei count, GLuint* samplers)
		public readonly DeleteSamplersDelegate DeleteSamplers;
		// void glDeleteShader (GLuint shader)
		public readonly DeleteShaderDelegate DeleteShader;
		// void glDeleteSync (GLsync sync)
		public readonly DeleteSyncDelegate DeleteSync;
		// void glDeleteTextures (GLsizei n, GLuint* textures)
		public readonly DeleteTexturesDelegate DeleteTextures;
		// void glDeleteTransformFeedbacks (GLsizei n, GLuint* ids)
		public readonly DeleteTransformFeedbacksDelegate DeleteTransformFeedbacks;
		// void glDeleteVertexArrays (GLsizei n, GLuint* arrays)
		public readonly DeleteVertexArraysDelegate DeleteVertexArrays;
		// void glDepthFunc (GLenum func)
		public readonly DepthFuncDelegate DepthFunc;
		// void glDepthMask (GLboolean flag)
		public readonly DepthMaskDelegate DepthMask;
		// void glDepthRangeArrayv (GLuint first, GLsizei count, GLdouble* v)
		public readonly DepthRangeArrayvDelegate DepthRangeArrayv;
		// void glDepthRangef (GLfloat n, GLfloat f)
		public readonly DepthRangefDelegate DepthRangef;
		// void glDepthRange (GLdouble near, GLdouble far)
		public readonly DepthRangeDelegate DepthRange;
		// void glDepthRangeIndexed (GLuint index, GLdouble n, GLdouble f)
		public readonly DepthRangeIndexedDelegate DepthRangeIndexed;
		// void glDetachShader (GLuint program, GLuint shader)
		public readonly DetachShaderDelegate DetachShader;
		// void glDisable (GLenum cap)
		public readonly DisableDelegate Disable;
		// void glDisablei (GLenum target, GLuint index)
		public readonly DisableiDelegate Disablei;
		// void glDisableVertexArrayAttrib (GLuint vaobj, GLuint index)
		public readonly DisableVertexArrayAttribDelegate DisableVertexArrayAttrib;
		// void glDisableVertexAttribArray (GLuint index)
		public readonly DisableVertexAttribArrayDelegate DisableVertexAttribArray;
		// void glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z)
		public readonly DispatchComputeDelegate DispatchCompute;
		// void glDispatchComputeIndirect (GLintptr indirect)
		public readonly DispatchComputeIndirectDelegate DispatchComputeIndirect;
		// void glDrawArrays (GLenum mode, GLint first, GLsizei count)
		public readonly DrawArraysDelegate DrawArrays;
		// void glDrawArraysIndirect (GLenum mode, void* indirect)
		public readonly DrawArraysIndirectDelegate DrawArraysIndirect;
		// void glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance)
		public readonly DrawArraysInstancedBaseInstanceDelegate DrawArraysInstancedBaseInstance;
		// void glDrawArraysInstanced (GLenum mode, GLint first, GLsizei count, GLsizei instancecount)
		public readonly DrawArraysInstancedDelegate DrawArraysInstanced;
		// void glDrawBuffer (GLenum buf)
		public readonly DrawBufferDelegate DrawBuffer;
		// void glDrawBuffers (GLsizei n, GLenum* bufs)
		public readonly DrawBuffersDelegate DrawBuffers;
		// void glDrawElementsBaseVertex (GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex)
		public readonly DrawElementsBaseVertexDelegate DrawElementsBaseVertex;
		// void glDrawElements (GLenum mode, GLsizei count, GLenum type, void* indices)
		public readonly DrawElementsDelegate DrawElements;
		// void glDrawElementsIndirect (GLenum mode, GLenum type, void* indirect)
		public readonly DrawElementsIndirectDelegate DrawElementsIndirect;
		// void glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLuint baseinstance)
		public readonly DrawElementsInstancedBaseInstanceDelegate DrawElementsInstancedBaseInstance;
		// void glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance)
		public readonly DrawElementsInstancedBaseVertexBaseInstanceDelegate DrawElementsInstancedBaseVertexBaseInstance;
		// void glDrawElementsInstancedBaseVertex (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount, GLint basevertex)
		public readonly DrawElementsInstancedBaseVertexDelegate DrawElementsInstancedBaseVertex;
		// void glDrawElementsInstanced (GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount)
		public readonly DrawElementsInstancedDelegate DrawElementsInstanced;
		// void glDrawRangeElementsBaseVertex (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex)
		public readonly DrawRangeElementsBaseVertexDelegate DrawRangeElementsBaseVertex;
		// void glDrawRangeElements (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices)
		public readonly DrawRangeElementsDelegate DrawRangeElements;
		// void glDrawTransformFeedback (GLenum mode, GLuint id)
		public readonly DrawTransformFeedbackDelegate DrawTransformFeedback;
		// void glDrawTransformFeedbackInstanced (GLenum mode, GLuint id, GLsizei instancecount)
		public readonly DrawTransformFeedbackInstancedDelegate DrawTransformFeedbackInstanced;
		// void glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream)
		public readonly DrawTransformFeedbackStreamDelegate DrawTransformFeedbackStream;
		// void glDrawTransformFeedbackStreamInstanced (GLenum mode, GLuint id, GLuint stream, GLsizei instancecount)
		public readonly DrawTransformFeedbackStreamInstancedDelegate DrawTransformFeedbackStreamInstanced;
		// void glEnable (GLenum cap)
		public readonly EnableDelegate Enable;
		// void glEnablei (GLenum target, GLuint index)
		public readonly EnableiDelegate Enablei;
		// void glEnableVertexArrayAttrib (GLuint vaobj, GLuint index)
		public readonly EnableVertexArrayAttribDelegate EnableVertexArrayAttrib;
		// void glEnableVertexAttribArray (GLuint index)
		public readonly EnableVertexAttribArrayDelegate EnableVertexAttribArray;
		// void glEndConditionalRender ()
		public readonly EndConditionalRenderDelegate EndConditionalRender;
		// void glEndQuery (GLenum target)
		public readonly EndQueryDelegate EndQuery;
		// void glEndQueryIndexed (GLenum target, GLuint index)
		public readonly EndQueryIndexedDelegate EndQueryIndexed;
		// void glEndTransformFeedback ()
		public readonly EndTransformFeedbackDelegate EndTransformFeedback;
		// GLsync glFenceSync (GLenum condition, GLbitfield flags)
		public readonly FenceSyncDelegate FenceSync;
		// void glFinish ()
		public readonly FinishDelegate Finish;
		// void glFlush ()
		public readonly FlushDelegate Flush;
		// void glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length)
		public readonly FlushMappedBufferRangeDelegate FlushMappedBufferRange;
		// void glFlushMappedNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length)
		public readonly FlushMappedNamedBufferRangeDelegate FlushMappedNamedBufferRange;
		// void glFramebufferParameteri (GLenum target, GLenum pname, GLint param)
		public readonly FramebufferParameteriDelegate FramebufferParameteri;
		// void glFramebufferRenderbuffer (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
		public readonly FramebufferRenderbufferDelegate FramebufferRenderbuffer;
		// void glFramebufferTexture1D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
		public readonly FramebufferTexture1DDelegate FramebufferTexture1D;
		// void glFramebufferTexture2D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
		public readonly FramebufferTexture2DDelegate FramebufferTexture2D;
		// void glFramebufferTexture3D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
		public readonly FramebufferTexture3DDelegate FramebufferTexture3D;
		// void glFramebufferTexture (GLenum target, GLenum attachment, GLuint texture, GLint level)
		public readonly FramebufferTextureDelegate FramebufferTexture;
		// void glFramebufferTextureLayer (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
		public readonly FramebufferTextureLayerDelegate FramebufferTextureLayer;
		// void glFrontFace (GLenum mode)
		public readonly FrontFaceDelegate FrontFace;
		// void glGenBuffers (GLsizei n, GLuint* buffers)
		public readonly GenBuffersDelegate GenBuffers;
		// void glGenerateMipmap (GLenum target)
		public readonly GenerateMipmapDelegate GenerateMipmap;
		// void glGenerateTextureMipmap (GLuint texture)
		public readonly GenerateTextureMipmapDelegate GenerateTextureMipmap;
		// void glGenFramebuffers (GLsizei n, GLuint* framebuffers)
		public readonly GenFramebuffersDelegate GenFramebuffers;
		// void glGenProgramPipelines (GLsizei n, GLuint* pipelines)
		public readonly GenProgramPipelinesDelegate GenProgramPipelines;
		// void glGenQueries (GLsizei n, GLuint* ids)
		public readonly GenQueriesDelegate GenQueries;
		// void glGenRenderbuffers (GLsizei n, GLuint* renderbuffers)
		public readonly GenRenderbuffersDelegate GenRenderbuffers;
		// void glGenSamplers (GLsizei count, GLuint* samplers)
		public readonly GenSamplersDelegate GenSamplers;
		// void glGenTextures (GLsizei n, GLuint* textures)
		public readonly GenTexturesDelegate GenTextures;
		// void glGenTransformFeedbacks (GLsizei n, GLuint* ids)
		public readonly GenTransformFeedbacksDelegate GenTransformFeedbacks;
		// void glGenVertexArrays (GLsizei n, GLuint* arrays)
		public readonly GenVertexArraysDelegate GenVertexArrays;
		// void glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint* params)
		public readonly GetActiveAtomicCounterBufferivDelegate GetActiveAtomicCounterBufferiv;
		// void glGetActiveAttrib (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)
		public readonly GetActiveAttribDelegate GetActiveAttrib;
		// void glGetActiveSubroutineName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name)
		public readonly GetActiveSubroutineNameDelegate GetActiveSubroutineName;
		// void glGetActiveSubroutineUniformiv (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values)
		public readonly GetActiveSubroutineUniformivDelegate GetActiveSubroutineUniformiv;
		// void glGetActiveSubroutineUniformName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name)
		public readonly GetActiveSubroutineUniformNameDelegate GetActiveSubroutineUniformName;
		// void glGetActiveUniformBlockiv (GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params)
		public readonly GetActiveUniformBlockivDelegate GetActiveUniformBlockiv;
		// void glGetActiveUniformBlockName (GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName)
		public readonly GetActiveUniformBlockNameDelegate GetActiveUniformBlockName;
		// void glGetActiveUniform (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name)
		public readonly GetActiveUniformDelegate GetActiveUniform;
		// void glGetActiveUniformName (GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName)
		public readonly GetActiveUniformNameDelegate GetActiveUniformName;
		// void glGetActiveUniformsiv (GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params)
		public readonly GetActiveUniformsivDelegate GetActiveUniformsiv;
		// void glGetAttachedShaders (GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders)
		public readonly GetAttachedShadersDelegate GetAttachedShaders;
		// GLint glGetAttribLocation (GLuint program, GLchar* name)
		public readonly GetAttribLocationDelegate GetAttribLocation;
		// void glGetBooleani_v (GLenum target, GLuint index, GLboolean* data)
		public readonly GetBooleani_vDelegate GetBooleani_v;
		// void glGetBooleanv (GLenum pname, GLboolean* data)
		public readonly GetBooleanvDelegate GetBooleanv;
		// void glGetBufferParameteri64v (GLenum target, GLenum pname, GLint64* params)
		public readonly GetBufferParameteri64vDelegate GetBufferParameteri64v;
		// void glGetBufferParameteriv (GLenum target, GLenum pname, GLint* params)
		public readonly GetBufferParameterivDelegate GetBufferParameteriv;
		// void glGetBufferPointerv (GLenum target, GLenum pname, void** params)
		public readonly GetBufferPointervDelegate GetBufferPointerv;
		// void glGetBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, void* data)
		public readonly GetBufferSubDataDelegate GetBufferSubData;
		// void glGetCompressedTexImage (GLenum target, GLint level, void* img)
		public readonly GetCompressedTexImageDelegate GetCompressedTexImage;
		// void glGetCompressedTextureImage (GLuint texture, GLint level, GLsizei bufSize, void* pixels)
		public readonly GetCompressedTextureImageDelegate GetCompressedTextureImage;
		// void glGetCompressedTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void* pixels)
		public readonly GetCompressedTextureSubImageDelegate GetCompressedTextureSubImage;
		// GLuint glGetDebugMessageLog (GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog)
		public readonly GetDebugMessageLogDelegate GetDebugMessageLog;
		// void glGetDoublei_v (GLenum target, GLuint index, GLdouble* data)
		public readonly GetDoublei_vDelegate GetDoublei_v;
		// void glGetDoublev (GLenum pname, GLdouble* data)
		public readonly GetDoublevDelegate GetDoublev;
		// GLenum glGetError ()
		public readonly GetErrorDelegate GetError;
		// void glGetFloati_v (GLenum target, GLuint index, GLfloat* data)
		public readonly GetFloati_vDelegate GetFloati_v;
		// void glGetFloatv (GLenum pname, GLfloat* data)
		public readonly GetFloatvDelegate GetFloatv;
		// GLint glGetFragDataIndex (GLuint program, GLchar* name)
		public readonly GetFragDataIndexDelegate GetFragDataIndex;
		// GLint glGetFragDataLocation (GLuint program, GLchar* name)
		public readonly GetFragDataLocationDelegate GetFragDataLocation;
		// void glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, GLint* params)
		public readonly GetFramebufferAttachmentParameterivDelegate GetFramebufferAttachmentParameteriv;
		// void glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint* params)
		public readonly GetFramebufferParameterivDelegate GetFramebufferParameteriv;
		// GLenum glGetGraphicsResetStatus ()
		public readonly GetGraphicsResetStatusDelegate GetGraphicsResetStatus;
		// void glGetInteger64i_v (GLenum target, GLuint index, GLint64* data)
		public readonly GetInteger64i_vDelegate GetInteger64i_v;
		// void glGetInteger64v (GLenum pname, GLint64* data)
		public readonly GetInteger64vDelegate GetInteger64v;
		// void glGetIntegeri_v (GLenum target, GLuint index, GLint* data)
		public readonly GetIntegeri_vDelegate GetIntegeri_v;
		// void glGetIntegerv (GLenum pname, GLint* data)
		public readonly GetIntegervDelegate GetIntegerv;
		// void glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64* params)
		public readonly GetInternalformati64vDelegate GetInternalformati64v;
		// void glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint* params)
		public readonly GetInternalformativDelegate GetInternalformativ;
		// void glGetMultisamplefv (GLenum pname, GLuint index, GLfloat* val)
		public readonly GetMultisamplefvDelegate GetMultisamplefv;
		// void glGetNamedBufferParameteri64v (GLuint buffer, GLenum pname, GLint64* params)
		public readonly GetNamedBufferParameteri64vDelegate GetNamedBufferParameteri64v;
		// void glGetNamedBufferParameteriv (GLuint buffer, GLenum pname, GLint* params)
		public readonly GetNamedBufferParameterivDelegate GetNamedBufferParameteriv;
		// void glGetNamedBufferPointerv (GLuint buffer, GLenum pname, void** params)
		public readonly GetNamedBufferPointervDelegate GetNamedBufferPointerv;
		// void glGetNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
		public readonly GetNamedBufferSubDataDelegate GetNamedBufferSubData;
		// void glGetNamedFramebufferAttachmentParameteriv (GLuint framebuffer, GLenum attachment, GLenum pname, GLint* params)
		public readonly GetNamedFramebufferAttachmentParameterivDelegate GetNamedFramebufferAttachmentParameteriv;
		// void glGetNamedFramebufferParameteriv (GLuint framebuffer, GLenum pname, GLint* param)
		public readonly GetNamedFramebufferParameterivDelegate GetNamedFramebufferParameteriv;
		// void glGetNamedRenderbufferParameteriv (GLuint renderbuffer, GLenum pname, GLint* params)
		public readonly GetNamedRenderbufferParameterivDelegate GetNamedRenderbufferParameteriv;
		// void glGetnCompressedTexImage (GLenum target, GLint lod, GLsizei bufSize, void* pixels)
		public readonly GetnCompressedTexImageDelegate GetnCompressedTexImage;
		// void glGetnTexImage (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		public readonly GetnTexImageDelegate GetnTexImage;
		// void glGetnUniformdv (GLuint program, GLint location, GLsizei bufSize, GLdouble* params)
		public readonly GetnUniformdvDelegate GetnUniformdv;
		// void glGetnUniformfv (GLuint program, GLint location, GLsizei bufSize, GLfloat* params)
		public readonly GetnUniformfvDelegate GetnUniformfv;
		// void glGetnUniformiv (GLuint program, GLint location, GLsizei bufSize, GLint* params)
		public readonly GetnUniformivDelegate GetnUniformiv;
		// void glGetnUniformuiv (GLuint program, GLint location, GLsizei bufSize, GLuint* params)
		public readonly GetnUniformuivDelegate GetnUniformuiv;
		// void glGetObjectLabel (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label)
		public readonly GetObjectLabelDelegate GetObjectLabel;
		// void glGetObjectPtrLabel (void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label)
		public readonly GetObjectPtrLabelDelegate GetObjectPtrLabel;
		// void glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary)
		public readonly GetProgramBinaryDelegate GetProgramBinary;
		// void glGetProgramInfoLog (GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		public readonly GetProgramInfoLogDelegate GetProgramInfoLog;
		// void glGetProgramInterfaceiv (GLuint program, GLenum programInterface, GLenum pname, GLint* params)
		public readonly GetProgramInterfaceivDelegate GetProgramInterfaceiv;
		// void glGetProgramiv (GLuint program, GLenum pname, GLint* params)
		public readonly GetProgramivDelegate GetProgramiv;
		// void glGetProgramPipelineInfoLog (GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		public readonly GetProgramPipelineInfoLogDelegate GetProgramPipelineInfoLog;
		// void glGetProgramPipelineiv (GLuint pipeline, GLenum pname, GLint* params)
		public readonly GetProgramPipelineivDelegate GetProgramPipelineiv;
		// GLuint glGetProgramResourceIndex (GLuint program, GLenum programInterface, GLchar* name)
		public readonly GetProgramResourceIndexDelegate GetProgramResourceIndex;
		// void glGetProgramResourceiv (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLint* params)
		public readonly GetProgramResourceivDelegate GetProgramResourceiv;
		// GLint glGetProgramResourceLocation (GLuint program, GLenum programInterface, GLchar* name)
		public readonly GetProgramResourceLocationDelegate GetProgramResourceLocation;
		// GLint glGetProgramResourceLocationIndex (GLuint program, GLenum programInterface, GLchar* name)
		public readonly GetProgramResourceLocationIndexDelegate GetProgramResourceLocationIndex;
		// void glGetProgramResourceName (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)
		public readonly GetProgramResourceNameDelegate GetProgramResourceName;
		// void glGetProgramStageiv (GLuint program, GLenum shadertype, GLenum pname, GLint* values)
		public readonly GetProgramStageivDelegate GetProgramStageiv;
		// void glGetQueryBufferObjecti64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		public readonly GetQueryBufferObjecti64vDelegate GetQueryBufferObjecti64v;
		// void glGetQueryBufferObjectiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		public readonly GetQueryBufferObjectivDelegate GetQueryBufferObjectiv;
		// void glGetQueryBufferObjectui64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		public readonly GetQueryBufferObjectui64vDelegate GetQueryBufferObjectui64v;
		// void glGetQueryBufferObjectuiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
		public readonly GetQueryBufferObjectuivDelegate GetQueryBufferObjectuiv;
		// void glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint* params)
		public readonly GetQueryIndexedivDelegate GetQueryIndexediv;
		// void glGetQueryiv (GLenum target, GLenum pname, GLint* params)
		public readonly GetQueryivDelegate GetQueryiv;
		// void glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64* params)
		public readonly GetQueryObjecti64vDelegate GetQueryObjecti64v;
		// void glGetQueryObjectiv (GLuint id, GLenum pname, GLint* params)
		public readonly GetQueryObjectivDelegate GetQueryObjectiv;
		// void glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64* params)
		public readonly GetQueryObjectui64vDelegate GetQueryObjectui64v;
		// void glGetQueryObjectuiv (GLuint id, GLenum pname, GLuint* params)
		public readonly GetQueryObjectuivDelegate GetQueryObjectuiv;
		// void glGetRenderbufferParameteriv (GLenum target, GLenum pname, GLint* params)
		public readonly GetRenderbufferParameterivDelegate GetRenderbufferParameteriv;
		// void glGetSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat* params)
		public readonly GetSamplerParameterfvDelegate GetSamplerParameterfv;
		// void glGetSamplerParameterIiv (GLuint sampler, GLenum pname, GLint* params)
		public readonly GetSamplerParameterIivDelegate GetSamplerParameterIiv;
		// void glGetSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint* params)
		public readonly GetSamplerParameterIuivDelegate GetSamplerParameterIuiv;
		// void glGetSamplerParameteriv (GLuint sampler, GLenum pname, GLint* params)
		public readonly GetSamplerParameterivDelegate GetSamplerParameteriv;
		// void glGetShaderInfoLog (GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog)
		public readonly GetShaderInfoLogDelegate GetShaderInfoLog;
		// void glGetShaderiv (GLuint shader, GLenum pname, GLint* params)
		public readonly GetShaderivDelegate GetShaderiv;
		// void glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision)
		public readonly GetShaderPrecisionFormatDelegate GetShaderPrecisionFormat;
		// void glGetShaderSource (GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source)
		public readonly GetShaderSourceDelegate GetShaderSource;
		// GLubyte* glGetString (GLenum name)
		public readonly GetStringDelegate GetString;
		// GLubyte* glGetStringi (GLenum name, GLuint index)
		public readonly GetStringiDelegate GetStringi;
		// GLuint glGetSubroutineIndex (GLuint program, GLenum shadertype, GLchar* name)
		public readonly GetSubroutineIndexDelegate GetSubroutineIndex;
		// GLint glGetSubroutineUniformLocation (GLuint program, GLenum shadertype, GLchar* name)
		public readonly GetSubroutineUniformLocationDelegate GetSubroutineUniformLocation;
		// void glGetSynciv (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values)
		public readonly GetSyncivDelegate GetSynciv;
		// void glGetTexImage (GLenum target, GLint level, GLenum format, GLenum type, void* pixels)
		public readonly GetTexImageDelegate GetTexImage;
		// void glGetTexLevelParameterfv (GLenum target, GLint level, GLenum pname, GLfloat* params)
		public readonly GetTexLevelParameterfvDelegate GetTexLevelParameterfv;
		// void glGetTexLevelParameteriv (GLenum target, GLint level, GLenum pname, GLint* params)
		public readonly GetTexLevelParameterivDelegate GetTexLevelParameteriv;
		// void glGetTexParameterfv (GLenum target, GLenum pname, GLfloat* params)
		public readonly GetTexParameterfvDelegate GetTexParameterfv;
		// void glGetTexParameterIiv (GLenum target, GLenum pname, GLint* params)
		public readonly GetTexParameterIivDelegate GetTexParameterIiv;
		// void glGetTexParameterIuiv (GLenum target, GLenum pname, GLuint* params)
		public readonly GetTexParameterIuivDelegate GetTexParameterIuiv;
		// void glGetTexParameteriv (GLenum target, GLenum pname, GLint* params)
		public readonly GetTexParameterivDelegate GetTexParameteriv;
		// void glGetTextureImage (GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		public readonly GetTextureImageDelegate GetTextureImage;
		// void glGetTextureLevelParameterfv (GLuint texture, GLint level, GLenum pname, GLfloat* params)
		public readonly GetTextureLevelParameterfvDelegate GetTextureLevelParameterfv;
		// void glGetTextureLevelParameteriv (GLuint texture, GLint level, GLenum pname, GLint* params)
		public readonly GetTextureLevelParameterivDelegate GetTextureLevelParameteriv;
		// void glGetTextureParameterfv (GLuint texture, GLenum pname, GLfloat* params)
		public readonly GetTextureParameterfvDelegate GetTextureParameterfv;
		// void glGetTextureParameterIiv (GLuint texture, GLenum pname, GLint* params)
		public readonly GetTextureParameterIivDelegate GetTextureParameterIiv;
		// void glGetTextureParameterIuiv (GLuint texture, GLenum pname, GLuint* params)
		public readonly GetTextureParameterIuivDelegate GetTextureParameterIuiv;
		// void glGetTextureParameteriv (GLuint texture, GLenum pname, GLint* params)
		public readonly GetTextureParameterivDelegate GetTextureParameteriv;
		// void glGetTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void* pixels)
		public readonly GetTextureSubImageDelegate GetTextureSubImage;
		// void glGetTransformFeedbacki_v (GLuint xfb, GLenum pname, GLuint index, GLint* param)
		public readonly GetTransformFeedbacki_vDelegate GetTransformFeedbacki_v;
		// void glGetTransformFeedbacki64_v (GLuint xfb, GLenum pname, GLuint index, GLint64* param)
		public readonly GetTransformFeedbacki64_vDelegate GetTransformFeedbacki64_v;
		// void glGetTransformFeedbackiv (GLuint xfb, GLenum pname, GLint* param)
		public readonly GetTransformFeedbackivDelegate GetTransformFeedbackiv;
		// void glGetTransformFeedbackVarying (GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)
		public readonly GetTransformFeedbackVaryingDelegate GetTransformFeedbackVarying;
		// GLuint glGetUniformBlockIndex (GLuint program, GLchar* uniformBlockName)
		public readonly GetUniformBlockIndexDelegate GetUniformBlockIndex;
		// void glGetUniformdv (GLuint program, GLint location, GLdouble* params)
		public readonly GetUniformdvDelegate GetUniformdv;
		// void glGetUniformfv (GLuint program, GLint location, GLfloat* params)
		public readonly GetUniformfvDelegate GetUniformfv;
		// void glGetUniformIndices (GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices)
		public readonly GetUniformIndicesDelegate GetUniformIndices;
		// void glGetUniformiv (GLuint program, GLint location, GLint* params)
		public readonly GetUniformivDelegate GetUniformiv;
		// GLint glGetUniformLocation (GLuint program, GLchar* name)
		public readonly GetUniformLocationDelegate GetUniformLocation;
		// void glGetUniformSubroutineuiv (GLenum shadertype, GLint location, GLuint* params)
		public readonly GetUniformSubroutineuivDelegate GetUniformSubroutineuiv;
		// void glGetUniformuiv (GLuint program, GLint location, GLuint* params)
		public readonly GetUniformuivDelegate GetUniformuiv;
		// void glGetVertexArrayIndexed64iv (GLuint vaobj, GLuint index, GLenum pname, GLint64* param)
		public readonly GetVertexArrayIndexed64ivDelegate GetVertexArrayIndexed64iv;
		// void glGetVertexArrayIndexediv (GLuint vaobj, GLuint index, GLenum pname, GLint* param)
		public readonly GetVertexArrayIndexedivDelegate GetVertexArrayIndexediv;
		// void glGetVertexArrayiv (GLuint vaobj, GLenum pname, GLint* param)
		public readonly GetVertexArrayivDelegate GetVertexArrayiv;
		// void glGetVertexAttribdv (GLuint index, GLenum pname, GLdouble* params)
		public readonly GetVertexAttribdvDelegate GetVertexAttribdv;
		// void glGetVertexAttribfv (GLuint index, GLenum pname, GLfloat* params)
		public readonly GetVertexAttribfvDelegate GetVertexAttribfv;
		// void glGetVertexAttribIiv (GLuint index, GLenum pname, GLint* params)
		public readonly GetVertexAttribIivDelegate GetVertexAttribIiv;
		// void glGetVertexAttribIuiv (GLuint index, GLenum pname, GLuint* params)
		public readonly GetVertexAttribIuivDelegate GetVertexAttribIuiv;
		// void glGetVertexAttribiv (GLuint index, GLenum pname, GLint* params)
		public readonly GetVertexAttribivDelegate GetVertexAttribiv;
		// void glGetVertexAttribLdv (GLuint index, GLenum pname, GLdouble* params)
		public readonly GetVertexAttribLdvDelegate GetVertexAttribLdv;
		// void glGetVertexAttribPointerv (GLuint index, GLenum pname, void** pointer)
		public readonly GetVertexAttribPointervDelegate GetVertexAttribPointerv;
		// void glHint (GLenum target, GLenum mode)
		public readonly HintDelegate Hint;
		// void glInvalidateBufferData (GLuint buffer)
		public readonly InvalidateBufferDataDelegate InvalidateBufferData;
		// void glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length)
		public readonly InvalidateBufferSubDataDelegate InvalidateBufferSubData;
		// void glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, GLenum* attachments)
		public readonly InvalidateFramebufferDelegate InvalidateFramebuffer;
		// void glInvalidateNamedFramebufferData (GLuint framebuffer, GLsizei numAttachments, GLenum* attachments)
		public readonly InvalidateNamedFramebufferDataDelegate InvalidateNamedFramebufferData;
		// void glInvalidateNamedFramebufferSubData (GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly InvalidateNamedFramebufferSubDataDelegate InvalidateNamedFramebufferSubData;
		// void glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly InvalidateSubFramebufferDelegate InvalidateSubFramebuffer;
		// void glInvalidateTexImage (GLuint texture, GLint level)
		public readonly InvalidateTexImageDelegate InvalidateTexImage;
		// void glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth)
		public readonly InvalidateTexSubImageDelegate InvalidateTexSubImage;
		// GLboolean glIsBuffer (GLuint buffer)
		public readonly IsBufferDelegate IsBuffer;
		// GLboolean glIsEnabled (GLenum cap)
		public readonly IsEnabledDelegate IsEnabled;
		// GLboolean glIsEnabledi (GLenum target, GLuint index)
		public readonly IsEnablediDelegate IsEnabledi;
		// GLboolean glIsFramebuffer (GLuint framebuffer)
		public readonly IsFramebufferDelegate IsFramebuffer;
		// GLboolean glIsProgram (GLuint program)
		public readonly IsProgramDelegate IsProgram;
		// GLboolean glIsProgramPipeline (GLuint pipeline)
		public readonly IsProgramPipelineDelegate IsProgramPipeline;
		// GLboolean glIsQuery (GLuint id)
		public readonly IsQueryDelegate IsQuery;
		// GLboolean glIsRenderbuffer (GLuint renderbuffer)
		public readonly IsRenderbufferDelegate IsRenderbuffer;
		// GLboolean glIsSampler (GLuint sampler)
		public readonly IsSamplerDelegate IsSampler;
		// GLboolean glIsShader (GLuint shader)
		public readonly IsShaderDelegate IsShader;
		// GLboolean glIsSync (GLsync sync)
		public readonly IsSyncDelegate IsSync;
		// GLboolean glIsTexture (GLuint texture)
		public readonly IsTextureDelegate IsTexture;
		// GLboolean glIsTransformFeedback (GLuint id)
		public readonly IsTransformFeedbackDelegate IsTransformFeedback;
		// GLboolean glIsVertexArray (GLuint array)
		public readonly IsVertexArrayDelegate IsVertexArray;
		// void glLineWidth (GLfloat width)
		public readonly LineWidthDelegate LineWidth;
		// void glLinkProgram (GLuint program)
		public readonly LinkProgramDelegate LinkProgram;
		// void glLogicOp (GLenum opcode)
		public readonly LogicOpDelegate LogicOp;
		// void* glMapBuffer (GLenum target, GLenum access)
		public readonly MapBufferDelegate MapBuffer;
		// void* glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)
		public readonly MapBufferRangeDelegate MapBufferRange;
		// void* glMapNamedBuffer (GLuint buffer, GLenum access)
		public readonly MapNamedBufferDelegate MapNamedBuffer;
		// void* glMapNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
		public readonly MapNamedBufferRangeDelegate MapNamedBufferRange;
		// void glMemoryBarrierByRegion (GLbitfield barriers)
		public readonly MemoryBarrierByRegionDelegate MemoryBarrierByRegion;
		// void glMemoryBarrier (GLbitfield barriers)
		public readonly MemoryBarrierDelegate MemoryBarrier;
		// void glMinSampleShading (GLfloat value)
		public readonly MinSampleShadingDelegate MinSampleShading;
		// void glMultiDrawArrays (GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount)
		public readonly MultiDrawArraysDelegate MultiDrawArrays;
		// void glMultiDrawArraysIndirect (GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride)
		public readonly MultiDrawArraysIndirectDelegate MultiDrawArraysIndirect;
		// void glMultiDrawElementsBaseVertex (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount, GLint* basevertex)
		public readonly MultiDrawElementsBaseVertexDelegate MultiDrawElementsBaseVertex;
		// void glMultiDrawElements (GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount)
		public readonly MultiDrawElementsDelegate MultiDrawElements;
		// void glMultiDrawElementsIndirect (GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride)
		public readonly MultiDrawElementsIndirectDelegate MultiDrawElementsIndirect;
		// void glNamedBufferData (GLuint buffer, GLsizeiptr size, void* data, GLenum usage)
		public readonly NamedBufferDataDelegate NamedBufferData;
		// void glNamedBufferStorage (GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags)
		public readonly NamedBufferStorageDelegate NamedBufferStorage;
		// void glNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void* data)
		public readonly NamedBufferSubDataDelegate NamedBufferSubData;
		// void glNamedFramebufferDrawBuffer (GLuint framebuffer, GLenum buf)
		public readonly NamedFramebufferDrawBufferDelegate NamedFramebufferDrawBuffer;
		// void glNamedFramebufferDrawBuffers (GLuint framebuffer, GLsizei n, GLenum* bufs)
		public readonly NamedFramebufferDrawBuffersDelegate NamedFramebufferDrawBuffers;
		// void glNamedFramebufferParameteri (GLuint framebuffer, GLenum pname, GLint param)
		public readonly NamedFramebufferParameteriDelegate NamedFramebufferParameteri;
		// void glNamedFramebufferReadBuffer (GLuint framebuffer, GLenum src)
		public readonly NamedFramebufferReadBufferDelegate NamedFramebufferReadBuffer;
		// void glNamedFramebufferRenderbuffer (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
		public readonly NamedFramebufferRenderbufferDelegate NamedFramebufferRenderbuffer;
		// void glNamedFramebufferTexture (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
		public readonly NamedFramebufferTextureDelegate NamedFramebufferTexture;
		// void glNamedFramebufferTextureLayer (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
		public readonly NamedFramebufferTextureLayerDelegate NamedFramebufferTextureLayer;
		// void glNamedRenderbufferStorage (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly NamedRenderbufferStorageDelegate NamedRenderbufferStorage;
		// void glNamedRenderbufferStorageMultisample (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly NamedRenderbufferStorageMultisampleDelegate NamedRenderbufferStorageMultisample;
		// void glObjectLabel (GLenum identifier, GLuint name, GLsizei length, GLchar* label)
		public readonly ObjectLabelDelegate ObjectLabel;
		// void glObjectPtrLabel (void* ptr, GLsizei length, GLchar* label)
		public readonly ObjectPtrLabelDelegate ObjectPtrLabel;
		// void glPatchParameterfv (GLenum pname, GLfloat* values)
		public readonly PatchParameterfvDelegate PatchParameterfv;
		// void glPatchParameteri (GLenum pname, GLint value)
		public readonly PatchParameteriDelegate PatchParameteri;
		// void glPauseTransformFeedback ()
		public readonly PauseTransformFeedbackDelegate PauseTransformFeedback;
		// void glPixelStoref (GLenum pname, GLfloat param)
		public readonly PixelStorefDelegate PixelStoref;
		// void glPixelStorei (GLenum pname, GLint param)
		public readonly PixelStoreiDelegate PixelStorei;
		// void glPointParameterf (GLenum pname, GLfloat param)
		public readonly PointParameterfDelegate PointParameterf;
		// void glPointParameterfv (GLenum pname, GLfloat* params)
		public readonly PointParameterfvDelegate PointParameterfv;
		// void glPointParameteri (GLenum pname, GLint param)
		public readonly PointParameteriDelegate PointParameteri;
		// void glPointParameteriv (GLenum pname, GLint* params)
		public readonly PointParameterivDelegate PointParameteriv;
		// void glPointSize (GLfloat size)
		public readonly PointSizeDelegate PointSize;
		// void glPolygonMode (GLenum face, GLenum mode)
		public readonly PolygonModeDelegate PolygonMode;
		// void glPolygonOffset (GLfloat factor, GLfloat units)
		public readonly PolygonOffsetDelegate PolygonOffset;
		// void glPopDebugGroup ()
		public readonly PopDebugGroupDelegate PopDebugGroup;
		// void glPrimitiveRestartIndex (GLuint index)
		public readonly PrimitiveRestartIndexDelegate PrimitiveRestartIndex;
		// void glProgramBinary (GLuint program, GLenum binaryFormat, void* binary, GLsizei length)
		public readonly ProgramBinaryDelegate ProgramBinary;
		// void glProgramParameteri (GLuint program, GLenum pname, GLint value)
		public readonly ProgramParameteriDelegate ProgramParameteri;
		// void glProgramUniform1d (GLuint program, GLint location, GLdouble v0)
		public readonly ProgramUniform1dDelegate ProgramUniform1d;
		// void glProgramUniform1dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		public readonly ProgramUniform1dvDelegate ProgramUniform1dv;
		// void glProgramUniform1f (GLuint program, GLint location, GLfloat v0)
		public readonly ProgramUniform1fDelegate ProgramUniform1f;
		// void glProgramUniform1fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		public readonly ProgramUniform1fvDelegate ProgramUniform1fv;
		// void glProgramUniform1i (GLuint program, GLint location, GLint v0)
		public readonly ProgramUniform1iDelegate ProgramUniform1i;
		// void glProgramUniform1iv (GLuint program, GLint location, GLsizei count, GLint* value)
		public readonly ProgramUniform1ivDelegate ProgramUniform1iv;
		// void glProgramUniform1ui (GLuint program, GLint location, GLuint v0)
		public readonly ProgramUniform1uiDelegate ProgramUniform1ui;
		// void glProgramUniform1uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		public readonly ProgramUniform1uivDelegate ProgramUniform1uiv;
		// void glProgramUniform2d (GLuint program, GLint location, GLdouble v0, GLdouble v1)
		public readonly ProgramUniform2dDelegate ProgramUniform2d;
		// void glProgramUniform2dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		public readonly ProgramUniform2dvDelegate ProgramUniform2dv;
		// void glProgramUniform2f (GLuint program, GLint location, GLfloat v0, GLfloat v1)
		public readonly ProgramUniform2fDelegate ProgramUniform2f;
		// void glProgramUniform2fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		public readonly ProgramUniform2fvDelegate ProgramUniform2fv;
		// void glProgramUniform2i (GLuint program, GLint location, GLint v0, GLint v1)
		public readonly ProgramUniform2iDelegate ProgramUniform2i;
		// void glProgramUniform2iv (GLuint program, GLint location, GLsizei count, GLint* value)
		public readonly ProgramUniform2ivDelegate ProgramUniform2iv;
		// void glProgramUniform2ui (GLuint program, GLint location, GLuint v0, GLuint v1)
		public readonly ProgramUniform2uiDelegate ProgramUniform2ui;
		// void glProgramUniform2uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		public readonly ProgramUniform2uivDelegate ProgramUniform2uiv;
		// void glProgramUniform3d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2)
		public readonly ProgramUniform3dDelegate ProgramUniform3d;
		// void glProgramUniform3dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		public readonly ProgramUniform3dvDelegate ProgramUniform3dv;
		// void glProgramUniform3f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
		public readonly ProgramUniform3fDelegate ProgramUniform3f;
		// void glProgramUniform3fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		public readonly ProgramUniform3fvDelegate ProgramUniform3fv;
		// void glProgramUniform3i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
		public readonly ProgramUniform3iDelegate ProgramUniform3i;
		// void glProgramUniform3iv (GLuint program, GLint location, GLsizei count, GLint* value)
		public readonly ProgramUniform3ivDelegate ProgramUniform3iv;
		// void glProgramUniform3ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
		public readonly ProgramUniform3uiDelegate ProgramUniform3ui;
		// void glProgramUniform3uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		public readonly ProgramUniform3uivDelegate ProgramUniform3uiv;
		// void glProgramUniform4d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3)
		public readonly ProgramUniform4dDelegate ProgramUniform4d;
		// void glProgramUniform4dv (GLuint program, GLint location, GLsizei count, GLdouble* value)
		public readonly ProgramUniform4dvDelegate ProgramUniform4dv;
		// void glProgramUniform4f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
		public readonly ProgramUniform4fDelegate ProgramUniform4f;
		// void glProgramUniform4fv (GLuint program, GLint location, GLsizei count, GLfloat* value)
		public readonly ProgramUniform4fvDelegate ProgramUniform4fv;
		// void glProgramUniform4i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
		public readonly ProgramUniform4iDelegate ProgramUniform4i;
		// void glProgramUniform4iv (GLuint program, GLint location, GLsizei count, GLint* value)
		public readonly ProgramUniform4ivDelegate ProgramUniform4iv;
		// void glProgramUniform4ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
		public readonly ProgramUniform4uiDelegate ProgramUniform4ui;
		// void glProgramUniform4uiv (GLuint program, GLint location, GLsizei count, GLuint* value)
		public readonly ProgramUniform4uivDelegate ProgramUniform4uiv;
		// void glProgramUniformMatrix2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix2dvDelegate ProgramUniformMatrix2dv;
		// void glProgramUniformMatrix2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix2fvDelegate ProgramUniformMatrix2fv;
		// void glProgramUniformMatrix2x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix2x3dvDelegate ProgramUniformMatrix2x3dv;
		// void glProgramUniformMatrix2x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix2x3fvDelegate ProgramUniformMatrix2x3fv;
		// void glProgramUniformMatrix2x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix2x4dvDelegate ProgramUniformMatrix2x4dv;
		// void glProgramUniformMatrix2x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix2x4fvDelegate ProgramUniformMatrix2x4fv;
		// void glProgramUniformMatrix3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix3dvDelegate ProgramUniformMatrix3dv;
		// void glProgramUniformMatrix3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix3fvDelegate ProgramUniformMatrix3fv;
		// void glProgramUniformMatrix3x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix3x2dvDelegate ProgramUniformMatrix3x2dv;
		// void glProgramUniformMatrix3x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix3x2fvDelegate ProgramUniformMatrix3x2fv;
		// void glProgramUniformMatrix3x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix3x4dvDelegate ProgramUniformMatrix3x4dv;
		// void glProgramUniformMatrix3x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix3x4fvDelegate ProgramUniformMatrix3x4fv;
		// void glProgramUniformMatrix4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix4dvDelegate ProgramUniformMatrix4dv;
		// void glProgramUniformMatrix4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix4fvDelegate ProgramUniformMatrix4fv;
		// void glProgramUniformMatrix4x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix4x2dvDelegate ProgramUniformMatrix4x2dv;
		// void glProgramUniformMatrix4x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix4x2fvDelegate ProgramUniformMatrix4x2fv;
		// void glProgramUniformMatrix4x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly ProgramUniformMatrix4x3dvDelegate ProgramUniformMatrix4x3dv;
		// void glProgramUniformMatrix4x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly ProgramUniformMatrix4x3fvDelegate ProgramUniformMatrix4x3fv;
		// void glProvokingVertex (GLenum mode)
		public readonly ProvokingVertexDelegate ProvokingVertex;
		// void glPushDebugGroup (GLenum source, GLuint id, GLsizei length, GLchar* message)
		public readonly PushDebugGroupDelegate PushDebugGroup;
		// void glQueryCounter (GLuint id, GLenum target)
		public readonly QueryCounterDelegate QueryCounter;
		// void glReadBuffer (GLenum src)
		public readonly ReadBufferDelegate ReadBuffer;
		// void glReadnPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data)
		public readonly ReadnPixelsDelegate ReadnPixels;
		// void glReadPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		public readonly ReadPixelsDelegate ReadPixels;
		// void glReleaseShaderCompiler ()
		public readonly ReleaseShaderCompilerDelegate ReleaseShaderCompiler;
		// void glRenderbufferStorage (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly RenderbufferStorageDelegate RenderbufferStorage;
		// void glRenderbufferStorageMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly RenderbufferStorageMultisampleDelegate RenderbufferStorageMultisample;
		// void glResumeTransformFeedback ()
		public readonly ResumeTransformFeedbackDelegate ResumeTransformFeedback;
		// void glSampleCoverage (GLfloat value, GLboolean invert)
		public readonly SampleCoverageDelegate SampleCoverage;
		// void glSampleMaski (GLuint maskNumber, GLbitfield mask)
		public readonly SampleMaskiDelegate SampleMaski;
		// void glSamplerParameterf (GLuint sampler, GLenum pname, GLfloat param)
		public readonly SamplerParameterfDelegate SamplerParameterf;
		// void glSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat* param)
		public readonly SamplerParameterfvDelegate SamplerParameterfv;
		// void glSamplerParameteri (GLuint sampler, GLenum pname, GLint param)
		public readonly SamplerParameteriDelegate SamplerParameteri;
		// void glSamplerParameterIiv (GLuint sampler, GLenum pname, GLint* param)
		public readonly SamplerParameterIivDelegate SamplerParameterIiv;
		// void glSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint* param)
		public readonly SamplerParameterIuivDelegate SamplerParameterIuiv;
		// void glSamplerParameteriv (GLuint sampler, GLenum pname, GLint* param)
		public readonly SamplerParameterivDelegate SamplerParameteriv;
		// void glScissorArrayv (GLuint first, GLsizei count, GLint* v)
		public readonly ScissorArrayvDelegate ScissorArrayv;
		// void glScissor (GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly ScissorDelegate Scissor;
		// void glScissorIndexed (GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)
		public readonly ScissorIndexedDelegate ScissorIndexed;
		// void glScissorIndexedv (GLuint index, GLint* v)
		public readonly ScissorIndexedvDelegate ScissorIndexedv;
		// void glShaderBinary (GLsizei count, GLuint* shaders, GLenum binaryformat, void* binary, GLsizei length)
		public readonly ShaderBinaryDelegate ShaderBinary;
		// void glShaderSource (GLuint shader, GLsizei count, GLchar** string, GLint* length)
		public readonly ShaderSourceDelegate ShaderSource;
		// void glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding)
		public readonly ShaderStorageBlockBindingDelegate ShaderStorageBlockBinding;
		// void glStencilFunc (GLenum func, GLint ref, GLuint mask)
		public readonly StencilFuncDelegate StencilFunc;
		// void glStencilFuncSeparate (GLenum face, GLenum func, GLint ref, GLuint mask)
		public readonly StencilFuncSeparateDelegate StencilFuncSeparate;
		// void glStencilMask (GLuint mask)
		public readonly StencilMaskDelegate StencilMask;
		// void glStencilMaskSeparate (GLenum face, GLuint mask)
		public readonly StencilMaskSeparateDelegate StencilMaskSeparate;
		// void glStencilOp (GLenum fail, GLenum zfail, GLenum zpass)
		public readonly StencilOpDelegate StencilOp;
		// void glStencilOpSeparate (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
		public readonly StencilOpSeparateDelegate StencilOpSeparate;
		// void glTexBuffer (GLenum target, GLenum internalformat, GLuint buffer)
		public readonly TexBufferDelegate TexBuffer;
		// void glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
		public readonly TexBufferRangeDelegate TexBufferRange;
		// void glTexImage1D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels)
		public readonly TexImage1DDelegate TexImage1D;
		// void glTexImage2D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels)
		public readonly TexImage2DDelegate TexImage2D;
		// void glTexImage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		public readonly TexImage2DMultisampleDelegate TexImage2DMultisample;
		// void glTexImage3D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels)
		public readonly TexImage3DDelegate TexImage3D;
		// void glTexImage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		public readonly TexImage3DMultisampleDelegate TexImage3DMultisample;
		// void glTexParameterf (GLenum target, GLenum pname, GLfloat param)
		public readonly TexParameterfDelegate TexParameterf;
		// void glTexParameterfv (GLenum target, GLenum pname, GLfloat* params)
		public readonly TexParameterfvDelegate TexParameterfv;
		// void glTexParameteri (GLenum target, GLenum pname, GLint param)
		public readonly TexParameteriDelegate TexParameteri;
		// void glTexParameterIiv (GLenum target, GLenum pname, GLint* params)
		public readonly TexParameterIivDelegate TexParameterIiv;
		// void glTexParameterIuiv (GLenum target, GLenum pname, GLuint* params)
		public readonly TexParameterIuivDelegate TexParameterIuiv;
		// void glTexParameteriv (GLenum target, GLenum pname, GLint* params)
		public readonly TexParameterivDelegate TexParameteriv;
		// void glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
		public readonly TexStorage1DDelegate TexStorage1D;
		// void glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly TexStorage2DDelegate TexStorage2D;
		// void glTexStorage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		public readonly TexStorage2DMultisampleDelegate TexStorage2DMultisample;
		// void glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
		public readonly TexStorage3DDelegate TexStorage3D;
		// void glTexStorage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		public readonly TexStorage3DMultisampleDelegate TexStorage3DMultisample;
		// void glTexSubImage1D (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
		public readonly TexSubImage1DDelegate TexSubImage1D;
		// void glTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		public readonly TexSubImage2DDelegate TexSubImage2D;
		// void glTexSubImage3D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
		public readonly TexSubImage3DDelegate TexSubImage3D;
		// void glTextureBarrier ()
		public readonly TextureBarrierDelegate TextureBarrier;
		// void glTextureBuffer (GLuint texture, GLenum internalformat, GLuint buffer)
		public readonly TextureBufferDelegate TextureBuffer;
		// void glTextureBufferRange (GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
		public readonly TextureBufferRangeDelegate TextureBufferRange;
		// void glTextureParameterf (GLuint texture, GLenum pname, GLfloat param)
		public readonly TextureParameterfDelegate TextureParameterf;
		// void glTextureParameterfv (GLuint texture, GLenum pname, GLfloat* param)
		public readonly TextureParameterfvDelegate TextureParameterfv;
		// void glTextureParameteri (GLuint texture, GLenum pname, GLint param)
		public readonly TextureParameteriDelegate TextureParameteri;
		// void glTextureParameterIiv (GLuint texture, GLenum pname, GLint* params)
		public readonly TextureParameterIivDelegate TextureParameterIiv;
		// void glTextureParameterIuiv (GLuint texture, GLenum pname, GLuint* params)
		public readonly TextureParameterIuivDelegate TextureParameterIuiv;
		// void glTextureParameteriv (GLuint texture, GLenum pname, GLint* param)
		public readonly TextureParameterivDelegate TextureParameteriv;
		// void glTextureStorage1D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width)
		public readonly TextureStorage1DDelegate TextureStorage1D;
		// void glTextureStorage2D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
		public readonly TextureStorage2DDelegate TextureStorage2D;
		// void glTextureStorage2DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
		public readonly TextureStorage2DMultisampleDelegate TextureStorage2DMultisample;
		// void glTextureStorage3D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
		public readonly TextureStorage3DDelegate TextureStorage3D;
		// void glTextureStorage3DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
		public readonly TextureStorage3DMultisampleDelegate TextureStorage3DMultisample;
		// void glTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels)
		public readonly TextureSubImage1DDelegate TextureSubImage1D;
		// void glTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels)
		public readonly TextureSubImage2DDelegate TextureSubImage2D;
		// void glTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels)
		public readonly TextureSubImage3DDelegate TextureSubImage3D;
		// void glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)
		public readonly TextureViewDelegate TextureView;
		// void glTransformFeedbackBufferBase (GLuint xfb, GLuint index, GLuint buffer)
		public readonly TransformFeedbackBufferBaseDelegate TransformFeedbackBufferBase;
		// void glTransformFeedbackBufferRange (GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
		public readonly TransformFeedbackBufferRangeDelegate TransformFeedbackBufferRange;
		// void glTransformFeedbackVaryings (GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode)
		public readonly TransformFeedbackVaryingsDelegate TransformFeedbackVaryings;
		// void glUniform1d (GLint location, GLdouble x)
		public readonly Uniform1dDelegate Uniform1d;
		// void glUniform1dv (GLint location, GLsizei count, GLdouble* value)
		public readonly Uniform1dvDelegate Uniform1dv;
		// void glUniform1f (GLint location, GLfloat v0)
		public readonly Uniform1fDelegate Uniform1f;
		// void glUniform1fv (GLint location, GLsizei count, GLfloat* value)
		public readonly Uniform1fvDelegate Uniform1fv;
		// void glUniform1i (GLint location, GLint v0)
		public readonly Uniform1iDelegate Uniform1i;
		// void glUniform1iv (GLint location, GLsizei count, GLint* value)
		public readonly Uniform1ivDelegate Uniform1iv;
		// void glUniform1ui (GLint location, GLuint v0)
		public readonly Uniform1uiDelegate Uniform1ui;
		// void glUniform1uiv (GLint location, GLsizei count, GLuint* value)
		public readonly Uniform1uivDelegate Uniform1uiv;
		// void glUniform2d (GLint location, GLdouble x, GLdouble y)
		public readonly Uniform2dDelegate Uniform2d;
		// void glUniform2dv (GLint location, GLsizei count, GLdouble* value)
		public readonly Uniform2dvDelegate Uniform2dv;
		// void glUniform2f (GLint location, GLfloat v0, GLfloat v1)
		public readonly Uniform2fDelegate Uniform2f;
		// void glUniform2fv (GLint location, GLsizei count, GLfloat* value)
		public readonly Uniform2fvDelegate Uniform2fv;
		// void glUniform2i (GLint location, GLint v0, GLint v1)
		public readonly Uniform2iDelegate Uniform2i;
		// void glUniform2iv (GLint location, GLsizei count, GLint* value)
		public readonly Uniform2ivDelegate Uniform2iv;
		// void glUniform2ui (GLint location, GLuint v0, GLuint v1)
		public readonly Uniform2uiDelegate Uniform2ui;
		// void glUniform2uiv (GLint location, GLsizei count, GLuint* value)
		public readonly Uniform2uivDelegate Uniform2uiv;
		// void glUniform3d (GLint location, GLdouble x, GLdouble y, GLdouble z)
		public readonly Uniform3dDelegate Uniform3d;
		// void glUniform3dv (GLint location, GLsizei count, GLdouble* value)
		public readonly Uniform3dvDelegate Uniform3dv;
		// void glUniform3f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
		public readonly Uniform3fDelegate Uniform3f;
		// void glUniform3fv (GLint location, GLsizei count, GLfloat* value)
		public readonly Uniform3fvDelegate Uniform3fv;
		// void glUniform3i (GLint location, GLint v0, GLint v1, GLint v2)
		public readonly Uniform3iDelegate Uniform3i;
		// void glUniform3iv (GLint location, GLsizei count, GLint* value)
		public readonly Uniform3ivDelegate Uniform3iv;
		// void glUniform3ui (GLint location, GLuint v0, GLuint v1, GLuint v2)
		public readonly Uniform3uiDelegate Uniform3ui;
		// void glUniform3uiv (GLint location, GLsizei count, GLuint* value)
		public readonly Uniform3uivDelegate Uniform3uiv;
		// void glUniform4d (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		public readonly Uniform4dDelegate Uniform4d;
		// void glUniform4dv (GLint location, GLsizei count, GLdouble* value)
		public readonly Uniform4dvDelegate Uniform4dv;
		// void glUniform4f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
		public readonly Uniform4fDelegate Uniform4f;
		// void glUniform4fv (GLint location, GLsizei count, GLfloat* value)
		public readonly Uniform4fvDelegate Uniform4fv;
		// void glUniform4i (GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
		public readonly Uniform4iDelegate Uniform4i;
		// void glUniform4iv (GLint location, GLsizei count, GLint* value)
		public readonly Uniform4ivDelegate Uniform4iv;
		// void glUniform4ui (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
		public readonly Uniform4uiDelegate Uniform4ui;
		// void glUniform4uiv (GLint location, GLsizei count, GLuint* value)
		public readonly Uniform4uivDelegate Uniform4uiv;
		// void glUniformBlockBinding (GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)
		public readonly UniformBlockBindingDelegate UniformBlockBinding;
		// void glUniformMatrix2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix2dvDelegate UniformMatrix2dv;
		// void glUniformMatrix2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix2fvDelegate UniformMatrix2fv;
		// void glUniformMatrix2x3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix2x3dvDelegate UniformMatrix2x3dv;
		// void glUniformMatrix2x3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix2x3fvDelegate UniformMatrix2x3fv;
		// void glUniformMatrix2x4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix2x4dvDelegate UniformMatrix2x4dv;
		// void glUniformMatrix2x4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix2x4fvDelegate UniformMatrix2x4fv;
		// void glUniformMatrix3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix3dvDelegate UniformMatrix3dv;
		// void glUniformMatrix3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix3fvDelegate UniformMatrix3fv;
		// void glUniformMatrix3x2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix3x2dvDelegate UniformMatrix3x2dv;
		// void glUniformMatrix3x2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix3x2fvDelegate UniformMatrix3x2fv;
		// void glUniformMatrix3x4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix3x4dvDelegate UniformMatrix3x4dv;
		// void glUniformMatrix3x4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix3x4fvDelegate UniformMatrix3x4fv;
		// void glUniformMatrix4dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix4dvDelegate UniformMatrix4dv;
		// void glUniformMatrix4fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix4fvDelegate UniformMatrix4fv;
		// void glUniformMatrix4x2dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix4x2dvDelegate UniformMatrix4x2dv;
		// void glUniformMatrix4x2fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix4x2fvDelegate UniformMatrix4x2fv;
		// void glUniformMatrix4x3dv (GLint location, GLsizei count, GLboolean transpose, GLdouble* value)
		public readonly UniformMatrix4x3dvDelegate UniformMatrix4x3dv;
		// void glUniformMatrix4x3fv (GLint location, GLsizei count, GLboolean transpose, GLfloat* value)
		public readonly UniformMatrix4x3fvDelegate UniformMatrix4x3fv;
		// void glUniformSubroutinesuiv (GLenum shadertype, GLsizei count, GLuint* indices)
		public readonly UniformSubroutinesuivDelegate UniformSubroutinesuiv;
		// GLboolean glUnmapBuffer (GLenum target)
		public readonly UnmapBufferDelegate UnmapBuffer;
		// GLboolean glUnmapNamedBuffer (GLuint buffer)
		public readonly UnmapNamedBufferDelegate UnmapNamedBuffer;
		// void glUseProgram (GLuint program)
		public readonly UseProgramDelegate UseProgram;
		// void glUseProgramStages (GLuint pipeline, GLbitfield stages, GLuint program)
		public readonly UseProgramStagesDelegate UseProgramStages;
		// void glValidateProgram (GLuint program)
		public readonly ValidateProgramDelegate ValidateProgram;
		// void glValidateProgramPipeline (GLuint pipeline)
		public readonly ValidateProgramPipelineDelegate ValidateProgramPipeline;
		// void glVertexArrayAttribBinding (GLuint vaobj, GLuint attribindex, GLuint bindingindex)
		public readonly VertexArrayAttribBindingDelegate VertexArrayAttribBinding;
		// void glVertexArrayAttribFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
		public readonly VertexArrayAttribFormatDelegate VertexArrayAttribFormat;
		// void glVertexArrayAttribIFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		public readonly VertexArrayAttribIFormatDelegate VertexArrayAttribIFormat;
		// void glVertexArrayAttribLFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		public readonly VertexArrayAttribLFormatDelegate VertexArrayAttribLFormat;
		// void glVertexArrayBindingDivisor (GLuint vaobj, GLuint bindingindex, GLuint divisor)
		public readonly VertexArrayBindingDivisorDelegate VertexArrayBindingDivisor;
		// void glVertexArrayElementBuffer (GLuint vaobj, GLuint buffer)
		public readonly VertexArrayElementBufferDelegate VertexArrayElementBuffer;
		// void glVertexArrayVertexBuffer (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
		public readonly VertexArrayVertexBufferDelegate VertexArrayVertexBuffer;
		// void glVertexArrayVertexBuffers (GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides)
		public readonly VertexArrayVertexBuffersDelegate VertexArrayVertexBuffers;
		// void glVertexAttrib1d (GLuint index, GLdouble x)
		public readonly VertexAttrib1dDelegate VertexAttrib1d;
		// void glVertexAttrib1dv (GLuint index, GLdouble* v)
		public readonly VertexAttrib1dvDelegate VertexAttrib1dv;
		// void glVertexAttrib1f (GLuint index, GLfloat x)
		public readonly VertexAttrib1fDelegate VertexAttrib1f;
		// void glVertexAttrib1fv (GLuint index, GLfloat* v)
		public readonly VertexAttrib1fvDelegate VertexAttrib1fv;
		// void glVertexAttrib1s (GLuint index, GLshort x)
		public readonly VertexAttrib1sDelegate VertexAttrib1s;
		// void glVertexAttrib1sv (GLuint index, GLshort* v)
		public readonly VertexAttrib1svDelegate VertexAttrib1sv;
		// void glVertexAttrib2d (GLuint index, GLdouble x, GLdouble y)
		public readonly VertexAttrib2dDelegate VertexAttrib2d;
		// void glVertexAttrib2dv (GLuint index, GLdouble* v)
		public readonly VertexAttrib2dvDelegate VertexAttrib2dv;
		// void glVertexAttrib2f (GLuint index, GLfloat x, GLfloat y)
		public readonly VertexAttrib2fDelegate VertexAttrib2f;
		// void glVertexAttrib2fv (GLuint index, GLfloat* v)
		public readonly VertexAttrib2fvDelegate VertexAttrib2fv;
		// void glVertexAttrib2s (GLuint index, GLshort x, GLshort y)
		public readonly VertexAttrib2sDelegate VertexAttrib2s;
		// void glVertexAttrib2sv (GLuint index, GLshort* v)
		public readonly VertexAttrib2svDelegate VertexAttrib2sv;
		// void glVertexAttrib3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
		public readonly VertexAttrib3dDelegate VertexAttrib3d;
		// void glVertexAttrib3dv (GLuint index, GLdouble* v)
		public readonly VertexAttrib3dvDelegate VertexAttrib3dv;
		// void glVertexAttrib3f (GLuint index, GLfloat x, GLfloat y, GLfloat z)
		public readonly VertexAttrib3fDelegate VertexAttrib3f;
		// void glVertexAttrib3fv (GLuint index, GLfloat* v)
		public readonly VertexAttrib3fvDelegate VertexAttrib3fv;
		// void glVertexAttrib3s (GLuint index, GLshort x, GLshort y, GLshort z)
		public readonly VertexAttrib3sDelegate VertexAttrib3s;
		// void glVertexAttrib3sv (GLuint index, GLshort* v)
		public readonly VertexAttrib3svDelegate VertexAttrib3sv;
		// void glVertexAttrib4bv (GLuint index, GLbyte* v)
		public readonly VertexAttrib4bvDelegate VertexAttrib4bv;
		// void glVertexAttrib4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		public readonly VertexAttrib4dDelegate VertexAttrib4d;
		// void glVertexAttrib4dv (GLuint index, GLdouble* v)
		public readonly VertexAttrib4dvDelegate VertexAttrib4dv;
		// void glVertexAttrib4f (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
		public readonly VertexAttrib4fDelegate VertexAttrib4f;
		// void glVertexAttrib4fv (GLuint index, GLfloat* v)
		public readonly VertexAttrib4fvDelegate VertexAttrib4fv;
		// void glVertexAttrib4iv (GLuint index, GLint* v)
		public readonly VertexAttrib4ivDelegate VertexAttrib4iv;
		// void glVertexAttrib4Nbv (GLuint index, GLbyte* v)
		public readonly VertexAttrib4NbvDelegate VertexAttrib4Nbv;
		// void glVertexAttrib4Niv (GLuint index, GLint* v)
		public readonly VertexAttrib4NivDelegate VertexAttrib4Niv;
		// void glVertexAttrib4Nsv (GLuint index, GLshort* v)
		public readonly VertexAttrib4NsvDelegate VertexAttrib4Nsv;
		// void glVertexAttrib4Nub (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
		public readonly VertexAttrib4NubDelegate VertexAttrib4Nub;
		// void glVertexAttrib4Nubv (GLuint index, GLubyte* v)
		public readonly VertexAttrib4NubvDelegate VertexAttrib4Nubv;
		// void glVertexAttrib4Nuiv (GLuint index, GLuint* v)
		public readonly VertexAttrib4NuivDelegate VertexAttrib4Nuiv;
		// void glVertexAttrib4Nusv (GLuint index, GLushort* v)
		public readonly VertexAttrib4NusvDelegate VertexAttrib4Nusv;
		// void glVertexAttrib4s (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
		public readonly VertexAttrib4sDelegate VertexAttrib4s;
		// void glVertexAttrib4sv (GLuint index, GLshort* v)
		public readonly VertexAttrib4svDelegate VertexAttrib4sv;
		// void glVertexAttrib4ubv (GLuint index, GLubyte* v)
		public readonly VertexAttrib4ubvDelegate VertexAttrib4ubv;
		// void glVertexAttrib4uiv (GLuint index, GLuint* v)
		public readonly VertexAttrib4uivDelegate VertexAttrib4uiv;
		// void glVertexAttrib4usv (GLuint index, GLushort* v)
		public readonly VertexAttrib4usvDelegate VertexAttrib4usv;
		// void glVertexAttribBinding (GLuint attribindex, GLuint bindingindex)
		public readonly VertexAttribBindingDelegate VertexAttribBinding;
		// void glVertexAttribDivisor (GLuint index, GLuint divisor)
		public readonly VertexAttribDivisorDelegate VertexAttribDivisor;
		// void glVertexAttribFormat (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
		public readonly VertexAttribFormatDelegate VertexAttribFormat;
		// void glVertexAttribI1i (GLuint index, GLint x)
		public readonly VertexAttribI1iDelegate VertexAttribI1i;
		// void glVertexAttribI1iv (GLuint index, GLint* v)
		public readonly VertexAttribI1ivDelegate VertexAttribI1iv;
		// void glVertexAttribI1ui (GLuint index, GLuint x)
		public readonly VertexAttribI1uiDelegate VertexAttribI1ui;
		// void glVertexAttribI1uiv (GLuint index, GLuint* v)
		public readonly VertexAttribI1uivDelegate VertexAttribI1uiv;
		// void glVertexAttribI2i (GLuint index, GLint x, GLint y)
		public readonly VertexAttribI2iDelegate VertexAttribI2i;
		// void glVertexAttribI2iv (GLuint index, GLint* v)
		public readonly VertexAttribI2ivDelegate VertexAttribI2iv;
		// void glVertexAttribI2ui (GLuint index, GLuint x, GLuint y)
		public readonly VertexAttribI2uiDelegate VertexAttribI2ui;
		// void glVertexAttribI2uiv (GLuint index, GLuint* v)
		public readonly VertexAttribI2uivDelegate VertexAttribI2uiv;
		// void glVertexAttribI3i (GLuint index, GLint x, GLint y, GLint z)
		public readonly VertexAttribI3iDelegate VertexAttribI3i;
		// void glVertexAttribI3iv (GLuint index, GLint* v)
		public readonly VertexAttribI3ivDelegate VertexAttribI3iv;
		// void glVertexAttribI3ui (GLuint index, GLuint x, GLuint y, GLuint z)
		public readonly VertexAttribI3uiDelegate VertexAttribI3ui;
		// void glVertexAttribI3uiv (GLuint index, GLuint* v)
		public readonly VertexAttribI3uivDelegate VertexAttribI3uiv;
		// void glVertexAttribI4bv (GLuint index, GLbyte* v)
		public readonly VertexAttribI4bvDelegate VertexAttribI4bv;
		// void glVertexAttribI4i (GLuint index, GLint x, GLint y, GLint z, GLint w)
		public readonly VertexAttribI4iDelegate VertexAttribI4i;
		// void glVertexAttribI4iv (GLuint index, GLint* v)
		public readonly VertexAttribI4ivDelegate VertexAttribI4iv;
		// void glVertexAttribI4sv (GLuint index, GLshort* v)
		public readonly VertexAttribI4svDelegate VertexAttribI4sv;
		// void glVertexAttribI4ubv (GLuint index, GLubyte* v)
		public readonly VertexAttribI4ubvDelegate VertexAttribI4ubv;
		// void glVertexAttribI4ui (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
		public readonly VertexAttribI4uiDelegate VertexAttribI4ui;
		// void glVertexAttribI4uiv (GLuint index, GLuint* v)
		public readonly VertexAttribI4uivDelegate VertexAttribI4uiv;
		// void glVertexAttribI4usv (GLuint index, GLushort* v)
		public readonly VertexAttribI4usvDelegate VertexAttribI4usv;
		// void glVertexAttribIFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		public readonly VertexAttribIFormatDelegate VertexAttribIFormat;
		// void glVertexAttribIPointer (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
		public readonly VertexAttribIPointerDelegate VertexAttribIPointer;
		// void glVertexAttribL1d (GLuint index, GLdouble x)
		public readonly VertexAttribL1dDelegate VertexAttribL1d;
		// void glVertexAttribL1dv (GLuint index, GLdouble* v)
		public readonly VertexAttribL1dvDelegate VertexAttribL1dv;
		// void glVertexAttribL2d (GLuint index, GLdouble x, GLdouble y)
		public readonly VertexAttribL2dDelegate VertexAttribL2d;
		// void glVertexAttribL2dv (GLuint index, GLdouble* v)
		public readonly VertexAttribL2dvDelegate VertexAttribL2dv;
		// void glVertexAttribL3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
		public readonly VertexAttribL3dDelegate VertexAttribL3d;
		// void glVertexAttribL3dv (GLuint index, GLdouble* v)
		public readonly VertexAttribL3dvDelegate VertexAttribL3dv;
		// void glVertexAttribL4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
		public readonly VertexAttribL4dDelegate VertexAttribL4d;
		// void glVertexAttribL4dv (GLuint index, GLdouble* v)
		public readonly VertexAttribL4dvDelegate VertexAttribL4dv;
		// void glVertexAttribLFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
		public readonly VertexAttribLFormatDelegate VertexAttribLFormat;
		// void glVertexAttribLPointer (GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer)
		public readonly VertexAttribLPointerDelegate VertexAttribLPointer;
		// void glVertexAttribP1ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		public readonly VertexAttribP1uiDelegate VertexAttribP1ui;
		// void glVertexAttribP1uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		public readonly VertexAttribP1uivDelegate VertexAttribP1uiv;
		// void glVertexAttribP2ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		public readonly VertexAttribP2uiDelegate VertexAttribP2ui;
		// void glVertexAttribP2uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		public readonly VertexAttribP2uivDelegate VertexAttribP2uiv;
		// void glVertexAttribP3ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		public readonly VertexAttribP3uiDelegate VertexAttribP3ui;
		// void glVertexAttribP3uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		public readonly VertexAttribP3uivDelegate VertexAttribP3uiv;
		// void glVertexAttribP4ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
		public readonly VertexAttribP4uiDelegate VertexAttribP4ui;
		// void glVertexAttribP4uiv (GLuint index, GLenum type, GLboolean normalized, GLuint* value)
		public readonly VertexAttribP4uivDelegate VertexAttribP4uiv;
		// void glVertexAttribPointer (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer)
		public readonly VertexAttribPointerDelegate VertexAttribPointer;
		// void glVertexBindingDivisor (GLuint bindingindex, GLuint divisor)
		public readonly VertexBindingDivisorDelegate VertexBindingDivisor;
		// void glViewportArrayv (GLuint first, GLsizei count, GLfloat* v)
		public readonly ViewportArrayvDelegate ViewportArrayv;
		// void glViewport (GLint x, GLint y, GLsizei width, GLsizei height)
		public readonly ViewportDelegate Viewport;
		// void glViewportIndexedf (GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)
		public readonly ViewportIndexedfDelegate ViewportIndexedf;
		// void glViewportIndexedfv (GLuint index, GLfloat* v)
		public readonly ViewportIndexedfvDelegate ViewportIndexedfv;
		// void glWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
		public readonly WaitSyncDelegate WaitSync;
		#endregion // commands
		public Gl (IHandleResolver resolver)
		{
			if (resolver == null) throw new ArgumentNullException ("resolver");
			resolver.LoadHandle ("glActiveShaderProgram", out ActiveShaderProgram);
			resolver.LoadHandle ("glActiveTexture", out ActiveTexture);
			resolver.LoadHandle ("glAttachShader", out AttachShader);
			resolver.LoadHandle ("glBeginConditionalRender", out BeginConditionalRender);
			resolver.LoadHandle ("glBeginQuery", out BeginQuery);
			resolver.LoadHandle ("glBeginQueryIndexed", out BeginQueryIndexed);
			resolver.LoadHandle ("glBeginTransformFeedback", out BeginTransformFeedback);
			resolver.LoadHandle ("glBindAttribLocation", out BindAttribLocation);
			resolver.LoadHandle ("glBindBufferBase", out BindBufferBase);
			resolver.LoadHandle ("glBindBuffer", out BindBuffer);
			resolver.LoadHandle ("glBindBufferRange", out BindBufferRange);
			resolver.LoadHandle ("glBindBuffersBase", out BindBuffersBase);
			resolver.LoadHandle ("glBindBuffersRange", out BindBuffersRange);
			resolver.LoadHandle ("glBindFragDataLocation", out BindFragDataLocation);
			resolver.LoadHandle ("glBindFragDataLocationIndexed", out BindFragDataLocationIndexed);
			resolver.LoadHandle ("glBindFramebuffer", out BindFramebuffer);
			resolver.LoadHandle ("glBindImageTexture", out BindImageTexture);
			resolver.LoadHandle ("glBindImageTextures", out BindImageTextures);
			resolver.LoadHandle ("glBindProgramPipeline", out BindProgramPipeline);
			resolver.LoadHandle ("glBindRenderbuffer", out BindRenderbuffer);
			resolver.LoadHandle ("glBindSampler", out BindSampler);
			resolver.LoadHandle ("glBindSamplers", out BindSamplers);
			resolver.LoadHandle ("glBindTexture", out BindTexture);
			resolver.LoadHandle ("glBindTextures", out BindTextures);
			resolver.LoadHandle ("glBindTextureUnit", out BindTextureUnit);
			resolver.LoadHandle ("glBindTransformFeedback", out BindTransformFeedback);
			resolver.LoadHandle ("glBindVertexArray", out BindVertexArray);
			resolver.LoadHandle ("glBindVertexBuffer", out BindVertexBuffer);
			resolver.LoadHandle ("glBindVertexBuffers", out BindVertexBuffers);
			resolver.LoadHandle ("glBlendColor", out BlendColor);
			resolver.LoadHandle ("glBlendEquation", out BlendEquation);
			resolver.LoadHandle ("glBlendEquationi", out BlendEquationi);
			resolver.LoadHandle ("glBlendEquationSeparate", out BlendEquationSeparate);
			resolver.LoadHandle ("glBlendEquationSeparatei", out BlendEquationSeparatei);
			resolver.LoadHandle ("glBlendFunc", out BlendFunc);
			resolver.LoadHandle ("glBlendFunci", out BlendFunci);
			resolver.LoadHandle ("glBlendFuncSeparate", out BlendFuncSeparate);
			resolver.LoadHandle ("glBlendFuncSeparatei", out BlendFuncSeparatei);
			resolver.LoadHandle ("glBlitFramebuffer", out BlitFramebuffer);
			resolver.LoadHandle ("glBlitNamedFramebuffer", out BlitNamedFramebuffer);
			resolver.LoadHandle ("glBufferData", out BufferData);
			resolver.LoadHandle ("glBufferStorage", out BufferStorage);
			resolver.LoadHandle ("glBufferSubData", out BufferSubData);
			resolver.LoadHandle ("glCheckFramebufferStatus", out CheckFramebufferStatus);
			resolver.LoadHandle ("glCheckNamedFramebufferStatus", out CheckNamedFramebufferStatus);
			resolver.LoadHandle ("glClampColor", out ClampColor);
			resolver.LoadHandle ("glClearBufferData", out ClearBufferData);
			resolver.LoadHandle ("glClearBufferfi", out ClearBufferfi);
			resolver.LoadHandle ("glClearBufferfv", out ClearBufferfv);
			resolver.LoadHandle ("glClearBufferiv", out ClearBufferiv);
			resolver.LoadHandle ("glClearBufferSubData", out ClearBufferSubData);
			resolver.LoadHandle ("glClearBufferuiv", out ClearBufferuiv);
			resolver.LoadHandle ("glClearColor", out ClearColor);
			resolver.LoadHandle ("glClearDepthf", out ClearDepthf);
			resolver.LoadHandle ("glClearDepth", out ClearDepth);
			resolver.LoadHandle ("glClear", out Clear);
			resolver.LoadHandle ("glClearNamedBufferData", out ClearNamedBufferData);
			resolver.LoadHandle ("glClearNamedBufferSubData", out ClearNamedBufferSubData);
			resolver.LoadHandle ("glClearNamedFramebufferfi", out ClearNamedFramebufferfi);
			resolver.LoadHandle ("glClearNamedFramebufferfv", out ClearNamedFramebufferfv);
			resolver.LoadHandle ("glClearNamedFramebufferiv", out ClearNamedFramebufferiv);
			resolver.LoadHandle ("glClearNamedFramebufferuiv", out ClearNamedFramebufferuiv);
			resolver.LoadHandle ("glClearStencil", out ClearStencil);
			resolver.LoadHandle ("glClearTexImage", out ClearTexImage);
			resolver.LoadHandle ("glClearTexSubImage", out ClearTexSubImage);
			resolver.LoadHandle ("glClientWaitSync", out ClientWaitSync);
			resolver.LoadHandle ("glClipControl", out ClipControl);
			resolver.LoadHandle ("glColorMask", out ColorMask);
			resolver.LoadHandle ("glColorMaski", out ColorMaski);
			resolver.LoadHandle ("glCompileShader", out CompileShader);
			resolver.LoadHandle ("glCompressedTexImage1D", out CompressedTexImage1D);
			resolver.LoadHandle ("glCompressedTexImage2D", out CompressedTexImage2D);
			resolver.LoadHandle ("glCompressedTexImage3D", out CompressedTexImage3D);
			resolver.LoadHandle ("glCompressedTexSubImage1D", out CompressedTexSubImage1D);
			resolver.LoadHandle ("glCompressedTexSubImage2D", out CompressedTexSubImage2D);
			resolver.LoadHandle ("glCompressedTexSubImage3D", out CompressedTexSubImage3D);
			resolver.LoadHandle ("glCompressedTextureSubImage1D", out CompressedTextureSubImage1D);
			resolver.LoadHandle ("glCompressedTextureSubImage2D", out CompressedTextureSubImage2D);
			resolver.LoadHandle ("glCompressedTextureSubImage3D", out CompressedTextureSubImage3D);
			resolver.LoadHandle ("glCopyBufferSubData", out CopyBufferSubData);
			resolver.LoadHandle ("glCopyImageSubData", out CopyImageSubData);
			resolver.LoadHandle ("glCopyNamedBufferSubData", out CopyNamedBufferSubData);
			resolver.LoadHandle ("glCopyTexImage1D", out CopyTexImage1D);
			resolver.LoadHandle ("glCopyTexImage2D", out CopyTexImage2D);
			resolver.LoadHandle ("glCopyTexSubImage1D", out CopyTexSubImage1D);
			resolver.LoadHandle ("glCopyTexSubImage2D", out CopyTexSubImage2D);
			resolver.LoadHandle ("glCopyTexSubImage3D", out CopyTexSubImage3D);
			resolver.LoadHandle ("glCopyTextureSubImage1D", out CopyTextureSubImage1D);
			resolver.LoadHandle ("glCopyTextureSubImage2D", out CopyTextureSubImage2D);
			resolver.LoadHandle ("glCopyTextureSubImage3D", out CopyTextureSubImage3D);
			resolver.LoadHandle ("glCreateBuffers", out CreateBuffers);
			resolver.LoadHandle ("glCreateFramebuffers", out CreateFramebuffers);
			resolver.LoadHandle ("glCreateProgram", out CreateProgram);
			resolver.LoadHandle ("glCreateProgramPipelines", out CreateProgramPipelines);
			resolver.LoadHandle ("glCreateQueries", out CreateQueries);
			resolver.LoadHandle ("glCreateRenderbuffers", out CreateRenderbuffers);
			resolver.LoadHandle ("glCreateSamplers", out CreateSamplers);
			resolver.LoadHandle ("glCreateShader", out CreateShader);
			resolver.LoadHandle ("glCreateShaderProgramv", out CreateShaderProgramv);
			resolver.LoadHandle ("glCreateTextures", out CreateTextures);
			resolver.LoadHandle ("glCreateTransformFeedbacks", out CreateTransformFeedbacks);
			resolver.LoadHandle ("glCreateVertexArrays", out CreateVertexArrays);
			resolver.LoadHandle ("glCullFace", out CullFace);
			resolver.LoadHandle ("glDebugMessageCallback", out DebugMessageCallback);
			resolver.LoadHandle ("glDebugMessageControl", out DebugMessageControl);
			resolver.LoadHandle ("glDebugMessageInsert", out DebugMessageInsert);
			resolver.LoadHandle ("glDeleteBuffers", out DeleteBuffers);
			resolver.LoadHandle ("glDeleteFramebuffers", out DeleteFramebuffers);
			resolver.LoadHandle ("glDeleteProgram", out DeleteProgram);
			resolver.LoadHandle ("glDeleteProgramPipelines", out DeleteProgramPipelines);
			resolver.LoadHandle ("glDeleteQueries", out DeleteQueries);
			resolver.LoadHandle ("glDeleteRenderbuffers", out DeleteRenderbuffers);
			resolver.LoadHandle ("glDeleteSamplers", out DeleteSamplers);
			resolver.LoadHandle ("glDeleteShader", out DeleteShader);
			resolver.LoadHandle ("glDeleteSync", out DeleteSync);
			resolver.LoadHandle ("glDeleteTextures", out DeleteTextures);
			resolver.LoadHandle ("glDeleteTransformFeedbacks", out DeleteTransformFeedbacks);
			resolver.LoadHandle ("glDeleteVertexArrays", out DeleteVertexArrays);
			resolver.LoadHandle ("glDepthFunc", out DepthFunc);
			resolver.LoadHandle ("glDepthMask", out DepthMask);
			resolver.LoadHandle ("glDepthRangeArrayv", out DepthRangeArrayv);
			resolver.LoadHandle ("glDepthRangef", out DepthRangef);
			resolver.LoadHandle ("glDepthRange", out DepthRange);
			resolver.LoadHandle ("glDepthRangeIndexed", out DepthRangeIndexed);
			resolver.LoadHandle ("glDetachShader", out DetachShader);
			resolver.LoadHandle ("glDisable", out Disable);
			resolver.LoadHandle ("glDisablei", out Disablei);
			resolver.LoadHandle ("glDisableVertexArrayAttrib", out DisableVertexArrayAttrib);
			resolver.LoadHandle ("glDisableVertexAttribArray", out DisableVertexAttribArray);
			resolver.LoadHandle ("glDispatchCompute", out DispatchCompute);
			resolver.LoadHandle ("glDispatchComputeIndirect", out DispatchComputeIndirect);
			resolver.LoadHandle ("glDrawArrays", out DrawArrays);
			resolver.LoadHandle ("glDrawArraysIndirect", out DrawArraysIndirect);
			resolver.LoadHandle ("glDrawArraysInstancedBaseInstance", out DrawArraysInstancedBaseInstance);
			resolver.LoadHandle ("glDrawArraysInstanced", out DrawArraysInstanced);
			resolver.LoadHandle ("glDrawBuffer", out DrawBuffer);
			resolver.LoadHandle ("glDrawBuffers", out DrawBuffers);
			resolver.LoadHandle ("glDrawElementsBaseVertex", out DrawElementsBaseVertex);
			resolver.LoadHandle ("glDrawElements", out DrawElements);
			resolver.LoadHandle ("glDrawElementsIndirect", out DrawElementsIndirect);
			resolver.LoadHandle ("glDrawElementsInstancedBaseInstance", out DrawElementsInstancedBaseInstance);
			resolver.LoadHandle ("glDrawElementsInstancedBaseVertexBaseInstance", out DrawElementsInstancedBaseVertexBaseInstance);
			resolver.LoadHandle ("glDrawElementsInstancedBaseVertex", out DrawElementsInstancedBaseVertex);
			resolver.LoadHandle ("glDrawElementsInstanced", out DrawElementsInstanced);
			resolver.LoadHandle ("glDrawRangeElementsBaseVertex", out DrawRangeElementsBaseVertex);
			resolver.LoadHandle ("glDrawRangeElements", out DrawRangeElements);
			resolver.LoadHandle ("glDrawTransformFeedback", out DrawTransformFeedback);
			resolver.LoadHandle ("glDrawTransformFeedbackInstanced", out DrawTransformFeedbackInstanced);
			resolver.LoadHandle ("glDrawTransformFeedbackStream", out DrawTransformFeedbackStream);
			resolver.LoadHandle ("glDrawTransformFeedbackStreamInstanced", out DrawTransformFeedbackStreamInstanced);
			resolver.LoadHandle ("glEnable", out Enable);
			resolver.LoadHandle ("glEnablei", out Enablei);
			resolver.LoadHandle ("glEnableVertexArrayAttrib", out EnableVertexArrayAttrib);
			resolver.LoadHandle ("glEnableVertexAttribArray", out EnableVertexAttribArray);
			resolver.LoadHandle ("glEndConditionalRender", out EndConditionalRender);
			resolver.LoadHandle ("glEndQuery", out EndQuery);
			resolver.LoadHandle ("glEndQueryIndexed", out EndQueryIndexed);
			resolver.LoadHandle ("glEndTransformFeedback", out EndTransformFeedback);
			resolver.LoadHandle ("glFenceSync", out FenceSync);
			resolver.LoadHandle ("glFinish", out Finish);
			resolver.LoadHandle ("glFlush", out Flush);
			resolver.LoadHandle ("glFlushMappedBufferRange", out FlushMappedBufferRange);
			resolver.LoadHandle ("glFlushMappedNamedBufferRange", out FlushMappedNamedBufferRange);
			resolver.LoadHandle ("glFramebufferParameteri", out FramebufferParameteri);
			resolver.LoadHandle ("glFramebufferRenderbuffer", out FramebufferRenderbuffer);
			resolver.LoadHandle ("glFramebufferTexture1D", out FramebufferTexture1D);
			resolver.LoadHandle ("glFramebufferTexture2D", out FramebufferTexture2D);
			resolver.LoadHandle ("glFramebufferTexture3D", out FramebufferTexture3D);
			resolver.LoadHandle ("glFramebufferTexture", out FramebufferTexture);
			resolver.LoadHandle ("glFramebufferTextureLayer", out FramebufferTextureLayer);
			resolver.LoadHandle ("glFrontFace", out FrontFace);
			resolver.LoadHandle ("glGenBuffers", out GenBuffers);
			resolver.LoadHandle ("glGenerateMipmap", out GenerateMipmap);
			resolver.LoadHandle ("glGenerateTextureMipmap", out GenerateTextureMipmap);
			resolver.LoadHandle ("glGenFramebuffers", out GenFramebuffers);
			resolver.LoadHandle ("glGenProgramPipelines", out GenProgramPipelines);
			resolver.LoadHandle ("glGenQueries", out GenQueries);
			resolver.LoadHandle ("glGenRenderbuffers", out GenRenderbuffers);
			resolver.LoadHandle ("glGenSamplers", out GenSamplers);
			resolver.LoadHandle ("glGenTextures", out GenTextures);
			resolver.LoadHandle ("glGenTransformFeedbacks", out GenTransformFeedbacks);
			resolver.LoadHandle ("glGenVertexArrays", out GenVertexArrays);
			resolver.LoadHandle ("glGetActiveAtomicCounterBufferiv", out GetActiveAtomicCounterBufferiv);
			resolver.LoadHandle ("glGetActiveAttrib", out GetActiveAttrib);
			resolver.LoadHandle ("glGetActiveSubroutineName", out GetActiveSubroutineName);
			resolver.LoadHandle ("glGetActiveSubroutineUniformiv", out GetActiveSubroutineUniformiv);
			resolver.LoadHandle ("glGetActiveSubroutineUniformName", out GetActiveSubroutineUniformName);
			resolver.LoadHandle ("glGetActiveUniformBlockiv", out GetActiveUniformBlockiv);
			resolver.LoadHandle ("glGetActiveUniformBlockName", out GetActiveUniformBlockName);
			resolver.LoadHandle ("glGetActiveUniform", out GetActiveUniform);
			resolver.LoadHandle ("glGetActiveUniformName", out GetActiveUniformName);
			resolver.LoadHandle ("glGetActiveUniformsiv", out GetActiveUniformsiv);
			resolver.LoadHandle ("glGetAttachedShaders", out GetAttachedShaders);
			resolver.LoadHandle ("glGetAttribLocation", out GetAttribLocation);
			resolver.LoadHandle ("glGetBooleani_v", out GetBooleani_v);
			resolver.LoadHandle ("glGetBooleanv", out GetBooleanv);
			resolver.LoadHandle ("glGetBufferParameteri64v", out GetBufferParameteri64v);
			resolver.LoadHandle ("glGetBufferParameteriv", out GetBufferParameteriv);
			resolver.LoadHandle ("glGetBufferPointerv", out GetBufferPointerv);
			resolver.LoadHandle ("glGetBufferSubData", out GetBufferSubData);
			resolver.LoadHandle ("glGetCompressedTexImage", out GetCompressedTexImage);
			resolver.LoadHandle ("glGetCompressedTextureImage", out GetCompressedTextureImage);
			resolver.LoadHandle ("glGetCompressedTextureSubImage", out GetCompressedTextureSubImage);
			resolver.LoadHandle ("glGetDebugMessageLog", out GetDebugMessageLog);
			resolver.LoadHandle ("glGetDoublei_v", out GetDoublei_v);
			resolver.LoadHandle ("glGetDoublev", out GetDoublev);
			resolver.LoadHandle ("glGetError", out GetError);
			resolver.LoadHandle ("glGetFloati_v", out GetFloati_v);
			resolver.LoadHandle ("glGetFloatv", out GetFloatv);
			resolver.LoadHandle ("glGetFragDataIndex", out GetFragDataIndex);
			resolver.LoadHandle ("glGetFragDataLocation", out GetFragDataLocation);
			resolver.LoadHandle ("glGetFramebufferAttachmentParameteriv", out GetFramebufferAttachmentParameteriv);
			resolver.LoadHandle ("glGetFramebufferParameteriv", out GetFramebufferParameteriv);
			resolver.LoadHandle ("glGetGraphicsResetStatus", out GetGraphicsResetStatus);
			resolver.LoadHandle ("glGetInteger64i_v", out GetInteger64i_v);
			resolver.LoadHandle ("glGetInteger64v", out GetInteger64v);
			resolver.LoadHandle ("glGetIntegeri_v", out GetIntegeri_v);
			resolver.LoadHandle ("glGetIntegerv", out GetIntegerv);
			resolver.LoadHandle ("glGetInternalformati64v", out GetInternalformati64v);
			resolver.LoadHandle ("glGetInternalformativ", out GetInternalformativ);
			resolver.LoadHandle ("glGetMultisamplefv", out GetMultisamplefv);
			resolver.LoadHandle ("glGetNamedBufferParameteri64v", out GetNamedBufferParameteri64v);
			resolver.LoadHandle ("glGetNamedBufferParameteriv", out GetNamedBufferParameteriv);
			resolver.LoadHandle ("glGetNamedBufferPointerv", out GetNamedBufferPointerv);
			resolver.LoadHandle ("glGetNamedBufferSubData", out GetNamedBufferSubData);
			resolver.LoadHandle ("glGetNamedFramebufferAttachmentParameteriv", out GetNamedFramebufferAttachmentParameteriv);
			resolver.LoadHandle ("glGetNamedFramebufferParameteriv", out GetNamedFramebufferParameteriv);
			resolver.LoadHandle ("glGetNamedRenderbufferParameteriv", out GetNamedRenderbufferParameteriv);
			resolver.LoadHandle ("glGetnCompressedTexImage", out GetnCompressedTexImage);
			resolver.LoadHandle ("glGetnTexImage", out GetnTexImage);
			resolver.LoadHandle ("glGetnUniformdv", out GetnUniformdv);
			resolver.LoadHandle ("glGetnUniformfv", out GetnUniformfv);
			resolver.LoadHandle ("glGetnUniformiv", out GetnUniformiv);
			resolver.LoadHandle ("glGetnUniformuiv", out GetnUniformuiv);
			resolver.LoadHandle ("glGetObjectLabel", out GetObjectLabel);
			resolver.LoadHandle ("glGetObjectPtrLabel", out GetObjectPtrLabel);
			resolver.LoadHandle ("glGetProgramBinary", out GetProgramBinary);
			resolver.LoadHandle ("glGetProgramInfoLog", out GetProgramInfoLog);
			resolver.LoadHandle ("glGetProgramInterfaceiv", out GetProgramInterfaceiv);
			resolver.LoadHandle ("glGetProgramiv", out GetProgramiv);
			resolver.LoadHandle ("glGetProgramPipelineInfoLog", out GetProgramPipelineInfoLog);
			resolver.LoadHandle ("glGetProgramPipelineiv", out GetProgramPipelineiv);
			resolver.LoadHandle ("glGetProgramResourceIndex", out GetProgramResourceIndex);
			resolver.LoadHandle ("glGetProgramResourceiv", out GetProgramResourceiv);
			resolver.LoadHandle ("glGetProgramResourceLocation", out GetProgramResourceLocation);
			resolver.LoadHandle ("glGetProgramResourceLocationIndex", out GetProgramResourceLocationIndex);
			resolver.LoadHandle ("glGetProgramResourceName", out GetProgramResourceName);
			resolver.LoadHandle ("glGetProgramStageiv", out GetProgramStageiv);
			resolver.LoadHandle ("glGetQueryBufferObjecti64v", out GetQueryBufferObjecti64v);
			resolver.LoadHandle ("glGetQueryBufferObjectiv", out GetQueryBufferObjectiv);
			resolver.LoadHandle ("glGetQueryBufferObjectui64v", out GetQueryBufferObjectui64v);
			resolver.LoadHandle ("glGetQueryBufferObjectuiv", out GetQueryBufferObjectuiv);
			resolver.LoadHandle ("glGetQueryIndexediv", out GetQueryIndexediv);
			resolver.LoadHandle ("glGetQueryiv", out GetQueryiv);
			resolver.LoadHandle ("glGetQueryObjecti64v", out GetQueryObjecti64v);
			resolver.LoadHandle ("glGetQueryObjectiv", out GetQueryObjectiv);
			resolver.LoadHandle ("glGetQueryObjectui64v", out GetQueryObjectui64v);
			resolver.LoadHandle ("glGetQueryObjectuiv", out GetQueryObjectuiv);
			resolver.LoadHandle ("glGetRenderbufferParameteriv", out GetRenderbufferParameteriv);
			resolver.LoadHandle ("glGetSamplerParameterfv", out GetSamplerParameterfv);
			resolver.LoadHandle ("glGetSamplerParameterIiv", out GetSamplerParameterIiv);
			resolver.LoadHandle ("glGetSamplerParameterIuiv", out GetSamplerParameterIuiv);
			resolver.LoadHandle ("glGetSamplerParameteriv", out GetSamplerParameteriv);
			resolver.LoadHandle ("glGetShaderInfoLog", out GetShaderInfoLog);
			resolver.LoadHandle ("glGetShaderiv", out GetShaderiv);
			resolver.LoadHandle ("glGetShaderPrecisionFormat", out GetShaderPrecisionFormat);
			resolver.LoadHandle ("glGetShaderSource", out GetShaderSource);
			resolver.LoadHandle ("glGetString", out GetString);
			resolver.LoadHandle ("glGetStringi", out GetStringi);
			resolver.LoadHandle ("glGetSubroutineIndex", out GetSubroutineIndex);
			resolver.LoadHandle ("glGetSubroutineUniformLocation", out GetSubroutineUniformLocation);
			resolver.LoadHandle ("glGetSynciv", out GetSynciv);
			resolver.LoadHandle ("glGetTexImage", out GetTexImage);
			resolver.LoadHandle ("glGetTexLevelParameterfv", out GetTexLevelParameterfv);
			resolver.LoadHandle ("glGetTexLevelParameteriv", out GetTexLevelParameteriv);
			resolver.LoadHandle ("glGetTexParameterfv", out GetTexParameterfv);
			resolver.LoadHandle ("glGetTexParameterIiv", out GetTexParameterIiv);
			resolver.LoadHandle ("glGetTexParameterIuiv", out GetTexParameterIuiv);
			resolver.LoadHandle ("glGetTexParameteriv", out GetTexParameteriv);
			resolver.LoadHandle ("glGetTextureImage", out GetTextureImage);
			resolver.LoadHandle ("glGetTextureLevelParameterfv", out GetTextureLevelParameterfv);
			resolver.LoadHandle ("glGetTextureLevelParameteriv", out GetTextureLevelParameteriv);
			resolver.LoadHandle ("glGetTextureParameterfv", out GetTextureParameterfv);
			resolver.LoadHandle ("glGetTextureParameterIiv", out GetTextureParameterIiv);
			resolver.LoadHandle ("glGetTextureParameterIuiv", out GetTextureParameterIuiv);
			resolver.LoadHandle ("glGetTextureParameteriv", out GetTextureParameteriv);
			resolver.LoadHandle ("glGetTextureSubImage", out GetTextureSubImage);
			resolver.LoadHandle ("glGetTransformFeedbacki_v", out GetTransformFeedbacki_v);
			resolver.LoadHandle ("glGetTransformFeedbacki64_v", out GetTransformFeedbacki64_v);
			resolver.LoadHandle ("glGetTransformFeedbackiv", out GetTransformFeedbackiv);
			resolver.LoadHandle ("glGetTransformFeedbackVarying", out GetTransformFeedbackVarying);
			resolver.LoadHandle ("glGetUniformBlockIndex", out GetUniformBlockIndex);
			resolver.LoadHandle ("glGetUniformdv", out GetUniformdv);
			resolver.LoadHandle ("glGetUniformfv", out GetUniformfv);
			resolver.LoadHandle ("glGetUniformIndices", out GetUniformIndices);
			resolver.LoadHandle ("glGetUniformiv", out GetUniformiv);
			resolver.LoadHandle ("glGetUniformLocation", out GetUniformLocation);
			resolver.LoadHandle ("glGetUniformSubroutineuiv", out GetUniformSubroutineuiv);
			resolver.LoadHandle ("glGetUniformuiv", out GetUniformuiv);
			resolver.LoadHandle ("glGetVertexArrayIndexed64iv", out GetVertexArrayIndexed64iv);
			resolver.LoadHandle ("glGetVertexArrayIndexediv", out GetVertexArrayIndexediv);
			resolver.LoadHandle ("glGetVertexArrayiv", out GetVertexArrayiv);
			resolver.LoadHandle ("glGetVertexAttribdv", out GetVertexAttribdv);
			resolver.LoadHandle ("glGetVertexAttribfv", out GetVertexAttribfv);
			resolver.LoadHandle ("glGetVertexAttribIiv", out GetVertexAttribIiv);
			resolver.LoadHandle ("glGetVertexAttribIuiv", out GetVertexAttribIuiv);
			resolver.LoadHandle ("glGetVertexAttribiv", out GetVertexAttribiv);
			resolver.LoadHandle ("glGetVertexAttribLdv", out GetVertexAttribLdv);
			resolver.LoadHandle ("glGetVertexAttribPointerv", out GetVertexAttribPointerv);
			resolver.LoadHandle ("glHint", out Hint);
			resolver.LoadHandle ("glInvalidateBufferData", out InvalidateBufferData);
			resolver.LoadHandle ("glInvalidateBufferSubData", out InvalidateBufferSubData);
			resolver.LoadHandle ("glInvalidateFramebuffer", out InvalidateFramebuffer);
			resolver.LoadHandle ("glInvalidateNamedFramebufferData", out InvalidateNamedFramebufferData);
			resolver.LoadHandle ("glInvalidateNamedFramebufferSubData", out InvalidateNamedFramebufferSubData);
			resolver.LoadHandle ("glInvalidateSubFramebuffer", out InvalidateSubFramebuffer);
			resolver.LoadHandle ("glInvalidateTexImage", out InvalidateTexImage);
			resolver.LoadHandle ("glInvalidateTexSubImage", out InvalidateTexSubImage);
			resolver.LoadHandle ("glIsBuffer", out IsBuffer);
			resolver.LoadHandle ("glIsEnabled", out IsEnabled);
			resolver.LoadHandle ("glIsEnabledi", out IsEnabledi);
			resolver.LoadHandle ("glIsFramebuffer", out IsFramebuffer);
			resolver.LoadHandle ("glIsProgram", out IsProgram);
			resolver.LoadHandle ("glIsProgramPipeline", out IsProgramPipeline);
			resolver.LoadHandle ("glIsQuery", out IsQuery);
			resolver.LoadHandle ("glIsRenderbuffer", out IsRenderbuffer);
			resolver.LoadHandle ("glIsSampler", out IsSampler);
			resolver.LoadHandle ("glIsShader", out IsShader);
			resolver.LoadHandle ("glIsSync", out IsSync);
			resolver.LoadHandle ("glIsTexture", out IsTexture);
			resolver.LoadHandle ("glIsTransformFeedback", out IsTransformFeedback);
			resolver.LoadHandle ("glIsVertexArray", out IsVertexArray);
			resolver.LoadHandle ("glLineWidth", out LineWidth);
			resolver.LoadHandle ("glLinkProgram", out LinkProgram);
			resolver.LoadHandle ("glLogicOp", out LogicOp);
			resolver.LoadHandle ("glMapBuffer", out MapBuffer);
			resolver.LoadHandle ("glMapBufferRange", out MapBufferRange);
			resolver.LoadHandle ("glMapNamedBuffer", out MapNamedBuffer);
			resolver.LoadHandle ("glMapNamedBufferRange", out MapNamedBufferRange);
			resolver.LoadHandle ("glMemoryBarrierByRegion", out MemoryBarrierByRegion);
			resolver.LoadHandle ("glMemoryBarrier", out MemoryBarrier);
			resolver.LoadHandle ("glMinSampleShading", out MinSampleShading);
			resolver.LoadHandle ("glMultiDrawArrays", out MultiDrawArrays);
			resolver.LoadHandle ("glMultiDrawArraysIndirect", out MultiDrawArraysIndirect);
			resolver.LoadHandle ("glMultiDrawElementsBaseVertex", out MultiDrawElementsBaseVertex);
			resolver.LoadHandle ("glMultiDrawElements", out MultiDrawElements);
			resolver.LoadHandle ("glMultiDrawElementsIndirect", out MultiDrawElementsIndirect);
			resolver.LoadHandle ("glNamedBufferData", out NamedBufferData);
			resolver.LoadHandle ("glNamedBufferStorage", out NamedBufferStorage);
			resolver.LoadHandle ("glNamedBufferSubData", out NamedBufferSubData);
			resolver.LoadHandle ("glNamedFramebufferDrawBuffer", out NamedFramebufferDrawBuffer);
			resolver.LoadHandle ("glNamedFramebufferDrawBuffers", out NamedFramebufferDrawBuffers);
			resolver.LoadHandle ("glNamedFramebufferParameteri", out NamedFramebufferParameteri);
			resolver.LoadHandle ("glNamedFramebufferReadBuffer", out NamedFramebufferReadBuffer);
			resolver.LoadHandle ("glNamedFramebufferRenderbuffer", out NamedFramebufferRenderbuffer);
			resolver.LoadHandle ("glNamedFramebufferTexture", out NamedFramebufferTexture);
			resolver.LoadHandle ("glNamedFramebufferTextureLayer", out NamedFramebufferTextureLayer);
			resolver.LoadHandle ("glNamedRenderbufferStorage", out NamedRenderbufferStorage);
			resolver.LoadHandle ("glNamedRenderbufferStorageMultisample", out NamedRenderbufferStorageMultisample);
			resolver.LoadHandle ("glObjectLabel", out ObjectLabel);
			resolver.LoadHandle ("glObjectPtrLabel", out ObjectPtrLabel);
			resolver.LoadHandle ("glPatchParameterfv", out PatchParameterfv);
			resolver.LoadHandle ("glPatchParameteri", out PatchParameteri);
			resolver.LoadHandle ("glPauseTransformFeedback", out PauseTransformFeedback);
			resolver.LoadHandle ("glPixelStoref", out PixelStoref);
			resolver.LoadHandle ("glPixelStorei", out PixelStorei);
			resolver.LoadHandle ("glPointParameterf", out PointParameterf);
			resolver.LoadHandle ("glPointParameterfv", out PointParameterfv);
			resolver.LoadHandle ("glPointParameteri", out PointParameteri);
			resolver.LoadHandle ("glPointParameteriv", out PointParameteriv);
			resolver.LoadHandle ("glPointSize", out PointSize);
			resolver.LoadHandle ("glPolygonMode", out PolygonMode);
			resolver.LoadHandle ("glPolygonOffset", out PolygonOffset);
			resolver.LoadHandle ("glPopDebugGroup", out PopDebugGroup);
			resolver.LoadHandle ("glPrimitiveRestartIndex", out PrimitiveRestartIndex);
			resolver.LoadHandle ("glProgramBinary", out ProgramBinary);
			resolver.LoadHandle ("glProgramParameteri", out ProgramParameteri);
			resolver.LoadHandle ("glProgramUniform1d", out ProgramUniform1d);
			resolver.LoadHandle ("glProgramUniform1dv", out ProgramUniform1dv);
			resolver.LoadHandle ("glProgramUniform1f", out ProgramUniform1f);
			resolver.LoadHandle ("glProgramUniform1fv", out ProgramUniform1fv);
			resolver.LoadHandle ("glProgramUniform1i", out ProgramUniform1i);
			resolver.LoadHandle ("glProgramUniform1iv", out ProgramUniform1iv);
			resolver.LoadHandle ("glProgramUniform1ui", out ProgramUniform1ui);
			resolver.LoadHandle ("glProgramUniform1uiv", out ProgramUniform1uiv);
			resolver.LoadHandle ("glProgramUniform2d", out ProgramUniform2d);
			resolver.LoadHandle ("glProgramUniform2dv", out ProgramUniform2dv);
			resolver.LoadHandle ("glProgramUniform2f", out ProgramUniform2f);
			resolver.LoadHandle ("glProgramUniform2fv", out ProgramUniform2fv);
			resolver.LoadHandle ("glProgramUniform2i", out ProgramUniform2i);
			resolver.LoadHandle ("glProgramUniform2iv", out ProgramUniform2iv);
			resolver.LoadHandle ("glProgramUniform2ui", out ProgramUniform2ui);
			resolver.LoadHandle ("glProgramUniform2uiv", out ProgramUniform2uiv);
			resolver.LoadHandle ("glProgramUniform3d", out ProgramUniform3d);
			resolver.LoadHandle ("glProgramUniform3dv", out ProgramUniform3dv);
			resolver.LoadHandle ("glProgramUniform3f", out ProgramUniform3f);
			resolver.LoadHandle ("glProgramUniform3fv", out ProgramUniform3fv);
			resolver.LoadHandle ("glProgramUniform3i", out ProgramUniform3i);
			resolver.LoadHandle ("glProgramUniform3iv", out ProgramUniform3iv);
			resolver.LoadHandle ("glProgramUniform3ui", out ProgramUniform3ui);
			resolver.LoadHandle ("glProgramUniform3uiv", out ProgramUniform3uiv);
			resolver.LoadHandle ("glProgramUniform4d", out ProgramUniform4d);
			resolver.LoadHandle ("glProgramUniform4dv", out ProgramUniform4dv);
			resolver.LoadHandle ("glProgramUniform4f", out ProgramUniform4f);
			resolver.LoadHandle ("glProgramUniform4fv", out ProgramUniform4fv);
			resolver.LoadHandle ("glProgramUniform4i", out ProgramUniform4i);
			resolver.LoadHandle ("glProgramUniform4iv", out ProgramUniform4iv);
			resolver.LoadHandle ("glProgramUniform4ui", out ProgramUniform4ui);
			resolver.LoadHandle ("glProgramUniform4uiv", out ProgramUniform4uiv);
			resolver.LoadHandle ("glProgramUniformMatrix2dv", out ProgramUniformMatrix2dv);
			resolver.LoadHandle ("glProgramUniformMatrix2fv", out ProgramUniformMatrix2fv);
			resolver.LoadHandle ("glProgramUniformMatrix2x3dv", out ProgramUniformMatrix2x3dv);
			resolver.LoadHandle ("glProgramUniformMatrix2x3fv", out ProgramUniformMatrix2x3fv);
			resolver.LoadHandle ("glProgramUniformMatrix2x4dv", out ProgramUniformMatrix2x4dv);
			resolver.LoadHandle ("glProgramUniformMatrix2x4fv", out ProgramUniformMatrix2x4fv);
			resolver.LoadHandle ("glProgramUniformMatrix3dv", out ProgramUniformMatrix3dv);
			resolver.LoadHandle ("glProgramUniformMatrix3fv", out ProgramUniformMatrix3fv);
			resolver.LoadHandle ("glProgramUniformMatrix3x2dv", out ProgramUniformMatrix3x2dv);
			resolver.LoadHandle ("glProgramUniformMatrix3x2fv", out ProgramUniformMatrix3x2fv);
			resolver.LoadHandle ("glProgramUniformMatrix3x4dv", out ProgramUniformMatrix3x4dv);
			resolver.LoadHandle ("glProgramUniformMatrix3x4fv", out ProgramUniformMatrix3x4fv);
			resolver.LoadHandle ("glProgramUniformMatrix4dv", out ProgramUniformMatrix4dv);
			resolver.LoadHandle ("glProgramUniformMatrix4fv", out ProgramUniformMatrix4fv);
			resolver.LoadHandle ("glProgramUniformMatrix4x2dv", out ProgramUniformMatrix4x2dv);
			resolver.LoadHandle ("glProgramUniformMatrix4x2fv", out ProgramUniformMatrix4x2fv);
			resolver.LoadHandle ("glProgramUniformMatrix4x3dv", out ProgramUniformMatrix4x3dv);
			resolver.LoadHandle ("glProgramUniformMatrix4x3fv", out ProgramUniformMatrix4x3fv);
			resolver.LoadHandle ("glProvokingVertex", out ProvokingVertex);
			resolver.LoadHandle ("glPushDebugGroup", out PushDebugGroup);
			resolver.LoadHandle ("glQueryCounter", out QueryCounter);
			resolver.LoadHandle ("glReadBuffer", out ReadBuffer);
			resolver.LoadHandle ("glReadnPixels", out ReadnPixels);
			resolver.LoadHandle ("glReadPixels", out ReadPixels);
			resolver.LoadHandle ("glReleaseShaderCompiler", out ReleaseShaderCompiler);
			resolver.LoadHandle ("glRenderbufferStorage", out RenderbufferStorage);
			resolver.LoadHandle ("glRenderbufferStorageMultisample", out RenderbufferStorageMultisample);
			resolver.LoadHandle ("glResumeTransformFeedback", out ResumeTransformFeedback);
			resolver.LoadHandle ("glSampleCoverage", out SampleCoverage);
			resolver.LoadHandle ("glSampleMaski", out SampleMaski);
			resolver.LoadHandle ("glSamplerParameterf", out SamplerParameterf);
			resolver.LoadHandle ("glSamplerParameterfv", out SamplerParameterfv);
			resolver.LoadHandle ("glSamplerParameteri", out SamplerParameteri);
			resolver.LoadHandle ("glSamplerParameterIiv", out SamplerParameterIiv);
			resolver.LoadHandle ("glSamplerParameterIuiv", out SamplerParameterIuiv);
			resolver.LoadHandle ("glSamplerParameteriv", out SamplerParameteriv);
			resolver.LoadHandle ("glScissorArrayv", out ScissorArrayv);
			resolver.LoadHandle ("glScissor", out Scissor);
			resolver.LoadHandle ("glScissorIndexed", out ScissorIndexed);
			resolver.LoadHandle ("glScissorIndexedv", out ScissorIndexedv);
			resolver.LoadHandle ("glShaderBinary", out ShaderBinary);
			resolver.LoadHandle ("glShaderSource", out ShaderSource);
			resolver.LoadHandle ("glShaderStorageBlockBinding", out ShaderStorageBlockBinding);
			resolver.LoadHandle ("glStencilFunc", out StencilFunc);
			resolver.LoadHandle ("glStencilFuncSeparate", out StencilFuncSeparate);
			resolver.LoadHandle ("glStencilMask", out StencilMask);
			resolver.LoadHandle ("glStencilMaskSeparate", out StencilMaskSeparate);
			resolver.LoadHandle ("glStencilOp", out StencilOp);
			resolver.LoadHandle ("glStencilOpSeparate", out StencilOpSeparate);
			resolver.LoadHandle ("glTexBuffer", out TexBuffer);
			resolver.LoadHandle ("glTexBufferRange", out TexBufferRange);
			resolver.LoadHandle ("glTexImage1D", out TexImage1D);
			resolver.LoadHandle ("glTexImage2D", out TexImage2D);
			resolver.LoadHandle ("glTexImage2DMultisample", out TexImage2DMultisample);
			resolver.LoadHandle ("glTexImage3D", out TexImage3D);
			resolver.LoadHandle ("glTexImage3DMultisample", out TexImage3DMultisample);
			resolver.LoadHandle ("glTexParameterf", out TexParameterf);
			resolver.LoadHandle ("glTexParameterfv", out TexParameterfv);
			resolver.LoadHandle ("glTexParameteri", out TexParameteri);
			resolver.LoadHandle ("glTexParameterIiv", out TexParameterIiv);
			resolver.LoadHandle ("glTexParameterIuiv", out TexParameterIuiv);
			resolver.LoadHandle ("glTexParameteriv", out TexParameteriv);
			resolver.LoadHandle ("glTexStorage1D", out TexStorage1D);
			resolver.LoadHandle ("glTexStorage2D", out TexStorage2D);
			resolver.LoadHandle ("glTexStorage2DMultisample", out TexStorage2DMultisample);
			resolver.LoadHandle ("glTexStorage3D", out TexStorage3D);
			resolver.LoadHandle ("glTexStorage3DMultisample", out TexStorage3DMultisample);
			resolver.LoadHandle ("glTexSubImage1D", out TexSubImage1D);
			resolver.LoadHandle ("glTexSubImage2D", out TexSubImage2D);
			resolver.LoadHandle ("glTexSubImage3D", out TexSubImage3D);
			resolver.LoadHandle ("glTextureBarrier", out TextureBarrier);
			resolver.LoadHandle ("glTextureBuffer", out TextureBuffer);
			resolver.LoadHandle ("glTextureBufferRange", out TextureBufferRange);
			resolver.LoadHandle ("glTextureParameterf", out TextureParameterf);
			resolver.LoadHandle ("glTextureParameterfv", out TextureParameterfv);
			resolver.LoadHandle ("glTextureParameteri", out TextureParameteri);
			resolver.LoadHandle ("glTextureParameterIiv", out TextureParameterIiv);
			resolver.LoadHandle ("glTextureParameterIuiv", out TextureParameterIuiv);
			resolver.LoadHandle ("glTextureParameteriv", out TextureParameteriv);
			resolver.LoadHandle ("glTextureStorage1D", out TextureStorage1D);
			resolver.LoadHandle ("glTextureStorage2D", out TextureStorage2D);
			resolver.LoadHandle ("glTextureStorage2DMultisample", out TextureStorage2DMultisample);
			resolver.LoadHandle ("glTextureStorage3D", out TextureStorage3D);
			resolver.LoadHandle ("glTextureStorage3DMultisample", out TextureStorage3DMultisample);
			resolver.LoadHandle ("glTextureSubImage1D", out TextureSubImage1D);
			resolver.LoadHandle ("glTextureSubImage2D", out TextureSubImage2D);
			resolver.LoadHandle ("glTextureSubImage3D", out TextureSubImage3D);
			resolver.LoadHandle ("glTextureView", out TextureView);
			resolver.LoadHandle ("glTransformFeedbackBufferBase", out TransformFeedbackBufferBase);
			resolver.LoadHandle ("glTransformFeedbackBufferRange", out TransformFeedbackBufferRange);
			resolver.LoadHandle ("glTransformFeedbackVaryings", out TransformFeedbackVaryings);
			resolver.LoadHandle ("glUniform1d", out Uniform1d);
			resolver.LoadHandle ("glUniform1dv", out Uniform1dv);
			resolver.LoadHandle ("glUniform1f", out Uniform1f);
			resolver.LoadHandle ("glUniform1fv", out Uniform1fv);
			resolver.LoadHandle ("glUniform1i", out Uniform1i);
			resolver.LoadHandle ("glUniform1iv", out Uniform1iv);
			resolver.LoadHandle ("glUniform1ui", out Uniform1ui);
			resolver.LoadHandle ("glUniform1uiv", out Uniform1uiv);
			resolver.LoadHandle ("glUniform2d", out Uniform2d);
			resolver.LoadHandle ("glUniform2dv", out Uniform2dv);
			resolver.LoadHandle ("glUniform2f", out Uniform2f);
			resolver.LoadHandle ("glUniform2fv", out Uniform2fv);
			resolver.LoadHandle ("glUniform2i", out Uniform2i);
			resolver.LoadHandle ("glUniform2iv", out Uniform2iv);
			resolver.LoadHandle ("glUniform2ui", out Uniform2ui);
			resolver.LoadHandle ("glUniform2uiv", out Uniform2uiv);
			resolver.LoadHandle ("glUniform3d", out Uniform3d);
			resolver.LoadHandle ("glUniform3dv", out Uniform3dv);
			resolver.LoadHandle ("glUniform3f", out Uniform3f);
			resolver.LoadHandle ("glUniform3fv", out Uniform3fv);
			resolver.LoadHandle ("glUniform3i", out Uniform3i);
			resolver.LoadHandle ("glUniform3iv", out Uniform3iv);
			resolver.LoadHandle ("glUniform3ui", out Uniform3ui);
			resolver.LoadHandle ("glUniform3uiv", out Uniform3uiv);
			resolver.LoadHandle ("glUniform4d", out Uniform4d);
			resolver.LoadHandle ("glUniform4dv", out Uniform4dv);
			resolver.LoadHandle ("glUniform4f", out Uniform4f);
			resolver.LoadHandle ("glUniform4fv", out Uniform4fv);
			resolver.LoadHandle ("glUniform4i", out Uniform4i);
			resolver.LoadHandle ("glUniform4iv", out Uniform4iv);
			resolver.LoadHandle ("glUniform4ui", out Uniform4ui);
			resolver.LoadHandle ("glUniform4uiv", out Uniform4uiv);
			resolver.LoadHandle ("glUniformBlockBinding", out UniformBlockBinding);
			resolver.LoadHandle ("glUniformMatrix2dv", out UniformMatrix2dv);
			resolver.LoadHandle ("glUniformMatrix2fv", out UniformMatrix2fv);
			resolver.LoadHandle ("glUniformMatrix2x3dv", out UniformMatrix2x3dv);
			resolver.LoadHandle ("glUniformMatrix2x3fv", out UniformMatrix2x3fv);
			resolver.LoadHandle ("glUniformMatrix2x4dv", out UniformMatrix2x4dv);
			resolver.LoadHandle ("glUniformMatrix2x4fv", out UniformMatrix2x4fv);
			resolver.LoadHandle ("glUniformMatrix3dv", out UniformMatrix3dv);
			resolver.LoadHandle ("glUniformMatrix3fv", out UniformMatrix3fv);
			resolver.LoadHandle ("glUniformMatrix3x2dv", out UniformMatrix3x2dv);
			resolver.LoadHandle ("glUniformMatrix3x2fv", out UniformMatrix3x2fv);
			resolver.LoadHandle ("glUniformMatrix3x4dv", out UniformMatrix3x4dv);
			resolver.LoadHandle ("glUniformMatrix3x4fv", out UniformMatrix3x4fv);
			resolver.LoadHandle ("glUniformMatrix4dv", out UniformMatrix4dv);
			resolver.LoadHandle ("glUniformMatrix4fv", out UniformMatrix4fv);
			resolver.LoadHandle ("glUniformMatrix4x2dv", out UniformMatrix4x2dv);
			resolver.LoadHandle ("glUniformMatrix4x2fv", out UniformMatrix4x2fv);
			resolver.LoadHandle ("glUniformMatrix4x3dv", out UniformMatrix4x3dv);
			resolver.LoadHandle ("glUniformMatrix4x3fv", out UniformMatrix4x3fv);
			resolver.LoadHandle ("glUniformSubroutinesuiv", out UniformSubroutinesuiv);
			resolver.LoadHandle ("glUnmapBuffer", out UnmapBuffer);
			resolver.LoadHandle ("glUnmapNamedBuffer", out UnmapNamedBuffer);
			resolver.LoadHandle ("glUseProgram", out UseProgram);
			resolver.LoadHandle ("glUseProgramStages", out UseProgramStages);
			resolver.LoadHandle ("glValidateProgram", out ValidateProgram);
			resolver.LoadHandle ("glValidateProgramPipeline", out ValidateProgramPipeline);
			resolver.LoadHandle ("glVertexArrayAttribBinding", out VertexArrayAttribBinding);
			resolver.LoadHandle ("glVertexArrayAttribFormat", out VertexArrayAttribFormat);
			resolver.LoadHandle ("glVertexArrayAttribIFormat", out VertexArrayAttribIFormat);
			resolver.LoadHandle ("glVertexArrayAttribLFormat", out VertexArrayAttribLFormat);
			resolver.LoadHandle ("glVertexArrayBindingDivisor", out VertexArrayBindingDivisor);
			resolver.LoadHandle ("glVertexArrayElementBuffer", out VertexArrayElementBuffer);
			resolver.LoadHandle ("glVertexArrayVertexBuffer", out VertexArrayVertexBuffer);
			resolver.LoadHandle ("glVertexArrayVertexBuffers", out VertexArrayVertexBuffers);
			resolver.LoadHandle ("glVertexAttrib1d", out VertexAttrib1d);
			resolver.LoadHandle ("glVertexAttrib1dv", out VertexAttrib1dv);
			resolver.LoadHandle ("glVertexAttrib1f", out VertexAttrib1f);
			resolver.LoadHandle ("glVertexAttrib1fv", out VertexAttrib1fv);
			resolver.LoadHandle ("glVertexAttrib1s", out VertexAttrib1s);
			resolver.LoadHandle ("glVertexAttrib1sv", out VertexAttrib1sv);
			resolver.LoadHandle ("glVertexAttrib2d", out VertexAttrib2d);
			resolver.LoadHandle ("glVertexAttrib2dv", out VertexAttrib2dv);
			resolver.LoadHandle ("glVertexAttrib2f", out VertexAttrib2f);
			resolver.LoadHandle ("glVertexAttrib2fv", out VertexAttrib2fv);
			resolver.LoadHandle ("glVertexAttrib2s", out VertexAttrib2s);
			resolver.LoadHandle ("glVertexAttrib2sv", out VertexAttrib2sv);
			resolver.LoadHandle ("glVertexAttrib3d", out VertexAttrib3d);
			resolver.LoadHandle ("glVertexAttrib3dv", out VertexAttrib3dv);
			resolver.LoadHandle ("glVertexAttrib3f", out VertexAttrib3f);
			resolver.LoadHandle ("glVertexAttrib3fv", out VertexAttrib3fv);
			resolver.LoadHandle ("glVertexAttrib3s", out VertexAttrib3s);
			resolver.LoadHandle ("glVertexAttrib3sv", out VertexAttrib3sv);
			resolver.LoadHandle ("glVertexAttrib4bv", out VertexAttrib4bv);
			resolver.LoadHandle ("glVertexAttrib4d", out VertexAttrib4d);
			resolver.LoadHandle ("glVertexAttrib4dv", out VertexAttrib4dv);
			resolver.LoadHandle ("glVertexAttrib4f", out VertexAttrib4f);
			resolver.LoadHandle ("glVertexAttrib4fv", out VertexAttrib4fv);
			resolver.LoadHandle ("glVertexAttrib4iv", out VertexAttrib4iv);
			resolver.LoadHandle ("glVertexAttrib4Nbv", out VertexAttrib4Nbv);
			resolver.LoadHandle ("glVertexAttrib4Niv", out VertexAttrib4Niv);
			resolver.LoadHandle ("glVertexAttrib4Nsv", out VertexAttrib4Nsv);
			resolver.LoadHandle ("glVertexAttrib4Nub", out VertexAttrib4Nub);
			resolver.LoadHandle ("glVertexAttrib4Nubv", out VertexAttrib4Nubv);
			resolver.LoadHandle ("glVertexAttrib4Nuiv", out VertexAttrib4Nuiv);
			resolver.LoadHandle ("glVertexAttrib4Nusv", out VertexAttrib4Nusv);
			resolver.LoadHandle ("glVertexAttrib4s", out VertexAttrib4s);
			resolver.LoadHandle ("glVertexAttrib4sv", out VertexAttrib4sv);
			resolver.LoadHandle ("glVertexAttrib4ubv", out VertexAttrib4ubv);
			resolver.LoadHandle ("glVertexAttrib4uiv", out VertexAttrib4uiv);
			resolver.LoadHandle ("glVertexAttrib4usv", out VertexAttrib4usv);
			resolver.LoadHandle ("glVertexAttribBinding", out VertexAttribBinding);
			resolver.LoadHandle ("glVertexAttribDivisor", out VertexAttribDivisor);
			resolver.LoadHandle ("glVertexAttribFormat", out VertexAttribFormat);
			resolver.LoadHandle ("glVertexAttribI1i", out VertexAttribI1i);
			resolver.LoadHandle ("glVertexAttribI1iv", out VertexAttribI1iv);
			resolver.LoadHandle ("glVertexAttribI1ui", out VertexAttribI1ui);
			resolver.LoadHandle ("glVertexAttribI1uiv", out VertexAttribI1uiv);
			resolver.LoadHandle ("glVertexAttribI2i", out VertexAttribI2i);
			resolver.LoadHandle ("glVertexAttribI2iv", out VertexAttribI2iv);
			resolver.LoadHandle ("glVertexAttribI2ui", out VertexAttribI2ui);
			resolver.LoadHandle ("glVertexAttribI2uiv", out VertexAttribI2uiv);
			resolver.LoadHandle ("glVertexAttribI3i", out VertexAttribI3i);
			resolver.LoadHandle ("glVertexAttribI3iv", out VertexAttribI3iv);
			resolver.LoadHandle ("glVertexAttribI3ui", out VertexAttribI3ui);
			resolver.LoadHandle ("glVertexAttribI3uiv", out VertexAttribI3uiv);
			resolver.LoadHandle ("glVertexAttribI4bv", out VertexAttribI4bv);
			resolver.LoadHandle ("glVertexAttribI4i", out VertexAttribI4i);
			resolver.LoadHandle ("glVertexAttribI4iv", out VertexAttribI4iv);
			resolver.LoadHandle ("glVertexAttribI4sv", out VertexAttribI4sv);
			resolver.LoadHandle ("glVertexAttribI4ubv", out VertexAttribI4ubv);
			resolver.LoadHandle ("glVertexAttribI4ui", out VertexAttribI4ui);
			resolver.LoadHandle ("glVertexAttribI4uiv", out VertexAttribI4uiv);
			resolver.LoadHandle ("glVertexAttribI4usv", out VertexAttribI4usv);
			resolver.LoadHandle ("glVertexAttribIFormat", out VertexAttribIFormat);
			resolver.LoadHandle ("glVertexAttribIPointer", out VertexAttribIPointer);
			resolver.LoadHandle ("glVertexAttribL1d", out VertexAttribL1d);
			resolver.LoadHandle ("glVertexAttribL1dv", out VertexAttribL1dv);
			resolver.LoadHandle ("glVertexAttribL2d", out VertexAttribL2d);
			resolver.LoadHandle ("glVertexAttribL2dv", out VertexAttribL2dv);
			resolver.LoadHandle ("glVertexAttribL3d", out VertexAttribL3d);
			resolver.LoadHandle ("glVertexAttribL3dv", out VertexAttribL3dv);
			resolver.LoadHandle ("glVertexAttribL4d", out VertexAttribL4d);
			resolver.LoadHandle ("glVertexAttribL4dv", out VertexAttribL4dv);
			resolver.LoadHandle ("glVertexAttribLFormat", out VertexAttribLFormat);
			resolver.LoadHandle ("glVertexAttribLPointer", out VertexAttribLPointer);
			resolver.LoadHandle ("glVertexAttribP1ui", out VertexAttribP1ui);
			resolver.LoadHandle ("glVertexAttribP1uiv", out VertexAttribP1uiv);
			resolver.LoadHandle ("glVertexAttribP2ui", out VertexAttribP2ui);
			resolver.LoadHandle ("glVertexAttribP2uiv", out VertexAttribP2uiv);
			resolver.LoadHandle ("glVertexAttribP3ui", out VertexAttribP3ui);
			resolver.LoadHandle ("glVertexAttribP3uiv", out VertexAttribP3uiv);
			resolver.LoadHandle ("glVertexAttribP4ui", out VertexAttribP4ui);
			resolver.LoadHandle ("glVertexAttribP4uiv", out VertexAttribP4uiv);
			resolver.LoadHandle ("glVertexAttribPointer", out VertexAttribPointer);
			resolver.LoadHandle ("glVertexBindingDivisor", out VertexBindingDivisor);
			resolver.LoadHandle ("glViewportArrayv", out ViewportArrayv);
			resolver.LoadHandle ("glViewport", out Viewport);
			resolver.LoadHandle ("glViewportIndexedf", out ViewportIndexedf);
			resolver.LoadHandle ("glViewportIndexedfv", out ViewportIndexedfv);
			resolver.LoadHandle ("glWaitSync", out WaitSync);
		}
	}
}

