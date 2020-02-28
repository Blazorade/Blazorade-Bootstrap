using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// The Embed component is used to create responsive video or slideshow embeds.
    /// </summary>
    partial class Embed
    {
        /// <summary>
        /// </summary>
        public Embed()
        {
            this.AspectRatio = EmbedAspectRatio.Ratio16by9;
            this.IFrameAttributes = new Dictionary<string, object>();
        }

        /// <summary>
        /// Specifies different aspect ratios for the embedded content. The default is 16 by 9.
        /// </summary>
        [Parameter]
        public EmbedAspectRatio AspectRatio { get; set; }

        /// <summary>
        /// The source URL of the content to embed.
        /// </summary>
        [Parameter]
        public string Source { get; set; }


        private IDictionary<string, object> IFrameAttributes { get; set; }



        /// <summary>
        /// </summary>
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

            base.OnParametersSet();

        }

    }
}
