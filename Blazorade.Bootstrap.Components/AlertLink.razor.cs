using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class AlertLink
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Alerts.AlertLink);
            base.OnParametersSet();
        }
    }
}
