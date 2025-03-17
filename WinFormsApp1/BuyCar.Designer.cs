namespace WinFormsApp1
{
    partial class BuyCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox5 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(482, 90);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Manual", "Automatic", "Automated Manual", "Continiously Variable" });
            comboBox1.Location = new Point(267, 154);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(481, 36);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Normale", "50%", "Te erreta" });
            comboBox3.Location = new Point(267, 336);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(481, 36);
            comboBox3.TabIndex = 8;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 90);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 34);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(1092, 526);
            button4.Name = "button4";
            button4.Size = new Size(168, 59);
            button4.TabIndex = 12;
            button4.Text = "Anullim";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 157);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 13;
            label1.Text = "Transmision";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 93);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 14;
            label2.Text = "Pershkrimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 93);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 15;
            label3.Text = "NR Shasie";
            // 
            // button1
            // 
            button1.Location = new Point(843, 26);
            button1.Name = "button1";
            button1.Size = new Size(135, 49);
            button1.TabIndex = 16;
            button1.Text = "Shtim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonShtim_Click;
            // 
            // button2
            // 
            button2.Location = new Point(984, 26);
            button2.Name = "button2";
            button2.Size = new Size(135, 49);
            button2.TabIndex = 17;
            button2.Text = "Modifikim";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(1125, 26);
            button3.Name = "button3";
            button3.Size = new Size(135, 49);
            button3.TabIndex = 18;
            button3.Text = "Fshi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(901, 526);
            button5.Name = "button5";
            button5.Size = new Size(168, 59);
            button5.TabIndex = 19;
            button5.Text = "Regjistrim";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 216);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 20;
            label4.Text = "Karburanti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 278);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 21;
            label5.Text = "Ngjyra";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 339);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 22;
            label6.Text = "Ngjyra e xhamave";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 397);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 23;
            label7.Text = "Cmimi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 394);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 24;
            label8.Text = "Viti i prodhimit";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 477);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 25;
            label9.Text = "Tipi i makines";
            label9.Click += label9_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(267, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 34);
            textBox3.TabIndex = 28;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(589, 388);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 34);
            textBox4.TabIndex = 29;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(267, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(480, 34);
            textBox6.TabIndex = 30;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.DoubleClick += textBox6_DoubleClick;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(256, 471);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(491, 34);
            textBox7.TabIndex = 31;
            textBox7.DoubleClick += textBox7_DoubleClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(476, 34);
            textBox2.TabIndex = 32;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.DoubleClick += textBox2_DoubleClick;
            // 
            // BuyCar
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 612);
            Controls.Add(textBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(20, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuyCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Forum";
            Load += BuyCar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private TextBox textBox5;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox2;
    }
}
