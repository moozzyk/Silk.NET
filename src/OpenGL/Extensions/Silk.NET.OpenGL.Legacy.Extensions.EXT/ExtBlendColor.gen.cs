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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_color")]
    public abstract unsafe partial class ExtBlendColor : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_color";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendColorEXT")]
        public abstract void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        public ExtBlendColor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

