using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class Embed
    {

        [Parameter]
        public bool AllowFullscreen { get; set; }

        [Parameter]
        public EmbedAspectRatio? AspectRatio { get; set; }

        [Parameter]
        public string Source { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Embeds.Embed);

            if (this.AspectRatio.HasValue)
            {
                switch(this.AspectRatio.Value)
                {
                    case EmbedAspectRatio.Ratio21by9:
                        this.AddClass(ClassNames.Embeds.Ratio21by9);
                        break;

                    case EmbedAspectRatio.Ratio16by9:
                        this.AddClass(ClassNames.Embeds.Ratio16by9);
                        break;

                    case EmbedAspectRatio.Ratio4by3:
                        this.AddClass(ClassNames.Embeds.Ratio4by3);
                        break;

                    case EmbedAspectRatio.Ratio1by1:
                        this.AddClass(ClassNames.Embeds.Ratio1by1);
                        break;
                }
            }

            base.OnParametersSet();
        }
    }
}
