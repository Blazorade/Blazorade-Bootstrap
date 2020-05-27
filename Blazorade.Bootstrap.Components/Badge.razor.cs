using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>Badge</c> component is used to add counts and labels to other components.
    /// </summary>
    public partial class Badge
    {

        /// <summary>
        /// Specifies whether the badge is a pill, i.e. with rounded corners.
        /// </summary>
        [Parameter]
        public bool IsPill { get; set; }

        /// <summary>
        /// Defines whether to open the link in a new tab.
        /// </summary>
        [Parameter]
        public bool OpenInNewTab { get; set; }

        /// <summary>
        /// The URL to use as link for the batch.
        /// </summary>
        [Parameter]
        public string Url { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Badges.Badge);
            if (this.IsPill) this.AddClasses(ClassNames.Badges.Pill);

            base.OnParametersSet();
        }

    }
}
