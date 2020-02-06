using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ProgressBar
    {
        [Parameter]
        public bool IsStriped { get; set; }

        [Parameter]
        public double ValueMin { get; set; }

        [Parameter]
        public double ValueMax { get; set; }

        [Parameter]
        public double Value { get; set; }

        public string CalculatedWidth {
            get
            {
                return $"{Math.Round(Value / ValueMax)}%;";
            }
        }

        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.ProgressBars.ProgressBar);
            this.AddAttribute("role", "progressbar");

            if(this.IsStriped)
            {
                this.AddClasses(ClassNames.ProgressBars.Striped);
            }

            if(null != this.Color)
            {
                this.AddClasses(this.GetColorClassName("bg", this.Color));
            }

            //// check and throw if contraints are busted
            //if(ValueMax < ValueMin)
            //{
            //    throw new ArgumentOutOfRangeException("ValueMax must be greater than ValueMin");
            //}
            //else if(Value > ValueMax || Value < ValueMin)
            //{
            //    throw new ArgumentOutOfRangeException("Value must be greater than ValueMin and less than ValueMax");
            //}
            //else
            //{
            //    // replace the "width" style on this element
            //    if(this.Styles.ContainsKey("width"))
            //    {
            //        this.RemoveStyle("width");
            //    }
            //    this.AddStyle("width", $"{Math.Round(Value / ValueMax)}%");
            //}

            base.OnParametersSet();
        }
    }
}
