using OnlineBankApp.Services;

namespace OnlineBankApp.Forms
{
    public partial class AddAmountForm : Form
    {
        private readonly CardService _cardService;

        public AddAmountForm(UserService userService, CardService cardService)
        {
            InitializeComponent();
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
                    MessageBox.Show("Amount added successfully!", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
