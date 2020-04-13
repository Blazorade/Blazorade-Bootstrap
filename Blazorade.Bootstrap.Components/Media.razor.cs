using Blazorade.Bootstrap.Components.Content;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// 
    /// </summary>
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
        [Parameter]
        public string Heading { get; set; }

        /// <summary>
        /// The heading level. Defaults to 5.
        /// </summary>
        [Parameter]
        public HeadingLevel HeadingLevel { get; set; }

        /// <summary>
        /// The heading display size. Defaults to <c>null</c>.
        /// </summary>
        [Parameter]
        public HeadingDisplay? HeadingDisplay { get; set; }

        /// <summary>
        /// Allows you to customize how the rendering is done. The context parameter is the value specified in <see cref="Heading"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> HeadingTemplate { get; set; }

        /// <summary>
        /// Defines the additional CSS styles to add to the image.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if you define the rendering of the image using the <see cref="ImageTemplate"/> parameter.
        /// </remarks>
        [Parameter]
        public string ImageCssStyle { get; set; }

        /// <summary>
        /// The URL to the image to show in the component.
        /// </summary>
        [Parameter]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Allows you to completely control the rendering of the image.
        /// </summary>
        [Parameter]
        public RenderFragment<string> ImageTemplate { get; set; }

        /// <summary>
        /// The horizontal alignment of the image.
        /// </summary>
        [Parameter]
        public HorizontalAlignment ImageHorizontalAlignment { get; set; }

        /// <summary>
        /// The vertical alignment of the image.
        /// </summary>
        [Parameter]
        public VerticalAlignment ImageVerticalAlignment { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.MediaObjects.Media);
            base.OnParametersSet();
        }

    }
}
