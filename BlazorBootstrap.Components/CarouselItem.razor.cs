using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselItemBase : BootstrapComponentBase
    {

        [Parameter]
        public bool IsActive { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Carousels.Item);

            if (this.IsActive)
            {
                this.AddClass(ClassNames.Active);
            }

            base.OnParametersSet();
        }
    }
}
