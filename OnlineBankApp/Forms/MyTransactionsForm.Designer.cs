namespace OnlineBankApp.Forms
{
    partial class MyTransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTransactionsForm));
            lblMyTransactions = new Label();
            groupBox1 = new GroupBox();
            dgvMyTransactions = new DataGridView();
            linkDashboard = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblMyTransactions
            // 
            lblMyTransactions.AutoSize = true;
            lblMyTransactions.Font = new Font("Segoe UI", 20F);
            lblMyTransactions.Location = new Point(281, 9);
            lblMyTransactions.Name = "lblMyTransactions";
            lblMyTransactions.Size = new Size(252, 37);
            lblMyTransactions.TabIndex = 0;
            lblMyTransactions.Text = "MY TRANSACTIONS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMyTransactions);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 422);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table";
            // 
            // dgvMyTransactions
            // 
            dgvMyTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyTransactions.Location = new Point(6, 22);
            dgvMyTransactions.Name = "dgvMyTransactions";
            dgvMyTransactions.Size = new Size(799, 394);
            dgvMyTransactions.TabIndex = 0;
            dgvMyTransactions.CellFormatting += dgvMyTransactions_CellFormatting;
            // 
            // linkDashboard
            // 
            linkDashboard.AutoSize = true;
            linkDashboard.Font = new Font("Segoe UI", 12F);
            linkDashboard.LinkBehavior = LinkBehavior.NeverUnderline;
            linkDashboard.Location = new Point(737, 52);
            linkDashboard.Name = "linkDashboard";
            linkDashboard.Size = new Size(86, 21);
            linkDashboard.TabIndex = 2;
            linkDashboard.TabStop = true;
            linkDashboard.Text = "Dashboard";
            linkDashboard.LinkClicked += linkDashboard_LinkClicked;
            // 
            // MyTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 510);
            Controls.Add(linkDashboard);
            Controls.Add(groupBox1);
            Controls.Add(lblMyTransactions);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MyTransactionsForm";
            Text = "MovaBank";
            Load += MyTransactionsForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMyTransactions;
        private GroupBox groupBox1;
        private DataGridView dgvMyTransactions;
        private LinkLabel linkDashboard;
    }
}