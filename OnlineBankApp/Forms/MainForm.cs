using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public MainForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var loginForm = new LoginForm(_userService, _cardService);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = txbFirstName.Text.Trim();
                var lastName = txbLastName.Text.Trim();
                var username = txbUsername.Text.Trim();
                var password = txbPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(firstName)
                    || string.IsNullOrWhiteSpace(lastName)
                    || string.IsNullOrWhiteSpace(username)
                    || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Fields cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var registerDto = new RegisterDto
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = username,
                    Password = password
                };

                var registeredUser = _userService.RegisterUser(registerDto);

                MessageBox.Show($"Registration completed! You can see your card number in dashboard!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

                var loginForm = new LoginForm(_userService, _cardService);
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Blue;
            btnSignUp.ForeColor = Color.White;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.White;
            btnSignUp.ForeColor = Color.Blue;
        }
    }
}
