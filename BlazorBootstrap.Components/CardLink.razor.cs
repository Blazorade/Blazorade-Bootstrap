using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class CardLink
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Link);
            base.OnParametersSet();
        }
    }
}
