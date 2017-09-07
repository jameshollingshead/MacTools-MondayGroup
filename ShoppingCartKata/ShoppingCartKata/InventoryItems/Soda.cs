using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Soda : IInventory
    {
        private const string name = "Soda";
        private const double price = 1.00;
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
            throw new NotImplementedException();
        }

        public double GetDiscountPrice()
        {
            throw new NotImplementedException();
        }
    }
}
