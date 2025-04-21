using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly long _userId;
        private readonly UserDto _userDto;
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public DashboardForm(long userId, UserDto userDto,
            UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userId = userId;
            _userDto = userDto;
            _userService = userService;
            _cardService = cardService;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txbFirstName.Text = _userDto.FirstName;
            txbLastName.Text = _userDto.LastName;
            txbCardNumber.Text = _userDto.CardNumber;
            txbBalance.Text = _userDto.Balance.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm(_userService, _cardService);
            loginForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _userService.DeleteAccount(_userId);

                    MessageBox.Show("Account deleted successfully!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();

                    var loginForm = new LoginForm(_userService, _cardService);
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
            var addAmountForm = new AddAmountForm(_userService, _cardService);
            addAmountForm.StartPosition = FormStartPosition.CenterScreen;
            addAmountForm.Show();
        }

        private void btnWithdrawAmount_Click(object sender, EventArgs e)
        {
            Hide();
            var withdrawAmountForm = new WithdrawAmountForm(_userService, _cardService);
            withdrawAmountForm.StartPosition = FormStartPosition.CenterScreen;
            withdrawAmountForm.Show();
        }
    }
}
