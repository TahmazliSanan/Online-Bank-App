using Microsoft.EntityFrameworkCore;
using OnlineBankApp.DataAccess.DataContext;
using OnlineBankApp.Dtos;
using OnlineBankApp.Entities;
using OnlineBankApp.Enums;

namespace OnlineBankApp.Services
{
    public class CardService
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }

        public CardDto GetCardByNumber(string cardNumber)
        {
            var card = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(cardNumber.ToLower())) ?? throw new Exception("Card number is not valid!");

            return new CardDto
            {
                Id = card.Id,
                OwnerFullName = $"{card.User!.FirstName} {card.User!.LastName}",
                OwnerUsername = card.User!.Username,
                Number = cardNumber,
                Balance = card.Balance
            };
        }

        public void TransferAmountBetweenTwoCards(string senderCardNumber,
            string receiverCardNumber, decimal amount)
        {
            if (senderCardNumber.ToLower().Equals(receiverCardNumber.ToLower()))
                throw new Exception("Cannot transfer to the same card!");

            var senderCard = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(senderCardNumber.ToLower())) ?? throw new Exception("Sender card number is not valid!");

            var receiverCard = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(receiverCardNumber.ToLower())) ?? throw new Exception("Receiver card number is not valid!");

            if (amount <= 0)
                throw new Exception("Amount cannot be less than or equal to zero!");

            if (senderCard.Balance < amount)
                throw new Exception("Insufficient balance!");

            senderCard.Balance -= amount;
            receiverCard.Balance += amount;

            var transaction = new Transaction
            {
                SenderCardNumber = senderCardNumber,
                ReceiverCardNumber = receiverCardNumber,
                Type = TransactionType.Transfer,
                ProcessedDate = DateTime.Now,
                UserId = AppSession.LoggedInUser!.Id
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void WithdrawAmountFromCard(string cardNumber, decimal amount)
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

            var transaction = new Transaction
            {
                SenderCardNumber = cardNumber,
                Type = TransactionType.Withdraw,
                ProcessedDate = DateTime.Now,
                UserId = AppSession.LoggedInUser!.Id
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void AddAmountToCard(string cardNumber, decimal amount)
        {
            var card = _context.Cards
                .Include(c => c.User)
                .FirstOrDefault(c => c.Number.ToLower()
                .Equals(cardNumber.ToLower())) ?? throw new Exception("Card number is not valid!");

            if (amount <= 0)
                throw new Exception("Amount cannot be less than or equal to zero!");

            card.Balance += amount;

            var transaction = new Transaction
            {
                SenderCardNumber = cardNumber,
                Type = TransactionType.Add,
                ProcessedDate = DateTime.Now,
                UserId = AppSession.LoggedInUser!.Id
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}
