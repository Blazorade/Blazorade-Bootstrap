using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents a slide in a <see cref="Carousel"/> component.
    /// </summary>
    public partial class CarouselItem
    {
        /// <summary>
        /// </summary>
        public CarouselItem()
        {
            this.MinHeight = "200px";
        }


        /// <summary>
        /// The background colour for the caption of the slide.
        /// </summary>
        [Parameter]
        public NamedColor? CaptionBackgroundColor { get; set; }

        /// <summary>
        /// The text colour for the caption.
        /// </summary>
        [Parameter]
        public NamedColor? CaptionTextColor { get; set; }

        /// <summary>
        /// The heading text of the caption.
        /// </summary>
        [Parameter]
        public string CaptionHeading { get; set; }

        /// <summary>
        /// The template that allows you to completely customize the caption heading. The context variable contains the value specified in <see cref="CaptionHeading"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> CaptionHeadingTemplate { get; set; }

        /// <summary>
        /// The body text of the caption.
        /// </summary>
        [Parameter]
        public string CaptionBody { get; set; }

        /// <summary>
        /// Allows you to fully customize the caption body. The context variable contains the value specified in <see cref="CaptionBody"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> CaptionBodyTemplate { get; set; }

        /// <summary>
        /// The custom background colour to use on the caption. Can be any value that can be specified on the <c>background-color</c> CSS style.
        /// </summary>
        [Parameter]
        public string CustomCaptionBackgroundColor { get; set; }

        /// <summary>
        /// The URL to the image to show in the slide, if you want to show an image.
        /// </summary>
        [Parameter]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Defines how you want the image to be scaled within the slide.
        /// </summary>
        [Parameter]
        public ImageScaleMode? ImageScaling { get; set; }

        /// <summary>
        /// Minimum height for the slide. Can be any value that can be specified for the <c>height</c> CSS style.
        /// </summary>
        [Parameter]
        public string MinHeight { get; set; }


        private IDictionary<string, object> CaptionAttributes;

        private string ImageFitMode; // Used from the Razor file.


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.CaptionAttributes = new Dictionary<string, object>();
            this.Height = this.Height ?? ComponentSize.p100;
            switch (this.ImageScaling)
            {
                case ImageScaleMode.Fill:
                    this.ImageFitMode = "cover";
                    break;

                case ImageScaleMode.Fit:
                    this.ImageFitMode = "contain";
                    break;
            }
            


            this.AddClasses(ClassNames.Carousels.Item);

            if (!string.IsNullOrEmpty(this.MinHeight))
            {
                this.AddStyle("min-height", this.MinHeight);
            }

            var captionClasses = new List<string>
            {
                "carousel-caption",
                "d-md-block"
            };
            var captionStyles = new List<string>();

            if (this.CaptionBackgroundColor.HasValue) captionClasses.Add(this.GetColorClassName("bg", this.CaptionBackgroundColor));
            if (this.CaptionTextColor.HasValue) captionClasses.Add(this.GetColorClassName("text", this.CaptionTextColor));

            if (!string.IsNullOrEmpty(this.CustomCaptionBackgroundColor)) captionStyles.Add($"background-color: {this.CustomCaptionBackgroundColor}");

            this.CaptionAttributes.Add("class", string.Join(" ", captionClasses));
            if (captionStyles.Count > 0) this.CaptionAttributes.Add("style", string.Join("; ", captionStyles));

            base.OnParametersSet();
        }

    }
}
