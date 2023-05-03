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
    public partial class IngresoCliente : Form
    {
        public IngresoCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            foreach (Form formulario in Application.OpenForms)
            {
                formulario.Show();
            }

            Form login = new LoginModal();
            login.ShowDialog();
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form homeCliente = new HomeCliente();
            homeCliente.Show();
        }
    }
}
