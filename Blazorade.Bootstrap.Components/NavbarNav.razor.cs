using System;
using System.Collections.Generic;
using System.Text;
using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Groups navigation items inside of a <see cref="Navbar"/> component. Use margins to align.
    /// </summary>
    public partial class NavbarNav
    {

        /// <summary>
        /// The items to show in the component.
        /// </summary>
        [Parameter]
        public IEnumerable<MenuItem> Items { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Navbars.Nav);
            base.OnParametersSet();
        }

    }
}
