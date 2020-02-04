using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class Navbar
    {
        public Navbar()
        {
            this.ExpandAt = NavbarExpandBreakpoint.MD;
        }


        [Parameter]
        public string BrandText { get; set; }

        [Parameter]
        public string BrandUrl { get; set; }

        [Parameter]
        public string BrandImageUrl { get; set; }

        [Parameter]
        public RenderFragment<ILink> BrandTemplate { get; set; }

        [Parameter]
        public bool CollapseBrand { get; set; }

        [Parameter]
        public NavbarColor? ColorScheme { get; set; }

        [Parameter]
        public NavbarExpandBreakpoint? ExpandAt { get; set; }

        [Parameter]
        public NavbarPlacement? Placement { get; set; }


        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClasses(ClassNames.Navbars.Navbar);

            if(this.ColorScheme == NavbarColor.Light)
            {
                this.AddClasses(ClassNames.Navbars.Light);
            }
            else if(this.ColorScheme == NavbarColor.Dark)
            {
                this.AddClasses(ClassNames.Navbars.Dark);
            }


            if(this.Placement == NavbarPlacement.FixedBottom)
            {
                this.AddClasses(ClassNames.Navbars.FixedBottom);
            }
            else if(this.Placement == NavbarPlacement.FixedTop)
            {
                this.AddClasses(ClassNames.Navbars.FixedTop);
            }
            else if(this.Placement == NavbarPlacement.StickyTop)
            {
                this.AddClasses(ClassNames.Navbars.StickyTop);
            }

            if (this.ExpandAt.HasValue)
            {
                if(this.ExpandAt == NavbarExpandBreakpoint.Always)
                {
                    this.AddClasses("navbar-expand");
                }
                else if(this.ExpandAt != NavbarExpandBreakpoint.Never)
                {
                    this.AddClasses($"navbar-expand-{this.ExpandAt.ToString().ToLower()}");
                }
            }

            base.OnParametersSet();

        }

    }

    public enum NavbarColor
    {
        Dark,
        Light
    }

    public enum NavbarPlacement
    {
        FixedTop,
        FixedBottom,
        StickyTop
    }
}
