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
    public unsafe struct ImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public ImageDrmFormatModifierExplicitCreateInfoEXT
        (
            StructureType sType = StructureType.ImageDrmFormatModifierExplicitCreateInfoExt,
            void* pNext = default,
            ulong drmFormatModifier = default,
            uint drmFormatModifierPlaneCount = default,
            SubresourceLayout* pPlaneLayouts = default
        )
        {
           SType = sType;
           PNext = pNext;
           DrmFormatModifier = drmFormatModifier;
           DrmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
           PPlaneLayouts = pPlaneLayouts;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong DrmFormatModifier;
/// <summary></summary>
        public uint DrmFormatModifierPlaneCount;
/// <summary></summary>
        public SubresourceLayout* PPlaneLayouts;
    }
}
