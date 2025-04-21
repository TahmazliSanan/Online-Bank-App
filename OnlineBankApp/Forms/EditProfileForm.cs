using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class EditProfileForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public EditProfileForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var dashboardForm = new DashboardForm(_userService, _cardService);
            dashboardForm.StartPosition = FormStartPosition.CenterScreen;
            dashboardForm.Show();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txbFirstName.Text = AppSession.LoggedInUser!.FirstName;
            txbLastName.Text = AppSession.LoggedInUser!.LastName;
            txbUsername.Text = AppSession.LoggedInUser!.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txbFirstName.Text;
                string lastName = txbLastName.Text;
                string username = txbUsername.Text;
                string newPassword = txbNewPassword.Text;

                if (string.IsNullOrWhiteSpace(firstName)
                    || string.IsNullOrWhiteSpace(lastName)
                    || string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Fields cannot be empty! Please try again!",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var updatedUser = new UserDto
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = username
                };

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    _userService.EditProfileWithoutPassword(AppSession.LoggedInUser!.Id, updatedUser);
                }
                else
                {
                    _userService.EditProfile(AppSession.LoggedInUser!.Id, newPassword, updatedUser);
                }

                MessageBox.Show($"Your profile was updated successfully!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
