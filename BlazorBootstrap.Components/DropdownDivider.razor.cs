using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class DropdownDivider
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Divider);
            base.OnParametersSet();
        }

    }
}
