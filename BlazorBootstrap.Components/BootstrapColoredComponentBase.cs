using Microsoft.AspNetCore.Components;
using System.Text;

namespace BlazorBootstrap.Components
{

    public abstract class BootstrapColoredComponentBase : BootstrapComponentBase
    {

        protected BootstrapColoredComponentBase()
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
