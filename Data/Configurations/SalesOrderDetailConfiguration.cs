using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SalesOrderDetailConfiguration : IEntityTypeConfiguration<SalesOrderDetail>
    {
        public void Configure(EntityTypeBuilder<SalesOrderDetail> builder)
        {
            builder.ToTable("salesorderdetail");

            builder.HasKey(x => new { x.SalesOrderDetailID, x.SalesOrderID });

            builder.HasOne(x => x.SpecialOffer)
                .WithMany()
                .HasForeignKey(x => x.SpecialOfferID);

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductID);
        }
    }
}