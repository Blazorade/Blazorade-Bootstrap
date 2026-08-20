using Microsoft.AspNetCore.Components;
using System;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders the heading and toggle button for an <see cref="AccordionItem"/>.
    /// </summary>
    public partial class AccordionHeader : BootstrapComponentBase
    {
        [CascadingParameter]
        private AccordionItem? CascadedItem { get; set; }

        internal AccordionItem Item => this.CascadedItem
            ?? throw new InvalidOperationException("AccordionHeader must be used inside an AccordionItem.");
    }
}
