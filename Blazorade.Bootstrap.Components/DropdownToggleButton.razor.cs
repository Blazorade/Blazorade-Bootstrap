using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class DropdownToggleButton
    {

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
