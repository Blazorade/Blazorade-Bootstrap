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
            var ca1 = ContentAlignment.Center;
            var ca2 = ContentAlignment.Center;
            Assert.AreEqual(ca1, ca2);
            Assert.IsTrue(ca1 == ca2);
        }

        [TestMethod]
        public void Equals02()
        {
            ContentAlignment? ca1 = null;
            ContentAlignment ca2 = ContentAlignment.Left;

            Assert.AreNotEqual(ca2, ca1);
        }

        [TestMethod]
        public void Equals03()
        {
            ContentAlignment? ca1 = ContentAlignment.Right;
            ContentAlignment ca2 = ContentAlignment.Right;

            Assert.AreEqual(ca1, ca2);
        }
    }
}
