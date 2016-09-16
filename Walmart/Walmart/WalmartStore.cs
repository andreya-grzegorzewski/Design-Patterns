using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Walmart
{
    public class WalmartStore // This is the facade in the facade pattern
    {
        private ConcreteFactory cf;
        private Inventory i;
        private Finances f;
        
        List<Product> products = new List<Product>();

        public WalmartStore(ConcreteFactory factory, Inventory inventory, Finances finances)
        {
            cf = factory;
            i = inventory;
            f = finances;
        }

        public string[] restockStore()
        {
            // We have to keep track of money this time
            double moneyToSpend = f.getMoney();
            string[] productsAndCosts = new string[50]; // Only buy up to 25 things at once
            
            for (int index = 0; index < 50; index += 2)
            {
                // Make a product of the least common category
                Product thing = cf.factoryMethod(i.getLeastCommonCategory());

                // If we can afford it...
                if (thing.getPrice() < moneyToSpend)
                {
                    // Buy the product and add it to the list
                    products.Add(thing);
                    f.buy(thing.getPrice());
                    moneyToSpend -= thing.getPrice();
                    i.addProduct(thing.getID());

                    // And document it
                    productsAndCosts[index] = thing.getDescription();
                    productsAndCosts[index + 1] = thing.getSalePrice().ToString();
                    
                    // Then wait so the random number generator will come up with a new product next time
                    Thread.Sleep(15);
                }
                else break; // If we're broke, break
            }
            return productsAndCosts;
        }

        // Used only once at the beginning of the program to get some products in the store
        // Therefore we don't actually need to buy anything, and the finances variable isn't used.
        public string[] initializeStore()
        {
            string[] productsAndCosts = new string[50]; // Only buy up to 25 things at once

            for (int index = 0; index < 50; index += 2)
            {
                // Create a product
                Product thing = cf.factoryMethod(-1);

                // Account for the product
                products.Add(thing);
                i.addProduct(thing.getID());

                // Even indices are descriptions of products; odd indices are costs
                productsAndCosts[index] = thing.getDescription();
                productsAndCosts[index + 1] = thing.getSalePrice().ToString();
                
                Thread.Sleep(15); // So the random number generator used in the ConcreteProduct constructor generates different numbers every time
            }
            return productsAndCosts;
        }

        // Sells a product
        public void sellToUser(int index)
        {
            Product thing = products[index];

            f.recordSale(thing.getSalePrice());
            i.removeProduct(thing.getID());

            products.Remove(thing);
        }
    }
}
