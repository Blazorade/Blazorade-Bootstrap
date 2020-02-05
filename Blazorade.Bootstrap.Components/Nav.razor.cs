using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Nav
    {

        [Parameter]
        public ContentAlignment? ContentAlignment { get; set; }

        protected override void OnParametersSet()
        {
            switch(this.ContentAlignment.GetValueOrDefault())
            {
                case Components.ContentAlignment.Center:
                    this.AddClasses(ClassNames.Navs.AlignContentCenter);
                    break;

                case Components.ContentAlignment.Right:
                    this.AddClasses(ClassNames.Navs.AlignContentRight);
                    break;
            }

            this.AddClasses(ClassNames.Navs.Nav);
            base.OnParametersSet();
        }
    }
}
