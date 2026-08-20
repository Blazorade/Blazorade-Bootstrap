namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Groups cards using Bootstrap's card group layout.
    /// </summary>
    public partial class CardGroup : BootstrapComponentBase
    {
        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("card-group");
            base.OnParametersSet();
        }
    }
}