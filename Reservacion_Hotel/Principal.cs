using System;
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
    public partial class Principal : Form
    {
        public Principal()
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
            Form login = new LoginModal();
            login.ShowDialog();
        }
    }
}
