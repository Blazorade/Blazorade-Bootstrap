using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different alignments for component content.
    /// </summary>
    public struct ContentAlignment
    {

        internal const string LeftValue = "left";
        internal const string CenterValue = "center";
        internal const string RightValue = "right";

        private static ICollection<string> Values = new List<string> { LeftValue, CenterValue, RightValue };

        internal ContentAlignment(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Converts the given string to <see cref="ContentAlignment"/>.
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator ContentAlignment(string s)
        {
            if (Values.Contains(s?.ToLower()))
            {
                return new ContentAlignment(s?.ToLower());
            }
            return new ContentAlignment(null);
        }

        /// <summary>
        /// Eqals operator.
        /// </summary>
        public static bool operator ==(ContentAlignment x, ContentAlignment y)
        {
            return x.Value == y.Value;
        }

        /// <summary>
        /// Not equals operator.
        /// </summary>
        public static bool operator !=(ContentAlignment x, ContentAlignment y)
        {
            return x.Value != y.Value;
        }



        /// <summary>
        /// Content is aligned to the left.
        /// </summary>
        public static ContentAlignment Left
        {
            get { return new ContentAlignment(LeftValue); }
        }

        /// <summary>
        /// Content is centered.
        /// </summary>
        public static ContentAlignment Center
        {
            get { return new ContentAlignment(CenterValue); }
        }

        /// <summary>
        /// Content is aligned to the right.
        /// </summary>
        public static ContentAlignment Right
        {
            get { return new ContentAlignment(RightValue); }
        }


        /// <summary>
        /// The actual value.
        /// </summary>
        public string Value { get; private set; }


        public override bool Equals(object obj)
        {
            if(obj is ContentAlignment)
            {
                ContentAlignment ca = (ContentAlignment)obj;
                return this.Value == ca.Value;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Value?.GetHashCode() ?? 0;
        }

        public override string ToString()
        {
            return this.Value;
        }

    }


}
