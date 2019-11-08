using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardSubtitleBase : BootstrapComponentBase
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Subtitle);
            this.AddClass(ClassNames.InlineText.TextMuted);
            base.OnParametersSet();
        }

    }
}
