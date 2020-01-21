using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public partial class CardImage
    {


        [Parameter]
        public bool IsOverlay { get; set; }



        protected override void OnParametersSet()
        {
            if (!this.IsOverlay)
            {
                this.AddClass(ClassNames.Cards.Image);
            }
            else
            {
                this.AddClass(ClassNames.Cards.OverlayImage);
            }

            base.OnParametersSet();
        }

    }
}
