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
            if (DesplegableOpciones.Text == "Administrador")
            {
                Form adminAccount = new IngresoAdministrador();
                adminAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != adminAccount)
                        formulario.Hide();
                }
            }
            else if (DesplegableOpciones.Text == "Cliente")
            {
                Form clientAccount = new IngresoCliente();
                clientAccount.Show();

                foreach (Form formulario in Application.OpenForms)
                {
                    if (formulario != clientAccount)
                        formulario.Hide();
                }
            }
            else if (DesplegableOpciones.Text == "Recepcionista")
            {
                Form receptionistAccount = new IngresoRecepcionista();
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
