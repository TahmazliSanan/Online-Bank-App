using OnlineBankApp.Dtos;

namespace OnlineBankApp.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly UserDto _userDto;

        public DashboardForm(UserDto userDto)
        {
            InitializeComponent();
            _userDto = userDto;
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
    }
}
