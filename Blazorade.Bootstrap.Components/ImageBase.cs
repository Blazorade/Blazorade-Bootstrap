using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Base class for images.
    /// </summary>
    public abstract class ImageBase : BootstrapComponentBase
    {

        /// <summary>
        /// The absolute or relative URL of the image.
        /// </summary>
        [Parameter]
        public string Src { get; set; }

        /// <summary>
        /// The alt text to use for the image.
        /// </summary>
        [Parameter]
        public string Alt { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddAttribute("src", this.Src);
            if (!string.IsNullOrEmpty(this.Alt))
            {
                this.AddAttribute("alt", this.Alt);
            }

            base.OnParametersSet();
        }
    }
}
