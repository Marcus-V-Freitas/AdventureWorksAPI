using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class CountryRegionConfiguration : IEntityTypeConfiguration<CountryRegion>
    {
        public void Configure(EntityTypeBuilder<CountryRegion> builder)
        {
            builder.HasKey(x => x.CountryRegionCode);
        }
    }
}