using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardBase : BootstrapComponentBase
    {

        [Parameter]
        public ComponentColor? Background { get; set; }

        [Parameter]
        public ComponentColor? Border { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Subtitle { get; set; }

        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// A collection of tuples specifying links to show in the card. The first item of each tuple is the link text, and the second item is the URL (href) of the link.
        /// </summary>
        [Parameter]
        public IEnumerable<Tuple<string, string>> Links { get; set; }



        protected bool HasBodyElements()
        {
            return !string.IsNullOrEmpty(this.Title)
                || !string.IsNullOrEmpty(this.Subtitle)
                || !string.IsNullOrEmpty(this.Text)
                || this.Links?.Count() > 0
                ;
        }

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Card);
            this.AddClass(this.GetColorClassName(prefix: "bg", color: this.Background));
            this.AddClass(this.GetColorClassName(prefix: "border", color: this.Border));

            base.OnParametersSet();
        }


    }
}
