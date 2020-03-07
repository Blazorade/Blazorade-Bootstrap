using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Blazorade.Bootstrap.Components.Utilities;

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
        public ComponentSize? Height { get; set; }

        /// <summary>
        /// Specifies how text should be aligned in the component.
        /// </summary>
        [Parameter]
        public TextAlignment? TextAlignment { get; set; }

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
        public ShadowSize? Shadow { get; set; }

        /// <summary>
        /// Specifies whether the component is a container for streteched links. If the component contains
        /// an <see cref="Anchor"/> where <see cref="Anchor.IsStretched"/> is set to <c>true</c>, then the
        /// entire component will act as that link.
        /// </summary>
        [Parameter]
        public bool IsStretchedLinkContainer { get; set; }

        /// <summary>
        /// Specifies the width for the component.
        /// </summary>
        [Parameter]
        public ComponentSize? Width { get; set; }



        /// <summary>
        /// </summary>
        [Inject]
        protected IJSRuntime JsInterop { get; set; }



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
        protected override void OnParametersSet()
        {
            #region Handle margins and paddings

            Action<Spacing?, string> spacingAdder = (size, prefix) =>
            {
                if (size.HasValue)
                {
                    this.AddClasses($"{prefix}-{size.Value.Value}");
                }
            };

            spacingAdder(this.Margin, "m");
            spacingAdder(this.MarginTop, "mt");
            spacingAdder(this.MarginRight, "mr");
            spacingAdder(this.MarginBottom, "mb");
            spacingAdder(this.MarginLeft, "ml");
            spacingAdder(this.MarginX, "mx");
            spacingAdder(this.MarginY, "my");

            spacingAdder(this.Padding, "p");
            spacingAdder(this.PaddingTop, "pt");
            spacingAdder(this.PaddingRight, "pr");
            spacingAdder(this.PaddingBottom, "pb");
            spacingAdder(this.PaddingLeft, "pl");
            spacingAdder(this.PaddingX, "px");
            spacingAdder(this.PaddingY, "py");

            #endregion

            #region Handle shadows

            if (this.Shadow.HasValue)
            {
                switch (this.Shadow.Value)
                {
                    case ShadowSize.None:
                        this.AddClasses(ClassNames.Shadows.None);
                        break;

                    case ShadowSize.Small:
                        this.AddClasses(ClassNames.Shadows.Small);
                        break;

                    case ShadowSize.Regular:
                        this.AddClasses(ClassNames.Shadows.Regular);
                        break;

                    case ShadowSize.Large:
                        this.AddClasses(ClassNames.Shadows.Large);
                        break;
                }
            }

            #endregion

            #region Handle sizes

            Action<ComponentSize?, string> sizeAdder = (size, prefix) => {
                if (size.HasValue)
                {
                    string suffix = size.Value == ComponentSize.Auto ? "auto" : $"{(int)size.Value}";
                    this.AddClasses($"{prefix}-{suffix}");
                }
            };

            sizeAdder(this.Height, "h");
            sizeAdder(this.Width, "w");

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


            if (!string.IsNullOrEmpty(this.Id))
            {
                this.AddAttribute("id", this.Id);
            }

            base.OnParametersSet();
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
