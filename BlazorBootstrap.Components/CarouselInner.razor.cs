using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselInnerBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Carousels.Inner);
            base.OnParametersSet();
        }
    }
}
