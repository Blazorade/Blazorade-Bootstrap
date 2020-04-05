using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
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
