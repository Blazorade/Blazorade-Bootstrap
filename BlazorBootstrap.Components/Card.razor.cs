using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBootstrap.Components
{
    public abstract class CardBase : BootstrapComponentBase
    {

        /// <summary>
        /// Allows you to completely control the contents of the card.
        /// </summary>
        /// <remarks>
        /// If you use this template, all other parameters will be ignored, and only the template you provide will be rendered.
        /// </remarks>
        [Parameter]
        public override RenderFragment ChildContent { get => base.ChildContent; set => base.ChildContent = value; }

        /// <summary>
        /// The title for the card.
        /// </summary>
        [Parameter]
        public string Title { get; set; }

        /// <summary>
        /// The template to use for the title.
        /// </summary>
        /// <remarks>
        /// <see cref="Title"/> is ignored if a template is specified in this parameter.
        /// </remarks>
        [Parameter]
        public RenderFragment TitleTemplate { get; set; }

        /// <summary>
        /// The subtitle of the card.
        /// </summary>
        [Parameter]
        public string Subtitle { get; set; }

        /// <summary>
        /// The template to use for the subtitle.
        /// </summary>
        /// <remarks>
        /// This will override <see cref="Subtitle"/>
        /// </remarks>
        [Parameter]
        public RenderFragment SubtitleTemplate { get; set; }


        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Card);

            base.OnParametersSet();
        }


    }
}
