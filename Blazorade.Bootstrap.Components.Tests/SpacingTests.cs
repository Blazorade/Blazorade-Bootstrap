using Blazorade.Bootstrap.Components.Content;
using Blazorade.Bootstrap.Components.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Tests
{
    [TestClass]
    public class SpacingTests
    {

        [TestMethod]
        public void Margin01()
        {
            var m1 = Spacing.S1;
            var m2 = 1;
            var m3 = "1";
            var m4 = "S1";
            var m5 = "s1";

            var div1 = new Div { Margin = m1 };
            var div2 = new Div { Margin = m2 };
            var div3 = new Div { Margin = m3 };
            var div4 = new Div { Margin = m4 };
            var div5 = new Div { Margin = m5 };

            Assert.AreEqual(m1, div1.Margin);
            Assert.AreEqual(m1, div2.Margin);
            Assert.AreEqual(m1, div3.Margin);
            Assert.AreEqual(m1, div4.Margin);
            Assert.AreEqual(m1, div5.Margin);
        }
    }
}
