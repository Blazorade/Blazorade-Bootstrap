using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public static class JsFunctions
    {

        private const string Root = "blazoradeBootstrap.";

        public const string Hide = Root + "hide";

        public const string Show = Root + "show";

        public const string RegisterEventCallback = Root + "registerEventCallback";

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

            public const string Command = CarouselRoot + "command";

            public const string SlideCount = CarouselRoot + "slideCount";
        }

        public static class Collapse
        {
            private const string CollapseRoot = Root + "collapses.";

            public const string Hide = CollapseRoot + "hide";

            public const string Show = CollapseRoot + "show";

            public const string Toggle = CollapseRoot + "toggle";
        }

        public static class Console
        {
            private const string ConsoleRoot = Root + "console.";

            public const string Error = ConsoleRoot + "error";

            public const string Log = ConsoleRoot + "log";

            public const string Warn = ConsoleRoot + "warn";
        }

        public static class Modal
        {
            private const string ModalRoot = Root + "modals.";

            public const string Hide = ModalRoot + "hide";

            public const string Show = ModalRoot + "show";

            public const string Toggle = ModalRoot + "toggle";
        }

        public static class Toast
        {
            private const string ToastRoot = Root + "toasts.";

            public const string Init = ToastRoot + "init";

            public const string Show = ToastRoot + "show";

            public const string Hide = ToastRoot + "hide";
        }

        public static class Tooltip
        {
            private const string TooltipRoot = Root + "tooltips.";

            public const string Init = TooltipRoot + "init";
        }
    }
}
