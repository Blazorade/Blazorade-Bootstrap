using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Container
    {
        public Container()
        {
            this.Type = ContainerType.FixedWidth;
        }

        [Parameter]
        public ContainerType Type { get; set; }


        protected override void OnParametersSet()
        {
            if(this.Type == ContainerType.FixedWidth)
            {
                this.AddClasses(ClassNames.Containers.FixedWidth);
            }
            else
            {
                this.AddClasses($"{ClassNames.Containers.FixedWidth}-{this.Type.ToString().ToLower()}");
            }

            base.OnParametersSet();
        }
    }
}
