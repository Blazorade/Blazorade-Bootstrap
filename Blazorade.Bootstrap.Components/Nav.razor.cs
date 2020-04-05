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
        public HorizontalAlignment? ContentAlignment { get; set; }

        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if(this.ContentAlignment == HorizontalAlignment.Center)
            {
                this.AddClasses(ClassNames.Navs.AlignContentCenter);
            }
            else if(this.ContentAlignment == HorizontalAlignment.Right)
            {
                this.AddClasses(ClassNames.Navs.AlignContentRight);
            }

            this.AddClasses(ClassNames.Navs.Nav);
            base.OnParametersSet();
        }
    }
}
