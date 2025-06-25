namespace typroject
{
    partial class Nurse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 27);
            textBox4.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(20, 195);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(126, 195);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 4;
            button2.Text = "View All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(239, 195);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 5;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 231);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(139, 231);
            button5.Name = "button5";
            button5.Size = new Size(100, 30);
            button5.TabIndex = 7;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 370);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 153);
            dataGridView2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 9;
            label1.Text = "Nurse ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 85);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 10;
            label2.Text = "Nurse Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 132);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 280);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nurse";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 53);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(358, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 31);
            label3.TabIndex = 1;
            label3.Text = "Nurse";
            // 
            // panel2
            // 
            panel2.Location = new Point(441, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 234);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(444, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 248);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(441, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 234);
            panel4.TabIndex = 0;
            // 
            // Nurse
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 535);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Name = "Nurse";
            Text = "Nurse Management";
            Load += Nurse_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
    }
}
