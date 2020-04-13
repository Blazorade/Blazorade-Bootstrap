using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Blazorade.Bootstrap.Components.Tests
{
    [TestClass]
    public class SizingTests
    {

        [TestMethod]
        public void CreateSize01()
        {
            Size s = .75d;
            Assert.AreEqual("75%", s.ToString());
        }

        [TestMethod]
        public void CreateSize02()
        {
            Size s = 64d;
            Assert.AreEqual("64px", s.ToString());
        }

    }
}
