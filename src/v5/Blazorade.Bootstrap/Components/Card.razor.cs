using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Displays a Bootstrap card with named, templated sections.
    /// </summary>
    public partial class Card : BootstrapComponentBase
    {
        /// <summary>
        /// The card header template.
        /// </summary>
        [Parameter]
        public RenderFragment? Header { get; set; }

        /// <summary>
        /// The card body template.
        /// </summary>
        [Parameter]
        public RenderFragment? Body { get; set; }

        /// <summary>
        /// The card footer template.
        /// </summary>
        [Parameter]
        public RenderFragment? Footer { get; set; }

        /// <summary>
        /// The card image template.
        /// </summary>
        [Parameter]
        public RenderFragment? Image { get; set; }

        /// <summary>
        /// The card title template.
        /// </summary>
        [Parameter]
        public RenderFragment? Title { get; set; }

        /// <summary>
        /// The card subtitle template.
        /// </summary>
        [Parameter]
        public RenderFragment? Subtitle { get; set; }

        /// <summary>
        /// The card text template.
        /// </summary>
        [Parameter]
        public RenderFragment? Text { get; set; }

        /// <summary>
        /// The card links template.
        /// </summary>
        [Parameter]
        public RenderFragment? Links { get; set; }

        /// <summary>
        /// The URL of the default card image.
        /// </summary>
        [Parameter]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The alternative text for the default card image.
        /// </summary>
        [Parameter]
        public string? ImageAlt { get; set; }

        /// <summary>
        /// Specifies where the default card image is rendered.
        /// </summary>
        [Parameter]
        public CardImagePosition ImagePosition { get; set; } = CardImagePosition.Top;

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("card");
            base.OnParametersSet();
        }
    }
}