namespace OnlineBankApp.Entities
{
    public class Card : BaseEntity
    {
        public string Number { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
