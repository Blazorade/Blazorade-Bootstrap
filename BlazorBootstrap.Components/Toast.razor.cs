using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    partial class Toast
    {

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

        [Parameter]
        public RenderFragment BodyTemplate { get; set; }

        [Parameter]
        public int Delay { get; set; }

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public RenderFragment HeaderTemplate { get; set; }

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

        [Parameter]
        public string Subheader { get; set; }




        [Inject]
        protected IJSRuntime JsInterop { get; set; }



        public void Hide()
        {
            this.HideAsync();
        }

        public async Task HideAsync()
        {
            await this.JsInterop.Toast().HideAsync(this.Id);
        }

        public void Show()
        {
            this.ShowAsync();
        }

        public async Task ShowAsync()
        {
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Show, this, nameof(this.OnShowAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Shown, this, nameof(this.OnShownAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Hide, this, nameof(this.OnHideAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Toast.Hidden, this, nameof(this.OnHiddenAsync));

            await this.JsInterop.Toast().ShowAsync(this.Id);
        }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Toasts.Toast);
            this.AddClass(ClassNames.Hide);

            this.AddAttribute("role", "alert");
            this.AddAttribute("aria-live", "assertive");
            this.AddAttribute("aria-atomic", "true");

            base.OnParametersSet();

            this.SetIdIfEmpty();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await this.JsInterop.Toast().InitAsync(this.Id, this.AutoHide, this.Delay);
                if (this.ShowOnRender)
                {
                    await this.JsInterop.Toast().ShowAsync(this.Id);
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
