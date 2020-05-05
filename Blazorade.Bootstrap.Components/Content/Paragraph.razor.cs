using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
    /// <summary>
    /// The <see cref="Paragraph"/> component produces a standard <c>&lt;p /&gt;</c> HTML element.
    /// </summary>
    partial class Paragraph
    {

        /// <summary>
        /// Specifies whether the paragraph is a lead paragraph.
        /// </summary>
        [Parameter]
        public bool IsLead { get; set; }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if (this.IsLead)
            {
                this.AddClasses(ClassNames.Paragraphs.Lead);
            }
            base.OnParametersSet();
        }
    }
}
