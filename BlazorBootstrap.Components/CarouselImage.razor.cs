using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class CarouselImage
    {
        protected override void OnParametersSet()
        {
            this.Width = ComponentSize.p100;
            this.AddClass("d-block");

            base.OnParametersSet();
        }
    }
}
