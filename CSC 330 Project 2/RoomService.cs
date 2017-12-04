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
    public partial class RoomService : Form
    {
        private Form previous;
        public RoomService(Form form)
        {
            previous = form;
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form next = new KitchenMenu(this);
            next.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form next = new CreateOrder(this);
            next.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form next = new EditOrder(this);
            next.Show();
        }

        private void RoomService_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            Environment.Exit(-1);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            MainScreen.frontDesk.UpdateFiles();
            MainScreen.kitchen.UpdateFiles();
            this.Dispose();
            previous.Show();
        }
    }
}
