using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad.UserInterface
{
   
    public partial class FormAdaugareAnunt : Form
    {
        
        private readonly string connectionString;

        // Calea către imaginea selectată
        private string selectedImagePath;

        // Calea către folderul unde vor fi salvate pozele
        private readonly string picturesFolderPath;

        
        public FormAdaugareAnunt()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            picturesFolderPath = ConfigurationManager.AppSettings["PicturesFolderPath"];

            InitializeComponent();
            InitializePictureBox();
        }

        
        private void InitializePictureBox()
        {
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        
        private void label2_Click(object sender, EventArgs e) { }

      
        private void textBox3_TextChanged(object sender, EventArgs e) { }

    
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e) { }

        private void FormAdaugareAnunt_Load(object sender, EventArgs e) { }

        // Metoda salvare anunt
        private bool SalveazaAnunt(string username, string description, decimal price, int category, string imagePath)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

              
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    
                    string insertAdQuery = @"INSERT INTO Advertisment (Description, Price, PublishDate, IdUser, Category) 
                                          OUTPUT INSERTED.AdId
                                          SELECT @Description, @Price, GETDATE(), u.IdUser, @Category
                                          FROM [User] u
                                          WHERE u.Username = @Username";

                    int adId;
                    using (SqlCommand command = new SqlCommand(insertAdQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Category", category);

                        
                        object result = command.ExecuteScalar();
                        if (result == null)
                            throw new Exception("Nu s-a putut crea anunțul.");

                        adId = (int)result;
                    }

                
                    string insertPictureQuery = "INSERT INTO Picture (AdId, FilePath) VALUES (@AdId, @FilePath)";
                    using (SqlCommand command = new SqlCommand(insertPictureQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@AdId", adId);
                        command.Parameters.AddWithValue("@FilePath", imagePath);
                        command.ExecuteNonQuery();
                    }

                
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Daca există o eroare, se face rollback la tranzacție
                    transaction.Rollback();
                    MessageBox.Show($"Eroare la salvarea anunțului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // butonul de adăugare anunț
        private void adaugare_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vă rugăm introduceți numele utilizatorului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (string.IsNullOrWhiteSpace(tbDescription.Text) ||
                cbCategory.SelectedIndex == -1 ||
                price.Value <= 0)
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii și trebuie completate corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Copiază imaginea selectată într-un folder și obține calea 
            string destinationPath = CopyImageToFolder(selectedImagePath);
            if (string.IsNullOrWhiteSpace(destinationPath))
            {
                return;
            }

            string username = tbName.Text;
            string descriere = tbDescription.Text;
            decimal pret = price.Value;
            int categorie = cbCategory.SelectedIndex + 1;

            if (SalveazaAnunt(username, descriere, pret, categorie, destinationPath))
            {
                MessageBox.Show("Anunțul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        
        private void tbName_TextChanged(object sender, EventArgs e) { }

        // butonul de selectare a imaginii
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // filtrul de fișiere pentru imagini
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Selectează o imagine";

               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    try
                    {
                        // Încarcă și afișează imaginea selectată în pictureBox
                        using (var stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                            }
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la încărcarea imaginii: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedImagePath = null;
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        // Metoda copiere imagine  în folderul final
        private string CopyImageToFolder(string sourcePath)
        {
            try
            {
                
                if (!Directory.Exists(picturesFolderPath))
                {
                    Directory.CreateDirectory(picturesFolderPath);
                }

                // Creează un nume unic pentru imaginea copiata
                string fileName = Path.GetFileName(sourcePath);
                string uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
                string destinationPath = Path.Combine(picturesFolderPath, uniqueFileName);

                // Copiază fișierul imagine în folderul specificat
                File.Copy(sourcePath, destinationPath, true);
                return destinationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea imaginii: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
