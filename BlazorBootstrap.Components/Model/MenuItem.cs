using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components.Model
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
