using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap.Components
{
    public abstract class BreadcrumbBase : BootstrapComponentBase
    {

        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.AddClass(ClassNames.Breadcrumbs.Breadcrumb);
            return base.SetParametersAsync(parameters);
        }
    }
}
