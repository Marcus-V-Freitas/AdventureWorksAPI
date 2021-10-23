using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            builder.ToTable("shoppingcartitem");

            builder.HasKey(x => x.ShoppingCartItemID);

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductID);
        }
    }
}