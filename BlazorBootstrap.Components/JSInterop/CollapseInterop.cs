using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components.JSInterop
{
    public class CollapseInterop : ComponentInteropBase
    {
        public CollapseInterop(IJSRuntime interopRuntime) : base(interopRuntime) { }

        
        public async Task HideAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Collapse.Hide, $"#{id}");
        }

        public async Task ShowAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Collapse.Show, $"#{id}");
        }

        public async Task ToggleAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Collapse.Toggle, $"#{id}");
        }

    }
}
