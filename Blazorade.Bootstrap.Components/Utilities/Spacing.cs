using System;
using System.Text.RegularExpressions;

namespace Blazorade.Bootstrap.Components.Utilities
{
    /// <summary>
    /// Defines different spacing values for components.
    /// </summary>
    /// <remarks>
    /// The members of this enumeration correspond to one of the supported size values. See https://getbootstrap.com/docs/4.5/utilities/spacing/#notation for details.
    /// </remarks>
    public struct Spacing
    {
        internal const string S0Value = "0";
        internal const string S1Value = "1";
        internal const string S2Value = "2";
        internal const string S3Value = "3";
        internal const string S4Value = "4";
        internal const string S5Value = "5";

        internal const string S1NValue = "-1";
        internal const string S2NValue = "-2";
        internal const string S3NValue = "-3";
        internal const string S4NValue = "-4";
        internal const string S5NValue = "-5";

        internal const string SAutoValue = "auto";


        /// <summary>
        /// Automatic spacing.
        /// </summary>
        public static Spacing Auto { get => new Spacing { Value = SAutoValue }; }

        /// <summary>
        /// No spacing.
        /// </summary>
        public static Spacing S0 { get => new Spacing { Value = S0Value }; }

        /// <summary>
        /// $spacer * 0.25
        /// </summary>
        public static Spacing S1 { get => new Spacing { Value = S1Value }; }

        /// <summary>
        /// $spacer * 0.5
        /// </summary>
        public static Spacing S2 { get => new Spacing { Value = S2Value }; }

        /// <summary>
        /// $spacer
        /// </summary>
        public static Spacing S3 { get => new Spacing { Value = S3Value }; }

        /// <summary>
        /// $spacer * 1.5
        /// </summary>
        public static Spacing S4 { get => new Spacing { Value = S4Value }; }

        /// <summary>
        /// $spacer * 3
        /// </summary>
        public static Spacing S5 { get => new Spacing { Value = S5Value }; }


        internal Spacing(int i) : this($"{i}") { }

        internal Spacing(string s)
        {
            if(int.TryParse(s, out int i))
            {
                this.Value = i < 0 ? $"n{i * -1}" : $"{i}";
            }
            else if((s?.ToLower()?.StartsWith('a')).GetValueOrDefault())
            {
                this.Value = SAutoValue;
            }
            else
            {
                this.Value = s;
            }
        }

        /// <summary>
        /// Converts the given number to <see cref="Spacing"/>.
        /// </summary>
        public static implicit operator Spacing(int i)
        {
            return new Spacing(i);
        }

        /// <summary>
        /// Converts the given string to <see cref="Spacing"/>.
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator Spacing(string s)
        {
            return new Spacing(s);
        }

        /// <summary>
        /// Returns <c>true</c> if the value has been set to auto.
        /// </summary>
        public bool IsAuto { get => this.Value?.ToLower() == SAutoValue.ToLower(); }

        /// <summary>
        /// Returns <c>true</c> if the spacing defines negative spacing.
        /// </summary>
        /// <remarks>
        /// Negative spacing is only supported for margins, but not paddings.
        /// </remarks>
        public bool IsNegative { get => this.NumericValue.GetValueOrDefault() < 0; }
        
        /// <summary>
        /// The numeric value.
        /// </summary>
        public int? NumericValue
        {
            get
            {
                if(int.TryParse(this.Value.Replace('n', '-'), out int i))
                {
                    return i;
                }
                return null;
            }
        }

        /// <summary>
        /// The actual value.
        /// </summary>
        public string Value { get; private set; }



        /// <summary>
        /// Returns the string representation of the instance.
        /// </summary>
        public override string ToString()
        {
            return this.Value ?? base.ToString();
        }
    }

}
