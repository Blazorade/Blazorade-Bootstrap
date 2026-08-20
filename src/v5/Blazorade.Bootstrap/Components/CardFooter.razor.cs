namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders a card footer.
    /// </summary>
    public partial class CardFooter : BootstrapComponentBase
    {
        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("card-footer");
            base.OnParametersSet();
        }
    }
}