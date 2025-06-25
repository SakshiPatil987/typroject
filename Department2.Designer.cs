namespace typroject
{
    partial class Department2
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department2));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            comboBoxDept = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            Department = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 27);
            textBox3.TabIndex = 2;
            // 
            // comboBoxDept
            // 
            comboBoxDept.FormattingEnabled = true;
            comboBoxDept.Location = new Point(234, 106);
            comboBoxDept.Name = "comboBoxDept";
            comboBoxDept.Size = new Size(147, 28);
            comboBoxDept.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(6, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(135, 245);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 5;
            button2.Text = "View All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(135, 296);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 6;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(273, 245);
            button4.Name = "button4";
            button4.Size = new Size(108, 39);
            button4.TabIndex = 7;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(273, 290);
            button5.Name = "button5";
            button5.Size = new Size(104, 41);
            button5.TabIndex = 8;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 303);
            button6.Name = "button6";
            button6.Size = new Size(75, 33);
            button6.TabIndex = 9;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 472);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 150);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 11;
            label1.Text = "Department ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 190);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 13;
            label3.Text = "Phone No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 14;
            label4.Text = "Department";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(comboBoxDept);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(0, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 379);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Department";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(553, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 355);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(Department);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 65);
            panel2.TabIndex = 17;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.FlatStyle = FlatStyle.System;
            Department.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Department.Location = new Point(439, 20);
            Department.Name = "Department";
            Department.Size = new Size(131, 31);
            Department.TabIndex = 0;
            Department.Text = "Department";
            Department.Click += label2_Click;
            // 
            // Department2
            // 
            ClientSize = new Size(990, 634);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Department2";
            Text = "Department Management";
            Load += Department2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;

        // Labels
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel2;
        private Label Department;
    }
}
