using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines options for addon placement in <see cref="InputGroup"/> components.
    /// </summary>
    /// <seealso cref="InputGroup"/>
    public enum AddonPlacement
    {
        /// <summary>
        /// Addons are appended to the input controls.
        /// </summary>
        Append,

        /// <summary>
        /// Addons are prepended to the input controls.
        /// </summary>
        Prepend
    }
}
