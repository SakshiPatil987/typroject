

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoctorAppointmentSystem
{
    public partial class Appointment : Form
    {
        private List<Doctor> doctors;
        private List<AppointmentData> appointments;

        public Appointment()
        {
            InitializeComponent();
            InitializeDoctors();
            appointments = new List<AppointmentData>();
        }

        private void InitializeDoctors()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. Smith", "Cardiologist", true),
                new Doctor("Dr. Johnson", "Neurologist", true),
                new Doctor("Dr. Lee", "Dermatologist", true)
            };

            comboBoxDoctors.DataSource = doctors;
            comboBoxDoctors.DisplayMember = "Name";
        }

        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoctors.SelectedItem is Doctor selectedDoctor)
            {
                UpdateDoctorAvailabilityLabel(selectedDoctor);
            }
        }

        private void UpdateDoctorAvailabilityLabel(Doctor doctor)
        {
            if (doctor.Available)
            {
                labelAvailability.Text = "Doctor Available";
                labelAvailability.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelAvailability.Text = "Doctor Not Available";
                labelAvailability.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonBookAppointment_Click(object sender, EventArgs e)
        {
            if (comboBoxDoctors.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxPatient.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientID.Text))
            {
                MessageBox.Show("Please fill in all fields before booking.");
                return;
            }

            if (!int.TryParse(textBoxPatientID.Text, out int patientID))
            {
                MessageBox.Show("Invalid Patient ID. Please enter a numeric value.");
                return;
            }

            if (appointments.Any(a => a.PatientID == patientID))
            {
                MessageBox.Show("An appointment for this Patient ID already exists. Please use a unique Patient ID.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Doctor selectedDoctor = (Doctor)comboBoxDoctors.SelectedItem;

            if (!selectedDoctor.Available)
            {
                MessageBox.Show("This doctor is already booked. Please select another doctor.");
                return;
            }

            int appointmentID = appointments.Count + 1;

            AppointmentData newAppointment = new AppointmentData
            {
                AppointmentID = appointmentID,
                PatientID = patientID,
                PatientName = textBoxPatient.Text,
                DoctorName = selectedDoctor.Name,
                AppointmentDate = dateTimePicker1.Value.Date,
                AppointmentTime = dateTimePickerTime.Value.TimeOfDay
            };

            appointments.Add(newAppointment);
            selectedDoctor.Available = false;

            UpdateDoctorDropdown();
            UpdateDoctorAvailabilityLabel(selectedDoctor);

            MessageBox.Show("Appointment booked successfully!");
            RefreshAppointmentGrid();
        }

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAppID.Text))
            {
                MessageBox.Show("Please enter an Appointment ID to delete.");
                return;
            }

            if (!int.TryParse(textBoxAppID.Text, out int appointmentID))
            {
                MessageBox.Show("Invalid Appointment ID.");
                return;
            }

            var appointmentToDelete = appointments.FirstOrDefault(a => a.AppointmentID == appointmentID);
            if (appointmentToDelete == null)
            {
                MessageBox.Show("Appointment not found.");
                return;
            }

            Doctor doctor = doctors.FirstOrDefault(d => d.Name == appointmentToDelete.DoctorName);
            if (doctor != null)
            {
                doctor.Available = true;
            }

            appointments.Remove(appointmentToDelete);
            UpdateDoctorDropdown();

            if (doctor != null)
            {
                UpdateDoctorAvailabilityLabel(doctor);
            }

            MessageBox.Show("Appointment deleted successfully!");
            RefreshAppointmentGrid();
        }

        private void RefreshAppointmentGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Appointment ID");
            dt.Columns.Add("Patient ID");
            dt.Columns.Add("Patient Name");
            dt.Columns.Add("Doctor Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");

            foreach (var appt in appointments)
            {
                dt.Rows.Add(appt.AppointmentID, appt.PatientID, appt.PatientName, appt.DoctorName, appt.AppointmentDate.ToShortDateString(), appt.AppointmentTime);
            }

            dataGridView1.DataSource = dt;
        }

        private void UpdateDoctorDropdown()
        {
            comboBoxDoctors.DataSource = null;
            comboBoxDoctors.DataSource = doctors;
            comboBoxDoctors.DisplayMember = "Name";
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
        }
    }

    public class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public bool Available { get; set; }

        public Doctor(string name, string specialty, bool available)
        {
            Name = name;
            Specialty = specialty;
            Available = available;
        }

        public override string ToString()
        {
            return $"{Name} ({Specialty})";
        }
    }

    public class AppointmentData
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
    }
}
