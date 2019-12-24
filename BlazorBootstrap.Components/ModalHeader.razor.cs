using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
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
