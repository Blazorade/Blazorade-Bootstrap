using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents a link in a <see cref="Card"/> component.
    /// </summary>
    public partial class CardLink
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Link);
            base.OnParametersSet();
        }
    }
}
