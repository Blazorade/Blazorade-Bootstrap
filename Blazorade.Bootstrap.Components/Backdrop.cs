using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// Defines behaviour for modal backdrops.
    /// </summary>
    public enum Backdrop
    {
        /// <summary>
        /// Do not display a backdrop.
        /// </summary>
        Hidden,

        /// <summary>
        /// Shows the default backdrop.
        /// </summary>
        Default,

        /// <summary>
        /// A static backdrop. Clicking the backdrop will not close the modal.
        /// </summary>
        Static
    }

}
