using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;
        private readonly TransactionService _transactionService;

        public DashboardForm(UserService userService, CardService cardService, 
            TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
            _transactionService = transactionService;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txbFirstName.Text = AppSession.LoggedInUser!.FirstName;
            txbLastName.Text = AppSession.LoggedInUser!.LastName;
            txbUsername.Text = AppSession.LoggedInUser!.Username;
            txbCardNumber.Text = AppSession.LoggedInUser!.CardNumber;
            txbBalance.Text = _cardService
                .GetCardByNumber(txbCardNumber.Text).Balance
                .ToString("0.00");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.LoggedInUser = null;
            Hide();
            var loginForm = new LoginForm(_userService, _cardService, _transactionService);
            loginForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _userService.DeleteAccount(AppSession.LoggedInUser!.Id);

                    MessageBox.Show("Account deleted successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();

                    var loginForm = new LoginForm(_userService, _cardService, _transactionService);
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Failed to delete account: {exception.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditProfile_MouseEnter(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.Green;
            btnEditProfile.ForeColor = Color.White;
        }

        private void btnEditProfile_MouseLeave(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.White;
            btnEditProfile.ForeColor = Color.Green;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Gray;
            btnLogout.ForeColor = Color.White;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.Gray;
        }

        private void btnDeleteAccount_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteAccount.BackColor = Color.Red;
            btnDeleteAccount.ForeColor = Color.White;
        }

        private void btnDeleteAccount_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteAccount.BackColor = Color.White;
            btnDeleteAccount.ForeColor = Color.Red;
        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            Hide();
            var addAmountForm = new AddAmountForm(_userService, _cardService, _transactionService);
            addAmountForm.StartPosition = FormStartPosition.CenterScreen;
            addAmountForm.Show();
        }

        private void btnWithdrawAmount_Click(object sender, EventArgs e)
        {
            Hide();
            var withdrawAmountForm = new WithdrawAmountForm(_userService, _cardService, _transactionService);
            withdrawAmountForm.StartPosition = FormStartPosition.CenterScreen;
            withdrawAmountForm.Show();
        }

        private void btnTransferAmount_Click(object sender, EventArgs e)
        {
            Hide();
            var transferAmountForm = new TransferAmountForm(_userService, _cardService, _transactionService);
            transferAmountForm.StartPosition = FormStartPosition.CenterScreen;
            transferAmountForm.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            Hide();
            var editProfileForm = new EditProfileForm(_userService, _cardService, _transactionService);
            editProfileForm.StartPosition = FormStartPosition.CenterScreen;
            editProfileForm.Show();
        }

        private void btnMyTransactions_MouseEnter(object sender, EventArgs e)
        {
            btnMyTransactions.BackColor = Color.DarkCyan;
            btnMyTransactions.ForeColor = Color.White;
        }

        private void btnMyTransactions_MouseLeave(object sender, EventArgs e)
        {
            btnMyTransactions.BackColor = Color.White;
            btnMyTransactions.ForeColor = Color.DarkCyan;
        }

        private void btnMyTransactions_Click(object sender, EventArgs e)
        {
            Hide();
            var myTransactionsForm = new MyTransactionsForm(_transactionService);
            myTransactionsForm.StartPosition = FormStartPosition.CenterScreen;
            myTransactionsForm.Show();
        }
    }
}
