using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Navbar</c> component is used to produce a responsive navigation header with built-in support for collapsing.
    /// </summary>
    public partial class Navbar
    {
        /// <summary>
        /// </summary>
        public Navbar()
        {
            this.ExpandAt = NavbarExpandBreakpoint.MD;
        }


        /// <summary>
        /// The text to use as the Brand text on the Navbar. The brand is the top-left element on the Navbar,
        /// which typically displays the name of the site or application.
        /// </summary>
        [Parameter]
        public string BrandText { get; set; }

        /// <summary>
        /// The link URL to use for the Brand text.
        /// </summary>
        [Parameter]
        public string BrandUrl { get; set; }

        /// <summary>
        /// The URL, either relative or absolute, to an image that will be used with the brand. <c>.svg</c> images work best,
        /// since they scale much better than bitmap based images such as <c>.png</c> or <c>.jpg</c>.
        /// </summary>
        [Parameter]
        public string BrandImageUrl { get; set; }

        /// <summary>
        /// Allows you to freely customize the Brand element on the Navbar.
        /// </summary>
        [Parameter]
        public RenderFragment<ILink> BrandTemplate { get; set; }

        /// <summary>
        /// Specifies whether the Brand is included in the collapsing part of the Navbar. The default, <c>false</c>, leaves the Brand element outside of the collapsing part of the Navbar.
        /// </summary>
        [Parameter]
        public bool CollapseBrand { get; set; }

        /// <summary>
        /// Defines the colour scheme for your Navbar. Controls the colour of the text used in the Navbar. You also have to specify the background colour for the Navbar.
        /// </summary>
        [Parameter]
        public NavbarColor? ColorScheme { get; set; }

        /// <summary>
        /// Specifies the responsive breakpoint at which the Navbar will expand from a collapsed state.
        /// </summary>
        [Parameter]
        public NavbarExpandBreakpoint? ExpandAt { get; set; }

        /// <summary>
        /// Specifies the placement for the Navbar.
        /// </summary>
        [Parameter]
        public NavbarPlacement? Placement { get; set; }


        /// <summary>
        /// </summary>
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

    /// <summary>
    /// Defines colour darkness for a <see cref="Navbar"/> component.
    /// </summary>
    public enum NavbarColor
    {
        /// <summary>
        /// The <see cref="Navbar"/> background colour is a dark colour.
        /// </summary>
        Dark,

        /// <summary>
        /// The <see cref="Navbar"/> background colour is a light colour.
        /// </summary>
        Light
    }

    /// <summary>
    /// Defines different placements for a <see cref="Navbar"/> component.
    /// </summary>
    public enum NavbarPlacement
    {
        /// <summary>
        /// The navbar is fixed to the top.
        /// </summary>
        FixedTop,

        /// <summary>
        /// The navbar is fixed to the bottom.
        /// </summary>
        FixedBottom,

        /// <summary>
        /// The navbar sticks to the top. Uses <c>position: sticky</c>, which may not be supported on all browsers.
        /// </summary>
        StickyTop
    }
}
