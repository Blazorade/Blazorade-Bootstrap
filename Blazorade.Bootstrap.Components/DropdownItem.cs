using Blazorade.Bootstrap.Components.Content;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <see cref="DropdownItem"/> component is used inside a <see cref="DropdownMenu"/> component to display a link or other element.
    /// </summary>
    public partial class DropdownItem : Anchor
    {

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Dropdowns.Item);
            base.OnParametersSet();
        }
    }
}
