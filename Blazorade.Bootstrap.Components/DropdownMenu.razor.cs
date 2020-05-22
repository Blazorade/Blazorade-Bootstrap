using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="DropdownMenu"/> component is uses as child component in a <see cref="Dropdown"/> component.
    /// It is the parent to one or many <see cref="DropdownItem"/> components.
    /// </summary>
    public partial class DropdownMenu
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Menu);
            base.OnParametersSet();
        }
    }
}
