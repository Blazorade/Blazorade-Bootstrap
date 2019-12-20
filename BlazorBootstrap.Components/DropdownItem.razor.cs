using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class DropdownItemBase : AnchorBase
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Item);
            base.OnParametersSet();
        }
    }
}
