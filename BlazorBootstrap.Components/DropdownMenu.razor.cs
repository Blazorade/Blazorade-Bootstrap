using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class DropdownMenu
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Menu);
            base.OnParametersSet();
        }
    }
}
