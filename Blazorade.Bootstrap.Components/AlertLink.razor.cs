using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// This component can be used inside of Alert components to provide link colors matching with the parent Alert component.
    /// </summary>
    /// <remarks>
    /// For details see https://github.com/Blazorade/Blazorade-Bootstrap/wiki/AlertLink
    /// </remarks>
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
