using System.Text.Json;
using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// A slideshow component for cycling through elements with virtually any kind of content.
    /// </summary>
    public partial class Carousel : BootstrapComponentBase, IDisposable
    {
        private const string RegisterEventCallbackFunction = "blazoradeBootstrap.registerCarouselEventCallback";
        private readonly List<CarouselItem> items = new();
        private int currentSlideIndex;
        private DotNetObjectReference<Carousel>? dotNetReference;

        /// <summary>
        /// The ID of the carousel element.
        /// </summary>
        [Parameter]
        public string? Id { get; set; }

        /// <summary>
        /// Specifies whether the carousel should start cycling automatically.
        /// </summary>
        [Parameter]
        public bool AutoStart { get; set; } = true;

        /// <summary>
        /// The number of milliseconds each slide is shown. The default is 5000 milliseconds.
        /// </summary>
        [Parameter]
        public int Interval { get; set; } = 5000;

        /// <summary>
        /// Specifies whether navigation controls are rendered.
        /// </summary>
        [Parameter]
        public bool ShowControls { get; set; }

        /// <summary>
        /// Specifies whether an indicator is rendered for each slide.
        /// </summary>
        [Parameter]
        public bool ShowIndicators { get; set; }

        /// <summary>
        /// The zero-based index of the initially active slide.
        /// </summary>
        [Parameter]
        public int ActiveIndex { get; set; }

        /// <summary>
        /// Specifies how to transition between slides.
        /// </summary>
        [Parameter]
        public CarouselTransitionType TransitionType { get; set; } = CarouselTransitionType.Slide;

        /// <summary>
        /// Fired when a transition from one slide to another starts.
        /// </summary>
        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlide { get; set; }

        /// <summary>
        /// Fired when a transition from one slide to another completes.
        /// </summary>
        [Parameter]
        public EventCallback<CarouselSlideEventArgs> OnSlid { get; set; }

        /// <summary>
        /// Gets the number of slides currently rendered by the carousel.
        /// </summary>
        public int SlideCount => this.items.Count;

        /// <summary>Starts cycling through the slides.</summary>
        public Task CycleAsync() => this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.carousels.cycle", $"#{this.Id}").AsTask();

        /// <summary>Pauses cycling through the slides.</summary>
        public Task PauseAsync() => this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.carousels.pause", $"#{this.Id}").AsTask();

        /// <summary>Moves to the specified zero-based slide index.</summary>
        public Task GoToSlideAsync(int slideNumber) => this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.carousels.to", $"#{this.Id}", slideNumber).AsTask();

        /// <summary>Moves to the previous slide.</summary>
        public Task PreviousAsync() => this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.carousels.prev", $"#{this.Id}").AsTask();

        /// <summary>Moves to the next slide.</summary>
        public Task NextAsync() => this.JsInterop.InvokeVoidAsync("blazoradeBootstrap.carousels.next", $"#{this.Id}").AsTask();

        /// <summary>Returns the number of slides known to Bootstrap.</summary>
        public Task<int?> GetSlideCountAsync() => this.JsInterop.InvokeAsync<int?>("blazoradeBootstrap.carousels.slideCount", $"#{this.Id}").AsTask();

        internal void RegisterItem(CarouselItem item)
        {
            if (!this.items.Contains(item))
            {
                this.items.Add(item);
                _ = this.InvokeAsync(this.StateHasChanged);
            }

            item.Index = this.items.IndexOf(item);
        }

        internal bool IsActive(CarouselItem item)
        {
            return item.Index == this.currentSlideIndex;
        }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.Id ??= $"carousel-{Guid.NewGuid():N}"[..18];
            this.currentSlideIndex = this.ActiveIndex;
            this.AddClasses("carousel");
            if (this.TransitionType == CarouselTransitionType.Fade)
            {
                this.AddClasses("carousel-fade");
            }

            if (this.AutoStart)
            {
                this.AddAttribute("data-bs-ride", "carousel");
            }

            this.AddAttribute("data-bs-interval", this.Interval);
            base.OnParametersSet();
        }

        /// <inheritdoc />
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                this.dotNetReference = DotNetObjectReference.Create(this);
                await this.JsInterop.InvokeVoidAsync(RegisterEventCallbackFunction, $"#{this.Id}", "slide.bs.carousel", this.dotNetReference, nameof(this.OnSlideAsync));
                await this.JsInterop.InvokeVoidAsync(RegisterEventCallbackFunction, $"#{this.Id}", "slid.bs.carousel", this.dotNetReference, nameof(this.OnSlidAsync));
            }
        }

        /// <summary>Handles Bootstrap's slide event.</summary>
        [JSInvokable]
        public async Task OnSlideAsync(JsonElement args)
        {
            var eventArgs = this.CreateSlideEventArgs(args);
            this.currentSlideIndex = eventArgs.To;
            await this.InvokeAsync(this.StateHasChanged);
            await this.OnSlide.InvokeAsync(eventArgs);
        }

        /// <summary>Handles Bootstrap's slid event.</summary>
        [JSInvokable]
        public Task OnSlidAsync(JsonElement args)
        {
            return this.OnSlid.InvokeAsync(this.CreateSlideEventArgs(args));
        }

        private CarouselSlideEventArgs CreateSlideEventArgs(JsonElement args)
        {
            return new CarouselSlideEventArgs(
                this,
                args.GetProperty("from").GetInt32(),
                args.GetProperty("to").GetInt32(),
                args.GetProperty("direction").GetString() ?? string.Empty);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            this.dotNetReference?.Dispose();
        }
    }
}
