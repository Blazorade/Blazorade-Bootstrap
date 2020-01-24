using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class ImageCarouselItem
    {

        [Parameter]
        public string CaptionTitle { get; set; }

        [Parameter]
        public string CaptionBody { get; set; }

        [Parameter]
        public string ImageUrl { get; set; }

        [Parameter]
        public ImageScaleMode ImageScaling { get; set; }

        private string BackgroundSize;

        protected override void OnParametersSet()
        {
            this.BackgroundSize = this.ImageScaling == ImageScaleMode.Fill ? "cover" : "contain";
            base.OnParametersSet();
        }
    }
}
