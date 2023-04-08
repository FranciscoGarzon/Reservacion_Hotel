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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrador")
            {
                this.Hide();
                var adminAccount = new Form2();
                adminAccount.ShowDialog();
            }
            else if (comboBox1.Text == "Recepcionista")
            {
                this.Hide();
                var login = new Form10();
                login.ShowDialog();
            }
            else if (comboBox1.Text == "Cliente")
            {
                this.Hide();
                var login = new Form11();
                login.ShowDialog();
            }
        }
    }
}
