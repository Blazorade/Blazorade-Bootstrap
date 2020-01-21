using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class ToastHeader
    {

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public bool ShowHideButton { get; set; }

        [Parameter]
        public string Subheader { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Toasts.Header);

            if(string.IsNullOrEmpty(this.Header) && string.IsNullOrEmpty(this.Subheader) && !this.ShowHideButton)
            {
                this.AddClass(ClassNames.DisplayNone);
            }


            base.OnParametersSet();
        }
    }
}
