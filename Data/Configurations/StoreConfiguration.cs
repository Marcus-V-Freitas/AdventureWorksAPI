using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("store");

            builder.HasKey(x => x.CustomerID);

            builder.HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerID);

            builder.HasOne(x => x.SalesPerson)
                .WithMany()
                .HasForeignKey(x => x.SalesPersonID);
        }
    }
}