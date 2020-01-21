using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ModalFooter
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Modals.Footer);
            base.OnParametersSet();
        }
    }
}
