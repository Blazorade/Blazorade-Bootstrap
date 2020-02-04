using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardSubtitle
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Subtitle, ClassNames.InlineText.TextMuted);
            base.OnParametersSet();
        }

    }
}
