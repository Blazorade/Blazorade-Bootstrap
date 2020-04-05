using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public struct Size
    {

        internal const string P25Value = "25";
        internal const string P50Value = "50";
        internal const string P75Value = "75";
        internal const string P100Value = "100";
        internal const string AutoValue = "auto";


        internal Size(string value)
        {
            this.Value = value;
        }


        /// <summary>
        /// Converts the given string to <see cref="Size"/>.
        /// </summary>
        public static implicit operator Size(string s)
        {
            return new Size(s);
        }

        /// <summary>
        /// </summary>
        public static bool operator ==(Size x, Size y)
        {
            return x.Value == y.Value;
        }

        /// <summary>
        /// </summary>
        public static bool operator !=(Size x, Size y)
        {
            return x.Value != y.Value;
        }



        public static Size Auto
        {
            get { return AutoValue; }
        }

        public static Size P25
        {
            get { return P25Value; }
        }

        public static Size P50
        {
            get { return P50Value; }
        }

        public static Size P75
        {
            get { return P75Value; }
        }

        public static Size P100
        {
            get { return P100Value; }
        }




        /// <summary>
        /// The value that specifies the size.
        /// </summary>
        public string Value { get; private set; }



        /// <summary>
        /// Compares the given object to the current.
        /// </summary>
        public override bool Equals(object obj)
        {
            if(obj is Size)
            {
                return ((Size)obj).Value == this.Value;
            }

            return false;
        }

        /// <summary>
        /// </summary>
        public override int GetHashCode()
        {
            return this.Value?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Returns the string representation.
        /// </summary>
        public override string ToString()
        {
            return this.Value;
        }
    }
}
