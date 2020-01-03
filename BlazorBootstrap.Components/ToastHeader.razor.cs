using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class ToastHeader
    {

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public bool ShowHide { get; set; }

        [Parameter]
        public string Subheader { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Toasts.Header);

            if(string.IsNullOrEmpty(this.Header) && string.IsNullOrEmpty(this.Subheader) && !this.ShowHide)
            {
                this.AddClass(ClassNames.DisplayNone);
            }


            base.OnParametersSet();
        }
    }
}
