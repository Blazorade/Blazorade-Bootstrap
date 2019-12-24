using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public static class JsNames
    {

        private const string Root = "blazorBootstrap.";

        public const string Hide = Root + "hide";

        public const string Show = Root + "show";


        public static class Alert
        {

            private const string AlertRoot = Root + "alerts.";

            public const string Dismiss = AlertRoot + "dismiss";

        }

        public static class Anchor
        {
            private const string AnchorRoot = Root + "anchors.";

            public const string Init = AnchorRoot + "init";

            public const string ScrollIntoView = AnchorRoot + "scrollIntoView";

        }

        public static class Carousel
        {
            private const string CarouselRoot = Root + "carousels.";

            public const string Init = CarouselRoot + "carousel";
        }

        public static class Modal
        {
            private const string ModalRoot = Root + "modals.";

            public const string Hide = ModalRoot + "hide";

            public const string Show = ModalRoot + "show";

            public const string Toggle = ModalRoot + "toggle";
        }
    }
}
