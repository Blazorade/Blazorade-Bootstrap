using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Toast component is used to push notifications to your visitor as a lighweight and customizable alert message.
    /// </summary>
    partial class Toast
    {

        /// <summary>
        /// </summary>
        public Toast()
        {
            this.AutoHide = true;
            this.Delay = 5000;
            this.ShowHideButton = true;

        }



        /// <summary>
        /// The callback that is triggered when the toast is about to hide.
        /// </summary>
        [Parameter]
        public EventCallback<Toast> OnHide { get; set; }

        /// <summary>
        /// The callback that is triggered when the toast has been completely hidden.
        /// </summary>
        [Parameter]
        public EventCallback<Toast> OnHidden { get; set; }

        /// <summary>
        /// The callback that is triggered when the toast is about to be shown.
        /// </summary>
        [Parameter]
        public EventCallback<Toast> OnShow { get; set; }

        /// <summary>
        /// The callback that is called when the toast as been completely shown.
        /// </summary>
        [Parameter]
        public EventCallback<Toast> OnShown { get; set; }



        /// <summary>
        /// Specifies whether the toast should automatically hide after the number of milliseconds specified in <see cref="Delay"/>.
        /// </summary>
        [Parameter]
        public bool AutoHide { get; set; }

        /// <summary>
        /// Allows you to completely customize the body of the toast. You can also specify any child content for the toast to specify the body.
        /// </summary>
        [Parameter]
        public RenderFragment BodyTemplate { get; set; }

        /// <summary>
        /// The number of millseconds to show the toast before automatically hiding. Ignored if <see cref="AutoHide"/> is set to <c>false</c>.
        /// </summary>
        [Parameter]
        public int Delay { get; set; }

        /// <summary>
        /// The header text of the toast.
        /// </summary>
        [Parameter]
        public string Header { get; set; }

        /// <summary>
        /// Allows you to completely customize the header.
        /// </summary>
        [Parameter]
        public RenderFragment<string> HeaderTemplate { get; set; }

        /// <summary>
        /// Specifies whether the hide button is shown in the header of the toast.
        /// </summary>
        [Parameter]
        public bool ShowHideButton { get; set; }

        /// <summary>
        /// Specifies whether to show the toast immediately when rendered without having to separately invoke the <see cref="ShowAsync"/> method.
        /// </summary>
        [Parameter]
        public bool ShowOnRender { get; set; }

        /// <summary>
        /// The subheader of the toast.
        /// </summary>
        [Parameter]
        public string Subheader { get; set; }



        /// <summary>
        /// Hides the toast.
        /// </summary>
        public void Hide()
        {
            this.HideAsync();
        }

        /// <summary>
        /// Hides the toast.
        /// </summary>
        /// <returns></returns>
        public async Task HideAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Toast.Hide, $"#{this.Id}");
        }

        /// <summary>
        /// Shows the toast.
        /// </summary>
        public void Show()
        {
            this.ShowAsync();
        }

        /// <summary>
        /// Shows the toast.
        /// </summary>
        /// <returns></returns>
        public async Task ShowAsync()
        {
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Show, this, nameof(this.OnShowAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Shown, this, nameof(this.OnShownAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Hide, this, nameof(this.OnHideAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Hidden, this, nameof(this.OnHiddenAsync));

            await this.JsInterop.InvokeVoidAsync(JsFunctions.Toast.Show, $"#{this.Id}");
        }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Toasts.Toast);
            this.AddClasses(ClassNames.Hide);

            this.AddAttribute("role", "alert");
            this.AddAttribute("aria-live", "assertive");
            this.AddAttribute("aria-atomic", "true");

            base.OnParametersSet();

            this.SetIdIfEmpty();
        }

        /// <summary>
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await this.JsInterop.InvokeVoidAsync(JsFunctions.Toast.Init, $"#{this.Id}", this.AutoHide, this.Delay);
                if (this.ShowOnRender)
                {
                    await this.JsInterop.InvokeVoidAsync(JsFunctions.Toast.Show, $"#{this.Id}");
                }
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        /// <summary>
        /// Triggers the <see cref="OnHide"/> callback.
        /// </summary>
        /// <remarks>Invoked by JS Interop. Not to be called directly.</remarks>
        [JSInvokable]
        public virtual async Task OnHideAsync()
        {
            await this.OnHide.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnHidden"/> callback.
        /// </summary>
        /// <remarks>Invoked by JS Interop. Not to be called directly.</remarks>
        [JSInvokable]
        public virtual async Task OnHiddenAsync()
        {
            await this.OnHidden.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnShow"/> callback.
        /// </summary>
        /// <remarks>Invoked by JS Interop. Not to be called directly.</remarks>
        [JSInvokable]
        public virtual async Task OnShowAsync()
        {
            await this.OnShow.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnShown"/> callback.
        /// </summary>
        /// <remarks>Invoked by JS Interop. Not to be called directly.</remarks>
        [JSInvokable]
        public virtual async Task OnShownAsync()
        {
            await this.OnShown.InvokeAsync(this);
        }

    }
}
