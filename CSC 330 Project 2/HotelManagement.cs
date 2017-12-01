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
            content = File.ReadAllText(path);//get all content from hotel rooms file
            String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split lines
            foreach(String entry in lines)//foreach line, split further
            {
                String[] individual = entry.Split(new[] { "\t" }, StringSplitOptions.None);//split lines into individual parts
                int roomNumber = Int32.Parse(individual[0]);//get room number
                bool availability = false;//get room availability
                if(individual[3] == "Occupied")
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
            /*Get all data from Hotel Reservations file*/
            path = "HotelReservations.txt";
            content = string.Empty;
            content = File.ReadAllText(path);
            lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach(String entry in lines)
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
                    hotelReservations.RemoveAt(i);
                }
            }
        }
        public void FinalizeBill()
        {

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
        private Order customerOrder;
        private Menu kitchenMenu;
        public Kitchen()
        {

        }
        public void CreateOrder(Order customerOrder)
        {

        }
        public void EditOrder(ref Order customerOrder)
        {

        }
        public void UpdateBill()
        {

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
        public Order()
        {

        }
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

    public class Menu//hold all menu items(Incomplete)
    {
        Dictionary<string, decimal> foodItems;
        public Menu()
        {
            //get items from food file
        }
        public void outputMenu() { }
    }
}
