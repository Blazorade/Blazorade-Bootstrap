using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
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
