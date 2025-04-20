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
                    MessageBox.Show("Field cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (decimal.TryParse(amount, out decimal amountAsDecimal))
                {
                    var cardDto = _cardService.AddAmountToCard(AppSession.CardNumber, amountAsDecimal);

                    MessageBox.Show("Amount added successfully! Please login again", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Hide();
                var loginForm = new LoginForm(_userService, _cardService);
                loginForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
