using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Badge</c> component is used to add counts and labels to other components.
    /// </summary>
    public partial class Badge : BootstrapComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Badge"/> component.
        /// </summary>
        public Badge()
        {
            this.Color = NamedColor.Secondary;
        }

        /// <summary>
        /// Specifies whether the badge has pill-shaped rounded corners.
        /// </summary>
        [Parameter]
        public bool IsPill { get; set; }

        /// <summary>
        /// Specifies the colour of the badge.
        /// </summary>
        [Parameter]
        public NamedColor? Color { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("badge");
            this.AddClasses(this.GetColorClassName("text-bg", this.Color));

            if (this.IsPill)
            {
                this.AddClasses("rounded-pill");
            }

            base.OnParametersSet();
        }
    }
}
