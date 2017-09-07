using System;
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
    class ChipsTest
    {
        private Chips chips;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            chips = new Chips();
        }

        [Test]
        public void GetNameReturnsChips()
        {
            Assert.AreEqual("Chips", chips.GetName());
        }

        [Test]
        public void GetPriceReturns75Cents()
        {
            Assert.AreEqual(0.75, chips.GetPrice(), delta);
        }

        [Test]
        public void GetDiscountNumberReturns1()
        {
            Assert.AreEqual(1, chips.GetNumberForDiscount());
        }

        [Test]
        public void DiscountPriceReturns75Cents()
        {
            Assert.AreEqual(0.75, chips.GetDiscountPrice(), delta);
        }
        
    }
}
