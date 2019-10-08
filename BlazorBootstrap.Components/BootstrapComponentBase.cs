using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorBootstrap.Components
{
    /// <summary>
    /// Base implementation for all Blazor Boostrap components.
    /// </summary>
    public abstract class BootstrapComponentBase : ComponentBase
    {

        /// <summary>
        /// Creates an instance of the class.
        /// </summary>
        protected BootstrapComponentBase()
        {
            this.Attributes = new Dictionary<string, object>();
            this.Classes = new List<string>();
        }


        /// <summary>
        /// Enables child content for the control.
        /// </summary>
        [Parameter]
        public virtual RenderFragment ChildContent { get; set; }

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
        public Spacing? Padding { get; set; }

        /// <summary>
        /// Defines the top padding for the component.
        /// </summary>
        public Spacing? PaddingTop { get; set; }

        /// <summary>
        /// Defines the right padding for the component.
        /// </summary>
        public Spacing? PaddingRight { get; set; }

        /// <summary>
        /// Defines the bottom padding for the component.
        /// </summary>
        public Spacing? PaddingBottom { get; set; }

        /// <summary>
        /// Defines the left padding for the component.
        /// </summary>
        public Spacing? PaddingLeft { get; set; }

        /// <summary>
        /// Defines the X-axis paddings for the component.
        /// </summary>
        public Spacing? PaddingX { get; set; }

        /// <summary>
        /// Defines the Y-axis paddings for the component.
        /// </summary>
        public Spacing? PaddingY { get; set; }

        #endregion

        /// <summary>
        /// A collection of attributes that will be merged onto the component when rendered.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> Attributes { get; set; }

        [Parameter]
        public TextAlignment? TextAlignment { get; set; }

        [Parameter]
        public NamedColor? BackgroundColor { get; set; }

        [Parameter]
        public NamedColor? BorderColor { get; set; }

        [Parameter]
        public NamedColor? TextColor { get; set; }



        protected bool AddAttribute(string name, object value)
        {
            if(!this.Attributes.ContainsKey(name))
            {
                this.Attributes.Add(name, value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds the given class to the <see cref="Classes"/> collection if it does not already exist.
        /// </summary>
        /// <param name="className">The class to add.</param>
        /// <returns>Returns <c>true</c> if the class was added.</returns>
        protected bool AddClass(string className)
        {
            if (!string.IsNullOrEmpty(className) && !this.Classes.Contains(className))
            {
                this.Classes.Add(className);
                this.HandleClassName();
                return true;
            }

            return false;
        }

        protected void ClearAttributes()
        {
            this.Attributes.Clear();
        }

        protected void ClearClasses()
        {
            this.Classes.Clear();
        }

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

        protected bool RemoveAttribute(string name)
        {
            if(this.Attributes.ContainsKey(name))
            {
                this.Attributes.Remove(name);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the given class from the collection if it exists.
        /// </summary>
        /// <param name="className"></param>
        /// <returns>Returns <c>true</c> if the class was removed.</returns>
        protected bool RemoveClass(string className)
        {
            if(!string.IsNullOrEmpty(className) && this.Classes.Contains(className))
            {
                this.Classes.Remove(className);
                this.HandleClassName();
                return true;
            }

            return false;
        }




        private IList<string> Classes { get; }

        private void HandleClassName()
        {
            if(this.Classes.Count > 0)
            {
                this.Attributes["class"] = string.Join(" ", this.Classes);
            }
            else if(this.Attributes.ContainsKey("class"))
            {
                this.Attributes.Remove("class");
            }
        }

        private string BreakClassName(string input)
        {
            var list = new List<string>();
            var rx = new Regex("[A-Z]+[a-z]*|[0-9]+");
            foreach(var m in from Match x in rx.Matches(input) where x.Success && !string.IsNullOrEmpty(x.Value) select x)
            {
                list.Add(m.Value.ToLower());
            }

            return string.Join("-", list);
        }

        protected override void OnParametersSet()
        {
            #region Handle margins and paddings.

            Action<Spacing?, string> spacingAdder = (size, prefix) =>
            {
                if (size.HasValue)
                {
                    if (size != Spacing.Auto)
                    {
                        this.AddClass($"{prefix}-{(int)size}");
                    }
                    else
                    {
                        this.AddClass($"{prefix}-auto");
                    }
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

            if (this.TextAlignment.HasValue)
            {
                this.AddClass($"text-{this.TextAlignment.ToString().ToLower()}");
            }

            if(this.BackgroundColor.HasValue) this.AddClass(this.GetColorClassName(prefix: "bg", color: this.BackgroundColor));
            if(this.BorderColor.HasValue) this.AddClass(this.GetColorClassName(prefix: "border", color: this.BorderColor));
            if(this.TextColor.HasValue) this.AddClass(this.GetColorClassName(prefix: "text", color: this.TextColor));

            base.OnParametersSet();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.Attributes.Clear();
            this.Classes.Clear();

            return base.SetParametersAsync(parameters);
        }
    }
}
