using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazorade.Bootstrap.Components.Model;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// The <c>Breadcrumb</c> component visualizes the current page in a navigational hierarchy.
    /// </summary>
    /// <example>
    /// <para>
    /// This example shows how you use the <c>Breadcrumb</c> component with a collection of links. You can build up
    /// the collection in your component's logic, and then just attach it to the <c>Breadcrumb</c> component.
    /// </para>
    /// <code>
    /// <![CDATA[
    /// @code {
    ///     List<ILink> items = new List<ILink>()
    ///     {
    ///         new Link() { Url = "/", Text = "Home", Description = "The front page of the site" },
    ///         new Link() { Url = "/section1", Text = "Section 1" },
    ///         new Link() { Url = "/section1/subsection1", Text = "Section 1.1" },
    ///         new Link() { Text = "This page", IsActive = true, Description = "This is your current page. You are here now." }
    ///     };
    /// }
    /// 
    /// <Breadcrumb Items="@items" />
    /// ]]>
    /// </code>
    /// <para>
    /// <see cref="BreadcrumbItem"/> for samples on how to build a <c>Breadcrumb</c> component declaratively.
    /// </para>
    /// </example>
    /// <seealso cref="BreadcrumbItem"/>
    public partial class Breadcrumb
    {

        /// <summary>
        /// The template to use to display each link with. If not specified, a default template is used.
        /// </summary>
        /// <remarks>
        /// This template is used only when the items in the <see cref="Breadcrumb"/> are added to the <see cref="Items"/> collection.
        /// If you use <see cref="BreadcrumbItem"/> components as child content to the <see cref="Breadcrumb"/>, this template
        /// is ignored.
        /// </remarks>
        /// <example>
        /// <para>
        /// The example below shows you how you can customize the rendering of items.
        /// </para>
        /// <code>
        /// <![CDATA[
        /// <Breadcrumb Items="@...">
        ///     <ItemTemplate>
        ///         @if (!string.IsNullOrEmpty(context.Url))
        ///         {
        ///             <Button Color = "NamedColor.Light" Shadow="Shadow.Regular">@context.Text</Button>
        ///         }
        ///         else
        ///         {
        ///             <Span>@context.Text(@context.Description)</Span>
        ///         }
        ///     </ItemTemplate>
        /// </Breadcrumb>
        /// ]]>
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment<ILink> ItemTemplate { get; set; }

        /// <summary>
        /// A collection of the items to show in the Breadcrumb component.
        /// </summary>
        [Parameter]
        public IReadOnlyList<ILink> Items { get; set; }



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
