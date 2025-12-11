using Microsoft.AspNetCore.Components;
using System.Text;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// The base class for all Bootstrap components that support colour theming with the colours specified in <see cref="NamedColor"/>.
    /// </summary>
    public abstract class ColoredBootstrapComponentBase : BootstrapComponentBase
    {

        /// <summary>
        /// </summary>
        protected ColoredBootstrapComponentBase()
        {
            this.AddClasses(this.GetType().Name.ToLower());
        }


        /// <summary>
        /// Specifies the colour to use in the component.
        /// </summary>
        [Parameter]
        public NamedColor? Color { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            var styleContext = this.GetColorClassName(color: this.Color);
            this.AddClasses(styleContext);

            base.OnParametersSet();
        }

    }
}
