using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace typroject
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();

            // Populate Gender ComboBox
            comboBox1.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox5.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patientab1 values(@patientid, @patientname, @gender, @email, @address)", con);
            cmd.Parameters.AddWithValue("@PatientID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem?.ToString() ?? string.Empty);
            cmd.Parameters.AddWithValue("@Email", textBox5.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patientab1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox5.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update patientab1 set patientname=@patientname, gender=@gender, email=@email, address=@address where patientid=@patientid", con);

            cmd.Parameters.AddWithValue("@PatientID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem?.ToString() ?? string.Empty);
            cmd.Parameters.AddWithValue("@Email", textBox5.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("delete patientab1 where patientid=@patientid", con);
            cmd.Parameters.AddWithValue("@PatientID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patientab1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patientab1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the cell click event if required
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel painting if required
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Handle group box enter event if required
        }

    }
}
