using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the header on a <see cref="Modal"/> component.
    /// </summary>
    public partial class ModalHeader
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Modals.Header);

            base.OnParametersSet();
        }
    }
}
