using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly UserDto _userDto;
        private readonly UserService _userService;

        public DashboardForm(UserDto userDto, UserService userService)
        {
            InitializeComponent();
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
    }
}
