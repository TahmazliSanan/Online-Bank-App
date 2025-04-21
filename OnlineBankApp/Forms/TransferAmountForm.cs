using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class TransferAmountForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public TransferAmountForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
        }

        private void btnTransferAmountBetweenTwoCards_Click(object sender, EventArgs e)
        {
            try
            {
                var receiverCardNumber = txbCardNumber.Text;
                var amount = txbAmount.Text;

                if (string.IsNullOrWhiteSpace(receiverCardNumber) 
                    || string.IsNullOrWhiteSpace(amount))
                {
                    MessageBox.Show("Fields cannot be empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.TryParse(amount, out decimal amountAsDecimal))
                {
                    var cardDto = _cardService.TransferAmountBetweenTwoCards(AppSession.CardNumber, receiverCardNumber, amountAsDecimal);

                    MessageBox.Show("Amount was transferred successfully! Please login again!", 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid amount format! Please try again!", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
