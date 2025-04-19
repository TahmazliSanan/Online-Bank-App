using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBankApp.Entities;

namespace OnlineBankApp.DataAccess.Configs
{
    public class CardConfig : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Number)
               .IsRequired()
               .HasMaxLength(19);

            builder.Property(c => c.Balance)
                   .HasColumnType("decimal(18,2)")
                   .HasDefaultValue(0);

            builder.HasOne(c => c.User)
                   .WithOne(u => u.Card)
                   .HasForeignKey<Card>(c => c.UserId);

            builder.ToTable("cards");
        }
    }
}
