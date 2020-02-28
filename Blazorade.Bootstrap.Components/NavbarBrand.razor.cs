using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// This component is used to create the brand section of a <see cref="Navbar"/> component. This section usually displays
    /// the name of the application or site, with an additional logo. The brand also normally works as a link to the front
    /// page of the site or application.
    /// </summary>
    public partial class NavbarBrand
    {

        /// <summary>
        /// The URL, either relative or absolute, to an image to use as logo in the brand section. This works best with SVG images, since they scale much better than bitmap based images.
        /// </summary>
        [Parameter]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The text to show in the brand section. Typically the name or title of your site or application.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// The URL that the brand link will point to. Very often this is the link to the front page of your site or application.
        /// </summary>
        [Parameter]
        public string Url { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Navbars.Brand);

            base.OnParametersSet();
        }
    }
}
