using System.Data;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static WinFormsApp1.Karburanti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Diagnostics;
using OfficeOpenXml;

namespace WinFormsApp1
{
    public partial class BuyCar : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        string query = "INSERT INTO Stock(Modeli, Motorri, Ngjjyra, NrShasie, DataMberritjes, Today, Age, VleraFaturave, KostoTransporti, KostoSallonTVSH, cmimiMe30%, CmimiMe15%, CmimiPerOAL6%TVSH)" +
            "VALUES (@Modeli, @Motorri, @Ngjjyra, @NrShasie, @DataMberritjes, @Today, @Age, @VleraFaturave, @KostoTransporti, @KostoSallonTVSH, @cmimiMe30%, @CmimiMe15%, @CmimiPerOAL6%TVSH)";
        string query3 = "INSERT INTO Vehicle (NrShasie, Cmimi, transmision, llojiIKarburantit, NgjyraEXhamave, Lloji, Viti, Pershkrimi, NgjyraMakines) " +
               "VALUES (@NrShasie, @Cmimi, @transmision, @llojiIKarburantit, @NgjyraEXhamave, @Lloji, @Viti, @Pershkrimi, @NgjyraMakines)";
        //string query1 = "DELETE FROM Vehicle WHERE CarCode = @CarCode;";
        string query1 = "DELETE FROM Stock WHERE CarCode = @NrShasie;";

        string query2 = "UPDATE Vehicle " +
                     "SET Cmimi = @Cmimi, transmision = @transmision, llojiIKarburantit = @llojiIKarburantit, " +
                     "NgjyraEXhamave = @NgjyraEXhamave, Lloji = @Lloji, Viti = @Viti, Pershkrimi = @Pershkrimi, NgjyraMakines = @NgjyraMakines " +
                     "WHERE CarCode = @CarCode";



        private void EnableFormFields()
        {
            textBox2.Enabled = true;
            textBox6.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
        }

        public BuyCar()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;

            textBox5.MaxLength = 15; // Ensure max length is 15
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Anullim button
        {

            //Debug.WriteLine("Anullim Clicked"); // Debugging
            // Show confirmation dialog
            //DialogResult result = MessageBox.Show(
            //   "A jeni i sigurt që dëshironi të anuloni?",
            // "Konfirmim",
            //M/essageBoxButtons.YesNo,
            //MessageBoxIcon.Question
            // );



            // Reset all inputs
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            button3.Enabled = true; // Fshi
            button2.Enabled = true; // Update
            button5.Enabled = true; // Regjistrim
            button4.Enabled = true; // Anullim
            button1.Enabled = true;

            textBox2.Enabled = false;
            textBox1.Enabled = true; //pershkrimi
            textBox6.Enabled = false;
            textBox5.Enabled = true; //nr. shasie
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //nr shasie
        {
            if (textBox5.Text.Length == 15)
            {
                textBox5.BackColor = System.Drawing.Color.LightGray; // Indicate success
            }
            else
            {
                textBox5.BackColor = System.Drawing.Color.White; // Reset color if not 15
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            Karburanti form2 = new Karburanti();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = form2.SelectedFuel;
            }
        }

        private void textBox6_DoubleClick(object sender, EventArgs e)
        {
            Ngjyra ngjyra = new Ngjyra();
            if (ngjyra.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = ngjyra.SelectColour;
            }

        }

        private void textBox7_DoubleClick(object sender, EventArgs e)
        {
            TipMakine tipi = new TipMakine();
            if (tipi.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = tipi.SelectType;
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShtim_Click(object sender, EventArgs e) //Fshi textbox
        {
            EnableFormFields();
            // Reset all inputs for a new entry

            textBox5.Text = ""; // Car Code
            textBox1.Text = ""; // Pershkrimi
            textBox2.Text = ""; // Karburanti
            textBox6.Text = ""; // Ngjyra e Makines
            textBox3.Text = ""; // Cmimi
            textBox4.Text = ""; // Viti
            textBox7.Text = ""; // Lloji

            comboBox1.SelectedIndex = -1; // Reset transmission dropdown
            comboBox3.SelectedIndex = -1; // Reset Ngjyra e Xhamave dropdown

            button3.Enabled = false; // Fshi
            button2.Enabled = false; // Update
            button5.Enabled = true;  // Regjistrim
            button4.Enabled = true;  // Anullim
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Fshi button
        {
            button5.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query1, con))
            {
                cmd.Parameters.AddWithValue("@NrShasie", textBox5.Text);
                cmd.Parameters.AddWithValue("@Pershkrimi", textBox1.Text);

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

        private void button2_Click_1(object sender, EventArgs e) //update button
        {

        }

        private void button5_Click(object sender, EventArgs e) //regjistrim button
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@NrShasie", textBox5.Text);
                cmd.Parameters.AddWithValue("@Pershkrimi", textBox1.Text);
                cmd.Parameters.AddWithValue("@transmision", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@llojiIKarburantit", textBox2.Text);
                cmd.Parameters.AddWithValue("@NgjyraMakines", textBox6.Text);
                cmd.Parameters.AddWithValue("@NgjyraEXhamave", comboBox3.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Cmimi", decimal.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Viti", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Lloji", textBox7.Text);



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

        private void BuyCar_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
