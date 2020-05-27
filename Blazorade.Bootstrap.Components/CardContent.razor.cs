using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The <c>CardContent</c> represents all content in a <see cref="Card"/> component, except for
    /// the <see cref="Card.Header"/> and <see cref="Card.Footer"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Normally, you should not need to use this component in your code. Instead, use the <see cref="Card"/> component.
    /// </para>
    /// </remarks>
    /// <seealso cref="Card"/>
    partial class CardContent
    {

        /// <summary>
        /// The template to use for the card body.
        /// </summary>
        [Parameter]
        public RenderFragment BodyTemplate { get; set; }

        /// <summary>
        /// Specifies the position for the image specified in <see cref="ImageUrl"/>.
        /// </summary>
        [Parameter]
        public CardImagePosition ImagePosition { get; set; }

        /// <summary>
        /// The template to use for the card image.
        /// </summary>
        [Parameter]
        public RenderFragment<string> ImageTemplate { get; set; }

        /// <summary>
        /// The URL, either absolute or relative, to the image to show in the card.
        /// </summary>
        [Parameter]
        public string ImageUrl { get; set; }

    }
}
