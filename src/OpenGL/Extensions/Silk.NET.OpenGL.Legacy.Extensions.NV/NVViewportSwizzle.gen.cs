// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_viewport_swizzle")]
    public abstract unsafe partial class NVViewportSwizzle : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_viewport_swizzle";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="swizzlex">
        /// To be added.
        /// </param>
        /// <param name="swizzley">
        /// To be added.
        /// </param>
        /// <param name="swizzlez">
        /// To be added.
        /// </param>
        /// <param name="swizzlew">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glViewportSwizzleNV")]
        public abstract void ViewportSwizzle([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV swizzlex, [Flow(FlowDirection.In)] NV swizzley, [Flow(FlowDirection.In)] NV swizzlez, [Flow(FlowDirection.In)] NV swizzlew);

        public NVViewportSwizzle(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

