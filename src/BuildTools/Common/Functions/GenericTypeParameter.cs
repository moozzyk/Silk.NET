// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;

namespace Generator.Common.Functions
{
    /// <summary>
    /// Represents a C# generic type parameter.
    /// </summary>
    public class GenericTypeParameter
    {
        public GenericTypeParameter()
        {
        }

        public GenericTypeParameter(string genericTypeParameterName, IEnumerable<string> constraints)
        {
            Name = genericTypeParameterName;
            Constraints = constraints.ToList();
        }

        /// <summary>
        /// Gets or sets the name of this generic type parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of generic type parameter constraints.
        /// </summary>
        public List<string> Constraints { get; set; } = new List<string>();
    }
}
