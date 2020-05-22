using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the footer on a <see cref="Modal"/> component.
    /// </summary>
    public partial class ModalFooter
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Modals.Footer);
            base.OnParametersSet();
        }
    }
}
