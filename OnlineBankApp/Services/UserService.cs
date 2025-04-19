using Microsoft.EntityFrameworkCore;
using OnlineBankApp.DataAccess.DataContext;
using OnlineBankApp.Dtos;
using OnlineBankApp.Entities;

namespace OnlineBankApp.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public UserDto LoginUser(LoginDto dto)
        {
            var loggedInUser = _context.Users
                .Include(u => u.Card)
                .FirstOrDefault(u => u.Username.ToLower()
                .Equals(dto.Username.ToLower())) ?? throw new Exception("User not found!");
            
            bool isPasswordMatch = BCrypt.Net.BCrypt
                .Verify(dto.Password, loggedInUser.HashedPassword);

            if (!isPasswordMatch)
                throw new Exception("Password is not correct!");

            return new UserDto
            {
                Id = loggedInUser.Id,
                FullName = $"{loggedInUser.FirstName} {loggedInUser.LastName}",
                Username = loggedInUser.Username,
                CardNumber = loggedInUser.Card!.Number
            };
        }

        public UserDto RegisterUser(RegisterDto dto)
        {
            var registeredUser = _context.Users
                .FirstOrDefault(u => u.Username.ToLower()
                .Equals(dto.Username.ToLower()));

            if (registeredUser is not null)
                throw new Exception("User is already registered!");

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var newUser = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Username = dto.Username,
                HashedPassword = hashedPassword,
            };

            var card = new Card
            {
                Number = GenerateCardNumber(),
                Balance = 0,
                User = newUser
            };

            _context.Users.Add(newUser);
            _context.Cards.Add(card);
            _context.SaveChanges();

            return new UserDto
            {
                Id = newUser.Id,
                FullName = $"{newUser.FirstName} {newUser.LastName}",
                Username = newUser.Username,
                CardNumber = card.Number
            };
        }

        private string GenerateCardNumber()
        {
            var random = new Random();
            var cardNumber = string.Empty;

            do
            {
                cardNumber = string.Join("-", Enumerable.Range(0, 4)
                    .Select(_ => random.Next(1000, 9999).ToString()));
            } while (_context.Cards.Any(c => c.Number.Equals(cardNumber)));

            return cardNumber;
        }
    }
}
