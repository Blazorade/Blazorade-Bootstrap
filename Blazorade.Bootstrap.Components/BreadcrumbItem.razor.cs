using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Blazorade.Bootstrap.Components
{

    /// <summary>
    /// Represents one item in a <see cref="Breadcrumb"/> component.
    /// </summary>
    /// <example>
    /// <para>
    /// The following example shows how you use the <c>BreadcrumbItem</c> component.
    /// </para>
    /// <code>
    /// <![CDATA[
    /// <Breadcrumb>
    ///     <BreadcrumbItem Url="/">Home</BreadcrumbItem>
    ///     <BreadcrumbItem Url="/page1">Page 1</BreadcrumbItem>
    ///     <BreadcrumbItem IsActive="true">Current Page</BreadcrumbItem>
    /// </Breadcrumb>
    /// ]]>
    /// </code>
    /// </example>
    /// <seealso cref="Breadcrumb"/>
    partial class BreadcrumbItem : ILink
    {

        /// <inheritdoc/>
        [Parameter]
        public string Description { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public int Index { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public bool IsActive { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public bool IsStretched { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public bool OpenInNewTab { get; set; }

        /// <inheritdoc/>
        /// <remarks>
        /// If this property is empty or <c>null</c>, the <see cref="BreadcrumbItem"/> will be rendered
        /// without a link using the <see cref="Content.Span"/> component.
        /// </remarks>
        [Parameter]
        public string Url { get; set; }

        /// <inheritdoc/>
        [Parameter]
        public string Text { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.AddClasses(ClassNames.Breadcrumbs.Item);
            if (this.IsActive)
            {
                this.AddClasses(ClassNames.Active);
            }
        }
    }
}
