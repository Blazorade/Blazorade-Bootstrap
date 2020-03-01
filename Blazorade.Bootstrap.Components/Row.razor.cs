using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Row
    {

        /// <summary>
        /// If set to <c>true</c>, all columns in the current row will be rendered without gutters (i.e. space between columns).
        /// </summary>
        [Parameter]
        public bool NoGutters { get; set; }


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
