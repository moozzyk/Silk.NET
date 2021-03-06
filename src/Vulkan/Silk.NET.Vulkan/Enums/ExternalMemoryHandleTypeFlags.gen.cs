// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalMemoryHandleTypeFlags
    {
        ExternalMemoryHandleTypeOpaqueFDBit = 1,
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        ExternalMemoryHandleTypeD3D11TextureBit = 8,
        ExternalMemoryHandleTypeD3D11TextureKmtBit = 16,
        ExternalMemoryHandleTypeD3D12HeapBit = 32,
        ExternalMemoryHandleTypeD3D12ResourceBit = 64,
        ExternalMemoryHandleTypeDmaBufBitExt = 512,
        ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1024,
        ExternalMemoryHandleTypeHostAllocationBitExt = 128,
        ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 256,
    }
}
