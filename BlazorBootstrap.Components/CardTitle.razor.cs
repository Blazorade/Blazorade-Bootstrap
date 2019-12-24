using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
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
