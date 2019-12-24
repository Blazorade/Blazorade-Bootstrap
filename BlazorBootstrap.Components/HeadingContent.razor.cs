using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public partial class HeadingContent
    {

        [Parameter]
        public string AnchorId { get; set; }

        [Parameter]
        public string HeadingId { get; set; }

        [Parameter]
        public bool IsAnchor { get; set; }



        [Inject]
        protected IJSRuntime JsInterop { get; set; }


        protected async Task AnchorOnClick(MouseEventArgs e)
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Anchor.ScrollIntoView, this.HeadingId);
        }

        protected async Task ContentOnMouseOver(MouseEventArgs e)
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Show, this.AnchorId);
        }

        protected async Task ContentOnMouseOut(MouseEventArgs e)
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Hide, this.AnchorId);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await this.JsInterop.InvokeVoidAsync(JsNames.Anchor.Init, this.Id, this.AnchorId);
            await base.OnAfterRenderAsync(firstRender);
        }

        protected override void OnParametersSet()
        {
            this.Id = $"{this.HeadingId}-content";
            this.AnchorId = $"{this.HeadingId}-anchor";

            base.OnParametersSet();
        }
    }
}
