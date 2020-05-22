using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The ProgressBar component, when placed inside of a Progress component, defines a bootstrap progress bar 
    /// or a section of a progress bar if multiple ProgressBar elements are used.
    /// </summary>
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
        /// The minimum value represented by the progress bar. This must be less than both <see cref="Value"/> and <see cref="MaxValue"/>.
        /// </summary>
        [Parameter]
        public double MinValue { get; set; }

        /// <summary>
        /// The maximum value represented by the progress bar. This must be greater than both <see cref="MinValue"/> and <see cref="Value"/>.
        /// </summary>
        [Parameter]
        public double MaxValue { get; set; }

        /// <summary>
        /// The current value represented by the progress bar. This must fall between <see cref="MinValue"/> and <see cref="MaxValue"/>.
        /// </summary>
        [Parameter]
        public double Value { get; set; }

        /// <summary>
        /// Set this to true if you want to show the percentage as text inside the bar.
        /// </summary>
        [Parameter]
        public bool ShowPercentage { get; set; }


        /// <summary>
        /// Returns the calculated width as an integer percentage value.
        /// </summary>
        protected string CalculatedWidth {
            get
            {
                return $"{Math.Round(Value / MaxValue, 2) * 100}%";
            }
        }

        /// <summary>
        /// </summary>
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

            // check and warn if contraints are busted
            if (MaxValue < MinValue)
            {
                this.LogWarningAsync($"MaxValue ({this.MaxValue}) must be greater than MinValue ({this.MinValue})", this);
            }
            
            if (Value > MaxValue || Value < MinValue)
            {
                this.LogWarningAsync($"Value ({this.Value}) must be greater than MinValue ({this.MinValue}) and less than MaxValue ({this.MaxValue})", this);
            }

            base.OnParametersSet();
        }
    }
}
