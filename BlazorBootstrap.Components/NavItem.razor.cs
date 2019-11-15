using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class NavItemBase : BootstrapComponentBase
    {

        [Parameter]
        public IMenuItem Item { get; set; }

        [Parameter]
        public string ItemUrl { get; set; }

        [Parameter]
        public string ItemText { get; set; }


        protected override void OnParametersSet()
        {
            if(null == this.Item)
            {
                this.Item = new MenuItem();
            }
            this.Item.Url = this.Item.Url ?? this.ItemUrl;
            this.Item.Text = this.Item.Text ?? this.ItemText;

            this.AddClass(ClassNames.Navbars.NavItem);
            base.OnParametersSet();
        }

    }
}
