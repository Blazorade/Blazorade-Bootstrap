using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="ButtonToolbar"/> component combines sets of <see cref="ButtonGroup"/> components together into a toolbar.
    /// </summary>
    public partial class ButtonToolbar
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ButtonToolbars.Toolbar);

            base.OnParametersSet();
        }
    }
}
