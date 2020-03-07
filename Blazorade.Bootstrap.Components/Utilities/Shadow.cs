using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Utilities
{
    /// <summary>
    /// Defines different shadow sizes for components.
    /// </summary>
    public struct Shadow
    {

        internal const string NoneValue = ClassNames.Shadows.None;

        internal const string SmallValue = ClassNames.Shadows.Small;

        internal const string RegularValue = ClassNames.Shadows.Regular;

        internal const string LargeValue = ClassNames.Shadows.Large;



        /// <summary>
        /// No shadow. Default.
        /// </summary>
        public static Shadow None
        {
            get { return new Shadow(NoneValue); }
        }

        /// <summary>
        /// A small shadow.
        /// </summary>
        public static Shadow Small
        {
            get { return new Shadow(SmallValue); }
        }

        /// <summary>
        /// Regular shadow.
        /// </summary>
        public static Shadow Regular
        {
            get { return new Shadow(RegularValue); }
        }

        /// <summary>
        /// Large shadow.
        /// </summary>
        public static Shadow Large
        {
            get { return new Shadow(LargeValue); }
        }


        internal Shadow(string s)
        {
            this.Value = s;
        }


        /// <summary>
        /// Converts the given string to <see cref="Shadow"/>.
        /// </summary>
        public static implicit operator Shadow(string s)
        {
            switch ($"{s}".ToLower())
            {
                case "sm":
                case "small":
                    return Shadow.Small;

                case "r":
                case "reg":
                case "regular":
                    return Shadow.Regular;

                case "lg":
                case "l":
                case "large":
                    return Shadow.Large;

                default:
                    return Shadow.None;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <remarks>
        /// The value equals the class name to add to an element for different sizes of shadows.
        /// </remarks>
        public string Value { get; private set; }

    }

}
