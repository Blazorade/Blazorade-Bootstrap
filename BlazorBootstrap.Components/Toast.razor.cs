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

        [Inject]
        protected IJSRuntime JsInterop { get; set; }


        public async Task ShowAsync()
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Toast.Show, $"#{this.Id}");
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
            await this.JsInterop.InvokeVoidAsync(JsNames.Toast.Init, $"#{this.Id}");

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
