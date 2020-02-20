using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components.JSInterop
{
    public class PopoverInterop : ComponentInteropBase
    {
        public PopoverInterop(IJSRuntime interop) : base(interop)
        {
        }


        public async Task HideAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Popover.Hide, $"#{id}");
        }

        public async Task InitAsync(string id, string title, string content, bool html, int delay, string placement, string trigger, int offset)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Popover.Init, $"#{id}", title, content, html, delay, placement, trigger, offset);
        }

        public async Task ShowAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Popover.Show, $"#{id}");
        }

    }
}
