using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CarouselItem
    {
        protected override void OnParametersSet()
        {
            this.Height = this.Height ?? ComponentSize.p100;

            this.AddClass(ClassNames.Carousels.Item);
            base.OnParametersSet();
        }
    }
}
