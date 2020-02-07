using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    partial class Spinner
    {

        public Spinner()
        {
            this.Size = SpinnerSize.Normal;
            this.Type = SpinnerType.Border;
        }


        [Parameter]
        public ContentAlignment? ContentAlignment { get; set; }

        [Parameter]
        public SpinnerSize Size { get; set; }

        [Parameter]
        public SpinnerType Type { get; set; }


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
