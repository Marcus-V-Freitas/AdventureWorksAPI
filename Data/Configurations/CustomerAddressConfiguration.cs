using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("customeraddress");

            builder.HasKey(x => new { x.AddressID, x.CustomerID });

            builder.HasOne(x => x.AddressType)
                .WithMany()
                .HasForeignKey(x => x.AddressTypeID);

            builder.HasOne(x => x.Address)
               .WithMany()
               .HasForeignKey(x => x.AddressID);

            builder.HasOne(x => x.Customer)
               .WithMany()
               .HasForeignKey(x => x.CustomerID);
        }
    }
}