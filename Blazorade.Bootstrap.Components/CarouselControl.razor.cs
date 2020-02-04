using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CarouselControl
    {
        public CarouselControl()
        {
            this.Direction = CarouselControlDirection.Next;
        }

        [Parameter]
        public override RenderFragment ChildContent { get => base.ChildContent; set => throw new NotSupportedException("This control does not support child content."); }

        /// <summary>
        /// A reference to the carousel the control belongs to.
        /// </summary>
        [Parameter]
        public Carousel Carousel { get; set; }


        [Parameter]
        public CarouselControlDirection Direction { get; set; }


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
