
namespace HospitalBilling
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblActualPay;
        private System.Windows.Forms.TextBox txtActualPay;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.Button btnExportPDF;

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
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDoctor = new Label();
            cmbDoctor = new ComboBox();
            btnRegisterPatient = new Button();
            dataGridViewPatients = new DataGridView();
            lblServices = new Label();
            clbServices = new CheckedListBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblActualPay = new Label();
            txtActualPay = new TextBox();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            btnGenerateBill = new Button();
            dataGridViewBills = new DataGridView();
            btnExportPDF = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBills).BeginInit();
            SuspendLayout();
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(12, 68);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(101, 20);
            lblPatientName.TabIndex = 0;
            lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(120, 61);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(150, 27);
            txtPatientName.TabIndex = 1;
            txtPatientName.TextChanged += txtPatientName_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 102);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 95);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(20, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(120, 132);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(150, 28);
            cmbGender.TabIndex = 5;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(20, 177);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(58, 20);
            lblDoctor.TabIndex = 6;
            lblDoctor.Text = "Doctor:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.Items.AddRange(new object[] { "Dr. Smith", "Dr. Johnson", "Dr. Brown" });
            cmbDoctor.Location = new Point(120, 170);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(150, 28);
            cmbDoctor.TabIndex = 7;
            // 
            // btnRegisterPatient
            // 
            btnRegisterPatient.Location = new Point(120, 223);
            btnRegisterPatient.Name = "btnRegisterPatient";
            btnRegisterPatient.Size = new Size(150, 30);
            btnRegisterPatient.TabIndex = 8;
            btnRegisterPatient.Text = "Register Patient";
            btnRegisterPatient.Click += BtnRegisterPatient_Click;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeight = 29;
            dataGridViewPatients.Location = new Point(20, 268);
            dataGridViewPatients.MultiSelect = false;
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 51;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(486, 120);
            dataGridViewPatients.TabIndex = 9;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Location = new Point(450, 17);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(109, 20);
            lblServices.TabIndex = 10;
            lblServices.Text = "Select Services:";
            // 
            // clbServices
            // 
            clbServices.Location = new Point(450, 45);
            clbServices.Name = "clbServices";
            clbServices.Size = new Size(200, 92);
            clbServices.TabIndex = 11;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(450, 140);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(96, 20);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "Discount (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(580, 137);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 27);
            txtDiscount.TabIndex = 13;
            // 
            // lblActualPay
            // 
            lblActualPay.AutoSize = true;
            lblActualPay.Location = new Point(450, 170);
            lblActualPay.Name = "lblActualPay";
            lblActualPay.Size = new Size(97, 20);
            lblActualPay.TabIndex = 14;
            lblActualPay.Text = "Amount Paid:";
            // 
            // txtActualPay
            // 
            txtActualPay.Location = new Point(580, 170);
            txtActualPay.Name = "txtActualPay";
            txtActualPay.Size = new Size(100, 27);
            txtActualPay.TabIndex = 15;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(450, 200);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(124, 20);
            lblPaymentMethod.TabIndex = 16;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Insurance", "UPI", "Bank Transfer" });
            cmbPaymentMethod.Location = new Point(580, 200);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(120, 28);
            cmbPaymentMethod.TabIndex = 17;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.Location = new Point(512, 250);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(150, 30);
            btnGenerateBill.TabIndex = 18;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.Click += BtnGenerateBill_Click;
            // 
            // dataGridViewBills
            // 
            dataGridViewBills.ColumnHeadersHeight = 29;
            dataGridViewBills.Location = new Point(20, 406);
            dataGridViewBills.MultiSelect = false;
            dataGridViewBills.Name = "dataGridViewBills";
            dataGridViewBills.RowHeadersWidth = 51;
            dataGridViewBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBills.Size = new Size(660, 120);
            dataGridViewBills.TabIndex = 19;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(540, 532);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(140, 30);
            btnExportPDF.TabIndex = 20;
            btnExportPDF.Text = "Export Bill as PDF";
            btnExportPDF.Click += BtnExportPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 21;
            label1.Text = "Billing department";
            // 
            // MainForm
            // 
            ClientSize = new Size(700, 574);
            Controls.Add(label1);
            Controls.Add(lblPatientName);
            Controls.Add(txtPatientName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblDoctor);
            Controls.Add(cmbDoctor);
            Controls.Add(btnRegisterPatient);
            Controls.Add(dataGridViewPatients);
            Controls.Add(lblServices);
            Controls.Add(clbServices);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblActualPay);
            Controls.Add(txtActualPay);
            Controls.Add(lblPaymentMethod);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(btnGenerateBill);
            Controls.Add(dataGridViewBills);
            Controls.Add(btnExportPDF);
            Name = "MainForm";
            Text = "Hospital Billing System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}







