using System;
using BilgeAdam.Restaurant.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilgeAdam.Restaurant.Tests
{
    [TestClass]
    public class EnumerateTest
    {
        [TestMethod]
        [Priority(0)]
        public void FirstClientHasIdAs1()
        {
            var c = new Client();
            Assert.IsTrue(c.Id == 1);
        }
        [TestMethod]
        [Priority(1)]
        public void SecondClientHasIdAs2()
        {
            var c = new Client();
            Assert.IsTrue(c.Id == 2);
        }
        [TestMethod]
        [Priority(2)]
        public void FirstTableHasIdAs3()
        {
            var c = new Table();
            Assert.IsTrue(c.Id == 3);
        }
    }
}
