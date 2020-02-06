using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class Progress
    {
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ProgressBars.Progress);

            base.OnParametersSet();
        }
    }
}
