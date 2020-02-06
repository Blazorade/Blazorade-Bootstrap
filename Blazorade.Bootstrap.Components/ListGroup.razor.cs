using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    partial class ListGroup
    {
        [Parameter]
        public bool IsFlush { get; set; }

        [Parameter]
        public bool IsHorizontal { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ListGroups.ListGroup);

            if(this.IsFlush)
            {
                this.AddClasses(ClassNames.ListGroups.Flush);
            }

            if(this.IsHorizontal)
            {
                this.AddClasses(ClassNames.ListGroups.Horizontal);
            }

            this.AddAttribute("role", "list");
            base.OnParametersSet();
        }
    }
}
