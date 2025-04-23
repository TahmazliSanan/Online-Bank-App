using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;
        private readonly TransactionService _transactionService;

        public LoginForm(UserService userService, CardService cardService, TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
            _transactionService = transactionService;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var mainForm = new MainForm(_userService, _cardService, _transactionService);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txbUsername.Text.Trim();
                var password = txbPassword.Text;

                if (string.IsNullOrWhiteSpace(username)
                    || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Fields cannot be empty! Please try again!", 
                        "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var loginDto = new LoginDto
                {
                    Username = username,
                    Password = password
                };

                var loggedInUser = _userService.LoginUser(loginDto);
                SaveSession(loggedInUser);
                Hide();

                var dashboardForm = new DashboardForm(_userService, _cardService, _transactionService);
                dashboardForm.StartPosition = FormStartPosition.CenterScreen;
                dashboardForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.Blue;
            btnSignIn.ForeColor = Color.White;
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.White;
            btnSignIn.ForeColor = Color.Blue;
        }

        private void SaveSession(UserDto userDto)
        {
            AppSession.LoggedInUser = userDto;
        }
    }
}
