using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components.JSInterop
{
    public class ToastInterop
    {
        public ToastInterop(IJSRuntime jsInterop)
        {
            this.JSInterop = jsInterop;
        }

        private IJSRuntime JSInterop;


        public async Task HideAsync(string id)
        {
            await this.JSInterop.InvokeVoidAsync(JsFunctions.Toast.Hide, $"#{id}");
        }

        public async Task InitAsync(string id, bool autoHide = true, int delay = 5000)
        {
            await this.JSInterop.InvokeVoidAsync(JsFunctions.Toast.Init, $"#{id}", autoHide, delay);
        }

        public async Task ShowAsync(string id)
        {
            await this.JSInterop.InvokeVoidAsync(JsFunctions.Toast.Show, $"#{id}");
        }

    }
}
