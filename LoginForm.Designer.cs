
namespace HospitalManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Button btnRefreshCaptcha;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBoxCaptcha = new PictureBox();
            lblCaptcha = new Label();
            txtCaptcha = new TextBox();
            btnRefreshCaptcha = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(394, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(558, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(399, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(558, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(572, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(610, 302);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(100, 40);
            pictureBoxCaptcha.TabIndex = 5;
            pictureBoxCaptcha.TabStop = false;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCaptcha.Location = new Point(399, 261);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(89, 23);
            lblCaptcha.TabIndex = 6;
            lblCaptcha.Text = "CAPTCHA:";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(558, 251);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(100, 27);
            txtCaptcha.TabIndex = 7;
            // 
            // btnRefreshCaptcha
            // 
            btnRefreshCaptcha.Location = new Point(682, 244);
            btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            btnRefreshCaptcha.Size = new Size(90, 40);
            btnRefreshCaptcha.TabIndex = 8;
            btnRefreshCaptcha.Text = "Refresh CAPTCHA";
            btnRefreshCaptcha.UseVisualStyleBackColor = true;
            btnRefreshCaptcha.Click += btnRefreshCaptcha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 42);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(145, 31);
            label1.TabIndex = 9;
            label1.Text = ".....Login Here";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 476);
            label2.Name = "label2";
            label2.Size = new Size(231, 28);
            label2.TabIndex = 10;
            label2.Text = " For New User Click Here";
            label2.Click += label2_Click;
            // 
            // LoginForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 603);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Controls.Add(btnRefreshCaptcha);
            Controls.Add(txtCaptcha);
            Controls.Add(lblCaptcha);
            Controls.Add(pictureBoxCaptcha);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Login Form with CAPTCHA";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
    }
}
