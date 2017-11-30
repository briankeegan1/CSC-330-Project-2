﻿using System;
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
            String path = "HotelRooms.txt";//path of hotelRooms file
            String content = string.Empty;//create string to hold all content
            content = File.ReadAllText(path);//get all content from hotel rooms file
            String[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.None);//split lines
            foreach(String entry in lines)
            {
                String[] individual = content.Split(new[] { "\t" }, StringSplitOptions.None);//split lines into individual parts
                int roomNumber = Int32.Parse(individual[0]);//get room number
                bool availability = false;//get room availability
                if(individual[3] == "0")
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
                Console.WriteLine(roomNumber);
                Console.WriteLine(availability);
                Console.WriteLine(nightlyRate);
                Console.WriteLine(numBeds);
            }
        }
        public void CreateReservation()
        {

        }
        public void EditReservation()
        {

        }
        public void DeleteReservation()
        {

        }
        public void FinalizeBill()
        {

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
        public Room(int numBeds, bool availability, decimal nightRate, int roomNumber)
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
        public Reservation(String customerName, int roomNumber, DateTime checkinDateTime, decimal totalBill)
        {
            CustomerName = customerName;
            RoomNumber = roomNumber;
            CheckInDateTime = checkinDateTime;
            TotalBill = totalBill;
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
