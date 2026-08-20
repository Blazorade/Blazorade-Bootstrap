using Microsoft.AspNetCore.Components;
using System;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders the collapsible body for an <see cref="AccordionItem"/>.
    /// </summary>
    public partial class AccordionBody : BootstrapComponentBase
    {
        [CascadingParameter]
        private AccordionItem? CascadedItem { get; set; }

        internal AccordionItem Item => this.CascadedItem
            ?? throw new InvalidOperationException("AccordionBody must be used inside an AccordionItem.");
    }
}
