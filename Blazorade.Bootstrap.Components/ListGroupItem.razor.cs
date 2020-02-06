using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ListGroupItem
    {
        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ListGroups.Item);

            if(this.IsActive)
            {
                this.AddClasses(ClassNames.Active);
            }

            if(this.IsDisabled)
            {
                this.AddClasses(ClassNames.Disabled);
            }

            if(Color != null)
            {
                this.AddClasses(this.GetColorClassName(prefix: ClassNames.ListGroups.Item, this.Color));
            }

            base.OnParametersSet();
        }
    }
}
