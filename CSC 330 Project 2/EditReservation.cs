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
        private DateTime date;
        private Form previous;
        public EditReservation(Form form)
        {
            previous = form;
            InitializeComponent();
            checkIn.Enabled = false;//disable changeable variables
            roomList.Enabled = false;
            changeRes.Enabled = false;
            deleteRes.Enabled = false;
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
        private void name_TextChanged(object sender, EventArgs e)
        {
            guestName = name.Text;//store guest name
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Int32.TryParse(number.Text, out roomNumber))//try to parse room number, if something other than a number is input then error will occur
                {
                }
                else
                {
                    roomNumber = -1;
                }
            }
            catch(Exception E)
            {
                number.Text = String.Empty;
            }
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(checkIn.Value < System.DateTime.Now)//check that chosen date an time are not in the past
            {
                checkIn.Value = System.DateTime.Now;
                errorLabel.Text = "Past dates are\nnot acceptable\nchanges to reservation.";
            }
            else//if valid date and time entered, then store value for later reservation changing
            {
                date = checkIn.Value;//store chenged date
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < MainScreen.frontDesk.NumberOfReservations(); i++)
            {
                if((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && !MainScreen.frontDesk.ReservationAt(i).CheckedIn)//if entered information was correct, and guest not checkedIn
                {
                    button1.BackColor = Color.White;
                    checkIn.Enabled = true;//enable the datetimePicker
                    checkIn.Value = MainScreen.frontDesk.ReservationAt(i).CheckInDateTime;//get value of reservation
                    roomList.Enabled = true;//enable the room list
                    changeRes.Enabled = true;//enable buttons
                    deleteRes.Enabled = true;
                    ReloadList();//reload list of available rooms
                }
                else if((MainScreen.frontDesk.ReservationAt(i).CustomerName == guestName) && (MainScreen.frontDesk.ReservationAt(i).RoomNumber == roomNumber) && MainScreen.frontDesk.ReservationAt(i).CheckedIn)
                {
                    //reservation not found
                    button1.BackColor = Color.SkyBlue;
                    errorLabel.Text = "Guest already\nchecked in.\nReservation cannot\n be modified";
                }
                else
                {
                    errorLabel.Text = "Invalid Information\nentered.";
                    button1.BackColor = Color.PaleVioletRed;
                }
            }
        }

        private void changeRes_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.EditReservation(guestName, roomNumber, date);
            number.Text = roomNumber.ToString();
            ReloadList();
        }

        private void deleteRes_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.DeleteReservation(guestName);//possibly add textbox to show success
            this.Dispose();
            previous.Show();
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
            nightlyRateLabel.Text = temp.NightRate.ToString();//change nightly rate label
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            previous.Show();
        }
    }
}
