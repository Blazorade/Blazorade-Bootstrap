using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class DropdownToggleLinkBase : AnchorBase
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Toggle);
            this.AddAttribute("role", "button");
            this.AddAttribute("data-toggle", "dropdown");
            this.AddAttribute("aria-haspopup", "true");
            this.AddAttribute("aria-expanded", "false");

            base.OnParametersSet();
        }
    }
}
