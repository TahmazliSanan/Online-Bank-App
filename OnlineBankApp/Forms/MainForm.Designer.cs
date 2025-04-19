namespace OnlineBankApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            grbFirstName = new GroupBox();
            txbFirstName = new TextBox();
            grbLastName = new GroupBox();
            txbLastName = new TextBox();
            grbUsername = new GroupBox();
            txbUsername = new TextBox();
            grbPassword = new GroupBox();
            txbPassword = new TextBox();
            lblRegistration = new Label();
            btnSignUp = new Button();
            linkLogin = new LinkLabel();
            grbFirstName.SuspendLayout();
            grbLastName.SuspendLayout();
            grbUsername.SuspendLayout();
            grbPassword.SuspendLayout();
            SuspendLayout();
            // 
            // grbFirstName
            // 
            grbFirstName.Controls.Add(txbFirstName);
            grbFirstName.Location = new Point(12, 82);
            grbFirstName.Name = "grbFirstName";
            grbFirstName.Size = new Size(216, 58);
            grbFirstName.TabIndex = 0;
            grbFirstName.TabStop = false;
            grbFirstName.Text = "First Name";
            // 
            // txbFirstName
            // 
            txbFirstName.Font = new Font("Segoe UI", 12F);
            txbFirstName.Location = new Point(6, 22);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(204, 29);
            txbFirstName.TabIndex = 0;
            // 
            // grbLastName
            // 
            grbLastName.Controls.Add(txbLastName);
            grbLastName.Location = new Point(256, 82);
            grbLastName.Name = "grbLastName";
            grbLastName.Size = new Size(216, 58);
            grbLastName.TabIndex = 1;
            grbLastName.TabStop = false;
            grbLastName.Text = "Last Name";
            // 
            // txbLastName
            // 
            txbLastName.Font = new Font("Segoe UI", 12F);
            txbLastName.Location = new Point(6, 22);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(204, 29);
            txbLastName.TabIndex = 0;
            // 
            // grbUsername
            // 
            grbUsername.Controls.Add(txbUsername);
            grbUsername.Location = new Point(12, 163);
            grbUsername.Name = "grbUsername";
            grbUsername.Size = new Size(216, 58);
            grbUsername.TabIndex = 2;
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
            // grbPassword
            // 
            grbPassword.Controls.Add(txbPassword);
            grbPassword.Location = new Point(256, 163);
            grbPassword.Name = "grbPassword";
            grbPassword.Size = new Size(216, 58);
            grbPassword.TabIndex = 3;
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
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 20F);
            lblRegistration.Location = new Point(152, 9);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(193, 37);
            lblRegistration.TabIndex = 4;
            lblRegistration.Text = "REGISTRATION";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Blue;
            btnSignUp.Font = new Font("Segoe UI", 12F);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(152, 247);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(193, 42);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI", 12F);
            linkLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLogin.Location = new Point(423, 268);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(49, 21);
            linkLogin.TabIndex = 6;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 303);
            Controls.Add(linkLogin);
            Controls.Add(btnSignUp);
            Controls.Add(lblRegistration);
            Controls.Add(grbPassword);
            Controls.Add(grbUsername);
            Controls.Add(grbLastName);
            Controls.Add(grbFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MovaBank";
            grbFirstName.ResumeLayout(false);
            grbFirstName.PerformLayout();
            grbLastName.ResumeLayout(false);
            grbLastName.PerformLayout();
            grbUsername.ResumeLayout(false);
            grbUsername.PerformLayout();
            grbPassword.ResumeLayout(false);
            grbPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbFirstName;
        private TextBox txbFirstName;
        private GroupBox grbLastName;
        private TextBox txbLastName;
        private GroupBox grbUsername;
        private TextBox txbUsername;
        private GroupBox grbPassword;
        private TextBox txbPassword;
        private Label lblRegistration;
        private Button btnSignUp;
        private LinkLabel linkLogin;
    }
}