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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Karburanti : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        public string SelectedFuel { get; private set; }

        public Karburanti()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            string cmd = "select Kodi, pershkrimiKarburantit from LlojiKarburantit";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Kodi"].HeaderText = "Kod";
            dataGridView1.Columns["pershkrimiKarburantit"].HeaderText = "Pershkrimi Karburantit";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectedFuel = dataGridView1.SelectedRows[0].Cells["pershkrimiKarburantit"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();  // Closes the Karburanti form
            }
            // Assuming the main form is called 'MainForm', create an instance of it and show it
            //BuyCar Car = new BuyCar();
            // Car.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }

   
}
