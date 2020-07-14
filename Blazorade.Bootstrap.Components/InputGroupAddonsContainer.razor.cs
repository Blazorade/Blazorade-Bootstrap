using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// A container for input group addons.
    /// </summary>
    /// <remarks>
    /// This component is primarily for use internally by <see cref="InputGroup"/>.
    /// </remarks>
    /// <seealso cref="InputGroup"/>
    partial class InputGroupAddonsContainer
    {

        /// <summary>
        /// Defines the placement of the container.
        /// </summary>
        [Parameter]
        public AddonPlacement? Placement { get; set; }

        /// <summary>
        /// Specifies the text to show as a basic text addon.
        /// </summary>
        /// <remarks>
        /// If not specified, only the addons you add to the child content of this container are shown.
        /// </remarks>
        [Parameter]
        public string AddonText { get; set; }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if(null == this.Placement || this.Placement == AddonPlacement.Prepend)
            {
                this.AddClasses(ClassNames.InputGroups.Prepend);
            }
            else if(this.Placement == AddonPlacement.Append)
            {
                this.AddClasses(ClassNames.InputGroups.Append);
            }
        }
    }
}
