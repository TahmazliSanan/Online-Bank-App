using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly long _userId;
        private readonly UserDto _userDto;
        private readonly UserService _userService;

        public DashboardForm(long userId, UserDto userDto, UserService userService)
        {
            InitializeComponent();
            _userId = userId;
            _userDto = userDto;
            _userService = userService;
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
            var loginForm = new LoginForm(_userService);
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

                    var loginForm = new LoginForm(_userService);
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
    }
}
