using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Builder
{
    /// <summary>
    /// Defines modifiers for applying component features on the different responsive breakpoints supported by Bootstrap.
    /// </summary>
    /// <typeparam name="TFeature">The type of feature interface to return by the modifier methods.</typeparam>
    /// <remarks>
    /// The XS breakpoint is missing because anything not explicitly applied to a responsive breakpoint applies to
    /// all breakpoints, including XS.
    /// </remarks>
    public interface IResponsiveBreakpointModifiers<TFeature>
    {
        /// <summary>
        /// Configures the preceeding features to be applied on all responsive breakpoints.
        /// </summary>
        TFeature OnAll();

        /// <summary>
        /// Configures the preceeding features to be applied to the SM responsive breakpoint and above.
        /// </summary>
        TFeature OnSm();

        /// <summary>
        /// Configures the preceeding features to be applied to the MD responsive breakpoint and above.
        /// </summary>
        TFeature OnMd();

        /// <summary>
        /// Configures the preceeding features to be applied to the LG responsive breakpoint and above.
        /// </summary>
        TFeature OnLg();

        /// <summary>
        /// Configures the preceeding features to be applied to the XL responsive breakpoint and above.
        /// </summary>
        TFeature OnXl();
    }
}
