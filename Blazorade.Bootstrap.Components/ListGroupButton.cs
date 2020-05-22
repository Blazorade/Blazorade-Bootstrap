using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents a button in a <see cref="ListGroup"/> component.
    /// </summary>
    public class ListGroupButton : Button
    {
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.ListGroups.Item, ClassNames.ListGroups.Action);

            // replace the button coloration with the list item coloration
            this.RemoveClass(this.GetColorClassName(prefix: !this.IsOutline ? ClassNames.Buttons.Button : ClassNames.Buttons.OutlineButton, color: this.Color));
            this.AddClasses(this.GetColorClassName(prefix: ClassNames.ListGroups.Item, this.Color));
        }
    }
}
