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
    public partial class FinalizeBill : Form
    {
        private String guestName;
        private int roomNumber;
        private Form previous;
        public FinalizeBill(Form form)
        {
            previous = form;
            InitializeComponent();
            button2.Enabled = false;//disable payment type buttons
            button3.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
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
                    decimal tempTotal = MainScreen.frontDesk.ReservationInfo(roomNumber).TotalBill;
                    button2.Enabled = true;//enable payment types
                    button3.Enabled = true;
                    MiscCharge.Text = "$" + Math.Round(tempTotal, 2);//output miscellaneous charges that were added by staff
                    double totalDays = (System.DateTime.Now - MainScreen.frontDesk.ReservationInfo(roomNumber).CheckInDateTime).TotalDays;
                    roomCharge.Text = "$" + Math.Round((decimal)totalDays * MainScreen.frontDesk.RoomInfo(roomNumber).NightRate, 2);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalDays = (System.DateTime.Now - MainScreen.frontDesk.ReservationInfo(roomNumber).CheckInDateTime).TotalDays;
            MainScreen.frontDesk.FinalizeBill((MainScreen.frontDesk.ReservationInfo(roomNumber).TotalBill) + Math.Round((decimal)totalDays * MainScreen.frontDesk.RoomInfo(roomNumber).NightRate, 2), roomNumber);
            while(progressBar1.Value != 100)//"authenticate the payment", really just make a progression bar move
            {
                progressBar1.PerformStep();
                System.Threading.Thread.Sleep(150);
            }
            MainScreen.frontDesk.UpdateFiles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (progressBar1.Value != 100)//"authenticate the payment", really just make a progression bar move
            {
                progressBar1.PerformStep();
                System.Threading.Thread.Sleep(150);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            this.Dispose();
            previous.Show();
        }

        private void FinalizeBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
