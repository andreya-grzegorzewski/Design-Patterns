using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart
{
    public partial class WalmartForm : Form
    {
        // Variables for subsystems and Walmart Store
        ConcreteFactory factory;
        Inventory inventory;
        Finances finances;
        WalmartStore wm;

        public WalmartForm()
        {
            InitializeComponent();

            // Sets up WalmartStore class
            factory = new ConcreteFactory();
            inventory = new Inventory();
            finances = new Finances();
            wm = new WalmartStore(factory, inventory, finances);


            // Displays the 25 products currently in the inventory
            string[] productsAndCosts = wm.initializeStore();
            
            for (int i = 0; i < productsAndCosts.Length; i += 2)
            {
                productsLB.Items.Add(productsAndCosts[i]);
                costsLB.Items.Add(productsAndCosts[i + 1]);
            }
        }

        // Shows a new product in the list boxes
        public void addProduct(Product thing)
        {
            productsLB.Items.Add(thing.getDescription());
            costsLB.Items.Add(thing.getSalePrice());
        }

        // Lets the user buy a product
        private void buyButton_Click(object sender, EventArgs e)
        {
            int index = productsLB.SelectedIndex;

            // Makes sure something is selected
            if (index == -1)
                MessageBox.Show("Choose what you'd like to buy!");

            else
            {
                // Updates the money label
                int money = Convert.ToInt32(moneyLabel.Text);
                money += Convert.ToInt32(costsLB.Items[index]);
                updateMoney(money);

                // Removes the product from the list boxes and sells the product
                productsLB.Items.RemoveAt(index);
                costsLB.Items.RemoveAt(index);
                wm.sellToUser(index);
            }
        }

        // Makes new products available for purchase
        private void restockButton_Click(object sender, EventArgs e)
        {
            string[] productsAndCosts = wm.restockStore();
            int money = Convert.ToInt32(moneyLabel.Text);

            // Makes sure there is something to put in the store
            if (productsAndCosts[0] == null)
                MessageBox.Show("There isn't enough money in the bank to restock!");

            else
            {
                for (int i = 0; i < productsAndCosts.Length; i += 2)
                {
                    // Makes sure there is an item to stock
                    if (productsAndCosts[i] == null)
                        break;

                    // Adds the item and updates the money count
                    productsLB.Items.Add(productsAndCosts[i]);
                    costsLB.Items.Add(productsAndCosts[i + 1]);
                    money -= (Convert.ToInt32(productsAndCosts[i + 1]) / 2);
                }
            }
            updateMoney(money); // Displays the money
        }

        private void updateMoney(int money)
        {
            moneyLabel.Text = money.ToString();
        }
    }
}
