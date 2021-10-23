using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class VendorAddressConfiguration : IEntityTypeConfiguration<VendorAddress>
    {
        public void Configure(EntityTypeBuilder<VendorAddress> builder)
        {
            builder.ToTable("vendoraddress");

            builder.HasKey(x => new { x.VendorID, x.AddressID });

            builder.HasOne(x => x.Vendor)
                .WithMany()
                .HasForeignKey(x => x.VendorID);

            builder.HasOne(x => x.Address)
                .WithMany()
                .HasForeignKey(x => x.AddressID);

            builder.HasOne(x => x.AddressType)
                .WithMany()
                .HasForeignKey(x => x.AddressTypeID);
        }
    }
}