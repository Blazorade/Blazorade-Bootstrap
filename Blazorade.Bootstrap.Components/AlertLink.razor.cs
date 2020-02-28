using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class AlertLink
    {
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Alerts.AlertLink);

            base.OnParametersSet();
        }
    }
}
