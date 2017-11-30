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
    public partial class CreateReservation : Form
    {
        private String guestName;
        private int roomNumber;
        private DateTime checkIn;
        private decimal nightlyRate;
        private bool availability;
        private Form previous;
        public CreateReservation(Form form)
        {
            previous = form;
            InitializeComponent();
            for(int i = 0; i < MainScreen.frontDesk.NumberOfRooms(); i++)
            {
                roomList.Items.Add(MainScreen.frontDesk.At(i).RoomNumber);
            }
        }

        private void roomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomNum = Int32.Parse(roomList.GetItemText(roomList.SelectedItem));//get selected room number(idk it was being weird so it lloks like this
            Room temp = MainScreen.frontDesk.RoomInfo(roomNum);//get room variable from list
            roomNumber = temp.RoomNumber;//store room number for later reservation creation
            nightlyRate = temp.NightRate;//store nightlyRate for later reservation creation

            numBedLabel.Text = temp.NumBeds.ToString();//output number of beds in room
            nightlyRateLabel.Text = nightlyRate.ToString();//change label text
            if(temp.Availability)//if room is available
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            guestName = textBox1.Text;//store entered guest name
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkIn = dateTimePicker1.Value;//store selected date and Time
        }

        private void createReservationButton_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.CreateReservation(guestName, roomNumber, checkIn, 0);
        }
    }
}
