using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap.Components
{
    public abstract class CardTextBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Text);
            base.OnParametersSet();
        }
    }
}
