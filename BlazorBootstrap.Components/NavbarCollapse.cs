using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public class NavbarCollapse : Collapse
    {

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClass(ClassNames.Navbars.Collapse);
        }
    }
}
