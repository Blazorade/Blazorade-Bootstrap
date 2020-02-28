namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different types for <see cref="CardGroup"/> components.
    /// </summary>
    public enum CardGroupType
    {
        /// <summary>
        /// The default type. Cards in a group of this type have equal width and equal height with no specing in between the cards.
        /// </summary>
        Group,

        /// <summary>
        /// Cards in a group of this type have equal width and equal height with a little bit of spacing in between.
        /// </summary>
        Deck,

        /// <summary>
        /// Cards in a group of this type have equal width, but the height is whatever height each card has. Cards are arranged
        /// top to bottom, left to right.
        /// </summary>
        Columns
    }
}
