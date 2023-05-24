using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservacion_Hotel
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
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

            Form signup = new SignupModal();
            signup.ShowDialog();
        }

        private void CrearCuentaBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UE019OE;Initial Catalog=RESERVA_HOTEL;Integrated Security=True";
            string query = "INSERT INTO CLIENTES VALUES (@id, @name, @phone, @email, @password)";

            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@id", Convert.ToInt64(IdentificacionCliente.Text));
            myCommand.Parameters.AddWithValue("@name", $"{NombreCliente.Text} {ApellidosCliente.Text}");
            myCommand.Parameters.AddWithValue("@phone", TelefonoCliente.Text);
            myCommand.Parameters.AddWithValue("@email", CorreoCliente.Text);
            myCommand.Parameters.AddWithValue("@password", ContrasenaCliente.Text);

            myConnection.Open();
            MessageBox.Show("Connection Opened!");
            myCommand.ExecuteNonQuery();

            myConnection.Close();
            MessageBox.Show("Connection Closed!");
        }
    }
}
