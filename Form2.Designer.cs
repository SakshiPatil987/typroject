namespace AdvancedBloodReportApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBloodReport;
        private Button btnGenerateReport;
        private Button btnClear;

        // Disposing of components used in the form
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvBloodReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnGenerateReport = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBloodReport).BeginInit();
            SuspendLayout();
            // 
            // dgvBloodReport
            // 
            dgvBloodReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBloodReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvBloodReport.Location = new Point(28, 78);
            dgvBloodReport.Name = "dgvBloodReport";
            dgvBloodReport.RowHeadersWidth = 51;
            dgvBloodReport.Size = new Size(600, 300);
            dgvBloodReport.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(20, 370);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(120, 30);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(150, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(640, 450);
            Controls.Add(dgvBloodReport);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnClear);
            Name = "Form2";
            Text = "Advanced Blood Report";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBloodReport).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

