using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardHeader
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Header);
            base.OnParametersSet();
        }
    }
}
