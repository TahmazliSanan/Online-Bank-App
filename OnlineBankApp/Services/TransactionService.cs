using Microsoft.EntityFrameworkCore;
using OnlineBankApp.DataAccess.DataContext;
using OnlineBankApp.Dtos;

namespace OnlineBankApp.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _context;

        public TransactionService(AppDbContext context)
        {
            _context = context;
        }

        public List<ReportDto> GetTransactions(long userId)
        {
            var transactions = _context.Transactions
                .Include(t => t.User)
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.ProcessedDate)
                .Select(t => new ReportDto
                {
                    Id = t.Id,
                    OwnerFullName = $"{t.User!.FirstName} {t.User!.LastName}",
                    SenderCardNumber = t.SenderCardNumber,
                    ReceiverCardNumber = t.ReceiverCardNumber,
                    TransactionType = t.Type.ToString(),
                    ProcessedDate = t.ProcessedDate,
                })
                .ToList();

            return transactions;
        }
    }
}
