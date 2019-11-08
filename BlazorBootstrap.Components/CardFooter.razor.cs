using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardFooterBase : BootstrapComponentBase
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Footer);
            base.OnParametersSet();
        }
    }
}
