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

        [Parameter]
        public string Width { get; set; }

        [Parameter]
        public string Height { get; set; }



        protected override void OnParametersSet()
        {
            this.AddAttribute("src", this.Src);
            if (!string.IsNullOrEmpty(this.Alt))
            {
                this.AddAttribute("alt", this.Alt);
            }

            var styles = new List<string>();
            if (!string.IsNullOrEmpty(this.Width)) styles.Add($"width:{this.Width}");
            if (!string.IsNullOrEmpty(this.Height)) styles.Add($"height:{this.Height}");

            if (styles.Count > 0)
            {
                this.AddAttribute("style", string.Join("; ", styles));
            }

            base.OnParametersSet();
        }
    }
}
