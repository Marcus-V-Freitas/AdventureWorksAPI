using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.HasKey(x => x.ProductID);

            builder.HasOne(x => x.ProductSubCategory)
             .WithMany()
             .HasForeignKey(x => x.ProductSubcategoryID);

            builder.HasOne(x => x.ProductModel)
                .WithMany()
                .HasForeignKey(x => x.ProductModelID);
        }
    }
}