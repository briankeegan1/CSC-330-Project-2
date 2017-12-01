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
    public partial class ReservationMenu : Form
    {
        private Form previous;
        public ReservationMenu(Form form)
        {
            previous = form;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previous.Show();//show previoud menu
            this.Dispose();//dispose of this form
        }

        private void createReservation_Click(object sender, EventArgs e)
        {
            this.Hide();//hide main form
            Form next = new CreateReservation(this);//create next form
            next.Show();//show next form
        }

        private void editReservation_Click(object sender, EventArgs e)
        {
            this.Hide();//hide main form
            Form next = new EditReservation(this);//create next form
            next.Show();//show next form
        }

        private void finalize_Click(object sender, EventArgs e)
        {
            this.Hide();//hide main form
            Form next = new FinalizeBill(this);//create next form
            next.Show();//show next form
        }

        private void ReservationMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
