namespace OnlineBankApp.Forms
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            linkLogin = new LinkLabel();
            btnSave = new Button();
            lblRegistration = new Label();
            grbPassword = new GroupBox();
            txbPassword = new TextBox();
            grbUsername = new GroupBox();
            txbUsername = new TextBox();
            grbLastName = new GroupBox();
            txbLastName = new TextBox();
            grbFirstName = new GroupBox();
            txbFirstName = new TextBox();
            grbPassword.SuspendLayout();
            grbUsername.SuspendLayout();
            grbLastName.SuspendLayout();
            grbFirstName.SuspendLayout();
            SuspendLayout();
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI", 12F);
            linkLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLogin.Location = new Point(385, 270);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(86, 21);
            linkLogin.TabIndex = 13;
            linkLogin.TabStop = true;
            linkLogin.Text = "Dashboard";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(151, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 42);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 20F);
            lblRegistration.Location = new Point(151, 9);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(176, 37);
            lblRegistration.TabIndex = 11;
            lblRegistration.Text = "EDIT PROFILE";
            // 
            // grbPassword
            // 
            grbPassword.Controls.Add(txbPassword);
            grbPassword.Location = new Point(255, 165);
            grbPassword.Name = "grbPassword";
            grbPassword.Size = new Size(216, 58);
            grbPassword.TabIndex = 10;
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
            grbUsername.Location = new Point(11, 165);
            grbUsername.Name = "grbUsername";
            grbUsername.Size = new Size(216, 58);
            grbUsername.TabIndex = 9;
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
            // grbLastName
            // 
            grbLastName.Controls.Add(txbLastName);
            grbLastName.Location = new Point(255, 84);
            grbLastName.Name = "grbLastName";
            grbLastName.Size = new Size(216, 58);
            grbLastName.TabIndex = 8;
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
            // grbFirstName
            // 
            grbFirstName.Controls.Add(txbFirstName);
            grbFirstName.Location = new Point(11, 84);
            grbFirstName.Name = "grbFirstName";
            grbFirstName.Size = new Size(216, 58);
            grbFirstName.TabIndex = 7;
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
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 303);
            Controls.Add(linkLogin);
            Controls.Add(btnSave);
            Controls.Add(lblRegistration);
            Controls.Add(grbPassword);
            Controls.Add(grbUsername);
            Controls.Add(grbLastName);
            Controls.Add(grbFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovaBank";
            Load += EditProfileForm_Load;
            grbPassword.ResumeLayout(false);
            grbPassword.PerformLayout();
            grbUsername.ResumeLayout(false);
            grbUsername.PerformLayout();
            grbLastName.ResumeLayout(false);
            grbLastName.PerformLayout();
            grbFirstName.ResumeLayout(false);
            grbFirstName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLogin;
        private Button btnSave;
        private Label lblRegistration;
        private GroupBox grbPassword;
        private TextBox txbPassword;
        private GroupBox grbUsername;
        private TextBox txbUsername;
        private GroupBox grbLastName;
        private TextBox txbLastName;
        private GroupBox grbFirstName;
        private TextBox txbFirstName;
    }
}