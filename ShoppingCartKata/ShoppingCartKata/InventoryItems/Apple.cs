using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Apple : IInventory
    {

        public string GetName()
        {
            return "Apple";
        }

        public double GetPrice()
        {
            return 0.50;
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
