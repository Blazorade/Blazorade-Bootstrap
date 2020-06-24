using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Layout
{
    /// <summary>
    /// The Container component is the foundation for many layout configurations in Bootstrap.
    /// </summary>
    /// <example>
    /// 
    /// </example>
    /// <seealso cref="Row"/>
    /// <seealso cref="Column"/>
    partial class Container
    {
        /// <summary>
        /// </summary>
        public Container()
        {
            this.Type = ContainerType.FixedWidth;
        }

        /// <summary>
        /// The type of container. The default is <see cref="ContainerType.FixedWidth"/>.
        /// </summary>
        [Parameter]
        public ContainerType Type { get; set; }


        /// <summary>
        /// </summary>
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
