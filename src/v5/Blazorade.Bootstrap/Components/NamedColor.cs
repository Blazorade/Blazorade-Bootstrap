using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines different named colours supported by Bootstrap.
    /// </summary>
    public enum NamedColor
    {
        /// <summary>
        /// The primary colour. This is typically modified to be your brand colour or the main colour you use to make items stand out.
        /// </summary>
        Primary,

        /// <summary>
        /// The secondary colour is typically used to support the primary colour, like a secondary brand colour or something like that.
        /// </summary>
        Secondary,

        /// <summary>
        /// The colour that is used to signal that a task has succeeded or to emphasize something positive, like the colour of a Save button.
        /// </summary>
        Success,

        /// <summary>
        /// The danger colour is used to signal dangerous actions, such as deleting something permanently. The danger colour is also used to bring focus to error messages etc.
        /// </summary>
        Danger,

        /// <summary>
        /// The warning colour is typically used to warn the user about something possibly dangerous.
        /// </summary>
        Warning,

        /// <summary>
        /// The colour used for generic informational data.
        /// </summary>
        Info,

        /// <summary>
        /// A generic light colour. The default is a grayscale colour, but can be modified to be a very light version of the <see cref="Primary"/> colour.
        /// </summary>
        Light,

        /// <summary>
        /// A generic dark colour. The default is a grayscale colour, but can be modified, for instance to a dark version of the brand colour.
        /// </summary>
        Dark,

        /// <summary>
        /// White.
        /// </summary>
        White,

        /// <summary>
        /// 50% white. Not supported by all components.
        /// </summary>
        White50,

        /// <summary>
        /// 50% black. Not supported by all components.
        /// </summary>
        Black50,

        /// <summary>
        /// Transparent.
        /// </summary>
        Transparent
    }
}
