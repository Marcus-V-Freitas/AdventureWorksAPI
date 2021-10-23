using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class TransactionHistoryArchiveConfiguration : IEntityTypeConfiguration<TransactionHistoryArchive>
    {
        public void Configure(EntityTypeBuilder<TransactionHistoryArchive> builder)
        {
            builder.ToTable("transactionhistoryarchive");

            builder.HasKey(x => x.TransactionID);

            builder.HasOne(x => x.TransactionHistory)
                .WithMany()
                .HasForeignKey(x => x.TransactionID);

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductID);
        }
    }
}