using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The event args class for <see cref="Carousel.OnSlide"/> and <see cref="Carousel.OnSlid"/>.
    /// </summary>
    public class CarouselSlideEventArgs
    {
        /// <summary>
        /// </summary>
        public CarouselSlideEventArgs(Carousel carousel, int from, int to, string direction)
        {
            this.Carousel = carousel;
            this.From = from;
            this.To = to;
            this.Direction = direction;
        }


        /// <summary>
        /// The source <see cref="Carousel"/> component instance for the event.
        /// </summary>
        public Carousel Carousel { get; private set; }

        /// <summary>
        /// The zero-based index of the slide the carousel is moving from.
        /// </summary>
        public int From { get; private set; }

        /// <summary>
        /// The zero-based index of the slide the carousel is moving to.
        /// </summary>
        public int To { get; private set; }

        /// <summary>
        /// A textual representation of the direction.
        /// </summary>
        public string Direction { get; private set; }

    }
}
