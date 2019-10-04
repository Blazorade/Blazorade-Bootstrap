using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    public abstract class BreadcrumbItemBase : BootstrapComponentBase
    {

        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public string Link { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Breadcrumbs.Item);

            if (this.IsActive) this.AddClass(ClassNames.Active);
            base.OnParametersSet();
        }

    }
}
