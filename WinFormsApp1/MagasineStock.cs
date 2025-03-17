using Microsoft.Data.SqlClient;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using OfficeOpenXml;

namespace WinFormsApp1
{
    public partial class MagasineStock : Form
    {
        public int IdKlientit { get; private set; }

        public string EmriKlientit { get; private set; }
        public string MbiemriKlientit { get; private set; }

        private List<Tuple<string, string>> vehicles;

        private DataTable dataTable;
        private DataView dataView;
        private object txtBox1;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        private System.Windows.Forms.TextBox txtSearch;



        public MagasineStock()
        {
            InitializeComponent();
        }

        private void MagasineStock_Load(object sender, EventArgs e)
        {
            LoadTipe();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTipe()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            string cmd = "Select * FROM Stock";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, cnn);
            //cmd.CommandText = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //searchResult.DataSource = dt;
            dataGridView1.DataSource = dt;
            adapter.Dispose();
            dt.Dispose();
            //  cnn.Close
        }

        private void FilterMagazine() //search
        {
            string search = textBox1.Text.Trim();
            string query = @"SELECT * FROM Stock 
                     WHERE 
                         NrShasie LIKE @search OR 
                         Modeli LIKE @search OR 
                         Motorri LIKE @search OR 
                         Ngjyra LIKE @search OR 
                         VleraFaturave LIKE @search OR 
                         DataMberritjes LIKE @search OR 
                         Today LIKE @search OR 
                         Age LIKE @search OR 
                         KostoTransporti LIKE @search OR 
                         KostoSallonTVSH LIKE @search OR 
                         cmimiMe30 LIKE @search OR 
                         CmimiMe15 LIKE @search OR 
                         CmimiPerOAL6TVSH LIKE @search";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LoadTipe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterMagazine();
        }

        private void button3_Click(object sender, EventArgs e) //shes button
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<Tuple<string, string>> selectedVehicles = new List<Tuple<string, string>>();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string nrShasie = row.Cells["NrShasie"].Value.ToString();
                    string model = row.Cells["Modeli"].Value.ToString();
                    selectedVehicles.Add(new Tuple<string, string>(nrShasie, model));
                }


                ProcesiShitje shitje = new ProcesiShitje(selectedVehicles);
                DialogResult result = shitje.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InsertIntoShitje(shitje.IdKlientit, shitje.EmriKlientit, shitje.MbiemriKlientit, selectedVehicles, shitje.emrKompani);
                }
            }
            
        }


        private void InsertIntoShitje(int IdKlientit, string emri, string mbiemri, List<Tuple<string, string>> vehicles, string emerKompani)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {                   
                        foreach (var vehicle in vehicles)
                        {
                            string query = @"INSERT INTO Shitje 
                            (NrShasie, Modeli, IdKlientit, EmriKlientit, MbiemriKlientit, EmriKompanise) 
                            VALUES 
                            (@NrShasie, @Modeli, @IdKlientit, @EmriKlientit, @MbiemriKlientit, @EmriKompanise)";

                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@NrShasie", vehicle.Item1);
                                cmd.Parameters.AddWithValue("@Modeli", vehicle.Item2);
                                cmd.Parameters.AddWithValue("@IdKlientit", IdKlientit);
                                cmd.Parameters.AddWithValue("@EmriKlientit", emri);
                                cmd.Parameters.AddWithValue("@MbiemriKlientit", mbiemri);
                                cmd.Parameters.AddWithValue("@EmriKompanise", emerKompani);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                   
                        using (var package = new ExcelPackage(new FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets[0]; // Read first worksheet
                            DataTable dtNew = new DataTable();

                            int rowCount = worksheet.Dimension.Rows;

                            // ✅ Explicitly define DataTable columns to prevent missing columns
                            dtNew.Columns.Add("Modeli", typeof(string));
                            dtNew.Columns.Add("Motorri", typeof(string));
                            dtNew.Columns.Add("Ngjyra", typeof(string));
                            dtNew.Columns.Add("Nr Shasie", typeof(string));
                            dtNew.Columns.Add("Dt mberritjes", typeof(string)); // Will be converted to DateTime later
                            dtNew.Columns.Add("Today", typeof(DateTime)); // Auto-filled later
                            dtNew.Columns.Add("Age", typeof(int));
                            dtNew.Columns.Add("Vlere fature", typeof(string));
                            dtNew.Columns.Add("Kosto transporti", typeof(string));
                            dtNew.Columns.Add("Kosto ne sallon me TVSH €", typeof(string));
                            dtNew.Columns.Add("Cmimi me 30%", typeof(string));
                            dtNew.Columns.Add("Cmimi me 15%", typeof(string));
                            dtNew.Columns.Add("Cmimi per OAL 6% me TVSH", typeof(string));

                        // ✅ Add rows with proper column mapping
                        for (int row = 2; row <= rowCount; row++) // Skip header row
                        {
                            DataRow dr = dtNew.NewRow();

                            dr["Modeli"] = worksheet.Cells[row, 2].Text.Trim();  // Column B
                            dr["Motorri"] = worksheet.Cells[row, 3].Text.Trim(); // Column C
                            dr["Ngjyra"] = worksheet.Cells[row, 4].Text.Trim();  // Column D
                            dr["Nr Shasie"] = worksheet.Cells[row, 5].Text.Trim(); // Column E

                            // ✅ Convert "Dt mberritjes" safely to DateTime
                            string rawDate = worksheet.Cells[row, 6].Text.Trim(); // Column F
                            DateTime parsedDate;
                            dr["Dt mberritjes"] = DateTime.TryParse(rawDate, out parsedDate) ? parsedDate.ToString("yyyy-MM-dd") : DBNull.Value;

                            dr["Today"] = DateTime.Now; // Auto-filled

                            // ✅ Ensure numeric columns are converted properly
                            dr["Age"] = int.TryParse(worksheet.Cells[row, 8].Text, out int age) ? age : 0;  // Column H
                            dr["Vlere fature"] = worksheet.Cells[row, 9].Text.Trim();  // Column I
                            dr["Kosto transporti"] = worksheet.Cells[row, 10].Text.Trim();  // Column J
                            dr["Kosto ne sallon me TVSH €"] = worksheet.Cells[row, 11].Text.Trim();  // Column K
                            dr["Cmimi me 30%"] = worksheet.Cells[row, 12].Text.Trim();  // Column L
                            dr["Cmimi me 15%"] = worksheet.Cells[row, 13].Text.Trim();  // Column M
                            dr["Cmimi per OAL 6% me TVSH"] = worksheet.Cells[row, 14].Text.Trim();  // Column N

                            dtNew.Rows.Add(dr);
                        }

                        // ✅ Rebind DataTable to DataGridView
                        dataGridView1.DataSource = dtNew;
                        SaveExcelDataToDatabase(dtNew);
                    }




                }
            }
        }


        private HashSet<string> GetExistingNrShasie()
        {
            HashSet<string> existingNrShasie = new HashSet<string>();

            string query = "SELECT NrShasie FROM Stock";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existingNrShasie.Add(reader["NrShasie"].ToString());
                    }
                }
            }

            return existingNrShasie;
        }

        private void SaveExcelDataToDatabase(DataTable dataTable)
        {
            HashSet<string> existingNrShasie = GetExistingNrShasie(); // Get existing records from DB

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Database connection successful.");

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    int insertedCount = 0; // Track inserted rows

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string nrShasie = row["Nr Shasie"].ToString().Trim(); // Trim to prevent whitespace issues
                        Console.WriteLine($"Checking: {nrShasie}, Exists: {existingNrShasie.Contains(nrShasie)}");

                        if (!existingNrShasie.Contains(nrShasie)) // Only insert new records
                        {
                            string query = @"
                        INSERT INTO Stock 
                        (Modeli, Motorri, Ngjyra, NrShasie, DataMberritjes, Today, Age, VleraFaturave, 
                         KostoTransporti, KostoSallonTVSH, cmimiMe30, CmimiMe15, CmimiPerOAL6TVSH) 
                        VALUES 
                        (@Modeli, @Motorri, @Ngjyra, @NrShasie, @DataMberritjes, @Today, @Age, @VleraFaturave, 
                         @KostoTransporti, @KostoSallonTVSH, @cmimiMe30, @CmimiMe15, @CmimiPerOAL6TVSH)";

                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@NrShasie", nrShasie);
                                cmd.Parameters.AddWithValue("@Modeli", row["Modeli"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Motorri", row["Motorri"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Ngjyra", row["Ngjyra"] ?? DBNull.Value);

                                if (DateTime.TryParse(row["Dt mberritjes"]?.ToString(), out DateTime dtMberritjes))
                                    cmd.Parameters.AddWithValue("@DataMberritjes", dtMberritjes);
                                else
                                    cmd.Parameters.AddWithValue("@DataMberritjes", DBNull.Value);

                                cmd.Parameters.AddWithValue("@Today", DateTime.Now);

                                if (int.TryParse(row["Age"]?.ToString(), out int age))
                                    cmd.Parameters.AddWithValue("@Age", age);
                                else
                                    cmd.Parameters.AddWithValue("@Age", DBNull.Value);

                                cmd.Parameters.AddWithValue("@VleraFaturave", row["Vlere fature"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@KostoTransporti", row["Kosto transporti"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@KostoSallonTVSH", row["Kosto ne sallon me TVSH €"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@cmimiMe30", row["Cmimi me 30%"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@CmimiMe15", row["Cmimi me 15%"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@CmimiPerOAL6TVSH", row["Cmimi per OAL 6% me TVSH"] ?? DBNull.Value);

                                try
                                {
                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    Console.WriteLine($"Rows inserted: {rowsAffected}");
                                    if (rowsAffected > 0) insertedCount++;
                                }
                                catch (SqlException ex)
                                {
                                   
                                    Console.WriteLine($"SQL Exception: {ex.Message}");
                                }
                            }
                        }
                    }

                    transaction.Commit(); // Commit the transaction
                    Console.WriteLine($"Total rows inserted: {insertedCount}");
                }
            }
        }


    }
}
