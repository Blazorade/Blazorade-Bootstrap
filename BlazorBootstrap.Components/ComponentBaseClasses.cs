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

        private string _Id;
        /// <summary>
        /// The <code>id</code> attribute of the component.
        /// </summary>
        [Parameter]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; this.HandleAttribute("id", value); }
        }


        /// <summary>
        /// A collection of attributes that will be merged onto the component when rendered.
        /// </summary>
        protected IDictionary<string, object> Attributes { get; }

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

        private void HandleAttribute(string name, object value)
        {
            if (null != value)
            {
                this.Attributes[name] = value;
            }
            else if (this.Attributes.ContainsKey(name))
            {
                this.Attributes.Remove(name);
            }
        }

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
