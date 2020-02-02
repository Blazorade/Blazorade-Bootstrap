using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class DropdownDivider
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Divider);
            base.OnParametersSet();
        }

    }
}
