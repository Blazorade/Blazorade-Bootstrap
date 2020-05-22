using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the header on a <see cref="Card"/> component.
    /// </summary>
    public partial class CardHeader
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Header);
            base.OnParametersSet();
        }
    }
}
