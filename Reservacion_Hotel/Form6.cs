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
    public partial class Form6 : Form
    {
        Form home = new Form1();
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
            if (comboBox1.Text == "Administrador")
            {
                this.Hide();
                home.Hide();
                var signup = new Form7();
                signup.ShowDialog();
            }else if (comboBox1.Text == "Clientes")
            {
                this.Hide();
                home.Hide();
                var signup = new Form3();
                signup.ShowDialog();
            }else if (comboBox1.Text == "Recepcionista")
            {
                this.Hide();
                home.Hide();
                var signup = new Form3();
                signup.ShowDialog();
            }

        }
    }
}
