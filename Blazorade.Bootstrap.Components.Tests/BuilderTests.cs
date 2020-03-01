using Blazorade.Bootstrap.Components.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Blazorade.Bootstrap.Components.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void Grid01()
        {
            var classes = new ColumnClassBuilder()
                .Col().OnAll()
                .Build().ToList();

            this.AssertClasses(classes, 1, "col");
        }

        [TestMethod]
        public void Grid02()
        {
            var classes = new ColumnClassBuilder()
                .Col(12).OnSm()
                .Col().OnSm()
                .Build().ToList();

            this.AssertClasses(classes, 2, "col-sm-12", "col-sm");
        }

        [TestMethod]
        public void Grid03()
        {
            var classes = new ColumnClassBuilder()
                .Col(8).OnMd()
                .Build().ToList();

            this.AssertClasses(classes, 1, "col-md-8");
        }

        [TestMethod]
        public void Grid04()
        {
            var classes = new ColumnClassBuilder()
                .Col().OnAll()
                .OrderFirst().OnSm()
                .OrderLast().OnXl()

                .Build().ToList();

            this.AssertClasses(classes, 3, "col", "order-sm-first", "order-xl-last");
        }

        [TestMethod]
        public void Grid05()
        {
            var classes = new ColumnClassBuilder()
                .Col(6).OrderFirst()
                .OnSm()
                .Build().ToList();

            this.AssertClasses(classes, 2, "col-sm-6", "order-sm-first");
        }

        [TestMethod]
        public void Grid06()
        {
            var classes = new ColumnClassBuilder()
                .Col(8).Order(3).OnAll()
                .ColAuto().OnMd()
                .ToList();

            this.AssertClasses(classes, 3, "col-8", "order-3", "col-md-auto");
        }

        [TestMethod]
        public void Grid07()
        {
            var classes = new ColumnClassBuilder()
                .Col().AlignStart().OnSm()
                .Col().AlignCenter().OnMd()
                .Col().AlignEnd().OnLg()
                .ToList();

            this.AssertClasses(classes, 6, "col-sm", "align-self-sm-start", "col-md", "align-self-md-center", "col-lg", "align-self-lg-end");
        }

        [TestMethod]
        public void Grid08()
        {
            var classes = new ColumnClassBuilder()
                .Col().Offset(4).OnAll()
                .Col().Offset(8).OnXl()
                .ToList();

            this.AssertClasses(classes, 4, "col", "offset-4", "col-xl", "offset-xl-8");
        }



        [TestMethod]
        public void Display01()
        {
            var classes = new ComponentClassBuilder()
                .DisplayBlock().OnAll()
                .DisplayInline().OnSm()
                .ToList();

            this.AssertClasses(classes, 2, "d-block", "d-sm-inline");
        }



        [TestMethod]
        public void Border01()
        {
            var classes = new ComponentClassBuilder()
                .Border()
                .Border0Top()
                .Border(NamedColor.Primary)
                .ToList();

            this.AssertClasses(classes, 3, "border", "border-top-0", "border-primary");
        }



        [TestMethod]
        public void Text01()
        {
            var classes = new ComponentClassBuilder()
                .Text(NamedColor.White50)
                .Build();

            this.AssertClasses(classes, 1, "text-white-50");
        }



        private void AssertClasses(IEnumerable<string> classes, int? expectedCount, params string[] expectedClasses)
        {
            Assert.IsNotNull(classes);

            if (expectedCount.HasValue)
            {
                Assert.AreEqual(expectedCount.Value, classes.Count());
            }

            if(null != expectedClasses)
            {
                foreach(var cls in expectedClasses)
                {
                    Assert.IsTrue(classes.Contains(cls));
                }
            }
        }
    }
}
