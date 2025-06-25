

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace typroject
{
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nursetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        // Phone number validation method
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for validating phone number (for example, 123-456-7890 or (123) 456-7890)
            string pattern = @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox4.Text;

            // Validate phone number
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into nursetab values(@nurseid,@nursename,@phone)", con);
            cmd.Parameters.AddWithValue("@NurseID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NurseName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nursetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string phone = textBox4.Text;

            // Validate phone number
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("update nursetab set nursename=@nursename, phone=@phone where nurseid=@nurseid", con);
            cmd.Parameters.AddWithValue("@NurseID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NurseName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from nursetab where nurseid=@nurseid", con);
            cmd.Parameters.AddWithValue("@NurseID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nursetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Nurse_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
