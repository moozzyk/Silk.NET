// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public enum ARB
    {
        UnsignedInt64Arb = 0x140F,
        Src1Color = 0x88F9,
        Src1Alpha = 0x8589,
        OneMinusSrc1Color = 0x88FA,
        OneMinusSrc1Alpha = 0x88FB,
        MaxDualSourceDrawBuffers = 0x88FC,
        MapReadBit = 0x1,
        MapWriteBit = 0x2,
        MapPersistentBit = 0x40,
        MapCoherentBit = 0x80,
        DynamicStorageBit = 0x100,
        ClientStorageBit = 0x200,
        ClientMappedBufferBarrierBit = 0x4000,
        BufferImmutableStorage = 0x821F,
        BufferStorageFlags = 0x8220,
        ClearTexture = 0x9365,
        SyncCLEventArb = 0x8240,
        SyncCLEventCompleteArb = 0x8241,
        LowerLeft = 0x8CA1,
        UpperLeft = 0x8CA2,
        NegativeOneToOne = 0x935E,
        ZeroToOne = 0x935F,
        ClipOrigin = 0x935C,
        ClipDepthMode = 0x935D,
        UnpackCompressedBlockWidth = 0x9127,
        UnpackCompressedBlockHeight = 0x9128,
        UnpackCompressedBlockDepth = 0x9129,
        UnpackCompressedBlockSize = 0x912A,
        PackCompressedBlockWidth = 0x912B,
        PackCompressedBlockHeight = 0x912C,
        PackCompressedBlockDepth = 0x912D,
        PackCompressedBlockSize = 0x912E,
        ComputeShader = 0x91B9,
        MaxComputeUniformBlocks = 0x91BB,
        MaxComputeTextureImageUnits = 0x91BC,
        MaxComputeImageUniforms = 0x91BD,
        MaxComputeSharedMemorySize = 0x8262,
        MaxComputeUniformComponents = 0x8263,
        MaxComputeAtomicCounterBuffers = 0x8264,
        MaxComputeAtomicCounters = 0x8265,
        MaxCombinedComputeUniformComponents = 0x8266,
        MaxComputeWorkGroupInvocations = 0x90EB,
        MaxComputeWorkGroupCount = 0x91BE,
        MaxComputeWorkGroupSize = 0x91BF,
        ComputeWorkGroupSize = 0x8267,
        UniformBlockReferencedByComputeShader = 0x90EC,
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
        DispatchIndirectBuffer = 0x90EE,
        DispatchIndirectBufferBinding = 0x90EF,
        ComputeShaderBit = 0x20,
        MaxComputeVariableGroupInvocationsArb = 0x9344,
        MaxComputeFixedGroupInvocationsArb = 0x90EB,
        MaxComputeVariableGroupSizeArb = 0x9345,
        MaxComputeFixedGroupSizeArb = 0x91BF,
        QueryWaitInverted = 0x8E17,
        QueryNoWaitInverted = 0x8E18,
        QueryByRegionWaitInverted = 0x8E19,
        QueryByRegionNoWaitInverted = 0x8E1A,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        MaxCullDistances = 0x82F9,
        MaxCombinedClipAndCullDistances = 0x82FA,
        DebugOutputSynchronousArb = 0x8242,
        DebugNextLoggedMessageLengthArb = 0x8243,
        DebugCallbackFunctionArb = 0x8244,
        DebugCallbackUserParamArb = 0x8245,
        DebugSourceApiArb = 0x8246,
        DebugSourceWindowSystemArb = 0x8247,
        DebugSourceShaderCompilerArb = 0x8248,
        DebugSourceThirdPartyArb = 0x8249,
        DebugSourceApplicationArb = 0x824A,
        DebugSourceOtherArb = 0x824B,
        DebugTypeErrorArb = 0x824C,
        DebugTypeDeprecatedBehaviorArb = 0x824D,
        DebugTypeUndefinedBehaviorArb = 0x824E,
        DebugTypePortabilityArb = 0x824F,
        DebugTypePerformanceArb = 0x8250,
        DebugTypeOtherArb = 0x8251,
        MaxDebugMessageLengthArb = 0x9143,
        MaxDebugLoggedMessagesArb = 0x9144,
        DebugLoggedMessagesArb = 0x9145,
        DebugSeverityHighArb = 0x9146,
        DebugSeverityMediumArb = 0x9147,
        DebugSeverityLowArb = 0x9148,
        DepthComponent32f = 0x8CAC,
        Depth32fStencil8 = 0x8CAD,
        Float32UnsignedInt248Rev = 0x8DAD,
        DepthClamp = 0x864F,
        TextureTarget = 0x1006,
        QueryTarget = 0x82EA,
        TextureBinding1D = 0x8068,
        TextureBinding1DArray = 0x8C1C,
        TextureBinding2D = 0x8069,
        TextureBinding2DArray = 0x8C1D,
        TextureBinding2DMultisample = 0x9104,
        TextureBinding2DMultisampleArray = 0x9105,
        TextureBinding3D = 0x806A,
        TextureBindingBuffer = 0x8C2C,
        TextureBindingCubeMap = 0x8514,
        TextureBindingCubeMapArray = 0x900A,
        TextureBindingRectangle = 0x84F6,
        DrawIndirectBuffer = 0x8F3F,
        DrawIndirectBufferBinding = 0x8F43,
        LocationComponent = 0x934A,
        TransformFeedbackBuffer = 0x8C8E,
        TransformFeedbackBufferIndex = 0x934B,
        TransformFeedbackBufferStride = 0x934C,
        Fixed = 0x140C,
        ImplementationColorReadType = 0x8B9A,
        ImplementationColorReadFormat = 0x8B9B,
        LowFloat = 0x8DF0,
        MediumFloat = 0x8DF1,
        HighFloat = 0x8DF2,
        LowInt = 0x8DF3,
        MediumInt = 0x8DF4,
        HighInt = 0x8DF5,
        ShaderCompiler = 0x8DFA,
        ShaderBinaryFormats = 0x8DF8,
        NumShaderBinaryFormats = 0x8DF9,
        MaxVertexUniformVectors = 0x8DFB,
        MaxVaryingVectors = 0x8DFC,
        MaxFragmentUniformVectors = 0x8DFD,
        Rgb565 = 0x8D62,
        Back = 0x405,
        PrimitiveBoundingBoxArb = 0x92BE,
        MultisampleLineWidthRangeArb = 0x9381,
        MultisampleLineWidthGranularityArb = 0x9382,
        CompressedRgb8Etc2 = 0x9274,
        CompressedSrgb8Etc2 = 0x9275,
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        CompressedRgba8Etc2Eac = 0x9278,
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        CompressedR11Eac = 0x9270,
        CompressedSignedR11Eac = 0x9271,
        CompressedRG11Eac = 0x9272,
        CompressedSignedRG11Eac = 0x9273,
        PrimitiveRestartFixedIndex = 0x8D69,
        AnySamplesPassedConservative = 0x8D6A,
        MaxElementIndex = 0x8D6B,
        MaxUniformLocations = 0x826E,
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
        MaxFramebufferWidth = 0x9315,
        MaxFramebufferHeight = 0x9316,
        MaxFramebufferLayers = 0x9317,
        MaxFramebufferSamples = 0x9318,
        InvalidFramebufferOperation = 0x506,
        FramebufferAttachmentColorEncoding = 0x8210,
        FramebufferAttachmentComponentType = 0x8211,
        FramebufferAttachmentRedSize = 0x8212,
        FramebufferAttachmentGreenSize = 0x8213,
        FramebufferAttachmentBlueSize = 0x8214,
        FramebufferAttachmentAlphaSize = 0x8215,
        FramebufferAttachmentDepthSize = 0x8216,
        FramebufferAttachmentStencilSize = 0x8217,
        FramebufferDefault = 0x8218,
        FramebufferUndefined = 0x8219,
        DepthStencilAttachment = 0x821A,
        MaxRenderbufferSize = 0x84E8,
        DepthStencil = 0x84F9,
        UnsignedInt248 = 0x84FA,
        Depth24Stencil8 = 0x88F0,
        TextureStencilSize = 0x88F1,
        UnsignedNormalized = 0x8C17,
        FramebufferBinding = 0x8CA6,
        DrawFramebufferBinding = 0x8CA6,
        RenderbufferBinding = 0x8CA7,
        ReadFramebuffer = 0x8CA8,
        DrawFramebuffer = 0x8CA9,
        ReadFramebufferBinding = 0x8CAA,
        RenderbufferSamples = 0x8CAB,
        FramebufferAttachmentObjectType = 0x8CD0,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentTextureLevel = 0x8CD2,
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        FramebufferAttachmentTextureLayer = 0x8CD4,
        FramebufferComplete = 0x8CD5,
        FramebufferIncompleteAttachment = 0x8CD6,
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        FramebufferIncompleteReadBuffer = 0x8CDC,
        FramebufferUnsupported = 0x8CDD,
        MaxColorAttachments = 0x8CDF,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        DepthAttachment = 0x8D00,
        StencilAttachment = 0x8D20,
        Framebuffer = 0x8D40,
        Renderbuffer = 0x8D41,
        RenderbufferWidth = 0x8D42,
        RenderbufferHeight = 0x8D43,
        RenderbufferInternalFormat = 0x8D44,
        StencilIndex1 = 0x8D46,
        StencilIndex4 = 0x8D47,
        StencilIndex8 = 0x8D48,
        StencilIndex16 = 0x8D49,
        RenderbufferRedSize = 0x8D50,
        RenderbufferGreenSize = 0x8D51,
        RenderbufferBlueSize = 0x8D52,
        RenderbufferAlphaSize = 0x8D53,
        RenderbufferDepthSize = 0x8D54,
        RenderbufferStencilSize = 0x8D55,
        FramebufferIncompleteMultisample = 0x8D56,
        MaxSamples = 0x8D57,
        FramebufferSrgb = 0x8DB9,
        LinesAdjacencyArb = 0xA,
        LineStripAdjacencyArb = 0xB,
        TrianglesAdjacencyArb = 0xC,
        TriangleStripAdjacencyArb = 0xD,
        ProgramPointSizeArb = 0x8642,
        MaxGeometryTextureImageUnitsArb = 0x8C29,
        FramebufferAttachmentLayeredArb = 0x8DA7,
        FramebufferIncompleteLayerTargetsArb = 0x8DA8,
        FramebufferIncompleteLayerCountArb = 0x8DA9,
        GeometryShaderArb = 0x8DD9,
        GeometryVerticesOutArb = 0x8DDA,
        GeometryInputTypeArb = 0x8DDB,
        GeometryOutputTypeArb = 0x8DDC,
        MaxGeometryVaryingComponentsArb = 0x8DDD,
        MaxVertexVaryingComponentsArb = 0x8DDE,
        MaxGeometryUniformComponentsArb = 0x8DDF,
        MaxGeometryOutputVerticesArb = 0x8DE0,
        MaxGeometryTotalOutputComponentsArb = 0x8DE1,
        MaxVaryingComponents = 0x8B4B,
        ProgramBinaryRetrievableHint = 0x8257,
        ProgramBinaryLength = 0x8741,
        NumProgramBinaryFormats = 0x87FE,
        ProgramBinaryFormats = 0x87FF,
        ShaderBinaryFormatSpirVArb = 0x9551,
        SpirVBinaryArb = 0x9552,
        GeometryShaderInvocations = 0x887F,
        MaxGeometryShaderInvocations = 0x8E5A,
        MinFragmentInterpolationOffset = 0x8E5B,
        MaxFragmentInterpolationOffset = 0x8E5C,
        FragmentInterpolationOffsetBits = 0x8E5D,
        MaxVertexStreams = 0x8E71,
        Double = 0x140A,
        DoubleVec2 = 0x8FFC,
        DoubleVec3 = 0x8FFD,
        DoubleVec4 = 0x8FFE,
        DoubleMat2 = 0x8F46,
        DoubleMat3 = 0x8F47,
        DoubleMat4 = 0x8F48,
        DoubleMat2x3 = 0x8F49,
        DoubleMat2x4 = 0x8F4A,
        DoubleMat3x2 = 0x8F4B,
        DoubleMat3x4 = 0x8F4C,
        DoubleMat4x2 = 0x8F4D,
        DoubleMat4x3 = 0x8F4E,
        Int64Arb = 0x140E,
        Int64Vec2Arb = 0x8FE9,
        Int64Vec3Arb = 0x8FEA,
        Int64Vec4Arb = 0x8FEB,
        UnsignedInt64Vec2Arb = 0x8FF5,
        UnsignedInt64Vec3Arb = 0x8FF6,
        UnsignedInt64Vec4Arb = 0x8FF7,
        HalfFloat = 0x140B,
        BlendColor = 0x8005,
        BlendEquation = 0x8009,
        ConstantColor = 0x8001,
        OneMinusConstantColor = 0x8002,
        ConstantAlpha = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        FuncAdd = 0x8006,
        FuncReverseSubtract = 0x800B,
        FuncSubtract = 0x800A,
        Min = 0x8007,
        Max = 0x8008,
        ParameterBufferArb = 0x80EE,
        ParameterBufferBindingArb = 0x80EF,
        VertexAttribArrayDivisorArb = 0x88FE,
        NumSampleCounts = 0x9380,
        ImageFormatCompatibilityType = 0x90C7,
        Samples = 0x80A9,
        Texture1D = 0xDE0,
        Texture1DArray = 0x8C18,
        Texture2D = 0xDE1,
        Texture2DArray = 0x8C1A,
        Texture3D = 0x806F,
        TextureCubeMap = 0x8513,
        TextureCubeMapArray = 0x9009,
        TextureRectangle = 0x84F5,
        TextureBuffer = 0x8C2A,
        Texture2DMultisample = 0x9100,
        Texture2DMultisampleArray = 0x9102,
        TextureCompressed = 0x86A1,
        InternalformatSupported = 0x826F,
        InternalformatPreferred = 0x8270,
        InternalformatRedSize = 0x8271,
        InternalformatGreenSize = 0x8272,
        InternalformatBlueSize = 0x8273,
        InternalformatAlphaSize = 0x8274,
        InternalformatDepthSize = 0x8275,
        InternalformatStencilSize = 0x8276,
        InternalformatSharedSize = 0x8277,
        InternalformatRedType = 0x8278,
        InternalformatGreenType = 0x8279,
        InternalformatBlueType = 0x827A,
        InternalformatAlphaType = 0x827B,
        InternalformatDepthType = 0x827C,
        InternalformatStencilType = 0x827D,
        MaxWidth = 0x827E,
        MaxHeight = 0x827F,
        MaxDepth = 0x8280,
        MaxLayers = 0x8281,
        MaxCombinedDimensions = 0x8282,
        ColorComponents = 0x8283,
        DepthComponents = 0x8284,
        StencilComponents = 0x8285,
        ColorRenderable = 0x8286,
        DepthRenderable = 0x8287,
        StencilRenderable = 0x8288,
        FramebufferRenderable = 0x8289,
        FramebufferRenderableLayered = 0x828A,
        FramebufferBlend = 0x828B,
        ReadPixels = 0x828C,
        ReadPixelsFormat = 0x828D,
        ReadPixelsType = 0x828E,
        TextureImageFormat = 0x828F,
        TextureImageType = 0x8290,
        GetTextureImageFormat = 0x8291,
        GetTextureImageType = 0x8292,
        Mipmap = 0x8293,
        ManualGenerateMipmap = 0x8294,
        AutoGenerateMipmap = 0x8295,
        ColorEncoding = 0x8296,
        SrgbRead = 0x8297,
        SrgbWrite = 0x8298,
        SrgbDecodeArb = 0x8299,
        Filter = 0x829A,
        VertexTexture = 0x829B,
        TessControlTexture = 0x829C,
        TessEvaluationTexture = 0x829D,
        GeometryTexture = 0x829E,
        FragmentTexture = 0x829F,
        ComputeTexture = 0x82A0,
        TextureShadow = 0x82A1,
        TextureGather = 0x82A2,
        TextureGatherShadow = 0x82A3,
        ShaderImageLoad = 0x82A4,
        ShaderImageStore = 0x82A5,
        ShaderImageAtomic = 0x82A6,
        ImageTexelSize = 0x82A7,
        ImageCompatibilityClass = 0x82A8,
        ImagePixelFormat = 0x82A9,
        ImagePixelType = 0x82AA,
        SimultaneousTextureAndDepthTest = 0x82AC,
        SimultaneousTextureAndStencilTest = 0x82AD,
        SimultaneousTextureAndDepthWrite = 0x82AE,
        SimultaneousTextureAndStencilWrite = 0x82AF,
        TextureCompressedBlockWidth = 0x82B1,
        TextureCompressedBlockHeight = 0x82B2,
        TextureCompressedBlockSize = 0x82B3,
        ClearBuffer = 0x82B4,
        TextureView = 0x82B5,
        ViewCompatibilityClass = 0x82B6,
        FullSupport = 0x82B7,
        CaveatSupport = 0x82B8,
        ImageClass4X32 = 0x82B9,
        ImageClass2X32 = 0x82BA,
        ImageClass1X32 = 0x82BB,
        ImageClass4X16 = 0x82BC,
        ImageClass2X16 = 0x82BD,
        ImageClass1X16 = 0x82BE,
        ImageClass4X8 = 0x82BF,
        ImageClass2X8 = 0x82C0,
        ImageClass1X8 = 0x82C1,
        ImageClass111110 = 0x82C2,
        ImageClass1010102 = 0x82C3,
        ViewClass128Bits = 0x82C4,
        ViewClass96Bits = 0x82C5,
        ViewClass64Bits = 0x82C6,
        ViewClass48Bits = 0x82C7,
        ViewClass32Bits = 0x82C8,
        ViewClass24Bits = 0x82C9,
        ViewClass16Bits = 0x82CA,
        ViewClass8Bits = 0x82CB,
        ViewClassS3TCDxt1Rgb = 0x82CC,
        ViewClassS3TCDxt1Rgba = 0x82CD,
        ViewClassS3TCDxt3Rgba = 0x82CE,
        ViewClassS3TCDxt5Rgba = 0x82CF,
        ViewClassRgtc1Red = 0x82D0,
        ViewClassRgtc2RG = 0x82D1,
        ViewClassBptcUnorm = 0x82D2,
        ViewClassBptcFloat = 0x82D3,
        ViewClassEacR11 = 0x9383,
        ViewClassEacRG11 = 0x9384,
        ViewClassEtc2Rgb = 0x9385,
        ViewClassEtc2Rgba = 0x9386,
        ViewClassEtc2EacRgba = 0x9387,
        ViewClassAstc4x4Rgba = 0x9388,
        ViewClassAstc5x4Rgba = 0x9389,
        ViewClassAstc5x5Rgba = 0x938A,
        ViewClassAstc6x5Rgba = 0x938B,
        ViewClassAstc6x6Rgba = 0x938C,
        ViewClassAstc8x5Rgba = 0x938D,
        ViewClassAstc8x6Rgba = 0x938E,
        ViewClassAstc8x8Rgba = 0x938F,
        ViewClassAstc10x5Rgba = 0x9390,
        ViewClassAstc10x6Rgba = 0x9391,
        ViewClassAstc10x8Rgba = 0x9392,
        ViewClassAstc10x10Rgba = 0x9393,
        ViewClassAstc12x10Rgba = 0x9394,
        ViewClassAstc12x12Rgba = 0x9395,
        MinMapBufferAlignment = 0x90BC,
        MapInvalidateRangeBit = 0x4,
        MapInvalidateBufferBit = 0x8,
        MapFlushExplicitBit = 0x10,
        MapUnsynchronizedBit = 0x20,
        AnySamplesPassed = 0x8C2F,
        MaxShaderCompilerThreadsArb = 0x91B0,
        CompletionStatusArb = 0x91B1,
        VerticesSubmittedArb = 0x82EE,
        PrimitivesSubmittedArb = 0x82EF,
        VertexShaderInvocationsArb = 0x82F0,
        TessControlShaderPatchesArb = 0x82F1,
        TessEvaluationShaderInvocationsArb = 0x82F2,
        GeometryShaderPrimitivesEmittedArb = 0x82F3,
        FragmentShaderInvocationsArb = 0x82F4,
        ComputeShaderInvocationsArb = 0x82F5,
        ClippingInputPrimitivesArb = 0x82F6,
        ClippingOutputPrimitivesArb = 0x82F7,
        PixelPackBufferArb = 0x88EB,
        PixelUnpackBufferArb = 0x88EC,
        PixelPackBufferBindingArb = 0x88ED,
        PixelUnpackBufferBindingArb = 0x88EF,
        PolygonOffsetClamp = 0x8E1B,
        Uniform = 0x92E1,
        UniformBlock = 0x92E2,
        ProgramInput = 0x92E3,
        ProgramOutput = 0x92E4,
        BufferVariable = 0x92E5,
        ShaderStorageBlock = 0x92E6,
        AtomicCounterBuffer = 0x92C0,
        VertexSubroutine = 0x92E8,
        TessControlSubroutine = 0x92E9,
        TessEvaluationSubroutine = 0x92EA,
        GeometrySubroutine = 0x92EB,
        FragmentSubroutine = 0x92EC,
        ComputeSubroutine = 0x92ED,
        VertexSubroutineUniform = 0x92EE,
        TessControlSubroutineUniform = 0x92EF,
        TessEvaluationSubroutineUniform = 0x92F0,
        GeometrySubroutineUniform = 0x92F1,
        FragmentSubroutineUniform = 0x92F2,
        ComputeSubroutineUniform = 0x92F3,
        TransformFeedbackVarying = 0x92F4,
        ActiveResources = 0x92F5,
        MaxNameLength = 0x92F6,
        MaxNumActiveVariables = 0x92F7,
        MaxNumCompatibleSubroutines = 0x92F8,
        NameLength = 0x92F9,
        Type = 0x92FA,
        ArraySize = 0x92FB,
        Offset = 0x92FC,
        BlockIndex = 0x92FD,
        ArrayStride = 0x92FE,
        MatrixStride = 0x92FF,
        IsRowMajor = 0x9300,
        AtomicCounterBufferIndex = 0x9301,
        BufferBinding = 0x9302,
        BufferDataSize = 0x9303,
        NumActiveVariables = 0x9304,
        ActiveVariables = 0x9305,
        ReferencedByVertexShader = 0x9306,
        ReferencedByTessControlShader = 0x9307,
        ReferencedByTessEvaluationShader = 0x9308,
        ReferencedByGeometryShader = 0x9309,
        ReferencedByFragmentShader = 0x930A,
        ReferencedByComputeShader = 0x930B,
        TopLevelArraySize = 0x930C,
        TopLevelArrayStride = 0x930D,
        Location = 0x930E,
        LocationIndex = 0x930F,
        IsPerPatch = 0x92E7,
        NumCompatibleSubroutines = 0x8E4A,
        CompatibleSubroutines = 0x8E4B,
        QuadsFollowProvokingVertexConvention = 0x8E4C,
        FirstVertexConvention = 0x8E4D,
        LastVertexConvention = 0x8E4E,
        ProvokingVertex = 0x8E4F,
        QueryBuffer = 0x9192,
        QueryBufferBarrierBit = 0x8000,
        QueryBufferBinding = 0x9193,
        QueryResultNoWait = 0x9194,
        NoError = 0x0,
        ContextFlagRobustAccessBitArb = 0x4,
        LoseContextOnResetArb = 0x8252,
        GuiltyContextResetArb = 0x8253,
        InnocentContextResetArb = 0x8254,
        UnknownContextResetArb = 0x8255,
        ResetNotificationStrategyArb = 0x8256,
        NoResetNotificationArb = 0x8261,
        SampleLocationSubpixelBitsArb = 0x933D,
        SampleLocationPixelGridWidthArb = 0x933E,
        SampleLocationPixelGridHeightArb = 0x933F,
        ProgrammableSampleLocationTableSizeArb = 0x9340,
        SampleLocationArb = 0x8E50,
        ProgrammableSampleLocationArb = 0x9341,
        FramebufferProgrammableSampleLocationsArb = 0x9342,
        FramebufferSampleLocationPixelGridArb = 0x9343,
        SamplerBinding = 0x8919,
        SampleShadingArb = 0x8C36,
        MinSampleShadingValueArb = 0x8C37,
        TextureCubeMapSeamless = 0x884F,
        VertexShaderBit = 0x1,
        FragmentShaderBit = 0x2,
        GeometryShaderBit = 0x4,
        TessControlShaderBit = 0x8,
        TessEvaluationShaderBit = 0x10,
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        ProgramSeparable = 0x8258,
        ActiveProgram = 0x8259,
        ProgramPipelineBinding = 0x825A,
        AtomicCounterBufferBinding = 0x92C1,
        AtomicCounterBufferStart = 0x92C2,
        AtomicCounterBufferSize = 0x92C3,
        AtomicCounterBufferDataSize = 0x92C4,
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        MaxVertexAtomicCounterBuffers = 0x92CC,
        MaxTessControlAtomicCounterBuffers = 0x92CD,
        MaxTessEvaluationAtomicCounterBuffers = 0x92CE,
        MaxGeometryAtomicCounterBuffers = 0x92CF,
        MaxFragmentAtomicCounterBuffers = 0x92D0,
        MaxCombinedAtomicCounterBuffers = 0x92D1,
        MaxVertexAtomicCounters = 0x92D2,
        MaxTessControlAtomicCounters = 0x92D3,
        MaxTessEvaluationAtomicCounters = 0x92D4,
        MaxGeometryAtomicCounters = 0x92D5,
        MaxFragmentAtomicCounters = 0x92D6,
        MaxCombinedAtomicCounters = 0x92D7,
        MaxAtomicCounterBufferSize = 0x92D8,
        MaxAtomicCounterBufferBindings = 0x92DC,
        ActiveAtomicCounterBuffers = 0x92D9,
        UniformAtomicCounterBufferIndex = 0x92DA,
        UnsignedIntAtomicCounter = 0x92DB,
        VertexAttribArrayBarrierBit = 0x1,
        ElementArrayBarrierBit = 0x2,
        UniformBarrierBit = 0x4,
        TextureFetchBarrierBit = 0x8,
        ShaderImageAccessBarrierBit = 0x20,
        CommandBarrierBit = 0x40,
        PixelBufferBarrierBit = 0x80,
        TextureUpdateBarrierBit = 0x100,
        BufferUpdateBarrierBit = 0x200,
        FramebufferBarrierBit = 0x400,
        TransformFeedbackBarrierBit = 0x800,
        AtomicCounterBarrierBit = 0x1000,
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        MaxImageUnits = 0x8F38,
        MaxCombinedImageUnitsAndFragmentOutputs = 0x8F39,
        ImageBindingName = 0x8F3A,
        ImageBindingLevel = 0x8F3B,
        ImageBindingLayered = 0x8F3C,
        ImageBindingLayer = 0x8F3D,
        ImageBindingAccess = 0x8F3E,
        Image1D = 0x904C,
        Image2D = 0x904D,
        Image3D = 0x904E,
        Image2DRect = 0x904F,
        ImageCube = 0x9050,
        ImageBuffer = 0x9051,
        Image1DArray = 0x9052,
        Image2DArray = 0x9053,
        ImageCubeMapArray = 0x9054,
        Image2DMultisample = 0x9055,
        Image2DMultisampleArray = 0x9056,
        IntImage1D = 0x9057,
        IntImage2D = 0x9058,
        IntImage3D = 0x9059,
        IntImage2DRect = 0x905A,
        IntImageCube = 0x905B,
        IntImageBuffer = 0x905C,
        IntImage1DArray = 0x905D,
        IntImage2DArray = 0x905E,
        IntImageCubeMapArray = 0x905F,
        IntImage2DMultisample = 0x9060,
        IntImage2DMultisampleArray = 0x9061,
        UnsignedIntImage1D = 0x9062,
        UnsignedIntImage2D = 0x9063,
        UnsignedIntImage3D = 0x9064,
        UnsignedIntImage2DRect = 0x9065,
        UnsignedIntImageCube = 0x9066,
        UnsignedIntImageBuffer = 0x9067,
        UnsignedIntImage1DArray = 0x9068,
        UnsignedIntImage2DArray = 0x9069,
        UnsignedIntImageCubeMapArray = 0x906A,
        UnsignedIntImage2DMultisample = 0x906B,
        UnsignedIntImage2DMultisampleArray = 0x906C,
        MaxImageSamples = 0x906D,
        ImageBindingFormat = 0x906E,
        ImageFormatCompatibilityBySize = 0x90C8,
        ImageFormatCompatibilityByClass = 0x90C9,
        MaxVertexImageUniforms = 0x90CA,
        MaxTessControlImageUniforms = 0x90CB,
        MaxTessEvaluationImageUniforms = 0x90CC,
        MaxGeometryImageUniforms = 0x90CD,
        MaxFragmentImageUniforms = 0x90CE,
        MaxCombinedImageUniforms = 0x90CF,
        ShaderStorageBuffer = 0x90D2,
        ShaderStorageBufferBinding = 0x90D3,
        ShaderStorageBufferStart = 0x90D4,
        ShaderStorageBufferSize = 0x90D5,
        MaxVertexShaderStorageBlocks = 0x90D6,
        MaxGeometryShaderStorageBlocks = 0x90D7,
        MaxTessControlShaderStorageBlocks = 0x90D8,
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        MaxFragmentShaderStorageBlocks = 0x90DA,
        MaxComputeShaderStorageBlocks = 0x90DB,
        MaxCombinedShaderStorageBlocks = 0x90DC,
        MaxShaderStorageBufferBindings = 0x90DD,
        MaxShaderStorageBlockSize = 0x90DE,
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        ShaderStorageBarrierBit = 0x2000,
        MaxCombinedShaderOutputResources = 0x8F39,
        ActiveSubroutines = 0x8DE5,
        ActiveSubroutineUniforms = 0x8DE6,
        ActiveSubroutineUniformLocations = 0x8E47,
        ActiveSubroutineMaxLength = 0x8E48,
        ActiveSubroutineUniformMaxLength = 0x8E49,
        MaxSubroutines = 0x8DE7,
        MaxSubroutineUniformLocations = 0x8DE8,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39,
        ShaderIncludeArb = 0x8DAE,
        NamedStringLengthArb = 0x8DE9,
        NamedStringTypeArb = 0x8DEA,
        SparseStorageBitArb = 0x400,
        SparseBufferPageSizeArb = 0x82F8,
        TextureSparseArb = 0x91A6,
        VirtualPageSizeIndexArb = 0x91A7,
        NumSparseLevelsArb = 0x91AA,
        NumVirtualPageSizesArb = 0x91A8,
        VirtualPageSizeXArb = 0x9195,
        VirtualPageSizeYArb = 0x9196,
        VirtualPageSizeZArb = 0x9197,
        MaxSparseTextureSizeArb = 0x9198,
        MaxSparse3DTextureSizeArb = 0x9199,
        MaxSparseArrayTextureLayersArb = 0x919A,
        SparseTextureFullArrayCubeMipmapsArb = 0x91A9,
        SpirVExtensions = 0x9553,
        NumSpirVExtensions = 0x9554,
        DepthStencilTextureMode = 0x90EA,
        MaxServerWaitTimeout = 0x9111,
        ObjectType = 0x9112,
        SyncCondition = 0x9113,
        SyncStatus = 0x9114,
        SyncFlags = 0x9115,
        SyncFence = 0x9116,
        SyncGpuCommandsComplete = 0x9117,
        Unsignaled = 0x9118,
        Signaled = 0x9119,
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
        SyncFlushCommandsBit = 0x1,
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF),
        Patches = 0xE,
        PatchVertices = 0x8E72,
        PatchDefaultInnerLevel = 0x8E73,
        PatchDefaultOuterLevel = 0x8E74,
        TessControlOutputVertices = 0x8E75,
        TessGenMode = 0x8E76,
        TessGenSpacing = 0x8E77,
        TessGenVertexOrder = 0x8E78,
        TessGenPointMode = 0x8E79,
        Triangles = 0x4,
        Isolines = 0x8E7A,
        Quads = 0x7,
        Equal = 0x202,
        FractionalOdd = 0x8E7B,
        FractionalEven = 0x8E7C,
        Ccw = 0x901,
        CW = 0x900,
        MaxPatchVertices = 0x8E7D,
        MaxTessGenLevel = 0x8E7E,
        MaxTessControlUniformComponents = 0x8E7F,
        MaxTessEvaluationUniformComponents = 0x8E80,
        MaxTessControlTextureImageUnits = 0x8E81,
        MaxTessEvaluationTextureImageUnits = 0x8E82,
        MaxTessControlOutputComponents = 0x8E83,
        MaxTessPatchComponents = 0x8E84,
        MaxTessControlTotalOutputComponents = 0x8E85,
        MaxTessEvaluationOutputComponents = 0x8E86,
        MaxTessControlUniformBlocks = 0x8E89,
        MaxTessEvaluationUniformBlocks = 0x8E8A,
        MaxTessControlInputComponents = 0x886C,
        MaxTessEvaluationInputComponents = 0x886D,
        MaxCombinedTessControlUniformComponents = 0x8E1E,
        MaxCombinedTessEvaluationUniformComponents = 0x8E1F,
        UniformBlockReferencedByTessControlShader = 0x84F0,
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        TessEvaluationShader = 0x8E87,
        TessControlShader = 0x8E88,
        ClampToBorderArb = 0x812D,
        TextureBufferArb = 0x8C2A,
        MaxTextureBufferSizeArb = 0x8C2B,
        TextureBindingBufferArb = 0x8C2C,
        TextureBufferDataStoreBindingArb = 0x8C2D,
        TextureBufferFormatArb = 0x8C2E,
        Rgb32f = 0x8815,
        Rgb32ui = 0x8D71,
        Rgb32i = 0x8D83,
        TextureBufferOffset = 0x919D,
        TextureBufferSize = 0x919E,
        TextureBufferOffsetAlignment = 0x919F,
        CompressedRgbaBptcUnormArb = 0x8E8C,
        CompressedSrgbAlphaBptcUnormArb = 0x8E8D,
        CompressedRgbBptcSignedFloatArb = 0x8E8E,
        CompressedRgbBptcUnsignedFloatArb = 0x8E8F,
        CompressedRedRgtc1 = 0x8DBB,
        CompressedSignedRedRgtc1 = 0x8DBC,
        CompressedRGRgtc2 = 0x8DBD,
        CompressedSignedRGRgtc2 = 0x8DBE,
        TextureCubeMapArrayArb = 0x9009,
        TextureBindingCubeMapArrayArb = 0x900A,
        ProxyTextureCubeMapArrayArb = 0x900B,
        SamplerCubeMapArrayArb = 0x900C,
        SamplerCubeMapArrayShadowArb = 0x900D,
        IntSamplerCubeMapArrayArb = 0x900E,
        UnsignedIntSamplerCubeMapArrayArb = 0x900F,
        TextureMaxAnisotropy = 0x84FE,
        MaxTextureMaxAnisotropy = 0x84FF,
        TextureReductionModeArb = 0x9366,
        WeightedAverageArb = 0x9367,
        MinProgramTextureGatherOffsetArb = 0x8E5E,
        MaxProgramTextureGatherOffsetArb = 0x8E5F,
        MaxProgramTextureGatherComponentsArb = 0x8F9F,
        MirrorClampToEdge = 0x8743,
        MirroredRepeatArb = 0x8370,
        SamplePosition = 0x8E50,
        SampleMask = 0x8E51,
        SampleMaskValue = 0x8E52,
        MaxSampleMaskWords = 0x8E59,
        ProxyTexture2DMultisample = 0x9101,
        ProxyTexture2DMultisampleArray = 0x9103,
        TextureSamples = 0x9106,
        TextureFixedSampleLocations = 0x9107,
        Sampler2DMultisample = 0x9108,
        IntSampler2DMultisample = 0x9109,
        UnsignedIntSampler2DMultisample = 0x910A,
        Sampler2DMultisampleArray = 0x910B,
        IntSampler2DMultisampleArray = 0x910C,
        UnsignedIntSampler2DMultisampleArray = 0x910D,
        MaxColorTextureSamples = 0x910E,
        MaxDepthTextureSamples = 0x910F,
        MaxIntegerSamples = 0x9110,
        RG = 0x8227,
        RGInteger = 0x8228,
        R8 = 0x8229,
        R16 = 0x822A,
        RG8 = 0x822B,
        RG16 = 0x822C,
        R16f = 0x822D,
        R32f = 0x822E,
        RG16f = 0x822F,
        RG32f = 0x8230,
        R8i = 0x8231,
        R8ui = 0x8232,
        R16i = 0x8233,
        R16ui = 0x8234,
        R32i = 0x8235,
        R32ui = 0x8236,
        RG8i = 0x8237,
        RG8ui = 0x8238,
        RG16i = 0x8239,
        RG16ui = 0x823A,
        RG32i = 0x823B,
        RG32ui = 0x823C,
        Rgb10A2ui = 0x906F,
        StencilIndex = 0x1901,
        TextureImmutableFormat = 0x912F,
        TextureSwizzleR = 0x8E42,
        TextureSwizzleG = 0x8E43,
        TextureSwizzleB = 0x8E44,
        TextureSwizzleA = 0x8E45,
        TextureSwizzleRgba = 0x8E46,
        TextureViewMinLevel = 0x82DB,
        TextureViewNumLevels = 0x82DC,
        TextureViewMinLayer = 0x82DD,
        TextureViewNumLayers = 0x82DE,
        TextureImmutableLevels = 0x82DF,
        TimeElapsed = 0x88BF,
        Timestamp = 0x8E28,
        TransformFeedback = 0x8E22,
        TransformFeedbackBufferPaused = 0x8E23,
        TransformFeedbackBufferActive = 0x8E24,
        TransformFeedbackBinding = 0x8E25,
        MaxTransformFeedbackBuffers = 0x8E70,
        TransformFeedbackOverflowArb = 0x82EC,
        TransformFeedbackStreamOverflowArb = 0x82ED,
        UniformBuffer = 0x8A11,
        UniformBufferBinding = 0x8A28,
        UniformBufferStart = 0x8A29,
        UniformBufferSize = 0x8A2A,
        MaxVertexUniformBlocks = 0x8A2B,
        MaxGeometryUniformBlocks = 0x8A2C,
        MaxFragmentUniformBlocks = 0x8A2D,
        MaxCombinedUniformBlocks = 0x8A2E,
        MaxUniformBufferBindings = 0x8A2F,
        MaxUniformBlockSize = 0x8A30,
        MaxCombinedVertexUniformComponents = 0x8A31,
        MaxCombinedGeometryUniformComponents = 0x8A32,
        MaxCombinedFragmentUniformComponents = 0x8A33,
        UniformBufferOffsetAlignment = 0x8A34,
        ActiveUniformBlockMaxNameLength = 0x8A35,
        ActiveUniformBlocks = 0x8A36,
        UniformType = 0x8A37,
        UniformBlockIndex = 0x8A3A,
        UniformOffset = 0x8A3B,
        UniformArrayStride = 0x8A3C,
        UniformMatrixStride = 0x8A3D,
        UniformIsRowMajor = 0x8A3E,
        UniformBlockBinding = 0x8A3F,
        UniformBlockDataSize = 0x8A40,
        UniformBlockNameLength = 0x8A41,
        UniformBlockActiveUniforms = 0x8A42,
        UniformBlockActiveUniformIndices = 0x8A43,
        UniformBlockReferencedByVertexShader = 0x8A44,
        UniformBlockReferencedByGeometryShader = 0x8A45,
        UniformBlockReferencedByFragmentShader = 0x8A46,
        InvalidIndex = unchecked((int)0xFFFFFFFF),
        Bgra = 0x80E1,
        VertexArrayBinding = 0x85B5,
        VertexAttribBinding = 0x82D4,
        VertexAttribRelativeOffset = 0x82D5,
        VertexBindingDivisor = 0x82D6,
        VertexBindingOffset = 0x82D7,
        VertexBindingStride = 0x82D8,
        MaxVertexAttribRelativeOffset = 0x82D9,
        MaxVertexAttribBindings = 0x82DA,
        UnsignedInt10f11f11fRev = 0x8C3B,
        UnsignedInt2101010Rev = 0x8368,
        Int2101010Rev = 0x8D9F,
        ScissorBox = 0xC10,
        Viewport = 0xBA2,
        DepthRange = 0xB70,
        ScissorTest = 0xC11,
        MaxViewports = 0x825B,
        ViewportSubpixelBits = 0x825C,
        ViewportBoundsRange = 0x825D,
        LayerProvokingVertex = 0x825E,
        ViewportIndexProvokingVertex = 0x825F,
        UndefinedVertex = 0x8260,
    }
}
