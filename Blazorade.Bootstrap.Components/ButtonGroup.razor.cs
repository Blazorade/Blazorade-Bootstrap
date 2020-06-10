using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>ButtonGroup</c> component is used to group <see cref="Button"/> components together. Buttons in the same group are joined together.
    /// </summary>
    public partial class ButtonGroup
    {

        /// <summary>
        /// Specifies the default size for buttons in the group.
        /// </summary>
        [Parameter]
        public ButtonSize? Size { get; set; }



        /// <summary>
        /// </summary>
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
