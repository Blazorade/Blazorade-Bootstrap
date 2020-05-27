using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components.Content
{
    /// <summary>
    /// Represents the content in a <see cref="Heading"/> component.
    /// </summary>
    /// <remarks>
    /// Not intended to be used directly from your code.
    /// </remarks>
    public partial class HeadingContent
    {

        /// <summary>
        /// The ID of the <see cref="Anchor"/> element that is shown when hovering over the content.
        /// </summary>
        [Parameter]
        public string AnchorId { get; set; }

        /// <summary>
        /// The element ID of the parent <see cref="Heading"/> component.
        /// </summary>
        [Parameter]
        public string HeadingId { get; set; }

        /// <summary>
        /// Specifies whether the heading is an automatic anchor.
        /// </summary>
        [Parameter]
        public bool IsAnchor { get; set; }


        /// <summary>
        /// </summary>
        protected async Task ContentOnMouseOver(MouseEventArgs e)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Show, this.AnchorId);
        }

        /// <summary>
        /// </summary>
        protected async Task ContentOnMouseOut(MouseEventArgs e)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Hide, this.AnchorId);
        }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.Id = $"{this.HeadingId}-content";
            this.AnchorId = $"{this.HeadingId}-anchor";

            base.OnParametersSet();
        }
    }
}
