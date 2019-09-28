using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class HeadingBase : BootstrapBase
    {
        protected HeadingBase()
        {
            this.Size = HeadingSize.H1;
        }

        [Parameter]
        public HeadingDisplay? Display { get; set; }

        [Parameter]
        public HeadingSize Size { get; set; }


        protected override void OnParametersSet()
        {
            var displayClassName = this.GetDisplayClassName();
            if (!string.IsNullOrEmpty(displayClassName))
            {
                this.AddClass(displayClassName);
            }
            this.AddClass(this.Size.ToString().ToLower());
            base.OnParametersSet();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.RemoveClass(this.Size.ToString().ToLower());
            this.RemoveClass(this.GetDisplayClassName());

            return base.SetParametersAsync(parameters);
        }


        private string GetDisplayClassName()
        {
            if (this.Display.HasValue)
            {
                return $"display-{((int)this.Display)}";
            }

            return null;
        }
    }
}
