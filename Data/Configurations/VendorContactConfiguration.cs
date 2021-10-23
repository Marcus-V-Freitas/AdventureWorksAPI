using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class VendorContactConfiguration : IEntityTypeConfiguration<VendorContact>
    {
        public void Configure(EntityTypeBuilder<VendorContact> builder)
        {
            builder.ToTable("vendorcontact");

            builder.HasKey(x => new { x.ContactID, x.VendorID });

            builder.HasOne(x => x.Vendor)
                .WithMany()
                .HasForeignKey(x => x.VendorID);

            builder.HasOne(x => x.Contact)
                .WithMany()
                .HasForeignKey(x => x.ContactID);

            builder.HasOne(x => x.ContactType)
                .WithMany()
                .HasForeignKey(x => x.ContactTypeID);
        }
    }
}