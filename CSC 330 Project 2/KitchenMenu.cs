using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_330_Project_2
{
    public partial class KitchenMenu : Form
    {
        private String item;
        private decimal itemCost;
        private Form previous;
        public KitchenMenu(Form form)
        {
            InitializeComponent();
            previous = form;
            //fill list with content
            String[] content = MainScreen.kitchen.getFoodKeys();//get all keys for list of foods
            foreach(String key in content)//add all keys to the menu
            {
                foodList.Items.Add(key);
            }
            content = null;//get all keys for list of drinks
            content = MainScreen.kitchen.getDrinkKeys();
            foreach (String key in content)//add all keys to the menu
            {
                drinkList.Items.Add(key);
            }
        }

        private void KitchenMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = foodList.SelectedItem.ToString();
            itemCost = MainScreen.kitchen.foodAt(item);
            itemName.Text = item;
            itemPrice.Text = itemCost.ToString();
            drinkList.SelectedItem = null;
        }

        private void drinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = drinkList.SelectedItem.ToString();
            itemCost = MainScreen.kitchen.drinkAt(item);
            itemName.Text = item;
            itemPrice.Text = itemCost.ToString();
            foodList.SelectedItem = null;
        }
    }
}
