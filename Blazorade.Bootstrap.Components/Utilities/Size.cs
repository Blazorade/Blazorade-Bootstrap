using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents various sizes that components use for both width and height.
    /// </summary>
    public struct Size
    {

        internal const string P25Value = "0.25";
        internal const string P50Value = "0.5";
        internal const string P75Value = "0.75";
        internal const string P100Value = "1";
        internal const string AutoValue = "auto";

        internal static IFormatProvider NumericFormatProvider = new CultureInfo("en-us"); // Used for formatting numbers. Specifies a dot as decimal separator, which is the same we use in code too.

        internal Size(string value, double? numericValue = null, bool isPercentage = false, bool isPixelSize = false)
        {
            this.Value = value;
            this.NumericValue = numericValue;
            this.IsPercentage = isPercentage;
            this.IsPixel = isPixelSize;
        }

        internal bool IsPixel { get; private set; }
        internal bool IsPercentage { get; private set; }



        /// <summary>
        /// Converts the given string to <see cref="Size"/>.
        /// </summary>
        public static implicit operator Size(string s)
        {
            if(double.TryParse(s, NumberStyles.Any, NumericFormatProvider, out double d))
            {
                return d;
            }

            return new Size(s);
        }

        /// <summary>
        /// Converts the given numeric value to a <see cref="Size"/>.
        /// </summary>
        public static implicit operator Size(double d)
        {
            var s = d.ToString(NumericFormatProvider);

            if (d > 1)
            {
                // If the numeric value is greater than 1, then we assume it is the size specified in pixels.
                return new Size(s, isPixelSize: true, numericValue: d);
            }
            else
            {
                // If the numeric value is 1 or less, we assume it is a percentage, where .5 equals 50%.
                return new Size(s, isPercentage: true, numericValue: d * 100);
            }
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



        /// <summary>
        /// Auto size.
        /// </summary>
        public static Size Auto
        {
            get { return AutoValue; }
        }

        /// <summary>
        /// 25%.
        /// </summary>
        public static Size P25
        {
            get { return P25Value; }
        }

        /// <summary>
        /// 50%.
        /// </summary>
        public static Size P50
        {
            get { return P50Value; }
        }

        /// <summary>
        /// 75%.
        /// </summary>
        public static Size P75
        {
            get { return P75Value; }
        }

        /// <summary>
        /// 100%.
        /// </summary>
        public static Size P100
        {
            get { return P100Value; }
        }



        internal double? NumericValue { get; private set; }

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
            if (this.NumericValue.HasValue)
            {
                if (this.IsPercentage)
                {
                    return $"{this.NumericValue.Value.ToString(NumericFormatProvider)}%";
                }
                else if(this.IsPixel)
                {
                    return $"{this.NumericValue.Value.ToString(NumericFormatProvider)}px";
                }
            }

            return this.Value;
        }
    }
}
