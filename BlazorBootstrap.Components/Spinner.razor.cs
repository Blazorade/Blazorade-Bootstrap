using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class Spinner
    {

        public Spinner()
        {
            this.Size = SpinnerSize.Normal;
            this.Type = SpinnerType.Border;
        }


        [Parameter]
        public SpinnerSize Size { get; set; }

        [Parameter]
        public SpinnerType Type { get; set; }


        protected override void OnParametersSet()
        {
            var className = $"{ClassNames.Spinners.Spinner}-{this.Type.ToString().ToLower()}";
            this.AddClass(className);
            if (this.Color.HasValue)
            {
                this.AddClass(this.GetColorClassName("text", this.Color));
            }

            if(this.Size == SpinnerSize.Small)
            {
                this.AddClass($"{className}-sm");
            }

            this.AddAttribute("role", "status");


            base.OnParametersSet();
        }
    }
}
