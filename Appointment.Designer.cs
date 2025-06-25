namespace DoctorAppointmentSystem
{
    partial class Appointment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox textBoxPatient;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button buttonDeleteAppointment;
        private System.Windows.Forms.DataGridView dataGridView1;

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
            labelPatientID = new Label();
            textBoxPatientID = new TextBox();
            labelPatientName = new Label();
            textBoxPatient = new TextBox();
            labelDoctor = new Label();
            comboBoxDoctors = new ComboBox();
            labelAvailability = new Label();
            labelDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelTime = new Label();
            dateTimePickerTime = new DateTimePicker();
            buttonBookAppointment = new Button();
            labelAppID = new Label();
            textBoxAppID = new TextBox();
            buttonDeleteAppointment = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelPatientID
            // 
            labelPatientID.AutoSize = true;
            labelPatientID.Location = new Point(20, 60);
            labelPatientID.Name = "labelPatientID";
            labelPatientID.Size = new Size(76, 20);
            labelPatientID.TabIndex = 0;
            labelPatientID.Text = "Patient ID:";
            // 
            // textBoxPatientID
            // 
            textBoxPatientID.Location = new Point(135, 53);
            textBoxPatientID.Name = "textBoxPatientID";
            textBoxPatientID.Size = new Size(200, 27);
            textBoxPatientID.TabIndex = 1;
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Location = new Point(20, 103);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new Size(101, 20);
            labelPatientName.TabIndex = 2;
            labelPatientName.Text = "Patient Name:";
            // 
            // textBoxPatient
            // 
            textBoxPatient.Location = new Point(135, 100);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(200, 27);
            textBoxPatient.TabIndex = 3;
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Location = new Point(20, 146);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(58, 20);
            labelDoctor.TabIndex = 4;
            labelDoctor.Text = "Doctor:";
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.Location = new Point(135, 138);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(200, 28);
            comboBoxDoctors.TabIndex = 5;
            // 
            // labelAvailability
            // 
            labelAvailability.AutoSize = true;
            labelAvailability.Location = new Point(372, 110);
            labelAvailability.Name = "labelAvailability";
            labelAvailability.Size = new Size(133, 20);
            labelAvailability.TabIndex = 6;
            labelAvailability.Text = "Doctor Availability";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(20, 184);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 7;
            labelDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(20, 233);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(45, 20);
            labelTime.TabIndex = 9;
            labelTime.Text = "Time:";
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(135, 226);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(200, 27);
            dateTimePickerTime.TabIndex = 10;
            // 
            // buttonBookAppointment
            // 
            buttonBookAppointment.Location = new Point(135, 281);
            buttonBookAppointment.Name = "buttonBookAppointment";
            buttonBookAppointment.Size = new Size(200, 30);
            buttonBookAppointment.TabIndex = 11;
            buttonBookAppointment.Text = "Book Appointment";
            buttonBookAppointment.Click += buttonBookAppointment_Click;
            // 
            // labelAppID
            // 
            labelAppID.AutoSize = true;
            labelAppID.Location = new Point(15, 339);
            labelAppID.Name = "labelAppID";
            labelAppID.Size = new Size(119, 20);
            labelAppID.TabIndex = 12;
            labelAppID.Text = "Appointment ID:";
            // 
            // textBoxAppID
            // 
            textBoxAppID.Location = new Point(145, 339);
            textBoxAppID.Name = "textBoxAppID";
            textBoxAppID.Size = new Size(200, 27);
            textBoxAppID.TabIndex = 13;
            // 
            // buttonDeleteAppointment
            // 
            buttonDeleteAppointment.Location = new Point(372, 334);
            buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            buttonDeleteAppointment.Size = new Size(150, 30);
            buttonDeleteAppointment.TabIndex = 14;
            buttonDeleteAppointment.Text = "Delete Appointment";
            buttonDeleteAppointment.Click += buttonDeleteAppointment_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 148);
            dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 16;
            label1.Text = "Appointment";
            // 
            // Appointment
            // 
            ClientSize = new Size(650, 550);
            Controls.Add(label1);
            Controls.Add(labelPatientID);
            Controls.Add(textBoxPatientID);
            Controls.Add(labelPatientName);
            Controls.Add(textBoxPatient);
            Controls.Add(labelDoctor);
            Controls.Add(comboBoxDoctors);
            Controls.Add(labelAvailability);
            Controls.Add(labelDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelTime);
            Controls.Add(dateTimePickerTime);
            Controls.Add(buttonBookAppointment);
            Controls.Add(labelAppID);
            Controls.Add(textBoxAppID);
            Controls.Add(buttonDeleteAppointment);
            Controls.Add(dataGridView1);
            Name = "Appointment";
            Text = "Doctor Appointment System";
            Load += Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}

