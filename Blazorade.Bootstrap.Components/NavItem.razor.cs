using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// A navigation item used inside a <see cref="NavbarNav"/> component.
    /// </summary>
    public partial class NavItem
    {

        /// <summary>
        /// A collection of child items.
        /// </summary>
        [Parameter]
        public IEnumerable<IMenuItem> Children { get; set; }

        /// <summary>
        /// The description for the item.
        /// </summary>
        [Parameter]
        public string Description { get; set; }

        /// <summary>
        /// The zero-based index of the item.
        /// </summary>
        [Parameter]
        public int Index { get; set; }

        /// <summary>
        /// Specifies whether the item should be marked as active.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the item is disabled.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// </summary>
        [Parameter]
        public bool IsStretched { get; set; }

        /// <summary>
        /// The contents of the navigation item can be specified as a <see cref="IMenuItem"/> implementation generated from an external source.
        /// </summary>
        [Parameter]
        public IMenuItem Item { get; set; }

        /// <summary>
        /// Specifies whether the link should be opened in a new tab.
        /// </summary>
        [Parameter]
        public bool OpenInNewTab { get; set; }

        /// <summary>
        /// The URL of the item.
        /// </summary>
        [Parameter]
        public string Url { get; set; }

        /// <summary>
        /// The text to display in the item.
        /// </summary>
        [Parameter]
        public string Text { get; set; }



        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if(null == this.Item)
            {
                this.Item = new MenuItem();
                this.Item.Children = this.Children;
                this.Item.Description = this.Description;
                this.Item.Index = this.Index;
                this.Item.IsActive = this.IsActive;
                this.Item.IsDisabled = this.IsDisabled;
                this.Item.IsStretched = this.IsStretched;
                this.Item.OpenInNewTab = this.OpenInNewTab;
                this.Item.Text = this.Text;
                this.Item.Url = this.Url;
            }

            this.AddClasses(ClassNames.Navbars.NavItem);
            base.OnParametersSet();
        }

    }
}
