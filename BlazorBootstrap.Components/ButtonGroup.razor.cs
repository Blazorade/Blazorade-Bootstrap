using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class ButtonGroup
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.ButtonGroups.Group);
            base.OnParametersSet();
        }
    }
}
