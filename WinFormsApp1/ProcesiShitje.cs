using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class ProcesiShitje : Form
    {
        public int IdKlientit {  get; private set; }
        public string EmriKlientit { get; private set; }
        public string MbiemriKlientit { get; private set; }
        public string emrKompani { get;  set; }

        private List<Tuple<string, string>> vehicles;

        public ProcesiShitje(List<Tuple<string, string>> selectedVehicles) 
        {
            InitializeComponent();
            vehicles = selectedVehicles;

            //this.emrKompani = emriKompani;
        }
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 2)
            {
                textBox2.BackColor = Color.White; // Change to normal color when 2 or more characters are entered
            }
            else
            {
                textBox2.BackColor = Color.Gray; // Keep it gray if less than 2 characters
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ProcesiShitje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today; // Disable past dates
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Nuk mund te zgjedhesh kete date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Value = DateTime.Today; // Reset the value to today
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gray; // Set the background color to gray initially
            textBox2.BackColor =Color.Gray;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 2)
            {
                textBox1.BackColor = Color.White; // Change to normal color when 2 or more characters are entered
            }
            else 
            {
                textBox1.BackColor = Color.Gray; // Keep it gray if less than 2 characters
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //VAZHDO
        private void button2_Click(object sender, EventArgs e)
        {
            string emri = textBox1.Text.Trim();
            string mbiemri = textBox2.Text.Trim();
            string emriKompanise = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(emri) || string.IsNullOrEmpty(mbiemri))
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query2 = "SELECT ID FROM Customer WHERE Emer = @Emer AND Mbiemer = @Mbiemer";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query2, con))
            {
                cmd.Parameters.AddWithValue("@Emer", emri);
                cmd.Parameters.AddWithValue("@Mbiemer", mbiemri);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        IdKlientit = Convert.ToInt32(result);
                        EmriKlientit = emri;
                        MbiemriKlientit = mbiemri;
                        emrKompani = emriKompanise; 
                        this.DialogResult = DialogResult.OK;
                        
                    }
                    else
                    {
                        MessageBox.Show("Klienti nuk u gjet në databazë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë kërkimit: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //REGJISTRIM 
        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Customer 
            (Emer, Mbiemer, Email, NRidentifikimi, klasaEpatentes, nrTelefoni, Shtetesia, EmerKompanie, Industria, AdresaeKompanies, DataeBlerjes)
        OUTPUT INSERTED.ID
        VALUES 
            (@Emer, @Mbiemer, @Email, @NRidentifikimi, @klasaEpatentes, @nrTelefoni, @Shtetesia, @EmerKompanie, @Industria, @AdresaeKompanies, @DataeBlerjes)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Assign parameters
                cmd.Parameters.AddWithValue("@Emer", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Mbiemer", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@NRidentifikimi", textBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@klasaEpatentes", textBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@nrTelefoni", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Shtetesia", textBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@EmerKompanie", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Industria", textBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@AdresaeKompanies", textBox9.Text.Trim());

                // Ensure the date format is correct
                cmd.Parameters.AddWithValue("@DataeBlerjes", dateTimePicker1.Value.Date);

                try
                {
                    con.Open();
                    // Get the inserted ID
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        IdKlientit = Convert.ToInt32(result);
                        EmriKlientit = textBox1.Text.Trim();
                        MbiemriKlientit = textBox2.Text.Trim();

                        MessageBox.Show("Klienti u regjistrua me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.DialogResult = DialogResult.OK;

                        
                    }
                }
                catch (Exception ex)
                {
                    // Show detailed error message
                    MessageBox.Show("Gabim gjatë regjistrimit: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
