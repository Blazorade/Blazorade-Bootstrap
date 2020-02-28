using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different types for transitions between slides in a <see cref="Carousel"/> component.
    /// </summary>
    public enum CarouselTransitionType
    {
        /// <summary>
        /// The slide are changed by sliding left or right.
        /// </summary>
        Slide,

        /// <summary>
        /// The slides are changed by fading from one to the other.
        /// </summary>
        Fade
    }
}
