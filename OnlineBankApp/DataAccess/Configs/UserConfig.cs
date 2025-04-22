using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBankApp.Entities;

namespace OnlineBankApp.DataAccess.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            
            builder.Property(u => u.FirstName)
                .IsRequired();

            builder.Property(u => u.LastName)
                .IsRequired();

            builder.Property(u => u.Username)
                .IsRequired();

            builder.Property(u => u.HashedPassword)
                .IsRequired();

            builder.HasOne(u => u.Card)
               .WithOne(c => c.User)
               .HasForeignKey<Card>(c => c.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Transactions)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("users");
        }
    }
}
