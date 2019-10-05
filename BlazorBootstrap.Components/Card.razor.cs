using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardBase : BootstrapComponentBase
    {

        [Parameter]
        public ComponentColor? Background { get; set; }

        [Parameter]
        public ComponentColor? Border { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Card);
            this.AddClass(this.GetColorClassName(prefix: "bg", color: this.Background));
            this.AddClass(this.GetColorClassName(prefix: "border", color: this.Border));

            base.OnParametersSet();
        }


    }
}
