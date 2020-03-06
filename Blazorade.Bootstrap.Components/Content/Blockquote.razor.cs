using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
    public partial class Blockquote
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.BlockQuotes.Blockquote);
            base.OnParametersSet();
        }
    }
}
