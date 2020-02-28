using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents an item in a <see cref="ListGroup"/> component.
    /// </summary>
    public partial class ListGroupItem
    {
        /// <summary>
        /// Indicates that the item is the current or active selection.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Makes an item appear as disabled.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }



        /// <summary>
        /// </summary>
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
