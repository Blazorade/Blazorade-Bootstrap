using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different positions for images contained in <see cref="Card"/> components.
    /// </summary>
    public enum CardImagePosition
    {
        /// <summary>
        /// Default. The image is positioned at the top of the card.
        /// </summary>
        Top,

        /// <summary>
        /// The image is positioned at the bottom of the card.
        /// </summary>
        Bottom,

        /// <summary>
        /// The image is positioned to the left of the card.
        /// </summary>
        Left,

        /// <summary>
        /// The image is positioned to the right of the card.
        /// </summary>
        Right,

        /// <summary>
        /// The contents of the card are overlaid over the image.
        /// </summary>
        Overlay
    }
}
