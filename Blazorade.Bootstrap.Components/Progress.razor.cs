using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Wrapper component for ProgressBar components.
    /// Use one or more ProgressBar components inside of a Progress component to create a bootstrap progress bar.
    /// </summary>
    public partial class Progress
    {
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ProgressBars.Progress);

            base.OnParametersSet();
        }
    }
}
