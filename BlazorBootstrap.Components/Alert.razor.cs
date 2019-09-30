using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap.Components
{
    public abstract class AlertBase : BootstrapStyledBase
    {

        [Parameter]
        public bool IsDismissible { get; set; }


        protected bool IsDismissed { get; private set; }

        protected void CloseButtonOnClick()
        {
            this.IsDismissed = true;
        }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Alerts.Alert);

            if (this.IsDismissible)
            {
                this.AddClass(ClassNames.Alerts.Dismissible);
            }

            base.OnParametersSet();
        }

    }
}
