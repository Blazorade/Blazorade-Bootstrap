using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="DropdownDivider"/> component is used to add a divider between items in a <see cref="Dropdown"/> menu.
    /// </summary>
    public partial class DropdownDivider
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Divider);
            base.OnParametersSet();
        }

    }
}
