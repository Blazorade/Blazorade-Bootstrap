using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// A link that is used to toggle a <see cref="Dropdown"/> component.
    /// </summary>
    public partial class DropdownToggleLink
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Toggle);
            this.AddAttribute("role", "button");
            this.AddAttribute("data-toggle", "dropdown");
            this.AddAttribute("aria-haspopup", "true");
            this.AddAttribute("aria-expanded", "false");

            base.OnParametersSet();
        }
    }
}
