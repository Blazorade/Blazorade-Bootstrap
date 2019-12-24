using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class CarouselInner
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Carousels.Inner);
            base.OnParametersSet();
        }
    }
}
