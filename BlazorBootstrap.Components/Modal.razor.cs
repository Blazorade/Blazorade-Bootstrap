using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public partial class Modal
    {

        public Modal()
        {
            this.Fade = true;
            this.Size = ModalSize.Default;
        }

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


        /// <summary>
        /// Hides the modal dialog.
        /// </summary>
        public async Task HideAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Modal.Hide, $"#{this.Id}");
        }

        /// <summary>
        /// Shows the modal dialog.
        /// </summary>
        public async Task ShowAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Modal.Show, $"#{this.Id}");
        }

        /// <summary>
        /// Toggles the modal dialog.
        /// </summary>
        public async Task ToggleAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Modal.Toggle, $"#{this.Id}");
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
