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
    public abstract class BootstrapBase : ComponentBase
    {

        /// <summary>
        /// Creates an instance of the class.
        /// </summary>
        protected BootstrapBase()
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

        /// <summary>
        /// Adds the given class to the <see cref="Classes"/> collection if it does not already exist.
        /// </summary>
        /// <param name="className">The class to add.</param>
        /// <returns>Returns <c>true</c> if the class was added.</returns>
        protected bool AddClass(string className)
        {
            if (!this.Classes.Contains(className))
            {
                this.Classes.Add(className);
                this.HandleClassName();
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
            if(this.Classes.Contains(className))
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

    }

    public abstract class BootstrapStyledBase : BootstrapBase
    {
        [Parameter]
        public ComponentStyle ComponentStyle { get; set; }


        protected override void OnParametersSet()
        {
            var prefix = this.GetType().Name.ToLower();
            this.AddClass(prefix);

            if(this.ComponentStyle != ComponentStyle.None)
            {
                var styleContext = $"{prefix}-{this.ComponentStyle.ToString().ToLower()}";
                this.AddClass(styleContext);
            }

            base.OnParametersSet();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            var prefix = this.GetType().Name.ToLower();
            var styleContext = $"{prefix}-{this.ComponentStyle.ToString().ToLower()}";

            this.RemoveClass(prefix);
            this.RemoveClass(styleContext);

            return base.SetParametersAsync(parameters);
        }
    }
}
