using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class DropdownMenuBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Menu);
            base.OnParametersSet();
        }
    }
}
