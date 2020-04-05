using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different horizontal alignments values.
    /// </summary>
    public struct HorizontalAlignment
    {

        internal const string LeftValue = "left";
        internal const string CenterValue = "center";
        internal const string RightValue = "right";

        private static ICollection<string> Values = new List<string> { LeftValue, CenterValue, RightValue };

        internal HorizontalAlignment(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Converts the given string to <see cref="HorizontalAlignment"/>.
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator HorizontalAlignment(string s)
        {
            if (Values.Contains(s?.ToLower()))
            {
                return new HorizontalAlignment(s?.ToLower());
            }
            return new HorizontalAlignment(null);
        }

        /// <summary>
        /// Eqals operator.
        /// </summary>
        public static bool operator ==(HorizontalAlignment x, HorizontalAlignment y)
        {
            return x.Value == y.Value;
        }

        /// <summary>
        /// Not equals operator.
        /// </summary>
        public static bool operator !=(HorizontalAlignment x, HorizontalAlignment y)
        {
            return x.Value != y.Value;
        }



        /// <summary>
        /// Content is aligned to the left.
        /// </summary>
        public static HorizontalAlignment Left
        {
            get { return new HorizontalAlignment(LeftValue); }
        }

        /// <summary>
        /// Content is centered.
        /// </summary>
        public static HorizontalAlignment Center
        {
            get { return new HorizontalAlignment(CenterValue); }
        }

        /// <summary>
        /// Content is aligned to the right.
        /// </summary>
        public static HorizontalAlignment Right
        {
            get { return new HorizontalAlignment(RightValue); }
        }


        /// <summary>
        /// The actual value.
        /// </summary>
        public string Value { get; private set; }



        /// <summary>
        /// Compares the given object to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare to the current.</param>
        public override bool Equals(object obj)
        {
            if(obj is HorizontalAlignment)
            {
                HorizontalAlignment ca = (HorizontalAlignment)obj;
                return this.Value == ca.Value;
            }
            return base.Equals(obj);
        }

        /// <summary>
        /// Returns the hash code for the alignment value.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Value?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Returns the string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Value;
        }

    }


}
