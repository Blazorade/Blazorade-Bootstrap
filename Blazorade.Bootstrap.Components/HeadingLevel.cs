using System.Text.RegularExpressions;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different levels for headings.
    /// </summary>
    public struct HeadingLevel
    {

        internal const int H1Value = 1;

        internal const int H2Value = 2;

        internal const int H3Value = 3;

        internal const int H4Value = 4;

        internal const int H5Value = 5;

        internal const int H6Value = 6;


        /// <summary>
        /// Converts the given integer to <see cref="HeadingLevel"/>.
        /// </summary>
        public static implicit operator HeadingLevel(int i)
        {
            return new HeadingLevel { Value = i };
        }

        /// <summary>
        /// Converts the given string to <see cref="HeadingLevel"/>.
        /// </summary>
        public static implicit operator HeadingLevel(string s)
        {
            if (int.TryParse(s, out int i))
            {
                return new HeadingLevel { Value = i };
            }

            var m = Regex.Match(s, "[Hh]\\d");
            if (m.Success)
            {
                return m.Value.Substring(1);
            }
            return H1;
        }

        /// <summary>
        /// First level.
        /// </summary>
        public static HeadingLevel H1
        {
            get { return new HeadingLevel { Value = H1Value }; }
        }

        /// <summary>
        /// Second level.
        /// </summary>
        public static HeadingLevel H2
        {
            get { return new HeadingLevel { Value = H2Value }; }
        }

        /// <summary>
        /// Third level.
        /// </summary>
        public static HeadingLevel H3
        {
            get { return new HeadingLevel { Value = H3Value }; }
        }

        /// <summary>
        /// Fourth level.
        /// </summary>
        public static HeadingLevel H4
        {
            get { return new HeadingLevel { Value = H4Value }; }
        }

        /// <summary>
        /// Fifth level.
        /// </summary>
        public static HeadingLevel H5
        {
            get { return new HeadingLevel { Value = H5Value }; }
        }

        /// <summary>
        /// Sixth level.
        /// </summary>
        public static HeadingLevel H6
        {
            get { return new HeadingLevel { Value = H6Value }; }
        }



        private int _Value;
        /// <summary>
        /// The actual value of the heading.
        /// </summary>
        public int Value { get { return _Value; } private set { _Value = value; } }

    }

}
