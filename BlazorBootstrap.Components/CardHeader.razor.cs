using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardHeaderBase : BootstrapComponentBase
    {

        [Parameter]
        public HeadingLevel? Level { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Header);
            base.OnParametersSet();
        }
    }
}
