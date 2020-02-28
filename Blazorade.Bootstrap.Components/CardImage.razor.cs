using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Renders an image in a <see cref="Card"/> component.
    /// </summary>
    public partial class CardImage
    {

        /// <summary>
        /// Specifies whether the card is an overlay image, i.e. the contents of the card are
        /// overlaid ver the image.
        /// </summary>
        [Parameter]
        public bool IsOverlay { get; set; }



        /// <summary>
        /// </summary>
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
