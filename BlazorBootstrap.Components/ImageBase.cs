using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class ImageBase : BootstrapComponentBase
    {

        [Parameter]
        public string Src { get; set; }

        [Parameter]
        public string Alt { get; set; }



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
