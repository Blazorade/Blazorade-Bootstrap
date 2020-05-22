using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the body of a <see cref="Modal"/> component.
    /// </summary>
    public partial class ModalBody
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Modals.Body);
            base.OnParametersSet();
        }
    }
}
