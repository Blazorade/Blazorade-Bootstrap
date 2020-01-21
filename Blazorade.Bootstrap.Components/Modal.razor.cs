using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    public partial class Modal
    {

        public Modal()
        {
            this.Fade = true;
            this.Size = ModalSize.Default;
        }


        [Parameter]
        public EventCallback<Modal> Hidden { get; set; }

        [Parameter]
        public EventCallback<Modal> Shown { get; set; }

        [Parameter]
        public EventCallback<Modal> Toggled { get; set; }



        [Parameter]
        public string Body { get; set; }

        [Parameter]
        public RenderFragment<string> BodyTemplate { get; set; }

        [Parameter]
        public bool Fade { get; set; }

        [Parameter]
        public RenderFragment FooterTemplate { get; set; }

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public RenderFragment<string> HeaderTemplate { get; set; }

        [Parameter]
        public ModalSize Size { get; set; }



        [Inject]
        protected IJSRuntime JsInterop { get; set; }




        private string DialogClasses { get; set; }


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



        protected override void OnParametersSet()
        {
            this.SetIdIfEmpty();

            this.AddClass(ClassNames.Modals.Modal);
            if (this.Fade)
            {
                this.AddClass(ClassNames.Fade);
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
