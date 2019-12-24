using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class CardFooter
    {
        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Footer);
            base.OnParametersSet();
        }
    }
}
