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
    public partial class EditOrder : Form
    {
        private String guestName;
        private int roomNumber;
        private String item;
        private decimal itemCost;
        bool clearingLists;
        List<Order> foundOrders;
        private Form previous;
        public EditOrder(Form form)
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
            foundOrders = new List<Order>();
            addOrder.Enabled = false;//disable controls to prevent orders with no customer information
            deleteOrder.Enabled = false;
            foodList.Enabled = false;
            drinkList.Enabled = false;
            sendKitchen.Enabled = false;
            ordersList.Enabled = false;
            deleteOrderButton.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MainScreen.frontDesk.NumberOfReservations(); i++)//search through all hotel reservations
            {
                if ((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && !MainScreen.frontDesk.ReservationAt(i).CheckedIn)//if entered information was correct, and guest not checkedIn
                {
                    errorLabel.Text = "Entered guest\nnever checked\nin.";
                    button1.BackColor = Color.Red;
                    break;
                }
                else if ((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && (MainScreen.frontDesk.ReservationAt(i).CheckedIn))//if guest is checked in
                {
                    name.Enabled = false;//disable reservation search, but don't allow changing of reservation information
                    number.Enabled = false;
                    ordersList.Enabled = true;
                    button1.Enabled = false;
                    errorLabel.Text = "";
                    button1.BackColor = Color.Green;
                    foundOrders = MainScreen.kitchen.AllOrderInfo(roomNumber);//get list of all orders for room number
                    if (foundOrders.Count == 0)//if customer never made an order to the kitchen, output error and lock controls
                    {
                        errorLabel.Text = "No orders found for entered information.";
                        name.Enabled = true;//reenable components that were disabled for search
                        number.Enabled = true;
                        ordersList.Enabled = false;
                        button1.Enabled = true;
                    }
                    else
                    {
                        errorLabel.Text = String.Empty;
                        String placeHolder = String.Empty;
                        int counter = 1;
                        //get order from kitchen variable, and then place placemarkers onto list of customer orders
                        foundOrders = MainScreen.kitchen.AllOrderInfo(roomNumber);
                        foreach (Order order in foundOrders)
                        {
                            placeHolder = "Order " + counter;
                            ordersList.Items.Add(placeHolder);
                            counter++;
                        }
                    }
                }
                else//if customer is never found, message will be displayed
                {
                    errorLabel.Text = "Entered reservation\ndoes not exist.";
                    button1.BackColor = Color.Red;
                }
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)//for deleting orders
        {
            MainScreen.kitchen.DeleteOrder(foundOrders[ordersList.SelectedIndex]);//call delete function to remove order from the class
            foundOrders.RemoveAt(ordersList.SelectedIndex);//remove order form list of foundOrders
            OrderTotalUpdate();//update order total
            UpdateOrdersList();//update orderList
        }

        private void EditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            Environment.Exit(-1);
        }

        private void ordersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!clearingLists)
            {
                if(ordersList.SelectedItem != null)
                {
                    deleteOrder.Enabled = true;//enable other controls
                    foodList.Enabled = true;
                    drinkList.Enabled = true;
                    sendKitchen.Enabled = true;
                    deleteOrderButton.Enabled = true;
                    //get order details, and then clear list and place new order items onto list
                    Order temp = foundOrders[ordersList.SelectedIndex];
                    clearingLists = true;
                    currentOrderList.Items.Clear();
                    clearingLists = false;
                    String[] items = temp.FoodItems;
                    foreach (String str in items)
                    {
                        currentOrderList.Items.Add(str);
                    }
                    OrderTotalUpdate();//update total
                }
            }
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clearingLists)//if lists are not being cleared, begin operations
            {
                if(foodList.SelectedItem != null)
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
        }

        private void drinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clearingLists)//if lists are not being cleared, begin operations
            {
                if(drinkList.SelectedItem != null)
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
        }

        private void currentOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!clearingLists)//if lists are not being cleared, begin operations
            {
                addOrder.Enabled = false;//enable add to order button if disabled
                deleteOrder.Enabled = true;//disable delete from order button if enabled
                String[] foodKeys = MainScreen.kitchen.GetFoodKeys();//get all the keys of drinks and foods from kitchen object
                String[] drinkKeys = MainScreen.kitchen.GetDrinkKeys();
                if(currentOrderList.SelectedItem != null)
                {
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
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            currentOrderList.Items.Add(item);//add item to current order
            OrderTotalUpdate();//update total
        }

        private void sendKitchen_Click(object sender, EventArgs e)
        {
            sendKitchen.BackColor = Color.Green;
            String[] tempList = new String[currentOrderList.Items.Count];//create a temporary list to hold order items
            for(int i = 0; i < currentOrderList.Items.Count; i++)//store all items in current order
            {
                tempList[i] = currentOrderList.Items[i].ToString();
            }
            MainScreen.kitchen.EditOrder(foundOrders[ordersList.SelectedIndex], new Order(roomNumber, tempList, Decimal.Parse(orderTotal.Text)));//edit the order to reflect changes
            OrderTotalUpdate();//update total
        }

        private void name_TextChanged_1(object sender, EventArgs e)
        {
            guestName = name.Text;//store guest name
        }

        private void number_TextChanged_1(object sender, EventArgs e)
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

        private Decimal OrderTotalUpdate()
        {
            decimal total = 0;//temporary total amount
            String[] foodKeys = MainScreen.kitchen.GetFoodKeys();//get all keys for food items
            String[] drinkKeys = MainScreen.kitchen.GetDrinkKeys();//get all keys for drink items
            for (int i = 0; i < currentOrderList.Items.Count; i++)//go through list and add to total accordingly
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
            orderTotal.Text = total.ToString();//dispaly total
            return total;//return total
        }

        private void UpdateOrdersList()
        {
            name.Enabled = false;//disable reservation search, but don't allow changing of reservation information
            number.Enabled = false;
            ordersList.Enabled = true;
            button1.Enabled = false;
            errorLabel.Text = "";
            foundOrders = MainScreen.kitchen.AllOrderInfo(roomNumber);//get list of all orders for room number
            if (foundOrders.Count == 0)//if customer never made an order to the kitchen, output error and lock controls
            {
                clearingLists = true;
                ordersList.ClearSelected();//clear selected
                ordersList.Items.Clear();//clear orders
                clearingLists = false;
                errorLabel.Text = "No orders found for entered information.";
                name.Enabled = true;//reenable components that were disabled for search
                number.Enabled = true;
                ordersList.Enabled = false;
                button1.Enabled = true;
                currentOrderList.Enabled = false;
                foodList.Enabled = false;
                drinkList.Enabled = false;
                addOrder.Enabled = false;

            }
            else
            {
                String placeHolder = String.Empty;
                int counter = 1;
                //get order from kitchen variable, and then place placemarkers onto list of customer orders
                foundOrders = MainScreen.kitchen.AllOrderInfo(roomNumber);
                foreach (Order order in foundOrders)
                {
                    placeHolder = "Order " + counter;
                    ordersList.Items.Add(placeHolder);
                    counter++;
                }
                ordersList.ClearSelected();//clear selected
                ordersList.Items.RemoveAt(ordersList.SelectedIndex);//remove selected order
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            previous.Show();
        }
    }
}
