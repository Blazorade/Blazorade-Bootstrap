using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselImageBase : ImageBase
    {
        protected override void OnParametersSet()
        {
            this.Width = ComponentSize.p100;
            this.AddClass("d-block");

            base.OnParametersSet();
        }
    }
}
