using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines the different responsive breakpoints supported by Bootstrap.
    /// </summary>
    public enum ResponsiveBreakpoint
    {
        /// <summary>
        /// Extra small. &lt; 576 px.
        /// </summary>
        XS,

        /// <summary>
        /// Small. &gt;= 576 px
        /// </summary>
        SM,

        /// <summary>
        /// Medium. &gt;= 768 px.
        /// </summary>
        MD,

        /// <summary>
        /// Large. &gt;= 992 px.
        /// </summary>
        LG,

        /// <summary>
        /// Extra large. &gt;= 1200 px.
        /// </summary>
        XL
    }
}
