using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Content
{
    /// <summary>
    /// Represents the heading elements <c>H1</c>, <c>H2</c>, <c>H3</c>, <c>H4</c>, <c>H5</c> and <c>H6</c>.
    /// </summary>
    public partial class Heading
    {

        /// <summary>
        /// </summary>
        public Heading()
        {
            this.Level = HeadingLevel.H1;
        }


        /// <summary>
        /// Use this property to specify a different display size for your heading to better visually fit into the overall look and feel.
        /// </summary>
        [Parameter]
        public HeadingDisplay? Display { get; set; }

        /// <summary>
        /// Specifies that the heading is also an anchor that you can link to. This requires that the <c>Id</c> property is also set on the
        /// heading. An anchor heading will display a link icon when hovered over to indicate that the heading is an anchor.
        /// </summary>
        [Parameter]
        public bool IsAnchor { get; set; }

        /// <summary>
        /// The heading level.
        /// </summary>
        [Parameter]
        public HeadingLevel Level { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            if (this.Display.HasValue)
            {
                this.AddClasses($"display-{(int)this.Display.Value.Value}");
            }


            base.OnParametersSet();
        }
    }
}
