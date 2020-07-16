using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Configuration
{
    /// <summary>
    /// Defines options for tooltips.
    /// </summary>
    public class TooltipOptions
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public TooltipOptions()
        {
            this.DefaultPlacement = TooltipPlacement.Top;
            this.SanitizeHtml = true;
        }


        /// <summary>
        /// Specifies whether to allow HTML markup in tooltips. Default is <c>false</c>.
        /// </summary>
        public bool AllowHtml { get; set; }

        /// <summary>
        /// Specifies the default placement for your tooltips. The default is <see cref="TooltipPlacement.Top"/>.
        /// </summary>
        public TooltipPlacement DefaultPlacement { get; set; }

        /// <summary>
        /// Determines whether HTML markup will be sanitized using the configured sanitization mechanism. Default is <c>true</c>.
        /// </summary>
        public bool SanitizeHtml { get; set; }
    }
}
