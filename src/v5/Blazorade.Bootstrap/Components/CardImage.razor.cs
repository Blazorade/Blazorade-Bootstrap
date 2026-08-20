using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders an image in a card.
    /// </summary>
    public partial class CardImage : BootstrapComponentBase
    {
        /// <summary>
        /// The image source URL.
        /// </summary>
        [Parameter]
        public string? Src { get; set; }

        /// <summary>
        /// The alternative text for the image.
        /// </summary>
        [Parameter]
        public string? Alt { get; set; }

        /// <summary>
        /// Specifies where the image is rendered in the card.
        /// </summary>
        [Parameter]
        public CardImagePosition Position { get; set; } = CardImagePosition.Top;

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses(this.Position == CardImagePosition.Overlay ? "card-img" : "card-img-" + this.Position.ToString().ToLowerInvariant());
            base.OnParametersSet();
        }
    }
}