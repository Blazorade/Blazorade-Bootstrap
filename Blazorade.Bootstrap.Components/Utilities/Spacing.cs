namespace Blazorade.Bootstrap.Components.Utilities
{
    /// <summary>
    /// Defines different spacing values for components.
    /// </summary>
    /// <remarks>
    /// The members of this enumeration correspond to one of the supported size values. <see cref="https://getbootstrap.com/docs/4.4/utilities/spacing/#notation"/>
    /// </remarks>
    public enum Spacing
    {
        /// <summary>
        /// Automatic spacing.
        /// </summary>
        Auto = -1,

        /// <summary>
        /// No spacing.
        /// </summary>
        Zero = 0,

        /// <summary>
        /// $spacer * 0.25
        /// </summary>
        One = 1,

        /// <summary>
        /// $spacer * 0.5
        /// </summary>
        Two = 2,

        /// <summary>
        /// $spacer
        /// </summary>
        Three = 3,

        /// <summary>
        /// $spacer * 1.5
        /// </summary>
        Four = 4,

        /// <summary>
        /// $spacer * 3
        /// </summary>
        Five = 5
    }
}
