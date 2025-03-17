using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Shitje : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        public Shitje()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Shitje_Load(object sender, EventArgs e)
        {
            LoadTipe();
        }

        private void LoadTipe()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            string cmd = "SELECT * FROM Shitje";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterMagazine();
            label1.Text = $"Totali i Rezultateve: {dataGridView1.RowCount - 1}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FilterMagazine() //search
        {
            string search = textBox1.Text.Trim();
            string query = @"SELECT * FROM Shitje 
                     WHERE 
                         NrShasie LIKE @search OR 
                         Modeli LIKE @search OR 
                         IdKlientit LIKE @search OR
                         EmriKlientit LIKE @search OR
                         MbiemriKlientit LIKE @search OR
                         EmriKompanise LIKE @search;";

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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = $"Totali i Rezultateve:__";
            LoadTipe(); 
        }
    }
}
