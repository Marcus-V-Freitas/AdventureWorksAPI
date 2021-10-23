using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ContactCreditcardConfiguration : IEntityTypeConfiguration<ContactCreditcard>
    {
        public void Configure(EntityTypeBuilder<ContactCreditcard> builder)
        {
            builder.ToTable("contactcreditcard");

            builder.HasKey(x => new { x.ContactID, x.CreditCardID });

            builder.HasOne(x => x.Contact)
                   .WithMany()
                   .HasForeignKey(x => x.ContactID);

            builder.HasOne(x => x.CreditCard)
                .WithMany()
                .HasForeignKey(x => x.CreditCardID);
        }
    }
}