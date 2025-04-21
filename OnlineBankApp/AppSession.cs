using OnlineBankApp.Dtos;

namespace OnlineBankApp
{
    public static class AppSession
    {
        public static UserDto? LoggedInUser { get; set; }
    }
}
