using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class ButtonGroup
    {

        [Parameter]
        public ButtonSize? Size { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.ButtonGroups.Group);
            switch (this.Size.GetValueOrDefault())
            {
                case ButtonSize.Large:
                    this.AddClass(ClassNames.ButtonGroups.Large);
                    break;

                case ButtonSize.Small:
                    this.AddClass(ClassNames.ButtonGroups.Small);
                    break;
            }

            base.OnParametersSet();
        }
    }
}
