using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardText
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Text);
            base.OnParametersSet();
        }
    }
}
