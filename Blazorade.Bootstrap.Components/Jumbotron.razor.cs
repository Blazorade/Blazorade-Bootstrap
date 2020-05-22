using Blazorade.Bootstrap.Components.Content;
using Blazorade.Bootstrap.Components.Layout;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="Jumbotron"/> component is a lightweight and flexible component for showcasing content.
    /// </summary>
    partial class Jumbotron
    {

        /// <summary>
        /// </summary>
        public Jumbotron()
        {
            this.HeadingLevel = 1;
            this.HeadingDisplay = 4;
            this.FluidContainerType = ContainerType.Fluid;
        }

        /// <summary>
        /// The text to show in the heading of the jumbotron.
        /// </summary>
        [Parameter]
        public string Heading { get; set; }

        /// <summary>
        /// The heading level for the heading. Defaults to <see cref="HeadingLevel.H1"/>.
        /// </summary>
        [Parameter]
        public HeadingLevel HeadingLevel { get; set; }

        /// <summary>
        /// The display size for the heading. Defaults to 4.
        /// </summary>
        [Parameter]
        public HeadingDisplay HeadingDisplay { get; set; }

        /// <summary>
        /// Allows you to completely customize how the heading is rendered. The context parameter is the value specified in <see cref="Heading"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> HeadingTemplate { get; set; }

        /// <summary>
        /// Specifies whether the jumbotron is a fluid jumbotron.
        /// </summary>
        [Parameter]
        public bool IsFluid { get; set; }

        /// <summary>
        /// The container type to use for jumbotrons where <see cref="IsFluid"/> is set to <c>true</c>.
        /// </summary>
        [Parameter]
        public ContainerType FluidContainerType { get; set; }

        /// <summary>
        /// The lead text to show below the heading.
        /// </summary>
        [Parameter]
        public string Lead { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Jumbotrons.Jumbotron);
            if (this.IsFluid)
            {
                this.AddClasses(ClassNames.Jumbotrons.Fluid);
            }

            base.OnParametersSet();
        }

    }
}
