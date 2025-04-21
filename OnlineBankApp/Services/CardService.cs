using Microsoft.EntityFrameworkCore;
using OnlineBankApp.DataAccess.DataContext;
using OnlineBankApp.Dtos;

namespace OnlineBankApp.Services
{
    public class CardService
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }

        public CardDto WithdrawAmountFromCard(string cardNumber, decimal amount)
        {
            var card = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(cardNumber.ToLower())) ?? throw new Exception("Card number is not valid!");

            if (amount <= 0)
                throw new Exception("Amount cannot be less than or equal to zero!");

            if (card.Balance < amount)
                throw new Exception("Insufficient balance!");

            card.Balance -= amount;
            _context.SaveChanges();

            return new CardDto
            {
                Id = card.Id,
                OwnerFullName = $"{card.User!.FirstName} {card.User!.LastName}",
                OwnerUsername = card.User!.Username,
                Number = cardNumber,
                Balance = card.Balance,
            };
        }

        public CardDto AddAmountToCard(string cardNumber, decimal amount)
        {
            var card = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(cardNumber.ToLower())) ?? throw new Exception("Card number is not valid!");

            if (amount <= 0)
                throw new Exception("Amount cannot be less than or equal to zero!");

            card.Balance += amount;
            _context.SaveChanges();

            return new CardDto
            {
                Id = card.Id,
                OwnerFullName = $"{card.User!.FirstName} {card.User!.LastName}",
                OwnerUsername = card.User!.Username,
                Number = cardNumber,
                Balance = card.Balance,
            };
        }
    }
}
