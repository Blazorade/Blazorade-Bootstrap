using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Jumbotron
    {

        [Parameter]
        public string Heading { get; set; }

        [Parameter]
        public RenderFragment<string> HeadingTemplate { get; set; }

        [Parameter]
        public string Lead { get; set; }

        [Parameter]
        public RenderFragment<string> LeadTemplate { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Jumbotrons.Jumbotron);

            base.OnParametersSet();
        }
    }
}
