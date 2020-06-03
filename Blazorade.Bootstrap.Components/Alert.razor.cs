using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Alert</c> component is used to provide feedback messages, typically in response to user actions.
    /// </summary>
    /// <seealso cref="AlertLink"/>
    public partial class Alert
    {

        /// <summary>
        /// The callback that is called when the alert is being dismissed, but not fully dismissed yet.
        /// </summary>
        [Parameter]
        public EventCallback<Alert> OnDismiss { get; set; }

        /// <summary>
        /// The callback that is called when the alert has completely been dismissed.
        /// </summary>
        [Parameter]
        public EventCallback<Alert> OnDismissed { get; set; }

        /// <summary>
        /// The template that is used to produce the heading of the alert.
        /// </summary>
        [Parameter]
        public RenderFragment HeadingTemplate { get; set; }

        /// <summary>
        /// The text for your alert heading.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored if <see cref="HeadingTemplate"/> is specified.
        /// </remarks>
        [Parameter]
        public string Heading { get; set; }

        /// <summary>
        /// Specifies whether the user can dismiss the alert.
        /// </summary>
        [Parameter]
        public bool IsDismissible { get; set; }

        /// <summary>
        /// Specifies whether the alert should fade when dismissed.
        /// </summary>
        [Parameter]
        public bool FadeOnDismiss { get; set; }



        /// <summary>
        /// Dismisses the alert.
        /// </summary>
        /// <remarks>
        /// The <see cref="IsDismissible"/> property must be set to <c>true</c> if you want to invoke this method.
        /// </remarks>
        /// <exception cref="InvalidOperationException">The exception that is thrown if the method is called when the <see cref="IsDismissible"/> property is set to <c>false</c>.</exception>
        public void Dismiss()
        {
            this.DismissAsync();
        }

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

            await this.JsInterop.InvokeVoidAsync(JsFunctions.Alert.Dismiss, $"#{this.Id}");
        }


        [JSInvokable]
        /// <summary>
        /// Triggers the <see cref="OnDismiss"/> callback.
        /// </summary>
        public virtual async Task OnDismissAsync()
        {
            await this.OnDismiss.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnDismissed"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnDismissedAsync()
        {
            await this.OnDismissed.InvokeAsync(this);
        }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Alerts.Alert);
            if (this.FadeOnDismiss)
            {
                this.AddClasses(ClassNames.Fade);
                this.AddClasses(ClassNames.Show);
            }

            if (this.IsDismissible)
            {
                this.AddClasses(ClassNames.Alerts.Dismissible);
            }

            base.OnParametersSet();

            if(this.IsDismissible) this.SetIdIfEmpty();
        }

        /// <summary>
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender && this.IsDismissible)
            {
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Alert.Close, this, nameof(this.OnDismissAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Alert.Closed, this, nameof(this.OnDismissedAsync), false);
            }
        }
    }
}
