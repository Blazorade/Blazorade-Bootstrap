using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorBootstrap.Components
{
    public abstract class AlertBase : BootstrapColoredComponentBase
    {

        [Parameter]
        public bool IsDismissible { get; set; }

        [Parameter]
        public bool FadeOnDismiss { get; set; }



        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        protected async void CloseButtonOnClick()
        {
            await this.JsInterop.InvokeVoidAsync("blazorbs.alerts.dismiss", $"#{this.Attributes["id"]}", this.FadeOnDismiss);
        }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Alerts.Alert);

            if (this.IsDismissible)
            {
                this.AddClass(ClassNames.Alerts.Dismissible);
            }

            base.OnParametersSet();

            if(this.IsDismissible) this.SetIdIfEmpty();
        }

    }
}
