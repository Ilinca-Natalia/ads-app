using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Ad.UserInterface
{
    
    public partial class FormStergereAnunt : Form
    {
        
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int currentUserId = -1; // ID-ul utilizatorului curent

        public FormStergereAnunt()
        {
            InitializeComponent(); 
            dgv.AutoGenerateColumns = true; 
            dgv.ReadOnly = true; //DataGridView doar citire
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgv.MultiSelect = false; // Se poate selecta doar o linie ptr. stergere
        }

        private void label2_Click(object sender, EventArgs e) { }

        // Buton cautare anunturi utilizator
        private void name_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text)) 
            {
                LoadUserAds(tbName.Text); 
            }
            else
            {
                MessageBox.Show("Vă rugăm să introduceți un nume de utilizator!");
                dgv.DataSource = null; // Golește DataGridView dacă numele este invalid
            }
        }

        // Buton stergere anunt
        private void stergere_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) // Verifică dacă a fost selectat un anunt ptr stergere
            {
                MessageBox.Show("Vă rugăm să selectați un anunț pentru ștergere!");
                return;
            }

            
            if (MessageBox.Show("Sunteți sigur că doriți să ștergeți acest anunț?",
                              "Confirmare ștergere",
                              MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            int adId = Convert.ToInt32(dgv.SelectedRows[0].Cells["AdId"].Value); // Obține ID-ul anunțului selectat

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction()) // incepe tranzactia
                {
                    try
                    {
                        // Șterge pozele anuntului selectat
                        string deletePicturesQuery = "DELETE FROM Picture WHERE AdId = @AdId";
                        using (SqlCommand cmd = new SqlCommand(deletePicturesQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdId", adId);
                            cmd.ExecuteNonQuery();
                        }

                        // Șterge anunțul selectat
                        string deleteAdQuery = "DELETE FROM Advertisment WHERE AdId = @AdId AND IdUser = @IdUser";
                        using (SqlCommand cmd = new SqlCommand(deleteAdQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdId", adId);
                            cmd.Parameters.AddWithValue("@IdUser", currentUserId);
                            int rowsAffected = cmd.ExecuteNonQuery(); //nr de randuri afectate

                            if (rowsAffected > 0) // Ștergere reușită
                            {
                                transaction.Commit(); 
                                MessageBox.Show("Anunțul a fost șters cu succes!");
                                LoadUserAds(tbName.Text); // Afiseaza anunturile ramase ale utilizatorului 
                            }
                            else
                            {
                                transaction.Rollback(); // Anuntul apartine altui utilizator
                                MessageBox.Show("Nu aveți dreptul să ștergeți acest anunț!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // eroare
                        MessageBox.Show($"Eroare la ștergerea anunțului: {ex.Message}");
                    }
                }
            }
        }

        // Selectare rand in dgv
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                dgv.Rows[e.RowIndex].Selected = true; 
            }
        }

        
        private void tbName_TextChanged(object sender, EventArgs e) { }

        // Metodă pentru afisarea anunturilor utilizatorului selectat
        private void LoadUserAds(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Obține ID-ul utilizatorului dupa numele introdus
                    string userQuery = "SELECT IdUser FROM [User] WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        var result = cmd.ExecuteScalar();

                        if (result != null) // Utilizator găsit
                        {
                            currentUserId = Convert.ToInt32(result);

                            // Obține anunțurile utilizatorului
                            string adsQuery = @"
                                SELECT a.AdId, a.Description, a.Price, a.PublishDate, a.Category 
                                FROM Advertisment a 
                                WHERE a.IdUser = @IdUser";

                            using (SqlCommand adsCmd = new SqlCommand(adsQuery, conn))
                            {
                                adsCmd.Parameters.AddWithValue("@IdUser", currentUserId);

                                DataTable dt = new DataTable();
                                using (SqlDataAdapter adapter = new SqlDataAdapter(adsCmd))
                                {
                                    adapter.Fill(dt); // Completează DataTable cu datele din baza de date
                                }

                                if (dt.Rows.Count > 0) // Nr anunțuri găsite
                                {
                                    dgv.Invoke((MethodInvoker)delegate
                                    {
                                        dgv.DataSource = dt; // Afișează anunțurile în DataGridView
                                        dgv.Refresh();
                                    });
                                }
                                else
                                {
                                    MessageBox.Show("Nu există anunțuri pentru acest utilizator");
                                    dgv.DataSource = null;
                                }
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Utilizatorul nu există!");
                            dgv.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea anunțurilor: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        
        private void FormStergereAnunt_Load(object sender, EventArgs e) { }
    }
}
