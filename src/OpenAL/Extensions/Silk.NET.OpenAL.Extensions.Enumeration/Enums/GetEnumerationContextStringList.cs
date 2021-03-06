﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines available parameters for
    /// <see cref="IEnumerationContextState.GetStringList(Device*, GetEnumerationContextStringList)" />.
    /// </summary>
    public enum GetEnumerationContextStringList
    {
        /// <summary>
        /// The specifier strings for all available devices. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifiers = 0x1005
    }
}