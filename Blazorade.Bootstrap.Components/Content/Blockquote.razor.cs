using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
    /// <summary>
    /// The <c>Blockquote</c> component represents a standard <c>blockquote</c> element in <c>HTML</c>.
    /// </summary>
    public partial class Blockquote
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.BlockQuotes.Blockquote);
            base.OnParametersSet();
        }
    }
}
