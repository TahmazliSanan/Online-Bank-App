using OnlineBankApp.Extensions;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class MyTransactionsForm : Form
    {
        private readonly TransactionService _transactionService;

        public MyTransactionsForm(TransactionService transactionService)
        {
            InitializeComponent();
            _transactionService = transactionService;
        }

        private void LoadMyTransactions()
        {
            FillTable();
        }

        private void FillTable()
        {
            var myTransactions = _transactionService.GetTransactions(AppSession.LoggedInUser!.Id);
            dgvMyTransactions.DataSource = myTransactions;
            dgvMyTransactions.RenameColumns();
            dgvMyTransactions.StyleDataGridView();
        }

        private void MyTransactionsForm_Load(object sender, EventArgs e)
        {
            LoadMyTransactions();
        }
    }
}
