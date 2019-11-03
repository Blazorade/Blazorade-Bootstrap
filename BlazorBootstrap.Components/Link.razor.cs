using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class LinkBase : BootstrapComponentBase
    {

        /// <summary>
        /// Defines whether the links is a stretched link.
        /// </summary>
        [Parameter]
        public bool IsStretched { get; set; }


        protected override void OnParametersSet()
        {
            if (this.IsStretched)
            {
                this.AddClass(ClassNames.Links.Stretched);
            }

            base.OnParametersSet();
        }
    }
}
