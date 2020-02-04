using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class DropdownMenu
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Menu);
            base.OnParametersSet();
        }
    }
}
