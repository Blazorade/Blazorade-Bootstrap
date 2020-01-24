using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    public partial class Carousel
    {
        public Carousel()
        {
            this.AutoStart = true;
            this.Interval = 5000;
            this.TransitionType = CarouselTransitionType.Slide;
        }


        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlide { get; set; }

        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlid { get; set; }



        private int CurrentSlideIndex = 0;
        private bool RequiresInit = true;


        private bool _AutoStart = true;
        [Parameter]
        public bool AutoStart
        {
            get { return _AutoStart; }
            set
            {
                this.RequiresInit = _AutoStart != value || this.RequiresInit;
                _AutoStart = value;
            }
        }

        [Parameter]
        public IEnumerable<string> ImageUrls { get; set; }

        private int _Interval = 5000;

        [Parameter]
        public int Interval
        {
            get { return _Interval; }
            set
            {
                this.RequiresInit = _Interval != value || this.RequiresInit;
                _Interval = value;
            }
        }

        [Parameter]
        public RenderFragment ItemsTemplate { get; set; }

        [Parameter]
        public bool ShowControls { get; set; }

        [Parameter]
        public bool ShowIndicators { get; set; }

        [Parameter]
        public CarouselTransitionType TransitionType { get; set; }

        [Inject]
        protected IJSRuntime JsInterop { get; set; }



        public async Task CycleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "cycle");
        }

        public async Task PauseAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "pause");
        }

        public async Task GoToSlideAsync(int slideNumber)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", slideNumber);
        }

        public async Task PreviousAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "prev");
        }

        public async Task NextAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "next");
        }

        [JSInvokable]
        public async Task OnSlideAsync(JsonElement args)
        {
            var eargs = this.CreateSlideEventArgs(args);
            this.CurrentSlideIndex = eargs.To;
            this.StateHasChanged();

            await this.OnSlide.InvokeAsync(eargs);
        }

        [JSInvokable]
        public async Task OnSlidAsync(JsonElement args)
        {
            var eargs = this.CreateSlideEventArgs(args);
            await this.OnSlid.InvokeAsync(eargs);
        }



        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClass(ClassNames.Carousels.Carousel);
            if(this.TransitionType == CarouselTransitionType.Fade)
            {
                this.AddClass(ClassNames.Carousels.Fade);
            }

            this.AddAttribute("data-ride", "carousel");

            base.OnParametersSet();
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (this.RequiresInit)
            {
                this.RequiresInit = false;


                await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Init, $"#{this.Attributes["id"]}", this.AutoStart, this.Interval);

                // The initialization process will dispose the carousel, so we need to register for the callback events after initializing.
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Carousel.Slide, this, nameof(this.OnSlideAsync), false, new[] { "from", "to", "direction" });
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Carousel.Slid, this, nameof(this.OnSlidAsync), false, new[] { "from", "to", "direction" });
            }

            await base.OnAfterRenderAsync(firstRender);
        }


        private CarouselSlideEventArgs CreateSlideEventArgs(JsonElement args)
        {
            return new CarouselSlideEventArgs(this, args.GetProperty("from").GetInt32(), args.GetProperty("to").GetInt32(), args.GetProperty("direction").GetString());
        }

        private int GetSlideCount()
        {
            return this.ImageUrls?.Count() ?? 0;
        }

    }
}
