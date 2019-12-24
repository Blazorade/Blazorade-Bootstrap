using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
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
