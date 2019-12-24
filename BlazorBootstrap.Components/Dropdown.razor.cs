using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class Dropdown
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Dropdown);

            base.OnParametersSet();
        }
    }
}
