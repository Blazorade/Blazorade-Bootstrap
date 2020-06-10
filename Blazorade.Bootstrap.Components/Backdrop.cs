using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// Defines behaviour for modal backdrops on <see cref="Modal"/> components.
    /// </summary>
    /// <see cref="Modal"/>
    public enum Backdrop
    {
        /// <summary>
        /// Do not display a backdrop. Clicking outside of the modal will not close the modal.
        /// </summary>
        Hidden,

        /// <summary>
        /// Shows the default backdrop. Clicking the backdrop will close the modal.
        /// </summary>
        Default,

        /// <summary>
        /// A static backdrop. Clicking the backdrop will not close the modal.
        /// </summary>
        Static
    }

}
