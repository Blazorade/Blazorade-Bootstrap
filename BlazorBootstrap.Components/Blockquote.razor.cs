using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class Blockquote
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.BlockQuotes.Blockquote);
            base.OnParametersSet();
        }
    }
}
