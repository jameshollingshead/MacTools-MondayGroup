using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Apple : IInventory
    {
        private const string name = "Apple";
        private const double price = 0.50;
        private const int numberForDiscount = 3;
        private const double discountPrice = 1.20;

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetNumberForDiscount()
        {
            return numberForDiscount;
        }

        public double GetDiscountPrice()
        {
            return discountPrice;
        }
    }
}
