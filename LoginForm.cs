using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using typroject;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        private string generatedCaptcha;

        public LoginForm()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (txtCaptcha.Text != generatedCaptcha)
            {
                MessageBox.Show("Invalid CAPTCHA. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerateCaptcha(); // Refresh CAPTCHA
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospitaldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadOnly;MultiSubnetFailover=True "))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users1 WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Main dashboardForm = new Main();
                            dashboardForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            generatedCaptcha = random.Next(10000, 99999).ToString(); // Simple 4-digit number CAPTCHA
            Bitmap captchaImage = new Bitmap(100, 40);

            using (Graphics g = Graphics.FromImage(captchaImage))
            {
                g.Clear(Color.White);
                Font font = new Font("Arial", 18, FontStyle.Bold);
                g.DrawString(generatedCaptcha, font, Brushes.Black, 10, 5);
            }

            pictureBoxCaptcha.Image = captchaImage;
        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            GenerateCaptcha(); // Refresh the CAPTCHA image
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegistrationForm da = new RegistrationForm();
            da.Show();
        }
    }
}
