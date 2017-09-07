using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Chips : IInventory
    {
        private const string name = "Chips";
        private const double price = 0.75;
        private const int numberForDiscount = 1;
        private const double discountPrice = .75;
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
