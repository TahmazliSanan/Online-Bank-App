namespace OnlineBankApp.Dtos
{
    public class UserDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}" ?? string.Empty;
        public string Username { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }
}
