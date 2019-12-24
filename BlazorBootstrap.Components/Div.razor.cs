using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class Div
    {

        [Parameter]
        public ContainerType? Container { get; set; }


        protected override void OnParametersSet()
        {
            if (this.Container.HasValue)
            {
                if(this.Container == ContainerType.FixedWidth)
                {
                    this.AddClass(ClassNames.Containers.FixedWidth);
                }
                else if(this.Container == ContainerType.Fluid)
                {
                    this.AddClass(ClassNames.Containers.Fluid);
                }
            }

            base.OnParametersSet();
        }
    }
}
