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
    public partial class EditReservation : Form
    {
        private String guestName;
        private int roomNumber;
        private Form previous;
        public EditReservation(Form form)
        {
            previous = form;
            InitializeComponent();
            checkIn.Enabled = false;
            roomList.Enabled = false;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            guestName = name.Text;
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Int32.TryParse(number.Text, out roomNumber))
                {
                }
            }
            catch
            {
                number.Text = String.Empty;
            }
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < MainScreen.frontDesk.NumberOfReservations(); i++)
            {
                if((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber))//if entered information was correct
                {
                    checkIn.Enabled = true;//enable the datetimePicker
                    checkIn.Value = MainScreen.frontDesk.ReservationAt(i).CheckInDateTime;//get value of reservation
                    roomList.Enabled = true;//enable the room list
                    for (int j = 0; j < MainScreen.frontDesk.NumberOfRooms(); j++)//populate room list 
                    {
                        roomList.Items.Add(MainScreen.frontDesk.RoomAt(j).RoomNumber);
                    }
                }
            }
        }

        private void changeRes_Click(object sender, EventArgs e)
        {

        }

        private void deleteRes_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomNum = Int32.Parse(roomList.GetItemText(roomList.SelectedItem));//get selected room number(idk it was being weird so it lloks like this
            Room temp = MainScreen.frontDesk.RoomInfo(roomNum);//get room variable from list
            roomNumber = temp.RoomNumber;//store room number for later reservation creation

            numBedLabel.Text = temp.NumBeds.ToString();//output number of beds in room
            if (temp.Availability)//if room is available
            {
                availabilityLabel.Text = "Available";
            }
            else
            {
                availabilityLabel.Text = "Taken";
            }
        }
    }
}
