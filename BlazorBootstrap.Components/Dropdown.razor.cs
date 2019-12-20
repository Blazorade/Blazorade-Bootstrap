using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class DropdownBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Dropdown);

            base.OnParametersSet();
        }
    }
}
