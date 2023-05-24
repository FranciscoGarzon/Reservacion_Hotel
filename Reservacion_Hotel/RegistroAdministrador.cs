using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reservacion_Hotel
{
    public partial class RegistroAdministrador : Form
    {
        public RegistroAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UE019OE;Initial Catalog=RESERVA_HOTEL;Integrated Security=True";
            string query = "INSERT INTO ADMINISTRADOR VALUES (@id, @name, @lastname, @password)";

            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@id", IdentificacionAdministrador.Text);
            myCommand.Parameters.AddWithValue("@name", NombreAdministrador.Text);
            myCommand.Parameters.AddWithValue("@lastname", ApellidosAdministrador.Text);
            myCommand.Parameters.AddWithValue("@password", ContrasenaAdministrador.Text);

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

        private void RegistroAdministrador_Load(object sender, EventArgs e)
        {
            
        }
    }
}
