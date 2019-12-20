using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using BlazorBootstrap.Components.Model;

namespace BlazorBootstrap.Components
{
    public abstract class AnchorBase : BootstrapComponentBase , ILink
    {

        protected AnchorBase()
        {
            this.IgnoreEmptyUrl = true;
        }

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


        [Parameter]
        public ILink Link { get; set; }



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


            base.OnParametersSet();
        }
    }
}
