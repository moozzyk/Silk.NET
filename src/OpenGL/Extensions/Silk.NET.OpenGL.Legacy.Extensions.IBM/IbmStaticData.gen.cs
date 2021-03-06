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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_static_data")]
    public abstract unsafe partial class IbmStaticData : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_static_data";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushStaticDataIBM")]
        public abstract void FlushStaticData([Flow(FlowDirection.In)] IBM target);

        public IbmStaticData(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

