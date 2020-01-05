using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public class NavItemLink : Anchor
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Navs.Link);
            base.OnParametersSet();
        }
    }
}
