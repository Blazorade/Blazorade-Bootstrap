using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components.Showroom
{
    partial class WikiLink
    {
        public WikiLink()
        {
            this.OpenInNewTab = true;
        }

        [Parameter]
        public string Page { get; set; }

        [Parameter]
        public string Section { get; set; }

        [Parameter]
        public bool OpenInNewTab { get; set; }


        public string Url { get; set; }


        protected override void OnParametersSet()
        {
            this.Url = "https://github.com/Blazorade/Blazorade-Bootstrap/wiki";
            if (!string.IsNullOrEmpty(this.Page))
            {
                this.Url = $"{this.Url}/{this.Page}";
            }
            if(!string.IsNullOrEmpty(this.Section))
            {
                this.Url = $"{this.Url}#{this.Section}";
            }

            base.OnParametersSet();
        }
    }
}
