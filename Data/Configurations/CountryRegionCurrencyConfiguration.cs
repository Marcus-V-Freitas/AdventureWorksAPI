using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class CountryRegionCurrencyConfiguration : IEntityTypeConfiguration<CountryRegionCurrency>
    {
        public void Configure(EntityTypeBuilder<CountryRegionCurrency> builder)
        {
            builder.HasKey(x => x.CountryRegionCode);

            builder.HasOne(x => x.Currency)
                    .WithMany()
                    .HasForeignKey(x => x.CurrencyCode);
        }
    }
}