using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorBootstrap.Components
{
    public abstract class AlertBase : ColoredBootstrapComponentBase
    {

        [Parameter]
        public RenderFragment AlertHeading { get; set; }

        [Parameter]
        public bool IsDismissible { get; set; }

        [Parameter]
        public bool FadeOnDismiss { get; set; }


        /// <summary>
        /// Dismisses the alert.
        /// </summary>
        /// <remarks>
        /// The <see cref="IsDismissible"/> property must be set to <c>true</c> if you want to invoke this method.
        /// </remarks>
        /// <exception cref="InvalidOperationException">The exception that is thrown if the method is called when the <see cref="IsDismissible"/> property is set to <c>false</c>.</exception>
        public async Task DismissAsync()
        {
            if (!this.IsDismissible)
            {
                throw new InvalidOperationException("Cannot dismiss an Alert if the IsDismissible property is false.");
            }

            await this.JsInterop.InvokeVoidAsync("blazorbs.alerts.dismiss", $"#{this.Attributes["id"]}", this.FadeOnDismiss);
        }


        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        protected async Task CloseButtonOnClick()
        {
            await this.DismissAsync();
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
