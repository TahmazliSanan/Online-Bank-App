using OnlineBankApp.Extensions;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class MyTransactionsForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;
        private readonly TransactionService _transactionService;

        public MyTransactionsForm(UserService userService, CardService cardService, 
            TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
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

        private void linkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var dashboardForm = new DashboardForm(_userService, _cardService, _transactionService);
            dashboardForm.StartPosition = FormStartPosition.CenterScreen;
            dashboardForm.Show();
        }
    }
}
