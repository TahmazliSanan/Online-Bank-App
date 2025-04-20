namespace OnlineBankApp.Forms
{
    partial class AddAmountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAmountForm));
            grbAmount = new GroupBox();
            txbAmount = new TextBox();
            lblAddAmount = new Label();
            btnAddAmountToCard = new Button();
            grbAmount.SuspendLayout();
            SuspendLayout();
            // 
            // grbAmount
            // 
            grbAmount.Controls.Add(txbAmount);
            grbAmount.Location = new Point(12, 74);
            grbAmount.Name = "grbAmount";
            grbAmount.Size = new Size(246, 71);
            grbAmount.TabIndex = 0;
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
            // lblAddAmount
            // 
            lblAddAmount.AutoSize = true;
            lblAddAmount.Font = new Font("Segoe UI", 20F);
            lblAddAmount.Location = new Point(41, 9);
            lblAddAmount.Name = "lblAddAmount";
            lblAddAmount.Size = new Size(193, 37);
            lblAddAmount.TabIndex = 1;
            lblAddAmount.Text = "ADD AMOUNT";
            // 
            // btnAddAmountToCard
            // 
            btnAddAmountToCard.Font = new Font("Segoe UI", 12F);
            btnAddAmountToCard.Location = new Point(22, 160);
            btnAddAmountToCard.Name = "btnAddAmountToCard";
            btnAddAmountToCard.Size = new Size(230, 48);
            btnAddAmountToCard.TabIndex = 2;
            btnAddAmountToCard.Text = "Add Amount";
            btnAddAmountToCard.UseVisualStyleBackColor = true;
            btnAddAmountToCard.Click += btnAddAmountToCard_Click;
            // 
            // AddAmountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 217);
            Controls.Add(btnAddAmountToCard);
            Controls.Add(lblAddAmount);
            Controls.Add(grbAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddAmountForm";
            Text = "MovaBank";
            grbAmount.ResumeLayout(false);
            grbAmount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAmount;
        private TextBox txbAmount;
        private Label lblAddAmount;
        private Button btnAddAmountToCard;
    }
}