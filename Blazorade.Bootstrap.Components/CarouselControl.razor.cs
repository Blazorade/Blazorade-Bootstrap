using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Supports the <see cref="Components.Carousel"/> component and displays controls to move back and forward through slides.
    /// </summary>
    public partial class CarouselControl
    {
        /// <summary>
        /// </summary>
        public CarouselControl()
        {
            this.Direction = CarouselControlDirection.Next;
        }

        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public override RenderFragment ChildContent { get => base.ChildContent; set => throw new NotSupportedException("This control does not support child content."); }

        /// <summary>
        /// A reference to the carousel the control belongs to.
        /// </summary>
        [Parameter]
        public Carousel Carousel { get; set; }

        /// <summary>
        /// Specifies the direction in which the control moves the slides.
        /// </summary>
        [Parameter]
        public CarouselControlDirection Direction { get; set; }


        /// <summary>
        /// </summary>
        protected override void OnParametersSet()
        {
            this.AddAttribute("href", $"#{this.Carousel.Id}");

            if(this.Direction == CarouselControlDirection.Next)
            {
                this.AddClasses(ClassNames.Carousels.ControlNext);
                this.AddAttribute("data-slide", "next");
            }
            else
            {
                this.AddClasses(ClassNames.Carousels.ControlPrevious);
                this.AddAttribute("data-slide", "prev");
            }

            base.OnParametersSet();
        }

    }
}
