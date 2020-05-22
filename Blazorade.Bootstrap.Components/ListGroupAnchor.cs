using System;
using System.Collections.Generic;
using System.Text;
using Blazorade.Bootstrap.Components.Content;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents a link in a <see cref="ListGroup"/> component.
    /// </summary>
    public class ListGroupAnchor : Anchor
    {
        /// <summary>
        /// Setting a color for a ListGroupAnchor will apply a contextual color to the list group item.
        /// </summary>
        [Parameter]
        public NamedColor? Color { get; set; }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ListGroups.Item, ClassNames.ListGroups.Action);

            if (Color != null)
            {
                this.AddClasses(this.GetColorClassName(ClassNames.ListGroups.Item, Color));
            }

            base.OnParametersSet();
        }
    }
}
