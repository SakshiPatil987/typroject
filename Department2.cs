using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace typroject
{
    public partial class Department2 : Form
    {
        public Department2()
        {
            InitializeComponent();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Check if the phone number contains only digits and has exactly 10 characters
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate phone number
            if (!IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }

            // Get the selected department name from ComboBox
            string deptName = comboBoxDept.SelectedItem?.ToString();

            // Proceed with inserting the record
            if (string.IsNullOrEmpty(deptName))
            {
                MessageBox.Show("Please select a department from the dropdown.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO deptab (deptid, deptname, phone) VALUES (@DeptID, @DeptName, @Phone)", con);
            cmd.Parameters.AddWithValue("@DeptID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@DeptName", deptName);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM deptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validate phone number
            if (!IsValidPhoneNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }

            string deptName = comboBoxDept.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(deptName))
            {
                MessageBox.Show("Please select a department from the dropdown.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE deptab SET deptname=@DeptName, phone=@Phone WHERE deptid=@DeptID", con);
            cmd.Parameters.AddWithValue("@DeptID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@DeptName", deptName);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM deptab WHERE deptid=@DeptID", con);
            cmd.Parameters.AddWithValue("@DeptID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM deptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main ds = new Main();
            ds.Show();
            this.Close();
        }

        private void Department2_Load(object sender, EventArgs e)
        {
            // Clear any existing items in the ComboBox
            comboBoxDept.Items.Clear();

            // Add department names manually
            comboBoxDept.Items.Add("Cardiology");
            comboBoxDept.Items.Add("Neurology");
            comboBoxDept.Items.Add("Orthopedics");
            comboBoxDept.Items.Add("Pediatrics");
            comboBoxDept.Items.Add("General Medicine");
            comboBoxDept.Items.Add("Surgery");
            comboBoxDept.Items.Add("Emergency");
            comboBoxDept.Items.Add("Casualty department");

            comboBoxDept.Items.Add(" Operating theatre (OT)");

            comboBoxDept.Items.Add("Intensive care unit ");
            comboBoxDept.Items.Add("ENT ");
            comboBoxDept.Items.Add("Geriatric");
            comboBoxDept.Items.Add("Gastroenterology ");
            comboBoxDept.Items.Add("Gynaecology ");
            comboBoxDept.Items.Add("Haematology ");
            comboBoxDept.Items.Add(" Opthalmology ");
            comboBoxDept.Items.Add(" Urology  ");
            comboBoxDept.Items.Add(" Inpatient  ");
            comboBoxDept.Items.Add(" Other... ");














            // Optionally set the default selected item if you want
            comboBoxDept.SelectedIndex = 0; // Set default to "Cardiology"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
