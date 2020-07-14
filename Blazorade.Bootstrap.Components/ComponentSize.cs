using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines standard values for specifying size on many Bootstrap components.
    /// </summary>
    public enum ComponentSize
    {
        /// <summary>
        /// The default size of the component. This is the size the component has if not explicitly specified.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// A small component.
        /// </summary>
        Small = -1,

        /// <summary>
        /// A large component.
        /// </summary>
        Large = 1
    }
}
