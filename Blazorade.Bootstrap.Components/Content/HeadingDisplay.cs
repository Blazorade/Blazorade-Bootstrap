namespace Blazorade.Bootstrap.Components.Content
{

    /// <summary>
    /// Allows you to make a Heading stand out as a larger than normal heading.
    /// </summary>
    /// <remarks>
    /// For details see https://getbootstrap.com/docs/4.5/content/typography/#display-headings.
    /// </remarks>
    public struct HeadingDisplay
    {

        internal const int D1Value = 1;
        internal const int D2Value = 2;
        internal const int D3Value = 3;
        internal const int D4Value = 4;


        /// <summary>
        /// Converts the given integer to a <see cref="HeadingDisplay"/> value.
        /// </summary>
        public static implicit operator HeadingDisplay(int i)
        {
            if(i >= D1Value && i <= D4Value)
            {
                return new HeadingDisplay { Value = i };
            }
            return new HeadingDisplay { Value = D1Value };
        }

        /// <summary>
        /// Convert the given string to a <see cref="HeadingDisplay"/> value.
        /// </summary>
        public static implicit operator HeadingDisplay(string s)
        {
            if(int.TryParse(s, out int i))
            {
                return i;
            }
            return new HeadingDisplay { Value = 1 };
        }

        /// <summary>
        /// </summary>
        public static HeadingDisplay D1 { get { return new HeadingDisplay { Value = D1Value }; } }

        /// <summary>
        /// </summary>
        public static HeadingDisplay D2 { get { return new HeadingDisplay { Value = D2Value }; } }

        /// <summary>
        /// </summary>
        public static HeadingDisplay D3 { get { return new HeadingDisplay { Value = D3Value }; } }

        /// <summary>
        /// </summary>
        public static HeadingDisplay D4 { get { return new HeadingDisplay { Value = D4Value }; } }

        /// <summary>
        /// Actual value.
        /// </summary>
        public int Value { get; private set; }
    }
}
