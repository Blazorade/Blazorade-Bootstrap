using Blazorade.Bootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    /// <summary>
    /// Represents the body of a <see cref="Card"/> component.
    /// </summary>
    /// <remarks>
    /// The <see cref="CardBody"/> encapsulates the <see cref="Title"/>, <see cref="Subtitle"/>, <see cref="Text"/> and <see cref="Links"/>
    /// shown in a <see cref="Card"/> component.
    /// </remarks>
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

        /// <summary>
        /// The title to show in the body of the Card.
        /// </summary>
        [Parameter]
        public string Title { get; set; }

        /// <summary>
        /// Allows you to customize how the title is rendered. The context parameter is the text specified in <see cref="Title"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> TitleTemplate { get; set; }

        /// <summary>
        /// A subtitle to render with the <see cref="Title"/>.
        /// </summary>
        [Parameter]
        public string Subtitle { get; set; }

        /// <summary>
        /// Allows you to customize how the subtitle is rendered. The context parameter is the text specified in <see cref="Subtitle"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> SubtitleTemplate { get; set; }

        /// <summary>
        /// The text to display in the body of the Card.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// Allows you to customize how the text is displayed. The context parameter is the text specified in <see cref="Text"/>.
        /// </summary>
        [Parameter]
        public RenderFragment<string> TextTemplate { get; set; }

        /// <summary>
        /// Specifies whether the card body will be overlayed over the image in the card.
        /// </summary>
        [Parameter]
        public bool IsImageOverlay { get; set; }

        private Card _Parent;
        /// <summary>
        /// The parent <see cref="Card"/> for the CardBody component.
        /// </summary>
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


        /// <summary>
        /// 
        /// </summary>
        protected override void OnParametersSet()
        {
            if (!this.IsImageOverlay)
            {
                this.AddClasses(ClassNames.Cards.Body);
            }
            else
            {
                this.AddClasses(ClassNames.Cards.ImageOverlay);
            }

            base.OnParametersSet();
        }

    }
}
