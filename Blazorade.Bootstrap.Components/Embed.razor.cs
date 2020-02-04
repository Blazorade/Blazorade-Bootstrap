using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    partial class Embed
    {
        public Embed()
        {
            this.AspectRatio = EmbedAspectRatio.Ratio16by9;
            this.IFrameAttributes = new Dictionary<string, object>();
        }

        [Parameter]
        public bool AllowFullscreen { get; set; }

        [Parameter]
        public EmbedAspectRatio AspectRatio { get; set; }

        [Parameter]
        public string Source { get; set; }


        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        protected IDictionary<string, object> IFrameAttributes { get; private set; }


        protected override void OnParametersSet()
        {
            this.AddClasses(ClassNames.Embeds.Embed);

            switch (this.AspectRatio)
            {
                case EmbedAspectRatio.Ratio21by9:
                    this.AddClasses(ClassNames.Embeds.Ratio21by9);
                    break;

                case EmbedAspectRatio.Ratio16by9:
                    this.AddClasses(ClassNames.Embeds.Ratio16by9);
                    break;

                case EmbedAspectRatio.Ratio4by3:
                    this.AddClasses(ClassNames.Embeds.Ratio4by3);
                    break;

                case EmbedAspectRatio.Ratio1by1:
                    this.AddClasses(ClassNames.Embeds.Ratio1by1);
                    break;
            }

            this.IFrameAttributes.Add("class", ClassNames.Embeds.Item);
            this.IFrameAttributes.Add("src", this.Source);

            if (this.AllowFullscreen)
            {
                this.IFrameAttributes.Add("allowfullscreen", "allowfullscreen");
            }

            base.OnParametersSet();
        }

    }
}
