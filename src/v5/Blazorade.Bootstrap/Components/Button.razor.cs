using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders a Bootstrap button.
    /// </summary>
    public partial class Button : BootstrapComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button"/> component.
        /// </summary>
        public Button()
        {
            this.Color = NamedColor.Primary;
        }

        /// <summary>
        /// The callback that is invoked when the button is clicked.
        /// </summary>
        [Parameter]
        public EventCallback<Button> OnClicked { get; set; }

        /// <summary>
        /// Specifies whether the button appears active.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the button is disabled.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Specifies whether the button is styled as an outline button.
        /// </summary>
        [Parameter]
        public bool IsOutline { get; set; }

        /// <summary>
        /// Specifies the colour of the button.
        /// </summary>
        [Parameter]
        public NamedColor? Color { get; set; }

        /// <summary>
        /// Specifies the size of the button.
        /// </summary>
        [Parameter]
        public ButtonSize Size { get; set; }

        /// <summary>
        /// Specifies the HTML button type.
        /// </summary>
        [Parameter]
        public ButtonType Type { get; set; }

        /// <summary>
        /// Invokes the <see cref="OnClicked"/> callback.
        /// </summary>
        protected virtual async Task OnClickedAsync()
        {
            await this.OnClicked.InvokeAsync(this);
        }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("btn");
            this.AddClasses(this.GetColorClassName(this.IsOutline ? "btn-outline" : "btn", this.Color));

            if (this.IsActive)
            {
                this.AddClasses("active");
            }

            switch (this.Size)
            {
                case ButtonSize.Large:
                    this.AddClasses("btn-lg");
                    break;
                case ButtonSize.Small:
                    this.AddClasses("btn-sm");
                    break;
            }

            if (this.IsDisabled)
            {
                this.AddAttribute("disabled", "disabled");
            }

            this.AddAttribute("type", this.Type switch
            {
                ButtonType.Submit => "submit",
                ButtonType.Reset => "reset",
                _ => "button"
            });

            base.OnParametersSet();
        }
    }

    /// <summary>
    /// Defines the available Bootstrap button sizes.
    /// </summary>
    public enum ButtonSize
    {
        /// <summary>
        /// The default button size.
        /// </summary>
        Normal,

        /// <summary>
        /// A large button.
        /// </summary>
        Large,

        /// <summary>
        /// A small button.
        /// </summary>
        Small
    }

    /// <summary>
    /// Defines the available HTML button types.
    /// </summary>
    public enum ButtonType
    {
        /// <summary>
        /// A button that does not submit a form.
        /// </summary>
        Button,

        /// <summary>
        /// A button that submits its form.
        /// </summary>
        Submit,

        /// <summary>
        /// A button that resets its form.
        /// </summary>
        Reset
    }
}
