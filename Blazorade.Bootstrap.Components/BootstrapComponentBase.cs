using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Blazorade.Bootstrap.Components.Utilities;
using Blazorade.Bootstrap.Components.Configuration;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Base implementation for all Blazor Boostrap components.
    /// </summary>
    public abstract class BootstrapComponentBase : Blazorade.Core.Components.BlazoradeComponentBase
    {

        /// <summary>
        /// Creates an instance of the class.
        /// </summary>
        protected BootstrapComponentBase()
        {
        }


        #region Margin

        /// <summary>
        /// Defines the margins on all sides of the component.
        /// </summary>
        [Parameter]
        public Spacing? Margin { get; set; }

        /// <summary>
        /// Defines the top margin for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginTop { get; set; }

        /// <summary>
        /// Defines the right margin for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginRight { get; set; }

        /// <summary>
        /// Defines the bottom margin for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginBottom { get; set; }

        /// <summary>
        /// Defines the left margin for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginLeft { get; set; }

        /// <summary>
        /// Defines the X-axis margins for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginX { get; set; }

        /// <summary>
        /// Defines the Y-axis margins for the component.
        /// </summary>
        [Parameter]
        public Spacing? MarginY { get; set; }

        #endregion

        #region Padding

        /// <summary>
        /// Defines the padding on all sides of the component.
        /// </summary>
        [Parameter]
        public Spacing? Padding { get; set; }

        /// <summary>
        /// Defines the top padding for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingTop { get; set; }

        /// <summary>
        /// Defines the right padding for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingRight { get; set; }

        /// <summary>
        /// Defines the bottom padding for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingBottom { get; set; }

        /// <summary>
        /// Defines the left padding for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingLeft { get; set; }

        /// <summary>
        /// Defines the X-axis paddings for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingX { get; set; }

        /// <summary>
        /// Defines the Y-axis paddings for the component.
        /// </summary>
        [Parameter]
        public Spacing? PaddingY { get; set; }

        #endregion

        /// <summary>
        /// The ID of the element rendered by the component.
        /// </summary>
        [Parameter]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the height for the component.
        /// </summary>
        [Parameter]
        public Size? Height { get; set; }

        /// <summary>
        /// Specifies how text should be aligned in the component.
        /// </summary>
        [Parameter]
        public HorizontalAlignment? TextAlignment { get; set; }

        /// <summary>
        /// Specifies the background colour.
        /// </summary>
        [Parameter]
        public NamedColor? BackgroundColor { get; set; }

        /// <summary>
        /// Specifies the border colour.
        /// </summary>
        [Parameter]
        public NamedColor? BorderColor { get; set; }

        /// <summary>
        /// Specifies the colour of the text contained in the component.
        /// </summary>
        [Parameter]
        public NamedColor? TextColor { get; set; }

        /// <summary>
        /// Specifies a shadow for the component. Shadows are used to make certain elements stand out.
        /// </summary>
        [Parameter]
        public Shadow? Shadow { get; set; }

        /// <summary>
        /// Specifies whether the component is a container for streteched links. If the component contains
        /// an <see cref="Content.Anchor"/> where <see cref="Content.Anchor.IsStretched"/> is set to <c>true</c>, then the
        /// entire component will act as that link.
        /// </summary>
        [Parameter]
        public bool IsStretchedLinkContainer { get; set; }

        /// <summary>
        /// Specifies the width for the component.
        /// </summary>
        [Parameter]
        public Size? Width { get; set; }

        /// <summary>
        /// The tooltip to show for the component.
        /// </summary>
        /// <remarks>
        /// To control how tooltips work in your application, you can configure default settings on the <see cref="TooltipOptions"/> class.
        /// Please refer to that class for more information on how to configure tooltip options.
        /// </remarks>
        /// <seealso cref="TooltipOptions"/>
        [Parameter]
        public string Tooltip { get; set; }

        /// <summary>
        /// Defines the placement for the tooltip.
        /// </summary>
        /// <remarks>
        /// If not specified, the default placement configured on <see cref="TooltipOptions"/> is used.
        /// </remarks>
        /// <seealso cref="TooltipOptions"/>
        [Parameter]
        public TooltipPlacement? TooltipPlacement { get; set; }



        /// <summary>
        /// The service that handles JS interop.
        /// </summary>
        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        /// <summary>
        /// Options for tooltips.
        /// </summary>
        [Inject]
        protected TooltipOptions TooltipOptions { get; set; }


        /// <summary>
        /// Generates a new ID that can be used on elements.
        /// </summary>
        /// <returns></returns>
        protected string GenerateNewId()
        {
            // Assume that the 8 first chars will be unique enough on one page. A long ID, i.e. a full Guid, seems to
            // cause problems with for instance the Navbar component, which does not work properly when collapsed, if
            // the ID is long.
            return "e" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
        }

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
        protected string GetColorClassName(string prefix = null, NamedColor? color = null)
        {
            prefix = prefix ?? this.GetType().Name.ToLower();
            string name = null;
            if (color.HasValue)
            {
                name = $"{prefix}-{this.BreakClassName(color.ToString())}";
            }

            return name;
        }

        /// <summary>
        /// Logs an error to the browser's console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Arguments to log with the message.</param>
        protected async Task LogErrorAsync(string message, params object[] args)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Console.Error, message, args);
        }

        /// <summary>
        /// Logs an info message to the browser's console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Arguments to log with the message.</param>
        protected async Task LogInfoAsync(string message, params object[] args)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Console.Log, message, args);
        }

        /// <summary>
        /// Logs a warning to the browser's console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Arguments to log with the message.</param>
        protected async Task LogWarningAsync(string message, params object[] args)
        {
            await this.JsInterop.InvokeVoidAsync(JsFunctions.Console.Warn, message, args);
        }

        /// <summary>
        /// </summary>
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if(!string.IsNullOrEmpty(this.Tooltip))
            {
                var ttOptions = this.TooltipOptions ?? new TooltipOptions();
                string placement = this.TooltipPlacement?.ToString()?.ToLower() ?? ttOptions.DefaultPlacement.ToString().ToLower();
                var options = new { html = ttOptions.AllowHtml, sanitize = ttOptions.SanitizeHtml, placement = placement };
                await this.JsInterop.InvokeVoidAsync(JsFunctions.Tooltip.Init, $"#{this.Id}", options);
            }

        }

        /// <summary>
        /// </summary>
        protected async override Task OnParametersSetAsync()
        {
            #region Handle margins and paddings

            Func<Spacing?, string, bool, Task> spacingAdder = async (size, prefix, isPadding) =>
            {
                if (size.HasValue)
                {
                    if (isPadding && size.Value.IsNegative)
                    {
                        this.SetIdIfEmpty();
                        await this.LogWarningAsync($"Padding cannot be set to a negative value. Padding: '{size.Value}'. Element Id: {this.Id}");
                    }
                    this.AddClasses($"{prefix}-{size.Value.Value}");
                }
            };

            await spacingAdder(this.Margin, "m", false);
            await spacingAdder(this.MarginTop, "mt", false);
            await spacingAdder(this.MarginRight, "mr", false);
            await spacingAdder(this.MarginBottom, "mb", false);
            await spacingAdder(this.MarginLeft, "ml", false);
            await spacingAdder(this.MarginX, "mx", false);
            await spacingAdder(this.MarginY, "my", false);

            await spacingAdder(this.Padding, "p", true);
            await spacingAdder(this.PaddingTop, "pt", true);
            await spacingAdder(this.PaddingRight, "pr", true);
            await spacingAdder(this.PaddingBottom, "pb", true);
            await spacingAdder(this.PaddingLeft, "pl", true);
            await spacingAdder(this.PaddingX, "px", true);
            await spacingAdder(this.PaddingY, "py", true);

            #endregion

            #region Handle shadows

            if (this.Shadow.HasValue)
            {
                string shadowCls;
                switch (this.Shadow.Value)
                {
                    case Utilities.Shadow.Small:
                        shadowCls = ClassNames.Shadows.Small;
                        break;

                    case Utilities.Shadow.Regular:
                        shadowCls = ClassNames.Shadows.Regular;
                        break;

                    case Utilities.Shadow.Large:
                        shadowCls = ClassNames.Shadows.Large;
                        break;

                    default:
                        shadowCls = ClassNames.Shadows.None;
                        break;
                }

                this.AddClasses(shadowCls);
            }

            #endregion

            #region Handle sizes

            Action<Size?, string, string> sizeAdder = (size, prefix, style) => {
                if (size.HasValue)
                {
                    if(size.Value.NumericValue.HasValue)
                    {
                        if (size.Value.IsPercentage)
                        {
                            this.AddClasses($"{prefix}-{Math.Floor(size.Value.NumericValue.Value)}");
                        }
                        else if (size.Value.IsPixel)
                        {
                            this.AddStyle(style, size.Value.ToString());
                        }
                    }
                    else
                    {
                        this.AddClasses($"{prefix}-{size.Value.Value}");
                    }
                }
            };

            sizeAdder(this.Height, "h", "height");
            sizeAdder(this.Width, "w", "width");

            #endregion


            if (this.TextAlignment.HasValue)
            {
                this.AddClasses($"text-{this.TextAlignment.ToString().ToLower()}");
            }

            if (this.BackgroundColor.HasValue) this.AddClasses(this.GetColorClassName(prefix: "bg", color: this.BackgroundColor));
            if (this.BorderColor.HasValue)
            {
                this.AddClasses("border");
                this.AddClasses(this.GetColorClassName(prefix: "border", color: this.BorderColor));
            }
            if (this.TextColor.HasValue) this.AddClasses(this.GetColorClassName(prefix: "text", color: this.TextColor));

            if (this.IsStretchedLinkContainer)
            {
                this.AddClasses(ClassNames.Position.Relative);
            }

            if (!string.IsNullOrEmpty(this.Tooltip))
            {
                this.SetIdIfEmpty();
                this.Attributes["title"] = this.Tooltip;
            }

            if (!string.IsNullOrEmpty(this.Id))
            {
                this.AddAttribute("id", this.Id);
            }


            await base.OnParametersSetAsync();
        }

        /// <summary>
        /// Sets the <c>id</c> attribute if it has not already been set.
        /// </summary>
        /// <param name="id">OPtional. The ID to set if it is empty. If not specified, an ID is automatically generated.</param>
        protected void SetIdIfEmpty(string id = null)
        {
            if (!this.Attributes.ContainsKey("id"))
            {
                id = this.Id ?? id ?? this.GenerateNewId();
                this.Id = id;
                this.Attributes.Add("id", id);
            }
        }



        private string BreakClassName(string input)
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
