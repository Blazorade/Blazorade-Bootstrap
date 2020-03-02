using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class DropdownItem : Anchor
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Item);
            base.OnParametersSet();
        }
    }
}
