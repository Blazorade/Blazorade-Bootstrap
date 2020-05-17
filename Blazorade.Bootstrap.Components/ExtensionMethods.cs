using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Defines extension methods for components.
    /// </summary>
    public static class ExtensionMethods
    {

        /// <summary>
        /// Assumes the input is a string where each word starts with a capital letter. Breaks up the string into the separate words.
        /// </summary>
        public static IEnumerable<string> FindWords(this string s)
        {
            var list = new List<string>();

            if(!string.IsNullOrEmpty(s))
            {
                var rx = new Regex("[A-Z]+[a-z]*|[0-9]+");
                foreach (var m in from Match x in rx.Matches(s) where x.Success && !string.IsNullOrEmpty(x.Value) select x)
                {
                    list.Add(m.Value);
                }
            }

            return list.AsEnumerable();
        }

        /// <summary>
        /// Assumes the given string contains multiple words that are not separated by spaces, but where each word starts with 
        /// a capital letter or a number. The result is returned as a string where a hyphen is inserted between each word.
        /// </summary>
        public static string Hyphenate(this string s)
        {
            if(null != s && !s.Contains('-'))
            {
                var words = s.FindWords();
                return string.Join('-', words);
            }
            return s;
        }

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

        /// <summary>
        /// Registers an event callback.
        /// </summary>
        /// <param name="jsInterop"></param>
        /// <param name="id">The ID of the element whose event to register for.</param>
        /// <param name="eventName">The name of the event to register for.</param>
        /// <param name="callbackTarget">The component that will receive the callback.</param>
        /// <param name="callbackMethodName">The name of the callback method on the <paramref name="callbackTarget"/>.</param>
        /// <param name="singleEvent">If set to <c>true</c> will automatically deregister after first event.</param>
        /// <param name="callbackParameters">Parameters to send to the callback method.</param>
        /// <returns></returns>
        public static async Task RegisterEventCallbackAsync(this IJSRuntime jsInterop, string id, string eventName, BootstrapComponentBase callbackTarget, string callbackMethodName, bool singleEvent = true, string[] callbackParameters = null)
        {
            await jsInterop.InvokeVoidAsync(JsFunctions.RegisterEventCallback, $"#{id}", eventName, DotNetObjectReference.Create(callbackTarget), callbackMethodName, singleEvent, callbackParameters);
        }

    }
}
