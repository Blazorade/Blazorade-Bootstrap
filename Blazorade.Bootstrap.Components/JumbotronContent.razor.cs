using Blazorade.Bootstrap.Components.Layout;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the contents of a <see cref="Jumbotron"/> component.
    /// </summary>
    partial class JumbotronContent
    {
        /// <summary>
        /// </summary>
        public JumbotronContent()
        {
            this.ContainerType = ContainerType.Fluid;
        }

        /// <summary>
        /// The container type for <see cref="Jumbotron"/> components that have <see cref="Jumbotron.IsFluid"/> set to <c>true</c>.
        /// </summary>
        [Parameter]
        public ContainerType ContainerType { get; set; }

        /// <summary>
        /// Defines if the containing <see cref="Jumbotron"/> component is a fluid container.
        /// </summary>
        [Parameter]
        public bool IsFluid { get; set; }

    }
}
