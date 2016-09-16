using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{

    public class ConcreteProduct : Product // This is the concrete product
    {
        private string category; // The type of product - i.e., shirt, chair, etc.
        private int id;          // numerical representation of the type of product
        private string color;
        private string material;
        private bool isDangerous = false;
        private int initPurchaseCost; // The amount of money that the Walmart Store can buy this product for

        private string[] categories = { "shirt", "shoes", "chair", "book", "blanket", "food", "gizmo", "gadget", "whatchamacallit", "lipstick" }; // potential types of product
        private string[] colors = { "black", "white", "gray", "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "chartreuse" }; // potential colors for each product
        private string[] materials = { "cotton", "silk", "wood", "canvas", "brass", "glass", "paper", "plastic", "potatoes", "12M sulfuric acid" }; // potential materials each product is made of

        public ConcreteProduct(int id)
        {
            Random rng = new Random();

            // If no valid ID is passed, we come up with a random ID
            if (id == -1)
                id = rng.Next(categories.Length);
            else
                this.id = id;

            // Assign the category appropriately, and pick a random color and material
            category = categories[id];
            color = colors[rng.Next(colors.Length)];
            material = materials[rng.Next(materials.Length)];

            // Assign danger value based on the type of product created.
            if (category == "food" || material == "12M sulfuric acid")
                isDangerous = true;

            else if (category == "gizmo" || category == "whatchamacallit" || category == "gadget")
            {
                int danger = rng.Next(2);
                if (danger == 1)
                    isDangerous = true;
            }

            // It's unlikely that other types of things are dangerous...
            else
            {
                int danger = rng.Next(100);
                if (danger >= 95)
                    isDangerous = true;
            }

            // Generate an initial cost between 5 and 15 dollars
            initPurchaseCost = rng.Next(5, 16);
        }

        // Gets the price that the product was purchased for originally
        double Product.getPrice()
        {
            return initPurchaseCost;
        }

        // Gets the description, including a warning if the product is dangerous
        string Product.getDescription()
        {
            string desc = color + " " + category + " made of " + material;
            if (isDangerous)
                return (desc + " - keep away from small children!");
            return desc;
        }

        // Gets the ID
        int Product.getID()
        {
            return id;
        }

        // Gets the price the product should be sold to customers for
        public double getSalePrice()
        {
            return (initPurchaseCost * 2);
        }
    }
}
