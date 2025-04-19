using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var mainForm = new MainForm(_userService);
            mainForm.Show();
        }
    }
}
