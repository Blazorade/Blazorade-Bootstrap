using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavItemBase : BootstrapComponentBase
    {

        [Parameter]
        public IMenuItem Item { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Navbars.NavItem);
            base.OnParametersSet();
        }

    }
}
