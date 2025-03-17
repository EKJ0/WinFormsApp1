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
//using FontAwsome.Sharp; 


namespace WinFormsApp1
{
    public partial class HOME : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CarCompanyDB"].ConnectionString;

        private Form CurrentChildForm;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public HOME()
        {
            InitializeComponent();
        }
        

        private void HOME_Load(object sender, EventArgs e)
        {
            dragging = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //NightControlBox   
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            this.ControlBox = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forum car = new Forum();
            car.StartPosition = FormStartPosition.Manual;
            car.Location = new Point(this.Location.X + 300, this.Location.Y + 53);
            car.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MagasineStock magazine = new MagasineStock();
            magazine.StartPosition = FormStartPosition.Manual;
            magazine.Location = new Point(this.Location.X + 300, this.Location.Y + 53);
            magazine.ShowDialog();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form ChildForm)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Shitje shitje = new Shitje();
            shitje.StartPosition = FormStartPosition.Manual;
            shitje.Location = new Point(this.Location.X + 300, this.Location.Y + 53);
            shitje.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.BringToFront();
        }
    }
}
