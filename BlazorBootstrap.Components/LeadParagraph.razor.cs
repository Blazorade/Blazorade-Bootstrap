using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class LeadParagraphBase : BootstrapBase
    {
        protected LeadParagraphBase()
        {
            this.AddClass(ClassNames.Paragraphs.Lead);
        }
    }
}
