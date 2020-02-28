using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The ListGroup component is used to display a series of content in a powerful and flexible way.
    /// </summary>
    partial class ListGroup
    {
        /// <summary>
        /// Removes some borders and rounder corners to render list group items edge-to-edge in a parent container.
        /// </summary>
        [Parameter]
        public bool IsFlush { get; set; }

        /// <summary>
        /// Changes the layout of list group items from vertical to horizontal across all breakpoints.
        /// </summary>
        [Parameter]
        public bool IsHorizontal { get; set; }



        /// <summary>
        /// </summary>
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
