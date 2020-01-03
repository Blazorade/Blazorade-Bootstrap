using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorBootstrap.Components
{
    public partial class Anchor
    {

        public Anchor()
        {
            this.IgnoreEmptyUrl = true;
        }

        /// <summary>
        /// Callback for when the anchor is clicked.
        /// </summary>
        [Parameter]
        public EventCallback<Anchor> Clicked { get; set; }



        /// <summary>
        /// The description of the link. This is typically used as tooltip for the link.
        /// </summary>
        [Parameter]
        public string Description { get; set; }

        /// <summary>
        /// Specifies that an empty or <c>null</c> value on <see cref="Url"/> is ignored, and the <c>href</c> attribute is always rendered regardless.
        /// </summary>
        [Parameter]
        public bool IgnoreEmptyUrl { get; set; }

        /// <summary>
        /// Some components use the index to number multiple links in a collection.
        /// </summary>
        [Parameter]
        public int Index { get; set; }

        /// <summary>
        /// Specifies whether the link should be marked as active.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the link is disabled. Disabled links must not be clickable.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Defines whether the links is a stretched link.
        /// </summary>
        [Parameter]
        public bool IsStretched { get; set; }

        /// <summary>
        /// Specifies whether the link should open in a new tab.
        /// </summary>
        [Parameter]
        public bool OpenInNewTab { get; set; }

        /// <summary>
        /// The URL to add to the link.
        /// </summary>
        [Parameter]
        public string Url { get; set; }

        /// <summary>
        /// The link text.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// Allows you to set the parameters of the Anchor by specifying an <see cref="ILink"/> object on this parameter.
        /// </summary>
        [Parameter]
        public ILink Link { get; set; }



        [Inject]
        protected IJSRuntime JsInterop { get; set; }


        protected bool IsAnchorLink { get; private set; }

        protected bool OnClickPreventDefault { get; private set; }

        protected string TargetId { get; private set; }


        /// <summary>
        /// Fires the <see cref="Clicked"/> event.
        /// </summary>
        /// <returns></returns>
        protected virtual async Task OnClickedAsync()
        {
            if(this.IsAnchorLink && !string.IsNullOrEmpty(this.TargetId))
            {
                await this.JsInterop.InvokeVoidAsync(JsFunctions.Anchor.ScrollIntoView, this.TargetId);
            }

            await this.Clicked.InvokeAsync(this);
        }

        protected override void OnParametersSet()
        {
            if(null != this.Link)
            {
                this.Description = this.Link.Description;
                this.Index = this.Link.Index;
                this.IsActive = this.Link.IsActive;
                this.IsDisabled = this.Link.IsDisabled;
                this.IsStretched = this.Link.IsStretched;
                this.OpenInNewTab = this.Link.OpenInNewTab;
                this.Text = this.Link.Text;
                this.Url = this.Link.Url;
            }

            if (!string.IsNullOrEmpty(this.Description))
            {
                this.AddAttribute("title", this.Description);
            }
            if (this.IsActive)
            {
                this.AddClass(ClassNames.Active);
            }
            if(this.IsDisabled)
            {
                this.AddAttribute("disabled", "disabled");
                this.AddClass(ClassNames.Disabled);
            }
            if (this.IsStretched)
            {
                this.AddClass(ClassNames.Links.Stretched);
            }
            if(this.OpenInNewTab)
            {
                this.AddAttribute("target", "_blank");
            }
            if(!string.IsNullOrEmpty(this.Url) || this.IgnoreEmptyUrl)
            {
                this.AddAttribute("href", $"{this.Url ?? "javascript:"}");
            }
            if(null != this?.Url && this.Url.StartsWith("#"))
            {
                this.IsAnchorLink = true;
                this.OnClickPreventDefault = true;
                this.TargetId = this.Url.Substring(1);
            }

            if (this.IsAnchorLink)
            {
                this.SetIdIfEmpty();
            }

            base.OnParametersSet();

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Anchor.Init, this.Id);
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
