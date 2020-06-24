using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Layout
{
    /// <summary>
    /// Represents a row in a grid.
    /// </summary>
    /// <example>
    /// For examples, see <see cref="Container"/>.
    /// </example>
    /// <seealso cref="Container"/>
    /// <seealso cref="Column"/>
    partial class Row
    {

        /// <summary>
        /// If set to <c>true</c>, all columns in the current row will be rendered without gutters (i.e. space between columns).
        /// </summary>
        [Parameter]
        public bool NoGutters { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.Rows.Row);

            if (this.NoGutters)
            {
                this.AddClasses(ClassNames.Rows.NoGutters);
            }
        }
    }
}
