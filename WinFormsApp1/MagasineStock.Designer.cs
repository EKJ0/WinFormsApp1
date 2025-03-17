namespace WinFormsApp1
{
    partial class MagasineStock
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(58, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1142, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(485, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(270, 68);
            button1.Name = "button1";
            button1.Size = new Size(140, 31);
            button1.TabIndex = 2;
            button1.Text = "Kerko";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 68);
            button2.Name = "button2";
            button2.Size = new Size(143, 31);
            button2.TabIndex = 3;
            button2.Text = "Pastro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 592);
            button3.Name = "button3";
            button3.Size = new Size(139, 55);
            button3.TabIndex = 4;
            button3.Text = "Shes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1027, 68);
            button4.Name = "button4";
            button4.Size = new Size(173, 31);
            button4.TabIndex = 5;
            button4.Text = "Import EXL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MagasineStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 659);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MagasineStock";
            Text = "MagasineStock";
            Load += MagasineStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}