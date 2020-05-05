using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Modal component enables you to add dialogs to your site or application for lightboxes, user notification, 
    /// or virtually any kind of custom content that you want to have the user focus on.
    /// </summary>
    public partial class Modal
    {

        /// <summary>
        /// </summary>
        public Modal()
        {
            this.Fade = true;
            this.Size = ModalSize.Default;
        }


        /// <summary>
        /// Fires when the modal is beginning to hide.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> OnHide { get; set; }

        /// <summary>
        /// Fires when the modal has been hidden.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> OnHidden { get; set; }

        /// <summary>
        /// Fires when hiding the modal has been prevented.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> OnHidePrevented { get; set; }

        /// <summary>
        /// Fires when the modal is beginning to show.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> OnShow { get; set; }

        /// <summary>
        /// Fires when the modal has been shown.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> OnShown { get; set; }



        /// <summary>
        /// Defines how the backdrop for the modal is displayed.
        /// </summary>
        [Parameter]
        public Backdrop? Backdrop { get; set; }

        /// <summary>
        /// The body text to show in the body area of the dialog.
        /// </summary>
        [Parameter]
        public string Body { get; set; }

        /// <summary>
        /// Allows you to fully customize the body of the dialog. Consider using <see cref="ModalBody"/> as a wrapper for your custom content.
        /// </summary>
        [Parameter]
        public RenderFragment<string> BodyTemplate { get; set; }

        /// <summary>
        /// Specifies whether the Modal will fade when shown or hidden.
        /// </summary>
        [Parameter]
        public bool Fade { get; set; }

        /// <summary>
        /// Allows you to specify content for the footer of your dialog. Consider using <see cref="ModalFooter"/> as wrapper for your footer content.
        /// </summary>
        [Parameter]
        public RenderFragment FooterTemplate { get; set; }

        /// <summary>
        /// The header text to show in the header section of the dialog.
        /// </summary>
        [Parameter]
        public string Header { get; set; }

        /// <summary>
        /// Allows you to customize the header of your dialog. Consider using the <see cref="ModalHeader"/> and <see cref="CloseModalButton"/>
        /// components when customizing the header.
        /// </summary>
        [Parameter]
        public RenderFragment<string> HeaderTemplate { get; set; }

        /// <summary>
        /// Defines the size of the Modal.
        /// </summary>
        [Parameter]
        public ModalSize Size { get; set; }


        private Dictionary<string, object> DialogAttributes = new Dictionary<string, object>();


        /// <summary>
        /// Hides the modal dialog.
        /// </summary>
        public void Hide()
        {
            this.HideAsync();
        }

        /// <summary>
        /// Hides the modal dialog.
        /// </summary>
        public async Task HideAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Modal.Hide, $"#{this.Id}");
            await this.OnHiddenAsync();
        }

        /// <summary>
        /// Shows the modal dialog.
        /// </summary>
        public void Show()
        {
            this.ShowAsync();
        }

        private bool EventsRegistered = false;
        /// <summary>
        /// Shows the modal dialog.
        /// </summary>
        public async Task ShowAsync()
        {
            if (!this.EventsRegistered)
            {
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Modal.Show, this, nameof(this.OnShowAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Modal.Shown, this, nameof(this.OnShownAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Modal.Hide, this, nameof(this.OnHideAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Modal.Hidden, this, nameof(this.OnHiddenAsync), false);
                await this.JsInterop.RegisterEventCallbackAsync(this.Id, EventNames.Modal.HidePrevented, this, nameof(this.OnHidePreventedAsync), false);
                this.EventsRegistered = true;
            }

            await this.JsInterop.InvokeVoidAsync(JsFunctions.Modal.Show, $"#{this.Id}");
        }




        /// <summary>
        /// Fires the <see cref="OnHide"/> event.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnHideAsync()
        {
            await this.OnHide.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="OnHidden"/> event.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnHiddenAsync()
        {
            await this.OnHidden.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="OnHidePrevented"/> event.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnHidePreventedAsync()
        {
            await this.OnHidePrevented.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="OnShow"/> event.
        /// </summary>
        [JSInvokable]
        public virtual async Task OnShowAsync()
        {
            await this.OnShow.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="OnShown"/> event.
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
            this.SetIdIfEmpty();

            this.AddClasses(ClassNames.Modals.Modal);
            if (this.Fade)
            {
                this.AddClasses(ClassNames.Fade);
            }

            this.AddAttribute("role", "dialog");
            this.AddAttribute("tabindex", "-1");
            this.AddAttribute("aria-hidden", "true");

            var dialogClasses = new List<string>
            {
                ClassNames.Modals.Dialog
            };
            if(this.Size != ModalSize.Default)
            {
                dialogClasses.Add($"{ClassNames.Modals.Modal}-{this.Size.ToString().ToLower()}");
            }
            this.DialogAttributes["class"] = string.Join(" ", dialogClasses);


            if(this.Backdrop.HasValue)
            {
                string bdValue = "";
                switch (this.Backdrop.Value)
                {
                    case Components.Backdrop.Hidden:
                        bdValue = "false";
                        break;

                    case Components.Backdrop.Static:
                        bdValue = "static";
                        break;

                    default:
                        bdValue = "true";
                        break;
                }

                this.AddAttribute("data-backdrop", bdValue);
            }

            base.OnParametersSet();
        }

    }
}
