using Blazorade.Bootstrap.Components.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazorade.Bootstrap.Components.Tests
{
    [TestClass]
    public class HeadingTests
    {

        [TestMethod]
        public void Level01()
        {
            Assert.AreEqual(1, HeadingLevel.H1.Value);
            Assert.AreEqual(2, HeadingLevel.H2.Value);
            Assert.AreEqual(3, HeadingLevel.H3.Value);
            Assert.AreEqual(4, HeadingLevel.H4.Value);
            Assert.AreEqual(5, HeadingLevel.H5.Value);
            Assert.AreEqual(6, HeadingLevel.H6.Value);
        }

        [TestMethod]
        public void Level02()
        {
            Assert.AreEqual(1, HeadingLevel.H1);
            Assert.AreEqual(2, HeadingLevel.H2);
            Assert.AreEqual(3, HeadingLevel.H3);
            Assert.AreEqual(4, HeadingLevel.H4);
            Assert.AreEqual(5, HeadingLevel.H5);
            Assert.AreEqual(6, HeadingLevel.H6);
        }

        [TestMethod]
        public void Level03()
        {
            Assert.AreEqual("1", HeadingLevel.H1);
            Assert.AreEqual("2", HeadingLevel.H2);
            Assert.AreEqual("3", HeadingLevel.H3);
            Assert.AreEqual("4", HeadingLevel.H4);
            Assert.AreEqual("5", HeadingLevel.H5);
            Assert.AreEqual("6", HeadingLevel.H6);
        }

        [TestMethod]
        public void Level04()
        {
            Assert.AreEqual("h1", HeadingLevel.H1);
            Assert.AreEqual("h2", HeadingLevel.H2);
            Assert.AreEqual("h3", HeadingLevel.H3);
            Assert.AreEqual("h4", HeadingLevel.H4);
            Assert.AreEqual("h5", HeadingLevel.H5);
            Assert.AreEqual("h6", HeadingLevel.H6);
        }

        [TestMethod]
        public void Level05()
        {
            Assert.AreEqual("H1", HeadingLevel.H1);
            Assert.AreEqual("H2", HeadingLevel.H2);
            Assert.AreEqual("H3", HeadingLevel.H3);
            Assert.AreEqual("H4", HeadingLevel.H4);
            Assert.AreEqual("H5", HeadingLevel.H5);
            Assert.AreEqual("H6", HeadingLevel.H6);
        }

    }
}
