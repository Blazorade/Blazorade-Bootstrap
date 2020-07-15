using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// A simple text addon for <see cref="InputGroup"/> components.
    /// </summary>
    /// <seealso cref="InputGroup"/>
    partial class InputGroupTextAddon
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.InputGroups.Text);
        }
    }
}
