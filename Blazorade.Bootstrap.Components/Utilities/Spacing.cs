using System;
using System.Text.RegularExpressions;

namespace Blazorade.Bootstrap.Components.Utilities
{
    /// <summary>
    /// Defines different spacing values for components.
    /// </summary>
    /// <remarks>
    /// The members of this enumeration correspond to one of the supported size values. <see cref="https://getbootstrap.com/docs/4.4/utilities/spacing/#notation"/>
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


        internal Spacing(int i)
        {
            this.Value = $"{i}";
        }

        internal Spacing(string s)
        {
            this.Value = s;
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
            if(!string.IsNullOrEmpty(s))
            {
                Match m = null;
                m = Regex.Match(s, "\\d");
                if (m.Success)
                {
                    return new Spacing(int.Parse(m.Value));
                }

                m = Regex.Match(s, "[Ss]\\d");
                if (m.Success)
                {
                    return new Spacing(m.Value.Substring(1, 1));
                }

                if(s.ToLower().StartsWith("a"))
                {
                    return Spacing.Auto;
                }
            }
            return 0;
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
                if(int.TryParse(this.Value, out int i))
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

    }

}
