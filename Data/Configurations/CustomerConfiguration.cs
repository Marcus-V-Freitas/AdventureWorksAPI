using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer");

            builder.HasKey(x => x.CustomerID);

            builder.HasOne(x => x.SalesTerritory)
                   .WithMany()
                   .HasForeignKey(x => x.TerritoryID);
        }
    }
}