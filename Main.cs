using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PatientInfoApp;
using BloodReportManagement;
using HospitalBilling;
using DoctorAppointmentSystem;


namespace typroject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BloodReportForm1 ds = new BloodReportForm1();
            ds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctor ds = new Doctor();
            ds.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Department2 ds = new Department2();
            ds.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient ds = new Patient();
            ds.Show();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nurse ds = new Nurse();
            ds.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Appointment ds = new Appointment();

            ds.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 ds = new Form1();

            ds.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainForm ds = new MainForm();

            ds.Show();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 73);
            button1.Name = "button1";
            button1.Size = new Size(158, 51);
            button1.TabIndex = 0;
            button1.Text = "Department";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(4, 488);
            button2.Name = "button2";
            button2.Size = new Size(175, 49);
            button2.TabIndex = 1;
            button2.Text = "Billing Department";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(12, 130);
            button3.Name = "button3";
            button3.Size = new Size(158, 58);
            button3.TabIndex = 2;
            button3.Text = "Patient";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(4, 212);
            button4.Name = "button4";
            button4.Size = new Size(166, 51);
            button4.TabIndex = 3;
            button4.Text = "Doctor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(4, 269);
            button5.Name = "button5";
            button5.Size = new Size(166, 53);
            button5.TabIndex = 4;
            button5.Text = "Nurse";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(4, 340);
            button6.Name = "button6";
            button6.Size = new Size(166, 57);
            button6.TabIndex = 5;
            button6.Text = "Blood Report";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(4, 422);
            button7.Name = "button7";
            button7.Size = new Size(167, 48);
            button7.TabIndex = 6;
            button7.Text = "Appointment";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 63);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 18);
            label2.Name = "label2";
            label2.Size = new Size(204, 31);
            label2.TabIndex = 9;
            label2.Text = "Aashirwad Hospital";
            // 
            // Main
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1079, 562);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;

        private void button1_Click_2(object sender, EventArgs e)
        {
            Department2 ds = new Department2();
            ds.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Patient ds = new Patient();
            ds.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Doctor ds = new Doctor();
            ds.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Nurse ns = new Nurse();
            ns.Show();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BloodReportForm1 bf = new BloodReportForm1();
            bf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainForm mg = new MainForm();
            mg.Show();
        }
        private Panel panel1;
        private Label label1;

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private Label label2;
    }
}
