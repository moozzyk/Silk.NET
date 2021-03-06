// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_memory_win32")]
    public abstract unsafe partial class KhrExternalMemoryWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_win32";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public abstract unsafe Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public abstract Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
        public abstract unsafe Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] IntPtr handle, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
        public abstract Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] IntPtr handle, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties);

        /// <summary>To be added.</summary>
        public unsafe Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int handle, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            // IntPtrOverloader
            return GetMemoryWin32HandleProperties(device, handleType, new IntPtr(handle), pMemoryWin32HandleProperties);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int handle, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties)
        {
            // IntPtrOverloader
            return GetMemoryWin32HandleProperties(device, handleType, new IntPtr(handle), out pMemoryWin32HandleProperties);
        }

        public KhrExternalMemoryWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

