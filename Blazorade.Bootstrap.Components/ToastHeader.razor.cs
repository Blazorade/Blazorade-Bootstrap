using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the header on a <see cref="Toast"/> component.
    /// </summary>
    partial class ToastHeader
    {

        /// <summary>
        /// The header text.
        /// </summary>
        [Parameter]
        public string Header { get; set; }

        /// <summary>
        /// Specifies whether the containing <see cref="Toast"/> component should display a hide button that the toast can be hidden with.
        /// </summary>
        [Parameter]
        public bool ShowHideButton { get; set; }

        /// <summary>
        /// The text for the subheader.
        /// </summary>
        [Parameter]
        public string Subheader { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Toasts.Header);

            if(string.IsNullOrEmpty(this.Header) && string.IsNullOrEmpty(this.Subheader) && !this.ShowHideButton)
            {
                this.AddClasses(ClassNames.DisplayNone);
            }


            base.OnParametersSet();
        }
    }
}
