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

namespace Ad.UserInterface
{
    public partial class FormModificareAnunt : Form
    {
        private readonly string connectionString;

        public FormModificareAnunt()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }


        private void nume_TextChanged(object sender, EventArgs e) { }
       

        // Buton afisare anunturi utilizator
        private void afisare_Click(object sender, EventArgs e)
        {
            
            string username = nume.Text;
            if (string.IsNullOrWhiteSpace(username)) 
            {
                
                MessageBox.Show("Vă rugăm introduceți un nume de utilizator!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Dacă numele este valid, căutăm anunțurile utilizatorului
            CautaAnunturi(username);
        }

        // Functie cautare anunturi ptr. un utilizator
        private void CautaAnunturi(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); 

            
                    string query = @"
                        SELECT a.AdId, a.Description, a.Price, a.PublishDate, a.Category 
                        FROM Advertisment a
                        JOIN [User] u ON a.IdUser = u.IdUser
                        WHERE u.Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Username", username);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); 

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Eroare la căutarea anunțurilor: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void descriereModificata_TextChanged(object sender, EventArgs e) { }



        private void pretNou_ValueChanged(object sender, EventArgs e) { }
        

        // Buton modificare anunt
        private void modificare_Click(object sender, EventArgs e)
        {
            // Verificăm dacă un anunț a fost selectat din DataGridView
            if (dataGridView1.SelectedRows.Count == 0) 
            {
                
                MessageBox.Show("Vă rugăm selectați un anunț din lista!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Obținem ID-ul anunțului selectat din dgv
            int adId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AdId"].Value);

            
            string descriereNoua = descriereModificata.Text;
            decimal pretNou = pret.Value;

            
            if (string.IsNullOrWhiteSpace(descriereNoua) && pretNou <= 0) 
            {
                
                MessageBox.Show("Vă rugăm completați corect descrierea și prețul!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

           
            ModificaAnunt(adId, descriereNoua, pretNou);
        }

        // Funcția modificarea anunt
        private void ModificaAnunt(int adId, string descriereNoua, decimal pretNou)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE Advertisment
                        SET Description = @Description, Price = @Price
                        WHERE AdId = @AdId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@AdId", adId);
                        command.Parameters.AddWithValue("@Description", descriereNoua);
                        command.Parameters.AddWithValue("@Price", pretNou);

                        
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0) 
                        {
                            
                            MessageBox.Show("Anunțul a fost modificat cu succes!", "Succes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            
                            MessageBox.Show("Nu a fost găsit niciun anunț cu ID-ul specificat.", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la modificarea anunțului: {ex.Message}", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eveniment selectare anunt din dgv
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // populam dgv cu datele noi
                descriereModificata.Text = selectedRow.Cells["Description"].Value?.ToString(); // nu se executa ToString daca valoarea e null
                pret.Value = Convert.ToDecimal(selectedRow.Cells["Price"].Value ?? 0); // punem 0 daca valoarea e null
            }
        }

        private void FormModificareAnunt_Load(object sender, EventArgs e) { }
        
    }
}
