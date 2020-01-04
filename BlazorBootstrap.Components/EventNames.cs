using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public static class EventNames
    {

        public static class Alert
        {
            public const string Close = "close.bs.alert";

            public const string Closed = "closed.bs.alert";
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
