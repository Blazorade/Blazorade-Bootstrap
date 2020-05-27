using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// This component can be used inside of <see cref="Alert"/> components to provide link colors matching with the parent <see cref="Alert"/> component.
    /// </summary>
    public partial class AlertLink
    {
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Alerts.AlertLink);

            base.OnParametersSet();
        }
    }
}
