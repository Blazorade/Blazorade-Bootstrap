using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class NavbarBrand
    {

        [Parameter]
        public string ImageUrl { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public string Url { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Navbars.Brand);

            base.OnParametersSet();
        }
    }
}
