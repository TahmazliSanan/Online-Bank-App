using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineBankApp.DataAccess.DataContext;
using OnlineBankApp.Forms;
using OnlineBankApp.Services;

namespace OnlineBankApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new ServiceCollection();
            var connectionString = "server=localhost;database=BankAppDb;user=root;password=23042002";

            builder.AddDbContext<AppDbContext>(options => options
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            
            builder.AddScoped<UserService>();
            builder.AddScoped<CardService>();
            builder.AddScoped<TransactionService>();
            
            var serviceProvider = builder.BuildServiceProvider();
            var userService = serviceProvider.GetRequiredService<UserService>();
            var cardService = serviceProvider.GetRequiredService<CardService>();
            var transactionService = serviceProvider.GetRequiredService<TransactionService>();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(userService, cardService, transactionService));
        }
    }
}