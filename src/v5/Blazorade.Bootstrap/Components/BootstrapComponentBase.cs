using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The base class for all Blazorade Bootstrap components.
    /// </summary>
    public abstract class BootstrapComponentBase : Blazorade.Core.Components.BlazoradeComponentBase
    {
        /// <summary>
        /// The JavaScript runtime available to Bootstrap components.
        /// </summary>
        [Microsoft.AspNetCore.Components.Inject]
        protected IJSRuntime JsInterop { get; set; } = default!;

        /// <summary>
        /// Generates the class name from the given prefix and colour. The method returns <c>{prefix}-{colour}</c>.
        /// </summary>
        /// <param name="prefix">
        /// The prefix (without a dash) for the class name, for instance <c>btn</c>. If the prefix is not specified,
        /// the lower case version of the current class name is used.
        /// </param>
        /// <param name="color">The colour to create the clas name from.</param>
        /// <returns>
        /// Returns the class name as <c>{prefix}-{color}</c> or <c>null</c> if <paramref name="color"/> is <c>null</c>.
        /// </returns>
        protected string? GetColorClassName(string? prefix = null, NamedColor? color = null)
        {
            prefix = prefix ?? this.GetType().Name.ToLower();
            string? name = null;
            if (color.HasValue)
            {
                name = $"{prefix}-{this.BreakClassName(color?.ToString())}";
            }

            return name;
        }


        private string BreakClassName(string? input)
        {
            var list = new List<string>();
            foreach (var w in input.FindWords())
            {
                list.Add(w.ToLower());
            }

            return string.Join("-", list);
        }

    }
}
