﻿using System;
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
    public partial class CreateOrder : Form
    {
        private Form previous;
        public CreateOrder(Form form)
        {
            InitializeComponent();
            previous = form;
        }
    }
}
