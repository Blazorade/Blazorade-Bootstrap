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
    /// <summary>
    /// A slideshow component for cycling through elements with virtually any kind of content.
    /// </summary>
    public partial class Carousel
    {
        /// <summary>
        /// </summary>
        public Carousel()
        {
            this.AutoStart = true;
            this.Interval = 5000;
            this.TransitionType = CarouselTransitionType.Slide;
        }


        /// <summary>
        /// Fired when the transition from one slide to another has started, but before it is completed.
        /// </summary>
        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlide { get; set; }

        /// <summary>
        /// Fired when the transition from one slide to another has completed.
        /// </summary>
        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlid { get; set; }



        private int CurrentSlideIndex = 0;
        private bool RequiresInit = true;


        private bool _AutoStart = true;
        /// <summary>
        /// Specifies whether the carousel should start automatically when loaded.
        /// </summary>
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

        /// <summary>
        /// An array of URLs pointing to images to show in the carousel.
        /// </summary>
        [Parameter]
        public IEnumerable<string> ImageUrls { get; set; }

        private int _Interval = 5000;
        /// <summary>
        /// The number of milliseconds each slide should be shown. The default is 5000ms.
        /// </summary>
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

        /// <summary>
        /// Specifies whether to show to controls on the carousel that allows the user to navigate to the next or previous slide.
        /// </summary>
        [Parameter]
        public bool ShowControls { get; set; }

        /// <summary>
        /// Specifies whether to show an indicator for each slide.
        /// </summary>
        [Parameter]
        public bool ShowIndicators { get; set; }

        /// <summary>
        /// Returns the number of slides currenty loaded into the carousel.
        /// </summary>
        public int SlideCount { get; private set; }

        /// <summary>
        /// Specifies how to transition from one slide to the other. The default is <see cref="CarouselTransitionType.Slide"/>.
        /// </summary>
        [Parameter]
        public CarouselTransitionType TransitionType { get; set; }



        /// <summary>
        /// Starts cycling through the slides in the carousel.
        /// </summary>
        public async Task CycleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "cycle");
        }

        /// <summary>
        /// Returns the number of slides currently loaded into the carousel.
        /// </summary>
        public async Task<int?> GetSlideCountAsync()
        {
            return await this.JsInterop.InvokeAsync<int?>(JsFunctions.Carousel.SlideCount, $"#{this.Id}");
        }

        /// <summary>
        /// Pauses the cycling of slides. The cycling can still be controlled with the other methods. Start auto cycling again with the <see cref="CycleAsync()"/> method.
        /// </summary>
        public async Task PauseAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "pause");
        }

        /// <summary>
        /// Moves the carousel to the given slide.
        /// </summary>
        /// <param name="slideNumber">The zero-based index of the slide to move to.</param>
        public async Task GoToSlideAsync(int slideNumber)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", slideNumber);
        }

        /// <summary>
        /// Moves the carousel to the previous slide. If the carousel is on the first slide, it will move to the last.
        /// </summary>
        public async Task PreviousAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "prev");
        }

        /// <summary>
        /// Moves the carousel to the next slide. If the carousel is on the last slide, it will move to the first.
        /// </summary>
        public async Task NextAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Carousel.Command, $"#{this.Id}", "next");
        }

        /// <summary>
        /// Used internally by JS interop.
        /// </summary>
        [JSInvokable]
        public async Task OnSlideAsync(JsonElement args)
        {
            var eargs = this.CreateSlideEventArgs(args);
            this.CurrentSlideIndex = eargs.To;
            this.StateHasChanged();

            await this.OnSlide.InvokeAsync(eargs);
        }

        /// <summary>
        /// Used internally by JS interop.
        /// </summary>
        [JSInvokable]
        public async Task OnSlidAsync(JsonElement args)
        {
            var eargs = this.CreateSlideEventArgs(args);
            await this.OnSlid.InvokeAsync(eargs);
        }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClasses(ClassNames.Carousels.Carousel);
            if(this.TransitionType == CarouselTransitionType.Fade)
            {
                this.AddClasses(ClassNames.Carousels.Fade);
            }

            this.AddAttribute("data-ride", "carousel");

            base.OnParametersSet();
        }

        /// <summary>
        /// </summary>
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

            var count = await this.GetSlideCountAsync();
            if(this.SlideCount != count)
            {
                this.SlideCount = count.GetValueOrDefault();
                this.StateHasChanged();
            }

            await base.OnAfterRenderAsync(firstRender);
        }



        private CarouselSlideEventArgs CreateSlideEventArgs(JsonElement args)
        {
            return new CarouselSlideEventArgs(this, args.GetProperty("from").GetInt32(), args.GetProperty("to").GetInt32(), args.GetProperty("direction").GetString());
        }

    }
}
