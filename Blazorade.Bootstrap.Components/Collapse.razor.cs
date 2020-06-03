using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Collapse</c> component is used to toggle the visibility of content.
    /// </summary>
    partial class Collapse
    {

        /// <summary>
        /// The callback that is triggered when the collapse is starting to show.
        /// </summary>
        [Parameter]
        public EventCallback<Collapse> OnShow { get; set; }

        /// <summary>
        /// The callback that is triggered when the collapse is completely shown.
        /// </summary>
        [Parameter]
        public EventCallback<Collapse> OnShown { get; set; }

        /// <summary>
        /// The callback that is triggered when the collapse is starting to hide.
        /// </summary>
        [Parameter]
        public EventCallback<Collapse> OnHide { get; set; }

        /// <summary>
        /// The callback that is triggered when the collapse is completely hidden.
        /// </summary>
        [Parameter]
        public EventCallback<Collapse> OnHidden { get; set; }



        /// <summary>
        /// Hides the component.
        /// </summary>
        public void Hide()
        {
            this.HideAsync();
        }

        /// <summary>
        /// Hides the component.
        /// </summary>
        public async Task HideAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Collapse.Hide, $"#{this.Id}");
        }

        /// <summary>
        /// Shows the component.
        /// </summary>
        public void Show()
        {
            this.ShowAsync();
        }

        /// <summary>
        /// Shows the component.
        /// </summary>
        public async Task ShowAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Collapse.Show, $"#{this.Id}");
        }

        /// <summary>
        /// Toggles the component.
        /// </summary>
        public void Toggle()
        {
            this.ToggleAsync();
        }

        /// <summary>
        /// Toggles the component.
        /// </summary>
        public async Task ToggleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Collapse.Toggle, $"#{this.Id}");
        }



        /// <summary>
        /// Triggers the <see cref="OnHide"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnHideAsync()
        {
            await this.OnHide.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnHidden"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnHiddenAsync()
        {
            await this.OnHidden.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnShow"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnShowAsync()
        {
            await this.OnShow.InvokeAsync(this);
        }

        /// <summary>
        /// Triggers the <see cref="OnShown"/> callback.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnShownAsync()
        {
            await this.OnShown.InvokeAsync(this);
        }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Collapses.Collapse);
            base.OnParametersSet();

            this.SetIdIfEmpty();
        }

        /// <summary>
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Collapse.Show, this, nameof(this.OnShowAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Collapse.Shown, this, nameof(this.OnShownAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Collapse.Hide, this, nameof(this.OnHideAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Collapse.Hidden, this, nameof(this.OnHiddenAsync), false);
            }
        }
    }
}
