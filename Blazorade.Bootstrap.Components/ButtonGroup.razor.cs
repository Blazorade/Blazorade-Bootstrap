using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ButtonGroup
    {

        [Parameter]
        public ButtonSize? Size { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ButtonGroups.Group);
            switch (this.Size.GetValueOrDefault())
            {
                case ButtonSize.Large:
                    this.AddClasses(ClassNames.ButtonGroups.Large);
                    break;

                case ButtonSize.Small:
                    this.AddClasses(ClassNames.ButtonGroups.Small);
                    break;
            }

            base.OnParametersSet();
        }
    }
}
