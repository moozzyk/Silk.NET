// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore_win32")]
    public abstract unsafe partial class ExtSemaphoreWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_win32";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        public abstract void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        public abstract void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged;

        public ExtSemaphoreWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

