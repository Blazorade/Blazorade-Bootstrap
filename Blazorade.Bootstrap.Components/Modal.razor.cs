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
        /// Fires when the modal has been hidden.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> Hidden { get; set; }

        /// <summary>
        /// Fires when the modal has been shown.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> Shown { get; set; }

        /// <summary>
        /// Fires when the modal has been toggled.
        /// </summary>
        [Parameter]
        public EventCallback<Modal> Toggled { get; set; }



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



        private string DialogClasses { get; set; }


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

        /// <summary>
        /// Shows the modal dialog.
        /// </summary>
        public async Task ShowAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Modal.Show, $"#{this.Id}");
            await this.OnShownAsync();
        }

        /// <summary>
        /// Toggles the modal dialog.
        /// </summary>
        public void Toggle()
        {
            this.ToggleAsync();
        }

        /// <summary>
        /// Toggles the modal dialog.
        /// </summary>
        public async Task ToggleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Modal.Toggle, $"#{this.Id}");
            await this.OnToggledAsync();
        }

        /// <summary>
        /// Performs the specified action on the modal.
        /// </summary>
        /// <param name="action">The action to perform on the modal.</param>
        public void Toggle(ToggleAction action)
        {
            this.ToggleAsync(action);
        }

        /// <summary>
        /// Performs the specified action on the modal.
        /// </summary>
        /// <param name="action">The action to perform on the modal.</param>
        public async Task ToggleAsync(ToggleAction action)
        {
            switch(action)
            {
                case ToggleAction.Hide:
                    await this.HideAsync();
                    break;

                case ToggleAction.Show:
                    await this.ShowAsync();
                    break;

                case ToggleAction.Toggle:
                    await this.ToggleAsync();
                    break;
            }
        }


        /// <summary>
        /// Fires the <see cref="Hidden"/> event.
        /// </summary>
        protected virtual async Task OnHiddenAsync()
        {
            await this.Hidden.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="Shown"/> event.
        /// </summary>
        protected virtual async Task OnShownAsync()
        {
            await this.Shown.InvokeAsync(this);
        }

        /// <summary>
        /// Fires the <see cref="Toggled"/> event.
        /// </summary>
        protected virtual async Task OnToggledAsync()
        {
            await this.Toggled.InvokeAsync(this);
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
            this.DialogClasses = string.Join(" ", dialogClasses);


            base.OnParametersSet();
        }
    }
}
