using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
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
        public RenderFragment ChildContent { get; set; }

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

            base.OnParametersSet();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            this.Attributes.Clear();
            this.Classes.Clear();

            return base.SetParametersAsync(parameters);
        }
    }

    public abstract class BootstrapColoredComponentBase : BootstrapComponentBase
    {

        protected BootstrapColoredComponentBase()
        {
            this.AddClass(this.GetType().Name.ToLower());
        }


        [Parameter]
        public ComponentColor Color { get; set; }

        protected string GetStyleClassName(string prefix = null)
        {
            prefix = prefix ?? this.GetType().Name.ToLower();
            string name = null;
            if(this.Color != ComponentColor.None)
            {
                name = $"{prefix}-{this.Color.ToString().ToLower()}";
            }

            return name;
        }

        protected override void OnParametersSet()
        {
            var styleContext = this.GetStyleClassName();
            this.AddClass(styleContext);

            base.OnParametersSet();
        }

    }
}
