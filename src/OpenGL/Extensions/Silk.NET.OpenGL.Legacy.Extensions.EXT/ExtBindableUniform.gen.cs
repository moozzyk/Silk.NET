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
    [Extension("EXT_bindable_uniform")]
    public abstract unsafe partial class ExtBindableUniform : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_bindable_uniform";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBufferSizeEXT")]
        public abstract int GetUniformBufferSize([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformOffsetEXT")]
        public abstract IntPtr GetUniformOffset([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniformBufferEXT")]
        public abstract void UniformBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint buffer);

        public ExtBindableUniform(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

