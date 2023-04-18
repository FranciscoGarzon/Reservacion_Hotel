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
    public partial class SignupModal : Form
    {
        public SignupModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrador")
            {
                this.Close();
                Form createAdminAccount = new RegistroAdministrador();
                createAdminAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != createAdminAccount)
                        formulario.Hide();
                }
            }
            else if (comboBox1.Text == "Cliente")
            {
                this.Close();
                Form createClientAccount = new RegistroCliente();
                createClientAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != createClientAccount)
                        formulario.Hide();
                }
            }
            else if (comboBox1.Text == "Recepcionista")
            {
                this.Close();
                Form createReceptionistAccount = new RegistroRecepcionista();
                createReceptionistAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != createReceptionistAccount)
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
