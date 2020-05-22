using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the title on a <see cref="Card"/> component.
    /// </summary>
    public partial class CardTitle
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Title);
            base.OnParametersSet();
        }
    }
}
