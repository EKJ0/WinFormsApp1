namespace WinFormsApp1
{
    partial class HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            panel9 = new Panel();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            button6 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 65);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 33);
            label1.TabIndex = 2;
            label1.Text = "HOME PAGE";
            label1.UseCompatibleTextRendering = true;
            label1.Visible = false;
            label1.Click += label1_Click_1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.EnableOptimizedParameterBinding = false;
            // 
            // panel9
            // 
            panel9.AutoScroll = true;
            panel9.BackColor = Color.FromArgb(64, 64, 64);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel2);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 65);
            panel9.Name = "panel9";
            panel9.Size = new Size(330, 420);
            panel9.TabIndex = 2;
            panel9.Paint += panel9_Paint_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(12, 483);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 54);
            panel4.TabIndex = 4;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(19, 13);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(-26, -15);
            button3.Name = "button3";
            button3.Size = new Size(327, 73);
            button3.TabIndex = 3;
            button3.Text = "                Magazine Stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(12, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 54);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(-26, -15);
            button2.Name = "button2";
            button2.Size = new Size(349, 73);
            button2.TabIndex = 3;
            button2.Text = "Shitje";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(12, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 54);
            panel5.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Silver;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(-14, -7);
            button4.Name = "button4";
            button4.Size = new Size(329, 73);
            button4.TabIndex = 3;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.AppWorkspace;
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(12, 137);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 54);
            panel7.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(-14, -7);
            button6.Name = "button6";
            button6.Size = new Size(329, 73);
            button6.TabIndex = 3;
            button6.Text = "Optimizo";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 54);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(-23, -10);
            button1.Name = "button1";
            button1.Size = new Size(361, 73);
            button1.TabIndex = 3;
            button1.Text = "  Grafik gjate viteve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Silver;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(704, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(686, 0);
            button5.Name = "button5";
            button5.Size = new Size(192, 66);
            button5.TabIndex = 3;
            button5.Text = "    Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(button5);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(330, 419);
            panel6.Name = "panel6";
            panel6.Size = new Size(880, 66);
            panel6.TabIndex = 5;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1210, 485);
            Controls.Add(panel6);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
        public Panel panel1;
        private Panel panel9;
        private Panel panel4;
        private PictureBox pictureBox7;
        private Button button3;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Button button4;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Button button6;
        private PictureBox pictureBox6;
        private Button button5;
        public PictureBox pictureBox1;
        private Panel panel6;

        // public bool ControlBox { get; set; }
    }
}