namespace OnlineBankApp.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnSignIn = new Button();
            lblLogin = new Label();
            grbPassword = new GroupBox();
            txbPassword = new TextBox();
            grbUsername = new GroupBox();
            txbUsername = new TextBox();
            linkRegister = new LinkLabel();
            grbPassword.SuspendLayout();
            grbUsername.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.Font = new Font("Segoe UI", 12F);
            btnSignIn.ForeColor = Color.Blue;
            btnSignIn.Location = new Point(178, 145);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(131, 36);
            btnSignIn.TabIndex = 11;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            btnSignIn.MouseEnter += btnSignIn_MouseEnter;
            btnSignIn.MouseLeave += btnSignIn_MouseLeave;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F);
            lblLogin.Location = new Point(187, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(95, 37);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "LOGIN";
            // 
            // grbPassword
            // 
            grbPassword.Controls.Add(txbPassword);
            grbPassword.Location = new Point(255, 71);
            grbPassword.Name = "grbPassword";
            grbPassword.Size = new Size(216, 58);
            grbPassword.TabIndex = 9;
            grbPassword.TabStop = false;
            grbPassword.Text = "Password";
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 12F);
            txbPassword.Location = new Point(6, 22);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(204, 29);
            txbPassword.TabIndex = 0;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // grbUsername
            // 
            grbUsername.Controls.Add(txbUsername);
            grbUsername.Location = new Point(12, 71);
            grbUsername.Name = "grbUsername";
            grbUsername.Size = new Size(216, 58);
            grbUsername.TabIndex = 8;
            grbUsername.TabStop = false;
            grbUsername.Text = "Username";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI", 12F);
            txbUsername.Location = new Point(6, 22);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(204, 29);
            txbUsername.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 12F);
            linkRegister.LinkBehavior = LinkBehavior.NeverUnderline;
            linkRegister.Location = new Point(404, 161);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(67, 21);
            linkRegister.TabIndex = 12;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 193);
            Controls.Add(linkRegister);
            Controls.Add(btnSignIn);
            Controls.Add(lblLogin);
            Controls.Add(grbPassword);
            Controls.Add(grbUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovaBank";
            grbPassword.ResumeLayout(false);
            grbPassword.PerformLayout();
            grbUsername.ResumeLayout(false);
            grbUsername.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Label lblLogin;
        private GroupBox grbPassword;
        private TextBox txbPassword;
        private GroupBox grbUsername;
        private TextBox txbUsername;
        private LinkLabel linkRegister;
    }
}