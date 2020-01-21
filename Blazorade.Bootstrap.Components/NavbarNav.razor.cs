using System;
using System.Collections.Generic;
using System.Text;
using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    public partial class NavbarNav
    {

        [Parameter]
        public IEnumerable<MenuItem> Items { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Navbars.Nav);
            base.OnParametersSet();
        }

    }
}
