using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>InputGroup</c> allows you to easily extend form controls by adding text, buttons, or button groups on either side of textual inputs, custom selects, and custom file inputs.
    /// </summary>
    partial class InputGroup
    {

        /// <summary>
        /// The size of the input group.
        /// </summary>
        [Parameter]
        public InputGroupSize Size { get; set; }

    }
}
