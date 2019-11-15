using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavbarCollapseBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Collapse);
            this.AddClass(ClassNames.Navbars.Collapse);

            base.OnParametersSet();
        }
    }
}
