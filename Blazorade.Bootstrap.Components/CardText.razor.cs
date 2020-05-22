using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the text on a <see cref="Card"/> component.
    /// </summary>
    public partial class CardText
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Cards.Text);
            base.OnParametersSet();
        }
    }
}
