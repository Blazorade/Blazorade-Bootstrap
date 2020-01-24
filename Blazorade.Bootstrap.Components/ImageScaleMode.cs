using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public enum ImageScaleMode
    {
        /// <summary>
        /// The image will be resized so that it completely fits within the area specified for the image.
        /// </summary>
        Fit,

        /// <summary>
        /// The image will be resized so that it completely fills the area specified for the image. Some cropping may occur.
        /// </summary>
        Fill
    }
}
