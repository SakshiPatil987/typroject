
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace typroject
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Check if the phone number contains only digits and has exactly 10 characters
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }



        private void Doctor_Load(object sender, EventArgs e)
        {
            // Predefined list of diseases
            var Specialists = new[] { "Cancer", "Diabetes", "Hypertension", "Asthma", "Flu", "Tuberculosis", "COVID-19" };

            // Populate ComboBox with disease names
            comboBoxDiseases.Items.AddRange(Specialists);

            // Establishing connection to the database
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();

            // Load doctor data into the DataGridView
            SqlCommand cmd = new SqlCommand("SELECT * FROM doctortab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();

            string selectedDisease = comboBoxDiseases.SelectedItem?.ToString();

            if (selectedDisease == null)
            {
                MessageBox.Show("Please select a disease.");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO doctortab (DoctorID, DoctorName, Experience, Phone, Specialists) VALUES (@DoctorID, @DoctorName, @Experience, @Phone, @Specialists)", con);
            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@DoctorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Experience", textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Specialists", selectedDisease);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM doctortab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM doctortab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();

            string SelectedSpecialists = comboBoxDiseases.SelectedItem?.ToString();

            if (SelectedSpecialists == null)
            {
                MessageBox.Show("Please select a disease.");
                return;
            }

            SqlCommand cmd = new SqlCommand("UPDATE doctortab SET DoctorName=@DoctorName, Experience=@Experience, Phone=@Phone, Specialists=@Specialists WHERE DoctorID=@DoctorID", con);
            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@DoctorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Experience", textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Specialists", SelectedSpecialists);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM doctortab WHERE DoctorID=@DoctorID", con);
            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

    }
}
