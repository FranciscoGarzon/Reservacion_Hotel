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
    public partial class RegistroRecepcionista : Form
    {
        public RegistroRecepcionista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UE019OE;Initial Catalog=RESERVA_HOTEL;Integrated Security=True";
            string query = "INSERT INTO Recepcionista VALUES (@id, @name, @lastname, @email, @password)";

            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@id", IdentificacionRecepcionista.Text);
            myCommand.Parameters.AddWithValue("@name", NombreRecepcionista.Text);
            myCommand.Parameters.AddWithValue("@lastname", ApellidosRecepcionista.Text);
            myCommand.Parameters.AddWithValue("@email", CorreoRecepcionista.Text);
            myCommand.Parameters.AddWithValue("@password", ContrasenaRecepcionista.Text);

            myConnection.Open();
            MessageBox.Show("Connection Opened!");
            myCommand.ExecuteNonQuery();

            myConnection.Close();
            MessageBox.Show("Connection Closed!");
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
