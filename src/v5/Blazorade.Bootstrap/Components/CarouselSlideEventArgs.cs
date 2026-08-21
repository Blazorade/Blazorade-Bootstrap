namespace Blazorade.Bootstrap.Components
{
    /// <summary>Event data for carousel slide transitions.</summary>
    public sealed class CarouselSlideEventArgs
    {
        /// <summary>Initializes event data for a carousel transition.</summary>
        public CarouselSlideEventArgs(Carousel carousel, int from, int to, string direction)
        {
            this.Carousel = carousel;
            this.From = from;
            this.To = to;
            this.Direction = direction;
        }

        /// <summary>The carousel that raised the event.</summary>
        public Carousel Carousel { get; }
        /// <summary>The zero-based source slide index.</summary>
        public int From { get; }
        /// <summary>The zero-based destination slide index.</summary>
        public int To { get; }
        /// <summary>The Bootstrap transition direction.</summary>
        public string Direction { get; }
    }
}
