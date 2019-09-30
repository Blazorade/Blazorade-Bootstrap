using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class BadgeBase : BootstrapStyledBase
    {

        [Parameter]
        public bool IsPill { get; set; }

        [Parameter]
        public string Link { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Badges.Badge);
            if (this.IsPill) this.AddClass(ClassNames.Badges.Pill);
            if (!string.IsNullOrEmpty(this.Link)) this.AddAttribute("href", this.Link);
            base.OnParametersSet();
        }

    }
}
