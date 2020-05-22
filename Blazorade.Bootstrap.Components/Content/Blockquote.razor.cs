using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
    /// <summary>
    /// The <see cref="Blockquote"/> component represents a standard <c>HTML</c> <c>BLOCKQUOTE</c> element.
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
