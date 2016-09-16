using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{
    public class Inventory // This is a subsystem in the facade pattern
    {
        private int[] categoryCount = new int[10]; // Keeps track of the number of products of each category

        // Adds a product to the inventory
        public void addProduct(int id)
        {
            categoryCount[id]++;
        }

        // Gets the id number of the category that has the least amount of products currently in the store
        public int getLeastCommonCategory()
        {
            int least = 0;
            for (int i = 1; i < 10; i++)
            {
                if (categoryCount[i] < categoryCount[least])
                    least = i;
            }
            return least;
        }

        // Removes a product from the inventory
        public void removeProduct(int id)
        {
            categoryCount[id]--;
        }
    }
}
