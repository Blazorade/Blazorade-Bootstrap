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
                this.AddClasses(ClassNames.Cards.Image);
            }
            else
            {
                this.AddClasses(ClassNames.Cards.OverlayImage);
            }

            base.OnParametersSet();
        }

    }
}
