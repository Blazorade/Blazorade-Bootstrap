using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavbarBase : BootstrapComponentBase
    {
        protected NavbarBase()
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

            this.AddClass(ClassNames.Navbars.Navbar);

            if(this.ColorScheme == NavbarColor.Light)
            {
                this.AddClass(ClassNames.Navbars.Light);
            }
            else if(this.ColorScheme == NavbarColor.Dark)
            {
                this.AddClass(ClassNames.Navbars.Dark);
            }


            if(this.Placement == NavbarPlacement.FixedBottom)
            {
                this.AddClass(ClassNames.Navbars.FixedBottom);
            }
            else if(this.Placement == NavbarPlacement.FixedTop)
            {
                this.AddClass(ClassNames.Navbars.FixedTop);
            }
            else if(this.Placement == NavbarPlacement.StickyTop)
            {
                this.AddClass(ClassNames.Navbars.StickyTop);
            }

            if (this.ExpandAt.HasValue)
            {
                if(this.ExpandAt == NavbarExpandBreakpoint.Always)
                {
                    this.AddClass("navbar-expand");
                }
                else if(this.ExpandAt != NavbarExpandBreakpoint.Never)
                {
                    this.AddClass($"navbar-expand-{this.ExpandAt.ToString().ToLower()}");
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
