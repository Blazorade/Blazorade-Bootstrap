using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents an item in a <see cref="NavbarNav"/> component with child items.
    /// </summary>
    public partial class DropdownNavItem
    {
        /// <summary>
        /// </summary>
        public DropdownNavItem()
        {
            this.Url = "#";
        }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Dropdown);
            base.OnParametersSet();
        }
    }
}
