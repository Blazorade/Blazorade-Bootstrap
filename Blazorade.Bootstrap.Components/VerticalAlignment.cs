using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components
{
    public struct VerticalAlignment
    {

        internal VerticalAlignment(string value)
        {
            this.Value = value;
        }

        public static implicit operator VerticalAlignment(string s)
        {
            return new VerticalAlignment(s);
        }

        public static bool operator ==(VerticalAlignment x, VerticalAlignment y)
        {
            return x.Value == y.Value;
        }

        public static bool operator !=(VerticalAlignment x, VerticalAlignment y)
        {
            return x.Value != y.Value;
        }

        internal const string TopValue = "top";
        internal const string MiddleValue = "middle";
        internal const string BottomValue = "bottom";


        public static VerticalAlignment Top
        {
            get { return TopValue; }
        }

        public static VerticalAlignment Middle
        {
            get { return MiddleValue; }
        }

        public static VerticalAlignment Bottom
        {
            get { return BottomValue; }
        }
        

        public string Value { get; set; }

    }
}
