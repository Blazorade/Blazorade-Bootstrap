using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardSubtitle
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Subtitle);
            this.AddClass(ClassNames.InlineText.TextMuted);
            base.OnParametersSet();
        }

    }
}
