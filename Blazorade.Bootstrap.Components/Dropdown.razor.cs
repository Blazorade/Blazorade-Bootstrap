using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="Dropdown"/> component is a contextual overlay that displays a list of links and other elements. The <see cref="Dropdown"/> can be toggled.
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
