using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public partial class Carousel
    {
        public Carousel()
        {
            this.AutoStart = true;
        }



        [Parameter]
        public bool AutoStart { get; set; }

        [Parameter]
        public bool ShowControls { get; set; }

        [Parameter]
        public bool ShowIndicators { get; set; }

        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        [Parameter]
        public IEnumerable<string> ImageUrls { get; set; }


        protected int GetSlideCount()
        {
            return this.ImageUrls?.Count() ?? 0;
        }

        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClass(ClassNames.Carousels.Carousel);
            this.AddAttribute("data-ride", "carousel");

            base.OnParametersSet();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (this.AutoStart)
                {
                    await this.JsInterop.InvokeVoidAsync(JsNames.Carousel.Init, $"#{this.Attributes["id"]}");
                }
            }

            await base.OnAfterRenderAsync(firstRender);
        }

    }
}
