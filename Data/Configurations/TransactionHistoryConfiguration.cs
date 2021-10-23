using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class TransactionHistoryConfiguration : IEntityTypeConfiguration<TransactionHistory>
    {
        public void Configure(EntityTypeBuilder<TransactionHistory> builder)
        {
            builder.ToTable("transactionhistory");

            builder.HasKey(x => x.TransactionID);

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductID);
        }
    }
}