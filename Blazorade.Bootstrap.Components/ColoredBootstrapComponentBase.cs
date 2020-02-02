using Microsoft.AspNetCore.Components;
using System.Text;

namespace Blazorade.Bootstrap.Components
{

    public abstract class ColoredBootstrapComponentBase : BootstrapComponentBase
    {

        protected ColoredBootstrapComponentBase()
        {
            this.AddClasses(this.GetType().Name.ToLower());
        }


        [Parameter]
        public NamedColor? Color { get; set; }



        protected override void OnParametersSet()
        {
            var styleContext = this.GetColorClassName(color: this.Color);
            this.AddClasses(styleContext);

            base.OnParametersSet();
        }

    }
}
