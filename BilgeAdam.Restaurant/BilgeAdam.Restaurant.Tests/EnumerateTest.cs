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
            var c = Client.CreateClient("Can PERK", "505 428 2970");
            Assert.IsTrue(c.Id == 1);
        }
        [TestMethod]
        [Priority(1)]
        public void SecondClientHasIdAs2()
        {
            var c = Client.CreateClient("Can PERK", "543 872-9834");
            Assert.IsTrue(c.Id == 2);
        }
        [TestMethod]
        [Priority(2)]
        public void FirstTableHasIdAs3()
        {
            var c = new Table();
            Assert.IsTrue(c.Id == 3);
        }

        [TestMethod]
        [Priority(3)]
        public void StringParamsWasConvertedToClientObject()
        {
            var otherClient = Client.CreateClient("Mazlum İLHANLI", "5057348209");
            Assert.IsTrue(otherClient.FullName == "Mazlum İLHANLI");

            var c2 = Client.CreateClient("Can PERK", "5054282970");
        }
    }
}