using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents one slide in a <see cref="Carousel" />.
    /// </summary>
    public partial class CarouselItem : BootstrapComponentBase
    {
        [CascadingParameter]
        private Carousel? ParentCarousel { get; set; }

        /// <summary>The image URL rendered by the slide.</summary>
        [Parameter]
        public string? ImageUrl { get; set; }

        /// <summary>The alternative text for the slide image.</summary>
        [Parameter]
        public string? ImageAlt { get; set; }

        /// <summary>The heading displayed in the slide caption.</summary>
        [Parameter]
        public string? CaptionHeading { get; set; }

        /// <summary>The body displayed in the slide caption.</summary>
        [Parameter]
        public string? CaptionBody { get; set; }

        /// <summary>A template that replaces the generated slide caption.</summary>
        [Parameter]
        public RenderFragment? CaptionTemplate { get; set; }

        internal int Index { get; set; } = -1;

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.ParentCarousel?.RegisterItem(this);
            this.AddClasses("carousel-item");
            if (this.ParentCarousel?.IsActive(this) == true)
            {
                this.AddClasses("active");
            }

            base.OnParametersSet();
        }
    }
}
