using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SalesTaxRateConfiguration : IEntityTypeConfiguration<SalesTaxRate>
    {
        public void Configure(EntityTypeBuilder<SalesTaxRate> builder)
        {
            builder.ToTable("salestaxrate");

            builder.HasKey(x => x.SalesTaxRateID);

            builder.HasOne(x => x.StateProvince)
                .WithMany()
                .HasForeignKey(x => x.StateProvinceID);
        }
    }
}