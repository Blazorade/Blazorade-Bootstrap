using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
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
                    this.AddClasses(ClassNames.Navs.AlignContentCenter);
                    break;

                case NavContentAlignment.Right:
                    this.AddClasses(ClassNames.Navs.AlignContentRight);
                    break;
            }

            this.AddClasses(ClassNames.Navs.Nav);
            base.OnParametersSet();
        }
    }
}
