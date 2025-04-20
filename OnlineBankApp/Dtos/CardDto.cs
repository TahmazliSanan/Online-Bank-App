namespace OnlineBankApp.Dtos
{
    public class CardDto
    {
        public int Id { get; set; }
        public string OwnerFullName { get; set; } = string.Empty;
        public string OwnerUsername { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }
}
