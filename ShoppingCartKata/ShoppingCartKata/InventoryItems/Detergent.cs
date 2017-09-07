using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Detergent : IInventory
    {
        private const string name = "Detergent";
        private const double price = 3.00;
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
