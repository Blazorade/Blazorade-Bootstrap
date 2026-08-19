using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap
{
    internal static class InternalExtensions
    {
        /// <summary>
        /// Assumes the input is a string where each word starts with a capital letter. Breaks up the string into the separate words.
        /// </summary>
        internal static IEnumerable<string> FindWords(this string? s)
        {
            var list = new List<string>();

            if (!string.IsNullOrEmpty(s))
            {
                var rx = new Regex("[A-Z]+[a-z]*|[0-9]+");
                foreach (var m in from Match x in rx.Matches(s) where x.Success && !string.IsNullOrEmpty(x.Value) select x)
                {
                    list.Add(m.Value);
                }
            }

            return list.AsEnumerable();
        }
    }
}
