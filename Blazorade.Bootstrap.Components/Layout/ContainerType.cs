using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Layout
{
    /// <summary>
    /// Defines different container types.
    /// </summary>
    public enum ContainerType
    {
        /// <summary>
        /// The container has a fixed max width at each breakpoint. The default type of container.
        /// </summary>
        FixedWidth,

        /// <summary>
        /// The container is fluid with a max width of 100%.
        /// </summary>
        Fluid,

        /// <summary>
        /// 100% wide on on SM screen sizes. Fixed width above this breakpoint.
        /// </summary>
        SM,

        /// <summary>
        /// 100% wide on on MD screen sizes. Fixed width above this breakpoint.
        /// </summary>
        MD,

        /// <summary>
        /// 100% wide on on LG screen sizes. Fixed width above this breakpoint.
        /// </summary>
        LG,

        /// <summary>
        /// 100% wide on on XL screen sizes. Fixed width above this breakpoint.
        /// </summary>
        XL,
    }
}
