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
    class DetergentTests
    {
        private Detergent detergent;
        private double delta = 0.001;

        [SetUp]
        public void SetUp()
        {
            detergent = new Detergent();
        }

        [Test]
        public void GetNameReturnsDetergent()
        {
            Assert.AreEqual("Detergent", detergent.GetName());
        }

        [Test]
        public void GetPriceReturns3Dollars()
        {
            Assert.AreEqual(3.00, detergent.GetPrice(), delta);
        }

        
    }
}
