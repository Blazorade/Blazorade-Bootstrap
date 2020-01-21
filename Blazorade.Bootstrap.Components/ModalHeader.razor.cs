using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ModalHeader
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Modals.Header);

            base.OnParametersSet();
        }
    }
}
