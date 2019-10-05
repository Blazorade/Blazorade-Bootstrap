using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardBodyBase : BootstrapComponentBase
    {

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Subtitle { get; set; }

        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// A collection of tuples specifying links to show in the card body. The first item of each tuple is the link text, and the second item is the URL (href) of the link.
        /// </summary>
        [Parameter]
        public IEnumerable<Tuple<string, string>> Links { get; set; }

        /// <summary>
        /// Specifies whether the card body will be overlayed over the image in the card.
        /// </summary>
        [Parameter]
        public bool IsImageOverlay { get; set; }



        protected override void OnParametersSet()
        {
            if (!this.IsImageOverlay)
            {
                this.AddClass(ClassNames.Cards.Body);
            }
            else
            {
                this.AddClass(ClassNames.Cards.ImageOverlay);
            }

            base.OnParametersSet();
        }

    }
}
