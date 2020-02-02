using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class ToastBody
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Toasts.Body);

            base.OnParametersSet();
        }
    }
}
