using Microsoft.AspNetCore.Components;
using System.Text;

namespace BlazorBootstrap.Components
{

    public abstract class ColoredBootstrapComponentBase : BootstrapComponentBase
    {

        protected ColoredBootstrapComponentBase()
        {
            this.AddClass(this.GetType().Name.ToLower());
        }


        [Parameter]
        public NamedColor? Color { get; set; }



        protected override void OnParametersSet()
        {
            var styleContext = this.GetColorClassName(color: this.Color);
            this.AddClass(styleContext);

            base.OnParametersSet();
        }

    }
}
