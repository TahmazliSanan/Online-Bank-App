using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class WithdrawAmountForm : Form
    {
        private readonly UserService _userService;
        private readonly CardService _cardService;

        public WithdrawAmountForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
            _userService = userService;
            _cardService = cardService;
        }

        private void btnWithdrawAmountFromCard_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = txbAmount.Text;

                if (string.IsNullOrWhiteSpace(amount))
                {
                    MessageBox.Show("Field cannot be empty! Please try again!", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.TryParse(amount, out decimal amountAsDecimal))
                {
                    var cardDto = _cardService.WithdrawAmountFromCard(AppSession.CardNumber, amountAsDecimal);

                    MessageBox.Show("Amount was withdrew successfully! Please login again!", 
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
