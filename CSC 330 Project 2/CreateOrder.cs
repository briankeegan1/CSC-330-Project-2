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
    public partial class CreateOrder : Form
    {
        private String guestName;
        private int roomNumber;
        private String item;
        private decimal itemCost;
        bool clearingLists;
        private Form previous;
        public CreateOrder(Form form)
        {
            InitializeComponent();
            previous = form;
            //fill list with content
            String[] content = MainScreen.kitchen.GetFoodKeys();//get all keys for list of foods
            foreach (String key in content)//add all keys to the menu
            {
                foodList.Items.Add(key);
            }
            content = null;//get all keys for list of drinks
            content = MainScreen.kitchen.GetDrinkKeys();
            foreach (String key in content)//add all keys to the menu
            {
                drinkList.Items.Add(key);
            }
            addOrder.Enabled = false;//disable controls to prevent orders with no customer information
            deleteOrder.Enabled = false;
            foodList.Enabled = false;
            drinkList.Enabled = false;
            sendKitchen.Enabled = false;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            currentOrderList.Items.Add(item);
            orderTotalUpdate();
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            clearingLists = true;
            currentOrderList.Items.RemoveAt(currentOrderList.SelectedIndex);
            clearingLists = false;
            orderTotalUpdate();
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!clearingLists)//if lists are not being cleared, begin operations
            {
                addOrder.Enabled = true;//enable add to order button if disabled
                deleteOrder.Enabled = false;//disable delete from order button if enabled
                item = foodList.SelectedItem.ToString();//store selected item
                itemCost = MainScreen.kitchen.FoodAt(item);//get dollar amount of selected item
                itemName.Text = item;//output name of item to label
                itemPrice.Text = itemCost.ToString();//output value of item to label
                clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                drinkList.ClearSelected();//clear selected items from other lists
                currentOrderList.ClearSelected();
                clearingLists = false;//set bool to indicate that we are done clearing the other lists
            }
        }

        private void drinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!clearingLists)//if lists are not being cleared, begin operations
            {
                addOrder.Enabled = true;//enable add to order button if disabled
                deleteOrder.Enabled = false;//disable delete from order button if enabled
                item = drinkList.SelectedItem.ToString();//store selected item
                itemCost = MainScreen.kitchen.DrinkAt(item);//get dollar amount of selected item
                itemName.Text = item;//output name of item to label
                itemPrice.Text = itemCost.ToString();//output value of item to label
                clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                foodList.ClearSelected();//clear selected items from other lists
                currentOrderList.ClearSelected();
                clearingLists = false;//set bool to indicate that we are done clearing the other lists
            }
        }

        private void currentOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!clearingLists)//if lists are not being cleared, begin operations
            {
                addOrder.Enabled = false;//enable add to order button if disabled
                deleteOrder.Enabled = true;//disable delete from order button if enabled
                String[] foodKeys = MainScreen.kitchen.GetFoodKeys();//get all the keys of drinks and foods from kitchen object
                String[] drinkKeys = MainScreen.kitchen.GetDrinkKeys();

                if (foodKeys.Contains<String>(currentOrderList.SelectedItem.ToString()))//if item is a food item
                {
                    item = currentOrderList.SelectedItem.ToString();//store selected item
                    itemCost = MainScreen.kitchen.FoodAt(item);//get dollar amount of selected item
                    itemName.Text = item;//output name of item to label
                    itemPrice.Text = itemCost.ToString();//output value of item to label
                    clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                    foodList.ClearSelected();//clear selected items from other lists
                    drinkList.ClearSelected();
                    clearingLists = false;//set bool to indicate that we are done clearing the other lists
                }
                else if (drinkKeys.Contains<String>(currentOrderList.SelectedItem.ToString()))
                {
                    item = currentOrderList.SelectedItem.ToString();//store selected item
                    itemCost = MainScreen.kitchen.DrinkAt(item);//get dollar amount of selected item
                    itemName.Text = item;//output name of item to label
                    itemPrice.Text = itemCost.ToString();//output value of item to label
                    clearingLists = true;//set bool to indicate that we are clearing the selected item on other lists to avoid confusion
                    foodList.ClearSelected();//clear selected items from other lists
                    drinkList.ClearSelected();
                    clearingLists = false;//set bool to indicate that we are done clearing the other lists
                }
            }
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void sendKitchen_Click(object sender, EventArgs e)
        {
            if(currentOrderList.Items.Count == 0)
            {
                //do nothing
            }
            else
            {
                string[] orderItems = new string[currentOrderList.Items.Count];
                for (int i = 0; i < currentOrderList.Items.Count; i++)
                {
                    orderItems[i] = currentOrderList.Items[i].ToString();
                }
                decimal total = 0;
                String[] foodKeys = MainScreen.kitchen.GetFoodKeys();//get all the keys of drinks and foods from kitchen object
                String[] drinkKeys = MainScreen.kitchen.GetDrinkKeys();
                for (int i = 0; i < currentOrderList.Items.Count; i++)
                {
                    if (foodKeys.Contains<String>(currentOrderList.Items[i].ToString()))//if item is a food item
                    {
                        total = total + MainScreen.kitchen.FoodAt(currentOrderList.Items[i].ToString());
                    }
                    else if (drinkKeys.Contains<String>(currentOrderList.Items[i].ToString()))//if item is a drink item
                    {
                        total = total + MainScreen.kitchen.DrinkAt(currentOrderList.Items[i].ToString());
                    }
                }
                MainScreen.kitchen.CreateOrder(new Order(Int32.Parse(number.Text), orderItems, total));
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            guestName = name.Text;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(number.Text, out roomNumber))//try to parse room number, if something other than a number is input then error will occur
                {
                }
                else
                {
                    roomNumber = -1;
                }
            }
            catch (Exception E)
            {
                number.Text = String.Empty;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MainScreen.frontDesk.NumberOfReservations(); i++)//search through all hotel reservations
            {
                if ((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && !MainScreen.frontDesk.ReservationAt(i).CheckedIn)//if entered information was correct, and guest not checkedIn
                {
                    errorLabel.Text = "Entered guest\nnever checked\nin.";
                    break;
                }
                else if ((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && (MainScreen.frontDesk.ReservationAt(i).CheckedIn))//if guest is checked in
                {
                    name.Enabled = false;//enable rest of controls when correct information is inserted
                    number.Enabled = false;
                    button1.Enabled = false;
                    addOrder.Enabled = true;
                    deleteOrder.Enabled = true;
                    foodList.Enabled = true;
                    drinkList.Enabled = true;
                    sendKitchen.Enabled = true;
                    errorLabel.Text = "";
                }
                else//if customer is never found, message will be displayed
                {
                    errorLabel.Text = "Entered reservation\ndoes not exist.";
                }
            }
        }

        private Decimal orderTotalUpdate()
        {
            decimal total = 0;
            String[] foodKeys = MainScreen.kitchen.GetFoodKeys();
            String[] drinkKeys = MainScreen.kitchen.GetDrinkKeys();
            for(int i = 0; i < currentOrderList.Items.Count; i++)
            {
                if (foodKeys.Contains<String>(currentOrderList.Items[i].ToString()))//if item is a food item
                {
                    total = total + MainScreen.kitchen.FoodAt(currentOrderList.Items[i].ToString());
                }
                else if (drinkKeys.Contains<String>(currentOrderList.Items[i].ToString()))//if item is a drink item
                {
                    total = total + MainScreen.kitchen.DrinkAt(currentOrderList.Items[i].ToString());
                }
            }
            orderTotal.Text = total.ToString();
            return total;
        }
    }
}
