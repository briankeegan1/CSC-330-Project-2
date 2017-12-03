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
        bool clearingLists;
        private Form previous;
        public KitchenMenu(Form form)
        {
            InitializeComponent();
            previous = form;
            //fill list with content
            String[] content = MainScreen.kitchen.GetFoodKeys();//get all keys for list of foods
            foreach(String key in content)//add all keys to the menu
            {
                foodList.Items.Add(key);
            }
            content = null;//get all keys for list of drinks
            content = MainScreen.kitchen.GetDrinkKeys();
            foreach (String key in content)//add all keys to the menu
            {
                drinkList.Items.Add(key);
            }
            clearingLists = false;
        }

        private void KitchenMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            Application.Exit();
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clearingLists)//if lists are not being cleared, begin operations
            {
                item = foodList.SelectedItem.ToString();//store selected item
                itemCost = MainScreen.kitchen.FoodAt(item);//get dollar amount of selected item
                itemName.Text = item;//output name of item to label
                itemPrice.Text = itemCost.ToString();//output value of item to label
                clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                drinkList.ClearSelected();//clear selected items from other lists
                clearingLists = false;//set bool to indicate that we are done clearing the other lists
            }
        }

        private void drinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clearingLists)//if lists are not being cleared, begin operations
            {
                item = drinkList.SelectedItem.ToString();//store selected item
                itemCost = MainScreen.kitchen.DrinkAt(item);//get dollar amount of selected item
                itemName.Text = item;//output name of item to label
                itemPrice.Text = itemCost.ToString();//output value of item to label
                clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                foodList.ClearSelected();//clear selected items from other lists
                clearingLists = false;//set bool to indicate that we are done clearing the other lists
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            previous.Show();
        }
    }
}
