using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
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
