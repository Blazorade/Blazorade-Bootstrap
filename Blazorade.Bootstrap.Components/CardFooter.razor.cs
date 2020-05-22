using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the footer in a <see cref="Card"/> component.
    /// </summary>
    public partial class CardFooter
    {
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Footer);
            base.OnParametersSet();
        }
    }
}
