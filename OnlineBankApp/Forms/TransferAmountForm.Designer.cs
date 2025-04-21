namespace OnlineBankApp.Forms
{
    partial class TransferAmountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferAmountForm));
            btnTransferAmountBetweenTwoCards = new Button();
            lblAddAmount = new Label();
            grbAmount = new GroupBox();
            txbAmount = new TextBox();
            grbCardNumber = new GroupBox();
            txbCardNumber = new TextBox();
            linkDashboard = new LinkLabel();
            grbAmount.SuspendLayout();
            grbCardNumber.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransferAmountBetweenTwoCards
            // 
            btnTransferAmountBetweenTwoCards.Font = new Font("Segoe UI", 12F);
            btnTransferAmountBetweenTwoCards.Location = new Point(22, 241);
            btnTransferAmountBetweenTwoCards.Name = "btnTransferAmountBetweenTwoCards";
            btnTransferAmountBetweenTwoCards.Size = new Size(230, 48);
            btnTransferAmountBetweenTwoCards.TabIndex = 3;
            btnTransferAmountBetweenTwoCards.Text = "Transfer Amount";
            btnTransferAmountBetweenTwoCards.UseVisualStyleBackColor = true;
            btnTransferAmountBetweenTwoCards.Click += btnTransferAmountBetweenTwoCards_Click;
            // 
            // lblAddAmount
            // 
            lblAddAmount.AutoSize = true;
            lblAddAmount.Font = new Font("Segoe UI", 15F);
            lblAddAmount.Location = new Point(37, 9);
            lblAddAmount.Name = "lblAddAmount";
            lblAddAmount.Size = new Size(195, 28);
            lblAddAmount.TabIndex = 4;
            lblAddAmount.Text = "TRANSFER AMOUNT";
            // 
            // grbAmount
            // 
            grbAmount.Controls.Add(txbAmount);
            grbAmount.Location = new Point(12, 154);
            grbAmount.Name = "grbAmount";
            grbAmount.Size = new Size(246, 71);
            grbAmount.TabIndex = 2;
            grbAmount.TabStop = false;
            grbAmount.Text = "Amount";
            // 
            // txbAmount
            // 
            txbAmount.Font = new Font("Segoe UI", 12F);
            txbAmount.Location = new Point(10, 28);
            txbAmount.Name = "txbAmount";
            txbAmount.Size = new Size(230, 29);
            txbAmount.TabIndex = 2;
            // 
            // grbCardNumber
            // 
            grbCardNumber.Controls.Add(txbCardNumber);
            grbCardNumber.Location = new Point(12, 77);
            grbCardNumber.Name = "grbCardNumber";
            grbCardNumber.Size = new Size(246, 71);
            grbCardNumber.TabIndex = 1;
            grbCardNumber.TabStop = false;
            grbCardNumber.Text = "Card Number";
            // 
            // txbCardNumber
            // 
            txbCardNumber.Font = new Font("Segoe UI", 12F);
            txbCardNumber.Location = new Point(10, 28);
            txbCardNumber.Name = "txbCardNumber";
            txbCardNumber.Size = new Size(230, 29);
            txbCardNumber.TabIndex = 1;
            // 
            // linkDashboard
            // 
            linkDashboard.AutoSize = true;
            linkDashboard.Font = new Font("Segoe UI", 12F);
            linkDashboard.LinkBehavior = LinkBehavior.NeverUnderline;
            linkDashboard.Location = new Point(166, 310);
            linkDashboard.Name = "linkDashboard";
            linkDashboard.Size = new Size(86, 21);
            linkDashboard.TabIndex = 5;
            linkDashboard.TabStop = true;
            linkDashboard.Text = "Dashboard";
            linkDashboard.LinkClicked += linkDashboard_LinkClicked;
            // 
            // TransferAmountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 340);
            Controls.Add(linkDashboard);
            Controls.Add(grbCardNumber);
            Controls.Add(btnTransferAmountBetweenTwoCards);
            Controls.Add(lblAddAmount);
            Controls.Add(grbAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TransferAmountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovaBank";
            grbAmount.ResumeLayout(false);
            grbAmount.PerformLayout();
            grbCardNumber.ResumeLayout(false);
            grbCardNumber.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransferAmountBetweenTwoCards;
        private Label lblAddAmount;
        private GroupBox grbAmount;
        private TextBox txbAmount;
        private GroupBox grbCardNumber;
        private TextBox txbCardNumber;
        private LinkLabel linkDashboard;
    }
}