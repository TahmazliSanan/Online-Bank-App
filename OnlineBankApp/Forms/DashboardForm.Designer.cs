namespace OnlineBankApp.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            grbOperations = new GroupBox();
            btnGetReport = new Button();
            btnTransferAmount = new Button();
            btnWithdrawAmount = new Button();
            btnAddAmount = new Button();
            label1 = new Label();
            grbAboutMe = new GroupBox();
            txbUsername = new TextBox();
            label2 = new Label();
            txbBalance = new TextBox();
            lblBalance = new Label();
            txbCardNumber = new TextBox();
            lblCardNumber = new Label();
            txbLastName = new TextBox();
            lblLastName = new Label();
            txbFirstName = new TextBox();
            lblFirstName = new Label();
            grbSettings = new GroupBox();
            btnMyTransactions = new Button();
            btnDeleteAccount = new Button();
            btnLogout = new Button();
            btnEditProfile = new Button();
            grbOperations.SuspendLayout();
            grbAboutMe.SuspendLayout();
            grbSettings.SuspendLayout();
            SuspendLayout();
            // 
            // grbOperations
            // 
            grbOperations.Controls.Add(btnGetReport);
            grbOperations.Controls.Add(btnTransferAmount);
            grbOperations.Controls.Add(btnWithdrawAmount);
            grbOperations.Controls.Add(btnAddAmount);
            grbOperations.Location = new Point(12, 94);
            grbOperations.Name = "grbOperations";
            grbOperations.Size = new Size(200, 287);
            grbOperations.TabIndex = 0;
            grbOperations.TabStop = false;
            grbOperations.Text = "Operations";
            // 
            // btnGetReport
            // 
            btnGetReport.Font = new Font("Segoe UI", 12F);
            btnGetReport.Location = new Point(9, 223);
            btnGetReport.Name = "btnGetReport";
            btnGetReport.Size = new Size(185, 50);
            btnGetReport.TabIndex = 3;
            btnGetReport.Text = "Download Report\r\n(PDF)";
            btnGetReport.UseVisualStyleBackColor = true;
            btnGetReport.Click += btnGetReport_Click;
            // 
            // btnTransferAmount
            // 
            btnTransferAmount.Font = new Font("Segoe UI", 12F);
            btnTransferAmount.Location = new Point(9, 156);
            btnTransferAmount.Name = "btnTransferAmount";
            btnTransferAmount.Size = new Size(185, 50);
            btnTransferAmount.TabIndex = 2;
            btnTransferAmount.Text = "Transfer";
            btnTransferAmount.UseVisualStyleBackColor = true;
            btnTransferAmount.Click += btnTransferAmount_Click;
            // 
            // btnWithdrawAmount
            // 
            btnWithdrawAmount.Font = new Font("Segoe UI", 12F);
            btnWithdrawAmount.Location = new Point(9, 89);
            btnWithdrawAmount.Name = "btnWithdrawAmount";
            btnWithdrawAmount.Size = new Size(185, 50);
            btnWithdrawAmount.TabIndex = 1;
            btnWithdrawAmount.Text = "Withdraw";
            btnWithdrawAmount.UseVisualStyleBackColor = true;
            btnWithdrawAmount.Click += btnWithdrawAmount_Click;
            // 
            // btnAddAmount
            // 
            btnAddAmount.Font = new Font("Segoe UI", 12F);
            btnAddAmount.Location = new Point(9, 22);
            btnAddAmount.Name = "btnAddAmount";
            btnAddAmount.Size = new Size(185, 50);
            btnAddAmount.TabIndex = 0;
            btnAddAmount.Text = "Add";
            btnAddAmount.UseVisualStyleBackColor = true;
            btnAddAmount.Click += btnAddAmount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            // 
            // grbAboutMe
            // 
            grbAboutMe.Controls.Add(txbUsername);
            grbAboutMe.Controls.Add(label2);
            grbAboutMe.Controls.Add(txbBalance);
            grbAboutMe.Controls.Add(lblBalance);
            grbAboutMe.Controls.Add(txbCardNumber);
            grbAboutMe.Controls.Add(lblCardNumber);
            grbAboutMe.Controls.Add(txbLastName);
            grbAboutMe.Controls.Add(lblLastName);
            grbAboutMe.Controls.Add(txbFirstName);
            grbAboutMe.Controls.Add(lblFirstName);
            grbAboutMe.Location = new Point(229, 94);
            grbAboutMe.Name = "grbAboutMe";
            grbAboutMe.Size = new Size(297, 287);
            grbAboutMe.TabIndex = 2;
            grbAboutMe.TabStop = false;
            grbAboutMe.Text = "About Me";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI", 12F);
            txbUsername.Location = new Point(120, 129);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(171, 29);
            txbUsername.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 132);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // txbBalance
            // 
            txbBalance.Font = new Font("Segoe UI", 12F);
            txbBalance.Location = new Point(120, 226);
            txbBalance.Name = "txbBalance";
            txbBalance.ReadOnly = true;
            txbBalance.Size = new Size(171, 29);
            txbBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F);
            lblBalance.Location = new Point(6, 229);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(66, 21);
            lblBalance.TabIndex = 6;
            lblBalance.Text = "Balance:";
            // 
            // txbCardNumber
            // 
            txbCardNumber.Font = new Font("Segoe UI", 12F);
            txbCardNumber.Location = new Point(120, 178);
            txbCardNumber.Name = "txbCardNumber";
            txbCardNumber.ReadOnly = true;
            txbCardNumber.Size = new Size(171, 29);
            txbCardNumber.TabIndex = 5;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Segoe UI", 12F);
            lblCardNumber.Location = new Point(6, 178);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(108, 21);
            lblCardNumber.TabIndex = 4;
            lblCardNumber.Text = "Card Number:";
            // 
            // txbLastName
            // 
            txbLastName.Font = new Font("Segoe UI", 12F);
            txbLastName.Location = new Point(120, 80);
            txbLastName.Name = "txbLastName";
            txbLastName.ReadOnly = true;
            txbLastName.Size = new Size(171, 29);
            txbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(6, 83);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(87, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txbFirstName
            // 
            txbFirstName.Font = new Font("Segoe UI", 12F);
            txbFirstName.Location = new Point(120, 34);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.ReadOnly = true;
            txbFirstName.Size = new Size(171, 29);
            txbFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(6, 37);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // grbSettings
            // 
            grbSettings.Controls.Add(btnMyTransactions);
            grbSettings.Controls.Add(btnDeleteAccount);
            grbSettings.Controls.Add(btnLogout);
            grbSettings.Controls.Add(btnEditProfile);
            grbSettings.Location = new Point(542, 94);
            grbSettings.Name = "grbSettings";
            grbSettings.Size = new Size(214, 287);
            grbSettings.TabIndex = 3;
            grbSettings.TabStop = false;
            grbSettings.Text = "Settings";
            // 
            // btnMyTransactions
            // 
            btnMyTransactions.BackColor = Color.White;
            btnMyTransactions.Font = new Font("Segoe UI", 12F);
            btnMyTransactions.ForeColor = Color.DarkCyan;
            btnMyTransactions.Location = new Point(15, 22);
            btnMyTransactions.Name = "btnMyTransactions";
            btnMyTransactions.Size = new Size(185, 50);
            btnMyTransactions.TabIndex = 6;
            btnMyTransactions.Text = "My Transactions";
            btnMyTransactions.UseVisualStyleBackColor = false;
            btnMyTransactions.Click += btnMyTransactions_Click;
            btnMyTransactions.MouseEnter += btnMyTransactions_MouseEnter;
            btnMyTransactions.MouseLeave += btnMyTransactions_MouseLeave;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.White;
            btnDeleteAccount.Font = new Font("Segoe UI", 12F);
            btnDeleteAccount.ForeColor = Color.Red;
            btnDeleteAccount.Location = new Point(15, 223);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(185, 50);
            btnDeleteAccount.TabIndex = 5;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            btnDeleteAccount.MouseEnter += btnDeleteAccount_MouseEnter;
            btnDeleteAccount.MouseLeave += btnDeleteAccount_MouseLeave;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = Color.Gray;
            btnLogout.Location = new Point(15, 156);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(185, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += btnLogout_MouseEnter;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.White;
            btnEditProfile.Font = new Font("Segoe UI", 12F);
            btnEditProfile.ForeColor = Color.Green;
            btnEditProfile.Location = new Point(15, 89);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(185, 50);
            btnEditProfile.TabIndex = 3;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            btnEditProfile.MouseEnter += btnEditProfile_MouseEnter;
            btnEditProfile.MouseLeave += btnEditProfile_MouseLeave;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 448);
            Controls.Add(grbSettings);
            Controls.Add(grbAboutMe);
            Controls.Add(label1);
            Controls.Add(grbOperations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovaBank";
            Load += DashboardForm_Load;
            grbOperations.ResumeLayout(false);
            grbAboutMe.ResumeLayout(false);
            grbAboutMe.PerformLayout();
            grbSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbOperations;
        private Label label1;
        private Button btnTransferAmount;
        private Button btnWithdrawAmount;
        private Button btnAddAmount;
        private GroupBox grbAboutMe;
        private Label lblLastName;
        private TextBox txbFirstName;
        private Label lblFirstName;
        private TextBox txbLastName;
        private Label lblCardNumber;
        private TextBox txbCardNumber;
        private TextBox txbBalance;
        private Label lblBalance;
        private GroupBox grbSettings;
        private Button btnDeleteAccount;
        private Button btnLogout;
        private Button btnEditProfile;
        private Button btnGetReport;
        private Button btnMyTransactions;
        private TextBox txbUsername;
        private Label label2;
    }
}