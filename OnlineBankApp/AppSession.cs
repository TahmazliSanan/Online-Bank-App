using OnlineBankApp.Dtos;

namespace OnlineBankApp
{
    public static class AppSession
    {
        public static long UserId { get; set; }
        public static string FullName { get; set; } = string.Empty;
        public static string CardNumber { get; set; } = string.Empty;
        public static UserDto? UserDto { get; set; }
    }
}
