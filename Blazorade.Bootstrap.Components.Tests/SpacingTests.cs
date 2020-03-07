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

            var div1 = new Div { Margin = m1 };
            var div2 = new Div { Margin = m2 };
            var div3 = new Div { Margin = m3 };

            Assert.AreEqual(m1, div1.Margin);
            Assert.AreEqual(m1, div2.Margin);
            Assert.AreEqual(m1, div3.Margin);
        }


        [TestMethod]
        public void Spacing01()
        {
            Spacing s1 = -5;
            Spacing s2 = "-5";

            Assert.AreEqual(s1, s2);
            Assert.IsTrue(s1.IsNegative);
            Assert.AreEqual("n5", s1.Value);
        }

        [TestMethod]
        public void Spacing02()
        {
            Spacing s1 = "auto";
            Assert.IsTrue(s1.IsAuto);

            Spacing s2 = "a";
            Assert.AreEqual(s1, s2);
        }
    }
}
