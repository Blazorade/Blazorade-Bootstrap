using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public static class ClassNames
    {

        /// <summary>
        /// A generic active class name.
        /// </summary>
        public const string Active = "active";

        public const string Collapse = "collapse";

        public const string Disabled = "disabled";

        public const string Fade = "fade";

        public static class Abbreviations
        {
            /// <summary>
            /// Gives a slightly smaller font size to an abbreviation.
            /// </summary>
            public const string Initialism = "initialism";

        }

        public static class Alerts
        {
            /// <summary>
            /// The default class for alerts.
            /// </summary>
            public const string Alert = "alert";

            /// <summary>
            /// Add this class to links inside of an Alert component.
            /// </summary>
            public const string AlertLink = "alert-link";

            /// <summary>
            /// Add this class to an alert along with the dismiss button.
            /// </summary>
            public const string Dismissible = "alert-dismissible";

            /// <summary>
            /// Use this class for headings inside of Alerts.
            /// </summary>
            public const string Heading = "alert-heading";

            /// <summary>
            /// Apply this class to links in Alerts.
            /// </summary>
            public const string Link = "alert-link";
        }

        public static class Alignments
        {
            /// <summary>
            /// Centers the text.
            /// </summary>
            public const string TextCenter = "text-center";

            /// <summary>
            /// Aligns text to the right.
            /// </summary>
            public const string TextRight = "text-right";
        }

        public static class Badges
        {
            /// <summary>
            /// The default class for badges.
            /// </summary>
            public const string Badge = "badge";

            /// <summary>
            /// Gives a badge a rounded look.
            /// </summary>
            public const string Pill = "badge-pill";
        }

        public static class BlockQuotes
        {
            /// <summary>
            /// A blockquote element.
            /// </summary>
            public const string Blockquote = "blockquote";

            /// <summary>
            /// A footer element inside of a blockquote element.
            /// </summary>
            public const string Footer = "blockquote-footer";
        }

        public static class Breadcrumbs
        {
            /// <summary>
            /// The default class for breadcrumbs.
            /// </summary>
            public const string Breadcrumb = "breadcrumb";

            /// <summary>
            /// The class name for breadcrumb items.
            /// </summary>
            public const string Item = "breadcrumb-item";
        }

        public static class Buttons
        {
            /// <summary>
            /// The default class for buttons.
            /// </summary>
            public const string Button = "btn";

            /// <summary>
            /// The class for outline buttons.
            /// </summary>
            public const string OutlineButton = "btn-outline";

            /// <summary>
            /// The class that styles the button as a link.
            /// </summary>
            public const string LinkButton = "btn-link";

            /// <summary>
            /// The class for close buttons.
            /// </summary>
            public const string Close = "close";

            /// <summary>
            /// The class for large buttons.
            /// </summary>
            public const string Large = "btn-lg";

            /// <summary>
            /// The class for small buttons.
            /// </summary>
            public const string Small = "btn-sm";

            /// <summary>
            /// The class for block-level buttons.
            /// </summary>
            public const string BlockLevel = "btn-block";
        }

        public static class ButtonGroups
        {
            public const string Group = "btn-group";
        }

        public static class ButtonToolbars
        {
            public const string Toolbar = "btn-toolbar";
        }

        public static class Cards
        {
            public const string Card = "card";

            public const string Header = "card-header";

            public const string Body = "card-body";

            public const string Title = "card-title";

            public const string Subtitle = "card-subtitle";

            public const string Text = "card-text";

            public const string Link = "card-link";

            public const string Image = "card-img-top";

            /// <summary>
            /// The class for an image in a card that is overlayed with the card body.
            /// </summary>
            public const string OverlayImage = "card-img";

            public const string Footer = "card-footer";

            /// <summary>
            /// The class for the card body that will be overlayed on top of an image in the card.
            /// </summary>
            public const string ImageOverlay = "card-img-overlay";
        }

        public static class CardGroups
        {
            public const string Group = "card-group";

            public const string Deck = "card-deck";

            public const string Columns = "card-columns";
        }

        public static class Carousels
        {
            public const string Carousel = "carousel slide";

            public const string Inner = "carousel-inner";

            public const string Item = "carousel-item";

            public const string Indicators = "carousel-indicators";

            public const string Control = "carousel-control";

            public const string ControlNext = "carousel-control-next";

            public const string ControlPrevious = "carousel-control-prev";

        }

        public static class Containers
        {
            public const string FixedWidth = "container";

            public const string Fluid = "container-fluid";
        }

        public static class Display
        {
            public const string Hidden = "d-none";
        }

        public static class Dropdowns
        {
            public const string Divider = "dropdown-divider";
            public const string Dropdown = "dropdown";
            public const string Item = "dropdown-item";
            public const string Menu = "dropdown-menu";
            public const string Toggle = "dropdown-toggle";
        }

        public static class Headings
        {
            /// <summary>
            /// Use on header to make it bigger than the default size. Display 1 is the biggest size.
            /// </summary>
            public const string Display1 = "display-1";

            /// <summary>
            /// Use on header to make it bigger than the default size. Display 2 is the second biggest size.
            /// </summary>
            public const string Display2 = "display-2";

            /// <summary>
            /// Use on header to make it bigger than the default size. Display 3 is the third biggest size.
            /// </summary>
            public const string Display3 = "display-3";

            /// <summary>
            /// Use on header to make it bigger than the default size. Display 4 is the fourth biggest size.
            /// </summary>
            public const string Display4 = "display-4";

            /// <summary>
            /// Heading 1
            /// </summary>
            public const string H1 = "h1";

            /// <summary>
            /// Heading 2
            /// </summary>
            public const string H2 = "h2";

            /// <summary>
            /// Heading 3
            /// </summary>
            public const string H3 = "h3";

            /// <summary>
            /// Heading 4
            /// </summary>
            public const string H4 = "h4";

            /// <summary>
            /// Heading 5
            /// </summary>
            public const string H5 = "h5";

            /// <summary>
            /// Heading 6
            /// </summary>
            public const string H6 = "h6";
        }

        public static class InlineText
        {

            /// <summary>
            /// Applies the same styling as <c>&lt;mark /&gt;</c>.
            /// </summary>
            public const string Mark = "mark";

            /// <summary>
            /// Applies the same styling as <c>&lt;small /&gt;</c>.
            /// </summary>
            public const string Small = "small";

            /// <summary>
            /// Gives the text a faded look.
            /// </summary>
            public const string TextMuted = "text-muted";
        }

        public static class Links
        {
            /// <summary>
            /// Defines the link as a stretched link.
            /// </summary>
            public const string Stretched = "stretched-link";
        }

        public static class Lists
        {

        }

        public static class Modals
        {
            public const string Body = "modal-body";
            public const string Content = "modal-content";
            public const string Dialog = "modal-dialog";
            public const string Footer = "modal-footer";
            public const string Header = "modal-header";
            public const string Modal = "modal";
            public const string Title = "modal-title";
        }

        public static class Navbars
        {
            public const string Navbar = "navbar";

            public const string Light = "navbar-light";

            public const string Dark = "navbar-dark";

            public const string Brand = "navbar-brand";

            public const string FixedTop = "fixed-top";

            public const string FixedBottom = "fixed-bottom";

            public const string StickyTop = "sticky-top";

            public const string Collapse = "navbar-collapse";

            public const string Nav = "navbar-nav";

            public const string NavItem = "nav-item";

            public const string NavLink = "nav-link";
        }

        public static class Paragraphs
        {
            /// <summary>
            /// Add this class to a <c>&ltp /&gt;</c> element to make it stand out more, like a lead paragrahp.
            /// </summary>
            public const string Lead = "lead";
        }

        public static class Position
        {
            public const string Relative = "position-relative";
        }

        public static class Shadows
        {
            public const string None = "shadow-none";

            public const string Small = "shadow-sm";

            public const string Regular = "shadow";

            public const string Large = "shadow-lg";
        }

    }
}
