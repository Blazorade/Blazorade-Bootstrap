using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Provides contextual feedback messages for typical user actions.
    /// </summary>
    public partial class Alert : ColoredBootstrapComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert"/> component.
        /// </summary>
        public Alert()
        {
            this.Color = NamedColor.Primary;
        }

        private const string AlertDismissFunction = "blazoradeBootstrap.alerts.dismiss";
        private const string RegisterEventCallbackFunction = "blazoradeBootstrap.registerEventCallback";
        private const string CloseEvent = "close.bs.alert";
        private const string ClosedEvent = "closed.bs.alert";

        /// <summary>
        /// The JavaScript runtime used to invoke Bootstrap's alert plugin.
        /// </summary>
        [Inject]
        protected IJSRuntime JsInterop { get; set; } = default!;

        /// <summary>
        /// The ID of the alert element.
        /// </summary>
        [Parameter]
        public string? Id { get; set; }

        /// <summary>
        /// The callback that is invoked when the alert starts being dismissed.
        /// </summary>
        [Parameter]
        public EventCallback<Alert> OnDismiss { get; set; }

        /// <summary>
        /// The callback that is invoked after the alert has been dismissed.
        /// </summary>
        [Parameter]
        public EventCallback<Alert> OnDismissed { get; set; }

        /// <summary>
        /// The text for the alert heading.
        /// </summary>
        /// <remarks>
        /// This parameter is ignored when <see cref="HeadingTemplate"/> is specified.
        /// </remarks>
        [Parameter]
        public string? Heading { get; set; }

        /// <summary>
        /// The template used to render the alert heading.
        /// </summary>
        [Parameter]
        public RenderFragment? HeadingTemplate { get; set; }

        /// <summary>
        /// Specifies whether the alert can be dismissed with a close button.
        /// </summary>
        [Parameter]
        public bool IsDismissible { get; set; }

        /// <summary>
        /// Specifies whether the alert should fade when it is dismissed.
        /// </summary>
        [Parameter]
        public bool FadeOnDismiss { get; set; }

        /// <summary>
        /// Dismisses the alert using Bootstrap's alert plugin.
        /// </summary>
        /// <remarks>
        /// The <see cref="IsDismissible"/> property must be <see langword="true"/>.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <see cref="IsDismissible"/> is <see langword="false"/>.
        /// </exception>
        public void Dismiss()
        {
            _ = this.DismissAsync();
        }

        /// <summary>
        /// Dismisses the alert using Bootstrap's alert plugin.
        /// </summary>
        /// <returns>A task that represents the asynchronous dismissal operation.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <see cref="IsDismissible"/> is <see langword="false"/>.
        /// </exception>
        public async Task DismissAsync()
        {
            if (!this.IsDismissible)
            {
                throw new InvalidOperationException("Cannot dismiss an Alert if the IsDismissible property is false.");
            }

            await this.JsInterop.InvokeVoidAsync(AlertDismissFunction, $"#{this.Id}");
        }

        /// <summary>
        /// Invokes the <see cref="OnDismiss"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnDismissAsync()
        {
            await this.OnDismiss.InvokeAsync(this);
        }

        /// <summary>
        /// Invokes the <see cref="OnDismissed"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnDismissedAsync()
        {
            await this.OnDismissed.InvokeAsync(this);
        }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("alert");

            if (this.IsDismissible)
            {
                this.AddClasses("alert-dismissible");
            }

            if (this.FadeOnDismiss)
            {
                this.AddClasses("fade");
                this.AddClasses("show");
            }

            base.OnParametersSet();

            if (this.IsDismissible)
            {
                this.Id ??= $"e{Guid.NewGuid():N}"[..9];
            }
        }

        /// <inheritdoc />
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender && this.IsDismissible)
            {
                await this.JsInterop.InvokeVoidAsync(
                    RegisterEventCallbackFunction,
                    $"#{this.Id}",
                    CloseEvent,
                    DotNetObjectReference.Create(this),
                    nameof(this.OnDismissAsync),
                    false);

                await this.JsInterop.InvokeVoidAsync(
                    RegisterEventCallbackFunction,
                    $"#{this.Id}",
                    ClosedEvent,
                    DotNetObjectReference.Create(this),
                    nameof(this.OnDismissedAsync),
                    false);
            }
        }
    }
}
