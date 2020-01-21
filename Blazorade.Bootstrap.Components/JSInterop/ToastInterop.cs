using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components.JSInterop
{
    public class ToastInterop : ComponentInteropBase
    {
        public ToastInterop(IJSRuntime interop) : base(interop)
        {
        }


        public async Task HideAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Toast.Hide, $"#{id}");
        }

        public async Task InitAsync(string id, bool autoHide = true, int delay = 5000)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Toast.Init, $"#{id}", autoHide, delay);
        }

        public async Task ShowAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Toast.Show, $"#{id}");
        }

    }
}
