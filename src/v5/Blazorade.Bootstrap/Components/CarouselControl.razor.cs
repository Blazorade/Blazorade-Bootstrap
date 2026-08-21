using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>Displays a control for moving through a <see cref="Carousel" />.</summary>
    public partial class CarouselControl : BootstrapComponentBase
    {
        /// <summary>The carousel controlled by this button.</summary>
        [Parameter, EditorRequired]
        public Carousel Carousel { get; set; } = default!;

        /// <summary>The direction in which the control moves.</summary>
        [Parameter]
        public CarouselControlDirection Direction { get; set; } = CarouselControlDirection.Next;

        /// <summary>The accessible label for the control.</summary>
        [Parameter]
        public string? Label { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses($"carousel-control-{(this.Direction == CarouselControlDirection.Next ? "next" : "prev")}");
            this.AddAttribute("data-bs-target", $"#{this.Carousel.Id}");
            this.AddAttribute("data-bs-slide", this.Direction == CarouselControlDirection.Next ? "next" : "prev");
            this.Label ??= this.Direction == CarouselControlDirection.Next ? "Next" : "Previous";
            base.OnParametersSet();
        }
    }
}
