using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class ToastBody
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Toasts.Body);

            base.OnParametersSet();
        }
    }
}
