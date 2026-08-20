using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders a card body with optional named content templates.
    /// </summary>
    public partial class CardBody : BootstrapComponentBase
    {
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
        /// Specifies whether the body is rendered over an image.
        /// </summary>
        [Parameter]
        public bool IsImageOverlay { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses(this.IsImageOverlay ? "card-img-overlay" : "card-body");
            base.OnParametersSet();
        }
    }
}