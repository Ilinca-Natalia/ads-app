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
    public partial class FormCautareAnunturi : Form
    {
     
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public FormCautareAnunturi()
        {
            InitializeComponent();

          
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true; 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridView1.MultiSelect = false; 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            LoadCategories(); // incarcare categoriile din baza de date
        }

        // Metoda incarcare categ din comboBox
        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); 

                    
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT CAST(Category AS VARCHAR(50)) AS Category FROM Advertisment ORDER BY Category", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cb.Items.Add("Toate categoriile"); 
                            while (reader.Read())
                            {
                               
                                if (!reader.IsDBNull(0))
                                {
                                    var category = reader.GetString(0);
                                    cb.Items.Add(category); 
                                }
                            }
                        }
                    }
                }
                cb.SelectedIndex = 0; // Setează prima opțiune 
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Eroare la încărcarea categoriilor: {ex.Message}");
            }
        }

     
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // conditie valoarea minimă <valoarea maximă
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e) { }
        

      
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // cond valoarea maximă > valoarea minimă
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
        }

        // Metoda pentru căutare 
        private void cautare_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.AdId,
                    u.Username as 'Utilizator',
                    a.Description as 'Descriere',
                    a.Price as 'Preț',
                    a.PublishDate as 'Data Publicării',
                    CAST(a.Category AS VARCHAR(50)) as 'Categorie'
                FROM Advertisment a
                JOIN [User] u ON a.IdUser = u.IdUser
                WHERE 1=1
                AND (@Category IS NULL OR CAST(a.Category AS VARCHAR(50)) = @Category)
                AND (@MinPrice = 0 OR a.Price >= @MinPrice)
                AND (@MaxPrice = 0 OR a.Price <= @MaxPrice)
                ORDER BY a.PublishDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        string selectedCategory = cb.SelectedIndex == 0 ? null : cb.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@Category", (object)selectedCategory ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MinPrice", numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("@MaxPrice", numericUpDown2.Value);

                        
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView1.DataSource = dt; 

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nu s-au găsit rezultate pentru criteriile selectate.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la căutarea anunțurilor: {ex.Message}");
            }
        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        

        private void FormCautareAnunturi_Load(object sender, EventArgs e) { }
        
    }
}
