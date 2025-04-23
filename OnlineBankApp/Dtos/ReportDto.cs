namespace OnlineBankApp.Dtos
{
    public class ReportDto
    {
        public long Id { get; set; }
        public string OwnerFullName { get; set; } = string.Empty;
        public string SenderCardNumber { get; set; } = string.Empty;
        public string? ReceiverCardNumber { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public DateTime ProcessedDate { get; set; }
    }
}
