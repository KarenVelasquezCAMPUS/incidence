using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contact");
        builder.Property(p => p.Id_Contact).IsRequired();
        builder.Property(p => p.Id_User).IsRequired();
        builder.Property(p => p.Id_ContactType).IsRequired();
        builder.Property(p => p.Id_CategoryContact).IsRequired();
        builder.Property(p => p.Description_Contact).IsRequired().HasMaxLength(100);
    }
}