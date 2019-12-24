using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class NavbarCollapse
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Collapse);
            this.AddClass(ClassNames.Navbars.Collapse);

            base.OnParametersSet();
        }
    }
}
