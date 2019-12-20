using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavItemBase : BootstrapComponentBase, IMenuItem
    {

        [Parameter]
        public IEnumerable<IMenuItem> Children { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public int Index { get; set; }

        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        [Parameter]
        public bool IsStretched { get; set; }

        [Parameter]
        public IMenuItem Item { get; set; }

        [Parameter]
        public bool OpenInNewTab { get; set; }

        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public string Text { get; set; }



        protected override void OnParametersSet()
        {
            if(null == this.Item)
            {
                this.Item = new MenuItem();
                this.Item.Children = this.Children;
                this.Item.Description = this.Description;
                this.Item.Index = this.Index;
                this.Item.IsActive = this.IsActive;
                this.Item.IsDisabled = this.IsDisabled;
                this.Item.IsStretched = this.IsStretched;
                this.Item.OpenInNewTab = this.OpenInNewTab;
                this.Item.Text = this.Text;
                this.Item.Url = this.Url;
            }

            this.AddClass(ClassNames.Navbars.NavItem);
            base.OnParametersSet();
        }

    }
}
