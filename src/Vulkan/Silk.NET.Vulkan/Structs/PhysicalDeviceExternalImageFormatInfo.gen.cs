// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceExternalImageFormatInfo
    {
        public PhysicalDeviceExternalImageFormatInfo
        (
            StructureType sType = StructureType.PhysicalDeviceExternalImageFormatInfo,
            void* pNext = default,
            ExternalMemoryHandleTypeFlags handleType = default
        )
        {
           SType = sType;
           PNext = pNext;
           HandleType = handleType;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags HandleType;
    }
}
