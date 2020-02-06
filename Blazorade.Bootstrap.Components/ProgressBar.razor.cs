using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class ProgressBar
    {
        /// <summary>
        /// If set to true, this progress bar will have a striped texture.
        /// </summary>
        [Parameter]
        public bool IsStriped { get; set; }

        /// <summary>
        /// If set to true, any stripe will be animated.
        /// </summary>
        [Parameter]
        public bool IsAnimated { get; set; }

        /// <summary>
        /// The minimum value represented by the progress bar. This must be less than both Value and ValueMax.
        /// </summary>
        [Parameter]
        public double ValueMin { get; set; }

        /// <summary>
        /// The maximum value represented by the progress bar. This must be greater than both ValueMin and Value.
        /// </summary>
        [Parameter]
        public double ValueMax { get; set; }

        /// <summary>
        /// The current value represented by the progress bar. This must fall between ValueMin and ValueMax.
        /// </summary>
        [Parameter]
        public double Value { get; set; }

        protected string CalculatedWidth {
            get
            {
                return $"{Math.Round(Value / ValueMax, 2) * 100}%;";
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

            if (this.IsAnimated)
            {
                this.AddClasses(ClassNames.ProgressBars.Animated);
            }

            if (null != this.Color)
            {
                this.AddClasses(this.GetColorClassName("bg", this.Color));
            }

            // check and throw if contraints are busted
            if (ValueMax < ValueMin)
            {
                throw new ArgumentOutOfRangeException("ValueMax must be greater than ValueMin");
            }
            else if (Value > ValueMax || Value < ValueMin)
            {
                throw new ArgumentOutOfRangeException("Value must be greater than ValueMin and less than ValueMax");
            }

            base.OnParametersSet();
        }
    }
}
