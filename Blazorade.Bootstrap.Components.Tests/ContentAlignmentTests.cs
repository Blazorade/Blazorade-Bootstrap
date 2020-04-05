using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Tests
{
    [TestClass]
    public class ContentAlignmentTests
    {

        [TestMethod]
        public void Equals01()
        {
            var ca1 = HorizontalAlignment.Center;
            var ca2 = HorizontalAlignment.Center;
            Assert.AreEqual(ca1, ca2);
            Assert.IsTrue(ca1 == ca2);
        }

        [TestMethod]
        public void Equals02()
        {
            HorizontalAlignment? ca1 = null;
            HorizontalAlignment ca2 = HorizontalAlignment.Left;

            Assert.AreNotEqual(ca2, ca1);
        }

        [TestMethod]
        public void Equals03()
        {
            HorizontalAlignment? ca1 = HorizontalAlignment.Right;
            HorizontalAlignment ca2 = HorizontalAlignment.Right;

            Assert.AreEqual(ca1, ca2);
        }
    }
}
