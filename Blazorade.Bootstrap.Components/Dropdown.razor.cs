using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Dropdown</c> component is a contextual overlay that displays a list of links and other elements. The <c>Dropdown</c> component can be toggled.
    /// </summary>
    public partial class Dropdown
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Dropdown);

            base.OnParametersSet();
        }
    }
}
