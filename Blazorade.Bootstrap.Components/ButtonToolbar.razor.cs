using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ButtonToolbar
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.ButtonToolbars.Toolbar);

            base.OnParametersSet();
        }
    }
}
