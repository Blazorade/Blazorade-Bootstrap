using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class DropdownNavItem
    {
        public DropdownNavItem()
        {
            this.Url = "#";
        }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Dropdown);
            base.OnParametersSet();
        }
    }
}
