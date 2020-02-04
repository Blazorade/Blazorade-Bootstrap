using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class ListGroup
    {

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ListGroups.ListGroup);

            this.AddAttribute("role", "list");
            base.OnParametersSet();
        }
    }
}
