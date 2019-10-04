using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class ButtonToolbarBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.ButtonToolbars.Toolbar);

            base.OnParametersSet();
        }
    }
}
