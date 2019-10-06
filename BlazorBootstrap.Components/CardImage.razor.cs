﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardImageBase : ImageBase
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
