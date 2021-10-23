using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SalesOrderHeadersSalesReasonConfiguration : IEntityTypeConfiguration<SalesOrderHeadersSalesReason>
    {
        public void Configure(EntityTypeBuilder<SalesOrderHeadersSalesReason> builder)
        {
            builder.ToTable("salesorderheaderssalesreason");

            builder.HasKey(x => new { x.SalesReasonID, x.SalesOrderID });

            builder.HasOne(x => x.SalesReason)
                .WithMany()
                .HasForeignKey(x => x.SalesReasonID);
        }
    }
}