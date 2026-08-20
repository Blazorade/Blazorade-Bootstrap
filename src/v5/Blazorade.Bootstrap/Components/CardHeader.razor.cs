namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders a card header.
    /// </summary>
    public partial class CardHeader : BootstrapComponentBase
    {
        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("card-header");
            base.OnParametersSet();
        }
    }
}