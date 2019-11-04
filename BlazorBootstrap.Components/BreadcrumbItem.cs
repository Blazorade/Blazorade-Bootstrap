using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public class BreadcrumbItem
    {

        /// <summary>
        /// The description for the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The zero-based index for the item.
        /// </summary>
        /// <remarks>
        /// The <see cref="Breadcrumb"/> component handles this property when enumerating items specified in the <see cref="Breadcrumb.Items"/> property.
        /// </remarks>
        public int Index { get; set; }

        /// <summary>
        /// Specifies whether the item is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The link for the breadcrumb item.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// The text to display in the item.
        /// </summary>
        public string Text { get; set; }

    }
}
