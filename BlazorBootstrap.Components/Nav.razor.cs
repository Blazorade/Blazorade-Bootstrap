using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class Nav
    {

        [Parameter]
        public NavContentAlignment? ContentAlignment { get; set; }

        protected override void OnParametersSet()
        {
            switch(this.ContentAlignment.GetValueOrDefault())
            {
                case NavContentAlignment.Center:
                    this.AddClass(ClassNames.Navs.AlignContentCenter);
                    break;

                case NavContentAlignment.Right:
                    this.AddClass(ClassNames.Navs.AlignContentRight);
                    break;
            }

            this.AddClass(ClassNames.Navs.Nav);
            base.OnParametersSet();
        }
    }
}
