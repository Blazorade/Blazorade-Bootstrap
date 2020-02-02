using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The base class for the <see cref="Badge"/> component.
    /// </summary>
    /// <remarks>
    /// For details see <see cref="https://github.com/MikaBerglund/Blazor-Bootstrap/wiki/Badge"/>
    /// </remarks>
    public partial class Badge
    {

        /// <summary>
        /// Specifies whether the badge is a pill, i.e. with rounded corners.
        /// </summary>
        [Parameter]
        public bool IsPill { get; set; }

        /// <summary>
        /// Make the badge into a link by specifying a relative or absolute URL.
        /// </summary>
        [Parameter]
        public string Link { get; set; }

        /// <summary>
        /// Defines whether to open the link in a new tab.
        /// </summary>
        [Parameter]
        public bool OpenLinkInNewTab { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Badges.Badge);
            if (this.IsPill) this.AddClasses(ClassNames.Badges.Pill);
            if (!string.IsNullOrEmpty(this.Link)) this.AddAttribute("href", this.Link);
            if (this.OpenLinkInNewTab) this.AddAttribute("target", "_blank");
            base.OnParametersSet();
        }

    }
}
