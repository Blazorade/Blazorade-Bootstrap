using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class BreadcrumbItemBase : BootstrapBase
    {

        protected BreadcrumbItemBase()
        {
            this.AddClass(ClassNames.Breadcrumbs.Item);
        }

        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public string Link { get; set; }


        protected override void OnParametersSet()
        {
            if (this.IsActive) this.AddClass(ClassNames.Active);
            base.OnParametersSet();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.RemoveClass(ClassNames.Active);
            return base.SetParametersAsync(parameters);
        }

    }
}
