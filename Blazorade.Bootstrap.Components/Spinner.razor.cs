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


            base.OnParametersSet();
        }
    }
}
