using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class AddAmountForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public AddAmountForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
        }

        private void btnAddAmountToCard_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = txbAmount.Text;

                if (string.IsNullOrWhiteSpace(amount))
                {
                    MessageBox.Show("Field cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.TryParse(amount, out decimal amountAsDecimal))
                {
                    var cardDto = _cardService.AddAmountToCard(AppSession.LoggedInUser!.CardNumber, amountAsDecimal);

                    MessageBox.Show("Amount was added successfully!", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid amount format! Please try again!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Hide();
                var loginForm = new DashboardForm(_userService, _cardService);
                loginForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var dashboardForm = new DashboardForm(_userService, _cardService);
            dashboardForm.StartPosition = FormStartPosition.CenterScreen;
            dashboardForm.Show();
        }
    }
}
