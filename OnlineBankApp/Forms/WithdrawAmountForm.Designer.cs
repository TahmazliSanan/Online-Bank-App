namespace OnlineBankApp.Forms
{
    partial class WithdrawAmountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawAmountForm));
            btnWithdrawAmountFromCard = new Button();
            lblWithdrawAmount = new Label();
            grbAmount = new GroupBox();
            txbAmount = new TextBox();
            grbAmount.SuspendLayout();
            SuspendLayout();
            // 
            // btnWithdrawAmountFromCard
            // 
            btnWithdrawAmountFromCard.Font = new Font("Segoe UI", 12F);
            btnWithdrawAmountFromCard.Location = new Point(22, 160);
            btnWithdrawAmountFromCard.Name = "btnWithdrawAmountFromCard";
            btnWithdrawAmountFromCard.Size = new Size(230, 48);
            btnWithdrawAmountFromCard.TabIndex = 5;
            btnWithdrawAmountFromCard.Text = "Withdraw Amount";
            btnWithdrawAmountFromCard.UseVisualStyleBackColor = true;
            btnWithdrawAmountFromCard.Click += btnWithdrawAmountFromCard_Click;
            // 
            // lblWithdrawAmount
            // 
            lblWithdrawAmount.AutoSize = true;
            lblWithdrawAmount.Font = new Font("Segoe UI", 15F);
            lblWithdrawAmount.Location = new Point(33, 9);
            lblWithdrawAmount.Name = "lblWithdrawAmount";
            lblWithdrawAmount.Size = new Size(207, 28);
            lblWithdrawAmount.TabIndex = 4;
            lblWithdrawAmount.Text = "WITHDRAW AMOUNT";
            // 
            // grbAmount
            // 
            grbAmount.Controls.Add(txbAmount);
            grbAmount.Location = new Point(12, 74);
            grbAmount.Name = "grbAmount";
            grbAmount.Size = new Size(246, 71);
            grbAmount.TabIndex = 3;
            grbAmount.TabStop = false;
            grbAmount.Text = "Amount";
            // 
            // txbAmount
            // 
            txbAmount.Font = new Font("Segoe UI", 12F);
            txbAmount.Location = new Point(10, 28);
            txbAmount.Name = "txbAmount";
            txbAmount.Size = new Size(230, 29);
            txbAmount.TabIndex = 0;
            // 
            // WithdrawAmountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 217);
            Controls.Add(btnWithdrawAmountFromCard);
            Controls.Add(lblWithdrawAmount);
            Controls.Add(grbAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WithdrawAmountForm";
            Text = "MovaBank";
            grbAmount.ResumeLayout(false);
            grbAmount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWithdrawAmountFromCard;
        private Label lblWithdrawAmount;
        private GroupBox grbAmount;
        private TextBox txbAmount;
    }
}