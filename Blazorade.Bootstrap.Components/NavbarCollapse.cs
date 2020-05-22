using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Supports collapsing for <see cref="Navbar"/> components.
    /// </summary>
    public class NavbarCollapse : Collapse
    {

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.Navbars.Collapse);
        }
    }
}
