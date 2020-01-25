using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public class CarouselSlideEventArgs
    {

        public CarouselSlideEventArgs(Carousel carousel, int from, int to, string direction)
        {
            this.Carousel = carousel;
            this.From = from;
            this.To = to;
            this.Direction = direction;
        }


        public Carousel Carousel { get; private set; }

        public int From { get; private set; }

        public int To { get; private set; }

        public string Direction { get; private set; }

    }
}
