using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardBase : BootstrapComponentBase
    {


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Card);

            base.OnParametersSet();
        }


    }
}
