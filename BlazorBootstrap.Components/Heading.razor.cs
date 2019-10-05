using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class HeadingBase : BootstrapComponentBase
    {

        protected HeadingBase()
        {
            this.Level = HeadingLevel.H1;
        }


        public HeadingDisplay? Display { get; set; }

        [Parameter]
        public HeadingLevel Level { get; set; }


        protected override void OnParametersSet()
        {
            if (this.Display.HasValue)
            {
                this.AddClass($"display-{(int)this.Display}");
            }


            base.OnParametersSet();
        }
    }
}
