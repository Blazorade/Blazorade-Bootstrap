using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardFooter
    {
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Footer);
            base.OnParametersSet();
        }
    }
}
