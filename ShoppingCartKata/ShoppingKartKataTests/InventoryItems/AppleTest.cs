﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCartKata.InventoryItems;

namespace ShoppingCartKataTests.InventoryItems
{
    [TestFixture]
    class AppleTest
    {
        private Apple apple;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            apple = new Apple();
        }

        [Test]
        public void GetNameReturnsApple()
        {
            Assert.AreEqual("Apple", apple.GetName());

        }

        [Test]
        public void GetPriceReturns50Cents()
        {
            Assert.AreEqual(0.50, apple.GetPrice(), delta);
        }
    }
}
