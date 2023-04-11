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
    public partial class LoginModal : Form
    {
        public LoginModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrador")
            {
                this.Close();
                Form adminAccount = new Form7();
                adminAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != adminAccount)
                        formulario.Hide();
                }
            }
            else if (comboBox1.Text == "Cliente")
            {
                Form clientAccount = new Form3();
                clientAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != clientAccount)
                        formulario.Hide();
                }
            }
            else if (comboBox1.Text == "Recepcionista")
            {
                this.Close();
                Form receptionistAccount = new Form8();
                receptionistAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != receptionistAccount)
                        formulario.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
