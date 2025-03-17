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

    public partial class Ngjyra : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        public string SelectColour { get; private set; }
        public Ngjyra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Ngjyra_Load(object sender, EventArgs e)
        {
            LoadTipe();
        }
        private void LoadTipe()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            string cmd = "select Kod, Ngjyra from NgjyraMakine";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectColour = dataGridView1.SelectedRows[0].Cells["Ngjyra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();  // Closes the Karburanti form
            }

        }
    }
}
