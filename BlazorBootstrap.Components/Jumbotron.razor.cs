using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
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
            this.AddClass(ClassNames.Jumbotrons.Jumbotron);

            base.OnParametersSet();
        }
    }
}
