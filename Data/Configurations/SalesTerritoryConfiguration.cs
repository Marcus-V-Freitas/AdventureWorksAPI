using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SalesTerritoryConfiguration : IEntityTypeConfiguration<SalesTerritory>
    {
        public void Configure(EntityTypeBuilder<SalesTerritory> builder)
        {
            builder.ToTable("salesterritory");

            builder.HasKey(x => x.TerritoryID);

            builder.HasOne(x => x.CountryRegion)
                .WithMany()
                .HasForeignKey(x => x.CountryRegionCode);
        }
    }
}