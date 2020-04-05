using Blazorade.Bootstrap.Components.Layout;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class JumbotronContent
    {
        /// <summary>
        /// </summary>
        public JumbotronContent()
        {
            this.ContainerType = ContainerType.Fluid;
        }

        [Parameter]
        public ContainerType ContainerType { get; set; }

        [Parameter]
        public bool IsFluid { get; set; }
    }
}
