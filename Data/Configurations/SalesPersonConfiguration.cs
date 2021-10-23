using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SalesPersonConfiguration : IEntityTypeConfiguration<SalesPerson>
    {
        public void Configure(EntityTypeBuilder<SalesPerson> builder)
        {
            builder.ToTable("salesperson");

            builder.HasKey(x => x.SalesPersonID);

            builder.HasOne(x => x.SalesTerritory)
                .WithMany()
                .HasForeignKey(x => x.TerritoryID);
        }
    }
}