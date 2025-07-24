using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Ad.UserInterface
{
    public partial class FormAfisareAnunturi : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public FormAfisareAnunturi()
        {
            InitializeComponent();


            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false; // Doar o linie poate fi selectată simultan.
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tbName_TextChanged(object sender, EventArgs e) { }


        //buton afisare anunturi utilizator
        private void afisareUtilizator_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vă rugăm să introduceți un nume de utilizator!");
                return;
            }

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
                            a.Category as 'Categorie',
                            p.FilePath as 'Cale foto'
                        FROM Advertisment a
                        JOIN [User] u ON a.IdUser = u.IdUser
                        JOIN [Picture] p ON p.AdId = a.AdId
                        WHERE u.Username = @Username
                        ORDER BY a.PublishDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Username", tbName.Text);

                        //  populăm un DataTable cu rezultatele
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        // populam dgv cu datele din dataTable
                        dgv.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {

                            MessageBox.Show("Nu există anunțuri pentru acest utilizator.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea anunțurilor: {ex.Message}");
            }
        }

        //buton afisare toate anunturile
        private void afisareTotala_Click(object sender, EventArgs e)
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
                            a.Category as 'Categorie',
                            p.FilePath as 'Cale foto'
                        FROM Advertisment a
                        JOIN [User] u ON a.IdUser = u.IdUser
                        JOIN [Picture] p ON a.AdId = p.AdId
                        ORDER BY a.PublishDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }


                        dgv.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {

                            MessageBox.Show("Nu există anunțuri în baza de date.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Eroare la încărcarea anunțurilor: {ex.Message}");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void FormAfisareAnunturi_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Pret_Total", con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out price))
                    {
                        
                        MessageBox.Show($"Pret total: {price:F2}"); 
                    }
                    else
                    {
                        MessageBox.Show("Rezultatul nu este valid sau este null.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la procedura: {ex.Message}");
                }
            }
        }
        private DataTable GetDataFromDatabase()
        {
            string connectionString = "Data Source=NATI;Initial Catalog=Produse;Integrated Security=True;Encrypt=True;TrustServer Certificate=True";
            string query = "SELECT * FROM Advertisment"; 

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            try
            {
                // Scriere antete in Excel
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                }

                // Scriere date in Excel
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                    }
                }

                // Salvare fisier Excel
                workbook.SaveAs(filePath);
                MessageBox.Show("Fișier Excel salvat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la exportul în Excel: {ex.Message}");
            }
            finally
            {
                // Curatare date excel
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            DataTable data = GetDataFromDatabase();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Salvează fișier Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(data, filePath);
            }
        }

    }
}

