using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazorade.Bootstrap.Components.Model;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// The Breadcrumb component visualizes the current page in a navigational hierarchy.
    /// </summary>
    public partial class Breadcrumb
    {

        /// <summary>
        /// The template to use to display each link with. If not specified, a default template is used.
        /// </summary>
        [Parameter]
        public RenderFragment<ILink> ItemTemplate { get; set; }

        /// <summary>
        /// A collection of the items to show in the Breadcrumb component.
        /// </summary>
        [Parameter]
        public IReadOnlyList<ILink> Items { get; set; }

        /// <summary>
        /// </summary>
        public override RenderFragment ChildContent {
            get => base.ChildContent;
            set => throw new NotSupportedException($"The '{this.GetType().Name}' component does not support child content with the '{nameof(this.ChildContent)}' property.");
        }


        private IDictionary<string, object> ListAttributes = new Dictionary<string, object>();
        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {

            this.AddAttribute("aria-label", ClassNames.Breadcrumbs.Breadcrumb);

            base.OnParametersSet();


            var classes = new List<string>
            {
                ClassNames.Breadcrumbs.Breadcrumb
            };
            var bgClass = this.GetColorClassName("bg", this.BackgroundColor);
            if (!string.IsNullOrEmpty(bgClass)) classes.Add(bgClass);

            var textClass = this.GetColorClassName("text", this.TextColor);
            if (!string.IsNullOrEmpty(textClass)) classes.Add(textClass);

            this.ListAttributes["class"] = string.Join(" ", classes);
        }
    }
}
