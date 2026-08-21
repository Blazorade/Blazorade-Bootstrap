using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Groups Bootstrap buttons together so that they appear joined.
    /// </summary>
    public partial class ButtonGroup : BootstrapComponentBase
    {
        /// <summary>
        /// Specifies the default size for buttons in the group.
        /// </summary>
        [Parameter]
        public ButtonSize Size { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("btn-group");

            switch (this.Size)
            {
                case ButtonSize.Large:
                    this.AddClasses("btn-group-lg");
                    break;
                case ButtonSize.Small:
                    this.AddClasses("btn-group-sm");
                    break;
            }

            base.OnParametersSet();
        }
    }
}