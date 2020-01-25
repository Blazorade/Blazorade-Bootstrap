using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CarouselItem
    {
        public CarouselItem()
        {
            this.MinHeight = "200px";
        }


        [Parameter]
        public NamedColor? CaptionBackgroundColor { get; set; }

        [Parameter]
        public NamedColor? CaptionTextColor { get; set; }

        [Parameter]
        public string CaptionHeading { get; set; }

        [Parameter]
        public RenderFragment<string> CaptionHeadingTemplate { get; set; }

        [Parameter]
        public string CaptionBody { get; set; }

        [Parameter]
        public RenderFragment<string> CaptionBodyTemplate { get; set; }

        [Parameter]
        public string CustomCaptionBackgroundColor { get; set; }

        [Parameter]
        public string ImageUrl { get; set; }

        [Parameter]
        public ImageScaleMode ImageScaling { get; set; }

        /// <summary>
        /// Minimum height for the slide. Can be any value that can be specified for the <c>height</c> CSS style.
        /// </summary>
        [Parameter]
        public string MinHeight { get; set; }


        protected IDictionary<string, object> CaptionAttributes;

        private string ImageFitMode;


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
            


            this.AddClass(ClassNames.Carousels.Item);

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
