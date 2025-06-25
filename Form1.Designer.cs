namespace PatientInfoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize components
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBoxDiseases = new ComboBox();
            comboBoxDoctors = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 1;
            // 
            // comboBoxDiseases
            // 
            comboBoxDiseases.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiseases.FormattingEnabled = true;
            comboBoxDiseases.Location = new Point(150, 142);
            comboBoxDiseases.Name = "comboBoxDiseases";
            comboBoxDiseases.Size = new Size(200, 28);
            comboBoxDiseases.TabIndex = 2;
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(150, 198);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(200, 28);
            comboBoxDoctors.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(150, 248);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 4;
            button1.Text = "Add Patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(750, 133);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 68);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Patient ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 7;
            label2.Text = "Patient Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 150);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "Disease:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 9;
            label4.Text = "Reference Doctor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 9);
            label5.Name = "label5";
            label5.Size = new Size(109, 31);
            label5.TabIndex = 10;
            label5.Text = "Diagnosis";
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBoxDoctors);
            Controls.Add(comboBoxDiseases);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Patient Information App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxDiseases;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label5;
    }
}
