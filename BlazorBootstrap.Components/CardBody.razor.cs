using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class CardBody
    {

        /// <summary>
        /// A collection of links to show in the card.
        /// </summary>
        [Parameter]
        public IEnumerable<ILink> Links { get; set; }

        /// <summary>
        /// The template to use for each link.
        /// </summary>
        /// <remarks>
        /// If not specified, a default template is used.
        /// </remarks>
        [Parameter]
        public RenderFragment<ILink> LinkTemplate { get; set; }

        /// <summary>
        /// A template that allows you to completely customize the links section of a card.
        /// </summary>
        /// <remarks>
        /// If not specified, a default template is used.
        /// </remarks>
        [Parameter]
        public RenderFragment<IEnumerable<ILink>> LinkSectionTemplate { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment<string> TitleTemplate { get; set; }

        [Parameter]
        public string Subtitle { get; set; }

        [Parameter]
        public RenderFragment<string> SubtitleTemplate { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public RenderFragment<string> TextTemplate { get; set; }

        /// <summary>
        /// Specifies whether the card body will be overlayed over the image in the card.
        /// </summary>
        [Parameter]
        public bool IsImageOverlay { get; set; }

        private Card _Parent;
        [Parameter]
        public Card Parent
        {
            get { return _Parent; }
            set
            {
                _Parent = value;
                this.Title = _Parent?.Title;
                this.TitleTemplate = _Parent?.TitleTemplate;
                this.Subtitle = _Parent?.Subtitle;
                this.SubtitleTemplate = _Parent.SubtitleTemplate;
                this.Text = _Parent?.Text;
                this.TextTemplate = _Parent?.TextTemplate;
                this.Links = _Parent?.Links;
                this.LinkTemplate = _Parent?.LinkTemplate;
                this.LinkSectionTemplate = _Parent?.LinkSectionTemplate;

                this.IsImageOverlay = _Parent?.ImagePosition == CardImagePosition.Overlay;

                this.ChildContent = _Parent?.ChildContent;
            }
        }


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
