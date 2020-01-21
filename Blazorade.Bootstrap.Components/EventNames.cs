using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public static class EventNames
    {

        public static class Alert
        {
            public const string Close = "close.bs.alert";

            public const string Closed = "closed.bs.alert";
        }

        public static class Collapse
        {
            public const string Hide = "hide.bs.collapse";

            public const string Hidden = "hidden.bs.collapse";

            public const string Show = "show.bs.collapse";

            public const string Shown = "shown.bs.collapse";
        }

        public static class Toast
        {
            public const string Show = "show.bs.toast";

            public const string Shown = "shown.bs.toast";

            public const string Hide = "hide.bs.toast";

            public const string Hidden = "hidden.bs.toast";
        }
    }
}
