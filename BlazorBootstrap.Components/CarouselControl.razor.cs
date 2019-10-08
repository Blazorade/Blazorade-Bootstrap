using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CarouselControlBase : BootstrapComponentBase
    {
        protected CarouselControlBase()
        {
            this.Direction = CarouselControlDirection.Next;
        }

        [Parameter]
        public override RenderFragment ChildContent { get => base.ChildContent; set => throw new NotSupportedException("This control does not support child content."); }


        [Parameter]
        public CarouselControlDirection Direction { get; set; }


        protected override void OnParametersSet()
        {
            if(this.Direction == CarouselControlDirection.Next)
            {
                this.AddClass(ClassNames.Carousels.ControlNext);
                this.AddAttribute("data-slide", "next");
            }
            else
            {
                this.AddClass(ClassNames.Carousels.ControlPrevious);
                this.AddAttribute("data-slide", "prev");
            }

            base.OnParametersSet();
        }

    }
}
