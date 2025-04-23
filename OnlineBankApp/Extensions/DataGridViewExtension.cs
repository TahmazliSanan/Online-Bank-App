namespace OnlineBankApp.Extensions
{
    public static class DataGridViewExtension
    {
        public static void StyleDataGridView(this DataGridView dataGridView)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.RowTemplate.Height = 35;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dataGridView.GridColor = Color.LightGray;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void RenameColumns(this DataGridView dataGridView)
        {
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["OwnerFullName"].Visible = false;
            dataGridView.Columns["SenderCardNumber"].HeaderText = "From Card";
            dataGridView.Columns["ReceiverCardNumber"].HeaderText = "To Card";
            dataGridView.Columns["TransactionType"].HeaderText = "Transaction Type";
            dataGridView.Columns["ProcessedDate"].HeaderText = "Date";
        }
    }
}
