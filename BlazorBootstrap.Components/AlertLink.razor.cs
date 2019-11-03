using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class AlertLinkBase : LinkBase
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Alerts.AlertLink);
            base.OnParametersSet();
        }
    }
}
