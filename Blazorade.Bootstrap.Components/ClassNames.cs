using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public static class ClassNames
    {

        /// <summary>
        /// A generic active class name.
        /// </summary>
        public const string Active = "active";

        public const string Disabled = "disabled";

        public const string Fade = "fade";

        public const string Show = "show";

        public const string Hide = "hide";

        public const string DisplayNone = "d-none";



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

            public const string Large = "btn-group-lg";

            public const string Small = "btn-group-sm";
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

            public const string Fade = "carousel-fade";

            public const string Inner = "carousel-inner";

            public const string Item = "carousel-item";

            public const string Indicators = "carousel-indicators";

            public const string ControlNext = "carousel-control-next";

            public const string ControlPrevious = "carousel-control-prev";

        }

        public static class Collapses
        {
            public const string Collapse = "collapse";
        }

        public static class Cols
        {
            public const string Col = "col";
        }

        public static class Containers
        {
            public const string FixedWidth = "container";
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

        public static class Embeds
        {
            public const string Embed = "embed-responsive";

            public const string Item = "embed-responsive-item";

            public const string Ratio21by9 = "embed-responsive-21by9";

            public const string Ratio16by9 = "embed-responsive-16by9";

            public const string Ratio4by3 = "embed-responsive-4by3";

            public const string Ratio1by1 = "embed-responsive-1by1";

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

        /// <summary>
        /// Class name constants for <see cref="InputGroup"/> component.
        /// </summary>
        public static class InputGroups
        {
            /// <summary>
            /// The class name used on all input groups.
            /// </summary>
            public const string InputGroup = "input-group";

            /// <summary>
            /// The class name to add to small input groups.
            /// </summary>
            public const string Small = "input-group-sm";

            /// <summary>
            /// The class name to add to large input groups.
            /// </summary>
            public const string Large = "input-group-lg";

            /// <summary>
            /// The class name for appended addons.
            /// </summary>
            public const string Append = "input-group-append";

            /// <summary>
            /// The class name for prepended addons.
            /// </summary>
            public const string Prepend = "input-group-prepend";

            /// <summary>
            /// The class name for text addons.
            /// </summary>
            public const string Text = "input-group-text";

        }

        public static class Jumbotrons
        {
            public const string Jumbotron = "jumbotron";
            public const string Lead = "lead";
            public const string Fluid = "jumbotron-fluid";
        }

        public static class Links
        {
            /// <summary>
            /// Defines the link as a stretched link.
            /// </summary>
            public const string Stretched = "stretched-link";
        }

        public static class ListGroups
        {
            public const string ListGroup = "list-group";
            public const string Horizontal = "list-group-horizontal";
            public const string Flush = "list-group-flush";
            public const string Item = "list-group-item";
            public const string Action = "list-group-item-action";
        }

        public static class Lists
        {
        }

        public static class MediaObjects
        {
            public const string Media = "media";
            public const string Body = "media-body";
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

        public static class Navs
        {
            public const string AlignContentCenter = "justify-content-center";

            public const string AlignContentRight = "justify-content-end";

            public const string Link = "nav-link";

            public const string Nav = "nav";
        }

        public static class Paginations
        {
            /// <summary>
            /// Add this class to mark an element as the container of page items
            /// </summary>
            public const string Pagination = "pagination";

            /// <summary>
            /// Add this class to mark an element as a page item, for use inside of a pagination element.
            /// </summary>
            public const string Item = "page-item";

            /// <summary>
            /// Add this class to an element inside of a page item to mark it as a link to another page in the pagination.
            /// </summary>
            public const string Link = "page-link";

            /// <summary>
            /// Add this class to a pagination element to make it large.
            /// </summary>
            public const string Large = "pagination-lg";

            /// <summary>
            /// Add this class to a pagination element to make it small.
            /// </summary>
            public const string Small = "pagination-sm";
        }

        public static class Paragraphs
        {
            /// <summary>
            /// Add this class to a <c>&ltp /&gt;</c> element to make it stand out more, like a lead paragrahp.
            /// </summary>
            public const string Lead = "lead";
        }

        public static class ProgressBars
        {
            /// <summary>
            /// Add this class mark an element as the outer "shell" of a progress bar.
            /// </summary>
            public const string Progress = "progress";

            /// <summary>
            /// Add this class to turn an element into a progress bar. Must be inside of a "progress" element.
            /// </summary>
            public const string ProgressBar = "progress-bar";

            /// <summary>
            /// Add this class to make a progress bar striped.
            /// </summary>
            public const string Striped = "progress-bar-striped";


            /// <summary>
            /// Add this class to animate the stripes (don't forget to add the "Striped" class!) from right to left.
            /// </summary>
            public const string Animated = "progress-bar-animated";
        }

        public static class Position
        {
            public const string Relative = "position-relative";
        }

        public static class Rows
        {
            public const string Row = "row";
            public const string NoGutters = "no-gutters";
        }

        public static class Shadows
        {
            public const string None = "shadow-none";

            public const string Small = "shadow-sm";

            public const string Regular = "shadow";

            public const string Large = "shadow-lg";
        }

        public static class Spinners
        {
            public const string Spinner = "spinner";
        }

        public static class Toasts
        {
            public const string Body = "toast-body";

            public const string Header = "toast-header";

            public const string Toast = "toast";
        }
    }
}
