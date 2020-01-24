using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    public partial class Carousel
    {
        public Carousel()
        {
            this.AutoStart = true;
        }


        public EventCallback<Carousel> OnSlide { get; set; }

        public EventCallback<Carousel> OnSlid { get; set; }



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


        public async Task CycleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, "cycle");
        }

        public async Task PauseAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, "pause");
        }

        public async Task CycleToAsync(int slideNumber)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, slideNumber);
        }

        public async Task PreviousAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, "prev");
        }

        public async Task NextAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, "next");
        }

        [JSInvokable]
        public async Task OnSlideAsync()
        {
            await this.OnSlide.InvokeAsync(this);
        }

        [JSInvokable]
        public async Task OnSlidAsync()
        {
            System.Diagnostics.Debug.WriteLine($"Slid: {this.Id}");
            await this.OnSlid.InvokeAsync(this);
        }

        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClass(ClassNames.Carousels.Carousel);
            this.AddAttribute("data-ride", "carousel");

            base.OnParametersSet();

            this.SetIdIfEmpty();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (this.AutoStart)
                {
                    await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Init, $"#{this.Attributes["id"]}");
                }

                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Carousel.Slide, this, nameof(this.OnSlideAsync), false, new [] { "from", "to" });
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Carousel.Slid, this, nameof(this.OnSlidAsync), false, new[] { "from", "to" });
            }

            await base.OnAfterRenderAsync(firstRender);
        }


        private int GetSlideCount()
        {
            return this.ImageUrls?.Count() ?? 0;
        }

    }
}
