using System;
using System.Collections.Generic;
using System.Text;
using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Pagination component allows you to supply a set of links and display a bootstrap pagination bar on the screen.
    /// </summary>
    public partial class Pagination
    {

        /// <summary>
        /// Set the size of the pagination component. Defaults to "Normal"
        /// </summary>
        [Parameter]
        public PaginationSize Size { get; set; } = PaginationSize.Normal;

        /// <summary>
        /// Create your own template using the <see cref="ILink"/> interface.
        /// </summary>
        [Parameter]
        public RenderFragment<ILink> ItemTemplate { get; set; }

        /// <summary>
        /// A list of <see cref="ILink"/> objects to use as page links.
        /// These MUST have the Url field populated to show up in the pagination!
        /// </summary>
        [Parameter]
        public IReadOnlyList<ILink> Items { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Paginations.Pagination);

            if(this.Size == PaginationSize.Large)
            {
                this.AddClasses(ClassNames.Paginations.Large);
            }

            if (this.Size == PaginationSize.Small)
            {
                this.AddClasses(ClassNames.Paginations.Small);
            }

            base.OnParametersSet();
        }

        
    }

    public enum PaginationSize
    {
        Normal,
        Large,
        Small
    }
}
