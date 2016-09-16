using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{
    public class Finances // This is a subsystem in the facade pattern
    {
        double money = 250.00;  // Start with $250 in the bank

        // Gets the amount of money that the store can safely spend on new products
        public double getMoney()
        {
            return money;
        }

        // Updates the store's money when it purchases new products
        public void buy(double cost)
        {
            money -= cost;
        }

        // Updates the store's money when it makes a sale
        public void recordSale(double saleAmt)
        {
            money += saleAmt;
        }
    }
}
