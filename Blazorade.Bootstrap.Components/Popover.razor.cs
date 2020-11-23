using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Popover</c> component is used to create a popover on any element on your site.
    /// </summary>
    partial class Popover
    {

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public Popover()
        {
            
            this.Delay = 0;
            this.Placement = "right";
            this.Offset = 0;
            this.Html = true;
            this.Trigger = "click";
            this.TargetElementId = GenerateNewId();


        }



        /// <summary>
        /// The callback that is triggered when the Popover is about to hide.
        /// </summary>
        [Parameter]
        public EventCallback<Popover> OnHide { get; set; }

        /// <summary>
        /// The callback that is triggered when the Popover has been completely hidden.
        /// </summary>
        [Parameter]
        public EventCallback<Popover> OnHidden { get; set; }

        /// <summary>
        /// The callback that is triggered when the Popover is about to be shown.
        /// </summary>
        [Parameter]
        public EventCallback<Popover> OnShow { get; set; }

        /// <summary>
        /// The callback that is called when the Popover as been completely shown.
        /// </summary>
        [Parameter]
        public EventCallback<Popover> OnShown { get; set; }



        /// <summary>
        /// Specifies whether the Popover should automatically hide after the number of milliseconds specified in <see cref="Delay"/>.
        /// </summary>
        [Parameter]
        public bool AutoHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public string TargetElementId { get; set; }

        [Parameter]
        public string Content { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool Html { get; set; }

        [Parameter]
        public string Placement { get; set; }

        [Parameter]
        public string Trigger { get; set; }


        [Parameter]
        public int Offset { get; set; }

        [Parameter]
        public RenderFragment BodyTemplate { get; set; }

        [Parameter]
        public int Delay { get; set; }

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public RenderFragment HeaderTemplate { get; set; }

        /// <summary>
        /// Specifies whether the hide button is shown in the header of the Popover.
        /// </summary>
        [Parameter]
        public bool ShowHideButton { get; set; }

        /// <summary>
        /// Specifies whether to show the Popover immediately when rendered without having to separately invoke the <see cref="ShowAsync"/> method.
        /// </summary>
        [Parameter]
        public bool ShowOnRender { get; set; }

        [Parameter]
        public string Subheader { get; set; }



        public void Hide()
        {
            this.HideAsync();
        }

        public async Task HideAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Popover.Hide, $"#{this.Id}");
        }

        public void Show()
        {
            this.ShowAsync();
        }

        public async Task ShowAsync()
        {
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Popover.Show, this, nameof(this.OnShowAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Popover.Shown, this, nameof(this.OnShownAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Popover.Hide, this, nameof(this.OnHideAsync));
            await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Popover.Hidden, this, nameof(this.OnHiddenAsync));

            await this.JsInterop.InvokeVoidAsync(JsFunctions.Popover.Show, $"#{this.Id}");
        }


        protected override void OnParametersSet()
        {
           // this.AddClasses(ClassNames.Popovers.Popover);

             //this.AddClasses(ClassNames.Hide);

           // this.AddAttribute("role", "tooltip");
            // this.AddAttribute("aria-live", "assertive");
            // this.AddAttribute("aria-atomic", "true");

            base.OnParametersSet();

            this.SetIdIfEmpty();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (this.TargetElementId == null) TargetElementId = this.Id;

                await this.JsInterop.InvokeVoidAsync(JsFunctions.Popover.Init, $"#{this.TargetElementId}", this.Title, this.Content, this.Html, this.Delay, this.Placement, this.Trigger, this.Offset);
                if (this.ShowOnRender)
                {
                    await this.ShowAsync();
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
