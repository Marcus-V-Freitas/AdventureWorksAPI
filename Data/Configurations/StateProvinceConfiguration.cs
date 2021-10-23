using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class StateProvinceConfiguration : IEntityTypeConfiguration<StateProvince>
    {
        public void Configure(EntityTypeBuilder<StateProvince> builder)
        {
            builder.ToTable("stateprovince");

            builder.HasKey(x => x.StateProvinceID);

            builder.HasOne(x => x.CountryRegion)
                .WithMany()
                .HasForeignKey(x => x.CountryRegionCode);

            builder.HasOne(x => x.SalesTerritory)
                .WithMany()
                .HasForeignKey(x => x.TerritoryID);
        }
    }
}