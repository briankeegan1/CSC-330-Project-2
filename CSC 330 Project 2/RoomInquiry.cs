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
    public partial class RoomInquiry : Form
    {
        private String guestName;
        private int roomNumber;
        private DateTime checkIn;
        private decimal nightlyRate;
        private bool availability;
        Form previous;
        public RoomInquiry(Form form)
        {
            InitializeComponent();
            previous = form;
            ReloadList();
        }

        private void roomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomNum = Int32.Parse(roomList.GetItemText(roomList.SelectedItem));//get selected room number(idk it was being weird so it lloks like this
            Room temp = MainScreen.frontDesk.RoomInfo(roomNum);//get room variable from list
            roomNumber = temp.RoomNumber;//store room number for later reservation creation
            nightlyRate = temp.NightRate;//store nightlyRate for later reservation creation

            numBedLabel.Text = temp.NumBeds.ToString();//output number of beds in room
            nightlyRateLabel.Text = nightlyRate.ToString();//change label text
            if (temp.Availability)//if room is available
            {
                availability = true;
                availabilityLabel.Text = "Available";
            }
            else
            {
                availability = false;
                availabilityLabel.Text = "Taken";
            }
        }

        private void ReloadList()
        {
            roomList.Items.Clear();
            for (int j = 0; j < MainScreen.frontDesk.NumberOfRooms(); j++)//populate room list 
            {
                if (MainScreen.frontDesk.RoomAt(j).Availability)//only place rooms in list if it is available
                    roomList.Items.Add(MainScreen.frontDesk.RoomAt(j).RoomNumber);
            }
        }

        private void RoomInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            //Application.Exit();
            Environment.Exit(-1);
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
