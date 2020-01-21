using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardTitle
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Title);
            base.OnParametersSet();
        }
    }
}
