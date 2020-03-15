using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Nav component provides a simple way to build navigation elements.
    /// </summary>
    partial class Nav
    {

        /// <summary>
        /// Allows you to specify how the content of the Nav is aligned. The default is <c>null</c>, which results in left alignment.
        /// </summary>
        [Parameter]
        public ContentAlignment? ContentAlignment { get; set; }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if(this.ContentAlignment == Components.ContentAlignment.Center)
            {
                this.AddClasses(ClassNames.Navs.AlignContentCenter);
            }
            else if(this.ContentAlignment == Components.ContentAlignment.Right)
            {
                this.AddClasses(ClassNames.Navs.AlignContentRight);
            }

            this.AddClasses(ClassNames.Navs.Nav);
            base.OnParametersSet();
        }
    }
}
