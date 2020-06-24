using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blazorade.Bootstrap.Components.Layout
{
    /// <summary>
    /// Represents a column in a grid.
    /// </summary>
    /// <example>
    /// For examples, see <see cref="Container"/>.
    /// </example>
    /// <seealso cref="Container"/>
    /// <seealso cref="Row"/>
    partial class Column
    {
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            var colClasses = from x in this.Classes where x == ClassNames.Cols.Col || x?.StartsWith($"{ClassNames.Cols.Col}-") == true select x;
            if(colClasses.Count() == 0)
            {
                this.AddClasses(ClassNames.Cols.Col);
            }
        }
    }
}
