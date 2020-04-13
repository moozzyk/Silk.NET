// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceSampleLocationsPropertiesEXT
    {
        public PhysicalDeviceSampleLocationsPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceSampleLocationsPropertiesExt,
            void* pNext = default,
            SampleCountFlags sampleLocationSampleCounts = default,
            Extent2D maxSampleLocationGridSize = default,
            uint sampleLocationSubPixelBits = default,
            Bool32 variableSampleLocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           SampleLocationSampleCounts = sampleLocationSampleCounts;
           MaxSampleLocationGridSize = maxSampleLocationGridSize;
           SampleLocationSubPixelBits = sampleLocationSubPixelBits;
           VariableSampleLocations = variableSampleLocations;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SampleCountFlags SampleLocationSampleCounts;
/// <summary></summary>
        public Extent2D MaxSampleLocationGridSize;
        /// <summary></summary>
       public fixed float SampleLocationCoordinateRange[2];
/// <summary></summary>
        public uint SampleLocationSubPixelBits;
/// <summary></summary>
        public Bool32 VariableSampleLocations;
    }
}