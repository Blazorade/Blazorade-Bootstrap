using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap.Components
{
    public abstract class CardTextBase : BootstrapComponentBase
    {

        public override RenderFragment ChildContent
        {
            get { return base.ChildContent; }
            set { throw new NotSupportedException("Setting the ChildContent parameter on this component is not supported."); }
        }

        [Parameter]
        public string Text { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Text);
            base.OnParametersSet();
        }
    }
}
