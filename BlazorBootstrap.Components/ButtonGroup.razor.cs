using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class ButtonGroupBase : BootstrapBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.ButtonGroups.Group);
            base.OnParametersSet();
        }
    }
}
