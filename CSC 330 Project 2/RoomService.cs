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

        private void RoomService_Load(object sender, EventArgs e)
        {

        }
    }
}
