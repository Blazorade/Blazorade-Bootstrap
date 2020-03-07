using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components.Utilities
{
    /// <summary>
    /// A close icon for <see cref="Modal"/> components.
    /// </summary>
    public class ModalCloseIcon : CloseIcon
    {

        /// <summary>
        /// </summary>
        protected override Task OnParametersSetAsync()
        {
            this.AddAttribute("data-dismiss", "modal");
            return base.OnParametersSetAsync();
        }
    }
}
