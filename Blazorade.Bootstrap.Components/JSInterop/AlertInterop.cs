using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components.JSInterop
{
    public class AlertInterop : ComponentInteropBase
    {
        public AlertInterop(IJSRuntime interop) : base(interop) { }


        public async Task DismissAsync(string id)
        {
            await this.InteropRuntime.InvokeVoidAsync(JsFunctions.Alert.Dismiss, $"#{id}");
        }
    }
}
