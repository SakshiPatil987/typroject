
namespace HospitalManagementSystem
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            lblId = new Label();
            textBox1 = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRePass = new Label();
            txtRePass = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ButtonFace;
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Location = new Point(488, 131);
            lblId.Name = "lblId";
            lblId.Size = new Size(66, 22);
            lblId.TabIndex = 0;
            lblId.Text = " User ID:";
            lblId.TextAlign = ContentAlignment.TopRight;
            lblId.Click += lblId_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(626, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(479, 179);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(626, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(488, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(626, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 5;
            // 
            // lblRePass
            // 
            lblRePass.AutoSize = true;
            lblRePass.Location = new Point(431, 271);
            lblRePass.Name = "lblRePass";
            lblRePass.Size = new Size(130, 20);
            lblRePass.TabIndex = 6;
            lblRePass.Text = "Confirm Password:";
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(626, 268);
            txtRePass.Name = "txtRePass";
            txtRePass.PasswordChar = '*';
            txtRePass.Size = new Size(200, 27);
            txtRePass.TabIndex = 7;
            txtRePass.TextChanged += txtRePass_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(508, 307);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(626, 307);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(508, 353);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(626, 350);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(458, 450);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(157, 38);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 16;
            label1.Text = "Ashirwad Hospital";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(655, 451);
            button1.Name = "button1";
            button1.Size = new Size(184, 37);
            button1.TabIndex = 17;
            button1.Text = "Already Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrationForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(876, 511);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtRePass);
            Controls.Add(lblRePass);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(textBox1);
            Controls.Add(lblId);
            DoubleBuffered = true;
            Name = "RegistrationForm";
            Text = "Registration Form";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button button1;
    }
}
