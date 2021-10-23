using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.HasKey(x => x.AddressID);

            builder.HasOne(x => x.StateProvince)
                   .WithMany()
                   .HasForeignKey(x => x.StateProvinceID);
        }
    }
}