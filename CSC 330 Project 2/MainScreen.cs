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
    public partial class MainScreen : Form
    {
        public static FrontDesk frontDesk;//static variable of frontDesk since it will be used everywhere
        public static Room hotelRooms;//static variable of Room since hotel room info is needed everywhere
        public static Kitchen kitchen;//static variable of Kitchen since kitchen info is needed in a number of scripts
        public MainScreen()
        {
            InitializeComponent();
            frontDesk = new FrontDesk();
            kitchen = new Kitchen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//hide main form
            Form next = new RoomService(this);//create next form
            next.Show();//show next form
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            this.Hide();//hide main form
            Form next = new ReservationMenu(this);//create next form
            next.Show();//show next form
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            Application.Exit();
        }
    }
}
