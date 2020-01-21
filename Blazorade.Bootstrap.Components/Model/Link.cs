using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Model
{

    /// <summary>
    /// Defines the interface to be implemented by link types.
    /// </summary>
    public interface ILink
    {
        /// <summary>
        /// The description of the link. This is typically used as tooltip for the link.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Some components use the index to number multiple links in a collection.
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// Specifies whether the link should be marked as active.
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the link is disabled. Disabled links must not be clickable.
        /// </summary>
        bool IsDisabled { get; set; }

        /// <summary>
        /// Specifies whether the link should be a stretched link.
        /// </summary>
        bool IsStretched { get; set; }

        /// <summary>
        /// Specifies whether the link should open in a new tab.
        /// </summary>
        bool OpenInNewTab { get; set; }

        /// <summary>
        /// The URL to add to the link.
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// The link text.
        /// </summary>
        string Text { get; set; }
    }

    /// <summary>
    /// Represents a basic link that is used by several components.
    /// </summary>
    public class Link : ILink
    {
        public string Description { get; set; }

        public int Index { get; set; }

        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public bool IsStretched { get; set; }

        public bool OpenInNewTab { get; set; }

        public string Url { get; set; }

        public string Text { get; set; }
    }
}
