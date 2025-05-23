﻿using OnlineBankApp.Dtos;
using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class EditProfileForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;
        private readonly TransactionService _transactionService;

        public EditProfileForm(UserService userService, CardService cardService, 
            TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
            _transactionService = transactionService;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var dashboardForm = new DashboardForm(_userService, _cardService, _transactionService);
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
                string firstName = txbFirstName.Text.Trim();
                string lastName = txbLastName.Text.Trim();
                string username = txbUsername.Text.Trim();
                string newPassword = txbNewPassword.Text.Trim();

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
                    _userService.EditProfile(AppSession.LoggedInUser!.Id, updatedUser);
                }
                else
                {
                    _userService.EditProfile(AppSession.LoggedInUser!.Id, updatedUser, newPassword);
                }

                MessageBox.Show($"Your profile was updated successfully!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

                var loginForm = new LoginForm(_userService, _cardService, _transactionService);
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
