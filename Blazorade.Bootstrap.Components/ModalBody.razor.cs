using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ModalBody
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Modals.Body);
            base.OnParametersSet();
        }
    }
}
