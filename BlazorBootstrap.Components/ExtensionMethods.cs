using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public static class ExtensionMethods
    {

        /// <summary>
        /// Breaks the given input into lines.
        /// </summary>
        /// <param name="input">The input string to split up into lines.</param>
        /// <returns>Returns a collection where each line of text is a separate item.</returns>
        /// <remarks>
        /// If <paramref name="input"/> is <c>null</c>, an empty collection is returned.
        /// </remarks>
        public static IEnumerable<string> Lines(this string input)
        {
            foreach(var line in input?.Split(new[] { Environment.NewLine}, StringSplitOptions.None))
            {
                yield return line;
            }

            yield break;
        }
    }
}
