using System;
using System.Collections.Generic;
using System.Text;
using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap.Components
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
