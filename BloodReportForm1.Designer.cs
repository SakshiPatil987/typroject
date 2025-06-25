namespace BloodReportManagement
{
    partial class BloodReportForm1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPatientID, lblPatientName, lblTestDate, lblRbcCount, lblWbcCount, lblPlateletCount, lblHemoglobin;
        private System.Windows.Forms.TextBox txtPatientID, txtPatientName, txtRbcCount, txtWbcCount, txtPlateletCount, txtHemoglobin;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Button btnAddReport, btnExportPdf;
        private System.Windows.Forms.DataGridView dataGridViewReports;

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
            lblPatientID = new Label();
            txtPatientID = new TextBox();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblTestDate = new Label();
            dtpTestDate = new DateTimePicker();
            lblRbcCount = new Label();
            txtRbcCount = new TextBox();
            lblWbcCount = new Label();
            txtWbcCount = new TextBox();
            lblPlateletCount = new Label();
            txtPlateletCount = new TextBox();
            lblHemoglobin = new Label();
            txtHemoglobin = new TextBox();
            btnAddReport = new Button();
            btnExportPdf = new Button();
            dataGridViewReports = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // lblPatientID
            // 
            lblPatientID.Location = new Point(20, 66);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(100, 23);
            lblPatientID.TabIndex = 0;
            lblPatientID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(150, 52);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(200, 27);
            txtPatientID.TabIndex = 1;
            // 
            // lblPatientName
            // 
            lblPatientName.Location = new Point(20, 101);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(120, 23);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(150, 85);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(200, 27);
            txtPatientName.TabIndex = 3;
            // 
            // lblTestDate
            // 
            lblTestDate.Location = new Point(20, 137);
            lblTestDate.Name = "lblTestDate";
            lblTestDate.Size = new Size(100, 23);
            lblTestDate.TabIndex = 4;
            lblTestDate.Text = "Test Date:";
            // 
            // dtpTestDate
            // 
            dtpTestDate.Location = new Point(150, 132);
            dtpTestDate.Name = "dtpTestDate";
            dtpTestDate.Size = new Size(200, 27);
            dtpTestDate.TabIndex = 5;
            // 
            // lblRbcCount
            // 
            lblRbcCount.Location = new Point(20, 176);
            lblRbcCount.Name = "lblRbcCount";
            lblRbcCount.Size = new Size(100, 23);
            lblRbcCount.TabIndex = 6;
            lblRbcCount.Text = "RBC Count:";
            // 
            // txtRbcCount
            // 
            txtRbcCount.Location = new Point(150, 172);
            txtRbcCount.Name = "txtRbcCount";
            txtRbcCount.Size = new Size(200, 27);
            txtRbcCount.TabIndex = 7;
            // 
            // lblWbcCount
            // 
            lblWbcCount.Location = new Point(20, 218);
            lblWbcCount.Name = "lblWbcCount";
            lblWbcCount.Size = new Size(100, 23);
            lblWbcCount.TabIndex = 8;
            lblWbcCount.Text = "WBC Count:";
            // 
            // txtWbcCount
            // 
            txtWbcCount.Location = new Point(150, 214);
            txtWbcCount.Name = "txtWbcCount";
            txtWbcCount.Size = new Size(200, 27);
            txtWbcCount.TabIndex = 9;
            // 
            // lblPlateletCount
            // 
            lblPlateletCount.Location = new Point(20, 257);
            lblPlateletCount.Name = "lblPlateletCount";
            lblPlateletCount.Size = new Size(120, 23);
            lblPlateletCount.TabIndex = 10;
            lblPlateletCount.Text = "Platelet Count:";
            // 
            // txtPlateletCount
            // 
            txtPlateletCount.Location = new Point(150, 253);
            txtPlateletCount.Name = "txtPlateletCount";
            txtPlateletCount.Size = new Size(200, 27);
            txtPlateletCount.TabIndex = 11;
            // 
            // lblHemoglobin
            // 
            lblHemoglobin.Location = new Point(20, 296);
            lblHemoglobin.Name = "lblHemoglobin";
            lblHemoglobin.Size = new Size(100, 23);
            lblHemoglobin.TabIndex = 12;
            lblHemoglobin.Text = "Hemoglobin Level:";
            // 
            // txtHemoglobin
            // 
            txtHemoglobin.Location = new Point(150, 292);
            txtHemoglobin.Name = "txtHemoglobin";
            txtHemoglobin.Size = new Size(200, 27);
            txtHemoglobin.TabIndex = 13;
            txtHemoglobin.TextChanged += txtHemoglobin_TextChanged;
            // 
            // btnAddReport
            // 
            btnAddReport.Location = new Point(20, 344);
            btnAddReport.Name = "btnAddReport";
            btnAddReport.Size = new Size(120, 30);
            btnAddReport.TabIndex = 14;
            btnAddReport.Text = "Add Report";
            btnAddReport.Click += btnAddReport_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(150, 344);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(120, 30);
            btnExportPdf.TabIndex = 15;
            btnExportPdf.Text = "Export PDF";
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(12, 380);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.Size = new Size(500, 200);
            dataGridViewReports.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 17;
            label1.Text = "Blood Report";
            // 
            // BloodReportForm1
            // 
            ClientSize = new Size(550, 605);
            Controls.Add(label1);
            Controls.Add(lblPatientID);
            Controls.Add(txtPatientID);
            Controls.Add(lblPatientName);
            Controls.Add(txtPatientName);
            Controls.Add(lblTestDate);
            Controls.Add(dtpTestDate);
            Controls.Add(lblRbcCount);
            Controls.Add(txtRbcCount);
            Controls.Add(lblWbcCount);
            Controls.Add(txtWbcCount);
            Controls.Add(lblPlateletCount);
            Controls.Add(txtPlateletCount);
            Controls.Add(lblHemoglobin);
            Controls.Add(txtHemoglobin);
            Controls.Add(btnAddReport);
            Controls.Add(btnExportPdf);
            Controls.Add(dataGridViewReports);
            Name = "BloodReportForm1";
            Text = "Blood Report Management System";
            Load += BloodReportForm1_Load_3;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}

