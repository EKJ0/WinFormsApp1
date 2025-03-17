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
    public partial class Forum : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        string query = "INSERT INTO Stock(Modeli, Motorri, Ngjjyra, NrShasie, DataMberritjes, Today, Age, VleraFaturave, KostoTransporti, KostoSallonTVSH, cmimiMe30, CmimiMe15, CmimiPerOAL6TVSH)" +
           "VALUES (@Modeli, @Motorri, @Ngjjyra, @NrShasie, @DataMberritjes, @Today, @Age, @VleraFaturave, @KostoTransporti, @KostoSallonTVSH, @cmimiMe30, @CmimiMe15, @CmimiPerOAL6TVSH)";
        string query1 = "DELETE FROM Stock WHERE NrShasie = @NrShasie;";

        public Forum()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;

            textBox1.MaxLength = 17;

        }

        private void EnableFormFields()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {
                cmd.Parameters.AddWithValue("@NrShasie", textBox1.Text);
                cmd.Parameters.AddWithValue("@Modeli", textBox2.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Makina u fshi me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nuk u gjet makina për të fshirë.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void Forum_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 17)
            {
                textBox1.BackColor = System.Drawing.Color.LightGray; // Indicate success
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White; 
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@NrShasie", textBox1.Text);
                cmd.Parameters.AddWithValue("@Modeli", textBox2.Text);
                cmd.Parameters.AddWithValue("@Motorri", textBox5.Text);
                cmd.Parameters.AddWithValue("@Ngjjyra", textBox4.Text);
                cmd.Parameters.AddWithValue("@DataMberritjes", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@VleraFaturave", textBox6.Text);
                cmd.Parameters.AddWithValue("@Today", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Age", textBox7.Text);
                cmd.Parameters.AddWithValue("@KostoTransporti", textBox7.Text);
                cmd.Parameters.AddWithValue("@KostoSallonTVSH", textBox7.Text);
                cmd.Parameters.AddWithValue("@cmimiMe30", textBox7.Text);
                cmd.Parameters.AddWithValue("@cmimiMe15", textBox7.Text);
                cmd.Parameters.AddWithValue("@CmimiPerOAL6TVSH", textBox7.Text);

                try
                {
                    // Open connection
                    con.Open();

                    // Execute Query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Show success message
                    if (rowsAffected > 0)
                    {
                        //this.TopMost = true; // Make the form appear above others
                        MessageBox.Show("Makina u regjistrua me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.TopMost = false; // Restore normal behavior
                    }
                    else
                    {
                        MessageBox.Show("Nuk u regjistrua makina!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.BringToFront();
                        this.Activate();
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    MessageBox.Show("Gabim gjatë regjistrimit: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableFormFields();
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";

            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;


            button3.Enabled = true; 
            button2.Enabled = true; 
            button5.Enabled = true; 
            button4.Enabled = true; 
            button1.Enabled = true;
        }
    }
}

