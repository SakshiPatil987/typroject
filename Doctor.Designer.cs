namespace typroject
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxDiseases = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button17 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDiseases
            // 
            comboBoxDiseases.FormattingEnabled = true;
            comboBoxDiseases.Location = new Point(188, 220);
            comboBoxDiseases.Name = "comboBoxDiseases";
            comboBoxDiseases.Size = new Size(121, 28);
            comboBoxDiseases.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.HideSelection = false;
            textBox3.Location = new Point(188, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 27);
            textBox4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 508);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(826, 138);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(21, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(132, 330);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 7;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(132, 377);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button17
            // 
            button17.Location = new Point(234, 331);
            button17.Name = "button17";
            button17.Size = new Size(75, 40);
            button17.TabIndex = 9;
            button17.Text = "Delete";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button5
            // 
            button5.Location = new Point(25, 374);
            button5.Name = "button5";
            button5.Size = new Size(75, 46);
            button5.TabIndex = 10;
            button5.Text = "Display";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button16_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 228);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 11;
            label1.Text = "Specialists";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 12;
            label2.Text = "Doctor ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 117);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 13;
            label3.Text = "Doctor Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 174);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 14;
            label4.Text = "Experience:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 292);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 15;
            label5.Text = "Phone:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button17);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxDiseases);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 436);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doctor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel2
            // 
            panel2.Location = new Point(430, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 318);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Location = new Point(495, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 125);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.cartoon_male_doctor_holding_a_clipboard_vector_25495014;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(463, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 341);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Location = new Point(-451, -66);
            panel4.Name = "panel4";
            panel4.Size = new Size(773, 60);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Location = new Point(0, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(788, 47);
            panel5.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(354, 8);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 19;
            label6.Text = "Doctor";
            // 
            // Doctor
            // 
            ClientSize = new Size(827, 658);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Doctor";
            Text = "Doctor Management";
            Load += Doctor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiseases;
        private System.Windows.Forms.TextBox textBox1; // Doctor ID
        private System.Windows.Forms.TextBox textBox2; // Doctor Name
        private System.Windows.Forms.TextBox textBox3; // Experience
        private System.Windows.Forms.TextBox textBox4; // Phone
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1; // Save Doctor
        private System.Windows.Forms.Button button2; // Load Doctors
        private System.Windows.Forms.Button button3; // Update Doctor
        private System.Windows.Forms.Button button17; // Delete Doctor
        private System.Windows.Forms.Button button5; // Refresh List
        private System.Windows.Forms.Label label1; // Disease Label
        private System.Windows.Forms.Label label2; // Doctor ID Label
        private System.Windows.Forms.Label label3; // Doctor Name Label
        private System.Windows.Forms.Label label4; // Experience Label
        private System.Windows.Forms.Label label5; // Phone Label
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
    }
}
