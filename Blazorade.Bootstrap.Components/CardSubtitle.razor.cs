using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the subtitle on a <see cref="Card"/> component.
    /// </summary>
    public partial class CardSubtitle
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Subtitle, ClassNames.InlineText.TextMuted);
            base.OnParametersSet();
        }

    }
}
