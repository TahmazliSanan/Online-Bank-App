using OnlineBankApp.Enums;

namespace OnlineBankApp.Entities
{
    public class Transaction : BaseEntity
    {
        public string SenderCardNumber { get; set; } = string.Empty;
        public string? ReceiverCardNumber { get; set; }
        public TransactionType Type { get; set; }
        public DateTime ProcessedDate { get; set; }
        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
