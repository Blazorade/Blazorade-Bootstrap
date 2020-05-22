using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the image on a <see cref="Media"/> component.
    /// </summary>
    partial class MediaImage
    {

        /// <summary>
        /// The URL to the image to show in the component.
        /// </summary>
        [Parameter]
        public string Url { get; set; }

        /// <summary>
        /// The horizontal alignment of the image.
        /// </summary>
        [Parameter]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// The vertical alignment of the image.
        /// </summary>
        [Parameter]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Specifies the CSS styles to add to the image.
        /// </summary>
        [Parameter]
        public string CssStyle { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if(this.VerticalAlignment == VerticalAlignment.Middle)
            {
                this.AddClasses("align-self-center");
            }
            else if (this.VerticalAlignment == VerticalAlignment.Bottom)
            {
                this.AddClasses("align-self-end");
            }
            else
            {
                // Default to top.
                this.AddClasses("align-self-start");
            }

            if(this.HorizontalAlignment == HorizontalAlignment.Right)
            {
                this.AddClasses("ml-3");
            }
            else
            {
                // Default to left, i.e. margin is on the right.
                this.AddClasses("mr-3");
            }

            base.OnParametersSet();
        }
    }
}
