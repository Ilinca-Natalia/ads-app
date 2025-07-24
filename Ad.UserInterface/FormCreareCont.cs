using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ad.UserInterface
{
    public partial class FormCreareCont : Form
    {
        
        private readonly string connectionString;

        public FormCreareCont()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            tbPassword.UseSystemPasswordChar = true; // Secretizare parola
        }

        private void FormCreareCont_Load(object sender, EventArgs e){}


        private void label1_Click(object sender, EventArgs e) { }
        

        private bool VerificaUtilizatorExistent(string username)
        {
            try
            {
                // using ptr. a asigura inchiderea conexiunii
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la verificarea utilizatorului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SalveazaUtilizator(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [User] (Username, Password) VALUES (@Username, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
    
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execută comanda SQL 
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Eroare la salvarea utilizatorului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Buton creare cont
        private void cont_Click(object sender, EventArgs e)
        {
            // Verificare câmpuri necompletate
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = tbName.Text;
            string password = tbPassword.Text;

            
            if (VerificaUtilizatorExistent(username))
            {
                MessageBox.Show("Acest nume de utilizator există deja!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (SalveazaUtilizator(username, password))
            {
                MessageBox.Show($"Contul pentru {username} a fost creat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
        }
    }
}
