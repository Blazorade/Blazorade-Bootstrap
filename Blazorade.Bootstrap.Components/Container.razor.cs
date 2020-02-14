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

        /// <summary>
        /// Defines the type for the container. The default is <see cref="ContainerType.FixedWidth"/>.
        /// </summary>
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
