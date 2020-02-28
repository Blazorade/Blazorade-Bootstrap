using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Spinner component is used to indicate a loading state of a UI element or page.
    /// </summary>
    partial class Spinner
    {

        /// <summary>
        /// </summary>
        public Spinner()
        {
            this.Size = SpinnerSize.Normal;
            this.Type = SpinnerType.Border;
        }


        /// <summary>
        /// Specifies how to align child content in your spinner.
        /// </summary>
        [Parameter]
        public ContentAlignment? ContentAlignment { get; set; }

        /// <summary>
        /// The size of the spinner. Defaults to <see cref="SpinnerSize.Normal"/>.
        /// </summary>
        [Parameter]
        public SpinnerSize Size { get; set; }

        /// <summary>
        /// The type of spinner. Defaults to <see cref="SpinnerType.Border"/>.
        /// </summary>
        [Parameter]
        public SpinnerType Type { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            var className = $"{ClassNames.Spinners.Spinner}-{this.Type.ToString().ToLower()}";
            this.AddClasses(className);
            if (this.Color.HasValue)
            {
                this.AddClasses(this.GetColorClassName("text", this.Color));
            }

            if(this.Size == SpinnerSize.Small)
            {
                this.AddClasses($"{className}-sm");
            }

            this.AddAttribute("role", "status");

            if(null != this.ChildContent)
            {
                if(null == this.ContentAlignment || this.ContentAlignment == Components.ContentAlignment.Left)
                {
                    this.MarginLeft = Spacing.Auto;
                }
                else if(this.ContentAlignment == Components.ContentAlignment.Right)
                {
                    this.MarginRight = Spacing.Auto;
                }
            }

            base.OnParametersSet();
        }
    }
}
