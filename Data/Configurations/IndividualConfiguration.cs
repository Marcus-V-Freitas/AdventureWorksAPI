using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class IndividualConfiguration : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.ToTable("individual");

            builder.HasKey(x => x.CustomerID);

            builder.HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerID);

            builder.HasOne(x => x.Contact)
                .WithMany()
                .HasForeignKey(x => x.ContactID);
        }
    }
}