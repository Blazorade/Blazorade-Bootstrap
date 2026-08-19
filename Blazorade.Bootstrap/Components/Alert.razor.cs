using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Provides contextual feedback messages for typical user actions.
    /// </summary>
    public partial class Alert : ColoredBootstrapComponentBase
    {
        /// <summary>
        /// The text for the alert heading.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored when <see cref="HeadingTemplate"/> is specified.
        /// </remarks>
        [Parameter]
        public string? Heading { get; set; }

        /// <summary>
        /// The template used to render the alert heading.
        /// </summary>
        [Parameter]
        public RenderFragment? HeadingTemplate { get; set; }

        /// <summary>
        /// Specifies whether the alert can be dismissed with a close button.
        /// </summary>
        [Parameter]
        public bool IsDismissible { get; set; }

        /// <summary>
        /// Specifies whether the alert should fade when it is dismissed.
        /// </summary>
        [Parameter]
        public bool FadeOnDismiss { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            if (this.IsDismissible)
            {
                this.AddClasses("alert-dismissible");
            }

            if (this.FadeOnDismiss)
            {
                this.AddClasses("fade");
                this.AddClasses("show");
            }

            base.OnParametersSet();
        }
    }
}
