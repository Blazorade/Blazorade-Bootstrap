using Blazorade.Bootstrap.Components.Content;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Media
    {
        /// <summary>
        /// </summary>
        public Media()
        {
            this.HeadingLevel = 5;
            this.ImageHorizontalAlignment = HorizontalAlignment.Left;
            this.ImageVerticalAlignment = VerticalAlignment.Top;
        }

        /// <summary>
        /// The heading to display in the component.
        /// </summary>
        public string Heading { get; set; }

        /// <summary>
        /// The heading level. Defaults to 5.
        /// </summary>
        public HeadingLevel HeadingLevel { get; set; }

        /// <summary>
        /// The heading display size. Defaults to <c>null</c>.
        /// </summary>
        public HeadingDisplay? HeadingDisplay { get; set; }

        /// <summary>
        /// The URL to the image to show in the component.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Allows you to completely control the rendering of the image.
        /// </summary>
        public RenderFragment<string> ImageTemplate { get; set; }

        /// <summary>
        /// The horizontal alignment of the image.
        /// </summary>
        public HorizontalAlignment ImageHorizontalAlignment { get; set; }

        /// <summary>
        /// The vertical alignment of the image.
        /// </summary>
        public VerticalAlignment ImageVerticalAlignment { get; set; }


        protected override void OnParametersSet()
        {

            base.OnParametersSet();
        }
    }
}
