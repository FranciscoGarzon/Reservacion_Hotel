﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservacion_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form signup = new SignupModal();
            signup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form login = new Form6();
            login.ShowDialog();
        }
    }
}
