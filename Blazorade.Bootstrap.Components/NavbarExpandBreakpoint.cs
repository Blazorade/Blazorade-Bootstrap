using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different breakpoints at which a <see cref="Navbar"/> will expand.
    /// </summary>
    public enum NavbarExpandBreakpoint
    {
        /// <summary>
        /// Expands by default at >= 576 px.
        /// </summary>
        SM,

        /// <summary>
        /// Expands by default at >= 768 px.
        /// </summary>
        MD,

        /// <summary>
        /// Expands by default at >= 992 px.
        /// </summary>
        LG,

        /// <summary>
        /// Expands by default at >= 1200 px.
        /// </summary>
        XL,

        /// <summary>
        /// The <see cref="Navbar"/> will never expand.
        /// </summary>
        Never,

        /// <summary>
        /// The <see cref="Navbar"/> is always expanded.
        /// </summary>
        Always
    }
}
