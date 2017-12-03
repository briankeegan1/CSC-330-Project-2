using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSC_330_Project_2
{
    public class FrontDesk//manage all reservation tasks
    {
        private List<Room> hotelRooms;//needs to be some sort of container, maybe List?
        private List<Reservation> hotelReservations;
        public FrontDesk()
        {
            hotelRooms = new List<Room>();//instantiate list of hotelRooms
            hotelReservations = new List<Reservation>();//instantiate list of hotelReservations

            /*Get all hotel room data from file*/
            String path = "HotelRooms.txt";//path of hotelRooms file
            String content = string.Empty;//create string to hold all content
            if (File.Exists(path))
            {
                content = File.ReadAllText(path);//get all content from hotel rooms file
                String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split lines
                foreach (String entry in lines)//foreach line, split further
                {
                    String[] individual = entry.Split(new[] { "\t" }, StringSplitOptions.None);//split lines into individual parts
                    int roomNumber = Int32.Parse(individual[0]);//get room number
                    bool availability = false;//get room availability
                    if (individual[3] == "Occupied")
                    {
                        availability = false;
                    }
                    else
                    {
                        availability = true;
                    }
                    decimal nightlyRate = Decimal.Parse(individual[2]);//get nightlyrate of room
                    int numBeds = Int32.Parse(individual[1]);//get number of beds
                    hotelRooms.Add(new Room(roomNumber, availability, nightlyRate, numBeds));
                }
            }
            else
            {
                Environment.Exit(1);
            }
            /*Get all data from Hotel Reservations file*/
            path = "CurrentHotelReservations.txt";
            content = string.Empty;
            if(File.Exists(path))
            {
                content = File.ReadAllText(path);
                String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);
                foreach (String entry in lines)
                {
                    String[] individual = entry.Split(new[] { "\t" }, StringSplitOptions.None);//split lines into individual parts
                    String guestName = individual[0];//get guestname
                    int roomNumber = Int32.Parse(individual[1]);//get and parse roomNumber
                    String date = individual[2];//store date string
                    String[] splitDate = date.Split(new[] { "/" }, StringSplitOptions.None);//split date string for later parsing
                    String time = individual[3];//get time string
                    String[] splitTime = time.Split(new[] { ":" }, StringSplitOptions.None);//split time string for later parsing
                    decimal totalBill = Decimal.Parse(individual[4]);//get and parse totalBill
                    DateTime dateTime = new DateTime(Int32.Parse(splitDate[2]), Int32.Parse(splitDate[0]), Int32.Parse(splitDate[1]), Int32.Parse(splitTime[0]), Int32.Parse(splitTime[1]), Int32.Parse(splitTime[2]));//create DateTime variable
                    bool checkedIn;
                    if (individual[5] == "false")
                        checkedIn = false;
                    else
                        checkedIn = true;
                    hotelReservations.Add(new Reservation(guestName, roomNumber, dateTime, totalBill, checkedIn));
                }
            }
            else
            {
                File.Create(path);
            }
        }
        public void CreateReservation(String guestName, int roomNumber, DateTime checkIn, decimal totalBill = 0)
        {
            hotelReservations.Add(new Reservation(guestName, roomNumber, checkIn, totalBill, false));//create new reservation, guests are checked in by front desk
            for(int i = 0; i < hotelRooms.Count; i++)
            {
                if(hotelRooms[i].RoomNumber == roomNumber)
                {
                    hotelRooms[i].Availability = false;
                    break;
                }
            }
        }
        public void EditReservation(String guestName, int roomNumber, DateTime checkIn)
        {
            Reservation reservation;
            for(int i = 0; i < NumberOfReservations(); i++)
            {
                if(ReservationAt(i).CustomerName == guestName)
                {
                    reservation = ReservationAt(i);//find correct reservation to edit
                    reservation.CheckInDateTime = checkIn;//change checkIn time of reservation
                    RoomInfo(reservation.RoomNumber).Availability = true;//change availability of old room
                    RoomInfo(roomNumber).Availability = false;//change availability of new room
                    reservation.RoomNumber = roomNumber;//change room number
                }
            }

        }
        public void DeleteReservation(String guestName)
        {
            
            for(int i = 0; i < NumberOfReservations(); i++)
            {
                if(guestName == hotelReservations[i].CustomerName)
                {
                    hotelRooms[hotelReservations[i].RoomNumber - 1].Availability = true;
                    hotelReservations.RemoveAt(i);
                }
            }
        }
        public void FinalizeBill(decimal totalBill, int roomNumber)
        {
            Reservation temp = ReservationInfo(roomNumber);
            String path = "PastHotelReservations.txt";//path of hotelRooms file
            if (File.Exists(path))
            {
                String content = temp.CustomerName + "\t" + temp.CheckInDateTime + "\t" + totalBill + "\t" + System.DateTime.Now + "\r\n";
                File.AppendAllText(path, content);
            }
            RoomInfo(roomNumber).Availability = true;
            hotelReservations.Remove(temp);
        }
        public void UpdateFiles()
        {
            String path = "HotelRooms.txt";//path of hotelRooms file
            String content = string.Empty;//create string to hold all content
            if(File.Exists(path))
            {
                String info = string.Empty;
                for (int i = 0; i < NumberOfRooms(); i++)//get all room info
                {
                    Room temp = hotelRooms[i];
                    info = info + temp.RoomNumber + "\t" + temp.NumBeds + "\t" + temp.NightRate + "\t" + (temp.Availability?"Available":"Occupied");
                    if(i != NumberOfRooms() - 1)//if we are not at the last entry add the next line character
                    {
                        info = info + "\r\n";
                    }
                    else//otherwise leave total content alone
                    {

                    }
                }
                File.WriteAllText(path, info);//write to file
            }
            
            /*Output all data to Hotel Reservations file*/
            path = "CurrentHotelReservations.txt";
            content = string.Empty;
            if (File.Exists(path))
            {
                String info = string.Empty;
                for (int i = 0; i < NumberOfReservations(); i++)
                {
                    Reservation temp = hotelReservations[i];
                    info = info + temp.CustomerName + "\t" + temp.RoomNumber + "\t" + temp.CheckInDateTime.Month + '/' + temp.CheckInDateTime.Day + '/' + temp.CheckInDateTime.Year + "\t" + temp.CheckInDateTime.Hour + ':' + temp.CheckInDateTime.Minute + ':' + temp.CheckInDateTime.Second + "\t" + temp.TotalBill + "\t" + temp.CheckedIn;
                    if (i != NumberOfReservations() - 1)//if we are not at the last entry add the next line character
                    {
                        info = info + "\r\n";
                    }
                    else//otherwise leave total content alone
                    {

                    }
                }
                if(info == string.Empty)//if all guests are checked out, delete the current reservations file
                {
                    File.Delete(path);
                }
                else//otherwise write over the current reservations file
                {
                    File.WriteAllText(path, info);
                }
            }
        }
        public Room RoomInfo(int roomNum)//get room info from room number
        {
            bool roomFound = false;
            for(int i = 0; i < hotelRooms.Count(); i++)//look through entire hotelRooms list
            {
                if(hotelRooms[i].RoomNumber == roomNum)//if room has matching room number return room variable
                {
                    roomFound = true;
                    return hotelRooms[i];
                }
            }
            if(!roomFound)//if we never found room, then return an incorrect room
            {
                return new Room(-1, false, -200, -1);
            }
            return null;//in case all else fails
        }
        public Room RoomAt(int index)//return room at index in list
        {
            return hotelRooms[index];
        }
        public int NumberOfRooms()//gets number of hotel rooms avaialable
        {
            return hotelRooms.Count;
        }
        public Reservation ReservationInfo(int roomNumber)
        {
            for(int i = 0; i < NumberOfReservations(); i++)
            {
                if(hotelReservations[i].RoomNumber == roomNumber)
                {
                    return hotelReservations[i];
                }
            }
            return null;
        }
        public Reservation ReservationAt(int index)//get reservation at index
        {
            return hotelReservations[index];
        }
        public int NumberOfReservations()
        {
            return hotelReservations.Count;
        }
    }

    public class Kitchen//manange all kitchen tasks
    {
        Dictionary<String, decimal> foodItems;
        Dictionary<String, decimal> drinksItems;
        private List<Order> customerOrders;
        public Kitchen()
        {
            customerOrders = new List<Order>();
            /*Fill out customerOrders with any orders that were not fulfilled file*/
            String path = "CustomerOrders.txt";//path of drink items
            if (File.Exists(path))
            {
                String content = String.Empty;
                content = File.ReadAllText(path);
                String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split all content into lines
                foreach (String ind in lines)
                {
                    String[] individual = ind.Split(new[] { "\t" }, StringSplitOptions.None);//split individual lines into seperate words
                    String[] food = individual[1].Split(new[] { "," }, StringSplitOptions.None);//split list of foods into seperate items
                    customerOrders.Add(new Order(Int32.Parse(individual[0]), food, Decimal.Parse(individual[2])));//store order data
                }
            }
            //Instantiate and retrieve all drink and food items from files
            foodItems = new Dictionary<string, decimal>();
            drinksItems = new Dictionary<string, decimal>();
            path = "HotelDrinksMenu.txt";//path of drink items
            if (File.Exists(path))
            {
                String content = String.Empty;
                content = File.ReadAllText(path);
                String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split all content into lines
                foreach (String ind in lines)
                {
                    String[] individual = ind.Split(new[] { "\t" }, StringSplitOptions.None);//split individual lines into seperate words
                    drinksItems.Add(individual[0], Decimal.Parse(individual[1]));//add drink items to drink menus
                }
            }
            //get items from food and drink files
            int hour = System.DateTime.Now.Hour;//getcurrent hour to setermine menu
            if (hour >= 0 && hour <= 11)//if it is breakfast time, load the breakfast menu
            {
                path = "BreakfastFoodMenu.txt";//path of food items
                if (File.Exists(path))
                {
                    String content = String.Empty;
                    content = File.ReadAllText(path);
                    String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split all content into lines
                    foreach (String ind in lines)
                    {
                        String[] individual = ind.Split(new[] { "\t" }, StringSplitOptions.None);//split individual lines into seperate words
                        foodItems.Add(individual[0], Decimal.Parse(individual[1]));//add food item to dictionary of food items
                    }
                }
            }
            else if (hour >= 12 && hour <= 17)//if it is lunch time, load lunch menu
            {
                path = "LunchFoodMenu.txt";//path of food items
                if (File.Exists(path))
                {
                    String content = String.Empty;
                    content = File.ReadAllText(path);
                    String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split all content into lines
                    foreach (String ind in lines)
                    {
                        String[] individual = ind.Split(new[] { "\t" }, StringSplitOptions.None);//split individual lines into seperate words
                        foodItems.Add(individual[0], Decimal.Parse(individual[1]));//add food item to dictionary of food items
                    }
                }
            }
            else//if it is dinner time, load the dinner contents
            {
                path = "DinnerFoodMenu.txt";//path of food items
                if (File.Exists(path))
                {
                    String content = String.Empty;
                    content = File.ReadAllText(path);
                    String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split all content into lines
                    foreach (String ind in lines)
                    {
                        String[] individual = ind.Split(new[] { "\t" }, StringSplitOptions.None);//split individual lines into seperate words
                        foodItems.Add(individual[0], Decimal.Parse(individual[1]));//add food item to dictionary of food items
                    }
                }
            }
        }
        public void CreateOrder(Order customerOrder)
        {
            customerOrders.Add(customerOrder);//add order to list
            MainScreen.frontDesk.ReservationInfo(customerOrder.RoomNumber).TotalBill = MainScreen.frontDesk.ReservationInfo(customerOrder.RoomNumber).TotalBill + customerOrder.OrderTotal;//update guest account
        }
        public void EditOrder(Order originalOrder, Order editedOrder)
        {
            int orig = customerOrders.IndexOf(originalOrder);//get idex of original order
            customerOrders[orig].FoodItems = editedOrder.FoodItems;//update information of order
            customerOrders[orig].OrderTotal = editedOrder.OrderTotal;
        }
        public void DeleteOrder(Order order)
        {
            int orig = customerOrders.IndexOf(order);//get idex of original order
            customerOrders.RemoveAt(orig);//remove order
        }
        //return dollar value of passed food item name
        public decimal FoodAt(String key)
        {
            return foodItems[key];
        }
        //return dollar value of passed drink item name
        public decimal DrinkAt(String key)
        {
            return drinksItems[key];
        }
        //return array of keys to be used for iterating through Dictionary
        public String[] GetFoodKeys()
        {
            return foodItems.Keys.ToArray<String>();
        }
        //return array of keys to be used for iterating through Dictionary
        public String[] GetDrinkKeys()
        {
            return drinksItems.Keys.ToArray<String>();
        }
        //returns list of all orders for passed room number
        public List<Order> AllOrderInfo(int roomNumber)
        {
            List<Order> foundOrders = new List<Order>();
            for(int i = 0; i < customerOrders.Count; i++)
            {
                if(customerOrders[i].RoomNumber == roomNumber)
                {
                    foundOrders.Add(customerOrders[i]);
                }
            }
            return foundOrders;
        }
        //return number of orders
        public int NumberofOrder()
        {
            return customerOrders.Count;
        }
        //update files
        public void UpdateFiles()
        {
            String path = "CustomerOrders.txt";//path of hotelRooms file
            String content = string.Empty;//create string to hold all content
            if (File.Exists(path))
            {
                String info = string.Empty;
                for(int i = 0; i < NumberofOrder(); i++)
                {
                    String[] str = customerOrders[i].FoodItems;
                    info = info + customerOrders[i].RoomNumber + '\t';
                    for(int j = 0; j < str.Length; j++)
                    {
                        if(j != str.Length - 1)
                        {
                            info = info + str[j] + ',';
                        }
                        else
                        {
                            info = info + str[j] + '\t';
                        }
                    }
                    if(i != NumberofOrder() - 1)
                    {
                        info = info + customerOrders[i].OrderTotal + "\r\n";
                    }
                    else
                    {
                        info = info + customerOrders[i].OrderTotal;
                    }
                }
                File.WriteAllText(path, info);//write to file
            }
        }
    }

    public class Room//contain all info for rooms
    {
        private int numBeds, roomNumber;
        private decimal nightRate;
        private bool availability;
        public Room(int roomNumber, bool availability, decimal nightRate, int numBeds)
        {
            NumBeds = numBeds;
            Availability = availability;
            NightRate = nightRate;
            RoomNumber = roomNumber;
        }

        public int NumBeds
        {
            get
            {
                return numBeds;
            }
            set
            {
                numBeds = value;
            }
        }
        public bool Availability
        {
            get
            {
                return availability;
            }
            set
            {
                availability = value;
            }
        }
        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }
        public decimal NightRate
        {
            get
            {
                return nightRate;
            }
            set
            {
                nightRate = value;
            }
        }
    }

    public class Reservation//hold reservation info
    {
        private String customerName;
        private int roomNumber;
        private DateTime checkinDateTime;
        private decimal totalBill;
        private bool checkedIn;
        public Reservation(String customerName, int roomNumber, DateTime checkinDateTime, decimal totalBill, bool checkedIn)
        {
            CustomerName = customerName;
            RoomNumber = roomNumber;
            CheckInDateTime = checkinDateTime;
            TotalBill = totalBill;
            CheckedIn = checkedIn;
        }
        public String CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }
        public DateTime CheckInDateTime
        {
            get
            {
                return checkinDateTime;
            }
            set
            {
                checkinDateTime = value;
            }
        }
        public decimal TotalBill
        {
            get
            {
                return totalBill;
            }
            set
            {
                totalBill = value;
            }
        }
        public bool CheckedIn
        {
            get
            {
                return checkedIn;
            }
            set
            {
                checkedIn = value;
            }
        }
    }

    public class Order//hold room service order information
    {
        private int roomNumber;
        private String[] foodItems;
        private decimal orderTotal;
        private bool fulfilled;
        public Order(int roomNumber, String[] foodItems, decimal orderTotal)
        {
            RoomNumber = roomNumber;
            FoodItems = foodItems;
            OrderTotal = orderTotal;
            Fulfilled = false;
        }
        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }
        public String[] FoodItems
        {
            get
            {
                return foodItems;
            }
            set
            {
                foodItems = value;
            }
        }
        public decimal OrderTotal
        {
            get
            {
                return orderTotal;
            }
            set
            {
                orderTotal = value;
            }
        }
        public bool Fulfilled
        {
            get
            {
                return fulfilled;
            }
            set
            {
                fulfilled = value;
            }
        }
    }
}
