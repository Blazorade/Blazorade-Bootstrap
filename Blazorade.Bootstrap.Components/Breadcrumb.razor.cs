using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazorade.Bootstrap.Components.Model;

namespace Blazorade.Bootstrap.Components
{
    public partial class Breadcrumb
    {

        [Parameter]
        public RenderFragment<ILink> ItemTemplate { get; set; }

        [Parameter]
        public IReadOnlyList<ILink> Items { get; set; }

        public override RenderFragment ChildContent {
            get => base.ChildContent;
            set => throw new NotSupportedException($"The '{this.GetType().Name}' component does not support child content with the '{nameof(this.ChildContent)}' property.");
        }


        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.AddAttribute("aria-label", ClassNames.Breadcrumbs.Breadcrumb);

            return base.SetParametersAsync(parameters);
        }
    }
}
