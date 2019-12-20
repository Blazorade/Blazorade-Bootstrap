using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class DropdownDividerBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Divider);
            base.OnParametersSet();
        }

    }
}
