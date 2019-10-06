using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselImageBase : ImageBase
    {
        protected override void OnParametersSet()
        {
            this.AddClass("d-block");
            this.AddClass("w-100");

            base.OnParametersSet();
        }
    }
}
