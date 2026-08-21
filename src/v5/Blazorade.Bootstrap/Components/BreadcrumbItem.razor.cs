using Microsoft.AspNetCore.Components;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents one item in a <see cref="Breadcrumb"/> component.
    /// </summary>
    public partial class BreadcrumbItem : BootstrapComponentBase
    {
        /// <summary>
        /// The description of the item, rendered as a tooltip for non-linked items.
        /// </summary>
        [Parameter]
        public string? Description { get; set; }

        /// <summary>
        /// Specifies whether the item represents the current page.
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// Specifies whether the link opens in a new browser tab.
        /// </summary>
        [Parameter]
        public bool OpenInNewTab { get; set; }

        /// <summary>
        /// The URL of the item. An item without a URL is rendered as text.
        /// </summary>
        [Parameter]
        public string? Url { get; set; }

        /// <summary>
        /// The text of the item when no child content is supplied.
        /// </summary>
        [Parameter]
        public string? Text { get; set; }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            this.AddClasses("breadcrumb-item");

            if (this.IsActive)
            {
                this.AddClasses("active");
                this.Attributes["aria-current"] = "page";
            }
            else
            {
                this.Attributes.Remove("aria-current");
            }

            base.OnParametersSet();
        }
    }
}
