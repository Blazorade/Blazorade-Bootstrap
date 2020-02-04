using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public class NavbarCollapse : Collapse
    {

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.Navbars.Collapse);
        }
    }
}
