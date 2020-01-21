using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Model
{

    public interface IMenuItem : ILink
    {
        IEnumerable<IMenuItem> Children { get; set; }
    }

    public class MenuItem : Link, IMenuItem
    {
        public IEnumerable<IMenuItem> Children { get; set; }
    }
}
