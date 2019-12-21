using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavbarBrandBase : BootstrapComponentBase
    {

        [Parameter]
        public string ImageUrl { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public string Url { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Navbars.Brand);

            base.OnParametersSet();
        }
    }
}
