using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{

    public interface IContextualComponent
    {
        ComponentStyleContext StyleContext { get; set; }
    }


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
        /// A collection of classes to apply to the component when rendering.
        /// </summary>
        protected IList<string> Classes { get; }


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
    }

    public abstract class BootstrapContextualBase : BootstrapBase, IContextualComponent
    {
        [Parameter]
        public ComponentStyleContext StyleContext { get; set; }
    }


    public abstract class BootstrapContainerBase : BootstrapBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }

    public abstract class BootstrapContextualContainerBase : BootstrapContainerBase, IContextualComponent
    {
        [Parameter]
        public ComponentStyleContext StyleContext { get; set; }
    }
}
