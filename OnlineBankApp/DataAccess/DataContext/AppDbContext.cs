using Microsoft.EntityFrameworkCore;

namespace OnlineBankApp.DataAccess.DataContext
{
    public class AppDbContext : DbContext
    {
        static string connectionString = "server=localhost;database=BankAppDb;user=root;password=23042002";

        public AppDbContext(DbContextOptionsBuilder builder)
        {
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
