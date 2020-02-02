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
            this.AddClasses(ClassNames.Dropdowns.Dropdown);
            base.OnParametersSet();
        }
    }
}
